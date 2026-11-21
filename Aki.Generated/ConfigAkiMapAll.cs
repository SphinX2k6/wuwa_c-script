using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200009A RID: 154
	public class ConfigAkiMapAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600039C RID: 924 RVA: 0x000717F0 File Offset: 0x0006F9F0
		static ConfigAkiMapAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAkiMapAll.CreateStaticDefaultValue), new Action(ConfigAkiMapAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00071810 File Offset: 0x0006FA10
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

		// Token: 0x0600039E RID: 926 RVA: 0x0007188F File Offset: 0x0006FA8F
		public static void ResetStaticDefaultValue()
		{
			ConfigAkiMapAll.LogPair = null;
			ConfigAkiMapAll.HandleId = 0;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0007189D File Offset: 0x0006FA9D
		public static void Init()
		{
			ConfigAkiMapAll.HandleId = ConfigCommon.InitDataStatement(ConfigAkiMapAll.HandleId, "db_map.db", "select BinData from `AkiMap`");
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000718B8 File Offset: 0x0006FAB8
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

		// Token: 0x0400041A RID: 1050
		private const string DB = "db_map.db";

		// Token: 0x0400041B RID: 1051
		private const string FILE = "d.地图.xlsx";

		// Token: 0x0400041C RID: 1052
		private const string TABLE = "AkiMap";

		// Token: 0x0400041D RID: 1053
		private const string COMMAND = "select BinData from `AkiMap`";

		// Token: 0x0400041E RID: 1054
		private const string KEY_PREFIX = "AkiMapAll";

		// Token: 0x0400041F RID: 1055
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000420 RID: 1056
		private static int HandleId;
	}
}
