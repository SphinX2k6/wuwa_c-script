using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200052B RID: 1323
	public class ConfigMapMarkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F0D RID: 7949 RVA: 0x0010C3FC File Offset: 0x0010A5FC
		static ConfigMapMarkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkAll.CreateStaticDefaultValue), new Action(ConfigMapMarkAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x0010C41C File Offset: 0x0010A61C
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

		// Token: 0x06001F0F RID: 7951 RVA: 0x0010C49B File Offset: 0x0010A69B
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkAll.LogPair = null;
			ConfigMapMarkAll.HandleId = 0;
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x0010C4A9 File Offset: 0x0010A6A9
		public static void Init()
		{
			ConfigMapMarkAll.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkAll.HandleId, "db_map_mark.db", "select BinData from `MapMark`");
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x0010C4C4 File Offset: 0x0010A6C4
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

		// Token: 0x04002411 RID: 9233
		private const string DB = "db_map_mark.db";

		// Token: 0x04002412 RID: 9234
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04002413 RID: 9235
		private const string TABLE = "MapMark";

		// Token: 0x04002414 RID: 9236
		private const string COMMAND = "select BinData from `MapMark`";

		// Token: 0x04002415 RID: 9237
		private const string KEY_PREFIX = "MapMarkAll";

		// Token: 0x04002416 RID: 9238
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002417 RID: 9239
		private static int HandleId;
	}
}
