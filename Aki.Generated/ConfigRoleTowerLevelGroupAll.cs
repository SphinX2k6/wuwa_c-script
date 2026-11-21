using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F8 RID: 2296
	public class ConfigRoleTowerLevelGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035E3 RID: 13795 RVA: 0x0018D55C File Offset: 0x0018B75C
		static ConfigRoleTowerLevelGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerLevelGroupAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerLevelGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x0018D57C File Offset: 0x0018B77C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerLevelGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerLevelGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerLevelGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerLevelGroup`")
			});
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x0018D5FB File Offset: 0x0018B7FB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerLevelGroupAll.LogPair = null;
			ConfigRoleTowerLevelGroupAll.HandleId = 0;
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x0018D609 File Offset: 0x0018B809
		public static void Init()
		{
			ConfigRoleTowerLevelGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerLevelGroupAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerLevelGroup`");
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x0018D624 File Offset: 0x0018B824
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerLevelGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerLevelGroupAll.HandleId, ConfigRoleTowerLevelGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerLevelGroup> readOnlyList = (IReadOnlyList<RoleTowerLevelGroup>)ConfigCommon.GetConfig("RoleTowerLevelGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerLevelGroup> list = new List<RoleTowerLevelGroup>();
			while (ConfigCommon.Step(ConfigRoleTowerLevelGroupAll.HandleId, false, ConfigRoleTowerLevelGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerLevelGroupAll.HandleId, 0, ConfigRoleTowerLevelGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerLevelGroupAll.HandleId, ConfigRoleTowerLevelGroupAll.LogPair);
					return null;
				}
				RoleTowerLevelGroup rootAsRoleTowerLevelGroup = RoleTowerLevelGroup.GetRootAsRoleTowerLevelGroup(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerLevelGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerLevelGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerLevelGroupAll.HandleId, ConfigRoleTowerLevelGroupAll.LogPair);
			return list;
		}

		// Token: 0x04003EAE RID: 16046
		private const string DB = "db_roletower.db";

		// Token: 0x04003EAF RID: 16047
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003EB0 RID: 16048
		private const string TABLE = "RoleTowerLevelGroup";

		// Token: 0x04003EB1 RID: 16049
		private const string COMMAND = "select BinData from `RoleTowerLevelGroup`";

		// Token: 0x04003EB2 RID: 16050
		private const string KEY_PREFIX = "RoleTowerLevelGroupAll";

		// Token: 0x04003EB3 RID: 16051
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EB4 RID: 16052
		private static int HandleId;
	}
}
