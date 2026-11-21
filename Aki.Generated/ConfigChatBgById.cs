using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000156 RID: 342
	public class ConfigChatBgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000805 RID: 2053 RVA: 0x0008A9B3 File Offset: 0x00088BB3
		static ConfigChatBgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatBgById.CreateStaticDefaultValue), new Action(ConfigChatBgById.ResetStaticDefaultValue));
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0008A9D4 File Offset: 0x00088BD4
		public static void CreateStaticDefaultValue()
		{
			ConfigChatBgById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatBgById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChatBg"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatBg` where Id=?")
			});
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0008AA53 File Offset: 0x00088C53
		public static void ResetStaticDefaultValue()
		{
			ConfigChatBgById.LogPair = null;
			ConfigChatBgById.HandleId = 0;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0008AA61 File Offset: 0x00088C61
		public static void Init()
		{
			ConfigChatBgById.HandleId = ConfigCommon.InitDataStatement(ConfigChatBgById.HandleId, "db_phonemsg.db", "select BinData from `ChatBg` where Id=?");
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0008AA7C File Offset: 0x00088C7C
		public static ChatBg? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatBgById.HandleId, ConfigChatBgById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatBgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChatBg?(ChatBg.GetRootAsChatBg(configBuffer));
				}
			}
			ConfigChatBgById.LogPair.Clear();
			ConfigChatBgById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChatBgById.HandleId, 1, p0Id, ConfigChatBgById.LogPair) || ConfigCommon.Step(ConfigChatBgById.HandleId, true, ConfigChatBgById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChatBgById.HandleId, ConfigChatBgById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatBgById.HandleId, 0, ConfigChatBgById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChatBgById.HandleId, ConfigChatBgById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChatBg rootAsChatBg = ChatBg.GetRootAsChatBg(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatBgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChatBgById.HandleId, ConfigChatBgById.LogPair);
			return new ChatBg?(rootAsChatBg);
		}

		// Token: 0x0400093E RID: 2366
		private const string DB = "db_phonemsg.db";

		// Token: 0x0400093F RID: 2367
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04000940 RID: 2368
		private const string TABLE = "ChatBg";

		// Token: 0x04000941 RID: 2369
		private const string COMMAND = "select BinData from `ChatBg` where Id=?";

		// Token: 0x04000942 RID: 2370
		private const string KEY_PREFIX = "ChatBgById";

		// Token: 0x04000943 RID: 2371
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000944 RID: 2372
		private static int HandleId;
	}
}
