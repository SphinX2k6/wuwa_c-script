using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200101E RID: 4126
public class FloroRanchDungeonFailSettleView : UiViewBase
{
	// Token: 0x0600A400 RID: 41984 RVA: 0x00301430 File Offset: 0x002FF630
	[NullableContext(1)]
	public FloroRanchDungeonFailSettleView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A401 RID: 41985 RVA: 0x0030143C File Offset: 0x002FF63C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickReChallengeButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickExitGameButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A402 RID: 41986 RVA: 0x00301528 File Offset: 0x002FF728
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchDungeonFailSettleView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchDungeonFailSettleView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A403 RID: 41987 RVA: 0x0030156B File Offset: 0x002FF76B
	private void OnClickReChallengeButton()
	{
		FloroRanchGamePlayModel.Instance.ReStartGame();
	}

	// Token: 0x0600A404 RID: 41988 RVA: 0x00301577 File Offset: 0x002FF777
	private void OnClickExitGameButton()
	{
		FloroRanchGamePlayModel.Instance.ExitGame(true);
	}

	// Token: 0x02007242 RID: 29250
	private class EComponent
	{
		// Token: 0x040252D5 RID: 152277
		public const int DungeonSettleItem = 0;

		// Token: 0x040252D6 RID: 152278
		public const int ReChallengeButton = 1;

		// Token: 0x040252D7 RID: 152279
		public const int ExitGameButton = 2;
	}
}
