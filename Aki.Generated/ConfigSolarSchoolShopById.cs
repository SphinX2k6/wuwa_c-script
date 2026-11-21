using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A23 RID: 2595
	public class ConfigSolarSchoolShopById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CE6 RID: 15590 RVA: 0x001B4E57 File Offset: 0x001B3057
		static ConfigSolarSchoolShopById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolShopById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolShopById.ResetStaticDefaultValue));
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x001B4E78 File Offset: 0x001B3078
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolShopById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolShopById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolShop"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolShop` where Id=?")
			});
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x001B4EF7 File Offset: 0x001B30F7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolShopById.LogPair = null;
			ConfigSolarSchoolShopById.HandleId = 0;
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x001B4F05 File Offset: 0x001B3105
		public static void Init()
		{
			ConfigSolarSchoolShopById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolShopById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolShop` where Id=?");
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x001B4F20 File Offset: 0x001B3120
		public static SolarSchoolShop? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolShopById.HandleId, ConfigSolarSchoolShopById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolShopById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolShop?(SolarSchoolShop.GetRootAsSolarSchoolShop(configBuffer));
				}
			}
			ConfigSolarSchoolShopById.LogPair.Clear();
			ConfigSolarSchoolShopById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolShopById.HandleId, 1, p0Id, ConfigSolarSchoolShopById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolShopById.HandleId, true, ConfigSolarSchoolShopById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolShopById.HandleId, ConfigSolarSchoolShopById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolShopById.HandleId, 0, ConfigSolarSchoolShopById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolShopById.HandleId, ConfigSolarSchoolShopById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolShop rootAsSolarSchoolShop = SolarSchoolShop.GetRootAsSolarSchoolShop(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolShopById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolShopById.HandleId, ConfigSolarSchoolShopById.LogPair);
			return new SolarSchoolShop?(rootAsSolarSchoolShop);
		}

		// Token: 0x040046DB RID: 18139
		private const string DB = "db_solarschool.db";

		// Token: 0x040046DC RID: 18140
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x040046DD RID: 18141
		private const string TABLE = "SolarSchoolShop";

		// Token: 0x040046DE RID: 18142
		private const string COMMAND = "select BinData from `SolarSchoolShop` where Id=?";

		// Token: 0x040046DF RID: 18143
		private const string KEY_PREFIX = "SolarSchoolShopById";

		// Token: 0x040046E0 RID: 18144
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046E1 RID: 18145
		private static int HandleId;
	}
}
