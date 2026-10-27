using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000324 RID: 804
	public class ConfigFloroRanchSkillAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012DD RID: 4829 RVA: 0x000C40D4 File Offset: 0x000C22D4
		static ConfigFloroRanchSkillAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchSkillAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchSkillAll.ResetStaticDefaultValue));
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x000C40F4 File Offset: 0x000C22F4
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchSkillAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchSkillAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchSkill`")
			});
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x000C4173 File Offset: 0x000C2373
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchSkillAll.LogPair = null;
			ConfigFloroRanchSkillAll.HandleId = 0;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x000C4181 File Offset: 0x000C2381
		public static void Init()
		{
			ConfigFloroRanchSkillAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchSkillAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchSkill`");
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x000C419C File Offset: 0x000C239C
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchSkill> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchSkillAll.HandleId, ConfigFloroRanchSkillAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchSkill> readOnlyList = (IReadOnlyList<FloroRanchSkill>)ConfigCommon.GetConfig("FloroRanchSkillAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchSkill> list = new List<FloroRanchSkill>();
			while (ConfigCommon.Step(ConfigFloroRanchSkillAll.HandleId, false, ConfigFloroRanchSkillAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchSkillAll.HandleId, 0, ConfigFloroRanchSkillAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchSkillAll.HandleId, ConfigFloroRanchSkillAll.LogPair);
					return null;
				}
				FloroRanchSkill rootAsFloroRanchSkill = FloroRanchSkill.GetRootAsFloroRanchSkill(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchSkill);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchSkillAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchSkillAll.HandleId, ConfigFloroRanchSkillAll.LogPair);
			return list;
		}

		// Token: 0x040015E0 RID: 5600
		private const string DB = "db_flororanch.db";

		// Token: 0x040015E1 RID: 5601
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015E2 RID: 5602
		private const string TABLE = "FloroRanchSkill";

		// Token: 0x040015E3 RID: 5603
		private const string COMMAND = "select BinData from `FloroRanchSkill`";

		// Token: 0x040015E4 RID: 5604
		private const string KEY_PREFIX = "FloroRanchSkillAll";

		// Token: 0x040015E5 RID: 5605
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015E6 RID: 5606
		private static int HandleId;
	}
}
