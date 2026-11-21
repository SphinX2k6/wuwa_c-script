using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000339 RID: 825
	public class ConfigFloroRanchSkillAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600135B RID: 4955 RVA: 0x000CA5E0 File Offset: 0x000C87E0
		static ConfigFloroRanchSkillAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchSkillAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchSkillAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x000CA600 File Offset: 0x000C8800
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

		// Token: 0x0600135D RID: 4957 RVA: 0x000CA67F File Offset: 0x000C887F
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchSkillAll.LogPair = null;
			ConfigFloroRanchSkillAll.HandleId = 0;
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x000CA68D File Offset: 0x000C888D
		public static void Init()
		{
			ConfigFloroRanchSkillAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchSkillAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchSkill`");
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x000CA6A8 File Offset: 0x000C88A8
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

		// Token: 0x04001673 RID: 5747
		private const string DB = "db_flororanch.db";

		// Token: 0x04001674 RID: 5748
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001675 RID: 5749
		private const string TABLE = "FloroRanchSkill";

		// Token: 0x04001676 RID: 5750
		private const string COMMAND = "select BinData from `FloroRanchSkill`";

		// Token: 0x04001677 RID: 5751
		private const string KEY_PREFIX = "FloroRanchSkillAll";

		// Token: 0x04001678 RID: 5752
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001679 RID: 5753
		private static int HandleId;
	}
}
