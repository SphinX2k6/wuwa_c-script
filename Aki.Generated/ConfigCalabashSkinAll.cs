using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000149 RID: 329
	public class ConfigCalabashSkinAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007B7 RID: 1975 RVA: 0x00088E28 File Offset: 0x00087028
		static ConfigCalabashSkinAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashSkinAll.CreateStaticDefaultValue), new Action(ConfigCalabashSkinAll.ResetStaticDefaultValue));
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00088E48 File Offset: 0x00087048
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashSkinAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashSkinAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashSkin`")
			});
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00088EC7 File Offset: 0x000870C7
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashSkinAll.LogPair = null;
			ConfigCalabashSkinAll.HandleId = 0;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00088ED5 File Offset: 0x000870D5
		public static void Init()
		{
			ConfigCalabashSkinAll.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashSkinAll.HandleId, "db_calabash.db", "select BinData from `CalabashSkin`");
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00088EF0 File Offset: 0x000870F0
		[NullableContext(2)]
		public static IReadOnlyList<CalabashSkin> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashSkinAll.HandleId, ConfigCalabashSkinAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CalabashSkin> readOnlyList = (IReadOnlyList<CalabashSkin>)ConfigCommon.GetConfig("CalabashSkinAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CalabashSkin> list = new List<CalabashSkin>();
			while (ConfigCommon.Step(ConfigCalabashSkinAll.HandleId, false, ConfigCalabashSkinAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashSkinAll.HandleId, 0, ConfigCalabashSkinAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCalabashSkinAll.HandleId, ConfigCalabashSkinAll.LogPair);
					return null;
				}
				CalabashSkin rootAsCalabashSkin = CalabashSkin.GetRootAsCalabashSkin(new ByteBuffer(item2));
				list.Add(rootAsCalabashSkin);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CalabashSkinAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCalabashSkinAll.HandleId, ConfigCalabashSkinAll.LogPair);
			return list;
		}

		// Token: 0x040008E3 RID: 2275
		private const string DB = "db_calabash.db";

		// Token: 0x040008E4 RID: 2276
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x040008E5 RID: 2277
		private const string TABLE = "CalabashSkin";

		// Token: 0x040008E6 RID: 2278
		private const string COMMAND = "select BinData from `CalabashSkin`";

		// Token: 0x040008E7 RID: 2279
		private const string KEY_PREFIX = "CalabashSkinAll";

		// Token: 0x040008E8 RID: 2280
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008E9 RID: 2281
		private static int HandleId;
	}
}
