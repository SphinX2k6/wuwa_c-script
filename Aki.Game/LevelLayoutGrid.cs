using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002876 RID: 10358
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class LevelLayoutGrid : GridProxyAbstract<ILevelLayoutGridData>
{
	// Token: 0x0601550A RID: 87306 RVA: 0x005622DF File Offset: 0x005604DF
	public LevelLayoutGrid(RoleBreakPreviewViewModel vm)
	{
		this.BoundViewModel = vm;
	}

	// Token: 0x0601550B RID: 87307 RVA: 0x005622EE File Offset: 0x005604EE
	private void Dispose()
	{
		this.BoundViewModel = null;
	}

	// Token: 0x0601550C RID: 87308 RVA: 0x005622F8 File Offset: 0x005604F8
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

	// Token: 0x0601550D RID: 87309 RVA: 0x005623B8 File Offset: 0x005605B8
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

	// Token: 0x0601550E RID: 87310 RVA: 0x0056245B File Offset: 0x0056065B
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.Dispose();
	}

	// Token: 0x0601550F RID: 87311 RVA: 0x00562469 File Offset: 0x00560669
	private void OnClickToggle()
	{
		this.BoundViewModel.HandleItemOnClickToggle(base.GridIndex);
	}

	// Token: 0x04009F50 RID: 40784
	[Nullable(2)]
	private RoleBreakPreviewViewModel BoundViewModel;

	// Token: 0x02008E8C RID: 36492
	[NullableContext(0)]
	private enum ELevelLayoutGridComponent
	{
		// Token: 0x0402E3B8 RID: 189368
		DarkItem,
		// Token: 0x0402E3B9 RID: 189369
		DarkText,
		// Token: 0x0402E3BA RID: 189370
		LightItem,
		// Token: 0x0402E3BB RID: 189371
		LightText,
		// Token: 0x0402E3BC RID: 189372
		LeftLine,
		// Token: 0x0402E3BD RID: 189373
		Toggle
	}
}
