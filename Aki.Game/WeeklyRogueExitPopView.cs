using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002D4B RID: 11595
public class WeeklyRogueExitPopView : UiViewBase
{
	// Token: 0x060185DB RID: 99803 RVA: 0x00634315 File Offset: 0x00632515
	[NullableContext(1)]
	public WeeklyRogueExitPopView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060185DC RID: 99804 RVA: 0x00634320 File Offset: 0x00632520
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

	// Token: 0x060185DD RID: 99805 RVA: 0x006343CC File Offset: 0x006325CC
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

	// Token: 0x060185DE RID: 99806 RVA: 0x006344CA File Offset: 0x006326CA
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

	// Token: 0x060185DF RID: 99807 RVA: 0x00634500 File Offset: 0x00632700
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

	// Token: 0x0400B4D3 RID: 46291
	[Nullable(2)]
	private ButtonItem ButtonItemSettle;

	// Token: 0x0400B4D4 RID: 46292
	[Nullable(2)]
	private ButtonItem ButtonItemExit;

	// Token: 0x020092DE RID: 37598
	private class EWeeklyRogueExitPopDefine
	{
		// Token: 0x0402F789 RID: 194441
		public const int TxtCurRoom = 0;

		// Token: 0x0402F78A RID: 194442
		public const int BtnSettle = 1;

		// Token: 0x0402F78B RID: 194443
		public const int BtnExit = 2;

		// Token: 0x0402F78C RID: 194444
		public const int TxtTips = 3;
	}
}
