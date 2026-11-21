using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005918 RID: 22808
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolScoreNotifyGameplay : SolarSchoolLetterGameplay
	{
		// Token: 0x17006BC5 RID: 27589
		// (get) Token: 0x060383AE RID: 230318 RVA: 0x00FB87B9 File Offset: 0x00FB69B9
		// (set) Token: 0x060383AF RID: 230319 RVA: 0x00FB87C1 File Offset: 0x00FB69C1
		private protected int ExamId { protected get; private set; }

		// Token: 0x060383B0 RID: 230320 RVA: 0x00FB87CC File Offset: 0x00FB69CC
		protected unsafe override int OnExParse(IReadOnlyDictionary<string, string> parameters)
		{
			int paramInt = ActivityActionBase.GetParamInt(parameters, "LetterId", 0);
			this.ExamId = ActivityActionBase.GetParamInt(parameters, "ExamId", 0);
			if (this.ExamId <= 0 || paramInt <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][ScoreNotify] 缺少书信Id或考试Id，成绩无法公示";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("letterId", paramInt);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("examId", this.ExamId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return -1;
			}
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			SolarSchoolExamResult solarSchoolExamResult;
			if (!playerData.TryGetExamResult(this.ExamId, out solarSchoolExamResult))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.YYZ;
				string message2 = "[SolarSchool][ScoreNotify] 考试结果不存在，检查流程是否先跑过考试";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("letterId", paramInt);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("examId", this.ExamId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return -1;
			}
			playerData.SetExamPublish(this.ExamId, true);
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.SolarSchool;
			ELogAuthor author3 = ELogAuthor.YYZ;
			string message3 = "[SolarSchool][ScoreNotify] 成绩已公示";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("letterId", paramInt);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("examId", this.ExamId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("score", solarSchoolExamResult.Score);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("rank", solarSchoolExamResult.Rank);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
			return paramInt;
		}

		// Token: 0x0401D99A RID: 121242
		private const string ParamKeyLetterId = "LetterId";

		// Token: 0x0401D99B RID: 121243
		private const string ParamKeyExamId = "ExamId";
	}
}
