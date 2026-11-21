using System;
using System.Collections.Generic;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200058C RID: 1420
public class AdvanceNoticeNewSkinTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x060043D9 RID: 17369 RVA: 0x00176CBC File Offset: 0x00174EBC
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

	// Token: 0x060043DA RID: 17370 RVA: 0x00176D2C File Offset: 0x00174F2C
	protected override void RefreshView()
	{
		int currentSubTabId = this.ViewModel.CurrentSubTabId;
		AdvertisingTabCostume advertisingTabCostumeById = AdvanceNoticeConfig.Instance.GetAdvertisingTabCostumeById(currentSubTabId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), advertisingTabCostumeById.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), advertisingTabCostumeById.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), advertisingTabCostumeById.Description, Array.Empty<object>());
		base.SetTextureWithPath(base.GetTexture(0), advertisingTabCostumeById.MainPic);
	}

	// Token: 0x02006833 RID: 26675
	private class EComponentDefine
	{
		// Token: 0x040225AC RID: 140716
		public const int BgTexture = 0;

		// Token: 0x040225AD RID: 140717
		public const int SubTitleText = 1;

		// Token: 0x040225AE RID: 140718
		public const int TitleText = 2;

		// Token: 0x040225AF RID: 140719
		public const int DescText = 3;
	}
}
