using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200077D RID: 1917
	public class ConfigQuestRefVideoConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CFF RID: 11519 RVA: 0x00157850 File Offset: 0x00155A50
		static ConfigQuestRefVideoConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestRefVideoConfigAll.CreateStaticDefaultValue), new Action(ConfigQuestRefVideoConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x00157870 File Offset: 0x00155A70
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestRefVideoConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestRefVideoConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questrefvideo.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/QuestRefVideoConfig/任务视频资源映射_Json_QuestRefMp4Config.csv"),
				new ValueTuple<string, object>("表名", "QuestRefVideoConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestRefVideoConfig`")
			});
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x001578EF File Offset: 0x00155AEF
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestRefVideoConfigAll.LogPair = null;
			ConfigQuestRefVideoConfigAll.HandleId = 0;
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x001578FD File Offset: 0x00155AFD
		public static void Init()
		{
			ConfigQuestRefVideoConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestRefVideoConfigAll.HandleId, "db_questrefvideo.db", "select BinData from `QuestRefVideoConfig`");
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x00157918 File Offset: 0x00155B18
		[NullableContext(2)]
		public static IReadOnlyList<QuestRefVideoConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestRefVideoConfigAll.HandleId, ConfigQuestRefVideoConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QuestRefVideoConfig> readOnlyList = (IReadOnlyList<QuestRefVideoConfig>)ConfigCommon.GetConfig("QuestRefVideoConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<QuestRefVideoConfig> list = new List<QuestRefVideoConfig>();
			while (ConfigCommon.Step(ConfigQuestRefVideoConfigAll.HandleId, false, ConfigQuestRefVideoConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestRefVideoConfigAll.HandleId, 0, ConfigQuestRefVideoConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestRefVideoConfigAll.HandleId, ConfigQuestRefVideoConfigAll.LogPair);
					return null;
				}
				QuestRefVideoConfig rootAsQuestRefVideoConfig = QuestRefVideoConfig.GetRootAsQuestRefVideoConfig(new ByteBuffer(item2));
				list.Add(rootAsQuestRefVideoConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QuestRefVideoConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestRefVideoConfigAll.HandleId, ConfigQuestRefVideoConfigAll.LogPair);
			return list;
		}

		// Token: 0x04003451 RID: 13393
		private const string DB = "db_questrefvideo.db";

		// Token: 0x04003452 RID: 13394
		private const string FILE = "UniverseEditor/QuestRefVideoConfig/任务视频资源映射_Json_QuestRefMp4Config.csv";

		// Token: 0x04003453 RID: 13395
		private const string TABLE = "QuestRefVideoConfig";

		// Token: 0x04003454 RID: 13396
		private const string COMMAND = "select BinData from `QuestRefVideoConfig`";

		// Token: 0x04003455 RID: 13397
		private const string KEY_PREFIX = "QuestRefVideoConfigAll";

		// Token: 0x04003456 RID: 13398
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003457 RID: 13399
		private static int HandleId;
	}
}
