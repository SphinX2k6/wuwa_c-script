using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007FE RID: 2046
	public class ConfigReportPlayerInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003006 RID: 12294 RVA: 0x0016C23C File Offset: 0x0016A43C
		static ConfigReportPlayerInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigReportPlayerInfoAll.CreateStaticDefaultValue), new Action(ConfigReportPlayerInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x0016C25C File Offset: 0x0016A45C
		public static void CreateStaticDefaultValue()
		{
			ConfigReportPlayerInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigReportPlayerInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_report.db"),
				new ValueTuple<string, object>("文件", "f.封禁处罚.xlsx"),
				new ValueTuple<string, object>("表名", "ReportPlayerInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `ReportPlayerInfo`")
			});
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x0016C2DB File Offset: 0x0016A4DB
		public static void ResetStaticDefaultValue()
		{
			ConfigReportPlayerInfoAll.LogPair = null;
			ConfigReportPlayerInfoAll.HandleId = 0;
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x0016C2E9 File Offset: 0x0016A4E9
		public static void Init()
		{
			ConfigReportPlayerInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigReportPlayerInfoAll.HandleId, "db_report.db", "select BinData from `ReportPlayerInfo`");
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x0016C304 File Offset: 0x0016A504
		[NullableContext(2)]
		public static IReadOnlyList<ReportPlayerInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigReportPlayerInfoAll.HandleId, ConfigReportPlayerInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ReportPlayerInfo> readOnlyList = (IReadOnlyList<ReportPlayerInfo>)ConfigCommon.GetConfig("ReportPlayerInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ReportPlayerInfo> list = new List<ReportPlayerInfo>();
			while (ConfigCommon.Step(ConfigReportPlayerInfoAll.HandleId, false, ConfigReportPlayerInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigReportPlayerInfoAll.HandleId, 0, ConfigReportPlayerInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigReportPlayerInfoAll.HandleId, ConfigReportPlayerInfoAll.LogPair);
					return null;
				}
				ReportPlayerInfo rootAsReportPlayerInfo = ReportPlayerInfo.GetRootAsReportPlayerInfo(new ByteBuffer(item2));
				list.Add(rootAsReportPlayerInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ReportPlayerInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigReportPlayerInfoAll.HandleId, ConfigReportPlayerInfoAll.LogPair);
			return list;
		}

		// Token: 0x040037D8 RID: 14296
		private const string DB = "db_report.db";

		// Token: 0x040037D9 RID: 14297
		private const string FILE = "f.封禁处罚.xlsx";

		// Token: 0x040037DA RID: 14298
		private const string TABLE = "ReportPlayerInfo";

		// Token: 0x040037DB RID: 14299
		private const string COMMAND = "select BinData from `ReportPlayerInfo`";

		// Token: 0x040037DC RID: 14300
		private const string KEY_PREFIX = "ReportPlayerInfoAll";

		// Token: 0x040037DD RID: 14301
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037DE RID: 14302
		private static int HandleId;
	}
}
