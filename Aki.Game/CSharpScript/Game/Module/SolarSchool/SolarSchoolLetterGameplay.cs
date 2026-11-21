using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005915 RID: 22805
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolLetterGameplay : SolarSchoolGameplayBase, ISolarSchoolLetterViewHandler
	{
		// Token: 0x17006BC3 RID: 27587
		// (get) Token: 0x0603837D RID: 230269 RVA: 0x00FB78DE File Offset: 0x00FB5ADE
		// (set) Token: 0x0603837E RID: 230270 RVA: 0x00FB78E6 File Offset: 0x00FB5AE6
		public ELetterAnimType StartAnimType { get; set; } = ELetterAnimType.NewOpen;

		// Token: 0x17006BC4 RID: 27588
		// (get) Token: 0x0603837F RID: 230271 RVA: 0x00FB78EF File Offset: 0x00FB5AEF
		private int PageNumber
		{
			get
			{
				return this.CurrentPageIndex + 1;
			}
		}

		// Token: 0x06038380 RID: 230272 RVA: 0x00FB78FC File Offset: 0x00FB5AFC
		protected override void OnGameplayStart()
		{
			SolarSchoolLetter? letter = SolarSchoolConfig.Instance.GetLetter(base.GameplayId);
			if (letter == null)
			{
				base.MarkFailed();
				return;
			}
			this.CalcPageRange(letter.Value);
			if (this.TotalPageCount <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][Letter] 书信页序为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", base.GameplayId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.MarkFailed();
				return;
			}
			this.StartAnimType = (ELetterAnimType)letter.Value.StartAnimStyle;
			base.AddState("OpenView", new Action(this.EnterOpenView));
			base.AddState("ShowPage", new Action(this.EnterShowPage));
		}

		// Token: 0x06038381 RID: 230273 RVA: 0x00FB79BE File Offset: 0x00FB5BBE
		protected override void OnGameplayEnd()
		{
			this.CloseView();
		}

		// Token: 0x06038382 RID: 230274 RVA: 0x00FB79C6 File Offset: 0x00FB5BC6
		private void EnterOpenView()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolLetterView, this, null);
		}

		// Token: 0x06038383 RID: 230275 RVA: 0x00FB79DC File Offset: 0x00FB5BDC
		private unsafe void EnterShowPage()
		{
			SolarSchoolLetter? letter = SolarSchoolConfig.Instance.GetLetter(base.GameplayId);
			if (letter == null)
			{
				return;
			}
			int num = letter.Value.PageList(this.CurrentPageIndex);
			this.ParagraphIds.Clear();
			SolarSchoolLetterPage? letterPage = SolarSchoolConfig.Instance.GetLetterPage(num);
			if (letterPage != null)
			{
				for (int i = 0; i < letterPage.Value.ParagraphLength; i++)
				{
					string text = letterPage.Value.Paragraph(i);
					if (!string.IsNullOrEmpty(text))
					{
						this.ParagraphIds.Add(text);
					}
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[SolarSchool][Letter] 展示书信分页";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", base.GameplayId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("pageId", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("pageNumber", this.PageNumber);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("totalPageCount", this.TotalPageCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("paragraphCount", this.ParagraphIds.Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			SolarSchoolLetterView view = this.View;
			if (view == null)
			{
				return;
			}
			view.ShowPage(this.PageNumber, this.TotalPageCount, this.IsLastPage(), this.ParagraphIds);
		}

		// Token: 0x06038384 RID: 230276 RVA: 0x00FB7B7C File Offset: 0x00FB5D7C
		public void OnViewReady(SolarSchoolLetterView view)
		{
			this.View = view;
		}

		// Token: 0x06038385 RID: 230277 RVA: 0x00FB7B85 File Offset: 0x00FB5D85
		public void OnOpeningFinished()
		{
			base.GotoState("ShowPage");
		}

		// Token: 0x06038386 RID: 230278 RVA: 0x00FB7B92 File Offset: 0x00FB5D92
		public void OnPageTypingFinished()
		{
		}

		// Token: 0x06038387 RID: 230279 RVA: 0x00FB7B94 File Offset: 0x00FB5D94
		public void OnContinueClicked()
		{
			if (this.CurrentPageIndex >= this.PageEndIndex)
			{
				this.CloseView();
				base.FinishGameplay();
				return;
			}
			this.CurrentPageIndex++;
			base.GotoState("ShowPage");
		}

		// Token: 0x06038388 RID: 230280 RVA: 0x00FB7BCA File Offset: 0x00FB5DCA
		public void OnViewClosed()
		{
			this.View = null;
		}

		// Token: 0x06038389 RID: 230281 RVA: 0x00FB7BD4 File Offset: 0x00FB5DD4
		private unsafe void CalcPageRange(SolarSchoolLetter letter)
		{
			this.TotalPageCount = letter.PageListLength;
			this.PageEndIndex = this.TotalPageCount - 1;
			if (this.TotalPageCount <= 0)
			{
				return;
			}
			int num = this.IndexOfPage(letter, letter.PageStart, 0);
			int num2 = this.IndexOfPage(letter, letter.PageEnd, this.TotalPageCount - 1);
			if (num > num2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][Letter] 起始页在结束页之后，退化为整段 PageList";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", base.GameplayId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("pageStart", letter.PageStart);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("pageEnd", letter.PageEnd);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				num = 0;
				num2 = this.TotalPageCount - 1;
			}
			this.PageEndIndex = num2;
			this.CurrentPageIndex = num;
		}

		// Token: 0x0603838A RID: 230282 RVA: 0x00FB7CDC File Offset: 0x00FB5EDC
		private unsafe int IndexOfPage(SolarSchoolLetter letter, int pageId, int fallbackIndex)
		{
			if (pageId <= 0)
			{
				return fallbackIndex;
			}
			for (int i = 0; i < letter.PageListLength; i++)
			{
				if (letter.PageList(i) == pageId)
				{
					return i;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[SolarSchool][Letter] 起止页不在 PageList 内，检查配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", base.GameplayId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("pageId", pageId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return fallbackIndex;
		}

		// Token: 0x0603838B RID: 230283 RVA: 0x00FB7D74 File Offset: 0x00FB5F74
		private bool IsLastPage()
		{
			return this.PageNumber >= this.TotalPageCount;
		}

		// Token: 0x0603838C RID: 230284 RVA: 0x00FB7D87 File Offset: 0x00FB5F87
		private void CloseView()
		{
			if (this.View == null)
			{
				base.CloseOpeningView(EUiViewName.SolarSchoolLetterView);
				return;
			}
			UiViewBase view = this.View;
			this.View = null;
			view.CloseMe(null);
		}

		// Token: 0x0401D982 RID: 121218
		[Nullable(2)]
		private SolarSchoolLetterView View;

		// Token: 0x0401D983 RID: 121219
		private readonly List<string> ParagraphIds = new List<string>();

		// Token: 0x0401D984 RID: 121220
		private int PageEndIndex;

		// Token: 0x0401D985 RID: 121221
		private int TotalPageCount;

		// Token: 0x0401D986 RID: 121222
		private int CurrentPageIndex;

		// Token: 0x0200B4D7 RID: 46295
		[Nullable(0)]
		private static class GameplayState
		{
			// Token: 0x04037EA2 RID: 229026
			public const string OpenView = "OpenView";

			// Token: 0x04037EA3 RID: 229027
			public const string ShowPage = "ShowPage";
		}
	}
}
