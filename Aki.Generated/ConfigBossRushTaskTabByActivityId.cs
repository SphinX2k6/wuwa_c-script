using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000116 RID: 278
	public class ConfigBossRushTaskTabByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000685 RID: 1669 RVA: 0x0007E6F7 File Offset: 0x0007C8F7
		static ConfigBossRushTaskTabByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushTaskTabByActivityId.CreateStaticDefaultValue), new Action(ConfigBossRushTaskTabByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0007E718 File Offset: 0x0007C918
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

		// Token: 0x06000687 RID: 1671 RVA: 0x0007E797 File Offset: 0x0007C997
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushTaskTabByActivityId.LogPair = null;
			ConfigBossRushTaskTabByActivityId.HandleId = 0;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0007E7A5 File Offset: 0x0007C9A5
		public static void Init()
		{
			ConfigBossRushTaskTabByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushTaskTabByActivityId.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushTaskTab` where ActivityId=?");
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0007E7C0 File Offset: 0x0007C9C0
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

		// Token: 0x0400077E RID: 1918
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x0400077F RID: 1919
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x04000780 RID: 1920
		private const string TABLE = "BossRushTaskTab";

		// Token: 0x04000781 RID: 1921
		private const string COMMAND = "select BinData from `BossRushTaskTab` where ActivityId=?";

		// Token: 0x04000782 RID: 1922
		private const string KEY_PREFIX = "BossRushTaskTabByActivityId";

		// Token: 0x04000783 RID: 1923
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000784 RID: 1924
		private static int HandleId;
	}
}
