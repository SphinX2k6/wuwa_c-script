using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020003E2 RID: 994
[NullableContext(2)]
[Nullable(0)]
public class AchievementSearchContentItem : UiPanelBase
{
	// Token: 0x06003615 RID: 13845 RVA: 0x0013D11E File Offset: 0x0013B31E
	[NullableContext(1)]
	public AchievementSearchContentItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06003616 RID: 13846 RVA: 0x0013D130 File Offset: 0x0013B330
	public UniTask Init()
	{
		AchievementSearchContentItem.<Init>d__8 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementSearchContentItem.<Init>d__8>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06003617 RID: 13847 RVA: 0x0013D174 File Offset: 0x0013B374
	[NullableContext(1)]
	public FVector2D GetItemSize(Vector2D vector)
	{
		UUIItem rootItem = base.GetRootItem();
		vector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
		return vector.ToUeVector2D(false);
	}

	// Token: 0x06003618 RID: 13848 RVA: 0x0013D1A3 File Offset: 0x0013B3A3
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x06003619 RID: 13849 RVA: 0x0013D1AC File Offset: 0x0013B3AC
	[NullableContext(1)]
	public AUIBaseActor GetUsingItem()
	{
		return (AUIBaseActor)base.GetRootItem().GetOwner();
	}

	// Token: 0x0600361A RID: 13850 RVA: 0x0013D1C0 File Offset: 0x0013B3C0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600361B RID: 13851 RVA: 0x0013D2D0 File Offset: 0x0013B4D0
	protected override void OnStart()
	{
		this.AchievementProgressItem = new AchievementProgressItem(base.GetItem(6));
		this.AchievementProgressItem.SetActive(true);
		this.AchievementGridItem = new AchievementGridItem();
		this.AchievementGridItem.Initialize(base.GetItem(1).GetOwner());
		this.ConfirmItem = new AchievementProgressConfirmItem(base.GetItem(0));
		this.ConfirmItem.SetClickCallback(new Action(this.OnClickButton));
		this.AddEventListener();
	}

	// Token: 0x0600361C RID: 13852 RVA: 0x0013D34C File Offset: 0x0013B54C
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x0600361D RID: 13853 RVA: 0x0013D36A File Offset: 0x0013B56A
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x0600361E RID: 13854 RVA: 0x0013D388 File Offset: 0x0013B588
	private void OnAchievementDataWithIdNotify(int id)
	{
		if (AchievementModel.Instance.AchievementSearchState)
		{
			return;
		}
		AchievementData achievementData = this.AchievementData;
		int? num = (achievementData != null) ? new int?(achievementData.GetId()) : null;
		if ((id == num.GetValueOrDefault() & num != null) && (this.AchievementData.IfSingleAchievement() || (!this.AchievementData.IfSingleAchievement() && this.AchievementData.GetNextLink() == 0)))
		{
			this.RefreshDesc();
			this.RefreshProgress();
			this.RefreshStar();
			this.RefreshRedPoint();
			this.RefreshReward();
			this.RefreshConfirmBtnState();
			this.RefreshAchievementProgressItem();
		}
	}

	// Token: 0x0600361F RID: 13855 RVA: 0x0013D427 File Offset: 0x0013B627
	private void OnClickButton()
	{
		AchievementController.Instance.RequestGetAchievementReward(false, this.AchievementData.GetId());
	}

	// Token: 0x06003620 RID: 13856 RVA: 0x0013D43F File Offset: 0x0013B63F
	[NullableContext(1)]
	public void Update(AchievementSearchData data)
	{
		this.AchievementData = data.AchievementData;
		this.RefreshTitle();
		this.RefreshDesc();
		this.RefreshProgress();
		this.RefreshStar();
		this.RefreshRedPoint();
		this.RefreshReward();
		this.RefreshConfirmBtnState();
		this.RefreshAchievementProgressItem();
	}

	// Token: 0x06003621 RID: 13857 RVA: 0x0013D480 File Offset: 0x0013B680
	private void RefreshTitle()
	{
		if (AchievementModel.Instance.AchievementSearchState)
		{
			base.GetText(2).SetText(this.AchievementData.GetReplaceTitle(AchievementModel.Instance.CurrentSearchText), true);
			return;
		}
		base.GetText(2).SetText(this.AchievementData.GetTitle(), true);
	}

	// Token: 0x06003622 RID: 13858 RVA: 0x0013D4D4 File Offset: 0x0013B6D4
	private void RefreshDesc()
	{
		if (AchievementModel.Instance.AchievementSearchState)
		{
			base.GetText(4).SetText(this.AchievementData.GetReplaceDesc(AchievementModel.Instance.CurrentSearchText), true);
			return;
		}
		base.GetText(4).SetText(this.AchievementData.GetDesc(), true);
	}

	// Token: 0x06003623 RID: 13859 RVA: 0x0013D528 File Offset: 0x0013B728
	private void RefreshProgress()
	{
		int? currentProgress = this.AchievementData.GetCurrentProgress();
		int? maxProgress = this.AchievementData.GetMaxProgress();
		LguiUtil.Instance.SetLocalText(base.GetText(3), "CollectProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			currentProgress,
			maxProgress
		}));
	}

	// Token: 0x06003624 RID: 13860 RVA: 0x0013D580 File Offset: 0x0013B780
	private void RefreshStar()
	{
		if (this.StarItem != null)
		{
			this.StarItem.Destroy(null);
			this.StarItem = null;
		}
		int count = this.AchievementData.IfSingleAchievement() ? this.AchievementData.GetAchievementShowStar() : AchievementSearchContentItem.MaxStarCount;
		this.StarItem = new AchievementStarItem(count, this.AchievementData, base.GetItem(5));
	}

	// Token: 0x06003625 RID: 13861 RVA: 0x0013D5E1 File Offset: 0x0013B7E1
	private void RefreshRedPoint()
	{
		this.ConfirmItem.RefreshRedPoint(this.AchievementData.RedPoint());
	}

	// Token: 0x06003626 RID: 13862 RVA: 0x0013D5F9 File Offset: 0x0013B7F9
	private void RefreshConfirmBtnState()
	{
		this.ConfirmItem.SetActive(this.AchievementData.GetFinishState() == EAchievementStateEnum.CanGetReward);
	}

	// Token: 0x06003627 RID: 13863 RVA: 0x0013D614 File Offset: 0x0013B814
	private void RefreshAchievementProgressItem()
	{
		this.AchievementProgressItem.RefreshState(this.AchievementData);
	}

	// Token: 0x06003628 RID: 13864 RVA: 0x0013D628 File Offset: 0x0013B828
	private void RefreshReward()
	{
		List<TItem> rewards = this.AchievementData.GetRewards();
		if (rewards.Count > 0)
		{
			this.RefreshRewardItem(rewards[0]);
		}
	}

	// Token: 0x06003629 RID: 13865 RVA: 0x0013D658 File Offset: 0x0013B858
	private void RefreshRewardItem(TItem data)
	{
		AchievementGridItemData achievementGridItemData = new AchievementGridItemData();
		achievementGridItemData.Data = new TItem?(data);
		achievementGridItemData.GetRewardState = (this.AchievementData.GetFinishState() == EAchievementStateEnum.HaveGetReward);
		this.AchievementGridItem.Refresh(achievementGridItemData, false, 0);
	}

	// Token: 0x0600362A RID: 13866 RVA: 0x0013D699 File Offset: 0x0013B899
	protected override void OnBeforeDestroy()
	{
		if (this.StarItem != null)
		{
			this.StarItem.Destroy(null);
			this.StarItem = null;
		}
		this.RemoveEventListener();
	}

	// Token: 0x04002D4B RID: 11595
	private AchievementStarItem StarItem;

	// Token: 0x04002D4C RID: 11596
	private AchievementData AchievementData;

	// Token: 0x04002D4D RID: 11597
	private AchievementProgressItem AchievementProgressItem;

	// Token: 0x04002D4E RID: 11598
	private AchievementGridItem AchievementGridItem;

	// Token: 0x04002D4F RID: 11599
	private AchievementProgressConfirmItem ConfirmItem;

	// Token: 0x04002D50 RID: 11600
	private static readonly int MaxStarCount = 3;

	// Token: 0x04002D51 RID: 11601
	private readonly UUIItem SourceItem;

	// Token: 0x02006709 RID: 26377
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040220A2 RID: 139426
		Confirm,
		// Token: 0x040220A3 RID: 139427
		CommonGridItem,
		// Token: 0x040220A4 RID: 139428
		Title,
		// Token: 0x040220A5 RID: 139429
		Progress,
		// Token: 0x040220A6 RID: 139430
		Desc,
		// Token: 0x040220A7 RID: 139431
		StarPos,
		// Token: 0x040220A8 RID: 139432
		ProgressBox
	}
}
