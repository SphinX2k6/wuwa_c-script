using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.CiacconaGal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011DF RID: 4575
[NullableContext(1)]
[Nullable(0)]
public class CiacconaActivityInfoPanel : UiPanelBase
{
	// Token: 0x060079ED RID: 31213 RVA: 0x0019A7E5 File Offset: 0x001989E5
	public CiacconaActivityInfoPanel(ActivityBaseData activityBaseData)
	{
		this.ActivityBaseData = activityBaseData;
	}

	// Token: 0x060079EE RID: 31214 RVA: 0x0019A7F4 File Offset: 0x001989F4
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

	// Token: 0x060079EF RID: 31215 RVA: 0x0019A8A0 File Offset: 0x00198AA0
	protected override UniTask OnBeforeStartAsync()
	{
		CiacconaActivityInfoPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaActivityInfoPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060079F0 RID: 31216 RVA: 0x0019A8E3 File Offset: 0x00198AE3
	protected override void OnBeforeShow()
	{
		this.RefreshFunctionArea();
	}

	// Token: 0x060079F1 RID: 31217 RVA: 0x0019A8EC File Offset: 0x00198AEC
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

	// Token: 0x060079F2 RID: 31218 RVA: 0x0019A98B File Offset: 0x00198B8B
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

	// Token: 0x060079F3 RID: 31219 RVA: 0x0019A9B0 File Offset: 0x00198BB0
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

	// Token: 0x060079F4 RID: 31220 RVA: 0x0019A9DA File Offset: 0x00198BDA
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

	// Token: 0x060079F5 RID: 31221 RVA: 0x0019A9FF File Offset: 0x00198BFF
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

	// Token: 0x060079F6 RID: 31222 RVA: 0x0019AA29 File Offset: 0x00198C29
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

	// Token: 0x060079F7 RID: 31223 RVA: 0x0019AA4F File Offset: 0x00198C4F
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

	// Token: 0x060079F8 RID: 31224 RVA: 0x0019AA70 File Offset: 0x00198C70
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

	// Token: 0x040037FE RID: 14334
	[Nullable(2)]
	private ActivityTitleTypeA CommonActivityTitle;

	// Token: 0x040037FF RID: 14335
	[Nullable(2)]
	private ActivityDescriptionTypeA CommonActivityDesc;

	// Token: 0x04003800 RID: 14336
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> CommonActivityReward;

	// Token: 0x04003801 RID: 14337
	[Nullable(2)]
	private ActivityFunctionalTypeA BottomItem;

	// Token: 0x04003802 RID: 14338
	private ActivityBaseData ActivityBaseData;

	// Token: 0x020077C9 RID: 30665
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040277E2 RID: 161762
		public const int ItemCommonActivityTitle = 0;

		// Token: 0x040277E3 RID: 161763
		public const int ItemCommonActivityDesc = 1;

		// Token: 0x040277E4 RID: 161764
		public const int ItemCommonActivityReward = 2;

		// Token: 0x040277E5 RID: 161765
		public const int ItemCommonActivityBottom = 3;
	}
}
