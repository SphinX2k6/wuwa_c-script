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

// Token: 0x020009AC RID: 2476
[NullableContext(1)]
[Nullable(0)]
public class ScratchTicketActivityView : ActivitySubViewBase
{
	// Token: 0x06006CB7 RID: 27831 RVA: 0x0021A57C File Offset: 0x0021877C
	protected override void OnSetData()
	{
		this.ScratchTicketData = (this.ActivityBaseData as ScratchTicketData);
	}

	// Token: 0x06006CB8 RID: 27832 RVA: 0x0021A590 File Offset: 0x00218790
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

	// Token: 0x06006CB9 RID: 27833 RVA: 0x0021A748 File Offset: 0x00218948
	protected override UniTask OnBeforeStartAsync()
	{
		ScratchTicketActivityView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ScratchTicketActivityView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006CBA RID: 27834 RVA: 0x0021A78C File Offset: 0x0021898C
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

	// Token: 0x06006CBB RID: 27835 RVA: 0x0021A89C File Offset: 0x00218A9C
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

	// Token: 0x06006CBC RID: 27836 RVA: 0x0021AA50 File Offset: 0x00218C50
	private void RefreshTimerText()
	{
		string item = this.GetTimeVisibleAndRemainTime().Item2;
		this.TitleItem.SetTimeTextByText(item);
	}

	// Token: 0x06006CBD RID: 27837 RVA: 0x0021AA75 File Offset: 0x00218C75
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06006CBE RID: 27838 RVA: 0x0021AA7D File Offset: 0x00218C7D
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

	// Token: 0x040043E3 RID: 17379
	private ActivityTitleTypeA TitleItem;

	// Token: 0x040043E4 RID: 17380
	private ActivityDescriptionTypeA DescriptionItem;

	// Token: 0x040043E5 RID: 17381
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListItem;

	// Token: 0x040043E6 RID: 17382
	[Nullable(2)]
	private ActivityFunctionalTypeA FunctionalItem;

	// Token: 0x040043E7 RID: 17383
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ScratchTicketProgressItem, ScratchTicketRoundData> RoundLayout;

	// Token: 0x040043E8 RID: 17384
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ScratchTicketConditionItem, ScratchTicketConditionData> ConditionLayout;

	// Token: 0x040043E9 RID: 17385
	[Nullable(2)]
	private ScratchTicketData ScratchTicketData;

	// Token: 0x040043EA RID: 17386
	private readonly Func<ScratchTicketProgressItem> CreateRoundItem = () => new ScratchTicketProgressItem();

	// Token: 0x040043EB RID: 17387
	private readonly Func<ScratchTicketConditionItem> CreateConditionItem = () => new ScratchTicketConditionItem();

	// Token: 0x02006CB3 RID: 27827
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04023B47 RID: 146247
		public const int TitleItem = 0;

		// Token: 0x04023B48 RID: 146248
		public const int DescriptionItem = 1;

		// Token: 0x04023B49 RID: 146249
		public const int RewardItem = 2;

		// Token: 0x04023B4A RID: 146250
		public const int FunctionItem = 3;

		// Token: 0x04023B4B RID: 146251
		public const int ScratchTicketRootItem = 4;

		// Token: 0x04023B4C RID: 146252
		public const int ScratchTicketProgressLayout = 5;

		// Token: 0x04023B4D RID: 146253
		public const int CostItemIcon = 6;

		// Token: 0x04023B4E RID: 146254
		public const int CostItemCount = 7;

		// Token: 0x04023B4F RID: 146255
		public const int ScratchTicketConditionLayout = 8;

		// Token: 0x04023B50 RID: 146256
		public const int EmptyItem = 9;

		// Token: 0x04023B51 RID: 146257
		public const int RoundSprite = 10;

		// Token: 0x04023B52 RID: 146258
		public const int ScratchTicketConditionRoot = 11;
	}
}
