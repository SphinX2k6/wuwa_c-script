using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000033 RID: 51
	public class ConfigAchievementAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000132 RID: 306 RVA: 0x00060870 File Offset: 0x0005EA70
		static ConfigAchievementAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAchievementAll.CreateStaticDefaultValue), new Action(ConfigAchievementAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00060890 File Offset: 0x0005EA90
		public static void CreateStaticDefaultValue()
		{
			ConfigAchievementAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAchievementAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_achievement.db"),
				new ValueTuple<string, object>("文件", "c.成就.xlsx"),
				new ValueTuple<string, object>("表名", "Achievement"),
				new ValueTuple<string, object>("语句", "select BinData from `Achievement`")
			});
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0006090F File Offset: 0x0005EB0F
		public static void ResetStaticDefaultValue()
		{
			ConfigAchievementAll.LogPair = null;
			ConfigAchievementAll.HandleId = 0;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0006091D File Offset: 0x0005EB1D
		public static void Init()
		{
			ConfigAchievementAll.HandleId = ConfigCommon.InitDataStatement(ConfigAchievementAll.HandleId, "db_achievement.db", "select BinData from `Achievement`");
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00060938 File Offset: 0x0005EB38
		[NullableContext(2)]
		public static IReadOnlyList<Achievement> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAchievementAll.HandleId, ConfigAchievementAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Achievement> readOnlyList = (IReadOnlyList<Achievement>)ConfigCommon.GetConfig("AchievementAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Achievement> list = new List<Achievement>();
			while (ConfigCommon.Step(ConfigAchievementAll.HandleId, false, ConfigAchievementAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAchievementAll.HandleId, 0, ConfigAchievementAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAchievementAll.HandleId, ConfigAchievementAll.LogPair);
					return null;
				}
				Achievement rootAsAchievement = Achievement.GetRootAsAchievement(new ByteBuffer(item2));
				list.Add(rootAsAchievement);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AchievementAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAchievementAll.HandleId, ConfigAchievementAll.LogPair);
			return list;
		}

		// Token: 0x04000149 RID: 329
		private const string DB = "db_achievement.db";

		// Token: 0x0400014A RID: 330
		private const string FILE = "c.成就.xlsx";

		// Token: 0x0400014B RID: 331
		private const string TABLE = "Achievement";

		// Token: 0x0400014C RID: 332
		private const string COMMAND = "select BinData from `Achievement`";

		// Token: 0x0400014D RID: 333
		private const string KEY_PREFIX = "AchievementAll";

		// Token: 0x0400014E RID: 334
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400014F RID: 335
		private static int HandleId;
	}
}
