using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using KuroSimpleCombat.KscAction;
using UnrealEngine;

// Token: 0x0200032B RID: 811
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class KuroSimpleCombatController : ControllerBase
{
	// Token: 0x170006A2 RID: 1698
	// (get) Token: 0x06002DBB RID: 11707 RVA: 0x0010EA73 File Offset: 0x0010CC73
	public bool MapInit
	{
		get
		{
			return this.IsMapInit;
		}
	}

	// Token: 0x170006A3 RID: 1699
	// (get) Token: 0x06002DBC RID: 11708 RVA: 0x0010EA7B File Offset: 0x0010CC7B
	public bool WorldInit
	{
		get
		{
			return this.IsWorldInit;
		}
	}

	// Token: 0x06002DBD RID: 11709 RVA: 0x0010EA83 File Offset: 0x0010CC83
	public void RegisterPendingAdd(long creatureId, KscActionEntityAdd action)
	{
		this.PendingAdds[creatureId] = action;
	}

	// Token: 0x06002DBE RID: 11710 RVA: 0x0010EA94 File Offset: 0x0010CC94
	public void UnregisterPendingAdd(long creatureId, KscActionEntityAdd action)
	{
		KscActionEntityAdd kscActionEntityAdd;
		if (this.PendingAdds.TryGetValue(creatureId, out kscActionEntityAdd) && kscActionEntityAdd == action)
		{
			this.PendingAdds.Remove(creatureId);
		}
	}

	// Token: 0x06002DBF RID: 11711 RVA: 0x0010EAC4 File Offset: 0x0010CCC4
	private bool CancelPendingAddIfAny(long creatureId)
	{
		KscActionEntityAdd kscActionEntityAdd;
		if (!this.PendingAdds.TryGetValue(creatureId, out kscActionEntityAdd))
		{
			return false;
		}
		this.PendingAdds.Remove(creatureId);
		kscActionEntityAdd.Task.Cancel();
		return true;
	}

	// Token: 0x06002DC0 RID: 11712 RVA: 0x0010EAFC File Offset: 0x0010CCFC
	private void CancelPendingActionsForEntity(long creatureId)
	{
		KscSubModelBase curSubModel = this.CurSubModel;
		if (curSubModel == null)
		{
			return;
		}
		UiAsyncTaskManager entityProcessMgr = curSubModel.EntityProcessMgr;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
		defaultInterpolatedStringHandler.AppendLiteral("KscAction_[");
		defaultInterpolatedStringHandler.AppendFormatted<long>(creatureId);
		defaultInterpolatedStringHandler.AppendLiteral("]");
		entityProcessMgr.CancelPendingByName(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x170006A4 RID: 1700
	// (get) Token: 0x06002DC1 RID: 11713 RVA: 0x0010EB4F File Offset: 0x0010CD4F
	[Nullable(2)]
	public KscSubModelBase CurSubModel
	{
		[NullableContext(2)]
		get
		{
			KscSubControllerBase curSubController = this.CurSubController;
			if (curSubController == null)
			{
				return null;
			}
			return curSubController.Model;
		}
	}

	// Token: 0x06002DC2 RID: 11714 RVA: 0x0010EB64 File Offset: 0x0010CD64
	[NullableContext(2)]
	public KscSubControllerBase GetSubController(EKscGameplayType kscGameplayType)
	{
		KscSubControllerBase result;
		if (!this.SubControllerMap.TryGetValue(kscGameplayType, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06002DC3 RID: 11715 RVA: 0x0010EB84 File Offset: 0x0010CD84
	[NullableContext(2)]
	public KscSubModelBase GetSubModel(EKscGameplayType kscGameplayType)
	{
		KscSubControllerBase subController = this.GetSubController(kscGameplayType);
		if (subController == null)
		{
			return null;
		}
		return subController.Model;
	}

	// Token: 0x06002DC4 RID: 11716 RVA: 0x0010EB98 File Offset: 0x0010CD98
	protected override bool OnInit()
	{
		base.PauseTick();
		foreach (KeyValuePair<EKscGameplayType, KscSubControllerBase> keyValuePair in this.SubControllerMap)
		{
			keyValuePair.Value.Init(keyValuePair.Key);
		}
		EventSystem.Instance.Add(EEventName.OnSetGameModeDataDone, new Action(this.OnGameModeDataChange));
		EventSystem.Instance.Add(EEventName.AfterLoadMap, new Action(this.OnAfterLoadMap));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnWorldReset));
		Net.Instance.Register(ENotifyMessageId.SimpleCombatEntityBuffUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.SimpleCombatEntityBuffUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.SimpleCombatEntityBuffLayerCountNotify, new Action<IMessage, Net.CallbackStatus>(this.SimpleCombatEntityBuffLayerCountNotify));
		Net.Instance.Register(ENotifyMessageId.SimpleCombatEntitySubTypeChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.SimpleCombatEntitySubTypeChangeNotify));
		Net.Instance.Register(ENotifyMessageId.SimpleCombatEntityAttributeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.SimpleCombatEntityAttributeUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.SimpleCombatBeginNotify, new Action<IMessage, Net.CallbackStatus>(this.SimpleCombatBeginNotify));
		Net.Instance.Register(ENotifyMessageId.SimpleCombatEndNotify, new Action<IMessage, Net.CallbackStatus>(this.SimpleCombatEndNotify));
		return true;
	}

	// Token: 0x06002DC5 RID: 11717 RVA: 0x0010ED18 File Offset: 0x0010CF18
	protected override bool OnClear()
	{
		foreach (KscSubControllerBase kscSubControllerBase in this.SubControllerMap.Values)
		{
			kscSubControllerBase.Clear();
		}
		EventSystem.Instance.Remove(EEventName.OnSetGameModeDataDone, new Action(this.OnGameModeDataChange));
		EventSystem.Instance.Remove(EEventName.AfterLoadMap, new Action(this.OnAfterLoadMap));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnWorldReset));
		Net.Instance.UnRegister(ENotifyMessageId.SimpleCombatEntityBuffUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SimpleCombatEntityBuffLayerCountNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SimpleCombatEntityAttributeUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SimpleCombatBeginNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SimpleCombatEndNotify);
		this.StopKscHeadStateManager();
		this.ResetObservedLifecycleStage();
		return true;
	}

	// Token: 0x06002DC6 RID: 11718 RVA: 0x0010EE3C File Offset: 0x0010D03C
	protected override bool OnLeaveLevel()
	{
		this.StopKscHeadStateManager();
		return true;
	}

	// Token: 0x06002DC7 RID: 11719 RVA: 0x0010EE48 File Offset: 0x0010D048
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	protected override ValueTuple<string, CustomPromise<bool>>? OnPreload()
	{
		this.ObserveLifecycleStage(EKscObservedLifecycleStage.Preload, "OnPreload");
		KscSubControllerBase curSubController = this.CurSubController;
		if (curSubController == null)
		{
			return null;
		}
		return curSubController.OnPreload();
	}

	// Token: 0x06002DC8 RID: 11720 RVA: 0x0010EE7A File Offset: 0x0010D07A
	private void ObserveLifecycleStage(EKscObservedLifecycleStage stage, string source)
	{
		this.ObservedLifecycleStages.Add(stage);
	}

	// Token: 0x06002DC9 RID: 11721 RVA: 0x0010EE88 File Offset: 0x0010D088
	private void ResetObservedLifecycleStage()
	{
		this.ObservedLifecycleStages.Clear();
	}

	// Token: 0x06002DCA RID: 11722 RVA: 0x0010EE95 File Offset: 0x0010D095
	private bool HasObservedLifecycleStage(EKscObservedLifecycleStage stage)
	{
		return this.ObservedLifecycleStages.Contains(stage);
	}

	// Token: 0x06002DCB RID: 11723 RVA: 0x0010EEA4 File Offset: 0x0010D0A4
	[NullableContext(2)]
	private KscSubControllerBase FindSubControllerByInstSubType(int instSubType)
	{
		foreach (KscSubControllerBase kscSubControllerBase in this.SubControllerMap.Values)
		{
			if (kscSubControllerBase.IsTargetMap(instSubType))
			{
				return kscSubControllerBase;
			}
		}
		return null;
	}

	// Token: 0x06002DCC RID: 11724 RVA: 0x0010EF08 File Offset: 0x0010D108
	[NullableContext(2)]
	private KscSubControllerBase ResolveSubControllerForLifecycle()
	{
		GameModeModel instance = GameModeModel.Instance;
		InstanceDungeon? instanceDungeon;
		int? num = (instance != null) ? ((instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().InstSubType) : null) : null;
		KscSubControllerBase kscSubControllerBase = (GameModeController.Instance.IsInInstance() && num != null) ? this.FindSubControllerByInstSubType(num.Value) : null;
		if (kscSubControllerBase != null)
		{
			this.CurSubController = kscSubControllerBase;
			return kscSubControllerBase;
		}
		return this.CurSubController;
	}

	// Token: 0x06002DCD RID: 11725 RVA: 0x0010EF94 File Offset: 0x0010D194
	private bool TryInitMap(string source)
	{
		KscSubControllerBase kscSubControllerBase = this.ResolveSubControllerForLifecycle();
		if (kscSubControllerBase == null)
		{
			return false;
		}
		kscSubControllerBase.InitMap();
		this.IsMapInit = true;
		return true;
	}

	// Token: 0x06002DCE RID: 11726 RVA: 0x0010EFBB File Offset: 0x0010D1BB
	private bool TryMapLoaded(string source)
	{
		if (this.CurSubController == null)
		{
			return false;
		}
		this.CurSubController.MapLoaded();
		this.IsWorldInit = true;
		return true;
	}

	// Token: 0x06002DCF RID: 11727 RVA: 0x0010EFDA File Offset: 0x0010D1DA
	private bool TryWorldDone(string source)
	{
		if (this.CurSubController == null)
		{
			return false;
		}
		this.CurSubController.WorldDone();
		base.ResumeTick();
		return true;
	}

	// Token: 0x06002DD0 RID: 11728 RVA: 0x0010EFF8 File Offset: 0x0010D1F8
	private UniTask CatchUpObservedLifecycleAfterOpenAsync(string source, [Nullable(2)] KscSubControllerBase expectedSubController = null)
	{
		KuroSimpleCombatController.<CatchUpObservedLifecycleAfterOpenAsync>d__31 <CatchUpObservedLifecycleAfterOpenAsync>d__;
		<CatchUpObservedLifecycleAfterOpenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CatchUpObservedLifecycleAfterOpenAsync>d__.<>4__this = this;
		<CatchUpObservedLifecycleAfterOpenAsync>d__.source = source;
		<CatchUpObservedLifecycleAfterOpenAsync>d__.expectedSubController = expectedSubController;
		<CatchUpObservedLifecycleAfterOpenAsync>d__.<>1__state = -1;
		<CatchUpObservedLifecycleAfterOpenAsync>d__.<>t__builder.Start<KuroSimpleCombatController.<CatchUpObservedLifecycleAfterOpenAsync>d__31>(ref <CatchUpObservedLifecycleAfterOpenAsync>d__);
		return <CatchUpObservedLifecycleAfterOpenAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06002DD1 RID: 11729 RVA: 0x0010F04B File Offset: 0x0010D24B
	private void TryCatchUpObservedLifecycleAfterOpen(string source)
	{
		if (this.ObservedLifecycleStages.Count == 0)
		{
			return;
		}
		this.CatchUpObservedLifecycleAfterOpenAsync(source, this.CurSubController).Forget();
	}

	// Token: 0x06002DD2 RID: 11730 RVA: 0x0010F06D File Offset: 0x0010D26D
	private void OnGameModeDataChange()
	{
		this.ObserveLifecycleStage(EKscObservedLifecycleStage.InitMap, "OnSetGameModeDataDone");
		this.TryInitMap("OnSetGameModeDataDone");
	}

	// Token: 0x06002DD3 RID: 11731 RVA: 0x0010F087 File Offset: 0x0010D287
	private void OnAfterLoadMap()
	{
		this.ObserveLifecycleStage(EKscObservedLifecycleStage.MapLoad, "AfterLoadMap");
		this.TryMapLoaded("AfterLoadMap");
	}

	// Token: 0x06002DD4 RID: 11732 RVA: 0x0010F0A1 File Offset: 0x0010D2A1
	private void OnWorldDone()
	{
		this.ObserveLifecycleStage(EKscObservedLifecycleStage.WorldDone, "WorldDoneAndCloseLoading");
		this.TryWorldDone("WorldDoneAndCloseLoading");
	}

	// Token: 0x06002DD5 RID: 11733 RVA: 0x0010F0BC File Offset: 0x0010D2BC
	private void OpenWorldByGameplayType(EKscGameplayType gamePlayType)
	{
		if (this.CurSubController != null)
		{
			return;
		}
		KscSubControllerBase curSubController;
		if (!this.SubControllerMap.TryGetValue(gamePlayType, out curSubController))
		{
			return;
		}
		KscLog.EModule flag = KscLog.EModule.Common;
		ELogAuthor author = ELogAuthor.TZQ;
		UObject obj = null;
		string log = "打开KSCWorld";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("gamePlayType", gamePlayType);
		KscLog.Info(flag, author, obj, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.CurSubController = curSubController;
		this.TryCatchUpObservedLifecycleAfterOpen("OpenWorldByGameplayType");
	}

	// Token: 0x06002DD6 RID: 11734 RVA: 0x0010F11C File Offset: 0x0010D31C
	[NullableContext(2)]
	private void CloseCurrentWorld(KscSubControllerBase expectedSubController = null)
	{
		if (this.CurSubController == null)
		{
			KscLog.Error(KscLog.EModule.Common, ELogAuthor.TZQ, null, "当前不在KSC玩法中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (expectedSubController != null && this.CurSubController != expectedSubController)
		{
			KscLog.Error(KscLog.EModule.Common, ELogAuthor.TZQ, null, "当前不是目标KSC玩法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		KscLog.Info(KscLog.EModule.Common, ELogAuthor.TZQ, null, "关闭KSCWorld", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.OnWorldReset();
	}

	// Token: 0x06002DD7 RID: 11735 RVA: 0x0010F18C File Offset: 0x0010D38C
	private void OnWorldReset()
	{
		if (this.IsWorldInit)
		{
			this.IsWorldInit = false;
			KscSubModelBase curSubModel = this.CurSubModel;
			if (curSubModel != null)
			{
				curSubModel.EntityProcessMgr.LogInfo("CancelAllTask Before");
			}
			KscSubModelBase curSubModel2 = this.CurSubModel;
			if (curSubModel2 != null)
			{
				curSubModel2.EntityProcessMgr.CancelAllTask();
			}
			this.PendingAdds.Clear();
			KscSubControllerBase curSubController = this.CurSubController;
			if (curSubController != null)
			{
				curSubController.WorldReset();
			}
		}
		if (this.IsMapInit)
		{
			this.IsMapInit = false;
			KscSubControllerBase curSubController2 = this.CurSubController;
			if (curSubController2 != null)
			{
				curSubController2.ClearMap();
			}
		}
		this.ResetObservedLifecycleStage();
		this.EntityPositions.Empty(true);
		this.CurSubController = null;
		base.PauseTick();
	}

	// Token: 0x06002DD8 RID: 11736 RVA: 0x0010F234 File Offset: 0x0010D434
	protected override void OnTick(float delta)
	{
		UKSC_World kscWorld = KscEnv.Instance.KscWorld;
		if (kscWorld == null)
		{
			return;
		}
		KscSubControllerBase curSubController = this.CurSubController;
		if (curSubController != null)
		{
			curSubController.Tick(delta);
		}
		kscWorld.GetEntityPositionsEx(ref this.EntityPositions);
		TowerDefensePlayerController.SyncMainLocations(delta);
	}

	// Token: 0x06002DD9 RID: 11737 RVA: 0x0010F274 File Offset: 0x0010D474
	[NullableContext(2)]
	public string GetSkillPathDt(int id)
	{
		ValueTuple<FKSCSkillTableRow, string> valueTuple;
		if (!this.CurSubModel.SkillDataDt.TryGetValue(id, out valueTuple))
		{
			return null;
		}
		return valueTuple.Item2;
	}

	// Token: 0x06002DDA RID: 11738 RVA: 0x0010F2A0 File Offset: 0x0010D4A0
	[NullableContext(2)]
	public FKSCSkillTableRow GetSkillRowDt(int id)
	{
		ValueTuple<FKSCSkillTableRow, string> valueTuple;
		if (!this.CurSubModel.SkillDataDt.TryGetValue(id, out valueTuple))
		{
			return null;
		}
		return valueTuple.Item1;
	}

	// Token: 0x06002DDB RID: 11739 RVA: 0x0010F2CC File Offset: 0x0010D4CC
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public ValueTuple<FKSCSkillTableRow, string>? GetSkillDataDt(int id)
	{
		ValueTuple<FKSCSkillTableRow, string> value;
		if (!this.CurSubModel.SkillDataDt.TryGetValue(id, out value))
		{
			return null;
		}
		return new ValueTuple<FKSCSkillTableRow, string>?(value);
	}

	// Token: 0x06002DDC RID: 11740 RVA: 0x0010F2FE File Offset: 0x0010D4FE
	[return: Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	public Dictionary<int, ValueTuple<FKSCSkillTableRow, string>> GetAllSkillDataDt()
	{
		return this.CurSubModel.SkillDataDt;
	}

	// Token: 0x06002DDD RID: 11741 RVA: 0x0010F30C File Offset: 0x0010D50C
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public UniTask<Dictionary<int, UKSC_DA_Buff>> LoadBuffAssets(int[] buffKeys)
	{
		KuroSimpleCombatController.<LoadBuffAssets>d__45 <LoadBuffAssets>d__;
		<LoadBuffAssets>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<int, UKSC_DA_Buff>>.Create();
		<LoadBuffAssets>d__.buffKeys = buffKeys;
		<LoadBuffAssets>d__.<>1__state = -1;
		<LoadBuffAssets>d__.<>t__builder.Start<KuroSimpleCombatController.<LoadBuffAssets>d__45>(ref <LoadBuffAssets>d__);
		return <LoadBuffAssets>d__.<>t__builder.Task;
	}

	// Token: 0x06002DDE RID: 11742 RVA: 0x0010F350 File Offset: 0x0010D550
	[return: Nullable(2)]
	public AKSC_Entity AddEntityImpl(UKSC_DA_Entity asset, IKscEntityParam params_)
	{
		UKSC_World kscWorld = KscEnv.Instance.KscWorld;
		AKSC_Entity aksc_Entity;
		if (kscWorld == null)
		{
			aksc_Entity = null;
		}
		else
		{
			FTransformDouble transform = params_.Transform;
			aksc_Entity = kscWorld.D_AddDaEntity(asset, transform, params_.IsPreview.GetValueOrDefault(), (int)params_.CreatureId);
		}
		AKSC_Entity aksc_Entity2 = aksc_Entity;
		if (aksc_Entity2 != null)
		{
			if (params_.Faction != null)
			{
				aksc_Entity2.SetFaction(params_.Faction.Value);
			}
			if (asset is UKSC_DA_Entity_Enemy && params_.Spline != null)
			{
				UKSC_Move_Spline uksc_Move_Spline = aksc_Entity2.GetMoveComponent() as UKSC_Move_Spline;
				if (uksc_Move_Spline != null)
				{
					uksc_Move_Spline.SetSpline(params_.Spline);
				}
			}
			if (asset is UKSC_DA_Entity_Tower && params_.RenderActor != null)
			{
				aksc_Entity2.SetRenderActor(params_.RenderActor);
			}
			KscEntityHandle value = new KscEntityHandle(aksc_Entity2, params_.CreatureId);
			this.CurSubModel.KscEntities[aksc_Entity2.EntityId_] = value;
			this.CurSubController.SetAttrs(aksc_Entity2, params_.PropertyId, params_.AttributeMap);
			this.CurSubModel.SetLogicProxy(params_.CreatureId, aksc_Entity2.EntityId_);
			return aksc_Entity2;
		}
		KscLog.EModule flag = KscLog.EModule.Common;
		ELogAuthor author = ELogAuthor.PZ;
		UObject kscWorld2 = KscEnv.Instance.KscWorld;
		string log = "加入战斗实体失败";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("asset", asset);
		KscLog.Warn(flag, author, kscWorld2, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x06002DDF RID: 11743 RVA: 0x0010F490 File Offset: 0x0010D690
	public void AsyncAddEntity(IKscEntityParam params_)
	{
		KscActionEntityAdd kscActionEntityAdd = new KscActionEntityAdd(params_);
		KscSubModelBase curSubModel = this.CurSubModel;
		if (curSubModel == null)
		{
			return;
		}
		curSubModel.EntityProcessMgr.RunTask(kscActionEntityAdd.Task);
	}

	// Token: 0x06002DE0 RID: 11744 RVA: 0x0010F4C0 File Offset: 0x0010D6C0
	public void RemoveEntityImpl(int kscEntityId, FName removeReason)
	{
		KscEntityHandle kscEntityHandle;
		if (!this.CurSubModel.KscEntities.TryGetValue(kscEntityId, out kscEntityHandle) || !kscEntityHandle.Valid)
		{
			KscLog.EModule flag = KscLog.EModule.Common;
			ELogAuthor author = ELogAuthor.PZ;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "移除战斗实体失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", kscEntityId);
			KscLog.Warn(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (this.CurSubModel.KscPlayerEntity == kscEntityHandle.KscEntity)
		{
			this.CurSubModel.SetKscPlayerEntity(null, 0L);
		}
		long creatureDataId = kscEntityHandle.CreatureDataId;
		UKSC_World kscWorld2 = KscEnv.Instance.KscWorld;
		if (kscWorld2 != null)
		{
			kscWorld2.RemoveEntityReason(kscEntityHandle.KscEntity, removeReason);
		}
		this.CurSubModel.KscEntities.Remove(kscEntityId);
		this.CurSubModel.RemoveLogicProxy(creatureDataId);
	}

	// Token: 0x06002DE1 RID: 11745 RVA: 0x0010F580 File Offset: 0x0010D780
	public void RemoveEntity(long creatureId, FName removeReason)
	{
		if (this.CancelPendingAddIfAny(creatureId))
		{
			this.CancelPendingActionsForEntity(creatureId);
			return;
		}
		this.CancelPendingActionsForEntity(creatureId);
		KscActionEntityRemove kscActionEntityRemove = new KscActionEntityRemove(creatureId, new FName?(removeReason), EKscEntityRemoveReasonType.None);
		KscSubModelBase curSubModel = this.CurSubModel;
		if (curSubModel == null)
		{
			return;
		}
		curSubModel.EntityProcessMgr.RunTask(kscActionEntityRemove.Task);
	}

	// Token: 0x06002DE2 RID: 11746 RVA: 0x0010F5D0 File Offset: 0x0010D7D0
	public void RemoveEntityImplByReasonType(int kscEntityId, EKscEntityRemoveReasonType removeReasonType)
	{
		KscEntityHandle kscEntityHandle;
		if (!this.CurSubModel.KscEntities.TryGetValue(kscEntityId, out kscEntityHandle) || !kscEntityHandle.Valid)
		{
			KscLog.EModule flag = KscLog.EModule.Common;
			ELogAuthor author = ELogAuthor.PZ;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "移除战斗实体失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", kscEntityId);
			KscLog.Warn(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		FName reason = KscData.kscEntityRemoveReasonList[(int)removeReasonType];
		if (this.CurSubModel.KscPlayerEntity == kscEntityHandle.KscEntity)
		{
			this.CurSubModel.SetKscPlayerEntity(null, 0L);
		}
		long creatureDataId = kscEntityHandle.CreatureDataId;
		if (removeReasonType == EKscEntityRemoveReasonType.Dead)
		{
			if (kscEntityHandle.KscEntity != null)
			{
				kscEntityHandle.KscEntity.Dead(0);
			}
		}
		else
		{
			UKSC_World kscWorld2 = KscEnv.Instance.KscWorld;
			if (kscWorld2 != null)
			{
				kscWorld2.RemoveEntityReason(kscEntityHandle.KscEntity, reason);
			}
		}
		this.CurSubModel.KscEntities.Remove(kscEntityId);
		this.CurSubModel.RemoveLogicProxy(creatureDataId);
	}

	// Token: 0x06002DE3 RID: 11747 RVA: 0x0010F6B4 File Offset: 0x0010D8B4
	public void RemoveEntityByReasonType(long creatureId, EKscEntityRemoveReasonType removeReasonType)
	{
		if (this.CancelPendingAddIfAny(creatureId))
		{
			this.CancelPendingActionsForEntity(creatureId);
			return;
		}
		this.CancelPendingActionsForEntity(creatureId);
		KscActionEntityRemove kscActionEntityRemove = new KscActionEntityRemove(creatureId, null, removeReasonType);
		KscSubModelBase curSubModel = this.CurSubModel;
		if (curSubModel == null)
		{
			return;
		}
		curSubModel.EntityProcessMgr.RunTask(kscActionEntityRemove.Task);
	}

	// Token: 0x06002DE4 RID: 11748 RVA: 0x0010F708 File Offset: 0x0010D908
	public unsafe void AddEntityDt(long creatureId, int key, int? propertyId, FTransformDouble transform, Action<AKSC_Entity> callback)
	{
		KscLog.EModule flag = KscLog.EModule.Common;
		ELogAuthor author = ELogAuthor.PZ;
		UObject kscWorld = KscEnv.Instance.KscWorld;
		string log = "加入Dt战斗实体加载中";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("creatureId", creatureId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dt key", key);
		KscLog.Info(flag, author, kscWorld, log, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		ValueTuple<FKSCEntityTableRow, string> valueTuple;
		if (!this.CurSubModel.EntityDataDt.TryGetValue(key, out valueTuple))
		{
			return;
		}
		string assetPath = valueTuple.Item2;
		if (string.IsNullOrEmpty(assetPath))
		{
			return;
		}
		LoadAssetParams<UKSC_DA_Entity> loadAssetParams = new LoadAssetParams<UKSC_DA_Entity>();
		loadAssetParams.Context = KscEnv.Instance.KscWorld;
		loadAssetParams.Id = key;
		loadAssetParams.Path = assetPath;
		UKSC_World kscWorld2 = KscEnv.Instance.KscWorld;
		loadAssetParams.NativeContainer = ((kscWorld2 != null) ? kscWorld2.LoadedEntityDa : null);
		loadAssetParams.Callback = delegate(UKSC_DA_Entity resultAsset)
		{
			if (!this.IsWorldInit)
			{
				KscLog.Warn(KscLog.EModule.Load, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "战斗实体加载失败，KSC世界已清理", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (resultAsset == null || !resultAsset.IsValid())
			{
				KscLog.EModule flag2 = KscLog.EModule.Load;
				ELogAuthor author2 = ELogAuthor.PZ;
				UObject kscWorld3 = KscEnv.Instance.KscWorld;
				string log2 = "从Dt加入战斗实体时加载失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Path", assetPath);
				KscLog.Warn(flag2, author2, kscWorld3, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			KscLog.EModule flag3 = KscLog.EModule.Load;
			ELogAuthor author3 = ELogAuthor.PZ;
			UObject kscWorld4 = KscEnv.Instance.KscWorld;
			string log3 = "从Dt加入战斗实体时加载成功";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Path", assetPath);
			KscLog.Info(flag3, author3, kscWorld4, log3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			AKSC_Entity aksc_Entity = this.AddEntityImpl(resultAsset, new KscEntityParam
			{
				CreatureId = creatureId,
				PropertyId = propertyId.GetValueOrDefault(),
				Transform = transform
			});
			if (aksc_Entity != null && callback != null)
			{
				callback(aksc_Entity);
			}
		};
		loadAssetParams.FailCallback = null;
		loadAssetParams.KscWorldHandle = KscEnv.Instance.KscWorldHandle;
		KscUtil.AsyncLoadKscAsset<UKSC_DA_Entity>(loadAssetParams);
	}

	// Token: 0x06002DE5 RID: 11749 RVA: 0x0010F848 File Offset: 0x0010DA48
	public int GetLogicProxy(int creatureId)
	{
		return this.CurSubModel.GetLogicProxy((long)creatureId).GetValueOrDefault();
	}

	// Token: 0x06002DE6 RID: 11750 RVA: 0x0010F86C File Offset: 0x0010DA6C
	private unsafe void ReqSimpleCombatEntityDie(Dictionary<long, SimpleCombatEntityDieContext> requestInfos)
	{
		SimpleCombatEntityDieRequest simpleCombatEntityDieRequest = SimpleCombatEntityDieRequest.Create();
		simpleCombatEntityDieRequest.EntityDieCtxMap.Add(requestInfos);
		Net.Instance.Call(ERequestMessageId.SimpleCombatEntityDieRequest, simpleCombatEntityDieRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SimpleCombatEntityDieResponse simpleCombatEntityDieResponse = (SimpleCombatEntityDieResponse)msg;
			if (simpleCombatEntityDieResponse == null || simpleCombatEntityDieResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				KscLog.EModule flag = KscLog.EModule.Common;
				ELogAuthor author = ELogAuthor.PZ;
				UObject kscWorld = KscEnv.Instance.KscWorld;
				string log = "请求实体死亡异常";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("requestInfos", requestInfos);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", (simpleCombatEntityDieResponse != null) ? new Aki.Protocol.ErrorCode?(simpleCombatEntityDieResponse.ErrorCode) : null);
				KscLog.Warn(flag, author, kscWorld, log, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}, 0);
	}

	// Token: 0x06002DE7 RID: 11751 RVA: 0x0010F8BC File Offset: 0x0010DABC
	public void BatchRemove(TArray<FKSC_RemoveContext> contexts)
	{
		int num = contexts.Num();
		if (num == 0)
		{
			return;
		}
		Dictionary<long, SimpleCombatEntityDieContext> dictionary = new Dictionary<long, SimpleCombatEntityDieContext>();
		for (int i = 0; i < num; i++)
		{
			this.RemoveContext.InitFromRemoveContext(contexts.Get(i), this.CurSubModel.KscEntities);
			this.TryReqRemove(this.RemoveContext, dictionary, true);
		}
		if (dictionary.Count > 0)
		{
			this.ReqSimpleCombatEntityDie(dictionary);
		}
	}

	// Token: 0x06002DE8 RID: 11752 RVA: 0x0010F924 File Offset: 0x0010DB24
	public void LandFireSpawn(TArray<FKSC_LandFireContext> contexts)
	{
		int num = contexts.Num();
		if (num == 0)
		{
			return;
		}
		Dictionary<long, SimpleCombatEntityDieContext> dictionary = new Dictionary<long, SimpleCombatEntityDieContext>();
		for (int i = 0; i < num; i++)
		{
			this.RemoveContext.InitFromLandFireContext(contexts.Get(i), this.CurSubModel.KscEntities);
			this.TryReqRemove(this.RemoveContext, dictionary, false);
		}
		if (dictionary.Count > 0)
		{
			this.ReqSimpleCombatEntityDie(dictionary);
		}
	}

	// Token: 0x06002DE9 RID: 11753 RVA: 0x0010F98C File Offset: 0x0010DB8C
	private void TryReqRemove(KscRemoveContext context, Dictionary<long, SimpleCombatEntityDieContext> request, bool isKscEntityRemoved = false)
	{
		if (this.IsDebugOn())
		{
			UKismetSystemLibrary.D_DrawDebugSphere(KscEnv.Instance.KscWorld, context.Location.ToUeVector(false), 16f, 16, new FLinearColor?(new FLinearColor(1f, 0f, 0f, 1f)), 16f, 0f);
		}
		if (context.CreatureDataId == 0L)
		{
			return;
		}
		if (this.CurSubController != null)
		{
			this.CurSubController.OnEntityRemoved(context, request);
		}
		else
		{
			KscLog.Warn(KscLog.EModule.Common, ELogAuthor.XY, KscEnv.Instance.KscWorld, "没有注册OnEntityRemoved回调, 无法批量移除实体", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (!isKscEntityRemoved)
		{
			this.RemoveEntity(context.CreatureDataId, context.ReasonName);
			return;
		}
		if (this.CancelPendingAddIfAny(context.CreatureDataId))
		{
			this.CancelPendingActionsForEntity(context.CreatureDataId);
			return;
		}
		this.CancelPendingActionsForEntity(context.CreatureDataId);
		KscActionEntityForget kscActionEntityForget = new KscActionEntityForget(context.CreatureDataId);
		KscSubModelBase curSubModel = this.CurSubModel;
		if (curSubModel == null)
		{
			return;
		}
		curSubModel.EntityProcessMgr.RunTask(kscActionEntityForget.Task);
	}

	// Token: 0x06002DEA RID: 11754 RVA: 0x0010FA90 File Offset: 0x0010DC90
	[NullableContext(2)]
	private void SimpleCombatEntityBuffUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		SimpleCombatEntityBuffUpdateNotify simpleCombatEntityBuffUpdateNotify = (SimpleCombatEntityBuffUpdateNotify)msg;
		int buffId = simpleCombatEntityBuffUpdateNotify.BuffId;
		long entityId = simpleCombatEntityBuffUpdateNotify.EntityId;
		KscActionBuffUpdate kscActionBuffUpdate = new KscActionBuffUpdate(simpleCombatEntityBuffUpdateNotify);
		KscSubModelBase curSubModel = this.CurSubModel;
		if (curSubModel == null)
		{
			return;
		}
		curSubModel.EntityProcessMgr.RunTask(kscActionBuffUpdate.Task);
	}

	// Token: 0x06002DEB RID: 11755 RVA: 0x0010FAD8 File Offset: 0x0010DCD8
	[NullableContext(2)]
	private void SimpleCombatEntityBuffLayerCountNotify(IMessage msg, Net.CallbackStatus status)
	{
		SimpleCombatEntityBuffLayerCountNotify simpleCombatEntityBuffLayerCountNotify = (SimpleCombatEntityBuffLayerCountNotify)msg;
		int buffId = simpleCombatEntityBuffLayerCountNotify.BuffId;
		long entityId = simpleCombatEntityBuffLayerCountNotify.EntityId;
		KscActionBuffLayoutUpdate kscActionBuffLayoutUpdate = new KscActionBuffLayoutUpdate(simpleCombatEntityBuffLayerCountNotify);
		KscSubModelBase curSubModel = this.CurSubModel;
		if (curSubModel == null)
		{
			return;
		}
		curSubModel.EntityProcessMgr.RunTask(kscActionBuffLayoutUpdate.Task);
	}

	// Token: 0x06002DEC RID: 11756 RVA: 0x0010FB20 File Offset: 0x0010DD20
	[NullableContext(2)]
	private void SimpleCombatEntitySubTypeChangeNotify(IMessage msg, Net.CallbackStatus status)
	{
		SimpleCombatEntitySubTypeChangeNotify simpleCombatEntitySubTypeChangeNotify = (SimpleCombatEntitySubTypeChangeNotify)msg;
		long entityId = simpleCombatEntitySubTypeChangeNotify.EntityId;
		SimpleCombatComponentPb newComponentData = simpleCombatEntitySubTypeChangeNotify.NewComponentData;
		MapField<int, int> mapField = (newComponentData != null) ? newComponentData.BuffLayers : null;
		if (mapField == null || mapField.Count <= 0)
		{
			return;
		}
		KscActionBuffsAdd kscActionBuffsAdd = new KscActionBuffsAdd(simpleCombatEntitySubTypeChangeNotify);
		KscSubModelBase curSubModel = this.CurSubModel;
		if (curSubModel == null)
		{
			return;
		}
		curSubModel.EntityProcessMgr.RunTask(kscActionBuffsAdd.Task);
	}

	// Token: 0x06002DED RID: 11757 RVA: 0x0010FB80 File Offset: 0x0010DD80
	[NullableContext(2)]
	private void SimpleCombatEntityAttributeUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		SimpleCombatEntityAttributeUpdateNotify simpleCombatEntityAttributeUpdateNotify = (SimpleCombatEntityAttributeUpdateNotify)msg;
		long entityId = simpleCombatEntityAttributeUpdateNotify.EntityId;
		KscActionAttrUpdate kscActionAttrUpdate = new KscActionAttrUpdate(MathUtils.Instance.LongToNumber(simpleCombatEntityAttributeUpdateNotify.EntityId), simpleCombatEntityAttributeUpdateNotify);
		KscSubModelBase curSubModel = this.CurSubModel;
		if (curSubModel == null)
		{
			return;
		}
		curSubModel.EntityProcessMgr.RunTask(kscActionAttrUpdate.Task);
	}

	// Token: 0x06002DEE RID: 11758 RVA: 0x0010FBD0 File Offset: 0x0010DDD0
	public void ModifyBuffAsync(int kscEntityId, bool isAdd, int buffId)
	{
		KscEntityHandle kscEntityHandle;
		if (!this.CurSubModel.KscEntities.TryGetValue(kscEntityId, out kscEntityHandle) || !kscEntityHandle.Valid)
		{
			KscLog.EModule flag = KscLog.EModule.Skill;
			ELogAuthor author = ELogAuthor.CFT;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "刷新buff时失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", kscEntityId);
			KscLog.Warn(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		KscActionBuffModifyLocal kscActionBuffModifyLocal = new KscActionBuffModifyLocal(kscEntityHandle.CreatureDataId, kscEntityId, isAdd, buffId);
		KscSubModelBase curSubModel = this.CurSubModel;
		if (curSubModel == null)
		{
			return;
		}
		curSubModel.EntityProcessMgr.RunTask(kscActionBuffModifyLocal.Task);
	}

	// Token: 0x06002DEF RID: 11759 RVA: 0x0010FC58 File Offset: 0x0010DE58
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public FKSC_MiniMapContext[] GetEntityPositions()
	{
		if (KscEnv.Instance.KscWorld == null)
		{
			return null;
		}
		List<FKSC_MiniMapContext> list = new List<FKSC_MiniMapContext>();
		int num = this.EntityPositions.Num();
		for (int i = 0; i < num; i++)
		{
			list.Add(this.EntityPositions.Get(i));
		}
		return list.ToArray();
	}

	// Token: 0x06002DF0 RID: 11760 RVA: 0x0010FCAC File Offset: 0x0010DEAC
	public void PushSimpleCombatEntityHp(long creatureDataId, float hp, float hpMax)
	{
		SimpleCombatEntitySyncAttributePush simpleCombatEntitySyncAttributePush = SimpleCombatEntitySyncAttributePush.Create();
		Dictionary<long, SimpleCombatEntityAttributePbInfo> dictionary = new Dictionary<long, SimpleCombatEntityAttributePbInfo>();
		SimpleCombatEntityAttributePbInfo simpleCombatEntityAttributePbInfo = SimpleCombatEntityAttributePbInfo.Create();
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		dictionary2[3] = (int)hp;
		dictionary2[2] = (int)hpMax;
		simpleCombatEntityAttributePbInfo.AttributeMap.Add(dictionary2);
		dictionary[creatureDataId] = simpleCombatEntityAttributePbInfo;
		simpleCombatEntitySyncAttributePush.EntityAttributeMap.Add(dictionary);
		Net.Instance.Send(EPushMessageId.SimpleCombatEntitySyncAttributePush, simpleCombatEntitySyncAttributePush);
	}

	// Token: 0x06002DF1 RID: 11761 RVA: 0x0010FD13 File Offset: 0x0010DF13
	public void SetDebugOn(bool value)
	{
		this.IsDebug = value;
	}

	// Token: 0x06002DF2 RID: 11762 RVA: 0x0010FD1C File Offset: 0x0010DF1C
	public bool IsDebugOn()
	{
		return this.IsDebug;
	}

	// Token: 0x06002DF3 RID: 11763 RVA: 0x0010FD24 File Offset: 0x0010DF24
	public void ToggleDebug()
	{
		this.IsDebug = !this.IsDebug;
	}

	// Token: 0x170006A5 RID: 1701
	// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x0010FD35 File Offset: 0x0010DF35
	[Nullable(2)]
	public UKSC_HeadStateManager KscHeadStateManager
	{
		[NullableContext(2)]
		get
		{
			return this.KscHeadStateManagerInternal;
		}
	}

	// Token: 0x06002DF5 RID: 11765 RVA: 0x0010FD3D File Offset: 0x0010DF3D
	public void StartKscHeadStateManager()
	{
		if (this.KscHeadStateManagerInternal != null)
		{
			return;
		}
		this.KscHeadStateManagerInternal = UKSC_HeadStateManager.CreateInstance(GlobalData.World);
	}

	// Token: 0x06002DF6 RID: 11766 RVA: 0x0010FD58 File Offset: 0x0010DF58
	public void StopKscHeadStateManager()
	{
		if (this.KscHeadStateManagerInternal != null)
		{
			UKSC_HeadStateManager.DestroyInstance();
			this.KscHeadStateManagerInternal = null;
		}
	}

	// Token: 0x06002DF7 RID: 11767 RVA: 0x0010FD6E File Offset: 0x0010DF6E
	[NullableContext(2)]
	private void SimpleCombatBeginNotify(IMessage msg, Net.CallbackStatus status)
	{
		this.OpenWorldByGameplayType(EKscGameplayType.FinalBattle);
	}

	// Token: 0x06002DF8 RID: 11768 RVA: 0x0010FD78 File Offset: 0x0010DF78
	[NullableContext(2)]
	private void SimpleCombatEndNotify(IMessage msg, Net.CallbackStatus status)
	{
		KscSubControllerBase kscSubControllerBase;
		this.CloseCurrentWorld(this.SubControllerMap.TryGetValue(EKscGameplayType.FinalBattle, out kscSubControllerBase) ? kscSubControllerBase : null);
	}

	// Token: 0x06002DF9 RID: 11769 RVA: 0x0010FDA0 File Offset: 0x0010DFA0
	[NullableContext(2)]
	public AKSC_Entity GetKscEntityHandle(long creatureId)
	{
		KscSubModelBase curSubModel = this.CurSubModel;
		KscEntityHandle kscEntityHandle = (curSubModel != null) ? curSubModel.GetKscEntityHandle(creatureId) : null;
		if (kscEntityHandle != null && kscEntityHandle.Valid && kscEntityHandle.KscEntity != null)
		{
			return kscEntityHandle.KscEntity;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || getCurrentEntity.Entity == null)
		{
			return null;
		}
		if (getCurrentEntity.CreatureDataId != creatureId)
		{
			return null;
		}
		KscSubModelBase curSubModel2 = this.CurSubModel;
		if (curSubModel2 == null)
		{
			return null;
		}
		return curSubModel2.KscPlayerEntity;
	}

	// Token: 0x06002DFA RID: 11770 RVA: 0x0010FE10 File Offset: 0x0010E010
	public void GmCreateEntity(int simpleCombatId, float distance)
	{
		string entityPathById = KuroSimpleCombatController.Instance.CurSubModel.GetEntityPathById(simpleCombatId);
		if (string.IsNullOrEmpty(entityPathById))
		{
			KscLog.EModule flag = KscLog.EModule.Common;
			ELogAuthor author = ELogAuthor.TZQ;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "[摩托战斗]实体资产路径不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("simpleCombatId", simpleCombatId);
			KscLog.Error(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
		if (worldEntity == null)
		{
			KscLog.Error(KscLog.EModule.Common, ELogAuthor.TZQ, KscEnv.Instance.KscWorld, "[摩托战斗]playerEntity为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		BaseActorComponent component = worldEntity.GetComponent<BaseActorComponent>();
		if (component == null)
		{
			KscLog.Error(KscLog.EModule.Common, ELogAuthor.TZQ, KscEnv.Instance.KscWorld, "[摩托战斗]baseActorComponent为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		global::Vector vector = component.ActorLocationProxy.Addition(component.ActorForwardProxy.Multiply((double)distance, MathUtils.Instance.CommonTempVector), MathUtils.Instance.CommonTempVector);
		FVectorDouble fvectorDouble = vector.ToUeVector(false);
		FVector fvector = global::Vector.OneVectorDouble;
		FTransformDouble transform = new FTransformDouble(ref global::Rotator.ZeroRotator, ref fvectorDouble, ref fvector);
		KuroSimpleCombatController.Instance.AsyncAddEntity(new KscEntityParam
		{
			CreatureId = -1L,
			SimpleCombatId = simpleCombatId,
			AssetPath = entityPathById,
			PropertyId = 0,
			Transform = transform
		});
	}

	// Token: 0x06002DFB RID: 11771 RVA: 0x0010FF58 File Offset: 0x0010E158
	public void GmAddBuff(int kscEntityId, int buffId)
	{
		if (kscEntityId == 0)
		{
			MotorcycleArrowSubController motorcycleArrowSubController = this.CurSubController as MotorcycleArrowSubController;
			if (motorcycleArrowSubController != null)
			{
				motorcycleArrowSubController.EffectManager.AddBuffEffect(buffId, null, true);
				return;
			}
		}
		int num = (kscEntityId == 0) ? this.GmGetPlayerEntityId() : kscEntityId;
		if (num != 0)
		{
			this.ModifyBuffAsync(num, true, buffId);
		}
	}

	// Token: 0x06002DFC RID: 11772 RVA: 0x0010FFA8 File Offset: 0x0010E1A8
	public void GmRemoveBuff(int kscEntityId, int buffId)
	{
		if (kscEntityId == 0)
		{
			MotorcycleArrowSubController motorcycleArrowSubController = this.CurSubController as MotorcycleArrowSubController;
			if (motorcycleArrowSubController != null)
			{
				motorcycleArrowSubController.EffectManager.RemovePlayerBuff(buffId);
				return;
			}
		}
		int num = (kscEntityId == 0) ? this.GmGetPlayerEntityId() : kscEntityId;
		if (num != 0)
		{
			this.ModifyBuffAsync(num, false, buffId);
		}
	}

	// Token: 0x06002DFD RID: 11773 RVA: 0x0010FFF0 File Offset: 0x0010E1F0
	public int GmGetPlayerEntityId()
	{
		KscSubModelBase curSubModel = this.CurSubModel;
		int? num;
		if (curSubModel == null)
		{
			num = null;
		}
		else
		{
			AKSC_Entity kscPlayerEntity = curSubModel.KscPlayerEntity;
			num = ((kscPlayerEntity != null) ? new int?(kscPlayerEntity.EntityId_) : null);
		}
		int? num2 = num;
		return num2.GetValueOrDefault();
	}

	// Token: 0x06002DFE RID: 11774 RVA: 0x00110038 File Offset: 0x0010E238
	public unsafe void GmAddPlayerEntity(IKscGmPlayerEntityParam param)
	{
		if (this.CurSubController == null)
		{
			KscLog.EModule flag = KscLog.EModule.Common;
			ELogAuthor author = ELogAuthor.CFT;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "Ksc尝试添加玩家角色,当前子控制器非法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SimpleCombatId", param.SimpleCombatId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SubTypeId", param.SubTypeId);
			KscLog.Warn(flag, author, kscWorld, log, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		KscLog.EModule flag2 = KscLog.EModule.Common;
		ELogAuthor author2 = ELogAuthor.CFT;
		UObject kscWorld2 = KscEnv.Instance.KscWorld;
		string log2 = "Ksc转发添加玩家角色请求";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("SimpleCombatId", param.SimpleCombatId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SubTypeId", param.SubTypeId);
		KscLog.Info(flag2, author2, kscWorld2, log2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		this.CurSubController.GmAddPlayerEntity(param);
	}

	// Token: 0x06002DFF RID: 11775 RVA: 0x00110130 File Offset: 0x0010E330
	public void GmPrintInfo()
	{
		if (this.CurSubController != null)
		{
			this.CurSubController.GmPrintInfo();
		}
	}

	// Token: 0x06002E00 RID: 11776 RVA: 0x00110145 File Offset: 0x0010E345
	public void GmCreateKSCWorld(int GamePlayType)
	{
		this.OpenWorldByGameplayType((EKscGameplayType)GamePlayType);
	}

	// Token: 0x170006A6 RID: 1702
	// (get) Token: 0x06002E01 RID: 11777 RVA: 0x0011014E File Offset: 0x0010E34E
	public static KuroSimpleCombatController Instance
	{
		get
		{
			return KuroSimpleCombatController._Instance;
		}
	}

	// Token: 0x06002E02 RID: 11778 RVA: 0x00110155 File Offset: 0x0010E355
	public static KuroSimpleCombatController GetOrCreateInstance()
	{
		if (KuroSimpleCombatController._Instance == null)
		{
			KuroSimpleCombatController.CreateInstance();
		}
		return KuroSimpleCombatController._Instance;
	}

	// Token: 0x06002E03 RID: 11779 RVA: 0x00110169 File Offset: 0x0010E369
	public static bool CreateInstance()
	{
		if (KuroSimpleCombatController._Instance != null)
		{
			return true;
		}
		KuroSimpleCombatController._Instance = new KuroSimpleCombatController();
		return true;
	}

	// Token: 0x06002E04 RID: 11780 RVA: 0x0011017F File Offset: 0x0010E37F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06002E05 RID: 11781 RVA: 0x00110181 File Offset: 0x0010E381
	public static void ResetStaticDefaultValue()
	{
		KuroSimpleCombatController._Instance = null;
	}

	// Token: 0x06002E06 RID: 11782 RVA: 0x00110189 File Offset: 0x0010E389
	static KuroSimpleCombatController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroSimpleCombatController.CreateStaticDefaultValue), new Action(KuroSimpleCombatController.ResetStaticDefaultValue));
	}

	// Token: 0x040029C8 RID: 10696
	private readonly Dictionary<EKscGameplayType, KscSubControllerBase> SubControllerMap = new Dictionary<EKscGameplayType, KscSubControllerBase>
	{
		{
			EKscGameplayType.TowerDefense,
			new TowerDefenseSubController()
		},
		{
			EKscGameplayType.SurvivorsRogue,
			new SurvivorsRogueSubController()
		},
		{
			EKscGameplayType.FinalBattle,
			new FinalBattleSubController()
		},
		{
			EKscGameplayType.MotorcycleArrow,
			new MotorcycleArrowSubController()
		},
		{
			EKscGameplayType.PinballBattle,
			new PinballBattleSubController()
		},
		{
			EKscGameplayType.Potato,
			new PotatoSubController()
		}
	};

	// Token: 0x040029C9 RID: 10697
	[Nullable(2)]
	public KscSubControllerBase CurSubController;

	// Token: 0x040029CA RID: 10698
	private TArray<FKSC_MiniMapContext> EntityPositions = new TArray<FKSC_MiniMapContext>();

	// Token: 0x040029CB RID: 10699
	private bool IsMapInit;

	// Token: 0x040029CC RID: 10700
	private bool IsWorldInit;

	// Token: 0x040029CD RID: 10701
	private List<EKscObservedLifecycleStage> ObservedLifecycleStages = new List<EKscObservedLifecycleStage>();

	// Token: 0x040029CE RID: 10702
	private readonly Dictionary<long, KscActionEntityAdd> PendingAdds = new Dictionary<long, KscActionEntityAdd>();

	// Token: 0x040029CF RID: 10703
	private readonly KscRemoveContext RemoveContext = new KscRemoveContext();

	// Token: 0x040029D0 RID: 10704
	public bool IsDebug;

	// Token: 0x040029D1 RID: 10705
	[Nullable(2)]
	private UKSC_HeadStateManager KscHeadStateManagerInternal;

	// Token: 0x040029D2 RID: 10706
	[Nullable(2)]
	private static KuroSimpleCombatController _Instance;
}
