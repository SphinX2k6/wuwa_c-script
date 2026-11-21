using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000793 RID: 1939
	public class ConfigQuestReachableBlockAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D83 RID: 11651 RVA: 0x0015DFA5 File Offset: 0x0015C1A5
		static ConfigQuestReachableBlockAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReachableBlockAll.CreateStaticDefaultValue), new Action(ConfigQuestReachableBlockAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x0015DFC4 File Offset: 0x0015C1C4
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestReachableBlockAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestReachableBlockAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questreachableblock.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/QuestRefMapBlockConfig/QuestReachableBlock.csv"),
				new ValueTuple<string, object>("表名", "QuestReachableBlock"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestReachableBlock`")
			});
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x0015E043 File Offset: 0x0015C243
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReachableBlockAll.LogPair = null;
			ConfigQuestReachableBlockAll.HandleId = 0;
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x0015E051 File Offset: 0x0015C251
		public static void Init()
		{
			ConfigQuestReachableBlockAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReachableBlockAll.HandleId, "db_questreachableblock.db", "select BinData from `QuestReachableBlock`");
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x0015E06C File Offset: 0x0015C26C
		[NullableContext(2)]
		public static IReadOnlyList<QuestReachableBlock> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestReachableBlockAll.HandleId, ConfigQuestReachableBlockAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QuestReachableBlock> readOnlyList = (IReadOnlyList<QuestReachableBlock>)ConfigCommon.GetConfig("QuestReachableBlockAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<QuestReachableBlock> list = new List<QuestReachableBlock>();
			while (ConfigCommon.Step(ConfigQuestReachableBlockAll.HandleId, false, ConfigQuestReachableBlockAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestReachableBlockAll.HandleId, 0, ConfigQuestReachableBlockAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestReachableBlockAll.HandleId, ConfigQuestReachableBlockAll.LogPair);
					return null;
				}
				QuestReachableBlock rootAsQuestReachableBlock = QuestReachableBlock.GetRootAsQuestReachableBlock(new ByteBuffer(item2));
				list.Add(rootAsQuestReachableBlock);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QuestReachableBlockAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestReachableBlockAll.HandleId, ConfigQuestReachableBlockAll.LogPair);
			return list;
		}

		// Token: 0x040034EB RID: 13547
		private const string DB = "db_questreachableblock.db";

		// Token: 0x040034EC RID: 13548
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/QuestReachableBlock.csv";

		// Token: 0x040034ED RID: 13549
		private const string TABLE = "QuestReachableBlock";

		// Token: 0x040034EE RID: 13550
		private const string COMMAND = "select BinData from `QuestReachableBlock`";

		// Token: 0x040034EF RID: 13551
		private const string KEY_PREFIX = "QuestReachableBlockAll";

		// Token: 0x040034F0 RID: 13552
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034F1 RID: 13553
		private static int HandleId;
	}
}
