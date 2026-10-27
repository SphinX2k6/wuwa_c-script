using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D6 RID: 1494
	public class ConfigMultiMapAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002311 RID: 8977 RVA: 0x0011FC2C File Offset: 0x0011DE2C
		static ConfigMultiMapAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMultiMapAll.CreateStaticDefaultValue), new Action(ConfigMultiMapAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x0011FC4C File Offset: 0x0011DE4C
		public static void CreateStaticDefaultValue()
		{
			ConfigMultiMapAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMultiMapAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "MultiMap"),
				new ValueTuple<string, object>("语句", "select BinData from `MultiMap`")
			});
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x0011FCCB File Offset: 0x0011DECB
		public static void ResetStaticDefaultValue()
		{
			ConfigMultiMapAll.LogPair = null;
			ConfigMultiMapAll.HandleId = 0;
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x0011FCD9 File Offset: 0x0011DED9
		public static void Init()
		{
			ConfigMultiMapAll.HandleId = ConfigCommon.InitDataStatement(ConfigMultiMapAll.HandleId, "db_map.db", "select BinData from `MultiMap`");
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x0011FCF4 File Offset: 0x0011DEF4
		[NullableContext(2)]
		public static IReadOnlyList<MultiMap> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMultiMapAll.HandleId, ConfigMultiMapAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MultiMap> readOnlyList = (IReadOnlyList<MultiMap>)ConfigCommon.GetConfig("MultiMapAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MultiMap> list = new List<MultiMap>();
			while (ConfigCommon.Step(ConfigMultiMapAll.HandleId, false, ConfigMultiMapAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMultiMapAll.HandleId, 0, ConfigMultiMapAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMultiMapAll.HandleId, ConfigMultiMapAll.LogPair);
					return null;
				}
				MultiMap rootAsMultiMap = MultiMap.GetRootAsMultiMap(new ByteBuffer(item2));
				list.Add(rootAsMultiMap);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MultiMapAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMultiMapAll.HandleId, ConfigMultiMapAll.LogPair);
			return list;
		}

		// Token: 0x040028BE RID: 10430
		private const string DB = "db_map.db";

		// Token: 0x040028BF RID: 10431
		private const string FILE = "d.地图.xlsx";

		// Token: 0x040028C0 RID: 10432
		private const string TABLE = "MultiMap";

		// Token: 0x040028C1 RID: 10433
		private const string COMMAND = "select BinData from `MultiMap`";

		// Token: 0x040028C2 RID: 10434
		private const string KEY_PREFIX = "MultiMapAll";

		// Token: 0x040028C3 RID: 10435
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028C4 RID: 10436
		private static int HandleId;
	}
}
