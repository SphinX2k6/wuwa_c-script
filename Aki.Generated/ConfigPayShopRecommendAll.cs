using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000644 RID: 1604
	public class ConfigPayShopRecommendAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025A8 RID: 9640 RVA: 0x0012E8FC File Offset: 0x0012CAFC
		static ConfigPayShopRecommendAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopRecommendAll.CreateStaticDefaultValue), new Action(ConfigPayShopRecommendAll.ResetStaticDefaultValue));
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x0012E91C File Offset: 0x0012CB1C
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

		// Token: 0x060025AA RID: 9642 RVA: 0x0012E99B File Offset: 0x0012CB9B
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopRecommendAll.LogPair = null;
			ConfigPayShopRecommendAll.HandleId = 0;
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x0012E9A9 File Offset: 0x0012CBA9
		public static void Init()
		{
			ConfigPayShopRecommendAll.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopRecommendAll.HandleId, "db_payshop.db", "select BinData from `PayShopRecommend`");
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x0012E9C4 File Offset: 0x0012CBC4
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

		// Token: 0x04002BC2 RID: 11202
		private const string DB = "db_payshop.db";

		// Token: 0x04002BC3 RID: 11203
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002BC4 RID: 11204
		private const string TABLE = "PayShopRecommend";

		// Token: 0x04002BC5 RID: 11205
		private const string COMMAND = "select BinData from `PayShopRecommend`";

		// Token: 0x04002BC6 RID: 11206
		private const string KEY_PREFIX = "PayShopRecommendAll";

		// Token: 0x04002BC7 RID: 11207
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BC8 RID: 11208
		private static int HandleId;
	}
}
