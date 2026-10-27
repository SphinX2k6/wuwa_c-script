using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F8 RID: 2552
	public class ConfigTowerDefencePhantomAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BE4 RID: 15332 RVA: 0x001AC6F0 File Offset: 0x001AA8F0
		static ConfigTowerDefencePhantomAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefencePhantomAll.CreateStaticDefaultValue), new Action(ConfigTowerDefencePhantomAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x001AC710 File Offset: 0x001AA910
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefencePhantomAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefencePhantomAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefencePhantom"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefencePhantom`")
			});
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x001AC78F File Offset: 0x001AA98F
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefencePhantomAll.LogPair = null;
			ConfigTowerDefencePhantomAll.HandleId = 0;
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x001AC79D File Offset: 0x001AA99D
		public static void Init()
		{
			ConfigTowerDefencePhantomAll.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefencePhantomAll.HandleId, "db_towerdefense.db", "select BinData from `TowerDefencePhantom`");
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x001AC7B8 File Offset: 0x001AA9B8
		[NullableContext(2)]
		public static IReadOnlyList<TowerDefencePhantom> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefencePhantomAll.HandleId, ConfigTowerDefencePhantomAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TowerDefencePhantom> readOnlyList = (IReadOnlyList<TowerDefencePhantom>)ConfigCommon.GetConfig("TowerDefencePhantomAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TowerDefencePhantom> list = new List<TowerDefencePhantom>();
			while (ConfigCommon.Step(ConfigTowerDefencePhantomAll.HandleId, false, ConfigTowerDefencePhantomAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefencePhantomAll.HandleId, 0, ConfigTowerDefencePhantomAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTowerDefencePhantomAll.HandleId, ConfigTowerDefencePhantomAll.LogPair);
					return null;
				}
				TowerDefencePhantom rootAsTowerDefencePhantom = TowerDefencePhantom.GetRootAsTowerDefencePhantom(new ByteBuffer(item2));
				list.Add(rootAsTowerDefencePhantom);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TowerDefencePhantomAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTowerDefencePhantomAll.HandleId, ConfigTowerDefencePhantomAll.LogPair);
			return list;
		}

		// Token: 0x040045AE RID: 17838
		private const string DB = "db_towerdefense.db";

		// Token: 0x040045AF RID: 17839
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x040045B0 RID: 17840
		private const string TABLE = "TowerDefencePhantom";

		// Token: 0x040045B1 RID: 17841
		private const string COMMAND = "select BinData from `TowerDefencePhantom`";

		// Token: 0x040045B2 RID: 17842
		private const string KEY_PREFIX = "TowerDefencePhantomAll";

		// Token: 0x040045B3 RID: 17843
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045B4 RID: 17844
		private static int HandleId;
	}
}
