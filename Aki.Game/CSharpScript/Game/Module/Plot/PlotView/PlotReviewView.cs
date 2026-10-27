using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200505F RID: 20575
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotReviewView : UiViewBase
	{
		// Token: 0x06034A60 RID: 215648 RVA: 0x00C70F15 File Offset: 0x00C6F115
		[NullableContext(1)]
		public PlotReviewView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034A61 RID: 215649 RVA: 0x00C70F28 File Offset: 0x00C6F128
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

		// Token: 0x06034A62 RID: 215650 RVA: 0x00C70FB4 File Offset: 0x00C6F1B4
		protected override UniTask OnBeforeStartAsync()
		{
			PlotReviewView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PlotReviewView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A63 RID: 215651 RVA: 0x00C70FF7 File Offset: 0x00C6F1F7
		private void ScrollToBottom(float _)
		{
			if (this.HasScrollToBottom)
			{
				return;
			}
			this.HasScrollToBottom = true;
			base.GetUIDynScrollViewComponent(1).SetScrollProgress(1f);
		}

		// Token: 0x06034A64 RID: 215652 RVA: 0x00C7101A File Offset: 0x00C6F21A
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06034A65 RID: 215653 RVA: 0x00C71023 File Offset: 0x00C6F223
		[NullableContext(1)]
		private PlotReviewDynamicScrollItem CreatePlotReviewItem(PlotReviewItemData data, UUIItem uiItem, int index)
		{
			PlotReviewDynamicScrollItem plotReviewDynamicScrollItem = new PlotReviewDynamicScrollItem();
			plotReviewDynamicScrollItem.SetTalkItemToggleClickCallBack(new Action<int>(this.OnTalkItemToggleClick));
			plotReviewDynamicScrollItem.SetTalkItemCanToggleChangeCallBack(new Func<int, bool>(this.CanTalkItemToggleChange));
			return plotReviewDynamicScrollItem;
		}

		// Token: 0x06034A66 RID: 215654 RVA: 0x00C7104E File Offset: 0x00C6F24E
		private void OnTalkItemToggleClick(int index)
		{
			this.PlayPlotAudioByIndex(index);
		}

		// Token: 0x06034A67 RID: 215655 RVA: 0x00C71057 File Offset: 0x00C6F257
		private bool CanTalkItemToggleChange(int index)
		{
			return this.CheckCanPlayPlotAudio(index);
		}

		// Token: 0x06034A68 RID: 215656 RVA: 0x00C71060 File Offset: 0x00C6F260
		private bool CheckCanPlayPlotAudio(int index)
		{
			if (this.Data == null)
			{
				return false;
			}
			int count = this.Data.PlotReviewItemDataList.Count;
			if (index < 0 || index >= count)
			{
				return false;
			}
			PlotReviewItemData plotReviewItemData = this.Data.PlotReviewItemDataList[index];
			if (plotReviewItemData.Type == EPlotReviewItemType.Option)
			{
				return false;
			}
			ITalkItem talkItem = ((PlotReviewTalkItemData)plotReviewItemData.Data).TalkItem;
			string text = talkItem.PlayVoice.GetValueOrDefault() ? talkItem.TidTalk : null;
			return !string.IsNullOrEmpty(text) && ConfigPlotAudioById.GetConfig(text, true) != null;
		}

		// Token: 0x06034A69 RID: 215657 RVA: 0x00C710FC File Offset: 0x00C6F2FC
		private void PlayPlotAudioByIndex(int index)
		{
			if (!this.CheckCanPlayPlotAudio(index))
			{
				return;
			}
			PlotAudio value = ConfigPlotAudioById.GetConfig(((PlotReviewTalkItemData)this.Data.PlotReviewItemDataList[index].Data).TalkItem.TidTalk, true).Value;
			if (this.CurrentPlayAudioIndex == index)
			{
				this.ClearCurPlayAudio();
				return;
			}
			if (this.CurrentPlayAudioIndex >= 0)
			{
				this.ClearCurPlayAudio();
			}
			string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(value);
			this.CurrentPlayAudioIndex = index;
			this.UpdateTalkItemPlayingState(index, true);
			this.PlotPlayEventResult = AudioSystem.Instance.PostEvent("play_vo_plot_review_log", null, new PostEventArgs?(new PostEventArgs
			{
				ExternalSourceName = "external_plot_review_log_voice",
				ExternalSourceMediaName = externalSourcesMediaName,
				CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					if (callbackType == EAkCallbackType.EndOfEvent && index == this.CurrentPlayAudioIndex)
					{
						this.OnAudioEnd();
					}
				}
			}));
		}

		// Token: 0x06034A6A RID: 215658 RVA: 0x00C71208 File Offset: 0x00C6F408
		public void ClearCurPlayAudio()
		{
			if (this.PlotPlayEventResult == 0)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
			this.OnAudioEnd();
		}

		// Token: 0x06034A6B RID: 215659 RVA: 0x00C71250 File Offset: 0x00C6F450
		private void OnAudioEnd()
		{
			if (this.CurrentPlayAudioIndex >= 0)
			{
				this.UpdateTalkItemPlayingState(this.CurrentPlayAudioIndex, false);
			}
			this.PlotPlayEventResult = 0;
			this.CurrentPlayAudioIndex = -1;
		}

		// Token: 0x06034A6C RID: 215660 RVA: 0x00C71276 File Offset: 0x00C6F476
		public bool IsPlayingAudio()
		{
			return this.PlotPlayEventResult != 0;
		}

		// Token: 0x06034A6D RID: 215661 RVA: 0x00C71284 File Offset: 0x00C6F484
		private void UpdateTalkItemPlayingState(int index, bool isPlaying)
		{
			((PlotReviewTalkItemData)this.Data.PlotReviewItemDataList[index].Data).IsPlaying = isPlaying;
			DynamicScrollView<PlotReviewDynamicScrollItem, PlotReviewDynamicScrollBaseItem, PlotReviewItemData> plotReviewDynamicScrollView = this.PlotReviewDynamicScrollView;
			PlotReviewDynamicScrollItem plotReviewDynamicScrollItem = (plotReviewDynamicScrollView != null) ? plotReviewDynamicScrollView.GetScrollItemFromIndex(index) : null;
			if (plotReviewDynamicScrollItem != null)
			{
				EToggleState talkItemToggleState = isPlaying ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
				plotReviewDynamicScrollItem.SetTalkItemToggleState(talkItemToggleState);
			}
		}

		// Token: 0x06034A6E RID: 215662 RVA: 0x00C712D8 File Offset: 0x00C6F4D8
		protected override void OnBeforeHide()
		{
			this.ClearCurPlayAudio();
		}

		// Token: 0x0401C0F1 RID: 114929
		private PlotReviewViewData Data;

		// Token: 0x0401C0F2 RID: 114930
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C0F3 RID: 114931
		private PlotReviewDynamicScrollBaseItem PlotReviewDynamicScrollBaseItem;

		// Token: 0x0401C0F4 RID: 114932
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		protected DynamicScrollView<PlotReviewDynamicScrollItem, PlotReviewDynamicScrollBaseItem, PlotReviewItemData> PlotReviewDynamicScrollView;

		// Token: 0x0401C0F5 RID: 114933
		private int CurrentPlayAudioIndex = -1;

		// Token: 0x0401C0F6 RID: 114934
		private int PlotPlayEventResult;

		// Token: 0x0401C0F7 RID: 114935
		private bool HasScrollToBottom;

		// Token: 0x0200B1C4 RID: 45508
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x04035E8E RID: 220814
			public const int CaptionItem = 0;

			// Token: 0x04035E8F RID: 220815
			public const int PlotReviewDynamicScrollView = 1;

			// Token: 0x04035E90 RID: 220816
			public const int PlotReviewItem = 2;
		}
	}
}
