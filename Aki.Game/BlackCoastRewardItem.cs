using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020011B1 RID: 4529
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BlackCoastRewardItem : GridProxyAbstract<BlackCoastProgressRewardData>
{
	// Token: 0x0600782F RID: 30767 RVA: 0x001928A4 File Offset: 0x00190AA4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.ClickRewardButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007830 RID: 30768 RVA: 0x00192A32 File Offset: 0x00190C32
	protected override void OnStart()
	{
		UUINiagara uiNiagara = base.GetUiNiagara(6);
		if (uiNiagara != null)
		{
			uiNiagara.SetAlpha(0f);
		}
		UUINiagara uiNiagara2 = base.GetUiNiagara(6);
		if (uiNiagara2 != null)
		{
			uiNiagara2.SetUIActive(true);
		}
		UUINiagara uiNiagara3 = base.GetUiNiagara(7);
		if (uiNiagara3 == null)
		{
			return;
		}
		uiNiagara3.SetUIActive(false);
	}

	// Token: 0x06007831 RID: 30769 RVA: 0x00192A70 File Offset: 0x00190C70
	public override void Refresh(BlackCoastProgressRewardData rewardData, bool isSelected, int gridIndex)
	{
		this.Data = rewardData;
		EActivityTaskState state = rewardData.GetState();
		this.SetRewardGoalValue(rewardData.Goal);
		this.RefreshRewardState(state, this.RewardState == null);
	}

	// Token: 0x06007832 RID: 30770 RVA: 0x00192AAC File Offset: 0x00190CAC
	public void SetRewardGoalValue(int value)
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetText(value.ToString(), true);
	}

	// Token: 0x06007833 RID: 30771 RVA: 0x00192AC8 File Offset: 0x00190CC8
	public void RefreshRewardState(EActivityTaskState state, bool isInit)
	{
		UUINiagara uiNiagara = base.GetUiNiagara(7);
		if (uiNiagara != null)
		{
			uiNiagara.SetUIActive(false);
		}
		if (uiNiagara != null)
		{
			uiNiagara.Deactivate();
		}
		if (!isInit)
		{
			EActivityTaskState? rewardState = this.RewardState;
			if (rewardState.GetValueOrDefault() == state & rewardState != null)
			{
				return;
			}
		}
		UUISprite[] array = new UUISprite[]
		{
			base.GetSprite(4),
			base.GetSprite(2),
			base.GetSprite(3)
		};
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetUIActive(i == (int)state);
		}
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(state == EActivityTaskState.FinishedAndUnclaimed);
		}
		UUINiagara uiNiagara2 = base.GetUiNiagara(6);
		if (uiNiagara2 != null)
		{
			uiNiagara2.SetAlpha(state == EActivityTaskState.FinishedAndUnclaimed);
		}
		if (state == EActivityTaskState.FinishedAndClaimed && !isInit)
		{
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(true);
			}
			if (uiNiagara != null)
			{
				uiNiagara.ActivateSystem(true);
			}
		}
		this.RewardState = new EActivityTaskState?(state);
	}

	// Token: 0x06007834 RID: 30772 RVA: 0x00192BAC File Offset: 0x00190DAC
	private void ClickRewardButton()
	{
		EActivityTaskState? rewardState = this.RewardState;
		if (rewardState != null)
		{
			switch (rewardState.GetValueOrDefault())
			{
			case EActivityTaskState.FinishedAndUnclaimed:
			{
				Action requestGetAllAvailableReward = this.RequestGetAllAvailableReward;
				if (requestGetAllAvailableReward == null)
				{
					return;
				}
				requestGetAllAvailableReward();
				return;
			}
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

	// Token: 0x06007835 RID: 30773 RVA: 0x00192C04 File Offset: 0x00190E04
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
			MountItem = base.GetButton(1).RootUIComp.Get(),
			PosBias = new FVector?(new FVector(0f, 30f, 0f))
		};
		EventSystem.Instance.Emit<RewardPopupData>(EEventName.RefreshRewardPopUp, p);
	}

	// Token: 0x0400374E RID: 14158
	private const int Y_BIAS = 30;

	// Token: 0x0400374F RID: 14159
	private EActivityTaskState? RewardState;

	// Token: 0x04003750 RID: 14160
	private BlackCoastProgressRewardData Data;

	// Token: 0x04003751 RID: 14161
	[Nullable(2)]
	public Action RequestGetAllAvailableReward;

	// Token: 0x02007798 RID: 30616
	[NullableContext(0)]
	private class ERewardItemNode
	{
		// Token: 0x040276F5 RID: 161525
		public const int TxtGoal = 0;

		// Token: 0x040276F6 RID: 161526
		public const int BtnReward = 1;

		// Token: 0x040276F7 RID: 161527
		public const int SpriteUnfinished = 2;

		// Token: 0x040276F8 RID: 161528
		public const int SpriteClaimed = 3;

		// Token: 0x040276F9 RID: 161529
		public const int SpriteFinished = 4;

		// Token: 0x040276FA RID: 161530
		public const int SpriteBackground = 5;

		// Token: 0x040276FB RID: 161531
		public const int NiagaraWait = 6;

		// Token: 0x040276FC RID: 161532
		public const int NiagaraGet = 7;

		// Token: 0x040276FD RID: 161533
		public const int RedDot = 8;
	}
}
