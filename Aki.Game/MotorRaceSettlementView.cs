using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017B2 RID: 6066
public class MotorRaceSettlementView : UiViewBase
{
	// Token: 0x0600EC86 RID: 60550 RVA: 0x004571C7 File Offset: 0x004553C7
	[NullableContext(1)]
	public MotorRaceSettlementView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EC87 RID: 60551 RVA: 0x004571D8 File Offset: 0x004553D8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnReChallengeBtnClick)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnExitBtnClick))
		};
	}

	// Token: 0x0600EC88 RID: 60552 RVA: 0x00457364 File Offset: 0x00455564
	protected override void OnBeforeShow()
	{
		MotorSettlementViewParams motorSettlementViewParams = this.OpenParam as MotorSettlementViewParams;
		this.IncId = (int)motorSettlementViewParams.IncId;
		ELevel elevel = ELevel.B;
		if (motorSettlementViewParams.Score >= motorSettlementViewParams.RankS)
		{
			elevel = ELevel.S;
			AudioSystem.Instance.PostEvent("play_ui_moto_parkour_settlement_level_s");
		}
		else if (motorSettlementViewParams.Score >= motorSettlementViewParams.RankB)
		{
			elevel = ELevel.A;
			AudioSystem.Instance.PostEvent("play_ui_moto_parkour_settlement_level_a");
		}
		else
		{
			AudioSystem.Instance.PostEvent("play_ui_moto_parkour_settlement_level_others");
		}
		base.GetItem(0).SetUIActive(elevel == ELevel.S);
		base.GetItem(1).SetUIActive(elevel == ELevel.A);
		base.GetItem(2).SetUIActive(elevel == ELevel.B);
		base.GetItem(5).SetUIActive(elevel == ELevel.S);
		base.GetItem(6).SetUIActive(elevel == ELevel.A);
		base.GetItem(7).SetUIActive(elevel == ELevel.B);
		base.GetText(11).SetText(motorSettlementViewParams.RankS.ToString(), true);
		base.GetText(12).SetText(motorSettlementViewParams.RankA.ToString(), true);
		base.GetText(13).SetText(motorSettlementViewParams.RankB.ToString(), true);
		UUIText text = base.GetText(8);
		if (text == null)
		{
			return;
		}
		text.SetText(motorSettlementViewParams.Score.ToString(), true);
	}

	// Token: 0x0600EC89 RID: 60553 RVA: 0x004574A8 File Offset: 0x004556A8
	protected override void OnAfterDestroy()
	{
		this.OnCloseView(this.Result, this.IncId);
	}

	// Token: 0x0600EC8A RID: 60554 RVA: 0x004574BC File Offset: 0x004556BC
	private void OnReChallengeBtnClick()
	{
		this.Result = 1;
		base.CloseMe(null);
	}

	// Token: 0x0600EC8B RID: 60555 RVA: 0x004574CC File Offset: 0x004556CC
	private void OnExitBtnClick()
	{
		this.Result = 0;
		base.CloseMe(null);
	}

	// Token: 0x0600EC8C RID: 60556 RVA: 0x004574DC File Offset: 0x004556DC
	private void OnCloseView(int result, int incId)
	{
		GeneralLogicTreeController.Instance.OpenSystemBoardResultRequest(result, incId);
	}

	// Token: 0x04008610 RID: 34320
	private int Result;

	// Token: 0x04008611 RID: 34321
	private int IncId = -1;

	// Token: 0x020079CE RID: 31182
	private class EComponents
	{
		// Token: 0x04027788 RID: 161672
		public const int ItemFirstBg = 0;

		// Token: 0x04027789 RID: 161673
		public const int ItemSecondBg = 1;

		// Token: 0x0402778A RID: 161674
		public const int ItemThirdBg = 2;

		// Token: 0x0402778B RID: 161675
		public const int BtnReChallenge = 3;

		// Token: 0x0402778C RID: 161676
		public const int BtnExit = 4;

		// Token: 0x0402778D RID: 161677
		public const int ItemFirstNum = 5;

		// Token: 0x0402778E RID: 161678
		public const int ItemSecondNum = 6;

		// Token: 0x0402778F RID: 161679
		public const int ItemThirdNum = 7;

		// Token: 0x04027790 RID: 161680
		public const int TextMyScore = 8;

		// Token: 0x04027791 RID: 161681
		public const int ItemNewRecord = 9;

		// Token: 0x04027792 RID: 161682
		public const int TextBestRecordTime = 10;

		// Token: 0x04027793 RID: 161683
		public const int TextFirstScore = 11;

		// Token: 0x04027794 RID: 161684
		public const int TextSecondScore = 12;

		// Token: 0x04027795 RID: 161685
		public const int TextThirdTimeScore = 13;
	}
}
