using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005063 RID: 20579
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTextCommonLogic : IStaticVariableResetter
	{
		// Token: 0x1700802F RID: 32815
		// (get) Token: 0x06034A87 RID: 215687 RVA: 0x00C7193A File Offset: 0x00C6FB3A
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public PlotOptionItem[] Options
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				GenericLayout<PlotOptionItem, object> optionLayout = this.OptionLayout;
				List<PlotOptionItem> list = (optionLayout != null) ? optionLayout.GetLayoutItemList() : null;
				if (list == null)
				{
					return null;
				}
				return list.ToArray();
			}
		}

		// Token: 0x17008030 RID: 32816
		// (get) Token: 0x06034A88 RID: 215688 RVA: 0x00C71959 File Offset: 0x00C6FB59
		public bool HasOptions
		{
			get
			{
				return this.CurrentContent != null && this.CurrentContent.Options != null && this.CurrentContent.Options.Count != 0;
			}
		}

		// Token: 0x17008031 RID: 32817
		// (get) Token: 0x06034A89 RID: 215689 RVA: 0x00C71988 File Offset: 0x00C6FB88
		public PawnInteractController InteractController
		{
			get
			{
				PlotView plotView = this.Parent as PlotView;
				if (plotView != null)
				{
					return plotView.InteractController;
				}
				return null;
			}
		}

		// Token: 0x06034A8A RID: 215690 RVA: 0x00C719AC File Offset: 0x00C6FBAC
		public PlotTextCommonLogic([Nullable(1)] UUIItem plotItem, [Nullable(1)] UUIText npcName, [Nullable(1)] UUIText npcTitle, [Nullable(1)] UUIText plotContent, [Nullable(1)] UUIItem lineItem, UUIScrollViewComponent textScrollView = null, ISimulatePlot parent = null, UUILayoutBase layOutBase = null, UUIItem optionItemBase = null, UUISliderComponent optionLimitBar = null, UiBehaviorLevelSequence uiViewSequence = null, UUIItem blockOption = null, UUIItem optionAdjustItem = null, UUIItem importantList = null, UUITexture importantOptionTipsIcon = null, UUIText importantOptionTipsText = null, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Action<string, UUITexture> setTextureByPathDelegate = null, UUISliderComponent autoSelectTimeBar = null, Action refreshAutoPlayButtonDelegate = null, UUIItem pnlLayoutTwo = null)
		{
			this.PlotItem = plotItem;
			this.NpcName = npcName;
			this.NpcTitle = npcTitle;
			this.PlotContent = plotContent;
			this.LineItem = lineItem;
			this.TextScrollView = textScrollView;
			this.Parent = parent;
			this.LayOutBase = layOutBase;
			this.OptionItemBase = optionItemBase;
			this.OptionLimitBar = optionLimitBar;
			this.AutoSelectTimeBar = autoSelectTimeBar;
			this.UiViewSequence = uiViewSequence;
			this.BlockOption = blockOption;
			this.OptionAdjustItem = optionAdjustItem;
			this.PnlLayoutTwo = pnlLayoutTwo;
			this.PlotItem.SetUIActive(false);
			this.LineItem.SetUIActive(false);
			this.SubtitleAnimation = (this.PlotContent.GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			this.SubtitleAnimDataComp = (this.PlotContent.GetOwner().GetComponentByClass(UUIEffectTextAnimation.StaticClass()) as UUIEffectTextAnimation);
			this.CurLang = LanguageSystem.Instance.PackageAudio;
			UUIScrollViewComponent textScrollView2 = this.TextScrollView;
			float? num;
			if (textScrollView2 == null)
			{
				num = null;
			}
			else
			{
				UUIItem uuiitem = textScrollView2.RootUIComp.Get();
				num = ((uuiitem != null) ? new float?(uuiitem.GetHeight()) : null);
			}
			float? num2 = num;
			this.TextScrollViewPrefabHeight = num2.GetValueOrDefault(174f);
			this.IsOptionShow = false;
			UUISliderComponent optionLimitBar2 = this.OptionLimitBar;
			if (optionLimitBar2 != null)
			{
				optionLimitBar2.GetRootComponent().SetUIActive(false);
			}
			UUISliderComponent autoSelectTimeBar2 = this.AutoSelectTimeBar;
			if (autoSelectTimeBar2 != null)
			{
				autoSelectTimeBar2.GetRootComponent().SetUIActive(false);
			}
			UUIItem blockOption2 = this.BlockOption;
			if (blockOption2 != null)
			{
				blockOption2.SetUIActive(false);
			}
			if (this.LayOutBase != null && this.OptionItemBase != null)
			{
				this.OptionItemBase.SetUIActive(false);
				this.LayOutBase.RootUIComp.Get().SetAlpha(1f);
				this.OptionLayout = new GenericLayout<PlotOptionItem, object>(this.LayOutBase, new Func<PlotOptionItem>(this.InitOptionItem), this.OptionItemBase.GetOwner() as AUIBaseActor, false, true);
				this.OptionLayout.SetActive(false);
			}
			UUIItem pnlLayoutTwo2 = this.PnlLayoutTwo;
			if (pnlLayoutTwo2 != null)
			{
				pnlLayoutTwo2.SetUIActive(false);
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 != null)
			{
				uiViewSequence2.AddSequenceFinishEvent("ChoiceClose", new Action<string>(this.OptionsLayoutHide), false);
			}
			this.NeedSelectedState = (this.Parent is PlotView);
			this.AutoSelectOptionComponent.Init(new PlotAutoSelectOptionComponentContext
			{
				OptionLimitBar = this.OptionLimitBar,
				AutoSelectTimeBar = this.AutoSelectTimeBar,
				ImportantList = importantList,
				ImportantOptionTipsIcon = importantOptionTipsIcon,
				ImportantOptionTipsText = importantOptionTipsText,
				GetCurrentContentDelegate = (() => this.CurrentContent),
				GetSelectedOptionDelegate = (() => this.SelectedPlotOptionItem),
				GetOptionItemsDelegate = (() => this.Options),
				GetAudioRemainingTimeDelegate = new Func<float>(this.GetCurrentAudioRemainingTime),
				GetAutoSelectExtraWaitTimeDelegate = new Func<float>(this.GetAutoSelectExtraWaitTime),
				SelectOptionByIndexDelegate = new Action<int>(this.SelectOptionByIndex),
				SetTextureByPathDelegate = setTextureByPathDelegate,
				RefreshAutoPlayButtonDelegate = refreshAutoPlayButtonDelegate
			});
		}

		// Token: 0x06034A8B RID: 215691 RVA: 0x00C71D1C File Offset: 0x00C6FF1C
		[NullableContext(1)]
		private void OptionsLayoutHide(string _)
		{
			if (this.IsOptionShow)
			{
				return;
			}
			GenericLayout<PlotOptionItem, object> optionLayout = this.OptionLayout;
			if (optionLayout != null)
			{
				optionLayout.SetActive(false);
			}
			UUIItem pnlLayoutTwo = this.PnlLayoutTwo;
			if (pnlLayoutTwo != null)
			{
				pnlLayoutTwo.SetUIActive(false);
			}
			UUISliderComponent optionLimitBar = this.OptionLimitBar;
			if (optionLimitBar != null)
			{
				optionLimitBar.GetRootComponent().SetUIActive(false);
			}
			UUISliderComponent autoSelectTimeBar = this.AutoSelectTimeBar;
			if (autoSelectTimeBar == null)
			{
				return;
			}
			autoSelectTimeBar.GetRootComponent().SetUIActive(false);
		}

		// Token: 0x06034A8C RID: 215692 RVA: 0x00C71D84 File Offset: 0x00C6FF84
		public void OnBeforeHide()
		{
			this.ClearPlotContent(false);
			TimerHandle blockOptionTimer = this.BlockOptionTimer;
			if (blockOptionTimer != null)
			{
				blockOptionTimer.Remove();
			}
			this.BlockOptionTimer = null;
			this.AutoSelectOptionComponent.Clear();
			GenericLayout<PlotOptionItem, object> optionLayout = this.OptionLayout;
			if (optionLayout != null)
			{
				optionLayout.SetActive(false);
			}
			UUIItem pnlLayoutTwo = this.PnlLayoutTwo;
			if (pnlLayoutTwo == null)
			{
				return;
			}
			pnlLayoutTwo.SetUIActive(false);
		}

		// Token: 0x06034A8D RID: 215693 RVA: 0x00C71DE0 File Offset: 0x00C6FFE0
		public void Clear()
		{
			this.RemoveSubtitleAnimationTimer();
			this.ClearCurPlayAudio();
			if (PlotModel.Instance.IsShowingHeadIcon)
			{
				PlotModel.Instance.IsShowingHeadIcon = false;
				PlotPortraitItem portraitItem = this.PortraitItem;
				if (portraitItem != null)
				{
					portraitItem.Destroy(null);
				}
				this.PortraitItem = null;
			}
			TimerHandle scrollStartTimer = this.ScrollStartTimer;
			if (scrollStartTimer != null)
			{
				scrollStartTimer.Remove();
			}
			this.ScrollStartTimer = null;
			this.RemoveTextAnimTimer();
			this.AutoSelectOptionComponent.Clear();
			this.HandleAkEvent(false);
			this.LastEndAkEvent = null;
		}

		// Token: 0x06034A8E RID: 215694 RVA: 0x00C71E61 File Offset: 0x00C70061
		[NullableContext(1)]
		private PlotOptionItem InitOptionItem()
		{
			PlotOptionItem plotOptionItem = new PlotOptionItem(this.Parent);
			plotOptionItem.BindOnHover(new Action<PlotOptionItem>(this.OnPlotOptionItemHover));
			plotOptionItem.BindOnUnHover(new Action<PlotOptionItem>(this.OnPlotOptionItemUnHover));
			return plotOptionItem;
		}

		// Token: 0x06034A8F RID: 215695 RVA: 0x00C71E92 File Offset: 0x00C70092
		[NullableContext(1)]
		private void OnPlotOptionItemUnHover(PlotOptionItem plotOptionItem)
		{
			if (this.NeedSelectedState)
			{
				return;
			}
			plotOptionItem.SetSelectedDisplay(false);
		}

		// Token: 0x06034A90 RID: 215696 RVA: 0x00C71EA4 File Offset: 0x00C700A4
		[NullableContext(1)]
		private void OnPlotOptionItemHover(PlotOptionItem plotOptionItem)
		{
			PlotOptionItem selectedPlotOptionItem = this.SelectedPlotOptionItem;
			if (selectedPlotOptionItem != null)
			{
				selectedPlotOptionItem.SetSelectedDisplay(false);
			}
			this.SelectedPlotOptionItem = plotOptionItem;
			plotOptionItem.SetSelectedDisplay(true);
			this.AutoSelectOptionComponent.OnSelectedOptionChanged();
		}

		// Token: 0x06034A91 RID: 215697 RVA: 0x00C71ED4 File Offset: 0x00C700D4
		public void ShowOptions()
		{
			if (!this.HasOptions)
			{
				return;
			}
			PlotModel.Instance.OptionEnable = true;
			this.SetOptionsShow(true);
			this.CurOption.Clear();
			this.CurOption.AddRange(this.FilterOption(this.CurrentContent.Options));
			this.OptionLayout.RefreshByData(this.CurOption.Cast<object>().ToList<object>(), delegate
			{
				this.HandleOptionState();
				this.AutoSelectOptionComponent.OnOptionsShow();
			}, false);
		}

		// Token: 0x06034A92 RID: 215698 RVA: 0x00C71F4B File Offset: 0x00C7014B
		public void ClearOptions()
		{
			this.CurOption.Clear();
			this.SetOptionsShow(false);
			this.SelectedPlotOptionItem = null;
			this.AutoSelectOptionComponent.Clear();
		}

		// Token: 0x06034A93 RID: 215699 RVA: 0x00C71F71 File Offset: 0x00C70171
		public void OnAutoPlayStateChanged()
		{
			this.AutoSelectOptionComponent.OnAutoPlayStateChanged();
		}

		// Token: 0x06034A94 RID: 215700 RVA: 0x00C71F7E File Offset: 0x00C7017E
		public void OnImmersiveInputStateChange()
		{
			this.AutoSelectOptionComponent.OnImmersiveInputStateChange();
		}

		// Token: 0x06034A95 RID: 215701 RVA: 0x00C71F8C File Offset: 0x00C7018C
		private void HandleOptionState()
		{
			if (!this.NeedSelectedState)
			{
				return;
			}
			PlotOptionItem selectedPlotOptionItem = this.SelectedPlotOptionItem;
			if (selectedPlotOptionItem != null)
			{
				selectedPlotOptionItem.SetSelectedDisplay(false);
			}
			this.SelectedPlotOptionItem = PlotAutoSelectOptionComponent.GetDefaultSelectedOptionItem(this.GetDisplayOptionItems(), this.CurrentContent);
			if (this.SelectedPlotOptionItem != null)
			{
				this.SelectedPlotOptionItem.SetSelectedDisplay(true);
				this.AutoSelectOptionComponent.OnSelectedOptionChanged();
				UiNavigationNewController.Instance.SetNavigationFocusForView(this.SelectedPlotOptionItem.GetToggleItem().GetRootComponent(), true, false, false);
			}
		}

		// Token: 0x06034A96 RID: 215702 RVA: 0x00C72008 File Offset: 0x00C70208
		[NullableContext(1)]
		private PlotOptionItem[] GetDisplayOptionItems()
		{
			List<PlotOptionItem> list = new List<PlotOptionItem>();
			int displayGridEndIndex = this.OptionLayout.GetDisplayGridEndIndex();
			for (int i = 0; i <= displayGridEndIndex; i++)
			{
				PlotOptionItem layoutItemByIndex = this.OptionLayout.GetLayoutItemByIndex(i);
				if (layoutItemByIndex != null)
				{
					list.Add(layoutItemByIndex);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06034A97 RID: 215703 RVA: 0x00C72050 File Offset: 0x00C70250
		public void SetOptionsShow(bool value)
		{
			if (value == this.IsOptionShow)
			{
				return;
			}
			this.IsOptionShow = value;
			if (value)
			{
				this.OptionLayout.SetActive(true);
				UUIItem pnlLayoutTwo = this.PnlLayoutTwo;
				if (pnlLayoutTwo != null)
				{
					pnlLayoutTwo.SetUIActive(true);
				}
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.PlaySequence("ChoiceStart", false, null);
				}
				if (this.BlockOption != null)
				{
					this.BlockOption.SetUIActive(true);
					this.BlockOptionTimer = TimerSystem.Instance.Delay(delegate(float _)
					{
						this.BlockOption.SetUIActive(false);
						this.BlockOptionTimer = null;
					}, PlotModel.Instance.PlotGlobalConfig.ProtectOptionTime, null, null, true, 1f);
					return;
				}
			}
			else
			{
				UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
				if (uiViewSequence2 != null)
				{
					uiViewSequence2.PlaySequence("ChoiceClose", false, null);
				}
				if (this.BlockOption != null)
				{
					this.BlockOption.SetUIActive(false);
					TimerHandle blockOptionTimer = this.BlockOptionTimer;
					if (blockOptionTimer != null)
					{
						blockOptionTimer.Remove();
					}
					this.BlockOptionTimer = null;
				}
			}
		}

		// Token: 0x06034A98 RID: 215704 RVA: 0x00C7214C File Offset: 0x00C7034C
		[NullableContext(1)]
		private List<PlotOption> FilterOption(List<ITalkOption> options)
		{
			List<PlotOption> list = new List<PlotOption>();
			for (int i = 0; i < options.Count; i++)
			{
				ITalkOption talkOption = options[i];
				bool flag = PlotModel.Instance.CheckOptionCondition(talkOption, i, this.CurrentContent);
				if (flag || talkOption.OptionLockTip != null)
				{
					PlotOption item = new PlotOption
					{
						Config = talkOption,
						ConditionCheck = flag,
						OnClick = new Action(this.OnOptionSelected)
					};
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06034A99 RID: 215705 RVA: 0x00C721C6 File Offset: 0x00C703C6
		private void OnOptionSelected()
		{
			this.AutoSelectOptionComponent.OnOptionSelected();
		}

		// Token: 0x06034A9A RID: 215706 RVA: 0x00C721D4 File Offset: 0x00C703D4
		private void SelectOptionByIndex(int optionIndex)
		{
			if (SequenceModel.Instance.IsPlaying)
			{
				SequenceController.Instance.SelectOption(optionIndex, this.CurrentContent.Id);
				return;
			}
			ITalkOption talkOption = this.CurrentContent.Options[optionIndex];
			FlowController.Instance.FlowShowTalk.SelectOption(optionIndex, talkOption.Actions);
		}

		// Token: 0x06034A9B RID: 215707 RVA: 0x00C7222C File Offset: 0x00C7042C
		public void InitInteractOptions()
		{
			if (this.InteractController == null)
			{
				return;
			}
			PlotModel.Instance.OptionEnable = true;
			this.SetOptionsShow(true);
			List<CommonInteractOption> showOptions = this.InteractController.ShowOptions;
			this.OptionLayout.RefreshByData(showOptions.Cast<object>().ToList<object>(), new Action(this.HandleOptionState), false);
		}

		// Token: 0x06034A9C RID: 215708 RVA: 0x00C72284 File Offset: 0x00C70484
		[NullableContext(1)]
		public void UpdatePlotSubtitle(ITalkItem inPlotSubtitleInfo)
		{
			bool flag = false;
			if (inPlotSubtitleInfo.Type.GetValueOrDefault() == ETalkItemType.SystemOption)
			{
				flag = (inPlotSubtitleInfo as ITalkItemSystemOption).OptionConfig.KeepPreTalkItem.GetValueOrDefault();
			}
			if (!flag)
			{
				this.ClearPlotContent(false);
			}
			this.IsInteraction = false;
			this.PlaySubtitle(inPlotSubtitleInfo);
		}

		// Token: 0x06034A9D RID: 215709 RVA: 0x00C722D8 File Offset: 0x00C704D8
		public void ClearPlotContent(bool keepCurrentContent = false)
		{
			UUIScrollViewComponent textScrollView = this.TextScrollView;
			if (textScrollView != null)
			{
				textScrollView.SetScrollProgress(0f);
			}
			this.HandleAkEvent(false);
			this.Talker = null;
			this.IsPause = false;
			this.IsSubmit = false;
			this.IsAudioEnd = false;
			this.AnimOffset = 1f;
			this.RemoveSubtitleAnimationTimer();
			this.ClearCurPlayAudio();
			this.RemoveTextAnimTimer();
			TimerHandle scrollStartTimer = this.ScrollStartTimer;
			if (scrollStartTimer != null)
			{
				scrollStartTimer.Remove();
			}
			this.ScrollStartTimer = null;
			if (!keepCurrentContent)
			{
				this.CurrentContent = null;
			}
		}

		// Token: 0x06034A9E RID: 215710 RVA: 0x00C72363 File Offset: 0x00C70563
		static PlotTextCommonLogic()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotTextCommonLogic.CreateStaticDefaultValue), new Action(PlotTextCommonLogic.ResetStaticDefaultValue));
		}

		// Token: 0x06034A9F RID: 215711 RVA: 0x00C72382 File Offset: 0x00C70582
		public static void CreateStaticDefaultValue()
		{
			PlotTextCommonLogic.CallbackEnableId = 0;
		}

		// Token: 0x06034AA0 RID: 215712 RVA: 0x00C7238A File Offset: 0x00C7058A
		public static void ResetStaticDefaultValue()
		{
			PlotTextCommonLogic.CallbackEnableId = 0;
		}

		// Token: 0x06034AA1 RID: 215713 RVA: 0x00C72394 File Offset: 0x00C70594
		private unsafe bool PlayTone(bool hasSubtitle = true)
		{
			if (this.IsAudioEnd)
			{
				return false;
			}
			if (this.CurrentContent.UniversalTone != null)
			{
				IUniversalTone universalTone = this.CurrentContent.UniversalTone;
				int? num = (universalTone.TimberId != null) ? universalTone.TimberId : ((this.Talker != null) ? new int?(this.Talker.GetValueOrDefault().TimberId) : null);
				int universalToneId = universalTone.UniversalToneId;
				if (num != null)
				{
					Interjection? config = ConfigInterjectionByTimberIdAndUniversalToneId.GetConfig(num.Value, universalToneId, true);
					if (config != null)
					{
						this.PlayTalkInterjection(config.Value, hasSubtitle);
						return true;
					}
				}
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "通用语气配置无法获取，策划检查配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("timberId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("universalToneId", universalToneId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return false;
		}

		// Token: 0x06034AA2 RID: 215714 RVA: 0x00C724A6 File Offset: 0x00C706A6
		private void HandleAkEvent(bool isStart)
		{
			if (isStart)
			{
				this.PlayAkEvent(this.CurrentContent.TalkAkEvent);
				this.LastEndAkEvent = this.CurrentContent.TalkEndAkEvent;
				return;
			}
			this.PlayAkEvent(this.LastEndAkEvent);
			this.LastEndAkEvent = null;
		}

		// Token: 0x06034AA3 RID: 215715 RVA: 0x00C724E4 File Offset: 0x00C706E4
		private void PlayAkEvent(IPostAkEventType config)
		{
			if (config == null)
			{
				return;
			}
			string text = "";
			switch (config.Type)
			{
			case EPostAkEvent.Global:
				text = ((IPostAkEventGlobal)config).AkEvent;
				break;
			case EPostAkEvent.Target:
				text = ((IPostAkEventTargeted)config).AkEvent;
				break;
			case EPostAkEvent.Map:
				text = ((IPostAkEventMap)config).AkEvent;
				break;
			case EPostAkEvent.MusicSubtitle:
				text = ((IPostAkEventMusicSubtitle)config).AkEvent;
				break;
			}
			text = AudioSystem.Instance.parseAudioEventPath(text);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			if (config.Type == EPostAkEvent.Global)
			{
				AudioSystem.Instance.PostEvent(text);
				return;
			}
			if (config.Type == EPostAkEvent.Target)
			{
				int entityId = ((IPostAkEventTargeted)config).EntityId;
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(entityId);
				if (entityByPbDataId == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Event;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "实体不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				BaseActorComponent component = entityByPbDataId.Entity.GetComponent<BaseActorComponent>();
				AActor aactor = (component != null) ? component.Owner : null;
				if (aactor == null || !aactor.IsValid())
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.Event;
					ELogAuthor author2 = ELogAuthor.FZX;
					string message2 = "未能获取到该实体对应的有效Actor";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", entityId);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				AudioSystem.Instance.PostEvent(text, aactor, null);
			}
		}

		// Token: 0x06034AA4 RID: 215716 RVA: 0x00C72640 File Offset: 0x00C70840
		private bool PlayTalkAudio()
		{
			if (this.IsAudioEnd)
			{
				return false;
			}
			if (this.CurLang != LanguageSystem.Instance.PackageAudio)
			{
				this.CurLang = LanguageSystem.Instance.PackageAudio;
				this.ClearCurPlayAudio();
			}
			if (this.PlotPlayEventResult != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Resume, new ExecuteActionArgs?(new ExecuteActionArgs(new int?(this.BREAK_TIME), null, null)));
				this.HandlePlotLogic(null, null);
				return true;
			}
			if (this.WaitAudioLoadTimer != null)
			{
				this.WaitAudioLoadTimer.Resume();
				return true;
			}
			PlotAudio? plotAudio = this.CurrentContent.PlayVoice.GetValueOrDefault() ? ConfigPlotAudioById.GetConfig(this.CurrentContent.TidTalk, true) : null;
			if (plotAudio == null)
			{
				return false;
			}
			float extraDuration = (plotAudio.Value.TailTime < 0) ? PlotModel.Instance.PlotGlobalConfig.AudioEndDelay : ((float)plotAudio.Value.TailTime);
			ExternalSourceSetting? config = ConfigExternalSourceSettingById.GetConfig(plotAudio.Value.ExternalSourceSetting, true);
			string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(plotAudio.Value);
			string @event = AudioSystem.Instance.parseAudioEventPath(config.Value.SubtitleEvent);
			PlotTextCommonLogic.CallbackEnableId++;
			int id = PlotTextCommonLogic.CallbackEnableId;
			AActor target = null;
			this.PlotPlayEventResult = AudioSystem.Instance.PostEvent(@event, target, new PostEventArgs?(new PostEventArgs
			{
				ExternalSourceName = config.Value.SubtitleSrc,
				ExternalSourceMediaName = externalSourcesMediaName,
				CallbackMask = new ECallbackMask?(ECallbackMask.Duration),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					if (id != PlotTextCommonLogic.CallbackEnableId)
					{
						return;
					}
					if (callbackType != EAkCallbackType.EndOfEvent)
					{
						if (callbackType == EAkCallbackType.Duration)
						{
							float audioRemainingTime = ((UAkDurationCallbackInfo)callbackInfo).Duration + extraDuration;
							this.SetAudioRemainingTime(audioRemainingTime);
							this.RemoveWaitAudioLoadTimer();
							PlotModel.Instance.PlotTemplate.HandleMouthAnim(this.CurrentContent);
							if (!this.IsPause)
							{
								this.HandlePlotLogic(null, null);
							}
						}
						return;
					}
					this.IsAudioEnd = true;
					this.PlotPlayEventResult = 0;
					this.ResetAudioRemainingTime();
					PlotTextCommonLogic.CallbackEnableId++;
					Action<float> plotAudioEndCallback = this.PlotAudioEndCallback;
					if (plotAudioEndCallback == null)
					{
						return;
					}
					plotAudioEndCallback(extraDuration);
				}
			}));
			this.WaitAudioLoadTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.FZX, "[PlotTextLogic] 加载剧情音频超时，直接显示剧情文本", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ClearCurPlayAudio();
				this.PlayDelayTime = null;
				this.IsAudioEnd = true;
				Action<float> plotAudioEndCallback = this.PlotAudioEndCallback;
				if (plotAudioEndCallback != null)
				{
					plotAudioEndCallback(0f);
				}
				this.HandlePlotLogic(null, null);
			}, (float)this.MAX_LOAD_AUDIO_TIME, null, null, true, 1f);
			return true;
		}

		// Token: 0x06034AA5 RID: 215717 RVA: 0x00C72864 File Offset: 0x00C70A64
		private unsafe void PlayTalkInterjection(Interjection config, bool hasSubtitle)
		{
			if (this.WaitAudioLoadTimer != null)
			{
				this.WaitAudioLoadTimer.Resume();
				return;
			}
			if (this.CurLang != LanguageSystem.Instance.PackageAudio)
			{
				this.CurLang = LanguageSystem.Instance.PackageAudio;
				this.ClearCurPlayAudio();
			}
			if (this.PlotPlayEventResult != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Resume, new ExecuteActionArgs?(new ExecuteActionArgs(new int?(this.BREAK_TIME), null, null)));
				if (hasSubtitle)
				{
					this.HandlePlotLogic(null, null);
				}
				return;
			}
			string eventName = AudioSystem.Instance.parseAudioEventPath(config.AkEvent);
			int id = PlotTextCommonLogic.CallbackEnableId;
			AActor target = null;
			this.PlotPlayEventResult = AudioSystem.Instance.PostEvent(eventName, target, new PostEventArgs?(new PostEventArgs
			{
				CallbackMask = new ECallbackMask?(ECallbackMask.Duration),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					if (id != PlotTextCommonLogic.CallbackEnableId)
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.Plot;
						ELogAuthor author = ELogAuthor.FZX;
						string message = "[PlotViewHud] 废弃的音频回调";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", id);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("eventName", eventName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("type", callbackType);
						instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
						return;
					}
					if (callbackType == EAkCallbackType.EndOfEvent)
					{
						this.IsAudioEnd = true;
						this.PlotPlayEventResult = 0;
						this.ResetAudioRemainingTime();
						PlotTextCommonLogic.CallbackEnableId++;
						if (hasSubtitle)
						{
							Action<float> plotAudioEndCallback = this.PlotAudioEndCallback;
							if (plotAudioEndCallback == null)
							{
								return;
							}
							plotAudioEndCallback(0f);
						}
						return;
					}
					if (callbackType == EAkCallbackType.Duration)
					{
						float duration = ((UAkDurationCallbackInfo)callbackInfo).Duration;
						this.SetAudioRemainingTime(duration);
						this.RemoveWaitAudioLoadTimer();
						if (!this.IsPause & hasSubtitle)
						{
							this.HandlePlotLogic(null, null);
						}
					}
				}
			}));
			if (hasSubtitle)
			{
				this.WaitAudioLoadTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.CFT, "加载通用语气音频超时，直接显示剧情文本", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.ClearCurPlayAudio();
					this.PlayDelayTime = null;
					this.IsAudioEnd = true;
					Action<float> plotAudioEndCallback = this.PlotAudioEndCallback;
					if (plotAudioEndCallback != null)
					{
						plotAudioEndCallback(0f);
					}
					this.HandlePlotLogic(null, null);
				}, (float)this.MAX_LOAD_AUDIO_TIME, null, null, true, 1f);
			}
		}

		// Token: 0x06034AA6 RID: 215718 RVA: 0x00C729C0 File Offset: 0x00C70BC0
		public void ClearCurPlayAudio()
		{
			this.RemoveWaitAudioLoadTimer();
			PlotTextCommonLogic.CallbackEnableId++;
			AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs(new int?(0), null, null)));
			this.PlotPlayEventResult = 0;
			this.ResetAudioRemainingTime();
		}

		// Token: 0x06034AA7 RID: 215719 RVA: 0x00C72A17 File Offset: 0x00C70C17
		private void RemoveWaitAudioLoadTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.WaitAudioLoadTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.WaitAudioLoadTimer);
			}
			this.WaitAudioLoadTimer = null;
		}

		// Token: 0x06034AA8 RID: 215720 RVA: 0x00C72A43 File Offset: 0x00C70C43
		private void SetAudioRemainingTime(float duration)
		{
			this.AudioDuration = duration;
			this.AudioEndTime = TimeUtil.Instance.GetServerTimeStamp() + (double)duration;
		}

		// Token: 0x06034AA9 RID: 215721 RVA: 0x00C72A5F File Offset: 0x00C70C5F
		private void ResetAudioRemainingTime()
		{
			this.AudioDuration = 0f;
			this.AudioEndTime = 0.0;
		}

		// Token: 0x06034AAA RID: 215722 RVA: 0x00C72A7C File Offset: 0x00C70C7C
		private float GetCurrentAudioRemainingTime()
		{
			if (this.IsAudioEnd || this.PlotPlayEventResult == 0 || this.AudioDuration <= 0f)
			{
				return 0f;
			}
			int? sourcePlayPosition = AudioSystem.Instance.GetSourcePlayPosition(this.PlotPlayEventResult, false);
			if (sourcePlayPosition != null)
			{
				return Math.Max(0f, this.AudioDuration - (float)sourcePlayPosition.Value);
			}
			return Math.Max(0f, (float)(this.AudioEndTime - TimeUtil.Instance.GetServerTimeStamp()));
		}

		// Token: 0x06034AAB RID: 215723 RVA: 0x00C72B00 File Offset: 0x00C70D00
		private float GetAutoSelectExtraWaitTime()
		{
			if (this.Parent is PlotView && PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC && this.CurrentContent.PlayVoice.GetValueOrDefault())
			{
				return (float)this.LEVEL_C_PLOT_VIEW_AUTO_SELECT_EXTRA_WAIT_TIME;
			}
			return 0f;
		}

		// Token: 0x06034AAC RID: 215724 RVA: 0x00C72B54 File Offset: 0x00C70D54
		public unsafe void PlaySubtitle(ITalkItem inPlotSubtitleInfo)
		{
			if (inPlotSubtitleInfo == null)
			{
				return;
			}
			this.CurrentContent = inPlotSubtitleInfo;
			this.HandleAkEvent(true);
			if (this.CurrentContent.Type.GetValueOrDefault() == ETalkItemType.Option || this.CurrentContent.Type.GetValueOrDefault() == ETalkItemType.SystemOption)
			{
				this.ClearCurPlayAudio();
				this.PlayTone(false);
				return;
			}
			ICaptionParam captionParams = this.CurrentContent.CaptionParams;
			if (this.CurrentContent.WhoId != null)
			{
				this.Talker = ConfigSpeakerById.GetConfig(this.CurrentContent.WhoId.Value, true);
			}
			if (captionParams != null && captionParams.StartTime == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "配置了字幕参数的无法播放语音";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("textId", (inPlotSubtitleInfo != null) ? inPlotSubtitleInfo.TidTalk : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("id", (inPlotSubtitleInfo != null) ? new int?(inPlotSubtitleInfo.Id) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("param", (inPlotSubtitleInfo != null) ? inPlotSubtitleInfo.CaptionParams : null);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.IsAudioEnd = true;
				Action<float> plotAudioEndCallback = this.PlotAudioEndCallback;
				if (plotAudioEndCallback != null)
				{
					plotAudioEndCallback(0f);
				}
				if (this.CurrentContent != inPlotSubtitleInfo)
				{
					return;
				}
				this.HandlePlotLogic(captionParams.TotalTime, captionParams.IntervalTime);
				return;
			}
			else
			{
				if (this.PlayTalkAudio() || this.PlayTone(true))
				{
					return;
				}
				this.IsAudioEnd = true;
				Action<float> plotAudioEndCallback2 = this.PlotAudioEndCallback;
				if (plotAudioEndCallback2 != null)
				{
					plotAudioEndCallback2(0f);
				}
				if (this.CurrentContent != inPlotSubtitleInfo)
				{
					return;
				}
				this.HandlePlotLogic(null, null);
				return;
			}
		}

		// Token: 0x06034AAD RID: 215725 RVA: 0x00C72D34 File Offset: 0x00C70F34
		public void PauseSubtitle()
		{
			if (this.CurrentContent == null)
			{
				return;
			}
			this.IsPause = true;
			if (this.WaitAudioLoadTimer != null)
			{
				this.WaitAudioLoadTimer.Pause();
				return;
			}
			if (this.PlotPlayEventResult != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Pause, new ExecuteActionArgs?(new ExecuteActionArgs(new int?(this.BREAK_TIME), null, null)));
			}
			TimerHandle scrollStartTimer = this.ScrollStartTimer;
			if (scrollStartTimer != null)
			{
				scrollStartTimer.Remove();
			}
			this.ScrollStartTimer = null;
			this.RemoveTextAnimTimer();
			if (this.SubtitleAnimationTimer != null)
			{
				this.AnimOffset = this.SubtitleAnimDataComp.GetSelectorOffset();
				this.SubtitleAnimation.Stop();
				this.SubtitleAnimationTimer.Pause();
			}
		}

		// Token: 0x06034AAE RID: 215726 RVA: 0x00C72DED File Offset: 0x00C70FED
		[NullableContext(1)]
		public void ResumeSubtitle(ITalkItem config)
		{
			this.IsPause = false;
			this.PlaySubtitle(config);
		}

		// Token: 0x06034AAF RID: 215727 RVA: 0x00C72DFD File Offset: 0x00C70FFD
		private void HandlePlotLogic(float? captionTotalTime = null, float? captionIntervalTime = null)
		{
			this.HandlePlotTitle();
			this.HandlePlotContent();
			this.HandlePlotContentAnim(captionTotalTime, captionIntervalTime);
			this.ScrollStartTimer = TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				this.ScrollStartTimer = TimerSystem.GameplayTimeInstance.Next(delegate(float _)
				{
					this.HandlePlotContentScroll();
				}, null, null);
			}, null, null);
		}

		// Token: 0x06034AB0 RID: 215728 RVA: 0x00C72E34 File Offset: 0x00C71034
		private void HandlePlotTitle()
		{
			this.PlotItem.SetUIActive(true);
			if (PlotModel.Instance.PlotConfig.SubtitleLevel.GetValueOrDefault() == EPlotLevel.LevelC && PlotModel.Instance.IsUseNewLevelBStyle())
			{
				this.NpcName.SetUIActive(false);
				this.NpcTitle.SetUIActive(false);
				this.LineItem.SetUIActive(false);
				return;
			}
			if (this.CurrentContent.Type != null)
			{
				ETalkItemType? type = this.CurrentContent.Type;
				ETalkItemType etalkItemType = ETalkItemType.Talk;
				if (!(type.GetValueOrDefault() == etalkItemType & type != null))
				{
					this.LineItem.SetUIActive(false);
					this.NpcName.SetUIActive(false);
					this.NpcTitle.SetUIActive(false);
					return;
				}
			}
			ITalkItemDialog talkItemDialog = this.CurrentContent as ITalkItemDialog;
			if (talkItemDialog != null && talkItemDialog.Style != null && talkItemDialog.Style.Type == ETalkItemStyle.InnerVoice)
			{
				this.LineItem.SetUIActive(false);
				this.NpcName.SetUIActive(false);
				this.NpcTitle.SetUIActive(false);
				return;
			}
			this.LineItem.SetUIActive(true);
			string configTextByTable = PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, new int?(this.Talker.Value.Id));
			if (!StringUtils.IsEmpty(configTextByTable))
			{
				this.NpcName.SetUIActive(true);
				this.NpcName.SetText(configTextByTable, true);
			}
			else
			{
				this.NpcName.SetUIActive(false);
			}
			string configTextByTable2 = PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerTitle, new int?(this.Talker.Value.Id));
			if (!StringUtils.IsEmpty(configTextByTable2))
			{
				this.NpcTitle.SetUIActive(true);
				this.NpcTitle.SetText(configTextByTable2, true);
				return;
			}
			this.NpcTitle.SetUIActive(false);
		}

		// Token: 0x06034AB1 RID: 215729 RVA: 0x00C72FF0 File Offset: 0x00C711F0
		private void HandlePlotContent()
		{
			if (this.CurrentContent.Type.GetValueOrDefault() == ETalkItemType.NoTextItem)
			{
				this.PlotContent.SetUIActive(false);
				return;
			}
			this.PlotContent.SetUIActive(true);
			string text = PublicUtil.Instance.GetFlowConfigLocalText(this.CurrentContent.TidTalk);
			if (StringUtils.IsEmpty(text))
			{
				FlowController instance = FlowController.Instance;
				string text2 = "字幕为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", this.CurrentContent.TidTalk);
				instance.LogError(text2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				text = this.CurrentContent.TidTalk;
			}
			bool needClear = PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelD;
			text = PlotModel.Instance.PlotTextReplacer.Replace(text, needClear);
			this.PlotContent.SetGameRichText(true);
			this.PlotContent.SetText(text, true);
			Action<string> plotContentUpdateCallback = this.PlotContentUpdateCallback;
			if (plotContentUpdateCallback == null)
			{
				return;
			}
			plotContentUpdateCallback(text);
		}

		// Token: 0x06034AB2 RID: 215730 RVA: 0x00C730D8 File Offset: 0x00C712D8
		private void HandlePlotContentScroll()
		{
			this.ScrollStartTimer = null;
			this.RemoveTextAnimTimer();
			if (this.TextScrollView == null)
			{
				return;
			}
			float y = this.PlotContent.GetTextRenderSize().Y;
			UUIItem uuiitem = this.TextScrollView.RootUIComp.Get();
			float num = (uuiitem != null) ? uuiitem.GetHeight() : this.TextScrollViewPrefabHeight;
			UUIItem optionAdjustItem = this.OptionAdjustItem;
			if (optionAdjustItem != null)
			{
				optionAdjustItem.SetHeight(num + (float)this.OPTIONHEIGHT_OFFSET);
			}
			if (y <= num)
			{
				return;
			}
			float textAnimSpeed = this.GetTextAnimSpeed();
			int num2 = ConfigCommonParamById.GetIntConfig("PlotAutoScrollDelayCharNum") ?? this.DEFAULT_AUTO_SCROLL_DELAY_CHAR_NUM;
			int displayCharLength = this.PlotContent.GetDisplayCharLength();
			if (displayCharLength <= num2)
			{
				num2 = this.PlotContent.GetRenderLineCharNum(0);
			}
			num2 = Math.Min(num2, Math.Max(displayCharLength - 1, 1));
			float interval = (float)num2 / textAnimSpeed * 1000f;
			int num3 = Math.Max(displayCharLength - num2, 1);
			this.ScrollTotalTime = (float)num3 / textAnimSpeed * 1000f;
			this.DelayTextScrollAnimTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.StartAutoScrollAnim();
			}, interval, null, null, true, 1f);
		}

		// Token: 0x06034AB3 RID: 215731 RVA: 0x00C731F8 File Offset: 0x00C713F8
		private float GetTextAnimSpeed()
		{
			if (this.IsInteraction)
			{
				return PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedInteraction;
			}
			if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC)
			{
				return PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedLevelC;
			}
			return PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedLevelD;
		}

		// Token: 0x06034AB4 RID: 215732 RVA: 0x00C73254 File Offset: 0x00C71454
		private void StartAutoScrollAnim()
		{
			this.CurrentAnimTime = 0f;
			int intervalTime = 100;
			this.TextScrollAnimTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				float num = this.CurrentAnimTime / this.ScrollTotalTime;
				UUIScrollViewComponent textScrollView = this.TextScrollView;
				if (textScrollView != null)
				{
					textScrollView.SetScrollProgress(num);
				}
				if (num >= 1f && TimerSystem.GameplayTimeInstance.Has(this.TextScrollAnimTimer))
				{
					TimerSystem.GameplayTimeInstance.Remove(this.TextScrollAnimTimer);
				}
				this.CurrentAnimTime += (float)intervalTime;
			}, (float)intervalTime, 1f, null, null, true);
		}

		// Token: 0x06034AB5 RID: 215733 RVA: 0x00C732AC File Offset: 0x00C714AC
		private void RemoveTextAnimTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TextScrollAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TextScrollAnimTimer);
			}
			if (TimerSystem.GameplayTimeInstance.Has(this.DelayTextScrollAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTextScrollAnimTimer);
			}
			this.TextScrollAnimTimer = null;
			this.DelayTextScrollAnimTimer = null;
		}

		// Token: 0x06034AB6 RID: 215734 RVA: 0x00C73310 File Offset: 0x00C71510
		private void HandlePlotContentAnim(float? captionTotalTime = null, float? captionIntervalTime = null)
		{
			if (this.SubtitleAnimation == null)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.YSQ, "找不到字幕动画组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.HandleSubtitleAnimFinished();
				return;
			}
			if (this.SubtitleAnimationTimer != null)
			{
				this.SubtitleAnimationTimer.Resume();
				(this.SubtitleAnimation.GetPlayTween() as ULGUIPlayTween_Float).from = this.AnimOffset;
				this.SubtitleAnimation.GetPlayTween().duration *= this.AnimOffset;
				this.SubtitleAnimation.Play();
				return;
			}
			if (this.IsSubmit)
			{
				this.SubtitleAnimDataComp.SetSelectorOffset(0f);
				return;
			}
			int displayCharLength = this.PlotContent.GetDisplayCharLength();
			this.SubtitleAnimation.Stop();
			float num;
			if (captionTotalTime != null)
			{
				num = captionTotalTime.Value;
			}
			else if (this.IsInteraction)
			{
				num = (float)displayCharLength / PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedInteraction;
			}
			else if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC)
			{
				num = (float)displayCharLength / PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedLevelC;
			}
			else
			{
				num = (float)displayCharLength / PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedLevelD;
			}
			this.SubtitleAnimDataComp.SetSelectorOffset(1f);
			this.SubtitleAnimation.GetPlayTween().duration = num;
			this.SubtitleAnimation.Play();
			this.IsTextAnimPlaying = true;
			num *= 1000f;
			if (captionIntervalTime != null)
			{
				this.PlayDelayTime = new float?(captionIntervalTime.Value * 1000f);
			}
			else
			{
				this.PlayDelayTime = new float?(0f);
			}
			this.WaitSubtitleAnimationFinish(num);
		}

		// Token: 0x06034AB7 RID: 215735 RVA: 0x00C734BC File Offset: 0x00C716BC
		private void WaitSubtitleAnimationFinish(float duration)
		{
			this.RemoveSubtitleAnimationTimer();
			float interval = Math.Max(duration, 20f);
			this.SubtitleAnimationTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.HandleSubtitleAnimFinished();
			}, interval, null, null, true, 1f);
		}

		// Token: 0x06034AB8 RID: 215736 RVA: 0x00C73500 File Offset: 0x00C71700
		private void RemoveSubtitleAnimationTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.SubtitleAnimationTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.SubtitleAnimationTimer);
			}
			this.SubtitleAnimationTimer = null;
		}

		// Token: 0x06034AB9 RID: 215737 RVA: 0x00C7352C File Offset: 0x00C7172C
		private void HandleSubtitleAnimFinished()
		{
			ULGUIPlayTweenComponent subtitleAnimation = this.SubtitleAnimation;
			ULGUIPlayTween_Float ulguiplayTween_Float = ((subtitleAnimation != null) ? subtitleAnimation.GetPlayTween() : null) as ULGUIPlayTween_Float;
			if (ulguiplayTween_Float != null)
			{
				ulguiplayTween_Float.from = 1f;
			}
			this.RemoveSubtitleAnimationTimer();
			this.IsTextAnimPlaying = false;
			this.IsSubmit = true;
			Action plotContentAnimFinishCallback = this.PlotContentAnimFinishCallback;
			if (plotContentAnimFinishCallback == null)
			{
				return;
			}
			plotContentAnimFinishCallback();
		}

		// Token: 0x06034ABA RID: 215738 RVA: 0x00C73583 File Offset: 0x00C71783
		[NullableContext(1)]
		public void SetPlotContentAnimFinishCallback(Action callback)
		{
			this.PlotContentAnimFinishCallback = callback;
		}

		// Token: 0x06034ABB RID: 215739 RVA: 0x00C7358C File Offset: 0x00C7178C
		[NullableContext(1)]
		public void SetPlotContentUpdateCallback(Action<string> callback)
		{
			this.PlotContentUpdateCallback = callback;
		}

		// Token: 0x06034ABC RID: 215740 RVA: 0x00C73595 File Offset: 0x00C71795
		[NullableContext(1)]
		public void SetPlotAudioEndCallback(Action<float> callback)
		{
			this.PlotAudioEndCallback = callback;
		}

		// Token: 0x06034ABD RID: 215741 RVA: 0x00C7359E File Offset: 0x00C7179E
		public void ForceSkipPlotContentAnim()
		{
			this.SubtitleAnimation.Stop();
			this.SubtitleAnimDataComp.SetSelectorOffset(0f);
			this.RemoveTextAnimTimer();
			UUIScrollViewComponent textScrollView = this.TextScrollView;
			if (textScrollView != null)
			{
				textScrollView.SetScrollProgress(1f);
			}
			this.HandleSubtitleAnimFinished();
		}

		// Token: 0x06034ABE RID: 215742 RVA: 0x00C735DD File Offset: 0x00C717DD
		public float GetPlotContentAnimDuration()
		{
			return this.SubtitleAnimation.GetPlayTween().duration;
		}

		// Token: 0x06034ABF RID: 215743 RVA: 0x00C735F0 File Offset: 0x00C717F0
		public void HandlePortraitVisible([Nullable(1)] UUIItem rootItem, SetHeadIconVisible headIconInfo, Action callback)
		{
			if (headIconInfo == null || callback == null)
			{
				return;
			}
			if (headIconInfo.Visible && !PlotModel.Instance.IsShowingHeadIcon)
			{
				PlotModel.Instance.IsShowingHeadIcon = true;
				this.PortraitItem = new PlotPortraitItem();
				this.PortraitItem.OpenAsync(rootItem, headIconInfo.HeadStyleConfig).ContinueWith(callback);
				return;
			}
			if (headIconInfo.Visible && PlotModel.Instance.IsShowingHeadIcon)
			{
				this.PortraitItem.CloseAsync().Forget();
				this.PortraitItem = new PlotPortraitItem();
				this.PortraitItem.OpenAsync(rootItem, headIconInfo.HeadStyleConfig).ContinueWith(callback);
				return;
			}
			if (!headIconInfo.Visible && PlotModel.Instance.IsShowingHeadIcon)
			{
				PlotModel.Instance.IsShowingHeadIcon = false;
				this.PortraitItem.CloseAsync().ContinueWith(callback);
				this.PortraitItem = null;
				return;
			}
			callback();
		}

		// Token: 0x06034AC0 RID: 215744 RVA: 0x00C736D0 File Offset: 0x00C718D0
		public UniTask DestroyPortraitItem()
		{
			PlotTextCommonLogic.<DestroyPortraitItem>d__122 <DestroyPortraitItem>d__;
			<DestroyPortraitItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DestroyPortraitItem>d__.<>4__this = this;
			<DestroyPortraitItem>d__.<>1__state = -1;
			<DestroyPortraitItem>d__.<>t__builder.Start<PlotTextCommonLogic.<DestroyPortraitItem>d__122>(ref <DestroyPortraitItem>d__);
			return <DestroyPortraitItem>d__.<>t__builder.Task;
		}

		// Token: 0x06034AC1 RID: 215745 RVA: 0x00C73713 File Offset: 0x00C71913
		public void OnTick(float delta)
		{
			this.AutoSelectOptionComponent.OnTick(delta, this.MuteTimeLimitedOption);
		}

		// Token: 0x0401C10A RID: 114954
		private int OPTIONHEIGHT_OFFSET = 265;

		// Token: 0x0401C10B RID: 114955
		private int DEFAULT_AUTO_SCROLL_DELAY_CHAR_NUM = 25;

		// Token: 0x0401C10C RID: 114956
		private int LEVEL_C_PLOT_VIEW_AUTO_SELECT_EXTRA_WAIT_TIME = 3000;

		// Token: 0x0401C10D RID: 114957
		private int BREAK_TIME = 1000;

		// Token: 0x0401C10E RID: 114958
		private int MAX_LOAD_AUDIO_TIME = 3000;

		// Token: 0x0401C10F RID: 114959
		public const int PLAY_FLAG = 8;

		// Token: 0x0401C110 RID: 114960
		public ITalkItem CurrentContent;

		// Token: 0x0401C111 RID: 114961
		[Nullable(1)]
		private string CurLang = "";

		// Token: 0x0401C112 RID: 114962
		private readonly float TextScrollViewPrefabHeight;

		// Token: 0x0401C113 RID: 114963
		private IPostAkEventType LastEndAkEvent;

		// Token: 0x0401C114 RID: 114964
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private readonly GenericLayout<PlotOptionItem, object> OptionLayout;

		// Token: 0x0401C115 RID: 114965
		private PlotOptionItem SelectedPlotOptionItem;

		// Token: 0x0401C116 RID: 114966
		private bool IsOptionShow;

		// Token: 0x0401C117 RID: 114967
		[Nullable(1)]
		public readonly List<PlotOption> CurOption = new List<PlotOption>();

		// Token: 0x0401C118 RID: 114968
		private TimerHandle BlockOptionTimer;

		// Token: 0x0401C119 RID: 114969
		[Nullable(1)]
		private readonly PlotAutoSelectOptionComponent AutoSelectOptionComponent = new PlotAutoSelectOptionComponent();

		// Token: 0x0401C11A RID: 114970
		private float OptionLimitTime;

		// Token: 0x0401C11B RID: 114971
		private float OptionLimitTimeDuration;

		// Token: 0x0401C11C RID: 114972
		private int TimeoutOptionIndex = -1;

		// Token: 0x0401C11D RID: 114973
		private bool HasTimeLimitedOption;

		// Token: 0x0401C11E RID: 114974
		public bool MuteTimeLimitedOption;

		// Token: 0x0401C11F RID: 114975
		private readonly bool NeedSelectedState;

		// Token: 0x0401C120 RID: 114976
		[Nullable(1)]
		protected readonly UUIItem PlotItem;

		// Token: 0x0401C121 RID: 114977
		[Nullable(1)]
		protected readonly UUIText NpcName;

		// Token: 0x0401C122 RID: 114978
		[Nullable(1)]
		protected readonly UUIText NpcTitle;

		// Token: 0x0401C123 RID: 114979
		[Nullable(1)]
		protected readonly UUIText PlotContent;

		// Token: 0x0401C124 RID: 114980
		[Nullable(1)]
		protected readonly UUIItem LineItem;

		// Token: 0x0401C125 RID: 114981
		protected readonly UUIScrollViewComponent TextScrollView;

		// Token: 0x0401C126 RID: 114982
		protected readonly ISimulatePlot Parent;

		// Token: 0x0401C127 RID: 114983
		protected readonly UUILayoutBase LayOutBase;

		// Token: 0x0401C128 RID: 114984
		protected readonly UUIItem OptionItemBase;

		// Token: 0x0401C129 RID: 114985
		protected readonly UUISliderComponent OptionLimitBar;

		// Token: 0x0401C12A RID: 114986
		protected readonly UUISliderComponent AutoSelectTimeBar;

		// Token: 0x0401C12B RID: 114987
		protected readonly UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x0401C12C RID: 114988
		protected readonly UUIItem BlockOption;

		// Token: 0x0401C12D RID: 114989
		protected readonly UUIItem OptionAdjustItem;

		// Token: 0x0401C12E RID: 114990
		protected readonly UUIItem PnlLayoutTwo;

		// Token: 0x0401C12F RID: 114991
		private readonly ULGUIPlayTweenComponent SubtitleAnimation;

		// Token: 0x0401C130 RID: 114992
		private readonly UUIEffectTextAnimation SubtitleAnimDataComp;

		// Token: 0x0401C131 RID: 114993
		public float? PlayDelayTime;

		// Token: 0x0401C132 RID: 114994
		private TimerHandle WaitAudioLoadTimer;

		// Token: 0x0401C133 RID: 114995
		private int PlotPlayEventResult;

		// Token: 0x0401C134 RID: 114996
		private float AudioDuration;

		// Token: 0x0401C135 RID: 114997
		private double AudioEndTime;

		// Token: 0x0401C136 RID: 114998
		private static int CallbackEnableId;

		// Token: 0x0401C137 RID: 114999
		private Action<float> PlotAudioEndCallback;

		// Token: 0x0401C138 RID: 115000
		private Speaker? Talker;

		// Token: 0x0401C139 RID: 115001
		private float AnimOffset = 1f;

		// Token: 0x0401C13A RID: 115002
		private bool IsPause;

		// Token: 0x0401C13B RID: 115003
		private bool IsSubmit;

		// Token: 0x0401C13C RID: 115004
		private bool IsAudioEnd;

		// Token: 0x0401C13D RID: 115005
		private TimerHandle ScrollStartTimer;

		// Token: 0x0401C13E RID: 115006
		private float ScrollTotalTime;

		// Token: 0x0401C13F RID: 115007
		private float CurrentAnimTime;

		// Token: 0x0401C140 RID: 115008
		private TimerHandle TextScrollAnimTimer;

		// Token: 0x0401C141 RID: 115009
		private TimerHandle DelayTextScrollAnimTimer;

		// Token: 0x0401C142 RID: 115010
		public TimerHandle SubtitleAnimationTimer;

		// Token: 0x0401C143 RID: 115011
		public bool IsInteraction;

		// Token: 0x0401C144 RID: 115012
		public bool IsTextAnimPlaying;

		// Token: 0x0401C145 RID: 115013
		private Action PlotContentAnimFinishCallback;

		// Token: 0x0401C146 RID: 115014
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string> PlotContentUpdateCallback;

		// Token: 0x0401C147 RID: 115015
		private PlotPortraitItem PortraitItem;
	}
}
