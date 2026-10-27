using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000148 RID: 328
	public class ConfigChatById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007B1 RID: 1969 RVA: 0x00085298 File Offset: 0x00083498
		static ConfigChatById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatById.CreateStaticDefaultValue), new Action(ConfigChatById.ResetStaticDefaultValue));
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000852B8 File Offset: 0x000834B8
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

		// Token: 0x060007B3 RID: 1971 RVA: 0x00085337 File Offset: 0x00083537
		public static void ResetStaticDefaultValue()
		{
			ConfigChatById.LogPair = null;
			ConfigChatById.HandleId = 0;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00085345 File Offset: 0x00083545
		public static void Init()
		{
			ConfigChatById.HandleId = ConfigCommon.InitDataStatement(ConfigChatById.HandleId, "db_chat.db", "select BinData from `Chat` where Id=?");
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00085360 File Offset: 0x00083560
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

		// Token: 0x040008DC RID: 2268
		private const string DB = "db_chat.db";

		// Token: 0x040008DD RID: 2269
		private const string FILE = "l.聊天.xlsx";

		// Token: 0x040008DE RID: 2270
		private const string TABLE = "Chat";

		// Token: 0x040008DF RID: 2271
		private const string COMMAND = "select BinData from `Chat` where Id=?";

		// Token: 0x040008E0 RID: 2272
		private const string KEY_PREFIX = "ChatById";

		// Token: 0x040008E1 RID: 2273
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008E2 RID: 2274
		private static int HandleId;
	}
}
