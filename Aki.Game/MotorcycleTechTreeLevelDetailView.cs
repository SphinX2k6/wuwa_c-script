using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002272 RID: 8818
public class MotorcycleTechTreeLevelDetailView : UiViewBase
{
	// Token: 0x0601137F RID: 70527 RVA: 0x00432D48 File Offset: 0x00430F48
	[NullableContext(1)]
	public MotorcycleTechTreeLevelDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011380 RID: 70528 RVA: 0x00432D54 File Offset: 0x00430F54
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06011381 RID: 70529 RVA: 0x00432DB0 File Offset: 0x00430FB0
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnBackButtonClick));
		this.CaptionItem.SetTitleLocalText("MotorBike_TechTree_TechLevelDetail");
		this.CaptionItem.SetHelpBtnActive(false);
		this.LevelScrollList = new GenericScrollViewNew<MotorcycleTechTreeListLevelItem, IMotorTechLevelPoint>(base.GetScrollViewWithScrollbar(1), new Func<MotorcycleTechTreeListLevelItem>(this.InitItem), null, false, null);
		List<IMotorTechLevelPoint> list = this.OpenParam as List<IMotorTechLevelPoint>;
		this.LevelScrollList.RefreshByData(list ?? new List<IMotorTechLevelPoint>(), null, false);
	}

	// Token: 0x06011382 RID: 70530 RVA: 0x00432E46 File Offset: 0x00431046
	protected override void OnBeforeDestroy()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.Destroy(null);
	}

	// Token: 0x06011383 RID: 70531 RVA: 0x00432E59 File Offset: 0x00431059
	[NullableContext(1)]
	private MotorcycleTechTreeListLevelItem InitItem()
	{
		return new MotorcycleTechTreeListLevelItem();
	}

	// Token: 0x06011384 RID: 70532 RVA: 0x00432E60 File Offset: 0x00431060
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04008307 RID: 33543
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008308 RID: 33544
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleTechTreeListLevelItem, IMotorTechLevelPoint> LevelScrollList;

	// Token: 0x020087AB RID: 34731
	private class EMotorTechTreeLevelComponent
	{
		// Token: 0x0402C172 RID: 180594
		public const int ItemCaption = 0;

		// Token: 0x0402C173 RID: 180595
		public const int LevelContent = 1;

		// Token: 0x0402C174 RID: 180596
		public const int ItemLevel = 2;
	}
}
