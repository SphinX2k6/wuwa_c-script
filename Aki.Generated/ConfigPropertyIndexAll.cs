using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200077E RID: 1918
	public class ConfigPropertyIndexAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D05 RID: 11525 RVA: 0x0015B3E0 File Offset: 0x001595E0
		static ConfigPropertyIndexAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPropertyIndexAll.CreateStaticDefaultValue), new Action(ConfigPropertyIndexAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x0015B400 File Offset: 0x00159600
		public static void CreateStaticDefaultValue()
		{
			ConfigPropertyIndexAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPropertyIndexAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_property.db"),
				new ValueTuple<string, object>("文件", "s.属性.xlsx"),
				new ValueTuple<string, object>("表名", "PropertyIndex"),
				new ValueTuple<string, object>("语句", "select BinData from `PropertyIndex`")
			});
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x0015B47F File Offset: 0x0015967F
		public static void ResetStaticDefaultValue()
		{
			ConfigPropertyIndexAll.LogPair = null;
			ConfigPropertyIndexAll.HandleId = 0;
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x0015B48D File Offset: 0x0015968D
		public static void Init()
		{
			ConfigPropertyIndexAll.HandleId = ConfigCommon.InitDataStatement(ConfigPropertyIndexAll.HandleId, "db_property.db", "select BinData from `PropertyIndex`");
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x0015B4A8 File Offset: 0x001596A8
		[NullableContext(2)]
		public static IReadOnlyList<PropertyIndex> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPropertyIndexAll.HandleId, ConfigPropertyIndexAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PropertyIndex> readOnlyList = (IReadOnlyList<PropertyIndex>)ConfigCommon.GetConfig("PropertyIndexAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PropertyIndex> list = new List<PropertyIndex>();
			while (ConfigCommon.Step(ConfigPropertyIndexAll.HandleId, false, ConfigPropertyIndexAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPropertyIndexAll.HandleId, 0, ConfigPropertyIndexAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPropertyIndexAll.HandleId, ConfigPropertyIndexAll.LogPair);
					return null;
				}
				PropertyIndex rootAsPropertyIndex = PropertyIndex.GetRootAsPropertyIndex(new ByteBuffer(item2));
				list.Add(rootAsPropertyIndex);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PropertyIndexAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPropertyIndexAll.HandleId, ConfigPropertyIndexAll.LogPair);
			return list;
		}

		// Token: 0x04003458 RID: 13400
		private const string DB = "db_property.db";

		// Token: 0x04003459 RID: 13401
		private const string FILE = "s.属性.xlsx";

		// Token: 0x0400345A RID: 13402
		private const string TABLE = "PropertyIndex";

		// Token: 0x0400345B RID: 13403
		private const string COMMAND = "select BinData from `PropertyIndex`";

		// Token: 0x0400345C RID: 13404
		private const string KEY_PREFIX = "PropertyIndexAll";

		// Token: 0x0400345D RID: 13405
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400345E RID: 13406
		private static int HandleId;
	}
}
