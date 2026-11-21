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

// Token: 0x0200106E RID: 4206
[NullableContext(1)]
[Nullable(0)]
public class FormationController : UiControllerBase
{
	// Token: 0x0600A74D RID: 42829 RVA: 0x00314320 File Offset: 0x00312520
	protected override bool OnClear()
	{
		this.ClearPreloadedFormationUi();
		BattleTeamModel.Instance.ResetAllSlots();
		return true;
	}

	// Token: 0x0600A74E RID: 42830 RVA: 0x00314333 File Offset: 0x00312533
	protected override void OnAddEvents()
	{
		FormationEventBridge.RegisterAll();
	}

	// Token: 0x0600A74F RID: 42831 RVA: 0x0031433A File Offset: 0x0031253A
	protected override void OnRemoveEvents()
	{
		FormationEventBridge.UnregisterAll();
	}

	// Token: 0x0600A750 RID: 42832 RVA: 0x00314341 File Offset: 0x00312541
	protected override void OnRegisterNetEvent()
	{
		FormationNetHandler.RegisterNetEvent();
	}

	// Token: 0x0600A751 RID: 42833 RVA: 0x00314348 File Offset: 0x00312548
	protected override void OnUnRegisterNetEvent()
	{
		FormationNetHandler.UnregisterNetEvent();
	}

