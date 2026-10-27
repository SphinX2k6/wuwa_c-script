using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B63 RID: 7011
public class FloroRanchGamePlayExplainView : UiViewBase
{
	// Token: 0x0600D015 RID: 53269 RVA: 0x002F72FE File Offset: 0x002F54FE
	[NullableContext(1)]
	public FloroRanchGamePlayExplainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D016 RID: 53270 RVA: 0x002F7308 File Offset: 0x002F5508
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

	// Token: 0x0600D017 RID: 53271 RVA: 0x002F74BC File Offset: 0x002F56BC
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

	// Token: 0x0600D018 RID: 53272 RVA: 0x002F75E4 File Offset: 0x002F57E4
	protected override void OnStart()
	{
		this.RegisterTermExplanation();
	}

	// Token: 0x0600D019 RID: 53273 RVA: 0x002F75EC File Offset: 0x002F57EC
	protected override void OnBeforeDestroy()
	{
		this.UnRegisterTermExplanation();
	}

	// Token: 0x0600D01A RID: 53274 RVA: 0x002F75F4 File Offset: 0x002F57F4
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

	// Token: 0x0600D01B RID: 53275 RVA: 0x002F763A File Offset: 0x002F583A
	private void UnRegisterTermExplanation()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(6));
	}

	// Token: 0x0600D01C RID: 53276 RVA: 0x002F764D File Offset: 0x002F584D
	private void OnMaskBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600D01D RID: 53277 RVA: 0x002F7656 File Offset: 0x002F5856
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x020080BE RID: 32958
	private class EComponents
	{
		// Token: 0x04029FD4 RID: 171988
		public const int BtnMask = 0;

		// Token: 0x04029FD5 RID: 171989
		public const int BtnClose = 1;

		// Token: 0x04029FD6 RID: 171990
		public const int ItemCost = 2;

		// Token: 0x04029FD7 RID: 171991
		public const int TextTarget = 3;

		// Token: 0x04029FD8 RID: 171992
		public const int TextFirstReward = 4;

		// Token: 0x04029FD9 RID: 171993
		public const int TextAgainReward = 5;

		// Token: 0x04029FDA RID: 171994
		public const int TextEnvironment = 6;

		// Token: 0x04029FDB RID: 171995
		public const int ItemAgainRewardPanel = 7;

		// Token: 0x04029FDC RID: 171996
		public const int RewardPanel = 8;
	}
}
