using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000123 RID: 291
	public class ConfigBossRushTaskConfigByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006D3 RID: 1747 RVA: 0x00083C7F File Offset: 0x00081E7F
		static ConfigBossRushTaskConfigByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushTaskConfigByTaskId.CreateStaticDefaultValue), new Action(ConfigBossRushTaskConfigByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00083CA0 File Offset: 0x00081EA0
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

		// Token: 0x060006D5 RID: 1749 RVA: 0x00083D1F File Offset: 0x00081F1F
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushTaskConfigByTaskId.LogPair = null;
			ConfigBossRushTaskConfigByTaskId.HandleId = 0;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00083D2D File Offset: 0x00081F2D
		public static void Init()
		{
			ConfigBossRushTaskConfigByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushTaskConfigByTaskId.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushTaskConfig` where TaskId=?");
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00083D48 File Offset: 0x00081F48
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

		// Token: 0x040007D9 RID: 2009
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x040007DA RID: 2010
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x040007DB RID: 2011
		private const string TABLE = "BossRushTaskConfig";

		// Token: 0x040007DC RID: 2012
		private const string COMMAND = "select BinData from `BossRushTaskConfig` where TaskId=?";

		// Token: 0x040007DD RID: 2013
		private const string KEY_PREFIX = "BossRushTaskConfigByTaskId";

		// Token: 0x040007DE RID: 2014
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007DF RID: 2015
		private static int HandleId;
	}
}
