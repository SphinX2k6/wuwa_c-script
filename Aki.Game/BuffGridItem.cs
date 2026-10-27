using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001377 RID: 4983
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class BuffGridItem : GridProxyAbstract<BuffGridItemData>
{
	// Token: 0x06008B75 RID: 35701 RVA: 0x001DD15A File Offset: 0x001DB35A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06008B76 RID: 35702 RVA: 0x001DD193 File Offset: 0x001DB393
	protected override void OnStart()
	{
		this.InitItem().Forget();
	}

	// Token: 0x06008B77 RID: 35703 RVA: 0x001DD1A0 File Offset: 0x001DB3A0
	private UniTask InitItem()
	{
		BuffGridItem.<InitItem>d__6 <InitItem>d__;
		<InitItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitItem>d__.<>4__this = this;
		<InitItem>d__.<>1__state = -1;
		<InitItem>d__.<>t__builder.Start<BuffGridItem.<InitItem>d__6>(ref <InitItem>d__);
		return <InitItem>d__.<>t__builder.Task;
	}

	// Token: 0x06008B78 RID: 35704 RVA: 0x001DD1E3 File Offset: 0x001DB3E3
	[NullableContext(1)]
	public override void Refresh(BuffGridItemData data, bool isSelected, int gridIndex)
	{
		this.WaitRefresh(data, isSelected, gridIndex).Forget();
	}

	// Token: 0x06008B79 RID: 35705 RVA: 0x001DD1F4 File Offset: 0x001DB3F4
	[NullableContext(1)]
	private UniTask WaitRefresh(BuffGridItemData data, bool isSelected, int gridIndex)
	{
		BuffGridItem.<WaitRefresh>d__8 <WaitRefresh>d__;
		<WaitRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitRefresh>d__.<>4__this = this;
		<WaitRefresh>d__.data = data;
		<WaitRefresh>d__.isSelected = isSelected;
		<WaitRefresh>d__.gridIndex = gridIndex;
		<WaitRefresh>d__.<>1__state = -1;
		<WaitRefresh>d__.<>t__builder.Start<BuffGridItem.<WaitRefresh>d__8>(ref <WaitRefresh>d__);
		return <WaitRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x04003DDE RID: 15838
	private BuffScrollItem GridItem1;

	// Token: 0x04003DDF RID: 15839
	private BuffScrollItem GridItem2;

	// Token: 0x04003DE0 RID: 15840
	private UniTaskCompletionSource _initTcs;
}
