using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002865 RID: 10341
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleFavorLockItem : GridProxyAbstract<RoleFavorLockItemData>
{
	// Token: 0x060154B3 RID: 87219 RVA: 0x005607D4 File Offset: 0x0055E9D4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x060154B4 RID: 87220 RVA: 0x00560844 File Offset: 0x0055EA44
	[NullableContext(1)]
	public override void Refresh(RoleFavorLockItemData roleFavorLockItemData, bool isSelected, int gridIndex)
	{
		this.RoleFavorLockItemData = roleFavorLockItemData;
		this.RefreshView();
	}

	// Token: 0x060154B5 RID: 87221 RVA: 0x00560854 File Offset: 0x0055EA54
	private void RefreshView()
	{
		if (this.RoleFavorLockItemData == null)
		{
			return;
		}
		string desc = this.RoleFavorLockItemData.Desc;
		bool isLock = this.RoleFavorLockItemData.IsLock;
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(desc, true);
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetText(desc, true);
		}
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(isLock);
		}
		UUIItem item2 = base.GetItem(0);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(!isLock);
	}

	// Token: 0x060154B6 RID: 87222 RVA: 0x005608D2 File Offset: 0x0055EAD2
	protected override void OnBeforeDestroy()
	{
		this.RoleFavorLockItemData = null;
	}

	// Token: 0x04009F0D RID: 40717
	[Nullable(2)]
	private RoleFavorLockItemData RoleFavorLockItemData;

	// Token: 0x02008E88 RID: 36488
	private enum ERoleFavorLockItemDefine
	{
		// Token: 0x0402E39F RID: 189343
		UnLockItem,
		// Token: 0x0402E3A0 RID: 189344
		LockItem,
		// Token: 0x0402E3A1 RID: 189345
		UnLockDescText,
		// Token: 0x0402E3A2 RID: 189346
		LockDescText
	}
}
