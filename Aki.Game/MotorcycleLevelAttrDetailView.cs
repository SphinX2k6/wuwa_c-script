using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200174E RID: 5966
public class MotorcycleLevelAttrDetailView : UiViewBase
{
	// Token: 0x0600E79C RID: 59292 RVA: 0x0043D380 File Offset: 0x0043B580
	[NullableContext(1)]
	public MotorcycleLevelAttrDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E79D RID: 59293 RVA: 0x0043D38C File Offset: 0x0043B58C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600E79E RID: 59294 RVA: 0x0043D3E8 File Offset: 0x0043B5E8
	protected override void OnStart()
	{
		string stringConfig = ConfigCommonParamById.GetStringConfig("MotorAttributeIcon");
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnBackButtonClick));
		this.CaptionItem.SetTitleLocalText("PrefabTextItem_1302715335_Text");
		if (!string.IsNullOrEmpty(stringConfig))
		{
			this.CaptionItem.SetTitleIcon(stringConfig);
		}
		this.AttrScrollList = new GenericScrollViewNew<MotorcycleLevelAttrListScrollItem, IMotorLevelAttrData>(base.GetScrollViewWithScrollbar(1), new Func<MotorcycleLevelAttrListScrollItem>(this.InitAttrItem), null, false, null);
		List<IMotorLevelAttrData> list = this.OpenParam as List<IMotorLevelAttrData>;
		this.AttrScrollList.RefreshByData(list ?? new List<IMotorLevelAttrData>(), null, false);
	}

	// Token: 0x0600E79F RID: 59295 RVA: 0x0043D491 File Offset: 0x0043B691
	protected override void OnBeforeDestroy()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.Destroy(null);
	}

	// Token: 0x0600E7A0 RID: 59296 RVA: 0x0043D4A4 File Offset: 0x0043B6A4
	[NullableContext(1)]
	private MotorcycleLevelAttrListScrollItem InitAttrItem()
	{
		return new MotorcycleLevelAttrListScrollItem();
	}

	// Token: 0x0600E7A1 RID: 59297 RVA: 0x0043D4AB File Offset: 0x0043B6AB
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04008412 RID: 33810
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008413 RID: 33811
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleLevelAttrListScrollItem, IMotorLevelAttrData> AttrScrollList;

	// Token: 0x02007918 RID: 31000
	private class EAttributeView
	{
		// Token: 0x0402740C RID: 160780
		public const int ItemCaption = 0;

		// Token: 0x0402740D RID: 160781
		public const int AttributeContent = 1;

		// Token: 0x0402740E RID: 160782
		public const int ItemAttribute = 2;
	}
}
