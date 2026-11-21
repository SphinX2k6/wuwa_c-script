using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200011F RID: 287
	public class ConfigBossRushScoreAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006BB RID: 1723 RVA: 0x000834D8 File Offset: 0x000816D8
		static ConfigBossRushScoreAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushScoreAll.CreateStaticDefaultValue), new Action(ConfigBossRushScoreAll.ResetStaticDefaultValue));
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000834F8 File Offset: 0x000816F8
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushScoreAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushScoreAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushScore"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushScore`")
			});
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00083577 File Offset: 0x00081777
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushScoreAll.LogPair = null;
			ConfigBossRushScoreAll.HandleId = 0;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00083585 File Offset: 0x00081785
		public static void Init()
		{
			ConfigBossRushScoreAll.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushScoreAll.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushScore`");
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x000835A0 File Offset: 0x000817A0
		[NullableContext(2)]
		public static IReadOnlyList<BossRushScore> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushScoreAll.HandleId, ConfigBossRushScoreAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BossRushScore> readOnlyList = (IReadOnlyList<BossRushScore>)ConfigCommon.GetConfig("BossRushScoreAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BossRushScore> list = new List<BossRushScore>();
			while (ConfigCommon.Step(ConfigBossRushScoreAll.HandleId, false, ConfigBossRushScoreAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushScoreAll.HandleId, 0, ConfigBossRushScoreAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBossRushScoreAll.HandleId, ConfigBossRushScoreAll.LogPair);
					return null;
				}
				BossRushScore rootAsBossRushScore = BossRushScore.GetRootAsBossRushScore(new ByteBuffer(item2));
				list.Add(rootAsBossRushScore);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BossRushScoreAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBossRushScoreAll.HandleId, ConfigBossRushScoreAll.LogPair);
			return list;
		}

		// Token: 0x040007BD RID: 1981
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x040007BE RID: 1982
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x040007BF RID: 1983
		private const string TABLE = "BossRushScore";

		// Token: 0x040007C0 RID: 1984
		private const string COMMAND = "select BinData from `BossRushScore`";

		// Token: 0x040007C1 RID: 1985
		private const string KEY_PREFIX = "BossRushScoreAll";

		// Token: 0x040007C2 RID: 1986
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007C3 RID: 1987
		private static int HandleId;
	}
}
