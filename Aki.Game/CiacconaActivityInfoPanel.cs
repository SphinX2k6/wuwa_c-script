using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.CiacconaGal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000693 RID: 1683
[NullableContext(1)]
[Nullable(0)]
public class CiacconaActivityInfoPanel : UiPanelBase
{
	// Token: 0x06004D84 RID: 19844 RVA: 0x001A3495 File Offset: 0x001A1695
	public CiacconaActivityInfoPanel(ActivityBaseData activityBaseData)
	{
		this.ActivityBaseData = activityBaseData;
	}

	// Token: 0x06004D85 RID: 19845 RVA: 0x001A34A4 File Offset: 0x001A16A4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06004D86 RID: 19846 RVA: 0x001A3550 File Offset: 0x001A1750
	protected override UniTask OnBeforeStartAsync()
	{
		CiacconaActivityInfoPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaActivityInfoPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004D87 RID: 19847 RVA: 0x001A3593 File Offset: 0x001A1793
	protected override void OnBeforeShow()
	{
		this.RefreshFunctionArea();
	}

	// Token: 0x06004D88 RID: 19848 RVA: 0x001A359C File Offset: 0x001A179C
	public void RefreshFunctionArea()
	{
		CiacconaGalActivityData activityDataById = CiacconaGalModel.Instance.GetActivityDataById(this.ActivityBaseData.Id);
		ActivityFunctionAreaParams parameters = new ActivityFunctionAreaParams
		{
			UnlockBtnFunction = new Action(this.OnBtnConfirmClick),
			UnlockBtnTextId = (activityDataById.State2Unlock ? "XKAVG_SystemTitle_17" : "XKAVG_SystemTitle_16")
		};
		ActivityFunctionalTypeA bottomItem = this.BottomItem;
		if (bottomItem != null)
		{
			bottomItem.RefreshGeneralPerformance(parameters);
		}
		bool flag = CiacconaGalModel.Instance.HasAnyEndingReward();
		bool flag2 = CiacconaGalModel.Instance.HasAnyProgressReward();
		bool flag3 = CiacconaGalModel.Instance.HasAnySubEndingReward();
		ActivityFunctionalTypeA bottomItem2 = this.BottomItem;
		if (bottomItem2 == null)
		{
			return;
		}
		bottomItem2.SetFunctionRedDotVisible(flag || flag2 || flag3);
	}

	// Token: 0x06004D89 RID: 19849 RVA: 0x001A363B File Offset: 0x001A183B
	public void SetTimer(bool visible, string text)
	{
		ActivityTitleTypeA commonActivityTitle = this.CommonActivityTitle;
		if (commonActivityTitle != null)
		{
			commonActivityTitle.SetTimeTextVisible(visible);
		}
		ActivityTitleTypeA commonActivityTitle2 = this.CommonActivityTitle;
		if (commonActivityTitle2 == null)
		{
			return;
		}
		commonActivityTitle2.SetTimeTextByText(text);
	}

	// Token: 0x06004D8A RID: 19850 RVA: 0x001A3660 File Offset: 0x001A1860
	public void SetTitle(string text)
	{
		ActivityTitleTypeA commonActivityTitle = this.CommonActivityTitle;
		if (commonActivityTitle != null)
		{
			commonActivityTitle.SetActivityBaseData(this.ActivityBaseData);
		}
		ActivityTitleTypeA commonActivityTitle2 = this.CommonActivityTitle;
		if (commonActivityTitle2 == null)
		{
			return;
		}
		commonActivityTitle2.SetTitleByText(text);
	}

	// Token: 0x06004D8B RID: 19851 RVA: 0x001A368A File Offset: 0x001A188A
	public void SetSubTitle(bool visible, string text)
	{
		ActivityTitleTypeA commonActivityTitle = this.CommonActivityTitle;
		if (commonActivityTitle != null)
		{
			commonActivityTitle.SetSubTitleVisible(visible);
		}
		ActivityTitleTypeA commonActivityTitle2 = this.CommonActivityTitle;
		if (commonActivityTitle2 == null)
		{
			return;
		}
		commonActivityTitle2.SetSubTitleByText(text);
	}

	// Token: 0x06004D8C RID: 19852 RVA: 0x001A36AF File Offset: 0x001A18AF
	public void SetDesc(bool visible, string text)
	{
		ActivityDescriptionTypeA commonActivityDesc = this.CommonActivityDesc;
		if (commonActivityDesc != null)
		{
			commonActivityDesc.SetContentVisible(visible);
		}
		ActivityDescriptionTypeA commonActivityDesc2 = this.CommonActivityDesc;
		if (commonActivityDesc2 == null)
		{
			return;
		}
		commonActivityDesc2.SetContentByTextId(text, Array.Empty<string>());
	}

	// Token: 0x06004D8D RID: 19853 RVA: 0x001A36D9 File Offset: 0x001A18D9
	public void SetReward(bool visible, List<TItem> rewardList)
	{
		ActivityRewardList<CommonItemSmallItemGrid, TItem> commonActivityReward = this.CommonActivityReward;
		if (commonActivityReward != null)
		{
			commonActivityReward.SetUiActive(visible);
		}
		ActivityRewardList<CommonItemSmallItemGrid, TItem> commonActivityReward2 = this.CommonActivityReward;
		if (commonActivityReward2 == null)
		{
			return;
		}
		commonActivityReward2.RefreshItemLayout(rewardList, null);
	}

	// Token: 0x06004D8E RID: 19854 RVA: 0x001A36FF File Offset: 0x001A18FF
	private void OnBtnConfirmClick()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
			ECiacconaGalActivityState state = CiacconaGalModel.Instance.GetActivityDataById(this.ActivityBaseData.Id).State;
			if (state != ECiacconaGalActivityState.Init)
			{
				if (state - ECiacconaGalActivityState.TaskFinish > 1)
				{
					return;
				}
				CiacconaGalController.Instance.OpenChapterEntryView(this.ActivityBaseData.Id, ECiacconaEntryType.FromActivity);
			}
			else if (unFinishPreGuideQuestId != 0)
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
		});
	}

	// Token: 0x06004D8F RID: 19855 RVA: 0x001A3720 File Offset: 0x001A1920
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		ActivityFunctionalTypeA bottomItem = this.BottomItem;
		UUIItem uuiitem;
		if (bottomItem == null)
		{
			uuiitem = null;
		}
		else
		{
			ActivityButtonItem functionButton = bottomItem.FunctionButton;
			uuiitem = ((functionButton != null) ? functionButton.GetRootItem() : null);
		}
		UUIItem uuiitem2 = uuiitem;
		if (uuiitem2 == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem2,
			uuiitem2
		};
	}

	// Token: 0x04003897 RID: 14487
	[Nullable(2)]
	private ActivityTitleTypeA CommonActivityTitle;

	// Token: 0x04003898 RID: 14488
	[Nullable(2)]
	private ActivityDescriptionTypeA CommonActivityDesc;

	// Token: 0x04003899 RID: 14489
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> CommonActivityReward;

	// Token: 0x0400389A RID: 14490
	[Nullable(2)]
	private ActivityFunctionalTypeA BottomItem;

	// Token: 0x0400389B RID: 14491
	private ActivityBaseData ActivityBaseData;

	// Token: 0x02006954 RID: 26964
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04022B14 RID: 142100
		public const int ItemCommonActivityTitle = 0;

		// Token: 0x04022B15 RID: 142101
		public const int ItemCommonActivityDesc = 1;

		// Token: 0x04022B16 RID: 142102
		public const int ItemCommonActivityReward = 2;

		// Token: 0x04022B17 RID: 142103
		public const int ItemCommonActivityBottom = 3;
	}
}
