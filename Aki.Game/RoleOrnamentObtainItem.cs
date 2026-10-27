using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002A5A RID: 10842
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleOrnamentObtainItem : GridProxyAbstract<IGetWayItemData>
{
	// Token: 0x0601697B RID: 92539 RVA: 0x005B9A84 File Offset: 0x005B7C84
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601697C RID: 92540 RVA: 0x005B9B8D File Offset: 0x005B7D8D
	private void OnClick()
	{
		if (this.Data.Type == EGetWayItemType.CanJump)
		{
			SkipTaskManager.RunByConfigId(this.Data.Id, this.Data.Id);
		}
	}

	// Token: 0x0601697D RID: 92541 RVA: 0x005B9BC0 File Offset: 0x005B7DC0
	public override void Refresh(IGetWayItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		bool flag = this.Data.Type == EGetWayItemType.CanJump;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.Data.Text, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.Data.Text, Array.Empty<object>());
	}

	// Token: 0x0400A7A3 RID: 42915
	private IGetWayItemData Data;

	// Token: 0x0200909C RID: 37020
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x0402EDB9 RID: 191929
		Button,
		// Token: 0x0402EDBA RID: 191930
		UnlockItem,
		// Token: 0x0402EDBB RID: 191931
		LockItem,
		// Token: 0x0402EDBC RID: 191932
		Name,
		// Token: 0x0402EDBD RID: 191933
		LockName
	}
}
