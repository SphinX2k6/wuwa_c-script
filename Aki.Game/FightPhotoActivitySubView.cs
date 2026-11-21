using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200072C RID: 1836
public class FightPhotoActivitySubView : ActivitySubViewBase
{
	// Token: 0x0600548C RID: 21644 RVA: 0x001BDE00 File Offset: 0x001BC000
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnRewardBtnClick))
		};
	}

	// Token: 0x0600548D RID: 21645 RVA: 0x001BDEC0 File Offset: 0x001BC0C0
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoActivitySubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoActivitySubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600548E RID: 21646 RVA: 0x001BDF04 File Offset: 0x001BC104
	protected override void OnRefreshView()
	{
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.OnRefreshView();
		}
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText(((FightPhotoActivityData)this.ActivityBaseData).GetFinishedLevelNum().ToString(), true);
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetText("/" + ((FightPhotoActivityData)this.ActivityBaseData).GetTotalLevelNum().ToString(), true);
		}
		int finishedTaskNum = ((FightPhotoActivityData)this.ActivityBaseData).GetFinishedTaskNum();
		int totalTaskNum = ((FightPhotoActivityData)this.ActivityBaseData).GetTotalTaskNum();
		UUIText text3 = base.GetText(4);
		if (text3 != null)
		{
			text3.SetText(finishedTaskNum.ToString() + "/" + totalTaskNum.ToString(), true);
		}
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(((FightPhotoActivityData)this.ActivityBaseData).IsTaskHasRedDot());
		}
		ActivitySubViewGeneralInfo commonInfoPanel2 = this.CommonInfoPanel;
		if (commonInfoPanel2 == null)
		{
			return;
		}
		commonInfoPanel2.SetFunctionRedDotVisible(((FightPhotoActivityData)this.ActivityBaseData).IsLevelHasRedDot());
	}

	// Token: 0x0600548F RID: 21647 RVA: 0x001BE011 File Offset: 0x001BC211
	private void OnRewardBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.FightPhotoRewardView, this.ActivityBaseData, null);
	}

	// Token: 0x06005490 RID: 21648 RVA: 0x001BE029 File Offset: 0x001BC229
	[NullableContext(1)]
	private void OnConfirmBtnClick(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_600064_Text", Array.Empty<object>());
				return;
			}
			FightPhotoActivityData fightPhotoActivityData = (FightPhotoActivityData)this.ActivityBaseData;
			if (!fightPhotoActivityData.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = fightPhotoActivityData.GetUnFinishPreGuideQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.FightPhotoLoadingView, this.ActivityBaseData, null);
		});
	}

	// Token: 0x04003B15 RID: 15125
	[Nullable(1)]
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x02006A14 RID: 27156
	private class EComponents
	{
		// Token: 0x04022E94 RID: 142996
		public const int CommonActivityInfo = 0;

		// Token: 0x04022E95 RID: 142997
		public const int TextFinishedLevelNum = 1;

		// Token: 0x04022E96 RID: 142998
		public const int TextTotalLevelNum = 2;

		// Token: 0x04022E97 RID: 142999
		public const int BtnReward = 3;

		// Token: 0x04022E98 RID: 143000
		public const int TextRewardProgress = 4;

		// Token: 0x04022E99 RID: 143001
		public const int ItemRedDot = 5;
	}
}
