using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000147 RID: 327
	public class ConfigChatBgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007AB RID: 1963 RVA: 0x0008504F File Offset: 0x0008324F
		static ConfigChatBgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatBgById.CreateStaticDefaultValue), new Action(ConfigChatBgById.ResetStaticDefaultValue));
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00085070 File Offset: 0x00083270
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

		// Token: 0x060007AD RID: 1965 RVA: 0x000850EF File Offset: 0x000832EF
		public static void ResetStaticDefaultValue()
		{
			ConfigChatBgById.LogPair = null;
			ConfigChatBgById.HandleId = 0;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000850FD File Offset: 0x000832FD
		public static void Init()
		{
			ConfigChatBgById.HandleId = ConfigCommon.InitDataStatement(ConfigChatBgById.HandleId, "db_phonemsg.db", "select BinData from `ChatBg` where Id=?");
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00085118 File Offset: 0x00083318
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

		// Token: 0x040008D5 RID: 2261
		private const string DB = "db_phonemsg.db";

		// Token: 0x040008D6 RID: 2262
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040008D7 RID: 2263
		private const string TABLE = "ChatBg";

		// Token: 0x040008D8 RID: 2264
		private const string COMMAND = "select BinData from `ChatBg` where Id=?";

		// Token: 0x040008D9 RID: 2265
		private const string KEY_PREFIX = "ChatBgById";

		// Token: 0x040008DA RID: 2266
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008DB RID: 2267
		private static int HandleId;
	}
}
