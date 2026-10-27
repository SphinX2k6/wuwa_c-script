using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000645 RID: 1605
	public class ConfigPayShopRecommendById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025AE RID: 9646 RVA: 0x0012EA8F File Offset: 0x0012CC8F
		static ConfigPayShopRecommendById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopRecommendById.CreateStaticDefaultValue), new Action(ConfigPayShopRecommendById.ResetStaticDefaultValue));
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x0012EAB0 File Offset: 0x0012CCB0
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

		// Token: 0x060025B0 RID: 9648 RVA: 0x0012EB2F File Offset: 0x0012CD2F
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopRecommendById.LogPair = null;
			ConfigPayShopRecommendById.HandleId = 0;
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x0012EB3D File Offset: 0x0012CD3D
		public static void Init()
		{
			ConfigPayShopRecommendById.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopRecommendById.HandleId, "db_payshop.db", "select BinData from `PayShopRecommend` where Id=?");
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x0012EB58 File Offset: 0x0012CD58
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

		// Token: 0x04002BC9 RID: 11209
		private const string DB = "db_payshop.db";

		// Token: 0x04002BCA RID: 11210
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002BCB RID: 11211
		private const string TABLE = "PayShopRecommend";

		// Token: 0x04002BCC RID: 11212
		private const string COMMAND = "select BinData from `PayShopRecommend` where Id=?";

		// Token: 0x04002BCD RID: 11213
		private const string KEY_PREFIX = "PayShopRecommendById";

		// Token: 0x04002BCE RID: 11214
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BCF RID: 11215
		private static int HandleId;
	}
}
