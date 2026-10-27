using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028CB RID: 10443
public class RoleSkillTrickSmallTitleItem : UiPanelBase
{
	// Token: 0x06015909 RID: 88329 RVA: 0x005721C4 File Offset: 0x005703C4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601590A RID: 88330 RVA: 0x0057220C File Offset: 0x0057040C
	[NullableContext(1)]
	public void SetText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
	}

	// Token: 0x02008EE0 RID: 36576
	private enum ETitleComponent
	{
		// Token: 0x0402E556 RID: 189782
		TitleText
	}
}
