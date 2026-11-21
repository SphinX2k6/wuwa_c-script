using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001FDE RID: 8158
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeaponSkinPreviewGridItem : LoopScrollSmallItemGrid<WeaponSkinData>
{
	// Token: 0x0601440B RID: 82955 RVA: 0x005E7D8A File Offset: 0x005E5F8A
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			this.SetSelected(true, true);
		}
	}

	// Token: 0x0601440C RID: 82956 RVA: 0x005E7D97 File Offset: 0x005E5F97
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x0601440D RID: 82957 RVA: 0x005E7DA4 File Offset: 0x005E5FA4
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
