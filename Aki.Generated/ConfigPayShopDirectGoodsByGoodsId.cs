using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200065B RID: 1627
	public class ConfigPayShopDirectGoodsByGoodsId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002632 RID: 9778 RVA: 0x00135130 File Offset: 0x00133330
		static ConfigPayShopDirectGoodsByGoodsId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopDirectGoodsByGoodsId.CreateStaticDefaultValue), new Action(ConfigPayShopDirectGoodsByGoodsId.ResetStaticDefaultValue));
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00135150 File Offset: 0x00133350
		public static void CreateStaticDefaultValue()
		{
			ConfigPayShopDirectGoodsByGoodsId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayShopDirectGoodsByGoodsId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_payshop.db"),
				new ValueTuple<string, object>("文件", "s.商业化商城.xlsx"),
				new ValueTuple<string, object>("表名", "PayShopDirectGoods"),
				new ValueTuple<string, object>("语句", "select BinData from `PayShopDirectGoods` where GoodsId=?")
			});
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x001351CF File Offset: 0x001333CF
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopDirectGoodsByGoodsId.LogPair = null;
			ConfigPayShopDirectGoodsByGoodsId.HandleId = 0;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x001351DD File Offset: 0x001333DD
		public static void Init()
		{
			ConfigPayShopDirectGoodsByGoodsId.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopDirectGoodsByGoodsId.HandleId, "db_payshop.db", "select BinData from `PayShopDirectGoods` where GoodsId=?");
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x001351F8 File Offset: 0x001333F8
		public static PayShopDirectGoods? GetConfig(int p0GoodsId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayShopDirectGoodsByGoodsId.HandleId, ConfigPayShopDirectGoodsByGoodsId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayShopDirectGoodsByGoodsId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GoodsId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PayShopDirectGoods?(PayShopDirectGoods.GetRootAsPayShopDirectGoods(configBuffer));
				}
			}
			ConfigPayShopDirectGoodsByGoodsId.LogPair.Clear();
			ConfigPayShopDirectGoodsByGoodsId.LogPair.Add(new ValueTuple<string, object>("GoodsId", p0GoodsId));
			if (!ConfigCommon.BindInt(ConfigPayShopDirectGoodsByGoodsId.HandleId, 1, p0GoodsId, ConfigPayShopDirectGoodsByGoodsId.LogPair) || ConfigCommon.Step(ConfigPayShopDirectGoodsByGoodsId.HandleId, true, ConfigPayShopDirectGoodsByGoodsId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPayShopDirectGoodsByGoodsId.HandleId, ConfigPayShopDirectGoodsByGoodsId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayShopDirectGoodsByGoodsId.HandleId, 0, ConfigPayShopDirectGoodsByGoodsId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPayShopDirectGoodsByGoodsId.HandleId, ConfigPayShopDirectGoodsByGoodsId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PayShopDirectGoods rootAsPayShopDirectGoods = PayShopDirectGoods.GetRootAsPayShopDirectGoods(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayShopDirectGoodsByGoodsId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GoodsId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPayShopDirectGoodsByGoodsId.HandleId, ConfigPayShopDirectGoodsByGoodsId.LogPair);
			return new PayShopDirectGoods?(rootAsPayShopDirectGoods);
		}

		// Token: 0x04002C63 RID: 11363
		private const string DB = "db_payshop.db";

		// Token: 0x04002C64 RID: 11364
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002C65 RID: 11365
		private const string TABLE = "PayShopDirectGoods";

		// Token: 0x04002C66 RID: 11366
		private const string COMMAND = "select BinData from `PayShopDirectGoods` where GoodsId=?";

		// Token: 0x04002C67 RID: 11367
		private const string KEY_PREFIX = "PayShopDirectGoodsByGoodsId";

		// Token: 0x04002C68 RID: 11368
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C69 RID: 11369
		private static int HandleId;
	}
}
