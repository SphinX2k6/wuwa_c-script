using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022CE RID: 8910
public class MotorRaceSettlementView : UiViewBase
{
	// Token: 0x060117EF RID: 71663 RVA: 0x0044A49F File Offset: 0x0044869F
	[NullableContext(1)]
	public MotorRaceSettlementView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060117F0 RID: 71664 RVA: 0x0044A4B0 File Offset: 0x004486B0
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

	// Token: 0x060117F1 RID: 71665 RVA: 0x0044A63C File Offset: 0x0044883C
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

	// Token: 0x060117F2 RID: 71666 RVA: 0x0044A780 File Offset: 0x00448980
	protected override void OnAfterDestroy()
	{
		this.OnCloseView(this.Result, this.IncId);
	}

	// Token: 0x060117F3 RID: 71667 RVA: 0x0044A794 File Offset: 0x00448994
	private void OnReChallengeBtnClick()
	{
		this.Result = 1;
		base.CloseMe(null);
	}

	// Token: 0x060117F4 RID: 71668 RVA: 0x0044A7A4 File Offset: 0x004489A4
	private void OnExitBtnClick()
	{
		this.Result = 0;
		base.CloseMe(null);
	}

	// Token: 0x060117F5 RID: 71669 RVA: 0x0044A7B4 File Offset: 0x004489B4
	private void OnCloseView(int result, int incId)
	{
		GeneralLogicTreeController.Instance.OpenSystemBoardResultRequest(result, incId);
	}

	// Token: 0x040084D2 RID: 34002
	private int Result;

	// Token: 0x040084D3 RID: 34003
	private int IncId = -1;

	// Token: 0x0200884A RID: 34890
	private class EComponents
	{
		// Token: 0x0402C486 RID: 181382
		public const int ItemFirstBg = 0;

		// Token: 0x0402C487 RID: 181383
		public const int ItemSecondBg = 1;

		// Token: 0x0402C488 RID: 181384
		public const int ItemThirdBg = 2;

		// Token: 0x0402C489 RID: 181385
		public const int BtnReChallenge = 3;

		// Token: 0x0402C48A RID: 181386
		public const int BtnExit = 4;

		// Token: 0x0402C48B RID: 181387
		public const int ItemFirstNum = 5;

		// Token: 0x0402C48C RID: 181388
		public const int ItemSecondNum = 6;

		// Token: 0x0402C48D RID: 181389
		public const int ItemThirdNum = 7;

		// Token: 0x0402C48E RID: 181390
		public const int TextMyScore = 8;

		// Token: 0x0402C48F RID: 181391
		public const int ItemNewRecord = 9;

		// Token: 0x0402C490 RID: 181392
		public const int TextBestRecordTime = 10;

		// Token: 0x0402C491 RID: 181393
		public const int TextFirstScore = 11;

		// Token: 0x0402C492 RID: 181394
		public const int TextSecondScore = 12;

		// Token: 0x0402C493 RID: 181395
		public const int TextThirdTimeScore = 13;
	}
}
