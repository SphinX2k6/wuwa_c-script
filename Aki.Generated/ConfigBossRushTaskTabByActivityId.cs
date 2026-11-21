using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000125 RID: 293
	public class ConfigBossRushTaskTabByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x0008405B File Offset: 0x0008225B
		static ConfigBossRushTaskTabByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushTaskTabByActivityId.CreateStaticDefaultValue), new Action(ConfigBossRushTaskTabByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0008407C File Offset: 0x0008227C
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushTaskTabByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushTaskTabByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushTaskTab"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushTaskTab` where ActivityId=?")
			});
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000840FB File Offset: 0x000822FB
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushTaskTabByActivityId.LogPair = null;
			ConfigBossRushTaskTabByActivityId.HandleId = 0;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00084109 File Offset: 0x00082309
		public static void Init()
		{
			ConfigBossRushTaskTabByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushTaskTabByActivityId.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushTaskTab` where ActivityId=?");
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00084124 File Offset: 0x00082324
		[NullableContext(2)]
		public static IReadOnlyList<BossRushTaskTab> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushTaskTabByActivityId.HandleId, ConfigBossRushTaskTabByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushTaskTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<BossRushTaskTab> readOnlyList = (IReadOnlyList<BossRushTaskTab>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBossRushTaskTabByActivityId.LogPair.Clear();
			ConfigBossRushTaskTabByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigBossRushTaskTabByActivityId.HandleId, 1, p0ActivityId, ConfigBossRushTaskTabByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigBossRushTaskTabByActivityId.HandleId, ConfigBossRushTaskTabByActivityId.LogPair);
				return null;
			}
			List<BossRushTaskTab> list = new List<BossRushTaskTab>();
			while (ConfigCommon.Step(ConfigBossRushTaskTabByActivityId.HandleId, false, ConfigBossRushTaskTabByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushTaskTabByActivityId.HandleId, 0, ConfigBossRushTaskTabByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBossRushTaskTabByActivityId.HandleId, ConfigBossRushTaskTabByActivityId.LogPair);
					return null;
				}
				BossRushTaskTab rootAsBossRushTaskTab = BossRushTaskTab.GetRootAsBossRushTaskTab(new ByteBuffer(item2));
				list.Add(rootAsBossRushTaskTab);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushTaskTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBossRushTaskTabByActivityId.HandleId, ConfigBossRushTaskTabByActivityId.LogPair);
			return list;
		}

		// Token: 0x040007E7 RID: 2023
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x040007E8 RID: 2024
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x040007E9 RID: 2025
		private const string TABLE = "BossRushTaskTab";

		// Token: 0x040007EA RID: 2026
		private const string COMMAND = "select BinData from `BossRushTaskTab` where ActivityId=?";

		// Token: 0x040007EB RID: 2027
		private const string KEY_PREFIX = "BossRushTaskTabByActivityId";

		// Token: 0x040007EC RID: 2028
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007ED RID: 2029
		private static int HandleId;
	}
}
