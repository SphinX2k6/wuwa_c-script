using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200010A RID: 266
	public class ConfigBossRushActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600063D RID: 1597 RVA: 0x0007CF2B File Offset: 0x0007B12B
		static ConfigBossRushActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushActivityById.CreateStaticDefaultValue), new Action(ConfigBossRushActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0007CF4C File Offset: 0x0007B14C
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushActivity` where Id=?")
			});
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0007CFCB File Offset: 0x0007B1CB
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushActivityById.LogPair = null;
			ConfigBossRushActivityById.HandleId = 0;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0007CFD9 File Offset: 0x0007B1D9
		public static void Init()
		{
			ConfigBossRushActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushActivityById.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushActivity` where Id=?");
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0007CFF4 File Offset: 0x0007B1F4
		public static BossRushActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushActivityById.HandleId, ConfigBossRushActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BossRushActivity?(BossRushActivity.GetRootAsBossRushActivity(configBuffer));
				}
			}
			ConfigBossRushActivityById.LogPair.Clear();
			ConfigBossRushActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBossRushActivityById.HandleId, 1, p0Id, ConfigBossRushActivityById.LogPair) || ConfigCommon.Step(ConfigBossRushActivityById.HandleId, true, ConfigBossRushActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBossRushActivityById.HandleId, ConfigBossRushActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushActivityById.HandleId, 0, ConfigBossRushActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBossRushActivityById.HandleId, ConfigBossRushActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BossRushActivity rootAsBossRushActivity = BossRushActivity.GetRootAsBossRushActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBossRushActivityById.HandleId, ConfigBossRushActivityById.LogPair);
			return new BossRushActivity?(rootAsBossRushActivity);
		}

		// Token: 0x0400072A RID: 1834
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x0400072B RID: 1835
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x0400072C RID: 1836
		private const string TABLE = "BossRushActivity";

		// Token: 0x0400072D RID: 1837
		private const string COMMAND = "select BinData from `BossRushActivity` where Id=?";

		// Token: 0x0400072E RID: 1838
		private const string KEY_PREFIX = "BossRushActivityById";

		// Token: 0x0400072F RID: 1839
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000730 RID: 1840
		private static int HandleId;
	}
}
