using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200196F RID: 6511
[NullableContext(1)]
[Nullable(0)]
public class CostTabItem : CommonTabItemBase
{
	// Token: 0x0601011A RID: 65818 RVA: 0x004AEE2D File Offset: 0x004AD02D
	public CostTabItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x0601011B RID: 65819 RVA: 0x004AEE3C File Offset: 0x004AD03C
	public void Init()
	{
		base.SetRootActor(this.SourceItem.GetOwner(), true);
	}

	// Token: 0x0601011C RID: 65820 RVA: 0x004AEE50 File Offset: 0x004AD050
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleClick))
		};
	}

	// Token: 0x0601011D RID: 65821 RVA: 0x004AEEF9 File Offset: 0x004AD0F9
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0601011E RID: 65822 RVA: 0x004AEF12 File Offset: 0x004AD112
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x0601011F RID: 65823 RVA: 0x004AEF2C File Offset: 0x004AD12C
	protected override void OnUpdateTabIcon(string iconPath)
	{
		this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, null);
	}

	// Token: 0x06010120 RID: 65824 RVA: 0x004AEF52 File Offset: 0x004AD152
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06010121 RID: 65825 RVA: 0x004AEF65 File Offset: 0x004AD165
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x04008EAB RID: 36523
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x02007B87 RID: 31623
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402801D RID: 163869
		Icon,
		// Token: 0x0402801E RID: 163870
		Toggle,
		// Token: 0x0402801F RID: 163871
		RedDot,
		// Token: 0x04028020 RID: 163872
		SpriteIcon,
		// Token: 0x04028021 RID: 163873
		SpriteSubIcon
	}
}
