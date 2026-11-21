using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058D5 RID: 22741
	public class SolarSchoolExamResult
	{
		// Token: 0x06038007 RID: 229383 RVA: 0x00FA7420 File Offset: 0x00FA5620
		public SolarSchoolExamResult(int examId, int score, int rank, bool isPublished = false)
		{
			this.ExamId = examId;
			this.Score = score;
			this.Rank = rank;
			this.IsPublished = isPublished;
		}

		// Token: 0x06038008 RID: 229384 RVA: 0x00FA7448 File Offset: 0x00FA5648
		[NullableContext(2)]
		public unsafe string GetRankIcon()
		{
			SolarSchoolExam? exam = SolarSchoolConfig.Instance.GetExam(this.ExamId);
			if (exam == null)
			{
				return null;
			}
			int scoreRankGroupId = exam.Value.ScoreRankGroupId;
			IReadOnlyList<SolarSchoolExamScoreRank> examScoreRankListByGroupId = SolarSchoolConfig.Instance.GetExamScoreRankListByGroupId(scoreRankGroupId);
			if (examScoreRankListByGroupId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][Exam] 名次组缺行，无名次图标";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("examId", this.ExamId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("rankGroupId", scoreRankGroupId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			foreach (SolarSchoolExamScoreRank solarSchoolExamScoreRank in examScoreRankListByGroupId)
			{
				if (this.Score >= solarSchoolExamScoreRank.ScoreMin && this.Score <= solarSchoolExamScoreRank.ScoreMax)
				{
					return string.IsNullOrEmpty(solarSchoolExamScoreRank.RankIcon) ? null : solarSchoolExamScoreRank.RankIcon;
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "[SolarSchool][Exam] 分数不落在任何名次区间，无名次图标";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("examId", this.ExamId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("rankGroupId", scoreRankGroupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("score", this.Score);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return null;
		}

		// Token: 0x0401D884 RID: 120964
		public int ExamId;

		// Token: 0x0401D885 RID: 120965
		public int Score;

		// Token: 0x0401D886 RID: 120966
		public int Rank;

		// Token: 0x0401D887 RID: 120967
		public bool IsPublished;
	}
}
