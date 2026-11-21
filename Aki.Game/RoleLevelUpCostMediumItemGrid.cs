using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001DFD RID: 7677
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleLevelUpCostMediumItemGrid : LoopScrollMediumItemGrid<ISelectedData>
{
	// Token: 0x06012F78 RID: 77688 RVA: 0x0058E038 File Offset: 0x0058C238
	protected override void OnRefresh(ISelectedData data, bool isSelected, int gridIndex)
	{
		int selectedCount = data.SelectedCount;
		int count = data.Count;
		string text;
		if (data.Count != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(selectedCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			text = "0";
		}
		string bottomText = text;
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.ItemId),
			ReduceButtonInfo = new LongPressButton
			{
				IsVisible = new bool?(selectedCount > 0),
				LongPressConfigId = new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne)
			},
			BottomText = bottomText
		};
		base.Apply<PropMediumItemGrid>(parameters);
	}

	// Token: 0x06012F79 RID: 77689 RVA: 0x0058E0E1 File Offset: 0x0058C2E1
	public UUIItem GetUiItemForGuide()
	{
		UUIExtendToggle itemGridExtendToggle = this.GetItemGridExtendToggle();
		return ((itemGridExtendToggle != null) ? itemGridExtendToggle.GetOwner().GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem;
	}
}
