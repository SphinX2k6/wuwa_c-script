using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200190F RID: 6415
public class DevelopRewardItem : UiPanelBase
{
	// Token: 0x0600BBFA RID: 48122 RVA: 0x002A9C0C File Offset: 0x002A7E0C
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

	// Token: 0x0600BBFB RID: 48123 RVA: 0x002A9C75 File Offset: 0x002A7E75
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

	// Token: 0x02007E82 RID: 32386
	private class ELevelItem
	{
		// Token: 0x0402964A RID: 169546
		public const int Light = 0;

		// Token: 0x0402964B RID: 169547
		public const int Dark = 1;
	}
}
