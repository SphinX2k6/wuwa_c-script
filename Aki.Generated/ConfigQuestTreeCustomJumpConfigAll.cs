using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200078E RID: 1934
	public class ConfigQuestTreeCustomJumpConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D66 RID: 11622 RVA: 0x00159C38 File Offset: 0x00157E38
		static ConfigQuestTreeCustomJumpConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTreeCustomJumpConfigAll.CreateStaticDefaultValue), new Action(ConfigQuestTreeCustomJumpConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x00159C58 File Offset: 0x00157E58
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

		// Token: 0x06002D68 RID: 11624 RVA: 0x00159CD7 File Offset: 0x00157ED7
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTreeCustomJumpConfigAll.LogPair = null;
			ConfigQuestTreeCustomJumpConfigAll.HandleId = 0;
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00159CE5 File Offset: 0x00157EE5
		public static void Init()
		{
			ConfigQuestTreeCustomJumpConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTreeCustomJumpConfigAll.HandleId, "db_questtreecustomjumpconfig.db", "select BinData from `QuestTreeCustomJumpConfig`");
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x00159D00 File Offset: 0x00157F00
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

		// Token: 0x040034C8 RID: 13512
		private const string DB = "db_questtreecustomjumpconfig.db";

		// Token: 0x040034C9 RID: 13513
		private const string FILE = "k.可视化编辑/c.Csv/r.任务树定制跳转/*.csv*";

		// Token: 0x040034CA RID: 13514
		private const string TABLE = "QuestTreeCustomJumpConfig";

		// Token: 0x040034CB RID: 13515
		private const string COMMAND = "select BinData from `QuestTreeCustomJumpConfig`";

		// Token: 0x040034CC RID: 13516
		private const string KEY_PREFIX = "QuestTreeCustomJumpConfigAll";

		// Token: 0x040034CD RID: 13517
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034CE RID: 13518
		private static int HandleId;
	}
}
