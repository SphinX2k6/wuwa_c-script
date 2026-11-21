using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005EE RID: 1518
	public class ConfigMultiMapAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023A1 RID: 9121 RVA: 0x001266A8 File Offset: 0x001248A8
		static ConfigMultiMapAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMultiMapAll.CreateStaticDefaultValue), new Action(ConfigMultiMapAll.ResetStaticDefaultValue));
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x001266C8 File Offset: 0x001248C8
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

		// Token: 0x060023A3 RID: 9123 RVA: 0x00126747 File Offset: 0x00124947
		public static void ResetStaticDefaultValue()
		{
			ConfigMultiMapAll.LogPair = null;
			ConfigMultiMapAll.HandleId = 0;
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x00126755 File Offset: 0x00124955
		public static void Init()
		{
			ConfigMultiMapAll.HandleId = ConfigCommon.InitDataStatement(ConfigMultiMapAll.HandleId, "db_map.db", "select BinData from `MultiMap`");
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x00126770 File Offset: 0x00124970
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

		// Token: 0x04002966 RID: 10598
		private const string DB = "db_map.db";

		// Token: 0x04002967 RID: 10599
		private const string FILE = "d.地图.xlsx";

		// Token: 0x04002968 RID: 10600
		private const string TABLE = "MultiMap";

		// Token: 0x04002969 RID: 10601
		private const string COMMAND = "select BinData from `MultiMap`";

		// Token: 0x0400296A RID: 10602
		private const string KEY_PREFIX = "MultiMapAll";

		// Token: 0x0400296B RID: 10603
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400296C RID: 10604
		private static int HandleId;
	}
}
