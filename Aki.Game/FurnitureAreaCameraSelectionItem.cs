using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200046E RID: 1134
[NullableContext(2)]
[Nullable(0)]
public class FurnitureAreaCameraSelectionItem : UiPanelBase
{
	// Token: 0x06003ABB RID: 15035 RVA: 0x0014ED48 File Offset: 0x0014CF48
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickPreBtn)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickNextBtn))
		};
	}

	// Token: 0x06003ABC RID: 15036 RVA: 0x0014EE1F File Offset: 0x0014D01F
	[NullableContext(1)]
	public void Refresh(string name)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), name, Array.Empty<object>());
	}

	// Token: 0x06003ABD RID: 15037 RVA: 0x0014EE38 File Offset: 0x0014D038
	private void OnClickPreBtn()
	{
		Action preBtnClickDelegate = this.PreBtnClickDelegate;
		if (preBtnClickDelegate == null)
		{
			return;
		}
		preBtnClickDelegate();
	}

	// Token: 0x06003ABE RID: 15038 RVA: 0x0014EE4A File Offset: 0x0014D04A
	private void OnClickNextBtn()
	{
		Action nextBtnClickDelegate = this.NextBtnClickDelegate;
		if (nextBtnClickDelegate == null)
		{
			return;
		}
		nextBtnClickDelegate();
	}

	// Token: 0x04002F55 RID: 12117
	public Action PreBtnClickDelegate;

	// Token: 0x04002F56 RID: 12118
	public Action NextBtnClickDelegate;
}
