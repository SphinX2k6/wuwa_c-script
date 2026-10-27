using System;
using System.Collections.Generic;
using Aki.Config;
using UnrealEngine;

// Token: 0x020010D2 RID: 4306
public class AdvanceNoticeNewAreaTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x06007024 RID: 28708 RVA: 0x0016D2F4 File Offset: 0x0016B4F4
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

	// Token: 0x06007025 RID: 28709 RVA: 0x0016D37C File Offset: 0x0016B57C
	protected override void RefreshView()
	{
		int currentSubTabId = this.ViewModel.CurrentSubTabId;
		AdvertisingTabRegion advertisingTabRegionById = AdvanceNoticeConfig.Instance.GetAdvertisingTabRegionById(currentSubTabId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), advertisingTabRegionById.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), advertisingTabRegionById.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), advertisingTabRegionById.Description, Array.Empty<object>());
		base.SetTextureWithPath(base.GetTexture(0), advertisingTabRegionById.MainPic);
	}

	// Token: 0x02007697 RID: 30359
	private class EComponentDefine
	{
		// Token: 0x0402721F RID: 160287
		public const int BgTexture = 0;

		// Token: 0x04027220 RID: 160288
		public const int SubTitleText = 1;

		// Token: 0x04027221 RID: 160289
		public const int TitleText = 2;

		// Token: 0x04027222 RID: 160290
		public const int DescText = 3;

		// Token: 0x04027223 RID: 160291
		public const int DescScrollView = 4;
	}
}
