using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000819 RID: 2073
	public class ConfigRoadZoneConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030A8 RID: 12456 RVA: 0x0016C58C File Offset: 0x0016A78C
		static ConfigRoadZoneConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadZoneConfigAll.CreateStaticDefaultValue), new Action(ConfigRoadZoneConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x0016C5AC File Offset: 0x0016A7AC
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

		// Token: 0x060030AA RID: 12458 RVA: 0x0016C62B File Offset: 0x0016A82B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadZoneConfigAll.LogPair = null;
			ConfigRoadZoneConfigAll.HandleId = 0;
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x0016C639 File Offset: 0x0016A839
		public static void Init()
		{
			ConfigRoadZoneConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoadZoneConfigAll.HandleId, "db_roadzoneconfig.db", "select BinData from `RoadZoneConfig`");
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x0016C654 File Offset: 0x0016A854
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

		// Token: 0x04003895 RID: 14485
		private const string DB = "db_roadzoneconfig.db";

		// Token: 0x04003896 RID: 14486
		private const string FILE = "UniverseEditor/LevelPlay/RoadZoneConfig.csv";

		// Token: 0x04003897 RID: 14487
		private const string TABLE = "RoadZoneConfig";

		// Token: 0x04003898 RID: 14488
		private const string COMMAND = "select BinData from `RoadZoneConfig`";

		// Token: 0x04003899 RID: 14489
		private const string KEY_PREFIX = "RoadZoneConfigAll";

		// Token: 0x0400389A RID: 14490
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400389B RID: 14491
		private static int HandleId;
	}
}
