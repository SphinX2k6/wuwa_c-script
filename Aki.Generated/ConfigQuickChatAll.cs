using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000796 RID: 1942
	public class ConfigQuickChatAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D96 RID: 11670 RVA: 0x0015AD3F File Offset: 0x00158F3F
		static ConfigQuickChatAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuickChatAll.CreateStaticDefaultValue), new Action(ConfigQuickChatAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x0015AD60 File Offset: 0x00158F60
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

		// Token: 0x06002D98 RID: 11672 RVA: 0x0015ADDF File Offset: 0x00158FDF
		public static void ResetStaticDefaultValue()
		{
			ConfigQuickChatAll.LogPair = null;
			ConfigQuickChatAll.HandleId = 0;
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x0015ADED File Offset: 0x00158FED
		public static void Init()
		{
			ConfigQuickChatAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuickChatAll.HandleId, "db_chat.db", "select BinData from `QuickChat`");
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x0015AE08 File Offset: 0x00159008
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

		// Token: 0x04003500 RID: 13568
		private const string DB = "db_chat.db";

		// Token: 0x04003501 RID: 13569
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x04003502 RID: 13570
		private const string TABLE = "QuickChat";

		// Token: 0x04003503 RID: 13571
		private const string COMMAND = "select BinData from `QuickChat`";

		// Token: 0x04003504 RID: 13572
		private const string KEY_PREFIX = "QuickChatAll";

		// Token: 0x04003505 RID: 13573
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003506 RID: 13574
		private static int HandleId;
	}
}
