using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000473 RID: 1139
	public class ConfigItemInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001ABC RID: 6844 RVA: 0x000F41BD File Offset: 0x000F23BD
		static ConfigItemInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemInfoAll.CreateStaticDefaultValue), new Action(ConfigItemInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x000F41DC File Offset: 0x000F23DC
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

		// Token: 0x06001ABE RID: 6846 RVA: 0x000F425B File Offset: 0x000F245B
		public static void ResetStaticDefaultValue()
		{
			ConfigItemInfoAll.LogPair = null;
			ConfigItemInfoAll.HandleId = 0;
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x000F4269 File Offset: 0x000F2469
		public static void Init()
		{
			ConfigItemInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigItemInfoAll.HandleId, "db_item.db", "select BinData from `ItemInfo`");
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x000F4284 File Offset: 0x000F2484
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

		// Token: 0x04001F09 RID: 7945
		private const string DB = "db_item.db";

		// Token: 0x04001F0A RID: 7946
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04001F0B RID: 7947
		private const string TABLE = "ItemInfo";

		// Token: 0x04001F0C RID: 7948
		private const string COMMAND = "select BinData from `ItemInfo`";

		// Token: 0x04001F0D RID: 7949
		private const string KEY_PREFIX = "ItemInfoAll";

		// Token: 0x04001F0E RID: 7950
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F0F RID: 7951
		private static int HandleId;
	}
}
