using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001766 RID: 5990
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineAttributePanelLite : UiPanelBase
{
	// Token: 0x0600AD8F RID: 44431 RVA: 0x002710E4 File Offset: 0x0026F2E4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickMainNew))
		};
	}

	// Token: 0x0600AD90 RID: 44432 RVA: 0x0027114C File Offset: 0x0026F34C
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineAttributePanelLite.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineAttributePanelLite.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AD91 RID: 44433 RVA: 0x0027118F File Offset: 0x0026F38F
	public void RefreshItemSwitch(IRefineAttrItemData data)
	{
		this.ItemMainNew.RefreshUi(data);
	}

	// Token: 0x0600AD92 RID: 44434 RVA: 0x0027119D File Offset: 0x0026F39D
	[NullableContext(1)]
	public void RefreshTitle(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
	}

	// Token: 0x0600AD93 RID: 44435 RVA: 0x002711B6 File Offset: 0x0026F3B6
	public void RefreshInteractive(bool active)
	{
		UUIButtonComponent button = base.GetButton(1);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(active);
	}

	// Token: 0x0600AD94 RID: 44436 RVA: 0x002711CA File Offset: 0x0026F3CA
	[NullableContext(1)]
	public void BindClickCallBack(Action callback)
	{
		this.OnClickCallBack = callback;
	}

	// Token: 0x0600AD95 RID: 44437 RVA: 0x002711D3 File Offset: 0x0026F3D3
	private void OnClickMainNew()
	{
		if (this.OnClickCallBack != null)
		{
			this.OnClickCallBack();
		}
	}

	// Token: 0x04004EE6 RID: 20198
	private AttributeSelectItem ItemMainNew;

	// Token: 0x04004EE7 RID: 20199
	private Action OnClickCallBack;

	// Token: 0x02007D58 RID: 32088
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040290B8 RID: 168120
		TextTips,
		// Token: 0x040290B9 RID: 168121
		ItemMainNew
	}
}
