using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200255A RID: 9562
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhotoMontageItem : GridProxyAbstract<PhotoMontageItemData>
{
	// Token: 0x06013494 RID: 78996 RVA: 0x004CC278 File Offset: 0x004CA478
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x06013495 RID: 78997 RVA: 0x004CC321 File Offset: 0x004CA521
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06013496 RID: 78998 RVA: 0x004CC330 File Offset: 0x004CA530
	public override void Refresh(PhotoMontageItemData data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Name, Array.Empty<object>());
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		this.SetToggleState(isSelected, false);
	}

	// Token: 0x06013497 RID: 78999 RVA: 0x004CC387 File Offset: 0x004CA587
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06013498 RID: 79000 RVA: 0x004CC3A4 File Offset: 0x004CA5A4
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x06013499 RID: 79001 RVA: 0x004CC3AE File Offset: 0x004CA5AE
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x0601349A RID: 79002 RVA: 0x004CC3B8 File Offset: 0x004CA5B8
	public override object GetKey(PhotoMontageItemData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0601349B RID: 79003 RVA: 0x004CC3C5 File Offset: 0x004CA5C5
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnMontageClick(base.GridIndex);
	}

	// Token: 0x04009185 RID: 37253
	public Action<int> OnMontageClick = delegate(int gridIndex)
	{
	};

	// Token: 0x02008B26 RID: 35622
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D2D9 RID: 185049
		Toggle,
		// Token: 0x0402D2DA RID: 185050
		SpriteIcon,
		// Token: 0x0402D2DB RID: 185051
		TextName,
		// Token: 0x0402D2DC RID: 185052
		TextCondition,
		// Token: 0x0402D2DD RID: 185053
		ItemLock
	}
}
