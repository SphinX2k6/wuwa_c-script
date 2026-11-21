using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000120 RID: 288
	public class ConfigBossRushScoreById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x0008366B File Offset: 0x0008186B
		static ConfigBossRushScoreById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushScoreById.CreateStaticDefaultValue), new Action(ConfigBossRushScoreById.ResetStaticDefaultValue));
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0008368C File Offset: 0x0008188C
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushScoreById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushScoreById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushScore"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushScore` where Id=?")
			});
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0008370B File Offset: 0x0008190B
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushScoreById.LogPair = null;
			ConfigBossRushScoreById.HandleId = 0;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00083719 File Offset: 0x00081919
		public static void Init()
		{
			ConfigBossRushScoreById.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushScoreById.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushScore` where Id=?");
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00083734 File Offset: 0x00081934
		public static BossRushScore? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushScoreById.HandleId, ConfigBossRushScoreById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushScoreById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BossRushScore?(BossRushScore.GetRootAsBossRushScore(configBuffer));
				}
			}
			ConfigBossRushScoreById.LogPair.Clear();
			ConfigBossRushScoreById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBossRushScoreById.HandleId, 1, p0Id, ConfigBossRushScoreById.LogPair) || ConfigCommon.Step(ConfigBossRushScoreById.HandleId, true, ConfigBossRushScoreById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBossRushScoreById.HandleId, ConfigBossRushScoreById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushScoreById.HandleId, 0, ConfigBossRushScoreById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBossRushScoreById.HandleId, ConfigBossRushScoreById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BossRushScore rootAsBossRushScore = BossRushScore.GetRootAsBossRushScore(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushScoreById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBossRushScoreById.HandleId, ConfigBossRushScoreById.LogPair);
			return new BossRushScore?(rootAsBossRushScore);
		}

		// Token: 0x040007C4 RID: 1988
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x040007C5 RID: 1989
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x040007C6 RID: 1990
		private const string TABLE = "BossRushScore";

		// Token: 0x040007C7 RID: 1991
		private const string COMMAND = "select BinData from `BossRushScore` where Id=?";

		// Token: 0x040007C8 RID: 1992
		private const string KEY_PREFIX = "BossRushScoreById";

		// Token: 0x040007C9 RID: 1993
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007CA RID: 1994
		private static int HandleId;
	}
}
