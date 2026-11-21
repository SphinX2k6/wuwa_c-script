using System;
using System.Collections.Generic;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200058D RID: 1421
public class AdvanceNoticeNewSystemOptimizeTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x060043DC RID: 17372 RVA: 0x00176DC4 File Offset: 0x00174FC4
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

	// Token: 0x060043DD RID: 17373 RVA: 0x00176E4C File Offset: 0x0017504C
	protected override void RefreshView()
	{
		int currentSubTabId = this.ViewModel.CurrentSubTabId;
		AdvertisingTabSystem advertisingTabSystemById = AdvanceNoticeConfig.Instance.GetAdvertisingTabSystemById(currentSubTabId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), advertisingTabSystemById.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), advertisingTabSystemById.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), advertisingTabSystemById.Description, Array.Empty<object>());
		base.SetTextureWithPath(base.GetTexture(0), advertisingTabSystemById.MainPic);
		base.GetScrollViewWithScrollbar(4).SetScrollProgress(0f);
	}

	// Token: 0x02006834 RID: 26676
	private class EComponentDefine
	{
		// Token: 0x040225B0 RID: 140720
		public const int BgTexture = 0;

		// Token: 0x040225B1 RID: 140721
		public const int SubTitleText = 1;

		// Token: 0x040225B2 RID: 140722
		public const int TitleText = 2;

		// Token: 0x040225B3 RID: 140723
		public const int DescText = 3;

		// Token: 0x040225B4 RID: 140724
		public const int DescScrollView = 4;
	}
}
