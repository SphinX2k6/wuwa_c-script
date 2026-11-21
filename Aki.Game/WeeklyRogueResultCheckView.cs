using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022AD RID: 8877
public class WeeklyRogueResultCheckView : UiViewBase
{
	// Token: 0x06015EBC RID: 89788 RVA: 0x0065AFE9 File Offset: 0x006591E9
	[NullableContext(1)]
	public WeeklyRogueResultCheckView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06015EBD RID: 89789 RVA: 0x0065AFF4 File Offset: 0x006591F4
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

	// Token: 0x06015EBE RID: 89790 RVA: 0x0065B0A0 File Offset: 0x006592A0
	protected override void OnBeforeCreate()
	{
		WeeklyRogueResultCheckData weeklyRogueResultCheckData = this.OpenParam as WeeklyRogueResultCheckData;
		this.CurrentInGameScore = ((weeklyRogueResultCheckData != null) ? weeklyRogueResultCheckData.CurrentInGameScore : 0);
		this.MaxInGameScore = ((weeklyRogueResultCheckData != null) ? weeklyRogueResultCheckData.MaxInGameScore : 0);
	}

	// Token: 0x06015EBF RID: 89791 RVA: 0x0065B0E0 File Offset: 0x006592E0
	protected override void OnStart()
	{
		this.ButtonItemSettle = new ButtonItem(base.GetItem(1));
		this.ButtonItemExit = new ButtonItem(base.GetItem(2));
		this.ButtonItemSettle.SetFunction(new Action<int>(this.OnClickBtnSettle));
		this.ButtonItemExit.SetFunction(new Action<int>(this.OnClickBtnExit));
		this.ButtonItemSettle.SetLocalTextNew("WeRougeEndButtonBack", Array.Empty<object>());
		this.ButtonItemExit.SetLocalTextNew("WeRougeEndButtonQuit", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "WeRouge_ExitCopyPopup", new <>z__ReadOnlyArray<object>(new object[]
		{
			this.CurrentInGameScore,
			this.MaxInGameScore
		}));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "PrefabtextItem_Roguetuichu02_Text", Array.Empty<object>());
	}

	// Token: 0x06015EC0 RID: 89792 RVA: 0x0065B1C1 File Offset: 0x006593C1
	private void OnClickBtnSettle(int _)
	{
		base.CloseMe(null);
	}

	// Token: 0x06015EC1 RID: 89793 RVA: 0x0065B1CA File Offset: 0x006593CA
	private void OnClickBtnExit(int _)
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

	// Token: 0x0400B85C RID: 47196
	private int CurrentInGameScore;

	// Token: 0x0400B85D RID: 47197
	private int MaxInGameScore;

	// Token: 0x0400B85E RID: 47198
	[Nullable(2)]
	private ButtonItem ButtonItemSettle;

	// Token: 0x0400B85F RID: 47199
	[Nullable(2)]
	private ButtonItem ButtonItemExit;

	// Token: 0x0200850F RID: 34063
	private class EWeeklyRogueResultCheckDefine
	{
		// Token: 0x0402AE41 RID: 175681
		public const int TxtCurRoom = 0;

		// Token: 0x0402AE42 RID: 175682
		public const int BtnSettle = 1;

		// Token: 0x0402AE43 RID: 175683
		public const int BtnExit = 2;

		// Token: 0x0402AE44 RID: 175684
		public const int TxtTips = 3;
	}
}
