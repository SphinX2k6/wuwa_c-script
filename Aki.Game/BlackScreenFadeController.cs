using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200170D RID: 5901
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BlackScreenFadeController : UiControllerBase
{
	// Token: 0x17000E00 RID: 3584
	// (get) Token: 0x0600A92A RID: 43306 RVA: 0x00261024 File Offset: 0x0025F224
	// (set) Token: 0x0600A92B RID: 43307 RVA: 0x0026102C File Offset: 0x0025F22C
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

	// Token: 0x0600A92C RID: 43308 RVA: 0x00261035 File Offset: 0x0025F235
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.UiManagerInit, new Action(this.PreloadBlackFadeScreen));
		EventSystem.Instance.Add<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
	}

	// Token: 0x0600A92D RID: 43309 RVA: 0x0026106C File Offset: 0x0025F26C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.UiManagerInit, new Action(this.PreloadBlackFadeScreen));
		EventSystem.Instance.Remove(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
	}

	// Token: 0x0600A92E RID: 43310 RVA: 0x002610A3 File Offset: 0x0025F2A3
	private void PreloadBlackFadeScreen()
	{
		if (this.BlackScreen != null)
		{
			return;
		}
		this.BlackScreen = new BlackScreenFadeView();
		this.BlackScreen.CreateByResourceIdAsync("UiView_BlackFadeScreen_Prefab", UiLayer.Instance.GetFloatUnit(ELayerType.Loading, 0), true);
	}

	// Token: 0x0600A92F RID: 43311 RVA: 0x002610DC File Offset: 0x0025F2DC
	private void OnTeamLivingStateChange(bool isMyTeam, ETeamGroupType groupType, ETeamLivingState state, ETeamLivingState oldState)
	{
		if (isMyTeam && groupType == ETeamGroupType.Battle && state == ETeamLivingState.Dead)
		{
			LevelLoadingController.Instance.CloseAllBlackScreenLoading();
			global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "OnAllDead关闭黑幕", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x0600A930 RID: 43312 RVA: 0x00261120 File Offset: 0x0025F320
	[NullableContext(2)]
	public bool CheckCanOpen(EUiViewName viewName, object param)
	{
		UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(viewName);
		return uiViewInfo != null && (uiViewInfo.Type != ELayerType.Normal || !this.NotEnableViews.Contains(viewName));
	}

	// Token: 0x0600A931 RID: 43313 RVA: 0x00261158 File Offset: 0x0025F358
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

	// Token: 0x0600A932 RID: 43314 RVA: 0x002612A4 File Offset: 0x0025F4A4
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

	// Token: 0x0600A933 RID: 43315 RVA: 0x00261330 File Offset: 0x0025F530
	protected override bool OnClear()
	{
		if (this.BlackScreen != null)
		{
			this.BlackScreen.Destroy(null);
			this.BlackScreen = null;
		}
		return true;
	}

	// Token: 0x0600A934 RID: 43316 RVA: 0x0026134E File Offset: 0x0025F54E
	public void ChangeColor(EFadeInScreenShowType screenType)
	{
		if (this.BlackScreen != null)
		{
			this.BlackScreen.UpdateScreenColor(screenType);
		}
	}

	// Token: 0x0600A935 RID: 43317 RVA: 0x00261364 File Offset: 0x0025F564
	public void ChangeColorByForce(EFadeInScreenShowType screenType)
	{
		if (this.BlackScreen != null)
		{
			this.BlackScreen.UpdateScreenColorAndChangeVisible(screenType);
		}
	}

	// Token: 0x0600A936 RID: 43318 RVA: 0x0026137A File Offset: 0x0025F57A
	public bool ChangeAspect(float aspectRatio, bool? bInstantly = null)
	{
		return this.BlackScreen != null && this.BlackScreen.ChangeAspect(aspectRatio, bInstantly);
	}

	// Token: 0x0600A937 RID: 43319 RVA: 0x00261393 File Offset: 0x0025F593
	private void SetFadeTime(float num)
	{
		if (this.BlackScreen != null)
		{
			this.BlackScreen.SetFadeTime(num);
		}
	}

	// Token: 0x0600A938 RID: 43320 RVA: 0x002613A9 File Offset: 0x0025F5A9
	private void SetIsFadeIn(bool value)
	{
		if (this.BlackScreen != null)
		{
			this.BlackScreen.SetIsFadeIn(value);
		}
	}

	// Token: 0x0600A939 RID: 43321 RVA: 0x002613BF File Offset: 0x0025F5BF
	public bool GetIsFadeIn()
	{
		BlackScreenFadeView blackScreen = this.BlackScreen;
		return blackScreen != null && blackScreen.GetActive();
	}

	// Token: 0x0600A93A RID: 43322 RVA: 0x002613D4 File Offset: 0x0025F5D4
	public bool CheckIfInCommon()
	{
		List<ELoadingReason> reasonsByPerform = LevelLoadingModel.Instance.GetReasonsByPerform(ELoadingPerform.CameraFade);
		return reasonsByPerform.Contains(ELoadingReason.Common) && reasonsByPerform.Count == 1;
	}

	// Token: 0x0600A93B RID: 43323 RVA: 0x00261404 File Offset: 0x0025F604
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

	// Token: 0x0600A93C RID: 43324 RVA: 0x0026144C File Offset: 0x0025F64C
	public EFadeInScreenShowType? GetScreenColorType()
	{
		BlackScreenFadeView blackScreen = this.BlackScreen;
		if (blackScreen == null)
		{
			return null;
		}
		return blackScreen.GetScreenColorType();
	}

	// Token: 0x17000E01 RID: 3585
	// (get) Token: 0x0600A93D RID: 43325 RVA: 0x00261472 File Offset: 0x0025F672
	public static BlackScreenFadeController Instance
	{
		get
		{
			return BlackScreenFadeController._Instance;
		}
	}

	// Token: 0x0600A93E RID: 43326 RVA: 0x00261479 File Offset: 0x0025F679
	public static BlackScreenFadeController GetOrCreateInstance()
	{
		if (BlackScreenFadeController._Instance == null)
		{
			BlackScreenFadeController.CreateInstance();
		}
		return BlackScreenFadeController._Instance;
	}

	// Token: 0x0600A93F RID: 43327 RVA: 0x0026148D File Offset: 0x0025F68D
	public static bool CreateInstance()
	{
		if (BlackScreenFadeController._Instance != null)
		{
			return true;
		}
		BlackScreenFadeController._Instance = new BlackScreenFadeController();
		return true;
	}

	// Token: 0x0600A940 RID: 43328 RVA: 0x002614A3 File Offset: 0x0025F6A3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A941 RID: 43329 RVA: 0x002614A5 File Offset: 0x0025F6A5
	public static void ResetStaticDefaultValue()
	{
		BlackScreenFadeController._Instance = null;
	}

	// Token: 0x0600A942 RID: 43330 RVA: 0x002614AD File Offset: 0x0025F6AD
	static BlackScreenFadeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BlackScreenFadeController.CreateStaticDefaultValue), new Action(BlackScreenFadeController.ResetStaticDefaultValue));
	}

	// Token: 0x04004D2B RID: 19755
	[Nullable(2)]
	private BlackScreenFadeView BlackScreen;

	// Token: 0x04004D2C RID: 19756
	public bool NeedInputDis;

	// Token: 0x04004D2D RID: 19757
	private readonly HashSet<EUiViewName> NotEnableViews = new HashSet<EUiViewName>
	{
		EUiViewName.GuideTutorialView,
		EUiViewName.GuideTutorialPopView
	};

	// Token: 0x04004D2E RID: 19758
	private bool NeedGuaranteeInternal = true;

	// Token: 0x04004D2F RID: 19759
	[Nullable(2)]
	private static BlackScreenFadeController _Instance;
}
