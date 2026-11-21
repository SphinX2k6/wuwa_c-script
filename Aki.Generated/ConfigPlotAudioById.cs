using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000761 RID: 1889
	public class ConfigPlotAudioById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C57 RID: 11351 RVA: 0x0015796F File Offset: 0x00155B6F
		static ConfigPlotAudioById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotAudioById.CreateStaticDefaultValue), new Action(ConfigPlotAudioById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x00157990 File Offset: 0x00155B90
		public static void CreateStaticDefaultValue()
		{
			ConfigPlotAudioById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlotAudioById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_plot_audio.db"),
				new ValueTuple<string, object>("文件", "j.剧情语音.xlsx"),
				new ValueTuple<string, object>("表名", "PlotAudio"),
				new ValueTuple<string, object>("语句", "select BinData from `PlotAudio` where Id=?")
			});
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x00157A0F File Offset: 0x00155C0F
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotAudioById.LogPair = null;
			ConfigPlotAudioById.HandleId = 0;
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x00157A1D File Offset: 0x00155C1D
		public static void Init()
		{
			ConfigPlotAudioById.HandleId = ConfigCommon.InitDataStatement(ConfigPlotAudioById.HandleId, "db_plot_audio.db", "select BinData from `PlotAudio` where Id=?");
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x00157A38 File Offset: 0x00155C38
		public static PlotAudio? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlotAudioById.HandleId, ConfigPlotAudioById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("PlotAudioById#" + p0Id);
				if (configBuffer != null)
				{
					return new PlotAudio?(PlotAudio.GetRootAsPlotAudio(configBuffer));
				}
			}
			ConfigPlotAudioById.LogPair.Clear();
			ConfigPlotAudioById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigPlotAudioById.HandleId, 1, p0Id, ConfigPlotAudioById.LogPair) || ConfigCommon.Step(ConfigPlotAudioById.HandleId, true, ConfigPlotAudioById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPlotAudioById.HandleId, ConfigPlotAudioById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlotAudioById.HandleId, 0, ConfigPlotAudioById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPlotAudioById.HandleId, ConfigPlotAudioById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PlotAudio rootAsPlotAudio = PlotAudio.GetRootAsPlotAudio(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("PlotAudioById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPlotAudioById.HandleId, ConfigPlotAudioById.LogPair);
			return new PlotAudio?(rootAsPlotAudio);
		}

		// Token: 0x0400338D RID: 13197
		private const string DB = "db_plot_audio.db";

		// Token: 0x0400338E RID: 13198
		private const string FILE = "j.剧情语音.xlsx";

		// Token: 0x0400338F RID: 13199
		private const string TABLE = "PlotAudio";

		// Token: 0x04003390 RID: 13200
		private const string COMMAND = "select BinData from `PlotAudio` where Id=?";

		// Token: 0x04003391 RID: 13201
		private const string KEY_PREFIX = "PlotAudioById";

		// Token: 0x04003392 RID: 13202
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003393 RID: 13203
		private static int HandleId;
	}
}
