using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

// Token: 0x02002430 RID: 9264
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class PhantomConfigRemoveItemGrid : LoopScrollMediumItemGrid<PhantomItemData>
{
	// Token: 0x06012941 RID: 76097 RVA: 0x00494B58 File Offset: 0x00492D58
	protected override void OnStart()
	{
		this.GetItemGridExtendToggle().OnStateChange.Add(new Action<EToggleState>(this.OnToggleClicked));
	}

	// Token: 0x06012942 RID: 76098 RVA: 0x00494B76 File Offset: 0x00492D76
	protected override void OnBeforeDestroy()
	{
		this.GetItemGridExtendToggle().OnStateChange.Remove(new Action<EToggleState>(this.OnToggleClicked));
	}

	// Token: 0x06012943 RID: 76099 RVA: 0x00494B94 File Offset: 0x00492D94
	protected override void OnRefresh(PhantomItemData data, bool isSelected, int gridIndex)
	{
		this.CurData = data;
		this.RefreshPrivate(data);
	}

	// Token: 0x06012944 RID: 76100 RVA: 0x00494BA4 File Offset: 0x00492DA4
	private void RefreshPrivate(PhantomItemData data)
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(data.GetUniqueId());
		if (phantomBattleData == null)
		{
			return;
		}
		PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.GetConfigId()),
			IsLockVisible = new bool?(data.GetIsLock()),
			IsDeprecate = new bool?(data.GetIsDeprecated()),
			StarLevel = new int?(data.GetQuality()),
			QualityId = new int?(phantomBattleData.GetQuality()),
			Level = new int?(phantomBattleData.GetCost()),
			IsLevelTextUseChangeColor = new bool?(true),
			BottomTextId = "VisionLevel",
			BottomTextParameter = new object[]
			{
				phantomBattleData.GetPhantomLevel()
			},
			VisionFetterGroupId = new int?(phantomBattleData.GetFetterGroupId()),
			IsOmitBottomText = new bool?(true)
		};
		propMediumItemGrid.StackDisplayInfo = new PhantomStackDisplay
		{
			StackCount = data.GetStackCount(),
			SelectedCount = 0,
			CanStack = PhantomStackUtil.CanStackWithSameSpec(phantomBattleData)
		};
		this.SetSelected(false, false);
		base.Apply<PropMediumItemGrid>(propMediumItemGrid);
	}

	// Token: 0x06012945 RID: 76101 RVA: 0x00494CC2 File Offset: 0x00492EC2
	private void OnToggleClicked(EToggleState state)
	{
		this.SetSelected(false, false);
		if (this.CurData != null)
		{
			ItemController.Instance.OpenItemTipsByItemUid(this.CurData.GetUniqueId(), this.CurData.GetConfigId(), true, null);
		}
	}

	// Token: 0x04008C02 RID: 35842
	[Nullable(2)]
	protected PhantomItemData CurData;
}
