using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001FE7 RID: 8167
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ItemExchangeConfig : ConfigBase
{
	// Token: 0x06010000 RID: 65536 RVA: 0x003E6340 File Offset: 0x003E4540
	public IReadOnlyList<ItemExchangeContent> GetExChangeConfigList(int itemId)
	{
		IReadOnlyList<ItemExchangeContent> configList = ConfigItemExchangeContentAll.GetConfigList(true);
		List<ItemExchangeContent> list = new List<ItemExchangeContent>();
		if (configList != null)
		{
			foreach (ItemExchangeContent item in configList)
			{
				if (item.ItemId == itemId)
				{
					list.Add(item);
				}
			}
		}
		list.Sort((ItemExchangeContent a, ItemExchangeContent b) => a.Times - b.Times);
		return list;
	}

	// Token: 0x06010001 RID: 65537 RVA: 0x003E63C8 File Offset: 0x003E45C8
	public ItemExchangeContent? GetFirstExChangeConfigList(int itemId)
	{
		return ConfigItemExchangeContentByItemId.GetConfig(itemId, true);
	}

	// Token: 0x06010002 RID: 65538 RVA: 0x003E63D1 File Offset: 0x003E45D1
	public ItemExchangeLimit? GetItemExchangeLimit(int itemId)
	{
		return ConfigItemExchangeLimitByItemId.GetConfig(itemId, true);
	}

	// Token: 0x17001363 RID: 4963
	// (get) Token: 0x06010003 RID: 65539 RVA: 0x003E63DA File Offset: 0x003E45DA
	public static ItemExchangeConfig Instance
	{
		get
		{
			return ItemExchangeConfig._Instance;
		}
	}

	// Token: 0x06010004 RID: 65540 RVA: 0x003E63E1 File Offset: 0x003E45E1
	public static ItemExchangeConfig GetOrCreateInstance()
	{
		if (ItemExchangeConfig._Instance == null)
		{
			ItemExchangeConfig.CreateInstance();
		}
		return ItemExchangeConfig._Instance;
	}

	// Token: 0x06010005 RID: 65541 RVA: 0x003E63F5 File Offset: 0x003E45F5
	public static bool CreateInstance()
	{
		if (ItemExchangeConfig._Instance != null)
		{
			return true;
		}
		ItemExchangeConfig._Instance = new ItemExchangeConfig();
		return true;
	}

	// Token: 0x06010006 RID: 65542 RVA: 0x003E640B File Offset: 0x003E460B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010007 RID: 65543 RVA: 0x003E640D File Offset: 0x003E460D
	public static void ResetStaticDefaultValue()
	{
		ItemExchangeConfig._Instance = null;
	}

	// Token: 0x06010008 RID: 65544 RVA: 0x003E6415 File Offset: 0x003E4615
	static ItemExchangeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemExchangeConfig.CreateStaticDefaultValue), new Action(ItemExchangeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007677 RID: 30327
	[Nullable(2)]
	private static ItemExchangeConfig _Instance;
}
