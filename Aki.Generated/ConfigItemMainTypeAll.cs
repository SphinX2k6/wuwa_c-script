using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000476 RID: 1142
	public class ConfigItemMainTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001ACE RID: 6862 RVA: 0x000F47CF File Offset: 0x000F29CF
		static ConfigItemMainTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemMainTypeAll.CreateStaticDefaultValue), new Action(ConfigItemMainTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x000F47F0 File Offset: 0x000F29F0
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

		// Token: 0x06001AD0 RID: 6864 RVA: 0x000F486F File Offset: 0x000F2A6F
		public static void ResetStaticDefaultValue()
		{
			ConfigItemMainTypeAll.LogPair = null;
			ConfigItemMainTypeAll.HandleId = 0;
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x000F487D File Offset: 0x000F2A7D
		public static void Init()
		{
			ConfigItemMainTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigItemMainTypeAll.HandleId, "db_bag.db", "select BinData from `ItemMainType`");
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x000F4898 File Offset: 0x000F2A98
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

		// Token: 0x04001F1E RID: 7966
		private const string DB = "db_bag.db";

		// Token: 0x04001F1F RID: 7967
		private const string FILE = "b.背包.xlsx";

		// Token: 0x04001F20 RID: 7968
		private const string TABLE = "ItemMainType";

		// Token: 0x04001F21 RID: 7969
		private const string COMMAND = "select BinData from `ItemMainType`";

		// Token: 0x04001F22 RID: 7970
		private const string KEY_PREFIX = "ItemMainTypeAll";

		// Token: 0x04001F23 RID: 7971
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F24 RID: 7972
		private static int HandleId;
	}
}
