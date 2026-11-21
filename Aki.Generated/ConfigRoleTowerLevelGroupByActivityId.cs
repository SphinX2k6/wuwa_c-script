using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F9 RID: 2297
	public class ConfigRoleTowerLevelGroupByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035E9 RID: 13801 RVA: 0x0018D6EF File Offset: 0x0018B8EF
		static ConfigRoleTowerLevelGroupByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerLevelGroupByActivityId.CreateStaticDefaultValue), new Action(ConfigRoleTowerLevelGroupByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x0018D710 File Offset: 0x0018B910
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerLevelGroupByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerLevelGroupByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerLevelGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerLevelGroup` where ActivityId=?")
			});
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x0018D78F File Offset: 0x0018B98F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerLevelGroupByActivityId.LogPair = null;
			ConfigRoleTowerLevelGroupByActivityId.HandleId = 0;
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x0018D79D File Offset: 0x0018B99D
		public static void Init()
		{
			ConfigRoleTowerLevelGroupByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerLevelGroupByActivityId.HandleId, "db_roletower.db", "select BinData from `RoleTowerLevelGroup` where ActivityId=?");
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x0018D7B8 File Offset: 0x0018B9B8
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerLevelGroup> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerLevelGroupByActivityId.HandleId, ConfigRoleTowerLevelGroupByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerLevelGroupByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RoleTowerLevelGroup> readOnlyList = (IReadOnlyList<RoleTowerLevelGroup>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleTowerLevelGroupByActivityId.LogPair.Clear();
			ConfigRoleTowerLevelGroupByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerLevelGroupByActivityId.HandleId, 1, p0ActivityId, ConfigRoleTowerLevelGroupByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleTowerLevelGroupByActivityId.HandleId, ConfigRoleTowerLevelGroupByActivityId.LogPair);
				return null;
			}
			List<RoleTowerLevelGroup> list = new List<RoleTowerLevelGroup>();
			while (ConfigCommon.Step(ConfigRoleTowerLevelGroupByActivityId.HandleId, false, ConfigRoleTowerLevelGroupByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerLevelGroupByActivityId.HandleId, 0, ConfigRoleTowerLevelGroupByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerLevelGroupByActivityId.HandleId, ConfigRoleTowerLevelGroupByActivityId.LogPair);
					return null;
				}
				RoleTowerLevelGroup rootAsRoleTowerLevelGroup = RoleTowerLevelGroup.GetRootAsRoleTowerLevelGroup(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerLevelGroup);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerLevelGroupByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerLevelGroupByActivityId.HandleId, ConfigRoleTowerLevelGroupByActivityId.LogPair);
			return list;
		}

		// Token: 0x04003EB5 RID: 16053
		private const string DB = "db_roletower.db";

		// Token: 0x04003EB6 RID: 16054
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003EB7 RID: 16055
		private const string TABLE = "RoleTowerLevelGroup";

		// Token: 0x04003EB8 RID: 16056
		private const string COMMAND = "select BinData from `RoleTowerLevelGroup` where ActivityId=?";

		// Token: 0x04003EB9 RID: 16057
		private const string KEY_PREFIX = "RoleTowerLevelGroupByActivityId";

		// Token: 0x04003EBA RID: 16058
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EBB RID: 16059
		private static int HandleId;
	}
}
