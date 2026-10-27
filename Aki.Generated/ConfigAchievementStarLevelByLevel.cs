using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200003A RID: 58
	public class ConfigAchievementStarLevelByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600015C RID: 348 RVA: 0x000616E0 File Offset: 0x0005F8E0
		static ConfigAchievementStarLevelByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAchievementStarLevelByLevel.CreateStaticDefaultValue), new Action(ConfigAchievementStarLevelByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00061700 File Offset: 0x0005F900
		public static void CreateStaticDefaultValue()
		{
			ConfigAchievementStarLevelByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAchievementStarLevelByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_achievement.db"),
				new ValueTuple<string, object>("文件", "c.成就.xlsx"),
				new ValueTuple<string, object>("表名", "AchievementStarLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `AchievementStarLevel` where Level=?")
			});
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0006177F File Offset: 0x0005F97F
		public static void ResetStaticDefaultValue()
		{
			ConfigAchievementStarLevelByLevel.LogPair = null;
			ConfigAchievementStarLevelByLevel.HandleId = 0;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0006178D File Offset: 0x0005F98D
		public static void Init()
		{
			ConfigAchievementStarLevelByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigAchievementStarLevelByLevel.HandleId, "db_achievement.db", "select BinData from `AchievementStarLevel` where Level=?");
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000617A8 File Offset: 0x0005F9A8
		public static AchievementStarLevel? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAchievementStarLevelByLevel.HandleId, ConfigAchievementStarLevelByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AchievementStarLevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AchievementStarLevel?(AchievementStarLevel.GetRootAsAchievementStarLevel(configBuffer));
				}
			}
			ConfigAchievementStarLevelByLevel.LogPair.Clear();
			ConfigAchievementStarLevelByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigAchievementStarLevelByLevel.HandleId, 1, p0Level, ConfigAchievementStarLevelByLevel.LogPair) || ConfigCommon.Step(ConfigAchievementStarLevelByLevel.HandleId, true, ConfigAchievementStarLevelByLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAchievementStarLevelByLevel.HandleId, ConfigAchievementStarLevelByLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAchievementStarLevelByLevel.HandleId, 0, ConfigAchievementStarLevelByLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAchievementStarLevelByLevel.HandleId, ConfigAchievementStarLevelByLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AchievementStarLevel rootAsAchievementStarLevel = AchievementStarLevel.GetRootAsAchievementStarLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AchievementStarLevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAchievementStarLevelByLevel.HandleId, ConfigAchievementStarLevelByLevel.LogPair);
			return new AchievementStarLevel?(rootAsAchievementStarLevel);
		}

		// Token: 0x0400017A RID: 378
		private const string DB = "db_achievement.db";

		// Token: 0x0400017B RID: 379
		private const string FILE = "c.成就.xlsx";

		// Token: 0x0400017C RID: 380
		private const string TABLE = "AchievementStarLevel";

		// Token: 0x0400017D RID: 381
		private const string COMMAND = "select BinData from `AchievementStarLevel` where Level=?";

		// Token: 0x0400017E RID: 382
		private const string KEY_PREFIX = "AchievementStarLevelByLevel";

		// Token: 0x0400017F RID: 383
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000180 RID: 384
		private static int HandleId;
	}
}
