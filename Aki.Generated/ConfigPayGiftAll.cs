using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000654 RID: 1620
	public class ConfigPayGiftAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002608 RID: 9736 RVA: 0x00134355 File Offset: 0x00132555
		static ConfigPayGiftAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayGiftAll.CreateStaticDefaultValue), new Action(ConfigPayGiftAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00134374 File Offset: 0x00132574
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

		// Token: 0x0600260A RID: 9738 RVA: 0x001343F3 File Offset: 0x001325F3
		public static void ResetStaticDefaultValue()
		{
			ConfigPayGiftAll.LogPair = null;
			ConfigPayGiftAll.HandleId = 0;
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x00134401 File Offset: 0x00132601
		public static void Init()
		{
			ConfigPayGiftAll.HandleId = ConfigCommon.InitDataStatement(ConfigPayGiftAll.HandleId, "db_paycurrency.db", "select BinData from `PayGift`");
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x0013441C File Offset: 0x0013261C
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

		// Token: 0x04002C32 RID: 11314
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002C33 RID: 11315
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002C34 RID: 11316
		private const string TABLE = "PayGift";

		// Token: 0x04002C35 RID: 11317
		private const string COMMAND = "select BinData from `PayGift`";

		// Token: 0x04002C36 RID: 11318
		private const string KEY_PREFIX = "PayGiftAll";

		// Token: 0x04002C37 RID: 11319
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C38 RID: 11320
		private static int HandleId;
	}
}
