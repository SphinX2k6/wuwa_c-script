using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000835 RID: 2101
	public class ConfigRoadZoneConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003150 RID: 12624 RVA: 0x00173874 File Offset: 0x00171A74
		static ConfigRoadZoneConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadZoneConfigAll.CreateStaticDefaultValue), new Action(ConfigRoadZoneConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x00173894 File Offset: 0x00171A94
		public static void CreateStaticDefaultValue()
		{
			ConfigRoadZoneConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoadZoneConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadzoneconfig.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/LevelPlay/RoadZoneConfig.csv"),
				new ValueTuple<string, object>("表名", "RoadZoneConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RoadZoneConfig`")
			});
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x00173913 File Offset: 0x00171B13
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadZoneConfigAll.LogPair = null;
			ConfigRoadZoneConfigAll.HandleId = 0;
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x00173921 File Offset: 0x00171B21
		public static void Init()
		{
			ConfigRoadZoneConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoadZoneConfigAll.HandleId, "db_roadzoneconfig.db", "select BinData from `RoadZoneConfig`");
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x0017393C File Offset: 0x00171B3C
		[NullableContext(2)]
		public static IReadOnlyList<RoadZoneConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoadZoneConfigAll.HandleId, ConfigRoadZoneConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoadZoneConfig> readOnlyList = (IReadOnlyList<RoadZoneConfig>)ConfigCommon.GetConfig("RoadZoneConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoadZoneConfig> list = new List<RoadZoneConfig>();
			while (ConfigCommon.Step(ConfigRoadZoneConfigAll.HandleId, false, ConfigRoadZoneConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoadZoneConfigAll.HandleId, 0, ConfigRoadZoneConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoadZoneConfigAll.HandleId, ConfigRoadZoneConfigAll.LogPair);
					return null;
				}
				RoadZoneConfig rootAsRoadZoneConfig = RoadZoneConfig.GetRootAsRoadZoneConfig(new ByteBuffer(item2));
				list.Add(rootAsRoadZoneConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoadZoneConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoadZoneConfigAll.HandleId, ConfigRoadZoneConfigAll.LogPair);
			return list;
		}

		// Token: 0x04003959 RID: 14681
		private const string DB = "db_roadzoneconfig.db";

		// Token: 0x0400395A RID: 14682
		private const string FILE = "UniverseEditor/LevelPlay/RoadZoneConfig.csv";

		// Token: 0x0400395B RID: 14683
		private const string TABLE = "RoadZoneConfig";

		// Token: 0x0400395C RID: 14684
		private const string COMMAND = "select BinData from `RoadZoneConfig`";

		// Token: 0x0400395D RID: 14685
		private const string KEY_PREFIX = "RoadZoneConfigAll";

		// Token: 0x0400395E RID: 14686
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400395F RID: 14687
		private static int HandleId;
	}
}
