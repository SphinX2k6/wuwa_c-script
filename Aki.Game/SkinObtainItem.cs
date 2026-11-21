using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Skin.Skip;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001FB4 RID: 8116
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SkinObtainItem : GridProxyAbstract<ISkinSkipData>
{
	// Token: 0x06014244 RID: 82500 RVA: 0x005E0F7C File Offset: 0x005DF17C
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

	// Token: 0x06014245 RID: 82501 RVA: 0x005E1085 File Offset: 0x005DF285
	private void OnClick()
	{
		if (this.Data.Type == ESkinSkipType.CanJump)
		{
			SkipTaskManager.RunByConfigId(this.Data.Id, this.Data.ConfigId);
		}
	}

	// Token: 0x06014246 RID: 82502 RVA: 0x005E10B8 File Offset: 0x005DF2B8
	public override void Refresh(ISkinSkipData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		bool flag = this.Data.Type == ESkinSkipType.CanJump;
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

	// Token: 0x0400AB15 RID: 43797
	private ISkinSkipData Data;

	// Token: 0x020082C7 RID: 33479
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x0402A44B RID: 173131
		Button,
		// Token: 0x0402A44C RID: 173132
		UnlockItem,
		// Token: 0x0402A44D RID: 173133
		LockItem,
		// Token: 0x0402A44E RID: 173134
		Name,
		// Token: 0x0402A44F RID: 173135
		LockName
	}
}
