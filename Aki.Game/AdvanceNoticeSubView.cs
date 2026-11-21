using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200058F RID: 1423
public class AdvanceNoticeSubView : ActivitySubViewBase
{
	// Token: 0x060043F1 RID: 17393 RVA: 0x001773F8 File Offset: 0x001755F8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnUrlButtonClick))
		};
	}

	// Token: 0x060043F2 RID: 17394 RVA: 0x001774FC File Offset: 0x001756FC
	protected override UniTask OnBeforeStartAsync()
	{
		AdvanceNoticeSubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdvanceNoticeSubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060043F3 RID: 17395 RVA: 0x0017753F File Offset: 0x0017573F
	protected override void OnBeforeShow()
	{
		AdvanceNoticeMultiGridItem multiGridItem = this.MultiGridItem;
		if (multiGridItem == null)
		{
			return;
		}
		multiGridItem.PlayAnim();
	}

	// Token: 0x060043F4 RID: 17396 RVA: 0x00177554 File Offset: 0x00175754
	protected override void OnRefreshView()
	{
		if (this.ActivityBaseData == null)
		{
			return;
		}
		AdvertisingPageInfo advertisingPageInfoByActivityId = AdvanceNoticeConfig.Instance.GetAdvertisingPageInfoByActivityId(this.ActivityBaseData.Id);
		base.SetTextureByPath(advertisingPageInfoByActivityId.InscriptionPic, base.GetTexture(8), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), advertisingPageInfoByActivityId.TitleText, Array.Empty<object>());
		base.GetText(5).SetText(advertisingPageInfoByActivityId.TitleVersion, true);
		DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds((this.ActivityBaseData as AdvanceNoticeData).GetUnlockTimeStamp() * (long)TimeUtil.Instance.InverseMillisecond).DateTime;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), AdvanceNoticeDefine.advanceNoticeDateTextList[dateTime.Month - 1], new <>z__ReadOnlySingleElementList<object>(dateTime.Day));
		UUIText text = base.GetText(7);
		bool flag = advertisingPageInfoByActivityId.PVLinkId > 0;
		text.SetUIActive(flag);
		base.GetSprite(2).SetUIActive(!flag);
		base.GetButton(1).RootUIComp.Get().SetUIActive(flag);
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(text, advertisingPageInfoByActivityId.PVText, Array.Empty<object>());
		}
	}

	// Token: 0x060043F5 RID: 17397 RVA: 0x0017768C File Offset: 0x0017588C
	private void OnUrlButtonClick()
	{
		if (this.ActivityBaseData == null || !KuroSdkController.Instance.CanUseSdk())
		{
			return;
		}
		int pvlinkId = AdvanceNoticeConfig.Instance.GetAdvertisingPageInfoByActivityId(this.ActivityBaseData.Id).PVLinkId;
		if (pvlinkId <= 0)
		{
			return;
		}
		AdvertisingUrlConfig advertisingUrlConfigById = AdvanceNoticeConfig.Instance.GetAdvertisingUrlConfigById(pvlinkId);
		string text = KuroSdkController.Instance.GetIfGlobalSdk() ? advertisingUrlConfigById.GlobalLinkUrl : advertisingUrlConfigById.LinkUrl;
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		KuroSdkController.Instance.OpenWebView("", text, true, true, true, "Default");
	}

	// Token: 0x040034B9 RID: 13497
	[Nullable(2)]
	protected AdvanceNoticeMultiGridItem MultiGridItem;

	// Token: 0x02006838 RID: 26680
	private class EComponentDefine
	{
		// Token: 0x040225C6 RID: 140742
		public const int UrlItem = 0;

		// Token: 0x040225C7 RID: 140743
		public const int UrlButton = 1;

		// Token: 0x040225C8 RID: 140744
		public const int TopRightSprite = 2;

		// Token: 0x040225C9 RID: 140745
		public const int ContentRootItem = 3;

		// Token: 0x040225CA RID: 140746
		public const int TitleDescText = 4;

		// Token: 0x040225CB RID: 140747
		public const int VersionText = 5;

		// Token: 0x040225CC RID: 140748
		public const int DateText = 6;

		// Token: 0x040225CD RID: 140749
		public const int UrlDescText = 7;

		// Token: 0x040225CE RID: 140750
		public const int LeftTexture = 8;
	}
}
