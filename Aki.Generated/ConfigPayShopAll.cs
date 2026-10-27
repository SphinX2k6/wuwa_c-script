using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000640 RID: 1600
	public class ConfigPayShopAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002590 RID: 9616 RVA: 0x0012E090 File Offset: 0x0012C290
		static ConfigPayShopAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopAll.CreateStaticDefaultValue), new Action(ConfigPayShopAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x0012E0B0 File Offset: 0x0012C2B0
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

		// Token: 0x06002592 RID: 9618 RVA: 0x0012E12F File Offset: 0x0012C32F
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopAll.LogPair = null;
			ConfigPayShopAll.HandleId = 0;
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x0012E13D File Offset: 0x0012C33D
		public static void Init()
		{
			ConfigPayShopAll.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopAll.HandleId, "db_payshop.db", "select BinData from `PayShop`");
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x0012E158 File Offset: 0x0012C358
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

		// Token: 0x04002BA6 RID: 11174
		private const string DB = "db_payshop.db";

		// Token: 0x04002BA7 RID: 11175
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002BA8 RID: 11176
		private const string TABLE = "PayShop";

		// Token: 0x04002BA9 RID: 11177
		private const string COMMAND = "select BinData from `PayShop`";

		// Token: 0x04002BAA RID: 11178
		private const string KEY_PREFIX = "PayShopAll";

		// Token: 0x04002BAB RID: 11179
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BAC RID: 11180
		private static int HandleId;
	}
}
