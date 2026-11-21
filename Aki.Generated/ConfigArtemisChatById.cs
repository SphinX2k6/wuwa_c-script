using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000BB RID: 187
	public class ConfigArtemisChatById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000463 RID: 1123 RVA: 0x00076055 File Offset: 0x00074255
		static ConfigArtemisChatById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigArtemisChatById.CreateStaticDefaultValue), new Action(ConfigArtemisChatById.ResetStaticDefaultValue));
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00076074 File Offset: 0x00074274
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

		// Token: 0x06000465 RID: 1125 RVA: 0x000760F3 File Offset: 0x000742F3
		public static void ResetStaticDefaultValue()
		{
			ConfigArtemisChatById.LogPair = null;
			ConfigArtemisChatById.HandleId = 0;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00076101 File Offset: 0x00074301
		public static void Init()
		{
			ConfigArtemisChatById.HandleId = ConfigCommon.InitDataStatement(ConfigArtemisChatById.HandleId, "db_artemis.db", "select BinData from `ArtemisChat` where Id=?");
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0007611C File Offset: 0x0007431C
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

		// Token: 0x04000501 RID: 1281
		private const string DB = "db_artemis.db";

		// Token: 0x04000502 RID: 1282
		private const string FILE = "a.爱弥斯预热签到活动.xlsx";

		// Token: 0x04000503 RID: 1283
		private const string TABLE = "ArtemisChat";

		// Token: 0x04000504 RID: 1284
		private const string COMMAND = "select BinData from `ArtemisChat` where Id=?";

		// Token: 0x04000505 RID: 1285
		private const string KEY_PREFIX = "ArtemisChatById";

		// Token: 0x04000506 RID: 1286
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000507 RID: 1287
		private static int HandleId;
	}
}
