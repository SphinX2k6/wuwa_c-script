using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C8 RID: 1992
	public class ConfigRandomPlotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EC2 RID: 11970 RVA: 0x001651C7 File Offset: 0x001633C7
		static ConfigRandomPlotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRandomPlotById.CreateStaticDefaultValue), new Action(ConfigRandomPlotById.ResetStaticDefaultValue));
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x001651E8 File Offset: 0x001633E8
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

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00165267 File Offset: 0x00163467
		public static void ResetStaticDefaultValue()
		{
			ConfigRandomPlotById.LogPair = null;
			ConfigRandomPlotById.HandleId = 0;
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00165275 File Offset: 0x00163475
		public static void Init()
		{
			ConfigRandomPlotById.HandleId = ConfigCommon.InitDataStatement(ConfigRandomPlotById.HandleId, "db_randomplot.db", "select BinData from `RandomPlot` where Id=?");
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00165290 File Offset: 0x00163490
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

		// Token: 0x0400365E RID: 13918
		private const string DB = "db_randomplot.db";

		// Token: 0x0400365F RID: 13919
		private const string FILE = "x.系统随机剧情.xlsx";

		// Token: 0x04003660 RID: 13920
		private const string TABLE = "RandomPlot";

		// Token: 0x04003661 RID: 13921
		private const string COMMAND = "select BinData from `RandomPlot` where Id=?";

		// Token: 0x04003662 RID: 13922
		private const string KEY_PREFIX = "RandomPlotById";

		// Token: 0x04003663 RID: 13923
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003664 RID: 13924
		private static int HandleId;
	}
}
