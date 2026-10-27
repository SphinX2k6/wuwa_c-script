using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000146 RID: 326
	public class ConfigChatBgAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x00084EBC File Offset: 0x000830BC
		static ConfigChatBgAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatBgAll.CreateStaticDefaultValue), new Action(ConfigChatBgAll.ResetStaticDefaultValue));
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00084EDC File Offset: 0x000830DC
		public static void CreateStaticDefaultValue()
		{
			ConfigChatBgAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatBgAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChatBg"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatBg`")
			});
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00084F5B File Offset: 0x0008315B
		public static void ResetStaticDefaultValue()
		{
			ConfigChatBgAll.LogPair = null;
			ConfigChatBgAll.HandleId = 0;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00084F69 File Offset: 0x00083169
		public static void Init()
		{
			ConfigChatBgAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatBgAll.HandleId, "db_phonemsg.db", "select BinData from `ChatBg`");
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00084F84 File Offset: 0x00083184
		[NullableContext(2)]
		public static IReadOnlyList<ChatBg> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatBgAll.HandleId, ConfigChatBgAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ChatBg> readOnlyList = (IReadOnlyList<ChatBg>)ConfigCommon.GetConfig("ChatBgAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ChatBg> list = new List<ChatBg>();
			while (ConfigCommon.Step(ConfigChatBgAll.HandleId, false, ConfigChatBgAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatBgAll.HandleId, 0, ConfigChatBgAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigChatBgAll.HandleId, ConfigChatBgAll.LogPair);
					return null;
				}
				ChatBg rootAsChatBg = ChatBg.GetRootAsChatBg(new ByteBuffer(item2));
				list.Add(rootAsChatBg);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ChatBgAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigChatBgAll.HandleId, ConfigChatBgAll.LogPair);
			return list;
		}

		// Token: 0x040008CE RID: 2254
		private const string DB = "db_phonemsg.db";

		// Token: 0x040008CF RID: 2255
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040008D0 RID: 2256
		private const string TABLE = "ChatBg";

		// Token: 0x040008D1 RID: 2257
		private const string COMMAND = "select BinData from `ChatBg`";

		// Token: 0x040008D2 RID: 2258
		private const string KEY_PREFIX = "ChatBgAll";

		// Token: 0x040008D3 RID: 2259
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008D4 RID: 2260
		private static int HandleId;
	}
}
