using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000047 RID: 71
	public class ConfigActivityQuestConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001AA RID: 426 RVA: 0x000632B4 File Offset: 0x000614B4
		static ConfigActivityQuestConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityQuestConfigAll.CreateStaticDefaultValue), new Action(ConfigActivityQuestConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000632D4 File Offset: 0x000614D4
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

		// Token: 0x060001AC RID: 428 RVA: 0x00063353 File Offset: 0x00061553
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityQuestConfigAll.LogPair = null;
			ConfigActivityQuestConfigAll.HandleId = 0;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00063361 File Offset: 0x00061561
		public static void Init()
		{
			ConfigActivityQuestConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityQuestConfigAll.HandleId, "db_activityquestconfig.db", "select BinData from `ActivityQuestConfig`");
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0006337C File Offset: 0x0006157C
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

		// Token: 0x040001D5 RID: 469
		private const string DB = "db_activityquestconfig.db";

		// Token: 0x040001D6 RID: 470
		private const string FILE = "h.活动任务.xlsx";

		// Token: 0x040001D7 RID: 471
		private const string TABLE = "ActivityQuestConfig";

		// Token: 0x040001D8 RID: 472
		private const string COMMAND = "select BinData from `ActivityQuestConfig`";

		// Token: 0x040001D9 RID: 473
		private const string KEY_PREFIX = "ActivityQuestConfigAll";

		// Token: 0x040001DA RID: 474
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001DB RID: 475
		private static int HandleId;
	}
}
