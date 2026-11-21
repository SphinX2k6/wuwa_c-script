using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000167 RID: 359
	public class ConfigChatThemeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600086B RID: 2155 RVA: 0x0008CB7F File Offset: 0x0008AD7F
		static ConfigChatThemeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatThemeById.CreateStaticDefaultValue), new Action(ConfigChatThemeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0008CBA0 File Offset: 0x0008ADA0
		public static void CreateStaticDefaultValue()
		{
			ConfigChatThemeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatThemeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChatTheme"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatTheme` where Id=?")
			});
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0008CC1F File Offset: 0x0008AE1F
		public static void ResetStaticDefaultValue()
		{
			ConfigChatThemeById.LogPair = null;
			ConfigChatThemeById.HandleId = 0;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0008CC2D File Offset: 0x0008AE2D
		public static void Init()
		{
			ConfigChatThemeById.HandleId = ConfigCommon.InitDataStatement(ConfigChatThemeById.HandleId, "db_phonemsg.db", "select BinData from `ChatTheme` where Id=?");
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0008CC48 File Offset: 0x0008AE48
		public static ChatTheme? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatThemeById.HandleId, ConfigChatThemeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatThemeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChatTheme?(ChatTheme.GetRootAsChatTheme(configBuffer));
				}
			}
			ConfigChatThemeById.LogPair.Clear();
			ConfigChatThemeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChatThemeById.HandleId, 1, p0Id, ConfigChatThemeById.LogPair) || ConfigCommon.Step(ConfigChatThemeById.HandleId, true, ConfigChatThemeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChatThemeById.HandleId, ConfigChatThemeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatThemeById.HandleId, 0, ConfigChatThemeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChatThemeById.HandleId, ConfigChatThemeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChatTheme rootAsChatTheme = ChatTheme.GetRootAsChatTheme(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatThemeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChatThemeById.HandleId, ConfigChatThemeById.LogPair);
			return new ChatTheme?(rootAsChatTheme);
		}

		// Token: 0x040009B5 RID: 2485
		private const string DB = "db_phonemsg.db";

		// Token: 0x040009B6 RID: 2486
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040009B7 RID: 2487
		private const string TABLE = "ChatTheme";

		// Token: 0x040009B8 RID: 2488
		private const string COMMAND = "select BinData from `ChatTheme` where Id=?";

		// Token: 0x040009B9 RID: 2489
		private const string KEY_PREFIX = "ChatThemeById";

		// Token: 0x040009BA RID: 2490
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009BB RID: 2491
		private static int HandleId;
	}
}
