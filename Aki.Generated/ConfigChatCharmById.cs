using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000159 RID: 345
	public class ConfigChatCharmById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000817 RID: 2071 RVA: 0x0008AFD7 File Offset: 0x000891D7
		static ConfigChatCharmById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatCharmById.CreateStaticDefaultValue), new Action(ConfigChatCharmById.ResetStaticDefaultValue));
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0008AFF8 File Offset: 0x000891F8
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

		// Token: 0x06000819 RID: 2073 RVA: 0x0008B077 File Offset: 0x00089277
		public static void ResetStaticDefaultValue()
		{
			ConfigChatCharmById.LogPair = null;
			ConfigChatCharmById.HandleId = 0;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0008B085 File Offset: 0x00089285
		public static void Init()
		{
			ConfigChatCharmById.HandleId = ConfigCommon.InitDataStatement(ConfigChatCharmById.HandleId, "db_phonemsg.db", "select BinData from `ChatCharm` where Id=?");
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0008B0A0 File Offset: 0x000892A0
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

		// Token: 0x04000953 RID: 2387
		private const string DB = "db_phonemsg.db";

		// Token: 0x04000954 RID: 2388
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04000955 RID: 2389
		private const string TABLE = "ChatCharm";

		// Token: 0x04000956 RID: 2390
		private const string COMMAND = "select BinData from `ChatCharm` where Id=?";

		// Token: 0x04000957 RID: 2391
		private const string KEY_PREFIX = "ChatCharmById";

		// Token: 0x04000958 RID: 2392
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000959 RID: 2393
		private static int HandleId;
	}
}
