using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200025A RID: 602
	public class ConfigDynamicMapMarkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E20 RID: 3616 RVA: 0x000ACE40 File Offset: 0x000AB040
		static ConfigDynamicMapMarkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDynamicMapMarkAll.CreateStaticDefaultValue), new Action(ConfigDynamicMapMarkAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x000ACE60 File Offset: 0x000AB060
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

		// Token: 0x06000E22 RID: 3618 RVA: 0x000ACEDF File Offset: 0x000AB0DF
		public static void ResetStaticDefaultValue()
		{
			ConfigDynamicMapMarkAll.LogPair = null;
			ConfigDynamicMapMarkAll.HandleId = 0;
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x000ACEED File Offset: 0x000AB0ED
		public static void Init()
		{
			ConfigDynamicMapMarkAll.HandleId = ConfigCommon.InitDataStatement(ConfigDynamicMapMarkAll.HandleId, "db_map_mark.db", "select BinData from `DynamicMapMark`");
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x000ACF08 File Offset: 0x000AB108
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

		// Token: 0x0400105A RID: 4186
		private const string DB = "db_map_mark.db";

		// Token: 0x0400105B RID: 4187
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x0400105C RID: 4188
		private const string TABLE = "DynamicMapMark";

		// Token: 0x0400105D RID: 4189
		private const string COMMAND = "select BinData from `DynamicMapMark`";

		// Token: 0x0400105E RID: 4190
		private const string KEY_PREFIX = "DynamicMapMarkAll";

		// Token: 0x0400105F RID: 4191
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001060 RID: 4192
		private static int HandleId;
	}
}
