using System;
using System.Runtime.CompilerServices;

// Token: 0x02002D18 RID: 11544
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeaponItemSmallItemGrid : LoopScrollSmallItemGrid<WeaponDataBase>
{
	// Token: 0x06018430 RID: 99376 RVA: 0x0062C46E File Offset: 0x0062A66E
	protected override void OnRefresh(WeaponDataBase data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06018431 RID: 99377 RVA: 0x0062C478 File Offset: 0x0062A678
	public void Refresh(WeaponDataBase data)
	{
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.GetItemId())
		};
		base.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x06018432 RID: 99378 RVA: 0x0062C4AA File Offset: 0x0062A6AA
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}
}
