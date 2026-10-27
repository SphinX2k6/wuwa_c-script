using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001E57 RID: 7767
internal class FloroRanchHelpItem : GridProxyAbstract<HelpText>
{
	// Token: 0x0600EC1C RID: 60444 RVA: 0x00380D6C File Offset: 0x0037EF6C
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

	// Token: 0x0600EC1D RID: 60445 RVA: 0x00380DB4 File Offset: 0x0037EFB4
	public override void Refresh(HelpText data, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, data.Content, Array.Empty<object>());
	}

	// Token: 0x0200840B RID: 33803
	private enum EFloroRanchHelpItemComponents
	{
		// Token: 0x0402AFA7 RID: 176039
		TextContent
	}
}
