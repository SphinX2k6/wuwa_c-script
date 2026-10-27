using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000764 RID: 1892
	public class ConfigPropertyIndexAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C69 RID: 11369 RVA: 0x001544D4 File Offset: 0x001526D4
		static ConfigPropertyIndexAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPropertyIndexAll.CreateStaticDefaultValue), new Action(ConfigPropertyIndexAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x001544F4 File Offset: 0x001526F4
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

		// Token: 0x06002C6B RID: 11371 RVA: 0x00154573 File Offset: 0x00152773
		public static void ResetStaticDefaultValue()
		{
			ConfigPropertyIndexAll.LogPair = null;
			ConfigPropertyIndexAll.HandleId = 0;
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x00154581 File Offset: 0x00152781
		public static void Init()
		{
			ConfigPropertyIndexAll.HandleId = ConfigCommon.InitDataStatement(ConfigPropertyIndexAll.HandleId, "db_property.db", "select BinData from `PropertyIndex`");
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x0015459C File Offset: 0x0015279C
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

		// Token: 0x040033A2 RID: 13218
		private const string DB = "db_property.db";

		// Token: 0x040033A3 RID: 13219
		private const string FILE = "s.属性.xlsx";

		// Token: 0x040033A4 RID: 13220
		private const string TABLE = "PropertyIndex";

		// Token: 0x040033A5 RID: 13221
		private const string COMMAND = "select BinData from `PropertyIndex`";

		// Token: 0x040033A6 RID: 13222
		private const string KEY_PREFIX = "PropertyIndexAll";

		// Token: 0x040033A7 RID: 13223
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033A8 RID: 13224
		private static int HandleId;
	}
}
