using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A21 RID: 2593
	public class ConfigSolarSchoolShopAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CDA RID: 15578 RVA: 0x001B4A8B File Offset: 0x001B2C8B
		static ConfigSolarSchoolShopAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolShopAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolShopAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x001B4AAC File Offset: 0x001B2CAC
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolShopAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolShopAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolShop"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolShop`")
			});
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x001B4B2B File Offset: 0x001B2D2B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolShopAll.LogPair = null;
			ConfigSolarSchoolShopAll.HandleId = 0;
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x001B4B39 File Offset: 0x001B2D39
		public static void Init()
		{
			ConfigSolarSchoolShopAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolShopAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolShop`");
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x001B4B54 File Offset: 0x001B2D54
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolShop> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolShopAll.HandleId, ConfigSolarSchoolShopAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolShop> readOnlyList = (IReadOnlyList<SolarSchoolShop>)ConfigCommon.GetConfig("SolarSchoolShopAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolShop> list = new List<SolarSchoolShop>();
			while (ConfigCommon.Step(ConfigSolarSchoolShopAll.HandleId, false, ConfigSolarSchoolShopAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolShopAll.HandleId, 0, ConfigSolarSchoolShopAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolShopAll.HandleId, ConfigSolarSchoolShopAll.LogPair);
					return null;
				}
				SolarSchoolShop rootAsSolarSchoolShop = SolarSchoolShop.GetRootAsSolarSchoolShop(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolShop);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolShopAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolShopAll.HandleId, ConfigSolarSchoolShopAll.LogPair);
			return list;
		}

		// Token: 0x040046CD RID: 18125
		private const string DB = "db_solarschool.db";

		// Token: 0x040046CE RID: 18126
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x040046CF RID: 18127
		private const string TABLE = "SolarSchoolShop";

		// Token: 0x040046D0 RID: 18128
		private const string COMMAND = "select BinData from `SolarSchoolShop`";

		// Token: 0x040046D1 RID: 18129
		private const string KEY_PREFIX = "SolarSchoolShopAll";

		// Token: 0x040046D2 RID: 18130
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046D3 RID: 18131
		private static int HandleId;
	}
}
