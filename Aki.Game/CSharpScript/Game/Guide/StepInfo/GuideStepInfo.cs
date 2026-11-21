using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Guide.GroupInfo;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x02003535 RID: 13621
	[NullableContext(2)]
	[Nullable(0)]
	public class GuideStepInfo
	{
		// Token: 0x17004877 RID: 18551
		// (get) Token: 0x06022A8C RID: 141964 RVA: 0x009DC818 File Offset: 0x009DAA18
		public GuideStep Config
		{
			get
			{
				if (this.ConfigInner == null)
				{
					this.ConfigInner = new GuideStep?(GuideConfig.Instance.GetStep(this.Id).Value);
				}
				return this.ConfigInner.Value;
			}
		}

		// Token: 0x06022A8D RID: 141965 RVA: 0x009DC860 File Offset: 0x009DAA60
		[NullableContext(1)]
		public GuideStepInfo(int stepId, GuideGroupInfo owner)
		{
			this.Id = stepId;
			this.OwnerGroup = owner;
			GuideGroup? guideGroup;
			this.OwnerGroupPriority = ((GuideConfig.Instance.GetGroup(owner.Id) != null) ? guideGroup.GetValueOrDefault().Priority : 0);
			this.ViewData = new GuideStepViewData(this);
			this.StateMachine = new StateMachine<GuideStepInfo, EGuideStepState>(this, null);
			this.StateMachine.AddState<InitState>(EGuideStepState.Init, null);
			this.StateMachine.AddState<ExecutingState>(EGuideStepState.Executing, null);
			this.StateMachine.AddState<PendingState>(EGuideStepState.Pending, null);
			this.StateMachine.AddState<BreakState>(EGuideStepState.Break, null);
			this.StateMachine.AddState<FinishState>(EGuideStepState.Finish, null);
			this.StateMachine.AddState<EndState>(EGuideStepState.End, null);
			this.StateMachine.Start(EGuideStepState.Init);
		}

		// Token: 0x06022A8E RID: 141966 RVA: 0x009DC927 File Offset: 0x009DAB27
		public void TryEnterExecuting()
		{
			if (this.CanEnterExecuting())
			{
				this.SwitchState(EGuideStepState.Executing);
				return;
			}
			this.SwitchState(EGuideStepState.Pending);
		}

		// Token: 0x06022A8F RID: 141967 RVA: 0x009DC940 File Offset: 0x009DAB40
		public void AssignGuideView(GuideBaseView view)
		{
			if (view == null)
			{
				return;
			}
			EUiViewName name = view.ViewInfo.Name;
			int viewId = view.GetViewId();
			if (this.StateMachine.CurrentState.GetValueOrDefault() != EGuideStepState.Executing)
			{
				UiManager.Instance.CloseViewById(viewId, null);
				return;
			}
			this.GuideView = view;
		}

		// Token: 0x06022A90 RID: 141968 RVA: 0x009DC990 File Offset: 0x009DAB90
		public void SwitchState(EGuideStepState toState)
		{
			if (this.StateMachine.CurrentState.GetValueOrDefault() == EGuideStepState.End && toState != EGuideStepState.Init)
			{
				return;
			}
			this.StateMachine.Switch(toState);
		}

		// Token: 0x06022A91 RID: 141969 RVA: 0x009DC9C4 File Offset: 0x009DABC4
		private bool CheckEnterExecutingConditions()
		{
			return UiLayer.Instance.IsUiActive() && !GuideModel.Instance.ShouldBlockGuideBecauseUiNotRender && !UiManager.Instance.IsViewShow(EUiViewName.PhantomExploreView);
		}

		// Token: 0x06022A92 RID: 141970 RVA: 0x009DC9F8 File Offset: 0x009DABF8
		private bool IsNeedNormalMask()
		{
			if (this.Config.ContentType == 4)
			{
				GuideFocusNew? guideFocus = GuideConfig.Instance.GetGuideFocus(this.Id);
				if (guideFocus != null && guideFocus.Value.UseMask)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06022A93 RID: 141971 RVA: 0x009DCA44 File Offset: 0x009DAC44
		private unsafe bool CheckTargetViewOpen()
		{
			GuideFocusNew value = GuideConfig.Instance.GetGuideFocus(this.Id).Value;
			string viewName = value.ViewName;
			string dynamicTabName = value.DynamicTabName;
			if (GuideTestUtil.CheckIsTestStep(this.Id))
			{
				viewName = GuideTestUtil.GuideTestParams.ViewName;
			}
			if (string.IsNullOrEmpty(viewName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.TL;
				string message = "聚焦引导步骤未配置界面名称";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("步骤Id", value.GuideId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo((EUiViewName)viewName);
			if (uiViewInfo == null)
			{
				return false;
			}
			UiViewBase uiViewBase;
			if (uiViewInfo.Type == ELayerType.Float)
			{
				uiViewBase = UiModel.Instance.GetFloatView((EUiViewName)viewName);
				if (uiViewBase == null)
				{
				}
			}
			else
			{
				uiViewBase = UiModel.Instance.GetTopView(uiViewInfo.Type);
			}
			if (uiViewBase == null)
			{
				return false;
			}
			if (uiViewBase.ViewInfo.Name != viewName)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Guide;
				ELogAuthor author2 = ELogAuthor.TL;
				string message2 = "当前打开的界面与聚焦步骤的目标界面不一致";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("当前打开界面", uiViewBase.ViewInfo.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("聚焦引导目标界面", viewName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("步骤Id", value.GuideId);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			if (!string.IsNullOrEmpty(dynamicTabName))
			{
				EventSystem.Instance.Emit<GuideStepInfo, GuideFocusNew>(EEventName.GuideFocusNeedUiTabView, this, value);
			}
			else
			{
				this.ViewData.SetAttachedView(uiViewBase);
			}
			return true;
		}

		// Token: 0x06022A94 RID: 141972 RVA: 0x009DCBF4 File Offset: 0x009DADF4
		private bool CheckCanTriggerTimeDilationGuide()
		{
			if (UiTimeDilation.Instance.IsUiTimeDilated)
			{
				return true;
			}
			if (UiModel.Instance.GetTopView(ELayerType.Pop) != null)
			{
				return false;
			}
			UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Normal);
			EUiViewName? euiViewName;
			if (topView == null)
			{
				euiViewName = null;
			}
			else
			{
				UiViewInfo viewInfo = topView.ViewInfo;
				euiViewName = ((viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null);
			}
			return euiViewName == EUiViewName.BattleView;
		}

		// Token: 0x06022A95 RID: 141973 RVA: 0x009DCC76 File Offset: 0x009DAE76
		private void StartLockInput()
		{
			if (this.LockInputTimer == null)
			{
				GuideModel.Instance.AddGuideLockInput();
				this.LockInputTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float id)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Guide;
					ELogAuthor author = ELogAuthor.JT;
					string message = "[Guide][引导触发后5秒没打开对应界面,触发保底]";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("步骤Id", this.Id);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.SwitchState(EGuideStepState.Break);
					if (GuideModel.Instance.IsGuideLockingInput)
					{
						GuideModel.Instance.RemoveGuideLockInput();
					}
				}, 4000f, null, null, true, 1f);
			}
		}

		// Token: 0x06022A96 RID: 141974 RVA: 0x009DCCB3 File Offset: 0x009DAEB3
		public void StopLockInput()
		{
			if (this.LockInputTimer != null)
			{
				GuideModel.Instance.RemoveGuideLockInput();
				TimerSystem.GameplayTimeInstance.Remove(this.LockInputTimer);
				this.LockInputTimer = null;
			}
		}

		// Token: 0x06022A97 RID: 141975 RVA: 0x009DCCE0 File Offset: 0x009DAEE0
		public bool CanEnterExecuting()
		{
			if (!this.CheckEnterExecutingConditions())
			{
				return false;
			}
			switch (this.Config.ContentType)
			{
			case 1:
			{
				bool flag = false;
				foreach (EUiViewName viewName in GuideDefine.guideTipsAllowedViews)
				{
					if (UiManager.Instance.IsViewOpen(viewName))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Guide;
					ELogAuthor author = ELogAuthor.WZ;
					string message = "tip引导步骤触发时, 玩家没有位于允许触发的界面";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("步骤Id", this.Id);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return false;
				}
				if (UiManager.Instance.IsViewOpen(EUiViewName.GuideTipsView))
				{
					GuideModel.Instance.BreakTypeViewStep((EGuideViewType)this.Config.ContentType);
					return false;
				}
				if (!this.CheckCanTriggerTimeDilationGuide() && this.Config.TimeScale < 1f)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Guide;
					ELogAuthor author2 = ELogAuthor.WZ;
					string message2 = "[Guide][有时停的【tip引导】触发时，有非战斗的页面打开，且ui未时停。引导不可触发]";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("步骤Id", this.Id);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return false;
				}
				return true;
			}
			case 3:
				if (!this.CheckCanTriggerTimeDilationGuide() && this.Config.TimeScale < 1f)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Guide;
					ELogAuthor author3 = ELogAuthor.WZ;
					string message3 = "[Guide][有时停的【图文引导】触发时，有非战斗的页面打开，且ui未时停。引导不可触发]";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("步骤Id", this.Id);
					instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					return false;
				}
				return true;
			case 4:
			{
				if (!this.CheckTargetViewOpen())
				{
					this.StopLockInput();
					return false;
				}
				if (this.IsNeedNormalMask())
				{
					this.StartLockInput();
				}
				UiPanelBase viewObj = this.ViewData.GetAttachedView();
				if (viewObj == null)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.Guide;
					ELogAuthor author4 = ELogAuthor.TL;
					string message4 = "聚焦引导  依附的页签界面不存在或未打开";
					ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("this.Id", this.Id);
					instance4.Warn(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
					return false;
				}
				if (this.GuideFocusBehavior == null)
				{
					this.GuideFocusBehavior = new UiBehaviorGuideFocus(viewObj);
					this.GuideFocusBehavior.SetParam(new object[]
					{
						this
					});
				}
				this.GuideFocusBehavior.SetOwner(viewObj);
				if (!this.GuideFocusBehavior.PrepareForOpenGuideFocus())
				{
					return false;
				}
				UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.GuideFocusView);
				if (viewByName != null && !viewByName.WaitToDestroy && !viewByName.IsDestroyOrDestroying)
				{
					GuideModel.Instance.BreakTypeViewStep((EGuideViewType)this.Config.ContentType);
					return false;
				}
				if (this.GuideFocusBehaviorProxy == null)
				{
					this.GuideFocusBehaviorProxy = new UiBehaviorBaseProxy(this.GuideFocusBehavior);
					this.GuideFocusBehaviorProxy.CreateAsync().ContinueWith(delegate(bool _)
					{
						if (this.GuideFocusBehaviorProxy == null)
						{
							return;
						}
						this.GuideFocusBehaviorProxy.StartAsync().Forget<bool>();
						viewObj.AddUiBehaviorProxy(this.GuideFocusBehaviorProxy);
					});
				}
				this.StopLockInput();
				return true;
			}
			}
			return true;
		}

		// Token: 0x06022A98 RID: 141976 RVA: 0x009DCFCC File Offset: 0x009DB1CC
		public void ClearGuideFocusBehavior()
		{
			UiBehaviorGuideFocus guideFocusBehavior = this.GuideFocusBehavior;
			if (guideFocusBehavior != null)
			{
				guideFocusBehavior.CleanGuideStep();
			}
			this.GuideFocusBehavior = null;
			this.GuideFocusBehaviorProxy = null;
		}

		// Token: 0x06022A99 RID: 141977 RVA: 0x009DCFF0 File Offset: 0x009DB1F0
		public bool SetLimitInputDistribute()
		{
			bool result = false;
			int contentType = this.Config.ContentType;
			if (contentType != 1)
			{
				if (contentType == 4)
				{
					GuideFocusNew value = GuideConfig.Instance.GetGuideFocus(this.Id).Value;
					foreach (string actionName in value.LimitInputEnumsIter())
					{
						InputDistributeModel.Instance.AddToLimitInputDistributeActions(actionName);
					}
					if (InputDistributeModel.Instance.HasActionLimitSet())
					{
						if (value.UseClick || value.UseMask || this.Config.TimeScale < 1f)
						{
							InputDistributeModel.Instance.AddToLimitInputDistributeActions("UI左键点击");
							InputDistributeModel.Instance.AddToLimitInputDistributeActions("显示鼠标");
						}
						result = true;
					}
				}
			}
			else
			{
				foreach (string actionName2 in GuideConfig.Instance.GetGuideTips(this.Id).Value.LimitInputEnumsIter())
				{
					InputDistributeModel.Instance.AddToLimitInputDistributeActions(actionName2);
				}
				if (InputDistributeModel.Instance.HasActionLimitSet())
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x04013345 RID: 78661
		public readonly int Id;

		// Token: 0x04013346 RID: 78662
		public readonly GuideGroupInfo OwnerGroup;

		// Token: 0x04013347 RID: 78663
		public readonly int OwnerGroupPriority;

		// Token: 0x04013348 RID: 78664
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public readonly StateMachine<GuideStepInfo, EGuideStepState> StateMachine;

		// Token: 0x04013349 RID: 78665
		public readonly GuideStepViewData ViewData;

		// Token: 0x0401334A RID: 78666
		public GuideBaseView GuideView;

		// Token: 0x0401334B RID: 78667
		public UiBehaviorBaseProxy GuideFocusBehaviorProxy;

		// Token: 0x0401334C RID: 78668
		private UiBehaviorGuideFocus GuideFocusBehavior;

		// Token: 0x0401334D RID: 78669
		private GuideStep? ConfigInner;

		// Token: 0x0401334E RID: 78670
		private TimerHandle LockInputTimer;

		// Token: 0x0401334F RID: 78671
		public bool IsExitingFromExecuting;
	}
}
