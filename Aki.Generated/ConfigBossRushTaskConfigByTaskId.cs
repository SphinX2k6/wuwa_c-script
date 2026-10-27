using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000114 RID: 276
	public class ConfigBossRushTaskConfigByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000679 RID: 1657 RVA: 0x0007E31B File Offset: 0x0007C51B
		static ConfigBossRushTaskConfigByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushTaskConfigByTaskId.CreateStaticDefaultValue), new Action(ConfigBossRushTaskConfigByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0007E33C File Offset: 0x0007C53C
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushTaskConfigByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushTaskConfigByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushTaskConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushTaskConfig` where TaskId=?")
			});
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0007E3BB File Offset: 0x0007C5BB
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushTaskConfigByTaskId.LogPair = null;
			ConfigBossRushTaskConfigByTaskId.HandleId = 0;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0007E3C9 File Offset: 0x0007C5C9
		public static void Init()
		{
			ConfigBossRushTaskConfigByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushTaskConfigByTaskId.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushTaskConfig` where TaskId=?");
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0007E3E4 File Offset: 0x0007C5E4
		public static BossRushTaskConfig? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushTaskConfigByTaskId.HandleId, ConfigBossRushTaskConfigByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushTaskConfigByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BossRushTaskConfig?(BossRushTaskConfig.GetRootAsBossRushTaskConfig(configBuffer));
				}
			}
			ConfigBossRushTaskConfigByTaskId.LogPair.Clear();
			ConfigBossRushTaskConfigByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigBossRushTaskConfigByTaskId.HandleId, 1, p0TaskId, ConfigBossRushTaskConfigByTaskId.LogPair) || ConfigCommon.Step(ConfigBossRushTaskConfigByTaskId.HandleId, true, ConfigBossRushTaskConfigByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBossRushTaskConfigByTaskId.HandleId, ConfigBossRushTaskConfigByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushTaskConfigByTaskId.HandleId, 0, ConfigBossRushTaskConfigByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBossRushTaskConfigByTaskId.HandleId, ConfigBossRushTaskConfigByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BossRushTaskConfig rootAsBossRushTaskConfig = BossRushTaskConfig.GetRootAsBossRushTaskConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushTaskConfigByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBossRushTaskConfigByTaskId.HandleId, ConfigBossRushTaskConfigByTaskId.LogPair);
			return new BossRushTaskConfig?(rootAsBossRushTaskConfig);
		}

		// Token: 0x04000770 RID: 1904
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x04000771 RID: 1905
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x04000772 RID: 1906
		private const string TABLE = "BossRushTaskConfig";

		// Token: 0x04000773 RID: 1907
		private const string COMMAND = "select BinData from `BossRushTaskConfig` where TaskId=?";

		// Token: 0x04000774 RID: 1908
		private const string KEY_PREFIX = "BossRushTaskConfigByTaskId";

		// Token: 0x04000775 RID: 1909
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000776 RID: 1910
		private static int HandleId;
	}
}
