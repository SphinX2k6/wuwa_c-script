using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A25 RID: 2597
	public class ConfigSolarSchoolShopGoodsByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CF2 RID: 15602 RVA: 0x001B5233 File Offset: 0x001B3433
		static ConfigSolarSchoolShopGoodsByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolShopGoodsByGroupId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolShopGoodsByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x001B5254 File Offset: 0x001B3454
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolShopGoodsByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolShopGoodsByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolShopGoods"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolShopGoods` where GroupId=?")
			});
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x001B52D3 File Offset: 0x001B34D3
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolShopGoodsByGroupId.LogPair = null;
			ConfigSolarSchoolShopGoodsByGroupId.HandleId = 0;
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x001B52E1 File Offset: 0x001B34E1
		public static void Init()
		{
			ConfigSolarSchoolShopGoodsByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolShopGoodsByGroupId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolShopGoods` where GroupId=?");
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x001B52FC File Offset: 0x001B34FC
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolShopGoods> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolShopGoodsByGroupId.HandleId, ConfigSolarSchoolShopGoodsByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolShopGoodsByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<SolarSchoolShopGoods> readOnlyList = (IReadOnlyList<SolarSchoolShopGoods>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolShopGoodsByGroupId.LogPair.Clear();
			ConfigSolarSchoolShopGoodsByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolShopGoodsByGroupId.HandleId, 1, p0GroupId, ConfigSolarSchoolShopGoodsByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolShopGoodsByGroupId.HandleId, ConfigSolarSchoolShopGoodsByGroupId.LogPair);
				return null;
			}
			List<SolarSchoolShopGoods> list = new List<SolarSchoolShopGoods>();
			while (ConfigCommon.Step(ConfigSolarSchoolShopGoodsByGroupId.HandleId, false, ConfigSolarSchoolShopGoodsByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolShopGoodsByGroupId.HandleId, 0, ConfigSolarSchoolShopGoodsByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolShopGoodsByGroupId.HandleId, ConfigSolarSchoolShopGoodsByGroupId.LogPair);
					return null;
				}
				SolarSchoolShopGoods rootAsSolarSchoolShopGoods = SolarSchoolShopGoods.GetRootAsSolarSchoolShopGoods(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolShopGoods);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolShopGoodsByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolShopGoodsByGroupId.HandleId, ConfigSolarSchoolShopGoodsByGroupId.LogPair);
			return list;
		}

		// Token: 0x040046E9 RID: 18153
		private const string DB = "db_solarschool.db";

		// Token: 0x040046EA RID: 18154
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x040046EB RID: 18155
		private const string TABLE = "SolarSchoolShopGoods";

		// Token: 0x040046EC RID: 18156
		private const string COMMAND = "select BinData from `SolarSchoolShopGoods` where GroupId=?";

		// Token: 0x040046ED RID: 18157
		private const string KEY_PREFIX = "SolarSchoolShopGoodsByGroupId";

		// Token: 0x040046EE RID: 18158
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046EF RID: 18159
		private static int HandleId;
	}
}
