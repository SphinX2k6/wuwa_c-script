using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A26 RID: 2598
	public class ConfigSolarSchoolShopRefreshAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CF8 RID: 15608 RVA: 0x001B546B File Offset: 0x001B366B
		static ConfigSolarSchoolShopRefreshAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolShopRefreshAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolShopRefreshAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x001B548C File Offset: 0x001B368C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolShopRefreshAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolShopRefreshAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolShopRefresh"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolShopRefresh`")
			});
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x001B550B File Offset: 0x001B370B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolShopRefreshAll.LogPair = null;
			ConfigSolarSchoolShopRefreshAll.HandleId = 0;
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x001B5519 File Offset: 0x001B3719
		public static void Init()
		{
			ConfigSolarSchoolShopRefreshAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolShopRefreshAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolShopRefresh`");
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x001B5534 File Offset: 0x001B3734
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolShopRefresh> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolShopRefreshAll.HandleId, ConfigSolarSchoolShopRefreshAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolShopRefresh> readOnlyList = (IReadOnlyList<SolarSchoolShopRefresh>)ConfigCommon.GetConfig("SolarSchoolShopRefreshAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolShopRefresh> list = new List<SolarSchoolShopRefresh>();
			while (ConfigCommon.Step(ConfigSolarSchoolShopRefreshAll.HandleId, false, ConfigSolarSchoolShopRefreshAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolShopRefreshAll.HandleId, 0, ConfigSolarSchoolShopRefreshAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolShopRefreshAll.HandleId, ConfigSolarSchoolShopRefreshAll.LogPair);
					return null;
				}
				SolarSchoolShopRefresh rootAsSolarSchoolShopRefresh = SolarSchoolShopRefresh.GetRootAsSolarSchoolShopRefresh(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolShopRefresh);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolShopRefreshAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolShopRefreshAll.HandleId, ConfigSolarSchoolShopRefreshAll.LogPair);
			return list;
		}

		// Token: 0x040046F0 RID: 18160
		private const string DB = "db_solarschool.db";

		// Token: 0x040046F1 RID: 18161
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x040046F2 RID: 18162
		private const string TABLE = "SolarSchoolShopRefresh";

		// Token: 0x040046F3 RID: 18163
		private const string COMMAND = "select BinData from `SolarSchoolShopRefresh`";

		// Token: 0x040046F4 RID: 18164
		private const string KEY_PREFIX = "SolarSchoolShopRefreshAll";

		// Token: 0x040046F5 RID: 18165
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046F6 RID: 18166
		private static int HandleId;
	}
}
