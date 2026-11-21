using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A1D RID: 18973
	public class FlagChallengeUtils
	{
		// Token: 0x0602F8F6 RID: 194806 RVA: 0x00D43584 File Offset: 0x00D41784
		[NullableContext(1)]
		public unsafe static string GetDynamicRes(EFlagChallengeUiStyleType style, string baseKey, int index)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted(baseKey);
			defaultInterpolatedStringHandler.AppendFormatted<int>(index);
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			Dictionary<string, string> dictionary;
			if (!FlagChallengeDefine.Instance.flagChallengeStyleRes.TryGetValue(style, out dictionary))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "未定义的资源";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("style", style);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", text);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return "";
			}
			string text2;
			if (!dictionary.TryGetValue(text, out text2) || string.IsNullOrEmpty(text2))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.FlagChallenge;
				ELogAuthor author2 = ELogAuthor.LJS;
				string message2 = "未定义的资源";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("style", style);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("key", text);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return "";
			}
			return text2;
		}

		// Token: 0x0602F8F7 RID: 194807 RVA: 0x00D4369C File Offset: 0x00D4189C
		public static bool IsInFlagChallengeDungeon()
		{
			return FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon;
		}

		// Token: 0x0602F8F8 RID: 194808 RVA: 0x00D436A8 File Offset: 0x00D418A8
		public static int GetStrongholdActivityId(int strongholdId)
		{
			FlagStronghold? strongholdConfig = FlagChallengeConfig.Instance.GetStrongholdConfig(strongholdId);
			return FlagChallengeConfig.Instance.GetLevelConfig(strongholdConfig.Value.ChallengeLevelId).Value.ActivityId;
		}

		// Token: 0x0602F8F9 RID: 194809 RVA: 0x00D436EC File Offset: 0x00D418EC
		public static int GetAreaActivityId(int areaId)
		{
			FlagChallengeArea? areaConfig = FlagChallengeConfig.Instance.GetAreaConfig(areaId);
			return FlagChallengeConfig.Instance.GetLevelConfig(areaConfig.Value.LevelId).Value.ActivityId;
		}

		// Token: 0x0602F8FA RID: 194810 RVA: 0x00D43730 File Offset: 0x00D41930
		public static int GetLevelActivityId(int levelId)
		{
			return FlagChallengeConfig.Instance.GetLevelConfig(levelId).Value.ActivityId;
		}

		// Token: 0x0602F8FB RID: 194811 RVA: 0x00D43758 File Offset: 0x00D41958
		public static int GetBuffActivityId(int buffId)
		{
			return FlagChallengeConfig.Instance.GetRoleBuffConfig(buffId).Value.ActivityId;
		}
	}
}
