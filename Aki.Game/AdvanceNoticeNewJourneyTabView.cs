using System;
using System.Collections.Generic;
using Aki.Config;
using UnrealEngine;

// Token: 0x020010D5 RID: 4309
public class AdvanceNoticeNewJourneyTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x06007033 RID: 28723 RVA: 0x0016DBD4 File Offset: 0x0016BDD4
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

	// Token: 0x06007034 RID: 28724 RVA: 0x0016DC5C File Offset: 0x0016BE5C
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

	// Token: 0x0200769A RID: 30362
	private class EComponentDefine
	{
		// Token: 0x0402723D RID: 160317
		public const int BgTexture = 0;

		// Token: 0x0402723E RID: 160318
		public const int SubTitleText = 1;

		// Token: 0x0402723F RID: 160319
		public const int TitleText = 2;

		// Token: 0x04027240 RID: 160320
		public const int DescText = 3;

		// Token: 0x04027241 RID: 160321
		public const int DescScrollView = 4;
	}
}
