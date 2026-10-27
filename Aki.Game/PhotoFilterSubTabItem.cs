using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200256C RID: 9580
public class PhotoFilterSubTabItem : GridProxyAbstract<PhotoSubTab>
{
	// Token: 0x0601356D RID: 79213 RVA: 0x004CFF68 File Offset: 0x004CE168
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x0601356E RID: 79214 RVA: 0x004CFFCF File Offset: 0x004CE1CF
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x0601356F RID: 79215 RVA: 0x004CFFE0 File Offset: 0x004CE1E0
	public override void Refresh(PhotoSubTab data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.SetSpriteByPath(data.Icon, base.GetSprite(1), false, null, null);
	}

	// Token: 0x06013570 RID: 79216 RVA: 0x004D0013 File Offset: 0x004CE213
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06013571 RID: 79217 RVA: 0x004D002A File Offset: 0x004CE22A
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06013572 RID: 79218 RVA: 0x004D0041 File Offset: 0x004CE241
	[NullableContext(1)]
	public override object GetKey(PhotoSubTab data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x06013573 RID: 79219 RVA: 0x004D004F File Offset: 0x004CE24F
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnSubTabClick(this.Data);
	}

	// Token: 0x040091C6 RID: 37318
	private PhotoSubTab Data;

	// Token: 0x040091C7 RID: 37319
	[Nullable(1)]
	public Action<PhotoSubTab> OnSubTabClick = delegate(PhotoSubTab data)
	{
	};

	// Token: 0x02008B50 RID: 35664
	private enum EComponents
	{
		// Token: 0x0402D3C7 RID: 185287
		ToggleTab,
		// Token: 0x0402D3C8 RID: 185288
		SpriteIcon
	}
}
