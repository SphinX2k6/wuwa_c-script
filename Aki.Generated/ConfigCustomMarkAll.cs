using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B2 RID: 434
	public class ConfigCustomMarkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A2F RID: 2607 RVA: 0x0009327C File Offset: 0x0009147C
		static ConfigCustomMarkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCustomMarkAll.CreateStaticDefaultValue), new Action(ConfigCustomMarkAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0009329C File Offset: 0x0009149C
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

		// Token: 0x06000A31 RID: 2609 RVA: 0x0009331B File Offset: 0x0009151B
		public static void ResetStaticDefaultValue()
		{
			ConfigCustomMarkAll.LogPair = null;
			ConfigCustomMarkAll.HandleId = 0;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00093329 File Offset: 0x00091529
		public static void Init()
		{
			ConfigCustomMarkAll.HandleId = ConfigCommon.InitDataStatement(ConfigCustomMarkAll.HandleId, "db_map_mark.db", "select BinData from `CustomMark`");
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00093344 File Offset: 0x00091544
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

		// Token: 0x04000BC2 RID: 3010
		private const string DB = "db_map_mark.db";

		// Token: 0x04000BC3 RID: 3011
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04000BC4 RID: 3012
		private const string TABLE = "CustomMark";

		// Token: 0x04000BC5 RID: 3013
		private const string COMMAND = "select BinData from `CustomMark`";

		// Token: 0x04000BC6 RID: 3014
		private const string KEY_PREFIX = "CustomMarkAll";

		// Token: 0x04000BC7 RID: 3015
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BC8 RID: 3016
		private static int HandleId;
	}
}
