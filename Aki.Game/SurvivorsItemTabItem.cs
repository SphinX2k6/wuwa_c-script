using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02002B25 RID: 11045
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsItemTabItem : LoopScrollMediumItemGrid<SurvivorsRogueItemCard>
{
	// Token: 0x06016EF8 RID: 93944 RVA: 0x005D23E4 File Offset: 0x005D05E4
	protected override void OnRefresh(SurvivorsRogueItemCard data, bool isSelected, int gridIndex)
	{
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = data,
			QualityId = new int?(data.QualityId),
			IconPath = SurvivorsRogueConfig.Instance.GetSurvivorsItem(data.Id).Value.Icon,
			IsNewVisible = new bool?(!data.LockState.GetValueOrDefault() && data.IsNew.GetValueOrDefault()),
			BottomTextId = data.TitleId,
			IsProhibit = new bool?(data.LockState.GetValueOrDefault())
		};
		base.Apply<PropMediumItemGrid>(parameters);
		this.SetSelected(isSelected, true);
	}

	// Token: 0x06016EF9 RID: 93945 RVA: 0x005D2495 File Offset: 0x005D0695
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, true);
		if (fireEvent)
		{
			this.OnExtendToggleStateChanged(this.GetItemGridExtendToggle().ToggleState);
		}
	}

	// Token: 0x06016EFA RID: 93946 RVA: 0x005D24B3 File Offset: 0x005D06B3
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06016EFB RID: 93947 RVA: 0x005D24BD File Offset: 0x005D06BD
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		Action<SurvivorsRogueItemCard, SurvivorsItemTabItem> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack((SurvivorsRogueItemCard)this.Data, this);
	}

	// Token: 0x0400AAB3 RID: 43699
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<SurvivorsRogueItemCard, SurvivorsItemTabItem> OnClickCallBack;
}
