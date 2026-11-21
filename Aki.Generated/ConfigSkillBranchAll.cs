using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200097D RID: 2429
	public class ConfigSkillBranchAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003901 RID: 14593 RVA: 0x0019EDC0 File Offset: 0x0019CFC0
		static ConfigSkillBranchAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillBranchAll.CreateStaticDefaultValue), new Action(ConfigSkillBranchAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x0019EDE0 File Offset: 0x0019CFE0
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillBranchAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillBranchAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skill.db"),
				new ValueTuple<string, object>("文件", "j.技能.xlsx"),
				new ValueTuple<string, object>("表名", "SkillBranch"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillBranch`")
			});
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x0019EE5F File Offset: 0x0019D05F
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillBranchAll.LogPair = null;
			ConfigSkillBranchAll.HandleId = 0;
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x0019EE6D File Offset: 0x0019D06D
		public static void Init()
		{
			ConfigSkillBranchAll.HandleId = ConfigCommon.InitDataStatement(ConfigSkillBranchAll.HandleId, "db_skill.db", "select BinData from `SkillBranch`");
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x0019EE88 File Offset: 0x0019D088
		[NullableContext(2)]
		public static IReadOnlyList<SkillBranch> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillBranchAll.HandleId, ConfigSkillBranchAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SkillBranch> readOnlyList = (IReadOnlyList<SkillBranch>)ConfigCommon.GetConfig("SkillBranchAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SkillBranch> list = new List<SkillBranch>();
			while (ConfigCommon.Step(ConfigSkillBranchAll.HandleId, false, ConfigSkillBranchAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillBranchAll.HandleId, 0, ConfigSkillBranchAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillBranchAll.HandleId, ConfigSkillBranchAll.LogPair);
					return null;
				}
				SkillBranch rootAsSkillBranch = SkillBranch.GetRootAsSkillBranch(new ByteBuffer(item2));
				list.Add(rootAsSkillBranch);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SkillBranchAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillBranchAll.HandleId, ConfigSkillBranchAll.LogPair);
			return list;
		}

		// Token: 0x04004251 RID: 16977
		private const string DB = "db_skill.db";

		// Token: 0x04004252 RID: 16978
		private const string FILE = "j.技能.xlsx";

		// Token: 0x04004253 RID: 16979
		private const string TABLE = "SkillBranch";

		// Token: 0x04004254 RID: 16980
		private const string COMMAND = "select BinData from `SkillBranch`";

		// Token: 0x04004255 RID: 16981
		private const string KEY_PREFIX = "SkillBranchAll";

		// Token: 0x04004256 RID: 16982
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004257 RID: 16983
		private static int HandleId;
	}
}
