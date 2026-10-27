using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B3 RID: 179
	public class ConfigArtemisChatById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000433 RID: 1075 RVA: 0x000717A1 File Offset: 0x0006F9A1
		static ConfigArtemisChatById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigArtemisChatById.CreateStaticDefaultValue), new Action(ConfigArtemisChatById.ResetStaticDefaultValue));
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000717C0 File Offset: 0x0006F9C0
		public static void CreateStaticDefaultValue()
		{
			ConfigArtemisChatById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigArtemisChatById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_artemis.db"),
				new ValueTuple<string, object>("文件", "a.爱弥斯预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "ArtemisChat"),
				new ValueTuple<string, object>("语句", "select BinData from `ArtemisChat` where Id=?")
			});
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0007183F File Offset: 0x0006FA3F
		public static void ResetStaticDefaultValue()
		{
			ConfigArtemisChatById.LogPair = null;
			ConfigArtemisChatById.HandleId = 0;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0007184D File Offset: 0x0006FA4D
		public static void Init()
		{
			ConfigArtemisChatById.HandleId = ConfigCommon.InitDataStatement(ConfigArtemisChatById.HandleId, "db_artemis.db", "select BinData from `ArtemisChat` where Id=?");
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00071868 File Offset: 0x0006FA68
		public static ArtemisChat? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigArtemisChatById.HandleId, ConfigArtemisChatById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ArtemisChatById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ArtemisChat?(ArtemisChat.GetRootAsArtemisChat(configBuffer));
				}
			}
			ConfigArtemisChatById.LogPair.Clear();
			ConfigArtemisChatById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigArtemisChatById.HandleId, 1, p0Id, ConfigArtemisChatById.LogPair) || ConfigCommon.Step(ConfigArtemisChatById.HandleId, true, ConfigArtemisChatById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigArtemisChatById.HandleId, ConfigArtemisChatById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigArtemisChatById.HandleId, 0, ConfigArtemisChatById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigArtemisChatById.HandleId, ConfigArtemisChatById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ArtemisChat rootAsArtemisChat = ArtemisChat.GetRootAsArtemisChat(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ArtemisChatById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigArtemisChatById.HandleId, ConfigArtemisChatById.LogPair);
			return new ArtemisChat?(rootAsArtemisChat);
		}

		// Token: 0x040004C9 RID: 1225
		private const string DB = "db_artemis.db";

		// Token: 0x040004CA RID: 1226
		private const string FILE = "a.爱弥斯预热签到活动.xlsx";

		// Token: 0x040004CB RID: 1227
		private const string TABLE = "ArtemisChat";

		// Token: 0x040004CC RID: 1228
		private const string COMMAND = "select BinData from `ArtemisChat` where Id=?";

		// Token: 0x040004CD RID: 1229
		private const string KEY_PREFIX = "ArtemisChatById";

		// Token: 0x040004CE RID: 1230
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004CF RID: 1231
		private static int HandleId;
	}
}
