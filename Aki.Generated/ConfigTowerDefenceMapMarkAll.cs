using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F6 RID: 2550
	public class ConfigTowerDefenceMapMarkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BD8 RID: 15320 RVA: 0x001AC314 File Offset: 0x001AA514
		static ConfigTowerDefenceMapMarkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceMapMarkAll.CreateStaticDefaultValue), new Action(ConfigTowerDefenceMapMarkAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x001AC334 File Offset: 0x001AA534
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

		// Token: 0x06003BDA RID: 15322 RVA: 0x001AC3B3 File Offset: 0x001AA5B3
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceMapMarkAll.LogPair = null;
			ConfigTowerDefenceMapMarkAll.HandleId = 0;
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x001AC3C1 File Offset: 0x001AA5C1
		public static void Init()
		{
			ConfigTowerDefenceMapMarkAll.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceMapMarkAll.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceMapMark`");
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x001AC3DC File Offset: 0x001AA5DC
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

		// Token: 0x040045A0 RID: 17824
		private const string DB = "db_towerdefense.db";

		// Token: 0x040045A1 RID: 17825
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x040045A2 RID: 17826
		private const string TABLE = "TowerDefenceMapMark";

		// Token: 0x040045A3 RID: 17827
		private const string COMMAND = "select BinData from `TowerDefenceMapMark`";

		// Token: 0x040045A4 RID: 17828
		private const string KEY_PREFIX = "TowerDefenceMapMarkAll";

		// Token: 0x040045A5 RID: 17829
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045A6 RID: 17830
		private static int HandleId;
	}
}
