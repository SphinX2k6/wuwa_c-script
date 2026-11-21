using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F1 RID: 497
	public class ConfigDangoBrawlScoreRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BA9 RID: 2985 RVA: 0x0009F138 File Offset: 0x0009D338
		static ConfigDangoBrawlScoreRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlScoreRewardAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlScoreRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0009F158 File Offset: 0x0009D358
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlScoreRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlScoreRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlScoreReward`")
			});
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0009F1D7 File Offset: 0x0009D3D7
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlScoreRewardAll.LogPair = null;
			ConfigDangoBrawlScoreRewardAll.HandleId = 0;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0009F1E5 File Offset: 0x0009D3E5
		public static void Init()
		{
			ConfigDangoBrawlScoreRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlScoreRewardAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlScoreReward`");
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0009F200 File Offset: 0x0009D400
		[NullableContext(2)]
		public static IReadOnlyList<DangoBrawlScoreReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlScoreRewardAll.HandleId, ConfigDangoBrawlScoreRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DangoBrawlScoreReward> readOnlyList = (IReadOnlyList<DangoBrawlScoreReward>)ConfigCommon.GetConfig("DangoBrawlScoreRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DangoBrawlScoreReward> list = new List<DangoBrawlScoreReward>();
			while (ConfigCommon.Step(ConfigDangoBrawlScoreRewardAll.HandleId, false, ConfigDangoBrawlScoreRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlScoreRewardAll.HandleId, 0, ConfigDangoBrawlScoreRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoBrawlScoreRewardAll.HandleId, ConfigDangoBrawlScoreRewardAll.LogPair);
					return null;
				}
				DangoBrawlScoreReward rootAsDangoBrawlScoreReward = DangoBrawlScoreReward.GetRootAsDangoBrawlScoreReward(new ByteBuffer(item2));
				list.Add(rootAsDangoBrawlScoreReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DangoBrawlScoreRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoBrawlScoreRewardAll.HandleId, ConfigDangoBrawlScoreRewardAll.LogPair);
			return list;
		}

		// Token: 0x04000D7B RID: 3451
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D7C RID: 3452
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D7D RID: 3453
		private const string TABLE = "DangoBrawlScoreReward";

		// Token: 0x04000D7E RID: 3454
		private const string COMMAND = "select BinData from `DangoBrawlScoreReward`";

		// Token: 0x04000D7F RID: 3455
		private const string KEY_PREFIX = "DangoBrawlScoreRewardAll";

		// Token: 0x04000D80 RID: 3456
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D81 RID: 3457
		private static int HandleId;
	}
}
