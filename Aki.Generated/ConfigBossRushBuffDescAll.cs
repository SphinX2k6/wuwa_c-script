using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200010D RID: 269
	public class ConfigBossRushBuffDescAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x0007D550 File Offset: 0x0007B750
		static ConfigBossRushBuffDescAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushBuffDescAll.CreateStaticDefaultValue), new Action(ConfigBossRushBuffDescAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0007D570 File Offset: 0x0007B770
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

		// Token: 0x06000651 RID: 1617 RVA: 0x0007D5EF File Offset: 0x0007B7EF
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushBuffDescAll.LogPair = null;
			ConfigBossRushBuffDescAll.HandleId = 0;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0007D5FD File Offset: 0x0007B7FD
		public static void Init()
		{
			ConfigBossRushBuffDescAll.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushBuffDescAll.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushBuffDesc`");
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0007D618 File Offset: 0x0007B818
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

		// Token: 0x0400073F RID: 1855
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x04000740 RID: 1856
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x04000741 RID: 1857
		private const string TABLE = "BossRushBuffDesc";

		// Token: 0x04000742 RID: 1858
		private const string COMMAND = "select BinData from `BossRushBuffDesc`";

		// Token: 0x04000743 RID: 1859
		private const string KEY_PREFIX = "BossRushBuffDescAll";

		// Token: 0x04000744 RID: 1860
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000745 RID: 1861
		private static int HandleId;
	}
}
