using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000034 RID: 52
	public class ConfigAchievementByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00060A03 File Offset: 0x0005EC03
		static ConfigAchievementByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAchievementByGroupId.CreateStaticDefaultValue), new Action(ConfigAchievementByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00060A24 File Offset: 0x0005EC24
		public static void CreateStaticDefaultValue()
		{
			ConfigAchievementByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAchievementByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_achievement.db"),
				new ValueTuple<string, object>("文件", "c.成就.xlsx"),
				new ValueTuple<string, object>("表名", "Achievement"),
				new ValueTuple<string, object>("语句", "select BinData from `Achievement` where GroupId=?")
			});
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00060AA3 File Offset: 0x0005ECA3
		public static void ResetStaticDefaultValue()
		{
			ConfigAchievementByGroupId.LogPair = null;
			ConfigAchievementByGroupId.HandleId = 0;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00060AB1 File Offset: 0x0005ECB1
		public static void Init()
		{
			ConfigAchievementByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigAchievementByGroupId.HandleId, "db_achievement.db", "select BinData from `Achievement` where GroupId=?");
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00060ACC File Offset: 0x0005ECCC
		[NullableContext(2)]
		public static IReadOnlyList<Achievement> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAchievementByGroupId.HandleId, ConfigAchievementByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AchievementByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<Achievement> readOnlyList = (IReadOnlyList<Achievement>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAchievementByGroupId.LogPair.Clear();
			ConfigAchievementByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigAchievementByGroupId.HandleId, 1, p0GroupId, ConfigAchievementByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigAchievementByGroupId.HandleId, ConfigAchievementByGroupId.LogPair);
				return null;
			}
			List<Achievement> list = new List<Achievement>();
			while (ConfigCommon.Step(ConfigAchievementByGroupId.HandleId, false, ConfigAchievementByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAchievementByGroupId.HandleId, 0, ConfigAchievementByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAchievementByGroupId.HandleId, ConfigAchievementByGroupId.LogPair);
					return null;
				}
				Achievement rootAsAchievement = Achievement.GetRootAsAchievement(new ByteBuffer(item2));
				list.Add(rootAsAchievement);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AchievementByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAchievementByGroupId.HandleId, ConfigAchievementByGroupId.LogPair);
			return list;
		}

		// Token: 0x04000150 RID: 336
		private const string DB = "db_achievement.db";

		// Token: 0x04000151 RID: 337
		private const string FILE = "c.成就.xlsx";

		// Token: 0x04000152 RID: 338
		private const string TABLE = "Achievement";

		// Token: 0x04000153 RID: 339
		private const string COMMAND = "select BinData from `Achievement` where GroupId=?";

		// Token: 0x04000154 RID: 340
		private const string KEY_PREFIX = "AchievementByGroupId";

		// Token: 0x04000155 RID: 341
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000156 RID: 342
		private static int HandleId;
	}
}
