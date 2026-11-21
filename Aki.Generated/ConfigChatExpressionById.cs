using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200015E RID: 350
	public class ConfigChatExpressionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000835 RID: 2101 RVA: 0x0008B9C7 File Offset: 0x00089BC7
		static ConfigChatExpressionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatExpressionById.CreateStaticDefaultValue), new Action(ConfigChatExpressionById.ResetStaticDefaultValue));
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0008B9E8 File Offset: 0x00089BE8
		public static void CreateStaticDefaultValue()
		{
			ConfigChatExpressionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatExpressionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_chat.db"),
				new ValueTuple<string, object>("文件", "l.聊天.xlsx"),
				new ValueTuple<string, object>("表名", "ChatExpression"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatExpression` where Id=?")
			});
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0008BA67 File Offset: 0x00089C67
		public static void ResetStaticDefaultValue()
		{
			ConfigChatExpressionById.LogPair = null;
			ConfigChatExpressionById.HandleId = 0;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0008BA75 File Offset: 0x00089C75
		public static void Init()
		{
			ConfigChatExpressionById.HandleId = ConfigCommon.InitDataStatement(ConfigChatExpressionById.HandleId, "db_chat.db", "select BinData from `ChatExpression` where Id=?");
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0008BA90 File Offset: 0x00089C90
		public static ChatExpression? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatExpressionById.HandleId, ConfigChatExpressionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatExpressionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChatExpression?(ChatExpression.GetRootAsChatExpression(configBuffer));
				}
			}
			ConfigChatExpressionById.LogPair.Clear();
			ConfigChatExpressionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChatExpressionById.HandleId, 1, p0Id, ConfigChatExpressionById.LogPair) || ConfigCommon.Step(ConfigChatExpressionById.HandleId, true, ConfigChatExpressionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChatExpressionById.HandleId, ConfigChatExpressionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatExpressionById.HandleId, 0, ConfigChatExpressionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChatExpressionById.HandleId, ConfigChatExpressionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChatExpression rootAsChatExpression = ChatExpression.GetRootAsChatExpression(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatExpressionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChatExpressionById.HandleId, ConfigChatExpressionById.LogPair);
			return new ChatExpression?(rootAsChatExpression);
		}

		// Token: 0x04000976 RID: 2422
		private const string DB = "db_chat.db";

		// Token: 0x04000977 RID: 2423
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x04000978 RID: 2424
		private const string TABLE = "ChatExpression";

		// Token: 0x04000979 RID: 2425
		private const string COMMAND = "select BinData from `ChatExpression` where Id=?";

		// Token: 0x0400097A RID: 2426
		private const string KEY_PREFIX = "ChatExpressionById";

		// Token: 0x0400097B RID: 2427
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400097C RID: 2428
		private static int HandleId;
	}
}
