using System;
using System.Collections.Generic;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058F5 RID: 22773
	public class SolarSchoolExamInProgressState : SolarSchoolInstanceInProgressState
	{
		// Token: 0x06038254 RID: 229972 RVA: 0x00FB1D04 File Offset: 0x00FAFF04
		protected override void OnEnterState(ESolarSchoolStageStateType? prev)
		{
			this.InitExam();
			if (this.ExamId == 0)
			{
				return;
			}
			base.OnEnterState(prev);
		}

		// Token: 0x06038255 RID: 229973 RVA: 0x00FB1D1C File Offset: 0x00FAFF1C
		protected override void OnTaskFinish(int taskId)
		{
			if (this.ExamId != 0)
			{
				this.SettleExam();
			}
			base.OnTaskFinish(taskId);
		}

		// Token: 0x06038256 RID: 229974 RVA: 0x00FB1D34 File Offset: 0x00FAFF34
		private unsafe void InitExam()
		{
			this.ExamId = 0;
			int instanceId = SolarSchoolGamePlayModel.Instance.InstanceId;
			SolarSchoolExam? examByInstanceId = SolarSchoolConfig.Instance.GetExamByInstanceId(instanceId);
			if (examByInstanceId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][Exam] 考试副本没有对应考试id，检查配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("instanceId", instanceId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishDay();
				return;
			}
			this.ExamId = examByInstanceId.Value.Id;
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			playerData.InitExamResult(this.ExamId);
			int[] attrList = playerData.GetAttrList();
			int num = SolarSchoolUtils.CalcExamBaseScore(this.ExamId, attrList);
			this.AddScore(num);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "[SolarSchool][Exam] 考试初始化";
			<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray8<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("instanceId", instanceId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("examId", this.ExamId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("examType", examByInstanceId.Value.ExamType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("attrValues", string.Join<int>(",", attrList));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("attrMax", string.Join<int>(",", examByInstanceId.Value.GetAttrMaxArray()));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("attrWeight", string.Join<int>(",", examByInstanceId.Value.GetAttrWeightArray()));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("scoreMax", examByInstanceId.Value.ScoreMax);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("baseScore", num);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 8));
		}

		// Token: 0x06038257 RID: 229975 RVA: 0x00FB1F44 File Offset: 0x00FB0144
		public unsafe void AddScore(int value)
		{
			if (this.ExamId == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][Exam] 考试未初始化";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			int num = SolarSchoolGamePlayModel.Instance.PlayerData.AddExamScore(this.ExamId, value);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "[SolarSchool][Exam] 考试加分";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("examId", this.ExamId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("total", num);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x06038258 RID: 229976 RVA: 0x00FB2024 File Offset: 0x00FB0224
		private unsafe void SettleExam()
		{
			SolarSchoolExam? exam = SolarSchoolConfig.Instance.GetExam(this.ExamId);
			if (exam == null)
			{
				return;
			}
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			ESolarSchoolExamType examType = (ESolarSchoolExamType)exam.Value.ExamType;
			int examScore = playerData.GetExamScore(this.ExamId);
			int num = this.RollRank(exam.Value.ScoreRankGroupId, examScore);
			playerData.SetExamResult(new SolarSchoolExamResult(this.ExamId, examScore, num, false), examType);
			SolarSchoolGamePlayModel.Instance.LogReporter.ReportStageSettle(ESolarSchoolStageSettleType.Exam);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[SolarSchool][Exam] 考试结算";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("examId", this.ExamId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("examType", examType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("score", examScore);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("rank", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x06038259 RID: 229977 RVA: 0x00FB2150 File Offset: 0x00FB0350
		private unsafe int RollRank(int rankGroupId, int score)
		{
			IReadOnlyList<SolarSchoolExamScoreRank> examScoreRankListByGroupId = SolarSchoolConfig.Instance.GetExamScoreRankListByGroupId(rankGroupId);
			if (examScoreRankListByGroupId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][Exam] 名次组缺行，名次记 0";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rankGroupId", rankGroupId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			foreach (SolarSchoolExamScoreRank solarSchoolExamScoreRank in examScoreRankListByGroupId)
			{
				if (score >= solarSchoolExamScoreRank.ScoreMin && score <= solarSchoolExamScoreRank.ScoreMax)
				{
					int num = Math.Min(solarSchoolExamScoreRank.RankRandMin, solarSchoolExamScoreRank.RankRandMax);
					int num2 = Math.Max(solarSchoolExamScoreRank.RankRandMin, solarSchoolExamScoreRank.RankRandMax) - num + 1;
					int num3 = (num2 <= 1) ? num : (num + RandomSystem.GetRandomInteger() % num2);
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SolarSchool;
					ELogAuthor author2 = ELogAuthor.YYZ;
					string message2 = "[SolarSchool][Exam] 考试排名计算";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ExamId", this.ExamId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RankGroupId", rankGroupId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Score", score);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Rank", num3);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					return num3;
				}
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.SolarSchool;
			ELogAuthor author3 = ELogAuthor.YYZ;
			string message3 = "[SolarSchool][Exam] 分数不落在任何名次区间，名次记 0";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("rankGroupId", rankGroupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("score", score);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return 0;
		}

		// Token: 0x0401D918 RID: 121112
		private int ExamId;
	}
}
