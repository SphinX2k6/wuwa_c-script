using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000115 RID: 277
	public class ConfigBossRushTaskTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600067F RID: 1663 RVA: 0x0007E564 File Offset: 0x0007C764
		static ConfigBossRushTaskTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushTaskTabAll.CreateStaticDefaultValue), new Action(ConfigBossRushTaskTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0007E584 File Offset: 0x0007C784
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

		// Token: 0x06000681 RID: 1665 RVA: 0x0007E603 File Offset: 0x0007C803
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushTaskTabAll.LogPair = null;
			ConfigBossRushTaskTabAll.HandleId = 0;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0007E611 File Offset: 0x0007C811
		public static void Init()
		{
			ConfigBossRushTaskTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushTaskTabAll.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushTaskTab`");
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0007E62C File Offset: 0x0007C82C
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

		// Token: 0x04000777 RID: 1911
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x04000778 RID: 1912
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x04000779 RID: 1913
		private const string TABLE = "BossRushTaskTab";

		// Token: 0x0400077A RID: 1914
		private const string COMMAND = "select BinData from `BossRushTaskTab`";

		// Token: 0x0400077B RID: 1915
		private const string KEY_PREFIX = "BossRushTaskTabAll";

		// Token: 0x0400077C RID: 1916
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400077D RID: 1917
		private static int HandleId;
	}
}
