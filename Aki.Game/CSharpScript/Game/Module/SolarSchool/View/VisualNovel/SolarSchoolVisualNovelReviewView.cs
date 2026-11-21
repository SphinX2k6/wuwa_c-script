using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Dialogue;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool.View.VisualNovel
{
	// Token: 0x02005A7B RID: 23163
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelReviewView : UiViewBase
	{
		// Token: 0x06039180 RID: 233856 RVA: 0x00FFDC32 File Offset: 0x00FFBE32
		public SolarSchoolVisualNovelReviewView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039181 RID: 233857 RVA: 0x00FFDC58 File Offset: 0x00FFBE58
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIDynScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039182 RID: 233858 RVA: 0x00FFDCE4 File Offset: 0x00FFBEE4
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolVisualNovelReviewView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelReviewView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039183 RID: 233859 RVA: 0x00FFDD27 File Offset: 0x00FFBF27
		protected override void OnBeforeHide()
		{
			this.StopCurrentAudio();
			if (this.ResumeOnClose)
			{
				VisualNovelContext context = this.Context;
				if (context != null)
				{
					context.Player.Resume();
				}
			}
			this.ResumeOnClose = false;
		}

		// Token: 0x06039184 RID: 233860 RVA: 0x00FFDD54 File Offset: 0x00FFBF54
		protected override void OnBeforeDestroy()
		{
			this.Context = null;
			this.CaptionItem = null;
			this.DynamicScrollView = null;
			this.ReviewItems = new List<PlotReviewItemData>();
		}

		// Token: 0x06039185 RID: 233861 RVA: 0x00FFDD78 File Offset: 0x00FFBF78
		private static List<PlotReviewItemData> CreateReviewItems(VisualNovelContext context)
		{
			List<PlotReviewItemData> list = new List<PlotReviewItemData>();
			IReadOnlyList<DialogueChoice> choiceHistory = context.Script.GetChoiceHistory();
			IReadOnlyList<DialogueItem> dialogueHistory = context.Script.GetDialogueHistory();
			int num = 0;
			foreach (DialogueItem dialogueItem in dialogueHistory)
			{
				SolarSchoolVisualNovelReviewView.AddTalkItem(list, dialogueItem.Config);
				if (num < choiceHistory.Count && choiceHistory[num].Item.Id == dialogueItem.Id)
				{
					VisualNovelItem item = context.GetItem(dialogueItem);
					bool flag;
					if (item == null)
					{
						flag = true;
					}
					else
					{
						EVisualNovelOptionInteractionType? optionInteractionType = item.OptionInteractionType;
						EVisualNovelOptionInteractionType evisualNovelOptionInteractionType = EVisualNovelOptionInteractionType.HideAndAutoSelect;
						flag = !(optionInteractionType.GetValueOrDefault() == evisualNovelOptionInteractionType & optionInteractionType != null);
					}
					if (flag)
					{
						SolarSchoolVisualNovelReviewView.AddOptionItem(list, choiceHistory[num]);
					}
					num++;
				}
			}
			DialogueItem currentItem = context.Script.GetCurrentItem();
			if (currentItem != null)
			{
				if (dialogueHistory.Count != 0)
				{
					IReadOnlyList<DialogueItem> readOnlyList = dialogueHistory;
					if (readOnlyList[readOnlyList.Count - 1] == currentItem)
					{
						return list;
					}
				}
				SolarSchoolVisualNovelReviewView.AddTalkItem(list, currentItem.Config);
			}
			return list;
		}

		// Token: 0x06039186 RID: 233862 RVA: 0x00FFDE94 File Offset: 0x00FFC094
		private static void AddTalkItem(List<PlotReviewItemData> items, ITalkItem talkItem)
		{
			if (talkItem is ITalkItemVisualNovelNoTextItem || string.IsNullOrEmpty(talkItem.TidTalk))
			{
				return;
			}
			items.Add(new PlotReviewItemData
			{
				Type = EPlotReviewItemType.Talk,
				Data = new PlotReviewTalkItemData
				{
					TalkItem = talkItem,
					ShowSpeakerName = (talkItem is ITalkItemVisualNovelTalk)
				}
			});
		}

		// Token: 0x06039187 RID: 233863 RVA: 0x00FFDEEC File Offset: 0x00FFC0EC
		private static void AddOptionItem(List<PlotReviewItemData> items, DialogueChoice choice)
		{
			items.Add(new PlotReviewItemData
			{
				Type = EPlotReviewItemType.Option,
				Data = new PlotReviewOptionItemData
				{
					TalkItem = choice.Item.Config,
					OptionIndex = choice.Option.Index
				}
			});
		}

		// Token: 0x06039188 RID: 233864 RVA: 0x00FFDF3A File Offset: 0x00FFC13A
		private PlotReviewDynamicScrollItem CreateReviewItem(PlotReviewItemData _, UUIItem __, int ___)
		{
			PlotReviewDynamicScrollItem plotReviewDynamicScrollItem = new PlotReviewDynamicScrollItem();
			plotReviewDynamicScrollItem.SetTalkItemToggleClickCallBack(new Action<int>(this.PlayAudio));
			plotReviewDynamicScrollItem.SetTalkItemCanToggleChangeCallBack(new Func<int, bool>(this.CanPlayAudio));
			return plotReviewDynamicScrollItem;
		}

		// Token: 0x06039189 RID: 233865 RVA: 0x00FFDF65 File Offset: 0x00FFC165
		private void ScrollToBottom(float _)
		{
			if (this.HasScrolledToBottom)
			{
				return;
			}
			this.HasScrolledToBottom = true;
			base.GetUIDynScrollViewComponent(1).SetScrollProgress(1f);
		}

		// Token: 0x0603918A RID: 233866 RVA: 0x00FFDF88 File Offset: 0x00FFC188
		private bool CanPlayAudio(int index)
		{
			if (index < 0 || index >= this.ReviewItems.Count || this.ReviewItems[index].Type != EPlotReviewItemType.Talk)
			{
				return false;
			}
			ITalkItem talkItem = ((PlotReviewTalkItemData)this.ReviewItems[index].Data).TalkItem;
			return talkItem.PlayVoice.GetValueOrDefault() && !string.IsNullOrEmpty(talkItem.TidTalk) && ConfigPlotAudioById.GetConfig(talkItem.TidTalk, true) != null;
		}

		// Token: 0x0603918B RID: 233867 RVA: 0x00FFE00C File Offset: 0x00FFC20C
		private void PlayAudio(int index)
		{
			if (!this.CanPlayAudio(index))
			{
				return;
			}
			if (this.CurrentAudioIndex == index)
			{
				this.StopCurrentAudio();
				return;
			}
			this.StopCurrentAudio();
			PlotAudio value = ConfigPlotAudioById.GetConfig(((PlotReviewTalkItemData)this.ReviewItems[index].Data).TalkItem.TidTalk, true).Value;
			string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(value);
			this.CurrentAudioIndex = index;
			this.SetAudioPlaying(index, true);
			this.AudioHandle = AudioSystem.Instance.PostEvent("play_vo_plot_review_log", null, new PostEventArgs?(new PostEventArgs
			{
				ExternalSourceName = "external_plot_review_log_voice",
				ExternalSourceMediaName = externalSourcesMediaName,
				CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo _)
				{
					if (callbackType == EAkCallbackType.EndOfEvent && this.CurrentAudioIndex == index)
					{
						this.OnAudioEnded();
					}
				}
			}));
		}

		// Token: 0x0603918C RID: 233868 RVA: 0x00FFE10C File Offset: 0x00FFC30C
		private void StopCurrentAudio()
		{
			if (this.AudioHandle == 0)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(this.AudioHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
			this.OnAudioEnded();
		}

		// Token: 0x0603918D RID: 233869 RVA: 0x00FFE154 File Offset: 0x00FFC354
		private void OnAudioEnded()
		{
			if (this.CurrentAudioIndex >= 0)
			{
				this.SetAudioPlaying(this.CurrentAudioIndex, false);
			}
			this.AudioHandle = 0;
			this.CurrentAudioIndex = -1;
		}

		// Token: 0x0603918E RID: 233870 RVA: 0x00FFE17C File Offset: 0x00FFC37C
		private void SetAudioPlaying(int index, bool playing)
		{
			((PlotReviewTalkItemData)this.ReviewItems[index].Data).IsPlaying = playing;
			DynamicScrollView<PlotReviewDynamicScrollItem, PlotReviewDynamicScrollBaseItem, PlotReviewItemData> dynamicScrollView = this.DynamicScrollView;
			PlotReviewDynamicScrollItem plotReviewDynamicScrollItem = (dynamicScrollView != null) ? dynamicScrollView.GetScrollItemFromIndex(index) : null;
			if (plotReviewDynamicScrollItem == null)
			{
				return;
			}
			plotReviewDynamicScrollItem.SetTalkItemToggleState(playing ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
		}

		// Token: 0x0401E0A7 RID: 123047
		private readonly PlotReviewDynamicScrollBaseItem DynamicScrollBaseItem = new PlotReviewDynamicScrollBaseItem();

		// Token: 0x0401E0A8 RID: 123048
		[Nullable(2)]
		private VisualNovelContext Context;

		// Token: 0x0401E0A9 RID: 123049
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401E0AA RID: 123050
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<PlotReviewDynamicScrollItem, PlotReviewDynamicScrollBaseItem, PlotReviewItemData> DynamicScrollView;

		// Token: 0x0401E0AB RID: 123051
		private List<PlotReviewItemData> ReviewItems = new List<PlotReviewItemData>();

		// Token: 0x0401E0AC RID: 123052
		private int CurrentAudioIndex = -1;

		// Token: 0x0401E0AD RID: 123053
		private int AudioHandle;

		// Token: 0x0401E0AE RID: 123054
		private bool ResumeOnClose;

		// Token: 0x0401E0AF RID: 123055
		private bool HasScrolledToBottom;

		// Token: 0x0200B697 RID: 46743
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040387E7 RID: 231399
			public const int CaptionItem = 0;

			// Token: 0x040387E8 RID: 231400
			public const int DynamicScrollView = 1;

			// Token: 0x040387E9 RID: 231401
			public const int ReviewItem = 2;
		}
	}
}
