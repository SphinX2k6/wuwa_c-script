using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000166 RID: 358
	public class ConfigChatThemeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000865 RID: 2149 RVA: 0x0008C9EC File Offset: 0x0008ABEC
		static ConfigChatThemeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatThemeAll.CreateStaticDefaultValue), new Action(ConfigChatThemeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0008CA0C File Offset: 0x0008AC0C
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

		// Token: 0x06000867 RID: 2151 RVA: 0x0008CA8B File Offset: 0x0008AC8B
		public static void ResetStaticDefaultValue()
		{
			ConfigChatThemeAll.LogPair = null;
			ConfigChatThemeAll.HandleId = 0;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0008CA99 File Offset: 0x0008AC99
		public static void Init()
		{
			ConfigChatThemeAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatThemeAll.HandleId, "db_phonemsg.db", "select BinData from `ChatTheme`");
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0008CAB4 File Offset: 0x0008ACB4
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

		// Token: 0x040009AE RID: 2478
		private const string DB = "db_phonemsg.db";

		// Token: 0x040009AF RID: 2479
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040009B0 RID: 2480
		private const string TABLE = "ChatTheme";

		// Token: 0x040009B1 RID: 2481
		private const string COMMAND = "select BinData from `ChatTheme`";

		// Token: 0x040009B2 RID: 2482
		private const string KEY_PREFIX = "ChatThemeAll";

		// Token: 0x040009B3 RID: 2483
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009B4 RID: 2484
		private static int HandleId;
	}
}
