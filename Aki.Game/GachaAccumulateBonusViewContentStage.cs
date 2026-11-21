using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001129 RID: 4393
[NullableContext(1)]
[Nullable(0)]
public class GachaAccumulateBonusViewContentStage : GachaAccumulateBonusContentBase
{
	// Token: 0x0600AF45 RID: 44869 RVA: 0x00339F58 File Offset: 0x00338158
	protected unsafe override void OnRegisterComponent()
	{
		int num = 18;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600AF46 RID: 44870 RVA: 0x0033A1DC File Offset: 0x003383DC
	protected override UniTask OnBeforeStartAsync()
	{
		GachaAccumulateBonusViewContentStage.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaAccumulateBonusViewContentStage.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF47 RID: 44871 RVA: 0x0033A220 File Offset: 0x00338420
	protected override void OnStart()
	{
		this.UiSequencePlayer = new UiSequencePlayer(this.RootItem);
		this.LoopScroll = new LoopScrollView<GachaAccumulateRewardItemStage, GachaAccumulateRewardItemStageData>(base.GetLoopScrollViewComponent(2), base.GetItem(3).GetOwner() as AUIBaseActor, () => new GachaAccumulateRewardItemStage(), false);
		this.LoopScroll.BindOnScrollValueChanged(delegate(FVector2D _)
		{
			this.OnLoopScrollValueChanged();
		});
		this.LoopScroll.BindLateUpdate(new Action<float>(this.OnLoopScrollLateUpdate));
	}

	// Token: 0x0600AF48 RID: 44872 RVA: 0x0033A2AF File Offset: 0x003384AF
	protected override void OnBeforeDestroy()
	{
		if (this.LoopScroll != null)
		{
			this.LoopScroll.UnBindLateUpdate();
			this.LoopScroll.ClearGridProxies();
			this.LoopScroll = null;
		}
	}

	// Token: 0x0600AF49 RID: 44873 RVA: 0x0033A2D8 File Offset: 0x003384D8
	public override UniTask PlayStartSequence()
	{
		GachaAccumulateBonusViewContentStage.<PlayStartSequence>d__23 <PlayStartSequence>d__;
		<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayStartSequence>d__.<>4__this = this;
		<PlayStartSequence>d__.<>1__state = -1;
		<PlayStartSequence>d__.<>t__builder.Start<GachaAccumulateBonusViewContentStage.<PlayStartSequence>d__23>(ref <PlayStartSequence>d__);
		return <PlayStartSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF4A RID: 44874 RVA: 0x0033A31C File Offset: 0x0033851C
	public override UniTask PlayCloseSequence()
	{
		GachaAccumulateBonusViewContentStage.<PlayCloseSequence>d__24 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<GachaAccumulateBonusViewContentStage.<PlayCloseSequence>d__24>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF4B RID: 44875 RVA: 0x0033A35F File Offset: 0x0033855F
	public override void SetOnClickBackButtonCallBack(Action callback)
	{
		this.OnClickBackButtonCallBack = callback;
	}

	// Token: 0x0600AF4C RID: 44876 RVA: 0x0033A368 File Offset: 0x00338568
	private void OnBackButtonClick()
	{
		this.OnClickBackButtonCallBack();
	}

	// Token: 0x0600AF4D RID: 44877 RVA: 0x0033A378 File Offset: 0x00338578
	private void RefreshCaptionHelpBtn(int accumulateId)
	{
		int helpId = GachaAccumulateConfig.Instance.GetHelpId(accumulateId);
		if (helpId <= 0)
		{
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetHelpBtnActive(false);
			return;
		}
		else
		{
			PopupCaptionItem captionItem2 = this.CaptionItem;
			if (captionItem2 != null)
			{
				captionItem2.SetHelpBtnActive(true);
			}
			PopupCaptionItem captionItem3 = this.CaptionItem;
			if (captionItem3 == null)
			{
				return;
			}
			captionItem3.SetHelpCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(helpId);
			});
			return;
		}
	}

	// Token: 0x0600AF4E RID: 44878 RVA: 0x0033A3E8 File Offset: 0x003385E8
	public override void RefreshView(int accumulateId)
	{
		this.CurrentAccumulateId = accumulateId;
		GachaAccumulateData accumulateData = GachaAccumulateModel.Instance.GetAccumulateData(accumulateId);
		if (accumulateData == null)
		{
			return;
		}
		this.RefreshCaptionHelpBtn(accumulateId);
		int cyclicBaseGachaNum = accumulateData.GetCyclicBaseGachaNum();
		bool flag = cyclicBaseGachaNum > 0 && accumulateData.CurGachaNum >= cyclicBaseGachaNum;
		UUIText text = base.GetText(10);
		UUIItem item = base.GetItem(17);
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "allProgressRewardsCompleted", Array.Empty<object>());
			item.SetUIActive(false);
		}
		else
		{
			text.SetText(accumulateData.CurGachaNum.ToString(), true);
			item.SetUIActive(true);
		}
		bool flag2 = this.CollectNonCyclicMilestones(accumulateData).Count <= 9;
		this.ApplyLayoutVisibility(flag2);
		if (flag2)
		{
			GachaAccumulateStageBigRewardPanel bigRewardPanel = this.BigRewardPanel;
			if (bigRewardPanel != null)
			{
				bigRewardPanel.SetUiActive(false);
			}
			GachaAccumulateStageCyclicPanel cyclicPanel = this.CyclicPanel;
			if (cyclicPanel != null)
			{
				cyclicPanel.SetUiActive(false);
			}
			this.NeedLateUpdate = false;
			this.LastAutoScrollAccumulateId = accumulateId;
			this.RefreshFixedLayout(accumulateId, accumulateData);
			this.RefreshFixedProgressBar(accumulateData);
			return;
		}
		this.RefreshLayout(accumulateId, accumulateData);
		this.RefreshProgressBar(accumulateData);
		this.RefreshBigRewardByScroll(accumulateData);
	}

