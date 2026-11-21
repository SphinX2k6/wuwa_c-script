using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000160 RID: 352
	public class ConfigChatExpressionGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000841 RID: 2113 RVA: 0x0008BDA3 File Offset: 0x00089FA3
		static ConfigChatExpressionGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatExpressionGroupById.CreateStaticDefaultValue), new Action(ConfigChatExpressionGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0008BDC4 File Offset: 0x00089FC4
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

		// Token: 0x06000843 RID: 2115 RVA: 0x0008BE43 File Offset: 0x0008A043
		public static void ResetStaticDefaultValue()
		{
			ConfigChatExpressionGroupById.LogPair = null;
			ConfigChatExpressionGroupById.HandleId = 0;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0008BE51 File Offset: 0x0008A051
		public static void Init()
		{
			ConfigChatExpressionGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigChatExpressionGroupById.HandleId, "db_chat.db", "select BinData from `ChatExpressionGroup` where Id=?");
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0008BE6C File Offset: 0x0008A06C
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

		// Token: 0x04000984 RID: 2436
		private const string DB = "db_chat.db";

		// Token: 0x04000985 RID: 2437
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x04000986 RID: 2438
		private const string TABLE = "ChatExpressionGroup";

		// Token: 0x04000987 RID: 2439
		private const string COMMAND = "select BinData from `ChatExpressionGroup` where Id=?";

		// Token: 0x04000988 RID: 2440
		private const string KEY_PREFIX = "ChatExpressionGroupById";

		// Token: 0x04000989 RID: 2441
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400098A RID: 2442
		private static int HandleId;
	}
}
