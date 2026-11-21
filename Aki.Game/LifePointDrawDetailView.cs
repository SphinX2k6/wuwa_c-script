using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200074B RID: 1867
[NullableContext(1)]
[Nullable(0)]
public class LifePointDrawDetailView : UiViewBase
{
	// Token: 0x060055CC RID: 21964 RVA: 0x001C2655 File Offset: 0x001C0855
	public LifePointDrawDetailView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060055CD RID: 21965 RVA: 0x001C2660 File Offset: 0x001C0860
	protected unsafe override void OnRegisterComponent()
	{
		this.LifePointDrawDetailViewModel = (this.OpenParam as LifePointDrawViewModel);
		LifePointDrawViewModel lifePointDrawDetailViewModel = this.LifePointDrawDetailViewModel;
		if (lifePointDrawDetailViewModel != null)
		{
			lifePointDrawDetailViewModel.RegisterView(this);
		}
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060055CE RID: 21966 RVA: 0x001C2834 File Offset: 0x001C0A34
	private void OnClickBtn()
	{
		LifePointDrawActivityController instance = LifePointDrawActivityController.Instance;
		LifePointDrawViewModel lifePointDrawDetailViewModel = this.LifePointDrawDetailViewModel;
		int? num;
		if (lifePointDrawDetailViewModel == null)
		{
			num = null;
		}
		else
		{
			LifePointDrawActivityData lifePointDrawActivityData = lifePointDrawDetailViewModel.LifePointDrawActivityData;
			num = ((lifePointDrawActivityData != null) ? new int?(lifePointDrawActivityData.Id) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		LifePointDrawViewModel lifePointDrawDetailViewModel2 = this.LifePointDrawDetailViewModel;
		instance.RequestStartChallenge(valueOrDefault, (lifePointDrawDetailViewModel2 != null) ? lifePointDrawDetailViewModel2.GetCurrentChallengeId() : 0);
	}

	// Token: 0x060055CF RID: 21967 RVA: 0x001C2898 File Offset: 0x001C0A98
	protected override UniTask OnBeforeStartAsync()
	{
		LifePointDrawDetailView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LifePointDrawDetailView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060055D0 RID: 21968 RVA: 0x001C28DB File Offset: 0x001C0ADB
	private LifePointDrawDetailItem CreateChallengeItem()
	{
		LifePointDrawDetailItem lifePointDrawDetailItem = new LifePointDrawDetailItem();
		lifePointDrawDetailItem.SetModel(this.LifePointDrawDetailViewModel);
		return lifePointDrawDetailItem;
	}

	// Token: 0x060055D1 RID: 21969 RVA: 0x001C28EE File Offset: 0x001C0AEE
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x060055D2 RID: 21970 RVA: 0x001C28F8 File Offset: 0x001C0AF8
	public void RefreshLayout(IReadOnlyList<int> list)
	{
		GenericLayout<LifePointDrawDetailItem, int> challengeLayout = this.ChallengeLayout;
		if (challengeLayout != null)
		{
			challengeLayout.RefreshByData(list, null, false);
		}
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(1);
		if (verticalLayout == null)
		{
			return;
		}
		verticalLayout.RootUIComp.Get().SetUIActive(list.Count > 1);
	}

	// Token: 0x060055D3 RID: 21971 RVA: 0x001C2940 File Offset: 0x001C0B40
	public void RefreshRewardLayout(List<TItem> list)
	{
		GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
		if (rewardLayout == null)
		{
			return;
		}
		rewardLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060055D4 RID: 21972 RVA: 0x001C2955 File Offset: 0x001C0B55
	protected override void OnBeforeShow()
	{
		LifePointDrawViewModel lifePointDrawDetailViewModel = this.LifePointDrawDetailViewModel;
		if (lifePointDrawDetailViewModel == null)
		{
			return;
		}
		lifePointDrawDetailViewModel.OnShowView();
	}

	// Token: 0x060055D5 RID: 21973 RVA: 0x001C2967 File Offset: 0x001C0B67
	public void ShowRightUpTitle(string title)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), title, Array.Empty<object>());
	}

	// Token: 0x060055D6 RID: 21974 RVA: 0x001C2980 File Offset: 0x001C0B80
	public void ShowDescText(string desc)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), desc, Array.Empty<object>());
	}

	// Token: 0x060055D7 RID: 21975 RVA: 0x001C299C File Offset: 0x001C0B9C
	public void RefreshLevelNumSprite(string sprite)
	{
		this.SetSpriteByPath(sprite, base.GetSprite(8), false, null, null);
	}

	// Token: 0x060055D8 RID: 21976 RVA: 0x001C29C4 File Offset: 0x001C0BC4
	public void RefreshDifficultTexture(string texture)
	{
		base.SetTextureByPath(texture, base.GetTexture(7), null, null);
	}

	// Token: 0x060055D9 RID: 21977 RVA: 0x001C29E9 File Offset: 0x001C0BE9
	public void PlaySwitchSequence()
	{
		base.PlaySequence("Switch", null, false);
	}

	// Token: 0x04003B72 RID: 15218
	[Nullable(2)]
	private LifePointDrawViewModel LifePointDrawDetailViewModel;

	// Token: 0x04003B73 RID: 15219
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003B74 RID: 15220
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<LifePointDrawDetailItem, int> ChallengeLayout;

	// Token: 0x04003B75 RID: 15221
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x02006A36 RID: 27190
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04022F3C RID: 143164
		public const int CaptionItem = 0;

		// Token: 0x04022F3D RID: 143165
		public const int VerticalLayout = 1;

		// Token: 0x04022F3E RID: 143166
		public const int LayoutItem = 2;

		// Token: 0x04022F3F RID: 143167
		public const int RightUpTitleText = 3;

		// Token: 0x04022F40 RID: 143168
		public const int DescText = 4;

		// Token: 0x04022F41 RID: 143169
		public const int RewardLayout = 5;

		// Token: 0x04022F42 RID: 143170
		public const int RewardItem = 6;

		// Token: 0x04022F43 RID: 143171
		public const int DifficultTexture = 7;

		// Token: 0x04022F44 RID: 143172
		public const int LevelNumSprite = 8;

		// Token: 0x04022F45 RID: 143173
		public const int Btn = 9;
	}
}
