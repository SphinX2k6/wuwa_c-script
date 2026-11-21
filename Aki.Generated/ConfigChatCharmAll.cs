using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000158 RID: 344
	public class ConfigChatCharmAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000811 RID: 2065 RVA: 0x0008AE44 File Offset: 0x00089044
		static ConfigChatCharmAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatCharmAll.CreateStaticDefaultValue), new Action(ConfigChatCharmAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0008AE64 File Offset: 0x00089064
		public static void CreateStaticDefaultValue()
		{
			ConfigChatCharmAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatCharmAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChatCharm"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatCharm`")
			});
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0008AEE3 File Offset: 0x000890E3
		public static void ResetStaticDefaultValue()
		{
			ConfigChatCharmAll.LogPair = null;
			ConfigChatCharmAll.HandleId = 0;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0008AEF1 File Offset: 0x000890F1
		public static void Init()
		{
			ConfigChatCharmAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatCharmAll.HandleId, "db_phonemsg.db", "select BinData from `ChatCharm`");
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0008AF0C File Offset: 0x0008910C
		[NullableContext(2)]
		public static IReadOnlyList<ChatCharm> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatCharmAll.HandleId, ConfigChatCharmAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ChatCharm> readOnlyList = (IReadOnlyList<ChatCharm>)ConfigCommon.GetConfig("ChatCharmAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ChatCharm> list = new List<ChatCharm>();
			while (ConfigCommon.Step(ConfigChatCharmAll.HandleId, false, ConfigChatCharmAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatCharmAll.HandleId, 0, ConfigChatCharmAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigChatCharmAll.HandleId, ConfigChatCharmAll.LogPair);
					return null;
				}
				ChatCharm rootAsChatCharm = ChatCharm.GetRootAsChatCharm(new ByteBuffer(item2));
				list.Add(rootAsChatCharm);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ChatCharmAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigChatCharmAll.HandleId, ConfigChatCharmAll.LogPair);
			return list;
		}

		// Token: 0x0400094C RID: 2380
		private const string DB = "db_phonemsg.db";

		// Token: 0x0400094D RID: 2381
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x0400094E RID: 2382
		private const string TABLE = "ChatCharm";

		// Token: 0x0400094F RID: 2383
		private const string COMMAND = "select BinData from `ChatCharm`";

		// Token: 0x04000950 RID: 2384
		private const string KEY_PREFIX = "ChatCharmAll";

		// Token: 0x04000951 RID: 2385
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000952 RID: 2386
		private static int HandleId;
	}
}
