using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200257D RID: 9597
public class PhotoTabItem : GridProxyAbstract<PhotoTab>
{
	// Token: 0x0601365B RID: 79451 RVA: 0x004D4250 File Offset: 0x004D2450
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnSelfStateChanged))
		};
	}

	// Token: 0x0601365C RID: 79452 RVA: 0x004D42CD File Offset: 0x004D24CD
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x0601365D RID: 79453 RVA: 0x004D42DC File Offset: 0x004D24DC
	public override void Refresh(PhotoTab data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.SetSpriteByPath(data.Icon, base.GetSprite(1), false, null, null);
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0601365E RID: 79454 RVA: 0x004D4321 File Offset: 0x004D2521
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0601365F RID: 79455 RVA: 0x004D4338 File Offset: 0x004D2538
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06013660 RID: 79456 RVA: 0x004D434F File Offset: 0x004D254F
	[NullableContext(1)]
	public override object GetKey(PhotoTab data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x06013661 RID: 79457 RVA: 0x004D435D File Offset: 0x004D255D
	private void OnSelfStateChanged(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnTabClick(this.Data);
	}

	// Token: 0x040091FC RID: 37372
	private PhotoTab Data;

	// Token: 0x040091FD RID: 37373
	[Nullable(1)]
	public Action<PhotoTab> OnTabClick = delegate(PhotoTab data)
	{
	};

	// Token: 0x02008B7B RID: 35707
	private enum EComponents
	{
		// Token: 0x0402D4B3 RID: 185523
		ToggleSelf,
		// Token: 0x0402D4B4 RID: 185524
		SpriteIcon,
		// Token: 0x0402D4B5 RID: 185525
		ItemRedDot
	}
}
