using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000155 RID: 341
	public class ConfigChatBgAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007FF RID: 2047 RVA: 0x0008A820 File Offset: 0x00088A20
		static ConfigChatBgAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatBgAll.CreateStaticDefaultValue), new Action(ConfigChatBgAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0008A840 File Offset: 0x00088A40
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

		// Token: 0x06000801 RID: 2049 RVA: 0x0008A8BF File Offset: 0x00088ABF
		public static void ResetStaticDefaultValue()
		{
			ConfigChatBgAll.LogPair = null;
			ConfigChatBgAll.HandleId = 0;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0008A8CD File Offset: 0x00088ACD
		public static void Init()
		{
			ConfigChatBgAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatBgAll.HandleId, "db_phonemsg.db", "select BinData from `ChatBg`");
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0008A8E8 File Offset: 0x00088AE8
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

		// Token: 0x04000937 RID: 2359
		private const string DB = "db_phonemsg.db";

		// Token: 0x04000938 RID: 2360
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04000939 RID: 2361
		private const string TABLE = "ChatBg";

		// Token: 0x0400093A RID: 2362
		private const string COMMAND = "select BinData from `ChatBg`";

		// Token: 0x0400093B RID: 2363
		private const string KEY_PREFIX = "ChatBgAll";

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
