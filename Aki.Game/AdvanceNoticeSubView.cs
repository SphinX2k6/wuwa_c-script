using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010DB RID: 4315
public class AdvanceNoticeSubView : ActivitySubViewBase
{
	// Token: 0x0600705B RID: 28763 RVA: 0x0016EA3C File Offset: 0x0016CC3C
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

	// Token: 0x0600705C RID: 28764 RVA: 0x0016EB40 File Offset: 0x0016CD40
	protected override UniTask OnBeforeStartAsync()
	{
		AdvanceNoticeSubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdvanceNoticeSubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600705D RID: 28765 RVA: 0x0016EB83 File Offset: 0x0016CD83
	protected override void OnBeforeShow()
	{
		AdvanceNoticeMultiGridItem multiGridItem = this.MultiGridItem;
		if (multiGridItem == null)
		{
			return;
		}
		multiGridItem.PlayAnim();
	}

	// Token: 0x0600705E RID: 28766 RVA: 0x0016EB98 File Offset: 0x0016CD98
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

	// Token: 0x0600705F RID: 28767 RVA: 0x0016ECD0 File Offset: 0x0016CED0
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

	// Token: 0x04003420 RID: 13344
	[Nullable(2)]
	protected AdvanceNoticeMultiGridItem MultiGridItem;

	// Token: 0x020076A4 RID: 30372
	private class EComponentDefine
	{
		// Token: 0x0402727D RID: 160381
		public const int UrlItem = 0;

		// Token: 0x0402727E RID: 160382
		public const int UrlButton = 1;

		// Token: 0x0402727F RID: 160383
		public const int TopRightSprite = 2;

		// Token: 0x04027280 RID: 160384
		public const int ContentRootItem = 3;

		// Token: 0x04027281 RID: 160385
		public const int TitleDescText = 4;

		// Token: 0x04027282 RID: 160386
		public const int VersionText = 5;

		// Token: 0x04027283 RID: 160387
		public const int DateText = 6;

		// Token: 0x04027284 RID: 160388
		public const int UrlDescText = 7;

		// Token: 0x04027285 RID: 160389
		public const int LeftTexture = 8;
	}
}
