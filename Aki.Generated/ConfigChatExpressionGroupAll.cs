using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200015F RID: 351
	public class ConfigChatExpressionGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600083B RID: 2107 RVA: 0x0008BC10 File Offset: 0x00089E10
		static ConfigChatExpressionGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatExpressionGroupAll.CreateStaticDefaultValue), new Action(ConfigChatExpressionGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0008BC30 File Offset: 0x00089E30
		public static void CreateStaticDefaultValue()
		{
			ConfigChatExpressionGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatExpressionGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_chat.db"),
				new ValueTuple<string, object>("文件", "l.聊天.xlsx"),
				new ValueTuple<string, object>("表名", "ChatExpressionGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatExpressionGroup`")
			});
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0008BCAF File Offset: 0x00089EAF
		public static void ResetStaticDefaultValue()
		{
			ConfigChatExpressionGroupAll.LogPair = null;
			ConfigChatExpressionGroupAll.HandleId = 0;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0008BCBD File Offset: 0x00089EBD
		public static void Init()
		{
			ConfigChatExpressionGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatExpressionGroupAll.HandleId, "db_chat.db", "select BinData from `ChatExpressionGroup`");
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0008BCD8 File Offset: 0x00089ED8
		[NullableContext(2)]
		public static IReadOnlyList<ChatExpressionGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatExpressionGroupAll.HandleId, ConfigChatExpressionGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ChatExpressionGroup> readOnlyList = (IReadOnlyList<ChatExpressionGroup>)ConfigCommon.GetConfig("ChatExpressionGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ChatExpressionGroup> list = new List<ChatExpressionGroup>();
			while (ConfigCommon.Step(ConfigChatExpressionGroupAll.HandleId, false, ConfigChatExpressionGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatExpressionGroupAll.HandleId, 0, ConfigChatExpressionGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigChatExpressionGroupAll.HandleId, ConfigChatExpressionGroupAll.LogPair);
					return null;
				}
				ChatExpressionGroup rootAsChatExpressionGroup = ChatExpressionGroup.GetRootAsChatExpressionGroup(new ByteBuffer(item2));
				list.Add(rootAsChatExpressionGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ChatExpressionGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigChatExpressionGroupAll.HandleId, ConfigChatExpressionGroupAll.LogPair);
			return list;
		}

		// Token: 0x0400097D RID: 2429
		private const string DB = "db_chat.db";

		// Token: 0x0400097E RID: 2430
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x0400097F RID: 2431
		private const string TABLE = "ChatExpressionGroup";

		// Token: 0x04000980 RID: 2432
		private const string COMMAND = "select BinData from `ChatExpressionGroup`";

		// Token: 0x04000981 RID: 2433
		private const string KEY_PREFIX = "ChatExpressionGroupAll";

		// Token: 0x04000982 RID: 2434
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000983 RID: 2435
		private static int HandleId;
	}
}
