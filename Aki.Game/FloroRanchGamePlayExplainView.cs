using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001022 RID: 4130
public class FloroRanchGamePlayExplainView : UiViewBase
{
	// Token: 0x0600A426 RID: 42022 RVA: 0x003023D6 File Offset: 0x003005D6
	[NullableContext(1)]
	public FloroRanchGamePlayExplainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A427 RID: 42023 RVA: 0x003023E0 File Offset: 0x003005E0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnMaskBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnCloseBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A428 RID: 42024 RVA: 0x00302594 File Offset: 0x00300794
	protected override void OnBeforeShow()
	{
		FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		if (currentActivityData == null)
		{
			return;
		}
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		FloroRanchSubDungeonData floroRanchSubDungeonData = currentActivityData.GetFloroRanchSubDungeonData(subInstanceId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Farm_DungeonTarget", new <>z__ReadOnlyArray<object>(new object[]
		{
			floroRanchSubDungeonData.GetMaxStage(),
			floroRanchSubDungeonData.GetStageDay()
		}));
		FloroRanchTag? floroRanchTagConfig = FloroRanchConfig.Instance.GetFloroRanchTagConfig(floroRanchSubDungeonData.TagId);
		if (floroRanchTagConfig != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), floroRanchTagConfig.Value.Name, Array.Empty<object>());
		}
		if (currentActivityData.ActivityDataType == EFloroRanchActivityDataType.Normal)
		{
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetText(floroRanchSubDungeonData.FirstReward.ToString(), true);
			}
			UUIText text2 = base.GetText(5);
			if (text2 != null)
			{
				text2.SetText(floroRanchSubDungeonData.AgainReward.ToString(), true);
			}
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(floroRanchSubDungeonData.AgainReward != 0);
			}
		}
		base.GetItem(8).SetUIActive(currentActivityData.ActivityDataType == EFloroRanchActivityDataType.Normal);
	}

	// Token: 0x0600A429 RID: 42025 RVA: 0x003026BC File Offset: 0x003008BC
	protected override void OnStart()
	{
		this.RegisterTermExplanation();
	}

	// Token: 0x0600A42A RID: 42026 RVA: 0x003026C4 File Offset: 0x003008C4
	protected override void OnBeforeDestroy()
	{
		this.UnRegisterTermExplanation();
	}

	// Token: 0x0600A42B RID: 42027 RVA: 0x003026CC File Offset: 0x003008CC
	private void RegisterTermExplanation()
	{
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(6),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.FloroRanch,
			Style = new ETermExplanationViewStyle?(ETermExplanationViewStyle.FloroRanch)
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x0600A42C RID: 42028 RVA: 0x00302712 File Offset: 0x00300912
	private void UnRegisterTermExplanation()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(6));
	}

	// Token: 0x0600A42D RID: 42029 RVA: 0x00302725 File Offset: 0x00300925
	private void OnMaskBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600A42E RID: 42030 RVA: 0x0030272E File Offset: 0x0030092E
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0200724C RID: 29260
	private class EComponents
	{
		// Token: 0x04025308 RID: 152328
		public const int BtnMask = 0;

		// Token: 0x04025309 RID: 152329
		public const int BtnClose = 1;

		// Token: 0x0402530A RID: 152330
		public const int ItemCost = 2;

		// Token: 0x0402530B RID: 152331
		public const int TextTarget = 3;

		// Token: 0x0402530C RID: 152332
		public const int TextFirstReward = 4;

		// Token: 0x0402530D RID: 152333
		public const int TextAgainReward = 5;

		// Token: 0x0402530E RID: 152334
		public const int TextEnvironment = 6;

		// Token: 0x0402530F RID: 152335
		public const int ItemAgainRewardPanel = 7;

		// Token: 0x04025310 RID: 152336
		public const int RewardPanel = 8;
	}
}
