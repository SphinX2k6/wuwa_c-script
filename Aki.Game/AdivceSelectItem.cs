using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B7F RID: 2943
[NullableContext(1)]
[Nullable(0)]
public class AdivceSelectItem : UiPanelBase
{
	// Token: 0x06007A8F RID: 31375 RVA: 0x0025F778 File Offset: 0x0025D978
	public AdivceSelectItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007A90 RID: 31376 RVA: 0x0025F7A4 File Offset: 0x0025D9A4
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

	// Token: 0x06007A91 RID: 31377 RVA: 0x0025F814 File Offset: 0x0025DA14
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

	// Token: 0x06007A92 RID: 31378 RVA: 0x0025F83C File Offset: 0x0025DA3C
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

	// Token: 0x06007A93 RID: 31379 RVA: 0x0025F8CC File Offset: 0x0025DACC
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

	// Token: 0x06007A94 RID: 31380 RVA: 0x0025F98C File Offset: 0x0025DB8C
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

	// Token: 0x06007A95 RID: 31381 RVA: 0x0025F9F8 File Offset: 0x0025DBF8
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

	// Token: 0x04004BFC RID: 19452
	public const string SPRITEONE = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnOne.SP_AdviceBtnOne";

	// Token: 0x04004BFD RID: 19453
	public const string SPRITETWO = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnTwo.SP_AdviceBtnTwo";

	// Token: 0x04004BFE RID: 19454
	public const string SPRITETHREE = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnThree.SP_AdviceBtnThree";

	// Token: 0x04004BFF RID: 19455
	public const string SPRITEEXPRESSION = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnbiaoqing.SP_AdviceBtnbiaoqing";

	// Token: 0x04004C00 RID: 19456
	public const string SPRITECHANGE = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnHuan.SP_AdviceBtnHuan";

	// Token: 0x04004C01 RID: 19457
	public const string SPRITEADD = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnJia.SP_AdviceBtnJia";

	// Token: 0x04004C02 RID: 19458
	public const string SPRITEDECREASE = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnJian.SP_AdviceBtnJian";

	// Token: 0x04004C03 RID: 19459
	private readonly List<AdviceSelectBtnContentItem> AdviceSelectBtnContentItem = new List<AdviceSelectBtnContentItem>();

	// Token: 0x04004C04 RID: 19460
	private readonly List<AdviceSelectLineContentItem> AdviceSelectLineContentItem = new List<AdviceSelectLineContentItem>();

	// Token: 0x02006E21 RID: 28193
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04024124 RID: 147748
		public const int Scroller = 0;

		// Token: 0x04024125 RID: 147749
		public const int Content = 1;

		// Token: 0x04024126 RID: 147750
		public const int BtnItem = 2;

		// Token: 0x04024127 RID: 147751
		public const int LineItem = 3;
	}
}
