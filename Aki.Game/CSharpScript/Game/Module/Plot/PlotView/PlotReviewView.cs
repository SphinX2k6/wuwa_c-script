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
	// Token: 0x0200402F RID: 16431
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotReviewView : UiViewBase
	{
		// Token: 0x06029953 RID: 170323 RVA: 0x00BBE1ED File Offset: 0x00BBC3ED
		[NullableContext(1)]
		public PlotReviewView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06029954 RID: 170324 RVA: 0x00BBE200 File Offset: 0x00BBC400
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

		// Token: 0x06029955 RID: 170325 RVA: 0x00BBE28C File Offset: 0x00BBC48C
		protected override UniTask OnBeforeStartAsync()
		{
			PlotReviewView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PlotReviewView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029956 RID: 170326 RVA: 0x00BBE2CF File Offset: 0x00BBC4CF
		private void ScrollToBottom(float _)
		{
			if (this.HasScrollToBottom)
			{
				return;
			}
			this.HasScrollToBottom = true;
			base.GetUIDynScrollViewComponent(1).SetScrollProgress(1f);
		}

		// Token: 0x06029957 RID: 170327 RVA: 0x00BBE2F2 File Offset: 0x00BBC4F2
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06029958 RID: 170328 RVA: 0x00BBE2FB File Offset: 0x00BBC4FB
		[NullableContext(1)]
		private PlotReviewDynamicScrollItem CreatePlotReviewItem(PlotReviewItemData data, UUIItem uiItem, int index)
		{
			PlotReviewDynamicScrollItem plotReviewDynamicScrollItem = new PlotReviewDynamicScrollItem();
			plotReviewDynamicScrollItem.SetTalkItemToggleClickCallBack(new Action<int>(this.OnTalkItemToggleClick));
			plotReviewDynamicScrollItem.SetTalkItemCanToggleChangeCallBack(new Func<int, bool>(this.CanTalkItemToggleChange));
			return plotReviewDynamicScrollItem;
		}

		// Token: 0x06029959 RID: 170329 RVA: 0x00BBE326 File Offset: 0x00BBC526
		private void OnTalkItemToggleClick(int index)
		{
			this.PlayPlotAudioByIndex(index);
		}

		// Token: 0x0602995A RID: 170330 RVA: 0x00BBE32F File Offset: 0x00BBC52F
		private bool CanTalkItemToggleChange(int index)
		{
			return this.CheckCanPlayPlotAudio(index);
		}

		// Token: 0x0602995B RID: 170331 RVA: 0x00BBE338 File Offset: 0x00BBC538
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

		// Token: 0x0602995C RID: 170332 RVA: 0x00BBE3D4 File Offset: 0x00BBC5D4
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

		// Token: 0x0602995D RID: 170333 RVA: 0x00BBE4E0 File Offset: 0x00BBC6E0
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

		// Token: 0x0602995E RID: 170334 RVA: 0x00BBE528 File Offset: 0x00BBC728
		private void OnAudioEnd()
		{
			if (this.CurrentPlayAudioIndex >= 0)
			{
				this.UpdateTalkItemPlayingState(this.CurrentPlayAudioIndex, false);
			}
			this.PlotPlayEventResult = 0;
			this.CurrentPlayAudioIndex = -1;
		}

		// Token: 0x0602995F RID: 170335 RVA: 0x00BBE54E File Offset: 0x00BBC74E
		public bool IsPlayingAudio()
		{
			return this.PlotPlayEventResult != 0;
		}

		// Token: 0x06029960 RID: 170336 RVA: 0x00BBE55C File Offset: 0x00BBC75C
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

		// Token: 0x06029961 RID: 170337 RVA: 0x00BBE5B0 File Offset: 0x00BBC7B0
		protected override void OnBeforeHide()
		{
			this.ClearCurPlayAudio();
		}

		// Token: 0x04016B1C RID: 92956
		private PlotReviewViewData Data;

		// Token: 0x04016B1D RID: 92957
		private PopupCaptionItem CaptionItem;

		// Token: 0x04016B1E RID: 92958
		private PlotReviewDynamicScrollBaseItem PlotReviewDynamicScrollBaseItem;

		// Token: 0x04016B1F RID: 92959
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		protected DynamicScrollView<PlotReviewDynamicScrollItem, PlotReviewDynamicScrollBaseItem, PlotReviewItemData> PlotReviewDynamicScrollView;

		// Token: 0x04016B20 RID: 92960
		private int CurrentPlayAudioIndex = -1;

		// Token: 0x04016B21 RID: 92961
		private int PlotPlayEventResult;

		// Token: 0x04016B22 RID: 92962
		private bool HasScrollToBottom;

		// Token: 0x02009BFE RID: 39934
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x040308E3 RID: 198883
			public const int CaptionItem = 0;

			// Token: 0x040308E4 RID: 198884
			public const int PlotReviewDynamicScrollView = 1;

			// Token: 0x040308E5 RID: 198885
			public const int PlotReviewItem = 2;
		}
	}
}
