using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A27 RID: 2599
	public class ConfigSolarSchoolShopRefreshByShopId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CFE RID: 15614 RVA: 0x001B55FF File Offset: 0x001B37FF
		static ConfigSolarSchoolShopRefreshByShopId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolShopRefreshByShopId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolShopRefreshByShopId.ResetStaticDefaultValue));
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x001B5620 File Offset: 0x001B3820
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolShopRefreshByShopId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolShopRefreshByShopId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolShopRefresh"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolShopRefresh` where ShopId=?")
			});
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x001B569F File Offset: 0x001B389F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolShopRefreshByShopId.LogPair = null;
			ConfigSolarSchoolShopRefreshByShopId.HandleId = 0;
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x001B56AD File Offset: 0x001B38AD
		public static void Init()
		{
			ConfigSolarSchoolShopRefreshByShopId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolShopRefreshByShopId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolShopRefresh` where ShopId=?");
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x001B56C8 File Offset: 0x001B38C8
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolShopRefresh> GetConfigList(int p0ShopId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolShopRefreshByShopId.HandleId, ConfigSolarSchoolShopRefreshByShopId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolShopRefreshByShopId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShopId);
				IReadOnlyList<SolarSchoolShopRefresh> readOnlyList = (IReadOnlyList<SolarSchoolShopRefresh>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolShopRefreshByShopId.LogPair.Clear();
			ConfigSolarSchoolShopRefreshByShopId.LogPair.Add(new ValueTuple<string, object>("ShopId", p0ShopId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolShopRefreshByShopId.HandleId, 1, p0ShopId, ConfigSolarSchoolShopRefreshByShopId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolShopRefreshByShopId.HandleId, ConfigSolarSchoolShopRefreshByShopId.LogPair);
				return null;
			}
			List<SolarSchoolShopRefresh> list = new List<SolarSchoolShopRefresh>();
			while (ConfigCommon.Step(ConfigSolarSchoolShopRefreshByShopId.HandleId, false, ConfigSolarSchoolShopRefreshByShopId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolShopRefreshByShopId.HandleId, 0, ConfigSolarSchoolShopRefreshByShopId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolShopRefreshByShopId.HandleId, ConfigSolarSchoolShopRefreshByShopId.LogPair);
					return null;
				}
				SolarSchoolShopRefresh rootAsSolarSchoolShopRefresh = SolarSchoolShopRefresh.GetRootAsSolarSchoolShopRefresh(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolShopRefresh);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolShopRefreshByShopId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShopId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolShopRefreshByShopId.HandleId, ConfigSolarSchoolShopRefreshByShopId.LogPair);
			return list;
		}

		// Token: 0x040046F7 RID: 18167
		private const string DB = "db_solarschool.db";

		// Token: 0x040046F8 RID: 18168
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x040046F9 RID: 18169
		private const string TABLE = "SolarSchoolShopRefresh";

		// Token: 0x040046FA RID: 18170
		private const string COMMAND = "select BinData from `SolarSchoolShopRefresh` where ShopId=?";

		// Token: 0x040046FB RID: 18171
		private const string KEY_PREFIX = "SolarSchoolShopRefreshByShopId";

		// Token: 0x040046FC RID: 18172
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046FD RID: 18173
		private static int HandleId;
	}
}
