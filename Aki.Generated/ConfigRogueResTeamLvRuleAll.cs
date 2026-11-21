using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200087A RID: 2170
	public class ConfigRogueResTeamLvRuleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032EE RID: 13038 RVA: 0x0017CED8 File Offset: 0x0017B0D8
		static ConfigRogueResTeamLvRuleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResTeamLvRuleAll.CreateStaticDefaultValue), new Action(ConfigRogueResTeamLvRuleAll.ResetStaticDefaultValue));
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x0017CEF8 File Offset: 0x0017B0F8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResTeamLvRuleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResTeamLvRuleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResTeamLvRule"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResTeamLvRule`")
			});
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x0017CF77 File Offset: 0x0017B177
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResTeamLvRuleAll.LogPair = null;
			ConfigRogueResTeamLvRuleAll.HandleId = 0;
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x0017CF85 File Offset: 0x0017B185
		public static void Init()
		{
			ConfigRogueResTeamLvRuleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResTeamLvRuleAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTeamLvRule`");
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x0017CFA0 File Offset: 0x0017B1A0
		[NullableContext(2)]
		public static IReadOnlyList<RogueResTeamLvRule> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResTeamLvRuleAll.HandleId, ConfigRogueResTeamLvRuleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueResTeamLvRule> readOnlyList = (IReadOnlyList<RogueResTeamLvRule>)ConfigCommon.GetConfig("RogueResTeamLvRuleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueResTeamLvRule> list = new List<RogueResTeamLvRule>();
			while (ConfigCommon.Step(ConfigRogueResTeamLvRuleAll.HandleId, false, ConfigRogueResTeamLvRuleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResTeamLvRuleAll.HandleId, 0, ConfigRogueResTeamLvRuleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueResTeamLvRuleAll.HandleId, ConfigRogueResTeamLvRuleAll.LogPair);
					return null;
				}
				RogueResTeamLvRule rootAsRogueResTeamLvRule = RogueResTeamLvRule.GetRootAsRogueResTeamLvRule(new ByteBuffer(item2));
				list.Add(rootAsRogueResTeamLvRule);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueResTeamLvRuleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueResTeamLvRuleAll.HandleId, ConfigRogueResTeamLvRuleAll.LogPair);
			return list;
		}

		// Token: 0x04003B3C RID: 15164
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003B3D RID: 15165
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003B3E RID: 15166
		private const string TABLE = "RogueResTeamLvRule";

		// Token: 0x04003B3F RID: 15167
		private const string COMMAND = "select BinData from `RogueResTeamLvRule`";

		// Token: 0x04003B40 RID: 15168
		private const string KEY_PREFIX = "RogueResTeamLvRuleAll";

		// Token: 0x04003B41 RID: 15169
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B42 RID: 15170
		private static int HandleId;
	}
}
