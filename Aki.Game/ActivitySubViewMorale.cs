using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Morale;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000822 RID: 2082
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewMorale : ActivitySubViewBase
{
	// Token: 0x17000BE3 RID: 3043
	// (get) Token: 0x06005E53 RID: 24147 RVA: 0x001E307D File Offset: 0x001E127D
	protected new ActivityMoraleData ActivityBaseData
	{
		get
		{
			return (ActivityMoraleData)this.ActivityBaseData;
		}
	}

	// Token: 0x06005E55 RID: 24149 RVA: 0x001E3094 File Offset: 0x001E1294
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

	// Token: 0x06005E56 RID: 24150 RVA: 0x001E3130 File Offset: 0x001E1330
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewMorale.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewMorale.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005E57 RID: 24151 RVA: 0x001E3173 File Offset: 0x001E1373
	protected override void OnStart()
	{
	}

	// Token: 0x06005E58 RID: 24152 RVA: 0x001E3178 File Offset: 0x001E1378
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

	// Token: 0x06005E59 RID: 24153 RVA: 0x001E31C8 File Offset: 0x001E13C8
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

	// Token: 0x06005E5A RID: 24154 RVA: 0x001E3208 File Offset: 0x001E1408
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

	// Token: 0x06005E5B RID: 24155 RVA: 0x001E3238 File Offset: 0x001E1438
	private void ClickCommonInfo(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			ActivityController.Instance.OpenActivityContentView(this.ActivityBaseData);
		});
	}

	// Token: 0x06005E5C RID: 24156 RVA: 0x001E3258 File Offset: 0x001E1458
	public void UpdateTipsFinishNeedGetReward()
	{
		bool uiActive = this.IsShowFinishTips();
		this.FinishTipsSubPanel.SetUiActive(uiActive);
	}

	// Token: 0x06005E5D RID: 24157 RVA: 0x001E3278 File Offset: 0x001E1478
	private bool IsShowFinishTips()
	{
		return this.ActivityBaseData != null && this.ActivityBaseData.IsUnLock() && this.ActivityBaseData.GetPreGuideQuestFinishState() && MoraleModel.Instance.IsProgressScoreReachTarget();
	}

	// Token: 0x06005E5E RID: 24158 RVA: 0x001E32AA File Offset: 0x001E14AA
	private void OnTipsFinishNeedGetRewardHelpCallback()
	{
		HelpController.Instance.OpenHelpById(322);
	}

	// Token: 0x06005E5F RID: 24159 RVA: 0x001E32BB File Offset: 0x001E14BB
	private void EventCloseView(EUiViewName viewName, int _)
	{
		if (viewName == EUiViewName.MoraleAreaSumView)
		{
			this.UpdateTipsFinishNeedGetReward();
		}
	}

	// Token: 0x06005E60 RID: 24160 RVA: 0x001E32D0 File Offset: 0x001E14D0
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

	// Token: 0x04003E59 RID: 15961
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04003E5A RID: 15962
	[Nullable(1)]
	public MoraleScoreProgressActivityPanel ScoreProgressPanel;

	// Token: 0x04003E5B RID: 15963
	[Nullable(1)]
	public RecommendQuestTipsSubPanel FinishTipsSubPanel;

	// Token: 0x02006B6E RID: 27502
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04023518 RID: 144664
		public const int ItemCommonPanel = 0;

		// Token: 0x04023519 RID: 144665
		public const int ItemTipsRoot = 1;

		// Token: 0x0402351A RID: 144666
		public const int TxtTips = 2;

		// Token: 0x0402351B RID: 144667
		public const int ItemProgressRoot = 3;

		// Token: 0x0402351C RID: 144668
		public const int ItemProgressPanel = 4;

		// Token: 0x0402351D RID: 144669
		public const int ItemFinishTipsPanel = 5;
	}
}
