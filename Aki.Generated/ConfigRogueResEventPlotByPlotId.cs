using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000865 RID: 2149
	public class ConfigRogueResEventPlotByPlotId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003270 RID: 12912 RVA: 0x0017A1C1 File Offset: 0x001783C1
		static ConfigRogueResEventPlotByPlotId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEventPlotByPlotId.CreateStaticDefaultValue), new Action(ConfigRogueResEventPlotByPlotId.ResetStaticDefaultValue));
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x0017A1E0 File Offset: 0x001783E0
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

		// Token: 0x06003272 RID: 12914 RVA: 0x0017A25F File Offset: 0x0017845F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEventPlotByPlotId.LogPair = null;
			ConfigRogueResEventPlotByPlotId.HandleId = 0;
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x0017A26D File Offset: 0x0017846D
		public static void Init()
		{
			ConfigRogueResEventPlotByPlotId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEventPlotByPlotId.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEventPlot` where PlotId=?");
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x0017A288 File Offset: 0x00178488
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

		// Token: 0x04003AA9 RID: 15017
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003AAA RID: 15018
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003AAB RID: 15019
		private const string TABLE = "RogueResEventPlot";

		// Token: 0x04003AAC RID: 15020
		private const string COMMAND = "select BinData from `RogueResEventPlot` where PlotId=?";

		// Token: 0x04003AAD RID: 15021
		private const string KEY_PREFIX = "RogueResEventPlotByPlotId";

		// Token: 0x04003AAE RID: 15022
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AAF RID: 15023
		private static int HandleId;
	}
}
