using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A5F RID: 6751
public class PhotoSettingTabItem : GridProxyAbstract<PhotoSubTab>
{
	// Token: 0x06010AB8 RID: 68280 RVA: 0x004E05A8 File Offset: 0x004DE7A8
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
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTabStateChanged))
		};
	}

	// Token: 0x06010AB9 RID: 68281 RVA: 0x004E0625 File Offset: 0x004DE825
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06010ABA RID: 68282 RVA: 0x004E0634 File Offset: 0x004DE834
	public override void Refresh(PhotoSubTab data, bool isSelected, int gridIndex)
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

	// Token: 0x06010ABB RID: 68283 RVA: 0x004E0679 File Offset: 0x004DE879
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06010ABC RID: 68284 RVA: 0x004E0690 File Offset: 0x004DE890
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06010ABD RID: 68285 RVA: 0x004E06A7 File Offset: 0x004DE8A7
	[NullableContext(1)]
	public override object GetKey(PhotoSubTab data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x06010ABE RID: 68286 RVA: 0x004E06B5 File Offset: 0x004DE8B5
	private void OnTabStateChanged(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnSubTabClick(this.Data);
	}

	// Token: 0x04009339 RID: 37689
	private PhotoSubTab Data;

	// Token: 0x0400933A RID: 37690
	[Nullable(1)]
	public Action<PhotoSubTab> OnSubTabClick = delegate(PhotoSubTab data)
	{
	};

	// Token: 0x02007CEB RID: 31979
	private enum EComponents
	{
		// Token: 0x04028741 RID: 165697
		ToggleTab,
		// Token: 0x04028742 RID: 165698
		SpriteIcon,
		// Token: 0x04028743 RID: 165699
		ItemRedDot
	}
}
