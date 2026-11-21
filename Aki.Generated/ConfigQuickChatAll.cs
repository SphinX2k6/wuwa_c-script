using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B0 RID: 1968
	public class ConfigQuickChatAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E32 RID: 11826 RVA: 0x00161C4B File Offset: 0x0015FE4B
		static ConfigQuickChatAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuickChatAll.CreateStaticDefaultValue), new Action(ConfigQuickChatAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x00161C6C File Offset: 0x0015FE6C
		public static void CreateStaticDefaultValue()
		{
			ConfigQuickChatAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuickChatAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_chat.db"),
				new ValueTuple<string, object>("文件", "l.聊天.xlsx"),
				new ValueTuple<string, object>("表名", "QuickChat"),
				new ValueTuple<string, object>("语句", "select BinData from `QuickChat`")
			});
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x00161CEB File Offset: 0x0015FEEB
		public static void ResetStaticDefaultValue()
		{
			ConfigQuickChatAll.LogPair = null;
			ConfigQuickChatAll.HandleId = 0;
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x00161CF9 File Offset: 0x0015FEF9
		public static void Init()
		{
			ConfigQuickChatAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuickChatAll.HandleId, "db_chat.db", "select BinData from `QuickChat`");
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x00161D14 File Offset: 0x0015FF14
		[NullableContext(2)]
		public static IReadOnlyList<QuickChat> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuickChatAll.HandleId, ConfigQuickChatAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QuickChat> readOnlyList = (IReadOnlyList<QuickChat>)ConfigCommon.GetConfig("QuickChatAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<QuickChat> list = new List<QuickChat>();
			while (ConfigCommon.Step(ConfigQuickChatAll.HandleId, false, ConfigQuickChatAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuickChatAll.HandleId, 0, ConfigQuickChatAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuickChatAll.HandleId, ConfigQuickChatAll.LogPair);
					return null;
				}
				QuickChat rootAsQuickChat = QuickChat.GetRootAsQuickChat(new ByteBuffer(item2));
				list.Add(rootAsQuickChat);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QuickChatAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuickChatAll.HandleId, ConfigQuickChatAll.LogPair);
			return list;
		}

		// Token: 0x040035B6 RID: 13750
		private const string DB = "db_chat.db";

		// Token: 0x040035B7 RID: 13751
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x040035B8 RID: 13752
		private const string TABLE = "QuickChat";

		// Token: 0x040035B9 RID: 13753
		private const string COMMAND = "select BinData from `QuickChat`";

		// Token: 0x040035BA RID: 13754
		private const string KEY_PREFIX = "QuickChatAll";

		// Token: 0x040035BB RID: 13755
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035BC RID: 13756
		private static int HandleId;
	}
}
