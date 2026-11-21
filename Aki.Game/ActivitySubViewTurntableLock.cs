using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009EB RID: 2539
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewTurntableLock : ActivitySubViewBase
{
	// Token: 0x06006EE1 RID: 28385 RVA: 0x002229E8 File Offset: 0x00220BE8
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

	// Token: 0x06006EE2 RID: 28386 RVA: 0x00222AB4 File Offset: 0x00220CB4
	protected override void OnSetData()
	{
		this.ActivityTurntableData = (this.ActivityBaseData as ActivityTurntableData);
	}

	// Token: 0x06006EE3 RID: 28387 RVA: 0x00222AC8 File Offset: 0x00220CC8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewTurntableLock.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewTurntableLock.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006EE4 RID: 28388 RVA: 0x00222B0C File Offset: 0x00220D0C
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

	// Token: 0x06006EE5 RID: 28389 RVA: 0x00222C38 File Offset: 0x00220E38
	protected override void OnRefreshView()
	{
		this.RefreshTimerText();
		this.RefreshCondition();
		this.RefreshRedDot();
	}

	// Token: 0x06006EE6 RID: 28390 RVA: 0x00222C4C File Offset: 0x00220E4C
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06006EE7 RID: 28391 RVA: 0x00222C54 File Offset: 0x00220E54
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

	// Token: 0x06006EE8 RID: 28392 RVA: 0x00222CD0 File Offset: 0x00220ED0
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

	// Token: 0x06006EE9 RID: 28393 RVA: 0x00222D10 File Offset: 0x00220F10
	private void RefreshRedDot()
	{
		bool functionRedDotVisible = this.ActivityTurntableData.IsHasPreQuestRedDot();
		this.FunctionalComponent.SetFunctionRedDotVisible(functionRedDotVisible);
	}

	// Token: 0x06006EEA RID: 28394 RVA: 0x00222D35 File Offset: 0x00220F35
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

	// Token: 0x040044C8 RID: 17608
	protected ActivityTurntableData ActivityTurntableData;

	// Token: 0x040044C9 RID: 17609
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x040044CA RID: 17610
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x040044CB RID: 17611
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x040044CC RID: 17612
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x02006CF0 RID: 27888
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023C75 RID: 146549
		public const int PanelItem = 0;

		// Token: 0x04023C76 RID: 146550
		public const int TitleItem = 1;

		// Token: 0x04023C77 RID: 146551
		public const int DescriptionItem = 2;

		// Token: 0x04023C78 RID: 146552
		public const int RewardListItem = 3;

		// Token: 0x04023C79 RID: 146553
		public const int FunctionArea = 4;
	}
}
