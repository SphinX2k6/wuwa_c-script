using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001261 RID: 4705
public class FlySettlementView : UiViewBase
{
	// Token: 0x0600BA4F RID: 47695 RVA: 0x0036FD43 File Offset: 0x0036DF43
	[NullableContext(1)]
	public FlySettlementView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BA50 RID: 47696 RVA: 0x0036FD54 File Offset: 0x0036DF54
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickChallengeAgain));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirm));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600BA51 RID: 47697 RVA: 0x0036FEA4 File Offset: 0x0036E0A4
	protected override void OnStart()
	{
		FlySettlementViewParams flySettlementViewParams = this.OpenParam as FlySettlementViewParams;
		this.IncId = flySettlementViewParams.IncId;
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetText(flySettlementViewParams.Score.ToString(), true);
		}
		string resourceId;
		if (flySettlementViewParams.Score >= flySettlementViewParams.RankS)
		{
			resourceId = "T_FlyScoreS";
		}
		else if (flySettlementViewParams.Score >= flySettlementViewParams.RankA)
		{
			resourceId = "T_FlyScoreA";
		}
		else
		{
			resourceId = "T_FlyScoreB";
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		UUITexture texture = base.GetTexture(1);
		base.SetTextureByPath(resourcePath, texture, null, null);
		bool uiactive = flySettlementViewParams.Score > flySettlementViewParams.BestRecordScore;
		UUITexture texture2 = base.GetTexture(4);
		if (texture2 != null)
		{
			texture2.SetUIActive(uiactive);
		}
		UUIText text2 = base.GetText(5);
		if (text2 == null)
		{
			return;
		}
		text2.SetUIActive(uiactive);
	}

	// Token: 0x0600BA52 RID: 47698 RVA: 0x0036FF77 File Offset: 0x0036E177
	protected override void OnAfterDestroy()
	{
		this.OnCloseView(this.Result, this.IncId);
	}

	// Token: 0x0600BA53 RID: 47699 RVA: 0x0036FF8B File Offset: 0x0036E18B
	private void OnClickChallengeAgain()
	{
		this.Result = 1;
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x0600BA54 RID: 47700 RVA: 0x0036FFAA File Offset: 0x0036E1AA
	private void OnClickConfirm()
	{
		this.Result = 0;
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x0600BA55 RID: 47701 RVA: 0x0036FFC9 File Offset: 0x0036E1C9
	private void OnCloseView(int result, int incId)
	{
		GeneralLogicTreeController.Instance.OpenSystemBoardResultRequest(result, incId);
	}

	// Token: 0x04006B69 RID: 27497
	private int Result;

	// Token: 0x04006B6A RID: 27498
	private int IncId = -1;

	// Token: 0x02007504 RID: 29956
	private static class EViewComponent
	{
		// Token: 0x040260B9 RID: 155833
		public const int ChallengeAgainBtn = 0;

		// Token: 0x040260BA RID: 155834
		public const int TexScore = 1;

		// Token: 0x040260BB RID: 155835
		public const int TxtNum = 2;

		// Token: 0x040260BC RID: 155836
		public const int ConfirmBtn = 3;

		// Token: 0x040260BD RID: 155837
		public const int NewRecordTexture = 4;

		// Token: 0x040260BE RID: 155838
		public const int NewRecordText = 5;
	}
}
