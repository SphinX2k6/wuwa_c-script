using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006D6 RID: 1750
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewDangoMonopoly : ActivitySubViewBase
{
	// Token: 0x17000AB6 RID: 2742
	// (get) Token: 0x0600510A RID: 20746 RVA: 0x001B23B7 File Offset: 0x001B05B7
	protected new ActivityDangoMonopolyData ActivityBaseData
	{
		get
		{
			return (ActivityDangoMonopolyData)this.ActivityBaseData;
		}
	}

	// Token: 0x0600510B RID: 20747 RVA: 0x001B23C4 File Offset: 0x001B05C4
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

	// Token: 0x0600510C RID: 20748 RVA: 0x001B24AF File Offset: 0x001B06AF
	private void OnBtnDice()
	{
		this.ActivityBaseData.OpenViewDiceTask();
	}

	// Token: 0x0600510D RID: 20749 RVA: 0x001B24BC File Offset: 0x001B06BC
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewDangoMonopoly.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewDangoMonopoly.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600510E RID: 20750 RVA: 0x001B24FF File Offset: 0x001B06FF
	protected override void OnStart()
	{
	}

	// Token: 0x0600510F RID: 20751 RVA: 0x001B2501 File Offset: 0x001B0701
	protected override void OnAddEventListener()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.DangoMonopolyTask, base.GetItem(2), new Action<bool, int>(this.UpdateRedDotActivity), 0);
	}

	// Token: 0x06005110 RID: 20752 RVA: 0x001B2526 File Offset: 0x001B0726
	protected override void OnRemoveEventListener()
	{
		RedDotController.Instance.UnBindRedDot(ERedDotName.DangoMonopolyTask);
	}

	// Token: 0x06005111 RID: 20753 RVA: 0x001B2538 File Offset: 0x001B0738
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

	// Token: 0x06005112 RID: 20754 RVA: 0x001B2619 File Offset: 0x001B0819
	private void ClickCommonInfo(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			this.ActivityBaseData.RequestEnterDangoMonopoly();
		});
	}

	// Token: 0x06005113 RID: 20755 RVA: 0x001B2638 File Offset: 0x001B0838
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

	// Token: 0x06005114 RID: 20756 RVA: 0x001B2662 File Offset: 0x001B0862
	public bool GetDiceShowState()
	{
		return this.ActivityBaseData.IsUnLock() && !this.ActivityBaseData.IsFinishAllRound();
	}

	// Token: 0x06005115 RID: 20757 RVA: 0x001B2684 File Offset: 0x001B0884
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

	// Token: 0x06005116 RID: 20758 RVA: 0x001B26D4 File Offset: 0x001B08D4
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

	// Token: 0x06005117 RID: 20759 RVA: 0x001B2723 File Offset: 0x001B0923
	protected override void OnTimer(float _)
	{
		this.UpdateBoardLockRemainTime();
	}

	// Token: 0x040039AF RID: 14767
	[Nullable(2)]
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x0200699E RID: 27038
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022C5B RID: 142427
		ItemCommonPanel,
		// Token: 0x04022C5C RID: 142428
		BtnDice,
		// Token: 0x04022C5D RID: 142429
		ItemDiceRedDot,
		// Token: 0x04022C5E RID: 142430
		TxtCurrentRound,
		// Token: 0x04022C5F RID: 142431
		TxtTotalRound,
		// Token: 0x04022C60 RID: 142432
		ItemRoundRoot,
		// Token: 0x04022C61 RID: 142433
		ItemDiceRoot,
		// Token: 0x04022C62 RID: 142434
		TxtDiceBtnTitle
	}
}
