using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000925 RID: 2341
	public class ConfigShopFixedByShopIdAndId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036F1 RID: 14065 RVA: 0x0018FFCB File Offset: 0x0018E1CB
		static ConfigShopFixedByShopIdAndId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigShopFixedByShopIdAndId.CreateStaticDefaultValue), new Action(ConfigShopFixedByShopIdAndId.ResetStaticDefaultValue));
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x0018FFEC File Offset: 0x0018E1EC
		public static void CreateStaticDefaultValue()
		{
			ConfigShopFixedByShopIdAndId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigShopFixedByShopIdAndId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shop.db"),
				new ValueTuple<string, object>("文件", "s.商城.xlsx"),
				new ValueTuple<string, object>("表名", "ShopFixed"),
				new ValueTuple<string, object>("语句", "select BinData from `ShopFixed` where ShopId =? AND Id = ?")
			});
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x0019006B File Offset: 0x0018E26B
		public static void ResetStaticDefaultValue()
		{
			ConfigShopFixedByShopIdAndId.LogPair = null;
			ConfigShopFixedByShopIdAndId.HandleId = 0;
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x00190079 File Offset: 0x0018E279
		public static void Init()
		{
			ConfigShopFixedByShopIdAndId.HandleId = ConfigCommon.InitDataStatement(ConfigShopFixedByShopIdAndId.HandleId, "db_shop.db", "select BinData from `ShopFixed` where ShopId =? AND Id = ?");
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00190094 File Offset: 0x0018E294
		public static ShopFixed? GetConfig(int p0ShopId, int p1Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigShopFixedByShopIdAndId.HandleId, ConfigShopFixedByShopIdAndId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("ShopFixedByShopIdAndId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShopId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ShopFixed?(ShopFixed.GetRootAsShopFixed(configBuffer));
				}
			}
			ConfigShopFixedByShopIdAndId.LogPair.Clear();
			ConfigShopFixedByShopIdAndId.LogPair.Add(new ValueTuple<string, object>("ShopId", p0ShopId));
			ConfigShopFixedByShopIdAndId.LogPair.Add(new ValueTuple<string, object>("Id", p1Id));
			if (!ConfigCommon.BindInt(ConfigShopFixedByShopIdAndId.HandleId, 1, p0ShopId, ConfigShopFixedByShopIdAndId.LogPair) || !ConfigCommon.BindInt(ConfigShopFixedByShopIdAndId.HandleId, 2, p1Id, ConfigShopFixedByShopIdAndId.LogPair) || ConfigCommon.Step(ConfigShopFixedByShopIdAndId.HandleId, true, ConfigShopFixedByShopIdAndId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigShopFixedByShopIdAndId.HandleId, ConfigShopFixedByShopIdAndId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigShopFixedByShopIdAndId.HandleId, 0, ConfigShopFixedByShopIdAndId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigShopFixedByShopIdAndId.HandleId, ConfigShopFixedByShopIdAndId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ShopFixed rootAsShopFixed = ShopFixed.GetRootAsShopFixed(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("ShopFixedByShopIdAndId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShopId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigShopFixedByShopIdAndId.HandleId, ConfigShopFixedByShopIdAndId.LogPair);
			return new ShopFixed?(rootAsShopFixed);
		}

		// Token: 0x04003FE9 RID: 16361
		private const string DB = "db_shop.db";

		// Token: 0x04003FEA RID: 16362
		private const string FILE = "s.商城.xlsx";

		// Token: 0x04003FEB RID: 16363
		private const string TABLE = "ShopFixed";

		// Token: 0x04003FEC RID: 16364
		private const string COMMAND = "select BinData from `ShopFixed` where ShopId =? AND Id = ?";

		// Token: 0x04003FED RID: 16365
		private const string KEY_PREFIX = "ShopFixedByShopIdAndId";

		// Token: 0x04003FEE RID: 16366
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FEF RID: 16367
		private static int HandleId;
	}
}
