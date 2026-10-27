using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000036 RID: 54
	public class ConfigAchievementCategoryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000144 RID: 324 RVA: 0x00060E84 File Offset: 0x0005F084
		static ConfigAchievementCategoryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAchievementCategoryAll.CreateStaticDefaultValue), new Action(ConfigAchievementCategoryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00060EA4 File Offset: 0x0005F0A4
		public static void CreateStaticDefaultValue()
		{
			ConfigAchievementCategoryAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAchievementCategoryAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_achievement.db"),
				new ValueTuple<string, object>("文件", "c.成就.xlsx"),
				new ValueTuple<string, object>("表名", "AchievementCategory"),
				new ValueTuple<string, object>("语句", "select BinData from `AchievementCategory`")
			});
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00060F23 File Offset: 0x0005F123
		public static void ResetStaticDefaultValue()
		{
			ConfigAchievementCategoryAll.LogPair = null;
			ConfigAchievementCategoryAll.HandleId = 0;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00060F31 File Offset: 0x0005F131
		public static void Init()
		{
			ConfigAchievementCategoryAll.HandleId = ConfigCommon.InitDataStatement(ConfigAchievementCategoryAll.HandleId, "db_achievement.db", "select BinData from `AchievementCategory`");
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00060F4C File Offset: 0x0005F14C
		[NullableContext(2)]
		public static IReadOnlyList<AchievementCategory> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAchievementCategoryAll.HandleId, ConfigAchievementCategoryAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AchievementCategory> readOnlyList = (IReadOnlyList<AchievementCategory>)ConfigCommon.GetConfig("AchievementCategoryAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AchievementCategory> list = new List<AchievementCategory>();
			while (ConfigCommon.Step(ConfigAchievementCategoryAll.HandleId, false, ConfigAchievementCategoryAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAchievementCategoryAll.HandleId, 0, ConfigAchievementCategoryAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAchievementCategoryAll.HandleId, ConfigAchievementCategoryAll.LogPair);
					return null;
				}
				AchievementCategory rootAsAchievementCategory = AchievementCategory.GetRootAsAchievementCategory(new ByteBuffer(item2));
				list.Add(rootAsAchievementCategory);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AchievementCategoryAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAchievementCategoryAll.HandleId, ConfigAchievementCategoryAll.LogPair);
			return list;
		}

		// Token: 0x0400015E RID: 350
		private const string DB = "db_achievement.db";

		// Token: 0x0400015F RID: 351
		private const string FILE = "c.成就.xlsx";

		// Token: 0x04000160 RID: 352
		private const string TABLE = "AchievementCategory";

		// Token: 0x04000161 RID: 353
		private const string COMMAND = "select BinData from `AchievementCategory`";

		// Token: 0x04000162 RID: 354
		private const string KEY_PREFIX = "AchievementCategoryAll";

		// Token: 0x04000163 RID: 355
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000164 RID: 356
		private static int HandleId;
	}
}
