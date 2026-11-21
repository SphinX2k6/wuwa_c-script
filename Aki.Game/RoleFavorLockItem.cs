using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001DE0 RID: 7648
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleFavorLockItem : GridProxyAbstract<RoleFavorLockItemData>
{
	// Token: 0x06012EB1 RID: 77489 RVA: 0x0058B530 File Offset: 0x00589730
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

	// Token: 0x06012EB2 RID: 77490 RVA: 0x0058B5A0 File Offset: 0x005897A0
	[NullableContext(1)]
	public override void Refresh(RoleFavorLockItemData roleFavorLockItemData, bool isSelected, int gridIndex)
	{
		this.RoleFavorLockItemData = roleFavorLockItemData;
		this.RefreshView();
	}

	// Token: 0x06012EB3 RID: 77491 RVA: 0x0058B5B0 File Offset: 0x005897B0
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

	// Token: 0x06012EB4 RID: 77492 RVA: 0x0058B62E File Offset: 0x0058982E
	protected override void OnBeforeDestroy()
	{
		this.RoleFavorLockItemData = null;
	}

	// Token: 0x0400A2F6 RID: 41718
	[Nullable(2)]
	private RoleFavorLockItemData RoleFavorLockItemData;

	// Token: 0x020080CE RID: 32974
	private enum ERoleFavorLockItemDefine
	{
		// Token: 0x04029A99 RID: 170649
		UnLockItem,
		// Token: 0x04029A9A RID: 170650
		LockItem,
		// Token: 0x04029A9B RID: 170651
		UnLockDescText,
		// Token: 0x04029A9C RID: 170652
		LockDescText
	}
}
