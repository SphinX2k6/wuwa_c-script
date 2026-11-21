using System;
using System.Collections.Generic;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000589 RID: 1417
public class AdvanceNoticeNewJourneyTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x060043C9 RID: 17353 RVA: 0x00176590 File Offset: 0x00174790
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent))
		};
	}

	// Token: 0x060043CA RID: 17354 RVA: 0x00176618 File Offset: 0x00174818
	protected override void RefreshView()
	{
		int currentSubTabId = this.ViewModel.CurrentSubTabId;
		AdvertisingTabStory advertisingTabStoryById = AdvanceNoticeConfig.Instance.GetAdvertisingTabStoryById(currentSubTabId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), advertisingTabStoryById.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), advertisingTabStoryById.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), advertisingTabStoryById.Description, Array.Empty<object>());
		base.SetTextureWithPath(base.GetTexture(0), advertisingTabStoryById.MainPic);
		base.GetScrollViewWithScrollbar(4).SetScrollProgress(0f);
	}

	// Token: 0x0200682E RID: 26670
	private class EComponentDefine
	{
		// Token: 0x04022586 RID: 140678
		public const int BgTexture = 0;

		// Token: 0x04022587 RID: 140679
		public const int SubTitleText = 1;

		// Token: 0x04022588 RID: 140680
		public const int TitleText = 2;

		// Token: 0x04022589 RID: 140681
		public const int DescText = 3;

		// Token: 0x0402258A RID: 140682
		public const int DescScrollView = 4;
	}
}
