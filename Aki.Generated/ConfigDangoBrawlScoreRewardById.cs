using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F2 RID: 498
	public class ConfigDangoBrawlScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BAF RID: 2991 RVA: 0x0009F2CB File Offset: 0x0009D4CB
		static ConfigDangoBrawlScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlScoreRewardById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0009F2EC File Offset: 0x0009D4EC
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlScoreReward` where Id=?")
			});
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0009F36B File Offset: 0x0009D56B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlScoreRewardById.LogPair = null;
			ConfigDangoBrawlScoreRewardById.HandleId = 0;
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0009F379 File Offset: 0x0009D579
		public static void Init()
		{
			ConfigDangoBrawlScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlScoreRewardById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlScoreReward` where Id=?");
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0009F394 File Offset: 0x0009D594
		public static DangoBrawlScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlScoreRewardById.HandleId, ConfigDangoBrawlScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlScoreReward?(DangoBrawlScoreReward.GetRootAsDangoBrawlScoreReward(configBuffer));
				}
			}
			ConfigDangoBrawlScoreRewardById.LogPair.Clear();
			ConfigDangoBrawlScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlScoreRewardById.HandleId, 1, p0Id, ConfigDangoBrawlScoreRewardById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlScoreRewardById.HandleId, true, ConfigDangoBrawlScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlScoreRewardById.HandleId, ConfigDangoBrawlScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlScoreRewardById.HandleId, 0, ConfigDangoBrawlScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlScoreRewardById.HandleId, ConfigDangoBrawlScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlScoreReward rootAsDangoBrawlScoreReward = DangoBrawlScoreReward.GetRootAsDangoBrawlScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlScoreRewardById.HandleId, ConfigDangoBrawlScoreRewardById.LogPair);
			return new DangoBrawlScoreReward?(rootAsDangoBrawlScoreReward);
		}

		// Token: 0x04000D82 RID: 3458
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D83 RID: 3459
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D84 RID: 3460
		private const string TABLE = "DangoBrawlScoreReward";

		// Token: 0x04000D85 RID: 3461
		private const string COMMAND = "select BinData from `DangoBrawlScoreReward` where Id=?";

		// Token: 0x04000D86 RID: 3462
		private const string KEY_PREFIX = "DangoBrawlScoreRewardById";

		// Token: 0x04000D87 RID: 3463
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D88 RID: 3464
		private static int HandleId;
	}
}
