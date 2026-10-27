using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D9F RID: 7583
public class FlySettlementView : UiViewBase
{
	// Token: 0x0600E631 RID: 58929 RVA: 0x003640E3 File Offset: 0x003622E3
	[NullableContext(1)]
	public FlySettlementView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E632 RID: 58930 RVA: 0x003640F4 File Offset: 0x003622F4
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

	// Token: 0x0600E633 RID: 58931 RVA: 0x00364244 File Offset: 0x00362444
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

	// Token: 0x0600E634 RID: 58932 RVA: 0x00364317 File Offset: 0x00362517
	protected override void OnAfterDestroy()
	{
		this.OnCloseView(this.Result, this.IncId);
	}

	// Token: 0x0600E635 RID: 58933 RVA: 0x0036432B File Offset: 0x0036252B
	private void OnClickChallengeAgain()
	{
		this.Result = 1;
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x0600E636 RID: 58934 RVA: 0x0036434A File Offset: 0x0036254A
	private void OnClickConfirm()
	{
		this.Result = 0;
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x0600E637 RID: 58935 RVA: 0x00364369 File Offset: 0x00362569
	private void OnCloseView(int result, int incId)
	{
		GeneralLogicTreeController.Instance.OpenSystemBoardResultRequest(result, incId);
	}

	// Token: 0x04006A88 RID: 27272
	private int Result;

	// Token: 0x04006A89 RID: 27273
	private int IncId = -1;

	// Token: 0x0200837C RID: 33660
	private static class EViewComponent
	{
		// Token: 0x0402AD93 RID: 175507
		public const int ChallengeAgainBtn = 0;

		// Token: 0x0402AD94 RID: 175508
		public const int TexScore = 1;

		// Token: 0x0402AD95 RID: 175509
		public const int TxtNum = 2;

		// Token: 0x0402AD96 RID: 175510
		public const int ConfirmBtn = 3;

		// Token: 0x0402AD97 RID: 175511
		public const int NewRecordTexture = 4;

		// Token: 0x0402AD98 RID: 175512
		public const int NewRecordText = 5;
	}
}
