using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000454 RID: 1108
	public class ConfigItemExchangeContentAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A02 RID: 6658 RVA: 0x000EC85C File Offset: 0x000EAA5C
		static ConfigItemExchangeContentAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemExchangeContentAll.CreateStaticDefaultValue), new Action(ConfigItemExchangeContentAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x000EC87C File Offset: 0x000EAA7C
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

		// Token: 0x06001A04 RID: 6660 RVA: 0x000EC8FB File Offset: 0x000EAAFB
		public static void ResetStaticDefaultValue()
		{
			ConfigItemExchangeContentAll.LogPair = null;
			ConfigItemExchangeContentAll.HandleId = 0;
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x000EC909 File Offset: 0x000EAB09
		public static void Init()
		{
			ConfigItemExchangeContentAll.HandleId = ConfigCommon.InitDataStatement(ConfigItemExchangeContentAll.HandleId, "db_item_exchange.db", "select BinData from `ItemExchangeContent`");
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x000EC924 File Offset: 0x000EAB24
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

		// Token: 0x04001E30 RID: 7728
		private const string DB = "db_item_exchange.db";

		// Token: 0x04001E31 RID: 7729
		private const string FILE = "d.道具兑换.xlsx";

		// Token: 0x04001E32 RID: 7730
		private const string TABLE = "ItemExchangeContent";

		// Token: 0x04001E33 RID: 7731
		private const string COMMAND = "select BinData from `ItemExchangeContent`";

		// Token: 0x04001E34 RID: 7732
		private const string KEY_PREFIX = "ItemExchangeContentAll";

		// Token: 0x04001E35 RID: 7733
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E36 RID: 7734
		private static int HandleId;
	}
}
