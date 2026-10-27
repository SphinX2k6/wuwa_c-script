using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200014D RID: 333
	public class ConfigChatExpressionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007CF RID: 1999 RVA: 0x00085C98 File Offset: 0x00083E98
		static ConfigChatExpressionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatExpressionAll.CreateStaticDefaultValue), new Action(ConfigChatExpressionAll.ResetStaticDefaultValue));
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00085CB8 File Offset: 0x00083EB8
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

		// Token: 0x060007D1 RID: 2001 RVA: 0x00085D37 File Offset: 0x00083F37
		public static void ResetStaticDefaultValue()
		{
			ConfigChatExpressionAll.LogPair = null;
			ConfigChatExpressionAll.HandleId = 0;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00085D45 File Offset: 0x00083F45
		public static void Init()
		{
			ConfigChatExpressionAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatExpressionAll.HandleId, "db_chat.db", "select BinData from `ChatExpression`");
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00085D60 File Offset: 0x00083F60
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

		// Token: 0x040008FF RID: 2303
		private const string DB = "db_chat.db";

		// Token: 0x04000900 RID: 2304
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x04000901 RID: 2305
		private const string TABLE = "ChatExpression";

		// Token: 0x04000902 RID: 2306
		private const string COMMAND = "select BinData from `ChatExpression`";

		// Token: 0x04000903 RID: 2307
		private const string KEY_PREFIX = "ChatExpressionAll";

		// Token: 0x04000904 RID: 2308
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000905 RID: 2309
		private static int HandleId;
	}
}
