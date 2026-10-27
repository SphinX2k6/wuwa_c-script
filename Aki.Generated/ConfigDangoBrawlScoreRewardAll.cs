using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001DF RID: 479
	public class ConfigDangoBrawlScoreRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B3D RID: 2877 RVA: 0x00099200 File Offset: 0x00097400
		static ConfigDangoBrawlScoreRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlScoreRewardAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlScoreRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00099220 File Offset: 0x00097420
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

		// Token: 0x06000B3F RID: 2879 RVA: 0x0009929F File Offset: 0x0009749F
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlScoreRewardAll.LogPair = null;
			ConfigDangoBrawlScoreRewardAll.HandleId = 0;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000992AD File Offset: 0x000974AD
		public static void Init()
		{
			ConfigDangoBrawlScoreRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlScoreRewardAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlScoreReward`");
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000992C8 File Offset: 0x000974C8
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

		// Token: 0x04000CFD RID: 3325
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CFE RID: 3326
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CFF RID: 3327
		private const string TABLE = "DangoBrawlScoreReward";

		// Token: 0x04000D00 RID: 3328
		private const string COMMAND = "select BinData from `DangoBrawlScoreReward`";

		// Token: 0x04000D01 RID: 3329
		private const string KEY_PREFIX = "DangoBrawlScoreRewardAll";

		// Token: 0x04000D02 RID: 3330
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D03 RID: 3331
		private static int HandleId;
	}
}
