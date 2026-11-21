using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200082B RID: 2091
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class BuffGridItem : GridProxyAbstract<BuffGridItemData>
{
	// Token: 0x06005F10 RID: 24336 RVA: 0x001E5F96 File Offset: 0x001E4196
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06005F11 RID: 24337 RVA: 0x001E5FCF File Offset: 0x001E41CF
	protected override void OnStart()
	{
		this.InitItem().Forget();
	}

	// Token: 0x06005F12 RID: 24338 RVA: 0x001E5FDC File Offset: 0x001E41DC
	private UniTask InitItem()
	{
		BuffGridItem.<InitItem>d__6 <InitItem>d__;
		<InitItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitItem>d__.<>4__this = this;
		<InitItem>d__.<>1__state = -1;
		<InitItem>d__.<>t__builder.Start<BuffGridItem.<InitItem>d__6>(ref <InitItem>d__);
		return <InitItem>d__.<>t__builder.Task;
	}

	// Token: 0x06005F13 RID: 24339 RVA: 0x001E601F File Offset: 0x001E421F
	[NullableContext(1)]
	public override void Refresh(BuffGridItemData data, bool isSelected, int gridIndex)
	{
		this.WaitRefresh(data, isSelected, gridIndex).Forget();
	}

	// Token: 0x06005F14 RID: 24340 RVA: 0x001E6030 File Offset: 0x001E4230
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

	// Token: 0x04003E76 RID: 15990
	private BuffScrollItem GridItem1;

	// Token: 0x04003E77 RID: 15991
	private BuffScrollItem GridItem2;

	// Token: 0x04003E78 RID: 15992
	private UniTaskCompletionSource _initTcs;
}
