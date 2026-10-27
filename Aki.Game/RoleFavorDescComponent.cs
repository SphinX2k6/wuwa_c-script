using System;
using System.Collections.Generic;
using UnrealEngine;

// Token: 0x0200286C RID: 10348
public class RoleFavorDescComponent : RoleFavorViewComponentBase
{
	// Token: 0x060154D4 RID: 87252 RVA: 0x00561530 File Offset: 0x0055F730
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x060154D5 RID: 87253 RVA: 0x0056158C File Offset: 0x0055F78C
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

	// Token: 0x060154D6 RID: 87254 RVA: 0x005615F8 File Offset: 0x0055F7F8
	protected override void OnStart()
	{
		UUIText text = base.GetText(2);
		if (!TermExplanationController.Instance.IsUiTextRegistered(text))
		{
			TermExplanationController.Instance.RegisterTextHyperlink(text, ETermExplanationViewType.Side, ETermExplanationReportType.RoleInfo, ETermExplanationViewAttachDirection.Left, null, null, null, ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
		}
	}

	// Token: 0x060154D7 RID: 87255 RVA: 0x00561638 File Offset: 0x0055F838
	protected override void OnBeforeDestroy()
	{
		UUIText text = base.GetText(2);
		if (TermExplanationController.Instance.IsUiTextRegistered(text))
		{
			TermExplanationController.Instance.UnRegisterTextHyperlink(text);
		}
	}
}
