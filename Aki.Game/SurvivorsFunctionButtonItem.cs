using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002B15 RID: 11029
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsFunctionButtonItem : UiPanelBase
{
	// Token: 0x06016EB4 RID: 93876 RVA: 0x005D1090 File Offset: 0x005CF290
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

	// Token: 0x06016EB5 RID: 93877 RVA: 0x005D1123 File Offset: 0x005CF323
	private void OnBtnClicked()
	{
		Action onBtnClickedCallback = this.OnBtnClickedCallback;
		if (onBtnClickedCallback == null)
		{
			return;
		}
		onBtnClickedCallback();
	}

	// Token: 0x06016EB6 RID: 93878 RVA: 0x005D1135 File Offset: 0x005CF335
	protected override void OnStart()
	{
		this.SetNewItemVisible(false);
		this.SetRedDotVisible(false);
	}

	// Token: 0x06016EB7 RID: 93879 RVA: 0x005D1145 File Offset: 0x005CF345
	public void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(1).SetUIActive(bVisible);
	}

	// Token: 0x06016EB8 RID: 93880 RVA: 0x005D1154 File Offset: 0x005CF354
	public void SetNewItemVisible(bool bVisible)
	{
		base.GetItem(2).SetUIActive(bVisible);
	}

	// Token: 0x06016EB9 RID: 93881 RVA: 0x005D1163 File Offset: 0x005CF363
	public void SetDescText(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textId, args);
	}

	// Token: 0x06016EBA RID: 93882 RVA: 0x005D1178 File Offset: 0x005CF378
	public void SetFunction(Action callback)
	{
		this.OnBtnClickedCallback = callback;
	}

	// Token: 0x0400AA63 RID: 43619
	[Nullable(2)]
	protected Action OnBtnClickedCallback;
}
