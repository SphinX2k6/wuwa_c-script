using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000139 RID: 313
	public class ConfigBuildingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000757 RID: 1879 RVA: 0x00086C58 File Offset: 0x00084E58
		static ConfigBuildingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuildingAll.CreateStaticDefaultValue), new Action(ConfigBuildingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00086C78 File Offset: 0x00084E78
		public static void CreateStaticDefaultValue()
		{
			ConfigBuildingAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuildingAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "Building"),
				new ValueTuple<string, object>("语句", "select BinData from `Building`")
			});
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00086CF7 File Offset: 0x00084EF7
		public static void ResetStaticDefaultValue()
		{
			ConfigBuildingAll.LogPair = null;
			ConfigBuildingAll.HandleId = 0;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00086D05 File Offset: 0x00084F05
		public static void Init()
		{
			ConfigBuildingAll.HandleId = ConfigCommon.InitDataStatement(ConfigBuildingAll.HandleId, "db_moonchasing.db", "select BinData from `Building`");
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00086D20 File Offset: 0x00084F20
		[NullableContext(2)]
		public static IReadOnlyList<Building> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuildingAll.HandleId, ConfigBuildingAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Building> readOnlyList = (IReadOnlyList<Building>)ConfigCommon.GetConfig("BuildingAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Building> list = new List<Building>();
			while (ConfigCommon.Step(ConfigBuildingAll.HandleId, false, ConfigBuildingAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuildingAll.HandleId, 0, ConfigBuildingAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBuildingAll.HandleId, ConfigBuildingAll.LogPair);
					return null;
				}
				Building rootAsBuilding = Building.GetRootAsBuilding(new ByteBuffer(item2));
				list.Add(rootAsBuilding);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BuildingAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBuildingAll.HandleId, ConfigBuildingAll.LogPair);
			return list;
		}

		// Token: 0x04000873 RID: 2163
		private const string DB = "db_moonchasing.db";

		// Token: 0x04000874 RID: 2164
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04000875 RID: 2165
		private const string TABLE = "Building";

		// Token: 0x04000876 RID: 2166
		private const string COMMAND = "select BinData from `Building`";

		// Token: 0x04000877 RID: 2167
		private const string KEY_PREFIX = "BuildingAll";

		// Token: 0x04000878 RID: 2168
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000879 RID: 2169
		private static int HandleId;
	}
}
