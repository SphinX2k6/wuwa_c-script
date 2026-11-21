using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x020020A1 RID: 8353
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsItemTabItem : LoopScrollMediumItemGrid<SurvivorsRogueItemCard>
{
	// Token: 0x06014929 RID: 84265 RVA: 0x005FEF60 File Offset: 0x005FD160
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

	// Token: 0x0601492A RID: 84266 RVA: 0x005FF011 File Offset: 0x005FD211
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, true);
		if (fireEvent)
		{
			this.OnExtendToggleStateChanged(this.GetItemGridExtendToggle().ToggleState);
		}
	}

	// Token: 0x0601492B RID: 84267 RVA: 0x005FF02F File Offset: 0x005FD22F
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x0601492C RID: 84268 RVA: 0x005FF039 File Offset: 0x005FD239
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		Action<SurvivorsRogueItemCard, SurvivorsItemTabItem> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack((SurvivorsRogueItemCard)this.Data, this);
	}

	// Token: 0x0400AEB9 RID: 44729
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<SurvivorsRogueItemCard, SurvivorsItemTabItem> OnClickCallBack;
}
