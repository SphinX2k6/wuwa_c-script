using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C83 RID: 7299
public class GachaPoolDetailView : UiViewBase
{
	// Token: 0x0600DC42 RID: 56386 RVA: 0x0033594C File Offset: 0x00333B4C
	[NullableContext(1)]
	public GachaPoolDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DC43 RID: 56387 RVA: 0x00335958 File Offset: 0x00333B58
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

	// Token: 0x0600DC44 RID: 56388 RVA: 0x00335A04 File Offset: 0x00333C04
	protected override UniTask OnBeforeStartAsync()
	{
		GachaPoolDetailView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaPoolDetailView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC45 RID: 56389 RVA: 0x00335A47 File Offset: 0x00333C47
	[NullableContext(1)]
	[CompilerGenerated]
	internal static int <OnBeforeStartAsync>g__SortFunc|3_0(GachaPoolDrop a, GachaPoolDrop b)
	{
		if (!a.IsUp)
		{
			return (b.IsUp > false) ? 1 : 0;
		}
		return -1;
	}

	// Token: 0x02008256 RID: 33366
	private enum EGachaPoolDetailViewDefine
	{
		// Token: 0x0402A86E RID: 174190
		TxtDetail,
		// Token: 0x0402A86F RID: 174191
		GridContent,
		// Token: 0x0402A870 RID: 174192
		GridItem,
		// Token: 0x0402A871 RID: 174193
		TxtTitle
	}
}
