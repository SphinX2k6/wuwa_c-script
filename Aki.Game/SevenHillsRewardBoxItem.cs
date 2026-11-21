using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000760 RID: 1888
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SevenHillsRewardBoxItem : GridProxyAbstract<LongShanScoreRewardData>
{
	// Token: 0x060056CA RID: 22218 RVA: 0x001C7850 File Offset: 0x001C5A50
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

	// Token: 0x060056CB RID: 22219 RVA: 0x001C79DE File Offset: 0x001C5BDE
	protected override void OnStart()
	{
		base.GetUiNiagara(7).SetAlpha(0f);
		base.GetUiNiagara(7).SetUIActive(true);
		base.GetUiNiagara(8).SetUIActive(false);
	}

	// Token: 0x060056CC RID: 22220 RVA: 0x001C7A0C File Offset: 0x001C5C0C
	[NullableContext(1)]
	public override void Refresh(LongShanScoreRewardData rewardData, bool isSelected, int gridIndex)
	{
		this.Data = rewardData;
		EActivityTaskState state = rewardData.GetState();
		base.GetText(6).SetText(rewardData.Goal.ToString(), true);
		this.RefreshRewardState(state);
	}

	// Token: 0x060056CD RID: 22221 RVA: 0x001C7A48 File Offset: 0x001C5C48
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

	// Token: 0x060056CE RID: 22222 RVA: 0x001C7B1C File Offset: 0x001C5D1C
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

	// Token: 0x060056CF RID: 22223 RVA: 0x001C7B6C File Offset: 0x001C5D6C
	private void RequestGetAllAvailableReward()
	{
		List<int> list = new List<int>(this.ActivityData.GetAllAvailableScoreRewardIds());
		if (list.Count > 0)
		{
			ActivityLongShanController.Instance.RequestScoreReward(this.ActivityData.Id, list);
		}
	}

	// Token: 0x060056D0 RID: 22224 RVA: 0x001C7BAC File Offset: 0x001C5DAC
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

	// Token: 0x04003BB7 RID: 15287
	private float Y_BIAS = 30f;

	// Token: 0x04003BB8 RID: 15288
	private LongShanScoreRewardData Data;

	// Token: 0x04003BB9 RID: 15289
	private EActivityTaskState? RewardState;

	// Token: 0x04003BBA RID: 15290
	public ActivityLongShanData ActivityData;

	// Token: 0x02006A56 RID: 27222
	[NullableContext(0)]
	private class ERewardItemNode
	{
		// Token: 0x04022FE7 RID: 143335
		public const int SpriteProgressBar = 0;

		// Token: 0x04022FE8 RID: 143336
		public const int BtnReward = 1;

		// Token: 0x04022FE9 RID: 143337
		public const int SpriteUnfinished = 2;

		// Token: 0x04022FEA RID: 143338
		public const int SpriteClaimed = 3;

		// Token: 0x04022FEB RID: 143339
		public const int SpriteReceived = 4;

		// Token: 0x04022FEC RID: 143340
		public const int ItemRedDot = 5;

		// Token: 0x04022FED RID: 143341
		public const int TextGoal = 6;

		// Token: 0x04022FEE RID: 143342
		public const int NiagaraClaimed = 7;

		// Token: 0x04022FEF RID: 143343
		public const int NiagaraReceived = 8;
	}
}
