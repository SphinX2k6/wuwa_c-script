using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000658 RID: 1624
	public class ConfigPayShopAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002620 RID: 9760 RVA: 0x00134B0C File Offset: 0x00132D0C
		static ConfigPayShopAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopAll.CreateStaticDefaultValue), new Action(ConfigPayShopAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x00134B2C File Offset: 0x00132D2C
		public static void CreateStaticDefaultValue()
		{
			ConfigPayShopAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayShopAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_payshop.db"),
				new ValueTuple<string, object>("文件", "s.商业化商城.xlsx"),
				new ValueTuple<string, object>("表名", "PayShop"),
				new ValueTuple<string, object>("语句", "select BinData from `PayShop`")
			});
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x00134BAB File Offset: 0x00132DAB
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopAll.LogPair = null;
			ConfigPayShopAll.HandleId = 0;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x00134BB9 File Offset: 0x00132DB9
		public static void Init()
		{
			ConfigPayShopAll.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopAll.HandleId, "db_payshop.db", "select BinData from `PayShop`");
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x00134BD4 File Offset: 0x00132DD4
		[NullableContext(2)]
		public static IReadOnlyList<PayShop> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayShopAll.HandleId, ConfigPayShopAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PayShop> readOnlyList = (IReadOnlyList<PayShop>)ConfigCommon.GetConfig("PayShopAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PayShop> list = new List<PayShop>();
			while (ConfigCommon.Step(ConfigPayShopAll.HandleId, false, ConfigPayShopAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayShopAll.HandleId, 0, ConfigPayShopAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPayShopAll.HandleId, ConfigPayShopAll.LogPair);
					return null;
				}
				PayShop rootAsPayShop = PayShop.GetRootAsPayShop(new ByteBuffer(item2));
				list.Add(rootAsPayShop);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PayShopAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPayShopAll.HandleId, ConfigPayShopAll.LogPair);
			return list;
		}

		// Token: 0x04002C4E RID: 11342
		private const string DB = "db_payshop.db";

		// Token: 0x04002C4F RID: 11343
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002C50 RID: 11344
		private const string TABLE = "PayShop";

		// Token: 0x04002C51 RID: 11345
		private const string COMMAND = "select BinData from `PayShop`";

		// Token: 0x04002C52 RID: 11346
		private const string KEY_PREFIX = "PayShopAll";

		// Token: 0x04002C53 RID: 11347
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C54 RID: 11348
		private static int HandleId;
	}
}
