using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200051E RID: 1310
	public class ConfigMapMarkRelativeSubTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EBF RID: 7871 RVA: 0x00107050 File Offset: 0x00105250
		static ConfigMapMarkRelativeSubTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkRelativeSubTypeAll.CreateStaticDefaultValue), new Action(ConfigMapMarkRelativeSubTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00107070 File Offset: 0x00105270
		public static void CreateStaticDefaultValue()
		{
			ConfigMapMarkRelativeSubTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapMarkRelativeSubTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "MapMarkRelativeSubType"),
				new ValueTuple<string, object>("语句", "select BinData from `MapMarkRelativeSubType`")
			});
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x001070EF File Offset: 0x001052EF
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkRelativeSubTypeAll.LogPair = null;
			ConfigMapMarkRelativeSubTypeAll.HandleId = 0;
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x001070FD File Offset: 0x001052FD
		public static void Init()
		{
			ConfigMapMarkRelativeSubTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkRelativeSubTypeAll.HandleId, "db_map_mark.db", "select BinData from `MapMarkRelativeSubType`");
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00107118 File Offset: 0x00105318
		[NullableContext(2)]
		public static IReadOnlyList<MapMarkRelativeSubType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapMarkRelativeSubTypeAll.HandleId, ConfigMapMarkRelativeSubTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MapMarkRelativeSubType> readOnlyList = (IReadOnlyList<MapMarkRelativeSubType>)ConfigCommon.GetConfig("MapMarkRelativeSubTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MapMarkRelativeSubType> list = new List<MapMarkRelativeSubType>();
			while (ConfigCommon.Step(ConfigMapMarkRelativeSubTypeAll.HandleId, false, ConfigMapMarkRelativeSubTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapMarkRelativeSubTypeAll.HandleId, 0, ConfigMapMarkRelativeSubTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapMarkRelativeSubTypeAll.HandleId, ConfigMapMarkRelativeSubTypeAll.LogPair);
					return null;
				}
				MapMarkRelativeSubType rootAsMapMarkRelativeSubType = MapMarkRelativeSubType.GetRootAsMapMarkRelativeSubType(new ByteBuffer(item2));
				list.Add(rootAsMapMarkRelativeSubType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MapMarkRelativeSubTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapMarkRelativeSubTypeAll.HandleId, ConfigMapMarkRelativeSubTypeAll.LogPair);
			return list;
		}

		// Token: 0x040023B6 RID: 9142
		private const string DB = "db_map_mark.db";

		// Token: 0x040023B7 RID: 9143
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x040023B8 RID: 9144
		private const string TABLE = "MapMarkRelativeSubType";

		// Token: 0x040023B9 RID: 9145
		private const string COMMAND = "select BinData from `MapMarkRelativeSubType`";

		// Token: 0x040023BA RID: 9146
		private const string KEY_PREFIX = "MapMarkRelativeSubTypeAll";

		// Token: 0x040023BB RID: 9147
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023BC RID: 9148
		private static int HandleId;
	}
}
