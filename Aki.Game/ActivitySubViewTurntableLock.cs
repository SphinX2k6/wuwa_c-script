using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001533 RID: 5427
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewTurntableLock : ActivitySubViewBase
{
	// Token: 0x06009B03 RID: 39683 RVA: 0x00218C48 File Offset: 0x00216E48
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
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
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009B04 RID: 39684 RVA: 0x00218D14 File Offset: 0x00216F14
	protected override void OnSetData()
	{
		this.ActivityTurntableData = (this.ActivityBaseData as ActivityTurntableData);
	}

	// Token: 0x06009B05 RID: 39685 RVA: 0x00218D28 File Offset: 0x00216F28
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewTurntableLock.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewTurntableLock.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009B06 RID: 39686 RVA: 0x00218D6C File Offset: 0x00216F6C
	protected override void OnStart()
	{
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
		if (localConfig == null)
		{
			return;
		}
		string descTheme = localConfig.Value.DescTheme;
		bool flag = !StringUtils.IsEmpty(descTheme);
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		this.TitleComponent.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
		}
		string desc = localConfig.Value.Desc;
		this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
		this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.FunctionExecute));
		if (this.ActivityTurntableData.IsUnLock())
		{
			this.ActivityTurntableData.SaveUnlockRedDot();
		}
	}

	// Token: 0x06009B07 RID: 39687 RVA: 0x00218E98 File Offset: 0x00217098
	protected override void OnRefreshView()
	{
		this.RefreshTimerText();
		this.RefreshCondition();
		this.RefreshRedDot();
	}

	// Token: 0x06009B08 RID: 39688 RVA: 0x00218EAC File Offset: 0x002170AC
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06009B09 RID: 39689 RVA: 0x00218EB4 File Offset: 0x002170B4
	private void RefreshCondition()
	{
		bool flag = this.ActivityBaseData.IsUnLock();
		ActivityButtonItem functionButton = this.FunctionalComponent.FunctionButton;
		if (functionButton != null)
		{
			functionButton.SetUiActive(flag);
		}
		this.FunctionalComponent.SetPanelConditionVisible(!flag);
		if (!flag)
		{
			ActivityButtonItem functionButton2 = this.FunctionalComponent.FunctionButton;
			if (functionButton2 != null)
			{
				functionButton2.SetUiActive(false);
			}
			this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
		}
	}

	// Token: 0x06009B0A RID: 39690 RVA: 0x00218F30 File Offset: 0x00217130
	private void RefreshTimerText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
	}

	// Token: 0x06009B0B RID: 39691 RVA: 0x00218F70 File Offset: 0x00217170
	private void RefreshRedDot()
	{
		bool functionRedDotVisible = this.ActivityTurntableData.IsHasPreQuestRedDot();
		this.FunctionalComponent.SetFunctionRedDotVisible(functionRedDotVisible);
	}

	// Token: 0x06009B0C RID: 39692 RVA: 0x00218F95 File Offset: 0x00217195
	private void FunctionExecute()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
				this.ActivityTurntableData.SavePreQuestRedDot(unFinishPreGuideQuestId);
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
			}
		});
	}

	// Token: 0x04004422 RID: 17442
	protected ActivityTurntableData ActivityTurntableData;

	// Token: 0x04004423 RID: 17443
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04004424 RID: 17444
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04004425 RID: 17445
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04004426 RID: 17446
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x02007B65 RID: 31589
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402893A RID: 166202
		public const int PanelItem = 0;

		// Token: 0x0402893B RID: 166203
		public const int TitleItem = 1;

		// Token: 0x0402893C RID: 166204
		public const int DescriptionItem = 2;

		// Token: 0x0402893D RID: 166205
		public const int RewardListItem = 3;

		// Token: 0x0402893E RID: 166206
		public const int FunctionArea = 4;
	}
}
