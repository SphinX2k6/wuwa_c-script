using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200063E RID: 1598
	public class ConfigPayItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002584 RID: 9604 RVA: 0x0012DCB4 File Offset: 0x0012BEB4
		static ConfigPayItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayItemAll.CreateStaticDefaultValue), new Action(ConfigPayItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x0012DCD4 File Offset: 0x0012BED4
		public static void CreateStaticDefaultValue()
		{
			ConfigPayItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_paycurrency.db"),
				new ValueTuple<string, object>("文件", "c.充值.xlsx"),
				new ValueTuple<string, object>("表名", "PayItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PayItem`")
			});
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x0012DD53 File Offset: 0x0012BF53
		public static void ResetStaticDefaultValue()
		{
			ConfigPayItemAll.LogPair = null;
			ConfigPayItemAll.HandleId = 0;
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x0012DD61 File Offset: 0x0012BF61
		public static void Init()
		{
			ConfigPayItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigPayItemAll.HandleId, "db_paycurrency.db", "select BinData from `PayItem`");
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x0012DD7C File Offset: 0x0012BF7C
		[NullableContext(2)]
		public static IReadOnlyList<PayItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayItemAll.HandleId, ConfigPayItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PayItem> readOnlyList = (IReadOnlyList<PayItem>)ConfigCommon.GetConfig("PayItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PayItem> list = new List<PayItem>();
			while (ConfigCommon.Step(ConfigPayItemAll.HandleId, false, ConfigPayItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayItemAll.HandleId, 0, ConfigPayItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPayItemAll.HandleId, ConfigPayItemAll.LogPair);
					return null;
				}
				PayItem rootAsPayItem = PayItem.GetRootAsPayItem(new ByteBuffer(item2));
				list.Add(rootAsPayItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PayItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPayItemAll.HandleId, ConfigPayItemAll.LogPair);
			return list;
		}

		// Token: 0x04002B98 RID: 11160
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002B99 RID: 11161
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002B9A RID: 11162
		private const string TABLE = "PayItem";

		// Token: 0x04002B9B RID: 11163
		private const string COMMAND = "select BinData from `PayItem`";

		// Token: 0x04002B9C RID: 11164
		private const string KEY_PREFIX = "PayItemAll";

		// Token: 0x04002B9D RID: 11165
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B9E RID: 11166
		private static int HandleId;
	}
}
