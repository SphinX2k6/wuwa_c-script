using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x02005834 RID: 22580
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemMainTypeMapping
	{
		// Token: 0x060395FB RID: 235003 RVA: 0x00D9DA14 File Offset: 0x00D9BC14
		public ItemMainTypeMapping(InventoryDefine.EItemMainTypeId itemMainType)
		{
			this.MainType = itemMainType;
		}

		// Token: 0x060395FC RID: 235004 RVA: 0x00D9DA2E File Offset: 0x00D9BC2E
		public void Add(ItemDataBase itemData)
		{
			this.ItemDataSet.Add(itemData);
		}

		// Token: 0x060395FD RID: 235005 RVA: 0x00D9DA3D File Offset: 0x00D9BC3D
		public void Remove(ItemDataBase itemData)
		{
			this.ItemDataSet.Remove(itemData);
		}

		// Token: 0x060395FE RID: 235006 RVA: 0x00D9DA4C File Offset: 0x00D9BC4C
		public HashSet<ItemDataBase> GetSet()
		{
			return this.ItemDataSet;
		}

		// Token: 0x060395FF RID: 235007 RVA: 0x00D9DA54 File Offset: 0x00D9BC54
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

		// Token: 0x0401E03C RID: 122940
		public readonly InventoryDefine.EItemMainTypeId MainType;

		// Token: 0x0401E03D RID: 122941
		private readonly HashSet<ItemDataBase> ItemDataSet = new HashSet<ItemDataBase>();
	}
}
