using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001EC RID: 492
	public class ConfigDangoBrawlRewardTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B8B RID: 2955 RVA: 0x0009E694 File Offset: 0x0009C894
		static ConfigDangoBrawlRewardTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlRewardTabAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlRewardTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0009E6B4 File Offset: 0x0009C8B4
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlRewardTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlRewardTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlRewardTab"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlRewardTab`")
			});
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0009E733 File Offset: 0x0009C933
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlRewardTabAll.LogPair = null;
			ConfigDangoBrawlRewardTabAll.HandleId = 0;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0009E741 File Offset: 0x0009C941
		public static void Init()
		{
			ConfigDangoBrawlRewardTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlRewardTabAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlRewardTab`");
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0009E75C File Offset: 0x0009C95C
		[NullableContext(2)]
		public static IReadOnlyList<DangoBrawlRewardTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlRewardTabAll.HandleId, ConfigDangoBrawlRewardTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DangoBrawlRewardTab> readOnlyList = (IReadOnlyList<DangoBrawlRewardTab>)ConfigCommon.GetConfig("DangoBrawlRewardTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DangoBrawlRewardTab> list = new List<DangoBrawlRewardTab>();
			while (ConfigCommon.Step(ConfigDangoBrawlRewardTabAll.HandleId, false, ConfigDangoBrawlRewardTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlRewardTabAll.HandleId, 0, ConfigDangoBrawlRewardTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoBrawlRewardTabAll.HandleId, ConfigDangoBrawlRewardTabAll.LogPair);
					return null;
				}
				DangoBrawlRewardTab rootAsDangoBrawlRewardTab = DangoBrawlRewardTab.GetRootAsDangoBrawlRewardTab(new ByteBuffer(item2));
				list.Add(rootAsDangoBrawlRewardTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DangoBrawlRewardTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoBrawlRewardTabAll.HandleId, ConfigDangoBrawlRewardTabAll.LogPair);
			return list;
		}

		// Token: 0x04000D58 RID: 3416
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D59 RID: 3417
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D5A RID: 3418
		private const string TABLE = "DangoBrawlRewardTab";

		// Token: 0x04000D5B RID: 3419
		private const string COMMAND = "select BinData from `DangoBrawlRewardTab`";

		// Token: 0x04000D5C RID: 3420
		private const string KEY_PREFIX = "DangoBrawlRewardTabAll";

		// Token: 0x04000D5D RID: 3421
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D5E RID: 3422
		private static int HandleId;
	}
}
