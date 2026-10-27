using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001DA RID: 474
	public class ConfigDangoBrawlRewardTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B1F RID: 2847 RVA: 0x0009875C File Offset: 0x0009695C
		static ConfigDangoBrawlRewardTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlRewardTabAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlRewardTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0009877C File Offset: 0x0009697C
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

		// Token: 0x06000B21 RID: 2849 RVA: 0x000987FB File Offset: 0x000969FB
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlRewardTabAll.LogPair = null;
			ConfigDangoBrawlRewardTabAll.HandleId = 0;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00098809 File Offset: 0x00096A09
		public static void Init()
		{
			ConfigDangoBrawlRewardTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlRewardTabAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlRewardTab`");
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00098824 File Offset: 0x00096A24
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

		// Token: 0x04000CDA RID: 3290
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CDB RID: 3291
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CDC RID: 3292
		private const string TABLE = "DangoBrawlRewardTab";

		// Token: 0x04000CDD RID: 3293
		private const string COMMAND = "select BinData from `DangoBrawlRewardTab`";

		// Token: 0x04000CDE RID: 3294
		private const string KEY_PREFIX = "DangoBrawlRewardTabAll";

		// Token: 0x04000CDF RID: 3295
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CE0 RID: 3296
		private static int HandleId;
	}
}
