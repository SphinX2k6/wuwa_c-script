using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Common.InputView.Controller;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BAF RID: 7087
[NullableContext(1)]
[Nullable(0)]
public class FormationController : UiControllerBase
{
	// Token: 0x0600D33C RID: 54076 RVA: 0x00309240 File Offset: 0x00307440
	protected override bool OnClear()
	{
		this.ClearPreloadedFormationUi();
		BattleTeamModel.Instance.ResetAllSlots();
		return true;
	}

	// Token: 0x0600D33D RID: 54077 RVA: 0x00309253 File Offset: 0x00307453
	protected override void OnAddEvents()
	{
		FormationEventBridge.RegisterAll();
	}

	// Token: 0x0600D33E RID: 54078 RVA: 0x0030925A File Offset: 0x0030745A
	protected override void OnRemoveEvents()
	{
		FormationEventBridge.UnregisterAll();
	}

	// Token: 0x0600D33F RID: 54079 RVA: 0x00309261 File Offset: 0x00307461
	protected override void OnRegisterNetEvent()
	{
		FormationNetHandler.RegisterNetEvent();
	}

	// Token: 0x0600D340 RID: 54080 RVA: 0x00309268 File Offset: 0x00307468
	protected override void OnUnRegisterNetEvent()
	{
		FormationNetHandler.UnregisterNetEvent();
	}

