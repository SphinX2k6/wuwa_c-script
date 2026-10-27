using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.LevelConditions;
using CSharpScript.Game.Ui;

// Token: 0x02001DC3 RID: 7619
[NullableContext(1)]
[Nullable(0)]
public abstract class GuideBaseView : UiViewBase
{
	// Token: 0x17001276 RID: 4726
	// (get) Token: 0x0600E786 RID: 59270 RVA: 0x00369278 File Offset: 0x00367478
	public float TotalDuration
	{
		get
		{
			if (this.GuideStepInfo == null)
			{
				return 0f;
			}
			return (float)this.GuideStepInfo.Config.Duration;
		}
	}

	// Token: 0x0600E787 RID: 59271 RVA: 0x003692A8 File Offset: 0x003674A8
	public GuideBaseView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E788 RID: 59272 RVA: 0x003693E0 File Offset: 0x003675E0
	private void CheckCondition()
	{
		GuideStep config = this.GuideStepInfo.Config;
		if (this.SuccessConditionCallback == null)
		{
			int successCondition = config.SuccessCondition;
			if (successCondition > 0 && LevelGeneralController.Instance.CheckCondition(successCondition.ToString(), null, false, Array.Empty<object>()))
			{
				this.OnFinishConditionOk(null);
			}
		}
		if (this.FailureConditionCallback == null)
		{
			int failureCondition = config.FailureCondition;
			if (failureCondition > 0 && LevelGeneralController.Instance.CheckCondition(failureCondition.ToString(), null, false, Array.Empty<object>()))
			{
				this.OnFinishConditionFail(null);
			}
		}
	}

	// Token: 0x0600E789 RID: 59273 RVA: 0x00369464 File Offset: 0x00367664
	protected bool CheckTickCondition()
	{
		int tickCondition = this.GuideStepInfo.Config.TickCondition;
		if (tickCondition == 0)
		{
			return true;
		}
		this.TickConditionDirtyFlag = true;
		return LevelGeneralController.Instance.CheckCondition(tickCondition.ToString(), null, true, new object[]
		{
			base.GetViewId()
		});
	}

