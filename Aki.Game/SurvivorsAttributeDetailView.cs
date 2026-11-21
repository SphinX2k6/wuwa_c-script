using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020020B1 RID: 8369
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsAttributeDetailView : UiViewBase
{
	// Token: 0x0601497F RID: 84351 RVA: 0x006003B9 File Offset: 0x005FE5B9
	public SurvivorsAttributeDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014980 RID: 84352 RVA: 0x006003C4 File Offset: 0x005FE5C4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06014981 RID: 84353 RVA: 0x00600420 File Offset: 0x005FE620
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnBackButtonClick));
		this.CaptionItem.SetTitleLocalText("PrefabTextItem_1302715335_Text");
		List<ISurvivorsAttributeUiData> data = this.OpenParam as List<ISurvivorsAttributeUiData>;
		this.AttrScrollList = new GenericScrollViewNew<SurvivorsRoleAttributeItem, ISurvivorsAttributeUiData>(base.GetScrollViewWithScrollbar(1), new Func<SurvivorsRoleAttributeItem>(this.InitAttrItem), null, false, null);
		this.AttrScrollList.RefreshByData(data, null, false);
		EventSystem.Instance.Emit<bool>(EEventName.AttributeComponentEvent, true);
	}

	// Token: 0x06014982 RID: 84354 RVA: 0x006004B2 File Offset: 0x005FE6B2
	protected override void OnBeforeDestroy()
	{
		this.CaptionItem.Destroy(null);
		if (this.AttrScrollList != null)
		{
			this.AttrScrollList = null;
		}
	}

	// Token: 0x06014983 RID: 84355 RVA: 0x006004CF File Offset: 0x005FE6CF
	private SurvivorsRoleAttributeItem InitAttrItem()
	{
		return new SurvivorsRoleAttributeItem();
	}

	// Token: 0x06014984 RID: 84356 RVA: 0x006004D6 File Offset: 0x005FE6D6
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400AEF6 RID: 44790
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400AEF7 RID: 44791
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<SurvivorsRoleAttributeItem, ISurvivorsAttributeUiData> AttrScrollList;
}
