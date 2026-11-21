using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F1 RID: 2289
	public class ConfigRoleTowerFloorAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035B9 RID: 13753 RVA: 0x0018C6EC File Offset: 0x0018A8EC
		static ConfigRoleTowerFloorAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerFloorAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerFloorAll.ResetStaticDefaultValue));
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x0018C70C File Offset: 0x0018A90C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerFloorAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerFloorAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerFloor"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerFloor`")
			});
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x0018C78B File Offset: 0x0018A98B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerFloorAll.LogPair = null;
			ConfigRoleTowerFloorAll.HandleId = 0;
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x0018C799 File Offset: 0x0018A999
		public static void Init()
		{
			ConfigRoleTowerFloorAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerFloorAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerFloor`");
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x0018C7B4 File Offset: 0x0018A9B4
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerFloor> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerFloorAll.HandleId, ConfigRoleTowerFloorAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerFloor> readOnlyList = (IReadOnlyList<RoleTowerFloor>)ConfigCommon.GetConfig("RoleTowerFloorAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerFloor> list = new List<RoleTowerFloor>();
			while (ConfigCommon.Step(ConfigRoleTowerFloorAll.HandleId, false, ConfigRoleTowerFloorAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerFloorAll.HandleId, 0, ConfigRoleTowerFloorAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerFloorAll.HandleId, ConfigRoleTowerFloorAll.LogPair);
					return null;
				}
				RoleTowerFloor rootAsRoleTowerFloor = RoleTowerFloor.GetRootAsRoleTowerFloor(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerFloor);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerFloorAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerFloorAll.HandleId, ConfigRoleTowerFloorAll.LogPair);
			return list;
		}

		// Token: 0x04003E7D RID: 15997
		private const string DB = "db_roletower.db";

		// Token: 0x04003E7E RID: 15998
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003E7F RID: 15999
		private const string TABLE = "RoleTowerFloor";

		// Token: 0x04003E80 RID: 16000
		private const string COMMAND = "select BinData from `RoleTowerFloor`";

		// Token: 0x04003E81 RID: 16001
		private const string KEY_PREFIX = "RoleTowerFloorAll";

		// Token: 0x04003E82 RID: 16002
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E83 RID: 16003
		private static int HandleId;
	}
}
