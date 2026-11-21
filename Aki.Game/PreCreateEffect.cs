using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.World.Define;
using UnrealEngine;

// Token: 0x0200026F RID: 623
[NullableContext(1)]
[Nullable(0)]
public class PreCreateEffect : IGameBudgetManagedObject, IStaticVariableResetter
{
	// Token: 0x06002673 RID: 9843 RVA: 0x000E8D77 File Offset: 0x000E6F77
	static PreCreateEffect()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PreCreateEffect.CreateStaticDefaultValue), new Action(PreCreateEffect.ResetStaticDefaultValue));
	}

	// Token: 0x170005EC RID: 1516
	// (get) Token: 0x06002674 RID: 9844 RVA: 0x000E8D96 File Offset: 0x000E6F96
	public static HashSet<string> PreCreateEffectSet
	{
		get
		{
			return PreCreateEffect._preCreateEffectSet;
		}
	}

	// Token: 0x06002675 RID: 9845 RVA: 0x000E8DA0 File Offset: 0x000E6FA0
	public void Init()
	{
		EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		EventSystem.Instance.Add<CreatureDataComponent, EntityHandle>(EEventName.CreateEntity, new Action<CreatureDataComponent, EntityHandle>(this.OnCreateEntity));
		int curLruCapacity = UKuroStaticLibrary.IsLowMemoryDevice() ? 60 : 100;
		this.CurLruCapacity = curLruCapacity;
	}

	// Token: 0x06002676 RID: 9846 RVA: 0x000E8DFC File Offset: 0x000E6FFC
	public void Clear()
	{
		EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		EventSystem.Instance.Remove(EEventName.CreateEntity, new Action<CreatureDataComponent, EntityHandle>(this.OnCreateEntity));
		EventSystem.Instance.RemoveAllTargetUseKey(this);
		this.PlayerPreCreateNumberMap.Clear();
	}

	// Token: 0x06002677 RID: 9847 RVA: 0x000E8E58 File Offset: 0x000E7058
	public static bool IsNeedPreCreateEffect()
	{
		return !GlobalData.IsPlayInEditor || ((GameModeModel.Instance.MapId > 3000 && GameModeModel.Instance.MapId < 4000) || GameModeModel.Instance.MapId == 2);
	}

	// Token: 0x06002678 RID: 9848 RVA: 0x000E8E98 File Offset: 0x000E7098
	private void OnCreateEntity(CreatureDataComponent creatureData, EntityHandle handle)
	{
		if (creatureData.GetEntityType() == EEntityType.Player)
		{
			this.ListenEntitySet.Add(handle.Id);
			EventSystem.Instance.AddWithTarget(handle.Entity, EEventName.AiHateAddOrRemove, new Action<bool, AiController>(this.AiHateAddOrRemove));
		}
		EventSystem.Instance.AddWithTargetUseHoldKey<ERemoveEntityType, EntityHandle>(this, handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
	}

	// Token: 0x06002679 RID: 9849 RVA: 0x000E8F00 File Offset: 0x000E7100
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

	// Token: 0x0600267A RID: 9850 RVA: 0x000E8FAC File Offset: 0x000E71AC
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

	// Token: 0x0600267B RID: 9851 RVA: 0x000E9008 File Offset: 0x000E7208
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

	// Token: 0x0600267C RID: 9852 RVA: 0x000E904F File Offset: 0x000E724F
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

	// Token: 0x0600267D RID: 9853 RVA: 0x000E907C File Offset: 0x000E727C
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

	// Token: 0x0600267E RID: 9854 RVA: 0x000E90F1 File Offset: 0x000E72F1
	public void SetForceLruCapacity(int? lruCapacity)
	{
		this.ForceLruCapacity = lruCapacity;
	}

	// Token: 0x0600267F RID: 9855 RVA: 0x000E90FC File Offset: 0x000E72FC
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

	// Token: 0x06002680 RID: 9856 RVA: 0x000E9144 File Offset: 0x000E7344
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

	// Token: 0x06002681 RID: 9857 RVA: 0x000E9240 File Offset: 0x000E7440
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

	// Token: 0x06002682 RID: 9858 RVA: 0x000E92BC File Offset: 0x000E74BC
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

	// Token: 0x06002683 RID: 9859 RVA: 0x000E9328 File Offset: 0x000E7528
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

	// Token: 0x06002684 RID: 9860 RVA: 0x000E93E8 File Offset: 0x000E75E8
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

	// Token: 0x06002685 RID: 9861 RVA: 0x000E9484 File Offset: 0x000E7684
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

	// Token: 0x06002686 RID: 9862 RVA: 0x000E94C2 File Offset: 0x000E76C2
	public void ScheduledTick(float deltaSeconds, int deltaFrames, float distance)
	{
		this.Tick((double)deltaSeconds);
	}

	// Token: 0x170005ED RID: 1517
	// (get) Token: 0x06002687 RID: 9863 RVA: 0x000E94CC File Offset: 0x000E76CC
	public bool HasScheduledAfterTick
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170005EE RID: 1518
	// (get) Token: 0x06002688 RID: 9864 RVA: 0x000E94CF File Offset: 0x000E76CF
	public bool HasOnEnabledChange
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170005EF RID: 1519
	// (get) Token: 0x06002689 RID: 9865 RVA: 0x000E94D2 File Offset: 0x000E76D2
	public bool HasOnWasRecentlyRenderedOnScreenChange
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0600268A RID: 9866 RVA: 0x000E94D5 File Offset: 0x000E76D5
	public GCHandle GetGCHandle()
	{
		return this.GameBudgetGCHandle;
	}

	// Token: 0x0600268B RID: 9867 RVA: 0x000E94DD File Offset: 0x000E76DD
	public static void CreateStaticDefaultValue()
	{
		PreCreateEffect.IsOpenPool = true;
		PreCreateEffect._preCreateEffectSet = new HashSet<string>();
	}

	// Token: 0x0600268C RID: 9868 RVA: 0x000E94EF File Offset: 0x000E76EF
	public static void ResetStaticDefaultValue()
	{
		PreCreateEffect.IsOpenPool = true;
		PreCreateEffect._preCreateEffectSet = null;
	}

	// Token: 0x040024E0 RID: 9440
	private const int HIT_EFFECT_COUNT = 3;

	// Token: 0x040024E1 RID: 9441
	private const int FIGHT_EFFECT_LRU_SIZE = 600;

	// Token: 0x040024E2 RID: 9442
	private const int NORMAL_EFFECT_LRU_SIZE = 100;

	// Token: 0x040024E3 RID: 9443
	private const int CHANGE_COUNT_EVERY_TICK = 3;

	// Token: 0x040024E4 RID: 9444
	private const int LOW_MEMORY_HIT_EFFECT_COUNT = 2;

	// Token: 0x040024E5 RID: 9445
	private const int LOW_MEMORY_FIGHT_EFFECT_LRU_SIZE = 300;

	// Token: 0x040024E6 RID: 9446
	private const int LOW_MEMORY_NORMAL_EFFECT_LRU_SIZE = 60;

	// Token: 0x040024E7 RID: 9447
	private const int PLAYER_CREATE_MAX = 150;

	// Token: 0x040024E8 RID: 9448
	private readonly string[] commonFightEffect = new string[]
	{
		"/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_ChangeRole.DA_Fx_Group_ChangeRole",
		"/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_ChangeRoleStart.DA_Fx_Group_ChangeRoleStart",
		"/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_ChangeRole_Play.DA_Fx_Group_ChangeRole_Play",
		"/Game/Aki/Effect/EffectAudio/RoleCommon/DA_Au_Role_Common_Char_Change.DA_Au_Role_Common_Char_Change",
		"/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_WeaponEnd.DA_Fx_Group_WeaponEnd"
	};

	// Token: 0x040024E9 RID: 9449
	private readonly FTransformDouble DefaultTransform = new FTransformDouble();

	// Token: 0x040024EA RID: 9450
	private readonly Dictionary<int, Queue<PreCreateEffectData>> PreCreateEffectMap = new Dictionary<int, Queue<PreCreateEffectData>>();

	// Token: 0x040024EB RID: 9451
	private readonly Queue<PreCreateEffectData> CurPreCreateEffect = new Queue<PreCreateEffectData>(4);

	// Token: 0x040024EC RID: 9452
	private readonly Dictionary<int, int> PlayerPreCreateNumberMap = new Dictionary<int, int>();

	// Token: 0x040024ED RID: 9453
	private readonly Dictionary<string, int> PreCreateEffectCountMap = new Dictionary<string, int>();

	// Token: 0x040024EE RID: 9454
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static HashSet<string> _preCreateEffectSet;

	// Token: 0x040024EF RID: 9455
	private readonly Stat PreCreateEffectStat = Stat.Create("PreCreateEffect", "", "");

	// Token: 0x040024F0 RID: 9456
	private uint? GameBudgetManagedTokenInternal;

	// Token: 0x040024F1 RID: 9457
	private int CurLruCapacity = 100;

	// Token: 0x040024F2 RID: 9458
	public int? ForceLruCapacity;

	// Token: 0x040024F3 RID: 9459
	private readonly HashSet<int> ListenEntitySet = new HashSet<int>();

	// Token: 0x040024F4 RID: 9460
	private readonly bool IsDebug = true;

	// Token: 0x040024F5 RID: 9461
	public static bool IsOpenPool;

	// Token: 0x040024F6 RID: 9462
	private GCHandle GameBudgetGCHandle;
}
