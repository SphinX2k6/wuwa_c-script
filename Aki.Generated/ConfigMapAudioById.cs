using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200050A RID: 1290
	public class ConfigMapAudioById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E47 RID: 7751 RVA: 0x001044D4 File Offset: 0x001026D4
		static ConfigMapAudioById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapAudioById.CreateStaticDefaultValue), new Action(ConfigMapAudioById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x001044F4 File Offset: 0x001026F4
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

		// Token: 0x06001E49 RID: 7753 RVA: 0x00104573 File Offset: 0x00102773
		public static void ResetStaticDefaultValue()
		{
			ConfigMapAudioById.LogPair = null;
			ConfigMapAudioById.HandleId = 0;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00104581 File Offset: 0x00102781
		public static void Init()
		{
			ConfigMapAudioById.HandleId = ConfigCommon.InitDataStatement(ConfigMapAudioById.HandleId, "db_audio.db", "select BinData from `MapAudio` where Id=?");
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x0010459C File Offset: 0x0010279C
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

		// Token: 0x0400232A RID: 9002
		private const string DB = "db_audio.db";

		// Token: 0x0400232B RID: 9003
		private const string FILE = "y.音频.xlsx";

		// Token: 0x0400232C RID: 9004
		private const string TABLE = "MapAudio";

		// Token: 0x0400232D RID: 9005
		private const string COMMAND = "select BinData from `MapAudio` where Id=?";

		// Token: 0x0400232E RID: 9006
		private const string KEY_PREFIX = "MapAudioById";

		// Token: 0x0400232F RID: 9007
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002330 RID: 9008
		private static int HandleId;
	}
}
