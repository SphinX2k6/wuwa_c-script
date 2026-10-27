using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000769 RID: 1897
	public class ConfigPunishReportById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C87 RID: 11399 RVA: 0x00154E85 File Offset: 0x00153085
		static ConfigPunishReportById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPunishReportById.CreateStaticDefaultValue), new Action(ConfigPunishReportById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x00154EA4 File Offset: 0x001530A4
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

		// Token: 0x06002C89 RID: 11401 RVA: 0x00154F23 File Offset: 0x00153123
		public static void ResetStaticDefaultValue()
		{
			ConfigPunishReportById.LogPair = null;
			ConfigPunishReportById.HandleId = 0;
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x00154F31 File Offset: 0x00153131
		public static void Init()
		{
			ConfigPunishReportById.HandleId = ConfigCommon.InitDataStatement(ConfigPunishReportById.HandleId, "db_punishreport.db", "select BinData from `PunishReport` where Id=?");
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x00154F4C File Offset: 0x0015314C
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

		// Token: 0x040033C5 RID: 13253
		private const string DB = "db_punishreport.db";

		// Token: 0x040033C6 RID: 13254
		private const string FILE = "t.讨伐报告.xlsx";

		// Token: 0x040033C7 RID: 13255
		private const string TABLE = "PunishReport";

		// Token: 0x040033C8 RID: 13256
		private const string COMMAND = "select BinData from `PunishReport` where Id=?";

		// Token: 0x040033C9 RID: 13257
		private const string KEY_PREFIX = "PunishReportById";

		// Token: 0x040033CA RID: 13258
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033CB RID: 13259
		private static int HandleId;
	}
}
