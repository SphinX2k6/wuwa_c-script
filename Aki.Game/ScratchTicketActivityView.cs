using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014F4 RID: 5364
[NullableContext(1)]
[Nullable(0)]
public class ScratchTicketActivityView : ActivitySubViewBase
{
	// Token: 0x060098DD RID: 39133 RVA: 0x0021088C File Offset: 0x0020EA8C
	protected override void OnSetData()
	{
		this.ScratchTicketData = (this.ActivityBaseData as ScratchTicketData);
	}

	// Token: 0x060098DE RID: 39134 RVA: 0x002108A0 File Offset: 0x0020EAA0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
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
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060098DF RID: 39135 RVA: 0x00210A58 File Offset: 0x0020EC58
	protected override UniTask OnBeforeStartAsync()
	{
		ScratchTicketActivityView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ScratchTicketActivityView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060098E0 RID: 39136 RVA: 0x00210A9C File Offset: 0x0020EC9C
	protected override void OnStart()
	{
		Activity? localConfig = this.ScratchTicketData.LocalConfig;
		if (localConfig == null)
		{
			return;
		}
		this.TitleItem.SetActivityBaseData(this.ScratchTicketData);
		this.TitleItem.SetTitleByText(this.ScratchTicketData.GetTitle());
		string descTheme = localConfig.Value.DescTheme;
		bool flag = !StringUtils.IsEmpty(descTheme);
		this.TitleItem.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleItem.SetSubTitleByTextId(descTheme, Array.Empty<string>());
		}
		this.DescriptionItem.SetContentByTextId(localConfig.Value.Desc, Array.Empty<string>());
		List<TItem> previewReward = this.ScratchTicketData.GetPreviewReward(null);
		this.RewardListItem.SetTitleByTextId("CollectActivity_reward");
		this.RewardListItem.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListItem.InitCommonGridItem));
		this.RewardListItem.RefreshItemLayout(previewReward, null);
		this.FunctionalItem.FunctionButton.SetFunction(new Action(this.FunctionExecute));
	}

	// Token: 0x060098E1 RID: 39137 RVA: 0x00210BAC File Offset: 0x0020EDAC
	protected override void OnRefreshView()
	{
		ScratchCardActivityRe? scratchCardActivityConfig = this.ScratchTicketData.GetScratchCardActivityConfig();
		if (scratchCardActivityConfig == null)
		{
			return;
		}
		bool flag = this.ScratchTicketData.IsUnLock();
		bool preGuideQuestFinishState = this.ScratchTicketData.GetPreGuideQuestFinishState();
		bool flag2 = this.ScratchTicketData.IsAllRoundFinish();
		this.FunctionalItem.SetPanelConditionVisible(!flag);
		this.RefreshTimerText();
		if (!flag)
		{
			this.FunctionalItem.SetPerformanceConditionLock(this.ScratchTicketData.ConditionGroupId, this.ScratchTicketData.Id);
		}
		this.FunctionalItem.FunctionButton.SetUiActive(flag);
		string showText = preGuideQuestFinishState ? "ScratchCardActivity_JoinIn02" : "ScratchCardActivity_JoinIn01";
		this.FunctionalItem.FunctionButton.SetShowText(showText);
		this.FunctionalItem.FunctionButton.SetRedDotVisible(this.ScratchTicketData.RedPointShowState);
		this.DescriptionItem.SetUiActive(!preGuideQuestFinishState);
		base.GetItem(9).SetUIActive(preGuideQuestFinishState && flag2);
		base.GetItem(4).SetUIActive(preGuideQuestFinishState);
		List<ScratchTicketRoundData> roundDataList = this.ScratchTicketData.GetRoundDataList();
		this.RoundLayout.RefreshByData(roundDataList, null, false);
		if (preGuideQuestFinishState && !flag2)
		{
			List<ScratchTicketConditionData> conditionDataList = this.ScratchTicketData.GetConditionDataList();
			this.ConditionLayout.RefreshByData(conditionDataList, null, false);
			EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.SetActivityViewCurrency, new <>z__ReadOnlySingleElementList<int>(scratchCardActivityConfig.Value.ItemId));
		}
		base.GetItem(11).SetUIActive(!flag2);
		ScratchTicketRoundData firstProgressRoundData = this.ScratchTicketData.GetFirstProgressRoundData();
		if (firstProgressRoundData != null)
		{
			string togRoundIcon = firstProgressRoundData.Config.Value.TogRoundIcon;
			this.SetSpriteByPath(togRoundIcon, base.GetSprite(10), false, null, null);
		}
	}

	// Token: 0x060098E2 RID: 39138 RVA: 0x00210D60 File Offset: 0x0020EF60
	private void RefreshTimerText()
	{
		string item = this.GetTimeVisibleAndRemainTime().Item2;
		this.TitleItem.SetTimeTextByText(item);
	}

	// Token: 0x060098E3 RID: 39139 RVA: 0x00210D85 File Offset: 0x0020EF85
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x060098E4 RID: 39140 RVA: 0x00210D8D File Offset: 0x0020EF8D
	private void FunctionExecute()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (!this.ScratchTicketData.ActivityHasClick())
			{
				this.ScratchTicketData.ClickRedDot();
			}
			if (!this.ScratchTicketData.GetPreGuideQuestFinishState())
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, this.ScratchTicketData.GetUnFinishPreGuideQuestId(), null);
				return;
			}
			ScratchCardActivityRe? scratchCardActivityConfig = this.ScratchTicketData.GetScratchCardActivityConfig();
			if (scratchCardActivityConfig.Value.JumpId == 0)
			{
				UiManager.Instance.OpenView(EUiViewName.ScratchTicketMainView, this.ScratchTicketData, null);
				return;
			}
			SkipTaskManager.RunByConfigId(scratchCardActivityConfig.Value.JumpId, null);
		});
	}

	// Token: 0x0400433E RID: 17214
	private ActivityTitleTypeA TitleItem;

	// Token: 0x0400433F RID: 17215
	private ActivityDescriptionTypeA DescriptionItem;

	// Token: 0x04004340 RID: 17216
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListItem;

	// Token: 0x04004341 RID: 17217
	[Nullable(2)]
	private ActivityFunctionalTypeA FunctionalItem;

	// Token: 0x04004342 RID: 17218
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ScratchTicketProgressItem, ScratchTicketRoundData> RoundLayout;

	// Token: 0x04004343 RID: 17219
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ScratchTicketConditionItem, ScratchTicketConditionData> ConditionLayout;

	// Token: 0x04004344 RID: 17220
	[Nullable(2)]
	private ScratchTicketData ScratchTicketData;

	// Token: 0x04004345 RID: 17221
	private readonly Func<ScratchTicketProgressItem> CreateRoundItem = () => new ScratchTicketProgressItem();

	// Token: 0x04004346 RID: 17222
	private readonly Func<ScratchTicketConditionItem> CreateConditionItem = () => new ScratchTicketConditionItem();

	// Token: 0x02007B27 RID: 31527
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04028809 RID: 165897
		public const int TitleItem = 0;

		// Token: 0x0402880A RID: 165898
		public const int DescriptionItem = 1;

		// Token: 0x0402880B RID: 165899
		public const int RewardItem = 2;

		// Token: 0x0402880C RID: 165900
		public const int FunctionItem = 3;

		// Token: 0x0402880D RID: 165901
		public const int ScratchTicketRootItem = 4;

		// Token: 0x0402880E RID: 165902
		public const int ScratchTicketProgressLayout = 5;

		// Token: 0x0402880F RID: 165903
		public const int CostItemIcon = 6;

		// Token: 0x04028810 RID: 165904
		public const int CostItemCount = 7;

		// Token: 0x04028811 RID: 165905
		public const int ScratchTicketConditionLayout = 8;

		// Token: 0x04028812 RID: 165906
		public const int EmptyItem = 9;

		// Token: 0x04028813 RID: 165907
		public const int RoundSprite = 10;

		// Token: 0x04028814 RID: 165908
		public const int ScratchTicketConditionRoot = 11;
	}
}
