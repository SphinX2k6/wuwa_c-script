using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F9 RID: 761
	public class ConfigFlagChallengeLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011DB RID: 4571 RVA: 0x000BE6E3 File Offset: 0x000BC8E3
		static ConfigFlagChallengeLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeLevelById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x000BE704 File Offset: 0x000BC904
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

		// Token: 0x060011DD RID: 4573 RVA: 0x000BE783 File Offset: 0x000BC983
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeLevelById.LogPair = null;
			ConfigFlagChallengeLevelById.HandleId = 0;
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x000BE791 File Offset: 0x000BC991
		public static void Init()
		{
			ConfigFlagChallengeLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeLevelById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeLevel` where Id=?");
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x000BE7AC File Offset: 0x000BC9AC
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

		// Token: 0x040014B3 RID: 5299
		private const string DB = "db_flagchallenge.db";

		// Token: 0x040014B4 RID: 5300
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x040014B5 RID: 5301
		private const string TABLE = "FlagChallengeLevel";

		// Token: 0x040014B6 RID: 5302
		private const string COMMAND = "select BinData from `FlagChallengeLevel` where Id=?";

		// Token: 0x040014B7 RID: 5303
		private const string KEY_PREFIX = "FlagChallengeLevelById";

		// Token: 0x040014B8 RID: 5304
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014B9 RID: 5305
		private static int HandleId;
	}
}
