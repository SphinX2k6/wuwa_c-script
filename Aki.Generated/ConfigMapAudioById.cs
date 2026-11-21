using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000520 RID: 1312
	public class ConfigMapAudioById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001ECB RID: 7883 RVA: 0x0010AC28 File Offset: 0x00108E28
		static ConfigMapAudioById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapAudioById.CreateStaticDefaultValue), new Action(ConfigMapAudioById.ResetStaticDefaultValue));
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0010AC48 File Offset: 0x00108E48
		public static void CreateStaticDefaultValue()
		{
			ConfigMapAudioById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapAudioById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频.xlsx"),
				new ValueTuple<string, object>("表名", "MapAudio"),
				new ValueTuple<string, object>("语句", "select BinData from `MapAudio` where Id=?")
			});
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x0010ACC7 File Offset: 0x00108EC7
		public static void ResetStaticDefaultValue()
		{
			ConfigMapAudioById.LogPair = null;
			ConfigMapAudioById.HandleId = 0;
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x0010ACD5 File Offset: 0x00108ED5
		public static void Init()
		{
			ConfigMapAudioById.HandleId = ConfigCommon.InitDataStatement(ConfigMapAudioById.HandleId, "db_audio.db", "select BinData from `MapAudio` where Id=?");
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x0010ACF0 File Offset: 0x00108EF0
		public static MapAudio? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapAudioById.HandleId, ConfigMapAudioById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapAudioById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapAudio?(MapAudio.GetRootAsMapAudio(configBuffer));
				}
			}
			ConfigMapAudioById.LogPair.Clear();
			ConfigMapAudioById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMapAudioById.HandleId, 1, p0Id, ConfigMapAudioById.LogPair) || ConfigCommon.Step(ConfigMapAudioById.HandleId, false, ConfigMapAudioById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapAudioById.HandleId, ConfigMapAudioById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapAudioById.HandleId, 0, ConfigMapAudioById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapAudioById.HandleId, ConfigMapAudioById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapAudio rootAsMapAudio = MapAudio.GetRootAsMapAudio(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapAudioById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapAudioById.HandleId, ConfigMapAudioById.LogPair);
			return new MapAudio?(rootAsMapAudio);
		}

		// Token: 0x040023C4 RID: 9156
		private const string DB = "db_audio.db";

		// Token: 0x040023C5 RID: 9157
		private const string FILE = "y.音频.xlsx";

		// Token: 0x040023C6 RID: 9158
		private const string TABLE = "MapAudio";

		// Token: 0x040023C7 RID: 9159
		private const string COMMAND = "select BinData from `MapAudio` where Id=?";

		// Token: 0x040023C8 RID: 9160
		private const string KEY_PREFIX = "MapAudioById";

		// Token: 0x040023C9 RID: 9161
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023CA RID: 9162
		private static int HandleId;
	}
}
