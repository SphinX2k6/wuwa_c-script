using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020014CE RID: 5326
[NullableContext(1)]
[Nullable(0)]
public class ItemMainTypeMapping
{
	// Token: 0x0600D516 RID: 54550 RVA: 0x003F5A8D File Offset: 0x003F3C8D
	public ItemMainTypeMapping(InventoryDefine.EItemMainTypeId itemMainType)
	{
		this.MainType = itemMainType;
	}

	// Token: 0x0600D517 RID: 54551 RVA: 0x003F5AA7 File Offset: 0x003F3CA7
	public void Add(ItemDataBase itemData)
	{
		this.ItemDataSet.Add(itemData);
	}

	// Token: 0x0600D518 RID: 54552 RVA: 0x003F5AB6 File Offset: 0x003F3CB6
	public void Remove(ItemDataBase itemData)
	{
		this.ItemDataSet.Remove(itemData);
	}

	// Token: 0x0600D519 RID: 54553 RVA: 0x003F5AC5 File Offset: 0x003F3CC5
	public HashSet<ItemDataBase> GetSet()
	{
		return this.ItemDataSet;
	}

	// Token: 0x0600D51A RID: 54554 RVA: 0x003F5AD0 File Offset: 0x003F3CD0
	public bool HasRedDot()
	{
		using (HashSet<ItemDataBase>.Enumerator enumerator = this.ItemDataSet.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.HasRedDot())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x040077A3 RID: 30627
	public readonly InventoryDefine.EItemMainTypeId MainType;

	// Token: 0x040077A4 RID: 30628
	private readonly HashSet<ItemDataBase> ItemDataSet = new HashSet<ItemDataBase>();
}
