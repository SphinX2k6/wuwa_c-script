using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ACF RID: 2767
	public class ConfigTowerDefencePhantomLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040EE RID: 16622 RVA: 0x001CBE60 File Offset: 0x001CA060
		static ConfigTowerDefencePhantomLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefencePhantomLevelAll.CreateStaticDefaultValue), new Action(ConfigTowerDefencePhantomLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x001CBE80 File Offset: 0x001CA080
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

		// Token: 0x060040F0 RID: 16624 RVA: 0x001CBEFF File Offset: 0x001CA0FF
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefencePhantomLevelAll.LogPair = null;
			ConfigTowerDefencePhantomLevelAll.HandleId = 0;
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x001CBF0D File Offset: 0x001CA10D
		public static void Init()
		{
			ConfigTowerDefencePhantomLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefencePhantomLevelAll.HandleId, "db_towerdefense.db", "select BinData from `TowerDefencePhantomLevel`");
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x001CBF28 File Offset: 0x001CA128
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

		// Token: 0x04004B8F RID: 19343
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004B90 RID: 19344
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004B91 RID: 19345
		private const string TABLE = "TowerDefencePhantomLevel";

		// Token: 0x04004B92 RID: 19346
		private const string COMMAND = "select BinData from `TowerDefencePhantomLevel`";

		// Token: 0x04004B93 RID: 19347
		private const string KEY_PREFIX = "TowerDefencePhantomLevelAll";

		// Token: 0x04004B94 RID: 19348
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B95 RID: 19349
		private static int HandleId;
	}
}
