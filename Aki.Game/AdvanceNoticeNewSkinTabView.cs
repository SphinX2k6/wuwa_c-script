using System;
using System.Collections.Generic;
using Aki.Config;
using UnrealEngine;

// Token: 0x020010D8 RID: 4312
public class AdvanceNoticeNewSkinTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x06007043 RID: 28739 RVA: 0x0016E300 File Offset: 0x0016C500
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x06007044 RID: 28740 RVA: 0x0016E370 File Offset: 0x0016C570
	protected override void RefreshView()
	{
		int currentSubTabId = this.ViewModel.CurrentSubTabId;
		AdvertisingTabCostume advertisingTabCostumeById = AdvanceNoticeConfig.Instance.GetAdvertisingTabCostumeById(currentSubTabId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), advertisingTabCostumeById.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), advertisingTabCostumeById.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), advertisingTabCostumeById.Description, Array.Empty<object>());
		base.SetTextureWithPath(base.GetTexture(0), advertisingTabCostumeById.MainPic);
	}

	// Token: 0x0200769F RID: 30367
	private class EComponentDefine
	{
		// Token: 0x04027263 RID: 160355
		public const int BgTexture = 0;

		// Token: 0x04027264 RID: 160356
		public const int SubTitleText = 1;

		// Token: 0x04027265 RID: 160357
		public const int TitleText = 2;

		// Token: 0x04027266 RID: 160358
		public const int DescText = 3;
	}
}
