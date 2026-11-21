using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C4 RID: 452
	public class ConfigCustomMarkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A9B RID: 2715 RVA: 0x000991B4 File Offset: 0x000973B4
		static ConfigCustomMarkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCustomMarkAll.CreateStaticDefaultValue), new Action(ConfigCustomMarkAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x000991D4 File Offset: 0x000973D4
		public static void CreateStaticDefaultValue()
		{
			ConfigCustomMarkAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCustomMarkAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "CustomMark"),
				new ValueTuple<string, object>("语句", "select BinData from `CustomMark`")
			});
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00099253 File Offset: 0x00097453
		public static void ResetStaticDefaultValue()
		{
			ConfigCustomMarkAll.LogPair = null;
			ConfigCustomMarkAll.HandleId = 0;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00099261 File Offset: 0x00097461
		public static void Init()
		{
			ConfigCustomMarkAll.HandleId = ConfigCommon.InitDataStatement(ConfigCustomMarkAll.HandleId, "db_map_mark.db", "select BinData from `CustomMark`");
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0009927C File Offset: 0x0009747C
		[NullableContext(2)]
		public static IReadOnlyList<CustomMark> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCustomMarkAll.HandleId, ConfigCustomMarkAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CustomMark> readOnlyList = (IReadOnlyList<CustomMark>)ConfigCommon.GetConfig("CustomMarkAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CustomMark> list = new List<CustomMark>();
			while (ConfigCommon.Step(ConfigCustomMarkAll.HandleId, false, ConfigCustomMarkAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCustomMarkAll.HandleId, 0, ConfigCustomMarkAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCustomMarkAll.HandleId, ConfigCustomMarkAll.LogPair);
					return null;
				}
				CustomMark rootAsCustomMark = CustomMark.GetRootAsCustomMark(new ByteBuffer(item2));
				list.Add(rootAsCustomMark);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CustomMarkAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCustomMarkAll.HandleId, ConfigCustomMarkAll.LogPair);
			return list;
		}

		// Token: 0x04000C40 RID: 3136
		private const string DB = "db_map_mark.db";

		// Token: 0x04000C41 RID: 3137
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04000C42 RID: 3138
		private const string TABLE = "CustomMark";

		// Token: 0x04000C43 RID: 3139
		private const string COMMAND = "select BinData from `CustomMark`";

		// Token: 0x04000C44 RID: 3140
		private const string KEY_PREFIX = "CustomMarkAll";

		// Token: 0x04000C45 RID: 3141
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C46 RID: 3142
		private static int HandleId;
	}
}
