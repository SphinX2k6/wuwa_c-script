using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Skin.Skip;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002A39 RID: 10809
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SkinObtainItem : GridProxyAbstract<ISkinSkipData>
{
	// Token: 0x06016822 RID: 92194 RVA: 0x005B4DC4 File Offset: 0x005B2FC4
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

	// Token: 0x06016823 RID: 92195 RVA: 0x005B4ECD File Offset: 0x005B30CD
	private void OnClick()
	{
		if (this.Data.Type == ESkinSkipType.CanJump)
		{
			SkipTaskManager.RunByConfigId(this.Data.Id, this.Data.ConfigId);
		}
	}

	// Token: 0x06016824 RID: 92196 RVA: 0x005B4F00 File Offset: 0x005B3100
	public override void Refresh(ISkinSkipData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		bool flag = this.Data.Type == ESkinSkipType.CanJump;
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

	// Token: 0x0400A711 RID: 42769
	private ISkinSkipData Data;

	// Token: 0x02009080 RID: 36992
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x0402ED51 RID: 191825
		Button,
		// Token: 0x0402ED52 RID: 191826
		UnlockItem,
		// Token: 0x0402ED53 RID: 191827
		LockItem,
		// Token: 0x0402ED54 RID: 191828
		Name,
		// Token: 0x0402ED55 RID: 191829
		LockName
	}
}
