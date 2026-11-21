using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000164 RID: 356
	public class ConfigChatPartnerFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x0008C610 File Offset: 0x0008A810
		static ConfigChatPartnerFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatPartnerFilterAll.CreateStaticDefaultValue), new Action(ConfigChatPartnerFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0008C630 File Offset: 0x0008A830
		public static void CreateStaticDefaultValue()
		{
			ConfigChatPartnerFilterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatPartnerFilterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChatPartnerFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatPartnerFilter`")
			});
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0008C6AF File Offset: 0x0008A8AF
		public static void ResetStaticDefaultValue()
		{
			ConfigChatPartnerFilterAll.LogPair = null;
			ConfigChatPartnerFilterAll.HandleId = 0;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0008C6BD File Offset: 0x0008A8BD
		public static void Init()
		{
			ConfigChatPartnerFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatPartnerFilterAll.HandleId, "db_phonemsg.db", "select BinData from `ChatPartnerFilter`");
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0008C6D8 File Offset: 0x0008A8D8
		[NullableContext(2)]
		public static IReadOnlyList<ChatPartnerFilter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatPartnerFilterAll.HandleId, ConfigChatPartnerFilterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ChatPartnerFilter> readOnlyList = (IReadOnlyList<ChatPartnerFilter>)ConfigCommon.GetConfig("ChatPartnerFilterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ChatPartnerFilter> list = new List<ChatPartnerFilter>();
			while (ConfigCommon.Step(ConfigChatPartnerFilterAll.HandleId, false, ConfigChatPartnerFilterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatPartnerFilterAll.HandleId, 0, ConfigChatPartnerFilterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigChatPartnerFilterAll.HandleId, ConfigChatPartnerFilterAll.LogPair);
					return null;
				}
				ChatPartnerFilter rootAsChatPartnerFilter = ChatPartnerFilter.GetRootAsChatPartnerFilter(new ByteBuffer(item2));
				list.Add(rootAsChatPartnerFilter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ChatPartnerFilterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigChatPartnerFilterAll.HandleId, ConfigChatPartnerFilterAll.LogPair);
			return list;
		}

		// Token: 0x040009A0 RID: 2464
		private const string DB = "db_phonemsg.db";

		// Token: 0x040009A1 RID: 2465
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040009A2 RID: 2466
		private const string TABLE = "ChatPartnerFilter";

		// Token: 0x040009A3 RID: 2467
		private const string COMMAND = "select BinData from `ChatPartnerFilter`";

		// Token: 0x040009A4 RID: 2468
		private const string KEY_PREFIX = "ChatPartnerFilterAll";

		// Token: 0x040009A5 RID: 2469
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009A6 RID: 2470
		private static int HandleId;
	}
}
