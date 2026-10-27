using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200077B RID: 1915
	public class ConfigQuestRefMapBlockConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CF3 RID: 11507 RVA: 0x00157474 File Offset: 0x00155674
		static ConfigQuestRefMapBlockConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestRefMapBlockConfigAll.CreateStaticDefaultValue), new Action(ConfigQuestRefMapBlockConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x00157494 File Offset: 0x00155694
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

		// Token: 0x06002CF5 RID: 11509 RVA: 0x00157513 File Offset: 0x00155713
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestRefMapBlockConfigAll.LogPair = null;
			ConfigQuestRefMapBlockConfigAll.HandleId = 0;
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x00157521 File Offset: 0x00155721
		public static void Init()
		{
			ConfigQuestRefMapBlockConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestRefMapBlockConfigAll.HandleId, "db_questrefmapblock.db", "select BinData from `QuestRefMapBlockConfig`");
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x0015753C File Offset: 0x0015573C
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

		// Token: 0x04003443 RID: 13379
		private const string DB = "db_questrefmapblock.db";

		// Token: 0x04003444 RID: 13380
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/QuestRefMapBlock.csv";

		// Token: 0x04003445 RID: 13381
		private const string TABLE = "QuestRefMapBlockConfig";

		// Token: 0x04003446 RID: 13382
		private const string COMMAND = "select BinData from `QuestRefMapBlockConfig`";

		// Token: 0x04003447 RID: 13383
		private const string KEY_PREFIX = "QuestRefMapBlockConfigAll";

		// Token: 0x04003448 RID: 13384
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003449 RID: 13385
		private static int HandleId;
	}
}
