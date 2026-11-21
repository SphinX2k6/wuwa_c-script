using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F6 RID: 1526
	public class ConfigMusicBeatTypeByBeatType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023D3 RID: 9171 RVA: 0x00127944 File Offset: 0x00125B44
		static ConfigMusicBeatTypeByBeatType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMusicBeatTypeByBeatType.CreateStaticDefaultValue), new Action(ConfigMusicBeatTypeByBeatType.ResetStaticDefaultValue));
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00127964 File Offset: 0x00125B64
		public static void CreateStaticDefaultValue()
		{
			ConfigMusicBeatTypeByBeatType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMusicBeatTypeByBeatType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_musicbeattype.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/y.音乐节拍配置/*.csv*"),
				new ValueTuple<string, object>("表名", "MusicBeatType"),
				new ValueTuple<string, object>("语句", "select BinData from `MusicBeatType` where BeatType=?")
			});
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x001279E3 File Offset: 0x00125BE3
		public static void ResetStaticDefaultValue()
		{
			ConfigMusicBeatTypeByBeatType.LogPair = null;
			ConfigMusicBeatTypeByBeatType.HandleId = 0;
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x001279F1 File Offset: 0x00125BF1
		public static void Init()
		{
			ConfigMusicBeatTypeByBeatType.HandleId = ConfigCommon.InitDataStatement(ConfigMusicBeatTypeByBeatType.HandleId, "db_musicbeattype.db", "select BinData from `MusicBeatType` where BeatType=?");
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x00127A0C File Offset: 0x00125C0C
		public static MusicBeatType? GetConfig(string p0BeatType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMusicBeatTypeByBeatType.HandleId, ConfigMusicBeatTypeByBeatType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("MusicBeatTypeByBeatType#" + p0BeatType);
				if (configBuffer != null)
				{
					return new MusicBeatType?(MusicBeatType.GetRootAsMusicBeatType(configBuffer));
				}
			}
			ConfigMusicBeatTypeByBeatType.LogPair.Clear();
			ConfigMusicBeatTypeByBeatType.LogPair.Add(new ValueTuple<string, object>("BeatType", p0BeatType));
			if (!ConfigCommon.BindString(ConfigMusicBeatTypeByBeatType.HandleId, 1, p0BeatType, ConfigMusicBeatTypeByBeatType.LogPair) || ConfigCommon.Step(ConfigMusicBeatTypeByBeatType.HandleId, true, ConfigMusicBeatTypeByBeatType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMusicBeatTypeByBeatType.HandleId, ConfigMusicBeatTypeByBeatType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMusicBeatTypeByBeatType.HandleId, 0, ConfigMusicBeatTypeByBeatType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMusicBeatTypeByBeatType.HandleId, ConfigMusicBeatTypeByBeatType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MusicBeatType rootAsMusicBeatType = MusicBeatType.GetRootAsMusicBeatType(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("MusicBeatTypeByBeatType#" + p0BeatType, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMusicBeatTypeByBeatType.HandleId, ConfigMusicBeatTypeByBeatType.LogPair);
			return new MusicBeatType?(rootAsMusicBeatType);
		}

		// Token: 0x040029A0 RID: 10656
		private const string DB = "db_musicbeattype.db";

		// Token: 0x040029A1 RID: 10657
		private const string FILE = "k.可视化编辑/c.Csv/y.音乐节拍配置/*.csv*";

		// Token: 0x040029A2 RID: 10658
		private const string TABLE = "MusicBeatType";

		// Token: 0x040029A3 RID: 10659
		private const string COMMAND = "select BinData from `MusicBeatType` where BeatType=?";

		// Token: 0x040029A4 RID: 10660
		private const string KEY_PREFIX = "MusicBeatTypeByBeatType";

		// Token: 0x040029A5 RID: 10661
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029A6 RID: 10662
		private static int HandleId;
	}
}
