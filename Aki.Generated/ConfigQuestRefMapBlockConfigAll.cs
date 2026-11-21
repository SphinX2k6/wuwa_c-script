using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000795 RID: 1941
	public class ConfigQuestRefMapBlockConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D8F RID: 11663 RVA: 0x0015E380 File Offset: 0x0015C580
		static ConfigQuestRefMapBlockConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestRefMapBlockConfigAll.CreateStaticDefaultValue), new Action(ConfigQuestRefMapBlockConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x0015E3A0 File Offset: 0x0015C5A0
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestRefMapBlockConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestRefMapBlockConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questrefmapblock.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/QuestRefMapBlockConfig/QuestRefMapBlock.csv"),
				new ValueTuple<string, object>("表名", "QuestRefMapBlockConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestRefMapBlockConfig`")
			});
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x0015E41F File Offset: 0x0015C61F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestRefMapBlockConfigAll.LogPair = null;
			ConfigQuestRefMapBlockConfigAll.HandleId = 0;
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x0015E42D File Offset: 0x0015C62D
		public static void Init()
		{
			ConfigQuestRefMapBlockConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestRefMapBlockConfigAll.HandleId, "db_questrefmapblock.db", "select BinData from `QuestRefMapBlockConfig`");
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x0015E448 File Offset: 0x0015C648
		[NullableContext(2)]
		public static IReadOnlyList<QuestRefMapBlockConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestRefMapBlockConfigAll.HandleId, ConfigQuestRefMapBlockConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QuestRefMapBlockConfig> readOnlyList = (IReadOnlyList<QuestRefMapBlockConfig>)ConfigCommon.GetConfig("QuestRefMapBlockConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<QuestRefMapBlockConfig> list = new List<QuestRefMapBlockConfig>();
			while (ConfigCommon.Step(ConfigQuestRefMapBlockConfigAll.HandleId, false, ConfigQuestRefMapBlockConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestRefMapBlockConfigAll.HandleId, 0, ConfigQuestRefMapBlockConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestRefMapBlockConfigAll.HandleId, ConfigQuestRefMapBlockConfigAll.LogPair);
					return null;
				}
				QuestRefMapBlockConfig rootAsQuestRefMapBlockConfig = QuestRefMapBlockConfig.GetRootAsQuestRefMapBlockConfig(new ByteBuffer(item2));
				list.Add(rootAsQuestRefMapBlockConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QuestRefMapBlockConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestRefMapBlockConfigAll.HandleId, ConfigQuestRefMapBlockConfigAll.LogPair);
			return list;
		}

		// Token: 0x040034F9 RID: 13561
		private const string DB = "db_questrefmapblock.db";

		// Token: 0x040034FA RID: 13562
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/QuestRefMapBlock.csv";

		// Token: 0x040034FB RID: 13563
		private const string TABLE = "QuestRefMapBlockConfig";

		// Token: 0x040034FC RID: 13564
		private const string COMMAND = "select BinData from `QuestRefMapBlockConfig`";

		// Token: 0x040034FD RID: 13565
		private const string KEY_PREFIX = "QuestRefMapBlockConfigAll";

		// Token: 0x040034FE RID: 13566
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034FF RID: 13567
		private static int HandleId;
	}
}