	// Token: 0x0600AF4F RID: 44879 RVA: 0x0033A4F8 File Offset: 0x003386F8
	private void ApplyLayoutVisibility(bool useFixed)
	{
		LoopScrollView<GachaAccumulateRewardItemStage, GachaAccumulateRewardItemStageData> loopScroll = this.LoopScroll;
		if (loopScroll != null)
		{
			loopScroll.SetTargetRootComponentActive(!useFixed);
		}
		base.GetItem(4).SetUIActive(!useFixed);
		base.GetItem(8).SetUIActive(!useFixed);
		base.GetItem(9).SetUIActive(!useFixed);
		base.GetHorizontalLayout(11).RootUIComp.Get().SetUIActive(useFixed);
		base.GetItem(13).SetUIActive(useFixed);
	}

	// Token: 0x0600AF50 RID: 44880 RVA: 0x0033A574 File Offset: 0x00338774
	private void RefreshLayout(int accumulateId, GachaAccumulateData accumulateData)
	{
		List<GachaAccumulateRewardItemStageData> list = new List<GachaAccumulateRewardItemStageData>();
		GachaAccumulateRewardData lastData = null;
		foreach (GachaAccumulateRewardData gachaAccumulateRewardData in accumulateData.GroupData.RewardInfos)
		{
			if (!gachaAccumulateRewardData.GetIfCyclic())
			{
				list.Add(new GachaAccumulateRewardItemStageData
				{
					AccumulateId = accumulateId,
					Data = gachaAccumulateRewardData,
					LastData = lastData
				});
				lastData = gachaAccumulateRewardData;
			}
		}
		this.LastSeenEndGridIndex = -2;
		if (this.LastAutoScrollAccumulateId != accumulateId)
		{
			this.LastAutoScrollAccumulateId = accumulateId;
			this.NeedLateUpdate = true;
		}
		this.LoopScroll.RefreshByData(list, false, null, false);
	}

