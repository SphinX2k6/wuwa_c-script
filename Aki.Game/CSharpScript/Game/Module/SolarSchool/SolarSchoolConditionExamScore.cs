using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005899 RID: 22681
	public class SolarSchoolConditionExamScore : ActivityConditionBase
	{
		// Token: 0x17006B3E RID: 27454
		// (get) Token: 0x06037E17 RID: 228887 RVA: 0x00FA057E File Offset: 0x00F9E77E
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E18 RID: 228888 RVA: 0x00FA0584 File Offset: 0x00F9E784
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.ExamId = p.GetInt("ExamId", 0);
			this.MinScore = p.GetInt("Min", int.MinValue);
			this.MaxScore = p.GetInt("Max", int.MaxValue);
			return true;
		}

		// Token: 0x06037E19 RID: 228889 RVA: 0x00FA05D0 File Offset: 0x00F9E7D0
		protected override bool OnCheck()
		{
			int conditionExamScore = SolarSchoolGamePlayModel.Instance.GetConditionExamScore(this.ExamId);
			return conditionExamScore >= this.MinScore && conditionExamScore <= this.MaxScore;
		}

		// Token: 0x06037E1A RID: 228890 RVA: 0x00FA0605 File Offset: 0x00F9E805
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolExamScoreChanged, new Action<int>(this.OnExamScoreChanged));
		}

		// Token: 0x06037E1B RID: 228891 RVA: 0x00FA0623 File Offset: 0x00F9E823
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolExamScoreChanged, new Action<int>(this.OnExamScoreChanged));
		}

		// Token: 0x06037E1C RID: 228892 RVA: 0x00FA0641 File Offset: 0x00F9E841
		protected override void OnClear()
		{
			this.ExamId = 0;
			this.MinScore = 0;
			this.MaxScore = 0;
		}

		// Token: 0x06037E1D RID: 228893 RVA: 0x00FA0658 File Offset: 0x00F9E858
		private void OnExamScoreChanged(int examId)
		{
			if (examId == this.ExamId)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x0401D7D5 RID: 120789
		private int ExamId;

		// Token: 0x0401D7D6 RID: 120790
		private int MinScore;

		// Token: 0x0401D7D7 RID: 120791
		private int MaxScore;
	}
}
