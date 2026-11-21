using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Avg;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x020052A4 RID: 21156
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballPlotView : UiTickViewBase, IPlotAvgPerformHandler
	{
		// Token: 0x06034A48 RID: 215624 RVA: 0x00EB8E63 File Offset: 0x00EB7063
		public PinballPlotView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x17006652 RID: 26194
		// (get) Token: 0x06034A49 RID: 215625 RVA: 0x00EB8E6C File Offset: 0x00EB706C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected ITalkOption[] CurrentOptions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.CurrentContent == null)
				{
					return null;
				}
				List<ITalkOption> options = this.CurrentContent.Options;
				if (options == null)
				{
					return null;
				}
				return options.ToArray();
			}
		}

		// Token: 0x17006653 RID: 26195
		// (get) Token: 0x06034A4A RID: 215626 RVA: 0x00EB8E90 File Offset: 0x00EB7090
		protected bool HasOptions
		{
			get
			{
				ITalkOption[] currentOptions = this.CurrentOptions;
				return currentOptions != null && currentOptions.Length != 0;
			}
		}

		// Token: 0x06034A4B RID: 215627 RVA: 0x00EB8EB0 File Offset: 0x00EB70B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 29;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnNextButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnContinueButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034A4C RID: 215628 RVA: 0x00EB930C File Offset: 0x00EB750C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballPlotView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballPlotView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A4D RID: 215629 RVA: 0x00EB9350 File Offset: 0x00EB7550
		protected override void OnStart()
		{
			UUILayoutBase layoutBase = base.GetLayoutBase(20);
			this.OptionLayout = new GenericLayout<PinballPlotOptionItem, IPinballPlotOptionItemData>(layoutBase, new Func<PinballPlotOptionItem>(this.CreateOptionItem), null, false, true);
			this.InitSkipComponent();
			this.InitDialogTextWriterComponent();
			this.InitCenterTextWriterComponent();
			this.InitTextScrollComponent();
			this.InitOptionComponent();
			this.InitWaitingProxyComponent();
			this.InitWaitingItemSeqPlayer();
			this.InitAutoPlayComponent();
			base.GetItem(7).SetUIActive(false);
			base.GetItem(25).SetUIActive(false);
			this.UiViewSequence.AddSequenceFinishEvent("Scene_Out", delegate(string _)
			{
				this.OnSceneOutSeqEnd();
			}, false);
			this.UiViewSequence.StartSequenceName = "Switch_In";
			this.UiViewSequence.CloseSequenceName = "Switch_Out";
			this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnEventSequence));
		}

		// Token: 0x06034A4E RID: 215630 RVA: 0x00EB9425 File Offset: 0x00EB7625
		private void OnEventSequence(string sequenceName, string eventName)
		{
			if (eventName == "Switch_In")
			{
				EventSystem.Instance.Emit(EEventName.OnPinballBattleViewSwitchIn);
			}
		}

		// Token: 0x06034A4F RID: 215631 RVA: 0x00EB9444 File Offset: 0x00EB7644
		private void OnSceneOutSeqEnd()
		{
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x06034A50 RID: 215632 RVA: 0x00EB9454 File Offset: 0x00EB7654
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PlotConfigChanged, new Action(this.UpdateByPlotConfig));
			EventSystem.Instance.Add<ShowTalk>(EEventName.PlotStartShowTalk, new Action<ShowTalk>(this.OnShowTalkStart));
			EventSystem.Instance.Add(EEventName.ClearPlotSubtitle, new Action(this.ClearPlotSubtitle));
			EventSystem.Instance.Add<bool>(EEventName.HidePlotUi, new Action<bool>(this.HideAll));
			EventSystem.Instance.Add(EEventName.ShowPlotSubtitleOptions, new Action(this.ShowOptions));
			EventSystem.Instance.Add<ITalkItem>(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.PlayTalk));
			this.SkipComp.AddEventListener();
		}

		// Token: 0x06034A51 RID: 215633 RVA: 0x00EB9514 File Offset: 0x00EB7714
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PlotConfigChanged, new Action(this.UpdateByPlotConfig));
			EventSystem.Instance.Remove<ShowTalk>(EEventName.PlotStartShowTalk, new Action<ShowTalk>(this.OnShowTalkStart));
			EventSystem.Instance.Remove(EEventName.ClearPlotSubtitle, new Action(this.ClearPlotSubtitle));
			EventSystem.Instance.Remove<bool>(EEventName.HidePlotUi, new Action<bool>(this.HideAll));
			EventSystem.Instance.Remove(EEventName.ShowPlotSubtitleOptions, new Action(this.ShowOptions));
			EventSystem.Instance.Remove<ITalkItem>(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.PlayTalk));
			this.SkipComp.RemoveEventListener();
		}

		// Token: 0x06034A52 RID: 215634 RVA: 0x00EB95D4 File Offset: 0x00EB77D4
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, true);
		}

		// Token: 0x06034A53 RID: 215635 RVA: 0x00EB95F2 File Offset: 0x00EB77F2
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, false);
		}

		// Token: 0x06034A54 RID: 215636 RVA: 0x00EB9610 File Offset: 0x00EB7810
		protected override void OnBeforeDestroy()
		{
			this.TextScrollComponent.Clear();
			this.DialogTextWriterComponent.Clear();
			this.CenterTextWriterComponent.Clear();
			this.WaitingProxyComponent.Clear();
			this.AutoPlayComponent.Clear();
			foreach (PinballAvgCharacter pinballAvgCharacter in this.AvgCharacterMap.Values)
			{
				pinballAvgCharacter.Destroy();
			}
			this.AvgCharacterMap.Clear();
		}

		// Token: 0x06034A55 RID: 215637 RVA: 0x00EB96A8 File Offset: 0x00EB78A8
		private void InitSkipComponent()
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(false);
			this.SkipComp = new PlotSkipComponent(base.GetButton(2), new Action(this.OnSkip), new Action(this.OnSkipPop), null, new Action(this.OnSkipCancel), new EUiBehaviourPopType?(EUiBehaviourPopType.PinballSmall), "UiItem_ComConfirmPopup");
			this.SkipComp.EnableSkipButton(false);
		}

		// Token: 0x06034A56 RID: 215638 RVA: 0x00EB9720 File Offset: 0x00EB7920
		private void InitTextScrollComponent()
		{
			PlotTextScrollComponentContext context = new PlotTextScrollComponentContext
			{
				TextComponent = base.GetText(10),
				TextScrollView = base.GetScrollView(9)
			};
			this.TextScrollComponent.Init(context);
		}

		// Token: 0x06034A57 RID: 215639 RVA: 0x00EB975C File Offset: 0x00EB795C
		private void InitDialogTextWriterComponent()
		{
			UUIText text = base.GetText(10);
			AActor owner = text.GetOwner();
			UUIEffectTextAnimation textAnimComp = owner.GetComponentByClass(UUIEffectTextAnimation.StaticClass()) as UUIEffectTextAnimation;
			ULGUIPlayTweenComponent tweenComp = owner.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent;
			PlotTextWriterComponentContext context = new PlotTextWriterComponentContext
			{
				TextComponent = text,
				TextAnimComp = textAnimComp,
				TweenComp = tweenComp,
				OnAnimCompleteDelegate = new Action(this.OnTextWriterEnd),
				OnStopDelegate = new Action(this.OnTextWriterEnd)
			};
			this.DialogTextWriterComponent.Init(context);
		}

		// Token: 0x06034A58 RID: 215640 RVA: 0x00EB97F0 File Offset: 0x00EB79F0
		private void InitCenterTextWriterComponent()
		{
			UUIText text = base.GetText(26);
			AActor owner = text.GetOwner();
			UUIEffectTextAnimation textAnimComp = owner.GetComponentByClass(UUIEffectTextAnimation.StaticClass()) as UUIEffectTextAnimation;
			ULGUIPlayTweenComponent tweenComp = owner.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent;
			PlotTextWriterComponentContext context = new PlotTextWriterComponentContext
			{
				TextComponent = text,
				TextAnimComp = textAnimComp,
				TweenComp = tweenComp,
				OnAnimCompleteDelegate = new Action(this.OnTextWriterEnd),
				OnStopDelegate = new Action(this.OnTextWriterEnd)
			};
			this.CenterTextWriterComponent.Init(context);
		}

		// Token: 0x06034A59 RID: 215641 RVA: 0x00EB9884 File Offset: 0x00EB7A84
		private void InitOptionComponent()
		{
			PlotOptionComponentContext context = new PlotOptionComponentContext
			{
				OptionsRefreshDelegate = new Action<ITalkOption[]>(this.OnRefreshOptions),
				OptionsShowDelegate = new Action(this.OnOptionsShow),
				OptionsHideDelegate = new Action(this.OnOptionsHide)
			};
			this.OptionComponent.Init(context);
		}

		// Token: 0x06034A5A RID: 215642 RVA: 0x00EB98DC File Offset: 0x00EB7ADC
		private void InitWaitingProxyComponent()
		{
			PlotWaitingProxyComponentContext context = new PlotWaitingProxyComponentContext
			{
				OnWaitingStartDelegate = new Action(this.OnWaitingStart),
				OnWaitingCompleteDelegate = new Action(this.OnWaitingComplete),
				OnWaitingCancelDelegate = new Action(this.OnWaitingCancel)
			};
			this.WaitingProxyComponent.Init(context);
		}

		// Token: 0x06034A5B RID: 215643 RVA: 0x00EB9931 File Offset: 0x00EB7B31
		private void InitWaitingItemSeqPlayer()
		{
			this.WaitingItemSeqPlayer = new LevelSequencePlayer(base.GetItem(23));
		}

		// Token: 0x06034A5C RID: 215644 RVA: 0x00EB9948 File Offset: 0x00EB7B48
		private void InitAutoPlayComponent()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			PlotAutoPlayComponentContext context = new PlotAutoPlayComponentContext
			{
				Toggle = extendToggle,
				WaitTime = PlotComponentUtils.GetAutoPlayEndWaitTime(false),
				AutoInSeqName = "Auto_In",
				AutoOutSeqName = "Auto_Out",
				CheckTalkFinishedDelegate = new Func<bool>(this.CheckTalkFinished),
				ContinueToNextTalkDelegate = new Action(this.ContinueToNextTalk)
			};
			this.AutoPlayComponent.Init(context);
		}

		// Token: 0x06034A5D RID: 215645 RVA: 0x00EB99BC File Offset: 0x00EB7BBC
		protected override void OnTick(float delta)
		{
			this.WaitingProxyComponent.OnTick(delta);
		}

		// Token: 0x06034A5E RID: 215646 RVA: 0x00EB99CC File Offset: 0x00EB7BCC
		private void UpdateByPlotConfig()
		{
			this.SkipComp.EnableSkipButton(false);
			bool canPause = PlotModel.Instance.PlotConfig.CanPause;
			this.AutoPlayComponent.SetToggleActive(canPause);
			this.AutoPlayComponent.UpdateAutoPlayToggle();
		}

		// Token: 0x06034A5F RID: 215647 RVA: 0x00EB9A0C File Offset: 0x00EB7C0C
		private void OnShowTalkStart(ShowTalk inShowTalk)
		{
			PlotSkipComponent skipComp = this.SkipComp;
			if (skipComp == null)
			{
				return;
			}
			skipComp.AddSummary(inShowTalk.TalkOutline);
		}

		// Token: 0x06034A60 RID: 215648 RVA: 0x00EB9A24 File Offset: 0x00EB7C24
		private void PlayTalk(ITalkItem talkItem)
		{
			this.ClearTalk();
			this.CurrentContent = talkItem;
			this.HandleTextLogic();
		}

		// Token: 0x06034A61 RID: 215649 RVA: 0x00EB9A3C File Offset: 0x00EB7C3C
		private void HandleTextLogic()
		{
			if (this.CurrentContent == null)
			{
				return;
			}
			ITalkItem currentContent = this.CurrentContent;
			bool flag = currentContent.Type.GetValueOrDefault() == ETalkItemType.AvgCenterText;
			bool flag2 = base.GetItem(7).IsUIActiveSelf();
			if (flag && flag2)
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.PlaySequence("Scene_Out", false, null);
				}
			}
			else if (!flag && !flag2)
			{
				base.GetItem(7).SetUIActive(true);
				UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
				if (uiViewSequence2 != null)
				{
					uiViewSequence2.PlaySequence("Scene_In", false, null);
				}
			}
			base.GetItem(25).SetUIActive(flag);
			if (flag)
			{
				this.HandleAvgCenterText(currentContent);
				return;
			}
			int? whoId = currentContent.WhoId;
			AvgTalkerConfig? avgTalkerConfig = null;
			if (whoId != null && whoId.Value != 0)
			{
				avgTalkerConfig = PlotAvgUtils.GetAvgTalkerConfigByTalkerId(whoId.Value);
			}
			if (avgTalkerConfig != null)
			{
				base.GetItem(24).SetUIActive(true);
				string configIdByTable = PublicUtil.Instance.GetConfigIdByTable(ETableText.SpeakerName, new int?(whoId.Value));
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), configIdByTable, Array.Empty<object>());
			}
			else
			{
				base.GetItem(24).SetUIActive(false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), currentContent.TidTalk, Array.Empty<object>());
			UUIText textComponent = this.DialogTextWriterComponent.GetTextComponent();
			if (textComponent == null)
			{
				return;
			}
			float textWriterAnimSpeed = PlotComponentUtils.GetTextWriterAnimSpeed(false);
			float textScrollDelayCharNum = PlotComponentUtils.GetTextScrollDelayCharNum();
			float textWriterAnimDuration = PlotComponentUtils.GetTextWriterAnimDuration(currentContent, textComponent, textWriterAnimSpeed);
			this.DialogTextWriterComponent.SetPlayDuration(textWriterAnimDuration);
			this.DialogTextWriterComponent.Play();
			this.TextScrollComponent.SetDelayCharNum(textScrollDelayCharNum);
			this.TextScrollComponent.SetCharReadSpeed(textWriterAnimSpeed);
			this.TextScrollComponent.PlayNextFrame();
			float talkWaitTime = PlotComponentUtils.GetTalkWaitTime(currentContent);
			this.WaitingProxyComponent.Wait(talkWaitTime);
			HashSet<int> speakerList = this.HandleAvgCharacterActions(currentContent, whoId, avgTalkerConfig);
			this.UpdateTalkerSpeakState(speakerList);
			this.PlotTextAkComponent.PlayTalkItemStartEvent(currentContent);
		}

		// Token: 0x06034A62 RID: 215650 RVA: 0x00EB9C34 File Offset: 0x00EB7E34
		private void HandleAvgCenterText(ITalkItem talkItem)
		{
			UUIText textComponent = this.CenterTextWriterComponent.GetTextComponent();
			if (textComponent == null)
			{
				return;
			}
			string tidTalk = talkItem.TidTalk;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(26), tidTalk, Array.Empty<object>());
			float textWriterAnimSpeed = PlotComponentUtils.GetTextWriterAnimSpeed(false);
			float textWriterAnimDuration = PlotComponentUtils.GetTextWriterAnimDuration(talkItem, textComponent, textWriterAnimSpeed);
			this.CenterTextWriterComponent.SetPlayDuration(textWriterAnimDuration);
			this.CenterTextWriterComponent.Play();
		}

		// Token: 0x06034A63 RID: 215651 RVA: 0x00EB9C98 File Offset: 0x00EB7E98
		private HashSet<int> HandleAvgCharacterActions(ITalkItem talkItem, int? whoId, AvgTalkerConfig? avgTalkerConfig)
		{
			HashSet<int> hashSet = new HashSet<int>();
			ETalkItemType? type = talkItem.Type;
			if (type != null)
			{
				switch (type.GetValueOrDefault())
				{
				case ETalkItemType.AvgTalk:
					this.HandleAvgTalk((ITalkItemAvgTalk)talkItem, whoId, avgTalkerConfig, hashSet);
					break;
				case ETalkItemType.AvgEnter:
					this.HandleAvgEnter((ITalkItemAvgEnter)talkItem, hashSet);
					break;
				case ETalkItemType.AvgExit:
					this.HandleAvgExit((ITalkItemAvgExit)talkItem);
					break;
				}
			}
			return hashSet;
		}

		// Token: 0x06034A64 RID: 215652 RVA: 0x00EB9D08 File Offset: 0x00EB7F08
		private void HandleAvgTalk(ITalkItemAvgTalk avgTalkItem, int? whoId, AvgTalkerConfig? avgTalkerConfig, HashSet<int> speakerSet)
		{
			EAvgRolePosition positionConfig = avgTalkItem.PositionConfig;
			if (whoId == null || whoId.Value == 0 || avgTalkerConfig == null)
			{
				return;
			}
			if (avgTalkerConfig.Value.IsGroup)
			{
				this.HandleGroupDialog(avgTalkItem, speakerSet);
				return;
			}
			ITalkItemAvgRoleConfig avgRoleConfig = avgTalkItem.AvgRoleConfig;
			EAvgRoleAnimationType animationType = avgRoleConfig.AnimationType;
			bool valueOrDefault = avgRoleConfig.IsAnimationLoop.GetValueOrDefault(true);
			this.HandleSingleDialog(whoId.Value, positionConfig, animationType, valueOrDefault, speakerSet);
		}

		// Token: 0x06034A65 RID: 215653 RVA: 0x00EB9D84 File Offset: 0x00EB7F84
		private void HandleGroupDialog(ITalkItemAvgTalk avgTalkItem, HashSet<int> speakerSet)
		{
			List<ActionInfo> actions = avgTalkItem.Actions;
			if (actions == null || actions.Count == 0)
			{
				return;
			}
			foreach (ActionInfo actionInfo in actions)
			{
				if (actionInfo.Name == EAction.AvgPlayRoleAction)
				{
					foreach (IAvgPlayRoleActionItem avgPlayRoleActionItem in ((AvgPlayRoleAction)actionInfo.Params).RoleActionList)
					{
						if (avgPlayRoleActionItem.ActionType == EAvgPlayRoleActionType.GroupDialog)
						{
							AvgTalkerEnterActionContext context = new AvgTalkerEnterActionContext
							{
								CharacterId = avgPlayRoleActionItem.RoleId,
								Position = avgPlayRoleActionItem.PositionConfig.Value,
								AnimationType = avgPlayRoleActionItem.AnimationType,
								IsLoop = avgPlayRoleActionItem.IsAnimationLoop.GetValueOrDefault(true)
							};
							PlotModel.Instance.PlotAvg.AvgCharacterEnterOrChangeAnim(context).Forget();
							speakerSet.Add(avgPlayRoleActionItem.RoleId);
						}
					}
				}
			}
		}

		// Token: 0x06034A66 RID: 215654 RVA: 0x00EB9EBC File Offset: 0x00EB80BC
		private void HandleSingleDialog(int whoId, EAvgRolePosition positionConfig, EAvgRoleAnimationType animationType, bool isLoop, HashSet<int> speakerSet)
		{
			speakerSet.Add(whoId);
			AvgTalkerEnterActionContext context = new AvgTalkerEnterActionContext
			{
				CharacterId = whoId,
				Position = positionConfig,
				AnimationType = animationType,
				IsLoop = isLoop
			};
			PlotModel.Instance.PlotAvg.AvgCharacterEnterOrChangeAnim(context).Forget();
		}

		// Token: 0x06034A67 RID: 215655 RVA: 0x00EB9F0C File Offset: 0x00EB810C
		private void HandleAvgEnter(ITalkItemAvgEnter avgTalkItem, HashSet<int> speakerSet)
		{
			int? whoId = avgTalkItem.WhoId;
			if (whoId == null || whoId.Value == 0)
			{
				return;
			}
			speakerSet.Add(whoId.Value);
			ITalkItemAvgRoleConfig avgRoleConfig = avgTalkItem.AvgRoleConfig;
			EAvgRoleAnimationType animationType = avgRoleConfig.AnimationType;
			bool valueOrDefault = avgRoleConfig.IsAnimationLoop.GetValueOrDefault();
			AvgTalkerEnterActionContext context = new AvgTalkerEnterActionContext
			{
				CharacterId = whoId.Value,
				Position = avgTalkItem.PositionConfig,
				AnimationType = animationType,
				IsLoop = valueOrDefault
			};
			PlotModel.Instance.PlotAvg.AvgCharacterEnterAsync(context).Forget<bool>();
		}

		// Token: 0x06034A68 RID: 215656 RVA: 0x00EB9FA0 File Offset: 0x00EB81A0
		private void HandleAvgExit(ITalkItemAvgExit avgTalkItem)
		{
			int? whoId = avgTalkItem.WhoId;
			if (whoId == null || whoId.Value == 0)
			{
				return;
			}
			PlotModel.Instance.PlotAvg.AvgCharacterExitAsync(whoId.Value).Forget<bool>();
		}

		// Token: 0x06034A69 RID: 215657 RVA: 0x00EB9FE4 File Offset: 0x00EB81E4
		private void ClearTalk()
		{
			if (this.CurrentContent != null)
			{
				this.PlotTextAkComponent.PlayTalkItemEndEvent(this.CurrentContent);
			}
			this.CurrentContent = null;
			this.TextScrollComponent.Stop();
			this.OptionComponent.HideOptions();
			this.DialogTextWriterComponent.Stop();
			this.CenterTextWriterComponent.Stop();
			this.WaitingProxyComponent.Cancel();
		}

		// Token: 0x06034A6A RID: 215658 RVA: 0x00EBA048 File Offset: 0x00EB8248
		private void TryContinue()
		{
			if (this.CurrentContent == null)
			{
				return;
			}
			if (this.WaitingProxyComponent.GetIsWaiting())
			{
				return;
			}
			if (this.CenterTextWriterComponent.GetIsPlaying())
			{
				this.CenterTextWriterComponent.JumpToEnd();
				return;
			}
			if (this.DialogTextWriterComponent.GetIsPlaying() || this.TextScrollComponent.GetIsPlaying())
			{
				this.JumpToEnd();
				return;
			}
			this.ContinueInternal();
		}

		// Token: 0x06034A6B RID: 215659 RVA: 0x00EBA0AC File Offset: 0x00EB82AC
		private void ContinueInternal()
		{
			FlowController.Instance.FlowShowTalk.SubmitSubtitle(this.CurrentContent);
		}

		// Token: 0x06034A6C RID: 215660 RVA: 0x00EBA0C3 File Offset: 0x00EB82C3
		private void JumpToEnd()
		{
			this.DialogTextWriterComponent.JumpToEnd();
			this.TextScrollComponent.JumpToEnd();
		}

		// Token: 0x06034A6D RID: 215661 RVA: 0x00EBA0DC File Offset: 0x00EB82DC
		public void ShowOptions()
		{
			if (this.CurrentContent == null || this.CurrentContent.Options == null || this.CurrentContent.Options.Count == 0)
			{
				return;
			}
			this.OptionComponent.ShowOptions();
			PlotOptionComponent optionComponent = this.OptionComponent;
			List<ITalkOption> options = this.CurrentContent.Options;
			optionComponent.RefreshOptions((options != null) ? options.ToArray() : null);
		}

		// Token: 0x06034A6E RID: 215662 RVA: 0x00EBA13E File Offset: 0x00EB833E
		private void ClearPlotSubtitle()
		{
			this.CurrentContent = null;
			this.ClearPlotView();
		}

		// Token: 0x06034A6F RID: 215663 RVA: 0x00EBA14D File Offset: 0x00EB834D
		private void ClearPlotView()
		{
			this.TextScrollComponent.Clear();
		}

		// Token: 0x06034A70 RID: 215664 RVA: 0x00EBA15A File Offset: 0x00EB835A
		private void HideAll(bool isHidden)
		{
		}

		// Token: 0x06034A71 RID: 215665 RVA: 0x00EBA15C File Offset: 0x00EB835C
		private void BuildOptionItemDataList(ITalkOption[] options)
		{
			this.OptionItemDataList.Clear();
			for (int i = 0; i < options.Length; i++)
			{
				ITalkOption talkOption = options[i];
				if (talkOption != null)
				{
					PinballPlotOptionItemData item = new PinballPlotOptionItemData
					{
						OptionIndex = i,
						OptionText = new TableTextArgNew(talkOption.TidTalkOption, Array.Empty<object>()),
						OptionDelegate = new Action<int>(this.OnOptionClick)
					};
					this.OptionItemDataList.Add(item);
				}
			}
		}

		// Token: 0x06034A72 RID: 215666 RVA: 0x00EBA1CA File Offset: 0x00EB83CA
		private void SetOptionRootItemActive(bool active)
		{
			base.GetItem(22).SetUIActive(active);
		}

		// Token: 0x06034A73 RID: 215667 RVA: 0x00EBA1DA File Offset: 0x00EB83DA
		private void OnRefreshOptions(ITalkOption[] options)
		{
			this.BuildOptionItemDataList(options);
			this.OptionLayout.RefreshByData(this.OptionItemDataList, null, false);
		}

		// Token: 0x06034A74 RID: 215668 RVA: 0x00EBA1F6 File Offset: 0x00EB83F6
		private void OnOptionsShow()
		{
			this.SetOptionRootItemActive(true);
		}

		// Token: 0x06034A75 RID: 215669 RVA: 0x00EBA1FF File Offset: 0x00EB83FF
		private void OnOptionsHide()
		{
			this.SetOptionRootItemActive(false);
		}

		// Token: 0x06034A76 RID: 215670 RVA: 0x00EBA208 File Offset: 0x00EB8408
		private void OnOptionClick(int optionIndex)
		{
			this.OptionComponent.SelectOption(optionIndex);
		}

		// Token: 0x06034A77 RID: 215671 RVA: 0x00EBA216 File Offset: 0x00EB8416
		private void OnSelectionItemClick(int optionIndex)
		{
			this.OptionComponent.SelectOption(optionIndex);
		}

		// Token: 0x06034A78 RID: 215672 RVA: 0x00EBA224 File Offset: 0x00EB8424
		protected void SetContinueArrowActive(bool active)
		{
			PlotModel.Instance.CanClick = active;
			base.GetSprite(11).SetUIActive(active);
			if (active)
			{
				this.UiViewSequence.PlayOrReplaySequenceByName("Page", false, null);
				return;
			}
			this.UiViewSequence.StopSequenceByKey("Page", false, false);
		}

		// Token: 0x06034A79 RID: 215673 RVA: 0x00EBA27C File Offset: 0x00EB847C
		private void ShowWaiting()
		{
			base.GetItem(23).SetUIActive(true);
			this.WaitingItemSeqPlayer.PlayOrReplaySequenceByName("Progressing", false, null);
			this.SetContinueArrowActive(false);
		}

		// Token: 0x06034A7A RID: 215674 RVA: 0x00EBA2B8 File Offset: 0x00EB84B8
		private void HideWaiting()
		{
			base.GetItem(23).SetUIActive(false);
			this.WaitingItemSeqPlayer.StopSequenceByKey("Progressing", false, false);
			this.SetContinueArrowActive(true);
		}

		// Token: 0x06034A7B RID: 215675 RVA: 0x00EBA2E1 File Offset: 0x00EB84E1
		private void OnWaitingStart()
		{
			this.ShowWaiting();
		}

		// Token: 0x06034A7C RID: 215676 RVA: 0x00EBA2E9 File Offset: 0x00EB84E9
		private void OnWaitingComplete()
		{
			this.HideWaiting();
			this.AutoPlayComponent.TryDelayPlayNextTalk();
		}

		// Token: 0x06034A7D RID: 215677 RVA: 0x00EBA2FD File Offset: 0x00EB84FD
		private void OnWaitingCancel()
		{
			this.HideWaiting();
		}

		// Token: 0x06034A7E RID: 215678 RVA: 0x00EBA305 File Offset: 0x00EB8505
		private PinballPlotOptionItem CreateOptionItem()
		{
			return new PinballPlotOptionItem();
		}

		// Token: 0x06034A7F RID: 215679 RVA: 0x00EBA30C File Offset: 0x00EB850C
		private void OnSkip()
		{
			FlowController.Instance.BackgroundFlow("UI点击跳过(PlotSubtitleView)", true, false, false);
		}

		// Token: 0x06034A80 RID: 215680 RVA: 0x00EBA320 File Offset: 0x00EB8520
		private void OnSkipPop()
		{
			this.AutoPlayComponent.MuteAutoPlay(true);
		}

		// Token: 0x06034A81 RID: 215681 RVA: 0x00EBA32E File Offset: 0x00EB852E
		private void OnSkipCancel()
		{
			this.AutoPlayComponent.MuteAutoPlay(false);
		}

		// Token: 0x06034A82 RID: 215682 RVA: 0x00EBA33C File Offset: 0x00EB853C
		private void OnNextButtonClick()
		{
			this.TryContinue();
		}

		// Token: 0x06034A83 RID: 215683 RVA: 0x00EBA344 File Offset: 0x00EB8544
		private void OnContinueButtonClick()
		{
			this.TryContinue();
		}

		// Token: 0x06034A84 RID: 215684 RVA: 0x00EBA34C File Offset: 0x00EB854C
		private bool CheckTalkFinished()
		{
			return !this.TextScrollComponent.GetIsPlaying() && !this.DialogTextWriterComponent.GetIsPlaying() && !this.CenterTextWriterComponent.GetIsPlaying() && !this.WaitingProxyComponent.GetIsWaiting();
		}

		// Token: 0x06034A85 RID: 215685 RVA: 0x00EBA385 File Offset: 0x00EB8585
		private void ContinueToNextTalk()
		{
			this.ContinueInternal();
		}

		// Token: 0x06034A86 RID: 215686 RVA: 0x00EBA38D File Offset: 0x00EB858D
		private void OnTextWriterEnd()
		{
			this.AutoPlayComponent.TryDelayPlayNextTalk();
		}

		// Token: 0x06034A87 RID: 215687 RVA: 0x00EBA39C File Offset: 0x00EB859C
		public UniTask PlayCharacterEnterPerformAsync(AvgTalkerEnterActionContext context)
		{
			PinballPlotView.<PlayCharacterEnterPerformAsync>d__82 <PlayCharacterEnterPerformAsync>d__;
			<PlayCharacterEnterPerformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCharacterEnterPerformAsync>d__.<>4__this = this;
			<PlayCharacterEnterPerformAsync>d__.context = context;
			<PlayCharacterEnterPerformAsync>d__.<>1__state = -1;
			<PlayCharacterEnterPerformAsync>d__.<>t__builder.Start<PinballPlotView.<PlayCharacterEnterPerformAsync>d__82>(ref <PlayCharacterEnterPerformAsync>d__);
			return <PlayCharacterEnterPerformAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A88 RID: 215688 RVA: 0x00EBA3E8 File Offset: 0x00EB85E8
		public UniTask PlayCharacterExitPerformAsync(int characterId)
		{
			PinballPlotView.<PlayCharacterExitPerformAsync>d__83 <PlayCharacterExitPerformAsync>d__;
			<PlayCharacterExitPerformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCharacterExitPerformAsync>d__.<>4__this = this;
			<PlayCharacterExitPerformAsync>d__.characterId = characterId;
			<PlayCharacterExitPerformAsync>d__.<>1__state = -1;
			<PlayCharacterExitPerformAsync>d__.<>t__builder.Start<PinballPlotView.<PlayCharacterExitPerformAsync>d__83>(ref <PlayCharacterExitPerformAsync>d__);
			return <PlayCharacterExitPerformAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A89 RID: 215689 RVA: 0x00EBA434 File Offset: 0x00EB8634
		public UniTask PlayCharacterMovePerformAsync(AvgTalkerMoveActionContext context)
		{
			PinballPlotView.<PlayCharacterMovePerformAsync>d__84 <PlayCharacterMovePerformAsync>d__;
			<PlayCharacterMovePerformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCharacterMovePerformAsync>d__.<>4__this = this;
			<PlayCharacterMovePerformAsync>d__.context = context;
			<PlayCharacterMovePerformAsync>d__.<>1__state = -1;
			<PlayCharacterMovePerformAsync>d__.<>t__builder.Start<PinballPlotView.<PlayCharacterMovePerformAsync>d__84>(ref <PlayCharacterMovePerformAsync>d__);
			return <PlayCharacterMovePerformAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A8A RID: 215690 RVA: 0x00EBA480 File Offset: 0x00EB8680
		public void ChangeCharacterAnim(int characterId, EAvgRoleAnimationType animationType, bool isLoop)
		{
			PinballAvgCharacter pinballAvgCharacter;
			if (!this.AvgCharacterMap.TryGetValue(characterId, out pinballAvgCharacter))
			{
				return;
			}
			PlotAvgCharacter character = PlotModel.Instance.PlotAvg.GetCharacter(characterId);
			if (character == null)
			{
				return;
			}
			pinballAvgCharacter.PlayAnimation(character.Direction, animationType, isLoop);
		}

		// Token: 0x06034A8B RID: 215691 RVA: 0x00EBA4C4 File Offset: 0x00EB86C4
		private void UpdateTalkerSpeakState(HashSet<int> speakerList)
		{
			foreach (KeyValuePair<int, PinballAvgCharacter> keyValuePair in this.AvgCharacterMap)
			{
				keyValuePair.Value.UpdateSpeakStatus(speakerList.Contains(keyValuePair.Key));
			}
		}

		// Token: 0x0401BE2E RID: 114222
		[Nullable(2)]
		protected ITalkItem CurrentContent;

		// Token: 0x0401BE2F RID: 114223
		protected List<IPinballPlotOptionItemData> OptionItemDataList;

		// Token: 0x0401BE30 RID: 114224
		protected List<IPinballPlotSelectionItemData> SelectionItemDataList;

		// Token: 0x0401BE31 RID: 114225
		protected Dictionary<int, PinballAvgCharacter> AvgCharacterMap;

		// Token: 0x0401BE32 RID: 114226
		protected Dictionary<EAvgRolePosition, UUIItem> PosItemMap;

		// Token: 0x0401BE33 RID: 114227
		protected List<PinballPlotSelectionItem> SelectionItemList;

		// Token: 0x0401BE34 RID: 114228
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<PinballPlotOptionItem, IPinballPlotOptionItemData> OptionLayout;

		// Token: 0x0401BE35 RID: 114229
		protected PlotTextScrollComponent TextScrollComponent;

		// Token: 0x0401BE36 RID: 114230
		protected PlotOptionComponent OptionComponent;

		// Token: 0x0401BE37 RID: 114231
		protected PlotTextWriterComponent DialogTextWriterComponent;

		// Token: 0x0401BE38 RID: 114232
		protected PlotTextWriterComponent CenterTextWriterComponent;

		// Token: 0x0401BE39 RID: 114233
		protected PlotWaitingProxyComponent WaitingProxyComponent;

		// Token: 0x0401BE3A RID: 114234
		protected PlotAutoPlayComponent AutoPlayComponent;

		// Token: 0x0401BE3B RID: 114235
		protected PlotTextAudioComponent PlotTextAkComponent;

		// Token: 0x0401BE3C RID: 114236
		[Nullable(2)]
		protected PlotSkipComponent SkipComp;

		// Token: 0x0401BE3D RID: 114237
		[Nullable(2)]
		protected LevelSequencePlayer WaitingItemSeqPlayer;

		// Token: 0x0200AF07 RID: 44807
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036134 RID: 221492
			CaptionItem,
			// Token: 0x04036135 RID: 221493
			AutoPlayToggle,
			// Token: 0x04036136 RID: 221494
			SkipButton,
			// Token: 0x04036137 RID: 221495
			SelectionItemA,
			// Token: 0x04036138 RID: 221496
			SelectionItemB,
			// Token: 0x04036139 RID: 221497
			SelectionItemC,
			// Token: 0x0403613A RID: 221498
			NextButton,
			// Token: 0x0403613B RID: 221499
			ContentRootItem,
			// Token: 0x0403613C RID: 221500
			SpeakerNameText,
			// Token: 0x0403613D RID: 221501
			DialogScrollView,
			// Token: 0x0403613E RID: 221502
			DialogText,
			// Token: 0x0403613F RID: 221503
			ContinueArrowSprite,
			// Token: 0x04036140 RID: 221504
			ContinueButton,
			// Token: 0x04036141 RID: 221505
			SpineRootItem,
			// Token: 0x04036142 RID: 221506
			LeftPosItemA,
			// Token: 0x04036143 RID: 221507
			LeftPosItemB,
			// Token: 0x04036144 RID: 221508
			CenterPosItem,
			// Token: 0x04036145 RID: 221509
			RightPosItemB,
			// Token: 0x04036146 RID: 221510
			RightPosItemA,
			// Token: 0x04036147 RID: 221511
			SpineTemplateItem,
			// Token: 0x04036148 RID: 221512
			OptionLayout,
			// Token: 0x04036149 RID: 221513
			OptionItem,
			// Token: 0x0403614A RID: 221514
			OptionRootItem,
			// Token: 0x0403614B RID: 221515
			WaitingItem,
			// Token: 0x0403614C RID: 221516
			SpeakerNameRootItem,
			// Token: 0x0403614D RID: 221517
			BlackScreenRootItem,
			// Token: 0x0403614E RID: 221518
			CenterText,
			// Token: 0x0403614F RID: 221519
			BgTexture,
			// Token: 0x04036150 RID: 221520
			DecorationTexture
		}
	}
}
