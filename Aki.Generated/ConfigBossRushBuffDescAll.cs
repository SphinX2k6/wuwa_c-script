using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200011C RID: 284
	public class ConfigBossRushBuffDescAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006A9 RID: 1705 RVA: 0x00082EB4 File Offset: 0x000810B4
		static ConfigBossRushBuffDescAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushBuffDescAll.CreateStaticDefaultValue), new Action(ConfigBossRushBuffDescAll.ResetStaticDefaultValue));
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00082ED4 File Offset: 0x000810D4
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushBuffDescAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushBuffDescAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushBuffDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushBuffDesc`")
			});
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00082F53 File Offset: 0x00081153
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushBuffDescAll.LogPair = null;
			ConfigBossRushBuffDescAll.HandleId = 0;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00082F61 File Offset: 0x00081161
		public static void Init()
		{
			ConfigBossRushBuffDescAll.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushBuffDescAll.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushBuffDesc`");
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00082F7C File Offset: 0x0008117C
		[NullableContext(2)]
		public static IReadOnlyList<BossRushBuffDesc> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushBuffDescAll.HandleId, ConfigBossRushBuffDescAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BossRushBuffDesc> readOnlyList = (IReadOnlyList<BossRushBuffDesc>)ConfigCommon.GetConfig("BossRushBuffDescAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BossRushBuffDesc> list = new List<BossRushBuffDesc>();
			while (ConfigCommon.Step(ConfigBossRushBuffDescAll.HandleId, false, ConfigBossRushBuffDescAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushBuffDescAll.HandleId, 0, ConfigBossRushBuffDescAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBossRushBuffDescAll.HandleId, ConfigBossRushBuffDescAll.LogPair);
					return null;
				}
				BossRushBuffDesc rootAsBossRushBuffDesc = BossRushBuffDesc.GetRootAsBossRushBuffDesc(new ByteBuffer(item2));
				list.Add(rootAsBossRushBuffDesc);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BossRushBuffDescAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBossRushBuffDescAll.HandleId, ConfigBossRushBuffDescAll.LogPair);
			return list;
		}

		// Token: 0x040007A8 RID: 1960
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x040007A9 RID: 1961
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x040007AA RID: 1962
		private const string TABLE = "BossRushBuffDesc";

		// Token: 0x040007AB RID: 1963
		private const string COMMAND = "select BinData from `BossRushBuffDesc`";

		// Token: 0x040007AC RID: 1964
		private const string KEY_PREFIX = "BossRushBuffDescAll";

		// Token: 0x040007AD RID: 1965
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007AE RID: 1966
		private static int HandleId;
	}
}
