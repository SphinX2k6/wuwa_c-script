using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A63 RID: 10851
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeaponSkinPreviewGridItem : LoopScrollSmallItemGrid<WeaponSkinData>
{
	// Token: 0x060169EA RID: 92650 RVA: 0x005BBC02 File Offset: 0x005B9E02
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			this.SetSelected(true, true);
		}
	}

	// Token: 0x060169EB RID: 92651 RVA: 0x005BBC0F File Offset: 0x005B9E0F
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x060169EC RID: 92652 RVA: 0x005BBC1C File Offset: 0x005B9E1C
	protected override void OnRefresh(WeaponSkinData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			IconPath = (data.IsEmptyData ? SkinConfig.Instance.GetDefaultWeaponSkinIconPath() : null),
			ItemConfigId = (data.IsEmptyData ? null : new int?(data.SkinId)),
			IsNewVisible = new bool?(false)
		};
		base.Apply<PropSmallItemGrid>(parameters);
		this.SetSelected(isSelected, false);
	}
}
