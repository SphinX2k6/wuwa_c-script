using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016C7 RID: 5831
[NullableContext(1)]
[Nullable(0)]
public class AdivceSelectItem : UiPanelBase
{
	// Token: 0x0600A6AF RID: 42671 RVA: 0x00255368 File Offset: 0x00253568
	public AdivceSelectItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A6B0 RID: 42672 RVA: 0x00255394 File Offset: 0x00253594
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600A6B1 RID: 42673 RVA: 0x00255404 File Offset: 0x00253604
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600A6B2 RID: 42674 RVA: 0x0025542C File Offset: 0x0025362C
	public void RefreshView(AdviceSelectItemData[] dataList)
	{
		this.ResetView();
		int num = 0;
		int num2 = 0;
		foreach (AdviceSelectItemData adviceSelectItemData in dataList)
		{
			if (adviceSelectItemData.GetIndex() != EAdviceSelectItemEnum.CutLine)
			{
				AdviceSelectBtnContentItem adviceSelectBtnItem = this.GetAdviceSelectBtnItem(num);
				adviceSelectBtnItem.GetRootItem().SetUIParent(base.GetScrollViewWithScrollbar(0).ContentUIItem, false);
				adviceSelectBtnItem.RefreshView(adviceSelectItemData);
				num++;
			}
			else
			{
				this.GetLineItem(num2).GetRootItem().SetUIParent(base.GetScrollViewWithScrollbar(0).ContentUIItem, false);
				num2++;
			}
		}
	}

	// Token: 0x0600A6B3 RID: 42675 RVA: 0x002554BC File Offset: 0x002536BC
	private void ResetView()
	{
		foreach (AdviceSelectBtnContentItem adviceSelectBtnContentItem in this.AdviceSelectBtnContentItem)
		{
			adviceSelectBtnContentItem.GetRootItem().SetUIActive(false);
			adviceSelectBtnContentItem.GetRootItem().SetUIParent(this.RootItem, false);
		}
		foreach (AdviceSelectLineContentItem adviceSelectLineContentItem in this.AdviceSelectLineContentItem)
		{
			adviceSelectLineContentItem.GetRootItem().SetUIActive(false);
			adviceSelectLineContentItem.GetRootItem().SetUIParent(this.RootItem, false);
		}
	}

	// Token: 0x0600A6B4 RID: 42676 RVA: 0x0025557C File Offset: 0x0025377C
	private AdviceSelectBtnContentItem GetAdviceSelectBtnItem(int index)
	{
		if (this.AdviceSelectBtnContentItem.Count > index)
		{
			this.AdviceSelectBtnContentItem[index].GetRootItem().SetUIActive(true);
			return this.AdviceSelectBtnContentItem[index];
		}
		UUIItem uuiitem = LguiUtil.Instance.CopyItem(base.GetItem(2), null);
		uuiitem.SetUIActive(true);
		AdviceSelectBtnContentItem adviceSelectBtnContentItem = new AdviceSelectBtnContentItem(uuiitem);
		this.AdviceSelectBtnContentItem.Add(adviceSelectBtnContentItem);
		return adviceSelectBtnContentItem;
	}

	// Token: 0x0600A6B5 RID: 42677 RVA: 0x002555E8 File Offset: 0x002537E8
	private AdviceSelectLineContentItem GetLineItem(int index)
	{
		if (this.AdviceSelectLineContentItem.Count > index)
		{
			this.AdviceSelectLineContentItem[index].GetRootItem().SetUIActive(true);
			return this.AdviceSelectLineContentItem[index];
		}
		UUIItem uuiitem = LguiUtil.Instance.CopyItem(base.GetItem(3), null);
		uuiitem.SetUIActive(true);
		AdviceSelectLineContentItem adviceSelectLineContentItem = new AdviceSelectLineContentItem(uuiitem);
		this.AdviceSelectLineContentItem.Add(adviceSelectLineContentItem);
		return adviceSelectLineContentItem;
	}

	// Token: 0x04004B55 RID: 19285
	public const string SPRITEONE = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnOne.SP_AdviceBtnOne";

	// Token: 0x04004B56 RID: 19286
	public const string SPRITETWO = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnTwo.SP_AdviceBtnTwo";

	// Token: 0x04004B57 RID: 19287
	public const string SPRITETHREE = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnThree.SP_AdviceBtnThree";

	// Token: 0x04004B58 RID: 19288
	public const string SPRITEEXPRESSION = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnbiaoqing.SP_AdviceBtnbiaoqing";

	// Token: 0x04004B59 RID: 19289
	public const string SPRITECHANGE = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnHuan.SP_AdviceBtnHuan";

	// Token: 0x04004B5A RID: 19290
	public const string SPRITEADD = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnJia.SP_AdviceBtnJia";

	// Token: 0x04004B5B RID: 19291
	public const string SPRITEDECREASE = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnJian.SP_AdviceBtnJian";

	// Token: 0x04004B5C RID: 19292
	private readonly List<AdviceSelectBtnContentItem> AdviceSelectBtnContentItem = new List<AdviceSelectBtnContentItem>();

	// Token: 0x04004B5D RID: 19293
	private readonly List<AdviceSelectLineContentItem> AdviceSelectLineContentItem = new List<AdviceSelectLineContentItem>();

	// Token: 0x02007C9C RID: 31900
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04028DFB RID: 167419
		public const int Scroller = 0;

		// Token: 0x04028DFC RID: 167420
		public const int Content = 1;

		// Token: 0x04028DFD RID: 167421
		public const int BtnItem = 2;

		// Token: 0x04028DFE RID: 167422
		public const int LineItem = 3;
	}
}
