using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000515 RID: 1301
	public class ConfigMapMarkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E89 RID: 7817 RVA: 0x00105CA8 File Offset: 0x00103EA8
		static ConfigMapMarkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkAll.CreateStaticDefaultValue), new Action(ConfigMapMarkAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00105CC8 File Offset: 0x00103EC8
		public static void CreateStaticDefaultValue()
		{
			ConfigMapMarkAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapMarkAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "MapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `MapMark`")
			});
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00105D47 File Offset: 0x00103F47
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkAll.LogPair = null;
			ConfigMapMarkAll.HandleId = 0;
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00105D55 File Offset: 0x00103F55
		public static void Init()
		{
			ConfigMapMarkAll.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkAll.HandleId, "db_map_mark.db", "select BinData from `MapMark`");
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00105D70 File Offset: 0x00103F70
		[NullableContext(2)]
		public static IReadOnlyList<MapMark> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapMarkAll.HandleId, ConfigMapMarkAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MapMark> readOnlyList = (IReadOnlyList<MapMark>)ConfigCommon.GetConfig("MapMarkAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MapMark> list = new List<MapMark>();
			while (ConfigCommon.Step(ConfigMapMarkAll.HandleId, false, ConfigMapMarkAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapMarkAll.HandleId, 0, ConfigMapMarkAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapMarkAll.HandleId, ConfigMapMarkAll.LogPair);
					return null;
				}
				MapMark rootAsMapMark = MapMark.GetRootAsMapMark(new ByteBuffer(item2));
				list.Add(rootAsMapMark);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MapMarkAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapMarkAll.HandleId, ConfigMapMarkAll.LogPair);
			return list;
		}

		// Token: 0x04002377 RID: 9079
		private const string DB = "db_map_mark.db";

		// Token: 0x04002378 RID: 9080
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04002379 RID: 9081
		private const string TABLE = "MapMark";

		// Token: 0x0400237A RID: 9082
		private const string COMMAND = "select BinData from `MapMark`";

		// Token: 0x0400237B RID: 9083
		private const string KEY_PREFIX = "MapMarkAll";

		// Token: 0x0400237C RID: 9084
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400237D RID: 9085
		private static int HandleId;
	}
}
