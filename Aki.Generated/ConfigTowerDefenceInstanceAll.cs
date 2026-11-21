using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC8 RID: 2760
	public class ConfigTowerDefenceInstanceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040C4 RID: 16580 RVA: 0x001CB083 File Offset: 0x001C9283
		static ConfigTowerDefenceInstanceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceInstanceAll.CreateStaticDefaultValue), new Action(ConfigTowerDefenceInstanceAll.ResetStaticDefaultValue));
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x001CB0A4 File Offset: 0x001C92A4
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefenceInstanceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefenceInstanceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefenceInstance"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefenceInstance`")
			});
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x001CB123 File Offset: 0x001C9323
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceInstanceAll.LogPair = null;
			ConfigTowerDefenceInstanceAll.HandleId = 0;
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x001CB131 File Offset: 0x001C9331
		public static void Init()
		{
			ConfigTowerDefenceInstanceAll.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceInstanceAll.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceInstance`");
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x001CB14C File Offset: 0x001C934C
		[NullableContext(2)]
		public static IReadOnlyList<TowerDefenceInstance> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefenceInstanceAll.HandleId, ConfigTowerDefenceInstanceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TowerDefenceInstance> readOnlyList = (IReadOnlyList<TowerDefenceInstance>)ConfigCommon.GetConfig("TowerDefenceInstanceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TowerDefenceInstance> list = new List<TowerDefenceInstance>();
			while (ConfigCommon.Step(ConfigTowerDefenceInstanceAll.HandleId, false, ConfigTowerDefenceInstanceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefenceInstanceAll.HandleId, 0, ConfigTowerDefenceInstanceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTowerDefenceInstanceAll.HandleId, ConfigTowerDefenceInstanceAll.LogPair);
					return null;
				}
				TowerDefenceInstance rootAsTowerDefenceInstance = TowerDefenceInstance.GetRootAsTowerDefenceInstance(new ByteBuffer(item2));
				list.Add(rootAsTowerDefenceInstance);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TowerDefenceInstanceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTowerDefenceInstanceAll.HandleId, ConfigTowerDefenceInstanceAll.LogPair);
			return list;
		}

		// Token: 0x04004B5E RID: 19294
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004B5F RID: 19295
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004B60 RID: 19296
		private const string TABLE = "TowerDefenceInstance";

		// Token: 0x04004B61 RID: 19297
		private const string COMMAND = "select BinData from `TowerDefenceInstance`";

		// Token: 0x04004B62 RID: 19298
		private const string KEY_PREFIX = "TowerDefenceInstanceAll";

		// Token: 0x04004B63 RID: 19299
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B64 RID: 19300
		private static int HandleId;
	}
}
