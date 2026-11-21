using System;
using System.Runtime.CompilerServices;

// Token: 0x02002272 RID: 8818
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeaponItemSmallItemGrid : LoopScrollSmallItemGrid<WeaponDataBase>
{
	// Token: 0x06015CD1 RID: 89297 RVA: 0x00652462 File Offset: 0x00650662
	protected override void OnRefresh(WeaponDataBase data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06015CD2 RID: 89298 RVA: 0x0065246C File Offset: 0x0065066C
	public void Refresh(WeaponDataBase data)
	{
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.GetItemId())
		};
		base.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x06015CD3 RID: 89299 RVA: 0x0065249E File Offset: 0x0065069E
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}
}
