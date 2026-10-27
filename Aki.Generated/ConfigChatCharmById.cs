using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200014A RID: 330
	public class ConfigChatCharmById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007BD RID: 1981 RVA: 0x00085673 File Offset: 0x00083873
		static ConfigChatCharmById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatCharmById.CreateStaticDefaultValue), new Action(ConfigChatCharmById.ResetStaticDefaultValue));
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00085694 File Offset: 0x00083894
		public static void CreateStaticDefaultValue()
		{
			ConfigChatCharmById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatCharmById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChatCharm"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatCharm` where Id=?")
			});
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00085713 File Offset: 0x00083913
		public static void ResetStaticDefaultValue()
		{
			ConfigChatCharmById.LogPair = null;
			ConfigChatCharmById.HandleId = 0;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00085721 File Offset: 0x00083921
		public static void Init()
		{
			ConfigChatCharmById.HandleId = ConfigCommon.InitDataStatement(ConfigChatCharmById.HandleId, "db_phonemsg.db", "select BinData from `ChatCharm` where Id=?");
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0008573C File Offset: 0x0008393C
		public static ChatCharm? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatCharmById.HandleId, ConfigChatCharmById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatCharmById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChatCharm?(ChatCharm.GetRootAsChatCharm(configBuffer));
				}
			}
			ConfigChatCharmById.LogPair.Clear();
			ConfigChatCharmById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChatCharmById.HandleId, 1, p0Id, ConfigChatCharmById.LogPair) || ConfigCommon.Step(ConfigChatCharmById.HandleId, true, ConfigChatCharmById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChatCharmById.HandleId, ConfigChatCharmById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatCharmById.HandleId, 0, ConfigChatCharmById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChatCharmById.HandleId, ConfigChatCharmById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChatCharm rootAsChatCharm = ChatCharm.GetRootAsChatCharm(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatCharmById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChatCharmById.HandleId, ConfigChatCharmById.LogPair);
			return new ChatCharm?(rootAsChatCharm);
		}

		// Token: 0x040008EA RID: 2282
		private const string DB = "db_phonemsg.db";

		// Token: 0x040008EB RID: 2283
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040008EC RID: 2284
		private const string TABLE = "ChatCharm";

		// Token: 0x040008ED RID: 2285
		private const string COMMAND = "select BinData from `ChatCharm` where Id=?";

		// Token: 0x040008EE RID: 2286
		private const string KEY_PREFIX = "ChatCharmById";

		// Token: 0x040008EF RID: 2287
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008F0 RID: 2288
		private static int HandleId;
	}
}
