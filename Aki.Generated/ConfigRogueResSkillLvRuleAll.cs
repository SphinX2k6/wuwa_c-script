using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000855 RID: 2133
	public class ConfigRogueResSkillLvRuleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003210 RID: 12816 RVA: 0x00174984 File Offset: 0x00172B84
		static ConfigRogueResSkillLvRuleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResSkillLvRuleAll.CreateStaticDefaultValue), new Action(ConfigRogueResSkillLvRuleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x001749A4 File Offset: 0x00172BA4
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

		// Token: 0x06003212 RID: 12818 RVA: 0x00174A23 File Offset: 0x00172C23
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResSkillLvRuleAll.LogPair = null;
			ConfigRogueResSkillLvRuleAll.HandleId = 0;
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x00174A31 File Offset: 0x00172C31
		public static void Init()
		{
			ConfigRogueResSkillLvRuleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResSkillLvRuleAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResSkillLvRule`");
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x00174A4C File Offset: 0x00172C4C
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

		// Token: 0x04003A39 RID: 14905
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A3A RID: 14906
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A3B RID: 14907
		private const string TABLE = "RogueResSkillLvRule";

		// Token: 0x04003A3C RID: 14908
		private const string COMMAND = "select BinData from `RogueResSkillLvRule`";

		// Token: 0x04003A3D RID: 14909
		private const string KEY_PREFIX = "RogueResSkillLvRuleAll";

		// Token: 0x04003A3E RID: 14910
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A3F RID: 14911
		private static int HandleId;
	}
}
