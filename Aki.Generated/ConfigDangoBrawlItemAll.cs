using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C8 RID: 456
	public class ConfigDangoBrawlItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AB3 RID: 2739 RVA: 0x000961E0 File Offset: 0x000943E0
		static ConfigDangoBrawlItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00096200 File Offset: 0x00094400
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

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0009627F File Offset: 0x0009447F
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemAll.LogPair = null;
			ConfigDangoBrawlItemAll.HandleId = 0;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0009628D File Offset: 0x0009448D
		public static void Init()
		{
			ConfigDangoBrawlItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItem`");
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x000962A8 File Offset: 0x000944A8
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

		// Token: 0x04000C5C RID: 3164
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C5D RID: 3165
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000C5E RID: 3166
		private const string TABLE = "DangoBrawlItem";

		// Token: 0x04000C5F RID: 3167
		private const string COMMAND = "select BinData from `DangoBrawlItem`";

		// Token: 0x04000C60 RID: 3168
		private const string KEY_PREFIX = "DangoBrawlItemAll";

		// Token: 0x04000C61 RID: 3169
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C62 RID: 3170
		private static int HandleId;
	}
}
