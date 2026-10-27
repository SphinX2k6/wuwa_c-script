using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001222 RID: 4642
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewDangoMonopoly : ActivitySubViewBase
{
	// Token: 0x17000A96 RID: 2710
	// (get) Token: 0x06007D73 RID: 32115 RVA: 0x001A96F7 File Offset: 0x001A78F7
	protected new ActivityDangoMonopolyData ActivityBaseData
	{
		get
		{
			return (ActivityDangoMonopolyData)this.ActivityBaseData;
		}
	}

	// Token: 0x06007D74 RID: 32116 RVA: 0x001A9704 File Offset: 0x001A7904
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnBtnDice))
		};
	}

	// Token: 0x06007D75 RID: 32117 RVA: 0x001A97EF File Offset: 0x001A79EF
	private void OnBtnDice()
	{
		this.ActivityBaseData.OpenViewDiceTask();
	}

	// Token: 0x06007D76 RID: 32118 RVA: 0x001A97FC File Offset: 0x001A79FC
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewDangoMonopoly.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewDangoMonopoly.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007D77 RID: 32119 RVA: 0x001A983F File Offset: 0x001A7A3F
	protected override void OnStart()
	{
	}

	// Token: 0x06007D78 RID: 32120 RVA: 0x001A9841 File Offset: 0x001A7A41
	protected override void OnAddEventListener()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.DangoMonopolyTask, base.GetItem(2), new Action<bool, int>(this.UpdateRedDotActivity), 0);
	}

	// Token: 0x06007D79 RID: 32121 RVA: 0x001A9866 File Offset: 0x001A7A66
	protected override void OnRemoveEventListener()
	{
		RedDotController.Instance.UnBindRedDot(ERedDotName.DangoMonopolyTask);
	}

	// Token: 0x06007D7A RID: 32122 RVA: 0x001A9878 File Offset: 0x001A7A78
	protected override void OnRefreshView()
	{
		bool flag = this.ActivityBaseData.IsUnLock();
		bool diceShowState = this.GetDiceShowState();
		int[] array;
		if (!diceShowState)
		{
			array = new int[0];
		}
		else
		{
			(array = new int[1])[0] = this.ActivityBaseData.DiceItemId;
		}
		int[] p = array;
		base.GetItem(5).SetUIActive(flag);
		base.GetItem(6).SetUIActive(diceShowState);
		EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.SetActivityViewCurrency, p);
		if (flag)
		{
			int currentBoardPosition = this.ActivityBaseData.GetCurrentBoardPosition();
			int totalRoundNum = this.ActivityBaseData.GetTotalRoundNum();
			base.GetText(3).SetText(currentBoardPosition.ToString(), true);
			UUIText text = base.GetText(4);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(totalRoundNum);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		this.UpdateRedDotActivity(false, 0);
		this.UpdateRoundRewardInfo();
		this.UpdateBoardLockRemainTime();
	}

	// Token: 0x06007D7B RID: 32123 RVA: 0x001A9959 File Offset: 0x001A7B59
	private void ClickCommonInfo(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			this.ActivityBaseData.RequestEnterDangoMonopoly();
		});
	}

	// Token: 0x06007D7C RID: 32124 RVA: 0x001A9978 File Offset: 0x001A7B78
	private void UpdateRedDotActivity(bool _1, int _2)
	{
		bool exDataRedPointShowState = this.ActivityBaseData.GetExDataRedPointShowState();
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel == null)
		{
			return;
		}
		commonInfoPanel.SetFunctionRedDotVisible(exDataRedPointShowState);
	}

	// Token: 0x06007D7D RID: 32125 RVA: 0x001A99A2 File Offset: 0x001A7BA2
	public bool GetDiceShowState()
	{
		return this.ActivityBaseData.IsUnLock() && !this.ActivityBaseData.IsFinishAllRound();
	}

	// Token: 0x06007D7E RID: 32126 RVA: 0x001A99C4 File Offset: 0x001A7BC4
	public void UpdateRoundRewardInfo()
	{
		if (!this.ActivityBaseData.IsAllGetRoundReward())
		{
			return;
		}
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		ActivityFunctionalTypeA activityFunctionalTypeA = (commonInfoPanel != null) ? commonInfoPanel.GetFunctional() : null;
		if (activityFunctionalTypeA != null)
		{
			activityFunctionalTypeA.SetActivatePanelConditionVisible(true);
		}
		if (activityFunctionalTypeA == null)
		{
			return;
		}
		activityFunctionalTypeA.SetActivateTextByTextId("DangoMonopoly_title_21", Array.Empty<string>());
	}

	// Token: 0x06007D7F RID: 32127 RVA: 0x001A9A14 File Offset: 0x001A7C14
	public void UpdateBoardLockRemainTime()
	{
		if (!this.ActivityBaseData.IsRunningBoardLock())
		{
			return;
		}
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		ActivityFunctionalTypeA activityFunctionalTypeA = (commonInfoPanel != null) ? commonInfoPanel.GetFunctional() : null;
		if (activityFunctionalTypeA != null)
		{
			activityFunctionalTypeA.SetPanelConditionVisible(true);
		}
		if (activityFunctionalTypeA == null)
		{
			return;
		}
		activityFunctionalTypeA.SetLockTextByText(this.ActivityBaseData.GetBoardRemainTimeStr());
	}

	// Token: 0x06007D80 RID: 32128 RVA: 0x001A9A63 File Offset: 0x001A7C63
	protected override void OnTimer(float _)
	{
		this.UpdateBoardLockRemainTime();
	}

	// Token: 0x04003917 RID: 14615
	[Nullable(2)]
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x02007813 RID: 30739
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402792A RID: 162090
		ItemCommonPanel,
		// Token: 0x0402792B RID: 162091
		BtnDice,
		// Token: 0x0402792C RID: 162092
		ItemDiceRedDot,
		// Token: 0x0402792D RID: 162093
		TxtCurrentRound,
		// Token: 0x0402792E RID: 162094
		TxtTotalRound,
		// Token: 0x0402792F RID: 162095
		ItemRoundRoot,
		// Token: 0x04027930 RID: 162096
		ItemDiceRoot,
		// Token: 0x04027931 RID: 162097
		TxtDiceBtnTitle
	}
}
