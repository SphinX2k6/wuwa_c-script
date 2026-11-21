using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000157 RID: 343
	public class ConfigChatById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600080B RID: 2059 RVA: 0x0008ABFC File Offset: 0x00088DFC
		static ConfigChatById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatById.CreateStaticDefaultValue), new Action(ConfigChatById.ResetStaticDefaultValue));
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0008AC1C File Offset: 0x00088E1C
		public static void CreateStaticDefaultValue()
		{
			ConfigChatById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_chat.db"),
				new ValueTuple<string, object>("文件", "l.聊天.xlsx"),
				new ValueTuple<string, object>("表名", "Chat"),
				new ValueTuple<string, object>("语句", "select BinData from `Chat` where Id=?")
			});
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0008AC9B File Offset: 0x00088E9B
		public static void ResetStaticDefaultValue()
		{
			ConfigChatById.LogPair = null;
			ConfigChatById.HandleId = 0;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0008ACA9 File Offset: 0x00088EA9
		public static void Init()
		{
			ConfigChatById.HandleId = ConfigCommon.InitDataStatement(ConfigChatById.HandleId, "db_chat.db", "select BinData from `Chat` where Id=?");
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0008ACC4 File Offset: 0x00088EC4
		public static Chat? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatById.HandleId, ConfigChatById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Chat?(Chat.GetRootAsChat(configBuffer));
				}
			}
			ConfigChatById.LogPair.Clear();
			ConfigChatById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChatById.HandleId, 1, p0Id, ConfigChatById.LogPair) || ConfigCommon.Step(ConfigChatById.HandleId, true, ConfigChatById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChatById.HandleId, ConfigChatById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatById.HandleId, 0, ConfigChatById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChatById.HandleId, ConfigChatById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Chat rootAsChat = Chat.GetRootAsChat(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChatById.HandleId, ConfigChatById.LogPair);
			return new Chat?(rootAsChat);
		}

		// Token: 0x04000945 RID: 2373
		private const string DB = "db_chat.db";

		// Token: 0x04000946 RID: 2374
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x04000947 RID: 2375
		private const string TABLE = "Chat";

		// Token: 0x04000948 RID: 2376
		private const string COMMAND = "select BinData from `Chat` where Id=?";

		// Token: 0x04000949 RID: 2377
		private const string KEY_PREFIX = "ChatById";

		// Token: 0x0400094A RID: 2378
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400094B RID: 2379
		private static int HandleId;
	}
}
