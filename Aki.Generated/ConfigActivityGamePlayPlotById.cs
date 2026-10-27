using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000041 RID: 65
	public class ConfigActivityGamePlayPlotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000186 RID: 390 RVA: 0x00062510 File Offset: 0x00060710
		static ConfigActivityGamePlayPlotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityGamePlayPlotById.CreateStaticDefaultValue), new Action(ConfigActivityGamePlayPlotById.ResetStaticDefaultValue));
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00062530 File Offset: 0x00060730
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

		// Token: 0x06000188 RID: 392 RVA: 0x000625AF File Offset: 0x000607AF
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityGamePlayPlotById.LogPair = null;
			ConfigActivityGamePlayPlotById.HandleId = 0;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000625BD File Offset: 0x000607BD
		public static void Init()
		{
			ConfigActivityGamePlayPlotById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityGamePlayPlotById.HandleId, "db_activitygameplayplot.db", "select BinData from `ActivityGamePlayPlot` where Id=?");
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000625D8 File Offset: 0x000607D8
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

		// Token: 0x040001AB RID: 427
		private const string DB = "db_activitygameplayplot.db";

		// Token: 0x040001AC RID: 428
		private const string FILE = "x.系统玩法对话配置.xlsx";

		// Token: 0x040001AD RID: 429
		private const string TABLE = "ActivityGamePlayPlot";

		// Token: 0x040001AE RID: 430
		private const string COMMAND = "select BinData from `ActivityGamePlayPlot` where Id=?";

		// Token: 0x040001AF RID: 431
		private const string KEY_PREFIX = "ActivityGamePlayPlotById";

		// Token: 0x040001B0 RID: 432
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001B1 RID: 433
		private static int HandleId;
	}
}
