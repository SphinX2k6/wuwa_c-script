using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001756 RID: 5974
public class MotorcycleTechTreeLevelDetailView : UiViewBase
{
	// Token: 0x0600E815 RID: 59413 RVA: 0x0043F954 File Offset: 0x0043DB54
	[NullableContext(1)]
	public MotorcycleTechTreeLevelDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E816 RID: 59414 RVA: 0x0043F960 File Offset: 0x0043DB60
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600E817 RID: 59415 RVA: 0x0043F9BC File Offset: 0x0043DBBC
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

	// Token: 0x0600E818 RID: 59416 RVA: 0x0043FA52 File Offset: 0x0043DC52
	protected override void OnBeforeDestroy()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.Destroy(null);
	}

	// Token: 0x0600E819 RID: 59417 RVA: 0x0043FA65 File Offset: 0x0043DC65
	[NullableContext(1)]
	private MotorcycleTechTreeListLevelItem InitItem()
	{
		return new MotorcycleTechTreeListLevelItem();
	}

	// Token: 0x0600E81A RID: 59418 RVA: 0x0043FA6C File Offset: 0x0043DC6C
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04008445 RID: 33861
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008446 RID: 33862
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleTechTreeListLevelItem, IMotorTechLevelPoint> LevelScrollList;

	// Token: 0x02007934 RID: 31028
	private class EMotorTechTreeLevelComponent
	{
		// Token: 0x0402748A RID: 160906
		public const int ItemCaption = 0;

		// Token: 0x0402748B RID: 160907
		public const int LevelContent = 1;

		// Token: 0x0402748C RID: 160908
		public const int ItemLevel = 2;
	}
}
