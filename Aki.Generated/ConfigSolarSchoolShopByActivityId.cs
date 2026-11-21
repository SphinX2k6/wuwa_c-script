using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A22 RID: 2594
	public class ConfigSolarSchoolShopByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CE0 RID: 15584 RVA: 0x001B4C1F File Offset: 0x001B2E1F
		static ConfigSolarSchoolShopByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolShopByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolShopByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x001B4C40 File Offset: 0x001B2E40
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolShopByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolShopByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolShop"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolShop` where ActivityId=?")
			});
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x001B4CBF File Offset: 0x001B2EBF
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolShopByActivityId.LogPair = null;
			ConfigSolarSchoolShopByActivityId.HandleId = 0;
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x001B4CCD File Offset: 0x001B2ECD
		public static void Init()
		{
			ConfigSolarSchoolShopByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolShopByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolShop` where ActivityId=?");
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x001B4CE8 File Offset: 0x001B2EE8
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolShop> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolShopByActivityId.HandleId, ConfigSolarSchoolShopByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolShopByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolShop> readOnlyList = (IReadOnlyList<SolarSchoolShop>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolShopByActivityId.LogPair.Clear();
			ConfigSolarSchoolShopByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolShopByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolShopByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolShopByActivityId.HandleId, ConfigSolarSchoolShopByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolShop> list = new List<SolarSchoolShop>();
			while (ConfigCommon.Step(ConfigSolarSchoolShopByActivityId.HandleId, false, ConfigSolarSchoolShopByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolShopByActivityId.HandleId, 0, ConfigSolarSchoolShopByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolShopByActivityId.HandleId, ConfigSolarSchoolShopByActivityId.LogPair);
					return null;
				}
				SolarSchoolShop rootAsSolarSchoolShop = SolarSchoolShop.GetRootAsSolarSchoolShop(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolShop);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolShopByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolShopByActivityId.HandleId, ConfigSolarSchoolShopByActivityId.LogPair);
			return list;
		}

		// Token: 0x040046D4 RID: 18132
		private const string DB = "db_solarschool.db";

		// Token: 0x040046D5 RID: 18133
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x040046D6 RID: 18134
		private const string TABLE = "SolarSchoolShop";

		// Token: 0x040046D7 RID: 18135
		private const string COMMAND = "select BinData from `SolarSchoolShop` where ActivityId=?";

		// Token: 0x040046D8 RID: 18136
		private const string KEY_PREFIX = "SolarSchoolShopByActivityId";

		// Token: 0x040046D9 RID: 18137
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046DA RID: 18138
		private static int HandleId;
	}
}
