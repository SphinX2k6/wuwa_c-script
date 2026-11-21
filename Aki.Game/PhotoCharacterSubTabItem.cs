using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A43 RID: 6723
public class PhotoCharacterSubTabItem : GridProxyAbstract<PhotoSubTab>
{
	// Token: 0x06010967 RID: 67943 RVA: 0x004DABE4 File Offset: 0x004D8DE4
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
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x06010968 RID: 67944 RVA: 0x004DAC61 File Offset: 0x004D8E61
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06010969 RID: 67945 RVA: 0x004DAC70 File Offset: 0x004D8E70
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

	// Token: 0x0601096A RID: 67946 RVA: 0x004DACB5 File Offset: 0x004D8EB5
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0601096B RID: 67947 RVA: 0x004DACCC File Offset: 0x004D8ECC
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0601096C RID: 67948 RVA: 0x004DACE3 File Offset: 0x004D8EE3
	[NullableContext(1)]
	public override object GetKey(PhotoSubTab data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0601096D RID: 67949 RVA: 0x004DACF1 File Offset: 0x004D8EF1
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnSubTabClick(this.Data);
	}

	// Token: 0x040092DA RID: 37594
	private PhotoSubTab Data;

	// Token: 0x040092DB RID: 37595
	[Nullable(1)]
	public Action<PhotoSubTab> OnSubTabClick = delegate(PhotoSubTab data)
	{
	};

	// Token: 0x02007CAA RID: 31914
	private enum EComponents
	{
		// Token: 0x040285E0 RID: 165344
		Toggle,
		// Token: 0x040285E1 RID: 165345
		SpriteIcon,
		// Token: 0x040285E2 RID: 165346
		ItemRedDot
	}
}
