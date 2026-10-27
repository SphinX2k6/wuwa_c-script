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
	// Token: 0x02006326 RID: 25382
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballPlotView : UiTickViewBase, IPlotAvgPerformHandler
	{
		// Token: 0x0603FD87 RID: 261511 RVA: 0x00F71F07 File Offset: 0x00F70107
		public PinballPlotView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x170092F0 RID: 37616
		// (get) Token: 0x0603FD88 RID: 261512 RVA: 0x00F71F10 File Offset: 0x00F70110
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

		// Token: 0x170092F1 RID: 37617
		// (get) Token: 0x0603FD89 RID: 261513 RVA: 0x00F71F34 File Offset: 0x00F70134
		protected bool HasOptions
		{
			get
			{
				ITalkOption[] currentOptions = this.CurrentOptions;
				return currentOptions != null && currentOptions.Length != 0;
			}
		}

		// Token: 0x0603FD8A RID: 261514 RVA: 0x00F71F54 File Offset: 0x00F70154
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

		// Token: 0x0603FD8B RID: 261515 RVA: 0x00F723B0 File Offset: 0x00F705B0
		protected override UniTask OnBeforeStartAsync()
		{
			PinballPlotView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballPlotView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FD8C RID: 261516 RVA: 0x00F723F4 File Offset: 0x00F705F4
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

		// Token: 0x0603FD8D RID: 261517 RVA: 0x00F724C9 File Offset: 0x00F706C9
		private void OnEventSequence(string sequenceName, string eventName)
		{
			if (eventName == "Switch_In")
			{
				EventSystem.Instance.Emit(EEventName.OnPinballBattleViewSwitchIn);
			}
		}

		// Token: 0x0603FD8E RID: 261518 RVA: 0x00F724E8 File Offset: 0x00F706E8
		private void OnSceneOutSeqEnd()
		{
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x0603FD8F RID: 261519 RVA: 0x00F724F8 File Offset: 0x00F706F8
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

		// Token: 0x0603FD90 RID: 261520 RVA: 0x00F725B8 File Offset: 0x00F707B8
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

		// Token: 0x0603FD91 RID: 261521 RVA: 0x00F72678 File Offset: 0x00F70878
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, true);
		}

		// Token: 0x0603FD92 RID: 261522 RVA: 0x00F72696 File Offset: 0x00F70896
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, false);
		}

		// Token: 0x0603FD93 RID: 261523 RVA: 0x00F726B4 File Offset: 0x00F708B4
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

		// Token: 0x0603FD94 RID: 261524 RVA: 0x00F7274C File Offset: 0x00F7094C
		private void InitSkipComponent()
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(false);
			this.SkipComp = new PlotSkipComponent(base.GetButton(2), new Action(this.OnSkip), new Action(this.OnSkipPop), null, new Action(this.OnSkipCancel), new EUiBehaviourPopType?(EUiBehaviourPopType.PinballSmall), "UiItem_ComConfirmPopup");
			this.SkipComp.EnableSkipButton(false);
		}

		// Token: 0x0603FD95 RID: 261525 RVA: 0x00F727C4 File Offset: 0x00F709C4
		private void InitTextScrollComponent()
		{
			PlotTextScrollComponentContext context = new PlotTextScrollComponentContext
			{
				TextComponent = base.GetText(10),
				TextScrollView = base.GetScrollView(9)
			};
			this.TextScrollComponent.Init(context);
		}

		// Token: 0x0603FD96 RID: 261526 RVA: 0x00F72800 File Offset: 0x00F70A00
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

		// Token: 0x0603FD97 RID: 261527 RVA: 0x00F72894 File Offset: 0x00F70A94
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

		// Token: 0x0603FD98 RID: 261528 RVA: 0x00F72928 File Offset: 0x00F70B28
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

		// Token: 0x0603FD99 RID: 261529 RVA: 0x00F72980 File Offset: 0x00F70B80
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

		// Token: 0x0603FD9A RID: 261530 RVA: 0x00F729D5 File Offset: 0x00F70BD5
		private void InitWaitingItemSeqPlayer()
		{
			this.WaitingItemSeqPlayer = new LevelSequencePlayer(base.GetItem(23));
		}

		// Token: 0x0603FD9B RID: 261531 RVA: 0x00F729EC File Offset: 0x00F70BEC
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

		// Token: 0x0603FD9C RID: 261532 RVA: 0x00F72A60 File Offset: 0x00F70C60
		protected override void OnTick(float delta)
		{
			this.WaitingProxyComponent.OnTick(delta);
		}

		// Token: 0x0603FD9D RID: 261533 RVA: 0x00F72A70 File Offset: 0x00F70C70
		private void UpdateByPlotConfig()
		{
			this.SkipComp.EnableSkipButton(false);
			bool canPause = PlotModel.Instance.PlotConfig.CanPause;
			this.AutoPlayComponent.SetToggleActive(canPause);
			this.AutoPlayComponent.UpdateAutoPlayToggle();
		}

		// Token: 0x0603FD9E RID: 261534 RVA: 0x00F72AB0 File Offset: 0x00F70CB0
		private void OnShowTalkStart(ShowTalk inShowTalk)
		{
			PlotSkipComponent skipComp = this.SkipComp;
			if (skipComp == null)
			{
				return;
			}
			skipComp.AddSummary(inShowTalk.TalkOutline);
		}

		// Token: 0x0603FD9F RID: 261535 RVA: 0x00F72AC8 File Offset: 0x00F70CC8
		private void PlayTalk(ITalkItem talkItem)
		{
			this.ClearTalk();
			this.CurrentContent = talkItem;
			this.HandleTextLogic();
		}

		// Token: 0x0603FDA0 RID: 261536 RVA: 0x00F72AE0 File Offset: 0x00F70CE0
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

		// Token: 0x0603FDA1 RID: 261537 RVA: 0x00F72CD8 File Offset: 0x00F70ED8
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

		// Token: 0x0603FDA2 RID: 261538 RVA: 0x00F72D3C File Offset: 0x00F70F3C
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

		// Token: 0x0603FDA3 RID: 261539 RVA: 0x00F72DAC File Offset: 0x00F70FAC
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

		// Token: 0x0603FDA4 RID: 261540 RVA: 0x00F72E28 File Offset: 0x00F71028
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

		// Token: 0x0603FDA5 RID: 261541 RVA: 0x00F72F60 File Offset: 0x00F71160
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

		// Token: 0x0603FDA6 RID: 261542 RVA: 0x00F72FB0 File Offset: 0x00F711B0
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

		// Token: 0x0603FDA7 RID: 261543 RVA: 0x00F73044 File Offset: 0x00F71244
		private void HandleAvgExit(ITalkItemAvgExit avgTalkItem)
		{
			int? whoId = avgTalkItem.WhoId;
			if (whoId == null || whoId.Value == 0)
			{
				return;
			}
			PlotModel.Instance.PlotAvg.AvgCharacterExitAsync(whoId.Value).Forget<bool>();
		}

		// Token: 0x0603FDA8 RID: 261544 RVA: 0x00F73088 File Offset: 0x00F71288
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

		// Token: 0x0603FDA9 RID: 261545 RVA: 0x00F730EC File Offset: 0x00F712EC
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

		// Token: 0x0603FDAA RID: 261546 RVA: 0x00F73150 File Offset: 0x00F71350
		private void ContinueInternal()
		{
			FlowController.Instance.FlowShowTalk.SubmitSubtitle(this.CurrentContent);
		}

		// Token: 0x0603FDAB RID: 261547 RVA: 0x00F73167 File Offset: 0x00F71367
		private void JumpToEnd()
		{
			this.DialogTextWriterComponent.JumpToEnd();
			this.TextScrollComponent.JumpToEnd();
		}

		// Token: 0x0603FDAC RID: 261548 RVA: 0x00F73180 File Offset: 0x00F71380
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

		// Token: 0x0603FDAD RID: 261549 RVA: 0x00F731E2 File Offset: 0x00F713E2
		private void ClearPlotSubtitle()
		{
			this.CurrentContent = null;
			this.ClearPlotView();
		}

		// Token: 0x0603FDAE RID: 261550 RVA: 0x00F731F1 File Offset: 0x00F713F1
		private void ClearPlotView()
		{
			this.TextScrollComponent.Clear();
		}

		// Token: 0x0603FDAF RID: 261551 RVA: 0x00F731FE File Offset: 0x00F713FE
		private void HideAll(bool isHidden)
		{
		}

		// Token: 0x0603FDB0 RID: 261552 RVA: 0x00F73200 File Offset: 0x00F71400
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

		// Token: 0x0603FDB1 RID: 261553 RVA: 0x00F7326E File Offset: 0x00F7146E
		private void SetOptionRootItemActive(bool active)
		{
			base.GetItem(22).SetUIActive(active);
		}

		// Token: 0x0603FDB2 RID: 261554 RVA: 0x00F7327E File Offset: 0x00F7147E
		private void OnRefreshOptions(ITalkOption[] options)
		{
			this.BuildOptionItemDataList(options);
			this.OptionLayout.RefreshByData(this.OptionItemDataList, null, false);
		}

		// Token: 0x0603FDB3 RID: 261555 RVA: 0x00F7329A File Offset: 0x00F7149A
		private void OnOptionsShow()
		{
			this.SetOptionRootItemActive(true);
		}

		// Token: 0x0603FDB4 RID: 261556 RVA: 0x00F732A3 File Offset: 0x00F714A3
		private void OnOptionsHide()
		{
			this.SetOptionRootItemActive(false);
		}

		// Token: 0x0603FDB5 RID: 261557 RVA: 0x00F732AC File Offset: 0x00F714AC
		private void OnOptionClick(int optionIndex)
		{
			this.OptionComponent.SelectOption(optionIndex);
		}

		// Token: 0x0603FDB6 RID: 261558 RVA: 0x00F732BA File Offset: 0x00F714BA
		private void OnSelectionItemClick(int optionIndex)
		{
			this.OptionComponent.SelectOption(optionIndex);
		}

		// Token: 0x0603FDB7 RID: 261559 RVA: 0x00F732C8 File Offset: 0x00F714C8
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

		// Token: 0x0603FDB8 RID: 261560 RVA: 0x00F73320 File Offset: 0x00F71520
		private void ShowWaiting()
		{
			base.GetItem(23).SetUIActive(true);
			this.WaitingItemSeqPlayer.PlayOrReplaySequenceByName("Progressing", false, null);
			this.SetContinueArrowActive(false);
		}

		// Token: 0x0603FDB9 RID: 261561 RVA: 0x00F7335C File Offset: 0x00F7155C
		private void HideWaiting()
		{
			base.GetItem(23).SetUIActive(false);
			this.WaitingItemSeqPlayer.StopSequenceByKey("Progressing", false, false);
			this.SetContinueArrowActive(true);
		}

		// Token: 0x0603FDBA RID: 261562 RVA: 0x00F73385 File Offset: 0x00F71585
		private void OnWaitingStart()
		{
			this.ShowWaiting();
		}

		// Token: 0x0603FDBB RID: 261563 RVA: 0x00F7338D File Offset: 0x00F7158D
		private void OnWaitingComplete()
		{
			this.HideWaiting();
			this.AutoPlayComponent.TryDelayPlayNextTalk();
		}

		// Token: 0x0603FDBC RID: 261564 RVA: 0x00F733A1 File Offset: 0x00F715A1
		private void OnWaitingCancel()
		{
			this.HideWaiting();
		}

		// Token: 0x0603FDBD RID: 261565 RVA: 0x00F733A9 File Offset: 0x00F715A9
		private PinballPlotOptionItem CreateOptionItem()
		{
			return new PinballPlotOptionItem();
		}

		// Token: 0x0603FDBE RID: 261566 RVA: 0x00F733B0 File Offset: 0x00F715B0
		private void OnSkip()
		{
			FlowController.Instance.BackgroundFlow("UI点击跳过(PlotSubtitleView)", true, false, false);
		}

		// Token: 0x0603FDBF RID: 261567 RVA: 0x00F733C4 File Offset: 0x00F715C4
		private void OnSkipPop()
		{
			this.AutoPlayComponent.MuteAutoPlay(true);
		}

		// Token: 0x0603FDC0 RID: 261568 RVA: 0x00F733D2 File Offset: 0x00F715D2
		private void OnSkipCancel()
		{
			this.AutoPlayComponent.MuteAutoPlay(false);
		}

		// Token: 0x0603FDC1 RID: 261569 RVA: 0x00F733E0 File Offset: 0x00F715E0
		private void OnNextButtonClick()
		{
			this.TryContinue();
		}

		// Token: 0x0603FDC2 RID: 261570 RVA: 0x00F733E8 File Offset: 0x00F715E8
		private void OnContinueButtonClick()
		{
			this.TryContinue();
		}

		// Token: 0x0603FDC3 RID: 261571 RVA: 0x00F733F0 File Offset: 0x00F715F0
		private bool CheckTalkFinished()
		{
			return !this.TextScrollComponent.GetIsPlaying() && !this.DialogTextWriterComponent.GetIsPlaying() && !this.CenterTextWriterComponent.GetIsPlaying() && !this.WaitingProxyComponent.GetIsWaiting();
		}

		// Token: 0x0603FDC4 RID: 261572 RVA: 0x00F73429 File Offset: 0x00F71629
		private void ContinueToNextTalk()
		{
			this.ContinueInternal();
		}

		// Token: 0x0603FDC5 RID: 261573 RVA: 0x00F73431 File Offset: 0x00F71631
		private void OnTextWriterEnd()
		{
			this.AutoPlayComponent.TryDelayPlayNextTalk();
		}

		// Token: 0x0603FDC6 RID: 261574 RVA: 0x00F73440 File Offset: 0x00F71640
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

		// Token: 0x0603FDC7 RID: 261575 RVA: 0x00F7348C File Offset: 0x00F7168C
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

		// Token: 0x0603FDC8 RID: 261576 RVA: 0x00F734D8 File Offset: 0x00F716D8
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

		// Token: 0x0603FDC9 RID: 261577 RVA: 0x00F73524 File Offset: 0x00F71724
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

		// Token: 0x0603FDCA RID: 261578 RVA: 0x00F73568 File Offset: 0x00F71768
		private void UpdateTalkerSpeakState(HashSet<int> speakerList)
		{
			foreach (KeyValuePair<int, PinballAvgCharacter> keyValuePair in this.AvgCharacterMap)
			{
				keyValuePair.Value.UpdateSpeakStatus(speakerList.Contains(keyValuePair.Key));
			}
		}

		// Token: 0x040214FF RID: 136447
		[Nullable(2)]
		protected ITalkItem CurrentContent;

		// Token: 0x04021500 RID: 136448
		protected List<IPinballPlotOptionItemData> OptionItemDataList;

		// Token: 0x04021501 RID: 136449
		protected List<IPinballPlotSelectionItemData> SelectionItemDataList;

		// Token: 0x04021502 RID: 136450
		protected Dictionary<int, PinballAvgCharacter> AvgCharacterMap;

		// Token: 0x04021503 RID: 136451
		protected Dictionary<EAvgRolePosition, UUIItem> PosItemMap;

		// Token: 0x04021504 RID: 136452
		protected List<PinballPlotSelectionItem> SelectionItemList;

		// Token: 0x04021505 RID: 136453
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<PinballPlotOptionItem, IPinballPlotOptionItemData> OptionLayout;

		// Token: 0x04021506 RID: 136454
		protected PlotTextScrollComponent TextScrollComponent;

		// Token: 0x04021507 RID: 136455
		protected PlotOptionComponent OptionComponent;

		// Token: 0x04021508 RID: 136456
		protected PlotTextWriterComponent DialogTextWriterComponent;

		// Token: 0x04021509 RID: 136457
		protected PlotTextWriterComponent CenterTextWriterComponent;

		// Token: 0x0402150A RID: 136458
		protected PlotWaitingProxyComponent WaitingProxyComponent;

		// Token: 0x0402150B RID: 136459
		protected PlotAutoPlayComponent AutoPlayComponent;

		// Token: 0x0402150C RID: 136460
		protected PlotTextAudioComponent PlotTextAkComponent;

		// Token: 0x0402150D RID: 136461
		[Nullable(2)]
		protected PlotSkipComponent SkipComp;

		// Token: 0x0402150E RID: 136462
		[Nullable(2)]
		protected LevelSequencePlayer WaitingItemSeqPlayer;

		// Token: 0x0200C520 RID: 50464
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B7D2 RID: 243666
			CaptionItem,
			// Token: 0x0403B7D3 RID: 243667
			AutoPlayToggle,
			// Token: 0x0403B7D4 RID: 243668
			SkipButton,
			// Token: 0x0403B7D5 RID: 243669
			SelectionItemA,
			// Token: 0x0403B7D6 RID: 243670
			SelectionItemB,
			// Token: 0x0403B7D7 RID: 243671
			SelectionItemC,
			// Token: 0x0403B7D8 RID: 243672
			NextButton,
			// Token: 0x0403B7D9 RID: 243673
			ContentRootItem,
			// Token: 0x0403B7DA RID: 243674
			SpeakerNameText,
			// Token: 0x0403B7DB RID: 243675
			DialogScrollView,
			// Token: 0x0403B7DC RID: 243676
			DialogText,
			// Token: 0x0403B7DD RID: 243677
			ContinueArrowSprite,
			// Token: 0x0403B7DE RID: 243678
			ContinueButton,
			// Token: 0x0403B7DF RID: 243679
			SpineRootItem,
			// Token: 0x0403B7E0 RID: 243680
			LeftPosItemA,
			// Token: 0x0403B7E1 RID: 243681
			LeftPosItemB,
			// Token: 0x0403B7E2 RID: 243682
			CenterPosItem,
			// Token: 0x0403B7E3 RID: 243683
			RightPosItemB,
			// Token: 0x0403B7E4 RID: 243684
			RightPosItemA,
			// Token: 0x0403B7E5 RID: 243685
			SpineTemplateItem,
			// Token: 0x0403B7E6 RID: 243686
			OptionLayout,
			// Token: 0x0403B7E7 RID: 243687
			OptionItem,
			// Token: 0x0403B7E8 RID: 243688
			OptionRootItem,
			// Token: 0x0403B7E9 RID: 243689
			WaitingItem,
			// Token: 0x0403B7EA RID: 243690
			SpeakerNameRootItem,
			// Token: 0x0403B7EB RID: 243691
			BlackScreenRootItem,
			// Token: 0x0403B7EC RID: 243692
			CenterText,
			// Token: 0x0403B7ED RID: 243693
			BgTexture,
			// Token: 0x0403B7EE RID: 243694
			DecorationTexture
		}
	}
}
