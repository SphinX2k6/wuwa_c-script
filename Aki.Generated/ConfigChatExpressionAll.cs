using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200015C RID: 348
	public class ConfigChatExpressionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000829 RID: 2089 RVA: 0x0008B5FC File Offset: 0x000897FC
		static ConfigChatExpressionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatExpressionAll.CreateStaticDefaultValue), new Action(ConfigChatExpressionAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0008B61C File Offset: 0x0008981C
		public static void CreateStaticDefaultValue()
		{
			ConfigChatExpressionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatExpressionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_chat.db"),
				new ValueTuple<string, object>("文件", "l.聊天.xlsx"),
				new ValueTuple<string, object>("表名", "ChatExpression"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatExpression`")
			});
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0008B69B File Offset: 0x0008989B
		public static void ResetStaticDefaultValue()
		{
			ConfigChatExpressionAll.LogPair = null;
			ConfigChatExpressionAll.HandleId = 0;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0008B6A9 File Offset: 0x000898A9
		public static void Init()
		{
			ConfigChatExpressionAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatExpressionAll.HandleId, "db_chat.db", "select BinData from `ChatExpression`");
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0008B6C4 File Offset: 0x000898C4
		[NullableContext(2)]
		public static IReadOnlyList<ChatExpression> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatExpressionAll.HandleId, ConfigChatExpressionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ChatExpression> readOnlyList = (IReadOnlyList<ChatExpression>)ConfigCommon.GetConfig("ChatExpressionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ChatExpression> list = new List<ChatExpression>();
			while (ConfigCommon.Step(ConfigChatExpressionAll.HandleId, false, ConfigChatExpressionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatExpressionAll.HandleId, 0, ConfigChatExpressionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigChatExpressionAll.HandleId, ConfigChatExpressionAll.LogPair);
					return null;
				}
				ChatExpression rootAsChatExpression = ChatExpression.GetRootAsChatExpression(new ByteBuffer(item2));
				list.Add(rootAsChatExpression);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ChatExpressionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigChatExpressionAll.HandleId, ConfigChatExpressionAll.LogPair);
			return list;
		}

		// Token: 0x04000968 RID: 2408
		private const string DB = "db_chat.db";

		// Token: 0x04000969 RID: 2409
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x0400096A RID: 2410
		private const string TABLE = "ChatExpression";

		// Token: 0x0400096B RID: 2411
		private const string COMMAND = "select BinData from `ChatExpression`";

		// Token: 0x0400096C RID: 2412
		private const string KEY_PREFIX = "ChatExpressionAll";

		// Token: 0x0400096D RID: 2413
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400096E RID: 2414
		private static int HandleId;
	}
}
