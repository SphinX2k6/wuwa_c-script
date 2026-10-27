using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000151 RID: 337
	public class ConfigChatExpressionGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007E7 RID: 2023 RVA: 0x0008643F File Offset: 0x0008463F
		static ConfigChatExpressionGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatExpressionGroupById.CreateStaticDefaultValue), new Action(ConfigChatExpressionGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00086460 File Offset: 0x00084660
		public static void CreateStaticDefaultValue()
		{
			ConfigChatExpressionGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatExpressionGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_chat.db"),
				new ValueTuple<string, object>("文件", "l.聊天.xlsx"),
				new ValueTuple<string, object>("表名", "ChatExpressionGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatExpressionGroup` where Id=?")
			});
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000864DF File Offset: 0x000846DF
		public static void ResetStaticDefaultValue()
		{
			ConfigChatExpressionGroupById.LogPair = null;
			ConfigChatExpressionGroupById.HandleId = 0;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000864ED File Offset: 0x000846ED
		public static void Init()
		{
			ConfigChatExpressionGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigChatExpressionGroupById.HandleId, "db_chat.db", "select BinData from `ChatExpressionGroup` where Id=?");
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00086508 File Offset: 0x00084708
		public static ChatExpressionGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatExpressionGroupById.HandleId, ConfigChatExpressionGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatExpressionGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChatExpressionGroup?(ChatExpressionGroup.GetRootAsChatExpressionGroup(configBuffer));
				}
			}
			ConfigChatExpressionGroupById.LogPair.Clear();
			ConfigChatExpressionGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChatExpressionGroupById.HandleId, 1, p0Id, ConfigChatExpressionGroupById.LogPair) || ConfigCommon.Step(ConfigChatExpressionGroupById.HandleId, true, ConfigChatExpressionGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChatExpressionGroupById.HandleId, ConfigChatExpressionGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatExpressionGroupById.HandleId, 0, ConfigChatExpressionGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChatExpressionGroupById.HandleId, ConfigChatExpressionGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChatExpressionGroup rootAsChatExpressionGroup = ChatExpressionGroup.GetRootAsChatExpressionGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatExpressionGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChatExpressionGroupById.HandleId, ConfigChatExpressionGroupById.LogPair);
			return new ChatExpressionGroup?(rootAsChatExpressionGroup);
		}

		// Token: 0x0400091B RID: 2331
		private const string DB = "db_chat.db";

		// Token: 0x0400091C RID: 2332
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x0400091D RID: 2333
		private const string TABLE = "ChatExpressionGroup";

		// Token: 0x0400091E RID: 2334
		private const string COMMAND = "select BinData from `ChatExpressionGroup` where Id=?";

		// Token: 0x0400091F RID: 2335
		private const string KEY_PREFIX = "ChatExpressionGroupById";

		// Token: 0x04000920 RID: 2336
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000921 RID: 2337
		private static int HandleId;
	}
}
