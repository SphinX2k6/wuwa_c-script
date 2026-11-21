using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000051 RID: 81
	public class ConfigActivityQuestConfigByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x00067F44 File Offset: 0x00066144
		static ConfigActivityQuestConfigByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityQuestConfigByQuestId.CreateStaticDefaultValue), new Action(ConfigActivityQuestConfigByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00067F64 File Offset: 0x00066164
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

		// Token: 0x060001E8 RID: 488 RVA: 0x00067FE3 File Offset: 0x000661E3
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityQuestConfigByQuestId.LogPair = null;
			ConfigActivityQuestConfigByQuestId.HandleId = 0;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00067FF1 File Offset: 0x000661F1
		public static void Init()
		{
			ConfigActivityQuestConfigByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigActivityQuestConfigByQuestId.HandleId, "db_activityquestconfig.db", "select BinData from `ActivityQuestConfig` where QuestId=?");
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0006800C File Offset: 0x0006620C
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

		// Token: 0x0400021B RID: 539
		private const string DB = "db_activityquestconfig.db";

		// Token: 0x0400021C RID: 540
		private const string FILE = "h.活动任务.xlsx";

		// Token: 0x0400021D RID: 541
		private const string TABLE = "ActivityQuestConfig";

		// Token: 0x0400021E RID: 542
		private const string COMMAND = "select BinData from `ActivityQuestConfig` where QuestId=?";

		// Token: 0x0400021F RID: 543
		private const string KEY_PREFIX = "ActivityQuestConfigByQuestId";

		// Token: 0x04000220 RID: 544
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000221 RID: 545
		private static int HandleId;
	}
}
