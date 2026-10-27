using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002B35 RID: 11061
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsAttributeDetailView : UiViewBase
{
	// Token: 0x06016F4E RID: 94030 RVA: 0x005D3849 File Offset: 0x005D1A49
	public SurvivorsAttributeDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016F4F RID: 94031 RVA: 0x005D3854 File Offset: 0x005D1A54
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06016F50 RID: 94032 RVA: 0x005D38B0 File Offset: 0x005D1AB0
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

	// Token: 0x06016F51 RID: 94033 RVA: 0x005D3942 File Offset: 0x005D1B42
	protected override void OnBeforeDestroy()
	{
		this.CaptionItem.Destroy(null);
		if (this.AttrScrollList != null)
		{
			this.AttrScrollList = null;
		}
	}

	// Token: 0x06016F52 RID: 94034 RVA: 0x005D395F File Offset: 0x005D1B5F
	private SurvivorsRoleAttributeItem InitAttrItem()
	{
		return new SurvivorsRoleAttributeItem();
	}

	// Token: 0x06016F53 RID: 94035 RVA: 0x005D3966 File Offset: 0x005D1B66
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400AAF0 RID: 43760
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400AAF1 RID: 43761
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<SurvivorsRoleAttributeItem, ISurvivorsAttributeUiData> AttrScrollList;
}
