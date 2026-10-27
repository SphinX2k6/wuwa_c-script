using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000643 RID: 1603
	public class ConfigPayShopDirectGoodsByGoodsId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025A2 RID: 9634 RVA: 0x0012E6B4 File Offset: 0x0012C8B4
		static ConfigPayShopDirectGoodsByGoodsId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopDirectGoodsByGoodsId.CreateStaticDefaultValue), new Action(ConfigPayShopDirectGoodsByGoodsId.ResetStaticDefaultValue));
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x0012E6D4 File Offset: 0x0012C8D4
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

		// Token: 0x060025A4 RID: 9636 RVA: 0x0012E753 File Offset: 0x0012C953
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopDirectGoodsByGoodsId.LogPair = null;
			ConfigPayShopDirectGoodsByGoodsId.HandleId = 0;
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x0012E761 File Offset: 0x0012C961
		public static void Init()
		{
			ConfigPayShopDirectGoodsByGoodsId.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopDirectGoodsByGoodsId.HandleId, "db_payshop.db", "select BinData from `PayShopDirectGoods` where GoodsId=?");
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x0012E77C File Offset: 0x0012C97C
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

		// Token: 0x04002BBB RID: 11195
		private const string DB = "db_payshop.db";

		// Token: 0x04002BBC RID: 11196
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002BBD RID: 11197
		private const string TABLE = "PayShopDirectGoods";

		// Token: 0x04002BBE RID: 11198
		private const string COMMAND = "select BinData from `PayShopDirectGoods` where GoodsId=?";

		// Token: 0x04002BBF RID: 11199
		private const string KEY_PREFIX = "PayShopDirectGoodsByGoodsId";

		// Token: 0x04002BC0 RID: 11200
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BC1 RID: 11201
		private static int HandleId;
	}
}
