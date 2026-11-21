using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000656 RID: 1622
	public class ConfigPayItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002614 RID: 9748 RVA: 0x00134730 File Offset: 0x00132930
		static ConfigPayItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayItemAll.CreateStaticDefaultValue), new Action(ConfigPayItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00134750 File Offset: 0x00132950
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

		// Token: 0x06002616 RID: 9750 RVA: 0x001347CF File Offset: 0x001329CF
		public static void ResetStaticDefaultValue()
		{
			ConfigPayItemAll.LogPair = null;
			ConfigPayItemAll.HandleId = 0;
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x001347DD File Offset: 0x001329DD
		public static void Init()
		{
			ConfigPayItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigPayItemAll.HandleId, "db_paycurrency.db", "select BinData from `PayItem`");
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x001347F8 File Offset: 0x001329F8
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

		// Token: 0x04002C40 RID: 11328
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002C41 RID: 11329
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002C42 RID: 11330
		private const string TABLE = "PayItem";

		// Token: 0x04002C43 RID: 11331
		private const string COMMAND = "select BinData from `PayItem`";

		// Token: 0x04002C44 RID: 11332
		private const string KEY_PREFIX = "PayItemAll";

		// Token: 0x04002C45 RID: 11333
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C46 RID: 11334
		private static int HandleId;
	}
}
