using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC5 RID: 2757
	public class ConfigTowerConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040B2 RID: 16562 RVA: 0x001CAA71 File Offset: 0x001C8C71
		static ConfigTowerConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerConfigAll.CreateStaticDefaultValue), new Action(ConfigTowerConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x001CAA90 File Offset: 0x001C8C90
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tower.db"),
				new ValueTuple<string, object>("文件", "p.爬塔新.xlsx"),
				new ValueTuple<string, object>("表名", "TowerConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerConfig`")
			});
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x001CAB0F File Offset: 0x001C8D0F
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerConfigAll.LogPair = null;
			ConfigTowerConfigAll.HandleId = 0;
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x001CAB1D File Offset: 0x001C8D1D
		public static void Init()
		{
			ConfigTowerConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigTowerConfigAll.HandleId, "db_tower.db", "select BinData from `TowerConfig`");
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x001CAB38 File Offset: 0x001C8D38
		[NullableContext(2)]
		public static IReadOnlyList<TowerConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerConfigAll.HandleId, ConfigTowerConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TowerConfig> readOnlyList = (IReadOnlyList<TowerConfig>)ConfigCommon.GetConfig("TowerConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TowerConfig> list = new List<TowerConfig>();
			while (ConfigCommon.Step(ConfigTowerConfigAll.HandleId, false, ConfigTowerConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerConfigAll.HandleId, 0, ConfigTowerConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTowerConfigAll.HandleId, ConfigTowerConfigAll.LogPair);
					return null;
				}
				TowerConfig rootAsTowerConfig = TowerConfig.GetRootAsTowerConfig(new ByteBuffer(item2));
				list.Add(rootAsTowerConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TowerConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTowerConfigAll.HandleId, ConfigTowerConfigAll.LogPair);
			return list;
		}

		// Token: 0x04004B49 RID: 19273
		private const string DB = "db_tower.db";

		// Token: 0x04004B4A RID: 19274
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004B4B RID: 19275
		private const string TABLE = "TowerConfig";

		// Token: 0x04004B4C RID: 19276
		private const string COMMAND = "select BinData from `TowerConfig`";

		// Token: 0x04004B4D RID: 19277
		private const string KEY_PREFIX = "TowerConfigAll";

		// Token: 0x04004B4E RID: 19278
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B4F RID: 19279
		private static int HandleId;
	}
}
