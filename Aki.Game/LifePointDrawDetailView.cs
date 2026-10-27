using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001297 RID: 4759
[NullableContext(1)]
[Nullable(0)]
public class LifePointDrawDetailView : UiViewBase
{
	// Token: 0x06008235 RID: 33333 RVA: 0x001B9985 File Offset: 0x001B7B85
	public LifePointDrawDetailView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008236 RID: 33334 RVA: 0x001B9990 File Offset: 0x001B7B90
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

	// Token: 0x06008237 RID: 33335 RVA: 0x001B9B64 File Offset: 0x001B7D64
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

	// Token: 0x06008238 RID: 33336 RVA: 0x001B9BC8 File Offset: 0x001B7DC8
	protected override UniTask OnBeforeStartAsync()
	{
		LifePointDrawDetailView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LifePointDrawDetailView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008239 RID: 33337 RVA: 0x001B9C0B File Offset: 0x001B7E0B
	private LifePointDrawDetailItem CreateChallengeItem()
	{
		LifePointDrawDetailItem lifePointDrawDetailItem = new LifePointDrawDetailItem();
		lifePointDrawDetailItem.SetModel(this.LifePointDrawDetailViewModel);
		return lifePointDrawDetailItem;
	}

	// Token: 0x0600823A RID: 33338 RVA: 0x001B9C1E File Offset: 0x001B7E1E
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600823B RID: 33339 RVA: 0x001B9C28 File Offset: 0x001B7E28
	public void RefreshLayout(List<int> list)
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

	// Token: 0x0600823C RID: 33340 RVA: 0x001B9C70 File Offset: 0x001B7E70
	public void RefreshRewardLayout(List<TItem> list)
	{
		GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
		if (rewardLayout == null)
		{
			return;
		}
		rewardLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0600823D RID: 33341 RVA: 0x001B9C85 File Offset: 0x001B7E85
	protected override void OnBeforeShow()
	{
		LifePointDrawViewModel lifePointDrawDetailViewModel = this.LifePointDrawDetailViewModel;
		if (lifePointDrawDetailViewModel == null)
		{
			return;
		}
		lifePointDrawDetailViewModel.OnShowView();
	}

	// Token: 0x0600823E RID: 33342 RVA: 0x001B9C97 File Offset: 0x001B7E97
	public void ShowRightUpTitle(string title)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), title, Array.Empty<object>());
	}

	// Token: 0x0600823F RID: 33343 RVA: 0x001B9CB0 File Offset: 0x001B7EB0
	public void ShowDescText(string desc)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), desc, Array.Empty<object>());
	}

	// Token: 0x06008240 RID: 33344 RVA: 0x001B9CCC File Offset: 0x001B7ECC
	public void RefreshLevelNumSprite(string sprite)
	{
		this.SetSpriteByPath(sprite, base.GetSprite(8), false, null, null);
	}

	// Token: 0x06008241 RID: 33345 RVA: 0x001B9CF4 File Offset: 0x001B7EF4
	public void RefreshDifficultTexture(string texture)
	{
		base.SetTextureByPath(texture, base.GetTexture(7), null, null);
	}

	// Token: 0x06008242 RID: 33346 RVA: 0x001B9D19 File Offset: 0x001B7F19
	public void PlaySwitchSequence()
	{
		base.PlaySequence("Switch", null, false);
	}

	// Token: 0x04003ADA RID: 15066
	[Nullable(2)]
	private LifePointDrawViewModel LifePointDrawDetailViewModel;

	// Token: 0x04003ADB RID: 15067
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003ADC RID: 15068
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<LifePointDrawDetailItem, int> ChallengeLayout;

	// Token: 0x04003ADD RID: 15069
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x020078AB RID: 30891
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04027C0B RID: 162827
		public const int CaptionItem = 0;

		// Token: 0x04027C0C RID: 162828
		public const int VerticalLayout = 1;

		// Token: 0x04027C0D RID: 162829
		public const int LayoutItem = 2;

		// Token: 0x04027C0E RID: 162830
		public const int RightUpTitleText = 3;

		// Token: 0x04027C0F RID: 162831
		public const int DescText = 4;

		// Token: 0x04027C10 RID: 162832
		public const int RewardLayout = 5;

		// Token: 0x04027C11 RID: 162833
		public const int RewardItem = 6;

		// Token: 0x04027C12 RID: 162834
		public const int DifficultTexture = 7;

		// Token: 0x04027C13 RID: 162835
		public const int LevelNumSprite = 8;

		// Token: 0x04027C14 RID: 162836
		public const int Btn = 9;
	}
}
