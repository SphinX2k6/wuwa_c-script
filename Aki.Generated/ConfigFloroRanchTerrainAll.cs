using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200032F RID: 815
	public class ConfigFloroRanchTerrainAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600131F RID: 4895 RVA: 0x000C57B0 File Offset: 0x000C39B0
		static ConfigFloroRanchTerrainAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTerrainAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchTerrainAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x000C57D0 File Offset: 0x000C39D0
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

		// Token: 0x06001321 RID: 4897 RVA: 0x000C584F File Offset: 0x000C3A4F
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTerrainAll.LogPair = null;
			ConfigFloroRanchTerrainAll.HandleId = 0;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x000C585D File Offset: 0x000C3A5D
		public static void Init()
		{
			ConfigFloroRanchTerrainAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTerrainAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTerrain`");
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x000C5878 File Offset: 0x000C3A78
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

		// Token: 0x0400162D RID: 5677
		private const string DB = "db_flororanch.db";

		// Token: 0x0400162E RID: 5678
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400162F RID: 5679
		private const string TABLE = "FloroRanchTerrain";

		// Token: 0x04001630 RID: 5680
		private const string COMMAND = "select BinData from `FloroRanchTerrain`";

		// Token: 0x04001631 RID: 5681
		private const string KEY_PREFIX = "FloroRanchTerrainAll";

		// Token: 0x04001632 RID: 5682
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001633 RID: 5683
		private static int HandleId;
	}
}
