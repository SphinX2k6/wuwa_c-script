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

// Token: 0x02000E76 RID: 3702
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class KuroSimpleCombatController : ControllerBase
{
	// Token: 0x1700067E RID: 1662
	// (get) Token: 0x06005A24 RID: 23076 RVA: 0x00106DC3 File Offset: 0x00104FC3
	public bool MapInit
	{
		get
		{
			return this.IsMapInit;
		}
	}

	// Token: 0x1700067F RID: 1663
	// (get) Token: 0x06005A25 RID: 23077 RVA: 0x00106DCB File Offset: 0x00104FCB
	public bool WorldInit
	{
		get
		{
			return this.IsWorldInit;
		}
	}

	// Token: 0x06005A26 RID: 23078 RVA: 0x00106DD3 File Offset: 0x00104FD3
	public void RegisterPendingAdd(long creatureId, KscActionEntityAdd action)
	{
		this.PendingAdds[creatureId] = action;
	}

	// Token: 0x06005A27 RID: 23079 RVA: 0x00106DE4 File Offset: 0x00104FE4
	public void UnregisterPendingAdd(long creatureId, KscActionEntityAdd action)
	{
		KscActionEntityAdd kscActionEntityAdd;
		if (this.PendingAdds.TryGetValue(creatureId, out kscActionEntityAdd) && kscActionEntityAdd == action)
		{
			this.PendingAdds.Remove(creatureId);
		}
	}

	// Token: 0x06005A28 RID: 23080 RVA: 0x00106E14 File Offset: 0x00105014
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

	// Token: 0x06005A29 RID: 23081 RVA: 0x00106E4C File Offset: 0x0010504C
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

	// Token: 0x17000680 RID: 1664
	// (get) Token: 0x06005A2A RID: 23082 RVA: 0x00106E9F File Offset: 0x0010509F
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

	// Token: 0x06005A2B RID: 23083 RVA: 0x00106EB4 File Offset: 0x001050B4
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

	// Token: 0x06005A2C RID: 23084 RVA: 0x00106ED4 File Offset: 0x001050D4
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

	// Token: 0x06005A2D RID: 23085 RVA: 0x00106EE8 File Offset: 0x001050E8
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

	// Token: 0x06005A2E RID: 23086 RVA: 0x00107068 File Offset: 0x00105268
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

	// Token: 0x06005A2F RID: 23087 RVA: 0x0010718C File Offset: 0x0010538C
	protected override bool OnLeaveLevel()
	{
		this.StopKscHeadStateManager();
		return true;
	}

	// Token: 0x06005A30 RID: 23088 RVA: 0x00107198 File Offset: 0x00105398
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

	// Token: 0x06005A31 RID: 23089 RVA: 0x001071CA File Offset: 0x001053CA
	private void ObserveLifecycleStage(EKscObservedLifecycleStage stage, string source)
	{
		this.ObservedLifecycleStages.Add(stage);
	}

	// Token: 0x06005A32 RID: 23090 RVA: 0x001071D8 File Offset: 0x001053D8
	private void ResetObservedLifecycleStage()
	{
		this.ObservedLifecycleStages.Clear();
	}

	// Token: 0x06005A33 RID: 23091 RVA: 0x001071E5 File Offset: 0x001053E5
	private bool HasObservedLifecycleStage(EKscObservedLifecycleStage stage)
	{
		return this.ObservedLifecycleStages.Contains(stage);
	}

	// Token: 0x06005A34 RID: 23092 RVA: 0x001071F4 File Offset: 0x001053F4
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

	// Token: 0x06005A35 RID: 23093 RVA: 0x00107258 File Offset: 0x00105458
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

	// Token: 0x06005A36 RID: 23094 RVA: 0x001072E4 File Offset: 0x001054E4
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

	// Token: 0x06005A37 RID: 23095 RVA: 0x0010730B File Offset: 0x0010550B
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

	// Token: 0x06005A38 RID: 23096 RVA: 0x0010732A File Offset: 0x0010552A
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

	// Token: 0x06005A39 RID: 23097 RVA: 0x00107348 File Offset: 0x00105548
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

	// Token: 0x06005A3A RID: 23098 RVA: 0x0010739B File Offset: 0x0010559B
	private void TryCatchUpObservedLifecycleAfterOpen(string source)
	{
		if (this.ObservedLifecycleStages.Count == 0)
		{
			return;
		}
		this.CatchUpObservedLifecycleAfterOpenAsync(source, this.CurSubController).Forget();
	}

	// Token: 0x06005A3B RID: 23099 RVA: 0x001073BD File Offset: 0x001055BD
	private void OnGameModeDataChange()
	{
		this.ObserveLifecycleStage(EKscObservedLifecycleStage.InitMap, "OnSetGameModeDataDone");
		this.TryInitMap("OnSetGameModeDataDone");
	}

	// Token: 0x06005A3C RID: 23100 RVA: 0x001073D7 File Offset: 0x001055D7
	private void OnAfterLoadMap()
	{
		this.ObserveLifecycleStage(EKscObservedLifecycleStage.MapLoad, "AfterLoadMap");
		this.TryMapLoaded("AfterLoadMap");
	}

	// Token: 0x06005A3D RID: 23101 RVA: 0x001073F1 File Offset: 0x001055F1
	private void OnWorldDone()
	{
		this.ObserveLifecycleStage(EKscObservedLifecycleStage.WorldDone, "WorldDoneAndCloseLoading");
		this.TryWorldDone("WorldDoneAndCloseLoading");
	}

	// Token: 0x06005A3E RID: 23102 RVA: 0x0010740C File Offset: 0x0010560C
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

	// Token: 0x06005A3F RID: 23103 RVA: 0x0010746C File Offset: 0x0010566C
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

	// Token: 0x06005A40 RID: 23104 RVA: 0x001074DC File Offset: 0x001056DC
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

	// Token: 0x06005A41 RID: 23105 RVA: 0x00107584 File Offset: 0x00105784
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

	// Token: 0x06005A42 RID: 23106 RVA: 0x001075C4 File Offset: 0x001057C4
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

	// Token: 0x06005A43 RID: 23107 RVA: 0x001075F0 File Offset: 0x001057F0
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

	// Token: 0x06005A44 RID: 23108 RVA: 0x0010761C File Offset: 0x0010581C
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

	// Token: 0x06005A45 RID: 23109 RVA: 0x0010764E File Offset: 0x0010584E
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

	// Token: 0x06005A46 RID: 23110 RVA: 0x0010765C File Offset: 0x0010585C
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

	// Token: 0x06005A47 RID: 23111 RVA: 0x001076A0 File Offset: 0x001058A0
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

	// Token: 0x06005A48 RID: 23112 RVA: 0x001077E0 File Offset: 0x001059E0
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

	// Token: 0x06005A49 RID: 23113 RVA: 0x00107810 File Offset: 0x00105A10
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

	// Token: 0x06005A4A RID: 23114 RVA: 0x001078D0 File Offset: 0x00105AD0
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

	// Token: 0x06005A4B RID: 23115 RVA: 0x00107920 File Offset: 0x00105B20
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

	// Token: 0x06005A4C RID: 23116 RVA: 0x00107A04 File Offset: 0x00105C04
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

	// Token: 0x06005A4D RID: 23117 RVA: 0x00107A58 File Offset: 0x00105C58
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

	// Token: 0x06005A4E RID: 23118 RVA: 0x00107B98 File Offset: 0x00105D98
	public int GetLogicProxy(int creatureId)
	{
		return this.CurSubModel.GetLogicProxy((long)creatureId).GetValueOrDefault();
	}

	// Token: 0x06005A4F RID: 23119 RVA: 0x00107BBC File Offset: 0x00105DBC
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

	// Token: 0x06005A50 RID: 23120 RVA: 0x00107C0C File Offset: 0x00105E0C
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

	// Token: 0x06005A51 RID: 23121 RVA: 0x00107C74 File Offset: 0x00105E74
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

	// Token: 0x06005A52 RID: 23122 RVA: 0x00107CDC File Offset: 0x00105EDC
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

	// Token: 0x06005A53 RID: 23123 RVA: 0x00107DE0 File Offset: 0x00105FE0
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

	// Token: 0x06005A54 RID: 23124 RVA: 0x00107E28 File Offset: 0x00106028
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

	// Token: 0x06005A55 RID: 23125 RVA: 0x00107E70 File Offset: 0x00106070
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

	// Token: 0x06005A56 RID: 23126 RVA: 0x00107ED0 File Offset: 0x001060D0
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

	// Token: 0x06005A57 RID: 23127 RVA: 0x00107F20 File Offset: 0x00106120
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

	// Token: 0x06005A58 RID: 23128 RVA: 0x00107FA8 File Offset: 0x001061A8
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

	// Token: 0x06005A59 RID: 23129 RVA: 0x00107FFC File Offset: 0x001061FC
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

	// Token: 0x06005A5A RID: 23130 RVA: 0x00108063 File Offset: 0x00106263
	public void SetDebugOn(bool value)
	{
		this.IsDebug = value;
	}

	// Token: 0x06005A5B RID: 23131 RVA: 0x0010806C File Offset: 0x0010626C
	public bool IsDebugOn()
	{
		return this.IsDebug;
	}

	// Token: 0x06005A5C RID: 23132 RVA: 0x00108074 File Offset: 0x00106274
	public void ToggleDebug()
	{
		this.IsDebug = !this.IsDebug;
	}

	// Token: 0x17000681 RID: 1665
	// (get) Token: 0x06005A5D RID: 23133 RVA: 0x00108085 File Offset: 0x00106285
	[Nullable(2)]
	public UKSC_HeadStateManager KscHeadStateManager
	{
		[NullableContext(2)]
		get
		{
			return this.KscHeadStateManagerInternal;
		}
	}

	// Token: 0x06005A5E RID: 23134 RVA: 0x0010808D File Offset: 0x0010628D
	public void StartKscHeadStateManager()
	{
		if (this.KscHeadStateManagerInternal != null)
		{
			return;
		}
		this.KscHeadStateManagerInternal = UKSC_HeadStateManager.CreateInstance(GlobalData.World);
	}

	// Token: 0x06005A5F RID: 23135 RVA: 0x001080A8 File Offset: 0x001062A8
	public void StopKscHeadStateManager()
	{
		if (this.KscHeadStateManagerInternal != null)
		{
			UKSC_HeadStateManager.DestroyInstance();
			this.KscHeadStateManagerInternal = null;
		}
	}

	// Token: 0x06005A60 RID: 23136 RVA: 0x001080BE File Offset: 0x001062BE
	[NullableContext(2)]
	private void SimpleCombatBeginNotify(IMessage msg, Net.CallbackStatus status)
	{
		this.OpenWorldByGameplayType(EKscGameplayType.FinalBattle);
	}

	// Token: 0x06005A61 RID: 23137 RVA: 0x001080C8 File Offset: 0x001062C8
	[NullableContext(2)]
	private void SimpleCombatEndNotify(IMessage msg, Net.CallbackStatus status)
	{
		KscSubControllerBase kscSubControllerBase;
		this.CloseCurrentWorld(this.SubControllerMap.TryGetValue(EKscGameplayType.FinalBattle, out kscSubControllerBase) ? kscSubControllerBase : null);
	}

	// Token: 0x06005A62 RID: 23138 RVA: 0x001080F0 File Offset: 0x001062F0
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

	// Token: 0x06005A63 RID: 23139 RVA: 0x00108160 File Offset: 0x00106360
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

	// Token: 0x06005A64 RID: 23140 RVA: 0x001082A8 File Offset: 0x001064A8
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

	// Token: 0x06005A65 RID: 23141 RVA: 0x001082F8 File Offset: 0x001064F8
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

	// Token: 0x06005A66 RID: 23142 RVA: 0x00108340 File Offset: 0x00106540
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

	// Token: 0x06005A67 RID: 23143 RVA: 0x00108388 File Offset: 0x00106588
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

	// Token: 0x06005A68 RID: 23144 RVA: 0x00108480 File Offset: 0x00106680
	public void GmPrintInfo()
	{
		if (this.CurSubController != null)
		{
			this.CurSubController.GmPrintInfo();
		}
	}

	// Token: 0x06005A69 RID: 23145 RVA: 0x00108495 File Offset: 0x00106695
	public void GmCreateKSCWorld(int GamePlayType)
	{
		this.OpenWorldByGameplayType((EKscGameplayType)GamePlayType);
	}

	// Token: 0x17000682 RID: 1666
	// (get) Token: 0x06005A6A RID: 23146 RVA: 0x0010849E File Offset: 0x0010669E
	public static KuroSimpleCombatController Instance
	{
		get
		{
			return KuroSimpleCombatController._Instance;
		}
	}

	// Token: 0x06005A6B RID: 23147 RVA: 0x001084A5 File Offset: 0x001066A5
	public static KuroSimpleCombatController GetOrCreateInstance()
	{
		if (KuroSimpleCombatController._Instance == null)
		{
			KuroSimpleCombatController.CreateInstance();
		}
		return KuroSimpleCombatController._Instance;
	}

	// Token: 0x06005A6C RID: 23148 RVA: 0x001084B9 File Offset: 0x001066B9
	public static bool CreateInstance()
	{
		if (KuroSimpleCombatController._Instance != null)
		{
			return true;
		}
		KuroSimpleCombatController._Instance = new KuroSimpleCombatController();
		return true;
	}

	// Token: 0x06005A6D RID: 23149 RVA: 0x001084CF File Offset: 0x001066CF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005A6E RID: 23150 RVA: 0x001084D1 File Offset: 0x001066D1
	public static void ResetStaticDefaultValue()
	{
		KuroSimpleCombatController._Instance = null;
	}

	// Token: 0x06005A6F RID: 23151 RVA: 0x001084D9 File Offset: 0x001066D9
	static KuroSimpleCombatController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroSimpleCombatController.CreateStaticDefaultValue), new Action(KuroSimpleCombatController.ResetStaticDefaultValue));
	}

	// Token: 0x0400292D RID: 10541
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

	// Token: 0x0400292E RID: 10542
	[Nullable(2)]
	public KscSubControllerBase CurSubController;

	// Token: 0x0400292F RID: 10543
	private TArray<FKSC_MiniMapContext> EntityPositions = new TArray<FKSC_MiniMapContext>();

	// Token: 0x04002930 RID: 10544
	private bool IsMapInit;

	// Token: 0x04002931 RID: 10545
	private bool IsWorldInit;

	// Token: 0x04002932 RID: 10546
	private List<EKscObservedLifecycleStage> ObservedLifecycleStages = new List<EKscObservedLifecycleStage>();

	// Token: 0x04002933 RID: 10547
	private readonly Dictionary<long, KscActionEntityAdd> PendingAdds = new Dictionary<long, KscActionEntityAdd>();

	// Token: 0x04002934 RID: 10548
	private readonly KscRemoveContext RemoveContext = new KscRemoveContext();

	// Token: 0x04002935 RID: 10549
	public bool IsDebug;

	// Token: 0x04002936 RID: 10550
	[Nullable(2)]
	private UKSC_HeadStateManager KscHeadStateManagerInternal;

	// Token: 0x04002937 RID: 10551
	[Nullable(2)]
	private static KuroSimpleCombatController _Instance;
}
