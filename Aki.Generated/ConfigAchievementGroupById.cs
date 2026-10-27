using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000039 RID: 57
	public class ConfigAchievementGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000156 RID: 342 RVA: 0x00061497 File Offset: 0x0005F697
		static ConfigAchievementGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAchievementGroupById.CreateStaticDefaultValue), new Action(ConfigAchievementGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000614B8 File Offset: 0x0005F6B8
		public static void CreateStaticDefaultValue()
		{
			ConfigAchievementGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAchievementGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_achievement.db"),
				new ValueTuple<string, object>("文件", "c.成就.xlsx"),
				new ValueTuple<string, object>("表名", "AchievementGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `AchievementGroup` where Id=?")
			});
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00061537 File Offset: 0x0005F737
		public static void ResetStaticDefaultValue()
		{
			ConfigAchievementGroupById.LogPair = null;
			ConfigAchievementGroupById.HandleId = 0;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00061545 File Offset: 0x0005F745
		public static void Init()
		{
			ConfigAchievementGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigAchievementGroupById.HandleId, "db_achievement.db", "select BinData from `AchievementGroup` where Id=?");
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00061560 File Offset: 0x0005F760
		public static AchievementGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAchievementGroupById.HandleId, ConfigAchievementGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AchievementGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AchievementGroup?(AchievementGroup.GetRootAsAchievementGroup(configBuffer));
				}
			}
			ConfigAchievementGroupById.LogPair.Clear();
			ConfigAchievementGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAchievementGroupById.HandleId, 1, p0Id, ConfigAchievementGroupById.LogPair) || ConfigCommon.Step(ConfigAchievementGroupById.HandleId, true, ConfigAchievementGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAchievementGroupById.HandleId, ConfigAchievementGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAchievementGroupById.HandleId, 0, ConfigAchievementGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAchievementGroupById.HandleId, ConfigAchievementGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AchievementGroup rootAsAchievementGroup = AchievementGroup.GetRootAsAchievementGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AchievementGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAchievementGroupById.HandleId, ConfigAchievementGroupById.LogPair);
			return new AchievementGroup?(rootAsAchievementGroup);
		}

		// Token: 0x04000173 RID: 371
		private const string DB = "db_achievement.db";

		// Token: 0x04000174 RID: 372
		private const string FILE = "c.成就.xlsx";

		// Token: 0x04000175 RID: 373
		private const string TABLE = "AchievementGroup";

		// Token: 0x04000176 RID: 374
		private const string COMMAND = "select BinData from `AchievementGroup` where Id=?";

		// Token: 0x04000177 RID: 375
		private const string KEY_PREFIX = "AchievementGroupById";

		// Token: 0x04000178 RID: 376
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000179 RID: 377
		private static int HandleId;
	}
}
