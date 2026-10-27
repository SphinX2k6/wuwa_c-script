using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200014E RID: 334
	public class ConfigChatExpressionByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007D5 RID: 2005 RVA: 0x00085E2B File Offset: 0x0008402B
		static ConfigChatExpressionByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatExpressionByGroupId.CreateStaticDefaultValue), new Action(ConfigChatExpressionByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00085E4C File Offset: 0x0008404C
		public static void CreateStaticDefaultValue()
		{
			ConfigChatExpressionByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatExpressionByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_chat.db"),
				new ValueTuple<string, object>("文件", "l.聊天.xlsx"),
				new ValueTuple<string, object>("表名", "ChatExpression"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatExpression` where GroupId=?")
			});
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00085ECB File Offset: 0x000840CB
		public static void ResetStaticDefaultValue()
		{
			ConfigChatExpressionByGroupId.LogPair = null;
			ConfigChatExpressionByGroupId.HandleId = 0;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00085ED9 File Offset: 0x000840D9
		public static void Init()
		{
			ConfigChatExpressionByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigChatExpressionByGroupId.HandleId, "db_chat.db", "select BinData from `ChatExpression` where GroupId=?");
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00085EF4 File Offset: 0x000840F4
		[NullableContext(2)]
		public static IReadOnlyList<ChatExpression> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatExpressionByGroupId.HandleId, ConfigChatExpressionByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatExpressionByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<ChatExpression> readOnlyList = (IReadOnlyList<ChatExpression>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigChatExpressionByGroupId.LogPair.Clear();
			ConfigChatExpressionByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigChatExpressionByGroupId.HandleId, 1, p0GroupId, ConfigChatExpressionByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigChatExpressionByGroupId.HandleId, ConfigChatExpressionByGroupId.LogPair);
				return null;
			}
			List<ChatExpression> list = new List<ChatExpression>();
			while (ConfigCommon.Step(ConfigChatExpressionByGroupId.HandleId, false, ConfigChatExpressionByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatExpressionByGroupId.HandleId, 0, ConfigChatExpressionByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigChatExpressionByGroupId.HandleId, ConfigChatExpressionByGroupId.LogPair);
					return null;
				}
				ChatExpression rootAsChatExpression = ChatExpression.GetRootAsChatExpression(new ByteBuffer(item2));
				list.Add(rootAsChatExpression);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatExpressionByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigChatExpressionByGroupId.HandleId, ConfigChatExpressionByGroupId.LogPair);
			return list;
		}

		// Token: 0x04000906 RID: 2310
		private const string DB = "db_chat.db";

		// Token: 0x04000907 RID: 2311
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x04000908 RID: 2312
		private const string TABLE = "ChatExpression";

		// Token: 0x04000909 RID: 2313
		private const string COMMAND = "select BinData from `ChatExpression` where GroupId=?";

		// Token: 0x0400090A RID: 2314
		private const string KEY_PREFIX = "ChatExpressionByGroupId";

		// Token: 0x0400090B RID: 2315
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400090C RID: 2316
		private static int HandleId;
	}
}
