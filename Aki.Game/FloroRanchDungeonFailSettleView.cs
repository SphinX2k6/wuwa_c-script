using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B5F RID: 7007
public class FloroRanchDungeonFailSettleView : UiViewBase
{
	// Token: 0x0600CFEF RID: 53231 RVA: 0x002F6358 File Offset: 0x002F4558
	[NullableContext(1)]
	public FloroRanchDungeonFailSettleView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600CFF0 RID: 53232 RVA: 0x002F6364 File Offset: 0x002F4564
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

	// Token: 0x0600CFF1 RID: 53233 RVA: 0x002F6450 File Offset: 0x002F4650
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchDungeonFailSettleView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchDungeonFailSettleView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CFF2 RID: 53234 RVA: 0x002F6493 File Offset: 0x002F4693
	private void OnClickReChallengeButton()
	{
		FloroRanchGamePlayModel.Instance.ReStartGame();
	}

	// Token: 0x0600CFF3 RID: 53235 RVA: 0x002F649F File Offset: 0x002F469F
	private void OnClickExitGameButton()
	{
		FloroRanchGamePlayModel.Instance.ExitGame(true);
	}

	// Token: 0x020080B4 RID: 32948
	private class EComponent
	{
		// Token: 0x04029FA1 RID: 171937
		public const int DungeonSettleItem = 0;

		// Token: 0x04029FA2 RID: 171938
		public const int ReChallengeButton = 1;

		// Token: 0x04029FA3 RID: 171939
		public const int ExitGameButton = 2;
	}
}
