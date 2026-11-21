using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000534 RID: 1332
	public class ConfigMapMarkRelativeSubTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F43 RID: 8003 RVA: 0x0010D7A4 File Offset: 0x0010B9A4
		static ConfigMapMarkRelativeSubTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkRelativeSubTypeAll.CreateStaticDefaultValue), new Action(ConfigMapMarkRelativeSubTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x0010D7C4 File Offset: 0x0010B9C4
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

		// Token: 0x06001F45 RID: 8005 RVA: 0x0010D843 File Offset: 0x0010BA43
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkRelativeSubTypeAll.LogPair = null;
			ConfigMapMarkRelativeSubTypeAll.HandleId = 0;
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x0010D851 File Offset: 0x0010BA51
		public static void Init()
		{
			ConfigMapMarkRelativeSubTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkRelativeSubTypeAll.HandleId, "db_map_mark.db", "select BinData from `MapMarkRelativeSubType`");
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x0010D86C File Offset: 0x0010BA6C
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

		// Token: 0x04002450 RID: 9296
		private const string DB = "db_map_mark.db";

		// Token: 0x04002451 RID: 9297
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04002452 RID: 9298
		private const string TABLE = "MapMarkRelativeSubType";

		// Token: 0x04002453 RID: 9299
		private const string COMMAND = "select BinData from `MapMarkRelativeSubType`";

		// Token: 0x04002454 RID: 9300
		private const string KEY_PREFIX = "MapMarkRelativeSubTypeAll";

		// Token: 0x04002455 RID: 9301
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002456 RID: 9302
		private static int HandleId;
	}
}
