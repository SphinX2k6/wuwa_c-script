using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000909 RID: 2313
	public class ConfigRoleTowerStageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003649 RID: 13897 RVA: 0x0018F850 File Offset: 0x0018DA50
		static ConfigRoleTowerStageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerStageAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerStageAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x0018F870 File Offset: 0x0018DA70
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerStageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerStageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerStage"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerStage`")
			});
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x0018F8EF File Offset: 0x0018DAEF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerStageAll.LogPair = null;
			ConfigRoleTowerStageAll.HandleId = 0;
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x0018F8FD File Offset: 0x0018DAFD
		public static void Init()
		{
			ConfigRoleTowerStageAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerStageAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerStage`");
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x0018F918 File Offset: 0x0018DB18
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerStage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerStageAll.HandleId, ConfigRoleTowerStageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerStage> readOnlyList = (IReadOnlyList<RoleTowerStage>)ConfigCommon.GetConfig("RoleTowerStageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerStage> list = new List<RoleTowerStage>();
			while (ConfigCommon.Step(ConfigRoleTowerStageAll.HandleId, false, ConfigRoleTowerStageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerStageAll.HandleId, 0, ConfigRoleTowerStageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerStageAll.HandleId, ConfigRoleTowerStageAll.LogPair);
					return null;
				}
				RoleTowerStage rootAsRoleTowerStage = RoleTowerStage.GetRootAsRoleTowerStage(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerStage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerStageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerStageAll.HandleId, ConfigRoleTowerStageAll.LogPair);
			return list;
		}

		// Token: 0x04003F25 RID: 16165
		private const string DB = "db_roletower.db";

		// Token: 0x04003F26 RID: 16166
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003F27 RID: 16167
		private const string TABLE = "RoleTowerStage";

		// Token: 0x04003F28 RID: 16168
		private const string COMMAND = "select BinData from `RoleTowerStage`";

		// Token: 0x04003F29 RID: 16169
		private const string KEY_PREFIX = "RoleTowerStageAll";

		// Token: 0x04003F2A RID: 16170
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F2B RID: 16171
		private static int HandleId;
	}
}
