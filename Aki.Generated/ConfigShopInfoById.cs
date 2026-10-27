using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000926 RID: 2342
	public class ConfigShopInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036F7 RID: 14071 RVA: 0x00190269 File Offset: 0x0018E469
		static ConfigShopInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigShopInfoById.CreateStaticDefaultValue), new Action(ConfigShopInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x00190288 File Offset: 0x0018E488
		public static void CreateStaticDefaultValue()
		{
			ConfigShopInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigShopInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shop.db"),
				new ValueTuple<string, object>("文件", "s.商城.xlsx"),
				new ValueTuple<string, object>("表名", "ShopInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `ShopInfo` where Id = ?")
			});
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x00190307 File Offset: 0x0018E507
		public static void ResetStaticDefaultValue()
		{
			ConfigShopInfoById.LogPair = null;
			ConfigShopInfoById.HandleId = 0;
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x00190315 File Offset: 0x0018E515
		public static void Init()
		{
			ConfigShopInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigShopInfoById.HandleId, "db_shop.db", "select BinData from `ShopInfo` where Id = ?");
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x00190330 File Offset: 0x0018E530
		public static ShopInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigShopInfoById.HandleId, ConfigShopInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShopInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ShopInfo?(ShopInfo.GetRootAsShopInfo(configBuffer));
				}
			}
			ConfigShopInfoById.LogPair.Clear();
			ConfigShopInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigShopInfoById.HandleId, 1, p0Id, ConfigShopInfoById.LogPair) || ConfigCommon.Step(ConfigShopInfoById.HandleId, true, ConfigShopInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigShopInfoById.HandleId, ConfigShopInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigShopInfoById.HandleId, 0, ConfigShopInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigShopInfoById.HandleId, ConfigShopInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ShopInfo rootAsShopInfo = ShopInfo.GetRootAsShopInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShopInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigShopInfoById.HandleId, ConfigShopInfoById.LogPair);
			return new ShopInfo?(rootAsShopInfo);
		}

		// Token: 0x04003FF0 RID: 16368
		private const string DB = "db_shop.db";

		// Token: 0x04003FF1 RID: 16369
		private const string FILE = "s.商城.xlsx";

		// Token: 0x04003FF2 RID: 16370
		private const string TABLE = "ShopInfo";

		// Token: 0x04003FF3 RID: 16371
		private const string COMMAND = "select BinData from `ShopInfo` where Id = ?";

		// Token: 0x04003FF4 RID: 16372
		private const string KEY_PREFIX = "ShopInfoById";

		// Token: 0x04003FF5 RID: 16373
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FF6 RID: 16374
		private static int HandleId;
	}
}
