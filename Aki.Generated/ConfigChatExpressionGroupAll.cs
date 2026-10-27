using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000150 RID: 336
	public class ConfigChatExpressionGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007E1 RID: 2017 RVA: 0x000862AC File Offset: 0x000844AC
		static ConfigChatExpressionGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatExpressionGroupAll.CreateStaticDefaultValue), new Action(ConfigChatExpressionGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000862CC File Offset: 0x000844CC
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

		// Token: 0x060007E3 RID: 2019 RVA: 0x0008634B File Offset: 0x0008454B
		public static void ResetStaticDefaultValue()
		{
			ConfigChatExpressionGroupAll.LogPair = null;
			ConfigChatExpressionGroupAll.HandleId = 0;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00086359 File Offset: 0x00084559
		public static void Init()
		{
			ConfigChatExpressionGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatExpressionGroupAll.HandleId, "db_chat.db", "select BinData from `ChatExpressionGroup`");
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00086374 File Offset: 0x00084574
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

		// Token: 0x04000914 RID: 2324
		private const string DB = "db_chat.db";

		// Token: 0x04000915 RID: 2325
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x04000916 RID: 2326
		private const string TABLE = "ChatExpressionGroup";

		// Token: 0x04000917 RID: 2327
		private const string COMMAND = "select BinData from `ChatExpressionGroup`";

		// Token: 0x04000918 RID: 2328
		private const string KEY_PREFIX = "ChatExpressionGroupAll";

		// Token: 0x04000919 RID: 2329
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400091A RID: 2330
		private static int HandleId;
	}
}
