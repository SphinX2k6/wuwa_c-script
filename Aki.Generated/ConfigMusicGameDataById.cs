using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005DF RID: 1503
	public class ConfigMusicGameDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002349 RID: 9033 RVA: 0x001210C1 File Offset: 0x0011F2C1
		static ConfigMusicGameDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMusicGameDataById.CreateStaticDefaultValue), new Action(ConfigMusicGameDataById.ResetStaticDefaultValue));
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x001210E0 File Offset: 0x0011F2E0
		public static void CreateStaticDefaultValue()
		{
			ConfigMusicGameDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMusicGameDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_musicgameconfig.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/MusicGameConfig.csv"),
				new ValueTuple<string, object>("表名", "MusicGameData"),
				new ValueTuple<string, object>("语句", "select BinData from `MusicGameData` where Id=?")
			});
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x0012115F File Offset: 0x0011F35F
		public static void ResetStaticDefaultValue()
		{
			ConfigMusicGameDataById.LogPair = null;
			ConfigMusicGameDataById.HandleId = 0;
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x0012116D File Offset: 0x0011F36D
		public static void Init()
		{
			ConfigMusicGameDataById.HandleId = ConfigCommon.InitDataStatement(ConfigMusicGameDataById.HandleId, "db_musicgameconfig.db", "select BinData from `MusicGameData` where Id=?");
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00121188 File Offset: 0x0011F388
		public static MusicGameData? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMusicGameDataById.HandleId, ConfigMusicGameDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MusicGameDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MusicGameData?(MusicGameData.GetRootAsMusicGameData(configBuffer));
				}
			}
			ConfigMusicGameDataById.LogPair.Clear();
			ConfigMusicGameDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMusicGameDataById.HandleId, 1, p0Id, ConfigMusicGameDataById.LogPair) || ConfigCommon.Step(ConfigMusicGameDataById.HandleId, true, ConfigMusicGameDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMusicGameDataById.HandleId, ConfigMusicGameDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMusicGameDataById.HandleId, 0, ConfigMusicGameDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMusicGameDataById.HandleId, ConfigMusicGameDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MusicGameData rootAsMusicGameData = MusicGameData.GetRootAsMusicGameData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MusicGameDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMusicGameDataById.HandleId, ConfigMusicGameDataById.LogPair);
			return new MusicGameData?(rootAsMusicGameData);
		}

		// Token: 0x040028FF RID: 10495
		private const string DB = "db_musicgameconfig.db";

		// Token: 0x04002900 RID: 10496
		private const string FILE = "UniverseEditor/MusicGameConfig.csv";

		// Token: 0x04002901 RID: 10497
		private const string TABLE = "MusicGameData";

		// Token: 0x04002902 RID: 10498
		private const string COMMAND = "select BinData from `MusicGameData` where Id=?";

		// Token: 0x04002903 RID: 10499
		private const string KEY_PREFIX = "MusicGameDataById";

		// Token: 0x04002904 RID: 10500
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002905 RID: 10501
		private static int HandleId;
	}
}
