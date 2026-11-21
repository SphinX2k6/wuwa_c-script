using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004AA RID: 1194
	public class ConfigKurotatoHandbookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C07 RID: 7175 RVA: 0x000FB630 File Offset: 0x000F9830
		static ConfigKurotatoHandbookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoHandbookAll.CreateStaticDefaultValue), new Action(ConfigKurotatoHandbookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x000FB650 File Offset: 0x000F9850
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoHandbookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoHandbookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoHandbook"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoHandbook`")
			});
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x000FB6CF File Offset: 0x000F98CF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoHandbookAll.LogPair = null;
			ConfigKurotatoHandbookAll.HandleId = 0;
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x000FB6DD File Offset: 0x000F98DD
		public static void Init()
		{
			ConfigKurotatoHandbookAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoHandbookAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoHandbook`");
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x000FB6F8 File Offset: 0x000F98F8
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoHandbook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoHandbookAll.HandleId, ConfigKurotatoHandbookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoHandbook> readOnlyList = (IReadOnlyList<KurotatoHandbook>)ConfigCommon.GetConfig("KurotatoHandbookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoHandbook> list = new List<KurotatoHandbook>();
			while (ConfigCommon.Step(ConfigKurotatoHandbookAll.HandleId, false, ConfigKurotatoHandbookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoHandbookAll.HandleId, 0, ConfigKurotatoHandbookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoHandbookAll.HandleId, ConfigKurotatoHandbookAll.LogPair);
					return null;
				}
				KurotatoHandbook rootAsKurotatoHandbook = KurotatoHandbook.GetRootAsKurotatoHandbook(new ByteBuffer(item2));
				list.Add(rootAsKurotatoHandbook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoHandbookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoHandbookAll.HandleId, ConfigKurotatoHandbookAll.LogPair);
			return list;
		}

		// Token: 0x0400208A RID: 8330
		private const string DB = "db_kurotato.db";

		// Token: 0x0400208B RID: 8331
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x0400208C RID: 8332
		private const string TABLE = "KurotatoHandbook";

		// Token: 0x0400208D RID: 8333
		private const string COMMAND = "select BinData from `KurotatoHandbook`";

		// Token: 0x0400208E RID: 8334
		private const string KEY_PREFIX = "KurotatoHandbookAll";

		// Token: 0x0400208F RID: 8335
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002090 RID: 8336
		private static int HandleId;
	}
}
