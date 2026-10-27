using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B9 RID: 185
	public class ConfigAudioById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000457 RID: 1111 RVA: 0x000724E0 File Offset: 0x000706E0
		static ConfigAudioById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAudioById.CreateStaticDefaultValue), new Action(ConfigAudioById.ResetStaticDefaultValue));
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00072500 File Offset: 0x00070700
		public static void CreateStaticDefaultValue()
		{
			ConfigAudioById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAudioById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频.xlsx"),
				new ValueTuple<string, object>("表名", "Audio"),
				new ValueTuple<string, object>("语句", "select BinData from `Audio` where Id=?")
			});
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0007257F File Offset: 0x0007077F
		public static void ResetStaticDefaultValue()
		{
			ConfigAudioById.LogPair = null;
			ConfigAudioById.HandleId = 0;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0007258D File Offset: 0x0007078D
		public static void Init()
		{
			ConfigAudioById.HandleId = ConfigCommon.InitDataStatement(ConfigAudioById.HandleId, "db_audio.db", "select BinData from `Audio` where Id=?");
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000725A8 File Offset: 0x000707A8
		public static Audio? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAudioById.HandleId, ConfigAudioById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("AudioById#" + p0Id);
				if (configBuffer != null)
				{
					return new Audio?(Audio.GetRootAsAudio(configBuffer));
				}
			}
			ConfigAudioById.LogPair.Clear();
			ConfigAudioById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigAudioById.HandleId, 1, p0Id, ConfigAudioById.LogPair) || ConfigCommon.Step(ConfigAudioById.HandleId, true, ConfigAudioById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAudioById.HandleId, ConfigAudioById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAudioById.HandleId, 0, ConfigAudioById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAudioById.HandleId, ConfigAudioById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Audio rootAsAudio = Audio.GetRootAsAudio(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("AudioById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAudioById.HandleId, ConfigAudioById.LogPair);
			return new Audio?(rootAsAudio);
		}

		// Token: 0x040004F3 RID: 1267
		private const string DB = "db_audio.db";

		// Token: 0x040004F4 RID: 1268
		private const string FILE = "y.音频.xlsx";

		// Token: 0x040004F5 RID: 1269
		private const string TABLE = "Audio";

		// Token: 0x040004F6 RID: 1270
		private const string COMMAND = "select BinData from `Audio` where Id=?";

		// Token: 0x040004F7 RID: 1271
		private const string KEY_PREFIX = "AudioById";

		// Token: 0x040004F8 RID: 1272
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004F9 RID: 1273
		private static int HandleId;
	}
}
