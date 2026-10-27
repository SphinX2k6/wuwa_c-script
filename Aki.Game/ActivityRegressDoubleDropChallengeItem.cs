using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014B6 RID: 5302
public class ActivityRegressDoubleDropChallengeItem : UiPanelBase
{
	// Token: 0x17000D05 RID: 3333
	// (get) Token: 0x06009636 RID: 38454 RVA: 0x00206CF3 File Offset: 0x00204EF3
	public EActivityRegressDoubleDropEntryType EntryType { get; }

	// Token: 0x06009637 RID: 38455 RVA: 0x00206CFB File Offset: 0x00204EFB
	public ActivityRegressDoubleDropChallengeItem(EActivityRegressDoubleDropEntryType entryType)
	{
		this.EntryType = entryType;
	}

	// Token: 0x06009638 RID: 38456 RVA: 0x00206D0C File Offset: 0x00204F0C
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

	// Token: 0x06009639 RID: 38457 RVA: 0x00206DE0 File Offset: 0x00204FE0
	protected override void OnStart()
	{
		base.OnStart();
		UUIItem item = base.GetItem(2);
		this.ConfirmButtonItem = new ButtonItem(item);
		this.ConfirmButtonItem.SetFunction(new Action<int>(this.OnConfirmBtnClick));
	}

	// Token: 0x0600963A RID: 38458 RVA: 0x00206E1E File Offset: 0x0020501E
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.UpdateVisual();
	}

	// Token: 0x0600963B RID: 38459 RVA: 0x00206E2C File Offset: 0x0020502C
	private void UpdateVisual()
	{
		this.UpdateUnlockState();
		this.UpdateRestTimes();
	}

	// Token: 0x0600963C RID: 38460 RVA: 0x00206E3C File Offset: 0x0020503C
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

	// Token: 0x0600963D RID: 38461 RVA: 0x00206F84 File Offset: 0x00205184
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

	// Token: 0x0600963E RID: 38462 RVA: 0x00207004 File Offset: 0x00205204
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

	// Token: 0x04004256 RID: 16982
	[Nullable(2)]
	private ButtonItem ConfirmButtonItem;

	// Token: 0x02007AEE RID: 31470
	private class EActivityRegressDoubleDropChallengeItemComponents
	{
		// Token: 0x04028703 RID: 165635
		public const int TxtName = 0;

		// Token: 0x04028704 RID: 165636
		public const int TxtTips = 1;

		// Token: 0x04028705 RID: 165637
		public const int BtnConfirmA = 2;

		// Token: 0x04028706 RID: 165638
		public const int PnlLock = 3;

		// Token: 0x04028707 RID: 165639
		public const int TxtLock = 4;

		// Token: 0x04028708 RID: 165640
		public const int PnlTips = 5;

		// Token: 0x04028709 RID: 165641
		public const int TxtNum = 6;

		// Token: 0x0402870A RID: 165642
		public const int IsPreOpenItem = 7;
	}
}
