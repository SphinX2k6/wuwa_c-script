using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200096A RID: 2410
public class ActivityRegressDoubleDropChallengeItem : UiPanelBase
{
	// Token: 0x17000D25 RID: 3365
	// (get) Token: 0x060069CB RID: 27083 RVA: 0x0020FC5F File Offset: 0x0020DE5F
	public EActivityRegressDoubleDropEntryType EntryType { get; }

	// Token: 0x060069CC RID: 27084 RVA: 0x0020FC67 File Offset: 0x0020DE67
	public ActivityRegressDoubleDropChallengeItem(EActivityRegressDoubleDropEntryType entryType)
	{
		this.EntryType = entryType;
	}

	// Token: 0x060069CD RID: 27085 RVA: 0x0020FC78 File Offset: 0x0020DE78
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x060069CE RID: 27086 RVA: 0x0020FD4C File Offset: 0x0020DF4C
	protected override void OnStart()
	{
		base.OnStart();
		UUIItem item = base.GetItem(2);
		this.ConfirmButtonItem = new ButtonItem(item);
		this.ConfirmButtonItem.SetFunction(new Action<int>(this.OnConfirmBtnClick));
	}

	// Token: 0x060069CF RID: 27087 RVA: 0x0020FD8A File Offset: 0x0020DF8A
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.UpdateVisual();
	}

	// Token: 0x060069D0 RID: 27088 RVA: 0x0020FD98 File Offset: 0x0020DF98
	private void UpdateVisual()
	{
		this.UpdateUnlockState();
		this.UpdateRestTimes();
	}

	// Token: 0x060069D1 RID: 27089 RVA: 0x0020FDA8 File Offset: 0x0020DFA8
	private void UpdateUnlockState()
	{
		RegressDoubleDrop? doubleDropConfig = ActivityRegressConfig.Instance.GetDoubleDropConfig(ActivityRegressModel.Instance.Grade);
		if (doubleDropConfig == null)
		{
			return;
		}
		RegressDoubleDrop value = doubleDropConfig.Value;
		bool flag = ActivityRegressModel.Instance.ActivityData.IsDoubleDropUnlock(this.EntryType);
		string text = "";
		bool uiactive = false;
		if (this.EntryType == EActivityRegressDoubleDropEntryType.WorldBoss)
		{
			int bossUnLock = value.BossUnLock;
			ConditionGroup? conditionGroup = ActivityRegressConfig.Instance.GetConditionGroup(bossUnLock);
			text = (((conditionGroup != null) ? conditionGroup.GetValueOrDefault().HintText : null) ?? "");
			uiactive = AdventureGuideModel.Instance.GetIsDetectionPreOpenByDungeonType(EDungeonType.Boss);
		}
		if (this.EntryType == EActivityRegressDoubleDropEntryType.WeeklyDungeon)
		{
			int weekUnLock = value.WeekUnLock;
			ConditionGroup? conditionGroup2 = ActivityRegressConfig.Instance.GetConditionGroup(weekUnLock);
			text = (((conditionGroup2 != null) ? conditionGroup2.GetValueOrDefault().HintText : null) ?? "");
			uiactive = AdventureGuideModel.Instance.GetIsDetectionPreOpenByDungeonType(EDungeonType.Weekly);
		}
		if (!flag && !StringUtils.IsEmpty(text))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), text, Array.Empty<object>());
		}
		this.ConfirmButtonItem.SetUiActive(flag);
		base.GetItem(3).SetUIActive(!flag);
		base.GetItem(7).SetUIActive(uiactive);
	}

	// Token: 0x060069D2 RID: 27090 RVA: 0x0020FEF0 File Offset: 0x0020E0F0
	private void UpdateRestTimes()
	{
		bool flag = ActivityRegressModel.Instance.ActivityData.IsDoubleDropUnlock(this.EntryType);
		int doubleDropRestTimes = ActivityRegressModel.Instance.GetDoubleDropRestTimes(this.EntryType);
		int doubleDropMaxTimes = ActivityRegressModel.Instance.GetDoubleDropMaxTimes(this.EntryType);
		UUIText text = base.GetText(6);
		LguiUtil.Instance.SetLocalTextNew(text, "Recall_double_reward_tips", new <>z__ReadOnlyArray<object>(new object[]
		{
			flag ? doubleDropRestTimes : doubleDropMaxTimes,
			doubleDropMaxTimes
		}));
	}

	// Token: 0x060069D3 RID: 27091 RVA: 0x0020FF70 File Offset: 0x0020E170
	private void OnConfirmBtnClick(int _)
	{
		ERegressGrade grade = ActivityRegressModel.Instance.Grade;
		RegressDoubleDrop? doubleDropConfig = ActivityRegressConfig.Instance.GetDoubleDropConfig(grade);
		if (doubleDropConfig == null)
		{
			return;
		}
		RegressDoubleDrop value = doubleDropConfig.Value;
		if (this.EntryType == EActivityRegressDoubleDropEntryType.WorldBoss)
		{
			ActivityRegressHelper.ReportRecallLog1024New(EReportLogEventNewType.DoubleDrop, 0, 1);
			SkipTaskManager.RunByConfigId(value.WorldBossAccessPathId, null);
			return;
		}
		if (this.EntryType == EActivityRegressDoubleDropEntryType.WeeklyDungeon)
		{
			ActivityRegressHelper.ReportRecallLog1024New(EReportLogEventNewType.DoubleDrop, 0, 2);
			SkipTaskManager.RunByConfigId(value.WeekAccessPathId, null);
		}
	}

	// Token: 0x040042EE RID: 17134
	[Nullable(2)]
	private ButtonItem ConfirmButtonItem;

	// Token: 0x02006C72 RID: 27762
	private class EActivityRegressDoubleDropChallengeItemComponents
	{
		// Token: 0x04023A1D RID: 145949
		public const int TxtName = 0;

		// Token: 0x04023A1E RID: 145950
		public const int TxtTips = 1;

		// Token: 0x04023A1F RID: 145951
		public const int BtnConfirmA = 2;

		// Token: 0x04023A20 RID: 145952
		public const int PnlLock = 3;

		// Token: 0x04023A21 RID: 145953
		public const int TxtLock = 4;

		// Token: 0x04023A22 RID: 145954
		public const int PnlTips = 5;

		// Token: 0x04023A23 RID: 145955
		public const int TxtNum = 6;

		// Token: 0x04023A24 RID: 145956
		public const int IsPreOpenItem = 7;
	}
}
