using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D2 RID: 2002
	public class ConfigRegressInvestigationAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EFE RID: 12030 RVA: 0x00162DEB File Offset: 0x00160FEB
		static ConfigRegressInvestigationAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressInvestigationAll.CreateStaticDefaultValue), new Action(ConfigRegressInvestigationAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x00162E0C File Offset: 0x0016100C
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

		// Token: 0x06002F00 RID: 12032 RVA: 0x00162E8B File Offset: 0x0016108B
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressInvestigationAll.LogPair = null;
			ConfigRegressInvestigationAll.HandleId = 0;
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x00162E99 File Offset: 0x00161099
		public static void Init()
		{
			ConfigRegressInvestigationAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressInvestigationAll.HandleId, "db_regressactivity.db", "select BinData from `RegressInvestigation`");
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x00162EB4 File Offset: 0x001610B4
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

		// Token: 0x040036A4 RID: 13988
		private const string DB = "db_regressactivity.db";

		// Token: 0x040036A5 RID: 13989
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040036A6 RID: 13990
		private const string TABLE = "RegressInvestigation";

		// Token: 0x040036A7 RID: 13991
		private const string COMMAND = "select BinData from `RegressInvestigation`";

		// Token: 0x040036A8 RID: 13992
		private const string KEY_PREFIX = "RegressInvestigationAll";

		// Token: 0x040036A9 RID: 13993
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036AA RID: 13994
		private static int HandleId;
	}
}
