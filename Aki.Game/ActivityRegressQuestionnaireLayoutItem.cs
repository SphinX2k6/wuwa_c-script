using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200094A RID: 2378
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivityRegressQuestionnaireLayoutItem : GridProxyAbstract<ActivityRegressQuestionnaireItemData>
{
	// Token: 0x060068E7 RID: 26855 RVA: 0x0020C3B2 File Offset: 0x0020A5B2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
	}

	// Token: 0x060068E8 RID: 26856 RVA: 0x0020C3D8 File Offset: 0x0020A5D8
	protected override void OnStart()
	{
		this.ItemGrid = new SmallItemGrid();
		this.ItemGrid.Initialize(base.GetItem(7).GetOwner());
		this.ItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.ItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnItemClick));
	}

	// Token: 0x060068E9 RID: 26857 RVA: 0x0020C448 File Offset: 0x0020A648
	public override void Refresh(ActivityRegressQuestionnaireItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		ActivityRegressHelper.RefreshItemGridByData(this.ItemGrid, data.ItemData.Value);
	}

	// Token: 0x060068EA RID: 26858 RVA: 0x0020C468 File Offset: 0x0020A668
	private void OnItemClick(MediumItemGridExtendCallback _)
	{
		if (this.Data.ItemData.Value.RewardState == ERegressRewardState.Reached)
		{
			ActivityRegressController.Instance.RequestClaimQuestionnaireReward(this.Data.Type);
			return;
		}
		int id = this.Data.ItemData.Value.ItemInfo.Value.Id;
		ItemController.Instance.OpenItemTipsByItemId(id, true, null, false);
	}

	// Token: 0x0400429F RID: 17055
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x040042A0 RID: 17056
	[Nullable(2)]
	private ActivityRegressQuestionnaireItemData Data;

	// Token: 0x02006C49 RID: 27721
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402395E RID: 145758
		public const int ItemRoot = 7;
	}
}
