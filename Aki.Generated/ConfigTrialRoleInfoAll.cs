using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A53 RID: 2643
	public class ConfigTrialRoleInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E06 RID: 15878 RVA: 0x001B8AB0 File Offset: 0x001B6CB0
		static ConfigTrialRoleInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialRoleInfoAll.CreateStaticDefaultValue), new Action(ConfigTrialRoleInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x001B8AD0 File Offset: 0x001B6CD0
		public static void CreateStaticDefaultValue()
		{
			ConfigTrialRoleInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrialRoleInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trial_role.db"),
				new ValueTuple<string, object>("文件", "s.试用角色.xlsx"),
				new ValueTuple<string, object>("表名", "TrialRoleInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `TrialRoleInfo`")
			});
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x001B8B4F File Offset: 0x001B6D4F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialRoleInfoAll.LogPair = null;
			ConfigTrialRoleInfoAll.HandleId = 0;
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x001B8B5D File Offset: 0x001B6D5D
		public static void Init()
		{
			ConfigTrialRoleInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrialRoleInfoAll.HandleId, "db_trial_role.db", "select BinData from `TrialRoleInfo`");
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x001B8B78 File Offset: 0x001B6D78
		[NullableContext(2)]
		public static IReadOnlyList<TrialRoleInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrialRoleInfoAll.HandleId, ConfigTrialRoleInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrialRoleInfo> readOnlyList = (IReadOnlyList<TrialRoleInfo>)ConfigCommon.GetConfig("TrialRoleInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrialRoleInfo> list = new List<TrialRoleInfo>();
			while (ConfigCommon.Step(ConfigTrialRoleInfoAll.HandleId, false, ConfigTrialRoleInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrialRoleInfoAll.HandleId, 0, ConfigTrialRoleInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrialRoleInfoAll.HandleId, ConfigTrialRoleInfoAll.LogPair);
					return null;
				}
				TrialRoleInfo rootAsTrialRoleInfo = TrialRoleInfo.GetRootAsTrialRoleInfo(new ByteBuffer(item2));
				list.Add(rootAsTrialRoleInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrialRoleInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrialRoleInfoAll.HandleId, ConfigTrialRoleInfoAll.LogPair);
			return list;
		}

		// Token: 0x0400482B RID: 18475
		private const string DB = "db_trial_role.db";

		// Token: 0x0400482C RID: 18476
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x0400482D RID: 18477
		private const string TABLE = "TrialRoleInfo";

		// Token: 0x0400482E RID: 18478
		private const string COMMAND = "select BinData from `TrialRoleInfo`";

		// Token: 0x0400482F RID: 18479
		private const string KEY_PREFIX = "TrialRoleInfoAll";

		// Token: 0x04004830 RID: 18480
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004831 RID: 18481
		private static int HandleId;
	}
}
