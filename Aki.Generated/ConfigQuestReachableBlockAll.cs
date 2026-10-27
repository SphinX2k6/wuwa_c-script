using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000779 RID: 1913
	public class ConfigQuestReachableBlockAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CE7 RID: 11495 RVA: 0x00157099 File Offset: 0x00155299
		static ConfigQuestReachableBlockAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReachableBlockAll.CreateStaticDefaultValue), new Action(ConfigQuestReachableBlockAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x001570B8 File Offset: 0x001552B8
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

		// Token: 0x06002CE9 RID: 11497 RVA: 0x00157137 File Offset: 0x00155337
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReachableBlockAll.LogPair = null;
			ConfigQuestReachableBlockAll.HandleId = 0;
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x00157145 File Offset: 0x00155345
		public static void Init()
		{
			ConfigQuestReachableBlockAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReachableBlockAll.HandleId, "db_questreachableblock.db", "select BinData from `QuestReachableBlock`");
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x00157160 File Offset: 0x00155360
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

		// Token: 0x04003435 RID: 13365
		private const string DB = "db_questreachableblock.db";

		// Token: 0x04003436 RID: 13366
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/QuestReachableBlock.csv";

		// Token: 0x04003437 RID: 13367
		private const string TABLE = "QuestReachableBlock";

		// Token: 0x04003438 RID: 13368
		private const string COMMAND = "select BinData from `QuestReachableBlock`";

		// Token: 0x04003439 RID: 13369
		private const string KEY_PREFIX = "QuestReachableBlockAll";

		// Token: 0x0400343A RID: 13370
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400343B RID: 13371
		private static int HandleId;
	}
}
