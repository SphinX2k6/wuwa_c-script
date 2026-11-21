using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200590C RID: 22796
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolExamGameplay : SolarSchoolGameplayBase, ISolarSchoolExamViewHandler
	{
		// Token: 0x06038336 RID: 230198 RVA: 0x00FB678C File Offset: 0x00FB498C
		protected override void OnGameplayStart()
		{
			if (SolarSchoolConfig.Instance.GetExamEvent(base.GameplayId) == null)
			{
				base.MarkFailed();
				return;
			}
			base.AddState("OpenView", new Action(this.EnterOpenView));
			base.AddState("WaitChoice", new Action(this.EnterWaitChoice));
			base.AddState("ShowResult", new Action(this.EnterShowResult));
		}

		// Token: 0x06038337 RID: 230199 RVA: 0x00FB67FF File Offset: 0x00FB49FF
		protected override void OnGameplayEnd()
		{
			this.CloseView();
		}

		// Token: 0x06038338 RID: 230200 RVA: 0x00FB6807 File Offset: 0x00FB4A07
		private void EnterOpenView()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolExamView, this, null);
		}

		// Token: 0x06038339 RID: 230201 RVA: 0x00FB681C File Offset: 0x00FB4A1C
		private unsafe void EnterWaitChoice()
		{
			SolarSchoolExamEvent? examEvent = SolarSchoolConfig.Instance.GetExamEvent(base.GameplayId);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[SolarSchool][Exam] 等待选择选项";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", base.GameplayId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("choiceGroupId", examEvent.Value.ChoiceGroupId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.ChoiceIds.Clear();
			foreach (SolarSchoolExamChoice solarSchoolExamChoice in (SolarSchoolConfig.Instance.GetExamChoiceListByGroupId(examEvent.Value.ChoiceGroupId) ?? Array.Empty<SolarSchoolExamChoice>()))
			{
				this.ChoiceIds.Add(solarSchoolExamChoice.Id);
			}
			SolarSchoolExamView view = this.View;
			if (view == null)
			{
				return;
			}
			view.ShowEvent(examEvent.Value, this.ChoiceIds);
		}

		// Token: 0x0603833A RID: 230202 RVA: 0x00FB6940 File Offset: 0x00FB4B40
		private void EnterShowResult()
		{
			if (this.JudgeSuccess)
			{
				SolarSchoolExamEvent? examEvent = SolarSchoolConfig.Instance.GetExamEvent(base.GameplayId);
				SolarSchoolGamePlayModel.Instance.AddCurrentExamScore((examEvent != null) ? examEvent.GetValueOrDefault().AddScore : 0);
			}
			SolarSchoolExamView view = this.View;
			if (view == null)
			{
				return;
			}
			view.ShowResult(this.JudgeSuccess);
		}

		// Token: 0x0603833B RID: 230203 RVA: 0x00FB69A1 File Offset: 0x00FB4BA1
		public void OnViewReady(SolarSchoolExamView view)
		{
			this.View = view;
			base.GotoState("WaitChoice");
		}

		// Token: 0x0603833C RID: 230204 RVA: 0x00FB69B8 File Offset: 0x00FB4BB8
		public unsafe void OnChoiceSelected(int choiceId)
		{
			SolarSchoolExamChoice? examChoice = SolarSchoolConfig.Instance.GetExamChoice(choiceId);
			if (examChoice == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][Exam] 选项表缺行，按答错结算";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", base.GameplayId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("choiceId", choiceId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.JudgeSuccess = false;
			}
			else
			{
				this.JudgeSuccess = examChoice.Value.IsCorrect;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "[SolarSchool][Exam] 选项判定";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("configId", base.GameplayId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("choiceId", choiceId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("success", this.JudgeSuccess);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			base.GotoState("ShowResult");
		}

		// Token: 0x0603833D RID: 230205 RVA: 0x00FB6AEF File Offset: 0x00FB4CEF
		public void OnResultConfirmed()
		{
			this.CloseView();
			base.FinishGameplay();
		}

		// Token: 0x0603833E RID: 230206 RVA: 0x00FB6AFD File Offset: 0x00FB4CFD
		public void OnViewClosed()
		{
			this.View = null;
		}

		// Token: 0x0603833F RID: 230207 RVA: 0x00FB6B06 File Offset: 0x00FB4D06
		private void CloseView()
		{
			if (this.View == null)
			{
				base.CloseOpeningView(EUiViewName.SolarSchoolExamView);
				return;
			}
			UiViewBase view = this.View;
			this.View = null;
			view.CloseMe(null);
		}

		// Token: 0x0401D96B RID: 121195
		[Nullable(2)]
		private SolarSchoolExamView View;

		// Token: 0x0401D96C RID: 121196
		private readonly List<int> ChoiceIds = new List<int>();

		// Token: 0x0401D96D RID: 121197
		private bool JudgeSuccess;

		// Token: 0x0200B4CE RID: 46286
		[Nullable(0)]
		private static class GameplayState
		{
			// Token: 0x04037E77 RID: 228983
			public const string OpenView = "OpenView";

			// Token: 0x04037E78 RID: 228984
			public const string WaitChoice = "WaitChoice";

			// Token: 0x04037E79 RID: 228985
			public const string ShowResult = "ShowResult";
		}
	}
}
