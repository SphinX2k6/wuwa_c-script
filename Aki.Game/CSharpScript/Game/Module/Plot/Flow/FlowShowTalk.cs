using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.Module.LevelLoading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x02004072 RID: 16498
	[NullableContext(2)]
	[Nullable(0)]
	public class FlowShowTalk
	{
		// Token: 0x06029D64 RID: 171364 RVA: 0x00BD44C4 File Offset: 0x00BD26C4
		public void FinishShowTalk()
		{
			FlowContext context = this.Context;
			long? ownerId = (context != null) ? new long?(context.FlowIncId) : null;
			this.CheckLastOption();
			this.LastHasOption = false;
			PlotModel.Instance.CenterTextTransition(false, null);
			PlotModel.Instance.ClearOptionReadState();
			PlotModel.Instance.CurShowTalk = null;
			PlotModel.Instance.OptionEnable = true;
			PlotModel.Instance.PlotTemplate.OnFinishShowTalk();
			this.Context.CurTalkId = -1;
			this.CurTalkSubtitleEnd = false;
			this.CurOptionShowing = false;
			this.Context.CurOptionId = -1;
			this.Context.CurSubActionId = 0;
			this.Context.CurShowTalk = null;
			this.Context.CurShowTalkActionId = 0;
			this.CurTalkItemIndex = -1;
			this.CurShowTalk = null;
			this.Context = null;
			this.IsShowCompleted = false;
			this.IsShowingSubtitle = false;
			this.IsPlayingStartActions = false;
			PlotController.Instance.ClearUi(ownerId);
			FlowController.Instance.EnableSkip(false);
			if (this.Level != null && this.CheckPlotLevelInAbc())
			{
				CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitCameraGuideAtOnce();
			}
			if (TimerSystem.Instance.Has(this.DelayPlayGamepadShakeHandle))
			{
				TimerSystem.Instance.Remove(this.DelayPlayGamepadShakeHandle);
			}
			if (this.StopGamepadShakeParams != null)
			{
				Global.CharacterController.StopKuroForceFeedback(this.StopGamepadShakeParams.GamepadShakeAsset, this.StopGamepadShakeParams.Tag);
				IStopGamepadShake stopGamepadShakeParams = this.StopGamepadShakeParams;
				bool flag;
				if (stopGamepadShakeParams == null)
				{
					flag = false;
				}
				else
				{
					UForceFeedbackComponent feedbackComponent = stopGamepadShakeParams.FeedbackComponent;
					flag = ((feedbackComponent != null) ? new bool?(feedbackComponent.IsValid()) : null).GetValueOrDefault();
				}
				if (flag)
				{
					this.StopGamepadShakeParams.FeedbackComponent.Stop();
				}
			}
			this.Level = null;
			EventSystem.Instance.Emit(EEventName.PlotEndShowTalk);
			FlowController.Instance.RunNextAction();
		}

		// Token: 0x06029D65 RID: 171365 RVA: 0x00BD46A8 File Offset: 0x00BD28A8
		[NullableContext(1)]
		public void Start(ShowTalk inShowTalk, FlowContext context)
		{
			this.CurShowTalk = inShowTalk;
			this.Context = context;
			this.CurTalkItemIndex = -1;
			this.Level = PlotModel.Instance.PlotConfig.PlotLevel;
			PlotModel.Instance.ResetOptionReadState(inShowTalk);
			List<ITalkItem> list = (inShowTalk != null) ? inShowTalk.TalkItems : null;
			ITalkItem talkItem = (list != null && list.Count > 0) ? list[0] : null;
			if (this.Level.GetValueOrDefault() == EPlotLevel.LevelC)
			{
				bool flag;
				if (talkItem == null)
				{
					flag = true;
				}
				else
				{
					ITalkBackground backgroundConfig = talkItem.BackgroundConfig;
					if (backgroundConfig == null)
					{
						flag = true;
					}
					else
					{
						ETalkBackgroundType type = backgroundConfig.Type;
						flag = false;
					}
				}
				if (flag && (talkItem == null || talkItem.Type.GetValueOrDefault() != ETalkItemType.CenterText))
				{
					LevelLoadingController instance = LevelLoadingController.Instance;
					ELoadingReason reason = ELoadingReason.Common;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 3);
					defaultInterpolatedStringHandler.AppendLiteral("FlowShowTalk_");
					defaultInterpolatedStringHandler.AppendFormatted(context.FlowListName);
					defaultInterpolatedStringHandler.AppendLiteral("_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(context.FlowId);
					defaultInterpolatedStringHandler.AppendLiteral("_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(context.FlowStateId);
					instance.CloseLoading(reason, defaultInterpolatedStringHandler.ToStringAndClear(), null, new float?(0f));
				}
			}
			PlotController.Instance.PlotViewManager.EmitPlotStartShowTalk(this.CurShowTalk);
			PlotModel.Instance.CurShowTalk = inShowTalk;
			if (this.Level.GetValueOrDefault() == EPlotLevel.LevelE || this.Context.IsBackground)
			{
				this.NextShowTalkItem();
				return;
			}
			PlotController.Instance.WaitViewCallback(delegate(bool result)
			{
				if (!result)
				{
					return;
				}
				this.NextShowTalkItem();
			});
		}

		// Token: 0x06029D66 RID: 171366 RVA: 0x00BD4824 File Offset: 0x00BD2A24
		private void NextShowTalkItem()
		{
			if (this.CurShowTalk == null)
			{
				FlowController.Instance.LogError("当前不在ShowTalk节点", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.CurTalkItemIndex++;
			if (this.CurShowTalk.TalkItems == null || this.CurTalkItemIndex >= this.CurShowTalk.TalkItems.Count)
			{
				this.FinishShowTalk();
				return;
			}
			ITalkItem talkItem = this.CurShowTalk.TalkItems[this.CurTalkItemIndex];
			this.HandleShowTalkItem(talkItem).Forget();
		}

		// Token: 0x06029D67 RID: 171367 RVA: 0x00BD48B0 File Offset: 0x00BD2AB0
		public void SwitchTalkItem(int inTalkId)
		{
			int count = this.CurShowTalk.TalkItems.Count;
			for (int i = 0; i < count; i++)
			{
				ITalkItem talkItem = this.CurShowTalk.TalkItems[i];
				if (talkItem.Id == inTalkId)
				{
					this.CurTalkItemIndex = i;
					this.HandleShowTalkItem(talkItem).Forget();
					return;
				}
			}
			this.FinishShowTalk();
		}

		// Token: 0x06029D68 RID: 171368 RVA: 0x00BD4910 File Offset: 0x00BD2B10
		[NullableContext(1)]
		private UniTask HandleShowTalkItem(ITalkItem talkItem)
		{
			FlowShowTalk.<HandleShowTalkItem>d__19 <HandleShowTalkItem>d__;
			<HandleShowTalkItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleShowTalkItem>d__.<>4__this = this;
			<HandleShowTalkItem>d__.talkItem = talkItem;
			<HandleShowTalkItem>d__.<>1__state = -1;
			<HandleShowTalkItem>d__.<>t__builder.Start<FlowShowTalk.<HandleShowTalkItem>d__19>(ref <HandleShowTalkItem>d__);
			return <HandleShowTalkItem>d__.<>t__builder.Task;
		}

		// Token: 0x06029D69 RID: 171369 RVA: 0x00BD495C File Offset: 0x00BD2B5C
		private void PlayStartActions()
		{
			if (this.IsPlayingStartActions)
			{
				return;
			}
			ITalkItem curTalkItem = this.CurTalkItem;
			List<ActionInfo> list = (curTalkItem != null) ? curTalkItem.IntroActions : null;
			if (list == null || list.Count == 0)
			{
				return;
			}
			this.IsPlayingStartActions = true;
			FlowController.Instance.ExecuteSubActions(list, new Action<bool>(this.OnStartActionsCompleted), false);
		}

		// Token: 0x06029D6A RID: 171370 RVA: 0x00BD49B0 File Offset: 0x00BD2BB0
		private void OnStartActionsCompleted(bool result)
		{
			this.IsPlayingStartActions = false;
			this.HandleShowTalkItemEnd(null);
		}

		// Token: 0x06029D6B RID: 171371 RVA: 0x00BD49C0 File Offset: 0x00BD2BC0
		private unsafe void HandleShowTalkItemEnd(ITalkItem config = null)
		{
			if (this.CurShowTalk == null || this.CurTalkSubtitleEnd || this.IsPlayingStartActions || this.IsShowingSubtitle)
			{
				return;
			}
			ITalkItem talkItem = config ?? this.CurTalkItem;
			if (!this.IsShowCompleted)
			{
				FlowController instance = FlowController.Instance;
				string text = "HandleShowTalkItemEnd 在 IsShowCompleted==false 时被调用，展示流程可能被提前打断";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("InvokeTalkId", (talkItem != null) ? new int?(talkItem.Id) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HasConfig", config != null);
				instance.LogError(text, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			global::Log instance2 = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[FlowShowTalk][Subtitle] 字幕完成";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", talkItem.Id);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.CurTalkSubtitleEnd = true;
			this.CurTalkItem = null;
			PlotController.Instance.PlotViewManager.OnSubmitSubtitle();
			FlowController.Instance.ExecuteSubActions(talkItem.Actions, new Action<bool>(this.OnTalkActionCompleted), false);
		}

		// Token: 0x06029D6C RID: 171372 RVA: 0x00BD4AE4 File Offset: 0x00BD2CE4
		private void OnTalkActionCompleted(bool result)
		{
			if (!result)
			{
				return;
			}
			ITalkItem talkItem = this.CurShowTalk.TalkItems[this.CurTalkItemIndex];
			if (this.Level.GetValueOrDefault() == EPlotLevel.LevelE)
			{
				this.NextShowTalkItem();
				return;
			}
			if (this.Level.GetValueOrDefault() == EPlotLevel.LevelD && talkItem.TimeLimitOptionGroup == null)
			{
				this.NextShowTalkItem();
				return;
			}
			if (talkItem.Type.GetValueOrDefault() == ETalkItemType.SystemOption)
			{
				this.CurOptionShowing = true;
				PlotController.Instance.ShowSystemOption(talkItem, new Action<int, List<ActionInfo>>(this.SelectOption));
				return;
			}
			if (talkItem.Options == null || talkItem.Options.Count <= 0)
			{
				this.NextShowTalkItem();
				return;
			}
			this.Context.CurOptionId = -1;
			this.CurOptionShowing = true;
			if (this.Context.IsBackground)
			{
				int recommendedOption = FlowController.Instance.GetRecommendedOption(talkItem);
				List<ActionInfo> actions = talkItem.Options[recommendedOption].Actions;
				this.HandleShowTalkItemOption(recommendedOption, actions);
				return;
			}
			PlotController.Instance.PlotViewManager.ShowPlotSubtitleOptions();
		}

		// Token: 0x06029D6D RID: 171373 RVA: 0x00BD4BE4 File Offset: 0x00BD2DE4
		[NullableContext(1)]
		public void HandleShowTalkItemOption(int optionId, List<ActionInfo> inActions)
		{
			FlowContext context = this.Context;
			if (((context != null) ? context.CurShowTalk : null) == null)
			{
				return;
			}
			if (this.Context.CurOptionId != -1 || !this.CurOptionShowing)
			{
				return;
			}
			this.LastSelectedOption = true;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[FlowShowTalk][Subtitle] 选择选项";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", optionId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.Context.CurOptionId = optionId;
			this.CurOptionShowing = false;
			PlotController.Instance.PlotViewManager.OnSelectedOptions();
			FlowController.Instance.SelectOption(this.Context.CurTalkId, optionId);
			FlowController.Instance.ExecuteSubActions(inActions, new Action<bool>(this.OnOptionActionCompleted), false);
		}

		// Token: 0x06029D6E RID: 171374 RVA: 0x00BD4CA0 File Offset: 0x00BD2EA0
		public void OnOptionActionCompleted(bool result)
		{
			if (!result)
			{
				return;
			}
			this.NextShowTalkItem();
		}

		// Token: 0x06029D6F RID: 171375 RVA: 0x00BD4CAC File Offset: 0x00BD2EAC
		public void Skip()
		{
			if (this.CurTalkItemIndex == -1)
			{
				this.NextShowTalkItem();
				return;
			}
			if (this.CurTalkItemIndex < this.CurShowTalk.TalkItems.Count)
			{
				if (this.CurOptionShowing)
				{
					ITalkItem talkItem = this.CurShowTalk.TalkItems[this.CurTalkItemIndex];
					int recommendedOption = FlowController.Instance.GetRecommendedOption(talkItem);
					this.HandleShowTalkItemOption(recommendedOption, talkItem.Options[recommendedOption].Actions);
					return;
				}
				if (!this.CurTalkSubtitleEnd && this.IsShowCompleted)
				{
					this.SubmitSubtitleInternal(this.CurShowTalk.TalkItems[this.CurTalkItemIndex]);
					return;
				}
			}
			else
			{
				this.FinishShowTalk();
			}
		}

		// Token: 0x06029D70 RID: 171376 RVA: 0x00BD4D58 File Offset: 0x00BD2F58
		private void CheckLastOption()
		{
			if (this.LastHasOption && !this.LastSelectedOption)
			{
				FlowController instance = FlowController.Instance;
				string text = "遗漏选项C级";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Miss TalkItem Id", this.LastId);
				instance.LogError(text, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			ShowTalk curShowTalk = this.CurShowTalk;
			if (((curShowTalk != null) ? curShowTalk.TalkItems : null) == null || this.CurTalkItemIndex >= this.CurShowTalk.TalkItems.Count)
			{
				return;
			}
			this.LastHasOption = (this.CurShowTalk.TalkItems[this.CurTalkItemIndex].Options != null && this.CurShowTalk.TalkItems[this.CurTalkItemIndex].Options.Count > 0);
			this.LastId = this.CurShowTalk.TalkItems[this.CurTalkItemIndex].Id;
		}

		// Token: 0x06029D71 RID: 171377 RVA: 0x00BD4E39 File Offset: 0x00BD3039
		private void PlayMontage()
		{
			FlowContext context = this.Context;
			if (context != null && context.IsBackground)
			{
				return;
			}
			PlotModel.Instance.HandlePlayMontage(this.CurTalkItem.Montage);
		}

		// Token: 0x06029D72 RID: 171378 RVA: 0x00BD4E68 File Offset: 0x00BD3068
		private void PlayGamepadShake(IGamepadShakeInTalk config)
		{
			FlowContext context = this.Context;
			if ((context != null && context.IsBackground) || config == null || this.Level.GetValueOrDefault() != EPlotLevel.LevelC)
			{
				return;
			}
			this.DelayPlayGamepadShakeHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.StopGamepadShakeParams = new StopGamepadShakeImpl();
				GamepadController.Instance.TriggerGamepadShakeEvent(config.Options, this.StopGamepadShakeParams).Forget();
			}, (float)((int)(config.DelayTime * 1000f)), null, null, true, 1f);
		}

		// Token: 0x06029D73 RID: 171379 RVA: 0x00BD4EEC File Offset: 0x00BD30EC
		private UniTask SetBackgroundImage()
		{
			FlowShowTalk.<SetBackgroundImage>d__30 <SetBackgroundImage>d__;
			<SetBackgroundImage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetBackgroundImage>d__.<>4__this = this;
			<SetBackgroundImage>d__.<>1__state = -1;
			<SetBackgroundImage>d__.<>t__builder.Start<FlowShowTalk.<SetBackgroundImage>d__30>(ref <SetBackgroundImage>d__);
			return <SetBackgroundImage>d__.<>t__builder.Task;
		}

		// Token: 0x06029D74 RID: 171380 RVA: 0x00BD4F30 File Offset: 0x00BD3130
		[NullableContext(1)]
		private UniTask SetTemplate(ITalkItem talkItem)
		{
			FlowShowTalk.<SetTemplate>d__31 <SetTemplate>d__;
			<SetTemplate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTemplate>d__.<>4__this = this;
			<SetTemplate>d__.talkItem = talkItem;
			<SetTemplate>d__.<>1__state = -1;
			<SetTemplate>d__.<>t__builder.Start<FlowShowTalk.<SetTemplate>d__31>(ref <SetTemplate>d__);
			return <SetTemplate>d__.<>t__builder.Task;
		}

		// Token: 0x06029D75 RID: 171381 RVA: 0x00BD4F7C File Offset: 0x00BD317C
		private UniTask ShowCenterTextView()
		{
			FlowShowTalk.<ShowCenterTextView>d__32 <ShowCenterTextView>d__;
			<ShowCenterTextView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowCenterTextView>d__.<>4__this = this;
			<ShowCenterTextView>d__.<>1__state = -1;
			<ShowCenterTextView>d__.<>t__builder.Start<FlowShowTalk.<ShowCenterTextView>d__32>(ref <ShowCenterTextView>d__);
			return <ShowCenterTextView>d__.<>t__builder.Task;
		}

		// Token: 0x06029D76 RID: 171382 RVA: 0x00BD4FC0 File Offset: 0x00BD31C0
		private void ShowSubtitle()
		{
			if (this.Context.IsBackground)
			{
				return;
			}
			this.IsShowingSubtitle = true;
			if (this.Level.GetValueOrDefault() == EPlotLevel.LevelE && PlotController.Instance.ShowTipsView(this.CurTalkItem, this.Context.PromptStyle.Value, this.Context.UiParam))
			{
				return;
			}
			if (this.Level.GetValueOrDefault() == EPlotLevel.LevelC)
			{
				ITalkItem curTalkItem = this.CurTalkItem;
				if (curTalkItem != null && curTalkItem.Type.GetValueOrDefault() == ETalkItemType.CenterText)
				{
					PlotModel.Instance.ShowTalkCenterText((ITalkItemCenterText)this.CurTalkItem, delegate
					{
						this.SubmitSubtitle(null);
					});
					return;
				}
			}
			PlotController.Instance.PlotViewManager.UpdatePlotSubtitle(this.CurTalkItem);
		}

		// Token: 0x06029D77 RID: 171383 RVA: 0x00BD5082 File Offset: 0x00BD3282
		private void SubmitSubtitleInternal(ITalkItem config = null)
		{
			this.IsShowingSubtitle = false;
			this.HandleShowTalkItemEnd(config);
		}

		// Token: 0x06029D78 RID: 171384 RVA: 0x00BD5092 File Offset: 0x00BD3292
		public void SubmitSubtitle(ITalkItem config)
		{
			if (this.Context == null || this.Context.IsBackground)
			{
				return;
			}
			this.SubmitSubtitleInternal(config);
		}

		// Token: 0x06029D79 RID: 171385 RVA: 0x00BD50B1 File Offset: 0x00BD32B1
		[NullableContext(1)]
		public void SelectOption(int optionId, List<ActionInfo> inActions)
		{
			if (this.Context == null || this.Context.IsBackground)
			{
				return;
			}
			this.HandleShowTalkItemOption(optionId, inActions);
		}

		// Token: 0x06029D7A RID: 171386 RVA: 0x00BD50D4 File Offset: 0x00BD32D4
		public bool CheckPlotLevelInAbc()
		{
			EPlotLevel? level = this.Level;
			EPlotLevel eplotLevel = EPlotLevel.LevelA;
			return (level.GetValueOrDefault() == eplotLevel & level != null) || this.Level.GetValueOrDefault() == EPlotLevel.LevelB || this.Level.GetValueOrDefault() == EPlotLevel.LevelC;
		}

		// Token: 0x04016D20 RID: 93472
		public ShowTalk CurShowTalk;

		// Token: 0x04016D21 RID: 93473
		public int CurTalkItemIndex;

		// Token: 0x04016D22 RID: 93474
		public FlowContext Context;

		// Token: 0x04016D23 RID: 93475
		private EPlotLevel? Level;

		// Token: 0x04016D24 RID: 93476
		private ITalkItem CurTalkItem;

		// Token: 0x04016D25 RID: 93477
		private int LastId = -1;

		// Token: 0x04016D26 RID: 93478
		private bool LastHasOption;

		// Token: 0x04016D27 RID: 93479
		private bool LastSelectedOption;

		// Token: 0x04016D28 RID: 93480
		private bool IsShowCompleted;

		// Token: 0x04016D29 RID: 93481
		private bool CurTalkSubtitleEnd;

		// Token: 0x04016D2A RID: 93482
		private bool CurOptionShowing;

		// Token: 0x04016D2B RID: 93483
		private bool IsPlayingStartActions;

		// Token: 0x04016D2C RID: 93484
		public bool IsShowingSubtitle;

		// Token: 0x04016D2D RID: 93485
		private IStopGamepadShake StopGamepadShakeParams;

		// Token: 0x04016D2E RID: 93486
		private TimerHandle DelayPlayGamepadShakeHandle;
	}
}
