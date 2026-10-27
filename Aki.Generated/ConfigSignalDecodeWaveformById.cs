using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200092B RID: 2347
	public class ConfigSignalDecodeWaveformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003715 RID: 14101 RVA: 0x00190CCC File Offset: 0x0018EECC
		static ConfigSignalDecodeWaveformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSignalDecodeWaveformById.CreateStaticDefaultValue), new Action(ConfigSignalDecodeWaveformById.ResetStaticDefaultValue));
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x00190CEC File Offset: 0x0018EEEC
		public static void CreateStaticDefaultValue()
		{
			ConfigSignalDecodeWaveformById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSignalDecodeWaveformById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_signaldecodewaveform.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/x.信号破译谱面配置/*.csv*"),
				new ValueTuple<string, object>("表名", "SignalDecodeWaveform"),
				new ValueTuple<string, object>("语句", "select BinData from `SignalDecodeWaveform` where Id=?")
			});
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x00190D6B File Offset: 0x0018EF6B
		public static void ResetStaticDefaultValue()
		{
			ConfigSignalDecodeWaveformById.LogPair = null;
			ConfigSignalDecodeWaveformById.HandleId = 0;
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x00190D79 File Offset: 0x0018EF79
		public static void Init()
		{
			ConfigSignalDecodeWaveformById.HandleId = ConfigCommon.InitDataStatement(ConfigSignalDecodeWaveformById.HandleId, "db_signaldecodewaveform.db", "select BinData from `SignalDecodeWaveform` where Id=?");
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x00190D94 File Offset: 0x0018EF94
		public static SignalDecodeWaveform? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSignalDecodeWaveformById.HandleId, ConfigSignalDecodeWaveformById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SignalDecodeWaveformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SignalDecodeWaveform?(SignalDecodeWaveform.GetRootAsSignalDecodeWaveform(configBuffer));
				}
			}
			ConfigSignalDecodeWaveformById.LogPair.Clear();
			ConfigSignalDecodeWaveformById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSignalDecodeWaveformById.HandleId, 1, p0Id, ConfigSignalDecodeWaveformById.LogPair) || ConfigCommon.Step(ConfigSignalDecodeWaveformById.HandleId, true, ConfigSignalDecodeWaveformById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSignalDecodeWaveformById.HandleId, ConfigSignalDecodeWaveformById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSignalDecodeWaveformById.HandleId, 0, ConfigSignalDecodeWaveformById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSignalDecodeWaveformById.HandleId, ConfigSignalDecodeWaveformById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SignalDecodeWaveform rootAsSignalDecodeWaveform = SignalDecodeWaveform.GetRootAsSignalDecodeWaveform(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SignalDecodeWaveformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSignalDecodeWaveformById.HandleId, ConfigSignalDecodeWaveformById.LogPair);
			return new SignalDecodeWaveform?(rootAsSignalDecodeWaveform);
		}

		// Token: 0x04004013 RID: 16403
		private const string DB = "db_signaldecodewaveform.db";

		// Token: 0x04004014 RID: 16404
		private const string FILE = "k.可视化编辑/c.Csv/x.信号破译谱面配置/*.csv*";

		// Token: 0x04004015 RID: 16405
		private const string TABLE = "SignalDecodeWaveform";

		// Token: 0x04004016 RID: 16406
		private const string COMMAND = "select BinData from `SignalDecodeWaveform` where Id=?";

		// Token: 0x04004017 RID: 16407
		private const string KEY_PREFIX = "SignalDecodeWaveformById";

		// Token: 0x04004018 RID: 16408
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004019 RID: 16409
		private static int HandleId;
	}
}
