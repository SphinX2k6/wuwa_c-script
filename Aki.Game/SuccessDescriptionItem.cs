using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001E0E RID: 7694
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SuccessDescriptionItem : GridProxyAbstract<SingleText>
{
	// Token: 0x06013012 RID: 77842 RVA: 0x0058E77D File Offset: 0x0058C97D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06013013 RID: 77843 RVA: 0x0058E7A0 File Offset: 0x0058C9A0
	public void SetDescriptionText(SingleText text)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), text.TextId, text.Params ?? Array.Empty<string>());
	}

	// Token: 0x06013014 RID: 77844 RVA: 0x0058E7C8 File Offset: 0x0058C9C8
	public override void Refresh(SingleText data, bool isSelected, int gridIndex)
	{
		this.SetDescriptionText(data);
	}
}
