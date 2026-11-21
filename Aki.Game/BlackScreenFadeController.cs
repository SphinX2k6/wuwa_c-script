using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000BC5 RID: 3013
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BlackScreenFadeController : UiControllerBase
{
	// Token: 0x17000E21 RID: 3617
	// (get) Token: 0x06007D0A RID: 32010 RVA: 0x0026B440 File Offset: 0x00269640
	// (set) Token: 0x06007D0B RID: 32011 RVA: 0x0026B448 File Offset: 0x00269648
	public bool NeedGuarantee
	{
		get
		{
			return this.NeedGuaranteeInternal;
		}
		set
		{
			this.NeedGuaranteeInternal = value;
		}
	}

	// Token: 0x06007D0C RID: 32012 RVA: 0x0026B451 File Offset: 0x00269651
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.UiManagerInit, new Action(this.PreloadBlackFadeScreen));
		EventSystem.Instance.Add<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
	}

	// Token: 0x06007D0D RID: 32013 RVA: 0x0026B488 File Offset: 0x00269688
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.UiManagerInit, new Action(this.PreloadBlackFadeScreen));
		EventSystem.Instance.Remove(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
	}

	// Token: 0x06007D0E RID: 32014 RVA: 0x0026B4BF File Offset: 0x002696BF
	private void PreloadBlackFadeScreen()
	{
		if (this.BlackScreen != null)
		{
			return;
		}
		this.BlackScreen = new BlackScreenFadeView();
		this.BlackScreen.CreateByResourceIdAsync("UiView_BlackFadeScreen_Prefab", UiLayer.Instance.GetFloatUnit(ELayerType.Loading, 0), true);
	}

	// Token: 0x06007D0F RID: 32015 RVA: 0x0026B4F8 File Offset: 0x002696F8
	private void OnTeamLivingStateChange(bool isMyTeam, ETeamGroupType groupType, ETeamLivingState state, ETeamLivingState oldState)
	{
		if (isMyTeam && groupType == ETeamGroupType.Battle && state == ETeamLivingState.Dead)
		{
			LevelLoadingController.Instance.CloseAllBlackScreenLoading();
			global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "OnAllDead关闭黑幕", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x06007D10 RID: 32016 RVA: 0x0026B53C File Offset: 0x0026973C
	[NullableContext(2)]
	public bool CheckCanOpen(EUiViewName viewName, object param)
	{
		UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(viewName);
		return uiViewInfo != null && (uiViewInfo.Type != ELayerType.Normal || !this.NotEnableViews.Contains(viewName));
	}

	// Token: 0x06007D11 RID: 32017 RVA: 0x0026B574 File Offset: 0x00269774
	public void AddFadeBlackScreen(float num, bool needBackToFight, bool needCheckOpenView, int? treeId, string tag)
	{
		LevelLoadingModel.Instance.CameraFadeShowPromise = new CustomPromise();
		int playerId = CreatureModel.Instance.GetPlayerId();
		if (SceneTeamModel.Instance.GetGroupLivingState(playerId, ETeamGroupType.Battle) == ETeamLivingState.Dead)
		{
			LevelLoadingController.Instance.CloseAllBlackScreenLoading();
			global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "因复活界面打开,黑幕关闭", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (treeId != null && LevelPlayModel.Instance.GetProcessingLevelPlayInfo(treeId.Value) == null)
		{
			LevelLoadingController.Instance.CloseAllBlackScreenLoading();
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.BlackScreen;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "此玩法已经被销毁，不执行进入黑幕：";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeId", treeId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.NeedInputDis = true;
		InputDistributeModel.Instance.RefreshInputDistributeTag();
		GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("BlackScreen");
		if (needBackToFight)
		{
			UiManager.Instance.ResetToBattleView(null);
		}
		if (needCheckOpenView)
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.All, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "黑幕期间禁止打开部分界面");
		}
		this.SetIsFadeIn(true);
		this.SetFadeTime(num);
		this.BlackScreen.ShowItem();
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.BlackScreen;
		ELogAuthor author2 = ELogAuthor.JYS;
		string message2 = "开始显示黑幕";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("标签", tag);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
	}

	// Token: 0x06007D12 RID: 32018 RVA: 0x0026B6C0 File Offset: 0x002698C0
	public void RemoveFadeBlackScreen(float num, string tag)
	{
		if (this.BlackScreen == null)
		{
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.BlackScreen;
		ELogAuthor author = ELogAuthor.JYS;
		string message = "触发结束黑屏";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标签", tag);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		BlackScreenController instance2 = BlackScreenController.Instance;
		EFadeInScreenShowType? screenColorType = this.GetScreenColorType();
		EFadeInScreenShowType efadeInScreenShowType = EFadeInScreenShowType.White;
		instance2.ConsumePendingBlackScreen((screenColorType.GetValueOrDefault() == efadeInScreenShowType & screenColorType != null) ? "White" : "Black");
		this.SetIsFadeIn(false);
		this.SetFadeTime(num);
		this.BlackScreen.HideItem();
	}

	// Token: 0x06007D13 RID: 32019 RVA: 0x0026B74C File Offset: 0x0026994C
	protected override bool OnClear()
	{
		if (this.BlackScreen != null)
		{
			this.BlackScreen.Destroy(null);
			this.BlackScreen = null;
		}
		return true;
	}

	// Token: 0x06007D14 RID: 32020 RVA: 0x0026B76A File Offset: 0x0026996A
	public void ChangeColor(EFadeInScreenShowType screenType)
	{
		if (this.BlackScreen != null)
		{
			this.BlackScreen.UpdateScreenColor(screenType);
		}
	}

	// Token: 0x06007D15 RID: 32021 RVA: 0x0026B780 File Offset: 0x00269980
	public void ChangeColorByForce(EFadeInScreenShowType screenType)
	{
		if (this.BlackScreen != null)
		{
			this.BlackScreen.UpdateScreenColorAndChangeVisible(screenType);
		}
	}

	// Token: 0x06007D16 RID: 32022 RVA: 0x0026B796 File Offset: 0x00269996
	public bool ChangeAspect(float aspectRatio, bool? bInstantly = null)
	{
		return this.BlackScreen != null && this.BlackScreen.ChangeAspect(aspectRatio, bInstantly);
	}

	// Token: 0x06007D17 RID: 32023 RVA: 0x0026B7AF File Offset: 0x002699AF
	private void SetFadeTime(float num)
	{
		if (this.BlackScreen != null)
		{
			this.BlackScreen.SetFadeTime(num);
		}
	}

	// Token: 0x06007D18 RID: 32024 RVA: 0x0026B7C5 File Offset: 0x002699C5
	private void SetIsFadeIn(bool value)
	{
		if (this.BlackScreen != null)
		{
			this.BlackScreen.SetIsFadeIn(value);
		}
	}

	// Token: 0x06007D19 RID: 32025 RVA: 0x0026B7DB File Offset: 0x002699DB
	public bool GetIsFadeIn()
	{
		BlackScreenFadeView blackScreen = this.BlackScreen;
		return blackScreen != null && blackScreen.GetActive();
	}

	// Token: 0x06007D1A RID: 32026 RVA: 0x0026B7F0 File Offset: 0x002699F0
	public bool CheckIfInCommon()
	{
		List<ELoadingReason> reasonsByPerform = LevelLoadingModel.Instance.GetReasonsByPerform(ELoadingPerform.CameraFade);
		return reasonsByPerform.Contains(ELoadingReason.Common) && reasonsByPerform.Count == 1;
	}

	// Token: 0x06007D1B RID: 32027 RVA: 0x0026B820 File Offset: 0x00269A20
	public int GetHierarchyIndex()
	{
		BlackScreenFadeView blackScreen = this.BlackScreen;
		int? num;
		if (blackScreen == null)
		{
			num = null;
		}
		else
		{
			UUIItem rootItem = blackScreen.GetRootItem();
			num = ((rootItem != null) ? new int?(rootItem.GetHierarchyIndex()) : null);
		}
		int? num2 = num;
		return num2.GetValueOrDefault();
	}

	// Token: 0x06007D1C RID: 32028 RVA: 0x0026B868 File Offset: 0x00269A68
	public EFadeInScreenShowType? GetScreenColorType()
	{
		BlackScreenFadeView blackScreen = this.BlackScreen;
		if (blackScreen == null)
		{
			return null;
		}
		return blackScreen.GetScreenColorType();
	}

	// Token: 0x17000E22 RID: 3618
	// (get) Token: 0x06007D1D RID: 32029 RVA: 0x0026B88E File Offset: 0x00269A8E
	public static BlackScreenFadeController Instance
	{
		get
		{
			return BlackScreenFadeController._Instance;
		}
	}

	// Token: 0x06007D1E RID: 32030 RVA: 0x0026B895 File Offset: 0x00269A95
	public static BlackScreenFadeController GetOrCreateInstance()
	{
		if (BlackScreenFadeController._Instance == null)
		{
			BlackScreenFadeController.CreateInstance();
		}
		return BlackScreenFadeController._Instance;
	}

	// Token: 0x06007D1F RID: 32031 RVA: 0x0026B8A9 File Offset: 0x00269AA9
	public static bool CreateInstance()
	{
		if (BlackScreenFadeController._Instance != null)
		{
			return true;
		}
		BlackScreenFadeController._Instance = new BlackScreenFadeController();
		return true;
	}

	// Token: 0x06007D20 RID: 32032 RVA: 0x0026B8BF File Offset: 0x00269ABF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007D21 RID: 32033 RVA: 0x0026B8C1 File Offset: 0x00269AC1
	public static void ResetStaticDefaultValue()
	{
		BlackScreenFadeController._Instance = null;
	}

	// Token: 0x06007D22 RID: 32034 RVA: 0x0026B8C9 File Offset: 0x00269AC9
	static BlackScreenFadeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BlackScreenFadeController.CreateStaticDefaultValue), new Action(BlackScreenFadeController.ResetStaticDefaultValue));
	}

	// Token: 0x04004DD2 RID: 19922
	[Nullable(2)]
	private BlackScreenFadeView BlackScreen;

	// Token: 0x04004DD3 RID: 19923
	public bool NeedInputDis;

	// Token: 0x04004DD4 RID: 19924
	private readonly HashSet<EUiViewName> NotEnableViews = new HashSet<EUiViewName>
	{
		EUiViewName.GuideTutorialView,
		EUiViewName.GuideTutorialPopView
	};

	// Token: 0x04004DD5 RID: 19925
	private bool NeedGuaranteeInternal = true;

	// Token: 0x04004DD6 RID: 19926
	[Nullable(2)]
	private static BlackScreenFadeController _Instance;
}
