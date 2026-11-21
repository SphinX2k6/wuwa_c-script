using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;

// Token: 0x02000C15 RID: 3093
[NullableContext(1)]
[Nullable(0)]
public class VisionRecoverySlotGridItem : VisionRecoverySlotItem, IGridProxy<PhantomItemData>
{
	// Token: 0x060080F4 RID: 33012 RVA: 0x00278CA0 File Offset: 0x00276EA0
	[NullableContext(2)]
	public VisionRecoverySlotGridItem(Action<bool, PhantomItemData> callBack = null, bool showRemoveBtn = true) : base(callBack, showRemoveBtn)
	{
	}

	// Token: 0x060080F5 RID: 33013 RVA: 0x00278CAA File Offset: 0x00276EAA
	public void Refresh(PhantomItemData data, bool isSelected, int gridIndex)
	{
		base.RefreshUi(data);
	}

	// Token: 0x17000E88 RID: 3720
	// (get) Token: 0x060080F6 RID: 33014 RVA: 0x00278CB3 File Offset: 0x00276EB3
	// (set) Token: 0x060080F7 RID: 33015 RVA: 0x00278CBB File Offset: 0x00276EBB
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<PhantomItemData>, PhantomItemData> ScrollViewDelegate { [return: Nullable(new byte[]
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

	// Token: 0x17000E89 RID: 3721
	// (get) Token: 0x060080F8 RID: 33016 RVA: 0x00278CC4 File Offset: 0x00276EC4
	// (set) Token: 0x060080F9 RID: 33017 RVA: 0x00278CCC File Offset: 0x00276ECC
	public int GridIndex { get; set; }

	// Token: 0x17000E8A RID: 3722
	// (get) Token: 0x060080FA RID: 33018 RVA: 0x00278CD5 File Offset: 0x00276ED5
	// (set) Token: 0x060080FB RID: 33019 RVA: 0x00278CDD File Offset: 0x00276EDD
	public int DisplayIndex { get; set; }

	// Token: 0x060080FC RID: 33020 RVA: 0x00278CE6 File Offset: 0x00276EE6
	public void Clear()
	{
	}

	// Token: 0x060080FD RID: 33021 RVA: 0x00278CE8 File Offset: 0x00276EE8
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x060080FE RID: 33022 RVA: 0x00278CEA File Offset: 0x00276EEA
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x060080FF RID: 33023 RVA: 0x00278CEC File Offset: 0x00276EEC
	public object GetKey(PhantomItemData data, int gridIndex)
	{
		return this.GridIndex;
	}
}
