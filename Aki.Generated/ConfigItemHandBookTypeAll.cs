using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200045A RID: 1114
	public class ConfigItemHandBookTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A26 RID: 6694 RVA: 0x000ED493 File Offset: 0x000EB693
		static ConfigItemHandBookTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemHandBookTypeAll.CreateStaticDefaultValue), new Action(ConfigItemHandBookTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x000ED4B4 File Offset: 0x000EB6B4
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

		// Token: 0x06001A28 RID: 6696 RVA: 0x000ED533 File Offset: 0x000EB733
		public static void ResetStaticDefaultValue()
		{
			ConfigItemHandBookTypeAll.LogPair = null;
			ConfigItemHandBookTypeAll.HandleId = 0;
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x000ED541 File Offset: 0x000EB741
		public static void Init()
		{
			ConfigItemHandBookTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigItemHandBookTypeAll.HandleId, "db_handbook.db", "select BinData from `ItemHandBookType`");
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x000ED55C File Offset: 0x000EB75C
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

		// Token: 0x04001E5A RID: 7770
		private const string DB = "db_handbook.db";

		// Token: 0x04001E5B RID: 7771
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001E5C RID: 7772
		private const string TABLE = "ItemHandBookType";

		// Token: 0x04001E5D RID: 7773
		private const string COMMAND = "select BinData from `ItemHandBookType`";

		// Token: 0x04001E5E RID: 7774
		private const string KEY_PREFIX = "ItemHandBookTypeAll";

		// Token: 0x04001E5F RID: 7775
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E60 RID: 7776
		private static int HandleId;
	}
}
