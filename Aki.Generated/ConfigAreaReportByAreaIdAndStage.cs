using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000AA RID: 170
	public class ConfigAreaReportByAreaIdAndStage : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x00070353 File Offset: 0x0006E553
		static ConfigAreaReportByAreaIdAndStage()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaReportByAreaIdAndStage.CreateStaticDefaultValue), new Action(ConfigAreaReportByAreaIdAndStage.ResetStaticDefaultValue));
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00070374 File Offset: 0x0006E574
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaReportByAreaIdAndStage.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaReportByAreaIdAndStage.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_area.db"),
				new ValueTuple<string, object>("文件", "q.区域.xlsx"),
				new ValueTuple<string, object>("表名", "AreaReport"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaReport` where AreaId=? AND Stage=?")
			});
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000703F3 File Offset: 0x0006E5F3
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaReportByAreaIdAndStage.LogPair = null;
			ConfigAreaReportByAreaIdAndStage.HandleId = 0;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00070401 File Offset: 0x0006E601
		public static void Init()
		{
			ConfigAreaReportByAreaIdAndStage.HandleId = ConfigCommon.InitDataStatement(ConfigAreaReportByAreaIdAndStage.HandleId, "db_area.db", "select BinData from `AreaReport` where AreaId=? AND Stage=?");
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0007041C File Offset: 0x0006E61C
		public static AreaReport? GetConfig(int p0AreaId, int p1Stage, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaReportByAreaIdAndStage.HandleId, ConfigAreaReportByAreaIdAndStage.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("AreaReportByAreaIdAndStage");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Stage);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AreaReport?(AreaReport.GetRootAsAreaReport(configBuffer));
				}
			}
			ConfigAreaReportByAreaIdAndStage.LogPair.Clear();
			ConfigAreaReportByAreaIdAndStage.LogPair.Add(new ValueTuple<string, object>("AreaId", p0AreaId));
			ConfigAreaReportByAreaIdAndStage.LogPair.Add(new ValueTuple<string, object>("Stage", p1Stage));
			if (!ConfigCommon.BindInt(ConfigAreaReportByAreaIdAndStage.HandleId, 1, p0AreaId, ConfigAreaReportByAreaIdAndStage.LogPair) || !ConfigCommon.BindInt(ConfigAreaReportByAreaIdAndStage.HandleId, 2, p1Stage, ConfigAreaReportByAreaIdAndStage.LogPair) || ConfigCommon.Step(ConfigAreaReportByAreaIdAndStage.HandleId, true, ConfigAreaReportByAreaIdAndStage.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAreaReportByAreaIdAndStage.HandleId, ConfigAreaReportByAreaIdAndStage.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaReportByAreaIdAndStage.HandleId, 0, ConfigAreaReportByAreaIdAndStage.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAreaReportByAreaIdAndStage.HandleId, ConfigAreaReportByAreaIdAndStage.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AreaReport rootAsAreaReport = AreaReport.GetRootAsAreaReport(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("AreaReportByAreaIdAndStage");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Stage);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAreaReportByAreaIdAndStage.HandleId, ConfigAreaReportByAreaIdAndStage.LogPair);
			return new AreaReport?(rootAsAreaReport);
		}

		// Token: 0x0400048A RID: 1162
		private const string DB = "db_area.db";

		// Token: 0x0400048B RID: 1163
		private const string FILE = "q.区域.xlsx";

		// Token: 0x0400048C RID: 1164
		private const string TABLE = "AreaReport";

		// Token: 0x0400048D RID: 1165
		private const string COMMAND = "select BinData from `AreaReport` where AreaId=? AND Stage=?";

		// Token: 0x0400048E RID: 1166
		private const string KEY_PREFIX = "AreaReportByAreaIdAndStage";

		// Token: 0x0400048F RID: 1167
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000490 RID: 1168
		private static int HandleId;
	}
}
