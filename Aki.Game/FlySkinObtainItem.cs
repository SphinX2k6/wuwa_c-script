using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002A52 RID: 10834
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FlySkinObtainItem : GridProxyAbstract<IFlySkinGetWayData>
{
	// Token: 0x0601691B RID: 92443 RVA: 0x005B81AC File Offset: 0x005B63AC
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

	// Token: 0x0601691C RID: 92444 RVA: 0x005B82B5 File Offset: 0x005B64B5
	private void OnClick()
	{
		if (this.Data.Type == EFlySkinGetWayType.CanJump)
		{
			SkipTaskManager.RunByConfigId(this.Data.Id, this.Data.ConfigId);
		}
	}

	// Token: 0x0601691D RID: 92445 RVA: 0x005B82E8 File Offset: 0x005B64E8
	public override void Refresh(IFlySkinGetWayData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		bool flag = this.Data.Type == EFlySkinGetWayType.CanJump;
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

	// Token: 0x0400A781 RID: 42881
	private IFlySkinGetWayData Data;

	// Token: 0x02009095 RID: 37013
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x0402ED93 RID: 191891
		Button,
		// Token: 0x0402ED94 RID: 191892
		UnlockItem,
		// Token: 0x0402ED95 RID: 191893
		LockItem,
		// Token: 0x0402ED96 RID: 191894
		Name,
		// Token: 0x0402ED97 RID: 191895
		LockName
	}
}
