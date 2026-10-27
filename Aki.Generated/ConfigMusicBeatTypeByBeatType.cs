using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005DE RID: 1502
	public class ConfigMusicBeatTypeByBeatType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002343 RID: 9027 RVA: 0x00120EC8 File Offset: 0x0011F0C8
		static ConfigMusicBeatTypeByBeatType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMusicBeatTypeByBeatType.CreateStaticDefaultValue), new Action(ConfigMusicBeatTypeByBeatType.ResetStaticDefaultValue));
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x00120EE8 File Offset: 0x0011F0E8
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

		// Token: 0x06002345 RID: 9029 RVA: 0x00120F67 File Offset: 0x0011F167
		public static void ResetStaticDefaultValue()
		{
			ConfigMusicBeatTypeByBeatType.LogPair = null;
			ConfigMusicBeatTypeByBeatType.HandleId = 0;
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00120F75 File Offset: 0x0011F175
		public static void Init()
		{
			ConfigMusicBeatTypeByBeatType.HandleId = ConfigCommon.InitDataStatement(ConfigMusicBeatTypeByBeatType.HandleId, "db_musicbeattype.db", "select BinData from `MusicBeatType` where BeatType=?");
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00120F90 File Offset: 0x0011F190
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

		// Token: 0x040028F8 RID: 10488
		private const string DB = "db_musicbeattype.db";

		// Token: 0x040028F9 RID: 10489
		private const string FILE = "k.可视化编辑/c.Csv/y.音乐节拍配置/*.csv*";

		// Token: 0x040028FA RID: 10490
		private const string TABLE = "MusicBeatType";

		// Token: 0x040028FB RID: 10491
		private const string COMMAND = "select BinData from `MusicBeatType` where BeatType=?";

		// Token: 0x040028FC RID: 10492
		private const string KEY_PREFIX = "MusicBeatTypeByBeatType";

		// Token: 0x040028FD RID: 10493
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028FE RID: 10494
		private static int HandleId;
	}
}
