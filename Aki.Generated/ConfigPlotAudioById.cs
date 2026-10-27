using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000749 RID: 1865
	public class ConfigPlotAudioById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BC7 RID: 11207 RVA: 0x00150EF3 File Offset: 0x0014F0F3
		static ConfigPlotAudioById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotAudioById.CreateStaticDefaultValue), new Action(ConfigPlotAudioById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x00150F14 File Offset: 0x0014F114
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

		// Token: 0x06002BC9 RID: 11209 RVA: 0x00150F93 File Offset: 0x0014F193
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotAudioById.LogPair = null;
			ConfigPlotAudioById.HandleId = 0;
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x00150FA1 File Offset: 0x0014F1A1
		public static void Init()
		{
			ConfigPlotAudioById.HandleId = ConfigCommon.InitDataStatement(ConfigPlotAudioById.HandleId, "db_plot_audio.db", "select BinData from `PlotAudio` where Id=?");
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00150FBC File Offset: 0x0014F1BC
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

		// Token: 0x040032E5 RID: 13029
		private const string DB = "db_plot_audio.db";

		// Token: 0x040032E6 RID: 13030
		private const string FILE = "j.剧情语音.xlsx";

		// Token: 0x040032E7 RID: 13031
		private const string TABLE = "PlotAudio";

		// Token: 0x040032E8 RID: 13032
		private const string COMMAND = "select BinData from `PlotAudio` where Id=?";

		// Token: 0x040032E9 RID: 13033
		private const string KEY_PREFIX = "PlotAudioById";

		// Token: 0x040032EA RID: 13034
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032EB RID: 13035
		private static int HandleId;
	}
}
