using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B2 RID: 178
	public class ConfigAreaReportByAreaIdAndStage : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600042D RID: 1069 RVA: 0x00074C07 File Offset: 0x00072E07
		static ConfigAreaReportByAreaIdAndStage()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaReportByAreaIdAndStage.CreateStaticDefaultValue), new Action(ConfigAreaReportByAreaIdAndStage.ResetStaticDefaultValue));
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00074C28 File Offset: 0x00072E28
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

		// Token: 0x0600042F RID: 1071 RVA: 0x00074CA7 File Offset: 0x00072EA7
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaReportByAreaIdAndStage.LogPair = null;
			ConfigAreaReportByAreaIdAndStage.HandleId = 0;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00074CB5 File Offset: 0x00072EB5
		public static void Init()
		{
			ConfigAreaReportByAreaIdAndStage.HandleId = ConfigCommon.InitDataStatement(ConfigAreaReportByAreaIdAndStage.HandleId, "db_area.db", "select BinData from `AreaReport` where AreaId=? AND Stage=?");
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00074CD0 File Offset: 0x00072ED0
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

		// Token: 0x040004C2 RID: 1218
		private const string DB = "db_area.db";

		// Token: 0x040004C3 RID: 1219
		private const string FILE = "q.区域.xlsx";

		// Token: 0x040004C4 RID: 1220
		private const string TABLE = "AreaReport";

		// Token: 0x040004C5 RID: 1221
		private const string COMMAND = "select BinData from `AreaReport` where AreaId=? AND Stage=?";

		// Token: 0x040004C6 RID: 1222
		private const string KEY_PREFIX = "AreaReportByAreaIdAndStage";

		// Token: 0x040004C7 RID: 1223
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004C8 RID: 1224
		private static int HandleId;
	}
}
