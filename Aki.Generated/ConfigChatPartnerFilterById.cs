using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000156 RID: 342
	public class ConfigChatPartnerFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000805 RID: 2053 RVA: 0x00086E3F File Offset: 0x0008503F
		static ConfigChatPartnerFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatPartnerFilterById.CreateStaticDefaultValue), new Action(ConfigChatPartnerFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00086E60 File Offset: 0x00085060
		public static void CreateStaticDefaultValue()
		{
			ConfigChatPartnerFilterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatPartnerFilterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChatPartnerFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatPartnerFilter` where Id=?")
			});
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00086EDF File Offset: 0x000850DF
		public static void ResetStaticDefaultValue()
		{
			ConfigChatPartnerFilterById.LogPair = null;
			ConfigChatPartnerFilterById.HandleId = 0;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00086EED File Offset: 0x000850ED
		public static void Init()
		{
			ConfigChatPartnerFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigChatPartnerFilterById.HandleId, "db_phonemsg.db", "select BinData from `ChatPartnerFilter` where Id=?");
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00086F08 File Offset: 0x00085108
		public static ChatPartnerFilter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatPartnerFilterById.HandleId, ConfigChatPartnerFilterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatPartnerFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChatPartnerFilter?(ChatPartnerFilter.GetRootAsChatPartnerFilter(configBuffer));
				}
			}
			ConfigChatPartnerFilterById.LogPair.Clear();
			ConfigChatPartnerFilterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChatPartnerFilterById.HandleId, 1, p0Id, ConfigChatPartnerFilterById.LogPair) || ConfigCommon.Step(ConfigChatPartnerFilterById.HandleId, true, ConfigChatPartnerFilterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChatPartnerFilterById.HandleId, ConfigChatPartnerFilterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatPartnerFilterById.HandleId, 0, ConfigChatPartnerFilterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChatPartnerFilterById.HandleId, ConfigChatPartnerFilterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChatPartnerFilter rootAsChatPartnerFilter = ChatPartnerFilter.GetRootAsChatPartnerFilter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatPartnerFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChatPartnerFilterById.HandleId, ConfigChatPartnerFilterById.LogPair);
			return new ChatPartnerFilter?(rootAsChatPartnerFilter);
		}

		// Token: 0x0400093E RID: 2366
		private const string DB = "db_phonemsg.db";

		// Token: 0x0400093F RID: 2367
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04000940 RID: 2368
		private const string TABLE = "ChatPartnerFilter";

		// Token: 0x04000941 RID: 2369
		private const string COMMAND = "select BinData from `ChatPartnerFilter` where Id=?";

		// Token: 0x04000942 RID: 2370
		private const string KEY_PREFIX = "ChatPartnerFilterById";

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
