using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;

// Token: 0x0200175C RID: 5980
[NullableContext(1)]
[Nullable(0)]
public class VisionRecoverySlotGridItem : VisionRecoverySlotItem, IGridProxy<PhantomItemData>
{
	// Token: 0x0600AD0D RID: 44301 RVA: 0x0026E82C File Offset: 0x0026CA2C
	[NullableContext(2)]
	public VisionRecoverySlotGridItem(Action<bool, PhantomItemData> callBack = null, bool showRemoveBtn = true) : base(callBack, showRemoveBtn)
	{
	}

	// Token: 0x0600AD0E RID: 44302 RVA: 0x0026E836 File Offset: 0x0026CA36
	public void Refresh(PhantomItemData data, bool isSelected, int gridIndex)
	{
		base.RefreshUi(data);
	}

	// Token: 0x17000E65 RID: 3685
	// (get) Token: 0x0600AD0F RID: 44303 RVA: 0x0026E83F File Offset: 0x0026CA3F
	// (set) Token: 0x0600AD10 RID: 44304 RVA: 0x0026E847 File Offset: 0x0026CA47
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

	// Token: 0x17000E66 RID: 3686
	// (get) Token: 0x0600AD11 RID: 44305 RVA: 0x0026E850 File Offset: 0x0026CA50
	// (set) Token: 0x0600AD12 RID: 44306 RVA: 0x0026E858 File Offset: 0x0026CA58
	public int GridIndex { get; set; }

	// Token: 0x17000E67 RID: 3687
	// (get) Token: 0x0600AD13 RID: 44307 RVA: 0x0026E861 File Offset: 0x0026CA61
	// (set) Token: 0x0600AD14 RID: 44308 RVA: 0x0026E869 File Offset: 0x0026CA69
	public int DisplayIndex { get; set; }

	// Token: 0x0600AD15 RID: 44309 RVA: 0x0026E872 File Offset: 0x0026CA72
	public void Clear()
	{
	}

	// Token: 0x0600AD16 RID: 44310 RVA: 0x0026E874 File Offset: 0x0026CA74
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600AD17 RID: 44311 RVA: 0x0026E876 File Offset: 0x0026CA76
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600AD18 RID: 44312 RVA: 0x0026E878 File Offset: 0x0026CA78
	public object GetKey(PhantomItemData data, int gridIndex)
	{
		return this.GridIndex;
	}
}
