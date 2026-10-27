using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000849 RID: 2121
	public class ConfigRogueResEventPlotByPlotId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031C8 RID: 12744 RVA: 0x00172ED9 File Offset: 0x001710D9
		static ConfigRogueResEventPlotByPlotId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEventPlotByPlotId.CreateStaticDefaultValue), new Action(ConfigRogueResEventPlotByPlotId.ResetStaticDefaultValue));
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x00172EF8 File Offset: 0x001710F8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEventPlotByPlotId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEventPlotByPlotId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEventPlot"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEventPlot` where PlotId=?")
			});
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x00172F77 File Offset: 0x00171177
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEventPlotByPlotId.LogPair = null;
			ConfigRogueResEventPlotByPlotId.HandleId = 0;
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x00172F85 File Offset: 0x00171185
		public static void Init()
		{
			ConfigRogueResEventPlotByPlotId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEventPlotByPlotId.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEventPlot` where PlotId=?");
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x00172FA0 File Offset: 0x001711A0
		public static RogueResEventPlot? GetConfig(int p0PlotId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEventPlotByPlotId.HandleId, ConfigRogueResEventPlotByPlotId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventPlotByPlotId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PlotId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEventPlot?(RogueResEventPlot.GetRootAsRogueResEventPlot(configBuffer));
				}
			}
			ConfigRogueResEventPlotByPlotId.LogPair.Clear();
			ConfigRogueResEventPlotByPlotId.LogPair.Add(new ValueTuple<string, object>("PlotId", p0PlotId));
			if (!ConfigCommon.BindInt(ConfigRogueResEventPlotByPlotId.HandleId, 1, p0PlotId, ConfigRogueResEventPlotByPlotId.LogPair) || ConfigCommon.Step(ConfigRogueResEventPlotByPlotId.HandleId, true, ConfigRogueResEventPlotByPlotId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEventPlotByPlotId.HandleId, ConfigRogueResEventPlotByPlotId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEventPlotByPlotId.HandleId, 0, ConfigRogueResEventPlotByPlotId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEventPlotByPlotId.HandleId, ConfigRogueResEventPlotByPlotId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEventPlot rootAsRogueResEventPlot = RogueResEventPlot.GetRootAsRogueResEventPlot(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventPlotByPlotId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PlotId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEventPlotByPlotId.HandleId, ConfigRogueResEventPlotByPlotId.LogPair);
			return new RogueResEventPlot?(rootAsRogueResEventPlot);
		}

		// Token: 0x040039E5 RID: 14821
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039E6 RID: 14822
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039E7 RID: 14823
		private const string TABLE = "RogueResEventPlot";

		// Token: 0x040039E8 RID: 14824
		private const string COMMAND = "select BinData from `RogueResEventPlot` where PlotId=?";

		// Token: 0x040039E9 RID: 14825
		private const string KEY_PREFIX = "RogueResEventPlotByPlotId";

		// Token: 0x040039EA RID: 14826
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039EB RID: 14827
		private static int HandleId;
	}
}