	// Token: 0x0600AF51 RID: 44881 RVA: 0x0033A628 File Offset: 0x00338828
	private void RefreshProgressBar(GachaAccumulateData accumulateData)
	{
		this.EnsurePointItems(accumulateData);
		List<int> milestones = this.CollectNonCyclicMilestones(accumulateData);
		base.GetSprite(5).SetFillAmount(this.CalcProgressFillAmount(milestones, accumulateData.CurGachaNum));
		this.RefreshPointItemsState(this.SpawnedPointItems, milestones, accumulateData.CurGachaNum);
	}

	// Token: 0x0600AF52 RID: 44882 RVA: 0x0033A670 File Offset: 0x00338870
	private void RefreshFixedLayout(int accumulateId, GachaAccumulateData accumulateData)
	{
		if (!this.FixedSpawnStarted)
		{
			this.FixedSpawnStarted = true;
			int count = this.CollectNonCyclicMilestones(accumulateData).Count;
			this.SpawnFixedPointItems(count);
			this.SpawnFixedItemsAsync(accumulateId, count).Forget();
			return;
		}
		if (!this.FixedReady)
		{
			return;
		}
		this.RefreshFixedRewardItemsData(accumulateId, accumulateData);
	}

	// Token: 0x0600AF53 RID: 44883 RVA: 0x0033A6C0 File Offset: 0x003388C0
	private UniTask SpawnFixedItemsAsync(int accumulateId, int count)
	{
		GachaAccumulateBonusViewContentStage.<SpawnFixedItemsAsync>d__33 <SpawnFixedItemsAsync>d__;
		<SpawnFixedItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SpawnFixedItemsAsync>d__.<>4__this = this;
		<SpawnFixedItemsAsync>d__.accumulateId = accumulateId;
		<SpawnFixedItemsAsync>d__.count = count;
		<SpawnFixedItemsAsync>d__.<>1__state = -1;
		<SpawnFixedItemsAsync>d__.<>t__builder.Start<GachaAccumulateBonusViewContentStage.<SpawnFixedItemsAsync>d__33>(ref <SpawnFixedItemsAsync>d__);
		return <SpawnFixedItemsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF54 RID: 44884 RVA: 0x0033A714 File Offset: 0x00338914
	private void RefreshFixedRewardItemsData(int accumulateId, GachaAccumulateData accumulateData)
	{
		GachaAccumulateRewardData lastData = null;
		int num = 0;
		foreach (GachaAccumulateRewardData gachaAccumulateRewardData in accumulateData.GroupData.RewardInfos)
		{
			if (!gachaAccumulateRewardData.GetIfCyclic())
			{
				if (num < this.SpawnedFixedRewardItems.Count)
				{
					GridProxyAbstract<GachaAccumulateRewardItemStageData> gridProxyAbstract = this.SpawnedFixedRewardItems[num];
					GachaAccumulateRewardItemStageData data = new GachaAccumulateRewardItemStageData
					{
						AccumulateId = accumulateId,
						Data = gachaAccumulateRewardData,
						LastData = lastData
					};
					gridProxyAbstract.Refresh(data, false, num);
				}
				lastData = gachaAccumulateRewardData;
				num++;
			}
		}
	}

	// Token: 0x0600AF55 RID: 44885 RVA: 0x0033A7B8 File Offset: 0x003389B8
	private void SpawnFixedPointItems(int count)
	{
		UUIItem item = base.GetItem(16);
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(15);
		if (item == null || horizontalLayout == null)
		{
			return;
		}
		item.SetUIActive(false);
		for (int i = 0; i < count; i++)
		{
			UUIItem uuiitem = LguiUtil.Instance.CopyItem(item, horizontalLayout.RootUIComp);
			uuiitem.SetUIActive(true);
			this.SpawnedFixedPointItems.Add(uuiitem);
		}
	}

	// Token: 0x0600AF56 RID: 44886 RVA: 0x0033A81C File Offset: 0x00338A1C
	private void RefreshFixedProgressBar(GachaAccumulateData accumulateData)
	{
		List<int> milestones = this.CollectNonCyclicMilestones(accumulateData);
		UUISprite sprite = base.GetSprite(14);
		float width = base.GetHorizontalLayout(15).RootUIComp.Get().Width;
		sprite.SetFillAmount(this.CalcFixedProgressFillAmount(milestones, accumulateData.CurGachaNum, width));
		this.RefreshPointItemsState(this.SpawnedFixedPointItems, milestones, accumulateData.CurGachaNum);
	}

	// Token: 0x0600AF57 RID: 44887 RVA: 0x0033A87C File Offset: 0x00338A7C
	private void RefreshPointItemsState(List<UUIItem> pointItems, List<int> milestones, int cur)
	{
		for (int i = 0; i < pointItems.Count; i++)
		{
			UUIItem attachUIChild = pointItems[i].GetAttachUIChild(1);
			if (attachUIChild != null)
			{
				bool uiactive = i < milestones.Count && cur >= milestones[i];
				attachUIChild.SetUIActive(uiactive);
			}
		}
	}

	// Token: 0x0600AF58 RID: 44888 RVA: 0x0033A8CC File Offset: 0x00338ACC
	private List<int> CollectNonCyclicMilestones(GachaAccumulateData accumulateData)
	{
		List<int> list = new List<int>();
		foreach (GachaAccumulateRewardData gachaAccumulateRewardData in accumulateData.GroupData.RewardInfos)
		{
			if (!gachaAccumulateRewardData.GetIfCyclic())
			{
				list.Add(gachaAccumulateRewardData.GachaNum);
			}
		}
		return list;
	}

	// Token: 0x0600AF59 RID: 44889 RVA: 0x0033A938 File Offset: 0x00338B38
	private float CalcProgressFillAmount(List<int> milestones, int cur)
	{
		if (milestones.Count == 0)
		{
			return 0f;
		}
		int num = 90;
		int num2 = 180;
		int num3 = num + num2 * (milestones.Count - 1);
		int num4 = milestones[milestones.Count - 1];
		double num5;
		if (cur >= num4)
		{
			num5 = (double)num3;
		}
		else if (cur < milestones[0])
		{
			num5 = (double)num * ((double)cur / (double)milestones[0]);
		}
		else
		{
			int num6 = 0;
			while (num6 < milestones.Count - 1 && (cur < milestones[num6] || cur >= milestones[num6 + 1]))
			{
				num6++;
			}
			double num7 = (double)(cur - milestones[num6]) / (double)(milestones[num6 + 1] - milestones[num6]);
			num5 = (double)(num + num2 * num6) + (double)num2 * num7;
		}
		double num8 = (num3 > 0) ? (num5 / (double)num3) : 0.0;
		return (float)((num8 < 0.0) ? 0.0 : ((num8 > 1.0) ? 1.0 : num8));
	}

	// Token: 0x0600AF5A RID: 44890 RVA: 0x0033AA50 File Offset: 0x00338C50
	private float CalcFixedProgressFillAmount(List<int> milestones, int cur, float pointListWidth)
	{
		if (milestones.Count == 0)
		{
			return 0f;
		}
		int num = 90;
		float num2 = (float)num + pointListWidth;
		if (milestones.Count != 1)
		{
			float num3 = pointListWidth / (float)(milestones.Count - 1);
			int num4 = milestones[milestones.Count - 1];
			double num5;
			if (cur >= num4)
			{
				num5 = (double)num2;
			}
			else if (cur < milestones[0])
			{
				num5 = (double)num * ((double)cur / (double)milestones[0]);
			}
			else
			{
				int num6 = 0;
				while (num6 < milestones.Count - 1 && (cur < milestones[num6] || cur >= milestones[num6 + 1]))
				{
					num6++;
				}
				double num7 = (double)(cur - milestones[num6]) / (double)(milestones[num6 + 1] - milestones[num6]);
				num5 = (double)((float)num + num3 * (float)num6) + (double)num3 * num7;
			}
			double num8 = (num2 > 0f) ? (num5 / (double)num2) : 0.0;
			return (float)((num8 < 0.0) ? 0.0 : ((num8 > 1.0) ? 1.0 : num8));
		}
		int num9 = milestones[0];
		if (num9 <= 0)
		{
			return 0f;
		}
		float num10 = (float)cur / (float)num9;
		if (num10 < 0f)
		{
			return 0f;
		}
		if (num10 <= 1f)
		{
			return num10;
		}
		return 1f;
	}

	// Token: 0x0600AF5B RID: 44891 RVA: 0x0033ABB4 File Offset: 0x00338DB4
	private void EnsurePointItems(GachaAccumulateData accumulateData)
	{
		UUIItem item = base.GetItem(7);
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(6);
		if (item == null || horizontalLayout == null)
		{
			return;
		}
		item.SetUIActive(false);
		int count = accumulateData.GroupData.RewardInfos.FindAll((GachaAccumulateRewardData reward) => !reward.GetIfCyclic()).Count;
		if (this.SpawnedPointItems.Count == count)
		{
			return;
		}
		foreach (UUIItem uuiitem in this.SpawnedPointItems)
		{
			AActor owner = uuiitem.GetOwner();
			if (owner != null)
			{
				owner.K2_DestroyActor();
			}
		}
		this.SpawnedPointItems.Clear();
		for (int i = 0; i < count; i++)
		{
			UUIItem uuiitem2 = LguiUtil.Instance.CopyItem(item, horizontalLayout.RootUIComp);
			uuiitem2.SetUIActive(true);
			this.SpawnedPointItems.Add(uuiitem2);
		}
	}

	// Token: 0x0600AF5C RID: 44892 RVA: 0x0033ACBC File Offset: 0x00338EBC
	private void OnLoopScrollLateUpdate(float deltaTime)
	{
		if (!this.NeedLateUpdate || this.LoopScroll == null)
		{
			return;
		}
		this.NeedLateUpdate = false;
		GachaAccumulateData accumulateData = GachaAccumulateModel.Instance.GetAccumulateData(this.CurrentAccumulateId);
		if (accumulateData == null)
		{
			return;
		}
		int gridIndex = this.FindHighestClaimedIndex(accumulateData);
		this.LoopScroll.ScrollToGridIndex(gridIndex, true);
	}

	// Token: 0x0600AF5D RID: 44893 RVA: 0x0033AD0C File Offset: 0x00338F0C
	private int FindHighestClaimedIndex(GachaAccumulateData accumulateData)
	{
		int num = -1;
		int num2 = 0;
		foreach (GachaAccumulateRewardData gachaAccumulateRewardData in accumulateData.GroupData.RewardInfos)
		{
			if (!gachaAccumulateRewardData.GetIfCyclic())
			{
				if (gachaAccumulateRewardData.Status == EGachaAccumulateRewardStatus.Claimed)
				{
					num = num2;
				}
				num2++;
			}
		}
		if (num >= 0)
		{
			return num;
		}
		return 0;
	}

	// Token: 0x0600AF5E RID: 44894 RVA: 0x0033AD80 File Offset: 0x00338F80
	private void OnLoopScrollValueChanged()
	{
		if (this.LoopScroll == null)
		{
			return;
		}
		int displayGridEndIndex = this.LoopScroll.GetDisplayGridEndIndex();
		if (displayGridEndIndex == this.LastSeenEndGridIndex)
		{
			return;
		}
		this.LastSeenEndGridIndex = displayGridEndIndex;
		if (displayGridEndIndex < 0)
		{
			return;
		}
		GachaAccumulateData accumulateData = GachaAccumulateModel.Instance.GetAccumulateData(this.CurrentAccumulateId);
		if (accumulateData == null)
		{
			return;
		}
		this.RefreshBigRewardByScroll(accumulateData);
	}

	// Token: 0x0600AF5F RID: 44895 RVA: 0x0033ADD4 File Offset: 0x00338FD4
	private void RefreshBigRewardByScroll(GachaAccumulateData accumulateData)
	{
		BigRewardSlot bigRewardSlot = this.PickBigRewardSlot(accumulateData);
		if (bigRewardSlot.Kind == EBigRewardSlotKind.Big)
		{
			GachaAccumulateStageBigRewardPanel bigRewardPanel = this.BigRewardPanel;
			if (bigRewardPanel != null)
			{
				bigRewardPanel.SetUiActive(true);
			}
			GachaAccumulateStageBigRewardPanel bigRewardPanel2 = this.BigRewardPanel;
			if (bigRewardPanel2 != null)
			{
				bigRewardPanel2.Refresh(this.CurrentAccumulateId, bigRewardSlot.Reward);
			}
			GachaAccumulateStageCyclicPanel cyclicPanel = this.CyclicPanel;
			if (cyclicPanel == null)
			{
				return;
			}
			cyclicPanel.SetUiActive(false);
			return;
		}
		else
		{
			GachaAccumulateStageBigRewardPanel bigRewardPanel3 = this.BigRewardPanel;
			if (bigRewardPanel3 != null)
			{
				bigRewardPanel3.SetUiActive(false);
			}
			if (bigRewardSlot.Kind == EBigRewardSlotKind.Cyclic)
			{
				GachaAccumulateRewardData reward2 = accumulateData.GroupData.RewardInfos.Find((GachaAccumulateRewardData reward) => reward.GetIfCyclic());
				GachaAccumulateStageCyclicPanel cyclicPanel2 = this.CyclicPanel;
				if (cyclicPanel2 != null)
				{
					cyclicPanel2.SetUiActive(true);
				}
				GachaAccumulateStageCyclicPanel cyclicPanel3 = this.CyclicPanel;
				if (cyclicPanel3 == null)
				{
					return;
				}
				cyclicPanel3.Refresh(this.CurrentAccumulateId, reward2, accumulateData);
				return;
			}
			else
			{
				GachaAccumulateStageCyclicPanel cyclicPanel4 = this.CyclicPanel;
				if (cyclicPanel4 == null)
				{
					return;
				}
				cyclicPanel4.SetUiActive(false);
				return;
			}
		}
	}

	// Token: 0x0600AF60 RID: 44896 RVA: 0x0033AEBC File Offset: 0x003390BC
	private BigRewardSlot PickBigRewardSlot(GachaAccumulateData accumulateData)
	{
		GachaAccumulateBonusViewContentStage.<>c__DisplayClass46_0 CS$<>8__locals1 = new GachaAccumulateBonusViewContentStage.<>c__DisplayClass46_0();
		List<GachaAccumulateRewardData> rewardInfos = accumulateData.GroupData.RewardInfos;
		List<GachaAccumulateRewardData> list = rewardInfos.FindAll((GachaAccumulateRewardData reward) => !reward.GetIfCyclic() && reward.IsBigReward);
		GachaAccumulateRewardData gachaAccumulateRewardData = rewardInfos.Find((GachaAccumulateRewardData reward) => reward.GetIfCyclic());
		bool flag = accumulateData.CurGachaNum >= accumulateData.GetCyclicBaseGachaNum();
		bool flag2 = gachaAccumulateRewardData != null && (gachaAccumulateRewardData.IsPreView || flag);
		LoopScrollView<GachaAccumulateRewardItemStage, GachaAccumulateRewardItemStageData> loopScroll = this.LoopScroll;
		int num = (loopScroll != null) ? loopScroll.GetDisplayGridEndIndex() : -1;
		GachaAccumulateBonusViewContentStage.<>c__DisplayClass46_0 CS$<>8__locals2 = CS$<>8__locals1;
		GachaAccumulateRewardItemStageData endData;
		if (num < 0)
		{
			endData = null;
		}
		else
		{
			LoopScrollView<GachaAccumulateRewardItemStage, GachaAccumulateRewardItemStageData> loopScroll2 = this.LoopScroll;
			endData = ((loopScroll2 != null) ? loopScroll2.TryGetCachedData(num) : null);
		}
		CS$<>8__locals2.endData = endData;
		GachaAccumulateRewardItemStageData endData2 = CS$<>8__locals1.endData;
		if (((endData2 != null) ? endData2.Data : null) == null)
		{
			return this.PickInitialSlot(list, flag2);
		}
		GachaAccumulateRewardData gachaAccumulateRewardData2 = list.Find((GachaAccumulateRewardData reward) => reward.GachaNum > CS$<>8__locals1.endData.Data.GachaNum);
		if (gachaAccumulateRewardData2 != null)
		{
			return BigRewardSlot.MakeBig(gachaAccumulateRewardData2);
		}
		if (flag2)
		{
			return BigRewardSlot.MakeCyclic();
		}
		return BigRewardSlot.MakeNone();
	}

	// Token: 0x0600AF61 RID: 44897 RVA: 0x0033AFCC File Offset: 0x003391CC
	private BigRewardSlot PickInitialSlot(List<GachaAccumulateRewardData> nonCyclicBigList, bool cyclicAllowed)
	{
		if (nonCyclicBigList.Count > 0)
		{
			return BigRewardSlot.MakeBig(nonCyclicBigList.Find((GachaAccumulateRewardData reward) => reward.Status == EGachaAccumulateRewardStatus.NotReached) ?? nonCyclicBigList[0]);
		}
		if (!cyclicAllowed)
		{
			return BigRewardSlot.MakeNone();
		}
		return BigRewardSlot.MakeCyclic();
	}

	// Token: 0x04006538 RID: 25912
	private const int FirstRewardPixelOffset = 90;

	// Token: 0x04006539 RID: 25913
	private const int BetweenRewardPixelOffset = 180;

	// Token: 0x0400653A RID: 25914
	private const int UnobservedEndGridIndex = -2;

	// Token: 0x0400653B RID: 25915
	private const int FixedLayoutMaxCount = 9;

	// Token: 0x0400653C RID: 25916
	[Nullable(2)]
	private UiSequencePlayer UiSequencePlayer;

	// Token: 0x0400653D RID: 25917
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<GachaAccumulateRewardItemStage, GachaAccumulateRewardItemStageData> LoopScroll;

	// Token: 0x0400653E RID: 25918
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400653F RID: 25919
	[Nullable(2)]
	private GachaAccumulateStageBigRewardPanel BigRewardPanel;

	// Token: 0x04006540 RID: 25920
	[Nullable(2)]
	private GachaAccumulateStageCyclicPanel CyclicPanel;

	// Token: 0x04006541 RID: 25921
	private Action OnClickBackButtonCallBack = delegate()
	{
	};

	// Token: 0x04006542 RID: 25922
	private int CurrentAccumulateId;

	// Token: 0x04006543 RID: 25923
	private int LastSeenEndGridIndex = -2;

	// Token: 0x04006544 RID: 25924
	private int LastAutoScrollAccumulateId;

	// Token: 0x04006545 RID: 25925
	private bool NeedLateUpdate;

	// Token: 0x04006546 RID: 25926
	private readonly List<UUIItem> SpawnedPointItems = new List<UUIItem>();

	// Token: 0x04006547 RID: 25927
	private readonly List<GachaAccumulateRewardItemStage> SpawnedFixedRewardItems = new List<GachaAccumulateRewardItemStage>();

	// Token: 0x04006548 RID: 25928
	private readonly List<UUIItem> SpawnedFixedPointItems = new List<UUIItem>();

	// Token: 0x04006549 RID: 25929
	private bool FixedSpawnStarted;

	// Token: 0x0400654A RID: 25930
	private bool FixedReady;
}
