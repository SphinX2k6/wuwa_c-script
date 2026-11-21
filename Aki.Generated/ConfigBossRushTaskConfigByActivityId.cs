using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000122 RID: 290
	public class ConfigBossRushTaskConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006CD RID: 1741 RVA: 0x00083A47 File Offset: 0x00081C47
		static ConfigBossRushTaskConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushTaskConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigBossRushTaskConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00083A68 File Offset: 0x00081C68
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

		// Token: 0x060006CF RID: 1743 RVA: 0x00083AE7 File Offset: 0x00081CE7
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushTaskConfigByActivityId.LogPair = null;
			ConfigBossRushTaskConfigByActivityId.HandleId = 0;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00083AF5 File Offset: 0x00081CF5
		public static void Init()
		{
			ConfigBossRushTaskConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushTaskConfigByActivityId.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushTaskConfig` where ActivityId=?");
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00083B10 File Offset: 0x00081D10
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

		// Token: 0x040007D2 RID: 2002
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x040007D3 RID: 2003
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x040007D4 RID: 2004
		private const string TABLE = "BossRushTaskConfig";

		// Token: 0x040007D5 RID: 2005
		private const string COMMAND = "select BinData from `BossRushTaskConfig` where ActivityId=?";

		// Token: 0x040007D6 RID: 2006
		private const string KEY_PREFIX = "BossRushTaskConfigByActivityId";

		// Token: 0x040007D7 RID: 2007
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007D8 RID: 2008
		private static int HandleId;
	}
}
