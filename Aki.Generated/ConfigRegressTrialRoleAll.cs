using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F9 RID: 2041
	public class ConfigRegressTrialRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FE8 RID: 12264 RVA: 0x0016B797 File Offset: 0x00169997
		static ConfigRegressTrialRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressTrialRoleAll.CreateStaticDefaultValue), new Action(ConfigRegressTrialRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x0016B7B8 File Offset: 0x001699B8
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

		// Token: 0x06002FEA RID: 12266 RVA: 0x0016B837 File Offset: 0x00169A37
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressTrialRoleAll.LogPair = null;
			ConfigRegressTrialRoleAll.HandleId = 0;
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x0016B845 File Offset: 0x00169A45
		public static void Init()
		{
			ConfigRegressTrialRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressTrialRoleAll.HandleId, "db_regressactivity.db", "select BinData from `RegressTrialRole`");
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x0016B860 File Offset: 0x00169A60
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

		// Token: 0x040037B5 RID: 14261
		private const string DB = "db_regressactivity.db";

		// Token: 0x040037B6 RID: 14262
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040037B7 RID: 14263
		private const string TABLE = "RegressTrialRole";

		// Token: 0x040037B8 RID: 14264
		private const string COMMAND = "select BinData from `RegressTrialRole`";

		// Token: 0x040037B9 RID: 14265
		private const string KEY_PREFIX = "RegressTrialRoleAll";

		// Token: 0x040037BA RID: 14266
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037BB RID: 14267
		private static int HandleId;
	}
}
