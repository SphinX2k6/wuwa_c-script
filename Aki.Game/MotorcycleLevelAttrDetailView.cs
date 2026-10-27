using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200226A RID: 8810
public class MotorcycleLevelAttrDetailView : UiViewBase
{
	// Token: 0x06011306 RID: 70406 RVA: 0x00430774 File Offset: 0x0042E974
	[NullableContext(1)]
	public MotorcycleLevelAttrDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011307 RID: 70407 RVA: 0x00430780 File Offset: 0x0042E980
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06011308 RID: 70408 RVA: 0x004307DC File Offset: 0x0042E9DC
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

	// Token: 0x06011309 RID: 70409 RVA: 0x00430885 File Offset: 0x0042EA85
	protected override void OnBeforeDestroy()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.Destroy(null);
	}

	// Token: 0x0601130A RID: 70410 RVA: 0x00430898 File Offset: 0x0042EA98
	[NullableContext(1)]
	private MotorcycleLevelAttrListScrollItem InitAttrItem()
	{
		return new MotorcycleLevelAttrListScrollItem();
	}

	// Token: 0x0601130B RID: 70411 RVA: 0x0043089F File Offset: 0x0042EA9F
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x040082D4 RID: 33492
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040082D5 RID: 33493
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleLevelAttrListScrollItem, IMotorLevelAttrData> AttrScrollList;

	// Token: 0x0200878F RID: 34703
	private class EAttributeView
	{
		// Token: 0x0402C0F4 RID: 180468
		public const int ItemCaption = 0;

		// Token: 0x0402C0F5 RID: 180469
		public const int AttributeContent = 1;

		// Token: 0x0402C0F6 RID: 180470
		public const int ItemAttribute = 2;
	}
}
