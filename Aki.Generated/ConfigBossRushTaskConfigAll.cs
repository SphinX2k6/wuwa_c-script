using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000121 RID: 289
	public class ConfigBossRushTaskConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006C7 RID: 1735 RVA: 0x000838B4 File Offset: 0x00081AB4
		static ConfigBossRushTaskConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushTaskConfigAll.CreateStaticDefaultValue), new Action(ConfigBossRushTaskConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000838D4 File Offset: 0x00081AD4
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

		// Token: 0x060006C9 RID: 1737 RVA: 0x00083953 File Offset: 0x00081B53
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushTaskConfigAll.LogPair = null;
			ConfigBossRushTaskConfigAll.HandleId = 0;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00083961 File Offset: 0x00081B61
		public static void Init()
		{
			ConfigBossRushTaskConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushTaskConfigAll.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushTaskConfig`");
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0008397C File Offset: 0x00081B7C
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

		// Token: 0x040007CB RID: 1995
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x040007CC RID: 1996
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x040007CD RID: 1997
		private const string TABLE = "BossRushTaskConfig";

		// Token: 0x040007CE RID: 1998
		private const string COMMAND = "select BinData from `BossRushTaskConfig`";

		// Token: 0x040007CF RID: 1999
		private const string KEY_PREFIX = "BossRushTaskConfigAll";

		// Token: 0x040007D0 RID: 2000
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007D1 RID: 2001
		private static int HandleId;
	}
}
