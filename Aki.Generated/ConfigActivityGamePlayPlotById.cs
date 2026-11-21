using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000049 RID: 73
	public class ConfigActivityGamePlayPlotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x00066DC4 File Offset: 0x00064FC4
		static ConfigActivityGamePlayPlotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityGamePlayPlotById.CreateStaticDefaultValue), new Action(ConfigActivityGamePlayPlotById.ResetStaticDefaultValue));
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00066DE4 File Offset: 0x00064FE4
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityGamePlayPlotById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityGamePlayPlotById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitygameplayplot.db"),
				new ValueTuple<string, object>("文件", "x.系统玩法对话配置.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityGamePlayPlot"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityGamePlayPlot` where Id=?")
			});
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00066E63 File Offset: 0x00065063
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityGamePlayPlotById.LogPair = null;
			ConfigActivityGamePlayPlotById.HandleId = 0;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00066E71 File Offset: 0x00065071
		public static void Init()
		{
			ConfigActivityGamePlayPlotById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityGamePlayPlotById.HandleId, "db_activitygameplayplot.db", "select BinData from `ActivityGamePlayPlot` where Id=?");
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00066E8C File Offset: 0x0006508C
		public static ActivityGamePlayPlot? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityGamePlayPlotById.HandleId, ConfigActivityGamePlayPlotById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityGamePlayPlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityGamePlayPlot?(ActivityGamePlayPlot.GetRootAsActivityGamePlayPlot(configBuffer));
				}
			}
			ConfigActivityGamePlayPlotById.LogPair.Clear();
			ConfigActivityGamePlayPlotById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityGamePlayPlotById.HandleId, 1, p0Id, ConfigActivityGamePlayPlotById.LogPair) || ConfigCommon.Step(ConfigActivityGamePlayPlotById.HandleId, true, ConfigActivityGamePlayPlotById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityGamePlayPlotById.HandleId, ConfigActivityGamePlayPlotById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityGamePlayPlotById.HandleId, 0, ConfigActivityGamePlayPlotById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityGamePlayPlotById.HandleId, ConfigActivityGamePlayPlotById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityGamePlayPlot rootAsActivityGamePlayPlot = ActivityGamePlayPlot.GetRootAsActivityGamePlayPlot(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityGamePlayPlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityGamePlayPlotById.HandleId, ConfigActivityGamePlayPlotById.LogPair);
			return new ActivityGamePlayPlot?(rootAsActivityGamePlayPlot);
		}

		// Token: 0x040001E3 RID: 483
		private const string DB = "db_activitygameplayplot.db";

		// Token: 0x040001E4 RID: 484
		private const string FILE = "x.系统玩法对话配置.xlsx";

		// Token: 0x040001E5 RID: 485
		private const string TABLE = "ActivityGamePlayPlot";

		// Token: 0x040001E6 RID: 486
		private const string COMMAND = "select BinData from `ActivityGamePlayPlot` where Id=?";

		// Token: 0x040001E7 RID: 487
		private const string KEY_PREFIX = "ActivityGamePlayPlotById";

		// Token: 0x040001E8 RID: 488
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001E9 RID: 489
		private static int HandleId;
	}
}
