using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Morale;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200136E RID: 4974
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewMorale : ActivitySubViewBase
{
	// Token: 0x17000BC3 RID: 3011
	// (get) Token: 0x06008AB8 RID: 35512 RVA: 0x001DA221 File Offset: 0x001D8421
	protected new ActivityMoraleData ActivityBaseData
	{
		get
		{
			return (ActivityMoraleData)this.ActivityBaseData;
		}
	}

	// Token: 0x06008ABA RID: 35514 RVA: 0x001DA238 File Offset: 0x001D8438
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x06008ABB RID: 35515 RVA: 0x001DA2D4 File Offset: 0x001D84D4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewMorale.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewMorale.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008ABC RID: 35516 RVA: 0x001DA317 File Offset: 0x001D8517
	protected override void OnStart()
	{
	}

	// Token: 0x06008ABD RID: 35517 RVA: 0x001DA31C File Offset: 0x001D851C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.EventCloseView));
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel == null)
		{
			return;
		}
		ActivityFunctionalTypeA functional = commonInfoPanel.GetFunctional();
		if (functional == null)
		{
			return;
		}
		ActivityButtonItem functionButton = functional.FunctionButton;
		if (functionButton == null)
		{
			return;
		}
		functionButton.BindRedDot(ERedDotName.Morale, 0);
	}

	// Token: 0x06008ABE RID: 35518 RVA: 0x001DA36C File Offset: 0x001D856C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.EventCloseView));
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel == null)
		{
			return;
		}
		ActivityFunctionalTypeA functional = commonInfoPanel.GetFunctional();
		if (functional == null)
		{
			return;
		}
		ActivityButtonItem functionButton = functional.FunctionButton;
		if (functionButton == null)
		{
			return;
		}
		functionButton.UnBindGivenUid(0);
	}

	// Token: 0x06008ABF RID: 35519 RVA: 0x001DA3AC File Offset: 0x001D85AC
	protected override void OnRefreshView()
	{
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew("Morale_title_20");
		}
		this.ScoreProgressPanel.UpdateData();
		this.UpdateTipsFinishNeedGetReward();
		this.UpdateGuideQuestState();
	}

	// Token: 0x06008AC0 RID: 35520 RVA: 0x001DA3DC File Offset: 0x001D85DC
	private void ClickCommonInfo(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			ActivityController.Instance.OpenActivityContentView(this.ActivityBaseData);
		});
	}

	// Token: 0x06008AC1 RID: 35521 RVA: 0x001DA3FC File Offset: 0x001D85FC
	public void UpdateTipsFinishNeedGetReward()
	{
		bool uiActive = this.IsShowFinishTips();
		this.FinishTipsSubPanel.SetUiActive(uiActive);
	}

	// Token: 0x06008AC2 RID: 35522 RVA: 0x001DA41C File Offset: 0x001D861C
	private bool IsShowFinishTips()
	{
		return this.ActivityBaseData != null && this.ActivityBaseData.IsUnLock() && this.ActivityBaseData.GetPreGuideQuestFinishState() && MoraleModel.Instance.IsProgressScoreReachTarget();
	}

	// Token: 0x06008AC3 RID: 35523 RVA: 0x001DA44E File Offset: 0x001D864E
	private void OnTipsFinishNeedGetRewardHelpCallback()
	{
		HelpController.Instance.OpenHelpById(322);
	}

	// Token: 0x06008AC4 RID: 35524 RVA: 0x001DA45F File Offset: 0x001D865F
	private void EventCloseView(EUiViewName viewName, int _)
	{
		if (viewName == EUiViewName.MoraleAreaSumView)
		{
			this.UpdateTipsFinishNeedGetReward();
		}
	}

	// Token: 0x06008AC5 RID: 35525 RVA: 0x001DA474 File Offset: 0x001D8674
	public void UpdateGuideQuestState()
	{
		if (this.ActivityBaseData == null || !this.ActivityBaseData.IsUnLock())
		{
			return;
		}
		bool preGuideQuestFinishState = this.ActivityBaseData.GetPreGuideQuestFinishState();
		base.GetItem(3).SetUIActive(preGuideQuestFinishState);
		if (preGuideQuestFinishState)
		{
			return;
		}
		this.CommonInfoPanel.SetBtnText("Morale_title_36", Array.Empty<object>());
		string preShowGuideQuestName = this.ActivityBaseData.GetPreShowGuideQuestName();
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		ActivityFunctionalTypeA activityFunctionalTypeA = (commonInfoPanel != null) ? commonInfoPanel.GetFunctional() : null;
		if (activityFunctionalTypeA != null)
		{
			ActivityButtonItem functionButton = activityFunctionalTypeA.FunctionButton;
			if (functionButton != null)
			{
				functionButton.SetUiActive(true);
			}
		}
		if (activityFunctionalTypeA != null)
		{
			activityFunctionalTypeA.SetPanelConditionVisible(true);
		}
		if (activityFunctionalTypeA != null)
		{
			activityFunctionalTypeA.SetLockSpriteVisible(false);
		}
		if (activityFunctionalTypeA != null)
		{
			activityFunctionalTypeA.SetLockConditionButtonVisible(false);
		}
		if (activityFunctionalTypeA == null)
		{
			return;
		}
		activityFunctionalTypeA.SetLockTextByTextId("Morale_title_35", new string[]
		{
			preShowGuideQuestName
		});
	}

	// Token: 0x04003DC1 RID: 15809
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04003DC2 RID: 15810
	[Nullable(1)]
	public MoraleScoreProgressActivityPanel ScoreProgressPanel;

	// Token: 0x04003DC3 RID: 15811
	[Nullable(1)]
	public RecommendQuestTipsSubPanel FinishTipsSubPanel;

	// Token: 0x020079E4 RID: 31204
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040281EB RID: 164331
		public const int ItemCommonPanel = 0;

		// Token: 0x040281EC RID: 164332
		public const int ItemTipsRoot = 1;

		// Token: 0x040281ED RID: 164333
		public const int TxtTips = 2;

		// Token: 0x040281EE RID: 164334
		public const int ItemProgressRoot = 3;

		// Token: 0x040281EF RID: 164335
		public const int ItemProgressPanel = 4;

		// Token: 0x040281F0 RID: 164336
		public const int ItemFinishTipsPanel = 5;
	}
}
