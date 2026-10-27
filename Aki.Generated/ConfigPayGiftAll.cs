using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200063C RID: 1596
	public class ConfigPayGiftAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002578 RID: 9592 RVA: 0x0012D8D9 File Offset: 0x0012BAD9
		static ConfigPayGiftAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayGiftAll.CreateStaticDefaultValue), new Action(ConfigPayGiftAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x0012D8F8 File Offset: 0x0012BAF8
		public static void CreateStaticDefaultValue()
		{
			ConfigPayGiftAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayGiftAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_paycurrency.db"),
				new ValueTuple<string, object>("文件", "c.充值.xlsx"),
				new ValueTuple<string, object>("表名", "PayGift"),
				new ValueTuple<string, object>("语句", "select BinData from `PayGift`")
			});
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x0012D977 File Offset: 0x0012BB77
		public static void ResetStaticDefaultValue()
		{
			ConfigPayGiftAll.LogPair = null;
			ConfigPayGiftAll.HandleId = 0;
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x0012D985 File Offset: 0x0012BB85
		public static void Init()
		{
			ConfigPayGiftAll.HandleId = ConfigCommon.InitDataStatement(ConfigPayGiftAll.HandleId, "db_paycurrency.db", "select BinData from `PayGift`");
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x0012D9A0 File Offset: 0x0012BBA0
		[NullableContext(2)]
		public static IReadOnlyList<PayGift> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayGiftAll.HandleId, ConfigPayGiftAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PayGift> readOnlyList = (IReadOnlyList<PayGift>)ConfigCommon.GetConfig("PayGiftAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PayGift> list = new List<PayGift>();
			while (ConfigCommon.Step(ConfigPayGiftAll.HandleId, false, ConfigPayGiftAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayGiftAll.HandleId, 0, ConfigPayGiftAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPayGiftAll.HandleId, ConfigPayGiftAll.LogPair);
					return null;
				}
				PayGift rootAsPayGift = PayGift.GetRootAsPayGift(new ByteBuffer(item2));
				list.Add(rootAsPayGift);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PayGiftAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPayGiftAll.HandleId, ConfigPayGiftAll.LogPair);
			return list;
		}

		// Token: 0x04002B8A RID: 11146
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002B8B RID: 11147
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002B8C RID: 11148
		private const string TABLE = "PayGift";

		// Token: 0x04002B8D RID: 11149
		private const string COMMAND = "select BinData from `PayGift`";

		// Token: 0x04002B8E RID: 11150
		private const string KEY_PREFIX = "PayGiftAll";

		// Token: 0x04002B8F RID: 11151
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B90 RID: 11152
		private static int HandleId;
	}
}
