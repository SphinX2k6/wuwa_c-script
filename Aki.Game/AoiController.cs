using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.Protocol.Debug;
using Aki.TDConfigMgr.Component;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020034D3 RID: 13523
[NullableContext(2)]
[Nullable(0)]
public class AoiController : ControllerBase
{
	// Token: 0x0601D8A8 RID: 121000 RVA: 0x0083D740 File Offset: 0x0083B940
	protected override bool OnInit()
	{
		Net.Instance.Register(ENotifyMessageId.LeaveAoiNotify, new Action<IMessage, Net.CallbackStatus>(this.LeaveAoiNotify));
		Net.Instance.Register(ENotifyMessageId.RemoveEntityAoiNotify, new Action<IMessage, Net.CallbackStatus>(this.RemoveEntityAoiNotify));
		Net.Instance.Register(ENotifyMessageId.PlayerAoiRangeNotify, new Action<IMessage, Net.CallbackStatus>(this.PlayerAoiRangeNotify));
		Net.Instance.Register(ENotifyMessageId.EntityAddNotify, new Action<IMessage, Net.CallbackStatus>(this.EntityAddNotify));
		Net.Instance.Register(ENotifyMessageId.EntityRemoveNotify, new Action<IMessage, Net.CallbackStatus>(this.EntityRemoveNotify));
		Net.Instance.Register(ENotifyMessageId.GmVoxelInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.GmVoxelInfoNotify));
		Net.Instance.Register(ENotifyMessageId.GmIsOverlapNotify, new Action<IMessage, Net.CallbackStatus>(this.VoxelBoxNotify));
		return true;
	}

	// Token: 0x0601D8A9 RID: 121001 RVA: 0x0083D814 File Offset: 0x0083BA14
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.LeaveAoiNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RemoveEntityAoiNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PlayerAoiRangeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.EntityAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.EntityRemoveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.GmVoxelInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.GmIsOverlapNotify);
		return true;
	}

	// Token: 0x0601D8AA RID: 121002 RVA: 0x0083D894 File Offset: 0x0083BA94
	private void LeaveAoiNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (long creatureDataId in ((LeaveAoiNotify)msg).EntityIds)
		{
			CreatureController.Instance.RemoveEntity(creatureDataId, "LeaveAoiNotify", ERemoveEntityType.RemoveTypeForce);
		}
	}

	// Token: 0x0601D8AB RID: 121003 RVA: 0x0083D8F4 File Offset: 0x0083BAF4
	private void RemoveEntityAoiNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (EntityRemoveInfo entityRemoveInfo in ((RemoveEntityAoiNotify)msg).RemoveInfos)
		{
			long entityId = entityRemoveInfo.EntityId;
			CreatureController.Instance.RemoveEntity(entityId, "RemoveEntityAoiNotify", entityRemoveInfo.Type);
		}
	}

	// Token: 0x0601D8AC RID: 121004 RVA: 0x0083D960 File Offset: 0x0083BB60
	private void PlayerAoiRangeNotify(IMessage msg, Net.CallbackStatus status)
	{
		PlayerAoiRangeNotify playerAoiRangeNotify = (PlayerAoiRangeNotify)msg;
		AoiModel.Instance.MinCoordinate = new FVector?(new FVector((float)playerAoiRangeNotify.MinX, (float)playerAoiRangeNotify.MinY));
		AoiModel.Instance.MaxCoordinate = new FVector?(new FVector((float)playerAoiRangeNotify.MaxX, (float)playerAoiRangeNotify.MaxY));
	}

	// Token: 0x0601D8AD RID: 121005 RVA: 0x0083D9B8 File Offset: 0x0083BBB8
	private void EntityAddNotify(IMessage msg, Net.CallbackStatus callbackStatus)
	{
		EntityAddNotify entityAddNotify = (EntityAddNotify)msg;
		AoiController.Instance.AddEntityPb(entityAddNotify.EntityPbs, entityAddNotify.IsAdd, callbackStatus);
	}

	// Token: 0x0601D8AE RID: 121006 RVA: 0x0083D9E4 File Offset: 0x0083BBE4
	[NullableContext(1)]
	private void AddEntityPb(IList<EntityPb> entities, bool add, Net.CallbackStatus callbackStatus)
	{
		int num = 0;
		if (callbackStatus.CallbackCount == 0)
		{
			callbackStatus.IsFinished = false;
		}
		else
		{
			num = (int)callbackStatus.UserData;
		}
		if (num >= entities.Count)
		{
			callbackStatus.IsFinished = true;
			return;
		}
		EntityPb entityPb = entities[num];
		callbackStatus.UserData = num + 1;
		if (entityPb == null)
		{
			callbackStatus.IsFinished = true;
			return;
		}
		long id = entityPb.Id;
		CreatureController.Instance.CheckDelayRemove(id, entityPb.ConfigType, entityPb.ConfigId);
		CreatureController.Instance.CheckPendingRemove(id, entityPb.ConfigType, entityPb.ConfigId);
		if (CreatureModel.Instance.RemoveCreaturePendingSet.Contains(id))
		{
			CreatureModel.Instance.RemoveRemoveCreaturePending(id);
			return;
		}
		if (CreatureModel.Instance.RemovePreCreature(id))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[AoiController.AddEntityPb]更新先行创建实体的信息。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			CreatureModel.Instance.GetEntity(id).Entity.GetComponent<CreatureDataComponent>().SetPbDataByProtocol(entityPb);
			return;
		}
		EntityHandle entityHandle = CreatureController.Instance.CreateEntity(entityPb, "AOI");
		if (entityHandle == null || !entityHandle.Valid)
		{
			return;
		}
		if (!GameModeModel.Instance.MapDone)
		{
			GameModeModel instance2 = GameModeModel.Instance;
			ELoadingPhase loadingPhase = instance2.LoadingPhase;
			if (instance2.PreAwakeEntityDuringLoad && loadingPhase >= ELoadingPhase.CheckVoxelStreamingEnd && loadingPhase <= ELoadingPhase.CheckStreamingStart && CreatureModel.Instance.IsEntityNeedPreAwake(entityHandle))
			{
				CreatureController.Instance.LoadEntityAsync(entityHandle, null, true);
			}
			return;
		}
		CreatureController.Instance.LoadEntityAsync(entityHandle, null, false);
	}

	// Token: 0x0601D8AF RID: 121007 RVA: 0x0083DB68 File Offset: 0x0083BD68
	private void EntityRemoveNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (EntityRemoveInfo entityRemoveInfo in ((EntityRemoveNotify)msg).RemoveInfos)
		{
			long entityId = entityRemoveInfo.EntityId;
			CreatureController.Instance.RemoveEntity(entityId, "EntityRemoveNotify", entityRemoveInfo.Type);
		}
	}

	// Token: 0x0601D8B0 RID: 121008 RVA: 0x0083DBD4 File Offset: 0x0083BDD4
	[NullableContext(1)]
	private void DrawDebugVoxel(VoxelSpan span, float cellSize, int interval, bool isOverlap = false)
	{
		double num = (double)cellSize * 0.5;
		FVectorDouble center = new FVectorDouble((double)span.X + num, (double)span.Y + num, (double)(span.Smax + span.Smin) * 0.5);
		FVectorDouble extent = new FVectorDouble(num, num, (double)(span.Smax - span.Smin) * 0.5);
		FRotator rotation = new FRotator(0f, 0f, 0f);
		FLinearColor lineColor = isOverlap ? new FLinearColor(1f, 0f, 0f, 1f) : new FLinearColor(0f, 1f, 0f, 1f);
		int num2 = 1;
		int num3 = interval / 1000;
		UKismetSystemLibrary.D_DrawDebugBox(GlobalData.World, center, extent, lineColor, rotation, (float)num3, (float)num2);
	}

	// Token: 0x0601D8B1 RID: 121009 RVA: 0x0083DCB4 File Offset: 0x0083BEB4
	public void StopDrawDebugVoxel()
	{
		if (this.BoxDurationTimer != null)
		{
			if (TimerSystem.Instance.Has(this.BoxDurationTimer))
			{
				TimerSystem.Instance.Remove(this.BoxDurationTimer);
			}
			this.BoxDurationTimer = null;
		}
		if (this.VoxelDurationTimer != null)
		{
			if (TimerSystem.Instance.Has(this.VoxelDurationTimer))
			{
				TimerSystem.Instance.Remove(this.VoxelDurationTimer);
			}
			this.VoxelDurationTimer = null;
		}
	}

	// Token: 0x0601D8B2 RID: 121010 RVA: 0x0083DD25 File Offset: 0x0083BF25
	private void VoxelBoxTimerCallback(float delta)
	{
		if (this.currentBox != null)
		{
			this.DrawDebugVoxel(this.currentBox, this.currentBoxCellSize, this.currentBoxInterval, this.currentBoxIsOverlap);
		}
	}

	// Token: 0x0601D8B3 RID: 121011 RVA: 0x0083DD50 File Offset: 0x0083BF50
	private void VoxelBoxNotify(IMessage msg, Net.CallbackStatus status)
	{
		GmIsOverlapNotify gmIsOverlapNotify = (GmIsOverlapNotify)msg;
		int num = 2000;
		this.currentBox = gmIsOverlapNotify.Box;
		this.currentBoxCellSize = gmIsOverlapNotify.CellSize;
		this.currentBoxInterval = num;
		this.currentBoxIsOverlap = gmIsOverlapNotify.IsOverlap;
		TimerHandle timerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.VoxelBoxTimerCallback), (float)num, 1f, null, null, true);
		if (timerHandle != null)
		{
			if (this.BoxDurationTimer != null && TimerSystem.Instance.Has(this.BoxDurationTimer))
			{
				TimerSystem.Instance.Remove(this.BoxDurationTimer);
			}
			this.BoxDurationTimer = timerHandle;
		}
	}

	// Token: 0x0601D8B4 RID: 121012 RVA: 0x0083DDEC File Offset: 0x0083BFEC
	private void GmVoxelTimerCallback(float delta)
	{
		if (this.currentSpans != null)
		{
			foreach (VoxelSpan span in this.currentSpans)
			{
				this.DrawDebugVoxel(span, this.currentSpansCellSize, this.currentSpansInterval, false);
			}
		}
	}

	// Token: 0x0601D8B5 RID: 121013 RVA: 0x0083DE50 File Offset: 0x0083C050
	private void GmVoxelInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		GmVoxelInfoNotify gmVoxelInfoNotify = (GmVoxelInfoNotify)msg;
		int num = 2000;
		this.currentSpans = gmVoxelInfoNotify.Spans;
		this.currentSpansCellSize = gmVoxelInfoNotify.CellSize;
		this.currentSpansInterval = num;
		TimerHandle timerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.GmVoxelTimerCallback), (float)num, 1f, null, null, true);
		if (timerHandle != null)
		{
			if (this.VoxelDurationTimer != null && TimerSystem.Instance.Has(this.VoxelDurationTimer))
			{
				TimerSystem.Instance.Remove(this.VoxelDurationTimer);
			}
			this.VoxelDurationTimer = timerHandle;
		}
	}

	// Token: 0x0601D8B6 RID: 121014 RVA: 0x0083DEE0 File Offset: 0x0083C0E0
	[NullableContext(1)]
	public void AddMonsterSizeTag(Entity entity)
	{
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		int? num;
		if (component == null)
		{
			num = null;
		}
		else
		{
			MonsterComponent monsterComponent = component.GetMonsterComponent();
			num = ((monsterComponent != null) ? new int?(monsterComponent.FightConfigId) : null);
		}
		int? num2 = num;
		BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
		if (num2 != null)
		{
			int? num3 = num2;
			int num4 = 0;
			if (!(num3.GetValueOrDefault() == num4 & num3 != null) && (component2 != null && component2.Valid))
			{
				MonsterBattleConf? config = ConfigMonsterBattleConfById.GetConfig(num2.Value, true);
				if (config == null)
				{
					return;
				}
				MonsterSizeId? config2 = ConfigMonsterSizeIdById.GetConfig(config.Value.MonsterSizeId, true);
				if (config2 == null)
				{
					return;
				}
				if (config2.Value.MonsterSizeTagLength > 0)
				{
					foreach (string tagName in config2.Value.MonsterSizeTagIter())
					{
						component2.AddTag(new int?(GameplayTagUtils.GetTagIdByName(tagName)));
					}
				}
				return;
			}
		}
	}

	// Token: 0x170028DB RID: 10459
	// (get) Token: 0x0601D8B7 RID: 121015 RVA: 0x0083E008 File Offset: 0x0083C208
	[Nullable(1)]
	public static AoiController Instance
	{
		[NullableContext(1)]
		get
		{
			return AoiController._Instance;
		}
	}

	// Token: 0x0601D8B8 RID: 121016 RVA: 0x0083E00F File Offset: 0x0083C20F
	[NullableContext(1)]
	public static AoiController GetOrCreateInstance()
	{
		if (AoiController._Instance == null)
		{
			AoiController.CreateInstance();
		}
		return AoiController._Instance;
	}

	// Token: 0x0601D8B9 RID: 121017 RVA: 0x0083E023 File Offset: 0x0083C223
	public static bool CreateInstance()
	{
		if (AoiController._Instance != null)
		{
			return true;
		}
		AoiController._Instance = new AoiController();
		return true;
	}

	// Token: 0x0601D8BA RID: 121018 RVA: 0x0083E039 File Offset: 0x0083C239
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D8BB RID: 121019 RVA: 0x0083E03B File Offset: 0x0083C23B
	public static void ResetStaticDefaultValue()
	{
		AoiController._Instance = null;
	}

	// Token: 0x0601D8BC RID: 121020 RVA: 0x0083E043 File Offset: 0x0083C243
	static AoiController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AoiController.CreateStaticDefaultValue), new Action(AoiController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E81D RID: 59421
	private TimerHandle VoxelDurationTimer;

	// Token: 0x0400E81E RID: 59422
	private TimerHandle BoxDurationTimer;

	// Token: 0x0400E81F RID: 59423
	private const int MILLIONSECOND_PER_SECOND = 1000;

	// Token: 0x0400E820 RID: 59424
	private VoxelSpan currentBox;

	// Token: 0x0400E821 RID: 59425
	private float currentBoxCellSize;

	// Token: 0x0400E822 RID: 59426
	private int currentBoxInterval;

	// Token: 0x0400E823 RID: 59427
	private bool currentBoxIsOverlap;

	// Token: 0x0400E824 RID: 59428
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IList<VoxelSpan> currentSpans;

	// Token: 0x0400E825 RID: 59429
	private float currentSpansCellSize;

	// Token: 0x0400E826 RID: 59430
	private int currentSpansInterval;

	// Token: 0x0400E827 RID: 59431
	private static AoiController _Instance;
}
