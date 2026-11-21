using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001FD5 RID: 8149
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleOrnamentObtainItem : GridProxyAbstract<IGetWayItemData>
{
	// Token: 0x0601439C RID: 82844 RVA: 0x005E5C08 File Offset: 0x005E3E08
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

	// Token: 0x0601439D RID: 82845 RVA: 0x005E5D11 File Offset: 0x005E3F11
	private void OnClick()
	{
		if (this.Data.Type == EGetWayItemType.CanJump)
		{
			SkipTaskManager.RunByConfigId(this.Data.Id, this.Data.Id);
		}
	}

	// Token: 0x0601439E RID: 82846 RVA: 0x005E5D44 File Offset: 0x005E3F44
	public override void Refresh(IGetWayItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		bool flag = this.Data.Type == EGetWayItemType.CanJump;
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.SetSelfInteractive(flag);
		}
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

	// Token: 0x0400ABA7 RID: 43943
	private IGetWayItemData Data;

	// Token: 0x020082E3 RID: 33507
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x0402A4B3 RID: 173235
		Button,
		// Token: 0x0402A4B4 RID: 173236
		UnlockItem,
		// Token: 0x0402A4B5 RID: 173237
		LockItem,
		// Token: 0x0402A4B6 RID: 173238
		Name,
		// Token: 0x0402A4B7 RID: 173239
		LockName
	}
}
