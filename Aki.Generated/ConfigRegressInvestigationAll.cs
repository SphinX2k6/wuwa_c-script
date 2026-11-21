using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007EE RID: 2030
	public class ConfigRegressInvestigationAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FA6 RID: 12198 RVA: 0x0016A0D3 File Offset: 0x001682D3
		static ConfigRegressInvestigationAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressInvestigationAll.CreateStaticDefaultValue), new Action(ConfigRegressInvestigationAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x0016A0F4 File Offset: 0x001682F4
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressInvestigationAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressInvestigationAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressInvestigation"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressInvestigation`")
			});
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x0016A173 File Offset: 0x00168373
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressInvestigationAll.LogPair = null;
			ConfigRegressInvestigationAll.HandleId = 0;
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x0016A181 File Offset: 0x00168381
		public static void Init()
		{
			ConfigRegressInvestigationAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressInvestigationAll.HandleId, "db_regressactivity.db", "select BinData from `RegressInvestigation`");
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x0016A19C File Offset: 0x0016839C
		[NullableContext(2)]
		public static IReadOnlyList<RegressInvestigation> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressInvestigationAll.HandleId, ConfigRegressInvestigationAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RegressInvestigation> readOnlyList = (IReadOnlyList<RegressInvestigation>)ConfigCommon.GetConfig("RegressInvestigationAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RegressInvestigation> list = new List<RegressInvestigation>();
			while (ConfigCommon.Step(ConfigRegressInvestigationAll.HandleId, false, ConfigRegressInvestigationAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressInvestigationAll.HandleId, 0, ConfigRegressInvestigationAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressInvestigationAll.HandleId, ConfigRegressInvestigationAll.LogPair);
					return null;
				}
				RegressInvestigation rootAsRegressInvestigation = RegressInvestigation.GetRootAsRegressInvestigation(new ByteBuffer(item2));
				list.Add(rootAsRegressInvestigation);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RegressInvestigationAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressInvestigationAll.HandleId, ConfigRegressInvestigationAll.LogPair);
			return list;
		}

		// Token: 0x04003768 RID: 14184
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003769 RID: 14185
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x0400376A RID: 14186
		private const string TABLE = "RegressInvestigation";

		// Token: 0x0400376B RID: 14187
		private const string COMMAND = "select BinData from `RegressInvestigation`";

		// Token: 0x0400376C RID: 14188
		private const string KEY_PREFIX = "RegressInvestigationAll";

		// Token: 0x0400376D RID: 14189
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400376E RID: 14190
		private static int HandleId;
	}
}
