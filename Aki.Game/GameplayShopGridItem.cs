using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;

// Token: 0x0200234A RID: 9034
[NullableContext(1)]
[Nullable(0)]
public class GameplayShopGridItem : GameplayShopItem, IGridProxy<IGameplayShopItemProxy>
{
	// Token: 0x17001786 RID: 6022
	// (get) Token: 0x06011FA2 RID: 73634 RVA: 0x0046875F File Offset: 0x0046695F
	// (set) Token: 0x06011FA3 RID: 73635 RVA: 0x00468767 File Offset: 0x00466967
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<IGameplayShopItemProxy>, IGameplayShopItemProxy> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x17001787 RID: 6023
	// (get) Token: 0x06011FA4 RID: 73636 RVA: 0x00468770 File Offset: 0x00466970
	// (set) Token: 0x06011FA5 RID: 73637 RVA: 0x00468778 File Offset: 0x00466978
	public int GridIndex { get; set; }

	// Token: 0x17001788 RID: 6024
	// (get) Token: 0x06011FA6 RID: 73638 RVA: 0x00468781 File Offset: 0x00466981
	// (set) Token: 0x06011FA7 RID: 73639 RVA: 0x00468789 File Offset: 0x00466989
	public int DisplayIndex { get; set; }

	// Token: 0x06011FA8 RID: 73640 RVA: 0x00468792 File Offset: 0x00466992
	public void Refresh(IGameplayShopItemProxy data, bool isSelected, int gridIndex)
	{
		base.RefreshByData(data);
	}

	// Token: 0x06011FA9 RID: 73641 RVA: 0x0046879B File Offset: 0x0046699B
	public void Clear()
	{
	}

	// Token: 0x06011FAA RID: 73642 RVA: 0x0046879D File Offset: 0x0046699D
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x06011FAB RID: 73643 RVA: 0x0046879F File Offset: 0x0046699F
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x06011FAC RID: 73644 RVA: 0x004687A1 File Offset: 0x004669A1
	public object GetKey(IGameplayShopItemProxy data, int gridIndex)
	{
		return gridIndex;
	}
}
