using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A24 RID: 2596
	public class ConfigSolarSchoolShopGoodsAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CEC RID: 15596 RVA: 0x001B50A0 File Offset: 0x001B32A0
		static ConfigSolarSchoolShopGoodsAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolShopGoodsAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolShopGoodsAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x001B50C0 File Offset: 0x001B32C0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolShopGoodsAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolShopGoodsAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolShopGoods"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolShopGoods`")
			});
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x001B513F File Offset: 0x001B333F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolShopGoodsAll.LogPair = null;
			ConfigSolarSchoolShopGoodsAll.HandleId = 0;
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x001B514D File Offset: 0x001B334D
		public static void Init()
		{
			ConfigSolarSchoolShopGoodsAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolShopGoodsAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolShopGoods`");
		}

		// Token: 0x06003CF0 RID: 15600 RVA: 0x001B5168 File Offset: 0x001B3368
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolShopGoods> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolShopGoodsAll.HandleId, ConfigSolarSchoolShopGoodsAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolShopGoods> readOnlyList = (IReadOnlyList<SolarSchoolShopGoods>)ConfigCommon.GetConfig("SolarSchoolShopGoodsAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolShopGoods> list = new List<SolarSchoolShopGoods>();
			while (ConfigCommon.Step(ConfigSolarSchoolShopGoodsAll.HandleId, false, ConfigSolarSchoolShopGoodsAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolShopGoodsAll.HandleId, 0, ConfigSolarSchoolShopGoodsAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolShopGoodsAll.HandleId, ConfigSolarSchoolShopGoodsAll.LogPair);
					return null;
				}
				SolarSchoolShopGoods rootAsSolarSchoolShopGoods = SolarSchoolShopGoods.GetRootAsSolarSchoolShopGoods(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolShopGoods);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolShopGoodsAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolShopGoodsAll.HandleId, ConfigSolarSchoolShopGoodsAll.LogPair);
			return list;
		}

		// Token: 0x040046E2 RID: 18146
		private const string DB = "db_solarschool.db";

		// Token: 0x040046E3 RID: 18147
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x040046E4 RID: 18148
		private const string TABLE = "SolarSchoolShopGoods";

		// Token: 0x040046E5 RID: 18149
		private const string COMMAND = "select BinData from `SolarSchoolShopGoods`";

		// Token: 0x040046E6 RID: 18150
		private const string KEY_PREFIX = "SolarSchoolShopGoodsAll";

		// Token: 0x040046E7 RID: 18151
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046E8 RID: 18152
		private static int HandleId;
	}
}
