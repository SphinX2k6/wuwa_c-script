using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001496 RID: 5270
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivityRegressQuestionnaireLayoutItem : GridProxyAbstract<ActivityRegressQuestionnaireItemData>
{
	// Token: 0x06009552 RID: 38226 RVA: 0x0020344A File Offset: 0x0020164A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
	}

	// Token: 0x06009553 RID: 38227 RVA: 0x00203470 File Offset: 0x00201670
	protected override void OnStart()
	{
		this.ItemGrid = new SmallItemGrid();
		this.ItemGrid.Initialize(base.GetItem(7).GetOwner());
		this.ItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.ItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnItemClick));
	}

	// Token: 0x06009554 RID: 38228 RVA: 0x002034E0 File Offset: 0x002016E0
	public override void Refresh(ActivityRegressQuestionnaireItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		ActivityRegressHelper.RefreshItemGridByData(this.ItemGrid, data.ItemData.Value);
	}

	// Token: 0x06009555 RID: 38229 RVA: 0x00203500 File Offset: 0x00201700
	private void OnItemClick(MediumItemGridExtendCallback _)
	{
		if (this.Data.ItemData.Value.RewardState == ERegressRewardState.Reached)
		{
			ActivityRegressController.Instance.RequestClaimQuestionnaireReward(this.Data.Type);
			return;
		}
		int id = this.Data.ItemData.Value.ItemInfo.Value.Id;
		ItemController.Instance.OpenItemTipsByItemId(id, true, null);
	}

	// Token: 0x04004207 RID: 16903
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x04004208 RID: 16904
	[Nullable(2)]
	private ActivityRegressQuestionnaireItemData Data;

	// Token: 0x02007AC5 RID: 31429
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04028644 RID: 165444
		public const int ItemRoot = 7;
	}
}
