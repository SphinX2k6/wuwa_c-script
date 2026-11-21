using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020003D4 RID: 980
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class AchievementDataItem : GridProxyAbstract<AchievementData>
{
	// Token: 0x170007BA RID: 1978
	// (get) Token: 0x06003584 RID: 13700 RVA: 0x0013A659 File Offset: 0x00138859
	// (set) Token: 0x06003585 RID: 13701 RVA: 0x0013A661 File Offset: 0x00138861
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public new ScrollViewDelegate<IGridProxy<AchievementData>, AchievementData> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x170007BB RID: 1979
	// (get) Token: 0x06003586 RID: 13702 RVA: 0x0013A66A File Offset: 0x0013886A
	// (set) Token: 0x06003587 RID: 13703 RVA: 0x0013A672 File Offset: 0x00138872
	public new int GridIndex { get; set; }

	// Token: 0x170007BC RID: 1980
	// (get) Token: 0x06003588 RID: 13704 RVA: 0x0013A67B File Offset: 0x0013887B
	// (set) Token: 0x06003589 RID: 13705 RVA: 0x0013A683 File Offset: 0x00138883
	public new int DisplayIndex { get; set; }

	// Token: 0x0600358A RID: 13706 RVA: 0x0013A68C File Offset: 0x0013888C
	public UniTask Init(UUIItem item)
	{
		AchievementDataItem.<Init>d__17 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementDataItem.<Init>d__17>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600358B RID: 13707 RVA: 0x0013A6D8 File Offset: 0x001388D8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600358C RID: 13708 RVA: 0x0013A867 File Offset: 0x00138A67
	protected override void OnStart()
	{
		if (this.AchievementGridItem == null)
		{
			this.AchievementGridItem = new AchievementGridItem();
			this.AchievementGridItem.Initialize(base.GetItem(8).GetOwner());
		}
		this.AchievementGridItem.SetActive(false);
		this.AddEventListener();
	}

	// Token: 0x0600358D RID: 13709 RVA: 0x0013A8A5 File Offset: 0x00138AA5
	public override void Refresh(AchievementData data, bool isSelected, int gridIndex)
	{
		this.RefreshUi(data);
	}

	// Token: 0x0600358E RID: 13710 RVA: 0x0013A8B0 File Offset: 0x00138AB0
	public void RefreshUi(AchievementData data)
	{
		if (data == null)
		{
			Log.Instance.Error(ELogModule.Achievement, ELogAuthor.BB, "AchievementDataItem Data为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.AchievementData = data;
		int? currentProgress = data.GetCurrentProgress();
		int? maxProgress = data.GetMaxProgress();
		EAchievementStateEnum finishState = data.GetFinishState();
		UUIText text = base.GetText(5);
		UUIText text2 = base.GetText(6);
		UUIText text3 = base.GetText(3);
		if (AchievementModel.Instance.AchievementSearchState)
		{
			string currentSearchText = AchievementModel.Instance.CurrentSearchText;
			text.SetText(data.GetReplaceTitle(currentSearchText), true);
			text2.SetText(data.GetReplaceDesc(currentSearchText), true);
		}
		else
		{
			text.SetText(data.GetTitle(), true);
			text2.SetText(data.GetDesc(), true);
		}
		LguiUtil.Instance.SetLocalText(base.GetText(7), "CollectProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			currentProgress,
			maxProgress
		}));
		base.SetButtonUiActive(2, finishState == EAchievementStateEnum.CanGetReward);
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(data.RedPoint());
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(finishState == EAchievementStateEnum.HaveGetReward);
		}
		if (finishState == EAchievementStateEnum.UnFinished)
		{
			if (text3 != null)
			{
				text3.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(text3, "Text_Doing_Text", Array.Empty<object>());
		}
		else if (finishState == EAchievementStateEnum.CanGetReward)
		{
			if (text3 != null)
			{
				text3.SetUIActive(false);
			}
		}
		else
		{
			if (text3 != null)
			{
				text3.SetUIActive(true);
			}
			DateTime localDateTime = DateTimeOffset.FromUnixTimeMilliseconds(data.GetFinishTime().Value * (long)TimeUtil.Instance.InverseMillisecond).LocalDateTime;
			string newText = TimeUtil.Instance.DateFormat4(localDateTime);
			if (text3 != null)
			{
				text3.SetText(newText, true);
			}
		}
		List<TItem> rewards = data.GetRewards();
		if (rewards.Count > 0)
		{
			this.RefreshRewardItem(rewards[0]);
		}
		this.RefreshStar();
	}

	// Token: 0x0600358F RID: 13711 RVA: 0x0013AA89 File Offset: 0x00138C89
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x06003590 RID: 13712 RVA: 0x0013AA92 File Offset: 0x00138C92
	public AUIBaseActor GetUsingItem(AchievementData data)
	{
		return (AUIBaseActor)base.GetRootItem().GetOwner();
	}

	// Token: 0x06003591 RID: 13713 RVA: 0x0013AAA4 File Offset: 0x00138CA4
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x06003592 RID: 13714 RVA: 0x0013AAC2 File Offset: 0x00138CC2
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x06003593 RID: 13715 RVA: 0x0013AAE0 File Offset: 0x00138CE0
	private void OnAchievementDataWithIdNotify(int id)
	{
		if (this.AchievementData != null && id == this.AchievementData.GetId() && (this.AchievementData.IfSingleAchievement() || (!this.AchievementData.IfSingleAchievement() && this.AchievementData.GetNextLink() == 0)))
		{
			this.RefreshUi(this.AchievementData);
		}
	}

	// Token: 0x06003594 RID: 13716 RVA: 0x0013AB36 File Offset: 0x00138D36
	private void OnClickButton()
	{
		AchievementController.Instance.RequestGetAchievementReward(false, this.AchievementData.GetId());
	}

	// Token: 0x06003595 RID: 13717 RVA: 0x0013AB50 File Offset: 0x00138D50
	private void RefreshStar()
	{
		if (this.StarItem != null)
		{
			this.StarItem.Destroy(null);
			this.StarItem = null;
		}
		int count = this.AchievementData.IfSingleAchievement() ? this.AchievementData.GetAchievementShowStar() : AchievementDataItem.MaxStarCount;
		this.StarItem = new AchievementStarItem(count, this.AchievementData, base.GetItem(9));
	}

	// Token: 0x06003596 RID: 13718 RVA: 0x0013ABB4 File Offset: 0x00138DB4
	private void RefreshRewardItem(TItem data)
	{
		this.AchievementGridItem.SetActive(true);
		AchievementGridItemData achievementGridItemData = new AchievementGridItemData();
		achievementGridItemData.Data = new TItem?(data);
		achievementGridItemData.GetRewardState = (this.AchievementData.GetFinishState() == EAchievementStateEnum.HaveGetReward);
		this.AchievementGridItem.Refresh(achievementGridItemData, false, 0);
	}

	// Token: 0x06003597 RID: 13719 RVA: 0x0013AC01 File Offset: 0x00138E01
	protected override void OnBeforeDestroy()
	{
		if (this.StarItem != null)
		{
			this.StarItem.Destroy(null);
		}
		if (this.AchievementGridItem != null)
		{
			this.AchievementGridItem.Destroy(null);
		}
		if (this.AchievementData != null)
		{
			this.AchievementData = null;
		}
		this.RemoveEventListener();
	}

	// Token: 0x04002D1A RID: 11546
	[Nullable(2)]
	private AchievementStarItem StarItem;

	// Token: 0x04002D1B RID: 11547
	[Nullable(2)]
	private AchievementData AchievementData;

	// Token: 0x04002D1C RID: 11548
	[Nullable(2)]
	private AchievementGridItem AchievementGridItem;

	// Token: 0x04002D1D RID: 11549
	private static readonly int MaxStarCount = 3;

	// Token: 0x020066F8 RID: 26360
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022049 RID: 139337
		Toggle,
		// Token: 0x0402204A RID: 139338
		RedDot,
		// Token: 0x0402204B RID: 139339
		ReceiveBtn,
		// Token: 0x0402204C RID: 139340
		AchieveStateText,
		// Token: 0x0402204D RID: 139341
		CompleteItem,
		// Token: 0x0402204E RID: 139342
		AchieveTitle,
		// Token: 0x0402204F RID: 139343
		AchieveDesc,
		// Token: 0x04022050 RID: 139344
		AchieveProgress,
		// Token: 0x04022051 RID: 139345
		CommonGridItem,
		// Token: 0x04022052 RID: 139346
		StarPos
	}
}
