using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000975 RID: 2421
	public class ConfigSignalDecodeTabColorById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038D1 RID: 14545 RVA: 0x0019DCA5 File Offset: 0x0019BEA5
		static ConfigSignalDecodeTabColorById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSignalDecodeTabColorById.CreateStaticDefaultValue), new Action(ConfigSignalDecodeTabColorById.ResetStaticDefaultValue));
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x0019DCC4 File Offset: 0x0019BEC4
		public static void CreateStaticDefaultValue()
		{
			ConfigSignalDecodeTabColorById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSignalDecodeTabColorById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_signaldecodetabcolor.db"),
				new ValueTuple<string, object>("文件", "x.信号破译页签颜色.csv"),
				new ValueTuple<string, object>("表名", "SignalDecodeTabColor"),
				new ValueTuple<string, object>("语句", "select BinData from `SignalDecodeTabColor` where Id=?")
			});
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x0019DD43 File Offset: 0x0019BF43
		public static void ResetStaticDefaultValue()
		{
			ConfigSignalDecodeTabColorById.LogPair = null;
			ConfigSignalDecodeTabColorById.HandleId = 0;
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x0019DD51 File Offset: 0x0019BF51
		public static void Init()
		{
			ConfigSignalDecodeTabColorById.HandleId = ConfigCommon.InitDataStatement(ConfigSignalDecodeTabColorById.HandleId, "db_signaldecodetabcolor.db", "select BinData from `SignalDecodeTabColor` where Id=?");
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x0019DD6C File Offset: 0x0019BF6C
		public static SignalDecodeTabColor? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSignalDecodeTabColorById.HandleId, ConfigSignalDecodeTabColorById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SignalDecodeTabColorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SignalDecodeTabColor?(SignalDecodeTabColor.GetRootAsSignalDecodeTabColor(configBuffer));
				}
			}
			ConfigSignalDecodeTabColorById.LogPair.Clear();
			ConfigSignalDecodeTabColorById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSignalDecodeTabColorById.HandleId, 1, p0Id, ConfigSignalDecodeTabColorById.LogPair) || ConfigCommon.Step(ConfigSignalDecodeTabColorById.HandleId, true, ConfigSignalDecodeTabColorById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSignalDecodeTabColorById.HandleId, ConfigSignalDecodeTabColorById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSignalDecodeTabColorById.HandleId, 0, ConfigSignalDecodeTabColorById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSignalDecodeTabColorById.HandleId, ConfigSignalDecodeTabColorById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SignalDecodeTabColor rootAsSignalDecodeTabColor = SignalDecodeTabColor.GetRootAsSignalDecodeTabColor(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SignalDecodeTabColorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSignalDecodeTabColorById.HandleId, ConfigSignalDecodeTabColorById.LogPair);
			return new SignalDecodeTabColor?(rootAsSignalDecodeTabColor);
		}

		// Token: 0x04004219 RID: 16921
		private const string DB = "db_signaldecodetabcolor.db";

		// Token: 0x0400421A RID: 16922
		private const string FILE = "x.信号破译页签颜色.csv";

		// Token: 0x0400421B RID: 16923
		private const string TABLE = "SignalDecodeTabColor";

		// Token: 0x0400421C RID: 16924
		private const string COMMAND = "select BinData from `SignalDecodeTabColor` where Id=?";

		// Token: 0x0400421D RID: 16925
		private const string KEY_PREFIX = "SignalDecodeTabColorById";

		// Token: 0x0400421E RID: 16926
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400421F RID: 16927
		private static int HandleId;
	}
}
