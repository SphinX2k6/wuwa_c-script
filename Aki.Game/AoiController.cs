using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.Protocol.Debug;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.World.Define;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02002A47 RID: 10823
[NullableContext(2)]
[Nullable(0)]
public class AoiController : ControllerBase
{
	// Token: 0x0601B5A7 RID: 112039 RVA: 0x00864C0C File Offset: 0x00862E0C
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

	// Token: 0x0601B5A8 RID: 112040 RVA: 0x00864CE0 File Offset: 0x00862EE0
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

	// Token: 0x0601B5A9 RID: 112041 RVA: 0x00864D60 File Offset: 0x00862F60
	private void LeaveAoiNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (long creatureDataId in ((LeaveAoiNotify)msg).EntityIds)
		{
			CreatureController.Instance.RemoveEntity(creatureDataId, "LeaveAoiNotify", ERemoveEntityType.RemoveTypeForce);
		}
	}

	// Token: 0x0601B5AA RID: 112042 RVA: 0x00864DC0 File Offset: 0x00862FC0
	private void RemoveEntityAoiNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (EntityRemoveInfo entityRemoveInfo in ((RemoveEntityAoiNotify)msg).RemoveInfos)
		{
			long entityId = entityRemoveInfo.EntityId;
			CreatureController.Instance.RemoveEntity(entityId, "RemoveEntityAoiNotify", entityRemoveInfo.Type);
		}
	}

	// Token: 0x0601B5AB RID: 112043 RVA: 0x00864E2C File Offset: 0x0086302C
	private void PlayerAoiRangeNotify(IMessage msg, Net.CallbackStatus status)
	{
		PlayerAoiRangeNotify playerAoiRangeNotify = (PlayerAoiRangeNotify)msg;
		AoiModel.Instance.MinCoordinate = new FVector?(new FVector((float)playerAoiRangeNotify.MinX, (float)playerAoiRangeNotify.MinY));
		AoiModel.Instance.MaxCoordinate = new FVector?(new FVector((float)playerAoiRangeNotify.MaxX, (float)playerAoiRangeNotify.MaxY));
	}

	// Token: 0x0601B5AC RID: 112044 RVA: 0x00864E84 File Offset: 0x00863084
	private void EntityAddNotify(IMessage msg, Net.CallbackStatus callbackStatus)
	{
		EntityAddNotify entityAddNotify = (EntityAddNotify)msg;
		AoiController.Instance.AddEntityPb(entityAddNotify.EntityPbs, entityAddNotify.IsAdd, callbackStatus);
	}

	// Token: 0x0601B5AD RID: 112045 RVA: 0x00864EB0 File Offset: 0x008630B0
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
		if (entityPb.ConfigType == EntityConfigType.Level)
		{
			ClientEntityInfo clientEntityInfo = CreatureModel.Instance.GetClientEntityInfo(entityPb.ConfigId);
			if (clientEntityInfo != null && clientEntityInfo.IsClientEntity && !clientEntityInfo.IsServerEntity)
			{
				clientEntityInfo.UpdateFlag(EClientEntityFlag.ServerEntity, false);
				return;
			}
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

	// Token: 0x0601B5AE RID: 112046 RVA: 0x00865070 File Offset: 0x00863270
	private void EntityRemoveNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (EntityRemoveInfo entityRemoveInfo in ((EntityRemoveNotify)msg).RemoveInfos)
		{
			long entityId = entityRemoveInfo.EntityId;
			EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
			if (entity != null && entity.Valid)
			{
				CreatureDataComponent component = entity.Entity.GetComponent<CreatureDataComponent>();
				if (component.IsClientEntity)
				{
					ClientEntityInfo clientEntityInfo = CreatureModel.Instance.GetClientEntityInfo(component.GetPbDataId());
					if (clientEntityInfo != null)
					{
						clientEntityInfo.RemoveFlag(EClientEntityFlag.ServerEntity);
						CreatureController.Instance.TryRemoveClientEntity(component.GetPbDataId(), "[ClientEntity] EntityRemoveNotify");
						continue;
					}
				}
			}
			CreatureController.Instance.RemoveEntity(entityId, "EntityRemoveNotify", entityRemoveInfo.Type);
		}
	}

	// Token: 0x0601B5AF RID: 112047 RVA: 0x00865144 File Offset: 0x00863344
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

	// Token: 0x0601B5B0 RID: 112048 RVA: 0x00865224 File Offset: 0x00863424
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

	// Token: 0x0601B5B1 RID: 112049 RVA: 0x00865295 File Offset: 0x00863495
	private void VoxelBoxTimerCallback(float delta)
	{
		if (this.currentBox != null)
		{
			this.DrawDebugVoxel(this.currentBox, this.currentBoxCellSize, this.currentBoxInterval, this.currentBoxIsOverlap);
		}
	}

	// Token: 0x0601B5B2 RID: 112050 RVA: 0x008652C0 File Offset: 0x008634C0
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

	// Token: 0x0601B5B3 RID: 112051 RVA: 0x0086535C File Offset: 0x0086355C
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

	// Token: 0x0601B5B4 RID: 112052 RVA: 0x008653C0 File Offset: 0x008635C0
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

	// Token: 0x0601B5B5 RID: 112053 RVA: 0x00865450 File Offset: 0x00863650
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

	// Token: 0x17002C73 RID: 11379
	// (get) Token: 0x0601B5B6 RID: 112054 RVA: 0x00865578 File Offset: 0x00863778
	[Nullable(1)]
	public static AoiController Instance
	{
		[NullableContext(1)]
		get
		{
			return AoiController._Instance;
		}
	}

	// Token: 0x0601B5B7 RID: 112055 RVA: 0x0086557F File Offset: 0x0086377F
	[NullableContext(1)]
	public static AoiController GetOrCreateInstance()
	{
		if (AoiController._Instance == null)
		{
			AoiController.CreateInstance();
		}
		return AoiController._Instance;
	}

	// Token: 0x0601B5B8 RID: 112056 RVA: 0x00865593 File Offset: 0x00863793
	public static bool CreateInstance()
	{
		if (AoiController._Instance != null)
		{
			return true;
		}
		AoiController._Instance = new AoiController();
		return true;
	}

	// Token: 0x0601B5B9 RID: 112057 RVA: 0x008655A9 File Offset: 0x008637A9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B5BA RID: 112058 RVA: 0x008655AB File Offset: 0x008637AB
	public static void ResetStaticDefaultValue()
	{
		AoiController._Instance = null;
	}

	// Token: 0x0601B5BB RID: 112059 RVA: 0x008655B3 File Offset: 0x008637B3
	static AoiController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AoiController.CreateStaticDefaultValue), new Action(AoiController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ECD1 RID: 60625
	private TimerHandle VoxelDurationTimer;

	// Token: 0x0400ECD2 RID: 60626
	private TimerHandle BoxDurationTimer;

	// Token: 0x0400ECD3 RID: 60627
	private const int MILLIONSECOND_PER_SECOND = 1000;

	// Token: 0x0400ECD4 RID: 60628
	private VoxelSpan currentBox;

	// Token: 0x0400ECD5 RID: 60629
	private float currentBoxCellSize;

	// Token: 0x0400ECD6 RID: 60630
	private int currentBoxInterval;

	// Token: 0x0400ECD7 RID: 60631
	private bool currentBoxIsOverlap;

	// Token: 0x0400ECD8 RID: 60632
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IList<VoxelSpan> currentSpans;

	// Token: 0x0400ECD9 RID: 60633
	private float currentSpansCellSize;

	// Token: 0x0400ECDA RID: 60634
	private int currentSpansInterval;

	// Token: 0x0400ECDB RID: 60635
	private static AoiController _Instance;
}
