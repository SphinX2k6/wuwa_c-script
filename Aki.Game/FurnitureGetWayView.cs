using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200048C RID: 1164
public class FurnitureGetWayView : UiViewBase
{
	// Token: 0x06003BC3 RID: 15299 RVA: 0x001538DC File Offset: 0x00151ADC
	[NullableContext(1)]
	public FurnitureGetWayView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06003BC4 RID: 15300 RVA: 0x001538E8 File Offset: 0x00151AE8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickCloseButton))
		};
	}

	// Token: 0x06003BC5 RID: 15301 RVA: 0x00153968 File Offset: 0x00151B68
	protected override UniTask OnBeforeStartAsync()
	{
		FurnitureGetWayView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurnitureGetWayView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003BC6 RID: 15302 RVA: 0x001539AB File Offset: 0x00151BAB
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x04003020 RID: 12320
	[Nullable(2)]
	protected FurnitureGetWayItem GetWayItem;
}
