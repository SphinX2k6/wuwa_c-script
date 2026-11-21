using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A28 RID: 2600
	public class ConfigSolarSchoolShopRefreshByShopIdAndWeek : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D04 RID: 15620 RVA: 0x001B5837 File Offset: 0x001B3A37
		static ConfigSolarSchoolShopRefreshByShopIdAndWeek()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolShopRefreshByShopIdAndWeek.CreateStaticDefaultValue), new Action(ConfigSolarSchoolShopRefreshByShopIdAndWeek.ResetStaticDefaultValue));
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x001B5858 File Offset: 0x001B3A58
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolShopRefresh"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolShopRefresh` where ShopId=? AND Week=?")
			});
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x001B58D7 File Offset: 0x001B3AD7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair = null;
			ConfigSolarSchoolShopRefreshByShopIdAndWeek.HandleId = 0;
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x001B58E5 File Offset: 0x001B3AE5
		public static void Init()
		{
			ConfigSolarSchoolShopRefreshByShopIdAndWeek.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolShopRefreshByShopIdAndWeek.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolShopRefresh` where ShopId=? AND Week=?");
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x001B5900 File Offset: 0x001B3B00
		public static SolarSchoolShopRefresh? GetConfig(int p0ShopId, int p1Week, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolShopRefreshByShopIdAndWeek.HandleId, ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolShopRefreshByShopIdAndWeek");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShopId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Week);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolShopRefresh?(SolarSchoolShopRefresh.GetRootAsSolarSchoolShopRefresh(configBuffer));
				}
			}
			ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair.Clear();
			ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair.Add(new ValueTuple<string, object>("ShopId", p0ShopId));
			ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair.Add(new ValueTuple<string, object>("Week", p1Week));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolShopRefreshByShopIdAndWeek.HandleId, 1, p0ShopId, ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair) || !ConfigCommon.BindInt(ConfigSolarSchoolShopRefreshByShopIdAndWeek.HandleId, 2, p1Week, ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair) || ConfigCommon.Step(ConfigSolarSchoolShopRefreshByShopIdAndWeek.HandleId, true, ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolShopRefreshByShopIdAndWeek.HandleId, ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolShopRefreshByShopIdAndWeek.HandleId, 0, ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolShopRefreshByShopIdAndWeek.HandleId, ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolShopRefresh rootAsSolarSchoolShopRefresh = SolarSchoolShopRefresh.GetRootAsSolarSchoolShopRefresh(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolShopRefreshByShopIdAndWeek");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShopId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Week);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolShopRefreshByShopIdAndWeek.HandleId, ConfigSolarSchoolShopRefreshByShopIdAndWeek.LogPair);
			return new SolarSchoolShopRefresh?(rootAsSolarSchoolShopRefresh);
		}

		// Token: 0x040046FE RID: 18174
		private const string DB = "db_solarschool.db";

		// Token: 0x040046FF RID: 18175
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x04004700 RID: 18176
		private const string TABLE = "SolarSchoolShopRefresh";

		// Token: 0x04004701 RID: 18177
		private const string COMMAND = "select BinData from `SolarSchoolShopRefresh` where ShopId=? AND Week=?";

		// Token: 0x04004702 RID: 18178
		private const string KEY_PREFIX = "SolarSchoolShopRefreshByShopIdAndWeek";

		// Token: 0x04004703 RID: 18179
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004704 RID: 18180
		private static int HandleId;
	}
}
