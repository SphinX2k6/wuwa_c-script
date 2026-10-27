using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200045D RID: 1117
	public class ConfigItemInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A38 RID: 6712 RVA: 0x000EDA69 File Offset: 0x000EBC69
		static ConfigItemInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemInfoAll.CreateStaticDefaultValue), new Action(ConfigItemInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x000EDA88 File Offset: 0x000EBC88
		public static void CreateStaticDefaultValue()
		{
			ConfigItemInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item.db"),
				new ValueTuple<string, object>("文件", "d.道具.xlsx"),
				new ValueTuple<string, object>("表名", "ItemInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemInfo`")
			});
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x000EDB07 File Offset: 0x000EBD07
		public static void ResetStaticDefaultValue()
		{
			ConfigItemInfoAll.LogPair = null;
			ConfigItemInfoAll.HandleId = 0;
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000EDB15 File Offset: 0x000EBD15
		public static void Init()
		{
			ConfigItemInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigItemInfoAll.HandleId, "db_item.db", "select BinData from `ItemInfo`");
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x000EDB30 File Offset: 0x000EBD30
		[NullableContext(2)]
		public static IReadOnlyList<ItemInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemInfoAll.HandleId, ConfigItemInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ItemInfo> readOnlyList = (IReadOnlyList<ItemInfo>)ConfigCommon.GetConfig("ItemInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ItemInfo> list = new List<ItemInfo>();
			while (ConfigCommon.Step(ConfigItemInfoAll.HandleId, false, ConfigItemInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemInfoAll.HandleId, 0, ConfigItemInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigItemInfoAll.HandleId, ConfigItemInfoAll.LogPair);
					return null;
				}
				ItemInfo rootAsItemInfo = ItemInfo.GetRootAsItemInfo(new ByteBuffer(item2));
				list.Add(rootAsItemInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ItemInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigItemInfoAll.HandleId, ConfigItemInfoAll.LogPair);
			return list;
		}

		// Token: 0x04001E6F RID: 7791
		private const string DB = "db_item.db";

		// Token: 0x04001E70 RID: 7792
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04001E71 RID: 7793
		private const string TABLE = "ItemInfo";

		// Token: 0x04001E72 RID: 7794
		private const string COMMAND = "select BinData from `ItemInfo`";

		// Token: 0x04001E73 RID: 7795
		private const string KEY_PREFIX = "ItemInfoAll";

		// Token: 0x04001E74 RID: 7796
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E75 RID: 7797
		private static int HandleId;
	}
}
