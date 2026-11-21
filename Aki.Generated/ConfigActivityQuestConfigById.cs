using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000050 RID: 80
	public class ConfigActivityQuestConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x00067CFB File Offset: 0x00065EFB
		static ConfigActivityQuestConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityQuestConfigById.CreateStaticDefaultValue), new Action(ConfigActivityQuestConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00067D1C File Offset: 0x00065F1C
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

		// Token: 0x060001E2 RID: 482 RVA: 0x00067D9B File Offset: 0x00065F9B
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityQuestConfigById.LogPair = null;
			ConfigActivityQuestConfigById.HandleId = 0;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00067DA9 File Offset: 0x00065FA9
		public static void Init()
		{
			ConfigActivityQuestConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityQuestConfigById.HandleId, "db_activityquestconfig.db", "select BinData from `ActivityQuestConfig` where Id=?");
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00067DC4 File Offset: 0x00065FC4
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

		// Token: 0x04000214 RID: 532
		private const string DB = "db_activityquestconfig.db";

		// Token: 0x04000215 RID: 533
		private const string FILE = "h.活动任务.xlsx";

		// Token: 0x04000216 RID: 534
		private const string TABLE = "ActivityQuestConfig";

		// Token: 0x04000217 RID: 535
		private const string COMMAND = "select BinData from `ActivityQuestConfig` where Id=?";

		// Token: 0x04000218 RID: 536
		private const string KEY_PREFIX = "ActivityQuestConfigById";

		// Token: 0x04000219 RID: 537
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400021A RID: 538
		private static int HandleId;
	}
}
