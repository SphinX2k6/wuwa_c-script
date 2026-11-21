using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F5 RID: 2293
	public class ConfigRoleTowerLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035D1 RID: 13777 RVA: 0x0018CF48 File Offset: 0x0018B148
		static ConfigRoleTowerLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerLevelAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x0018CF68 File Offset: 0x0018B168
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerLevel`")
			});
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x0018CFE7 File Offset: 0x0018B1E7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerLevelAll.LogPair = null;
			ConfigRoleTowerLevelAll.HandleId = 0;
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x0018CFF5 File Offset: 0x0018B1F5
		public static void Init()
		{
			ConfigRoleTowerLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerLevelAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerLevel`");
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x0018D010 File Offset: 0x0018B210
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerLevelAll.HandleId, ConfigRoleTowerLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerLevel> readOnlyList = (IReadOnlyList<RoleTowerLevel>)ConfigCommon.GetConfig("RoleTowerLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerLevel> list = new List<RoleTowerLevel>();
			while (ConfigCommon.Step(ConfigRoleTowerLevelAll.HandleId, false, ConfigRoleTowerLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerLevelAll.HandleId, 0, ConfigRoleTowerLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerLevelAll.HandleId, ConfigRoleTowerLevelAll.LogPair);
					return null;
				}
				RoleTowerLevel rootAsRoleTowerLevel = RoleTowerLevel.GetRootAsRoleTowerLevel(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerLevelAll.HandleId, ConfigRoleTowerLevelAll.LogPair);
			return list;
		}

		// Token: 0x04003E99 RID: 16025
		private const string DB = "db_roletower.db";

		// Token: 0x04003E9A RID: 16026
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003E9B RID: 16027
		private const string TABLE = "RoleTowerLevel";

		// Token: 0x04003E9C RID: 16028
		private const string COMMAND = "select BinData from `RoleTowerLevel`";

		// Token: 0x04003E9D RID: 16029
		private const string KEY_PREFIX = "RoleTowerLevelAll";

		// Token: 0x04003E9E RID: 16030
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E9F RID: 16031
		private static int HandleId;
	}
}
