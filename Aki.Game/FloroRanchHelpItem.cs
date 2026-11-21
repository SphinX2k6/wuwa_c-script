using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001319 RID: 4889
internal class FloroRanchHelpItem : GridProxyAbstract<HelpText>
{
	// Token: 0x0600C03B RID: 49211 RVA: 0x0038CA18 File Offset: 0x0038AC18
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

	// Token: 0x0600C03C RID: 49212 RVA: 0x0038CA60 File Offset: 0x0038AC60
	public override void Refresh(HelpText data, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, data.Content, Array.Empty<object>());
	}

	// Token: 0x02007590 RID: 30096
	private enum EFloroRanchHelpItemComponents
	{
		// Token: 0x040262CB RID: 156363
		TextContent
	}
}
