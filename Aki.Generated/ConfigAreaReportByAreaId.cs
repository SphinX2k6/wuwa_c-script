using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A9 RID: 169
	public class ConfigAreaReportByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x0007011D File Offset: 0x0006E31D
		static ConfigAreaReportByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaReportByAreaId.CreateStaticDefaultValue), new Action(ConfigAreaReportByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0007013C File Offset: 0x0006E33C
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

		// Token: 0x060003F9 RID: 1017 RVA: 0x000701BB File Offset: 0x0006E3BB
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaReportByAreaId.LogPair = null;
			ConfigAreaReportByAreaId.HandleId = 0;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000701C9 File Offset: 0x0006E3C9
		public static void Init()
		{
			ConfigAreaReportByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigAreaReportByAreaId.HandleId, "db_area.db", "select BinData from `AreaReport` where AreaId=?");
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000701E4 File Offset: 0x0006E3E4
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

		// Token: 0x04000483 RID: 1155
		private const string DB = "db_area.db";

		// Token: 0x04000484 RID: 1156
		private const string FILE = "q.区域.xlsx";

		// Token: 0x04000485 RID: 1157
		private const string TABLE = "AreaReport";

		// Token: 0x04000486 RID: 1158
		private const string COMMAND = "select BinData from `AreaReport` where AreaId=?";

		// Token: 0x04000487 RID: 1159
		private const string KEY_PREFIX = "AreaReportByAreaId";

		// Token: 0x04000488 RID: 1160
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000489 RID: 1161
		private static int HandleId;
	}
}
