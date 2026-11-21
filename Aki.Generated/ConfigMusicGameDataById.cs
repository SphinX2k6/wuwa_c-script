using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F7 RID: 1527
	public class ConfigMusicGameDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023D9 RID: 9177 RVA: 0x00127B3D File Offset: 0x00125D3D
		static ConfigMusicGameDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMusicGameDataById.CreateStaticDefaultValue), new Action(ConfigMusicGameDataById.ResetStaticDefaultValue));
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00127B5C File Offset: 0x00125D5C
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

		// Token: 0x060023DB RID: 9179 RVA: 0x00127BDB File Offset: 0x00125DDB
		public static void ResetStaticDefaultValue()
		{
			ConfigMusicGameDataById.LogPair = null;
			ConfigMusicGameDataById.HandleId = 0;
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x00127BE9 File Offset: 0x00125DE9
		public static void Init()
		{
			ConfigMusicGameDataById.HandleId = ConfigCommon.InitDataStatement(ConfigMusicGameDataById.HandleId, "db_musicgameconfig.db", "select BinData from `MusicGameData` where Id=?");
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00127C04 File Offset: 0x00125E04
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

		// Token: 0x040029A7 RID: 10663
		private const string DB = "db_musicgameconfig.db";

		// Token: 0x040029A8 RID: 10664
		private const string FILE = "UniverseEditor/MusicGameConfig.csv";

		// Token: 0x040029A9 RID: 10665
		private const string TABLE = "MusicGameData";

		// Token: 0x040029AA RID: 10666
		private const string COMMAND = "select BinData from `MusicGameData` where Id=?";

		// Token: 0x040029AB RID: 10667
		private const string KEY_PREFIX = "MusicGameDataById";

		// Token: 0x040029AC RID: 10668
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029AD RID: 10669
		private static int HandleId;
	}
}
