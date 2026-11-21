using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000797 RID: 1943
	public class ConfigQuestRefVideoConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D9B RID: 11675 RVA: 0x0015E75C File Offset: 0x0015C95C
		static ConfigQuestRefVideoConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestRefVideoConfigAll.CreateStaticDefaultValue), new Action(ConfigQuestRefVideoConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x0015E77C File Offset: 0x0015C97C
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

		// Token: 0x06002D9D RID: 11677 RVA: 0x0015E7FB File Offset: 0x0015C9FB
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestRefVideoConfigAll.LogPair = null;
			ConfigQuestRefVideoConfigAll.HandleId = 0;
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x0015E809 File Offset: 0x0015CA09
		public static void Init()
		{
			ConfigQuestRefVideoConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestRefVideoConfigAll.HandleId, "db_questrefvideo.db", "select BinData from `QuestRefVideoConfig`");
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x0015E824 File Offset: 0x0015CA24
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

		// Token: 0x04003507 RID: 13575
		private const string DB = "db_questrefvideo.db";

		// Token: 0x04003508 RID: 13576
		private const string FILE = "UniverseEditor/QuestRefVideoConfig/任务视频资源映射_Json_QuestRefMp4Config.csv";

		// Token: 0x04003509 RID: 13577
		private const string TABLE = "QuestRefVideoConfig";

		// Token: 0x0400350A RID: 13578
		private const string COMMAND = "select BinData from `QuestRefVideoConfig`";

		// Token: 0x0400350B RID: 13579
		private const string KEY_PREFIX = "QuestRefVideoConfigAll";

		// Token: 0x0400350C RID: 13580
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400350D RID: 13581
		private static int HandleId;
	}
}
