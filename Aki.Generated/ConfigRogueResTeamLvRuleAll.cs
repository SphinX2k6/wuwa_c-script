using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200085E RID: 2142
	public class ConfigRogueResTeamLvRuleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003246 RID: 12870 RVA: 0x00175BF0 File Offset: 0x00173DF0
		static ConfigRogueResTeamLvRuleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResTeamLvRuleAll.CreateStaticDefaultValue), new Action(ConfigRogueResTeamLvRuleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x00175C10 File Offset: 0x00173E10
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

		// Token: 0x06003248 RID: 12872 RVA: 0x00175C8F File Offset: 0x00173E8F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResTeamLvRuleAll.LogPair = null;
			ConfigRogueResTeamLvRuleAll.HandleId = 0;
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x00175C9D File Offset: 0x00173E9D
		public static void Init()
		{
			ConfigRogueResTeamLvRuleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResTeamLvRuleAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTeamLvRule`");
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x00175CB8 File Offset: 0x00173EB8
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

		// Token: 0x04003A78 RID: 14968
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A79 RID: 14969
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A7A RID: 14970
		private const string TABLE = "RogueResTeamLvRule";

		// Token: 0x04003A7B RID: 14971
		private const string COMMAND = "select BinData from `RogueResTeamLvRule`";

		// Token: 0x04003A7C RID: 14972
		private const string KEY_PREFIX = "RogueResTeamLvRuleAll";

		// Token: 0x04003A7D RID: 14973
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A7E RID: 14974
		private static int HandleId;
	}
}
