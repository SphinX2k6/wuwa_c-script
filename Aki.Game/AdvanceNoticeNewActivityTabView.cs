using System;
using System.Collections.Generic;
using Aki.Config;
using UnrealEngine;

// Token: 0x020010D1 RID: 4305
public class AdvanceNoticeNewActivityTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x06007021 RID: 28705 RVA: 0x0016D1C0 File Offset: 0x0016B3C0
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

	// Token: 0x06007022 RID: 28706 RVA: 0x0016D248 File Offset: 0x0016B448
	protected override void RefreshView()
	{
		int currentSubTabId = this.ViewModel.CurrentSubTabId;
		AdvertisingTabActivity advertisingTabActivityById = AdvanceNoticeConfig.Instance.GetAdvertisingTabActivityById(currentSubTabId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), advertisingTabActivityById.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), advertisingTabActivityById.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), advertisingTabActivityById.Description, Array.Empty<object>());
		base.SetTextureWithPath(base.GetTexture(0), advertisingTabActivityById.MainPic);
		base.GetScrollViewWithScrollbar(4).SetScrollProgress(0f);
	}

	// Token: 0x02007696 RID: 30358
	private class EComponentDefine
	{
		// Token: 0x0402721A RID: 160282
		public const int BgTexture = 0;

		// Token: 0x0402721B RID: 160283
		public const int SubTitleText = 1;

		// Token: 0x0402721C RID: 160284
		public const int TitleText = 2;

		// Token: 0x0402721D RID: 160285
		public const int DescText = 3;

		// Token: 0x0402721E RID: 160286
		public const int DescScrollView = 4;
	}
}
