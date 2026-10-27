using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BA2 RID: 7074
public class FloroRanchTechDetailPanel : UiPanelBase
{
	// Token: 0x0600D2A0 RID: 53920 RVA: 0x003066A4 File Offset: 0x003048A4
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

	// Token: 0x0600D2A1 RID: 53921 RVA: 0x00306818 File Offset: 0x00304A18
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

	// Token: 0x0600D2A2 RID: 53922 RVA: 0x0030689F File Offset: 0x00304A9F
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(2));
	}

	// Token: 0x0600D2A3 RID: 53923 RVA: 0x003068B4 File Offset: 0x00304AB4
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

	// Token: 0x0600D2A4 RID: 53924 RVA: 0x00306A4C File Offset: 0x00304C4C
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

	// Token: 0x0400608D RID: 24717
	[Nullable(2)]
	public FloroRanchTechnologyData Data;

	// Token: 0x0400608E RID: 24718
	[Nullable(2)]
	private ButtonItem UnlockBtn;

	// Token: 0x0400608F RID: 24719
	[Nullable(1)]
	public Action<string> UnlockSuccessCallback = delegate(string textId)
	{
	};

	// Token: 0x0200813E RID: 33086
	private class EComponents
	{
		// Token: 0x0402A2FA RID: 172794
		public const int TxtName = 0;

		// Token: 0x0402A2FB RID: 172795
		public const int SpriteIcon = 1;

		// Token: 0x0402A2FC RID: 172796
		public const int TxtDesc = 2;

		// Token: 0x0402A2FD RID: 172797
		public const int TxtCost = 3;

		// Token: 0x0402A2FE RID: 172798
		public const int ItemUnlockBtn = 4;

		// Token: 0x0402A2FF RID: 172799
		public const int ItemUnlockPanel = 5;

		// Token: 0x0402A300 RID: 172800
		public const int ItemLockPanel = 6;

		// Token: 0x0402A301 RID: 172801
		public const int PanelCost = 7;

		// Token: 0x0402A302 RID: 172802
		public const int SpriteIconBg = 8;

		// Token: 0x0402A303 RID: 172803
		public const int SpriteIconBgLock = 9;
	}
}
