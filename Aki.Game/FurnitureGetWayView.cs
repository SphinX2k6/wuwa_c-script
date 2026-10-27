using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000FD7 RID: 4055
public class FurnitureGetWayView : UiViewBase
{
	// Token: 0x0600682B RID: 26667 RVA: 0x0014B018 File Offset: 0x00149218
	[NullableContext(1)]
	public FurnitureGetWayView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600682C RID: 26668 RVA: 0x0014B024 File Offset: 0x00149224
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

	// Token: 0x0600682D RID: 26669 RVA: 0x0014B0A4 File Offset: 0x001492A4
	protected override UniTask OnBeforeStartAsync()
	{
		FurnitureGetWayView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurnitureGetWayView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600682E RID: 26670 RVA: 0x0014B0E7 File Offset: 0x001492E7
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x04002F87 RID: 12167
	[Nullable(2)]
	protected FurnitureGetWayItem GetWayItem;
}
