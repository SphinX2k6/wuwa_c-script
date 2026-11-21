using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200015D RID: 349
	public class ConfigChatExpressionByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600082F RID: 2095 RVA: 0x0008B78F File Offset: 0x0008998F
		static ConfigChatExpressionByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatExpressionByGroupId.CreateStaticDefaultValue), new Action(ConfigChatExpressionByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0008B7B0 File Offset: 0x000899B0
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

		// Token: 0x06000831 RID: 2097 RVA: 0x0008B82F File Offset: 0x00089A2F
		public static void ResetStaticDefaultValue()
		{
			ConfigChatExpressionByGroupId.LogPair = null;
			ConfigChatExpressionByGroupId.HandleId = 0;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0008B83D File Offset: 0x00089A3D
		public static void Init()
		{
			ConfigChatExpressionByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigChatExpressionByGroupId.HandleId, "db_chat.db", "select BinData from `ChatExpression` where GroupId=?");
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0008B858 File Offset: 0x00089A58
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

		// Token: 0x0400096F RID: 2415
		private const string DB = "db_chat.db";

		// Token: 0x04000970 RID: 2416
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x04000971 RID: 2417
		private const string TABLE = "ChatExpression";

		// Token: 0x04000972 RID: 2418
		private const string COMMAND = "select BinData from `ChatExpression` where GroupId=?";

		// Token: 0x04000973 RID: 2419
		private const string KEY_PREFIX = "ChatExpressionByGroupId";

		// Token: 0x04000974 RID: 2420
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000975 RID: 2421
		private static int HandleId;
	}
}
