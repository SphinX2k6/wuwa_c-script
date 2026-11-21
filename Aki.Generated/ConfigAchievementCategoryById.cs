using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000037 RID: 55
	public class ConfigAchievementCategoryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600014A RID: 330 RVA: 0x000648B7 File Offset: 0x00062AB7
		static ConfigAchievementCategoryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAchievementCategoryById.CreateStaticDefaultValue), new Action(ConfigAchievementCategoryById.ResetStaticDefaultValue));
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000648D8 File Offset: 0x00062AD8
		public static void CreateStaticDefaultValue()
		{
			ConfigAchievementCategoryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAchievementCategoryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_achievement.db"),
				new ValueTuple<string, object>("文件", "c.成就.xlsx"),
				new ValueTuple<string, object>("表名", "AchievementCategory"),
				new ValueTuple<string, object>("语句", "select BinData from `AchievementCategory` where Id=?")
			});
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00064957 File Offset: 0x00062B57
		public static void ResetStaticDefaultValue()
		{
			ConfigAchievementCategoryById.LogPair = null;
			ConfigAchievementCategoryById.HandleId = 0;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00064965 File Offset: 0x00062B65
		public static void Init()
		{
			ConfigAchievementCategoryById.HandleId = ConfigCommon.InitDataStatement(ConfigAchievementCategoryById.HandleId, "db_achievement.db", "select BinData from `AchievementCategory` where Id=?");
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00064980 File Offset: 0x00062B80
		public static AchievementCategory? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAchievementCategoryById.HandleId, ConfigAchievementCategoryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AchievementCategoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AchievementCategory?(AchievementCategory.GetRootAsAchievementCategory(configBuffer));
				}
			}
			ConfigAchievementCategoryById.LogPair.Clear();
			ConfigAchievementCategoryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAchievementCategoryById.HandleId, 1, p0Id, ConfigAchievementCategoryById.LogPair) || ConfigCommon.Step(ConfigAchievementCategoryById.HandleId, true, ConfigAchievementCategoryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAchievementCategoryById.HandleId, ConfigAchievementCategoryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAchievementCategoryById.HandleId, 0, ConfigAchievementCategoryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAchievementCategoryById.HandleId, ConfigAchievementCategoryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AchievementCategory rootAsAchievementCategory = AchievementCategory.GetRootAsAchievementCategory(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AchievementCategoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAchievementCategoryById.HandleId, ConfigAchievementCategoryById.LogPair);
			return new AchievementCategory?(rootAsAchievementCategory);
		}

		// Token: 0x04000165 RID: 357
		private const string DB = "db_achievement.db";

		// Token: 0x04000166 RID: 358
		private const string FILE = "c.成就.xlsx";

		// Token: 0x04000167 RID: 359
		private const string TABLE = "AchievementCategory";

		// Token: 0x04000168 RID: 360
		private const string COMMAND = "select BinData from `AchievementCategory` where Id=?";

		// Token: 0x04000169 RID: 361
		private const string KEY_PREFIX = "AchievementCategoryById";

		// Token: 0x0400016A RID: 362
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400016B RID: 363
		private static int HandleId;
	}
}
