using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000154 RID: 340
	public class ConfigChatPartnerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x00086A64 File Offset: 0x00084C64
		static ConfigChatPartnerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatPartnerById.CreateStaticDefaultValue), new Action(ConfigChatPartnerById.ResetStaticDefaultValue));
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00086A84 File Offset: 0x00084C84
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

		// Token: 0x060007FB RID: 2043 RVA: 0x00086B03 File Offset: 0x00084D03
		public static void ResetStaticDefaultValue()
		{
			ConfigChatPartnerById.LogPair = null;
			ConfigChatPartnerById.HandleId = 0;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00086B11 File Offset: 0x00084D11
		public static void Init()
		{
			ConfigChatPartnerById.HandleId = ConfigCommon.InitDataStatement(ConfigChatPartnerById.HandleId, "db_phonemsg.db", "select BinData from `ChatPartner` where Id = ?");
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00086B2C File Offset: 0x00084D2C
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

		// Token: 0x04000930 RID: 2352
		private const string DB = "db_phonemsg.db";

		// Token: 0x04000931 RID: 2353
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04000932 RID: 2354
		private const string TABLE = "ChatPartner";

		// Token: 0x04000933 RID: 2355
		private const string COMMAND = "select BinData from `ChatPartner` where Id = ?";

		// Token: 0x04000934 RID: 2356
		private const string KEY_PREFIX = "ChatPartnerById";

		// Token: 0x04000935 RID: 2357
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000936 RID: 2358
		private static int HandleId;
	}
}
