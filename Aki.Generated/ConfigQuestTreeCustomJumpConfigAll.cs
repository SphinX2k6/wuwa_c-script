using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A8 RID: 1960
	public class ConfigQuestTreeCustomJumpConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E02 RID: 11778 RVA: 0x00160B44 File Offset: 0x0015ED44
		static ConfigQuestTreeCustomJumpConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTreeCustomJumpConfigAll.CreateStaticDefaultValue), new Action(ConfigQuestTreeCustomJumpConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x00160B64 File Offset: 0x0015ED64
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTreeCustomJumpConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTreeCustomJumpConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtreecustomjumpconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/r.任务树定制跳转/*.csv*"),
				new ValueTuple<string, object>("表名", "QuestTreeCustomJumpConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestTreeCustomJumpConfig`")
			});
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x00160BE3 File Offset: 0x0015EDE3
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTreeCustomJumpConfigAll.LogPair = null;
			ConfigQuestTreeCustomJumpConfigAll.HandleId = 0;
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x00160BF1 File Offset: 0x0015EDF1
		public static void Init()
		{
			ConfigQuestTreeCustomJumpConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTreeCustomJumpConfigAll.HandleId, "db_questtreecustomjumpconfig.db", "select BinData from `QuestTreeCustomJumpConfig`");
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x00160C0C File Offset: 0x0015EE0C
		[NullableContext(2)]
		public static IReadOnlyList<QuestTreeCustomJumpConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTreeCustomJumpConfigAll.HandleId, ConfigQuestTreeCustomJumpConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QuestTreeCustomJumpConfig> readOnlyList = (IReadOnlyList<QuestTreeCustomJumpConfig>)ConfigCommon.GetConfig("QuestTreeCustomJumpConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<QuestTreeCustomJumpConfig> list = new List<QuestTreeCustomJumpConfig>();
			while (ConfigCommon.Step(ConfigQuestTreeCustomJumpConfigAll.HandleId, false, ConfigQuestTreeCustomJumpConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTreeCustomJumpConfigAll.HandleId, 0, ConfigQuestTreeCustomJumpConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestTreeCustomJumpConfigAll.HandleId, ConfigQuestTreeCustomJumpConfigAll.LogPair);
					return null;
				}
				QuestTreeCustomJumpConfig rootAsQuestTreeCustomJumpConfig = QuestTreeCustomJumpConfig.GetRootAsQuestTreeCustomJumpConfig(new ByteBuffer(item2));
				list.Add(rootAsQuestTreeCustomJumpConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QuestTreeCustomJumpConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestTreeCustomJumpConfigAll.HandleId, ConfigQuestTreeCustomJumpConfigAll.LogPair);
			return list;
		}

		// Token: 0x0400357E RID: 13694
		private const string DB = "db_questtreecustomjumpconfig.db";

		// Token: 0x0400357F RID: 13695
		private const string FILE = "k.可视化编辑/c.Csv/r.任务树定制跳转/*.csv*";

		// Token: 0x04003580 RID: 13696
		private const string TABLE = "QuestTreeCustomJumpConfig";

		// Token: 0x04003581 RID: 13697
		private const string COMMAND = "select BinData from `QuestTreeCustomJumpConfig`";

		// Token: 0x04003582 RID: 13698
		private const string KEY_PREFIX = "QuestTreeCustomJumpConfigAll";

		// Token: 0x04003583 RID: 13699
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003584 RID: 13700
		private static int HandleId;
	}
}
