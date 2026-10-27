using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002558 RID: 9560
public class PhotoCharacterSubTabItem : GridProxyAbstract<PhotoSubTab>
{
	// Token: 0x06013487 RID: 78983 RVA: 0x004CC0A8 File Offset: 0x004CA2A8
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

	// Token: 0x06013488 RID: 78984 RVA: 0x004CC125 File Offset: 0x004CA325
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06013489 RID: 78985 RVA: 0x004CC134 File Offset: 0x004CA334
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

	// Token: 0x0601348A RID: 78986 RVA: 0x004CC179 File Offset: 0x004CA379
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0601348B RID: 78987 RVA: 0x004CC190 File Offset: 0x004CA390
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0601348C RID: 78988 RVA: 0x004CC1A7 File Offset: 0x004CA3A7
	[NullableContext(1)]
	public override object GetKey(PhotoSubTab data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0601348D RID: 78989 RVA: 0x004CC1B5 File Offset: 0x004CA3B5
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnSubTabClick(this.Data);
	}

	// Token: 0x04009181 RID: 37249
	private PhotoSubTab Data;

	// Token: 0x04009182 RID: 37250
	[Nullable(1)]
	public Action<PhotoSubTab> OnSubTabClick = delegate(PhotoSubTab data)
	{
	};

	// Token: 0x02008B24 RID: 35620
	private enum EComponents
	{
		// Token: 0x0402D2D3 RID: 185043
		Toggle,
		// Token: 0x0402D2D4 RID: 185044
		SpriteIcon,
		// Token: 0x0402D2D5 RID: 185045
		ItemRedDot
	}
}
