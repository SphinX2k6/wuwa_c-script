using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005917 RID: 22807
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolLetterView : SolarSchoolHideHudViewBase
	{
		// Token: 0x06038398 RID: 230296 RVA: 0x00FB805C File Offset: 0x00FB625C
		public SolarSchoolLetterView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038399 RID: 230297 RVA: 0x00FB808C File Offset: 0x00FB628C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnSolarSchoolContiuneClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnBtnSkipClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603839A RID: 230298 RVA: 0x00FB821C File Offset: 0x00FB641C
		public void ShowPage(int pageNumber, int totalPageCount, bool isLastPage, IReadOnlyList<string> paragraphIds)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SolarSchool_ShuXinnum", new int[]
			{
				pageNumber,
				totalPageCount
			});
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			if (this.HasShownPage)
			{
				base.PlaySequence("Switch", null, false);
			}
			this.HasShownPage = true;
			this.CurrentPageNumber = pageNumber;
			this.IsLastPage = isLastPage;
			this.PageParagraphIds = paragraphIds;
			this.SetContinueButtonVisible(false);
			this.SetSkipButtonMode(SolarSchoolLetterView.ESkipButtonMode.Skip);
			this.SetScrollLocked(true);
			this.PendingScrollToEnd = false;
			this.FocusParagraphIndex = -1;
			this.DisplayedParagraphs.Clear();
			this.AppendNextParagraph();
		}

		// Token: 0x0603839B RID: 230299 RVA: 0x00FB82C6 File Offset: 0x00FB64C6
		private void PlayOpening(ELetterAnimType animType)
		{
			this.AnimType = animType;
			this.ShowContent(animType != ELetterAnimType.NewOpen);
		}

		// Token: 0x0603839C RID: 230300 RVA: 0x00FB82DC File Offset: 0x00FB64DC
		protected override void OnAfterPlayStartSequence()
		{
			if (this.AnimType == ELetterAnimType.NewOpen)
			{
				this.SetSkipButtonMode(SolarSchoolLetterView.ESkipButtonMode.Open);
				return;
			}
			ISolarSchoolLetterViewHandler handler = this.Handler;
			if (handler == null)
			{
				return;
			}
			handler.OnOpeningFinished();
		}

		// Token: 0x0603839D RID: 230301 RVA: 0x00FB82FF File Offset: 0x00FB64FF
		private void PlayOpenLetter()
		{
			this.SetSkipButtonMode(SolarSchoolLetterView.ESkipButtonMode.None);
			base.PlaySequence("Open", delegate
			{
				ISolarSchoolLetterViewHandler handler = this.Handler;
				if (handler == null)
				{
					return;
				}
				handler.OnOpeningFinished();
			}, true);
		}

		// Token: 0x0603839E RID: 230302 RVA: 0x00FB8320 File Offset: 0x00FB6520
		private void ShowContent(bool showContent)
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(!showContent);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(showContent);
		}

		// Token: 0x0603839F RID: 230303 RVA: 0x00FB834C File Offset: 0x00FB654C
		private void AppendNextParagraph()
		{
			if (this.DisplayedParagraphs.Count >= this.PageParagraphIds.Count)
			{
				if (this.DisplayedParagraphs.Count == 0)
				{
					GenericLayout<SolarSchoolLetterParagraphItem, SolarSchoolLetterParagraphData> paragraphLayout = this.ParagraphLayout;
					if (paragraphLayout != null)
					{
						paragraphLayout.RefreshByData(this.DisplayedParagraphs, delegate
						{
							UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = this.GetScrollViewWithScrollbar(7);
							if (scrollViewWithScrollbar == null)
							{
								return;
							}
							scrollViewWithScrollbar.SetScrollProgress(0f);
						}, false);
					}
				}
				this.OnPageTypingFinished();
				return;
			}
			int paragraphIndex = this.DisplayedParagraphs.Count;
			this.DisplayedParagraphs.Add(new SolarSchoolLetterParagraphData
			{
				PageNumber = this.CurrentPageNumber,
				ParagraphIndex = paragraphIndex,
				TextId = this.PageParagraphIds[paragraphIndex]
			});
			GenericLayout<SolarSchoolLetterParagraphItem, SolarSchoolLetterParagraphData> paragraphLayout2 = this.ParagraphLayout;
			if (paragraphLayout2 == null)
			{
				return;
			}
			paragraphLayout2.RefreshByData(this.DisplayedParagraphs, delegate
			{
				this.OnParagraphRefreshed(paragraphIndex);
			}, false);
		}

		// Token: 0x060383A0 RID: 230304 RVA: 0x00FB8430 File Offset: 0x00FB6630
		private void OnParagraphRefreshed(int paragraphIndex)
		{
			if (paragraphIndex != this.DisplayedParagraphs.Count - 1)
			{
				return;
			}
			this.FocusParagraphIndex = paragraphIndex;
			this.IsFocusLayoutReady = false;
		}

		// Token: 0x060383A1 RID: 230305 RVA: 0x00FB8451 File Offset: 0x00FB6651
		private void OnPageTypingFinished()
		{
			this.PendingScrollToEnd = true;
			SolarSchoolContinueButtonItem continueButton = this.ContinueButton;
			if (continueButton != null)
			{
				continueButton.SetDone(this.IsLastPage);
			}
			this.SetSkipButtonMode(SolarSchoolLetterView.ESkipButtonMode.None);
			this.SetContinueButtonVisible(true);
			ISolarSchoolLetterViewHandler handler = this.Handler;
			if (handler == null)
			{
				return;
			}
			handler.OnPageTypingFinished();
		}

		// Token: 0x060383A2 RID: 230306 RVA: 0x00FB848F File Offset: 0x00FB668F
		private void SetContinueButtonVisible(bool visible)
		{
			this.ContinueInteractable = visible;
			if (visible)
			{
				SolarSchoolContinueButtonItem continueButton = this.ContinueButton;
				if (continueButton == null)
				{
					return;
				}
				continueButton.PlayShow(true);
				return;
			}
			else
			{
				SolarSchoolContinueButtonItem continueButton2 = this.ContinueButton;
				if (continueButton2 == null)
				{
					return;
				}
				continueButton2.PlayHide(true);
				return;
			}
		}

		// Token: 0x060383A3 RID: 230307 RVA: 0x00FB84C0 File Offset: 0x00FB66C0
		private void SetSkipButtonMode(SolarSchoolLetterView.ESkipButtonMode mode)
		{
			this.SkipButtonMode = mode;
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(mode > SolarSchoolLetterView.ESkipButtonMode.None);
		}

		// Token: 0x060383A4 RID: 230308 RVA: 0x00FB84FC File Offset: 0x00FB66FC
		private void SetScrollLocked(bool locked)
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(7);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			if (locked)
			{
				scrollViewWithScrollbar.StopMovement();
			}
			scrollViewWithScrollbar.SetCanScroll(!locked);
			scrollViewWithScrollbar.SetRayCastTargetForScrollView(!locked);
		}

		// Token: 0x060383A5 RID: 230309 RVA: 0x00FB8532 File Offset: 0x00FB6732
		private void OnScrollLateUpdate(float _)
		{
			if (this.PendingScrollToEnd)
			{
				this.PendingScrollToEnd = false;
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(7);
				if (scrollViewWithScrollbar != null)
				{
					scrollViewWithScrollbar.ScrollToEnd();
				}
				this.SetScrollLocked(false);
				return;
			}
			if (this.FocusParagraphIndex >= 0)
			{
				this.FocusParagraphAndPlay();
			}
		}

		// Token: 0x060383A6 RID: 230310 RVA: 0x00FB856C File Offset: 0x00FB676C
		private void FocusParagraphAndPlay()
		{
			if (!this.IsFocusLayoutReady)
			{
				this.IsFocusLayoutReady = true;
				return;
			}
			int focusParagraphIndex = this.FocusParagraphIndex;
			this.FocusParagraphIndex = -1;
			UUIItem uuiitem;
			if (focusParagraphIndex <= 0)
			{
				uuiitem = null;
			}
			else
			{
				GenericLayout<SolarSchoolLetterParagraphItem, SolarSchoolLetterParagraphData> paragraphLayout = this.ParagraphLayout;
				uuiitem = ((paragraphLayout != null) ? paragraphLayout.GetItemByIndex(focusParagraphIndex) : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 != null)
			{
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(7);
				if (scrollViewWithScrollbar != null)
				{
					scrollViewWithScrollbar.ScrollTo(uuiitem2, true);
				}
			}
			GenericLayout<SolarSchoolLetterParagraphItem, SolarSchoolLetterParagraphData> paragraphLayout2 = this.ParagraphLayout;
			if (paragraphLayout2 == null)
			{
				return;
			}
			SolarSchoolLetterParagraphItem layoutItemByIndex = paragraphLayout2.GetLayoutItemByIndex(focusParagraphIndex);
			if (layoutItemByIndex == null)
			{
				return;
			}
			layoutItemByIndex.Play();
		}

		// Token: 0x060383A7 RID: 230311 RVA: 0x00FB85E4 File Offset: 0x00FB67E4
		private void OnBtnSolarSchoolContiuneClick()
		{
			if (!this.ContinueInteractable)
			{
				return;
			}
			this.SetContinueButtonVisible(false);
			ISolarSchoolLetterViewHandler handler = this.Handler;
			if (handler == null)
			{
				return;
			}
			handler.OnContinueClicked();
		}

		// Token: 0x060383A8 RID: 230312 RVA: 0x00FB8608 File Offset: 0x00FB6808
		private void OnBtnSkipClick()
		{
			SolarSchoolLetterView.ESkipButtonMode skipButtonMode = this.SkipButtonMode;
			if (skipButtonMode == SolarSchoolLetterView.ESkipButtonMode.Open)
			{
				this.PlayOpenLetter();
				return;
			}
			if (skipButtonMode != SolarSchoolLetterView.ESkipButtonMode.Skip)
			{
				return;
			}
			GenericLayout<SolarSchoolLetterParagraphItem, SolarSchoolLetterParagraphData> paragraphLayout = this.ParagraphLayout;
			if (paragraphLayout == null)
			{
				return;
			}
			SolarSchoolLetterParagraphItem layoutItemByIndex = paragraphLayout.GetLayoutItemByIndex(this.DisplayedParagraphs.Count - 1);
			if (layoutItemByIndex == null)
			{
				return;
			}
			layoutItemByIndex.SkipToEnd();
		}

		// Token: 0x060383A9 RID: 230313 RVA: 0x00FB8654 File Offset: 0x00FB6854
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolLetterView.<OnBeforeStartAsync>d__33 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolLetterView.<OnBeforeStartAsync>d__33>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060383AA RID: 230314 RVA: 0x00FB8698 File Offset: 0x00FB6898
		protected override void OnStart()
		{
			this.SetSkipButtonMode(SolarSchoolLetterView.ESkipButtonMode.None);
			this.SetScrollLocked(true);
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(7);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.OnLateUpdate.Bind(new Action<float>(this.OnScrollLateUpdate));
			}
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			ISolarSchoolLetterViewHandler solarSchoolLetterViewHandler = this.OpenParam as ISolarSchoolLetterViewHandler;
			if (solarSchoolLetterViewHandler == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.YYZ, "[SolarSchool][Letter] 书信界面打开参数缺失", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Handler = solarSchoolLetterViewHandler;
			this.Handler.OnViewReady(this);
			this.PlayOpening(solarSchoolLetterViewHandler.StartAnimType);
		}

		// Token: 0x060383AB RID: 230315 RVA: 0x00FB8738 File Offset: 0x00FB6938
		protected override void OnBeforeDestroy()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(7);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.OnLateUpdate.Unbind();
			}
			this.PendingScrollToEnd = false;
			this.FocusParagraphIndex = -1;
			this.DisplayedParagraphs.Clear();
			this.ContinueButton = null;
			ISolarSchoolLetterViewHandler handler = this.Handler;
			if (handler != null)
			{
				handler.OnViewClosed();
			}
			this.Handler = null;
		}

		// Token: 0x0401D98C RID: 121228
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolLetterParagraphItem, SolarSchoolLetterParagraphData> ParagraphLayout;

		// Token: 0x0401D98D RID: 121229
		[Nullable(2)]
		private SolarSchoolContinueButtonItem ContinueButton;

		// Token: 0x0401D98E RID: 121230
		[Nullable(2)]
		private ISolarSchoolLetterViewHandler Handler;

		// Token: 0x0401D98F RID: 121231
		private readonly List<SolarSchoolLetterParagraphData> DisplayedParagraphs = new List<SolarSchoolLetterParagraphData>();

		// Token: 0x0401D990 RID: 121232
		private IReadOnlyList<string> PageParagraphIds = Array.Empty<string>();

		// Token: 0x0401D991 RID: 121233
		private int CurrentPageNumber;

		// Token: 0x0401D992 RID: 121234
		private bool IsLastPage;

		// Token: 0x0401D993 RID: 121235
		private ELetterAnimType AnimType = ELetterAnimType.ReOpen;

		// Token: 0x0401D994 RID: 121236
		private SolarSchoolLetterView.ESkipButtonMode SkipButtonMode;

		// Token: 0x0401D995 RID: 121237
		private bool ContinueInteractable;

		// Token: 0x0401D996 RID: 121238
		private bool HasShownPage;

		// Token: 0x0401D997 RID: 121239
		private bool PendingScrollToEnd;

		// Token: 0x0401D998 RID: 121240
		private int FocusParagraphIndex = -1;

		// Token: 0x0401D999 RID: 121241
		private bool IsFocusLayoutReady;

		// Token: 0x0200B4D9 RID: 46297
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04037EA7 RID: 229031
			public const int TxtLetterContent = 0;

			// Token: 0x04037EA8 RID: 229032
			public const int TxtNum = 1;

			// Token: 0x04037EA9 RID: 229033
			public const int BtnSolarSchoolContiune = 2;

			// Token: 0x04037EAA RID: 229034
			public const int Content = 3;

			// Token: 0x04037EAB RID: 229035
			public const int PnlLetterCover = 4;

			// Token: 0x04037EAC RID: 229036
			public const int PnlLetterContent = 5;

			// Token: 0x04037EAD RID: 229037
			public const int BtnSkip = 6;

			// Token: 0x04037EAE RID: 229038
			public const int SvInfo = 7;
		}

		// Token: 0x0200B4DA RID: 46298
		[NullableContext(0)]
		private enum ESkipButtonMode
		{
			// Token: 0x04037EB0 RID: 229040
			None,
			// Token: 0x04037EB1 RID: 229041
			Open,
			// Token: 0x04037EB2 RID: 229042
			Skip
		}
	}
}
