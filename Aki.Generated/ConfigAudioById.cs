using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C1 RID: 193
	public class ConfigAudioById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000487 RID: 1159 RVA: 0x00076D94 File Offset: 0x00074F94
		static ConfigAudioById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAudioById.CreateStaticDefaultValue), new Action(ConfigAudioById.ResetStaticDefaultValue));
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00076DB4 File Offset: 0x00074FB4
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

		// Token: 0x06000489 RID: 1161 RVA: 0x00076E33 File Offset: 0x00075033
		public static void ResetStaticDefaultValue()
		{
			ConfigAudioById.LogPair = null;
			ConfigAudioById.HandleId = 0;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00076E41 File Offset: 0x00075041
		public static void Init()
		{
			ConfigAudioById.HandleId = ConfigCommon.InitDataStatement(ConfigAudioById.HandleId, "db_audio.db", "select BinData from `Audio` where Id=?");
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00076E5C File Offset: 0x0007505C
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

		// Token: 0x0400052B RID: 1323
		private const string DB = "db_audio.db";

		// Token: 0x0400052C RID: 1324
		private const string FILE = "y.音频.xlsx";

		// Token: 0x0400052D RID: 1325
		private const string TABLE = "Audio";

		// Token: 0x0400052E RID: 1326
		private const string COMMAND = "select BinData from `Audio` where Id=?";

		// Token: 0x0400052F RID: 1327
		private const string KEY_PREFIX = "AudioById";

		// Token: 0x04000530 RID: 1328
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000531 RID: 1329
		private static int HandleId;
	}
}
