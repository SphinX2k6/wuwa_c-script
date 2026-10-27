using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000111 RID: 273
	public class ConfigBossRushScoreById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000667 RID: 1639 RVA: 0x0007DD07 File Offset: 0x0007BF07
		static ConfigBossRushScoreById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushScoreById.CreateStaticDefaultValue), new Action(ConfigBossRushScoreById.ResetStaticDefaultValue));
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0007DD28 File Offset: 0x0007BF28
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

		// Token: 0x06000669 RID: 1641 RVA: 0x0007DDA7 File Offset: 0x0007BFA7
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushScoreById.LogPair = null;
			ConfigBossRushScoreById.HandleId = 0;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0007DDB5 File Offset: 0x0007BFB5
		public static void Init()
		{
			ConfigBossRushScoreById.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushScoreById.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushScore` where Id=?");
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0007DDD0 File Offset: 0x0007BFD0
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

		// Token: 0x0400075B RID: 1883
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x0400075C RID: 1884
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x0400075D RID: 1885
		private const string TABLE = "BossRushScore";

		// Token: 0x0400075E RID: 1886
		private const string COMMAND = "select BinData from `BossRushScore` where Id=?";

		// Token: 0x0400075F RID: 1887
		private const string KEY_PREFIX = "BossRushScoreById";

		// Token: 0x04000760 RID: 1888
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000761 RID: 1889
		private static int HandleId;
	}
}
