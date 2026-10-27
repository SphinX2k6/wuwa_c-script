using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200010B RID: 267
	public class ConfigBossRushBuffAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x0007D174 File Offset: 0x0007B374
		static ConfigBossRushBuffAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushBuffAll.CreateStaticDefaultValue), new Action(ConfigBossRushBuffAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0007D194 File Offset: 0x0007B394
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

		// Token: 0x06000645 RID: 1605 RVA: 0x0007D213 File Offset: 0x0007B413
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushBuffAll.LogPair = null;
			ConfigBossRushBuffAll.HandleId = 0;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0007D221 File Offset: 0x0007B421
		public static void Init()
		{
			ConfigBossRushBuffAll.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushBuffAll.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushBuff`");
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0007D23C File Offset: 0x0007B43C
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

		// Token: 0x04000731 RID: 1841
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x04000732 RID: 1842
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x04000733 RID: 1843
		private const string TABLE = "BossRushBuff";

		// Token: 0x04000734 RID: 1844
		private const string COMMAND = "select BinData from `BossRushBuff`";

		// Token: 0x04000735 RID: 1845
		private const string KEY_PREFIX = "BossRushBuffAll";

		// Token: 0x04000736 RID: 1846
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000737 RID: 1847
		private static int HandleId;
	}
}
