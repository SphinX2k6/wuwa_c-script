using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000035 RID: 53
	public class ConfigAchievementById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600013E RID: 318 RVA: 0x00060C3B File Offset: 0x0005EE3B
		static ConfigAchievementById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAchievementById.CreateStaticDefaultValue), new Action(ConfigAchievementById.ResetStaticDefaultValue));
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00060C5C File Offset: 0x0005EE5C
		public static void CreateStaticDefaultValue()
		{
			ConfigAchievementById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAchievementById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_achievement.db"),
				new ValueTuple<string, object>("文件", "c.成就.xlsx"),
				new ValueTuple<string, object>("表名", "Achievement"),
				new ValueTuple<string, object>("语句", "select BinData from `Achievement` where Id=?")
			});
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00060CDB File Offset: 0x0005EEDB
		public static void ResetStaticDefaultValue()
		{
			ConfigAchievementById.LogPair = null;
			ConfigAchievementById.HandleId = 0;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00060CE9 File Offset: 0x0005EEE9
		public static void Init()
		{
			ConfigAchievementById.HandleId = ConfigCommon.InitDataStatement(ConfigAchievementById.HandleId, "db_achievement.db", "select BinData from `Achievement` where Id=?");
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00060D04 File Offset: 0x0005EF04
		public static Achievement? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAchievementById.HandleId, ConfigAchievementById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AchievementById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Achievement?(Achievement.GetRootAsAchievement(configBuffer));
				}
			}
			ConfigAchievementById.LogPair.Clear();
			ConfigAchievementById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAchievementById.HandleId, 1, p0Id, ConfigAchievementById.LogPair) || ConfigCommon.Step(ConfigAchievementById.HandleId, true, ConfigAchievementById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAchievementById.HandleId, ConfigAchievementById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAchievementById.HandleId, 0, ConfigAchievementById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAchievementById.HandleId, ConfigAchievementById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Achievement rootAsAchievement = Achievement.GetRootAsAchievement(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AchievementById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAchievementById.HandleId, ConfigAchievementById.LogPair);
			return new Achievement?(rootAsAchievement);
		}

		// Token: 0x04000157 RID: 343
		private const string DB = "db_achievement.db";

		// Token: 0x04000158 RID: 344
		private const string FILE = "c.成就.xlsx";

		// Token: 0x04000159 RID: 345
		private const string TABLE = "Achievement";

		// Token: 0x0400015A RID: 346
		private const string COMMAND = "select BinData from `Achievement` where Id=?";

		// Token: 0x0400015B RID: 347
		private const string KEY_PREFIX = "AchievementById";

		// Token: 0x0400015C RID: 348
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400015D RID: 349
		private static int HandleId;
	}
}
