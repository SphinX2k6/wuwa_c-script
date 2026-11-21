using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000900 RID: 2304
	public class ConfigRoleTowerRewardTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003613 RID: 13843 RVA: 0x0018E603 File Offset: 0x0018C803
		static ConfigRoleTowerRewardTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerRewardTabAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerRewardTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x0018E624 File Offset: 0x0018C824
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerRewardTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerRewardTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerRewardTab"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerRewardTab`")
			});
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x0018E6A3 File Offset: 0x0018C8A3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerRewardTabAll.LogPair = null;
			ConfigRoleTowerRewardTabAll.HandleId = 0;
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x0018E6B1 File Offset: 0x0018C8B1
		public static void Init()
		{
			ConfigRoleTowerRewardTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerRewardTabAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerRewardTab`");
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x0018E6CC File Offset: 0x0018C8CC
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerRewardTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerRewardTabAll.HandleId, ConfigRoleTowerRewardTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerRewardTab> readOnlyList = (IReadOnlyList<RoleTowerRewardTab>)ConfigCommon.GetConfig("RoleTowerRewardTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerRewardTab> list = new List<RoleTowerRewardTab>();
			while (ConfigCommon.Step(ConfigRoleTowerRewardTabAll.HandleId, false, ConfigRoleTowerRewardTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerRewardTabAll.HandleId, 0, ConfigRoleTowerRewardTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerRewardTabAll.HandleId, ConfigRoleTowerRewardTabAll.LogPair);
					return null;
				}
				RoleTowerRewardTab rootAsRoleTowerRewardTab = RoleTowerRewardTab.GetRootAsRoleTowerRewardTab(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerRewardTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerRewardTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerRewardTabAll.HandleId, ConfigRoleTowerRewardTabAll.LogPair);
			return list;
		}

		// Token: 0x04003EE6 RID: 16102
		private const string DB = "db_roletower.db";

		// Token: 0x04003EE7 RID: 16103
		private const string FILE = "j.角色爬塔_局外.xlsx";

		// Token: 0x04003EE8 RID: 16104
		private const string TABLE = "RoleTowerRewardTab";

		// Token: 0x04003EE9 RID: 16105
		private const string COMMAND = "select BinData from `RoleTowerRewardTab`";

		// Token: 0x04003EEA RID: 16106
		private const string KEY_PREFIX = "RoleTowerRewardTabAll";

		// Token: 0x04003EEB RID: 16107
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EEC RID: 16108
		private static int HandleId;
	}
}
