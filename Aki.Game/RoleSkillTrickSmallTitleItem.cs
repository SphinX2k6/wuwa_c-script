using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E46 RID: 7750
public class RoleSkillTrickSmallTitleItem : UiPanelBase
{
	// Token: 0x06013309 RID: 78601 RVA: 0x0059D07C File Offset: 0x0059B27C
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

	// Token: 0x0601330A RID: 78602 RVA: 0x0059D0C4 File Offset: 0x0059B2C4
	[NullableContext(1)]
	public void SetText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
	}

	// Token: 0x02008128 RID: 33064
	private enum ETitleComponent
	{
		// Token: 0x04029C51 RID: 171089
		TitleText
	}
}
