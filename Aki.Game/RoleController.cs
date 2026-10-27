using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Map.UISceneLevel.UI_Scene.UI_BP;
using CSharpScript.Game;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;
using CSharpScript.Game.Module.BossPiling;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.View;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x020027AA RID: 10154
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RoleController : UiControllerBase
{
	// Token: 0x06014DCF RID: 85455 RVA: 0x0054B92C File Offset: 0x00549B2C
	protected override bool OnInit()
	{
		InputManager.Instance.RegisterOpenViewFunc(EUiViewName.RoleRootView, this.OpenRoleMainViewByInput);
		return true;
	}

	// Token: 0x06014DD0 RID: 85456 RVA: 0x0054B944 File Offset: 0x00549B44
	[NullableContext(2)]
	public bool CanOpenView(EUiViewName viewName, object arg = null)
	{
		if (!FunctionModel.Instance.IsOpen(10001))
		{
			return false;
		}
		if (SceneTeamModel.Instance.IsPhantomTeam || SceneTeamModel.Instance.HasPhantomRole())
		{
			ScrollingTipsController.Instance.ShowTipsById("PhantomFormationEnterRoleTip", Array.Empty<object>());
			return false;
		}
		int playerId = CreatureModel.Instance.GetPlayerId();
		return SceneTeamModel.Instance.GetCurrentGroupLivingState(playerId) != ETeamLivingState.Dead || this.CheckInDeadCanOpenInstanceDungeon();
	}

	// Token: 0x06014DD1 RID: 85457 RVA: 0x0054B9B8 File Offset: 0x00549BB8
	private bool CheckInDeadCanOpenInstanceDungeon()
	{
		if (TowerModel.Instance.CheckInTower())
		{
			return true;
		}
		BossRushModel instance = BossRushModel.Instance;
		if (((instance != null) ? new bool?(instance.CheckInBossRush()) : null).GetValueOrDefault())
		{
			return true;
		}
		ShipTowerModel instance2 = ShipTowerModel.Instance;
		if (((instance2 != null) ? new bool?(instance2.CheckInBattleShipTower()) : null).GetValueOrDefault())
		{
			return true;
		}
		BabelTowerModel instance3 = BabelTowerModel.Instance;
		return ((instance3 != null) ? new bool?(instance3.CheckInBattleBabelTower()) : null).GetValueOrDefault() || LordGymController.Instance.IsInLordGymDungeon() || BossPilingModel.Instance.CheckIsBossPiling() || AdamSmasherController.Instance.IsInAdamSmasherDungeon();
	}

	// Token: 0x06014DD2 RID: 85458 RVA: 0x0054BA7C File Offset: 0x00549C7C
	[NullableContext(2)]
	public void OpenRoleMainView(ERoleAgentType agentType, int selectRoleId = 0, List<int> roleIdList = null, EUiTabViewName? openTabView = null, TOpenViewCallBack finishCallback = null)
	{
		if (roleIdList == null)
		{
			roleIdList = new List<int>();
		}
		this.OpenRoleMainViewByParam(new OpenRoleMainViewData
		{
			AgentType = agentType,
			SelectRoleId = new int?(selectRoleId),
			RoleIdList = roleIdList,
			OpenTabView = openTabView,
			FinishCallback = finishCallback,
			TeamPositionType = new ETeamPositionType?(ETeamPositionType.Normal),
			Source = new ERoleViewSource?(ERoleViewSource.Normal)
		});
	}

	// Token: 0x06014DD3 RID: 85459 RVA: 0x0054BAE0 File Offset: 0x00549CE0
	public void OpenRoleMainViewByParam(IOpenRoleMainViewData param)
	{
		int valueOrDefault = param.SelectRoleId.GetValueOrDefault();
		List<int> roleIdList = param.RoleIdList ?? new List<int>();
		RoleViewAgent roleViewAgent = RoleModel.Instance.GetRoleViewAgent(param.AgentType);
		ETeamPositionType valueOrDefault2 = param.TeamPositionType.GetValueOrDefault();
		roleViewAgent.Init(roleIdList, valueOrDefault, param.OpenTabView, param.Source.GetValueOrDefault());
		roleViewAgent.TeamPositionType = new ETeamPositionType?(valueOrDefault2);
		UiManager.Instance.OpenView(EUiViewName.RoleRootView, roleViewAgent, param.FinishCallback);
	}

	// Token: 0x06014DD4 RID: 85460 RVA: 0x0054BB6D File Offset: 0x00549D6D
	public void OpenRoleViewByViewModel(EUiViewName viewName, RoleViewViewModel viewModel)
	{
		if (!this.CheckRoleCanOpenView(viewModel.RoleId, viewName))
		{
			return;
		}
		UiManager.Instance.OpenView(viewName, viewModel, null);
	}

	// Token: 0x06014DD5 RID: 85461 RVA: 0x0054BB8C File Offset: 0x00549D8C
	public void CloseAndOpenRoleViewByViewModel(EUiViewName closeViewName, EUiViewName openViewName, RoleViewViewModel viewModel)
	{
		if (!this.CheckRoleCanOpenView(viewModel.RoleId, openViewName))
		{
			return;
		}
		UiManager.Instance.CloseAndOpenView(closeViewName, openViewName, viewModel, null, true);
	}

	// Token: 0x06014DD6 RID: 85462 RVA: 0x0054BBB0 File Offset: 0x00549DB0
	private bool CheckRoleCanOpenView(int roleId, EUiViewName viewName)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleId);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (roleInstanceById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LRC;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("角色不存在: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(roleId);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		RoleLevelData levelData = roleInstanceById.GetLevelData();
		bool roleNeedBreakUp = levelData.GetRoleNeedBreakUp();
		bool result = !roleNeedBreakUp && !levelData.GetRoleIsMaxLevel();
		if (viewName == EUiViewName.RoleLevelUpView)
		{
			return result;
		}
		if (viewName == EUiViewName.RoleBreachView)
		{
			return roleNeedBreakUp;
		}
		if (viewName == EUiViewName.RoleBreachSuccessView || viewName == EUiViewName.WeaponReplaceView)
		{
			return true;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Role;
		ELogAuthor author2 = ELogAuthor.LRC;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
		defaultInterpolatedStringHandler.AppendLiteral("无法通过该接口打开界面: ");
		defaultInterpolatedStringHandler.AppendFormatted<EUiViewName>(viewName);
		instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}

	// Token: 0x06014DD7 RID: 85463 RVA: 0x0054BCA0 File Offset: 0x00549EA0
	[NullableContext(2)]
	public void CloseAndOpenRoleMainView(EUiViewName closeViewName, ERoleAgentType agentType, int selectRoleId = 0, List<int> roleIdList = null, EUiTabViewName? openTabView = null, Action<bool> finishCallback = null)
	{
		if (roleIdList == null)
		{
			roleIdList = new List<int>();
		}
		RoleViewAgent roleViewAgent = RoleModel.Instance.GetRoleViewAgent(agentType);
		roleViewAgent.Init(roleIdList, selectRoleId, openTabView, ERoleViewSource.Normal);
		UiManager.Instance.CloseAndOpenView(closeViewName, EUiViewName.RoleRootView, roleViewAgent, finishCallback, true);
	}

	// Token: 0x06014DD8 RID: 85464 RVA: 0x0054BCE4 File Offset: 0x00549EE4
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoleRootView, new Func<EUiViewName, object, bool>(this.CanOpenView), "RoleController.CanOpenView");
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoleDevelopRootView, new Func<EUiViewName, object, bool>(this.CanOpenRoleDevelopView), "RoleController.CanOpenRoleDevelopView");
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoleDevelopSelectTargetView, new Func<EUiViewName, object, bool>(this.CanOpenRoleDevelopView), "RoleController.CanOpenRoleDevelopSelectTargetView");
	}

	// Token: 0x06014DD9 RID: 85465 RVA: 0x0054BD54 File Offset: 0x00549F54
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoleRootView, new Func<EUiViewName, object, bool>(this.CanOpenView));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoleDevelopRootView, new Func<EUiViewName, object, bool>(this.CanOpenRoleDevelopView));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoleDevelopSelectTargetView, new Func<EUiViewName, object, bool>(this.CanOpenRoleDevelopView));
	}

	// Token: 0x06014DDA RID: 85466 RVA: 0x0054BDB4 File Offset: 0x00549FB4
	public bool CheckCharacterInBattleTag(bool useIgnoreList = false)
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		return (!useIgnoreList || !RoleController.IsInIgnoreBattleTagInst()) && baseCharacter != null && baseCharacter.CharacterActorComponent.Entity.CheckGetComponent<BaseTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]);
	}

	// Token: 0x06014DDB RID: 85467 RVA: 0x0054BDFC File Offset: 0x00549FFC
	private unsafe static bool IsInIgnoreBattleTagInst()
	{
		IReadOnlyList<int> readOnlyList = ConfigCommonParamById.GetIntArrayConfig("IgnoreInBattleTagInstSubTypeList") ?? Array.Empty<int>();
		int instanceId = CreatureModel.Instance.GetInstanceId();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Role;
		ELogAuthor author = ELogAuthor.TZJ;
		string message = "检查无视战斗状态的副本列表";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ignoreList", readOnlyList);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("id", instanceId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (instanceId == 0)
		{
			return true;
		}
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config != null && readOnlyList.Contains(config.Value.InstSubType);
	}

	// Token: 0x06014DDC RID: 85468 RVA: 0x0054BEB2 File Offset: 0x0054A0B2
	public bool CheckCharacterInBattleTagAndShowTips(bool useIgnoreList = false)
	{
		if (RoleController.Instance.CheckCharacterInBattleTag(useIgnoreList))
		{
			ScrollingTipsController.Instance.ShowTipsById("ForbiddenActionInFight", Array.Empty<object>());
			return true;
		}
		return false;
	}

	// Token: 0x06014DDD RID: 85469 RVA: 0x0054BED8 File Offset: 0x0054A0D8
	public void OnSelectedRoleChange(int roleId, int roleSkinId)
	{
		TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		this.RefreshUiSceneRoleActor(roleSystemRoleActor, roleId, roleSkinId, null);
		EventSystem.Instance.Emit(EEventName.OnSelectedRoleChanged);
	}

	// Token: 0x06014DDE RID: 85470 RVA: 0x0054BF0C File Offset: 0x0054A10C
	public void SetRoleMorphType(TsUiSceneRoleActor roleActor, EUiModelMorphType morphType)
	{
		UiModelBase model = roleActor.Model;
		UiRoleMorphComponent uiRoleMorphComponent = (model != null) ? model.GetComponent<UiRoleMorphComponent>() : null;
		if (uiRoleMorphComponent != null && uiRoleMorphComponent.SetMorphType(morphType))
		{
			EventSystem.Instance.Emit(EEventName.OnRoleMorphTypeChanged);
		}
	}

	// Token: 0x06014DDF RID: 85471 RVA: 0x0054BF48 File Offset: 0x0054A148
	public UniTask RefreshUiSceneRoleActorAsync(TsUiSceneRoleActor roleActor, int roleId, int roleSkinId, Action callback = null)
	{
		RoleController.<RefreshUiSceneRoleActorAsync>d__17 <RefreshUiSceneRoleActorAsync>d__;
		<RefreshUiSceneRoleActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshUiSceneRoleActorAsync>d__.<>4__this = this;
		<RefreshUiSceneRoleActorAsync>d__.roleActor = roleActor;
		<RefreshUiSceneRoleActorAsync>d__.roleId = roleId;
		<RefreshUiSceneRoleActorAsync>d__.roleSkinId = roleSkinId;
		<RefreshUiSceneRoleActorAsync>d__.callback = callback;
		<RefreshUiSceneRoleActorAsync>d__.<>1__state = -1;
		<RefreshUiSceneRoleActorAsync>d__.<>t__builder.Start<RoleController.<RefreshUiSceneRoleActorAsync>d__17>(ref <RefreshUiSceneRoleActorAsync>d__);
		return <RefreshUiSceneRoleActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014DE0 RID: 85472 RVA: 0x0054BFAC File Offset: 0x0054A1AC
	public void RefreshUiSceneRoleActor(TsUiSceneRoleActor roleActor, int roleId, int roleSkinId, Action callback = null)
	{
		UiModelBase model = roleActor.Model;
		UiRoleDataComponent uiRoleDataComponent = (model != null) ? model.CheckGetComponent<UiRoleDataComponent>() : null;
		if (uiRoleDataComponent != null && uiRoleDataComponent.RoleDataId == roleId && uiRoleDataComponent != null && uiRoleDataComponent.RoleSkinId == roleSkinId)
		{
			return;
		}
		Action loadFinishCallBack = delegate()
		{
			Action callback2 = callback;
			if (callback2 != null)
			{
				callback2();
			}
			UiRoleUtils.PlayRoleChangeEffect(roleActor);
		};
		UiModelBase model2 = roleActor.Model;
		UiRoleLoadComponent uiRoleLoadComponent = (model2 != null) ? model2.CheckGetComponent<UiRoleLoadComponent>() : null;
		if (uiRoleLoadComponent != null)
		{
			uiRoleLoadComponent.LoadModelByRoleDataId(roleId, roleSkinId, true, loadFinishCallBack);
		}
		if (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("BP_UIShowRoom").Value, ECollectActorType.UI) is BP_UIShowRoom_C)
		{
			UiSceneManager.Instance.AddUiShowRoomShowActor(roleActor, true);
		}
	}

	// Token: 0x06014DE1 RID: 85473 RVA: 0x0054C062 File Offset: 0x0054A262
	public void OnSelectedRoleChangeByConfig(int roleId, int skinId, Action callback = null)
	{
		this.RefreshUiSceneRoleActorByConfigId(roleId, skinId, callback);
		EventSystem.Instance.Emit(EEventName.OnSelectedRoleChanged);
	}

	// Token: 0x06014DE2 RID: 85474 RVA: 0x0054C080 File Offset: 0x0054A280
	public void RefreshUiSceneRoleActorByConfigId(int roleId, int skinId, Action callback = null)
	{
		TsUiSceneRoleActor uiSceneRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		UiModelBase model = uiSceneRoleActor.Model;
		UiRoleDataComponent uiRoleDataComponent = (model != null) ? model.CheckGetComponent<UiRoleDataComponent>() : null;
		if (uiRoleDataComponent != null && uiRoleDataComponent.RoleConfigId == roleId)
		{
			return;
		}
		Action loadFinishCallBack = delegate()
		{
			Action callback2 = callback;
			if (callback2 != null)
			{
				callback2();
			}
			UiRoleUtils.PlayRoleChangeEffect(uiSceneRoleActor);
		};
		UiModelBase model2 = uiSceneRoleActor.Model;
		UiRoleLoadComponent uiRoleLoadComponent = (model2 != null) ? model2.CheckGetComponent<UiRoleLoadComponent>() : null;
		if (uiRoleLoadComponent != null)
		{
			uiRoleLoadComponent.LoadModelByRoleConfigId(roleId, skinId, true, loadFinishCallBack);
		}
		UiSceneManager.Instance.AddUiShowRoomShowActor(uiSceneRoleActor, true);
	}

	// Token: 0x06014DE3 RID: 85475 RVA: 0x0054C118 File Offset: 0x0054A318
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<TsUiSceneRoleActor> LoadUiSceneRoleActorByConfigIdAsync(EUiModelUseWay uiModelUseWay, int roleId, int skinId)
	{
		RoleController.<LoadUiSceneRoleActorByConfigIdAsync>d__21 <LoadUiSceneRoleActorByConfigIdAsync>d__;
		<LoadUiSceneRoleActorByConfigIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<TsUiSceneRoleActor>.Create();
		<LoadUiSceneRoleActorByConfigIdAsync>d__.uiModelUseWay = uiModelUseWay;
		<LoadUiSceneRoleActorByConfigIdAsync>d__.roleId = roleId;
		<LoadUiSceneRoleActorByConfigIdAsync>d__.skinId = skinId;
		<LoadUiSceneRoleActorByConfigIdAsync>d__.<>1__state = -1;
		<LoadUiSceneRoleActorByConfigIdAsync>d__.<>t__builder.Start<RoleController.<LoadUiSceneRoleActorByConfigIdAsync>d__21>(ref <LoadUiSceneRoleActorByConfigIdAsync>d__);
		return <LoadUiSceneRoleActorByConfigIdAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014DE4 RID: 85476 RVA: 0x0054C16C File Offset: 0x0054A36C
	public void ShowUiSceneActorAndShadow(bool isShow)
	{
		TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		UiModelBase uiModelBase = (roleSystemRoleActor != null) ? roleSystemRoleActor.Model : null;
		if (uiModelBase != null)
		{
			UiModelUtil.Instance.SetVisible(uiModelBase, true);
		}
		BP_UIShowRoom_C bp_UIShowRoom_C = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("BP_UIShowRoom").Value, ECollectActorType.UI) as BP_UIShowRoom_C;
		if (bp_UIShowRoom_C != null)
		{
			bp_UIShowRoom_C.SetActorHiddenInGame(!isShow);
		}
	}

	// Token: 0x06014DE5 RID: 85477 RVA: 0x0054C1CC File Offset: 0x0054A3CC
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.RedDotStart, new Action(this.OnRedDotStartEvent));
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.ResetRoleTrialState));
		EventSystem.Instance.Add(EEventName.TextLanguageChange, new Action<string, string>(this.OnTextLanguageChange));
		EventSystem.Instance.Add(EEventName.OnResponseCommonItemFinished, new Action(this.OnResponseCommonItemFinished));
	}

	// Token: 0x06014DE6 RID: 85478 RVA: 0x0054C268 File Offset: 0x0054A468
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.RedDotStart, new Action(this.OnRedDotStartEvent));
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.ResetRoleTrialState));
		EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnTextLanguageChange));
		EventSystem.Instance.Remove(EEventName.OnResponseCommonItemFinished, new Action(this.OnResponseCommonItemFinished));
	}

	// Token: 0x06014DE7 RID: 85479 RVA: 0x0054C301 File Offset: 0x0054A501
	private void OnLoadingNetDataDone()
	{
		this.SendRoleFavorListRequest();
		this.RequestRoleDevelopDependentData().Forget();
	}

	// Token: 0x06014DE8 RID: 85480 RVA: 0x0054C314 File Offset: 0x0054A514
	private void OnResponseCommonItemFinished()
	{
		RoleOrnamentModel instance = RoleOrnamentModel.Instance;
		instance.SetCommonItemFinished();
		int[] array = instance.TakePendingOrnamentIdsForInit();
		if (array != null)
		{
			InventoryController.Instance.InitOrnamentItemData(array);
		}
		List<int[]> list = instance.TakeAllPendingOrnamentUnlockBatches();
		foreach (int[] ids in list)
		{
			RoleController.ProcessOrnamentUnlock(ids);
		}
		int count = list.Count;
	}

	// Token: 0x06014DE9 RID: 85481 RVA: 0x0054C390 File Offset: 0x0054A590
	private void OnRedDotStartEvent()
	{
		foreach (int p in RoleModel.Instance.GetRoleIdList())
		{
			EventSystem.Instance.Emit<int>(EEventName.RedDotCreateRole, p);
		}
	}

	// Token: 0x06014DEA RID: 85482 RVA: 0x0054C3F4 File Offset: 0x0054A5F4
	private void ResetRoleTrialState()
	{
		if (!RoleModel.Instance.IsInRoleTrial)
		{
			return;
		}
		Log.Instance.Info(ELogModule.Role, ELogAuthor.XXJ, "切换地图,重置进入试用角色状态", default(ReadOnlySpan<ValueTuple<string, object>>));
		RoleModel.Instance.RoleTrialIdList.Clear();
		RoleModel.Instance.RoleTrialShowMap.Clear();
		RoleModel.Instance.IsInRoleTrial = false;
	}

	// Token: 0x06014DEB RID: 85483 RVA: 0x0054C454 File Offset: 0x0054A654
	private void OnTextLanguageChange(string oldLang, string newLang)
	{
		Dictionary<int, RoleInstance> roleMap = RoleModel.Instance.GetRoleMap();
		Dictionary<int, RoleRobotData> roleRobotMap = RoleModel.Instance.GetRoleRobotMap();
		foreach (KeyValuePair<int, RoleInstance> keyValuePair in roleMap)
		{
			RoleInstance value = keyValuePair.Value;
			if (!PlayerInfoModel.Instance.IsPlayerId(value.GetRoleId(), null))
			{
				RoleInfo roleConfig = value.GetRoleConfig();
				string roleName = RoleConfig.Instance.GetRoleName(roleConfig.Name);
				value.SetRoleName(roleName);
			}
		}
		foreach (KeyValuePair<int, RoleRobotData> keyValuePair2 in roleRobotMap)
		{
			RoleRobotData value2 = keyValuePair2.Value;
			RoleInfo roleConfig2 = value2.GetRoleConfig();
			string roleName2 = RoleConfig.Instance.GetRoleName(roleConfig2.Name);
			value2.SetName(roleName2);
		}
	}

	// Token: 0x06014DEC RID: 85484 RVA: 0x0054C558 File Offset: 0x0054A758
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PbGetRoleListNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PbGetRoleListNotify pbGetRoleListNotify = (PbGetRoleListNotify)msg;
			RoleModel.Instance.UpdateRoleInfoByServerData(pbGetRoleListNotify.RoleList.ToArray<roleInfo>());
		});
		Net.Instance.Register(ENotifyMessageId.PbRolePropsNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PbRolePropsNotify pbRolePropsNotify = (PbRolePropsNotify)msg;
			RoleModel.Instance.RoleAttrUpdate(pbRolePropsNotify.RoleId, pbRolePropsNotify.BaseProp.ToArray<ArrayIntInt>(), pbRolePropsNotify.AddProp.ToArray<ArrayIntInt>());
		});
		Net.Instance.Register(ENotifyMessageId.PbRoleActiveNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PbRoleActiveNotify pbRoleActiveNotify = (PbRoleActiveNotify)msg;
			int roleId = pbRoleActiveNotify.Role.RoleId;
			RoleModel.Instance.UpdateRoleInfo(pbRoleActiveNotify.Role);
			NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.RoleDataItem, roleId);
			NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.PersonalDataItem, roleId);
			PersonalModel.Instance.SetPersonalTipState(true);
			EventSystem.Instance.Emit(EEventName.RoleSelectionListUpdate);
			EventSystem.Instance.Emit<int>(EEventName.ActiveRole, roleId);
		});
		Net.Instance.Register(ENotifyMessageId.PbRoleExpNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PbRoleExpNotify pbRoleExpNotify = (PbRoleExpNotify)msg;
			RoleModel.Instance.RoleLevelUp(pbRoleExpNotify.RoleId, pbRoleExpNotify.Exp, pbRoleExpNotify.Level);
		});
		Net.Instance.Register(ENotifyMessageId.PbRoleResonLockFinishNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PbRoleResonLockFinishNotify pbRoleResonLockFinishNotify = (PbRoleResonLockFinishNotify)msg;
			if (pbRoleResonLockFinishNotify != null)
			{
				RoleModel.Instance.RoleResonanceLockFinish(pbRoleResonLockFinishNotify);
			}
		});
		Net.Instance.Register(ENotifyMessageId.PbRoleSkillLevelNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PbRoleSkillLevelNotify pbRoleSkillLevelNotify = (PbRoleSkillLevelNotify)msg;
			if (pbRoleSkillLevelNotify != null)
			{
				RoleModel.Instance.RoleSkillLevelUp(pbRoleSkillLevelNotify.RoleId, pbRoleSkillLevelNotify.SkillInfo);
			}
		});
		Net.Instance.Register(ENotifyMessageId.RoleChangeNameNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleChangeNameNotify roleChangeNameNotify = (RoleChangeNameNotify)msg;
			if (roleChangeNameNotify != null)
			{
				RoleModel.Instance.RoleNameUpdate(roleChangeNameNotify.RoleId, roleChangeNameNotify.Name);
			}
		});
		Net.Instance.Register(ENotifyMessageId.RoleTrialOpenNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleTrialOpenNotify roleTrialOpenNotify = (RoleTrialOpenNotify)msg;
			if (roleTrialOpenNotify.ShowTips && !RoleModel.Instance.IsInRoleTrial && !PlotModel.Instance.InSeamlessFormation && !PlotModel.Instance.InDigitalScreen && GameModeModel.Instance.WorldDone)
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleAdd", Array.Empty<object>());
			}
			TeleportModel.Instance.SetAllowTeleportByUi(roleTrialOpenNotify.EnableMapAndTeleport, "TrialRole");
			InstanceDungeonController.Instance.UpdateTrialRoleDungeonWhiteList(roleTrialOpenNotify.CanEnterDungeonList.ToArray<int>());
			RoleModel.Instance.RoleTrialIdList.Clear();
			RoleModel.Instance.RoleTrialShowMap.Clear();
			foreach (TrialRoleItem trialRoleItem in roleTrialOpenNotify.TrialRoleItems)
			{
				RoleModel.Instance.RoleTrialIdList.Add(trialRoleItem.RoleId);
				RoleModel.Instance.RoleTrialShowMap[trialRoleItem.RoleId] = trialRoleItem.Show;
			}
			if (!RoleModel.Instance.IsInRoleTrial && RoleModel.Instance.RoleTrialIdList.Count > 0)
			{
				RoleModel.Instance.IsInRoleTrial = true;
				Log.Instance.Info(ELogModule.Role, ELogAuthor.XXJ, "进入角色试用状态", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		});
		Net.Instance.Register(ENotifyMessageId.RoleTrialCloseNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleTrialCloseNotify roleTrialCloseNotify = (RoleTrialCloseNotify)msg;
			if (roleTrialCloseNotify.ShowTips && RoleModel.Instance.IsInRoleTrial && !PlotModel.Instance.InSeamlessFormation && !PlotModel.Instance.InDigitalScreen && GameModeModel.Instance.WorldDone)
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleDetach", Array.Empty<object>());
			}
			TeleportModel.Instance.SetAllowTeleportByUi(roleTrialCloseNotify.EnableMapAndTeleport, "TrialRole");
			InstanceDungeonController.Instance.UpdateTrialRoleDungeonWhiteList(roleTrialCloseNotify.CanEnterDungeonList.ToArray<int>());
			RoleModel.Instance.RoleTrialIdList.Clear();
			foreach (int item in roleTrialCloseNotify.RoleIds)
			{
				RoleModel.Instance.RoleTrialIdList.Add(item);
			}
			foreach (int num in new List<int>(RoleModel.Instance.RoleTrialShowMap.Keys))
			{
				if (!RoleModel.Instance.RoleTrialIdList.Contains(num))
				{
					RoleModel.Instance.RoleTrialShowMap.Remove(num);
				}
			}
			if (RoleModel.Instance.IsInRoleTrial && RoleModel.Instance.RoleTrialIdList.Count <= 0)
			{
				RoleModel.Instance.IsInRoleTrial = false;
				Log.Instance.Info(ELogModule.Role, ELogAuthor.XXJ, "角色试用状态结束", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		});
		Net.Instance.Register(ENotifyMessageId.RoleSkillNodeNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleSkillNodeNotify roleSkillNodeNotify = (RoleSkillNodeNotify)msg;
			if (roleSkillNodeNotify != null)
			{
				RoleModel.Instance.UpdateRoleSkillNodeData(roleSkillNodeNotify.RoleId, roleSkillNodeNotify.SkillNodeState.ToArray<ArraySkillNode>());
			}
		});
		Net.Instance.Register(ENotifyMessageId.RoleFavorListNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleFavorListNotify roleFavorListNotify = (RoleFavorListNotify)msg;
			if (roleFavorListNotify != null)
			{
				Dictionary<int, ConditionInfo> dictionary = new Dictionary<int, ConditionInfo>();
				MapField<int, ConditionInfo> roleConditionInfoMap = roleFavorListNotify.RoleConditionInfoMap;
				foreach (int num in roleConditionInfoMap.Keys)
				{
					int key = num;
					dictionary[key] = roleConditionInfoMap[num];
				}
				RoleModel.Instance.UpdateRoleFavorCondition(dictionary);
				RoleModel.Instance.UpdateRoleFavorData(roleFavorListNotify.FavorList.ToArray<RoleFavor>());
			}
		});
		Net.Instance.Register(ENotifyMessageId.RoleFavorActiveNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleFavorActiveNotify roleFavorActiveNotify = (RoleFavorActiveNotify)msg;
			if (roleFavorActiveNotify != null)
			{
				RoleModel.Instance.UpdateRoleFavorDataSingle(roleFavorActiveNotify.RoleFavorInfo);
			}
		});
		Net.Instance.Register(ENotifyMessageId.RoleFavorExpTipsNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleFavorExpTipsNotify roleFavorExpTipsNotify = (RoleFavorExpTipsNotify)msg;
			if (roleFavorExpTipsNotify != null)
			{
				EventSystem.Instance.Emit<TItem>(EEventName.OnAddFavorItem, new TItem
				{
					ItemData = new InventoryDefine.GetItemData(roleFavorExpTipsNotify.ItemId, 0),
					Count = roleFavorExpTipsNotify.Count
				});
			}
		});
		Net.Instance.Register(ENotifyMessageId.RoleFavorFinishConditionNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleFavorFinishConditionNotify roleFavorFinishConditionNotify = (RoleFavorFinishConditionNotify)msg;
			if (roleFavorFinishConditionNotify != null)
			{
				Dictionary<int, ConditionInfo> dictionary = new Dictionary<int, ConditionInfo>();
				MapField<int, ConditionInfo> roleConditionInfoMap = roleFavorFinishConditionNotify.RoleConditionInfoMap;
				foreach (int num in roleConditionInfoMap.Keys)
				{
					int key = num;
					dictionary[key] = roleConditionInfoMap[num];
				}
				RoleModel.Instance.UpdateRoleFavorCondition(dictionary);
			}
		});
		Net.Instance.Register(ENotifyMessageId.RoleFavorNewCanUnLockNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleFavorNewCanUnLockNotify roleFavorNewCanUnLockNotify = (RoleFavorNewCanUnLockNotify)msg;
			if (roleFavorNewCanUnLockNotify != null)
			{
				RoleModel.Instance.UpdateRoleFavorNewCanUnLockId(roleFavorNewCanUnLockNotify);
			}
		});
		Net.Instance.Register(ENotifyMessageId.RoleFavorLevelUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleFavorLevelUpdateNotify roleFavorLevelUpdateNotify = (RoleFavorLevelUpdateNotify)msg;
			if (roleFavorLevelUpdateNotify != null)
			{
				RoleModel.Instance.UpdateRoleFavorLevelAndExp(roleFavorLevelUpdateNotify);
			}
		});
		Net.Instance.Register(ENotifyMessageId.RoleSkinChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleSkinChangeNotify));
		Net.Instance.Register(ENotifyMessageId.RoleConfigInfoNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			foreach (RoleConfigInfo roleConfigInfo in ((RoleConfigInfoNotify)msg).RoleConfigs)
			{
				this.UpdateRoleSkillBranch(roleConfigInfo.RoleId, roleConfigInfo.SkillBranch, false);
			}
		});
		Net.Instance.Register(ENotifyMessageId.RoleConfigInfoUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			foreach (RoleConfigInfo roleConfigInfo in ((RoleConfigInfoUpdateNotify)msg).RoleConfigs)
			{
				this.UpdateRoleSkillBranch(roleConfigInfo.RoleId, roleConfigInfo.SkillBranch, true);
			}
		});
		Net.Instance.Register(ENotifyMessageId.RoleUpdateDevelopTargetNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleUpdateDevelopTargetNotify));
		Net.Instance.Register(ENotifyMessageId.RoleDevelopConfigUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleDevelopConfigUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.OrnamentInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnOrnamentInfoNotify));
		Net.Instance.Register(ENotifyMessageId.OrnamentUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnOrnamentUnlockNotify));
		Net.Instance.Register(ENotifyMessageId.EntityDressOrnamentChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnEntityDressOrnamentChangeNotify));
		Net.Instance.Register(ENotifyMessageId.OrnamentDressInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnOrnamentDressInfoUpdateNotify));
	}

	// Token: 0x06014DED RID: 85485 RVA: 0x0054C954 File Offset: 0x0054AB54
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PbGetRoleListNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PbRolePropsNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PbRoleActiveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PbRoleExpNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PbRoleResonLockFinishNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PbRoleSkillLevelNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleChangeNameNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTrialOpenNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTrialCloseNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleSkillNodeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleFavorListNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleFavorActiveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleFavorExpTipsNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleFavorNewCanUnLockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleFavorLevelUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleSkinChangeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleConfigInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleConfigInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.OrnamentInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.OrnamentUnlockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.EntityDressOrnamentChangeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.OrnamentDressInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleUpdateDevelopTargetNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleDevelopConfigUpdateNotify);
	}

	// Token: 0x06014DEE RID: 85486 RVA: 0x0054CAE1 File Offset: 0x0054ACE1
	public bool IsInRoleTrial()
	{
		return RoleModel.Instance.IsInRoleTrial;
	}

	// Token: 0x06014DEF RID: 85487 RVA: 0x0054CAF0 File Offset: 0x0054ACF0
	public void SendPbUpLevelRoleRequest(int roleId, ArrayIntInt[] itemList, Action successCallback)
	{
		if (itemList == null || itemList.Length == 0)
		{
			return;
		}
		PbUpLevelRoleRequest pbUpLevelRoleRequest = PbUpLevelRoleRequest.Create();
		pbUpLevelRoleRequest.RoleId = roleId;
		pbUpLevelRoleRequest.ItemList.Add(itemList);
		Net.Instance.Call(ERequestMessageId.PbUpLevelRoleRequest, pbUpLevelRoleRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PbUpLevelRoleResponse pbUpLevelRoleResponse = (PbUpLevelRoleResponse)msg;
			if (pbUpLevelRoleResponse == null)
			{
				return;
			}
			if (pbUpLevelRoleResponse.Code == Aki.Protocol.ErrorCode.Success)
			{
				RoleModel.Instance.RoleLevelUpReceiveItem(pbUpLevelRoleResponse.ItemMap.ToDictionary<int, int>());
				RoleModel.Instance.RoleLevelUp(pbUpLevelRoleResponse.RoleId, pbUpLevelRoleResponse.Exp, pbUpLevelRoleResponse.Level);
				successCallback();
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(pbUpLevelRoleResponse.Code, EResponseMessageId.PbUpLevelRoleResponse, null, true, true);
		}, 0);
	}

	// Token: 0x06014DF0 RID: 85488 RVA: 0x0054CB48 File Offset: 0x0054AD48
	public void SendPbOverRoleRequest(int roleId)
	{
		PbOverRoleRequest pbOverRoleRequest = PbOverRoleRequest.Create();
		pbOverRoleRequest.RoleId = roleId;
		Net.Instance.Call(ERequestMessageId.PbOverRoleRequest, pbOverRoleRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PbOverRoleResponse pbOverRoleResponse = (PbOverRoleResponse)msg;
			if (pbOverRoleResponse == null)
			{
				return;
			}
			if (pbOverRoleResponse.Code == Aki.Protocol.ErrorCode.Success)
			{
				RoleModel.Instance.RoleBreakUp(pbOverRoleResponse.RoleId, pbOverRoleResponse.Breakthrough);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(pbOverRoleResponse.Code, EResponseMessageId.PbOverRoleResponse, null, true, true);
		}, 0);
	}

	// Token: 0x06014DF1 RID: 85489 RVA: 0x0054CB94 File Offset: 0x0054AD94
	public void SendPbUpLevelSkillRequest(int roleId, int skillNodeId)
	{
		if (RoleController.Instance.CheckCharacterInBattleTagAndShowTips(false))
		{
			return;
		}
		if (RoleModel.Instance.GetRoleInstanceById(roleId).IsTrialRole())
		{
			return;
		}
		PbUpLevelSkillRequest pbUpLevelSkillRequest = PbUpLevelSkillRequest.Create();
		pbUpLevelSkillRequest.RoleId = roleId;
		pbUpLevelSkillRequest.SkillId = RoleSkillConfig.Instance.GetSkillTreeNode(skillNodeId).Value.SkillId;
		int lastLevel = RoleModel.Instance.GetRoleSkillTreeNodeLevel(roleId, skillNodeId);
		Net.Instance.Call(ERequestMessageId.PbUpLevelSkillRequest, pbUpLevelSkillRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PbUpLevelSkillResponse pbUpLevelSkillResponse = (PbUpLevelSkillResponse)msg;
			if (pbUpLevelSkillResponse == null)
			{
				return;
			}
			if (pbUpLevelSkillResponse.Code == Aki.Protocol.ErrorCode.Success)
			{
				RoleController.ShowSkillTreeLevelUpSuccessView(skillNodeId, lastLevel, roleId, null);
				RoleModel.Instance.RoleSkillLevelUp(pbUpLevelSkillResponse.RoleId, pbUpLevelSkillResponse.SkillInfo);
				EventSystem.Instance.Emit<int>(EEventName.SkillTreeNodeLevelUp, skillNodeId);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(pbUpLevelSkillResponse.Code, EResponseMessageId.PbUpLevelSkillResponse, null, true, true);
		}, 0);
	}

	// Token: 0x06014DF2 RID: 85490 RVA: 0x0054CC4C File Offset: 0x0054AE4C
	public static void SendRoleSkillQuickLevelUpRequest(int roleId, int skillNodeId, int targetLevel)
	{
		if (RoleController.Instance.CheckCharacterInBattleTagAndShowTips(false))
		{
			return;
		}
		if (RoleUtils.IsTrialRole(roleId))
		{
			return;
		}
		RoleSkillQuickLevelUpRequest roleSkillQuickLevelUpRequest = RoleSkillQuickLevelUpRequest.Create();
		roleSkillQuickLevelUpRequest.RoleId = roleId;
		roleSkillQuickLevelUpRequest.SkillId = RoleSkillConfig.Instance.GetSkillTreeNode(skillNodeId).Value.SkillId;
		roleSkillQuickLevelUpRequest.TargetLevel = targetLevel;
		int lastLevel = RoleModel.Instance.GetRoleSkillTreeNodeLevel(roleId, skillNodeId);
		Net.Instance.Call(ERequestMessageId.RoleSkillQuickLevelUpRequest, roleSkillQuickLevelUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleSkillQuickLevelUpResponse roleSkillQuickLevelUpResponse = (RoleSkillQuickLevelUpResponse)msg;
			if (roleSkillQuickLevelUpResponse == null)
			{
				return;
			}
			if (roleSkillQuickLevelUpResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				RoleController.ShowSkillTreeLevelUpSuccessView(skillNodeId, lastLevel, roleId, new int?(targetLevel));
				if (roleSkillQuickLevelUpResponse.RoleInfo != null)
				{
					RoleModel.Instance.UpdateRoleInfo(roleSkillQuickLevelUpResponse.RoleInfo);
				}
				EventSystem.Instance.Emit<int>(EEventName.SkillTreeNodeLevelUp, skillNodeId);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(roleSkillQuickLevelUpResponse.ErrorCode, EResponseMessageId.RoleSkillQuickLevelUpResponse, null, true, true);
		}, 0);
	}

	// Token: 0x06014DF3 RID: 85491 RVA: 0x0054CD10 File Offset: 0x0054AF10
	public void SendResonanceUnlockRequest(int roleId)
	{
		if (this.CheckCharacterInBattleTagAndShowTips(false))
		{
			return;
		}
		RoleInstance roleInstance = RoleModel.Instance.GetRoleInstanceById(roleId);
		if (roleInstance.IsTrialRole())
		{
			return;
		}
		ResonantChainUnlockRequest resonantChainUnlockRequest = ResonantChainUnlockRequest.Create();
		resonantChainUnlockRequest.RoleId = roleId;
		Net.Instance.Call(ERequestMessageId.ResonantChainUnlockRequest, resonantChainUnlockRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ResonantChainUnlockResponse resonantChainUnlockResponse = (ResonantChainUnlockResponse)msg;
			if (resonantChainUnlockResponse == null)
			{
				return;
			}
			if (resonantChainUnlockResponse.ErrCode == Aki.Protocol.ErrorCode.Success)
			{
				roleInstance.GetResonanceData().SetResonantChainGroupIndex(resonantChainUnlockResponse.ResonantChainGroupIndex);
				int index = resonantChainUnlockResponse.ResonantChainGroupIndex - 1;
				List<ResonantChain> roleResonanceConfigList = RoleModel.Instance.GetRoleResonanceConfigList(roleInstance);
				LevelUpSuccessEffectData data = new LevelUpSuccessEffectData
				{
					Title = "Text_ResonanceUnlockSuccess_Text",
					TextList = new List<SingleText>
					{
						new SingleText
						{
							TextId = roleResonanceConfigList[index].AttributesDescription,
							Params = roleResonanceConfigList[index].AttributesDescriptionParams()
						}
					}
				};
				RoleLevelUpSuccessController.Instance.OpenSuccessEffectView(data, null);
				EventSystem.Instance.Emit(EEventName.UpdateRoleResonanceDetailView);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(resonantChainUnlockResponse.ErrCode, EResponseMessageId.ResonantChainUnlockResponse, null, true, true);
		}, 0);
	}

	// Token: 0x06014DF4 RID: 85492 RVA: 0x0054CD78 File Offset: 0x0054AF78
	public void SendRoleSkillViewRequest(int roleId, int skillId, Action callBack = null)
	{
		if (RoleModel.Instance.GetRoleInstanceById(roleId) == null)
		{
			RoleModel.Instance.GetRoleDataById(roleId, true);
		}
		global::SkillEffect curRoleSkillViewDataLocal = RoleModel.Instance.GetCurRoleSkillViewDataLocal(roleId, skillId);
		global::SkillEffect nextRoleSkillViewDataLocal = RoleModel.Instance.GetNextRoleSkillViewDataLocal(roleId, skillId);
		RoleModel.Instance.UpdateRoleSkillViewData(curRoleSkillViewDataLocal, nextRoleSkillViewDataLocal, skillId);
		if (callBack != null)
		{
			callBack();
		}
	}

	// Token: 0x06014DF5 RID: 85493 RVA: 0x0054CDCF File Offset: 0x0054AFCF
	public void OpenTeamRoleSelectView(TeamRoleSelectViewData data)
	{
		UiManager.Instance.OpenView(EUiViewName.TeamRoleSelectView, data, null);
	}

	// Token: 0x06014DF6 RID: 85494 RVA: 0x0054CDE2 File Offset: 0x0054AFE2
	public void PlayRoleMontage(EPerformanceRoleState roleState, bool reLoop = false, bool reLoopFromLoopToStart = false, bool waitLaseStateEnd = false)
	{
		TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		object obj;
		if (roleSystemRoleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = roleSystemRoleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiRoleStateMachineComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.SetState(roleState, reLoop, reLoopFromLoopToStart, waitLaseStateEnd);
	}

	// Token: 0x06014DF7 RID: 85495 RVA: 0x0054CE15 File Offset: 0x0054B015
	public void SetInstantAttributeBlend(bool instantAttributeBlend)
	{
		TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		object obj;
		if (roleSystemRoleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = roleSystemRoleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiRoleStateMachineComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.SetInstantAttributeBlend(instantAttributeBlend);
	}

	// Token: 0x06014DF8 RID: 85496 RVA: 0x0054CE44 File Offset: 0x0054B044
	public void SendRoleActivateSkillRequest(int roleId, int skillNodeId)
	{
		if (this.CheckCharacterInBattleTagAndShowTips(false))
		{
			return;
		}
		if (RoleModel.Instance.GetRoleInstanceById(roleId).IsTrialRole())
		{
			return;
		}
		RoleActivateSkillRequest roleActivateSkillRequest = RoleActivateSkillRequest.Create();
		roleActivateSkillRequest.RoleId = roleId;
		roleActivateSkillRequest.SkillNodeId = skillNodeId;
		Net.Instance.Call(ERequestMessageId.RoleActivateSkillRequest, roleActivateSkillRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleActivateSkillResponse roleActivateSkillResponse = (RoleActivateSkillResponse)msg;
			if (roleActivateSkillResponse == null)
			{
				return;
			}
			if (roleActivateSkillResponse.Code == Aki.Protocol.ErrorCode.Success)
			{
				RoleController.ShowSkillTreeLevelUpSuccessView(skillNodeId, 0, roleId, null);
				EventSystem.Instance.Emit<int>(EEventName.SkillTreeNodeActive, skillNodeId);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(roleActivateSkillResponse.Code, EResponseMessageId.RoleActivateSkillResponse, null, true, true);
		}, 0);
	}

	// Token: 0x06014DF9 RID: 85497 RVA: 0x0054CEC4 File Offset: 0x0054B0C4
	public void SendRoleFavorListRequest()
	{
		RoleFavorListRequest message = RoleFavorListRequest.Create();
		Net.Instance.Call(ERequestMessageId.RoleFavorListRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleFavorListResponse roleFavorListResponse = (RoleFavorListResponse)msg;
			if (roleFavorListResponse == null)
			{
				return;
			}
			if (roleFavorListResponse.ErrCode == Aki.Protocol.ErrorCode.Success)
			{
				RoleModel.Instance.UpdateRoleFavorData(roleFavorListResponse.FavorList.ToArray<RoleFavor>());
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(roleFavorListResponse.ErrCode, EResponseMessageId.RoleFavorListResponse, null, true, true);
		}, 0);
	}

	// Token: 0x06014DFA RID: 85498 RVA: 0x0054CF08 File Offset: 0x0054B108
	public UniTask SendRoleFavorListRequestAsync()
	{
		RoleController.<SendRoleFavorListRequestAsync>d__44 <SendRoleFavorListRequestAsync>d__;
		<SendRoleFavorListRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SendRoleFavorListRequestAsync>d__.<>1__state = -1;
		<SendRoleFavorListRequestAsync>d__.<>t__builder.Start<RoleController.<SendRoleFavorListRequestAsync>d__44>(ref <SendRoleFavorListRequestAsync>d__);
		return <SendRoleFavorListRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014DFB RID: 85499 RVA: 0x0054CF44 File Offset: 0x0054B144
	public void SendRoleFavorUnLockRequest(FavorItemType favorItemType, int roleId, int unLockId)
	{
		RoleFavorUnLockRequest roleFavorUnLockRequest = RoleFavorUnLockRequest.Create();
		roleFavorUnLockRequest.ItemType = favorItemType;
		roleFavorUnLockRequest.RoleId = roleId;
		roleFavorUnLockRequest.UnLockId = unLockId;
		Net.Instance.Call(ERequestMessageId.RoleFavorUnLockRequest, roleFavorUnLockRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleFavorUnLockResponse roleFavorUnLockResponse = (RoleFavorUnLockResponse)msg;
			if (roleFavorUnLockResponse == null)
			{
				return;
			}
			RoleFavorData favorData = RoleModel.Instance.GetRoleInstanceById(roleFavorUnLockResponse.RoleId).GetFavorData();
			if (roleFavorUnLockResponse.ErrCode == Aki.Protocol.ErrorCode.Success)
			{
				favorData.UpdateUnlockId(roleFavorUnLockResponse.ItemType, roleId, roleFavorUnLockResponse.UnLockId);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(roleFavorUnLockResponse.ErrCode, EResponseMessageId.RoleFavorUnLockResponse, null, true, true);
		}, 0);
	}

	// Token: 0x06014DFC RID: 85500 RVA: 0x0054CF9B File Offset: 0x0054B19B
	public void SendRoleActiveRequest(int roleId)
	{
	}

	// Token: 0x06014DFD RID: 85501 RVA: 0x0054CFA0 File Offset: 0x0054B1A0
	public bool CheckRoleTargetLevel(int level)
	{
		RoleInstance[] allRoleList = RoleModel.Instance.GetAllRoleList();
		if (allRoleList == null)
		{
			return false;
		}
		int num = allRoleList.Length;
		for (int i = 0; i < num; i++)
		{
			RoleLevelData levelData = allRoleList[i].GetLevelData();
			if (levelData != null && levelData.GetLevel() > level)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06014DFE RID: 85502 RVA: 0x0054CFE8 File Offset: 0x0054B1E8
	public bool CheckRoleSkillTargetLevel(int level)
	{
		RoleInstance[] allRoleList = RoleModel.Instance.GetAllRoleList();
		if (allRoleList == null)
		{
			return false;
		}
		int num = allRoleList.Length;
		for (int i = 0; i < num; i++)
		{
			RoleSkillData skillData = allRoleList[i].GetSkillData();
			if (skillData != null)
			{
				int[] allSkillLevel = skillData.GetAllSkillLevel();
				int num2 = allSkillLevel.Length;
				for (int j = 0; j < num2; j++)
				{
					if (allSkillLevel[j] >= level)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06014DFF RID: 85503 RVA: 0x0054D04C File Offset: 0x0054B24C
	public static void ShowSkillTreeLevelUpSuccessView(int skillNodeId, int lastLevel, int roleDataId, int? targetLevel = null)
	{
		int nodeType = RoleSkillConfig.Instance.GetSkillTreeNode(skillNodeId).Value.NodeType;
		int value = targetLevel ?? (lastLevel + 1);
		switch (nodeType)
		{
		case 1:
			RoleController.Instance.ShowInnerSkillNodeLevelUpSuccessView(skillNodeId, lastLevel, new int?(value));
			return;
		case 2:
			RoleController.Instance.ShowInnerSkillNodeLevelUpSuccessView(skillNodeId, lastLevel, new int?(value));
			return;
		case 3:
			RoleController.Instance.ShowOuterSkillNodeLevelUpSuccessView(skillNodeId, roleDataId);
			return;
		case 4:
			RoleController.Instance.ShowAttributeNodeLevelUpSuccessView(skillNodeId);
			return;
		default:
			return;
		}
	}

	// Token: 0x06014E00 RID: 85504 RVA: 0x0054D0E8 File Offset: 0x0054B2E8
	public void ShowAttributeNodeLevelUpSuccessView(int skillNodeId)
	{
		SkillTree? skillTreeNode = RoleSkillConfig.Instance.GetSkillTreeNode(skillNodeId);
		LevelUpSuccessEffectData data = new LevelUpSuccessEffectData
		{
			Title = "Text_ResonanceUnlockSuccess_Text",
			TextList = new List<SingleText>
			{
				new SingleText
				{
					TextId = skillTreeNode.Value.PropertyNodeDescribe,
					Params = skillTreeNode.Value.PropertyNodeParam()
				}
			}
		};
		RoleLevelUpSuccessController.Instance.OpenSuccessEffectView(data, null);
	}

	// Token: 0x06014E01 RID: 85505 RVA: 0x0054D160 File Offset: 0x0054B360
	public void ShowOuterSkillNodeLevelUpSuccessView(int skillNodeId, int roleDataId)
	{
		int skillId = RoleSkillConfig.Instance.GetSkillTreeNode(skillNodeId).Value.SkillId;
		int upgradeSkillIdIfUpgraded = RoleModel.Instance.GetUpgradeSkillIdIfUpgraded(skillId, roleDataId);
		int skillId2 = (upgradeSkillIdIfUpgraded > 0) ? upgradeSkillIdIfUpgraded : skillId;
		Aki.Config.Skill? skillConfigById = RoleSkillConfig.Instance.GetSkillConfigById(skillId2);
		LevelUpSuccessEffectData data = new LevelUpSuccessEffectData
		{
			Title = "Text_ResonanceUnlockSuccess_Text",
			TextList = new List<SingleText>
			{
				new SingleText
				{
					TextId = skillConfigById.Value.SkillDescribe,
					Params = skillConfigById.Value.SkillDetailNum()
				}
			}
		};
		RoleLevelUpSuccessController.Instance.OpenSuccessEffectView(data, null);
	}

	// Token: 0x06014E02 RID: 85506 RVA: 0x0054D210 File Offset: 0x0054B410
	public void ShowInnerSkillNodeLevelUpSuccessView(int skillNodeId, int lastLevel, int? targetLevel = null)
	{
		List<IAttributeInfo> list = new List<IAttributeInfo>();
		int skillId = RoleSkillConfig.Instance.GetSkillTreeNode(skillNodeId).Value.SkillId;
		int maxSkillLevel = RoleSkillConfig.Instance.GetSkillConfigById(skillId).Value.MaxSkillLevel;
		int num = targetLevel ?? (lastLevel + 1);
		global::SkillEffect roleSkillEffect = RoleModel.Instance.GetRoleSkillEffect(skillId, lastLevel);
		List<global::OneSkillEffect> list2 = (roleSkillEffect != null) ? roleSkillEffect.EffectDescList : null;
		global::SkillEffect roleSkillEffect2 = RoleModel.Instance.GetRoleSkillEffect(skillId, num);
		List<global::OneSkillEffect> list3 = (roleSkillEffect2 != null) ? roleSkillEffect2.EffectDescList : null;
		if (list2 != null && list3 != null)
		{
			for (int i = 0; i < list2.Count; i++)
			{
				global::OneSkillEffect effect = list2[i];
				global::OneSkillEffect effect2 = list3[i];
				string skillAttributeNameByOneSkillEffect = RoleModel.Instance.GetSkillAttributeNameByOneSkillEffect(effect);
				string skillAttributeDescriptionByOneSkillEffect = RoleModel.Instance.GetSkillAttributeDescriptionByOneSkillEffect(effect);
				string skillAttributeDescriptionByOneSkillEffect2 = RoleModel.Instance.GetSkillAttributeDescriptionByOneSkillEffect(effect2);
				if (skillAttributeDescriptionByOneSkillEffect != skillAttributeDescriptionByOneSkillEffect2)
				{
					AttributeInfo item = new AttributeInfo
					{
						Name = skillAttributeNameByOneSkillEffect,
						ShowArrow = new bool?(true),
						PreText = skillAttributeDescriptionByOneSkillEffect,
						CurText = skillAttributeDescriptionByOneSkillEffect2
					};
					list.Add(item);
				}
			}
		}
		bool value = num == maxSkillLevel;
		LevelUpSuccessAttributeData data = new LevelUpSuccessAttributeData
		{
			LevelInfo = new LevelInfo
			{
				PreUpgradeLv = lastLevel,
				UpgradeLv = num,
				FormatStringId = "Text_LevelShow_Text",
				IsMaxLevel = new bool?(value)
			},
			WiderScrollView = new bool?(true),
			AttributeInfo = list
		};
		RoleLevelUpSuccessController.Instance.OpenSuccessAttributeView(data, null);
	}

	// Token: 0x06014E03 RID: 85507 RVA: 0x0054D3B8 File Offset: 0x0054B5B8
	public UniTask RobotRolePropRequest(int[] idList)
	{
		RoleController.<RobotRolePropRequest>d__53 <RobotRolePropRequest>d__;
		<RobotRolePropRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RobotRolePropRequest>d__.idList = idList;
		<RobotRolePropRequest>d__.<>1__state = -1;
		<RobotRolePropRequest>d__.<>t__builder.Start<RoleController.<RobotRolePropRequest>d__53>(ref <RobotRolePropRequest>d__);
		return <RobotRolePropRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06014E04 RID: 85508 RVA: 0x0054D3FC File Offset: 0x0054B5FC
	public void RoleSkinChangeRequest(int roleId, int skinId, bool signatureWeapon, Action<int, bool> roleSkinChangeCallBack)
	{
		RoleSkinChangeRequest roleSkinChangeRequest = Aki.Protocol.RoleSkinChangeRequest.Create();
		roleSkinChangeRequest.RoleId = roleId;
		roleSkinChangeRequest.SkinId = skinId;
		roleSkinChangeRequest.SignatureWeapon = signatureWeapon;
		Net.Instance.Call(ERequestMessageId.RoleSkinChangeRequest, roleSkinChangeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleSkinChangeResponse roleSkinChangeResponse = (RoleSkinChangeResponse)msg;
			if (roleSkinChangeResponse == null)
			{
				return;
			}
			if (roleSkinChangeResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(roleSkinChangeResponse.ErrorCode, EResponseMessageId.RoleSkinChangeResponse, null, true, true);
				return;
			}
			if (signatureWeapon)
			{
				RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(skinId);
				WeaponSkinModel.Instance.UpdateWeaponSkinData(roleId, roleSkinData.GetSuitWeaponSkinId());
			}
			RoleModel.Instance.UpdateRoleSkinInfo(roleId, skinId);
			ScrollingTipsController.Instance.ShowTipsById("RoleSkinReplaceTip", Array.Empty<object>());
			roleSkinChangeCallBack(skinId, signatureWeapon);
			EventSystem.Instance.Emit<int>(EEventName.OnRoleSkinChange, roleId);
		}, 0);
	}

	// Token: 0x06014E05 RID: 85509 RVA: 0x0054D474 File Offset: 0x0054B674
	[NullableContext(2)]
	private void OnRoleSkinChangeNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleSkinChangeNotify roleSkinChangeNotify = (RoleSkinChangeNotify)msg;
		int roleId = roleSkinChangeNotify.RoleId;
		int skinId = roleSkinChangeNotify.SkinId;
		RoleModel.Instance.UpdateRoleSkinInfo(roleId, skinId);
		EventSystem.Instance.Emit<int>(EEventName.OnRoleSkinChange, roleId);
	}

	// Token: 0x06014E06 RID: 85510 RVA: 0x0054D4B4 File Offset: 0x0054B6B4
	public void RoleOperateSelfBgmRequest(int roleId, bool enabled, Action successCallback = null)
	{
		RoleOperateSelfBgmRequest roleOperateSelfBgmRequest = new RoleOperateSelfBgmRequest();
		roleOperateSelfBgmRequest.RoleId = roleId;
		roleOperateSelfBgmRequest.IsOpen = enabled;
		Net.Instance.Call(ERequestMessageId.RoleOperateSelfBgmRequest, roleOperateSelfBgmRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleOperateSelfBgmResponse roleOperateSelfBgmResponse = (RoleOperateSelfBgmResponse)msg;
			if (roleOperateSelfBgmResponse == null)
			{
				return;
			}
			if (roleOperateSelfBgmResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(roleOperateSelfBgmResponse.ErrorCode, EResponseMessageId.RoleOperateSelfBgmResponse, null, true, true);
				return;
			}
			RoleModel.Instance.UpdateRoleBackgroundMusicEnabled(roleId, enabled);
			EventSystem.Instance.Emit<int, bool>(EEventName.OnRoleBackgroundMusicEnabledChanged, roleId, enabled);
			Action successCallback2 = successCallback;
			if (successCallback2 == null)
			{
				return;
			}
			successCallback2();
		}, 0);
	}

	// Token: 0x06014E07 RID: 85511 RVA: 0x0054D517 File Offset: 0x0054B717
	private void UpdateRoleSkillBranch(int roleId, int skillBranch, bool notify = true)
	{
		RoleModel.Instance.SetRoleBranch(roleId, skillBranch);
		RoleModel.Instance.AddRoleSkillBranchChangeRequestRecord(roleId);
		if (notify)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnRoleSkillBranchChanged, roleId);
		}
	}

	// Token: 0x06014E08 RID: 85512 RVA: 0x0054D544 File Offset: 0x0054B744
	public void RequestRoleSkillBranchModify(int roleId, int skillBranch)
	{
		RoleSkillBranchModifyRequest roleSkillBranchModifyRequest = RoleSkillBranchModifyRequest.Create();
		roleSkillBranchModifyRequest.RoleId = roleId;
		roleSkillBranchModifyRequest.SkillBranch = skillBranch;
		Net.Instance.Call(ERequestMessageId.RoleSkillBranchModifyRequest, roleSkillBranchModifyRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleSkillBranchModifyResponse roleSkillBranchModifyResponse = (RoleSkillBranchModifyResponse)msg;
			if (roleSkillBranchModifyResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(roleSkillBranchModifyResponse.ErrorCode, 15261, null, true, true);
				return;
			}
			this.UpdateRoleSkillBranch(roleId, skillBranch, true);
			TableTextArgNew tableTextArgNew = new TableTextArgNew(RoleConfig.Instance.GetSkillBranchConfigById(skillBranch).Value.Name, Array.Empty<object>());
			ScrollingTipsController.Instance.ShowTipsByTextId(RoleConfig.Instance.GetSkillBranchSwitchSuccessKey(), new object[]
			{
				tableTextArgNew
			});
			if (RoleModel.Instance.IsInGamePlayRoleEdit)
			{
				this.ModifyRoleSkillBranchInCurrentGamePlay(roleId, skillBranch, false);
			}
			if (InstanceDungeonModel.Instance.GetMatchTeamInfo() != null)
			{
				List<int> item = BattleTeamModel.Instance.OwnRoleConfigIdList.Item1;
				InstanceDungeonEntranceController.Instance.MatchChangeRoleRequest(item).Forget<bool>();
			}
		}, 0);
	}

	// Token: 0x06014E09 RID: 85513 RVA: 0x0054D5A8 File Offset: 0x0054B7A8
	public void SynRoleSkillBranchNormalToGamePlay(int roleId, ESkillBranchCacheType type)
	{
		RoleModel instance = RoleModel.Instance;
		int roleCurrentBranchId = instance.GetRoleCurrentBranchId(roleId);
		instance.SetRoleSkillBranchGamePlayCache(roleId, roleCurrentBranchId, type);
	}

	// Token: 0x06014E0A RID: 85514 RVA: 0x0054D5CC File Offset: 0x0054B7CC
	public void ModifyRoleSkillBranchInCurrentGamePlay(int roleId, int skillBranch, bool needTips = true)
	{
		RoleModel.Instance.SetRoleSkillBranchGamePlayCache(roleId, skillBranch, RoleModel.Instance.RoleSkillBranchCacheType);
		if (needTips)
		{
			TableTextArgNew tableTextArgNew = new TableTextArgNew(RoleConfig.Instance.GetSkillBranchConfigById(skillBranch).Value.Name, Array.Empty<object>());
			ScrollingTipsController.Instance.ShowTipsByTextId("SkillBranch_Change_Temporary_Text", new object[]
			{
				tableTextArgNew
			});
		}
		EventSystem.Instance.Emit<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, roleId);
	}

	// Token: 0x06014E0B RID: 85515 RVA: 0x0054D644 File Offset: 0x0054B844
	[NullableContext(2)]
	private void OnOrnamentInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		OrnamentInfo ornamentInfo = ((OrnamentInfoNotify)msg).OrnamentInfo;
		if (ornamentInfo == null)
		{
			return;
		}
		RepeatedField<int> unlockOrnamentIds = ornamentInfo.UnlockOrnamentIds;
		RepeatedField<OrnamentDressInfo> ornamentDressInfos = ornamentInfo.OrnamentDressInfos;
		RepeatedField<int> redPointOrnamentIds = ornamentInfo.RedPointOrnamentIds;
		RoleOrnamentModel.Instance.UpdateOwnOrnament(unlockOrnamentIds.ToArray<int>());
		RoleOrnamentModel.Instance.UpdateWearOrnament(ornamentDressInfos);
		RoleOrnamentModel.Instance.UpdateNewlyAddedOrnament(redPointOrnamentIds.ToArray<int>());
		if (RoleOrnamentModel.Instance.GetIsCommonItemFinished())
		{
			InventoryController.Instance.InitOrnamentItemData(unlockOrnamentIds.ToArray<int>());
			return;
		}
		RoleOrnamentModel.Instance.SetPendingOrnamentIdsForInit(unlockOrnamentIds.ToArray<int>());
	}

	// Token: 0x06014E0C RID: 85516 RVA: 0x0054D6D0 File Offset: 0x0054B8D0
	[NullableContext(2)]
	private void OnOrnamentUnlockNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<int> unlockOrnamentIds = ((OrnamentUnlockNotify)msg).UnlockOrnamentIds;
		if (RoleOrnamentModel.Instance.GetIsCommonItemFinished())
		{
			RoleController.ProcessOrnamentUnlock(unlockOrnamentIds.ToArray<int>());
			return;
		}
		RoleOrnamentModel.Instance.AddPendingOrnamentUnlockBatch(unlockOrnamentIds.ToArray<int>());
	}

	// Token: 0x06014E0D RID: 85517 RVA: 0x0054D714 File Offset: 0x0054B914
	private static void ProcessOrnamentUnlock(int[] ids)
	{
		RoleOrnamentModel.Instance.UpdateOwnOrnament(ids);
		List<TItem> list = new List<TItem>();
		foreach (int num in ids)
		{
			InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(num, 0);
			list.Add(new TItem(itemData, 1));
			EventSystem.Instance.Emit<int>(EEventName.OnOrnamentUnlock, num);
			RoleOrnamentModel.Instance.SetOrnamentNewlyAcquired(num, true);
		}
		InventoryController.Instance.AddOrnamentItemData(ids);
		EventSystem.Instance.Emit<TItem[]>(EEventName.OnAddOrnamentItemList, list.ToArray());
	}

	// Token: 0x06014E0E RID: 85518 RVA: 0x0054D79C File Offset: 0x0054B99C
	[NullableContext(2)]
	private void OnOrnamentDressInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<OrnamentDressInfo> ornamentDressInfos = ((OrnamentDressInfoUpdateNotify)msg).OrnamentDressInfos;
		RoleOrnamentModel.Instance.UpdateWearOrnament(ornamentDressInfos);
		EventSystem.Instance.Emit(EEventName.OnOrnamentChange);
	}

	// Token: 0x06014E0F RID: 85519 RVA: 0x0054D7D0 File Offset: 0x0054B9D0
	[NullableContext(2)]
	private void OnEntityDressOrnamentChangeNotify(IMessage msg, Net.CallbackStatus status)
	{
		EntityDressOrnamentChangeNotify entityDressOrnamentChangeNotify = (EntityDressOrnamentChangeNotify)msg;
		long creatureDataId = MathUtils.Instance.LongToNumber(entityDressOrnamentChangeNotify.EntityId);
		EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
		CharacterOutlookComponent characterOutlookComponent;
		if (entity == null)
		{
			characterOutlookComponent = null;
		}
		else
		{
			WorldEntity entity2 = entity.Entity;
			characterOutlookComponent = ((entity2 != null) ? entity2.GetComponent<CharacterOutlookComponent>() : null);
		}
		CharacterOutlookComponent characterOutlookComponent2 = characterOutlookComponent;
		if (characterOutlookComponent2 == null)
		{
			return;
		}
		characterOutlookComponent2.OnEntityDressOrnamentChangeNotify(entityDressOrnamentChangeNotify);
	}

	// Token: 0x06014E10 RID: 85520 RVA: 0x0054D824 File Offset: 0x0054BA24
	public void RequestChangeOrnamentRequest(int roleSkinId, int ornamentId, bool isDress)
	{
		int normalizedOrnamentSkinId = RoleOrnamentModel.Instance.GetNormalizedOrnamentSkinId(roleSkinId);
		ChangeOrnamentRequest changeOrnamentRequest = ChangeOrnamentRequest.Create();
		changeOrnamentRequest.RoleSkinId = normalizedOrnamentSkinId;
		changeOrnamentRequest.OrnamentId = ornamentId;
		changeOrnamentRequest.IsDress = isDress;
		Net.Instance.Call(ERequestMessageId.ChangeOrnamentRequest, changeOrnamentRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ChangeOrnamentResponse changeOrnamentResponse = (ChangeOrnamentResponse)msg;
			if (changeOrnamentResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(changeOrnamentResponse.ErrorCode, 19523, null, true, true);
				return;
			}
			string textId = isDress ? "OrnamentUiText_05" : "OrnamentUiText_06";
			ScrollingTipsController.Instance.ShowTipsByTextId(textId, Array.Empty<object>());
		}, 0);
	}

	// Token: 0x06014E11 RID: 85521 RVA: 0x0054D888 File Offset: 0x0054BA88
	public bool CheckCanWearOrnamentAndShowTip()
	{
		BaseTagComponent component = SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<BaseTagComponent>();
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]) || component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_ForbiddenActionInFight_Text", Array.Empty<object>());
			return false;
		}
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.正常游泳"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_ForbiddenActionInSwimming_Text", Array.Empty<object>());
			return false;
		}
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_ForbiddenActionInClimbing_Text", Array.Empty<object>());
			return false;
		}
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_ForbiddenActionMidair_Text", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x06014E12 RID: 85522 RVA: 0x0054D97C File Offset: 0x0054BB7C
	public void OpenOrnamentPreviewView(int ornamentId, int? skinId)
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.RoleOrnamentShowView))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("OrnamentUiText_08", Array.Empty<object>());
			return;
		}
		RoleOrnamentShowViewParams param = new RoleOrnamentShowViewParams
		{
			OrnamentId = ornamentId,
			SkinId = skinId
		};
		UiManager.Instance.OpenView(EUiViewName.RoleOrnamentShowView, param, null);
	}

	// Token: 0x06014E13 RID: 85523 RVA: 0x0054D9D4 File Offset: 0x0054BBD4
	public void SkipToRoleOrnamentViewByItemId(int itemId, bool skipCameraBlend = true)
	{
		if (RoleConfig.Instance.GetOrnamentConfig(itemId) == null)
		{
			return;
		}
		int[] roleSkinIds = RoleOrnamentModel.Instance.GetRoleOrnamentData(itemId).GetRoleSkinIds();
		int? skinId = null;
		int? num = null;
		int[] array = roleSkinIds;
		int i = 0;
		while (i < array.Length)
		{
			int num2 = array[i];
			int roleId = RoleSkinModel.Instance.GetRoleSkinData(num2).GetRoleId();
			if (!RoleModel.Instance.IsMainRole(roleId))
			{
				goto IL_84;
			}
			int num3 = roleId;
			int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
			if (num3 == curSelectMainRoleId.GetValueOrDefault() & curSelectMainRoleId != null)
			{
				goto IL_84;
			}
			IL_B5:
			i++;
			continue;
			IL_84:
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleId);
			if (roleInstanceById != null && num2 == roleInstanceById.GetRoleSkinId())
			{
				skinId = new int?(num2);
				num = new int?(roleId);
				break;
			}
			goto IL_B5;
		}
		if (num == null || skinId == null || !RoleModel.Instance.IsRoleOwned(num.Value))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("ConfirmBox_233_Content", Array.Empty<object>());
			return;
		}
		this.OpenRoleOrnamentView(num.Value, skinId, new int?(itemId), null, new bool?(skipCameraBlend));
	}

	// Token: 0x06014E14 RID: 85524 RVA: 0x0054DAFC File Offset: 0x0054BCFC
	[NullableContext(2)]
	public void OpenRoleOrnamentView(int roleId, int? skinId = null, int? ornamentId = null, TOpenViewCallBack finishCallback = null, bool? skipCameraBlend = null)
	{
		WeaponDataBase weaponDataByRoleDataId = WeaponModel.Instance.GetWeaponDataByRoleDataId(roleId, true);
		if (!(weaponDataByRoleDataId is WeaponInstance))
		{
			return;
		}
		ISkinViewData param = new SkinViewData
		{
			RoleId = roleId,
			TabViewName = EUiTabViewName.RoleOrnamentTabView,
			WeaponId = ((WeaponInstance)weaponDataByRoleDataId).GetIncId().Value,
			NeedLoadRole = true,
			OrnamentSkinId = skinId,
			OrnamentId = ornamentId,
			SkipOrnamentCameraBlend = skipCameraBlend
		};
		UiManager.Instance.OpenView(EUiViewName.SkinRootView, param, finishCallback);
	}

	// Token: 0x06014E15 RID: 85525 RVA: 0x0054DB80 File Offset: 0x0054BD80
	[NullableContext(2)]
	private void OnRoleUpdateDevelopTargetNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleUpdateDevelopTargetNotify roleUpdateDevelopTargetNotify = (RoleUpdateDevelopTargetNotify)msg;
		RoleDevelopModel.Instance.SelectPlanId = roleUpdateDevelopTargetNotify.PlanId;
		RoleDevelopModel.Instance.SelectFirstVisionMonsterId = roleUpdateDevelopTargetNotify.FirstPhantomId;
		int roleId = roleUpdateDevelopTargetNotify.RoleId;
		int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
		if (roleId != 0 && devTargetRoleId != roleId)
		{
			RoleDevelopData roleDevelopData = RoleDevelopModel.Instance.GetRoleDevelopData(roleId);
			if (roleDevelopData != null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RoleProject_Tips14", new object[]
				{
					roleDevelopData.GetDevelopRoleData().GetName()
				});
			}
			else
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RoleProject_Tips11", Array.Empty<object>());
			}
		}
		else if (roleId == 0 && devTargetRoleId != 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RoleProject_Tips15", Array.Empty<object>());
		}
		RoleDevelopModel.Instance.UpdateDevTargetRoleId(roleId);
		EventSystem.Instance.Emit(EEventName.RoleDevTargetRoleIdChange);
	}

	// Token: 0x06014E16 RID: 85526 RVA: 0x0054DC4C File Offset: 0x0054BE4C
	[NullableContext(2)]
	private void OnRoleDevelopConfigUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleDevelopConfigs configs = ((RoleDevelopConfigUpdateNotify)msg).Configs;
		if (configs == null)
		{
			Log.Instance.Error(ELogModule.RoleDev, ELogAuthor.LJS, "RoleDevelopConfigUpdateNotify Configs为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		RoleDevelopModel.Instance.UpdateRoleDevConfig(configs);
	}

	// Token: 0x06014E17 RID: 85527 RVA: 0x0054DC94 File Offset: 0x0054BE94
	public UniTask RequestRoleDevelopConfig()
	{
		RoleController.<RequestRoleDevelopConfig>d__73 <RequestRoleDevelopConfig>d__;
		<RequestRoleDevelopConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRoleDevelopConfig>d__.<>1__state = -1;
		<RequestRoleDevelopConfig>d__.<>t__builder.Start<RoleController.<RequestRoleDevelopConfig>d__73>(ref <RequestRoleDevelopConfig>d__);
		return <RequestRoleDevelopConfig>d__.<>t__builder.Task;
	}

	// Token: 0x06014E18 RID: 85528 RVA: 0x0054DCD0 File Offset: 0x0054BED0
	public UniTask RequestRoleDevelopDependentData()
	{
		RoleController.<RequestRoleDevelopDependentData>d__74 <RequestRoleDevelopDependentData>d__;
		<RequestRoleDevelopDependentData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRoleDevelopDependentData>d__.<>4__this = this;
		<RequestRoleDevelopDependentData>d__.<>1__state = -1;
		<RequestRoleDevelopDependentData>d__.<>t__builder.Start<RoleController.<RequestRoleDevelopDependentData>d__74>(ref <RequestRoleDevelopDependentData>d__);
		return <RequestRoleDevelopDependentData>d__.<>t__builder.Task;
	}

	// Token: 0x06014E19 RID: 85529 RVA: 0x0054DD14 File Offset: 0x0054BF14
	public void RequestRoleDevelopVisionRecommendData()
	{
		foreach (RoleDevelopData roleDevelopData in RoleDevelopModel.Instance.GetNormalRoleDevelopData())
		{
			int id = roleDevelopData.GetId();
			VisionRecommendController.Instance.RequestRoleVisionRecommendData(id);
			VisionRecommendController.Instance.RequestRoleVisionRecommendAttr(id);
		}
	}

	// Token: 0x06014E1A RID: 85530 RVA: 0x0054DD80 File Offset: 0x0054BF80
	public void RequestUpdateDevelopTarget(int roleId, ERoleDevelopUpdateTargetSource source, int? fetterGroupId = null, int? firstPhantomId = null)
	{
		RoleUpdateDevelopTargetRequest roleUpdateDevelopTargetRequest = RoleUpdateDevelopTargetRequest.Create();
		roleUpdateDevelopTargetRequest.RoleId = roleId;
		roleUpdateDevelopTargetRequest.Source = (int)source;
		roleUpdateDevelopTargetRequest.PlanId = fetterGroupId.GetValueOrDefault();
		roleUpdateDevelopTargetRequest.FirstPhantomId = firstPhantomId.GetValueOrDefault();
		Net.Instance.Call(ERequestMessageId.RoleUpdateDevelopTargetRequest, roleUpdateDevelopTargetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleUpdateDevelopTargetResponse roleUpdateDevelopTargetResponse = (RoleUpdateDevelopTargetResponse)msg;
			if (roleUpdateDevelopTargetResponse == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RoleDev;
				ELogAuthor author = ELogAuthor.WMQ;
				string message = "RoleUpdateDevelopTarget请求无响应";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("response", roleUpdateDevelopTargetResponse);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (roleUpdateDevelopTargetResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(roleUpdateDevelopTargetResponse.ErrorCode, 29361, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06014E1B RID: 85531 RVA: 0x0054DDEC File Offset: 0x0054BFEC
	public static void OpenRoleDevelopView(int? roleId)
	{
		RoleDevelopRootViewData roleDevelopRootViewData = new RoleDevelopRootViewData();
		roleDevelopRootViewData.RoleId = roleId;
		UiManager.Instance.OpenView(EUiViewName.RoleDevelopRootView, roleDevelopRootViewData, null);
	}

	// Token: 0x06014E1C RID: 85532 RVA: 0x0054DE18 File Offset: 0x0054C018
	public static void OpenRoleDevelopSelectTargetView(ERoleDevelopUpdateTargetSource source, int? roleId = null)
	{
		RoleDevelopSelectTargetViewData roleDevelopSelectTargetViewData = new RoleDevelopSelectTargetViewData();
		roleDevelopSelectTargetViewData.RoleId = roleId;
		roleDevelopSelectTargetViewData.Source = source;
		UiManager.Instance.OpenView(EUiViewName.RoleDevelopSelectTargetView, roleDevelopSelectTargetViewData, null);
	}

	// Token: 0x06014E1D RID: 85533 RVA: 0x0054DE4C File Offset: 0x0054C04C
	public void LogRoleDevelopClick(int roleId, ERoleDevelopCategoryType mainPage, ERoleDevelopLogSubPage subPage, ERoleDevelopLogItemState? itemState = null)
	{
		RoleDevLogEvent roleDevLogEvent = new RoleDevLogEvent();
		roleDevLogEvent.i_role_id = roleId;
		roleDevLogEvent.i_role_type = ((RoleModel.Instance.IsRoleOwned(roleId) > false) ? 1 : 0);
		roleDevLogEvent.i_main_page = (int)mainPage;
		roleDevLogEvent.i_sub_page = (int)subPage;
		roleDevLogEvent.i_type = (int)((itemState != null) ? itemState.Value : ERoleDevelopLogItemState.Normal);
		LogController.Instance.LogRoleDevPush(roleDevLogEvent);
	}

	// Token: 0x06014E1E RID: 85534 RVA: 0x0054DEAC File Offset: 0x0054C0AC
	public void LogRoleDevelopSkillRecommendClick(int roleId, bool isActive)
	{
		RoleDevelopSkillRecommendClickLogEvent roleDevelopSkillRecommendClickLogEvent = new RoleDevelopSkillRecommendClickLogEvent();
		roleDevelopSkillRecommendClickLogEvent.i_role_id = roleId;
		roleDevelopSkillRecommendClickLogEvent.i_operation = ((isActive > false) ? 1 : 0);
		LogReportController.Instance.LogReport(roleDevelopSkillRecommendClickLogEvent);
	}

	// Token: 0x06014E1F RID: 85535 RVA: 0x0054DEDB File Offset: 0x0054C0DB
	public bool CanOpenRoleDevelopView(EUiViewName viewName, object arg = null)
	{
		return FunctionModel.Instance.IsOpen(EFunctionType.RoleDev);
	}

	// Token: 0x06014E20 RID: 85536 RVA: 0x0054DEF4 File Offset: 0x0054C0F4
	[NullableContext(0)]
	public UniTask<bool> RequestPlayerVoiceLanguage()
	{
		RoleController.<RequestPlayerVoiceLanguage>d__82 <RequestPlayerVoiceLanguage>d__;
		<RequestPlayerVoiceLanguage>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestPlayerVoiceLanguage>d__.<>1__state = -1;
		<RequestPlayerVoiceLanguage>d__.<>t__builder.Start<RoleController.<RequestPlayerVoiceLanguage>d__82>(ref <RequestPlayerVoiceLanguage>d__);
		return <RequestPlayerVoiceLanguage>d__.<>t__builder.Task;
	}

	// Token: 0x06014E21 RID: 85537 RVA: 0x0054DF30 File Offset: 0x0054C130
	[NullableContext(0)]
	public UniTask<bool> RequestPlayerRoleVoiceSet([Nullable(1)] List<RoleVoiceSetting> roleList)
	{
		RoleController.<RequestPlayerRoleVoiceSet>d__83 <RequestPlayerRoleVoiceSet>d__;
		<RequestPlayerRoleVoiceSet>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestPlayerRoleVoiceSet>d__.roleList = roleList;
		<RequestPlayerRoleVoiceSet>d__.<>1__state = -1;
		<RequestPlayerRoleVoiceSet>d__.<>t__builder.Start<RoleController.<RequestPlayerRoleVoiceSet>d__83>(ref <RequestPlayerRoleVoiceSet>d__);
		return <RequestPlayerRoleVoiceSet>d__.<>t__builder.Task;
	}

	// Token: 0x17001B27 RID: 6951
	// (get) Token: 0x06014E22 RID: 85538 RVA: 0x0054DF73 File Offset: 0x0054C173
	public static RoleController Instance
	{
		get
		{
			return RoleController._Instance;
		}
	}

	// Token: 0x06014E23 RID: 85539 RVA: 0x0054DF7A File Offset: 0x0054C17A
	public static RoleController GetOrCreateInstance()
	{
		if (RoleController._Instance == null)
		{
			RoleController.CreateInstance();
		}
		return RoleController._Instance;
	}

	// Token: 0x06014E24 RID: 85540 RVA: 0x0054DF8E File Offset: 0x0054C18E
	public static bool CreateInstance()
	{
		if (RoleController._Instance != null)
		{
			return true;
		}
		RoleController._Instance = new RoleController();
		return true;
	}

	// Token: 0x06014E25 RID: 85541 RVA: 0x0054DFA4 File Offset: 0x0054C1A4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014E26 RID: 85542 RVA: 0x0054DFA6 File Offset: 0x0054C1A6
	public static void ResetStaticDefaultValue()
	{
		RoleController._Instance = null;
	}

	// Token: 0x06014E27 RID: 85543 RVA: 0x0054DFAE File Offset: 0x0054C1AE
	static RoleController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleController.CreateStaticDefaultValue), new Action(RoleController.ResetStaticDefaultValue));
	}

	// Token: 0x04009CF0 RID: 40176
	private readonly Action OpenRoleMainViewByInput = delegate()
	{
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, 0, null, null, null);
	};

	// Token: 0x04009CF1 RID: 40177
	[Nullable(2)]
	private static RoleController _Instance;
}
