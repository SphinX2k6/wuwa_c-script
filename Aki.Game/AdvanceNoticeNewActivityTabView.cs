using System;
using System.Collections.Generic;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000585 RID: 1413
public class AdvanceNoticeNewActivityTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x060043B7 RID: 17335 RVA: 0x00175B7C File Offset: 0x00173D7C
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

	// Token: 0x060043B8 RID: 17336 RVA: 0x00175C04 File Offset: 0x00173E04
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

	// Token: 0x0200682A RID: 26666
	private class EComponentDefine
	{
		// Token: 0x04022563 RID: 140643
		public const int BgTexture = 0;

		// Token: 0x04022564 RID: 140644
		public const int SubTitleText = 1;

		// Token: 0x04022565 RID: 140645
		public const int TitleText = 2;

		// Token: 0x04022566 RID: 140646
		public const int DescText = 3;

		// Token: 0x04022567 RID: 140647
		public const int DescScrollView = 4;
	}
}
