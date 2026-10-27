using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DE7 RID: 7655
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HandBookCommonItem : LoopScrollSmallItemGrid<HandBookCommonItemData>
{
	// Token: 0x0600E91A RID: 59674 RVA: 0x003734B0 File Offset: 0x003716B0
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

	// Token: 0x0600E91B RID: 59675 RVA: 0x00373525 File Offset: 0x00371725
	public HandBookCommonItemData GetData()
	{
		return this.HandBookCommonItemData;
	}

	// Token: 0x0600E91C RID: 59676 RVA: 0x0037352D File Offset: 0x0037172D
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x0600E91D RID: 59677 RVA: 0x00373537 File Offset: 0x00371737
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x04006C0C RID: 27660
	protected HandBookCommonItemData HandBookCommonItemData;
}
