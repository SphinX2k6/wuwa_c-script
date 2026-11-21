using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000DC8 RID: 3528
public class DevelopRewardItem : UiPanelBase
{
	// Token: 0x06008FE4 RID: 36836 RVA: 0x002B4368 File Offset: 0x002B2568
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008FE5 RID: 36837 RVA: 0x002B43D1 File Offset: 0x002B25D1
	public void SetIsUnlock(bool bUnlock)
	{
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(bUnlock);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(!bUnlock);
	}

	// Token: 0x02007009 RID: 28681
	private class ELevelItem
	{
		// Token: 0x04024976 RID: 149878
		public const int Light = 0;

		// Token: 0x04024977 RID: 149879
		public const int Dark = 1;
	}
}
