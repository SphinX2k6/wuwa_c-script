using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001FFB RID: 8187
[NullableContext(1)]
[Nullable(0)]
public class ItemMainTypeMapping
{
	// Token: 0x060100AE RID: 65710 RVA: 0x003E9495 File Offset: 0x003E7695
	public ItemMainTypeMapping(InventoryDefine.EItemMainTypeId itemMainType)
	{
		this.MainType = itemMainType;
	}

	// Token: 0x060100AF RID: 65711 RVA: 0x003E94AF File Offset: 0x003E76AF
	public void Add(ItemDataBase itemData)
	{
		this.ItemDataSet.Add(itemData);
	}

	// Token: 0x060100B0 RID: 65712 RVA: 0x003E94BE File Offset: 0x003E76BE
	public void Remove(ItemDataBase itemData)
	{
		this.ItemDataSet.Remove(itemData);
	}

	// Token: 0x060100B1 RID: 65713 RVA: 0x003E94CD File Offset: 0x003E76CD
	public HashSet<ItemDataBase> GetSet()
	{
		return this.ItemDataSet;
	}

	// Token: 0x060100B2 RID: 65714 RVA: 0x003E94D8 File Offset: 0x003E76D8
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

	// Token: 0x040076BA RID: 30394
	public readonly InventoryDefine.EItemMainTypeId MainType;

	// Token: 0x040076BB RID: 30395
	private readonly HashSet<ItemDataBase> ItemDataSet = new HashSet<ItemDataBase>();
}
