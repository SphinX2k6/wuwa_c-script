using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200030E RID: 782
	public class ConfigFlagChallengeLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001259 RID: 4697 RVA: 0x000C4BEF File Offset: 0x000C2DEF
		static ConfigFlagChallengeLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeLevelById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000C4C10 File Offset: 0x000C2E10
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局外.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeLevel` where Id=?")
			});
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x000C4C8F File Offset: 0x000C2E8F
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeLevelById.LogPair = null;
			ConfigFlagChallengeLevelById.HandleId = 0;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x000C4C9D File Offset: 0x000C2E9D
		public static void Init()
		{
			ConfigFlagChallengeLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeLevelById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeLevel` where Id=?");
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000C4CB8 File Offset: 0x000C2EB8
		public static FlagChallengeLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeLevelById.HandleId, ConfigFlagChallengeLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagChallengeLevel?(FlagChallengeLevel.GetRootAsFlagChallengeLevel(configBuffer));
				}
			}
			ConfigFlagChallengeLevelById.LogPair.Clear();
			ConfigFlagChallengeLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeLevelById.HandleId, 1, p0Id, ConfigFlagChallengeLevelById.LogPair) || ConfigCommon.Step(ConfigFlagChallengeLevelById.HandleId, true, ConfigFlagChallengeLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagChallengeLevelById.HandleId, ConfigFlagChallengeLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeLevelById.HandleId, 0, ConfigFlagChallengeLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagChallengeLevelById.HandleId, ConfigFlagChallengeLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagChallengeLevel rootAsFlagChallengeLevel = FlagChallengeLevel.GetRootAsFlagChallengeLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagChallengeLevelById.HandleId, ConfigFlagChallengeLevelById.LogPair);
			return new FlagChallengeLevel?(rootAsFlagChallengeLevel);
		}

		// Token: 0x04001546 RID: 5446
		private const string DB = "db_flagchallenge.db";

		// Token: 0x04001547 RID: 5447
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x04001548 RID: 5448
		private const string TABLE = "FlagChallengeLevel";

		// Token: 0x04001549 RID: 5449
		private const string COMMAND = "select BinData from `FlagChallengeLevel` where Id=?";

		// Token: 0x0400154A RID: 5450
		private const string KEY_PREFIX = "FlagChallengeLevelById";

		// Token: 0x0400154B RID: 5451
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400154C RID: 5452
		private static int HandleId;
	}
}
