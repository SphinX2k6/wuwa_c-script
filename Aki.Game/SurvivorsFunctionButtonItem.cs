using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002091 RID: 8337
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsFunctionButtonItem : UiPanelBase
{
	// Token: 0x060148E5 RID: 84197 RVA: 0x005FDC0C File Offset: 0x005FBE0C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClicked))
		};
	}

	// Token: 0x060148E6 RID: 84198 RVA: 0x005FDC9F File Offset: 0x005FBE9F
	private void OnBtnClicked()
	{
		Action onBtnClickedCallback = this.OnBtnClickedCallback;
		if (onBtnClickedCallback == null)
		{
			return;
		}
		onBtnClickedCallback();
	}

	// Token: 0x060148E7 RID: 84199 RVA: 0x005FDCB1 File Offset: 0x005FBEB1
	protected override void OnStart()
	{
		this.SetNewItemVisible(false);
		this.SetRedDotVisible(false);
	}

	// Token: 0x060148E8 RID: 84200 RVA: 0x005FDCC1 File Offset: 0x005FBEC1
	public void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(1).SetUIActive(bVisible);
	}

	// Token: 0x060148E9 RID: 84201 RVA: 0x005FDCD0 File Offset: 0x005FBED0
	public void SetNewItemVisible(bool bVisible)
	{
		base.GetItem(2).SetUIActive(bVisible);
	}

	// Token: 0x060148EA RID: 84202 RVA: 0x005FDCDF File Offset: 0x005FBEDF
	public void SetDescText(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textId, args);
	}

	// Token: 0x060148EB RID: 84203 RVA: 0x005FDCF4 File Offset: 0x005FBEF4
	public void SetFunction(Action callback)
	{
		this.OnBtnClickedCallback = callback;
	}

	// Token: 0x0400AE69 RID: 44649
	[Nullable(2)]
	protected Action OnBtnClickedCallback;
}
