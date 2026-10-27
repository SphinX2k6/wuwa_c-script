using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B5E RID: 7006
public class FloroRanchDungeonEndlessSettleView : UiViewBase
{
	// Token: 0x0600CFEA RID: 53226 RVA: 0x002F6206 File Offset: 0x002F4406
	[NullableContext(1)]
	public FloroRanchDungeonEndlessSettleView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600CFEB RID: 53227 RVA: 0x002F6210 File Offset: 0x002F4410
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
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnExitGameButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600CFEC RID: 53228 RVA: 0x002F62FC File Offset: 0x002F44FC
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchDungeonEndlessSettleView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchDungeonEndlessSettleView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CFED RID: 53229 RVA: 0x002F633F File Offset: 0x002F453F
	private void OnClickReChallengeButton()
	{
		FloroRanchGamePlayModel.Instance.ReStartGame();
	}

	// Token: 0x0600CFEE RID: 53230 RVA: 0x002F634B File Offset: 0x002F454B
	private void OnExitGameButton()
	{
		FloroRanchGamePlayModel.Instance.ExitGame(true);
	}

	// Token: 0x020080B2 RID: 32946
	private class EComponent
	{
		// Token: 0x04029F98 RID: 171928
		public const int DungeonSettleItem = 0;

		// Token: 0x04029F99 RID: 171929
		public const int ReChallengeButton = 1;

		// Token: 0x04029F9A RID: 171930
		public const int ExitGameButton = 2;
	}
}
