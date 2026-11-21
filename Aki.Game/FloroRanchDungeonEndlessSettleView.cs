using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200101D RID: 4125
public class FloroRanchDungeonEndlessSettleView : UiViewBase
{
	// Token: 0x0600A3FB RID: 41979 RVA: 0x003012DE File Offset: 0x002FF4DE
	[NullableContext(1)]
	public FloroRanchDungeonEndlessSettleView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A3FC RID: 41980 RVA: 0x003012E8 File Offset: 0x002FF4E8
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

	// Token: 0x0600A3FD RID: 41981 RVA: 0x003013D4 File Offset: 0x002FF5D4
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchDungeonEndlessSettleView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchDungeonEndlessSettleView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A3FE RID: 41982 RVA: 0x00301417 File Offset: 0x002FF617
	private void OnClickReChallengeButton()
	{
		FloroRanchGamePlayModel.Instance.ReStartGame();
	}

	// Token: 0x0600A3FF RID: 41983 RVA: 0x00301423 File Offset: 0x002FF623
	private void OnExitGameButton()
	{
		FloroRanchGamePlayModel.Instance.ExitGame(true);
	}

	// Token: 0x02007240 RID: 29248
	private class EComponent
	{
		// Token: 0x040252CC RID: 152268
		public const int DungeonSettleItem = 0;

		// Token: 0x040252CD RID: 152269
		public const int ReChallengeButton = 1;

		// Token: 0x040252CE RID: 152270
		public const int ExitGameButton = 2;
	}
}
