using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

// Token: 0x02001915 RID: 6421
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class PhantomConfigRemoveItemGrid : LoopScrollMediumItemGrid<PhantomItemData>
{
	// Token: 0x0600FDF7 RID: 65015 RVA: 0x004A2124 File Offset: 0x004A0324
	protected override void OnStart()
	{
		this.GetItemGridExtendToggle().OnStateChange.Add(new Action<EToggleState>(this.OnToggleClicked));
	}

	// Token: 0x0600FDF8 RID: 65016 RVA: 0x004A2142 File Offset: 0x004A0342
	protected override void OnBeforeDestroy()
	{
		this.GetItemGridExtendToggle().OnStateChange.Remove(new Action<EToggleState>(this.OnToggleClicked));
	}

	// Token: 0x0600FDF9 RID: 65017 RVA: 0x004A2160 File Offset: 0x004A0360
	protected override void OnRefresh(PhantomItemData data, bool isSelected, int gridIndex)
	{
		this.CurData = data;
		this.RefreshPrivate(data);
	}

	// Token: 0x0600FDFA RID: 65018 RVA: 0x004A2170 File Offset: 0x004A0370
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

	// Token: 0x0600FDFB RID: 65019 RVA: 0x004A228E File Offset: 0x004A048E
	private void OnToggleClicked(EToggleState state)
	{
		this.SetSelected(false, false);
		if (this.CurData != null)
		{
			ItemController.Instance.OpenItemTipsByItemUid(this.CurData.GetUniqueId(), this.CurData.GetConfigId(), true, null);
		}
	}

	// Token: 0x04008D49 RID: 36169
	[Nullable(2)]
	protected PhantomItemData CurData;
}
