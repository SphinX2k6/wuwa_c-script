using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200160C RID: 5644
public class WheelTowerBossBuffTip : UiViewBase
{
	// Token: 0x06009EED RID: 40685 RVA: 0x0022C12C File Offset: 0x0022A32C
	[NullableContext(1)]
	public WheelTowerBossBuffTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009EEE RID: 40686 RVA: 0x0022C138 File Offset: 0x0022A338
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnMaskBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009EEF RID: 40687 RVA: 0x0022C1E0 File Offset: 0x0022A3E0
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerBossBuffTip.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerBossBuffTip.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009EF0 RID: 40688 RVA: 0x0022C223 File Offset: 0x0022A423
	private void OnMaskBtnClick()
	{
		base.CloseMe(null);
	}
}
