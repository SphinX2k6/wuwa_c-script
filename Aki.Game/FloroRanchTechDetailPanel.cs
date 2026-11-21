using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001061 RID: 4193
public class FloroRanchTechDetailPanel : UiPanelBase
{
	// Token: 0x0600A6B1 RID: 42673 RVA: 0x00311784 File Offset: 0x0030F984
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A6B2 RID: 42674 RVA: 0x003118F8 File Offset: 0x0030FAF8
	protected override void OnStart()
	{
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(2),
			ViewType = ETermExplanationViewType.Side,
			AttachDirection = new ETermExplanationViewAttachDirection?(ETermExplanationViewAttachDirection.Left),
			AttachItem = base.GetRootItem(),
			Style = new ETermExplanationViewStyle?(ETermExplanationViewStyle.FloroRanch),
			ReportType = ETermExplanationReportType.FloroRanch
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
		this.UnlockBtn = new ButtonItem(base.GetItem(4));
		this.UnlockBtn.SetFunction(new Action<int>(this.OnClickBtnUnlock));
	}

	// Token: 0x0600A6B3 RID: 42675 RVA: 0x0031197F File Offset: 0x0030FB7F
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(2));
	}

	// Token: 0x0600A6B4 RID: 42676 RVA: 0x00311994 File Offset: 0x0030FB94
	[NullableContext(1)]
	public void Refresh(FloroRanchTechnologyData data)
	{
		this.Data = data;
		this.SetSpriteByPath(data.Icon, base.GetSprite(1), false, null, null);
		UUISprite sprite = base.GetSprite(1);
		UUIItem uuiitem = sprite;
		bool bUseChangeColor = !data.IsUnLock;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Des, Array.Empty<object>());
		global::FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
		int technologyCoinNum = activityData.GetTechnologyCoinNum();
		UUIText text = base.GetText(3);
		text.SetText(data.Cost.ToString(), true);
		UUIItem uuiitem2 = text;
		bool bUseChangeColor2 = technologyCoinNum < data.Cost;
		fcolor = new FColor?(text.changeColor);
		uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
		base.GetItem(7).SetUIActive(!data.IsUnLock);
		bool flag = activityData.IsPreNodeAllUnlock(data);
		ButtonItem unlockBtn = this.UnlockBtn;
		if (unlockBtn != null)
		{
			unlockBtn.SetUiActive(!data.IsUnLock && flag);
		}
		ButtonItem unlockBtn2 = this.UnlockBtn;
		if (unlockBtn2 != null)
		{
			unlockBtn2.SetRedDotVisible(technologyCoinNum >= data.Cost && !data.IsUnLock && flag);
		}
		base.GetItem(6).SetUIActive(!flag);
		base.GetItem(5).SetUIActive(data.IsUnLock);
		UUISprite sprite2 = base.GetSprite(8);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(data.IsUnLock);
		}
		UUISprite sprite3 = base.GetSprite(9);
		if (sprite3 == null)
		{
			return;
		}
		sprite3.SetUIActive(!data.IsUnLock);
	}

	// Token: 0x0600A6B5 RID: 42677 RVA: 0x00311B2C File Offset: 0x0030FD2C
	private void OnClickBtnUnlock(int _)
	{
		if (FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true).GetTechnologyCoinNum() < this.Data.Cost)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_200003_Text", Array.Empty<object>());
			return;
		}
		FloroRanchController.Instance.RequestUnlockTechPoint(this.Data.Id, delegate(FloroRanchUnlockTechPointResponse response)
		{
			this.Refresh(this.Data);
			Action<string> unlockSuccessCallback = this.UnlockSuccessCallback;
			if (unlockSuccessCallback == null)
			{
				return;
			}
			unlockSuccessCallback(this.Data.Des);
		});
	}

	// Token: 0x0400615C RID: 24924
	[Nullable(2)]
	public FloroRanchTechnologyData Data;

	// Token: 0x0400615D RID: 24925
	[Nullable(2)]
	private ButtonItem UnlockBtn;

	// Token: 0x0400615E RID: 24926
	[Nullable(1)]
	public Action<string> UnlockSuccessCallback = delegate(string textId)
	{
	};

	// Token: 0x020072CC RID: 29388
	private class EComponents
	{
		// Token: 0x0402562E RID: 153134
		public const int TxtName = 0;

		// Token: 0x0402562F RID: 153135
		public const int SpriteIcon = 1;

		// Token: 0x04025630 RID: 153136
		public const int TxtDesc = 2;

		// Token: 0x04025631 RID: 153137
		public const int TxtCost = 3;

		// Token: 0x04025632 RID: 153138
		public const int ItemUnlockBtn = 4;

		// Token: 0x04025633 RID: 153139
		public const int ItemUnlockPanel = 5;

		// Token: 0x04025634 RID: 153140
		public const int ItemLockPanel = 6;

		// Token: 0x04025635 RID: 153141
		public const int PanelCost = 7;

		// Token: 0x04025636 RID: 153142
		public const int SpriteIconBg = 8;

		// Token: 0x04025637 RID: 153143
		public const int SpriteIconBgLock = 9;
	}
}
