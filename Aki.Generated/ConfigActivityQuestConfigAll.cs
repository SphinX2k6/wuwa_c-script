using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200004F RID: 79
	public class ConfigActivityQuestConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001DA RID: 474 RVA: 0x00067B68 File Offset: 0x00065D68
		static ConfigActivityQuestConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityQuestConfigAll.CreateStaticDefaultValue), new Action(ConfigActivityQuestConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00067B88 File Offset: 0x00065D88
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityQuestConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityQuestConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityquestconfig.db"),
				new ValueTuple<string, object>("文件", "h.活动任务.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityQuestConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityQuestConfig`")
			});
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00067C07 File Offset: 0x00065E07
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityQuestConfigAll.LogPair = null;
			ConfigActivityQuestConfigAll.HandleId = 0;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00067C15 File Offset: 0x00065E15
		public static void Init()
		{
			ConfigActivityQuestConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityQuestConfigAll.HandleId, "db_activityquestconfig.db", "select BinData from `ActivityQuestConfig`");
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00067C30 File Offset: 0x00065E30
		[NullableContext(2)]
		public static IReadOnlyList<ActivityQuestConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityQuestConfigAll.HandleId, ConfigActivityQuestConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ActivityQuestConfig> readOnlyList = (IReadOnlyList<ActivityQuestConfig>)ConfigCommon.GetConfig("ActivityQuestConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ActivityQuestConfig> list = new List<ActivityQuestConfig>();
			while (ConfigCommon.Step(ConfigActivityQuestConfigAll.HandleId, false, ConfigActivityQuestConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityQuestConfigAll.HandleId, 0, ConfigActivityQuestConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivityQuestConfigAll.HandleId, ConfigActivityQuestConfigAll.LogPair);
					return null;
				}
				ActivityQuestConfig rootAsActivityQuestConfig = ActivityQuestConfig.GetRootAsActivityQuestConfig(new ByteBuffer(item2));
				list.Add(rootAsActivityQuestConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ActivityQuestConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivityQuestConfigAll.HandleId, ConfigActivityQuestConfigAll.LogPair);
			return list;
		}

		// Token: 0x0400020D RID: 525
		private const string DB = "db_activityquestconfig.db";

		// Token: 0x0400020E RID: 526
		private const string FILE = "h.活动任务.xlsx";

		// Token: 0x0400020F RID: 527
		private const string TABLE = "ActivityQuestConfig";

		// Token: 0x04000210 RID: 528
		private const string COMMAND = "select BinData from `ActivityQuestConfig`";

		// Token: 0x04000211 RID: 529
		private const string KEY_PREFIX = "ActivityQuestConfigAll";

		// Token: 0x04000212 RID: 530
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000213 RID: 531
		private static int HandleId;
	}
}
