using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200012A RID: 298
	public class ConfigBuildingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006FD RID: 1789 RVA: 0x000812F4 File Offset: 0x0007F4F4
		static ConfigBuildingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuildingAll.CreateStaticDefaultValue), new Action(ConfigBuildingAll.ResetStaticDefaultValue));
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00081314 File Offset: 0x0007F514
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

		// Token: 0x060006FF RID: 1791 RVA: 0x00081393 File Offset: 0x0007F593
		public static void ResetStaticDefaultValue()
		{
			ConfigBuildingAll.LogPair = null;
			ConfigBuildingAll.HandleId = 0;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000813A1 File Offset: 0x0007F5A1
		public static void Init()
		{
			ConfigBuildingAll.HandleId = ConfigCommon.InitDataStatement(ConfigBuildingAll.HandleId, "db_moonchasing.db", "select BinData from `Building`");
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000813BC File Offset: 0x0007F5BC
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

		// Token: 0x0400080A RID: 2058
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400080B RID: 2059
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400080C RID: 2060
		private const string TABLE = "Building";

		// Token: 0x0400080D RID: 2061
		private const string COMMAND = "select BinData from `Building`";

		// Token: 0x0400080E RID: 2062
		private const string KEY_PREFIX = "BuildingAll";

		// Token: 0x0400080F RID: 2063
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000810 RID: 2064
		private static int HandleId;
	}
}
