using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000124 RID: 292
	public class ConfigBossRushTaskTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006D9 RID: 1753 RVA: 0x00083EC8 File Offset: 0x000820C8
		static ConfigBossRushTaskTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushTaskTabAll.CreateStaticDefaultValue), new Action(ConfigBossRushTaskTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00083EE8 File Offset: 0x000820E8
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushTaskTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushTaskTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushTaskTab"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushTaskTab`")
			});
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00083F67 File Offset: 0x00082167
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushTaskTabAll.LogPair = null;
			ConfigBossRushTaskTabAll.HandleId = 0;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00083F75 File Offset: 0x00082175
		public static void Init()
		{
			ConfigBossRushTaskTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushTaskTabAll.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushTaskTab`");
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00083F90 File Offset: 0x00082190
		[NullableContext(2)]
		public static IReadOnlyList<BossRushTaskTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushTaskTabAll.HandleId, ConfigBossRushTaskTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BossRushTaskTab> readOnlyList = (IReadOnlyList<BossRushTaskTab>)ConfigCommon.GetConfig("BossRushTaskTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BossRushTaskTab> list = new List<BossRushTaskTab>();
			while (ConfigCommon.Step(ConfigBossRushTaskTabAll.HandleId, false, ConfigBossRushTaskTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushTaskTabAll.HandleId, 0, ConfigBossRushTaskTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBossRushTaskTabAll.HandleId, ConfigBossRushTaskTabAll.LogPair);
					return null;
				}
				BossRushTaskTab rootAsBossRushTaskTab = BossRushTaskTab.GetRootAsBossRushTaskTab(new ByteBuffer(item2));
				list.Add(rootAsBossRushTaskTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BossRushTaskTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBossRushTaskTabAll.HandleId, ConfigBossRushTaskTabAll.LogPair);
			return list;
		}

		// Token: 0x040007E0 RID: 2016
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x040007E1 RID: 2017
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x040007E2 RID: 2018
		private const string TABLE = "BossRushTaskTab";

		// Token: 0x040007E3 RID: 2019
		private const string COMMAND = "select BinData from `BossRushTaskTab`";

		// Token: 0x040007E4 RID: 2020
		private const string KEY_PREFIX = "BossRushTaskTabAll";

		// Token: 0x040007E5 RID: 2021
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007E6 RID: 2022
		private static int HandleId;
	}
}
