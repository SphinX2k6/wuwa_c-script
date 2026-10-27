using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007AE RID: 1966
	public class ConfigRandomPlotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E26 RID: 11814 RVA: 0x0015E2BB File Offset: 0x0015C4BB
		static ConfigRandomPlotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRandomPlotById.CreateStaticDefaultValue), new Action(ConfigRandomPlotById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x0015E2DC File Offset: 0x0015C4DC
		public static void CreateStaticDefaultValue()
		{
			ConfigRandomPlotById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRandomPlotById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_randomplot.db"),
				new ValueTuple<string, object>("文件", "x.系统随机剧情.xlsx"),
				new ValueTuple<string, object>("表名", "RandomPlot"),
				new ValueTuple<string, object>("语句", "select BinData from `RandomPlot` where Id=?")
			});
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x0015E35B File Offset: 0x0015C55B
		public static void ResetStaticDefaultValue()
		{
			ConfigRandomPlotById.LogPair = null;
			ConfigRandomPlotById.HandleId = 0;
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x0015E369 File Offset: 0x0015C569
		public static void Init()
		{
			ConfigRandomPlotById.HandleId = ConfigCommon.InitDataStatement(ConfigRandomPlotById.HandleId, "db_randomplot.db", "select BinData from `RandomPlot` where Id=?");
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x0015E384 File Offset: 0x0015C584
		public static RandomPlot? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRandomPlotById.HandleId, ConfigRandomPlotById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RandomPlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RandomPlot?(RandomPlot.GetRootAsRandomPlot(configBuffer));
				}
			}
			ConfigRandomPlotById.LogPair.Clear();
			ConfigRandomPlotById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRandomPlotById.HandleId, 1, p0Id, ConfigRandomPlotById.LogPair) || ConfigCommon.Step(ConfigRandomPlotById.HandleId, true, ConfigRandomPlotById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRandomPlotById.HandleId, ConfigRandomPlotById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRandomPlotById.HandleId, 0, ConfigRandomPlotById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRandomPlotById.HandleId, ConfigRandomPlotById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RandomPlot rootAsRandomPlot = RandomPlot.GetRootAsRandomPlot(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RandomPlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRandomPlotById.HandleId, ConfigRandomPlotById.LogPair);
			return new RandomPlot?(rootAsRandomPlot);
		}

		// Token: 0x040035A8 RID: 13736
		private const string DB = "db_randomplot.db";

		// Token: 0x040035A9 RID: 13737
		private const string FILE = "x.系统随机剧情.xlsx";

		// Token: 0x040035AA RID: 13738
		private const string TABLE = "RandomPlot";

		// Token: 0x040035AB RID: 13739
		private const string COMMAND = "select BinData from `RandomPlot` where Id=?";

		// Token: 0x040035AC RID: 13740
		private const string KEY_PREFIX = "RandomPlotById";

		// Token: 0x040035AD RID: 13741
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035AE RID: 13742
		private static int HandleId;
	}
}
