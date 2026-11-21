using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020014E9 RID: 5353
public struct TItem : IEquatable<TItem>
{
	// Token: 0x0600D60C RID: 54796 RVA: 0x003F847C File Offset: 0x003F667C
	[NullableContext(1)]
	public TItem(InventoryDefine.IGetItemData itemData, int count)
	{
		this.ItemData = itemData;
		this.Count = count;
	}

	// Token: 0x0600D60D RID: 54797 RVA: 0x003F848C File Offset: 0x003F668C
	public readonly bool Equals(TItem other)
	{
		return this.ItemData.ItemId == other.ItemData.ItemId && this.ItemData.IncId == other.ItemData.IncId && this.Count == other.Count;
	}

	// Token: 0x0600D60E RID: 54798 RVA: 0x003F84D9 File Offset: 0x003F66D9
	public override readonly int GetHashCode()
	{
		return HashCode.Combine<int, int, int>(this.ItemData.ItemId, this.ItemData.IncId, this.Count);
	}

	// Token: 0x0600D60F RID: 54799 RVA: 0x003F84FC File Offset: 0x003F66FC
	[NullableContext(2)]
	public override readonly bool Equals(object obj)
	{
		if (obj is TItem)
		{
			TItem other = (TItem)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x0600D610 RID: 54800 RVA: 0x003F8521 File Offset: 0x003F6721
	public static bool operator ==(TItem left, TItem right)
	{
		return left.Equals(right);
	}

	// Token: 0x0600D611 RID: 54801 RVA: 0x003F852B File Offset: 0x003F672B
	public static bool operator !=(TItem left, TItem right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04007824 RID: 30756
	[Nullable(1)]
	public InventoryDefine.IGetItemData ItemData;

	// Token: 0x04007825 RID: 30757
	public int Count;
}
