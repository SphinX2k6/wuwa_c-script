using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002FB RID: 763
	public class ConfigFlagChallengeMonLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011E7 RID: 4583 RVA: 0x000BEABF File Offset: 0x000BCCBF
		static ConfigFlagChallengeMonLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeMonLevelById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeMonLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x000BEAE0 File Offset: 0x000BCCE0
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeMonLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeMonLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeMonLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeMonLevel` where Id=?")
			});
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x000BEB5F File Offset: 0x000BCD5F
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeMonLevelById.LogPair = null;
			ConfigFlagChallengeMonLevelById.HandleId = 0;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x000BEB6D File Offset: 0x000BCD6D
		public static void Init()
		{
			ConfigFlagChallengeMonLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeMonLevelById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeMonLevel` where Id=?");
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000BEB88 File Offset: 0x000BCD88
		public static FlagChallengeMonLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeMonLevelById.HandleId, ConfigFlagChallengeMonLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeMonLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagChallengeMonLevel?(FlagChallengeMonLevel.GetRootAsFlagChallengeMonLevel(configBuffer));
				}
			}
			ConfigFlagChallengeMonLevelById.LogPair.Clear();
			ConfigFlagChallengeMonLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeMonLevelById.HandleId, 1, p0Id, ConfigFlagChallengeMonLevelById.LogPair) || ConfigCommon.Step(ConfigFlagChallengeMonLevelById.HandleId, true, ConfigFlagChallengeMonLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagChallengeMonLevelById.HandleId, ConfigFlagChallengeMonLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeMonLevelById.HandleId, 0, ConfigFlagChallengeMonLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagChallengeMonLevelById.HandleId, ConfigFlagChallengeMonLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagChallengeMonLevel rootAsFlagChallengeMonLevel = FlagChallengeMonLevel.GetRootAsFlagChallengeMonLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeMonLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagChallengeMonLevelById.HandleId, ConfigFlagChallengeMonLevelById.LogPair);
			return new FlagChallengeMonLevel?(rootAsFlagChallengeMonLevel);
		}

		// Token: 0x040014C1 RID: 5313
		private const string DB = "db_flagchallenge.db";

		// Token: 0x040014C2 RID: 5314
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x040014C3 RID: 5315
		private const string TABLE = "FlagChallengeMonLevel";

		// Token: 0x040014C4 RID: 5316
		private const string COMMAND = "select BinData from `FlagChallengeMonLevel` where Id=?";

		// Token: 0x040014C5 RID: 5317
		private const string KEY_PREFIX = "FlagChallengeMonLevelById";

		// Token: 0x040014C6 RID: 5318
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014C7 RID: 5319
		private static int HandleId;
	}
}
