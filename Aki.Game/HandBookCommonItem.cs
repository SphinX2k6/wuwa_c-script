using System;
using System.Runtime.CompilerServices;

// Token: 0x020012A9 RID: 4777
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HandBookCommonItem : LoopScrollSmallItemGrid<HandBookCommonItemData>
{
	// Token: 0x0600BD39 RID: 48441 RVA: 0x0037F1B8 File Offset: 0x0037D3B8
	[NullableContext(1)]
	protected override void OnRefresh(HandBookCommonItemData data, bool isSelected, int gridIndex)
	{
		this.HandBookCommonItemData = data;
		bool isLock = data.IsLock;
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			IsNotFoundVisible = new bool?(isLock),
			IsNewVisible = new bool?(data.IsNew),
			IconPath = (isLock ? null : data.Icon),
			QualityId = new int?(isLock ? 0 : data.QualityId)
		};
		base.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x0600BD3A RID: 48442 RVA: 0x0037F22D File Offset: 0x0037D42D
	public HandBookCommonItemData GetData()
	{
		return this.HandBookCommonItemData;
	}

	// Token: 0x0600BD3B RID: 48443 RVA: 0x0037F235 File Offset: 0x0037D435
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x0600BD3C RID: 48444 RVA: 0x0037F23F File Offset: 0x0037D43F
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x04006CED RID: 27885
	protected HandBookCommonItemData HandBookCommonItemData;
}
