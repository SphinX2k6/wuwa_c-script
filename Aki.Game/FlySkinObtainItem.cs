using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001FCD RID: 8141
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FlySkinObtainItem : GridProxyAbstract<IFlySkinGetWayData>
{
	// Token: 0x0601433C RID: 82748 RVA: 0x005E42F0 File Offset: 0x005E24F0
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

	// Token: 0x0601433D RID: 82749 RVA: 0x005E43F9 File Offset: 0x005E25F9
	private void OnClick()
	{
		if (this.Data.Type == EFlySkinGetWayType.CanJump)
		{
			SkipTaskManager.RunByConfigId(this.Data.Id, this.Data.ConfigId);
		}
	}

	// Token: 0x0601433E RID: 82750 RVA: 0x005E442C File Offset: 0x005E262C
	public override void Refresh(IFlySkinGetWayData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		bool flag = this.Data.Type == EFlySkinGetWayType.CanJump;
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

	// Token: 0x0400AB85 RID: 43909
	private IFlySkinGetWayData Data;

	// Token: 0x020082DC RID: 33500
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x0402A48D RID: 173197
		Button,
		// Token: 0x0402A48E RID: 173198
		UnlockItem,
		// Token: 0x0402A48F RID: 173199
		LockItem,
		// Token: 0x0402A490 RID: 173200
		Name,
		// Token: 0x0402A491 RID: 173201
		LockName
	}
}
