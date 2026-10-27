using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200010F RID: 271
	public class ConfigBossRushMapMarkByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x0007D92C File Offset: 0x0007BB2C
		static ConfigBossRushMapMarkByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushMapMarkByActivityId.CreateStaticDefaultValue), new Action(ConfigBossRushMapMarkByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0007D94C File Offset: 0x0007BB4C
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushMapMarkByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushMapMarkByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushMapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushMapMark` where ActivityId=?")
			});
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0007D9CB File Offset: 0x0007BBCB
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushMapMarkByActivityId.LogPair = null;
			ConfigBossRushMapMarkByActivityId.HandleId = 0;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0007D9D9 File Offset: 0x0007BBD9
		public static void Init()
		{
			ConfigBossRushMapMarkByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushMapMarkByActivityId.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushMapMark` where ActivityId=?");
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0007D9F4 File Offset: 0x0007BBF4
		public static BossRushMapMark? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushMapMarkByActivityId.HandleId, ConfigBossRushMapMarkByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushMapMarkByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BossRushMapMark?(BossRushMapMark.GetRootAsBossRushMapMark(configBuffer));
				}
			}
			ConfigBossRushMapMarkByActivityId.LogPair.Clear();
			ConfigBossRushMapMarkByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigBossRushMapMarkByActivityId.HandleId, 1, p0ActivityId, ConfigBossRushMapMarkByActivityId.LogPair) || ConfigCommon.Step(ConfigBossRushMapMarkByActivityId.HandleId, true, ConfigBossRushMapMarkByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBossRushMapMarkByActivityId.HandleId, ConfigBossRushMapMarkByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushMapMarkByActivityId.HandleId, 0, ConfigBossRushMapMarkByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBossRushMapMarkByActivityId.HandleId, ConfigBossRushMapMarkByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BossRushMapMark rootAsBossRushMapMark = BossRushMapMark.GetRootAsBossRushMapMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushMapMarkByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBossRushMapMarkByActivityId.HandleId, ConfigBossRushMapMarkByActivityId.LogPair);
			return new BossRushMapMark?(rootAsBossRushMapMark);
		}

		// Token: 0x0400074D RID: 1869
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x0400074E RID: 1870
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x0400074F RID: 1871
		private const string TABLE = "BossRushMapMark";

		// Token: 0x04000750 RID: 1872
		private const string COMMAND = "select BinData from `BossRushMapMark` where ActivityId=?";

		// Token: 0x04000751 RID: 1873
		private const string KEY_PREFIX = "BossRushMapMarkByActivityId";

		// Token: 0x04000752 RID: 1874
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000753 RID: 1875
		private static int HandleId;
	}
}
