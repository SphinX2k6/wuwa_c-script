using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000246 RID: 582
	public class ConfigDynamicMapMarkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DA8 RID: 3496 RVA: 0x000A6B7C File Offset: 0x000A4D7C
		static ConfigDynamicMapMarkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDynamicMapMarkAll.CreateStaticDefaultValue), new Action(ConfigDynamicMapMarkAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x000A6B9C File Offset: 0x000A4D9C
		public static void CreateStaticDefaultValue()
		{
			ConfigDynamicMapMarkAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDynamicMapMarkAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "DynamicMapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `DynamicMapMark`")
			});
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x000A6C1B File Offset: 0x000A4E1B
		public static void ResetStaticDefaultValue()
		{
			ConfigDynamicMapMarkAll.LogPair = null;
			ConfigDynamicMapMarkAll.HandleId = 0;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000A6C29 File Offset: 0x000A4E29
		public static void Init()
		{
			ConfigDynamicMapMarkAll.HandleId = ConfigCommon.InitDataStatement(ConfigDynamicMapMarkAll.HandleId, "db_map_mark.db", "select BinData from `DynamicMapMark`");
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000A6C44 File Offset: 0x000A4E44
		[NullableContext(2)]
		public static IReadOnlyList<DynamicMapMark> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDynamicMapMarkAll.HandleId, ConfigDynamicMapMarkAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DynamicMapMark> readOnlyList = (IReadOnlyList<DynamicMapMark>)ConfigCommon.GetConfig("DynamicMapMarkAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DynamicMapMark> list = new List<DynamicMapMark>();
			while (ConfigCommon.Step(ConfigDynamicMapMarkAll.HandleId, false, ConfigDynamicMapMarkAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDynamicMapMarkAll.HandleId, 0, ConfigDynamicMapMarkAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDynamicMapMarkAll.HandleId, ConfigDynamicMapMarkAll.LogPair);
					return null;
				}
				DynamicMapMark rootAsDynamicMapMark = DynamicMapMark.GetRootAsDynamicMapMark(new ByteBuffer(item2));
				list.Add(rootAsDynamicMapMark);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DynamicMapMarkAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDynamicMapMarkAll.HandleId, ConfigDynamicMapMarkAll.LogPair);
			return list;
		}

		// Token: 0x04000FCE RID: 4046
		private const string DB = "db_map_mark.db";

		// Token: 0x04000FCF RID: 4047
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04000FD0 RID: 4048
		private const string TABLE = "DynamicMapMark";

		// Token: 0x04000FD1 RID: 4049
		private const string COMMAND = "select BinData from `DynamicMapMark`";

		// Token: 0x04000FD2 RID: 4050
		private const string KEY_PREFIX = "DynamicMapMarkAll";

		// Token: 0x04000FD3 RID: 4051
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FD4 RID: 4052
		private static int HandleId;
	}
}
