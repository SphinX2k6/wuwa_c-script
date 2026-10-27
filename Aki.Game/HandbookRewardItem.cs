using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001338 RID: 4920
[NullableContext(1)]
[Nullable(0)]
public class HandbookRewardItem : GridProxyAbstract<int>
{
	// Token: 0x060088FA RID: 35066 RVA: 0x001D4578 File Offset: 0x001D2778
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

	// Token: 0x060088FB RID: 35067 RVA: 0x001D46A7 File Offset: 0x001D28A7
	protected override void OnStart()
	{
		base.GetUiNiagara(6).SetAlpha(0f);
		base.GetUiNiagara(6).SetUIActive(true);
		base.GetUiNiagara(7).SetUIActive(false);
	}

	// Token: 0x060088FC RID: 35068 RVA: 0x001D46D4 File Offset: 0x001D28D4
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

	// Token: 0x060088FD RID: 35069 RVA: 0x001D4730 File Offset: 0x001D2930
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

	// Token: 0x060088FE RID: 35070 RVA: 0x001D4794 File Offset: 0x001D2994
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

	// Token: 0x060088FF RID: 35071 RVA: 0x001D4884 File Offset: 0x001D2A84
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

	// Token: 0x06008900 RID: 35072 RVA: 0x001D48D2 File Offset: 0x001D2AD2
	private void RequestGetAllAvailableReward()
	{
		MoonChasingController.Instance.RequestAllAvailableHandbookReward();
	}

	// Token: 0x06008901 RID: 35073 RVA: 0x001D48E0 File Offset: 0x001D2AE0
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

	// Token: 0x04003D0E RID: 15630
	private EHandbookRewardState? RewardState;

	// Token: 0x04003D0F RID: 15631
	private HandbookRewardData Data;

	// Token: 0x04003D10 RID: 15632
	private const int Y_BIAS = 30;

	// Token: 0x04003D11 RID: 15633
	private const string REWARD_BACKGROUND_COLOR_UNFINISHED = "00000033";

	// Token: 0x04003D12 RID: 15634
	private const string REWARD_BACKGROUND_COLOR_FINISHED = "F3EAAB1E";

	// Token: 0x020079A3 RID: 31139
	[NullableContext(0)]
	private class ERewardItemNode
	{
		// Token: 0x040280D4 RID: 164052
		public const int TxtValueUnFinished = 0;

		// Token: 0x040280D5 RID: 164053
		public const int BtnReward = 1;

		// Token: 0x040280D6 RID: 164054
		public const int SpriteUnfinished = 2;

		// Token: 0x040280D7 RID: 164055
		public const int SpriteClaimed = 3;

		// Token: 0x040280D8 RID: 164056
		public const int SpriteFinished = 4;

		// Token: 0x040280D9 RID: 164057
		public const int SpriteBackground = 5;

		// Token: 0x040280DA RID: 164058
		public const int NiagaraWait = 6;

		// Token: 0x040280DB RID: 164059
		public const int NiagaraGet = 7;

		// Token: 0x040280DC RID: 164060
		public const int RedDot = 8;

		// Token: 0x040280DD RID: 164061
		public const int TxtValueFinished = 9;

		// Token: 0x040280DE RID: 164062
		public const int TxtValueReceivable = 10;
	}
}
