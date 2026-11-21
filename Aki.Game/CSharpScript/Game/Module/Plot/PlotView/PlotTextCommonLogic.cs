using System;
using System.Collections.Generic;
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
	// Token: 0x02004033 RID: 16435
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTextCommonLogic : IStaticVariableResetter
	{
		// Token: 0x170053EF RID: 21487
		// (get) Token: 0x0602997A RID: 170362 RVA: 0x00BBEC12 File Offset: 0x00BBCE12
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

		// Token: 0x170053F0 RID: 21488
		// (get) Token: 0x0602997B RID: 170363 RVA: 0x00BBEC31 File Offset: 0x00BBCE31
		public bool HasOptions
		{
			get
			{
				return this.CurrentContent != null && this.CurrentContent.Options != null && this.CurrentContent.Options.Count != 0;
			}
		}

		// Token: 0x170053F1 RID: 21489
		// (get) Token: 0x0602997C RID: 170364 RVA: 0x00BBEC60 File Offset: 0x00BBCE60
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

		// Token: 0x0602997D RID: 170365 RVA: 0x00BBEC84 File Offset: 0x00BBCE84
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

		// Token: 0x0602997E RID: 170366 RVA: 0x00BBEFF4 File Offset: 0x00BBD1F4
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

		// Token: 0x0602997F RID: 170367 RVA: 0x00BBF05C File Offset: 0x00BBD25C
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

		// Token: 0x06029980 RID: 170368 RVA: 0x00BBF0B8 File Offset: 0x00BBD2B8
		public void Clear()
		{
			this.RemoveSubtitleAnimationTimer();
			this.ClearCurPlayAudio(null);
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

		// Token: 0x06029981 RID: 170369 RVA: 0x00BBF142 File Offset: 0x00BBD342
		[NullableContext(1)]
		private PlotOptionItem InitOptionItem()
		{
			PlotOptionItem plotOptionItem = new PlotOptionItem(this.Parent);
			plotOptionItem.BindOnHover(new Action<PlotOptionItem>(this.OnPlotOptionItemHover));
			plotOptionItem.BindOnUnHover(new Action<PlotOptionItem>(this.OnPlotOptionItemUnHover));
			return plotOptionItem;
		}

		// Token: 0x06029982 RID: 170370 RVA: 0x00BBF173 File Offset: 0x00BBD373
		[NullableContext(1)]
		private void OnPlotOptionItemUnHover(PlotOptionItem plotOptionItem)
		{
			if (this.NeedSelectedState)
			{
				return;
			}
			plotOptionItem.SetSelectedDisplay(false);
		}

		// Token: 0x06029983 RID: 170371 RVA: 0x00BBF185 File Offset: 0x00BBD385
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

		// Token: 0x06029984 RID: 170372 RVA: 0x00BBF1B4 File Offset: 0x00BBD3B4
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
			this.OptionLayout.RefreshByData(new List<object>(this.CurOption), delegate
			{
				this.HandleOptionState();
				this.AutoSelectOptionComponent.OnOptionsShow();
			}, false);
		}

		// Token: 0x06029985 RID: 170373 RVA: 0x00BBF226 File Offset: 0x00BBD426
		public void ClearOptions()
		{
			this.CurOption.Clear();
			this.SetOptionsShow(false);
			this.SelectedPlotOptionItem = null;
			this.AutoSelectOptionComponent.Clear();
		}

		// Token: 0x06029986 RID: 170374 RVA: 0x00BBF24C File Offset: 0x00BBD44C
		public void OnAutoPlayStateChanged()
		{
			this.AutoSelectOptionComponent.OnAutoPlayStateChanged();
		}

		// Token: 0x06029987 RID: 170375 RVA: 0x00BBF259 File Offset: 0x00BBD459
		public void OnImmersiveInputStateChange()
		{
			this.AutoSelectOptionComponent.OnImmersiveInputStateChange();
		}

		// Token: 0x06029988 RID: 170376 RVA: 0x00BBF268 File Offset: 0x00BBD468
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

		// Token: 0x06029989 RID: 170377 RVA: 0x00BBF2E4 File Offset: 0x00BBD4E4
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

		// Token: 0x0602998A RID: 170378 RVA: 0x00BBF32C File Offset: 0x00BBD52C
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

		// Token: 0x0602998B RID: 170379 RVA: 0x00BBF428 File Offset: 0x00BBD628
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

		// Token: 0x0602998C RID: 170380 RVA: 0x00BBF4A2 File Offset: 0x00BBD6A2
		private void OnOptionSelected()
		{
			this.AutoSelectOptionComponent.OnOptionSelected();
		}

		// Token: 0x0602998D RID: 170381 RVA: 0x00BBF4B0 File Offset: 0x00BBD6B0
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

		// Token: 0x0602998E RID: 170382 RVA: 0x00BBF508 File Offset: 0x00BBD708
		public void InitInteractOptions()
		{
			if (this.InteractController == null)
			{
				return;
			}
			PlotModel.Instance.OptionEnable = true;
			this.SetOptionsShow(true);
			List<CommonInteractOption> showOptions = this.InteractController.ShowOptions;
			this.OptionLayout.RefreshByData(new List<object>(showOptions), new Action(this.HandleOptionState), false);
		}

		// Token: 0x0602998F RID: 170383 RVA: 0x00BBF55C File Offset: 0x00BBD75C
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

		// Token: 0x06029990 RID: 170384 RVA: 0x00BBF5B0 File Offset: 0x00BBD7B0
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
			this.ClearCurPlayAudio(null);
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

		// Token: 0x06029991 RID: 170385 RVA: 0x00BBF644 File Offset: 0x00BBD844
		static PlotTextCommonLogic()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotTextCommonLogic.CreateStaticDefaultValue), new Action(PlotTextCommonLogic.ResetStaticDefaultValue));
		}

		// Token: 0x06029992 RID: 170386 RVA: 0x00BBF663 File Offset: 0x00BBD863
		public static void CreateStaticDefaultValue()
		{
			PlotTextCommonLogic.CallbackEnableId = 0;
		}

		// Token: 0x06029993 RID: 170387 RVA: 0x00BBF66B File Offset: 0x00BBD86B
		public static void ResetStaticDefaultValue()
		{
			PlotTextCommonLogic.CallbackEnableId = 0;
		}

		// Token: 0x06029994 RID: 170388 RVA: 0x00BBF674 File Offset: 0x00BBD874
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

		// Token: 0x06029995 RID: 170389 RVA: 0x00BBF786 File Offset: 0x00BBD986
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

		// Token: 0x06029996 RID: 170390 RVA: 0x00BBF7C4 File Offset: 0x00BBD9C4
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

		// Token: 0x06029997 RID: 170391 RVA: 0x00BBF920 File Offset: 0x00BBDB20
		private bool PlayTalkAudio()
		{
			if (this.IsAudioEnd)
			{
				return false;
			}
			if (this.CurLang != LanguageSystem.Instance.PackageAudio)
			{
				this.CurLang = LanguageSystem.Instance.PackageAudio;
				this.ClearCurPlayAudio(null);
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
				this.ClearCurPlayAudio(null);
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

		// Token: 0x06029998 RID: 170392 RVA: 0x00BBFB50 File Offset: 0x00BBDD50
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
				this.ClearCurPlayAudio(null);
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
					this.ClearCurPlayAudio(null);
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

		// Token: 0x06029999 RID: 170393 RVA: 0x00BBFCB4 File Offset: 0x00BBDEB4
		public void ClearCurPlayAudio(ExecuteActionArgs? args = null)
		{
			this.RemoveWaitAudioLoadTimer();
			if (this.PlotPlayEventResult == 0)
			{
				this.ResetAudioRemainingTime();
				return;
			}
			PlotTextCommonLogic.CallbackEnableId++;
			AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Stop, new ExecuteActionArgs?(args ?? new ExecuteActionArgs(new int?(100), null, null)));
			this.PlotPlayEventResult = 0;
			this.ResetAudioRemainingTime();
		}

		// Token: 0x0602999A RID: 170394 RVA: 0x00BBFD2F File Offset: 0x00BBDF2F
		private void RemoveWaitAudioLoadTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.WaitAudioLoadTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.WaitAudioLoadTimer);
			}
			this.WaitAudioLoadTimer = null;
		}

		// Token: 0x0602999B RID: 170395 RVA: 0x00BBFD5B File Offset: 0x00BBDF5B
		private void SetAudioRemainingTime(float duration)
		{
			this.AudioDuration = duration;
			this.AudioEndTime = TimeUtil.Instance.GetServerTimeStamp() + (double)duration;
		}

		// Token: 0x0602999C RID: 170396 RVA: 0x00BBFD77 File Offset: 0x00BBDF77
		private void ResetAudioRemainingTime()
		{
			this.AudioDuration = 0f;
			this.AudioEndTime = 0.0;
		}

		// Token: 0x0602999D RID: 170397 RVA: 0x00BBFD94 File Offset: 0x00BBDF94
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

		// Token: 0x0602999E RID: 170398 RVA: 0x00BBFE18 File Offset: 0x00BBE018
		private float GetAutoSelectExtraWaitTime()
		{
			if (this.Parent is PlotView && PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC && this.CurrentContent.PlayVoice.GetValueOrDefault())
			{
				return (float)this.LEVEL_C_PLOT_VIEW_AUTO_SELECT_EXTRA_WAIT_TIME;
			}
			return 0f;
		}

		// Token: 0x0602999F RID: 170399 RVA: 0x00BBFE6C File Offset: 0x00BBE06C
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
				this.ClearCurPlayAudio(null);
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

		// Token: 0x060299A0 RID: 170400 RVA: 0x00BC0058 File Offset: 0x00BBE258
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

		// Token: 0x060299A1 RID: 170401 RVA: 0x00BC0111 File Offset: 0x00BBE311
		[NullableContext(1)]
		public void ResumeSubtitle(ITalkItem config)
		{
			this.IsPause = false;
			this.PlaySubtitle(config);
		}

		// Token: 0x060299A2 RID: 170402 RVA: 0x00BC0121 File Offset: 0x00BBE321
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

		// Token: 0x060299A3 RID: 170403 RVA: 0x00BC0158 File Offset: 0x00BBE358
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

		// Token: 0x060299A4 RID: 170404 RVA: 0x00BC0314 File Offset: 0x00BBE514
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

		// Token: 0x060299A5 RID: 170405 RVA: 0x00BC03FC File Offset: 0x00BBE5FC
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

		// Token: 0x060299A6 RID: 170406 RVA: 0x00BC051C File Offset: 0x00BBE71C
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

		// Token: 0x060299A7 RID: 170407 RVA: 0x00BC0578 File Offset: 0x00BBE778
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

		// Token: 0x060299A8 RID: 170408 RVA: 0x00BC05D0 File Offset: 0x00BBE7D0
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

		// Token: 0x060299A9 RID: 170409 RVA: 0x00BC0634 File Offset: 0x00BBE834
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

		// Token: 0x060299AA RID: 170410 RVA: 0x00BC07E0 File Offset: 0x00BBE9E0
		private void WaitSubtitleAnimationFinish(float duration)
		{
			this.RemoveSubtitleAnimationTimer();
			float interval = Math.Max(duration, 20f);
			this.SubtitleAnimationTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.HandleSubtitleAnimFinished();
			}, interval, null, null, true, 1f);
		}

		// Token: 0x060299AB RID: 170411 RVA: 0x00BC0824 File Offset: 0x00BBEA24
		private void RemoveSubtitleAnimationTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.SubtitleAnimationTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.SubtitleAnimationTimer);
			}
			this.SubtitleAnimationTimer = null;
		}

		// Token: 0x060299AC RID: 170412 RVA: 0x00BC0850 File Offset: 0x00BBEA50
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

		// Token: 0x060299AD RID: 170413 RVA: 0x00BC08A7 File Offset: 0x00BBEAA7
		[NullableContext(1)]
		public void SetPlotContentAnimFinishCallback(Action callback)
		{
			this.PlotContentAnimFinishCallback = callback;
		}

		// Token: 0x060299AE RID: 170414 RVA: 0x00BC08B0 File Offset: 0x00BBEAB0
		[NullableContext(1)]
		public void SetPlotContentUpdateCallback(Action<string> callback)
		{
			this.PlotContentUpdateCallback = callback;
		}

		// Token: 0x060299AF RID: 170415 RVA: 0x00BC08B9 File Offset: 0x00BBEAB9
		[NullableContext(1)]
		public void SetPlotAudioEndCallback(Action<float> callback)
		{
			this.PlotAudioEndCallback = callback;
		}

		// Token: 0x060299B0 RID: 170416 RVA: 0x00BC08C2 File Offset: 0x00BBEAC2
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

		// Token: 0x060299B1 RID: 170417 RVA: 0x00BC0901 File Offset: 0x00BBEB01
		public float GetPlotContentAnimDuration()
		{
			return this.SubtitleAnimation.GetPlayTween().duration;
		}

		// Token: 0x060299B2 RID: 170418 RVA: 0x00BC0914 File Offset: 0x00BBEB14
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

		// Token: 0x060299B3 RID: 170419 RVA: 0x00BC09F4 File Offset: 0x00BBEBF4
		public UniTask DestroyPortraitItem()
		{
			PlotTextCommonLogic.<DestroyPortraitItem>d__122 <DestroyPortraitItem>d__;
			<DestroyPortraitItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DestroyPortraitItem>d__.<>4__this = this;
			<DestroyPortraitItem>d__.<>1__state = -1;
			<DestroyPortraitItem>d__.<>t__builder.Start<PlotTextCommonLogic.<DestroyPortraitItem>d__122>(ref <DestroyPortraitItem>d__);
			return <DestroyPortraitItem>d__.<>t__builder.Task;
		}

		// Token: 0x060299B4 RID: 170420 RVA: 0x00BC0A37 File Offset: 0x00BBEC37
		public void OnTick(float delta)
		{
			this.AutoSelectOptionComponent.OnTick(delta, this.MuteTimeLimitedOption);
		}

		// Token: 0x04016B35 RID: 92981
		private int OPTIONHEIGHT_OFFSET = 265;

		// Token: 0x04016B36 RID: 92982
		private int DEFAULT_AUTO_SCROLL_DELAY_CHAR_NUM = 25;

		// Token: 0x04016B37 RID: 92983
		private int LEVEL_C_PLOT_VIEW_AUTO_SELECT_EXTRA_WAIT_TIME = 3000;

		// Token: 0x04016B38 RID: 92984
		private int BREAK_TIME = 1000;

		// Token: 0x04016B39 RID: 92985
		private int MAX_LOAD_AUDIO_TIME = 3000;

		// Token: 0x04016B3A RID: 92986
		public const int PLAY_FLAG = 8;

		// Token: 0x04016B3B RID: 92987
		public ITalkItem CurrentContent;

		// Token: 0x04016B3C RID: 92988
		[Nullable(1)]
		private string CurLang = "";

		// Token: 0x04016B3D RID: 92989
		private readonly float TextScrollViewPrefabHeight;

		// Token: 0x04016B3E RID: 92990
		private IPostAkEventType LastEndAkEvent;

		// Token: 0x04016B3F RID: 92991
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private readonly GenericLayout<PlotOptionItem, object> OptionLayout;

		// Token: 0x04016B40 RID: 92992
		private PlotOptionItem SelectedPlotOptionItem;

		// Token: 0x04016B41 RID: 92993
		private bool IsOptionShow;

		// Token: 0x04016B42 RID: 92994
		[Nullable(1)]
		public readonly List<PlotOption> CurOption = new List<PlotOption>();

		// Token: 0x04016B43 RID: 92995
		private TimerHandle BlockOptionTimer;

		// Token: 0x04016B44 RID: 92996
		[Nullable(1)]
		private readonly PlotAutoSelectOptionComponent AutoSelectOptionComponent = new PlotAutoSelectOptionComponent();

		// Token: 0x04016B45 RID: 92997
		private float OptionLimitTime;

		// Token: 0x04016B46 RID: 92998
		private float OptionLimitTimeDuration;

		// Token: 0x04016B47 RID: 92999
		private int TimeoutOptionIndex = -1;

		// Token: 0x04016B48 RID: 93000
		private bool HasTimeLimitedOption;

		// Token: 0x04016B49 RID: 93001
		public bool MuteTimeLimitedOption;

		// Token: 0x04016B4A RID: 93002
		private readonly bool NeedSelectedState;

		// Token: 0x04016B4B RID: 93003
		[Nullable(1)]
		protected readonly UUIItem PlotItem;

		// Token: 0x04016B4C RID: 93004
		[Nullable(1)]
		protected readonly UUIText NpcName;

		// Token: 0x04016B4D RID: 93005
		[Nullable(1)]
		protected readonly UUIText NpcTitle;

		// Token: 0x04016B4E RID: 93006
		[Nullable(1)]
		protected readonly UUIText PlotContent;

		// Token: 0x04016B4F RID: 93007
		[Nullable(1)]
		protected readonly UUIItem LineItem;

		// Token: 0x04016B50 RID: 93008
		protected readonly UUIScrollViewComponent TextScrollView;

		// Token: 0x04016B51 RID: 93009
		protected readonly ISimulatePlot Parent;

		// Token: 0x04016B52 RID: 93010
		protected readonly UUILayoutBase LayOutBase;

		// Token: 0x04016B53 RID: 93011
		protected readonly UUIItem OptionItemBase;

		// Token: 0x04016B54 RID: 93012
		protected readonly UUISliderComponent OptionLimitBar;

		// Token: 0x04016B55 RID: 93013
		protected readonly UUISliderComponent AutoSelectTimeBar;

		// Token: 0x04016B56 RID: 93014
		protected readonly UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x04016B57 RID: 93015
		protected readonly UUIItem BlockOption;

		// Token: 0x04016B58 RID: 93016
		protected readonly UUIItem OptionAdjustItem;

		// Token: 0x04016B59 RID: 93017
		protected readonly UUIItem PnlLayoutTwo;

		// Token: 0x04016B5A RID: 93018
		private readonly ULGUIPlayTweenComponent SubtitleAnimation;

		// Token: 0x04016B5B RID: 93019
		private readonly UUIEffectTextAnimation SubtitleAnimDataComp;

		// Token: 0x04016B5C RID: 93020
		public float? PlayDelayTime;

		// Token: 0x04016B5D RID: 93021
		private TimerHandle WaitAudioLoadTimer;

		// Token: 0x04016B5E RID: 93022
		private int PlotPlayEventResult;

		// Token: 0x04016B5F RID: 93023
		private float AudioDuration;

		// Token: 0x04016B60 RID: 93024
		private double AudioEndTime;

		// Token: 0x04016B61 RID: 93025
		private static int CallbackEnableId;

		// Token: 0x04016B62 RID: 93026
		private Action<float> PlotAudioEndCallback;

		// Token: 0x04016B63 RID: 93027
		private Speaker? Talker;

		// Token: 0x04016B64 RID: 93028
		private float AnimOffset = 1f;

		// Token: 0x04016B65 RID: 93029
		private bool IsPause;

		// Token: 0x04016B66 RID: 93030
		private bool IsSubmit;

		// Token: 0x04016B67 RID: 93031
		private bool IsAudioEnd;

		// Token: 0x04016B68 RID: 93032
		private TimerHandle ScrollStartTimer;

		// Token: 0x04016B69 RID: 93033
		private float ScrollTotalTime;

		// Token: 0x04016B6A RID: 93034
		private float CurrentAnimTime;

		// Token: 0x04016B6B RID: 93035
		private TimerHandle TextScrollAnimTimer;

		// Token: 0x04016B6C RID: 93036
		private TimerHandle DelayTextScrollAnimTimer;

		// Token: 0x04016B6D RID: 93037
		public TimerHandle SubtitleAnimationTimer;

		// Token: 0x04016B6E RID: 93038
		public bool IsInteraction;

		// Token: 0x04016B6F RID: 93039
		public bool IsTextAnimPlaying;

		// Token: 0x04016B70 RID: 93040
		private Action PlotContentAnimFinishCallback;

		// Token: 0x04016B71 RID: 93041
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string> PlotContentUpdateCallback;

		// Token: 0x04016B72 RID: 93042
		private PlotPortraitItem PortraitItem;
	}
}
