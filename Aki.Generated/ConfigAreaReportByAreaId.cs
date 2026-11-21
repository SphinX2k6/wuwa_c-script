using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B1 RID: 177
	public class ConfigAreaReportByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000427 RID: 1063 RVA: 0x000749D1 File Offset: 0x00072BD1
		static ConfigAreaReportByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaReportByAreaId.CreateStaticDefaultValue), new Action(ConfigAreaReportByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000749F0 File Offset: 0x00072BF0
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaReportByAreaId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaReportByAreaId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_area.db"),
				new ValueTuple<string, object>("文件", "q.区域.xlsx"),
				new ValueTuple<string, object>("表名", "AreaReport"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaReport` where AreaId=?")
			});
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00074A6F File Offset: 0x00072C6F
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaReportByAreaId.LogPair = null;
			ConfigAreaReportByAreaId.HandleId = 0;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00074A7D File Offset: 0x00072C7D
		public static void Init()
		{
			ConfigAreaReportByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigAreaReportByAreaId.HandleId, "db_area.db", "select BinData from `AreaReport` where AreaId=?");
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00074A98 File Offset: 0x00072C98
		[NullableContext(2)]
		public static IReadOnlyList<AreaReport> GetConfigList(int p0AreaId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaReportByAreaId.HandleId, ConfigAreaReportByAreaId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaReportByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				IReadOnlyList<AreaReport> readOnlyList = (IReadOnlyList<AreaReport>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAreaReportByAreaId.LogPair.Clear();
			ConfigAreaReportByAreaId.LogPair.Add(new ValueTuple<string, object>("AreaId", p0AreaId));
			if (!ConfigCommon.BindInt(ConfigAreaReportByAreaId.HandleId, 1, p0AreaId, ConfigAreaReportByAreaId.LogPair))
			{
				ConfigCommon.Reset(ConfigAreaReportByAreaId.HandleId, ConfigAreaReportByAreaId.LogPair);
				return null;
			}
			List<AreaReport> list = new List<AreaReport>();
			while (ConfigCommon.Step(ConfigAreaReportByAreaId.HandleId, false, ConfigAreaReportByAreaId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaReportByAreaId.HandleId, 0, ConfigAreaReportByAreaId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAreaReportByAreaId.HandleId, ConfigAreaReportByAreaId.LogPair);
					return null;
				}
				AreaReport rootAsAreaReport = AreaReport.GetRootAsAreaReport(new ByteBuffer(item2));
				list.Add(rootAsAreaReport);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaReportByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAreaReportByAreaId.HandleId, ConfigAreaReportByAreaId.LogPair);
			return list;
		}

		// Token: 0x040004BB RID: 1211
		private const string DB = "db_area.db";

		// Token: 0x040004BC RID: 1212
		private const string FILE = "q.区域.xlsx";

		// Token: 0x040004BD RID: 1213
		private const string TABLE = "AreaReport";

		// Token: 0x040004BE RID: 1214
		private const string COMMAND = "select BinData from `AreaReport` where AreaId=?";

		// Token: 0x040004BF RID: 1215
		private const string KEY_PREFIX = "AreaReportByAreaId";

		// Token: 0x040004C0 RID: 1216
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004C1 RID: 1217
		private static int HandleId;
	}
}
