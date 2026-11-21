using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.LevelConditions;
using CSharpScript.Game.Ui;

// Token: 0x02001285 RID: 4741
[NullableContext(1)]
[Nullable(0)]
public abstract class GuideBaseView : UiViewBase
{
	// Token: 0x0600BBA4 RID: 48036 RVA: 0x00374EF0 File Offset: 0x003730F0
	private static HashSet<EUiViewName> BuildGuideConflictView()
	{
		HashSet<EUiViewName> hashSet = new HashSet<EUiViewName>
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
		};
		foreach (EUiViewName item in LoadingDefine.loadingViewList)
		{
			hashSet.Add(item);
		}
		return hashSet;
	}

	// Token: 0x170012A0 RID: 4768
	// (get) Token: 0x0600BBA5 RID: 48037 RVA: 0x00375024 File Offset: 0x00373224
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

	// Token: 0x0600BBA6 RID: 48038 RVA: 0x00375053 File Offset: 0x00373253
	public GuideBaseView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BBA7 RID: 48039 RVA: 0x00375074 File Offset: 0x00373274
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

	// Token: 0x0600BBA8 RID: 48040 RVA: 0x003750F8 File Offset: 0x003732F8
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

	// Token: 0x0600BBA9 RID: 48041 RVA: 0x0037514C File Offset: 0x0037334C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnUiScreenRootVisibleChange, new Action<bool>(this.OnVisibleChanged));
		this.OnGuideBaseViewAddEvent();
	}

	// Token: 0x0600BBAA RID: 48042 RVA: 0x00375170 File Offset: 0x00373370
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnUiScreenRootVisibleChange, new Action<bool>(this.OnVisibleChanged));
		this.OnGuideBaseViewRemoveEvent();
	}

	// Token: 0x0600BBAB RID: 48043 RVA: 0x00375194 File Offset: 0x00373394
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

	// Token: 0x0600BBAC RID: 48044 RVA: 0x003751B0 File Offset: 0x003733B0
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

	// Token: 0x0600BBAD RID: 48045 RVA: 0x00375210 File Offset: 0x00373410
	public void DoCloseByFinished()
	{
		if (!this.IsFinished)
		{
			this.IsFinished = true;
			this.OnGuideViewCloseWhenFinish();
			this.DoCloseWithMinShowDuration();
		}
	}

	// Token: 0x0600BBAE RID: 48046 RVA: 0x00375230 File Offset: 0x00373430
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

	// Token: 0x0600BBAF RID: 48047 RVA: 0x00375273 File Offset: 0x00373473
	private void DoClose()
	{
		if (this.TimeTicker != null)
		{
			this.TimeTicker.Remove();
			this.TimeTicker = null;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600BBB0 RID: 48048 RVA: 0x00375298 File Offset: 0x00373498
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

	// Token: 0x0600BBB1 RID: 48049 RVA: 0x003753CA File Offset: 0x003735CA
	private void OnActionCall(string name, InputDistributeDefine.EActionType value, InputIdentification inputIdentification)
	{
		TInputHandle<float> inputCallback = this.InputCallback;
		if (inputCallback == null)
		{
			return;
		}
		inputCallback(name, (float)value, inputIdentification);
	}

	// Token: 0x0600BBB2 RID: 48050 RVA: 0x003753E0 File Offset: 0x003735E0
	private void OnAxisCall(string name, float value, InputIdentification inputIdentification)
	{
		TInputHandle<float> inputCallback = this.InputCallback;
		if (inputCallback == null)
		{
			return;
		}
		inputCallback(name, value, inputIdentification);
	}

	// Token: 0x0600BBB3 RID: 48051 RVA: 0x003753F8 File Offset: 0x003735F8
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

	// Token: 0x0600BBB4 RID: 48052 RVA: 0x00375490 File Offset: 0x00373690
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

	// Token: 0x0600BBB5 RID: 48053 RVA: 0x00375588 File Offset: 0x00373788
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

	// Token: 0x0600BBB6 RID: 48054 RVA: 0x00375599 File Offset: 0x00373799
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

	// Token: 0x0600BBB7 RID: 48055 RVA: 0x003755AC File Offset: 0x003737AC
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

	// Token: 0x0600BBB8 RID: 48056 RVA: 0x0037560F File Offset: 0x0037380F
	protected override void OnStart()
	{
		this.OnGuideBaseViewStart();
		this.TimeTicker = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
	}

	// Token: 0x0600BBB9 RID: 48057 RVA: 0x00375640 File Offset: 0x00373840
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

	// Token: 0x0600BBBA RID: 48058 RVA: 0x003756C4 File Offset: 0x003738C4
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

	// Token: 0x0600BBBB RID: 48059 RVA: 0x0037571C File Offset: 0x0037391C
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

	// Token: 0x0600BBBC RID: 48060 RVA: 0x003757B4 File Offset: 0x003739B4
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

	// Token: 0x0600BBBD RID: 48061 RVA: 0x0037583C File Offset: 0x00373A3C
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

	// Token: 0x0600BBBE RID: 48062 RVA: 0x00375898 File Offset: 0x00373A98
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

	// Token: 0x0600BBBF RID: 48063 RVA: 0x00375951 File Offset: 0x00373B51
	private void CloseWhileDurationEnd()
	{
		this.DoClose();
	}

	// Token: 0x0600BBC0 RID: 48064 RVA: 0x00375959 File Offset: 0x00373B59
	protected virtual void OnBeforeGuideBaseViewCreate()
	{
	}

	// Token: 0x0600BBC1 RID: 48065 RVA: 0x0037595B File Offset: 0x00373B5B
	protected virtual void OnGuideBaseViewStart()
	{
	}

	// Token: 0x0600BBC2 RID: 48066 RVA: 0x0037595D File Offset: 0x00373B5D
	protected virtual void OnGuideBaseViewAfterHide()
	{
	}

	// Token: 0x0600BBC3 RID: 48067 RVA: 0x0037595F File Offset: 0x00373B5F
	protected virtual void OnGuideViewAfterShow()
	{
	}

	// Token: 0x0600BBC4 RID: 48068 RVA: 0x00375961 File Offset: 0x00373B61
	protected virtual void OnGuideBaseViewDestroy()
	{
	}

	// Token: 0x0600BBC5 RID: 48069 RVA: 0x00375963 File Offset: 0x00373B63
	protected virtual void OnGuideBaseViewAddEvent()
	{
	}

	// Token: 0x0600BBC6 RID: 48070 RVA: 0x00375965 File Offset: 0x00373B65
	protected virtual void OnGuideBaseViewRemoveEvent()
	{
	}

	// Token: 0x0600BBC7 RID: 48071 RVA: 0x00375967 File Offset: 0x00373B67
	protected virtual void OnGuideBaseViewTick(float delta)
	{
	}

	// Token: 0x0600BBC8 RID: 48072 RVA: 0x00375969 File Offset: 0x00373B69
	protected virtual void OnDurationChange(float remainDuration)
	{
	}

	// Token: 0x0600BBC9 RID: 48073 RVA: 0x0037596B File Offset: 0x00373B6B
	protected virtual void OnGuideViewCloseWhenFinish()
	{
	}

	// Token: 0x0600BBCA RID: 48074 RVA: 0x0037596D File Offset: 0x00373B6D
	protected virtual bool OnCheckBaseViewFinishConditionOk()
	{
		return true;
	}

	// Token: 0x0600BBCB RID: 48075 RVA: 0x00375970 File Offset: 0x00373B70
	protected virtual bool OnCheckBaseViewFinishConditionFail()
	{
		return true;
	}

	// Token: 0x04006BF9 RID: 27641
	private HashSet<EUiViewName> guideConflictView = GuideBaseView.BuildGuideConflictView();

	// Token: 0x04006BFA RID: 27642
	public bool IgnoreState;

	// Token: 0x04006BFB RID: 27643
	protected bool IsFinished;

	// Token: 0x04006BFC RID: 27644
	[Nullable(2)]
	protected GuideStepInfo GuideStepInfo;

	// Token: 0x04006BFD RID: 27645
	protected readonly Dictionary<string, float> CombineInputMap = new Dictionary<string, float>();

	// Token: 0x04006BFE RID: 27646
	protected float RemainDuration;

	// Token: 0x04006BFF RID: 27647
	private float RemainMinShowDuration;

	// Token: 0x04006C00 RID: 27648
	private bool IsConditionRegistered;

	// Token: 0x04006C01 RID: 27649
	private bool TickConditionDirtyFlag;

	// Token: 0x04006C02 RID: 27650
	[Nullable(2)]
	private ConditionPassCallback SuccessConditionCallback;

	// Token: 0x04006C03 RID: 27651
	[Nullable(2)]
	private ConditionPassCallback FailureConditionCallback;

	// Token: 0x04006C04 RID: 27652
	[Nullable(2)]
	protected TimerHandle TimeTicker;

	// Token: 0x04006C05 RID: 27653
	[Nullable(2)]
	private TInputHandle<float> InputCallback;
}
