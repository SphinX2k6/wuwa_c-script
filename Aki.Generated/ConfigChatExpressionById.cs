using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200014F RID: 335
	public class ConfigChatExpressionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007DB RID: 2011 RVA: 0x00086063 File Offset: 0x00084263
		static ConfigChatExpressionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatExpressionById.CreateStaticDefaultValue), new Action(ConfigChatExpressionById.ResetStaticDefaultValue));
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00086084 File Offset: 0x00084284
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

		// Token: 0x060007DD RID: 2013 RVA: 0x00086103 File Offset: 0x00084303
		public static void ResetStaticDefaultValue()
		{
			ConfigChatExpressionById.LogPair = null;
			ConfigChatExpressionById.HandleId = 0;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00086111 File Offset: 0x00084311
		public static void Init()
		{
			ConfigChatExpressionById.HandleId = ConfigCommon.InitDataStatement(ConfigChatExpressionById.HandleId, "db_chat.db", "select BinData from `ChatExpression` where Id=?");
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0008612C File Offset: 0x0008432C
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

		// Token: 0x0400090D RID: 2317
		private const string DB = "db_chat.db";

		// Token: 0x0400090E RID: 2318
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x0400090F RID: 2319
		private const string TABLE = "ChatExpression";

		// Token: 0x04000910 RID: 2320
		private const string COMMAND = "select BinData from `ChatExpression` where Id=?";

		// Token: 0x04000911 RID: 2321
		private const string KEY_PREFIX = "ChatExpressionById";

		// Token: 0x04000912 RID: 2322
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000913 RID: 2323
		private static int HandleId;
	}
}
