using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001278 RID: 4728
public class FightPhotoActivitySubView : ActivitySubViewBase
{
	// Token: 0x060080F5 RID: 33013 RVA: 0x001B5130 File Offset: 0x001B3330
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

	// Token: 0x060080F6 RID: 33014 RVA: 0x001B51F0 File Offset: 0x001B33F0
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoActivitySubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoActivitySubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060080F7 RID: 33015 RVA: 0x001B5234 File Offset: 0x001B3434
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

	// Token: 0x060080F8 RID: 33016 RVA: 0x001B5341 File Offset: 0x001B3541
	private void OnRewardBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.FightPhotoRewardView, this.ActivityBaseData, null);
	}

	// Token: 0x060080F9 RID: 33017 RVA: 0x001B5359 File Offset: 0x001B3559
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

	// Token: 0x04003A7D RID: 14973
	[Nullable(1)]
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x02007889 RID: 30857
	private class EComponents
	{
		// Token: 0x04027B63 RID: 162659
		public const int CommonActivityInfo = 0;

		// Token: 0x04027B64 RID: 162660
		public const int TextFinishedLevelNum = 1;

		// Token: 0x04027B65 RID: 162661
		public const int TextTotalLevelNum = 2;

		// Token: 0x04027B66 RID: 162662
		public const int BtnReward = 3;

		// Token: 0x04027B67 RID: 162663
		public const int TextRewardProgress = 4;

		// Token: 0x04027B68 RID: 162664
		public const int ItemRedDot = 5;
	}
}
