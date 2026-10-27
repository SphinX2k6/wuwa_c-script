using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009FD RID: 2557
	public class ConfigTowerDefenceRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C02 RID: 15362 RVA: 0x001AD0E0 File Offset: 0x001AB2E0
		static ConfigTowerDefenceRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceRewardAll.CreateStaticDefaultValue), new Action(ConfigTowerDefenceRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x001AD100 File Offset: 0x001AB300
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

		// Token: 0x06003C04 RID: 15364 RVA: 0x001AD17F File Offset: 0x001AB37F
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceRewardAll.LogPair = null;
			ConfigTowerDefenceRewardAll.HandleId = 0;
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x001AD18D File Offset: 0x001AB38D
		public static void Init()
		{
			ConfigTowerDefenceRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceRewardAll.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceReward`");
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x001AD1A8 File Offset: 0x001AB3A8
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

		// Token: 0x040045D1 RID: 17873
		private const string DB = "db_towerdefense.db";

		// Token: 0x040045D2 RID: 17874
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x040045D3 RID: 17875
		private const string TABLE = "TowerDefenceReward";

		// Token: 0x040045D4 RID: 17876
		private const string COMMAND = "select BinData from `TowerDefenceReward`";

		// Token: 0x040045D5 RID: 17877
		private const string KEY_PREFIX = "TowerDefenceRewardAll";

		// Token: 0x040045D6 RID: 17878
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045D7 RID: 17879
		private static int HandleId;
	}
}
