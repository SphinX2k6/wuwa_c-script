using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002574 RID: 9588
public class PhotoSettingTabItem : GridProxyAbstract<PhotoSubTab>
{
	// Token: 0x060135D5 RID: 79317 RVA: 0x004D1940 File Offset: 0x004CFB40
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

	// Token: 0x060135D6 RID: 79318 RVA: 0x004D19BD File Offset: 0x004CFBBD
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x060135D7 RID: 79319 RVA: 0x004D19CC File Offset: 0x004CFBCC
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

	// Token: 0x060135D8 RID: 79320 RVA: 0x004D1A11 File Offset: 0x004CFC11
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x060135D9 RID: 79321 RVA: 0x004D1A28 File Offset: 0x004CFC28
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060135DA RID: 79322 RVA: 0x004D1A3F File Offset: 0x004CFC3F
	[NullableContext(1)]
	public override object GetKey(PhotoSubTab data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x060135DB RID: 79323 RVA: 0x004D1A4D File Offset: 0x004CFC4D
	private void OnTabStateChanged(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnSubTabClick(this.Data);
	}

	// Token: 0x040091E0 RID: 37344
	private PhotoSubTab Data;

	// Token: 0x040091E1 RID: 37345
	[Nullable(1)]
	public Action<PhotoSubTab> OnSubTabClick = delegate(PhotoSubTab data)
	{
	};

	// Token: 0x02008B65 RID: 35685
	private enum EComponents
	{
		// Token: 0x0402D434 RID: 185396
		ToggleTab,
		// Token: 0x0402D435 RID: 185397
		SpriteIcon,
		// Token: 0x0402D436 RID: 185398
		ItemRedDot
	}
}
