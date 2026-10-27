using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02004C68 RID: 19560
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainAnalysisCluePanel : UiTabViewBase
	{
		// Token: 0x06032909 RID: 207113 RVA: 0x00BC8798 File Offset: 0x00BC6998
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603290A RID: 207114 RVA: 0x00BC8844 File Offset: 0x00BC6A44
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffMainAnalysisCluePanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffMainAnalysisCluePanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603290B RID: 207115 RVA: 0x00BC8888 File Offset: 0x00BC6A88
		protected override void OnBeforeShow()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
			}
			int curQuestionIndex = this.Proxy.GetCurQuestionIndex();
			List<int> clueRecords = this.Proxy.GetClueRecords(curQuestionIndex);
			for (int i = 0; i < clueRecords.Count; i++)
			{
				this.ClueItemList[i].Refresh(new int?(clueRecords[i]));
			}
			for (int j = clueRecords.Count; j < 3; j++)
			{
				this.ClueItemList[j].Refresh(null);
			}
			this.RefreshClueState();
			this.RefreshDialogPanel();
			this.RefreshDialog();
			this.LogReport();
		}

		// Token: 0x0603290C RID: 207116 RVA: 0x00BC8948 File Offset: 0x00BC6B48
		protected void LogReport()
		{
			SheriffReasoningCompleteEvent sheriffReasoningCompleteEvent = new SheriffReasoningCompleteEvent();
			sheriffReasoningCompleteEvent.i_quest_id = this.Proxy.GetAnomalyInfo().AnomalyId;
			int curQuestionIndex = this.Proxy.GetCurQuestionIndex();
			sheriffReasoningCompleteEvent.i_question_id = this.Proxy.GetQuestionIdByIndex(curQuestionIndex);
			sheriffReasoningCompleteEvent.i_result_id = ((this.ClueState != EClueState.Success) ? 1 : 0);
			List<int> clueRecords = this.Proxy.GetClueRecords(curQuestionIndex);
			sheriffReasoningCompleteEvent.o_clue_id = clueRecords;
			LogReportController.Instance.LogReport(sheriffReasoningCompleteEvent);
		}

		// Token: 0x0603290D RID: 207117 RVA: 0x00BC89C0 File Offset: 0x00BC6BC0
		protected void RefreshClueState()
		{
			this.QuestionAnalysisConfig = null;
			int curQuestionIndex = this.Proxy.GetCurQuestionIndex();
			int questionIdByIndex = this.Proxy.GetQuestionIdByIndex(curQuestionIndex);
			ISheriffQuestionJsonConfig questionConfig = this.Proxy.GetQuestionConfig(questionIdByIndex);
			List<int> clueRecords = this.Proxy.GetClueRecords(curQuestionIndex);
			foreach (ISheriffQuestionResultJsonConfig sheriffQuestionResultJsonConfig in questionConfig.ResultConfigs)
			{
				bool flag = true;
				foreach (int item in sheriffQuestionResultJsonConfig.ClueCombination)
				{
					if (!clueRecords.Contains(item))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					this.QuestionAnalysisConfig = sheriffQuestionResultJsonConfig;
					break;
				}
			}
			if (this.QuestionAnalysisConfig != null)
			{
				this.ClueState = EClueState.Success;
				this.GetTalkList(this.QuestionAnalysisConfig.ReasoningStateId);
				if (this.QuestionAnalysisConfig.NextQuestionId != null)
				{
					this.DialogPanel.SetNextQuestionIdOrEnding(this.QuestionAnalysisConfig);
					return;
				}
				if (this.QuestionAnalysisConfig.EndingId != null)
				{
					this.DialogPanel.SetNextQuestionIdOrEnding(this.QuestionAnalysisConfig);
					return;
				}
			}
			else
			{
				this.ClueState = EClueState.Fail;
				this.Proxy.SetFailureCount();
				this.GetTalkList(SheriffConfig.Instance.GetQuestionById(questionIdByIndex).Value.FailResultDesc().ToList<string>());
			}
		}

		// Token: 0x0603290E RID: 207118 RVA: 0x00BC8B50 File Offset: 0x00BC6D50
		private void GetTalkList(List<string> stateIds)
		{
			this.CurTalkIndex = 0;
			this.TalkList.Clear();
			foreach (ActionInfo actionInfo in FlowConfig.Instance.GetFlowStateActions(stateIds[0], int.Parse(stateIds[1]), int.Parse(stateIds[2])))
			{
				if (actionInfo.Name == EAction.ShowTalk)
				{
					foreach (ITalkItem talkItem in (actionInfo.Params as ShowTalk).TalkItems)
					{
						this.TalkList.Add(talkItem.TidTalk ?? "");
					}
				}
			}
		}

		// Token: 0x0603290F RID: 207119 RVA: 0x00BC8C3C File Offset: 0x00BC6E3C
		protected void RefreshDialogPanel()
		{
			if (this.ClueState != EClueState.Success)
			{
				int curQuestionIndex = this.Proxy.GetCurQuestionIndex();
				int questionIdByIndex = this.Proxy.GetQuestionIdByIndex(curQuestionIndex);
				SheriffMainAnalysisClueDialogPanel dialogPanel = this.DialogPanel;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
				defaultInterpolatedStringHandler.AppendLiteral("ReasoningQuestion_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(questionIdByIndex);
				defaultInterpolatedStringHandler.AppendLiteral("_QuestionDesc");
				dialogPanel.RefreshTitleText(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			this.DialogPanel.RefreshDialogPanel(this.ClueState);
		}

		// Token: 0x06032910 RID: 207120 RVA: 0x00BC8CB8 File Offset: 0x00BC6EB8
		private void RefreshDialog()
		{
			if (this.CurTalkIndex < this.TalkList.Count)
			{
				this.DialogPanel.RefreshDialogText(this.TalkList[this.CurTalkIndex]);
				this.CurTalkIndex++;
				return;
			}
			if (this.ClueState == EClueState.Success)
			{
				this.ClueState = EClueState.Conclusion;
				this.GetTalkList(this.QuestionAnalysisConfig.ResultDesc);
				this.CurTalkIndex = 0;
				SheriffMainAnalysisClueDialogPanel dialogPanel = this.DialogPanel;
				ISheriffQuestionResultJsonConfig questionAnalysisConfig = this.QuestionAnalysisConfig;
				dialogPanel.RefreshNextBtnText(questionAnalysisConfig != null && questionAnalysisConfig.EndingId != null);
				this.DialogPanel.RefreshDialogPanel(EClueState.Conclusion);
				int curQuestionIndex = this.Proxy.GetCurQuestionIndex();
				int questionIdByIndex = this.Proxy.GetQuestionIdByIndex(curQuestionIndex);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
				defaultInterpolatedStringHandler.AppendLiteral("ReasoningQuestion_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(questionIdByIndex);
				defaultInterpolatedStringHandler.AppendLiteral("_QuestionDesc");
				string text = defaultInterpolatedStringHandler.ToStringAndClear();
				this.DialogPanel.RefreshTitleText(text);
				this.Proxy.SetConclusionKey(this.TalkList[this.CurTalkIndex]);
				this.DialogPanel.RefreshDialogText(this.TalkList[this.CurTalkIndex]);
				return;
			}
			EClueState clueState = this.ClueState;
		}

		// Token: 0x0401AE84 RID: 110212
		protected EClueState ClueState;

		// Token: 0x0401AE85 RID: 110213
		[Nullable(2)]
		protected SheriffMainProxy Proxy;

		// Token: 0x0401AE86 RID: 110214
		protected List<SheriffMainAnalysisClueItem> ClueItemList = new List<SheriffMainAnalysisClueItem>();

		// Token: 0x0401AE87 RID: 110215
		[Nullable(2)]
		protected ISheriffQuestionResultJsonConfig QuestionAnalysisConfig;

		// Token: 0x0401AE88 RID: 110216
		[Nullable(2)]
		protected SheriffMainAnalysisClueDialogPanel DialogPanel;

		// Token: 0x0401AE89 RID: 110217
		protected List<string> TalkList = new List<string>();

		// Token: 0x0401AE8A RID: 110218
		protected int CurTalkIndex;

		// Token: 0x0200AE1A RID: 44570
		[NullableContext(0)]
		private static class EDefine
		{
			// Token: 0x04034E02 RID: 216578
			public const int TogSkyEyeClue1 = 0;

			// Token: 0x04034E03 RID: 216579
			public const int TogSkyEyeClue2 = 1;

			// Token: 0x04034E04 RID: 216580
			public const int TogSkyEyeClue3 = 2;

			// Token: 0x04034E05 RID: 216581
			public const int DialogItem = 3;
		}
	}
}
