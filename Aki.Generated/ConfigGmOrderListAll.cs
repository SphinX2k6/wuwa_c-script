using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003BB RID: 955
	public class ConfigGmOrderListAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001669 RID: 5737 RVA: 0x000DBC44 File Offset: 0x000D9E44
		static ConfigGmOrderListAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmOrderListAll.CreateStaticDefaultValue), new Action(ConfigGmOrderListAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000DBC64 File Offset: 0x000D9E64
		public static void CreateStaticDefaultValue()
		{
			ConfigGmOrderListAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGmOrderListAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gm.db"),
				new ValueTuple<string, object>("文件", "g.GM.xlsx"),
				new ValueTuple<string, object>("表名", "GmOrderList"),
				new ValueTuple<string, object>("语句", "select BinData from `GmOrderList`")
			});
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000DBCE3 File Offset: 0x000D9EE3
		public static void ResetStaticDefaultValue()
		{
			ConfigGmOrderListAll.LogPair = null;
			ConfigGmOrderListAll.HandleId = 0;
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x000DBCF1 File Offset: 0x000D9EF1
		public static void Init()
		{
			ConfigGmOrderListAll.HandleId = ConfigCommon.InitDataStatement(ConfigGmOrderListAll.HandleId, "db_gm.db", "select BinData from `GmOrderList`");
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x000DBD0C File Offset: 0x000D9F0C
		[NullableContext(2)]
		public static IReadOnlyList<GmOrderList> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGmOrderListAll.HandleId, ConfigGmOrderListAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GmOrderList> readOnlyList = (IReadOnlyList<GmOrderList>)ConfigCommon.GetConfig("GmOrderListAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GmOrderList> list = new List<GmOrderList>();
			while (ConfigCommon.Step(ConfigGmOrderListAll.HandleId, false, ConfigGmOrderListAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGmOrderListAll.HandleId, 0, ConfigGmOrderListAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGmOrderListAll.HandleId, ConfigGmOrderListAll.LogPair);
					return null;
				}
				GmOrderList rootAsGmOrderList = GmOrderList.GetRootAsGmOrderList(new ByteBuffer(item2));
				list.Add(rootAsGmOrderList);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GmOrderListAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGmOrderListAll.HandleId, ConfigGmOrderListAll.LogPair);
			return list;
		}

		// Token: 0x04001A01 RID: 6657
		private const string DB = "db_gm.db";

		// Token: 0x04001A02 RID: 6658
		private const string FILE = "g.GM.xlsx";

		// Token: 0x04001A03 RID: 6659
		private const string TABLE = "GmOrderList";

		// Token: 0x04001A04 RID: 6660
		private const string COMMAND = "select BinData from `GmOrderList`";

		// Token: 0x04001A05 RID: 6661
		private const string KEY_PREFIX = "GmOrderListAll";

		// Token: 0x04001A06 RID: 6662
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A07 RID: 6663
		private static int HandleId;
	}
}
