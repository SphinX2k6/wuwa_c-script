using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C1F RID: 3103
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineAttributePanelLite : UiPanelBase
{
	// Token: 0x06008176 RID: 33142 RVA: 0x0027B5A4 File Offset: 0x002797A4
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

	// Token: 0x06008177 RID: 33143 RVA: 0x0027B60C File Offset: 0x0027980C
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineAttributePanelLite.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineAttributePanelLite.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008178 RID: 33144 RVA: 0x0027B64F File Offset: 0x0027984F
	public void RefreshItemSwitch(IRefineAttrItemData data)
	{
		this.ItemMainNew.RefreshUi(data);
	}

	// Token: 0x06008179 RID: 33145 RVA: 0x0027B65D File Offset: 0x0027985D
	[NullableContext(1)]
	public void RefreshTitle(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
	}

	// Token: 0x0600817A RID: 33146 RVA: 0x0027B676 File Offset: 0x00279876
	public void RefreshInteractive(bool active)
	{
		UUIButtonComponent button = base.GetButton(1);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(active);
	}

	// Token: 0x0600817B RID: 33147 RVA: 0x0027B68A File Offset: 0x0027988A
	[NullableContext(1)]
	public void BindClickCallBack(Action callback)
	{
		this.OnClickCallBack = callback;
	}

	// Token: 0x0600817C RID: 33148 RVA: 0x0027B693 File Offset: 0x00279893
	private void OnClickMainNew()
	{
		if (this.OnClickCallBack != null)
		{
			this.OnClickCallBack();
		}
	}

	// Token: 0x04004F90 RID: 20368
	private AttributeSelectItem ItemMainNew;

	// Token: 0x04004F91 RID: 20369
	private Action OnClickCallBack;

	// Token: 0x02006EDE RID: 28382
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040243E3 RID: 148451
		TextTips,
		// Token: 0x040243E4 RID: 148452
		ItemMainNew
	}
}
