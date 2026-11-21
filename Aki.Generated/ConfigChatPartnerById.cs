using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000163 RID: 355
	public class ConfigChatPartnerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000853 RID: 2131 RVA: 0x0008C3C8 File Offset: 0x0008A5C8
		static ConfigChatPartnerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatPartnerById.CreateStaticDefaultValue), new Action(ConfigChatPartnerById.ResetStaticDefaultValue));
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0008C3E8 File Offset: 0x0008A5E8
		public static void CreateStaticDefaultValue()
		{
			ConfigChatPartnerById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatPartnerById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChatPartner"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatPartner` where Id = ?")
			});
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0008C467 File Offset: 0x0008A667
		public static void ResetStaticDefaultValue()
		{
			ConfigChatPartnerById.LogPair = null;
			ConfigChatPartnerById.HandleId = 0;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0008C475 File Offset: 0x0008A675
		public static void Init()
		{
			ConfigChatPartnerById.HandleId = ConfigCommon.InitDataStatement(ConfigChatPartnerById.HandleId, "db_phonemsg.db", "select BinData from `ChatPartner` where Id = ?");
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0008C490 File Offset: 0x0008A690
		public static ChatPartner? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatPartnerById.HandleId, ConfigChatPartnerById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatPartnerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChatPartner?(ChatPartner.GetRootAsChatPartner(configBuffer));
				}
			}
			ConfigChatPartnerById.LogPair.Clear();
			ConfigChatPartnerById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChatPartnerById.HandleId, 1, p0Id, ConfigChatPartnerById.LogPair) || ConfigCommon.Step(ConfigChatPartnerById.HandleId, true, ConfigChatPartnerById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChatPartnerById.HandleId, ConfigChatPartnerById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatPartnerById.HandleId, 0, ConfigChatPartnerById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChatPartnerById.HandleId, ConfigChatPartnerById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChatPartner rootAsChatPartner = ChatPartner.GetRootAsChatPartner(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatPartnerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChatPartnerById.HandleId, ConfigChatPartnerById.LogPair);
			return new ChatPartner?(rootAsChatPartner);
		}

		// Token: 0x04000999 RID: 2457
		private const string DB = "db_phonemsg.db";

		// Token: 0x0400099A RID: 2458
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x0400099B RID: 2459
		private const string TABLE = "ChatPartner";

		// Token: 0x0400099C RID: 2460
		private const string COMMAND = "select BinData from `ChatPartner` where Id = ?";

		// Token: 0x0400099D RID: 2461
		private const string KEY_PREFIX = "ChatPartnerById";

		// Token: 0x0400099E RID: 2462
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400099F RID: 2463
		private static int HandleId;
	}
}
