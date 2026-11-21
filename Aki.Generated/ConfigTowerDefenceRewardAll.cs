using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD2 RID: 2770
	public class ConfigTowerDefenceRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004100 RID: 16640 RVA: 0x001CC474 File Offset: 0x001CA674
		static ConfigTowerDefenceRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceRewardAll.CreateStaticDefaultValue), new Action(ConfigTowerDefenceRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x001CC494 File Offset: 0x001CA694
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefenceRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefenceRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefenceReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefenceReward`")
			});
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x001CC513 File Offset: 0x001CA713
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceRewardAll.LogPair = null;
			ConfigTowerDefenceRewardAll.HandleId = 0;
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x001CC521 File Offset: 0x001CA721
		public static void Init()
		{
			ConfigTowerDefenceRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceRewardAll.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceReward`");
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x001CC53C File Offset: 0x001CA73C
		[NullableContext(2)]
		public static IReadOnlyList<TowerDefenceReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefenceRewardAll.HandleId, ConfigTowerDefenceRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TowerDefenceReward> readOnlyList = (IReadOnlyList<TowerDefenceReward>)ConfigCommon.GetConfig("TowerDefenceRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TowerDefenceReward> list = new List<TowerDefenceReward>();
			while (ConfigCommon.Step(ConfigTowerDefenceRewardAll.HandleId, false, ConfigTowerDefenceRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefenceRewardAll.HandleId, 0, ConfigTowerDefenceRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTowerDefenceRewardAll.HandleId, ConfigTowerDefenceRewardAll.LogPair);
					return null;
				}
				TowerDefenceReward rootAsTowerDefenceReward = TowerDefenceReward.GetRootAsTowerDefenceReward(new ByteBuffer(item2));
				list.Add(rootAsTowerDefenceReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TowerDefenceRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTowerDefenceRewardAll.HandleId, ConfigTowerDefenceRewardAll.LogPair);
			return list;
		}

		// Token: 0x04004BA4 RID: 19364
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004BA5 RID: 19365
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004BA6 RID: 19366
		private const string TABLE = "TowerDefenceReward";

		// Token: 0x04004BA7 RID: 19367
		private const string COMMAND = "select BinData from `TowerDefenceReward`";

		// Token: 0x04004BA8 RID: 19368
		private const string KEY_PREFIX = "TowerDefenceRewardAll";

		// Token: 0x04004BA9 RID: 19369
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BAA RID: 19370
		private static int HandleId;
	}
}
