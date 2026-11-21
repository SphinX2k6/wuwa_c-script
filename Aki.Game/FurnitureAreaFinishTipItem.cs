using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000470 RID: 1136
public class FurnitureAreaFinishTipItem : UiPanelBase
{
	// Token: 0x06003AC0 RID: 15040 RVA: 0x0014EE64 File Offset: 0x0014D064
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06003AC1 RID: 15041 RVA: 0x0014EE9D File Offset: 0x0014D09D
	[NullableContext(1)]
	public void Refresh(string content)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), content, Array.Empty<object>());
	}
}
