using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A68 RID: 6760
public class PhotoTabItem : GridProxyAbstract<PhotoTab>
{
	// Token: 0x06010B3C RID: 68412 RVA: 0x004E2C20 File Offset: 0x004E0E20
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

	// Token: 0x06010B3D RID: 68413 RVA: 0x004E2C9D File Offset: 0x004E0E9D
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06010B3E RID: 68414 RVA: 0x004E2CAC File Offset: 0x004E0EAC
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

	// Token: 0x06010B3F RID: 68415 RVA: 0x004E2CF1 File Offset: 0x004E0EF1
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06010B40 RID: 68416 RVA: 0x004E2D08 File Offset: 0x004E0F08
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06010B41 RID: 68417 RVA: 0x004E2D1F File Offset: 0x004E0F1F
	[NullableContext(1)]
	public override object GetKey(PhotoTab data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x06010B42 RID: 68418 RVA: 0x004E2D2D File Offset: 0x004E0F2D
	private void OnSelfStateChanged(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnTabClick(this.Data);
	}

	// Token: 0x04009354 RID: 37716
	private PhotoTab Data;

	// Token: 0x04009355 RID: 37717
	[Nullable(1)]
	public Action<PhotoTab> OnTabClick = delegate(PhotoTab data)
	{
	};

	// Token: 0x02007D01 RID: 32001
	private enum EComponents
	{
		// Token: 0x040287C0 RID: 165824
		ToggleSelf,
		// Token: 0x040287C1 RID: 165825
		SpriteIcon,
		// Token: 0x040287C2 RID: 165826
		ItemRedDot
	}
}
