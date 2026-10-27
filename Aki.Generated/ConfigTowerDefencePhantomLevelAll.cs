using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009FA RID: 2554
	public class ConfigTowerDefencePhantomLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BF0 RID: 15344 RVA: 0x001ACACC File Offset: 0x001AACCC
		static ConfigTowerDefencePhantomLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefencePhantomLevelAll.CreateStaticDefaultValue), new Action(ConfigTowerDefencePhantomLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x001ACAEC File Offset: 0x001AACEC
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefencePhantomLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefencePhantomLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefencePhantomLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefencePhantomLevel`")
			});
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x001ACB6B File Offset: 0x001AAD6B
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefencePhantomLevelAll.LogPair = null;
			ConfigTowerDefencePhantomLevelAll.HandleId = 0;
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x001ACB79 File Offset: 0x001AAD79
		public static void Init()
		{
			ConfigTowerDefencePhantomLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefencePhantomLevelAll.HandleId, "db_towerdefense.db", "select BinData from `TowerDefencePhantomLevel`");
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x001ACB94 File Offset: 0x001AAD94
		[NullableContext(2)]
		public static IReadOnlyList<TowerDefencePhantomLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefencePhantomLevelAll.HandleId, ConfigTowerDefencePhantomLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TowerDefencePhantomLevel> readOnlyList = (IReadOnlyList<TowerDefencePhantomLevel>)ConfigCommon.GetConfig("TowerDefencePhantomLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TowerDefencePhantomLevel> list = new List<TowerDefencePhantomLevel>();
			while (ConfigCommon.Step(ConfigTowerDefencePhantomLevelAll.HandleId, false, ConfigTowerDefencePhantomLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefencePhantomLevelAll.HandleId, 0, ConfigTowerDefencePhantomLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTowerDefencePhantomLevelAll.HandleId, ConfigTowerDefencePhantomLevelAll.LogPair);
					return null;
				}
				TowerDefencePhantomLevel rootAsTowerDefencePhantomLevel = TowerDefencePhantomLevel.GetRootAsTowerDefencePhantomLevel(new ByteBuffer(item2));
				list.Add(rootAsTowerDefencePhantomLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TowerDefencePhantomLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTowerDefencePhantomLevelAll.HandleId, ConfigTowerDefencePhantomLevelAll.LogPair);
			return list;
		}

		// Token: 0x040045BC RID: 17852
		private const string DB = "db_towerdefense.db";

		// Token: 0x040045BD RID: 17853
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x040045BE RID: 17854
		private const string TABLE = "TowerDefencePhantomLevel";

		// Token: 0x040045BF RID: 17855
		private const string COMMAND = "select BinData from `TowerDefencePhantomLevel`";

		// Token: 0x040045C0 RID: 17856
		private const string KEY_PREFIX = "TowerDefencePhantomLevelAll";

		// Token: 0x040045C1 RID: 17857
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045C2 RID: 17858
		private static int HandleId;
	}
}
