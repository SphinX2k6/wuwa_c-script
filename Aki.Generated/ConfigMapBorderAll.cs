using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200050E RID: 1294
	public class ConfigMapBorderAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E5F RID: 7775 RVA: 0x00104D2F File Offset: 0x00102F2F
		static ConfigMapBorderAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapBorderAll.CreateStaticDefaultValue), new Action(ConfigMapBorderAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00104D50 File Offset: 0x00102F50
		public static void CreateStaticDefaultValue()
		{
			ConfigMapBorderAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapBorderAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "MapBorder"),
				new ValueTuple<string, object>("语句", "select BinData from `MapBorder`")
			});
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00104DCF File Offset: 0x00102FCF
		public static void ResetStaticDefaultValue()
		{
			ConfigMapBorderAll.LogPair = null;
			ConfigMapBorderAll.HandleId = 0;
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00104DDD File Offset: 0x00102FDD
		public static void Init()
		{
			ConfigMapBorderAll.HandleId = ConfigCommon.InitDataStatement(ConfigMapBorderAll.HandleId, "db_map.db", "select BinData from `MapBorder`");
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00104DF8 File Offset: 0x00102FF8
		[NullableContext(2)]
		public static IReadOnlyList<MapBorder> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapBorderAll.HandleId, ConfigMapBorderAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MapBorder> readOnlyList = (IReadOnlyList<MapBorder>)ConfigCommon.GetConfig("MapBorderAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MapBorder> list = new List<MapBorder>();
			while (ConfigCommon.Step(ConfigMapBorderAll.HandleId, false, ConfigMapBorderAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapBorderAll.HandleId, 0, ConfigMapBorderAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapBorderAll.HandleId, ConfigMapBorderAll.LogPair);
					return null;
				}
				MapBorder rootAsMapBorder = MapBorder.GetRootAsMapBorder(new ByteBuffer(item2));
				list.Add(rootAsMapBorder);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MapBorderAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapBorderAll.HandleId, ConfigMapBorderAll.LogPair);
			return list;
		}

		// Token: 0x04002346 RID: 9030
		private const string DB = "db_map.db";

		// Token: 0x04002347 RID: 9031
		private const string FILE = "d.地图.xlsx";

		// Token: 0x04002348 RID: 9032
		private const string TABLE = "MapBorder";

		// Token: 0x04002349 RID: 9033
		private const string COMMAND = "select BinData from `MapBorder`";

		// Token: 0x0400234A RID: 9034
		private const string KEY_PREFIX = "MapBorderAll";

		// Token: 0x0400234B RID: 9035
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400234C RID: 9036
		private static int HandleId;
	}
}