	// Token: 0x0600A752 RID: 42834 RVA: 0x00314350 File Offset: 0x00312550
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.Formation2DView, new Func<EUiViewName, object, bool>(this.CanOpenView), "FormationController");
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.Formation3DView, new Func<EUiViewName, object, bool>(this.CanOpenView), "FormationController");
	}

	// Token: 0x0600A753 RID: 42835 RVA: 0x0031439D File Offset: 0x0031259D
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.Formation2DView, new Func<EUiViewName, object, bool>(this.CanOpenView));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.Formation3DView, new Func<EUiViewName, object, bool>(this.CanOpenView));
	}

	// Token: 0x0600A754 RID: 42836 RVA: 0x003143D8 File Offset: 0x003125D8
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

	// Token: 0x0600A755 RID: 42837 RVA: 0x00314420 File Offset: 0x00312620
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
		this.RealOpenBattleTeamView(isHideTitle, flag.GetValueOrDefault());
	}

	// Token: 0x0600A756 RID: 42838 RVA: 0x00314500 File Offset: 0x00312700
	private void RealOpenBattleTeamView(bool isHideTitle, bool canUseSpecialTrailRole)
	{
		IEditBattleTeamViewParam param = new IEditBattleTeamViewParam
		{
			IsHideTitle = isHideTitle,
			CanUseSpecialTrailRole = canUseSpecialTrailRole
		};
		UiManager.Instance.OpenView(EUiViewName.BattleTeam2DView, param, null);
	}

	// Token: 0x0600A757 RID: 42839 RVA: 0x00314532 File Offset: 0x00312732
	public void CloseBattleTeamView()
	{
		BattleTeamModel.Instance.ResetAllSlots();
		if (UiManager.Instance.IsViewShow(EUiViewName.BattleTeam2DView))
		{
			UiManager.Instance.CloseView(EUiViewName.BattleTeam2DView, null);
		}
	}

	// Token: 0x0600A758 RID: 42840 RVA: 0x00314560 File Offset: 0x00312760
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

	// Token: 0x0600A759 RID: 42841 RVA: 0x00314646 File Offset: 0x00312846
	public void SetBattleTeam(int[] roleIdArray)
	{
		BattleTeamModel.Instance.ApplyRoleIdList(roleIdArray, true);
	}

	// Token: 0x0600A75A RID: 42842 RVA: 0x00314654 File Offset: 0x00312854
	public void RefreshMainRoleInfo()
	{
		BattleTeamModel.Instance.ChangeMainRoleData();
		FormationModel.Instance.ChangeEditedMainRole();
	}

	// Token: 0x0600A75B RID: 42843 RVA: 0x0031466C File Offset: 0x0031286C
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

	// Token: 0x0600A75C RID: 42844 RVA: 0x0031471C File Offset: 0x0031291C
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

	// Token: 0x0600A75D RID: 42845 RVA: 0x00314750 File Offset: 0x00312950
	public bool GetUseFormation3DView()
	{
		return !Info.Instance.IsLowMemoryDevice && LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.UseFormation3DView, false);
	}

	// Token: 0x0600A75E RID: 42846 RVA: 0x0031476B File Offset: 0x0031296B
	public void SetUseFormation3DView(bool use3dView)
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.UseFormation3DView, use3dView);
	}

	// Token: 0x0600A75F RID: 42847 RVA: 0x0031477C File Offset: 0x0031297C
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

	// Token: 0x0600A760 RID: 42848 RVA: 0x003147FB File Offset: 0x003129FB
	public long? TakeFormationViewOpenStartTimeMs()
	{
		long? formationViewOpenStartTimeMs = this.FormationViewOpenStartTimeMs;
		this.FormationViewOpenStartTimeMs = null;
		return formationViewOpenStartTimeMs;
	}

	// Token: 0x0600A761 RID: 42849 RVA: 0x00314810 File Offset: 0x00312A10
	[NullableContext(2)]
	public void OpenRenameFormationInputView(int formationId, Action onRenameSuccess = null)
	{
		FormationController.<>c__DisplayClass25_0 CS$<>8__locals1 = new FormationController.<>c__DisplayClass25_0();
		CS$<>8__locals1.formationId = formationId;
		CS$<>8__locals1.onRenameSuccess = onRenameSuccess;
		FormationData formationData = FormationModel.Instance.GetFormationData(CS$<>8__locals1.formationId);
		string text = ((formationData != null) ? formationData.Name : null) ?? string.Empty;
		string currentDisplayName = StringUtils.IsEmpty(text) ? (ConfigMultiTextLang.GetLocalTextNew("PrefabTextItem_3608949261_Text", null) ?? string.Empty) : text;
		CommonInputViewController.Instance.OpenRenameFormationInputView(delegate([Nullable(1)] string input)
		{
			FormationController.<>c__DisplayClass25_0.<<OpenRenameFormationInputView>b__0>d <<OpenRenameFormationInputView>b__0>d;
			<<OpenRenameFormationInputView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
			<<OpenRenameFormationInputView>b__0>d.<>4__this = CS$<>8__locals1;
			<<OpenRenameFormationInputView>b__0>d.input = input;
			<<OpenRenameFormationInputView>b__0>d.<>1__state = -1;
			<<OpenRenameFormationInputView>b__0>d.<>t__builder.Start<FormationController.<>c__DisplayClass25_0.<<OpenRenameFormationInputView>b__0>d>(ref <<OpenRenameFormationInputView>b__0>d);
			return <<OpenRenameFormationInputView>b__0>d.<>t__builder.Task;
		}, text, currentDisplayName);
	}

	// Token: 0x1700118E RID: 4494
	// (get) Token: 0x0600A762 RID: 42850 RVA: 0x0031488F File Offset: 0x00312A8F
	public static FormationController Instance
	{
		get
		{
			return FormationController._Instance;
		}
	}

	// Token: 0x0600A763 RID: 42851 RVA: 0x00314896 File Offset: 0x00312A96
	public static FormationController GetOrCreateInstance()
	{
		if (FormationController._Instance == null)
		{
			FormationController.CreateInstance();
		}
		return FormationController._Instance;
	}

	// Token: 0x0600A764 RID: 42852 RVA: 0x003148AA File Offset: 0x00312AAA
	public static bool CreateInstance()
	{
		if (FormationController._Instance != null)
		{
			return true;
		}
		FormationController._Instance = new FormationController();
		return true;
	}

	// Token: 0x0600A765 RID: 42853 RVA: 0x003148C0 File Offset: 0x00312AC0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A766 RID: 42854 RVA: 0x003148C2 File Offset: 0x00312AC2
	public static void ResetStaticDefaultValue()
	{
		FormationController._Instance = null;
	}

	// Token: 0x0600A767 RID: 42855 RVA: 0x003148CA File Offset: 0x00312ACA
	static FormationController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationController.CreateStaticDefaultValue), new Action(FormationController.ResetStaticDefaultValue));
	}

	// Token: 0x04006189 RID: 24969
	private const bool DEFAULT_USE_FORMATION_3D_VIEW = false;

	// Token: 0x0400618A RID: 24970
	private long? FormationViewOpenStartTimeMs;

	// Token: 0x0400618B RID: 24971
	[Nullable(2)]
	private UPrefabAsset PreloadedFormationUi;

	// Token: 0x0400618C RID: 24972
	private string PreloadedFormationUiPath = string.Empty;

	// Token: 0x0400618D RID: 24973
	private int FormationUiPreloadId = -1;

	// Token: 0x0400618E RID: 24974
	[Nullable(2)]
	private static FormationController _Instance;
}
