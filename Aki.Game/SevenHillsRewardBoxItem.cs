using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020012AC RID: 4780
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SevenHillsRewardBoxItem : GridProxyAbstract<LongShanScoreRewardData>
{
	// Token: 0x06008333 RID: 33587 RVA: 0x001BEAC0 File Offset: 0x001BCCC0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUINiagara));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickRewardButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008334 RID: 33588 RVA: 0x001BEC4E File Offset: 0x001BCE4E
	protected override void OnStart()
	{
		base.GetUiNiagara(7).SetAlpha(0f);
		base.GetUiNiagara(7).SetUIActive(true);
		base.GetUiNiagara(8).SetUIActive(false);
	}

	// Token: 0x06008335 RID: 33589 RVA: 0x001BEC7C File Offset: 0x001BCE7C
	[NullableContext(1)]
	public override void Refresh(LongShanScoreRewardData rewardData, bool isSelected, int gridIndex)
	{
		this.Data = rewardData;
		EActivityTaskState state = rewardData.GetState();
		base.GetText(6).SetText(rewardData.Goal.ToString(), true);
		this.RefreshRewardState(state);
	}

	// Token: 0x06008336 RID: 33590 RVA: 0x001BECB8 File Offset: 0x001BCEB8
	public void RefreshRewardState(EActivityTaskState state)
	{
		UUINiagara uiNiagara = base.GetUiNiagara(8);
		uiNiagara.SetUIActive(false);
		uiNiagara.Deactivate();
		base.GetSprite(2).SetUIActive(state == EActivityTaskState.Active);
		base.GetSprite(3).SetUIActive(state == EActivityTaskState.FinishedAndUnclaimed);
		base.GetSprite(4).SetUIActive(state == EActivityTaskState.FinishedAndClaimed);
		base.GetItem(5).SetUIActive(state == EActivityTaskState.FinishedAndUnclaimed);
		float scoreRewardRelativeProgress = this.ActivityData.GetScoreRewardRelativeProgress(this.Data.Id);
		base.GetSprite(0).SetFillAmount(scoreRewardRelativeProgress);
		base.GetUiNiagara(7).SetAlpha(state == EActivityTaskState.FinishedAndUnclaimed);
		EActivityTaskState? rewardState = this.RewardState;
		EActivityTaskState eactivityTaskState = EActivityTaskState.FinishedAndUnclaimed;
		if ((rewardState.GetValueOrDefault() == eactivityTaskState & rewardState != null) && state == EActivityTaskState.FinishedAndClaimed)
		{
			uiNiagara.SetUIActive(true);
			uiNiagara.ActivateSystem(true);
		}
		this.RewardState = new EActivityTaskState?(state);
	}

	// Token: 0x06008337 RID: 33591 RVA: 0x001BED8C File Offset: 0x001BCF8C
	private void OnClickRewardButton()
	{
		EActivityTaskState? rewardState = this.RewardState;
		if (rewardState != null)
		{
			switch (rewardState.GetValueOrDefault())
			{
			case EActivityTaskState.FinishedAndUnclaimed:
				this.RequestGetAllAvailableReward();
				return;
			case EActivityTaskState.Active:
				this.RefreshRewardPopup(false);
				return;
			case EActivityTaskState.FinishedAndClaimed:
				this.RefreshRewardPopup(true);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x06008338 RID: 33592 RVA: 0x001BEDDC File Offset: 0x001BCFDC
	private void RequestGetAllAvailableReward()
	{
		List<int> list = this.ActivityData.GetAllAvailableScoreRewardIds().ToList<int>();
		if (list.Count > 0)
		{
			ActivityLongShanController.Instance.RequestScoreReward(this.ActivityData.Id, list);
		}
	}

	// Token: 0x06008339 RID: 33593 RVA: 0x001BEE1C File Offset: 0x001BD01C
	private void RefreshRewardPopup(bool isClaimed)
	{
		List<DailyActivityDefine.RewardTuple> list = new List<DailyActivityDefine.RewardTuple>();
		foreach (TItem titem in this.Data.GetPreviewReward())
		{
			DailyActivityDefine.RewardTuple item = new DailyActivityDefine.RewardTuple
			{
				Id = titem.ItemData.ItemId,
				Num = titem.Count,
				Received = isClaimed
			};
			list.Add(item);
		}
		RewardPopupData p = new RewardPopupData
		{
			RewardLists = list,
			MountItem = base.GetButton(1).RootUIComp,
			PosBias = new FVector?(new FVector(0f, this.Y_BIAS, 0f))
		};
		EventSystem.Instance.Emit<RewardPopupData>(EEventName.RefreshRewardPopUp, p);
	}

	// Token: 0x04003B1F RID: 15135
	private float Y_BIAS = 30f;

	// Token: 0x04003B20 RID: 15136
	private LongShanScoreRewardData Data;

	// Token: 0x04003B21 RID: 15137
	private EActivityTaskState? RewardState;

	// Token: 0x04003B22 RID: 15138
	public ActivityLongShanData ActivityData;

	// Token: 0x020078CC RID: 30924
	[NullableContext(0)]
	private class ERewardItemNode
	{
		// Token: 0x04027CB9 RID: 163001
		public const int SpriteProgressBar = 0;

		// Token: 0x04027CBA RID: 163002
		public const int BtnReward = 1;

		// Token: 0x04027CBB RID: 163003
		public const int SpriteUnfinished = 2;

		// Token: 0x04027CBC RID: 163004
		public const int SpriteClaimed = 3;

		// Token: 0x04027CBD RID: 163005
		public const int SpriteReceived = 4;

		// Token: 0x04027CBE RID: 163006
		public const int ItemRedDot = 5;

		// Token: 0x04027CBF RID: 163007
		public const int TextGoal = 6;

		// Token: 0x04027CC0 RID: 163008
		public const int NiagaraClaimed = 7;

		// Token: 0x04027CC1 RID: 163009
		public const int NiagaraReceived = 8;
	}
}
