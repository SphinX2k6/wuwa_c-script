using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x0200480B RID: 18443
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemMainTypeMapping
	{
		// Token: 0x0602E50F RID: 189711 RVA: 0x00CEC8D4 File Offset: 0x00CEAAD4
		public ItemMainTypeMapping(InventoryDefine.EItemMainTypeId itemMainType)
		{
			this.MainType = itemMainType;
		}

		// Token: 0x0602E510 RID: 189712 RVA: 0x00CEC8EE File Offset: 0x00CEAAEE
		public void Add(ItemDataBase itemData)
		{
			this.ItemDataSet.Add(itemData);
		}

		// Token: 0x0602E511 RID: 189713 RVA: 0x00CEC8FD File Offset: 0x00CEAAFD
		public void Remove(ItemDataBase itemData)
		{
			this.ItemDataSet.Remove(itemData);
		}

		// Token: 0x0602E512 RID: 189714 RVA: 0x00CEC90C File Offset: 0x00CEAB0C
		public HashSet<ItemDataBase> GetSet()
		{
			return this.ItemDataSet;
		}

		// Token: 0x0602E513 RID: 189715 RVA: 0x00CEC914 File Offset: 0x00CEAB14
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

		// Token: 0x04018AD5 RID: 101077
		public readonly InventoryDefine.EItemMainTypeId MainType;

		// Token: 0x04018AD6 RID: 101078
		private readonly HashSet<ItemDataBase> ItemDataSet = new HashSet<ItemDataBase>();
	}
}
