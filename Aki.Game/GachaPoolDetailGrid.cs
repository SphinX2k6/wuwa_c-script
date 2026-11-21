using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001143 RID: 4419
public class GachaPoolDetailGrid : UiPanelBase
{
	// Token: 0x0600B05C RID: 45148 RVA: 0x00340F88 File Offset: 0x0033F188
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B05D RID: 45149 RVA: 0x00341034 File Offset: 0x0033F234
	protected override UniTask OnBeforeStartAsync()
	{
		GachaPoolDetailGrid.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaPoolDetailGrid.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040065E0 RID: 26080
	[Nullable(2)]
	public GachaPoolDetailData Data;

	// Token: 0x020073E1 RID: 29665
	private enum EGachaPoolDetailGridDefine
	{
		// Token: 0x04025B9F RID: 154527
		TxtDesc,
		// Token: 0x04025BA0 RID: 154528
		ContentItem,
		// Token: 0x04025BA1 RID: 154529
		Item,
		// Token: 0x04025BA2 RID: 154530
		TxtTitle
	}
}
