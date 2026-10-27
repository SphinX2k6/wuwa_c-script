using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F0 RID: 2544
	public class ConfigTowerConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BB4 RID: 15284 RVA: 0x001AB6DD File Offset: 0x001A98DD
		static ConfigTowerConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerConfigAll.CreateStaticDefaultValue), new Action(ConfigTowerConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x001AB6FC File Offset: 0x001A98FC
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

		// Token: 0x06003BB6 RID: 15286 RVA: 0x001AB77B File Offset: 0x001A997B
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerConfigAll.LogPair = null;
			ConfigTowerConfigAll.HandleId = 0;
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x001AB789 File Offset: 0x001A9989
		public static void Init()
		{
			ConfigTowerConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigTowerConfigAll.HandleId, "db_tower.db", "select BinData from `TowerConfig`");
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x001AB7A4 File Offset: 0x001A99A4
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

		// Token: 0x04004576 RID: 17782
		private const string DB = "db_tower.db";

		// Token: 0x04004577 RID: 17783
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004578 RID: 17784
		private const string TABLE = "TowerConfig";

		// Token: 0x04004579 RID: 17785
		private const string COMMAND = "select BinData from `TowerConfig`";

		// Token: 0x0400457A RID: 17786
		private const string KEY_PREFIX = "TowerConfigAll";

		// Token: 0x0400457B RID: 17787
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400457C RID: 17788
		private static int HandleId;
	}
}
