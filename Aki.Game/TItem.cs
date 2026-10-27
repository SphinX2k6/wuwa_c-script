using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02002016 RID: 8214
public struct TItem : IEquatable<TItem>
{
	// Token: 0x060101A4 RID: 65956 RVA: 0x003EBE84 File Offset: 0x003EA084
	[NullableContext(1)]
	public TItem(InventoryDefine.IGetItemData itemData, int count)
	{
		this.ItemData = itemData;
		this.Count = count;
	}

	// Token: 0x060101A5 RID: 65957 RVA: 0x003EBE94 File Offset: 0x003EA094
	public readonly bool Equals(TItem other)
	{
		return this.ItemData.ItemId == other.ItemData.ItemId && this.ItemData.IncId == other.ItemData.IncId && this.Count == other.Count;
	}

	// Token: 0x060101A6 RID: 65958 RVA: 0x003EBEE1 File Offset: 0x003EA0E1
	public override readonly int GetHashCode()
	{
		return HashCode.Combine<int, int, int>(this.ItemData.ItemId, this.ItemData.IncId, this.Count);
	}

	// Token: 0x060101A7 RID: 65959 RVA: 0x003EBF04 File Offset: 0x003EA104
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

	// Token: 0x060101A8 RID: 65960 RVA: 0x003EBF29 File Offset: 0x003EA129
	public static bool operator ==(TItem left, TItem right)
	{
		return left.Equals(right);
	}

	// Token: 0x060101A9 RID: 65961 RVA: 0x003EBF33 File Offset: 0x003EA133
	public static bool operator !=(TItem left, TItem right)
	{
		return !left.Equals(right);
	}

	// Token: 0x0400773B RID: 30523
	[Nullable(1)]
	public InventoryDefine.IGetItemData ItemData;

	// Token: 0x0400773C RID: 30524
	public int Count;
}
