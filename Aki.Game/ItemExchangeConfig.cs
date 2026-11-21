using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020014BA RID: 5306
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ItemExchangeConfig : ConfigBase
{
	// Token: 0x0600D468 RID: 54376 RVA: 0x003F2940 File Offset: 0x003F0B40
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

	// Token: 0x0600D469 RID: 54377 RVA: 0x003F29C8 File Offset: 0x003F0BC8
	public ItemExchangeContent? GetFirstExChangeConfigList(int itemId)
	{
		return ConfigItemExchangeContentByItemId.GetConfig(itemId, true);
	}

	// Token: 0x0600D46A RID: 54378 RVA: 0x003F29D1 File Offset: 0x003F0BD1
	public ItemExchangeLimit? GetItemExchangeLimit(int itemId)
	{
		return ConfigItemExchangeLimitByItemId.GetConfig(itemId, true);
	}

	// Token: 0x17001390 RID: 5008
	// (get) Token: 0x0600D46B RID: 54379 RVA: 0x003F29DA File Offset: 0x003F0BDA
	public static ItemExchangeConfig Instance
	{
		get
		{
			return ItemExchangeConfig._Instance;
		}
	}

	// Token: 0x0600D46C RID: 54380 RVA: 0x003F29E1 File Offset: 0x003F0BE1
	public static ItemExchangeConfig GetOrCreateInstance()
	{
		if (ItemExchangeConfig._Instance == null)
		{
			ItemExchangeConfig.CreateInstance();
		}
		return ItemExchangeConfig._Instance;
	}

	// Token: 0x0600D46D RID: 54381 RVA: 0x003F29F5 File Offset: 0x003F0BF5
	public static bool CreateInstance()
	{
		if (ItemExchangeConfig._Instance != null)
		{
			return true;
		}
		ItemExchangeConfig._Instance = new ItemExchangeConfig();
		return true;
	}

	// Token: 0x0600D46E RID: 54382 RVA: 0x003F2A0B File Offset: 0x003F0C0B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D46F RID: 54383 RVA: 0x003F2A0D File Offset: 0x003F0C0D
	public static void ResetStaticDefaultValue()
	{
		ItemExchangeConfig._Instance = null;
	}

	// Token: 0x0600D470 RID: 54384 RVA: 0x003F2A15 File Offset: 0x003F0C15
	static ItemExchangeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemExchangeConfig.CreateStaticDefaultValue), new Action(ItemExchangeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007760 RID: 30560
	[Nullable(2)]
	private static ItemExchangeConfig _Instance;
}
