using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000108 RID: 264
	public class ConfigBossRushActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000631 RID: 1585 RVA: 0x0007CB08 File Offset: 0x0007AD08
		static ConfigBossRushActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushActivityAll.CreateStaticDefaultValue), new Action(ConfigBossRushActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0007CB28 File Offset: 0x0007AD28
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

		// Token: 0x06000633 RID: 1587 RVA: 0x0007CBA7 File Offset: 0x0007ADA7
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushActivityAll.LogPair = null;
			ConfigBossRushActivityAll.HandleId = 0;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0007CBB5 File Offset: 0x0007ADB5
		public static void Init()
		{
			ConfigBossRushActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushActivityAll.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushActivity`");
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0007CBD0 File Offset: 0x0007ADD0
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

		// Token: 0x0400071C RID: 1820
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x0400071D RID: 1821
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x0400071E RID: 1822
		private const string TABLE = "BossRushActivity";

		// Token: 0x0400071F RID: 1823
		private const string COMMAND = "select BinData from `BossRushActivity`";

		// Token: 0x04000720 RID: 1824
		private const string KEY_PREFIX = "BossRushActivityAll";

		// Token: 0x04000721 RID: 1825
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000722 RID: 1826
		private static int HandleId;
	}
}
