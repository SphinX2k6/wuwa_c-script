using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000165 RID: 357
	public class ConfigChatPartnerFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600085F RID: 2143 RVA: 0x0008C7A3 File Offset: 0x0008A9A3
		static ConfigChatPartnerFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatPartnerFilterById.CreateStaticDefaultValue), new Action(ConfigChatPartnerFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0008C7C4 File Offset: 0x0008A9C4
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

		// Token: 0x06000861 RID: 2145 RVA: 0x0008C843 File Offset: 0x0008AA43
		public static void ResetStaticDefaultValue()
		{
			ConfigChatPartnerFilterById.LogPair = null;
			ConfigChatPartnerFilterById.HandleId = 0;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0008C851 File Offset: 0x0008AA51
		public static void Init()
		{
			ConfigChatPartnerFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigChatPartnerFilterById.HandleId, "db_phonemsg.db", "select BinData from `ChatPartnerFilter` where Id=?");
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0008C86C File Offset: 0x0008AA6C
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

		// Token: 0x040009A7 RID: 2471
		private const string DB = "db_phonemsg.db";

		// Token: 0x040009A8 RID: 2472
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040009A9 RID: 2473
		private const string TABLE = "ChatPartnerFilter";

		// Token: 0x040009AA RID: 2474
		private const string COMMAND = "select BinData from `ChatPartnerFilter` where Id=?";

		// Token: 0x040009AB RID: 2475
		private const string KEY_PREFIX = "ChatPartnerFilterById";

		// Token: 0x040009AC RID: 2476
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009AD RID: 2477
		private static int HandleId;
	}
}
