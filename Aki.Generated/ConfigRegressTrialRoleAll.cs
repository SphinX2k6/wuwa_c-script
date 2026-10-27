using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007DD RID: 2013
	public class ConfigRegressTrialRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F40 RID: 12096 RVA: 0x001644AF File Offset: 0x001626AF
		static ConfigRegressTrialRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressTrialRoleAll.CreateStaticDefaultValue), new Action(ConfigRegressTrialRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x001644D0 File Offset: 0x001626D0
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressTrialRoleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressTrialRoleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressTrialRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressTrialRole`")
			});
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x0016454F File Offset: 0x0016274F
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressTrialRoleAll.LogPair = null;
			ConfigRegressTrialRoleAll.HandleId = 0;
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x0016455D File Offset: 0x0016275D
		public static void Init()
		{
			ConfigRegressTrialRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressTrialRoleAll.HandleId, "db_regressactivity.db", "select BinData from `RegressTrialRole`");
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x00164578 File Offset: 0x00162778
		[NullableContext(2)]
		public static IReadOnlyList<RegressTrialRole> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressTrialRoleAll.HandleId, ConfigRegressTrialRoleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RegressTrialRole> readOnlyList = (IReadOnlyList<RegressTrialRole>)ConfigCommon.GetConfig("RegressTrialRoleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RegressTrialRole> list = new List<RegressTrialRole>();
			while (ConfigCommon.Step(ConfigRegressTrialRoleAll.HandleId, false, ConfigRegressTrialRoleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressTrialRoleAll.HandleId, 0, ConfigRegressTrialRoleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressTrialRoleAll.HandleId, ConfigRegressTrialRoleAll.LogPair);
					return null;
				}
				RegressTrialRole rootAsRegressTrialRole = RegressTrialRole.GetRootAsRegressTrialRole(new ByteBuffer(item2));
				list.Add(rootAsRegressTrialRole);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RegressTrialRoleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressTrialRoleAll.HandleId, ConfigRegressTrialRoleAll.LogPair);
			return list;
		}

		// Token: 0x040036F1 RID: 14065
		private const string DB = "db_regressactivity.db";

		// Token: 0x040036F2 RID: 14066
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040036F3 RID: 14067
		private const string TABLE = "RegressTrialRole";

		// Token: 0x040036F4 RID: 14068
		private const string COMMAND = "select BinData from `RegressTrialRole`";

		// Token: 0x040036F5 RID: 14069
		private const string KEY_PREFIX = "RegressTrialRoleAll";

		// Token: 0x040036F6 RID: 14070
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036F7 RID: 14071
		private static int HandleId;
	}
}
