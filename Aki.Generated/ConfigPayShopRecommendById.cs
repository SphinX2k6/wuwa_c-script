using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200065D RID: 1629
	public class ConfigPayShopRecommendById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600263E RID: 9790 RVA: 0x0013550B File Offset: 0x0013370B
		static ConfigPayShopRecommendById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopRecommendById.CreateStaticDefaultValue), new Action(ConfigPayShopRecommendById.ResetStaticDefaultValue));
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x0013552C File Offset: 0x0013372C
		public static void CreateStaticDefaultValue()
		{
			ConfigPayShopRecommendById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayShopRecommendById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_payshop.db"),
				new ValueTuple<string, object>("文件", "s.商业化商城.xlsx"),
				new ValueTuple<string, object>("表名", "PayShopRecommend"),
				new ValueTuple<string, object>("语句", "select BinData from `PayShopRecommend` where Id=?")
			});
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x001355AB File Offset: 0x001337AB
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopRecommendById.LogPair = null;
			ConfigPayShopRecommendById.HandleId = 0;
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x001355B9 File Offset: 0x001337B9
		public static void Init()
		{
			ConfigPayShopRecommendById.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopRecommendById.HandleId, "db_payshop.db", "select BinData from `PayShopRecommend` where Id=?");
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x001355D4 File Offset: 0x001337D4
		public static PayShopRecommend? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayShopRecommendById.HandleId, ConfigPayShopRecommendById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayShopRecommendById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PayShopRecommend?(PayShopRecommend.GetRootAsPayShopRecommend(configBuffer));
				}
			}
			ConfigPayShopRecommendById.LogPair.Clear();
			ConfigPayShopRecommendById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPayShopRecommendById.HandleId, 1, p0Id, ConfigPayShopRecommendById.LogPair) || ConfigCommon.Step(ConfigPayShopRecommendById.HandleId, true, ConfigPayShopRecommendById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPayShopRecommendById.HandleId, ConfigPayShopRecommendById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayShopRecommendById.HandleId, 0, ConfigPayShopRecommendById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPayShopRecommendById.HandleId, ConfigPayShopRecommendById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PayShopRecommend rootAsPayShopRecommend = PayShopRecommend.GetRootAsPayShopRecommend(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayShopRecommendById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPayShopRecommendById.HandleId, ConfigPayShopRecommendById.LogPair);
			return new PayShopRecommend?(rootAsPayShopRecommend);
		}

		// Token: 0x04002C71 RID: 11377
		private const string DB = "db_payshop.db";

		// Token: 0x04002C72 RID: 11378
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002C73 RID: 11379
		private const string TABLE = "PayShopRecommend";

		// Token: 0x04002C74 RID: 11380
		private const string COMMAND = "select BinData from `PayShopRecommend` where Id=?";

		// Token: 0x04002C75 RID: 11381
		private const string KEY_PREFIX = "PayShopRecommendById";

		// Token: 0x04002C76 RID: 11382
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C77 RID: 11383
		private static int HandleId;
	}
}
