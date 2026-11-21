using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001DC RID: 476
	public class ConfigDangoBrawlItemComposeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B2B RID: 2859 RVA: 0x0009C4F4 File Offset: 0x0009A6F4
		static ConfigDangoBrawlItemComposeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemComposeAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemComposeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0009C514 File Offset: 0x0009A714
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

		// Token: 0x06000B2D RID: 2861 RVA: 0x0009C593 File Offset: 0x0009A793
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemComposeAll.LogPair = null;
			ConfigDangoBrawlItemComposeAll.HandleId = 0;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0009C5A1 File Offset: 0x0009A7A1
		public static void Init()
		{
			ConfigDangoBrawlItemComposeAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemComposeAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemCompose`");
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0009C5BC File Offset: 0x0009A7BC
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

		// Token: 0x04000CE8 RID: 3304
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CE9 RID: 3305
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000CEA RID: 3306
		private const string TABLE = "DangoBrawlItemCompose";

		// Token: 0x04000CEB RID: 3307
		private const string COMMAND = "select BinData from `DangoBrawlItemCompose`";

		// Token: 0x04000CEC RID: 3308
		private const string KEY_PREFIX = "DangoBrawlItemComposeAll";

		// Token: 0x04000CED RID: 3309
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CEE RID: 3310
		private static int HandleId;
	}
}
