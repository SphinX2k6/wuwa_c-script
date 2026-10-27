using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002893 RID: 10387
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SuccessDescriptionItem : GridProxyAbstract<SingleText>
{
	// Token: 0x06015614 RID: 87572 RVA: 0x00563A21 File Offset: 0x00561C21
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06015615 RID: 87573 RVA: 0x00563A44 File Offset: 0x00561C44
	public void SetDescriptionText(SingleText text)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), text.TextId, text.Params ?? Array.Empty<string>());
	}

	// Token: 0x06015616 RID: 87574 RVA: 0x00563A6C File Offset: 0x00561C6C
	public override void Refresh(SingleText data, bool isSelected, int gridIndex)
	{
		this.SetDescriptionText(data);
	}
}