	// Token: 0x0600E78A RID: 59274 RVA: 0x003694B8 File Offset: 0x003676B8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnUiScreenRootVisibleChange, new Action<bool>(this.OnVisibleChanged));
		this.OnGuideBaseViewAddEvent();
	}

	// Token: 0x0600E78B RID: 59275 RVA: 0x003694DC File Offset: 0x003676DC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnUiScreenRootVisibleChange, new Action<bool>(this.OnVisibleChanged));
		this.OnGuideBaseViewRemoveEvent();
	}

	// Token: 0x0600E78C RID: 59276 RVA: 0x00369500 File Offset: 0x00367700
	private void OnVisibleChanged(bool isShow)
	{
		if (!base.GetActive())
		{
			return;
		}
		if (isShow)
		{
			this.OnAfterShow();
			return;
		}
		this.OnAfterHide();
	}

	// Token: 0x0600E78D RID: 59277 RVA: 0x0036951C File Offset: 0x0036771C
	protected bool HasConflictView()
	{
		foreach (EUiViewName name in this.guideConflictView)
		{
			if (UiManager.Instance.IsViewShow(name))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600E78E RID: 59278 RVA: 0x0036957C File Offset: 0x0036777C
	public void DoCloseByFinished()
	{
		if (!this.IsFinished)
		{
			this.IsFinished = true;
			this.OnGuideViewCloseWhenFinish();
			this.DoCloseWithMinShowDuration();
		}
	}

	// Token: 0x0600E78F RID: 59279 RVA: 0x0036959C File Offset: 0x0036779C
	private void DoCloseWithMinShowDuration()
	{
		float remainMinShowDuration = this.RemainMinShowDuration;
		if (remainMinShowDuration < 20f)
		{
			this.DoClose();
			return;
		}
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.DoClose();
		}, remainMinShowDuration, null, null, true, 1f);
	}

	// Token: 0x0600E790 RID: 59280 RVA: 0x003695DF File Offset: 0x003677DF
	private void DoClose()
	{
		if (this.TimeTicker != null)
		{
			this.TimeTicker.Remove();
			this.TimeTicker = null;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600E791 RID: 59281 RVA: 0x00369604 File Offset: 0x00367804
	protected unsafe void BindInput(List<string> rawInputEnums, List<string> inputEnums, TInputHandle<float> callback)
	{
		if (rawInputEnums.Count != inputEnums.Count)
		{
			return;
		}
		if (this.InputCallback == callback)
		{
			return;
		}
		this.InputCallback = callback;
		for (int i = 0; i < inputEnums.Count; i++)
		{
			string text = rawInputEnums[i];
			if (actionMappings.HasField(text))
			{
				InputDistributeController.Instance.BindAction(inputEnums[i], new TInputHandle<InputDistributeDefine.EActionType>(this.OnActionCall));
				this.CombineInputMap[inputEnums[i]] = 1f;
			}
			else if (axisMappings.HasField(text))
			{
				InputDistributeController.Instance.BindAxis(inputEnums[i], new TInputHandle<float>(this.OnAxisCall));
				this.CombineInputMap[inputEnums[i]] = 0f;
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.TL;
				string message = "引导步骤  填的操作映射未定义";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("this.GuideStepInfo!.Id", this.GuideStepInfo.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("错误的操作映射", text);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
	}

	// Token: 0x0600E792 RID: 59282 RVA: 0x00369736 File Offset: 0x00367936
	private void OnActionCall(string name, InputDistributeDefine.EActionType value, InputIdentification inputIdentification)
	{
		TInputHandle<float> inputCallback = this.InputCallback;
		if (inputCallback == null)
		{
			return;
		}
		inputCallback(name, (float)value, inputIdentification);
	}

	// Token: 0x0600E793 RID: 59283 RVA: 0x0036974C File Offset: 0x0036794C
	private void OnAxisCall(string name, float value, InputIdentification inputIdentification)
	{
		TInputHandle<float> inputCallback = this.InputCallback;
		if (inputCallback == null)
		{
			return;
		}
		inputCallback(name, value, inputIdentification);
	}

	// Token: 0x0600E794 RID: 59284 RVA: 0x00369764 File Offset: 0x00367964
	protected bool IsAllCombineInputPass()
	{
		bool flag = true;
		foreach (KeyValuePair<string, float> keyValuePair in this.CombineInputMap)
		{
			string key = keyValuePair.Key;
			float value = keyValuePair.Value;
			if (actionMappings.HasField(key))
			{
				flag = (flag && value != 1f);
			}
			else if (axisMappings.HasField(key))
			{
				flag = (flag && value > 0f);
			}
		}
		return flag;
	}

	// Token: 0x0600E795 RID: 59285 RVA: 0x003697FC File Offset: 0x003679FC
	protected unsafe void UnbindInput(string[] rawInputEnums, string[] inputEnums)
	{
		if (rawInputEnums.Length != inputEnums.Length)
		{
			return;
		}
		if (this.InputCallback == null)
		{
			return;
		}
		for (int i = 0; i < inputEnums.Length; i++)
		{
			string text = rawInputEnums[i];
			if (actionMappings.HasField(text))
			{
				InputDistributeController.Instance.UnBindAction(inputEnums[i], new TInputHandle<InputDistributeDefine.EActionType>(this.OnActionCall));
			}
			else if (axisMappings.HasField(text))
			{
				InputDistributeController.Instance.UnBindAxis(inputEnums[i], new TInputHandle<float>(this.OnAxisCall));
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.TL;
				string message = "引导步骤  填的操作映射未定义";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("this.GuideStepInfo!.Id", this.GuideStepInfo.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("错误的操作映射", text);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			this.CombineInputMap.Remove(inputEnums[i]);
		}
		this.InputCallback = null;
	}

	// Token: 0x0600E796 RID: 59286 RVA: 0x003698F4 File Offset: 0x00367AF4
	protected void OnFinishConditionOk([Nullable(new byte[]
	{
		2,
		1
	})] object[] paramList = null)
	{
		if (!this.OnCheckBaseViewFinishConditionOk())
		{
			return;
		}
		this.DoCloseByFinished();
	}

	// Token: 0x0600E797 RID: 59287 RVA: 0x00369905 File Offset: 0x00367B05
	protected void OnFinishConditionFail([Nullable(new byte[]
	{
		2,
		1
	})] object[] paramList = null)
	{
		if (!this.OnCheckBaseViewFinishConditionFail())
		{
			return;
		}
		this.DoCloseWithMinShowDuration();
	}

	// Token: 0x0600E798 RID: 59288 RVA: 0x00369918 File Offset: 0x00367B18
	protected override void OnBeforeCreate()
	{
		this.IsConditionRegistered = false;
		this.GuideStepInfo = (this.OpenParam as GuideStepInfo);
		this.RemainDuration = this.TotalDuration;
		this.RemainMinShowDuration = (float)this.GuideStepInfo.Config.MinDuration;
		this.GuideStepInfo.AssignGuideView(this);
		this.RegisterFinishCondition();
		this.OnBeforeGuideBaseViewCreate();
	}

	// Token: 0x0600E799 RID: 59289 RVA: 0x0036997B File Offset: 0x00367B7B
	protected override void OnStart()
	{
		this.OnGuideBaseViewStart();
		this.TimeTicker = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
	}

	// Token: 0x0600E79A RID: 59290 RVA: 0x003699AC File Offset: 0x00367BAC
	protected override void OnAfterShow()
	{
		GuideStep config = this.GuideStepInfo.Config;
		if (config.IsDangerous)
		{
			LguiUtil.Instance.LoadPrefabByResourceIdAsync("UiItem_Danger_Tip", this.RootItem, null, ResourceSystem.EResourceLoadPriority.Default, "js_undefined");
		}
		float timeScale = config.TimeScale;
		if (timeScale < 1f && !GameModeModel.Instance.IsMulti)
		{
			InputDistributeController.Instance.RefreshInputTag();
			UiTimeDilation.Instance.SetTimeDilationHighLevel(timeScale, "GuideBase");
		}
		this.RegisterFinishCondition();
		this.OnGuideViewAfterShow();
	}

	// Token: 0x0600E79B RID: 59291 RVA: 0x00369A30 File Offset: 0x00367C30
	protected override void OnAfterHide()
	{
		if (this.GuideStepInfo.Config.TimeScale < 1f && !GameModeModel.Instance.IsMulti)
		{
			UiTimeDilation.Instance.ResetTimeDilationHighLevel("GuideBase");
			InputDistributeController.Instance.RefreshInputTag();
		}
		this.UnRegisterFinishCondition();
		this.OnGuideBaseViewAfterHide();
	}

	// Token: 0x0600E79C RID: 59292 RVA: 0x00369A88 File Offset: 0x00367C88
	private void RegisterFinishCondition()
	{
		if (this.IsConditionRegistered)
		{
			return;
		}
		this.IsConditionRegistered = true;
		GuideStep config = this.GuideStepInfo.Config;
		if (config.SuccessCondition != 0)
		{
			ConditionPassCallback conditionPassCallback = new ConditionPassCallback(new TConditionPassCallback(this.OnFinishConditionOk), null);
			if (LevelConditionRegistry.Instance.RegisterConditionGroup(config.SuccessCondition, conditionPassCallback))
			{
				this.SuccessConditionCallback = conditionPassCallback;
			}
		}
		if (config.FailureCondition != 0)
		{
			ConditionPassCallback conditionPassCallback2 = new ConditionPassCallback(new TConditionPassCallback(this.OnFinishConditionFail), null);
			if (LevelConditionRegistry.Instance.RegisterConditionGroup(config.FailureCondition, conditionPassCallback2))
			{
				this.FailureConditionCallback = conditionPassCallback2;
			}
		}
	}

	// Token: 0x0600E79D RID: 59293 RVA: 0x00369B20 File Offset: 0x00367D20
	private void UnRegisterFinishCondition()
	{
		if (!this.IsConditionRegistered)
		{
			return;
		}
		this.IsConditionRegistered = false;
		GuideStep config = this.GuideStepInfo.Config;
		int successCondition = config.SuccessCondition;
		if (this.SuccessConditionCallback != null)
		{
			LevelConditionRegistry.Instance.UnRegisterConditionGroup(config.SuccessCondition, this.SuccessConditionCallback);
			this.SuccessConditionCallback = null;
		}
		int failureCondition = config.FailureCondition;
		if (this.FailureConditionCallback != null)
		{
			LevelConditionRegistry.Instance.UnRegisterConditionGroup(config.FailureCondition, this.FailureConditionCallback);
			this.FailureConditionCallback = null;
		}
	}

	// Token: 0x0600E79E RID: 59294 RVA: 0x00369BA8 File Offset: 0x00367DA8
	protected override void OnBeforeDestroy()
	{
		this.TickConditionDirtyFlag = false;
		if (this.TimeTicker != null)
		{
			this.TimeTicker.Remove();
			this.TimeTicker = null;
		}
		GuideStepInfo guideStepInfo = this.GuideStepInfo;
		this.OnGuideBaseViewDestroy();
		if (this.IgnoreState)
		{
			return;
		}
		if (this.IsFinished)
		{
			guideStepInfo.SwitchState(EGuideStepState.Finish);
			return;
		}
		guideStepInfo.SwitchState(EGuideStepState.Break);
	}

	// Token: 0x0600E79F RID: 59295 RVA: 0x00369C04 File Offset: 0x00367E04
	public void OnTick(float delta)
	{
		if (LoadingModel.Instance.IsLoadingView)
		{
			return;
		}
		this.OnGuideBaseViewTick(delta);
		float num = this.RemainDuration;
		if (num > 0f)
		{
			float num2 = delta;
			GuideStepInfo guideStepInfo = this.GuideStepInfo;
			bool flag;
			if (guideStepInfo == null)
			{
				flag = false;
			}
			else
			{
				GuideStepViewData viewData = guideStepInfo.ViewData;
				flag = ((viewData != null) ? new bool?(viewData.IsAttachToBattleView) : null).GetValueOrDefault();
			}
			if (flag && !base.IsShow && !this.TickConditionDirtyFlag)
			{
				num2 = 0f;
			}
			num -= num2;
			if (num <= 0f)
			{
				this.CloseWhileDurationEnd();
			}
			this.RemainDuration = num;
			this.OnDurationChange(num);
		}
		if (base.IsShow)
		{
			this.RemainMinShowDuration -= delta;
			this.CheckCondition();
		}
	}

	// Token: 0x0600E7A0 RID: 59296 RVA: 0x00369CBD File Offset: 0x00367EBD
	private void CloseWhileDurationEnd()
	{
		this.DoClose();
	}

	// Token: 0x0600E7A1 RID: 59297 RVA: 0x00369CC5 File Offset: 0x00367EC5
	protected virtual void OnBeforeGuideBaseViewCreate()
	{
	}

	// Token: 0x0600E7A2 RID: 59298 RVA: 0x00369CC7 File Offset: 0x00367EC7
	protected virtual void OnGuideBaseViewStart()
	{
	}

	// Token: 0x0600E7A3 RID: 59299 RVA: 0x00369CC9 File Offset: 0x00367EC9
	protected virtual void OnGuideBaseViewAfterHide()
	{
	}

	// Token: 0x0600E7A4 RID: 59300 RVA: 0x00369CCB File Offset: 0x00367ECB
	protected virtual void OnGuideViewAfterShow()
	{
	}

	// Token: 0x0600E7A5 RID: 59301 RVA: 0x00369CCD File Offset: 0x00367ECD
	protected virtual void OnGuideBaseViewDestroy()
	{
	}

	// Token: 0x0600E7A6 RID: 59302 RVA: 0x00369CCF File Offset: 0x00367ECF
	protected virtual void OnGuideBaseViewAddEvent()
	{
	}

	// Token: 0x0600E7A7 RID: 59303 RVA: 0x00369CD1 File Offset: 0x00367ED1
	protected virtual void OnGuideBaseViewRemoveEvent()
	{
	}

	// Token: 0x0600E7A8 RID: 59304 RVA: 0x00369CD3 File Offset: 0x00367ED3
	protected virtual void OnGuideBaseViewTick(float delta)
	{
	}

	// Token: 0x0600E7A9 RID: 59305 RVA: 0x00369CD5 File Offset: 0x00367ED5
	protected virtual void OnDurationChange(float remainDuration)
	{
	}

	// Token: 0x0600E7AA RID: 59306 RVA: 0x00369CD7 File Offset: 0x00367ED7
	protected virtual void OnGuideViewCloseWhenFinish()
	{
	}

	// Token: 0x0600E7AB RID: 59307 RVA: 0x00369CD9 File Offset: 0x00367ED9
	protected virtual bool OnCheckBaseViewFinishConditionOk()
	{
		return true;
	}

	// Token: 0x0600E7AC RID: 59308 RVA: 0x00369CDC File Offset: 0x00367EDC
	protected virtual bool OnCheckBaseViewFinishConditionFail()
	{
		return true;
	}

	// Token: 0x04006B18 RID: 27416
	private HashSet<EUiViewName> guideConflictView = new HashSet<EUiViewName>
	{
		EUiViewName.MonthCardRewardView,
		EUiViewName.QuestRewardView,
		EUiViewName.ExploreRewardView,
		EUiViewName.CommonRewardView,
		EUiViewName.ItemTipsView,
		EUiViewName.ExploreDetailView,
		EUiViewName.TowerUnlockView,
		EUiViewName.TowerOverLockUnlockView,
		EUiViewName.PowerView,
		EUiViewName.ActivityRewardPopUpView,
		EUiViewName.RoleGenderChangeView,
		EUiViewName.ConfirmBoxView,
		EUiViewName.CdKeyInputView,
		EUiViewName.CompositeRewardView,
		EUiViewName.LogUploadView,
		EUiViewName.RacingBetsSuccessTip,
		EUiViewName.RacingBetsFailTip,
		EUiViewName.DangoAbyssInfoView,
		EUiViewName.PhantomArenaStartView,
		EUiViewName.TutorialPopView,
		EUiViewName.ResolutionListView
	}.Concat(LoadingDefine.loadingViewList).ToHashSet<EUiViewName>();

	// Token: 0x04006B19 RID: 27417
	public bool IgnoreState;

	// Token: 0x04006B1A RID: 27418
	protected bool IsFinished;

	// Token: 0x04006B1B RID: 27419
	[Nullable(2)]
	protected GuideStepInfo GuideStepInfo;

	// Token: 0x04006B1C RID: 27420
	protected readonly Dictionary<string, float> CombineInputMap = new Dictionary<string, float>();

	// Token: 0x04006B1D RID: 27421
	protected float RemainDuration;

	// Token: 0x04006B1E RID: 27422
	private float RemainMinShowDuration;

	// Token: 0x04006B1F RID: 27423
	private bool IsConditionRegistered;

	// Token: 0x04006B20 RID: 27424
	private bool TickConditionDirtyFlag;

	// Token: 0x04006B21 RID: 27425
	[Nullable(2)]
	private ConditionPassCallback SuccessConditionCallback;

	// Token: 0x04006B22 RID: 27426
	[Nullable(2)]
	private ConditionPassCallback FailureConditionCallback;

	// Token: 0x04006B23 RID: 27427
	[Nullable(2)]
	protected TimerHandle TimeTicker;

	// Token: 0x04006B24 RID: 27428
	[Nullable(2)]
	private TInputHandle<float> InputCallback;
}
