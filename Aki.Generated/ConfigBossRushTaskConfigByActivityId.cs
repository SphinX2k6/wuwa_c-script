using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000113 RID: 275
	public class ConfigBossRushTaskConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000673 RID: 1651 RVA: 0x0007E0E3 File Offset: 0x0007C2E3
		static ConfigBossRushTaskConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushTaskConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigBossRushTaskConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0007E104 File Offset: 0x0007C304
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushTaskConfigByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushTaskConfigByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushTaskConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushTaskConfig` where ActivityId=?")
			});
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0007E183 File Offset: 0x0007C383
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushTaskConfigByActivityId.LogPair = null;
			ConfigBossRushTaskConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0007E191 File Offset: 0x0007C391
		public static void Init()
		{
			ConfigBossRushTaskConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushTaskConfigByActivityId.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushTaskConfig` where ActivityId=?");
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0007E1AC File Offset: 0x0007C3AC
		[NullableContext(2)]
		public static IReadOnlyList<BossRushTaskConfig> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushTaskConfigByActivityId.HandleId, ConfigBossRushTaskConfigByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushTaskConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<BossRushTaskConfig> readOnlyList = (IReadOnlyList<BossRushTaskConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBossRushTaskConfigByActivityId.LogPair.Clear();
			ConfigBossRushTaskConfigByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigBossRushTaskConfigByActivityId.HandleId, 1, p0ActivityId, ConfigBossRushTaskConfigByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigBossRushTaskConfigByActivityId.HandleId, ConfigBossRushTaskConfigByActivityId.LogPair);
				return null;
			}
			List<BossRushTaskConfig> list = new List<BossRushTaskConfig>();
			while (ConfigCommon.Step(ConfigBossRushTaskConfigByActivityId.HandleId, false, ConfigBossRushTaskConfigByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushTaskConfigByActivityId.HandleId, 0, ConfigBossRushTaskConfigByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBossRushTaskConfigByActivityId.HandleId, ConfigBossRushTaskConfigByActivityId.LogPair);
					return null;
				}
				BossRushTaskConfig rootAsBossRushTaskConfig = BossRushTaskConfig.GetRootAsBossRushTaskConfig(new ByteBuffer(item2));
				list.Add(rootAsBossRushTaskConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushTaskConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBossRushTaskConfigByActivityId.HandleId, ConfigBossRushTaskConfigByActivityId.LogPair);
			return list;
		}

		// Token: 0x04000769 RID: 1897
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x0400076A RID: 1898
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x0400076B RID: 1899
		private const string TABLE = "BossRushTaskConfig";

		// Token: 0x0400076C RID: 1900
		private const string COMMAND = "select BinData from `BossRushTaskConfig` where ActivityId=?";

		// Token: 0x0400076D RID: 1901
		private const string KEY_PREFIX = "BossRushTaskConfigByActivityId";

		// Token: 0x0400076E RID: 1902
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400076F RID: 1903
		private static int HandleId;
	}
}
