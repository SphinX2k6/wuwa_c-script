using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001DA RID: 474
	public class ConfigDangoBrawlItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B1F RID: 2847 RVA: 0x0009C118 File Offset: 0x0009A318
		static ConfigDangoBrawlItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0009C138 File Offset: 0x0009A338
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗局内.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlItem"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlItem`")
			});
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0009C1B7 File Offset: 0x0009A3B7
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemAll.LogPair = null;
			ConfigDangoBrawlItemAll.HandleId = 0;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0009C1C5 File Offset: 0x0009A3C5
		public static void Init()
		{
			ConfigDangoBrawlItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItem`");
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0009C1E0 File Offset: 0x0009A3E0
		[NullableContext(2)]
		public static IReadOnlyList<DangoBrawlItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlItemAll.HandleId, ConfigDangoBrawlItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DangoBrawlItem> readOnlyList = (IReadOnlyList<DangoBrawlItem>)ConfigCommon.GetConfig("DangoBrawlItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DangoBrawlItem> list = new List<DangoBrawlItem>();
			while (ConfigCommon.Step(ConfigDangoBrawlItemAll.HandleId, false, ConfigDangoBrawlItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlItemAll.HandleId, 0, ConfigDangoBrawlItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoBrawlItemAll.HandleId, ConfigDangoBrawlItemAll.LogPair);
					return null;
				}
				DangoBrawlItem rootAsDangoBrawlItem = DangoBrawlItem.GetRootAsDangoBrawlItem(new ByteBuffer(item2));
				list.Add(rootAsDangoBrawlItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DangoBrawlItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoBrawlItemAll.HandleId, ConfigDangoBrawlItemAll.LogPair);
			return list;
		}

		// Token: 0x04000CDA RID: 3290
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CDB RID: 3291
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000CDC RID: 3292
		private const string TABLE = "DangoBrawlItem";

		// Token: 0x04000CDD RID: 3293
		private const string COMMAND = "select BinData from `DangoBrawlItem`";

		// Token: 0x04000CDE RID: 3294
		private const string KEY_PREFIX = "DangoBrawlItemAll";

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
