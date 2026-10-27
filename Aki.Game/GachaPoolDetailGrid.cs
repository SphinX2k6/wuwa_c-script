using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C84 RID: 7300
public class GachaPoolDetailGrid : UiPanelBase
{
	// Token: 0x0600DC46 RID: 56390 RVA: 0x00335A5C File Offset: 0x00333C5C
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

	// Token: 0x0600DC47 RID: 56391 RVA: 0x00335B08 File Offset: 0x00333D08
	protected override UniTask OnBeforeStartAsync()
	{
		GachaPoolDetailGrid.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaPoolDetailGrid.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400650E RID: 25870
	[Nullable(2)]
	public GachaPoolDetailData Data;

	// Token: 0x02008259 RID: 33369
	private enum EGachaPoolDetailGridDefine
	{
		// Token: 0x0402A87E RID: 174206
		TxtDesc,
		// Token: 0x0402A87F RID: 174207
		ContentItem,
		// Token: 0x0402A880 RID: 174208
		Item,
		// Token: 0x0402A881 RID: 174209
		TxtTitle
	}
}
