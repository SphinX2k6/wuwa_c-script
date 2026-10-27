using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000109 RID: 265
	public class ConfigBossRushActivityByActivityIdAndInstanceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000637 RID: 1591 RVA: 0x0007CC9B File Offset: 0x0007AE9B
		static ConfigBossRushActivityByActivityIdAndInstanceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushActivityByActivityIdAndInstanceId.CreateStaticDefaultValue), new Action(ConfigBossRushActivityByActivityIdAndInstanceId.ResetStaticDefaultValue));
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0007CCBC File Offset: 0x0007AEBC
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushActivityByActivityIdAndInstanceId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushActivityByActivityIdAndInstanceId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushActivity` where ActivityId=? And InstId=?")
			});
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0007CD3B File Offset: 0x0007AF3B
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushActivityByActivityIdAndInstanceId.LogPair = null;
			ConfigBossRushActivityByActivityIdAndInstanceId.HandleId = 0;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0007CD49 File Offset: 0x0007AF49
		public static void Init()
		{
			ConfigBossRushActivityByActivityIdAndInstanceId.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushActivityByActivityIdAndInstanceId.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushActivity` where ActivityId=? And InstId=?");
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0007CD64 File Offset: 0x0007AF64
		[NullableContext(2)]
		public static IReadOnlyList<BossRushActivity> GetConfigList(int p0ActivityId, int p1InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushActivityByActivityIdAndInstanceId.HandleId, ConfigBossRushActivityByActivityIdAndInstanceId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushActivityByActivityIdAndInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InstId);
				IReadOnlyList<BossRushActivity> readOnlyList = (IReadOnlyList<BossRushActivity>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBossRushActivityByActivityIdAndInstanceId.LogPair.Clear();
			ConfigBossRushActivityByActivityIdAndInstanceId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigBossRushActivityByActivityIdAndInstanceId.LogPair.Add(new ValueTuple<string, object>("InstId", p1InstId));
			if (!ConfigCommon.BindInt(ConfigBossRushActivityByActivityIdAndInstanceId.HandleId, 1, p0ActivityId, ConfigBossRushActivityByActivityIdAndInstanceId.LogPair) || !ConfigCommon.BindInt(ConfigBossRushActivityByActivityIdAndInstanceId.HandleId, 2, p1InstId, ConfigBossRushActivityByActivityIdAndInstanceId.LogPair))
			{
				ConfigCommon.Reset(ConfigBossRushActivityByActivityIdAndInstanceId.HandleId, ConfigBossRushActivityByActivityIdAndInstanceId.LogPair);
				return null;
			}
			List<BossRushActivity> list = new List<BossRushActivity>();
			while (ConfigCommon.Step(ConfigBossRushActivityByActivityIdAndInstanceId.HandleId, false, ConfigBossRushActivityByActivityIdAndInstanceId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushActivityByActivityIdAndInstanceId.HandleId, 0, ConfigBossRushActivityByActivityIdAndInstanceId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBossRushActivityByActivityIdAndInstanceId.HandleId, ConfigBossRushActivityByActivityIdAndInstanceId.LogPair);
					return null;
				}
				BossRushActivity rootAsBossRushActivity = BossRushActivity.GetRootAsBossRushActivity(new ByteBuffer(item2));
				list.Add(rootAsBossRushActivity);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushActivityByActivityIdAndInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InstId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBossRushActivityByActivityIdAndInstanceId.HandleId, ConfigBossRushActivityByActivityIdAndInstanceId.LogPair);
			return list;
		}

		// Token: 0x04000723 RID: 1827
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x04000724 RID: 1828
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x04000725 RID: 1829
		private const string TABLE = "BossRushActivity";

		// Token: 0x04000726 RID: 1830
		private const string COMMAND = "select BinData from `BossRushActivity` where ActivityId=? And InstId=?";

		// Token: 0x04000727 RID: 1831
		private const string KEY_PREFIX = "BossRushActivityByActivityIdAndInstanceId";

		// Token: 0x04000728 RID: 1832
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000729 RID: 1833
		private static int HandleId;
	}
}
