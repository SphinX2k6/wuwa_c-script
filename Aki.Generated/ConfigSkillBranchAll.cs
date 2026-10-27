using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000932 RID: 2354
	public class ConfigSkillBranchAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600373F RID: 14143 RVA: 0x00191BA0 File Offset: 0x0018FDA0
		static ConfigSkillBranchAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillBranchAll.CreateStaticDefaultValue), new Action(ConfigSkillBranchAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x00191BC0 File Offset: 0x0018FDC0
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

		// Token: 0x06003741 RID: 14145 RVA: 0x00191C3F File Offset: 0x0018FE3F
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillBranchAll.LogPair = null;
			ConfigSkillBranchAll.HandleId = 0;
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x00191C4D File Offset: 0x0018FE4D
		public static void Init()
		{
			ConfigSkillBranchAll.HandleId = ConfigCommon.InitDataStatement(ConfigSkillBranchAll.HandleId, "db_skill.db", "select BinData from `SkillBranch`");
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x00191C68 File Offset: 0x0018FE68
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

		// Token: 0x04004044 RID: 16452
		private const string DB = "db_skill.db";

		// Token: 0x04004045 RID: 16453
		private const string FILE = "j.技能.xlsx";

		// Token: 0x04004046 RID: 16454
		private const string TABLE = "SkillBranch";

		// Token: 0x04004047 RID: 16455
		private const string COMMAND = "select BinData from `SkillBranch`";

		// Token: 0x04004048 RID: 16456
		private const string KEY_PREFIX = "SkillBranchAll";

		// Token: 0x04004049 RID: 16457
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400404A RID: 16458
		private static int HandleId;
	}
}
