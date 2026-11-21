using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001955 RID: 6485
internal class ActivePanel : UiPanelBase
{
	// Token: 0x06010057 RID: 65623 RVA: 0x004AC137 File Offset: 0x004AA337
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06010058 RID: 65624 RVA: 0x004AC15A File Offset: 0x004AA35A
	[NullableContext(1)]
	public void SetText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
	}
}
