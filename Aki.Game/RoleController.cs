using System;
using System.Collections.Generic;
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

// Token: 0x02001D25 RID: 7461
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RoleController : UiControllerBase
{
	// Token: 0x060127C9 RID: 75721 RVA: 0x005764B4 File Offset: 0x005746B4
	protected override bool OnInit()
	{
		InputManager.Instance.RegisterOpenViewFunc(EUiViewName.RoleRootView, this.OpenRoleMainViewByInput);
		return true;
	}

	// Token: 0x060127CA RID: 75722 RVA: 0x005764CC File Offset: 0x005746CC
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

	// Token: 0x060127CB RID: 75723 RVA: 0x00576540 File Offset: 0x00574740
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

	// Token: 0x060127CC RID: 75724 RVA: 0x00576604 File Offset: 0x00574804
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

	// Token: 0x060127CD RID: 75725 RVA: 0x00576668 File Offset: 0x00574868
	public void OpenRoleMainViewByParam(IOpenRoleMainViewData param)
	{
		int valueOrDefault = param.SelectRoleId.GetValueOrDefault();
		List<int> roleIdList = param.RoleIdList ?? new List<int>();
		RoleViewAgent roleViewAgent = RoleModel.Instance.GetRoleViewAgent(param.AgentType);
		ETeamPositionType valueOrDefault2 = param.TeamPositionType.GetValueOrDefault();
		roleViewAgent.Init(roleIdList, valueOrDefault, param.OpenTabView, param.Source.GetValueOrDefault(), param.UseMainViewSort);
		roleViewAgent.TeamPositionType = new ETeamPositionType?(valueOrDefault2);
		UiManager.Instance.OpenView(EUiViewName.RoleRootView, roleViewAgent, param.FinishCallback);
	}

	// Token: 0x060127CE RID: 75726 RVA: 0x005766FB File Offset: 0x005748FB
	public void OpenRoleViewByViewModel(EUiViewName viewName, RoleViewViewModel viewModel)
	{
		if (!this.CheckRoleCanOpenView(viewModel.RoleId, viewName))
		{
			return;
		}
		UiManager.Instance.OpenView(viewName, viewModel, null);
	}

	// Token: 0x060127CF RID: 75727 RVA: 0x0057671A File Offset: 0x0057491A
	public void CloseAndOpenRoleViewByViewModel(EUiViewName closeViewName, EUiViewName openViewName, RoleViewViewModel viewModel)
	{
		if (!this.CheckRoleCanOpenView(viewModel.RoleId, openViewName))
		{
			return;
		}
		UiManager.Instance.CloseAndOpenView(closeViewName, openViewName, viewModel, null, true);
	}

	// Token: 0x060127D0 RID: 75728 RVA: 0x0057673C File Offset: 0x0057493C
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

	// Token: 0x060127D1 RID: 75729 RVA: 0x0057682C File Offset: 0x00574A2C
	[NullableContext(2)]
	public void CloseAndOpenRoleMainView(EUiViewName closeViewName, ERoleAgentType agentType, int selectRoleId = 0, List<int> roleIdList = null, EUiTabViewName? openTabView = null, Action<bool> finishCallback = null)
	{
		if (roleIdList == null)
		{
			roleIdList = new List<int>();
		}
		RoleViewAgent roleViewAgent = RoleModel.Instance.GetRoleViewAgent(agentType);
		roleViewAgent.Init(roleIdList, selectRoleId, openTabView, ERoleViewSource.Normal, false);
		UiManager.Instance.CloseAndOpenView(closeViewName, EUiViewName.RoleRootView, roleViewAgent, finishCallback, true);
	}

	// Token: 0x060127D2 RID: 75730 RVA: 0x00576874 File Offset: 0x00574A74
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoleRootView, new Func<EUiViewName, object, bool>(this.CanOpenView), "RoleController.CanOpenView");
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoleDevelopRootView, new Func<EUiViewName, object, bool>(this.CanOpenRoleDevelopView), "RoleController.CanOpenRoleDevelopView");
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoleDevelopSelectTargetView, new Func<EUiViewName, object, bool>(this.CanOpenRoleDevelopView), "RoleController.CanOpenRoleDevelopSelectTargetView");
	}

	// Token: 0x060127D3 RID: 75731 RVA: 0x005768E4 File Offset: 0x00574AE4
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoleRootView, new Func<EUiViewName, object, bool>(this.CanOpenView));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoleDevelopRootView, new Func<EUiViewName, object, bool>(this.CanOpenRoleDevelopView));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoleDevelopSelectTargetView, new Func<EUiViewName, object, bool>(this.CanOpenRoleDevelopView));
	}

	// Token: 0x060127D4 RID: 75732 RVA: 0x00576944 File Offset: 0x00574B44
	public bool CheckCharacterInBattleTag(bool useIgnoreList = false)
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		return (!useIgnoreList || !RoleController.IsInIgnoreBattleTagInst()) && baseCharacter != null && baseCharacter.CharacterActorComponent.Entity.CheckGetComponent<BaseTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]);
	}

	// Token: 0x060127D5 RID: 75733 RVA: 0x0057698C File Offset: 0x00574B8C
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
		if (config == null)
		{
			return false;
		}
		using (IEnumerator<int> enumerator = readOnlyList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == config.Value.InstSubType)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060127D6 RID: 75734 RVA: 0x00576A80 File Offset: 0x00574C80
	public bool CheckCharacterInBattleTagAndShowTips(bool useIgnoreList = false)
	{
		if (RoleController.Instance.CheckCharacterInBattleTag(useIgnoreList))
		{
			ScrollingTipsController.Instance.ShowTipsById("ForbiddenActionInFight", Array.Empty<object>());
			return true;
		}
		return false;
	}

	// Token: 0x060127D7 RID: 75735 RVA: 0x00576AA8 File Offset: 0x00574CA8
	public void OnSelectedRoleChange(int roleId, int roleSkinId)
	{
		TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		this.RefreshUiSceneRoleActor(roleSystemRoleActor, roleId, roleSkinId, null);
		EventSystem.Instance.Emit(EEventName.OnSelectedRoleChanged);
	}

	// Token: 0x060127D8 RID: 75736 RVA: 0x00576ADC File Offset: 0x00574CDC
	public void SetRoleMorphType(TsUiSceneRoleActor roleActor, EUiModelMorphType morphType)
	{
		UiModelBase model = roleActor.Model;
		UiRoleMorphComponent uiRoleMorphComponent = (model != null) ? model.GetComponent<UiRoleMorphComponent>() : null;
		if (uiRoleMorphComponent != null && uiRoleMorphComponent.SetMorphType(morphType))
		{
			EventSystem.Instance.Emit(EEventName.OnRoleMorphTypeChanged);
		}
	}

	// Token: 0x060127D9 RID: 75737 RVA: 0x00576B18 File Offset: 0x00574D18
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

	// Token: 0x060127DA RID: 75738 RVA: 0x00576B7C File Offset: 0x00574D7C
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

	// Token: 0x060127DB RID: 75739 RVA: 0x00576C32 File Offset: 0x00574E32
	public void OnSelectedRoleChangeByConfig(int roleId, int skinId, Action callback = null)
	{
		this.RefreshUiSceneRoleActorByConfigId(roleId, skinId, callback);
		EventSystem.Instance.Emit(EEventName.OnSelectedRoleChanged);
	}

	// Token: 0x060127DC RID: 75740 RVA: 0x00576C50 File Offset: 0x00574E50
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

	// Token: 0x060127DD RID: 75741 RVA: 0x00576CE8 File Offset: 0x00574EE8
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

	// Token: 0x060127DE RID: 75742 RVA: 0x00576D3C File Offset: 0x00574F3C
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

	// Token: 0x060127DF RID: 75743 RVA: 0x00576D9C File Offset: 0x00574F9C
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.RedDotStart, new Action(this.OnRedDotStartEvent));
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.ResetRoleTrialState));
		EventSystem.Instance.Add(EEventName.TextLanguageChange, new Action<string, string>(this.OnTextLanguageChange));
		EventSystem.Instance.Add(EEventName.OnResponseCommonItemFinished, new Action(this.OnResponseCommonItemFinished));
	}

	// Token: 0x060127E0 RID: 75744 RVA: 0x00576E38 File Offset: 0x00575038
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.RedDotStart, new Action(this.OnRedDotStartEvent));
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.ResetRoleTrialState));
		EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnTextLanguageChange));
		EventSystem.Instance.Remove(EEventName.OnResponseCommonItemFinished, new Action(this.OnResponseCommonItemFinished));
	}

	// Token: 0x060127E1 RID: 75745 RVA: 0x00576ED1 File Offset: 0x005750D1
	private void OnLoadingNetDataDone()
	{
		this.SendRoleFavorListRequest();
		this.RequestRoleDevelopDependentData().Forget();
	}

	// Token: 0x060127E2 RID: 75746 RVA: 0x00576EE4 File Offset: 0x005750E4
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

	// Token: 0x060127E3 RID: 75747 RVA: 0x00576F60 File Offset: 0x00575160
	private void OnRedDotStartEvent()
	{
		foreach (int p in RoleModel.Instance.GetRoleIdList(null))
		{
			EventSystem.Instance.Emit<int>(EEventName.RedDotCreateRole, p);
		}
	}

	// Token: 0x060127E4 RID: 75748 RVA: 0x00576FC4 File Offset: 0x005751C4
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

	// Token: 0x060127E5 RID: 75749 RVA: 0x00577024 File Offset: 0x00575224
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

	// Token: 0x060127E6 RID: 75750 RVA: 0x00577128 File Offset: 0x00575328
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PbGetRoleListNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PbGetRoleListNotify pbGetRoleListNotify = (PbGetRoleListNotify)msg;
			roleInfo[] array = new roleInfo[pbGetRoleListNotify.RoleList.Count];
			pbGetRoleListNotify.RoleList.CopyTo(array, 0);
			RoleModel.Instance.UpdateRoleInfoByServerData(array);
		});
		Net.Instance.Register(ENotifyMessageId.PbRolePropsNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PbRolePropsNotify pbRolePropsNotify = (PbRolePropsNotify)msg;
			ArrayIntInt[] array = new ArrayIntInt[pbRolePropsNotify.BaseProp.Count];
			pbRolePropsNotify.BaseProp.CopyTo(array, 0);
			ArrayIntInt[] array2 = new ArrayIntInt[pbRolePropsNotify.AddProp.Count];
			pbRolePropsNotify.AddProp.CopyTo(array2, 0);
			RoleModel.Instance.RoleAttrUpdate(pbRolePropsNotify.RoleId, array, array2);
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
			int[] array = new int[roleTrialOpenNotify.CanEnterDungeonList.Count];
			roleTrialOpenNotify.CanEnterDungeonList.CopyTo(array, 0);
			InstanceDungeonController.Instance.UpdateTrialRoleDungeonWhiteList(array);
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
			int[] array = new int[roleTrialCloseNotify.CanEnterDungeonList.Count];
			roleTrialCloseNotify.CanEnterDungeonList.CopyTo(array, 0);
			InstanceDungeonController.Instance.UpdateTrialRoleDungeonWhiteList(array);
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
				ArraySkillNode[] array = new ArraySkillNode[roleSkillNodeNotify.SkillNodeState.Count];
				roleSkillNodeNotify.SkillNodeState.CopyTo(array, 0);
				RoleModel.Instance.UpdateRoleSkillNodeData(roleSkillNodeNotify.RoleId, array);
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
				RoleFavor[] array = new RoleFavor[roleFavorListNotify.FavorList.Count];
				roleFavorListNotify.FavorList.CopyTo(array, 0);
				RoleModel.Instance.UpdateRoleFavorData(array);
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

	// Token: 0x060127E7 RID: 75751 RVA: 0x00577524 File Offset: 0x00575724
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

	// Token: 0x060127E8 RID: 75752 RVA: 0x005776B1 File Offset: 0x005758B1
	public bool IsInRoleTrial()
	{
		return RoleModel.Instance.IsInRoleTrial;
	}

	// Token: 0x060127E9 RID: 75753 RVA: 0x005776C0 File Offset: 0x005758C0
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
				RoleModel.Instance.RoleLevelUpReceiveItem(new Dictionary<int, int>(pbUpLevelRoleResponse.ItemMap));
				RoleModel.Instance.RoleLevelUp(pbUpLevelRoleResponse.RoleId, pbUpLevelRoleResponse.Exp, pbUpLevelRoleResponse.Level);
				successCallback();
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(pbUpLevelRoleResponse.Code, EResponseMessageId.PbUpLevelRoleResponse, null, true, true);
		}, 0);
	}

	// Token: 0x060127EA RID: 75754 RVA: 0x00577718 File Offset: 0x00575918
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

	// Token: 0x060127EB RID: 75755 RVA: 0x00577764 File Offset: 0x00575964
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

	// Token: 0x060127EC RID: 75756 RVA: 0x0057781C File Offset: 0x00575A1C
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

	// Token: 0x060127ED RID: 75757 RVA: 0x005778E0 File Offset: 0x00575AE0
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

	// Token: 0x060127EE RID: 75758 RVA: 0x00577948 File Offset: 0x00575B48
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

	// Token: 0x060127EF RID: 75759 RVA: 0x0057799F File Offset: 0x00575B9F
	public void OpenTeamRoleSelectView(TeamRoleSelectViewData data)
	{
		UiManager.Instance.OpenView(EUiViewName.TeamRoleSelectView, data, null);
	}

	// Token: 0x060127F0 RID: 75760 RVA: 0x005779B2 File Offset: 0x00575BB2
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

	// Token: 0x060127F1 RID: 75761 RVA: 0x005779E5 File Offset: 0x00575BE5
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

	// Token: 0x060127F2 RID: 75762 RVA: 0x00577A14 File Offset: 0x00575C14
	public void SetTriggerElementEnd(bool triggerElementEnd)
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
		obj2.SetTriggerElementEnd(triggerElementEnd);
	}

	// Token: 0x060127F3 RID: 75763 RVA: 0x00577A44 File Offset: 0x00575C44
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

	// Token: 0x060127F4 RID: 75764 RVA: 0x00577AC4 File Offset: 0x00575CC4
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
				RoleFavor[] array = new RoleFavor[roleFavorListResponse.FavorList.Count];
				roleFavorListResponse.FavorList.CopyTo(array, 0);
				RoleModel.Instance.UpdateRoleFavorData(array);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(roleFavorListResponse.ErrCode, EResponseMessageId.RoleFavorListResponse, null, true, true);
		}, 0);
	}

	// Token: 0x060127F5 RID: 75765 RVA: 0x00577B08 File Offset: 0x00575D08
	public UniTask SendRoleFavorListRequestAsync()
	{
		RoleController.<SendRoleFavorListRequestAsync>d__45 <SendRoleFavorListRequestAsync>d__;
		<SendRoleFavorListRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SendRoleFavorListRequestAsync>d__.<>1__state = -1;
		<SendRoleFavorListRequestAsync>d__.<>t__builder.Start<RoleController.<SendRoleFavorListRequestAsync>d__45>(ref <SendRoleFavorListRequestAsync>d__);
		return <SendRoleFavorListRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060127F6 RID: 75766 RVA: 0x00577B44 File Offset: 0x00575D44
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

	// Token: 0x060127F7 RID: 75767 RVA: 0x00577B9B File Offset: 0x00575D9B
	public void SendRoleActiveRequest(int roleId)
	{
	}

	// Token: 0x060127F8 RID: 75768 RVA: 0x00577BA0 File Offset: 0x00575DA0
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

	// Token: 0x060127F9 RID: 75769 RVA: 0x00577BE8 File Offset: 0x00575DE8
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

	// Token: 0x060127FA RID: 75770 RVA: 0x00577C4C File Offset: 0x00575E4C
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

	// Token: 0x060127FB RID: 75771 RVA: 0x00577CE8 File Offset: 0x00575EE8
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

	// Token: 0x060127FC RID: 75772 RVA: 0x00577D60 File Offset: 0x00575F60
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

	// Token: 0x060127FD RID: 75773 RVA: 0x00577E10 File Offset: 0x00576010
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

	// Token: 0x060127FE RID: 75774 RVA: 0x00577FB8 File Offset: 0x005761B8
	public UniTask RobotRolePropRequest(int[] idList)
	{
		RoleController.<RobotRolePropRequest>d__54 <RobotRolePropRequest>d__;
		<RobotRolePropRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RobotRolePropRequest>d__.idList = idList;
		<RobotRolePropRequest>d__.<>1__state = -1;
		<RobotRolePropRequest>d__.<>t__builder.Start<RoleController.<RobotRolePropRequest>d__54>(ref <RobotRolePropRequest>d__);
		return <RobotRolePropRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060127FF RID: 75775 RVA: 0x00577FFC File Offset: 0x005761FC
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

	// Token: 0x06012800 RID: 75776 RVA: 0x00578074 File Offset: 0x00576274
	[NullableContext(2)]
	private void OnRoleSkinChangeNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleSkinChangeNotify roleSkinChangeNotify = (RoleSkinChangeNotify)msg;
		int roleId = roleSkinChangeNotify.RoleId;
		int skinId = roleSkinChangeNotify.SkinId;
		RoleModel.Instance.UpdateRoleSkinInfo(roleId, skinId);
		EventSystem.Instance.Emit<int>(EEventName.OnRoleSkinChange, roleId);
	}

	// Token: 0x06012801 RID: 75777 RVA: 0x005780B4 File Offset: 0x005762B4
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

	// Token: 0x06012802 RID: 75778 RVA: 0x00578117 File Offset: 0x00576317
	private void UpdateRoleSkillBranch(int roleId, int skillBranch, bool notify = true)
	{
		RoleModel.Instance.SetRoleBranch(roleId, skillBranch);
		RoleModel.Instance.AddRoleSkillBranchChangeRequestRecord(roleId);
		if (notify)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnRoleSkillBranchChanged, roleId);
		}
	}

	// Token: 0x06012803 RID: 75779 RVA: 0x00578144 File Offset: 0x00576344
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(roleSkillBranchModifyResponse.ErrorCode, 25832, null, true, true);
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

	// Token: 0x06012804 RID: 75780 RVA: 0x005781A8 File Offset: 0x005763A8
	public void SynRoleSkillBranchNormalToGamePlay(int roleId, ESkillBranchCacheType type)
	{
		RoleModel instance = RoleModel.Instance;
		int roleCurrentBranchId = instance.GetRoleCurrentBranchId(roleId);
		instance.SetRoleSkillBranchGamePlayCache(roleId, roleCurrentBranchId, type);
	}

	// Token: 0x06012805 RID: 75781 RVA: 0x005781CC File Offset: 0x005763CC
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

	// Token: 0x06012806 RID: 75782 RVA: 0x00578244 File Offset: 0x00576444
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
		int[] array = new int[unlockOrnamentIds.Count];
		unlockOrnamentIds.CopyTo(array, 0);
		RoleOrnamentModel.Instance.UpdateOwnOrnament(array);
		RoleOrnamentModel.Instance.UpdateWearOrnament(ornamentDressInfos);
		int[] array2 = new int[redPointOrnamentIds.Count];
		redPointOrnamentIds.CopyTo(array2, 0);
		RoleOrnamentModel.Instance.UpdateNewlyAddedOrnament(array2);
		if (RoleOrnamentModel.Instance.GetIsCommonItemFinished())
		{
			int[] array3 = new int[unlockOrnamentIds.Count];
			unlockOrnamentIds.CopyTo(array3, 0);
			InventoryController.Instance.InitOrnamentItemData(array3);
			return;
		}
		int[] array4 = new int[unlockOrnamentIds.Count];
		unlockOrnamentIds.CopyTo(array4, 0);
		RoleOrnamentModel.Instance.SetPendingOrnamentIdsForInit(array4);
	}

	// Token: 0x06012807 RID: 75783 RVA: 0x00578314 File Offset: 0x00576514
	[NullableContext(2)]
	private void OnOrnamentUnlockNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<int> unlockOrnamentIds = ((OrnamentUnlockNotify)msg).UnlockOrnamentIds;
		if (RoleOrnamentModel.Instance.GetIsCommonItemFinished())
		{
			int[] array = new int[unlockOrnamentIds.Count];
			unlockOrnamentIds.CopyTo(array, 0);
			RoleController.ProcessOrnamentUnlock(array);
			return;
		}
		int[] array2 = new int[unlockOrnamentIds.Count];
		unlockOrnamentIds.CopyTo(array2, 0);
		RoleOrnamentModel.Instance.AddPendingOrnamentUnlockBatch(array2);
	}

	// Token: 0x06012808 RID: 75784 RVA: 0x00578374 File Offset: 0x00576574
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

	// Token: 0x06012809 RID: 75785 RVA: 0x005783FC File Offset: 0x005765FC
	[NullableContext(2)]
	private void OnOrnamentDressInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<OrnamentDressInfo> ornamentDressInfos = ((OrnamentDressInfoUpdateNotify)msg).OrnamentDressInfos;
		RoleOrnamentModel.Instance.UpdateWearOrnament(ornamentDressInfos);
		EventSystem.Instance.Emit(EEventName.OnOrnamentChange);
	}

	// Token: 0x0601280A RID: 75786 RVA: 0x00578430 File Offset: 0x00576630
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

	// Token: 0x0601280B RID: 75787 RVA: 0x00578484 File Offset: 0x00576684
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(changeOrnamentResponse.ErrorCode, 23664, null, true, true);
				return;
			}
			string textId = isDress ? "OrnamentUiText_05" : "OrnamentUiText_06";
			ScrollingTipsController.Instance.ShowTipsByTextId(textId, Array.Empty<object>());
		}, 0);
	}

	// Token: 0x0601280C RID: 75788 RVA: 0x005784E8 File Offset: 0x005766E8
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

	// Token: 0x0601280D RID: 75789 RVA: 0x005785DC File Offset: 0x005767DC
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

	// Token: 0x0601280E RID: 75790 RVA: 0x00578634 File Offset: 0x00576834
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

	// Token: 0x0601280F RID: 75791 RVA: 0x0057875C File Offset: 0x0057695C
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

	// Token: 0x06012810 RID: 75792 RVA: 0x005787E0 File Offset: 0x005769E0
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

	// Token: 0x06012811 RID: 75793 RVA: 0x005788AC File Offset: 0x00576AAC
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

	// Token: 0x06012812 RID: 75794 RVA: 0x005788F4 File Offset: 0x00576AF4
	public UniTask RequestRoleDevelopConfig()
	{
		RoleController.<RequestRoleDevelopConfig>d__74 <RequestRoleDevelopConfig>d__;
		<RequestRoleDevelopConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRoleDevelopConfig>d__.<>1__state = -1;
		<RequestRoleDevelopConfig>d__.<>t__builder.Start<RoleController.<RequestRoleDevelopConfig>d__74>(ref <RequestRoleDevelopConfig>d__);
		return <RequestRoleDevelopConfig>d__.<>t__builder.Task;
	}

	// Token: 0x06012813 RID: 75795 RVA: 0x00578930 File Offset: 0x00576B30
	public UniTask RequestRoleDevelopDependentData()
	{
		RoleController.<RequestRoleDevelopDependentData>d__75 <RequestRoleDevelopDependentData>d__;
		<RequestRoleDevelopDependentData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRoleDevelopDependentData>d__.<>4__this = this;
		<RequestRoleDevelopDependentData>d__.<>1__state = -1;
		<RequestRoleDevelopDependentData>d__.<>t__builder.Start<RoleController.<RequestRoleDevelopDependentData>d__75>(ref <RequestRoleDevelopDependentData>d__);
		return <RequestRoleDevelopDependentData>d__.<>t__builder.Task;
	}

	// Token: 0x06012814 RID: 75796 RVA: 0x00578974 File Offset: 0x00576B74
	public UniTask RequestTeamRecommendData()
	{
		RoleController.<RequestTeamRecommendData>d__76 <RequestTeamRecommendData>d__;
		<RequestTeamRecommendData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestTeamRecommendData>d__.<>1__state = -1;
		<RequestTeamRecommendData>d__.<>t__builder.Start<RoleController.<RequestTeamRecommendData>d__76>(ref <RequestTeamRecommendData>d__);
		return <RequestTeamRecommendData>d__.<>t__builder.Task;
	}

	// Token: 0x06012815 RID: 75797 RVA: 0x005789B0 File Offset: 0x00576BB0
	public void RequestRoleDevelopVisionRecommendData()
	{
		foreach (RoleDevelopData roleDevelopData in RoleDevelopModel.Instance.GetNormalRoleDevelopData())
		{
			int id = roleDevelopData.GetId();
			VisionRecommendController.Instance.RequestRoleVisionRecommendData(id);
			VisionRecommendController.Instance.RequestRoleVisionRecommendAttr(id);
		}
	}

	// Token: 0x06012816 RID: 75798 RVA: 0x00578A1C File Offset: 0x00576C1C
	public void RequestUpdateDevelopTarget(int roleId, ERoleDevelopUpdateTargetSource source, int? fetterGroupId = null, int? firstPhantomId = null)
	{
		RoleUpdateDevelopTargetRequest roleUpdateDevelopTargetRequest = RoleUpdateDevelopTargetRequest.Create();
		roleUpdateDevelopTargetRequest.RoleId = roleId;
		roleUpdateDevelopTargetRequest.Source = (int)source;
		roleUpdateDevelopTargetRequest.PlanId = fetterGroupId.GetValueOrDefault();
		roleUpdateDevelopTargetRequest.FirstPhantomId = firstPhantomId.GetValueOrDefault();
		int roleId2 = (roleId != 0) ? roleId : RoleDevelopModel.Instance.DevTargetRoleId;
		roleUpdateDevelopTargetRequest.Core = ((RoleDevelopUtil.IsKeyPropertyReached(roleId2) > false) ? 1 : 0);
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(roleUpdateDevelopTargetResponse.ErrorCode, 29614, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06012817 RID: 75799 RVA: 0x00578AA8 File Offset: 0x00576CA8
	public static void OpenRoleDevelopView(int? roleId)
	{
		RoleDevelopRootViewData roleDevelopRootViewData = new RoleDevelopRootViewData();
		roleDevelopRootViewData.RoleId = roleId;
		UiManager.Instance.OpenView(EUiViewName.RoleDevelopRootView, roleDevelopRootViewData, null);
	}

	// Token: 0x06012818 RID: 75800 RVA: 0x00578AD4 File Offset: 0x00576CD4
	public static void OpenRoleDevelopSelectTargetView(ERoleDevelopUpdateTargetSource source, int? roleId = null)
	{
		RoleDevelopSelectTargetViewData roleDevelopSelectTargetViewData = new RoleDevelopSelectTargetViewData();
		roleDevelopSelectTargetViewData.RoleId = roleId;
		roleDevelopSelectTargetViewData.Source = source;
		UiManager.Instance.OpenView(EUiViewName.RoleDevelopSelectTargetView, roleDevelopSelectTargetViewData, null);
	}

	// Token: 0x06012819 RID: 75801 RVA: 0x00578B06 File Offset: 0x00576D06
	public void LogRoleDevelopClick(int roleId, ERoleDevelopCategoryType mainPage, ERoleDevelopLogSubPage subPage, ERoleDevelopLogItemState? itemState = null)
	{
		this.PushRoleDevLog(roleId, mainPage, (int)subPage, itemState);
	}

	// Token: 0x0601281A RID: 75802 RVA: 0x00578B14 File Offset: 0x00576D14
	public void LogRoleDevelopSwitchPage(int roleId, ERoleDevelopCategoryType mainPage)
	{
		this.PushRoleDevLog(roleId, mainPage, 0, null);
	}

	// Token: 0x0601281B RID: 75803 RVA: 0x00578B34 File Offset: 0x00576D34
	private void PushRoleDevLog(int roleId, ERoleDevelopCategoryType mainPage, int subPage, ERoleDevelopLogItemState? itemState)
	{
		RoleDevLogEvent roleDevLogEvent = new RoleDevLogEvent();
		roleDevLogEvent.i_role_id = roleId;
		roleDevLogEvent.i_role_type = ((RoleModel.Instance.IsRoleOwned(roleId) > false) ? 1 : 0);
		roleDevLogEvent.i_main_page = (int)mainPage;
		roleDevLogEvent.i_sub_page = subPage;
		roleDevLogEvent.i_type = (int)((itemState != null) ? itemState.Value : ERoleDevelopLogItemState.Normal);
		roleDevLogEvent.i_status = RoleController.GetRoleDevelopLogStatus(RoleDevelopUtil.GetCategoryHintType(roleId, mainPage));
		roleDevLogEvent.i_core = ((RoleDevelopUtil.IsKeyPropertyReached(roleId) > false) ? 1 : 0);
		LogController.Instance.LogRoleDevPush(roleDevLogEvent);
	}

	// Token: 0x0601281C RID: 75804 RVA: 0x00578BB5 File Offset: 0x00576DB5
	private static int GetRoleDevelopLogStatus(ERoleDevelopCategoryHintType hintType)
	{
		switch (hintType)
		{
		case ERoleDevelopCategoryHintType.Finish:
			return 1;
		case ERoleDevelopCategoryHintType.Upgrade:
			return 3;
		case ERoleDevelopCategoryHintType.CanImprove:
			return 2;
		default:
			return 0;
		}
	}

	// Token: 0x0601281D RID: 75805 RVA: 0x00578BD4 File Offset: 0x00576DD4
	public void LogRoleDevelopSkillRecommendClick(int roleId, bool isActive)
	{
		RoleDevelopSkillRecommendClickLogEvent roleDevelopSkillRecommendClickLogEvent = new RoleDevelopSkillRecommendClickLogEvent();
		roleDevelopSkillRecommendClickLogEvent.i_role_id = roleId;
		roleDevelopSkillRecommendClickLogEvent.i_operation = ((isActive > false) ? 1 : 0);
		LogReportController.Instance.LogReport(roleDevelopSkillRecommendClickLogEvent);
	}

	// Token: 0x0601281E RID: 75806 RVA: 0x00578C03 File Offset: 0x00576E03
	public bool CanOpenRoleDevelopView(EUiViewName viewName, object arg = null)
	{
		return FunctionModel.Instance.IsOpen(EFunctionType.RoleDev);
	}

	// Token: 0x0601281F RID: 75807 RVA: 0x00578C1C File Offset: 0x00576E1C
	[NullableContext(0)]
	public UniTask<bool> RequestPlayerVoiceLanguage()
	{
		RoleController.<RequestPlayerVoiceLanguage>d__87 <RequestPlayerVoiceLanguage>d__;
		<RequestPlayerVoiceLanguage>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestPlayerVoiceLanguage>d__.<>1__state = -1;
		<RequestPlayerVoiceLanguage>d__.<>t__builder.Start<RoleController.<RequestPlayerVoiceLanguage>d__87>(ref <RequestPlayerVoiceLanguage>d__);
		return <RequestPlayerVoiceLanguage>d__.<>t__builder.Task;
	}

	// Token: 0x06012820 RID: 75808 RVA: 0x00578C58 File Offset: 0x00576E58
	[NullableContext(0)]
	public UniTask<bool> RequestPlayerRoleVoiceSet([Nullable(1)] List<RoleVoiceSetting> roleList)
	{
		RoleController.<RequestPlayerRoleVoiceSet>d__88 <RequestPlayerRoleVoiceSet>d__;
		<RequestPlayerRoleVoiceSet>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestPlayerRoleVoiceSet>d__.roleList = roleList;
		<RequestPlayerRoleVoiceSet>d__.<>1__state = -1;
		<RequestPlayerRoleVoiceSet>d__.<>t__builder.Start<RoleController.<RequestPlayerRoleVoiceSet>d__88>(ref <RequestPlayerRoleVoiceSet>d__);
		return <RequestPlayerRoleVoiceSet>d__.<>t__builder.Task;
	}

	// Token: 0x17001B7E RID: 7038
	// (get) Token: 0x06012821 RID: 75809 RVA: 0x00578C9B File Offset: 0x00576E9B
	public static RoleController Instance
	{
		get
		{
			return RoleController._Instance;
		}
	}

	// Token: 0x06012822 RID: 75810 RVA: 0x00578CA2 File Offset: 0x00576EA2
	public static RoleController GetOrCreateInstance()
	{
		if (RoleController._Instance == null)
		{
			RoleController.CreateInstance();
		}
		return RoleController._Instance;
	}

	// Token: 0x06012823 RID: 75811 RVA: 0x00578CB6 File Offset: 0x00576EB6
	public static bool CreateInstance()
	{
		if (RoleController._Instance != null)
		{
			return true;
		}
		RoleController._Instance = new RoleController();
		return true;
	}

	// Token: 0x06012824 RID: 75812 RVA: 0x00578CCC File Offset: 0x00576ECC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012825 RID: 75813 RVA: 0x00578CCE File Offset: 0x00576ECE
	public static void ResetStaticDefaultValue()
	{
		RoleController._Instance = null;
	}

	// Token: 0x06012826 RID: 75814 RVA: 0x00578CD6 File Offset: 0x00576ED6
	static RoleController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleController.CreateStaticDefaultValue), new Action(RoleController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A0D3 RID: 41171
	private readonly Action OpenRoleMainViewByInput = delegate()
	{
		RoleController.Instance.OpenRoleMainViewByParam(new OpenRoleMainViewData
		{
			AgentType = ERoleAgentType.Normal,
			UseMainViewSort = true
		});
	};

	// Token: 0x0400A0D4 RID: 41172
	[Nullable(2)]
	private static RoleController _Instance;
}
