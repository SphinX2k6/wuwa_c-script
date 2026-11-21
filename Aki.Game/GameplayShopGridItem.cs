using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;

// Token: 0x0200182F RID: 6191
[NullableContext(1)]
[Nullable(0)]
public class GameplayShopGridItem : GameplayShopItem, IGridProxy<IGameplayShopItemProxy>
{
	// Token: 0x170017C0 RID: 6080
	// (get) Token: 0x0600F452 RID: 62546 RVA: 0x00475827 File Offset: 0x00473A27
	// (set) Token: 0x0600F453 RID: 62547 RVA: 0x0047582F File Offset: 0x00473A2F
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

	// Token: 0x170017C1 RID: 6081
	// (get) Token: 0x0600F454 RID: 62548 RVA: 0x00475838 File Offset: 0x00473A38
	// (set) Token: 0x0600F455 RID: 62549 RVA: 0x00475840 File Offset: 0x00473A40
	public int GridIndex { get; set; }

	// Token: 0x170017C2 RID: 6082
	// (get) Token: 0x0600F456 RID: 62550 RVA: 0x00475849 File Offset: 0x00473A49
	// (set) Token: 0x0600F457 RID: 62551 RVA: 0x00475851 File Offset: 0x00473A51
	public int DisplayIndex { get; set; }

	// Token: 0x0600F458 RID: 62552 RVA: 0x0047585A File Offset: 0x00473A5A
	public void Refresh(IGameplayShopItemProxy data, bool isSelected, int gridIndex)
	{
		base.RefreshByData(data);
	}

	// Token: 0x0600F459 RID: 62553 RVA: 0x00475863 File Offset: 0x00473A63
	public void Clear()
	{
	}

	// Token: 0x0600F45A RID: 62554 RVA: 0x00475865 File Offset: 0x00473A65
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600F45B RID: 62555 RVA: 0x00475867 File Offset: 0x00473A67
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600F45C RID: 62556 RVA: 0x00475869 File Offset: 0x00473A69
	public object GetKey(IGameplayShopItemProxy data, int gridIndex)
	{
		return gridIndex;
	}
}
