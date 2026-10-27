using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000155 RID: 341
	public class ConfigChatPartnerFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007FF RID: 2047 RVA: 0x00086CAC File Offset: 0x00084EAC
		static ConfigChatPartnerFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatPartnerFilterAll.CreateStaticDefaultValue), new Action(ConfigChatPartnerFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00086CCC File Offset: 0x00084ECC
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

		// Token: 0x06000801 RID: 2049 RVA: 0x00086D4B File Offset: 0x00084F4B
		public static void ResetStaticDefaultValue()
		{
			ConfigChatPartnerFilterAll.LogPair = null;
			ConfigChatPartnerFilterAll.HandleId = 0;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00086D59 File Offset: 0x00084F59
		public static void Init()
		{
			ConfigChatPartnerFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatPartnerFilterAll.HandleId, "db_phonemsg.db", "select BinData from `ChatPartnerFilter`");
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00086D74 File Offset: 0x00084F74
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

		// Token: 0x04000937 RID: 2359
		private const string DB = "db_phonemsg.db";

		// Token: 0x04000938 RID: 2360
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04000939 RID: 2361
		private const string TABLE = "ChatPartnerFilter";

		// Token: 0x0400093A RID: 2362
		private const string COMMAND = "select BinData from `ChatPartnerFilter`";

		// Token: 0x0400093B RID: 2363
		private const string KEY_PREFIX = "ChatPartnerFilterAll";

		// Token: 0x0400093C RID: 2364
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400093D RID: 2365
		private static int HandleId;
	}
}
