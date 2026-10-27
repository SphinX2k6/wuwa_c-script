using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000038 RID: 56
	public class ConfigAchievementGroupByCategory : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00061260 File Offset: 0x0005F460
		static ConfigAchievementGroupByCategory()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAchievementGroupByCategory.CreateStaticDefaultValue), new Action(ConfigAchievementGroupByCategory.ResetStaticDefaultValue));
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00061280 File Offset: 0x0005F480
		public static void CreateStaticDefaultValue()
		{
			ConfigAchievementGroupByCategory.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAchievementGroupByCategory.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_achievement.db"),
				new ValueTuple<string, object>("文件", "c.成就.xlsx"),
				new ValueTuple<string, object>("表名", "AchievementGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `AchievementGroup` where Category=?")
			});
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000612FF File Offset: 0x0005F4FF
		public static void ResetStaticDefaultValue()
		{
			ConfigAchievementGroupByCategory.LogPair = null;
			ConfigAchievementGroupByCategory.HandleId = 0;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0006130D File Offset: 0x0005F50D
		public static void Init()
		{
			ConfigAchievementGroupByCategory.HandleId = ConfigCommon.InitDataStatement(ConfigAchievementGroupByCategory.HandleId, "db_achievement.db", "select BinData from `AchievementGroup` where Category=?");
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00061328 File Offset: 0x0005F528
		[NullableContext(2)]
		public static IReadOnlyList<AchievementGroup> GetConfigList(int p0Category, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAchievementGroupByCategory.HandleId, ConfigAchievementGroupByCategory.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AchievementGroupByCategory");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Category);
				IReadOnlyList<AchievementGroup> readOnlyList = (IReadOnlyList<AchievementGroup>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAchievementGroupByCategory.LogPair.Clear();
			ConfigAchievementGroupByCategory.LogPair.Add(new ValueTuple<string, object>("Category", p0Category));
			if (!ConfigCommon.BindInt(ConfigAchievementGroupByCategory.HandleId, 1, p0Category, ConfigAchievementGroupByCategory.LogPair))
			{
				ConfigCommon.Reset(ConfigAchievementGroupByCategory.HandleId, ConfigAchievementGroupByCategory.LogPair);
				return null;
			}
			List<AchievementGroup> list = new List<AchievementGroup>();
			while (ConfigCommon.Step(ConfigAchievementGroupByCategory.HandleId, false, ConfigAchievementGroupByCategory.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAchievementGroupByCategory.HandleId, 0, ConfigAchievementGroupByCategory.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAchievementGroupByCategory.HandleId, ConfigAchievementGroupByCategory.LogPair);
					return null;
				}
				AchievementGroup rootAsAchievementGroup = AchievementGroup.GetRootAsAchievementGroup(new ByteBuffer(item2));
				list.Add(rootAsAchievementGroup);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AchievementGroupByCategory");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Category);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAchievementGroupByCategory.HandleId, ConfigAchievementGroupByCategory.LogPair);
			return list;
		}

		// Token: 0x0400016C RID: 364
		private const string DB = "db_achievement.db";

		// Token: 0x0400016D RID: 365
		private const string FILE = "c.成就.xlsx";

		// Token: 0x0400016E RID: 366
		private const string TABLE = "AchievementGroup";

		// Token: 0x0400016F RID: 367
		private const string COMMAND = "select BinData from `AchievementGroup` where Category=?";

		// Token: 0x04000170 RID: 368
		private const string KEY_PREFIX = "AchievementGroupByCategory";

		// Token: 0x04000171 RID: 369
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000172 RID: 370
		private static int HandleId;
	}
}
