using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000971 RID: 2417
	public class ConfigShopInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038B9 RID: 14521 RVA: 0x0019D489 File Offset: 0x0019B689
		static ConfigShopInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigShopInfoById.CreateStaticDefaultValue), new Action(ConfigShopInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x0019D4A8 File Offset: 0x0019B6A8
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

		// Token: 0x060038BB RID: 14523 RVA: 0x0019D527 File Offset: 0x0019B727
		public static void ResetStaticDefaultValue()
		{
			ConfigShopInfoById.LogPair = null;
			ConfigShopInfoById.HandleId = 0;
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x0019D535 File Offset: 0x0019B735
		public static void Init()
		{
			ConfigShopInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigShopInfoById.HandleId, "db_shop.db", "select BinData from `ShopInfo` where Id = ?");
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x0019D550 File Offset: 0x0019B750
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

		// Token: 0x040041FD RID: 16893
		private const string DB = "db_shop.db";

		// Token: 0x040041FE RID: 16894
		private const string FILE = "s.商城.xlsx";

		// Token: 0x040041FF RID: 16895
		private const string TABLE = "ShopInfo";

		// Token: 0x04004200 RID: 16896
		private const string COMMAND = "select BinData from `ShopInfo` where Id = ?";

		// Token: 0x04004201 RID: 16897
		private const string KEY_PREFIX = "ShopInfoById";

		// Token: 0x04004202 RID: 16898
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004203 RID: 16899
		private static int HandleId;
	}
}
