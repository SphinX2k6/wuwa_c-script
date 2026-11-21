using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000970 RID: 2416
	public class ConfigShopFixedByShopIdAndId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038B3 RID: 14515 RVA: 0x0019D1EB File Offset: 0x0019B3EB
		static ConfigShopFixedByShopIdAndId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigShopFixedByShopIdAndId.CreateStaticDefaultValue), new Action(ConfigShopFixedByShopIdAndId.ResetStaticDefaultValue));
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x0019D20C File Offset: 0x0019B40C
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

		// Token: 0x060038B5 RID: 14517 RVA: 0x0019D28B File Offset: 0x0019B48B
		public static void ResetStaticDefaultValue()
		{
			ConfigShopFixedByShopIdAndId.LogPair = null;
			ConfigShopFixedByShopIdAndId.HandleId = 0;
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x0019D299 File Offset: 0x0019B499
		public static void Init()
		{
			ConfigShopFixedByShopIdAndId.HandleId = ConfigCommon.InitDataStatement(ConfigShopFixedByShopIdAndId.HandleId, "db_shop.db", "select BinData from `ShopFixed` where ShopId =? AND Id = ?");
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x0019D2B4 File Offset: 0x0019B4B4
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

		// Token: 0x040041F6 RID: 16886
		private const string DB = "db_shop.db";

		// Token: 0x040041F7 RID: 16887
		private const string FILE = "s.商城.xlsx";

		// Token: 0x040041F8 RID: 16888
		private const string TABLE = "ShopFixed";

		// Token: 0x040041F9 RID: 16889
		private const string COMMAND = "select BinData from `ShopFixed` where ShopId =? AND Id = ?";

		// Token: 0x040041FA RID: 16890
		private const string KEY_PREFIX = "ShopFixedByShopIdAndId";

		// Token: 0x040041FB RID: 16891
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041FC RID: 16892
		private static int HandleId;
	}
}
