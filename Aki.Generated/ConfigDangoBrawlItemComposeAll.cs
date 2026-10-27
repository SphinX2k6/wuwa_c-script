using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001CA RID: 458
	public class ConfigDangoBrawlItemComposeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000ABF RID: 2751 RVA: 0x000965BC File Offset: 0x000947BC
		static ConfigDangoBrawlItemComposeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemComposeAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemComposeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x000965DC File Offset: 0x000947DC
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlItemComposeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlItemComposeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗局内.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlItemCompose"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlItemCompose`")
			});
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0009665B File Offset: 0x0009485B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemComposeAll.LogPair = null;
			ConfigDangoBrawlItemComposeAll.HandleId = 0;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00096669 File Offset: 0x00094869
		public static void Init()
		{
			ConfigDangoBrawlItemComposeAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemComposeAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemCompose`");
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00096684 File Offset: 0x00094884
		[NullableContext(2)]
		public static IReadOnlyList<DangoBrawlItemCompose> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlItemComposeAll.HandleId, ConfigDangoBrawlItemComposeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DangoBrawlItemCompose> readOnlyList = (IReadOnlyList<DangoBrawlItemCompose>)ConfigCommon.GetConfig("DangoBrawlItemComposeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DangoBrawlItemCompose> list = new List<DangoBrawlItemCompose>();
			while (ConfigCommon.Step(ConfigDangoBrawlItemComposeAll.HandleId, false, ConfigDangoBrawlItemComposeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlItemComposeAll.HandleId, 0, ConfigDangoBrawlItemComposeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoBrawlItemComposeAll.HandleId, ConfigDangoBrawlItemComposeAll.LogPair);
					return null;
				}
				DangoBrawlItemCompose rootAsDangoBrawlItemCompose = DangoBrawlItemCompose.GetRootAsDangoBrawlItemCompose(new ByteBuffer(item2));
				list.Add(rootAsDangoBrawlItemCompose);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DangoBrawlItemComposeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoBrawlItemComposeAll.HandleId, ConfigDangoBrawlItemComposeAll.LogPair);
			return list;
		}

		// Token: 0x04000C6A RID: 3178
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C6B RID: 3179
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000C6C RID: 3180
		private const string TABLE = "DangoBrawlItemCompose";

		// Token: 0x04000C6D RID: 3181
		private const string COMMAND = "select BinData from `DangoBrawlItemCompose`";

		// Token: 0x04000C6E RID: 3182
		private const string KEY_PREFIX = "DangoBrawlItemComposeAll";

		// Token: 0x04000C6F RID: 3183
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C70 RID: 3184
		private static int HandleId;
	}
}
