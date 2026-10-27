using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011FA RID: 4602
public class ActivityCorniceMeetingSettleDetailPanel : UiPanelBase
{
	// Token: 0x06007B13 RID: 31507 RVA: 0x0019ED7C File Offset: 0x0019CF7C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007B14 RID: 31508 RVA: 0x0019EE8C File Offset: 0x0019D08C
	protected override void OnStart()
	{
		if (this.Data == null)
		{
			return;
		}
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		if (currentActivityData == null)
		{
			return;
		}
		ActivityCorniceMeetingLevelEntryData levelEntryData = currentActivityData.GetLevelEntryData(this.Data.LevelPlayId);
		if (levelEntryData == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Text_ItemCost_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			levelEntryData.CurrentScore.ToString(),
			(levelEntryData != null) ? new int?(levelEntryData.GetMaxScoreConfig()) : null
		}));
		string timeString = TimeUtil.Instance.GetTimeString((double)this.Data.RemainingTime);
		base.GetText(1).SetText(timeString, true);
		base.GetItem(5).SetUIActive(levelEntryData.CurrentScore >= levelEntryData.GetMaxScoreConfig());
		base.GetItem(4).SetUIActive(levelEntryData.CurrentScore > 0);
		base.GetItem(3).SetUIActive(this.Data.NewRemainingTimeRecord && !this.Data.NewScoreRecord);
		base.GetItem(2).SetUIActive(this.Data.NewScoreRecord);
		base.GetItem(6).SetUIActive(false);
	}

	// Token: 0x0400385B RID: 14427
	[Nullable(1)]
	public CorniceChallengeEndNotify Data;

	// Token: 0x020077E1 RID: 30689
	private class EChildComponents
	{
		// Token: 0x0402784A RID: 161866
		public const int TxtScore = 0;

		// Token: 0x0402784B RID: 161867
		public const int TxtTime = 1;

		// Token: 0x0402784C RID: 161868
		public const int ScoreNewRecordItem = 2;

		// Token: 0x0402784D RID: 161869
		public const int TimeNewRecordItem = 3;

		// Token: 0x0402784E RID: 161870
		public const int ScorePanelItem = 4;

		// Token: 0x0402784F RID: 161871
		public const int TimePanelItem = 5;

		// Token: 0x04027850 RID: 161872
		public const int TxtFailTipsItem = 6;
	}
}
