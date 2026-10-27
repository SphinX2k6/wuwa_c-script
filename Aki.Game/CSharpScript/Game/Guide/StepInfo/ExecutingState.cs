using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x02004607 RID: 17927
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class ExecutingState : StateBase<GuideStepInfo, EGuideStepState>
	{
		// Token: 0x0602E382 RID: 189314 RVA: 0x00AAFAEE File Offset: 0x00AADCEE
		public ExecutingState(GuideStepInfo owner, EGuideStepState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideStepInfo, EGuideStepState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E383 RID: 189315 RVA: 0x00AAFB00 File Offset: 0x00AADD00
		private void OpenGuideView()
		{
			GuideStepInfo stepInfo = this.Owner;
			if (stepInfo.GuideView != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.TL;
				string message = "重复打开引导界面";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("步骤Id", stepInfo.Id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (stepInfo.Config.ContentType == 3)
			{
				GuideTutorial? guideTutorial = GuideConfig.Instance.GetGuideTutorial(this.Owner.Id);
				bool isPreExecute = this.Owner.OwnerGroup.GetIfPreExecute();
				bool isSilentUnlock = guideTutorial.Value.SilentUnlock;
				TutorialController.Instance.TryUnlockAndOpenTutorialTip(guideTutorial.Value.Id, delegate(bool success)
				{
					if (!success)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Guide;
						ELogAuthor author2 = ELogAuthor.TL;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 1);
						defaultInterpolatedStringHandler.AppendLiteral("打开教学引导失败, 教学目录请求解锁协议返回失败, 触发打断, 步骤ID: ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(stepInfo.Id);
						instance2.Warn(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
						this.Owner.SwitchState(EGuideStepState.Break);
						return;
					}
					if (!this.IsValid)
					{
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.Guide;
						ELogAuthor author3 = ELogAuthor.TL;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
						defaultInterpolatedStringHandler.AppendLiteral("打开教学引导失败, 当前已退出执行状态, 步骤ID: ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(stepInfo.Id);
						instance3.Warn(module3, author3, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
						return;
					}
					if (isSilentUnlock)
					{
						Log instance4 = Log.Instance;
						ELogModule module4 = ELogModule.Guide;
						ELogAuthor author4 = ELogAuthor.HYF;
						string message2 = "图文引导静默解锁";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("步骤Id", stepInfo.Id);
						instance4.Info(module4, author4, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						this.Owner.SwitchState(EGuideStepState.Finish);
						return;
					}
					if (!isPreExecute)
					{
						this.OpenTutorialGuide(stepInfo);
					}
				});
				if (isPreExecute && !isSilentUnlock)
				{
					this.OpenTutorialGuide(stepInfo);
					return;
				}
			}
			else
			{
				GuideModel.Instance.OpenGuideView(stepInfo);
			}
		}

		// Token: 0x0602E384 RID: 189316 RVA: 0x00AAFC18 File Offset: 0x00AADE18
		private void OpenTutorialGuide(GuideStepInfo stepInfo)
		{
			TutorialListInfo tutorialListInfo = new TutorialListInfo(stepInfo);
			tutorialListInfo.Init();
			GuideModel.Instance.AddTutorialInfo(tutorialListInfo);
		}

		// Token: 0x0602E385 RID: 189317 RVA: 0x00AAFC3D File Offset: 0x00AADE3D
		private void ClearShowDelayTimer()
		{
			if (this.ShowDelayTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ShowDelayTimer);
				this.ShowDelayTimer = null;
			}
		}

		// Token: 0x0602E386 RID: 189318 RVA: 0x00AAFC5F File Offset: 0x00AADE5F
		private void ClearTimeDilationCheckTimer()
		{
			if (this.TimeDilationCheckTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimeDilationCheckTimer);
				this.TimeDilationCheckTimer = null;
			}
		}

		// Token: 0x0602E387 RID: 189319 RVA: 0x00AAFC84 File Offset: 0x00AADE84
		private unsafe void StartTimeDilationCheckTimer()
		{
			int duration = this.Owner.Config.Duration;
			if (duration == 0)
			{
				return;
			}
			if (this.TimeDilationCheckTimer == null)
			{
				int realGuaranteedTime = 30000;
				if (duration > 30000)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Guide;
					ELogAuthor author = ELogAuthor.TL;
					string message = "引导保底时间被配置修改";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("步骤Id", this.Owner.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("组Id", this.Owner.OwnerGroup.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("新保底时间", duration);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					realGuaranteedTime = duration + 2000;
				}
				this.TimeDilationCheckTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					this.TimeDilationCheckTimer = null;
					if (this.Owner.Config.IsTimeUpAsFinish)
					{
						this.Owner.SwitchState(EGuideStepState.Finish);
						return;
					}
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Guide;
					ELogAuthor author2 = ELogAuthor.TL;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[引导步骤][时停设置超过保底时长(");
					defaultInterpolatedStringHandler.AppendFormatted<int>(realGuaranteedTime);
					defaultInterpolatedStringHandler.AppendLiteral("秒)未清除, 触发保底机制恢复时停, 请检查引导配置触发流程是否合理！]");
					string message2 = defaultInterpolatedStringHandler.ToStringAndClear();
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("步骤Id", this.Owner.Id);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.Owner.SwitchState(EGuideStepState.Break);
				}, (float)realGuaranteedTime, null, null, true, 1f);
			}
		}

		// Token: 0x0602E388 RID: 189320 RVA: 0x00AAFDA4 File Offset: 0x00AADFA4
		protected override void OnEnter(EGuideStepState? lastState)
		{
			this.IsValid = true;
			GuideStep config = this.Owner.Config;
			float timeScale = config.TimeScale;
			if (config.ContentType == 4)
			{
				GuideModel.Instance.AddFocusGuideGroupToView(this.Owner.OwnerGroup);
			}
			if (timeScale < 1f && !GameModeModel.Instance.IsMulti)
			{
				InputDistributeController.Instance.RefreshInputTag();
				UiTimeDilation.Instance.SetTimeDilationHighLevel(timeScale, "GuideStep");
				this.StartTimeDilationCheckTimer();
			}
			else if (this.Owner.OwnerGroupPriority > 0)
			{
				this.StartTimeDilationCheckTimer();
			}
			int showDelay = config.ShowDelay;
			if (showDelay > 0)
			{
				this.ClearShowDelayTimer();
				this.ShowDelayTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					this.ShowDelayTimer = null;
					this.OnOpenGuideView();
				}, (float)showDelay, null, null, true, 1f);
				return;
			}
			this.OnOpenGuideView();
		}

		// Token: 0x0602E389 RID: 189321 RVA: 0x00AAFE74 File Offset: 0x00AAE074
		private void OnOpenGuideView()
		{
			this.OpenGuideView();
			this.Owner.ViewData.IsAttachToBattleView = UiManager.Instance.IsViewOpen(EUiViewName.BattleView);
			this.IsLimitDistribute = this.Owner.SetLimitInputDistribute();
		}

		// Token: 0x0602E38A RID: 189322 RVA: 0x00AAFEAC File Offset: 0x00AAE0AC
		protected override void OnExit(EGuideStepState nextState)
		{
			this.IsValid = false;
			GuideStepInfo owner = this.Owner;
			owner.IsExitingFromExecuting = true;
			if (this.Owner.Config.TimeScale < 1f && !GameModeModel.Instance.IsMulti)
			{
				this.ClearTimeDilationCheckTimer();
				UiTimeDilation.Instance.ResetTimeDilationHighLevel("GuideStep");
				InputDistributeController.Instance.RefreshInputTag();
			}
			else if (this.Owner.OwnerGroupPriority > 0)
			{
				this.ClearTimeDilationCheckTimer();
			}
			this.ClearShowDelayTimer();
			GuideBaseView guideView = owner.GuideView;
			if (guideView != null)
			{
				int viewId = guideView.GetViewId();
				if (!guideView.IsDestroyOrDestroying)
				{
					guideView.IgnoreState = true;
					UiManager.Instance.CloseViewById(viewId, null);
				}
				owner.GuideView = null;
			}
			GuideModel.Instance.RemoveStepViewSingletonMap(owner);
			owner.ClearGuideFocusBehavior();
			owner.ViewData.Clear();
			if (this.IsLimitDistribute)
			{
				InputDistributeModel.Instance.ClearLimitInputDistributeActions();
			}
			owner.IsExitingFromExecuting = false;
		}

		// Token: 0x04018D01 RID: 101633
		private bool IsValid = true;

		// Token: 0x04018D02 RID: 101634
		private bool IsLimitDistribute;

		// Token: 0x04018D03 RID: 101635
		[Nullable(2)]
		private TimerHandle TimeDilationCheckTimer;

		// Token: 0x04018D04 RID: 101636
		[Nullable(2)]
		private TimerHandle ShowDelayTimer;
	}
}
