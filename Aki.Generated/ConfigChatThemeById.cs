using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000158 RID: 344
	public class ConfigChatThemeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000811 RID: 2065 RVA: 0x0008721B File Offset: 0x0008541B
		static ConfigChatThemeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatThemeById.CreateStaticDefaultValue), new Action(ConfigChatThemeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0008723C File Offset: 0x0008543C
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

		// Token: 0x06000813 RID: 2067 RVA: 0x000872BB File Offset: 0x000854BB
		public static void ResetStaticDefaultValue()
		{
			ConfigChatThemeById.LogPair = null;
			ConfigChatThemeById.HandleId = 0;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x000872C9 File Offset: 0x000854C9
		public static void Init()
		{
			ConfigChatThemeById.HandleId = ConfigCommon.InitDataStatement(ConfigChatThemeById.HandleId, "db_phonemsg.db", "select BinData from `ChatTheme` where Id=?");
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x000872E4 File Offset: 0x000854E4
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

		// Token: 0x0400094C RID: 2380
		private const string DB = "db_phonemsg.db";

		// Token: 0x0400094D RID: 2381
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x0400094E RID: 2382
		private const string TABLE = "ChatTheme";

		// Token: 0x0400094F RID: 2383
		private const string COMMAND = "select BinData from `ChatTheme` where Id=?";

		// Token: 0x04000950 RID: 2384
		private const string KEY_PREFIX = "ChatThemeById";

		// Token: 0x04000951 RID: 2385
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000952 RID: 2386
		private static int HandleId;
	}
}
