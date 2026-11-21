using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008EC RID: 2284
	public class ConfigRoleTowerBranchAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600359B RID: 13723 RVA: 0x0018BCFC File Offset: 0x00189EFC
		static ConfigRoleTowerBranchAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerBranchAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerBranchAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x0018BD1C File Offset: 0x00189F1C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerBranchAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerBranchAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerBranch"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerBranch`")
			});
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x0018BD9B File Offset: 0x00189F9B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerBranchAll.LogPair = null;
			ConfigRoleTowerBranchAll.HandleId = 0;
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x0018BDA9 File Offset: 0x00189FA9
		public static void Init()
		{
			ConfigRoleTowerBranchAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerBranchAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerBranch`");
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x0018BDC4 File Offset: 0x00189FC4
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerBranch> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerBranchAll.HandleId, ConfigRoleTowerBranchAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerBranch> readOnlyList = (IReadOnlyList<RoleTowerBranch>)ConfigCommon.GetConfig("RoleTowerBranchAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerBranch> list = new List<RoleTowerBranch>();
			while (ConfigCommon.Step(ConfigRoleTowerBranchAll.HandleId, false, ConfigRoleTowerBranchAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerBranchAll.HandleId, 0, ConfigRoleTowerBranchAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerBranchAll.HandleId, ConfigRoleTowerBranchAll.LogPair);
					return null;
				}
				RoleTowerBranch rootAsRoleTowerBranch = RoleTowerBranch.GetRootAsRoleTowerBranch(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerBranch);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerBranchAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerBranchAll.HandleId, ConfigRoleTowerBranchAll.LogPair);
			return list;
		}

		// Token: 0x04003E5A RID: 15962
		private const string DB = "db_roletower.db";

		// Token: 0x04003E5B RID: 15963
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003E5C RID: 15964
		private const string TABLE = "RoleTowerBranch";

		// Token: 0x04003E5D RID: 15965
		private const string COMMAND = "select BinData from `RoleTowerBranch`";

		// Token: 0x04003E5E RID: 15966
		private const string KEY_PREFIX = "RoleTowerBranchAll";

		// Token: 0x04003E5F RID: 15967
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E60 RID: 15968
		private static int HandleId;
	}
}
