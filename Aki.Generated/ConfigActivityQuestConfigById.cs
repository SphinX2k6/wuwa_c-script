using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000048 RID: 72
	public class ConfigActivityQuestConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x00063447 File Offset: 0x00061647
		static ConfigActivityQuestConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityQuestConfigById.CreateStaticDefaultValue), new Action(ConfigActivityQuestConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00063468 File Offset: 0x00061668
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityQuestConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityQuestConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityquestconfig.db"),
				new ValueTuple<string, object>("文件", "h.活动任务.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityQuestConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityQuestConfig` where Id=?")
			});
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000634E7 File Offset: 0x000616E7
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityQuestConfigById.LogPair = null;
			ConfigActivityQuestConfigById.HandleId = 0;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000634F5 File Offset: 0x000616F5
		public static void Init()
		{
			ConfigActivityQuestConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityQuestConfigById.HandleId, "db_activityquestconfig.db", "select BinData from `ActivityQuestConfig` where Id=?");
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00063510 File Offset: 0x00061710
		public static ActivityQuestConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityQuestConfigById.HandleId, ConfigActivityQuestConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityQuestConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityQuestConfig?(ActivityQuestConfig.GetRootAsActivityQuestConfig(configBuffer));
				}
			}
			ConfigActivityQuestConfigById.LogPair.Clear();
			ConfigActivityQuestConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityQuestConfigById.HandleId, 1, p0Id, ConfigActivityQuestConfigById.LogPair) || ConfigCommon.Step(ConfigActivityQuestConfigById.HandleId, true, ConfigActivityQuestConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityQuestConfigById.HandleId, ConfigActivityQuestConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityQuestConfigById.HandleId, 0, ConfigActivityQuestConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityQuestConfigById.HandleId, ConfigActivityQuestConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityQuestConfig rootAsActivityQuestConfig = ActivityQuestConfig.GetRootAsActivityQuestConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityQuestConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityQuestConfigById.HandleId, ConfigActivityQuestConfigById.LogPair);
			return new ActivityQuestConfig?(rootAsActivityQuestConfig);
		}

		// Token: 0x040001DC RID: 476
		private const string DB = "db_activityquestconfig.db";

		// Token: 0x040001DD RID: 477
		private const string FILE = "h.活动任务.xlsx";

		// Token: 0x040001DE RID: 478
		private const string TABLE = "ActivityQuestConfig";

		// Token: 0x040001DF RID: 479
		private const string COMMAND = "select BinData from `ActivityQuestConfig` where Id=?";

		// Token: 0x040001E0 RID: 480
		private const string KEY_PREFIX = "ActivityQuestConfigById";

		// Token: 0x040001E1 RID: 481
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001E2 RID: 482
		private static int HandleId;
	}
}
