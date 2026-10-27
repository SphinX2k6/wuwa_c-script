using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A41 RID: 23105
	public class FlagChallengeUtils
	{
		// Token: 0x0603A9AD RID: 240045 RVA: 0x00DF3000 File Offset: 0x00DF1200
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

		// Token: 0x0603A9AE RID: 240046 RVA: 0x00DF3118 File Offset: 0x00DF1318
		public static bool IsInFlagChallengeDungeon()
		{
			return FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon;
		}

		// Token: 0x0603A9AF RID: 240047 RVA: 0x00DF3124 File Offset: 0x00DF1324
		public static int GetStrongholdActivityId(int strongholdId)
		{
			FlagStronghold? strongholdConfig = FlagChallengeConfig.Instance.GetStrongholdConfig(strongholdId);
			return FlagChallengeConfig.Instance.GetLevelConfig(strongholdConfig.Value.ChallengeLevelId).Value.ActivityId;
		}

		// Token: 0x0603A9B0 RID: 240048 RVA: 0x00DF3168 File Offset: 0x00DF1368
		public static int GetAreaActivityId(int areaId)
		{
			FlagChallengeArea? areaConfig = FlagChallengeConfig.Instance.GetAreaConfig(areaId);
			return FlagChallengeConfig.Instance.GetLevelConfig(areaConfig.Value.LevelId).Value.ActivityId;
		}

		// Token: 0x0603A9B1 RID: 240049 RVA: 0x00DF31AC File Offset: 0x00DF13AC
		public static int GetLevelActivityId(int levelId)
		{
			return FlagChallengeConfig.Instance.GetLevelConfig(levelId).Value.ActivityId;
		}

		// Token: 0x0603A9B2 RID: 240050 RVA: 0x00DF31D4 File Offset: 0x00DF13D4
		public static int GetBuffActivityId(int buffId)
		{
			return FlagChallengeConfig.Instance.GetRoleBuffConfig(buffId).Value.ActivityId;
		}
	}
}
