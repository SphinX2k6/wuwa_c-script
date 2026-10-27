using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000112 RID: 274
	public class ConfigBossRushTaskConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600066D RID: 1645 RVA: 0x0007DF50 File Offset: 0x0007C150
		static ConfigBossRushTaskConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushTaskConfigAll.CreateStaticDefaultValue), new Action(ConfigBossRushTaskConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0007DF70 File Offset: 0x0007C170
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushTaskConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushTaskConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushTaskConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushTaskConfig`")
			});
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0007DFEF File Offset: 0x0007C1EF
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushTaskConfigAll.LogPair = null;
			ConfigBossRushTaskConfigAll.HandleId = 0;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0007DFFD File Offset: 0x0007C1FD
		public static void Init()
		{
			ConfigBossRushTaskConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushTaskConfigAll.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushTaskConfig`");
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0007E018 File Offset: 0x0007C218
		[NullableContext(2)]
		public static IReadOnlyList<BossRushTaskConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushTaskConfigAll.HandleId, ConfigBossRushTaskConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BossRushTaskConfig> readOnlyList = (IReadOnlyList<BossRushTaskConfig>)ConfigCommon.GetConfig("BossRushTaskConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BossRushTaskConfig> list = new List<BossRushTaskConfig>();
			while (ConfigCommon.Step(ConfigBossRushTaskConfigAll.HandleId, false, ConfigBossRushTaskConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushTaskConfigAll.HandleId, 0, ConfigBossRushTaskConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBossRushTaskConfigAll.HandleId, ConfigBossRushTaskConfigAll.LogPair);
					return null;
				}
				BossRushTaskConfig rootAsBossRushTaskConfig = BossRushTaskConfig.GetRootAsBossRushTaskConfig(new ByteBuffer(item2));
				list.Add(rootAsBossRushTaskConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BossRushTaskConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBossRushTaskConfigAll.HandleId, ConfigBossRushTaskConfigAll.LogPair);
			return list;
		}

		// Token: 0x04000762 RID: 1890
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x04000763 RID: 1891
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x04000764 RID: 1892
		private const string TABLE = "BossRushTaskConfig";

		// Token: 0x04000765 RID: 1893
		private const string COMMAND = "select BinData from `BossRushTaskConfig`";

		// Token: 0x04000766 RID: 1894
		private const string KEY_PREFIX = "BossRushTaskConfigAll";

		// Token: 0x04000767 RID: 1895
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000768 RID: 1896
		private static int HandleId;
	}
}
