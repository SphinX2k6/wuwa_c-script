using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002470 RID: 9328
internal class ActivePanel : UiPanelBase
{
	// Token: 0x06012B9F RID: 76703 RVA: 0x0049E9CB File Offset: 0x0049CBCB
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06012BA0 RID: 76704 RVA: 0x0049E9EE File Offset: 0x0049CBEE
	[NullableContext(1)]
	public void SetText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
	}
}
