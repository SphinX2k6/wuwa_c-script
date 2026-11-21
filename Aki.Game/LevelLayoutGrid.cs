using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001DF1 RID: 7665
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class LevelLayoutGrid : GridProxyAbstract<ILevelLayoutGridData>
{
	// Token: 0x06012F08 RID: 77576 RVA: 0x0058D03B File Offset: 0x0058B23B
	public LevelLayoutGrid(RoleBreakPreviewViewModel vm)
	{
		this.BoundViewModel = vm;
	}

	// Token: 0x06012F09 RID: 77577 RVA: 0x0058D04A File Offset: 0x0058B24A
	private void Dispose()
	{
		this.BoundViewModel = null;
	}

	// Token: 0x06012F0A RID: 77578 RVA: 0x0058D054 File Offset: 0x0058B254
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickToggle))
		};
	}

	// Token: 0x06012F0B RID: 77579 RVA: 0x0058D114 File Offset: 0x0058B314
	public override void Refresh(ILevelLayoutGridData data, bool isSelected, int gridIndex)
	{
		base.GridIndex = gridIndex;
		bool isAvailable = data.IsAvailable;
		string text = data.LevelContent.ToString();
		base.GetItem(0).SetUIActive(!isAvailable);
		base.GetText(1).SetText(isAvailable ? "" : text, true);
		base.GetItem(2).SetUIActive(isAvailable);
		base.GetText(3).SetText(isAvailable ? text : "", true);
		base.GetItem(4).SetUIActive(gridIndex != 0);
		base.GetExtendToggle(5).SetToggleState(data.IsChosen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06012F0C RID: 77580 RVA: 0x0058D1B7 File Offset: 0x0058B3B7
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.Dispose();
	}

	// Token: 0x06012F0D RID: 77581 RVA: 0x0058D1C5 File Offset: 0x0058B3C5
	private void OnClickToggle()
	{
		this.BoundViewModel.HandleItemOnClickToggle(base.GridIndex);
	}

	// Token: 0x0400A339 RID: 41785
	[Nullable(2)]
	private RoleBreakPreviewViewModel BoundViewModel;

	// Token: 0x020080D2 RID: 32978
	[NullableContext(0)]
	private enum ELevelLayoutGridComponent
	{
		// Token: 0x04029AB2 RID: 170674
		DarkItem,
		// Token: 0x04029AB3 RID: 170675
		DarkText,
		// Token: 0x04029AB4 RID: 170676
		LightItem,
		// Token: 0x04029AB5 RID: 170677
		LightText,
		// Token: 0x04029AB6 RID: 170678
		LeftLine,
		// Token: 0x04029AB7 RID: 170679
		Toggle
	}
}
