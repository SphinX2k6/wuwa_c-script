using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002D53 RID: 11603
public class WeeklyRogueResultCheckView : UiViewBase
{
	// Token: 0x0601861A RID: 99866 RVA: 0x00634FD9 File Offset: 0x006331D9
	[NullableContext(1)]
	public WeeklyRogueResultCheckView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0601861B RID: 99867 RVA: 0x00634FE4 File Offset: 0x006331E4
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

	// Token: 0x0601861C RID: 99868 RVA: 0x00635090 File Offset: 0x00633290
	protected override void OnBeforeCreate()
	{
		WeeklyRogueResultCheckData weeklyRogueResultCheckData = this.OpenParam as WeeklyRogueResultCheckData;
		this.CurrentInGameScore = ((weeklyRogueResultCheckData != null) ? weeklyRogueResultCheckData.CurrentInGameScore : 0);
		this.MaxInGameScore = ((weeklyRogueResultCheckData != null) ? weeklyRogueResultCheckData.MaxInGameScore : 0);
	}

	// Token: 0x0601861D RID: 99869 RVA: 0x006350D0 File Offset: 0x006332D0
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

	// Token: 0x0601861E RID: 99870 RVA: 0x006351B1 File Offset: 0x006333B1
	private void OnClickBtnSettle(int _)
	{
		base.CloseMe(null);
	}

	// Token: 0x0601861F RID: 99871 RVA: 0x006351BA File Offset: 0x006333BA
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

	// Token: 0x0400B4E7 RID: 46311
	private int CurrentInGameScore;

	// Token: 0x0400B4E8 RID: 46312
	private int MaxInGameScore;

	// Token: 0x0400B4E9 RID: 46313
	[Nullable(2)]
	private ButtonItem ButtonItemSettle;

	// Token: 0x0400B4EA RID: 46314
	[Nullable(2)]
	private ButtonItem ButtonItemExit;

	// Token: 0x020092E8 RID: 37608
	private class EWeeklyRogueResultCheckDefine
	{
		// Token: 0x0402F7B9 RID: 194489
		public const int TxtCurRoom = 0;

		// Token: 0x0402F7BA RID: 194490
		public const int BtnSettle = 1;

		// Token: 0x0402F7BB RID: 194491
		public const int BtnExit = 2;

		// Token: 0x0402F7BC RID: 194492
		public const int TxtTips = 3;
	}
}
