using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000344 RID: 836
	public class ConfigFloroRanchTerrainAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600139D RID: 5021 RVA: 0x000CBCBC File Offset: 0x000C9EBC
		static ConfigFloroRanchTerrainAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTerrainAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchTerrainAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x000CBCDC File Offset: 0x000C9EDC
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchTerrainAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchTerrainAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchTerrain"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchTerrain`")
			});
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x000CBD5B File Offset: 0x000C9F5B
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTerrainAll.LogPair = null;
			ConfigFloroRanchTerrainAll.HandleId = 0;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x000CBD69 File Offset: 0x000C9F69
		public static void Init()
		{
			ConfigFloroRanchTerrainAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTerrainAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTerrain`");
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x000CBD84 File Offset: 0x000C9F84
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchTerrain> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchTerrainAll.HandleId, ConfigFloroRanchTerrainAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchTerrain> readOnlyList = (IReadOnlyList<FloroRanchTerrain>)ConfigCommon.GetConfig("FloroRanchTerrainAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchTerrain> list = new List<FloroRanchTerrain>();
			while (ConfigCommon.Step(ConfigFloroRanchTerrainAll.HandleId, false, ConfigFloroRanchTerrainAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchTerrainAll.HandleId, 0, ConfigFloroRanchTerrainAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchTerrainAll.HandleId, ConfigFloroRanchTerrainAll.LogPair);
					return null;
				}
				FloroRanchTerrain rootAsFloroRanchTerrain = FloroRanchTerrain.GetRootAsFloroRanchTerrain(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchTerrain);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchTerrainAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchTerrainAll.HandleId, ConfigFloroRanchTerrainAll.LogPair);
			return list;
		}

		// Token: 0x040016C0 RID: 5824
		private const string DB = "db_flororanch.db";

		// Token: 0x040016C1 RID: 5825
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040016C2 RID: 5826
		private const string TABLE = "FloroRanchTerrain";

		// Token: 0x040016C3 RID: 5827
		private const string COMMAND = "select BinData from `FloroRanchTerrain`";

		// Token: 0x040016C4 RID: 5828
		private const string KEY_PREFIX = "FloroRanchTerrainAll";

		// Token: 0x040016C5 RID: 5829
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016C6 RID: 5830
		private static int HandleId;
	}
}
