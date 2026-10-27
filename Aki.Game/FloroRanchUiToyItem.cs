using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BAD RID: 7085
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUiToyItem : FloroRanchUiItemBase
{
	// Token: 0x0600D328 RID: 54056 RVA: 0x00308C28 File Offset: 0x00306E28
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

	// Token: 0x0600D329 RID: 54057 RVA: 0x00308EC6 File Offset: 0x003070C6
	protected override void OnBeforeCreate()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x0600D32A RID: 54058 RVA: 0x00308EE0 File Offset: 0x003070E0
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchUiToyItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchUiToyItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D32B RID: 54059 RVA: 0x00308F24 File Offset: 0x00307124
	public override UniTask RefreshItem()
	{
		FloroRanchUiToyItem.<RefreshItem>d__8 <RefreshItem>d__;
		<RefreshItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshItem>d__.<>4__this = this;
		<RefreshItem>d__.<>1__state = -1;
		<RefreshItem>d__.<>t__builder.Start<FloroRanchUiToyItem.<RefreshItem>d__8>(ref <RefreshItem>d__);
		return <RefreshItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D32C RID: 54060 RVA: 0x00308F67 File Offset: 0x00307167
	public override FTransform? GetRewardPopTransform()
	{
		return new FTransform?(base.GetRootActor().GetTransform());
	}

	// Token: 0x0600D32D RID: 54061 RVA: 0x00308F7C File Offset: 0x0030717C
	public override UniTask PlayShowAnim()
	{
		FloroRanchUiToyItem.<PlayShowAnim>d__10 <PlayShowAnim>d__;
		<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayShowAnim>d__.<>4__this = this;
		<PlayShowAnim>d__.<>1__state = -1;
		<PlayShowAnim>d__.<>t__builder.Start<FloroRanchUiToyItem.<PlayShowAnim>d__10>(ref <PlayShowAnim>d__);
		return <PlayShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D32E RID: 54062 RVA: 0x00308FC0 File Offset: 0x003071C0
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiToyItem.<PlayHideAnim>d__11 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiToyItem.<PlayHideAnim>d__11>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D32F RID: 54063 RVA: 0x00309004 File Offset: 0x00307204
	public override UniTask PlayNormalAnim()
	{
		FloroRanchUiToyItem.<PlayNormalAnim>d__12 <PlayNormalAnim>d__;
		<PlayNormalAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNormalAnim>d__.<>4__this = this;
		<PlayNormalAnim>d__.<>1__state = -1;
		<PlayNormalAnim>d__.<>t__builder.Start<FloroRanchUiToyItem.<PlayNormalAnim>d__12>(ref <PlayNormalAnim>d__);
		return <PlayNormalAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D330 RID: 54064 RVA: 0x00309048 File Offset: 0x00307248
	public UniTask PlayToyLevelUpAnim()
	{
		FloroRanchUiToyItem.<PlayToyLevelUpAnim>d__13 <PlayToyLevelUpAnim>d__;
		<PlayToyLevelUpAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayToyLevelUpAnim>d__.<>4__this = this;
		<PlayToyLevelUpAnim>d__.<>1__state = -1;
		<PlayToyLevelUpAnim>d__.<>t__builder.Start<FloroRanchUiToyItem.<PlayToyLevelUpAnim>d__13>(ref <PlayToyLevelUpAnim>d__);
		return <PlayToyLevelUpAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D331 RID: 54065 RVA: 0x0030908B File Offset: 0x0030728B
	public void SetSelectState(bool isSelect)
	{
		base.GetExtendToggle(0).SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600D332 RID: 54066 RVA: 0x003090A4 File Offset: 0x003072A4
	private void OnToggleClick(EToggleState toggleState)
	{
		Action onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback();
	}

	// Token: 0x0600D333 RID: 54067 RVA: 0x003090B6 File Offset: 0x003072B6
	public void BindClickCallback(Action callback)
	{
		this.OnClickCallback = callback;
	}

	// Token: 0x040060B5 RID: 24757
	private FloroRanchEntityDebugInfoItem DebugInfoItem;

	// Token: 0x040060B6 RID: 24758
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x040060B7 RID: 24759
	public FloroRanchToyLevelItem ToyLevelItem;

	// Token: 0x040060B8 RID: 24760
	private Action OnClickCallback = delegate()
	{
	};

	// Token: 0x02008169 RID: 33129
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A3B0 RID: 172976
		public const int Toggle = 0;

		// Token: 0x0402A3B1 RID: 172977
		public const int QualitySprite = 1;

		// Token: 0x0402A3B2 RID: 172978
		public const int IconTexture = 2;

		// Token: 0x0402A3B3 RID: 172979
		public const int CountDownPanel = 3;

		// Token: 0x0402A3B4 RID: 172980
		public const int CountdownText = 4;

		// Token: 0x0402A3B5 RID: 172981
		public const int NumPanel = 5;

		// Token: 0x0402A3B6 RID: 172982
		public const int NumText = 6;

		// Token: 0x0402A3B7 RID: 172983
		public const int LockSprite = 7;

		// Token: 0x0402A3B8 RID: 172984
		public const int InfoPanel = 8;

		// Token: 0x0402A3B9 RID: 172985
		public const int BgSprite = 9;

		// Token: 0x0402A3BA RID: 172986
		public const int IconMaskTexture = 10;

		// Token: 0x0402A3BB RID: 172987
		public const int UnknownPanel = 11;

		// Token: 0x0402A3BC RID: 172988
		public const int ItemPhantomIcon = 12;

		// Token: 0x0402A3BD RID: 172989
		public const int ItemNew = 13;

		// Token: 0x0402A3BE RID: 172990
		public const int ToyRaceItem = 14;

		// Token: 0x0402A3BF RID: 172991
		public const int ToyRaceIcon = 15;

		// Token: 0x0402A3C0 RID: 172992
		public const int ToyLevelItem = 16;
	}
}
