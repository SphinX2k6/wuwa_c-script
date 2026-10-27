using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000110 RID: 272
	public class ConfigBossRushScoreAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000661 RID: 1633 RVA: 0x0007DB74 File Offset: 0x0007BD74
		static ConfigBossRushScoreAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushScoreAll.CreateStaticDefaultValue), new Action(ConfigBossRushScoreAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0007DB94 File Offset: 0x0007BD94
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

		// Token: 0x06000663 RID: 1635 RVA: 0x0007DC13 File Offset: 0x0007BE13
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushScoreAll.LogPair = null;
			ConfigBossRushScoreAll.HandleId = 0;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0007DC21 File Offset: 0x0007BE21
		public static void Init()
		{
			ConfigBossRushScoreAll.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushScoreAll.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushScore`");
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0007DC3C File Offset: 0x0007BE3C
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

		// Token: 0x04000754 RID: 1876
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x04000755 RID: 1877
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x04000756 RID: 1878
		private const string TABLE = "BossRushScore";

		// Token: 0x04000757 RID: 1879
		private const string COMMAND = "select BinData from `BossRushScore`";

		// Token: 0x04000758 RID: 1880
		private const string KEY_PREFIX = "BossRushScoreAll";

		// Token: 0x04000759 RID: 1881
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400075A RID: 1882
		private static int HandleId;
	}
}
