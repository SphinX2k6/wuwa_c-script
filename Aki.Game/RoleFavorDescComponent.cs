using System;
using System.Collections.Generic;
using UnrealEngine;

// Token: 0x02001DE7 RID: 7655
public class RoleFavorDescComponent : RoleFavorViewComponentBase
{
	// Token: 0x06012ED2 RID: 77522 RVA: 0x0058C28C File Offset: 0x0058A48C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06012ED3 RID: 77523 RVA: 0x0058C2E8 File Offset: 0x0058A4E8
	protected override void OnRefreshView()
	{
		if (this.ContentData == null)
		{
			return;
		}
		UUIText text = base.GetText(1);
		UUIText text2 = base.GetText(2);
		string title = this.ContentData.Title;
		string content = this.ContentData.Content;
		if (text != null)
		{
			text.SetText(title, true);
		}
		if (text2 != null)
		{
			text2.SetText(content, true);
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
		if (scrollViewWithScrollbar == null)
		{
			return;
		}
		scrollViewWithScrollbar.SetScrollProgress(0f);
	}

	// Token: 0x06012ED4 RID: 77524 RVA: 0x0058C354 File Offset: 0x0058A554
	protected override void OnStart()
	{
		UUIText text = base.GetText(2);
		if (!TermExplanationController.Instance.IsUiTextRegistered(text))
		{
			TermExplanationController.Instance.RegisterTextHyperlink(text, ETermExplanationViewType.Side, ETermExplanationReportType.RoleInfo, ETermExplanationViewAttachDirection.Left, null, null, null, ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
		}
	}

	// Token: 0x06012ED5 RID: 77525 RVA: 0x0058C394 File Offset: 0x0058A594
	protected override void OnBeforeDestroy()
	{
		UUIText text = base.GetText(2);
		if (TermExplanationController.Instance.IsUiTextRegistered(text))
		{
			TermExplanationController.Instance.UnRegisterTextHyperlink(text);
		}
	}
}
