using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F2D RID: 3885
[NullableContext(2)]
[Nullable(0)]
public class AchievementSearchContentItem : UiPanelBase
{
	// Token: 0x0600627D RID: 25213 RVA: 0x001347F6 File Offset: 0x001329F6
	[NullableContext(1)]
	public AchievementSearchContentItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x0600627E RID: 25214 RVA: 0x00134808 File Offset: 0x00132A08
	public UniTask Init()
	{
		AchievementSearchContentItem.<Init>d__8 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementSearchContentItem.<Init>d__8>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600627F RID: 25215 RVA: 0x0013484C File Offset: 0x00132A4C
	[NullableContext(1)]
	public FVector2D GetItemSize(Vector2D vector)
	{
		UUIItem rootItem = base.GetRootItem();
		vector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
		return vector.ToUeVector2D(false);
	}

	// Token: 0x06006280 RID: 25216 RVA: 0x0013487B File Offset: 0x00132A7B
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x06006281 RID: 25217 RVA: 0x00134884 File Offset: 0x00132A84
	[NullableContext(1)]
	public AUIBaseActor GetUsingItem()
	{
		return (AUIBaseActor)base.GetRootItem().GetOwner();
	}

	// Token: 0x06006282 RID: 25218 RVA: 0x00134898 File Offset: 0x00132A98
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

	// Token: 0x06006283 RID: 25219 RVA: 0x001349A8 File Offset: 0x00132BA8
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

	// Token: 0x06006284 RID: 25220 RVA: 0x00134A24 File Offset: 0x00132C24
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x06006285 RID: 25221 RVA: 0x00134A42 File Offset: 0x00132C42
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x06006286 RID: 25222 RVA: 0x00134A60 File Offset: 0x00132C60
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

	// Token: 0x06006287 RID: 25223 RVA: 0x00134AFF File Offset: 0x00132CFF
	private void OnClickButton()
	{
		AchievementController.Instance.RequestGetAchievementReward(false, this.AchievementData.GetId());
	}

	// Token: 0x06006288 RID: 25224 RVA: 0x00134B17 File Offset: 0x00132D17
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

	// Token: 0x06006289 RID: 25225 RVA: 0x00134B58 File Offset: 0x00132D58
	private void RefreshTitle()
	{
		if (AchievementModel.Instance.AchievementSearchState)
		{
			base.GetText(2).SetText(this.AchievementData.GetReplaceTitle(AchievementModel.Instance.CurrentSearchText), true);
			return;
		}
		base.GetText(2).SetText(this.AchievementData.GetTitle(), true);
	}

	// Token: 0x0600628A RID: 25226 RVA: 0x00134BAC File Offset: 0x00132DAC
	private void RefreshDesc()
	{
		if (AchievementModel.Instance.AchievementSearchState)
		{
			base.GetText(4).SetText(this.AchievementData.GetReplaceDesc(AchievementModel.Instance.CurrentSearchText), true);
			return;
		}
		base.GetText(4).SetText(this.AchievementData.GetDesc(), true);
	}

	// Token: 0x0600628B RID: 25227 RVA: 0x00134C00 File Offset: 0x00132E00
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

	// Token: 0x0600628C RID: 25228 RVA: 0x00134C58 File Offset: 0x00132E58
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

	// Token: 0x0600628D RID: 25229 RVA: 0x00134CB9 File Offset: 0x00132EB9
	private void RefreshRedPoint()
	{
		this.ConfirmItem.RefreshRedPoint(this.AchievementData.RedPoint());
	}

	// Token: 0x0600628E RID: 25230 RVA: 0x00134CD1 File Offset: 0x00132ED1
	private void RefreshConfirmBtnState()
	{
		this.ConfirmItem.SetActive(this.AchievementData.GetFinishState() == EAchievementStateEnum.CanGetReward);
	}

	// Token: 0x0600628F RID: 25231 RVA: 0x00134CEC File Offset: 0x00132EEC
	private void RefreshAchievementProgressItem()
	{
		this.AchievementProgressItem.RefreshState(this.AchievementData);
	}

	// Token: 0x06006290 RID: 25232 RVA: 0x00134D00 File Offset: 0x00132F00
	private void RefreshReward()
	{
		List<TItem> rewards = this.AchievementData.GetRewards();
		if (rewards.Count > 0)
		{
			this.RefreshRewardItem(rewards[0]);
		}
	}

	// Token: 0x06006291 RID: 25233 RVA: 0x00134D30 File Offset: 0x00132F30
	private void RefreshRewardItem(TItem data)
	{
		AchievementGridItemData achievementGridItemData = new AchievementGridItemData();
		achievementGridItemData.Data = new TItem?(data);
		achievementGridItemData.GetRewardState = (this.AchievementData.GetFinishState() == EAchievementStateEnum.HaveGetReward);
		this.AchievementGridItem.Refresh(achievementGridItemData, false, 0);
	}

	// Token: 0x06006292 RID: 25234 RVA: 0x00134D71 File Offset: 0x00132F71
	protected override void OnBeforeDestroy()
	{
		if (this.StarItem != null)
		{
			this.StarItem.Destroy(null);
			this.StarItem = null;
		}
		this.RemoveEventListener();
	}

	// Token: 0x04002CB2 RID: 11442
	private AchievementStarItem StarItem;

	// Token: 0x04002CB3 RID: 11443
	private AchievementData AchievementData;

	// Token: 0x04002CB4 RID: 11444
	private AchievementProgressItem AchievementProgressItem;

	// Token: 0x04002CB5 RID: 11445
	private AchievementGridItem AchievementGridItem;

	// Token: 0x04002CB6 RID: 11446
	private AchievementProgressConfirmItem ConfirmItem;

	// Token: 0x04002CB7 RID: 11447
	private static readonly int MaxStarCount = 3;

	// Token: 0x04002CB8 RID: 11448
	private readonly UUIItem SourceItem;

	// Token: 0x02007575 RID: 30069
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04026D57 RID: 159063
		Confirm,
		// Token: 0x04026D58 RID: 159064
		CommonGridItem,
		// Token: 0x04026D59 RID: 159065
		Title,
		// Token: 0x04026D5A RID: 159066
		Progress,
		// Token: 0x04026D5B RID: 159067
		Desc,
		// Token: 0x04026D5C RID: 159068
		StarPos,
		// Token: 0x04026D5D RID: 159069
		ProgressBox
	}
}
