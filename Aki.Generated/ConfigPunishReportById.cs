using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000783 RID: 1923
	public class ConfigPunishReportById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D23 RID: 11555 RVA: 0x0015BD91 File Offset: 0x00159F91
		static ConfigPunishReportById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPunishReportById.CreateStaticDefaultValue), new Action(ConfigPunishReportById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x0015BDB0 File Offset: 0x00159FB0
		public static void CreateStaticDefaultValue()
		{
			ConfigPunishReportById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPunishReportById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_punishreport.db"),
				new ValueTuple<string, object>("文件", "t.讨伐报告.xlsx"),
				new ValueTuple<string, object>("表名", "PunishReport"),
				new ValueTuple<string, object>("语句", "select BinData from `PunishReport` where Id=?")
			});
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x0015BE2F File Offset: 0x0015A02F
		public static void ResetStaticDefaultValue()
		{
			ConfigPunishReportById.LogPair = null;
			ConfigPunishReportById.HandleId = 0;
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x0015BE3D File Offset: 0x0015A03D
		public static void Init()
		{
			ConfigPunishReportById.HandleId = ConfigCommon.InitDataStatement(ConfigPunishReportById.HandleId, "db_punishreport.db", "select BinData from `PunishReport` where Id=?");
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x0015BE58 File Offset: 0x0015A058
		public static PunishReport? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPunishReportById.HandleId, ConfigPunishReportById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PunishReportById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PunishReport?(PunishReport.GetRootAsPunishReport(configBuffer));
				}
			}
			ConfigPunishReportById.LogPair.Clear();
			ConfigPunishReportById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPunishReportById.HandleId, 1, p0Id, ConfigPunishReportById.LogPair) || ConfigCommon.Step(ConfigPunishReportById.HandleId, true, ConfigPunishReportById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPunishReportById.HandleId, ConfigPunishReportById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPunishReportById.HandleId, 0, ConfigPunishReportById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPunishReportById.HandleId, ConfigPunishReportById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PunishReport rootAsPunishReport = PunishReport.GetRootAsPunishReport(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PunishReportById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPunishReportById.HandleId, ConfigPunishReportById.LogPair);
			return new PunishReport?(rootAsPunishReport);
		}

		// Token: 0x0400347B RID: 13435
		private const string DB = "db_punishreport.db";

		// Token: 0x0400347C RID: 13436
		private const string FILE = "t.讨伐报告.xlsx";

		// Token: 0x0400347D RID: 13437
		private const string TABLE = "PunishReport";

		// Token: 0x0400347E RID: 13438
		private const string COMMAND = "select BinData from `PunishReport` where Id=?";

		// Token: 0x0400347F RID: 13439
		private const string KEY_PREFIX = "PunishReportById";

		// Token: 0x04003480 RID: 13440
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003481 RID: 13441
		private static int HandleId;
	}
}
