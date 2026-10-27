using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000460 RID: 1120
	public class ConfigItemMainTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A4A RID: 6730 RVA: 0x000EE07B File Offset: 0x000EC27B
		static ConfigItemMainTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemMainTypeAll.CreateStaticDefaultValue), new Action(ConfigItemMainTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x000EE09C File Offset: 0x000EC29C
		public static void CreateStaticDefaultValue()
		{
			ConfigItemMainTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemMainTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bag.db"),
				new ValueTuple<string, object>("文件", "b.背包.xlsx"),
				new ValueTuple<string, object>("表名", "ItemMainType"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemMainType`")
			});
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x000EE11B File Offset: 0x000EC31B
		public static void ResetStaticDefaultValue()
		{
			ConfigItemMainTypeAll.LogPair = null;
			ConfigItemMainTypeAll.HandleId = 0;
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x000EE129 File Offset: 0x000EC329
		public static void Init()
		{
			ConfigItemMainTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigItemMainTypeAll.HandleId, "db_bag.db", "select BinData from `ItemMainType`");
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x000EE144 File Offset: 0x000EC344
		[NullableContext(2)]
		public static IReadOnlyList<ItemMainType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemMainTypeAll.HandleId, ConfigItemMainTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ItemMainType> readOnlyList = (IReadOnlyList<ItemMainType>)ConfigCommon.GetConfig("ItemMainTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ItemMainType> list = new List<ItemMainType>();
			while (ConfigCommon.Step(ConfigItemMainTypeAll.HandleId, false, ConfigItemMainTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemMainTypeAll.HandleId, 0, ConfigItemMainTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigItemMainTypeAll.HandleId, ConfigItemMainTypeAll.LogPair);
					return null;
				}
				ItemMainType rootAsItemMainType = ItemMainType.GetRootAsItemMainType(new ByteBuffer(item2));
				list.Add(rootAsItemMainType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ItemMainTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigItemMainTypeAll.HandleId, ConfigItemMainTypeAll.LogPair);
			return list;
		}

		// Token: 0x04001E84 RID: 7812
		private const string DB = "db_bag.db";

		// Token: 0x04001E85 RID: 7813
		private const string FILE = "b.背包.xlsx";

		// Token: 0x04001E86 RID: 7814
		private const string TABLE = "ItemMainType";

		// Token: 0x04001E87 RID: 7815
		private const string COMMAND = "select BinData from `ItemMainType`";

		// Token: 0x04001E88 RID: 7816
		private const string KEY_PREFIX = "ItemMainTypeAll";

		// Token: 0x04001E89 RID: 7817
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E8A RID: 7818
		private static int HandleId;
	}
}
