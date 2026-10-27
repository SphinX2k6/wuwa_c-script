using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CF9 RID: 7417
public class PinballBattleBossComingTips : PinballBattleTipsBase
{
	// Token: 0x0600E0A1 RID: 57505 RVA: 0x0034AF12 File Offset: 0x00349112
	[NullableContext(1)]
	public PinballBattleBossComingTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E0A2 RID: 57506 RVA: 0x0034AF1C File Offset: 0x0034911C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600E0A3 RID: 57507 RVA: 0x0034AF88 File Offset: 0x00349188
	protected override UniTask OnBeforeStartAsync()
	{
		PinballBattleBossComingTips.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PinballBattleBossComingTips.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}
}
