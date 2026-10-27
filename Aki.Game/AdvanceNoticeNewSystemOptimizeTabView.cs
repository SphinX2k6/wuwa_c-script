using System;
using System.Collections.Generic;
using Aki.Config;
using UnrealEngine;

// Token: 0x020010D9 RID: 4313
public class AdvanceNoticeNewSystemOptimizeTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x06007046 RID: 28742 RVA: 0x0016E408 File Offset: 0x0016C608
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

	// Token: 0x06007047 RID: 28743 RVA: 0x0016E490 File Offset: 0x0016C690
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

	// Token: 0x020076A0 RID: 30368
	private class EComponentDefine
	{
		// Token: 0x04027267 RID: 160359
		public const int BgTexture = 0;

		// Token: 0x04027268 RID: 160360
		public const int SubTitleText = 1;

		// Token: 0x04027269 RID: 160361
		public const int TitleText = 2;

		// Token: 0x0402726A RID: 160362
		public const int DescText = 3;

		// Token: 0x0402726B RID: 160363
		public const int DescScrollView = 4;
	}
}
