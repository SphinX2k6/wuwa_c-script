using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200065C RID: 1628
	public class ConfigPayShopRecommendAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002638 RID: 9784 RVA: 0x00135378 File Offset: 0x00133578
		static ConfigPayShopRecommendAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopRecommendAll.CreateStaticDefaultValue), new Action(ConfigPayShopRecommendAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00135398 File Offset: 0x00133598
		public static void CreateStaticDefaultValue()
		{
			ConfigPayShopRecommendAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayShopRecommendAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_payshop.db"),
				new ValueTuple<string, object>("文件", "s.商业化商城.xlsx"),
				new ValueTuple<string, object>("表名", "PayShopRecommend"),
				new ValueTuple<string, object>("语句", "select BinData from `PayShopRecommend`")
			});
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00135417 File Offset: 0x00133617
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopRecommendAll.LogPair = null;
			ConfigPayShopRecommendAll.HandleId = 0;
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00135425 File Offset: 0x00133625
		public static void Init()
		{
			ConfigPayShopRecommendAll.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopRecommendAll.HandleId, "db_payshop.db", "select BinData from `PayShopRecommend`");
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00135440 File Offset: 0x00133640
		[NullableContext(2)]
		public static IReadOnlyList<PayShopRecommend> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayShopRecommendAll.HandleId, ConfigPayShopRecommendAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PayShopRecommend> readOnlyList = (IReadOnlyList<PayShopRecommend>)ConfigCommon.GetConfig("PayShopRecommendAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PayShopRecommend> list = new List<PayShopRecommend>();
			while (ConfigCommon.Step(ConfigPayShopRecommendAll.HandleId, false, ConfigPayShopRecommendAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayShopRecommendAll.HandleId, 0, ConfigPayShopRecommendAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPayShopRecommendAll.HandleId, ConfigPayShopRecommendAll.LogPair);
					return null;
				}
				PayShopRecommend rootAsPayShopRecommend = PayShopRecommend.GetRootAsPayShopRecommend(new ByteBuffer(item2));
				list.Add(rootAsPayShopRecommend);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PayShopRecommendAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPayShopRecommendAll.HandleId, ConfigPayShopRecommendAll.LogPair);
			return list;
		}

		// Token: 0x04002C6A RID: 11370
		private const string DB = "db_payshop.db";

		// Token: 0x04002C6B RID: 11371
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002C6C RID: 11372
		private const string TABLE = "PayShopRecommend";

		// Token: 0x04002C6D RID: 11373
		private const string COMMAND = "select BinData from `PayShopRecommend`";

		// Token: 0x04002C6E RID: 11374
		private const string KEY_PREFIX = "PayShopRecommendAll";

		// Token: 0x04002C6F RID: 11375
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C70 RID: 11376
		private static int HandleId;
	}
}
