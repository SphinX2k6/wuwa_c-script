using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020007EC RID: 2028
[NullableContext(1)]
[Nullable(0)]
public class HandbookRewardItem : GridProxyAbstract<int>
{
	// Token: 0x06005C95 RID: 23701 RVA: 0x001DD3E4 File Offset: 0x001DB5E4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUINiagara)),
			new ValueTuple<int, Type>(7, typeof(UUINiagara)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.ClickRewardButton))
		};
	}

	// Token: 0x06005C96 RID: 23702 RVA: 0x001DD513 File Offset: 0x001DB713
	protected override void OnStart()
	{
		base.GetUiNiagara(6).SetAlpha(0f);
		base.GetUiNiagara(6).SetUIActive(true);
		base.GetUiNiagara(7).SetUIActive(false);
	}

	// Token: 0x06005C97 RID: 23703 RVA: 0x001DD540 File Offset: 0x001DB740
	public override void Refresh(int rewardId, bool isSelected, int gridIndex)
	{
		HandbookRewardData handbookRewardDataById = MoonChasingModel.Instance.GetHandbookRewardDataById(rewardId);
		if (handbookRewardDataById == null)
		{
			return;
		}
		this.Data = handbookRewardDataById;
		int handbookUnlockCount = MoonChasingModel.Instance.GetHandbookUnlockCount();
		EHandbookRewardState state = handbookRewardDataById.GetState(handbookUnlockCount);
		this.SetRewardGoalValue(state, handbookRewardDataById.Goal);
		this.RefreshRewardState(state, this.RewardState == null);
	}

	// Token: 0x06005C98 RID: 23704 RVA: 0x001DD59C File Offset: 0x001DB79C
	public void SetRewardGoalValue(EHandbookRewardState state, int value)
	{
		UUIText[] array = new UUIText[]
		{
			base.GetText(0),
			base.GetText(10),
			base.GetText(9)
		};
		for (int i = 0; i < array.Length; i++)
		{
			bool flag = i == (int)state;
			array[i].SetUIActive(flag);
			if (flag)
			{
				array[i].SetText(value.ToString(), true);
			}
		}
	}

	// Token: 0x06005C99 RID: 23705 RVA: 0x001DD600 File Offset: 0x001DB800
	public void RefreshRewardState(EHandbookRewardState state, bool isInit)
	{
		UUINiagara uiNiagara = base.GetUiNiagara(7);
		uiNiagara.SetUIActive(false);
		uiNiagara.Deactivate();
		if (!isInit)
		{
			EHandbookRewardState? rewardState = this.RewardState;
			if (rewardState.GetValueOrDefault() == state & rewardState != null)
			{
				return;
			}
		}
		UUISprite[] array = new UUISprite[]
		{
			base.GetSprite(2),
			base.GetSprite(4),
			base.GetSprite(3)
		};
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetUIActive(i == (int)state);
		}
		base.GetItem(8).SetUIActive(state == EHandbookRewardState.FinishedAndUnclaimed);
		FColor color = FColor.FromHex((state == EHandbookRewardState.Active) ? "00000033" : "F3EAAB1E");
		base.GetSprite(5).SetColor(color);
		base.GetUiNiagara(6).SetAlpha(state == EHandbookRewardState.FinishedAndUnclaimed);
		if (state == EHandbookRewardState.FinishedAndClaimed && !isInit)
		{
			uiNiagara.SetUIActive(true);
			uiNiagara.ActivateSystem(true);
		}
		this.RewardState = new EHandbookRewardState?(state);
	}

	// Token: 0x06005C9A RID: 23706 RVA: 0x001DD6F0 File Offset: 0x001DB8F0
	private void ClickRewardButton()
	{
		EHandbookRewardState? rewardState = this.RewardState;
		if (rewardState != null)
		{
			switch (rewardState.GetValueOrDefault())
			{
			case EHandbookRewardState.Active:
				this.RefreshRewardPopup(false);
				return;
			case EHandbookRewardState.FinishedAndUnclaimed:
				this.RequestGetAllAvailableReward();
				return;
			case EHandbookRewardState.FinishedAndClaimed:
				this.RefreshRewardPopup(true);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x06005C9B RID: 23707 RVA: 0x001DD73E File Offset: 0x001DB93E
	private void RequestGetAllAvailableReward()
	{
		MoonChasingController.Instance.RequestAllAvailableHandbookReward();
	}

	// Token: 0x06005C9C RID: 23708 RVA: 0x001DD74C File Offset: 0x001DB94C
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
			PosBias = new FVector?(new FVector(0f, 30f, 0f))
		};
		EventSystem.Instance.Emit<RewardPopupData>(EEventName.RefreshRewardPopUp, p);
	}

	// Token: 0x04003DA6 RID: 15782
	private EHandbookRewardState? RewardState;

	// Token: 0x04003DA7 RID: 15783
	private HandbookRewardData Data;

	// Token: 0x04003DA8 RID: 15784
	private const int Y_BIAS = 30;

	// Token: 0x04003DA9 RID: 15785
	private const string REWARD_BACKGROUND_COLOR_UNFINISHED = "00000033";

	// Token: 0x04003DAA RID: 15786
	private const string REWARD_BACKGROUND_COLOR_FINISHED = "F3EAAB1E";

	// Token: 0x02006B2D RID: 27437
	[NullableContext(0)]
	private class ERewardItemNode
	{
		// Token: 0x04023401 RID: 144385
		public const int TxtValueUnFinished = 0;

		// Token: 0x04023402 RID: 144386
		public const int BtnReward = 1;

		// Token: 0x04023403 RID: 144387
		public const int SpriteUnfinished = 2;

		// Token: 0x04023404 RID: 144388
		public const int SpriteClaimed = 3;

		// Token: 0x04023405 RID: 144389
		public const int SpriteFinished = 4;

		// Token: 0x04023406 RID: 144390
		public const int SpriteBackground = 5;

		// Token: 0x04023407 RID: 144391
		public const int NiagaraWait = 6;

		// Token: 0x04023408 RID: 144392
		public const int NiagaraGet = 7;

		// Token: 0x04023409 RID: 144393
		public const int RedDot = 8;

		// Token: 0x0402340A RID: 144394
		public const int TxtValueFinished = 9;

		// Token: 0x0402340B RID: 144395
		public const int TxtValueReceivable = 10;
	}
}
