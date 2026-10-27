using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000049 RID: 73
	public class ConfigActivityQuestConfigByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x00063690 File Offset: 0x00061890
		static ConfigActivityQuestConfigByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityQuestConfigByQuestId.CreateStaticDefaultValue), new Action(ConfigActivityQuestConfigByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000636B0 File Offset: 0x000618B0
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityQuestConfigByQuestId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityQuestConfigByQuestId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityquestconfig.db"),
				new ValueTuple<string, object>("文件", "h.活动任务.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityQuestConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityQuestConfig` where QuestId=?")
			});
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0006372F File Offset: 0x0006192F
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityQuestConfigByQuestId.LogPair = null;
			ConfigActivityQuestConfigByQuestId.HandleId = 0;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0006373D File Offset: 0x0006193D
		public static void Init()
		{
			ConfigActivityQuestConfigByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigActivityQuestConfigByQuestId.HandleId, "db_activityquestconfig.db", "select BinData from `ActivityQuestConfig` where QuestId=?");
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00063758 File Offset: 0x00061958
		public static ActivityQuestConfig? GetConfig(int p0QuestId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityQuestConfigByQuestId.HandleId, ConfigActivityQuestConfigByQuestId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityQuestConfigByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityQuestConfig?(ActivityQuestConfig.GetRootAsActivityQuestConfig(configBuffer));
				}
			}
			ConfigActivityQuestConfigByQuestId.LogPair.Clear();
			ConfigActivityQuestConfigByQuestId.LogPair.Add(new ValueTuple<string, object>("QuestId", p0QuestId));
			if (!ConfigCommon.BindInt(ConfigActivityQuestConfigByQuestId.HandleId, 1, p0QuestId, ConfigActivityQuestConfigByQuestId.LogPair) || ConfigCommon.Step(ConfigActivityQuestConfigByQuestId.HandleId, true, ConfigActivityQuestConfigByQuestId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityQuestConfigByQuestId.HandleId, ConfigActivityQuestConfigByQuestId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityQuestConfigByQuestId.HandleId, 0, ConfigActivityQuestConfigByQuestId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityQuestConfigByQuestId.HandleId, ConfigActivityQuestConfigByQuestId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityQuestConfig rootAsActivityQuestConfig = ActivityQuestConfig.GetRootAsActivityQuestConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityQuestConfigByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityQuestConfigByQuestId.HandleId, ConfigActivityQuestConfigByQuestId.LogPair);
			return new ActivityQuestConfig?(rootAsActivityQuestConfig);
		}

		// Token: 0x040001E3 RID: 483
		private const string DB = "db_activityquestconfig.db";

		// Token: 0x040001E4 RID: 484
		private const string FILE = "h.活动任务.xlsx";

		// Token: 0x040001E5 RID: 485
		private const string TABLE = "ActivityQuestConfig";

		// Token: 0x040001E6 RID: 486
		private const string COMMAND = "select BinData from `ActivityQuestConfig` where QuestId=?";

		// Token: 0x040001E7 RID: 487
		private const string KEY_PREFIX = "ActivityQuestConfigByQuestId";

		// Token: 0x040001E8 RID: 488
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001E9 RID: 489
		private static int HandleId;
	}
}
