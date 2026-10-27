using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020050A2 RID: 20642
	[NullableContext(2)]
	[Nullable(0)]
	public class FlowShowTalk
	{
		// Token: 0x06034E6B RID: 216683 RVA: 0x00C8723C File Offset: 0x00C8543C
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

		// Token: 0x06034E6C RID: 216684 RVA: 0x00C87420 File Offset: 0x00C85620
		[NullableContext(1)]
		public void Start(ShowTalk inShowTalk, FlowContext context)
		{
			this.CurShowTalk = inShowTalk;
			this.Context = context;
			this.CurTalkItemIndex = -1;
			this.Level = PlotModel.Instance.PlotConfig.PlotLevel;
			PlotModel.Instance.ResetOptionReadState(inShowTalk);
			if (this.Level.GetValueOrDefault() == EPlotLevel.LevelC)
			{
				bool flag;
				if (inShowTalk == null)
				{
					flag = true;
				}
				else
				{
					ITalkItem talkItem = inShowTalk.TalkItems.ElementAtOrDefault(0);
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
				}
				if (flag)
				{
					bool flag2;
					if (inShowTalk == null)
					{
						flag2 = true;
					}
					else
					{
						ITalkItem talkItem2 = inShowTalk.TalkItems.ElementAtOrDefault(0);
						flag2 = (((talkItem2 != null) ? talkItem2.Type : null).GetValueOrDefault() != ETalkItemType.CenterText);
					}
					if (flag2)
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

		// Token: 0x06034E6D RID: 216685 RVA: 0x00C875A4 File Offset: 0x00C857A4
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

		// Token: 0x06034E6E RID: 216686 RVA: 0x00C87630 File Offset: 0x00C85830
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

		// Token: 0x06034E6F RID: 216687 RVA: 0x00C87690 File Offset: 0x00C85890
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

		// Token: 0x06034E70 RID: 216688 RVA: 0x00C876DC File Offset: 0x00C858DC
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

		// Token: 0x06034E71 RID: 216689 RVA: 0x00C87730 File Offset: 0x00C85930
		private void OnStartActionsCompleted(bool result)
		{
			this.IsPlayingStartActions = false;
			this.HandleShowTalkItemEnd(null);
		}

		// Token: 0x06034E72 RID: 216690 RVA: 0x00C87740 File Offset: 0x00C85940
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

		// Token: 0x06034E73 RID: 216691 RVA: 0x00C87864 File Offset: 0x00C85A64
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

		// Token: 0x06034E74 RID: 216692 RVA: 0x00C87964 File Offset: 0x00C85B64
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

		// Token: 0x06034E75 RID: 216693 RVA: 0x00C87A20 File Offset: 0x00C85C20
		public void OnOptionActionCompleted(bool result)
		{
			if (!result)
			{
				return;
			}
			this.NextShowTalkItem();
		}

		// Token: 0x06034E76 RID: 216694 RVA: 0x00C87A2C File Offset: 0x00C85C2C
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

		// Token: 0x06034E77 RID: 216695 RVA: 0x00C87AD8 File Offset: 0x00C85CD8
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

		// Token: 0x06034E78 RID: 216696 RVA: 0x00C87BB9 File Offset: 0x00C85DB9
		private void PlayMontage()
		{
			FlowContext context = this.Context;
			if (context != null && context.IsBackground)
			{
				return;
			}
			PlotModel.Instance.HandlePlayMontage(this.CurTalkItem.Montage);
		}

		// Token: 0x06034E79 RID: 216697 RVA: 0x00C87BE8 File Offset: 0x00C85DE8
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

		// Token: 0x06034E7A RID: 216698 RVA: 0x00C87C6C File Offset: 0x00C85E6C
		private UniTask SetBackgroundImage()
		{
			FlowShowTalk.<SetBackgroundImage>d__30 <SetBackgroundImage>d__;
			<SetBackgroundImage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetBackgroundImage>d__.<>4__this = this;
			<SetBackgroundImage>d__.<>1__state = -1;
			<SetBackgroundImage>d__.<>t__builder.Start<FlowShowTalk.<SetBackgroundImage>d__30>(ref <SetBackgroundImage>d__);
			return <SetBackgroundImage>d__.<>t__builder.Task;
		}

		// Token: 0x06034E7B RID: 216699 RVA: 0x00C87CB0 File Offset: 0x00C85EB0
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

		// Token: 0x06034E7C RID: 216700 RVA: 0x00C87CFC File Offset: 0x00C85EFC
		private UniTask ShowCenterTextView()
		{
			FlowShowTalk.<ShowCenterTextView>d__32 <ShowCenterTextView>d__;
			<ShowCenterTextView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowCenterTextView>d__.<>4__this = this;
			<ShowCenterTextView>d__.<>1__state = -1;
			<ShowCenterTextView>d__.<>t__builder.Start<FlowShowTalk.<ShowCenterTextView>d__32>(ref <ShowCenterTextView>d__);
			return <ShowCenterTextView>d__.<>t__builder.Task;
		}

		// Token: 0x06034E7D RID: 216701 RVA: 0x00C87D40 File Offset: 0x00C85F40
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

		// Token: 0x06034E7E RID: 216702 RVA: 0x00C87E02 File Offset: 0x00C86002
		private void SubmitSubtitleInternal(ITalkItem config = null)
		{
			this.IsShowingSubtitle = false;
			this.HandleShowTalkItemEnd(config);
		}

		// Token: 0x06034E7F RID: 216703 RVA: 0x00C87E12 File Offset: 0x00C86012
		public void SubmitSubtitle(ITalkItem config)
		{
			if (this.Context == null || this.Context.IsBackground)
			{
				return;
			}
			this.SubmitSubtitleInternal(config);
		}

		// Token: 0x06034E80 RID: 216704 RVA: 0x00C87E31 File Offset: 0x00C86031
		[NullableContext(1)]
		public void SelectOption(int optionId, List<ActionInfo> inActions)
		{
			if (this.Context == null || this.Context.IsBackground)
			{
				return;
			}
			this.HandleShowTalkItemOption(optionId, inActions);
		}

		// Token: 0x06034E81 RID: 216705 RVA: 0x00C87E54 File Offset: 0x00C86054
		public bool CheckPlotLevelInAbc()
		{
			EPlotLevel? level = this.Level;
			EPlotLevel eplotLevel = EPlotLevel.LevelA;
			return (level.GetValueOrDefault() == eplotLevel & level != null) || this.Level.GetValueOrDefault() == EPlotLevel.LevelB || this.Level.GetValueOrDefault() == EPlotLevel.LevelC;
		}

		// Token: 0x0401C2EF RID: 115439
		public ShowTalk CurShowTalk;

		// Token: 0x0401C2F0 RID: 115440
		public int CurTalkItemIndex;

		// Token: 0x0401C2F1 RID: 115441
		public FlowContext Context;

		// Token: 0x0401C2F2 RID: 115442
		private EPlotLevel? Level;

		// Token: 0x0401C2F3 RID: 115443
		private ITalkItem CurTalkItem;

		// Token: 0x0401C2F4 RID: 115444
		private int LastId = -1;

		// Token: 0x0401C2F5 RID: 115445
		private bool LastHasOption;

		// Token: 0x0401C2F6 RID: 115446
		private bool LastSelectedOption;

		// Token: 0x0401C2F7 RID: 115447
		private bool IsShowCompleted;

		// Token: 0x0401C2F8 RID: 115448
		private bool CurTalkSubtitleEnd;

		// Token: 0x0401C2F9 RID: 115449
		private bool CurOptionShowing;

		// Token: 0x0401C2FA RID: 115450
		private bool IsPlayingStartActions;

		// Token: 0x0401C2FB RID: 115451
		public bool IsShowingSubtitle;

		// Token: 0x0401C2FC RID: 115452
		private IStopGamepadShake StopGamepadShakeParams;

		// Token: 0x0401C2FD RID: 115453
		private TimerHandle DelayPlayGamepadShakeHandle;
	}
}
