using System;
using System.Collections.Generic;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000586 RID: 1414
public class AdvanceNoticeNewAreaTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x060043BA RID: 17338 RVA: 0x00175CB0 File Offset: 0x00173EB0
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

	// Token: 0x060043BB RID: 17339 RVA: 0x00175D38 File Offset: 0x00173F38
	protected override void RefreshView()
	{
		int currentSubTabId = this.ViewModel.CurrentSubTabId;
		AdvertisingTabRegion advertisingTabRegionById = AdvanceNoticeConfig.Instance.GetAdvertisingTabRegionById(currentSubTabId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), advertisingTabRegionById.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), advertisingTabRegionById.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), advertisingTabRegionById.Description, Array.Empty<object>());
		base.SetTextureWithPath(base.GetTexture(0), advertisingTabRegionById.MainPic);
	}

	// Token: 0x0200682B RID: 26667
	private class EComponentDefine
	{
		// Token: 0x04022568 RID: 140648
		public const int BgTexture = 0;

		// Token: 0x04022569 RID: 140649
		public const int SubTitleText = 1;

		// Token: 0x0402256A RID: 140650
		public const int TitleText = 2;

		// Token: 0x0402256B RID: 140651
		public const int DescText = 3;

		// Token: 0x0402256C RID: 140652
		public const int DescScrollView = 4;
	}
}
