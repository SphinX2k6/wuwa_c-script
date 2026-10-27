using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000FB9 RID: 4025
[NullableContext(2)]
[Nullable(0)]
public class FurnitureAreaCameraSelectionItem : UiPanelBase
{
	// Token: 0x06006723 RID: 26403 RVA: 0x00146484 File Offset: 0x00144684
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

	// Token: 0x06006724 RID: 26404 RVA: 0x0014655B File Offset: 0x0014475B
	[NullableContext(1)]
	public void Refresh(string name)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), name, Array.Empty<object>());
	}

	// Token: 0x06006725 RID: 26405 RVA: 0x00146574 File Offset: 0x00144774
	private void OnClickPreBtn()
	{
		Action preBtnClickDelegate = this.PreBtnClickDelegate;
		if (preBtnClickDelegate == null)
		{
			return;
		}
		preBtnClickDelegate();
	}

	// Token: 0x06006726 RID: 26406 RVA: 0x00146586 File Offset: 0x00144786
	private void OnClickNextBtn()
	{
		Action nextBtnClickDelegate = this.NextBtnClickDelegate;
		if (nextBtnClickDelegate == null)
		{
			return;
		}
		nextBtnClickDelegate();
	}

	// Token: 0x04002EBC RID: 11964
	public Action PreBtnClickDelegate;

	// Token: 0x04002EBD RID: 11965
	public Action NextBtnClickDelegate;
}
