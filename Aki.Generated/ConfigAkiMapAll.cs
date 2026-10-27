using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000092 RID: 146
	public class ConfigAkiMapAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600036C RID: 876 RVA: 0x0006CF3C File Offset: 0x0006B13C
		static ConfigAkiMapAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAkiMapAll.CreateStaticDefaultValue), new Action(ConfigAkiMapAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0006CF5C File Offset: 0x0006B15C
		public static void CreateStaticDefaultValue()
		{
			ConfigAkiMapAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAkiMapAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "AkiMap"),
				new ValueTuple<string, object>("语句", "select BinData from `AkiMap`")
			});
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0006CFDB File Offset: 0x0006B1DB
		public static void ResetStaticDefaultValue()
		{
			ConfigAkiMapAll.LogPair = null;
			ConfigAkiMapAll.HandleId = 0;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0006CFE9 File Offset: 0x0006B1E9
		public static void Init()
		{
			ConfigAkiMapAll.HandleId = ConfigCommon.InitDataStatement(ConfigAkiMapAll.HandleId, "db_map.db", "select BinData from `AkiMap`");
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0006D004 File Offset: 0x0006B204
		[NullableContext(2)]
		public static IReadOnlyList<AkiMap> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAkiMapAll.HandleId, ConfigAkiMapAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AkiMap> readOnlyList = (IReadOnlyList<AkiMap>)ConfigCommon.GetConfig("AkiMapAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AkiMap> list = new List<AkiMap>();
			while (ConfigCommon.Step(ConfigAkiMapAll.HandleId, false, ConfigAkiMapAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAkiMapAll.HandleId, 0, ConfigAkiMapAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAkiMapAll.HandleId, ConfigAkiMapAll.LogPair);
					return null;
				}
				AkiMap rootAsAkiMap = AkiMap.GetRootAsAkiMap(new ByteBuffer(item2));
				list.Add(rootAsAkiMap);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AkiMapAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAkiMapAll.HandleId, ConfigAkiMapAll.LogPair);
			return list;
		}

		// Token: 0x040003E2 RID: 994
		private const string DB = "db_map.db";

		// Token: 0x040003E3 RID: 995
		private const string FILE = "d.地图.xlsx";

		// Token: 0x040003E4 RID: 996
		private const string TABLE = "AkiMap";

		// Token: 0x040003E5 RID: 997
		private const string COMMAND = "select BinData from `AkiMap`";

		// Token: 0x040003E6 RID: 998
		private const string KEY_PREFIX = "AkiMapAll";

		// Token: 0x040003E7 RID: 999
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003E8 RID: 1000
		private static int HandleId;
	}
}
