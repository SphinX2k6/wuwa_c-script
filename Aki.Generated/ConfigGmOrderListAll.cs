using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A5 RID: 933
	public class ConfigGmOrderListAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015E5 RID: 5605 RVA: 0x000D54F0 File Offset: 0x000D36F0
		static ConfigGmOrderListAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmOrderListAll.CreateStaticDefaultValue), new Action(ConfigGmOrderListAll.ResetStaticDefaultValue));
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x000D5510 File Offset: 0x000D3710
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

		// Token: 0x060015E7 RID: 5607 RVA: 0x000D558F File Offset: 0x000D378F
		public static void ResetStaticDefaultValue()
		{
			ConfigGmOrderListAll.LogPair = null;
			ConfigGmOrderListAll.HandleId = 0;
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x000D559D File Offset: 0x000D379D
		public static void Init()
		{
			ConfigGmOrderListAll.HandleId = ConfigCommon.InitDataStatement(ConfigGmOrderListAll.HandleId, "db_gm.db", "select BinData from `GmOrderList`");
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x000D55B8 File Offset: 0x000D37B8
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

		// Token: 0x04001967 RID: 6503
		private const string DB = "db_gm.db";

		// Token: 0x04001968 RID: 6504
		private const string FILE = "g.GM.xlsx";

		// Token: 0x04001969 RID: 6505
		private const string TABLE = "GmOrderList";

		// Token: 0x0400196A RID: 6506
		private const string COMMAND = "select BinData from `GmOrderList`";

		// Token: 0x0400196B RID: 6507
		private const string KEY_PREFIX = "GmOrderListAll";

		// Token: 0x0400196C RID: 6508
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400196D RID: 6509
		private static int HandleId;
	}
}
