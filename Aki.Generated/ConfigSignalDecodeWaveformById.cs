using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000976 RID: 2422
	public class ConfigSignalDecodeWaveformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038D7 RID: 14551 RVA: 0x0019DEEC File Offset: 0x0019C0EC
		static ConfigSignalDecodeWaveformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSignalDecodeWaveformById.CreateStaticDefaultValue), new Action(ConfigSignalDecodeWaveformById.ResetStaticDefaultValue));
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x0019DF0C File Offset: 0x0019C10C
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

		// Token: 0x060038D9 RID: 14553 RVA: 0x0019DF8B File Offset: 0x0019C18B
		public static void ResetStaticDefaultValue()
		{
			ConfigSignalDecodeWaveformById.LogPair = null;
			ConfigSignalDecodeWaveformById.HandleId = 0;
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x0019DF99 File Offset: 0x0019C199
		public static void Init()
		{
			ConfigSignalDecodeWaveformById.HandleId = ConfigCommon.InitDataStatement(ConfigSignalDecodeWaveformById.HandleId, "db_signaldecodewaveform.db", "select BinData from `SignalDecodeWaveform` where Id=?");
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x0019DFB4 File Offset: 0x0019C1B4
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

		// Token: 0x04004220 RID: 16928
		private const string DB = "db_signaldecodewaveform.db";

		// Token: 0x04004221 RID: 16929
		private const string FILE = "k.可视化编辑/c.Csv/x.信号破译谱面配置/*.csv*";

		// Token: 0x04004222 RID: 16930
		private const string TABLE = "SignalDecodeWaveform";

		// Token: 0x04004223 RID: 16931
		private const string COMMAND = "select BinData from `SignalDecodeWaveform` where Id=?";

		// Token: 0x04004224 RID: 16932
		private const string KEY_PREFIX = "SignalDecodeWaveformById";

		// Token: 0x04004225 RID: 16933
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004226 RID: 16934
		private static int HandleId;
	}
}
