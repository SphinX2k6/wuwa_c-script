using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000149 RID: 329
	public class ConfigChatCharmAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007B7 RID: 1975 RVA: 0x000854E0 File Offset: 0x000836E0
		static ConfigChatCharmAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatCharmAll.CreateStaticDefaultValue), new Action(ConfigChatCharmAll.ResetStaticDefaultValue));
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00085500 File Offset: 0x00083700
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

		// Token: 0x060007B9 RID: 1977 RVA: 0x0008557F File Offset: 0x0008377F
		public static void ResetStaticDefaultValue()
		{
			ConfigChatCharmAll.LogPair = null;
			ConfigChatCharmAll.HandleId = 0;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0008558D File Offset: 0x0008378D
		public static void Init()
		{
			ConfigChatCharmAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatCharmAll.HandleId, "db_phonemsg.db", "select BinData from `ChatCharm`");
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000855A8 File Offset: 0x000837A8
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

		// Token: 0x040008E3 RID: 2275
		private const string DB = "db_phonemsg.db";

		// Token: 0x040008E4 RID: 2276
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040008E5 RID: 2277
		private const string TABLE = "ChatCharm";

		// Token: 0x040008E6 RID: 2278
		private const string COMMAND = "select BinData from `ChatCharm`";

		// Token: 0x040008E7 RID: 2279
		private const string KEY_PREFIX = "ChatCharmAll";

		// Token: 0x040008E8 RID: 2280
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008E9 RID: 2281
		private static int HandleId;
	}
}