	// Token: 0x0600D341 RID: 54081 RVA: 0x00309270 File Offset: 0x00307470
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.Formation2DView, new Func<EUiViewName, object, bool>(this.CanOpenView), "FormationController");
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.Formation3DView, new Func<EUiViewName, object, bool>(this.CanOpenView), "FormationController");
	}

	// Token: 0x0600D342 RID: 54082 RVA: 0x003092BD File Offset: 0x003074BD
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.Formation2DView, new Func<EUiViewName, object, bool>(this.CanOpenView));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.Formation3DView, new Func<EUiViewName, object, bool>(this.CanOpenView));
	}

	// Token: 0x0600D343 RID: 54083 RVA: 0x003092F8 File Offset: 0x003074F8
	public bool CanOpenView(EUiViewName viewName, object param)
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.Formation2DView) || UiManager.Instance.IsViewOpen(EUiViewName.Formation3DView))
		{
			return true;
		}
		EOpenViewBlockReason eopenViewBlockReason = FormationValidators.CanOpenFormationViewChain.Run();
		if (eopenViewBlockReason == EOpenViewBlockReason.None)
		{
			return true;
		}
		FormationValidators.ApplyOpenViewBlockReason(eopenViewBlockReason);
		return false;
	}

	// Token: 0x0600D344 RID: 54084 RVA: 0x00309340 File Offset: 0x00307540
	public void OpenBattleTeamView(int instanceDungeonId, bool isMulti = false, bool isNeedEntrance = true, bool isHideTitle = false, bool? canUseSpecialTrailRole = null)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		if (!isMulti)
		{
			instance.NeedEntrance = isNeedEntrance;
		}
		bool? flag = canUseSpecialTrailRole;
		if (flag == null)
		{
			flag = new bool?(RoleModel.Instance.CanUseSpecialTrialRole(new int?(instanceDungeonId)));
		}
		if (InstanceDungeonConfig.Instance.GetConfig(instanceDungeonId) == null)
		{
			Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "[BattleTeam]找不到副本数据，不能打开战前编队", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		instance.Context.SetInstanceDungeonId(new int?(instanceDungeonId));
		if (instance.Context.IsMultiInstanceDungeon && InstanceDungeonModel.Instance.MatchingPlayerCount() <= 0)
		{
			Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "打开战前编队时，数据已经被清理，操作中止", default(ReadOnlySpan<ValueTuple<string, object>>));
			instance.Context.SetInstanceDungeonId(null);
			return;
		}
		IEditBattleTeamViewParam param = new IEditBattleTeamViewParam
		{
			IsHideTitle = isHideTitle,
			CanUseSpecialTrailRole = flag.GetValueOrDefault()
		};
		UiManager.Instance.OpenView(EUiViewName.BattleTeam2DView, param, null);
	}

	// Token: 0x0600D345 RID: 54085 RVA: 0x0030943D File Offset: 0x0030763D
	public void CloseBattleTeamView()
	{
		BattleTeamModel.Instance.ResetAllSlots();
		if (UiManager.Instance.IsViewShow(EUiViewName.BattleTeam2DView))
		{
			UiManager.Instance.CloseView(EUiViewName.BattleTeam2DView, null);
		}
	}

	// Token: 0x0600D346 RID: 54086 RVA: 0x0030946C File Offset: 0x0030766C
	public void ExitBattleTeam(bool bRequest = true)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		if (instance.Context.IsMultiInstanceDungeon && bRequest)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Formation;
			ELogAuthor author = ELogAuthor.SYB;
			string message = "[BattleTeam]离开{DungeonId} 副本的战前编队";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("{DungeonId}", instance.Context.InstanceDungeonId);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			InstanceDungeonEntranceController.Instance.LeaveMatchTeamRequest();
		}
		instance.Context.SetInstanceDungeonId(null);
		instance.SetLeaderPlayerId(null);
		if (UiManager.Instance.IsViewShow(EUiViewName.ChatView))
		{
			UiManager.Instance.CloseView(EUiViewName.ChatView, delegate(bool _)
			{
				this.CloseBattleTeamView();
			});
			return;
		}
		if (UiManager.Instance.IsViewShow(EUiViewName.TeamRoleSelectView))
		{
			UiManager.Instance.CloseView(EUiViewName.TeamRoleSelectView, delegate(bool _)
			{
				this.CloseBattleTeamView();
			});
			return;
		}
		this.CloseBattleTeamView();
	}

	// Token: 0x0600D347 RID: 54087 RVA: 0x00309552 File Offset: 0x00307752
	public void SetBattleTeam(int[] roleIdArray)
	{
		BattleTeamModel.Instance.ApplyRoleIdList(roleIdArray, true);
	}

	// Token: 0x0600D348 RID: 54088 RVA: 0x00309560 File Offset: 0x00307760
	public void RefreshMainRoleInfo()
	{
		BattleTeamModel.Instance.ChangeMainRoleData();
		FormationModel.Instance.ChangeEditedMainRole();
	}

	// Token: 0x0600D349 RID: 54089 RVA: 0x00309578 File Offset: 0x00307778
	public void PreloadFormationUi()
	{
		if (!this.GetUseFormation3DView())
		{
			this.ClearPreloadedFormationUi();
			return;
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("UiView_TeamB");
		if (string.IsNullOrEmpty(resourcePath))
		{
			return;
		}
		if (this.PreloadedFormationUiPath == resourcePath)
		{
			UPrefabAsset preloadedFormationUi = this.PreloadedFormationUi;
			if ((preloadedFormationUi != null && preloadedFormationUi.IsValid()) || this.FormationUiPreloadId != -1)
			{
				return;
			}
		}
		this.ClearPreloadedFormationUi();
		this.PreloadedFormationUiPath = resourcePath;
		bool isCompleted = false;
		int formationUiPreloadId = ResourceSystem.Instance.LoadAsync<UPrefabAsset>(resourcePath, delegate([Nullable(2)] UPrefabAsset asset, string _)
		{
			isCompleted = true;
			this.FormationUiPreloadId = -1;
			this.PreloadedFormationUi = asset;
		}, ResourceSystem.EResourceLoadPriority.Preload, "Ui.FormationUi");
		if (!isCompleted)
		{
			this.FormationUiPreloadId = formationUiPreloadId;
		}
	}

	// Token: 0x0600D34A RID: 54090 RVA: 0x00309628 File Offset: 0x00307828
	private void ClearPreloadedFormationUi()
	{
		if (this.FormationUiPreloadId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.FormationUiPreloadId);
			this.FormationUiPreloadId = -1;
		}
		this.PreloadedFormationUi = null;
		this.PreloadedFormationUiPath = string.Empty;
	}

	// Token: 0x0600D34B RID: 54091 RVA: 0x0030965C File Offset: 0x0030785C
	public bool GetUseFormation3DView()
	{
		return !Info.Instance.IsLowMemoryDevice && LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.UseFormation3DView, false);
	}

	// Token: 0x0600D34C RID: 54092 RVA: 0x00309677 File Offset: 0x00307877
	public void SetUseFormation3DView(bool use3dView)
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.UseFormation3DView, use3dView);
	}

	// Token: 0x0600D34D RID: 54093 RVA: 0x00309688 File Offset: 0x00307888
	[NullableContext(2)]
	public void OpenFormationView(object param = null, TOpenViewCallBack finishCallback = null)
	{
		EUiViewName euiViewName = this.GetUseFormation3DView() ? EUiViewName.Formation3DView : EUiViewName.Formation2DView;
		long startTimeMs = DateTimeOffset.Now.ToUnixTimeMilliseconds();
		if (!UiManager.Instance.IsViewOpen(euiViewName))
		{
			this.FormationViewOpenStartTimeMs = new long?(startTimeMs);
		}
		UiManager.Instance.OpenView(euiViewName, param, delegate(bool success, int viewId)
		{
			long? formationViewOpenStartTimeMs = this.FormationViewOpenStartTimeMs;
			long startTimeMs = startTimeMs;
			if (formationViewOpenStartTimeMs.GetValueOrDefault() == startTimeMs & formationViewOpenStartTimeMs != null)
			{
				this.FormationViewOpenStartTimeMs = null;
			}
			TOpenViewCallBack finishCallback2 = finishCallback;
			if (finishCallback2 == null)
			{
				return;
			}
			finishCallback2(success, viewId);
		});
	}

	// Token: 0x0600D34E RID: 54094 RVA: 0x00309707 File Offset: 0x00307907
	public long? TakeFormationViewOpenStartTimeMs()
	{
		long? formationViewOpenStartTimeMs = this.FormationViewOpenStartTimeMs;
		this.FormationViewOpenStartTimeMs = null;
		return formationViewOpenStartTimeMs;
	}

	// Token: 0x0600D34F RID: 54095 RVA: 0x0030971C File Offset: 0x0030791C
	[NullableContext(2)]
	public void OpenRenameFormationInputView(int formationId, Action onRenameSuccess = null)
	{
		FormationController.<>c__DisplayClass24_0 CS$<>8__locals1 = new FormationController.<>c__DisplayClass24_0();
		CS$<>8__locals1.formationId = formationId;
		CS$<>8__locals1.onRenameSuccess = onRenameSuccess;
		FormationData formationData = FormationModel.Instance.GetFormationData(CS$<>8__locals1.formationId);
		string text = ((formationData != null) ? formationData.Name : null) ?? string.Empty;
		string currentDisplayName = StringUtils.IsEmpty(text) ? (ConfigMultiTextLang.GetLocalTextNew("PrefabTextItem_3608949261_Text", null) ?? string.Empty) : text;
		CommonInputViewController.Instance.OpenRenameFormationInputView(delegate([Nullable(1)] string input)
		{
			FormationController.<>c__DisplayClass24_0.<<OpenRenameFormationInputView>b__0>d <<OpenRenameFormationInputView>b__0>d;
			<<OpenRenameFormationInputView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
			<<OpenRenameFormationInputView>b__0>d.<>4__this = CS$<>8__locals1;
			<<OpenRenameFormationInputView>b__0>d.input = input;
			<<OpenRenameFormationInputView>b__0>d.<>1__state = -1;
			<<OpenRenameFormationInputView>b__0>d.<>t__builder.Start<FormationController.<>c__DisplayClass24_0.<<OpenRenameFormationInputView>b__0>d>(ref <<OpenRenameFormationInputView>b__0>d);
			return <<OpenRenameFormationInputView>b__0>d.<>t__builder.Task;
		}, text, currentDisplayName);
	}

	// Token: 0x17001169 RID: 4457
	// (get) Token: 0x0600D350 RID: 54096 RVA: 0x0030979B File Offset: 0x0030799B
	public static FormationController Instance
	{
		get
		{
			return FormationController._Instance;
		}
	}

	// Token: 0x0600D351 RID: 54097 RVA: 0x003097A2 File Offset: 0x003079A2
	public static FormationController GetOrCreateInstance()
	{
		if (FormationController._Instance == null)
		{
			FormationController.CreateInstance();
		}
		return FormationController._Instance;
	}

	// Token: 0x0600D352 RID: 54098 RVA: 0x003097B6 File Offset: 0x003079B6
	public static bool CreateInstance()
	{
		if (FormationController._Instance != null)
		{
			return true;
		}
		FormationController._Instance = new FormationController();
		return true;
	}

	// Token: 0x0600D353 RID: 54099 RVA: 0x003097CC File Offset: 0x003079CC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D354 RID: 54100 RVA: 0x003097CE File Offset: 0x003079CE
	public static void ResetStaticDefaultValue()
	{
		FormationController._Instance = null;
	}

	// Token: 0x0600D355 RID: 54101 RVA: 0x003097D6 File Offset: 0x003079D6
	static FormationController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationController.CreateStaticDefaultValue), new Action(FormationController.ResetStaticDefaultValue));
	}

	// Token: 0x040060BA RID: 24762
	private const bool DEFAULT_USE_FORMATION_3D_VIEW = false;

	// Token: 0x040060BB RID: 24763
	private long? FormationViewOpenStartTimeMs;

	// Token: 0x040060BC RID: 24764
	[Nullable(2)]
	private UPrefabAsset PreloadedFormationUi;

	// Token: 0x040060BD RID: 24765
	private string PreloadedFormationUiPath = string.Empty;

	// Token: 0x040060BE RID: 24766
	private int FormationUiPreloadId = -1;

	// Token: 0x040060BF RID: 24767
	[Nullable(2)]
	private static FormationController _Instance;
}
