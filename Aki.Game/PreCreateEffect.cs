using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.World.Define;
using UnrealEngine;

// Token: 0x0200026B RID: 619
[NullableContext(1)]
[Nullable(0)]
public class PreCreateEffect : IGameBudgetManagedObject, IStaticVariableResetter
{
	// Token: 0x060025B9 RID: 9657 RVA: 0x000E2790 File Offset: 0x000E0990
	static PreCreateEffect()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PreCreateEffect.CreateStaticDefaultValue), new Action(PreCreateEffect.ResetStaticDefaultValue));
	}

	// Token: 0x170005C5 RID: 1477
	// (get) Token: 0x060025BA RID: 9658 RVA: 0x000E27AF File Offset: 0x000E09AF
	public static HashSet<string> PreCreateEffectSet
	{
		get
		{
			return PreCreateEffect._preCreateEffectSet;
		}
	}

	// Token: 0x060025BB RID: 9659 RVA: 0x000E27B8 File Offset: 0x000E09B8
	public void Init()
	{
		EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		EventSystem.Instance.Add<CreatureDataComponent, EntityHandle>(EEventName.CreateEntity, new Action<CreatureDataComponent, EntityHandle>(this.OnCreateEntity));
		int curLruCapacity = UKuroStaticLibrary.IsLowMemoryDevice() ? 60 : 100;
		this.CurLruCapacity = curLruCapacity;
	}

	// Token: 0x060025BC RID: 9660 RVA: 0x000E2814 File Offset: 0x000E0A14
	public void Clear()
	{
		EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		EventSystem.Instance.Remove(EEventName.CreateEntity, new Action<CreatureDataComponent, EntityHandle>(this.OnCreateEntity));
		EventSystem.Instance.RemoveAllTargetUseKey(this);
		this.PlayerPreCreateNumberMap.Clear();
	}

	// Token: 0x060025BD RID: 9661 RVA: 0x000E2870 File Offset: 0x000E0A70
	public static bool IsNeedPreCreateEffect()
	{
		return !GlobalData.IsPlayInEditor || ((GameModeModel.Instance.MapId > 3000 && GameModeModel.Instance.MapId < 4000) || GameModeModel.Instance.MapId == 2);
	}

	// Token: 0x060025BE RID: 9662 RVA: 0x000E28B0 File Offset: 0x000E0AB0
	private void OnCreateEntity(CreatureDataComponent creatureData, EntityHandle handle)
	{
		if (creatureData.GetEntityType() == EEntityType.Player)
		{
			this.ListenEntitySet.Add(handle.Id);
			EventSystem.Instance.AddWithTarget(handle.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.AiHateAddOrRemove));
		}
		EventSystem.Instance.AddWithTargetUseHoldKey<ERemoveEntityType, EntityHandle>(this, handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
	}

	// Token: 0x060025BF RID: 9663 RVA: 0x000E2918 File Offset: 0x000E0B18
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		if (this.ListenEntitySet.Contains(handle.Id))
		{
			this.ListenEntitySet.Remove(handle.Id);
			EventSystem.Instance.RemoveWithTarget(handle.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.AiHateAddOrRemove));
		}
		EventSystem.Instance.RemoveWithTargetUseKey(this, handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		if (this.PreCreateEffectMap.ContainsKey(handle.Id))
		{
			this.PreCreateEffectMap.Remove(handle.Id);
		}
		this.PlayerPreCreateNumberMap.Remove(handle.Id);
	}

	// Token: 0x060025C0 RID: 9664 RVA: 0x000E29C4 File Offset: 0x000E0BC4
	public void AiHateAddOrRemove(bool addOrRemove, AiController from)
	{
		if (addOrRemove)
		{
			int id = from.CharActorComp.Entity.Id;
			Queue<PreCreateEffectData> queue;
			if (this.PreCreateEffectMap.TryGetValue(id, out queue))
			{
				while (!queue.Empty)
				{
					this.CurPreCreateEffect.Push(queue.Pop());
				}
				this.PreCreateEffectMap.Remove(id);
			}
		}
	}

	// Token: 0x060025C1 RID: 9665 RVA: 0x000E2A20 File Offset: 0x000E0C20
	private void OnBattleStateChanged(bool isInBattleState)
	{
		if (isInBattleState)
		{
			this.InitCommonEffect();
			int curLruCapacity = UKuroStaticLibrary.IsLowMemoryDevice() ? 300 : 600;
			this.CurLruCapacity = curLruCapacity;
			return;
		}
		int curLruCapacity2 = UKuroStaticLibrary.IsLowMemoryDevice() ? 60 : 100;
		this.CurLruCapacity = curLruCapacity2;
	}

	// Token: 0x060025C2 RID: 9666 RVA: 0x000E2A67 File Offset: 0x000E0C67
	public void Tick(double delta)
	{
		if (!PreCreateEffect.IsOpenPool)
		{
			return;
		}
		if (!this.CurPreCreateEffect.Empty && PreCreateEffect.IsNeedPreCreateEffect())
		{
			this.PreCreateEffectInternal();
		}
		this.UpdateLruCapacity();
	}

	// Token: 0x060025C3 RID: 9667 RVA: 0x000E2A94 File Offset: 0x000E0C94
	private void UpdateLruCapacity()
	{
		int effectLruCapacity = EffectSystem.Instance.GetEffectLruCapacity();
		int num = this.ForceLruCapacity ?? this.CurLruCapacity;
		if (effectLruCapacity == num)
		{
			return;
		}
		if (effectLruCapacity > this.CurLruCapacity)
		{
			int num2 = EffectSystem.Instance.GetEffectLruSize() - 3;
			EffectSystem.Instance.SetEffectLruCapacity((num2 > num) ? num2 : num);
			return;
		}
		EffectSystem.Instance.SetEffectLruCapacity(600);
	}

	// Token: 0x060025C4 RID: 9668 RVA: 0x000E2B09 File Offset: 0x000E0D09
	public void SetForceLruCapacity(int? lruCapacity)
	{
		this.ForceLruCapacity = lruCapacity;
	}

	// Token: 0x060025C5 RID: 9669 RVA: 0x000E2B14 File Offset: 0x000E0D14
	private void InitCommonEffect()
	{
		foreach (string path in this.commonFightEffect)
		{
			if (EffectSystem.Instance.GetEffectLruCount(path) == 0)
			{
				this.CurPreCreateEffect.Push(new PreCreateEffectData(-1, path));
			}
		}
	}

	// Token: 0x060025C6 RID: 9670 RVA: 0x000E2B5C File Offset: 0x000E0D5C
	private void AddEffect(PreCreateEffectData data)
	{
		Entity entity = EntitySystem.Instance.Get(data.EntityId);
		bool flag;
		if (entity == null)
		{
			flag = false;
		}
		else
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			EEntityType? eentityType = (component != null) ? new EEntityType?(component.GetEntityType()) : null;
			EEntityType eentityType2 = EEntityType.Player;
			flag = (eentityType.GetValueOrDefault() == eentityType2 & eentityType != null);
		}
		if (!flag)
		{
			if (!this.PreCreateEffectMap.ContainsKey(data.EntityId))
			{
				this.PreCreateEffectMap[data.EntityId] = new Queue<PreCreateEffectData>(4);
			}
			this.PreCreateEffectMap[data.EntityId].Push(data);
			this.PreCreateEffectCountMap[data.Path] = this.PreCreateEffectCountMap.GetValueOrDefault(data.Path, 0) + 1;
			return;
		}
		int valueOrDefault = this.PlayerPreCreateNumberMap.GetValueOrDefault(data.EntityId, 0);
		if (valueOrDefault >= 150)
		{
			return;
		}
		this.PlayerPreCreateNumberMap[data.EntityId] = valueOrDefault + 1;
		this.CurPreCreateEffect.Push(data);
	}

	// Token: 0x060025C7 RID: 9671 RVA: 0x000E2C58 File Offset: 0x000E0E58
	[NullableContext(2)]
	public void AddPreCreateEffect(int entityId, string effectPath)
	{
		if (string.IsNullOrEmpty(effectPath) || effectPath.Contains("/Niagara") || effectPath.Contains("/MaterialController/") || effectPath.Contains("/UIResources/") || effectPath.Contains("/Aki/Character"))
		{
			return;
		}
		PreCreateEffectData data = new PreCreateEffectData(entityId, effectPath);
		if (this.PreCreateEffectCountMap.GetValueOrDefault(effectPath, 0) == 0)
		{
			this.AddEffect(data);
		}
		if (this.IsDebug)
		{
			PreCreateEffect.PreCreateEffectSet.Add(effectPath);
		}
	}

	// Token: 0x060025C8 RID: 9672 RVA: 0x000E2CD4 File Offset: 0x000E0ED4
	public void AddPreCreateHitEffect(int entityId, string hitEffectPath)
	{
		if (string.IsNullOrEmpty(hitEffectPath))
		{
			return;
		}
		PreCreateEffectData data = new PreCreateEffectData(entityId, hitEffectPath);
		int num = (UKuroStaticLibrary.IsLowMemoryDevice() ? 2 : 3) - EffectSystem.Instance.GetEffectLruCount(hitEffectPath) - this.PreCreateEffectCountMap.GetValueOrDefault(hitEffectPath, 0);
		for (int i = 0; i < num; i++)
		{
			this.AddEffect(data);
		}
		if (this.IsDebug)
		{
			PreCreateEffect.PreCreateEffectSet.Add(hitEffectPath);
		}
	}

	// Token: 0x060025C9 RID: 9673 RVA: 0x000E2D40 File Offset: 0x000E0F40
	private void PreCreateEffectInternal()
	{
		PreCreateEffectData preCreateEffectData = this.CurPreCreateEffect.Pop();
		int valueOrDefault = this.PreCreateEffectCountMap.GetValueOrDefault(preCreateEffectData.Path, 0);
		if (valueOrDefault - 1 <= 0)
		{
			this.PreCreateEffectCountMap.Remove(preCreateEffectData.Path);
		}
		else
		{
			this.PreCreateEffectCountMap[preCreateEffectData.Path] = valueOrDefault - 1;
		}
		EffectSystem instance = EffectSystem.Instance;
		UObject gameInstance = GlobalData.GameInstance;
		FTransformDouble? ftransformDouble = new FTransformDouble?(this.DefaultTransform);
		int handle = instance.SpawnEffect(gameInstance, ftransformDouble, preCreateEffectData.Path, "PreCreateEffect", new EffectContext(new int?(preCreateEffectData.EntityId), null, false), EEffectType.Scene, null, null, null, true, false);
		EffectSystem.Instance.StopEffectById(handle, "PreCreateEffect", true, null);
		bool isDebug = this.IsDebug;
	}

	// Token: 0x060025CA RID: 9674 RVA: 0x000E2E00 File Offset: 0x000E1000
	public void RegisterTick()
	{
		if (this.GameBudgetManagedTokenInternal != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Preload;
			ELogAuthor author = ELogAuthor.YZ;
			string message = "EffectHandle RegisterTick: 重复注册Tick";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EffectHandle", base.GetType().Name);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.UnregisterTick();
		}
		if (!this.GameBudgetGCHandle.IsAllocated)
		{
			this.GameBudgetGCHandle = GCHandle.Alloc(this, GCHandleType.Normal);
		}
		TsGameBudgetGroupConfigCache tsIdleExecConfig = GameBudgetAllocatorConfigCreator.Instance.TsIdleExecConfig;
		this.GameBudgetManagedTokenInternal = new uint?(GameBudgetInterfaceController.Instance.RegisterTick(tsIdleExecConfig.GroupName, tsIdleExecConfig.SignificanceGroup, this, null, true, true, true, true));
	}

	// Token: 0x060025CB RID: 9675 RVA: 0x000E2E9C File Offset: 0x000E109C
	public void UnregisterTick()
	{
		if (this.GameBudgetManagedTokenInternal != null)
		{
			GameBudgetInterfaceController.Instance.UnregisterTick(this);
			this.GameBudgetManagedTokenInternal = null;
		}
		if (this.GameBudgetGCHandle.IsAllocated)
		{
			this.GameBudgetGCHandle.Free();
		}
	}

	// Token: 0x060025CC RID: 9676 RVA: 0x000E2EDA File Offset: 0x000E10DA
	public void ScheduledTick(float deltaSeconds, int deltaFrames, float distance)
	{
		this.Tick((double)deltaSeconds);
	}

	// Token: 0x170005C6 RID: 1478
	// (get) Token: 0x060025CD RID: 9677 RVA: 0x000E2EE4 File Offset: 0x000E10E4
	public bool HasScheduledAfterTick
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170005C7 RID: 1479
	// (get) Token: 0x060025CE RID: 9678 RVA: 0x000E2EE7 File Offset: 0x000E10E7
	public bool HasOnEnabledChange
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170005C8 RID: 1480
	// (get) Token: 0x060025CF RID: 9679 RVA: 0x000E2EEA File Offset: 0x000E10EA
	public bool HasOnWasRecentlyRenderedOnScreenChange
	{
		get
		{
			return false;
		}
	}

	// Token: 0x060025D0 RID: 9680 RVA: 0x000E2EED File Offset: 0x000E10ED
	public GCHandle GetGCHandle()
	{
		return this.GameBudgetGCHandle;
	}

	// Token: 0x060025D1 RID: 9681 RVA: 0x000E2EF5 File Offset: 0x000E10F5
	public static void CreateStaticDefaultValue()
	{
		PreCreateEffect.IsOpenPool = true;
		PreCreateEffect._preCreateEffectSet = new HashSet<string>();
	}

	// Token: 0x060025D2 RID: 9682 RVA: 0x000E2F07 File Offset: 0x000E1107
	public static void ResetStaticDefaultValue()
	{
		PreCreateEffect.IsOpenPool = true;
		PreCreateEffect._preCreateEffectSet = null;
	}

	// Token: 0x0400245F RID: 9311
	private const int HIT_EFFECT_COUNT = 3;

	// Token: 0x04002460 RID: 9312
	private const int FIGHT_EFFECT_LRU_SIZE = 600;

	// Token: 0x04002461 RID: 9313
	private const int NORMAL_EFFECT_LRU_SIZE = 100;

	// Token: 0x04002462 RID: 9314
	private const int CHANGE_COUNT_EVERY_TICK = 3;

	// Token: 0x04002463 RID: 9315
	private const int LOW_MEMORY_HIT_EFFECT_COUNT = 2;

	// Token: 0x04002464 RID: 9316
	private const int LOW_MEMORY_FIGHT_EFFECT_LRU_SIZE = 300;

	// Token: 0x04002465 RID: 9317
	private const int LOW_MEMORY_NORMAL_EFFECT_LRU_SIZE = 60;

	// Token: 0x04002466 RID: 9318
	private const int PLAYER_CREATE_MAX = 150;

	// Token: 0x04002467 RID: 9319
	private readonly string[] commonFightEffect = new string[]
	{
		"/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_ChangeRole.DA_Fx_Group_ChangeRole",
		"/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_ChangeRoleStart.DA_Fx_Group_ChangeRoleStart",
		"/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_ChangeRole_Play.DA_Fx_Group_ChangeRole_Play",
		"/Game/Aki/Effect/EffectAudio/RoleCommon/DA_Au_Role_Common_Char_Change.DA_Au_Role_Common_Char_Change",
		"/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_WeaponEnd.DA_Fx_Group_WeaponEnd"
	};

	// Token: 0x04002468 RID: 9320
	private readonly FTransformDouble DefaultTransform = new FTransformDouble();

	// Token: 0x04002469 RID: 9321
	private readonly Dictionary<int, Queue<PreCreateEffectData>> PreCreateEffectMap = new Dictionary<int, Queue<PreCreateEffectData>>();

	// Token: 0x0400246A RID: 9322
	private readonly Queue<PreCreateEffectData> CurPreCreateEffect = new Queue<PreCreateEffectData>(4);

	// Token: 0x0400246B RID: 9323
	private readonly Dictionary<int, int> PlayerPreCreateNumberMap = new Dictionary<int, int>();

	// Token: 0x0400246C RID: 9324
	private readonly Dictionary<string, int> PreCreateEffectCountMap = new Dictionary<string, int>();

	// Token: 0x0400246D RID: 9325
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static HashSet<string> _preCreateEffectSet;

	// Token: 0x0400246E RID: 9326
	private readonly Stat PreCreateEffectStat = Stat.Create("PreCreateEffect", "", "");

	// Token: 0x0400246F RID: 9327
	private uint? GameBudgetManagedTokenInternal;

	// Token: 0x04002470 RID: 9328
	private int CurLruCapacity = 100;

	// Token: 0x04002471 RID: 9329
	public int? ForceLruCapacity;

	// Token: 0x04002472 RID: 9330
	private readonly HashSet<int> ListenEntitySet = new HashSet<int>();

	// Token: 0x04002473 RID: 9331
	private readonly bool IsDebug = true;

	// Token: 0x04002474 RID: 9332
	public static bool IsOpenPool;

	// Token: 0x04002475 RID: 9333
	private GCHandle GameBudgetGCHandle;
}
