using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200106C RID: 4204
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUiToyItem : FloroRanchUiItemBase
{
	// Token: 0x0600A739 RID: 42809 RVA: 0x00313D08 File Offset: 0x00311F08
	protected unsafe override void OnRegisterComponent()
	{
		int num = 17;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A73A RID: 42810 RVA: 0x00313FA6 File Offset: 0x003121A6
	protected override void OnBeforeCreate()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x0600A73B RID: 42811 RVA: 0x00313FC0 File Offset: 0x003121C0
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchUiToyItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchUiToyItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A73C RID: 42812 RVA: 0x00314004 File Offset: 0x00312204
	public override UniTask RefreshItem()
	{
		FloroRanchUiToyItem.<RefreshItem>d__8 <RefreshItem>d__;
		<RefreshItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshItem>d__.<>4__this = this;
		<RefreshItem>d__.<>1__state = -1;
		<RefreshItem>d__.<>t__builder.Start<FloroRanchUiToyItem.<RefreshItem>d__8>(ref <RefreshItem>d__);
		return <RefreshItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A73D RID: 42813 RVA: 0x00314047 File Offset: 0x00312247
	public override FTransform? GetRewardPopTransform()
	{
		return new FTransform?(base.GetRootActor().GetTransform());
	}

	// Token: 0x0600A73E RID: 42814 RVA: 0x0031405C File Offset: 0x0031225C
	public override UniTask PlayShowAnim()
	{
		FloroRanchUiToyItem.<PlayShowAnim>d__10 <PlayShowAnim>d__;
		<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayShowAnim>d__.<>4__this = this;
		<PlayShowAnim>d__.<>1__state = -1;
		<PlayShowAnim>d__.<>t__builder.Start<FloroRanchUiToyItem.<PlayShowAnim>d__10>(ref <PlayShowAnim>d__);
		return <PlayShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A73F RID: 42815 RVA: 0x003140A0 File Offset: 0x003122A0
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiToyItem.<PlayHideAnim>d__11 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiToyItem.<PlayHideAnim>d__11>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A740 RID: 42816 RVA: 0x003140E4 File Offset: 0x003122E4
	public override UniTask PlayNormalAnim()
	{
		FloroRanchUiToyItem.<PlayNormalAnim>d__12 <PlayNormalAnim>d__;
		<PlayNormalAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNormalAnim>d__.<>4__this = this;
		<PlayNormalAnim>d__.<>1__state = -1;
		<PlayNormalAnim>d__.<>t__builder.Start<FloroRanchUiToyItem.<PlayNormalAnim>d__12>(ref <PlayNormalAnim>d__);
		return <PlayNormalAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A741 RID: 42817 RVA: 0x00314128 File Offset: 0x00312328
	public UniTask PlayToyLevelUpAnim()
	{
		FloroRanchUiToyItem.<PlayToyLevelUpAnim>d__13 <PlayToyLevelUpAnim>d__;
		<PlayToyLevelUpAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayToyLevelUpAnim>d__.<>4__this = this;
		<PlayToyLevelUpAnim>d__.<>1__state = -1;
		<PlayToyLevelUpAnim>d__.<>t__builder.Start<FloroRanchUiToyItem.<PlayToyLevelUpAnim>d__13>(ref <PlayToyLevelUpAnim>d__);
		return <PlayToyLevelUpAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A742 RID: 42818 RVA: 0x0031416B File Offset: 0x0031236B
	public void SetSelectState(bool isSelect)
	{
		base.GetExtendToggle(0).SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600A743 RID: 42819 RVA: 0x00314184 File Offset: 0x00312384
	private void OnToggleClick(EToggleState toggleState)
	{
		Action onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback();
	}

	// Token: 0x0600A744 RID: 42820 RVA: 0x00314196 File Offset: 0x00312396
	public void BindClickCallback(Action callback)
	{
		this.OnClickCallback = callback;
	}

	// Token: 0x04006184 RID: 24964
	private FloroRanchEntityDebugInfoItem DebugInfoItem;

	// Token: 0x04006185 RID: 24965
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x04006186 RID: 24966
	public FloroRanchToyLevelItem ToyLevelItem;

	// Token: 0x04006187 RID: 24967
	private Action OnClickCallback = delegate()
	{
	};

	// Token: 0x020072F7 RID: 29431
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040256E4 RID: 153316
		public const int Toggle = 0;

		// Token: 0x040256E5 RID: 153317
		public const int QualitySprite = 1;

		// Token: 0x040256E6 RID: 153318
		public const int IconTexture = 2;

		// Token: 0x040256E7 RID: 153319
		public const int CountDownPanel = 3;

		// Token: 0x040256E8 RID: 153320
		public const int CountdownText = 4;

		// Token: 0x040256E9 RID: 153321
		public const int NumPanel = 5;

		// Token: 0x040256EA RID: 153322
		public const int NumText = 6;

		// Token: 0x040256EB RID: 153323
		public const int LockSprite = 7;

		// Token: 0x040256EC RID: 153324
		public const int InfoPanel = 8;

		// Token: 0x040256ED RID: 153325
		public const int BgSprite = 9;

		// Token: 0x040256EE RID: 153326
		public const int IconMaskTexture = 10;

		// Token: 0x040256EF RID: 153327
		public const int UnknownPanel = 11;

		// Token: 0x040256F0 RID: 153328
		public const int ItemPhantomIcon = 12;

		// Token: 0x040256F1 RID: 153329
		public const int ItemNew = 13;

		// Token: 0x040256F2 RID: 153330
		public const int ToyRaceItem = 14;

		// Token: 0x040256F3 RID: 153331
		public const int ToyRaceIcon = 15;

		// Token: 0x040256F4 RID: 153332
		public const int ToyLevelItem = 16;
	}
}
