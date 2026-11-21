using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200011A RID: 282
	public class ConfigBossRushBuffAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600069D RID: 1693 RVA: 0x00082AD8 File Offset: 0x00080CD8
		static ConfigBossRushBuffAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushBuffAll.CreateStaticDefaultValue), new Action(ConfigBossRushBuffAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00082AF8 File Offset: 0x00080CF8
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushBuffAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushBuffAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushBuff`")
			});
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00082B77 File Offset: 0x00080D77
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushBuffAll.LogPair = null;
			ConfigBossRushBuffAll.HandleId = 0;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00082B85 File Offset: 0x00080D85
		public static void Init()
		{
			ConfigBossRushBuffAll.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushBuffAll.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushBuff`");
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00082BA0 File Offset: 0x00080DA0
		[NullableContext(2)]
		public static IReadOnlyList<BossRushBuff> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushBuffAll.HandleId, ConfigBossRushBuffAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BossRushBuff> readOnlyList = (IReadOnlyList<BossRushBuff>)ConfigCommon.GetConfig("BossRushBuffAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BossRushBuff> list = new List<BossRushBuff>();
			while (ConfigCommon.Step(ConfigBossRushBuffAll.HandleId, false, ConfigBossRushBuffAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushBuffAll.HandleId, 0, ConfigBossRushBuffAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBossRushBuffAll.HandleId, ConfigBossRushBuffAll.LogPair);
					return null;
				}
				BossRushBuff rootAsBossRushBuff = BossRushBuff.GetRootAsBossRushBuff(new ByteBuffer(item2));
				list.Add(rootAsBossRushBuff);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BossRushBuffAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBossRushBuffAll.HandleId, ConfigBossRushBuffAll.LogPair);
			return list;
		}

		// Token: 0x0400079A RID: 1946
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x0400079B RID: 1947
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x0400079C RID: 1948
		private const string TABLE = "BossRushBuff";

		// Token: 0x0400079D RID: 1949
		private const string COMMAND = "select BinData from `BossRushBuff`";

		// Token: 0x0400079E RID: 1950
		private const string KEY_PREFIX = "BossRushBuffAll";

		// Token: 0x0400079F RID: 1951
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007A0 RID: 1952
		private static int HandleId;
	}
}
