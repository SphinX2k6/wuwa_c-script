using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001952 RID: 6482
[NullableContext(1)]
[Nullable(0)]
internal class GetWayPanel : UiPanelBase
{
	// Token: 0x0601004E RID: 65614 RVA: 0x004ABF60 File Offset: 0x004AA160
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClicked))
		};
	}

	// Token: 0x0601004F RID: 65615 RVA: 0x004ABFDD File Offset: 0x004AA1DD
	private void OnButtonClicked()
	{
		if (this.ButtonFunction != null)
		{
			this.ButtonFunction();
		}
	}

	// Token: 0x06010050 RID: 65616 RVA: 0x004ABFF2 File Offset: 0x004AA1F2
	public void SetButtonFunction(Action func)
	{
		this.ButtonFunction = func;
	}

	// Token: 0x06010051 RID: 65617 RVA: 0x004ABFFC File Offset: 0x004AA1FC
	public void SetText(string textId)
	{
		UUIText text = base.GetText(2);
		LguiUtil.Instance.SetLocalTextNew(text, textId, Array.Empty<object>());
	}

	// Token: 0x04008E4C RID: 36428
	[Nullable(2)]
	private Action ButtonFunction;
}
