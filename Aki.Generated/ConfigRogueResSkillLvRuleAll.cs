using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000871 RID: 2161
	public class ConfigRogueResSkillLvRuleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032B8 RID: 12984 RVA: 0x0017BC6C File Offset: 0x00179E6C
		static ConfigRogueResSkillLvRuleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResSkillLvRuleAll.CreateStaticDefaultValue), new Action(ConfigRogueResSkillLvRuleAll.ResetStaticDefaultValue));
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x0017BC8C File Offset: 0x00179E8C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResSkillLvRuleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResSkillLvRuleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResSkillLvRule"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResSkillLvRule`")
			});
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x0017BD0B File Offset: 0x00179F0B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResSkillLvRuleAll.LogPair = null;
			ConfigRogueResSkillLvRuleAll.HandleId = 0;
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x0017BD19 File Offset: 0x00179F19
		public static void Init()
		{
			ConfigRogueResSkillLvRuleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResSkillLvRuleAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResSkillLvRule`");
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x0017BD34 File Offset: 0x00179F34
		[NullableContext(2)]
		public static IReadOnlyList<RogueResSkillLvRule> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResSkillLvRuleAll.HandleId, ConfigRogueResSkillLvRuleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueResSkillLvRule> readOnlyList = (IReadOnlyList<RogueResSkillLvRule>)ConfigCommon.GetConfig("RogueResSkillLvRuleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueResSkillLvRule> list = new List<RogueResSkillLvRule>();
			while (ConfigCommon.Step(ConfigRogueResSkillLvRuleAll.HandleId, false, ConfigRogueResSkillLvRuleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResSkillLvRuleAll.HandleId, 0, ConfigRogueResSkillLvRuleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueResSkillLvRuleAll.HandleId, ConfigRogueResSkillLvRuleAll.LogPair);
					return null;
				}
				RogueResSkillLvRule rootAsRogueResSkillLvRule = RogueResSkillLvRule.GetRootAsRogueResSkillLvRule(new ByteBuffer(item2));
				list.Add(rootAsRogueResSkillLvRule);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueResSkillLvRuleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueResSkillLvRuleAll.HandleId, ConfigRogueResSkillLvRuleAll.LogPair);
			return list;
		}

		// Token: 0x04003AFD RID: 15101
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003AFE RID: 15102
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003AFF RID: 15103
		private const string TABLE = "RogueResSkillLvRule";

		// Token: 0x04003B00 RID: 15104
		private const string COMMAND = "select BinData from `RogueResSkillLvRule`";

		// Token: 0x04003B01 RID: 15105
		private const string KEY_PREFIX = "RogueResSkillLvRuleAll";

		// Token: 0x04003B02 RID: 15106
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B03 RID: 15107
		private static int HandleId;
	}
}
