using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000310 RID: 784
	public class ConfigFlagChallengeMonLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001265 RID: 4709 RVA: 0x000C4FCB File Offset: 0x000C31CB
		static ConfigFlagChallengeMonLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeMonLevelById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeMonLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000C4FEC File Offset: 0x000C31EC
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

		// Token: 0x06001267 RID: 4711 RVA: 0x000C506B File Offset: 0x000C326B
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeMonLevelById.LogPair = null;
			ConfigFlagChallengeMonLevelById.HandleId = 0;
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x000C5079 File Offset: 0x000C3279
		public static void Init()
		{
			ConfigFlagChallengeMonLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeMonLevelById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeMonLevel` where Id=?");
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x000C5094 File Offset: 0x000C3294
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

		// Token: 0x04001554 RID: 5460
		private const string DB = "db_flagchallenge.db";

		// Token: 0x04001555 RID: 5461
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x04001556 RID: 5462
		private const string TABLE = "FlagChallengeMonLevel";

		// Token: 0x04001557 RID: 5463
		private const string COMMAND = "select BinData from `FlagChallengeMonLevel` where Id=?";

		// Token: 0x04001558 RID: 5464
		private const string KEY_PREFIX = "FlagChallengeMonLevelById";

		// Token: 0x04001559 RID: 5465
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400155A RID: 5466
		private static int HandleId;
	}
}
