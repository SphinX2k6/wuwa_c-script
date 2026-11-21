using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ACB RID: 2763
	public class ConfigTowerDefenceMapMarkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040D6 RID: 16598 RVA: 0x001CB6A8 File Offset: 0x001C98A8
		static ConfigTowerDefenceMapMarkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceMapMarkAll.CreateStaticDefaultValue), new Action(ConfigTowerDefenceMapMarkAll.ResetStaticDefaultValue));
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x001CB6C8 File Offset: 0x001C98C8
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefenceMapMarkAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefenceMapMarkAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefenceMapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefenceMapMark`")
			});
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x001CB747 File Offset: 0x001C9947
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceMapMarkAll.LogPair = null;
			ConfigTowerDefenceMapMarkAll.HandleId = 0;
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x001CB755 File Offset: 0x001C9955
		public static void Init()
		{
			ConfigTowerDefenceMapMarkAll.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceMapMarkAll.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceMapMark`");
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x001CB770 File Offset: 0x001C9970
		[NullableContext(2)]
		public static IReadOnlyList<TowerDefenceMapMark> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefenceMapMarkAll.HandleId, ConfigTowerDefenceMapMarkAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TowerDefenceMapMark> readOnlyList = (IReadOnlyList<TowerDefenceMapMark>)ConfigCommon.GetConfig("TowerDefenceMapMarkAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TowerDefenceMapMark> list = new List<TowerDefenceMapMark>();
			while (ConfigCommon.Step(ConfigTowerDefenceMapMarkAll.HandleId, false, ConfigTowerDefenceMapMarkAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefenceMapMarkAll.HandleId, 0, ConfigTowerDefenceMapMarkAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTowerDefenceMapMarkAll.HandleId, ConfigTowerDefenceMapMarkAll.LogPair);
					return null;
				}
				TowerDefenceMapMark rootAsTowerDefenceMapMark = TowerDefenceMapMark.GetRootAsTowerDefenceMapMark(new ByteBuffer(item2));
				list.Add(rootAsTowerDefenceMapMark);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TowerDefenceMapMarkAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTowerDefenceMapMarkAll.HandleId, ConfigTowerDefenceMapMarkAll.LogPair);
			return list;
		}

		// Token: 0x04004B73 RID: 19315
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004B74 RID: 19316
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004B75 RID: 19317
		private const string TABLE = "TowerDefenceMapMark";

		// Token: 0x04004B76 RID: 19318
		private const string COMMAND = "select BinData from `TowerDefenceMapMark`";

		// Token: 0x04004B77 RID: 19319
		private const string KEY_PREFIX = "TowerDefenceMapMarkAll";

		// Token: 0x04004B78 RID: 19320
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B79 RID: 19321
		private static int HandleId;
	}
}
