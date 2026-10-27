using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E2 RID: 2018
	public class ConfigReportPlayerInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F5E RID: 12126 RVA: 0x00164F54 File Offset: 0x00163154
		static ConfigReportPlayerInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigReportPlayerInfoAll.CreateStaticDefaultValue), new Action(ConfigReportPlayerInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x00164F74 File Offset: 0x00163174
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

		// Token: 0x06002F60 RID: 12128 RVA: 0x00164FF3 File Offset: 0x001631F3
		public static void ResetStaticDefaultValue()
		{
			ConfigReportPlayerInfoAll.LogPair = null;
			ConfigReportPlayerInfoAll.HandleId = 0;
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x00165001 File Offset: 0x00163201
		public static void Init()
		{
			ConfigReportPlayerInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigReportPlayerInfoAll.HandleId, "db_report.db", "select BinData from `ReportPlayerInfo`");
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x0016501C File Offset: 0x0016321C
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

		// Token: 0x04003714 RID: 14100
		private const string DB = "db_report.db";

		// Token: 0x04003715 RID: 14101
		private const string FILE = "f.封禁处罚.xlsx";

		// Token: 0x04003716 RID: 14102
		private const string TABLE = "ReportPlayerInfo";

		// Token: 0x04003717 RID: 14103
		private const string COMMAND = "select BinData from `ReportPlayerInfo`";

		// Token: 0x04003718 RID: 14104
		private const string KEY_PREFIX = "ReportPlayerInfoAll";

		// Token: 0x04003719 RID: 14105
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400371A RID: 14106
		private static int HandleId;
	}
}
