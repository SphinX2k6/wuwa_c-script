using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000157 RID: 343
	public class ConfigChatThemeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600080B RID: 2059 RVA: 0x00087088 File Offset: 0x00085288
		static ConfigChatThemeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatThemeAll.CreateStaticDefaultValue), new Action(ConfigChatThemeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x000870A8 File Offset: 0x000852A8
		public static void CreateStaticDefaultValue()
		{
			ConfigChatThemeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatThemeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChatTheme"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatTheme`")
			});
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00087127 File Offset: 0x00085327
		public static void ResetStaticDefaultValue()
		{
			ConfigChatThemeAll.LogPair = null;
			ConfigChatThemeAll.HandleId = 0;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00087135 File Offset: 0x00085335
		public static void Init()
		{
			ConfigChatThemeAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatThemeAll.HandleId, "db_phonemsg.db", "select BinData from `ChatTheme`");
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00087150 File Offset: 0x00085350
		[NullableContext(2)]
		public static IReadOnlyList<ChatTheme> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatThemeAll.HandleId, ConfigChatThemeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ChatTheme> readOnlyList = (IReadOnlyList<ChatTheme>)ConfigCommon.GetConfig("ChatThemeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ChatTheme> list = new List<ChatTheme>();
			while (ConfigCommon.Step(ConfigChatThemeAll.HandleId, false, ConfigChatThemeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatThemeAll.HandleId, 0, ConfigChatThemeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigChatThemeAll.HandleId, ConfigChatThemeAll.LogPair);
					return null;
				}
				ChatTheme rootAsChatTheme = ChatTheme.GetRootAsChatTheme(new ByteBuffer(item2));
				list.Add(rootAsChatTheme);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ChatThemeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigChatThemeAll.HandleId, ConfigChatThemeAll.LogPair);
			return list;
		}

		// Token: 0x04000945 RID: 2373
		private const string DB = "db_phonemsg.db";

		// Token: 0x04000946 RID: 2374
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04000947 RID: 2375
		private const string TABLE = "ChatTheme";

		// Token: 0x04000948 RID: 2376
		private const string COMMAND = "select BinData from `ChatTheme`";

		// Token: 0x04000949 RID: 2377
		private const string KEY_PREFIX = "ChatThemeAll";

		// Token: 0x0400094A RID: 2378
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400094B RID: 2379
		private static int HandleId;
	}
}
