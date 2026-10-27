using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000FBB RID: 4027
public class FurnitureAreaFinishTipItem : UiPanelBase
{
	// Token: 0x06006728 RID: 26408 RVA: 0x001465A0 File Offset: 0x001447A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06006729 RID: 26409 RVA: 0x001465D9 File Offset: 0x001447D9
	[NullableContext(1)]
	public void Refresh(string content)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), content, Array.Empty<object>());
	}
}
