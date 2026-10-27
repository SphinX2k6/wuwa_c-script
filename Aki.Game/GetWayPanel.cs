using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200246D RID: 9325
[NullableContext(1)]
[Nullable(0)]
internal class GetWayPanel : UiPanelBase
{
	// Token: 0x06012B96 RID: 76694 RVA: 0x0049E7F4 File Offset: 0x0049C9F4
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

	// Token: 0x06012B97 RID: 76695 RVA: 0x0049E871 File Offset: 0x0049CA71
	private void OnButtonClicked()
	{
		if (this.ButtonFunction != null)
		{
			this.ButtonFunction();
		}
	}

	// Token: 0x06012B98 RID: 76696 RVA: 0x0049E886 File Offset: 0x0049CA86
	public void SetButtonFunction(Action func)
	{
		this.ButtonFunction = func;
	}

	// Token: 0x06012B99 RID: 76697 RVA: 0x0049E890 File Offset: 0x0049CA90
	public void SetText(string textId)
	{
		UUIText text = base.GetText(2);
		LguiUtil.Instance.SetLocalTextNew(text, textId, Array.Empty<object>());
	}

	// Token: 0x04008D05 RID: 36101
	[Nullable(2)]
	private Action ButtonFunction;
}
