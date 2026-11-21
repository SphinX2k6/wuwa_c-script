using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000906 RID: 2310
	public class ConfigRoleTowerScoreRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003637 RID: 13879 RVA: 0x0018F23C File Offset: 0x0018D43C
		static ConfigRoleTowerScoreRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerScoreRewardAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerScoreRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x0018F25C File Offset: 0x0018D45C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerScoreRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerScoreRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerScoreReward`")
			});
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x0018F2DB File Offset: 0x0018D4DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerScoreRewardAll.LogPair = null;
			ConfigRoleTowerScoreRewardAll.HandleId = 0;
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x0018F2E9 File Offset: 0x0018D4E9
		public static void Init()
		{
			ConfigRoleTowerScoreRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerScoreRewardAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerScoreReward`");
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x0018F304 File Offset: 0x0018D504
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerScoreReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerScoreRewardAll.HandleId, ConfigRoleTowerScoreRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerScoreReward> readOnlyList = (IReadOnlyList<RoleTowerScoreReward>)ConfigCommon.GetConfig("RoleTowerScoreRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerScoreReward> list = new List<RoleTowerScoreReward>();
			while (ConfigCommon.Step(ConfigRoleTowerScoreRewardAll.HandleId, false, ConfigRoleTowerScoreRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerScoreRewardAll.HandleId, 0, ConfigRoleTowerScoreRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerScoreRewardAll.HandleId, ConfigRoleTowerScoreRewardAll.LogPair);
					return null;
				}
				RoleTowerScoreReward rootAsRoleTowerScoreReward = RoleTowerScoreReward.GetRootAsRoleTowerScoreReward(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerScoreReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerScoreRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerScoreRewardAll.HandleId, ConfigRoleTowerScoreRewardAll.LogPair);
			return list;
		}

		// Token: 0x04003F10 RID: 16144
		private const string DB = "db_roletower.db";

		// Token: 0x04003F11 RID: 16145
		private const string FILE = "j.角色爬塔_局外.xlsx";

		// Token: 0x04003F12 RID: 16146
		private const string TABLE = "RoleTowerScoreReward";

		// Token: 0x04003F13 RID: 16147
		private const string COMMAND = "select BinData from `RoleTowerScoreReward`";

		// Token: 0x04003F14 RID: 16148
		private const string KEY_PREFIX = "RoleTowerScoreRewardAll";

		// Token: 0x04003F15 RID: 16149
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F16 RID: 16150
		private static int HandleId;
	}
}
