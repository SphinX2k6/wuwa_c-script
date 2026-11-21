using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200046A RID: 1130
	public class ConfigItemExchangeContentAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A86 RID: 6790 RVA: 0x000F2FB0 File Offset: 0x000F11B0
		static ConfigItemExchangeContentAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemExchangeContentAll.CreateStaticDefaultValue), new Action(ConfigItemExchangeContentAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x000F2FD0 File Offset: 0x000F11D0
		public static void CreateStaticDefaultValue()
		{
			ConfigItemExchangeContentAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemExchangeContentAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item_exchange.db"),
				new ValueTuple<string, object>("文件", "d.道具兑换.xlsx"),
				new ValueTuple<string, object>("表名", "ItemExchangeContent"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemExchangeContent`")
			});
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x000F304F File Offset: 0x000F124F
		public static void ResetStaticDefaultValue()
		{
			ConfigItemExchangeContentAll.LogPair = null;
			ConfigItemExchangeContentAll.HandleId = 0;
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x000F305D File Offset: 0x000F125D
		public static void Init()
		{
			ConfigItemExchangeContentAll.HandleId = ConfigCommon.InitDataStatement(ConfigItemExchangeContentAll.HandleId, "db_item_exchange.db", "select BinData from `ItemExchangeContent`");
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x000F3078 File Offset: 0x000F1278
		[NullableContext(2)]
		public static IReadOnlyList<ItemExchangeContent> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemExchangeContentAll.HandleId, ConfigItemExchangeContentAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ItemExchangeContent> readOnlyList = (IReadOnlyList<ItemExchangeContent>)ConfigCommon.GetConfig("ItemExchangeContentAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ItemExchangeContent> list = new List<ItemExchangeContent>();
			while (ConfigCommon.Step(ConfigItemExchangeContentAll.HandleId, false, ConfigItemExchangeContentAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemExchangeContentAll.HandleId, 0, ConfigItemExchangeContentAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigItemExchangeContentAll.HandleId, ConfigItemExchangeContentAll.LogPair);
					return null;
				}
				ItemExchangeContent rootAsItemExchangeContent = ItemExchangeContent.GetRootAsItemExchangeContent(new ByteBuffer(item2));
				list.Add(rootAsItemExchangeContent);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ItemExchangeContentAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigItemExchangeContentAll.HandleId, ConfigItemExchangeContentAll.LogPair);
			return list;
		}

		// Token: 0x04001ECA RID: 7882
		private const string DB = "db_item_exchange.db";

		// Token: 0x04001ECB RID: 7883
		private const string FILE = "d.道具兑换.xlsx";

		// Token: 0x04001ECC RID: 7884
		private const string TABLE = "ItemExchangeContent";

		// Token: 0x04001ECD RID: 7885
		private const string COMMAND = "select BinData from `ItemExchangeContent`";

		// Token: 0x04001ECE RID: 7886
		private const string KEY_PREFIX = "ItemExchangeContentAll";

		// Token: 0x04001ECF RID: 7887
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001ED0 RID: 7888
		private static int HandleId;
	}
}
