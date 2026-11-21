using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022A5 RID: 8869
public class WeeklyRogueExitPopView : UiViewBase
{
	// Token: 0x06015E7D RID: 89725 RVA: 0x0065A325 File Offset: 0x00658525
	[NullableContext(1)]
	public WeeklyRogueExitPopView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06015E7E RID: 89726 RVA: 0x0065A330 File Offset: 0x00658530
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06015E7F RID: 89727 RVA: 0x0065A3DC File Offset: 0x006585DC
	protected override void OnStart()
	{
		this.ButtonItemSettle = new ButtonItem(base.GetItem(1));
		this.ButtonItemExit = new ButtonItem(base.GetItem(2));
		this.ButtonItemSettle.SetFunction(new Action<int>(this.OnClickBtnSettle));
		this.ButtonItemExit.SetFunction(new Action<int>(this.OnClickBtnExit));
		this.ButtonItemSettle.SetLocalTextNew("WeeklyRogue_ExitTip_button1", Array.Empty<object>());
		this.ButtonItemExit.SetLocalTextNew("WeeklyRogue_ExitTip_button2", Array.Empty<object>());
		int currentLayer = WeeklyRogueModel.Instance.CurrentLayer;
		int maxLayer = WeeklyRogueModel.Instance.MaxLayer;
		int currentScore = WeeklyRogueModel.Instance.CurrentScore;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "WeeklyRogue_ExitTip_CurRoom", new <>z__ReadOnlyArray<object>(new object[]
		{
			currentLayer,
			maxLayer
		}));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "WeeklyRogue_ExitTip_Desc", new <>z__ReadOnlySingleElementList<object>(currentScore));
	}

	// Token: 0x06015E80 RID: 89728 RVA: 0x0065A4DA File Offset: 0x006586DA
	private void OnClickBtnSettle(int _)
	{
		UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool success)
		{
			WeeklyRogueController weeklyRogueController = ActivityManager.GetActivityController(ActivityType.RogueWeekly) as WeeklyRogueController;
			if (weeklyRogueController == null)
			{
				return;
			}
			weeklyRogueController.InstanceSettleRequest(null);
		});
	}

	// Token: 0x06015E81 RID: 89729 RVA: 0x0065A510 File Offset: 0x00658710
	private void OnClickBtnExit(int _)
	{
		WeeklyRogueController instance = WeeklyRogueController.Instance;
		if (instance != null)
		{
			instance.MarkAutoOpenDailyActivityWeekly();
		}
		UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool success)
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default);
		});
	}

	// Token: 0x0400B848 RID: 47176
	[Nullable(2)]
	private ButtonItem ButtonItemSettle;

	// Token: 0x0400B849 RID: 47177
	[Nullable(2)]
	private ButtonItem ButtonItemExit;

	// Token: 0x02008505 RID: 34053
	private class EWeeklyRogueExitPopDefine
	{
		// Token: 0x0402AE11 RID: 175633
		public const int TxtCurRoom = 0;

		// Token: 0x0402AE12 RID: 175634
		public const int BtnSettle = 1;

		// Token: 0x0402AE13 RID: 175635
		public const int BtnExit = 2;

		// Token: 0x0402AE14 RID: 175636
		public const int TxtTips = 3;
	}
}
