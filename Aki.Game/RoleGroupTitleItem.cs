using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200116A RID: 4458
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleGroupTitleItem : SyncGridProxyAbstract<RoleGroupTitleData_Data>
{
	// Token: 0x060075B7 RID: 30135 RVA: 0x001854DC File Offset: 0x001836DC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060075B8 RID: 30136 RVA: 0x00185548 File Offset: 0x00183748
	[NullableContext(1)]
	public override void Refresh(RoleGroupTitleData_Data data)
	{
		if (data.IsEmpty)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(true);
			return;
		}
		else
		{
			UUIText text2 = base.GetText(0);
			if (text2 != null)
			{
				text2.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TitleTextId, new <>z__ReadOnlySingleElementList<object>(data.TitleParam));
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0200773E RID: 30526
	private class ETitleComp
	{
		// Token: 0x04027554 RID: 161108
		public const int TxtTitle = 0;

		// Token: 0x04027555 RID: 161109
		public const int UiItemEmpty = 3;
	}
}
