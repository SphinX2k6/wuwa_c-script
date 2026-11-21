using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008FC RID: 2300
	public class ConfigRoleTowerRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035FB RID: 13819 RVA: 0x0018DDB8 File Offset: 0x0018BFB8
		static ConfigRoleTowerRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerRewardAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x0018DDD8 File Offset: 0x0018BFD8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerReward`")
			});
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x0018DE57 File Offset: 0x0018C057
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerRewardAll.LogPair = null;
			ConfigRoleTowerRewardAll.HandleId = 0;
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x0018DE65 File Offset: 0x0018C065
		public static void Init()
		{
			ConfigRoleTowerRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerRewardAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerReward`");
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x0018DE80 File Offset: 0x0018C080
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerRewardAll.HandleId, ConfigRoleTowerRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerReward> readOnlyList = (IReadOnlyList<RoleTowerReward>)ConfigCommon.GetConfig("RoleTowerRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerReward> list = new List<RoleTowerReward>();
			while (ConfigCommon.Step(ConfigRoleTowerRewardAll.HandleId, false, ConfigRoleTowerRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerRewardAll.HandleId, 0, ConfigRoleTowerRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerRewardAll.HandleId, ConfigRoleTowerRewardAll.LogPair);
					return null;
				}
				RoleTowerReward rootAsRoleTowerReward = RoleTowerReward.GetRootAsRoleTowerReward(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerRewardAll.HandleId, ConfigRoleTowerRewardAll.LogPair);
			return list;
		}

		// Token: 0x04003ECA RID: 16074
		private const string DB = "db_roletower.db";

		// Token: 0x04003ECB RID: 16075
		private const string FILE = "j.角色爬塔_局外.xlsx";

		// Token: 0x04003ECC RID: 16076
		private const string TABLE = "RoleTowerReward";

		// Token: 0x04003ECD RID: 16077
		private const string COMMAND = "select BinData from `RoleTowerReward`";

		// Token: 0x04003ECE RID: 16078
		private const string KEY_PREFIX = "RoleTowerRewardAll";

		// Token: 0x04003ECF RID: 16079
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003ED0 RID: 16080
		private static int HandleId;
	}
}
