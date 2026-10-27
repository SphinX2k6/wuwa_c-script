using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002489 RID: 9353
[NullableContext(1)]
[Nullable(0)]
public class CostTabItem : CommonTabItemBase
{
	// Token: 0x06012C61 RID: 76897 RVA: 0x004A16C2 File Offset: 0x0049F8C2
	public CostTabItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06012C62 RID: 76898 RVA: 0x004A16D1 File Offset: 0x0049F8D1
	public void Init()
	{
		base.SetRootActor(this.SourceItem.GetOwner(), true);
	}

	// Token: 0x06012C63 RID: 76899 RVA: 0x004A16E8 File Offset: 0x0049F8E8
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

	// Token: 0x06012C64 RID: 76900 RVA: 0x004A1791 File Offset: 0x0049F991
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06012C65 RID: 76901 RVA: 0x004A17AA File Offset: 0x0049F9AA
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x06012C66 RID: 76902 RVA: 0x004A17C4 File Offset: 0x0049F9C4
	protected override void OnUpdateTabIcon(string iconPath)
	{
		this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, null);
	}

	// Token: 0x06012C67 RID: 76903 RVA: 0x004A17EA File Offset: 0x0049F9EA
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06012C68 RID: 76904 RVA: 0x004A17FD File Offset: 0x0049F9FD
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x04008D64 RID: 36196
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x02008A00 RID: 35328
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CD07 RID: 183559
		Icon,
		// Token: 0x0402CD08 RID: 183560
		Toggle,
		// Token: 0x0402CD09 RID: 183561
		RedDot,
		// Token: 0x0402CD0A RID: 183562
		SpriteIcon,
		// Token: 0x0402CD0B RID: 183563
		SpriteSubIcon
	}
}
