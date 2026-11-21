using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000470 RID: 1136
	public class ConfigItemHandBookTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AAA RID: 6826 RVA: 0x000F3BE7 File Offset: 0x000F1DE7
		static ConfigItemHandBookTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemHandBookTypeAll.CreateStaticDefaultValue), new Action(ConfigItemHandBookTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x000F3C08 File Offset: 0x000F1E08
		public static void CreateStaticDefaultValue()
		{
			ConfigItemHandBookTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemHandBookTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "ItemHandBookType"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemHandBookType`")
			});
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x000F3C87 File Offset: 0x000F1E87
		public static void ResetStaticDefaultValue()
		{
			ConfigItemHandBookTypeAll.LogPair = null;
			ConfigItemHandBookTypeAll.HandleId = 0;
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000F3C95 File Offset: 0x000F1E95
		public static void Init()
		{
			ConfigItemHandBookTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigItemHandBookTypeAll.HandleId, "db_handbook.db", "select BinData from `ItemHandBookType`");
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x000F3CB0 File Offset: 0x000F1EB0
		[NullableContext(2)]
		public static IReadOnlyList<ItemHandBookType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemHandBookTypeAll.HandleId, ConfigItemHandBookTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ItemHandBookType> readOnlyList = (IReadOnlyList<ItemHandBookType>)ConfigCommon.GetConfig("ItemHandBookTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ItemHandBookType> list = new List<ItemHandBookType>();
			while (ConfigCommon.Step(ConfigItemHandBookTypeAll.HandleId, false, ConfigItemHandBookTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemHandBookTypeAll.HandleId, 0, ConfigItemHandBookTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigItemHandBookTypeAll.HandleId, ConfigItemHandBookTypeAll.LogPair);
					return null;
				}
				ItemHandBookType rootAsItemHandBookType = ItemHandBookType.GetRootAsItemHandBookType(new ByteBuffer(item2));
				list.Add(rootAsItemHandBookType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ItemHandBookTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigItemHandBookTypeAll.HandleId, ConfigItemHandBookTypeAll.LogPair);
			return list;
		}

		// Token: 0x04001EF4 RID: 7924
		private const string DB = "db_handbook.db";

		// Token: 0x04001EF5 RID: 7925
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001EF6 RID: 7926
		private const string TABLE = "ItemHandBookType";

		// Token: 0x04001EF7 RID: 7927
		private const string COMMAND = "select BinData from `ItemHandBookType`";

		// Token: 0x04001EF8 RID: 7928
		private const string KEY_PREFIX = "ItemHandBookTypeAll";

		// Token: 0x04001EF9 RID: 7929
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EFA RID: 7930
		private static int HandleId;
	}
}
