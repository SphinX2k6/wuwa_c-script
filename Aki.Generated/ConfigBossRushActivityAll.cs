using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000117 RID: 279
	public class ConfigBossRushActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x0008246C File Offset: 0x0008066C
		static ConfigBossRushActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushActivityAll.CreateStaticDefaultValue), new Action(ConfigBossRushActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0008248C File Offset: 0x0008068C
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushActivityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushActivityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushActivity`")
			});
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0008250B File Offset: 0x0008070B
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushActivityAll.LogPair = null;
			ConfigBossRushActivityAll.HandleId = 0;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00082519 File Offset: 0x00080719
		public static void Init()
		{
			ConfigBossRushActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushActivityAll.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushActivity`");
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00082534 File Offset: 0x00080734
		[NullableContext(2)]
		public static IReadOnlyList<BossRushActivity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushActivityAll.HandleId, ConfigBossRushActivityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BossRushActivity> readOnlyList = (IReadOnlyList<BossRushActivity>)ConfigCommon.GetConfig("BossRushActivityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BossRushActivity> list = new List<BossRushActivity>();
			while (ConfigCommon.Step(ConfigBossRushActivityAll.HandleId, false, ConfigBossRushActivityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushActivityAll.HandleId, 0, ConfigBossRushActivityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBossRushActivityAll.HandleId, ConfigBossRushActivityAll.LogPair);
					return null;
				}
				BossRushActivity rootAsBossRushActivity = BossRushActivity.GetRootAsBossRushActivity(new ByteBuffer(item2));
				list.Add(rootAsBossRushActivity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BossRushActivityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBossRushActivityAll.HandleId, ConfigBossRushActivityAll.LogPair);
			return list;
		}

		// Token: 0x04000785 RID: 1925
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x04000786 RID: 1926
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x04000787 RID: 1927
		private const string TABLE = "BossRushActivity";

		// Token: 0x04000788 RID: 1928
		private const string COMMAND = "select BinData from `BossRushActivity`";

		// Token: 0x04000789 RID: 1929
		private const string KEY_PREFIX = "BossRushActivityAll";

		// Token: 0x0400078A RID: 1930
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400078B RID: 1931
		private static int HandleId;
	}
}
