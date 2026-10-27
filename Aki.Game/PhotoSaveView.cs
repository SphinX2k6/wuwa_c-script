using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Spring25;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x020025DC RID: 9692
[NullableContext(1)]
[Nullable(0)]
public class PhotoSaveView : UiViewBase
{
	// Token: 0x06013B03 RID: 80643 RVA: 0x004EDF84 File Offset: 0x004EC184
	public PhotoSaveView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013B04 RID: 80644 RVA: 0x004EDFA8 File Offset: 0x004EC1A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUISprite)),
			new ValueTuple<int, Type>(9, typeof(UUISprite)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIText)),
			new ValueTuple<int, Type>(18, typeof(UUIText)),
			new ValueTuple<int, Type>(19, typeof(UUITexture)),
			new ValueTuple<int, Type>(20, typeof(UUIText)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIText)),
			new ValueTuple<int, Type>(26, typeof(UUIText)),
			new ValueTuple<int, Type>(27, typeof(UUIItem)),
			new ValueTuple<int, Type>(28, typeof(UUIItem)),
			new ValueTuple<int, Type>(29, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(30, typeof(UUIItem)),
			new ValueTuple<int, Type>(31, typeof(UUIItem)),
			new ValueTuple<int, Type>(32, typeof(UUITexture)),
			new ValueTuple<int, Type>(33, typeof(UUITexture)),
			new ValueTuple<int, Type>(34, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(35, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(36, typeof(UUIItem)),
			new ValueTuple<int, Type>(37, typeof(UUITexture)),
			new ValueTuple<int, Type>(38, typeof(UUIVerticalLayout))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickedConfirmButton)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickedCloseButton)),
			new ValueTuple<int, Delegate>(29, new Action(this.OnClickRetake)),
			new ValueTuple<int, Delegate>(34, new Action<EToggleState>(this.OnClickPersonalInfoShow)),
			new ValueTuple<int, Delegate>(35, new Action<EToggleState>(this.OnClickPersonalInfoShow))
		};
	}

	// Token: 0x06013B05 RID: 80645 RVA: 0x004EE3C0 File Offset: 0x004EC5C0
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoSaveView.<OnBeforeStartAsync>d__31 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoSaveView.<OnBeforeStartAsync>d__31>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013B06 RID: 80646 RVA: 0x004EE403 File Offset: 0x004EC603
	private PhotoShareBtnItem InitShareBtn()
	{
		PhotoShareBtnItem photoShareBtnItem = new PhotoShareBtnItem();
		photoShareBtnItem.SetClickCallBack(new Action<EChannelShare, int>(this.OnClickShareBtn));
		return photoShareBtnItem;
	}

	// Token: 0x06013B07 RID: 80647 RVA: 0x004EE41C File Offset: 0x004EC61C
	private GachaShareSwitchItem InitGachaShareSwitchItem()
	{
		GachaShareSwitchItem gachaShareSwitchItem = new GachaShareSwitchItem();
		gachaShareSwitchItem.SetToggleClickCallback(new Action<GachaShareSwitchData, int>(this.OnClickGachaSwitchItem));
		return gachaShareSwitchItem;
	}

	// Token: 0x06013B08 RID: 80648 RVA: 0x004EE438 File Offset: 0x004EC638
	private void OnClickGachaSwitchItem(GachaShareSwitchData switchData, int gridIndex)
	{
		GenericLayout<GachaShareSwitchItem, GachaShareSwitchData> gachaSwitchLayout = this.GachaSwitchLayout;
		if (gachaSwitchLayout != null && gachaSwitchLayout.GetSelectedGridIndex() == gridIndex)
		{
			return;
		}
		GachaShareTenPanel gachaViewTen = this.GachaViewTen;
		if (gachaViewTen != null)
		{
			gachaViewTen.SetUiActive(switchData.TenGachaInfo != null);
		}
		GachaShareOnePanel gachaView = this.GachaView;
		if (gachaView != null)
		{
			gachaView.SetUiActive(switchData.GachaInfo != null);
		}
		if (switchData.GachaInfo != null)
		{
			GachaShareOnePanel gachaView2 = this.GachaView;
			if (gachaView2 != null)
			{
				gachaView2.Refresh(switchData.GachaInfo);
			}
		}
		GenericLayout<GachaShareSwitchItem, GachaShareSwitchData> gachaSwitchLayout2 = this.GachaSwitchLayout;
		if (gachaSwitchLayout2 != null)
		{
			gachaSwitchLayout2.SelectGridProxy(gridIndex, false);
		}
		bool flag = switchData.GachaInfo != null;
		GachaResult gachaInfo = flag ? switchData.GachaInfo : switchData.TenGachaInfo[0];
		this.SetGachaExtraType(flag, gachaInfo);
	}

	// Token: 0x06013B09 RID: 80649 RVA: 0x004EE4F0 File Offset: 0x004EC6F0
	private void SetGachaExtraType(bool isSingle, GachaResult gachaInfo)
	{
		InventoryDefine.EItemDataType itemIdType = GachaConfig.Instance.GetItemIdType(gachaInfo.Proto_GachaReward.ItemId);
		EShareReportExtraType shareReportExtraType = EShareReportExtraType.None;
		if (itemIdType == InventoryDefine.EItemDataType.RoleItem)
		{
			shareReportExtraType = (isSingle ? EShareReportExtraType.CharacterGachaOne : EShareReportExtraType.CharacterGachaTen);
		}
		else if (itemIdType == InventoryDefine.EItemDataType.WeaponItem)
		{
			shareReportExtraType = (isSingle ? EShareReportExtraType.WeaponGachaOne : EShareReportExtraType.WeaponGachaTen);
		}
		this.ShareReportExtraType = shareReportExtraType;
	}

	// Token: 0x06013B0A RID: 80650 RVA: 0x004EE538 File Offset: 0x004EC738
	private UniTask RefreshGachaView(IReadOnlyList<GachaResult> gachaInfos)
	{
		PhotoSaveView.<RefreshGachaView>d__36 <RefreshGachaView>d__;
		<RefreshGachaView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshGachaView>d__.<>4__this = this;
		<RefreshGachaView>d__.gachaInfos = gachaInfos;
		<RefreshGachaView>d__.<>1__state = -1;
		<RefreshGachaView>d__.<>t__builder.Start<PhotoSaveView.<RefreshGachaView>d__36>(ref <RefreshGachaView>d__);
		return <RefreshGachaView>d__.<>t__builder.Task;
	}

	// Token: 0x06013B0B RID: 80651 RVA: 0x004EE584 File Offset: 0x004EC784
	[NullableContext(2)]
	private UniTask RefreshOneGachaView(GachaResult gachaInfo)
	{
		PhotoSaveView.<RefreshOneGachaView>d__37 <RefreshOneGachaView>d__;
		<RefreshOneGachaView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshOneGachaView>d__.<>4__this = this;
		<RefreshOneGachaView>d__.gachaInfo = gachaInfo;
		<RefreshOneGachaView>d__.<>1__state = -1;
		<RefreshOneGachaView>d__.<>t__builder.Start<PhotoSaveView.<RefreshOneGachaView>d__37>(ref <RefreshOneGachaView>d__);
		return <RefreshOneGachaView>d__.<>t__builder.Task;
	}

	// Token: 0x06013B0C RID: 80652 RVA: 0x004EE5D0 File Offset: 0x004EC7D0
	private UniTask RefreshTenGachaView(IReadOnlyList<GachaResult> gachaInfos)
	{
		PhotoSaveView.<RefreshTenGachaView>d__38 <RefreshTenGachaView>d__;
		<RefreshTenGachaView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTenGachaView>d__.<>4__this = this;
		<RefreshTenGachaView>d__.gachaInfos = gachaInfos;
		<RefreshTenGachaView>d__.<>1__state = -1;
		<RefreshTenGachaView>d__.<>t__builder.Start<PhotoSaveView.<RefreshTenGachaView>d__38>(ref <RefreshTenGachaView>d__);
		return <RefreshTenGachaView>d__.<>t__builder.Task;
	}

	// Token: 0x06013B0D RID: 80653 RVA: 0x004EE61B File Offset: 0x004EC81B
	private IReadOnlyList<GachaResult> GetSortTenGachaInfos(IReadOnlyList<GachaResult> gachaInfos)
	{
		List<GachaResult> list = new List<GachaResult>(gachaInfos);
		list.Sort(delegate(GachaResult a, GachaResult b)
		{
			if (a.Proto_GachaReward == null || b.Proto_GachaReward == null)
			{
				return 0;
			}
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.Proto_GachaReward.ItemId);
			ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(b.Proto_GachaReward.ItemId);
			int num = (itemConfigData != null) ? itemConfigData.QualityId : 0;
			int num2 = (itemConfigData2 != null) ? itemConfigData2.QualityId : 0;
			if (num == num2)
			{
				int num3 = PhotoSaveView.<GetSortTenGachaInfos>g__RevertType|39_0(GachaConfig.Instance.GetItemIdType(a.Proto_GachaReward.ItemId));
				return PhotoSaveView.<GetSortTenGachaInfos>g__RevertType|39_0(GachaConfig.Instance.GetItemIdType(b.Proto_GachaReward.ItemId)) - num3;
			}
			return num2 - num;
		});
		return list;
	}

	// Token: 0x06013B0E RID: 80654 RVA: 0x004EE648 File Offset: 0x004EC848
	private UniTask InitFragmentMemorySubView(FragmentMemoryCollectData data)
	{
		PhotoSaveView.<InitFragmentMemorySubView>d__40 <InitFragmentMemorySubView>d__;
		<InitFragmentMemorySubView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitFragmentMemorySubView>d__.<>4__this = this;
		<InitFragmentMemorySubView>d__.data = data;
		<InitFragmentMemorySubView>d__.<>1__state = -1;
		<InitFragmentMemorySubView>d__.<>t__builder.Start<PhotoSaveView.<InitFragmentMemorySubView>d__40>(ref <InitFragmentMemorySubView>d__);
		return <InitFragmentMemorySubView>d__.<>t__builder.Task;
	}

	// Token: 0x06013B0F RID: 80655 RVA: 0x004EE694 File Offset: 0x004EC894
	private UniTask InitRoleSkinSubView(RoleSkinData data)
	{
		PhotoSaveView.<InitRoleSkinSubView>d__41 <InitRoleSkinSubView>d__;
		<InitRoleSkinSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleSkinSubView>d__.<>4__this = this;
		<InitRoleSkinSubView>d__.data = data;
		<InitRoleSkinSubView>d__.<>1__state = -1;
		<InitRoleSkinSubView>d__.<>t__builder.Start<PhotoSaveView.<InitRoleSkinSubView>d__41>(ref <InitRoleSkinSubView>d__);
		return <InitRoleSkinSubView>d__.<>t__builder.Task;
	}

	// Token: 0x06013B10 RID: 80656 RVA: 0x004EE6E0 File Offset: 0x004EC8E0
	private UniTask InitWheelTowerSettlementShareView(IWheelTowerSettlementViewData data)
	{
		PhotoSaveView.<InitWheelTowerSettlementShareView>d__42 <InitWheelTowerSettlementShareView>d__;
		<InitWheelTowerSettlementShareView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitWheelTowerSettlementShareView>d__.<>4__this = this;
		<InitWheelTowerSettlementShareView>d__.data = data;
		<InitWheelTowerSettlementShareView>d__.<>1__state = -1;
		<InitWheelTowerSettlementShareView>d__.<>t__builder.Start<PhotoSaveView.<InitWheelTowerSettlementShareView>d__42>(ref <InitWheelTowerSettlementShareView>d__);
		return <InitWheelTowerSettlementShareView>d__.<>t__builder.Task;
	}

	// Token: 0x06013B11 RID: 80657 RVA: 0x004EE72C File Offset: 0x004EC92C
	private UniTask InitWheelTowerTotalScoreView()
	{
		PhotoSaveView.<InitWheelTowerTotalScoreView>d__43 <InitWheelTowerTotalScoreView>d__;
		<InitWheelTowerTotalScoreView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitWheelTowerTotalScoreView>d__.<>4__this = this;
		<InitWheelTowerTotalScoreView>d__.<>1__state = -1;
		<InitWheelTowerTotalScoreView>d__.<>t__builder.Start<PhotoSaveView.<InitWheelTowerTotalScoreView>d__43>(ref <InitWheelTowerTotalScoreView>d__);
		return <InitWheelTowerTotalScoreView>d__.<>t__builder.Task;
	}

	// Token: 0x06013B12 RID: 80658 RVA: 0x004EE770 File Offset: 0x004EC970
	private UniTask InitChallengeRecordShareView(ShipTowerRecordShareData data)
	{
		PhotoSaveView.<InitChallengeRecordShareView>d__44 <InitChallengeRecordShareView>d__;
		<InitChallengeRecordShareView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChallengeRecordShareView>d__.<>4__this = this;
		<InitChallengeRecordShareView>d__.data = data;
		<InitChallengeRecordShareView>d__.<>1__state = -1;
		<InitChallengeRecordShareView>d__.<>t__builder.Start<PhotoSaveView.<InitChallengeRecordShareView>d__44>(ref <InitChallengeRecordShareView>d__);
		return <InitChallengeRecordShareView>d__.<>t__builder.Task;
	}

	// Token: 0x06013B13 RID: 80659 RVA: 0x004EE7BC File Offset: 0x004EC9BC
	private UniTask InitHandBookPhotoShareView(HandBookPhotoData data)
	{
		PhotoSaveView.<InitHandBookPhotoShareView>d__45 <InitHandBookPhotoShareView>d__;
		<InitHandBookPhotoShareView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitHandBookPhotoShareView>d__.<>4__this = this;
		<InitHandBookPhotoShareView>d__.data = data;
		<InitHandBookPhotoShareView>d__.<>1__state = -1;
		<InitHandBookPhotoShareView>d__.<>t__builder.Start<PhotoSaveView.<InitHandBookPhotoShareView>d__45>(ref <InitHandBookPhotoShareView>d__);
		return <InitHandBookPhotoShareView>d__.<>t__builder.Task;
	}

	// Token: 0x06013B14 RID: 80660 RVA: 0x004EE808 File Offset: 0x004ECA08
	private UniTask InitTowerVariationShareView()
	{
		PhotoSaveView.<InitTowerVariationShareView>d__46 <InitTowerVariationShareView>d__;
		<InitTowerVariationShareView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTowerVariationShareView>d__.<>4__this = this;
		<InitTowerVariationShareView>d__.<>1__state = -1;
		<InitTowerVariationShareView>d__.<>t__builder.Start<PhotoSaveView.<InitTowerVariationShareView>d__46>(ref <InitTowerVariationShareView>d__);
		return <InitTowerVariationShareView>d__.<>t__builder.Task;
	}

	// Token: 0x06013B15 RID: 80661 RVA: 0x004EE84C File Offset: 0x004ECA4C
	private UniTask InitVersionPreheatSubView(VersionPreheatShareData data)
	{
		PhotoSaveView.<InitVersionPreheatSubView>d__47 <InitVersionPreheatSubView>d__;
		<InitVersionPreheatSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitVersionPreheatSubView>d__.<>4__this = this;
		<InitVersionPreheatSubView>d__.data = data;
		<InitVersionPreheatSubView>d__.<>1__state = -1;
		<InitVersionPreheatSubView>d__.<>t__builder.Start<PhotoSaveView.<InitVersionPreheatSubView>d__47>(ref <InitVersionPreheatSubView>d__);
		return <InitVersionPreheatSubView>d__.<>t__builder.Task;
	}

	// Token: 0x06013B16 RID: 80662 RVA: 0x004EE898 File Offset: 0x004ECA98
	private UniTask InitSpring25SubView(Spring25ShareData data)
	{
		PhotoSaveView.<InitSpring25SubView>d__48 <InitSpring25SubView>d__;
		<InitSpring25SubView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSpring25SubView>d__.<>4__this = this;
		<InitSpring25SubView>d__.data = data;
		<InitSpring25SubView>d__.<>1__state = -1;
		<InitSpring25SubView>d__.<>t__builder.Start<PhotoSaveView.<InitSpring25SubView>d__48>(ref <InitSpring25SubView>d__);
		return <InitSpring25SubView>d__.<>t__builder.Task;
	}

	// Token: 0x06013B17 RID: 80663 RVA: 0x004EE8E4 File Offset: 0x004ECAE4
	private void RefreshPhotoPanel()
	{
		base.GetItem(14).SetUIActive(true);
		base.GetItem(15).SetUIActive(false);
		UUIItem item = base.GetItem(13);
		UUIItem item2 = base.GetItem(7);
		UUIText text = base.GetText(10);
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		float viewportScale = UWidgetLayoutLibrary.GetViewportScale(GlobalData.World);
		if (this.ShareActionId == EShareActionId.Photo || this.ShareActionId == EShareActionId.Birthday)
		{
			item.SetWidth(viewportSize.X / (viewportScale * 1.5f));
			item.SetHeight(viewportSize.Y / (viewportScale * 1.5f));
		}
		else
		{
			item.SetWidth(1750f);
			item.SetHeight(986f);
		}
		if (PhotographController.Instance.CheckIfInNormalCamera())
		{
			text.SetUIActive(false);
			item2.SetUIActive(false);
			this.RefreshShareBtn();
		}
		else if (PhotographController.Instance.CheckIfInEntityCamera())
		{
			text.SetUIActive(true);
			item2.SetUIActive(true);
			this.RefreshBtnEmpty();
		}
		else if (PhotographController.Instance.CheckIfInTogetherCamera())
		{
			text.SetUIActive(false);
			item2.SetUIActive(false);
			this.RefreshShareBtn();
		}
		this.RefreshSaveBtn();
	}

	// Token: 0x06013B18 RID: 80664 RVA: 0x004EE9FC File Offset: 0x004ECBFC
	private void RefreshLandscapePanel(HandBookPhotoData data)
	{
		base.GetItem(14).SetUIActive(false);
		base.GetItem(15).SetUIActive(true);
		base.GetItem(7).SetUIActive(false);
		this.RefreshShareBtn();
		this.RefreshSaveBtn();
		int index = data.Index;
		base.GetText(18).SetUIActive(data.DateText != null);
		if (data.DateText != null)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(18), "DateOfAcquisition", new <>z__ReadOnlySingleElementList<object>(data.DateText[index]));
		}
		base.GetText(17).SetUIActive(data.NameText != null);
		if (data.NameText != null)
		{
			base.GetText(17).SetText(data.NameText[index], true);
		}
		base.GetText(16).SetUIActive(data.TypeText != null);
		if (data.TypeText != null)
		{
			base.GetText(16).SetText(data.TypeText[index], true);
		}
		base.GetText(20).SetUIActive(data.DescrtptionText != null);
		if (data.DescrtptionText != null)
		{
			base.GetText(20).SetText(data.DescrtptionText[index], true);
		}
		base.GetTexture(19).SetUIActive(data.TextureList != null);
		if (data.TextureList != null)
		{
			base.SetTextureByPath(data.TextureList[index], base.GetTexture(19), null, null);
		}
	}

	// Token: 0x06013B19 RID: 80665 RVA: 0x004EEB78 File Offset: 0x004ECD78
	private void RefreshFullScreenPhotoPanel(bool isProcess)
	{
		UUIItem item = base.GetItem(14);
		item.SetUIActive(true);
		base.GetItem(15).SetUIActive(false);
		UUIItem item2 = base.GetItem(13);
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		float viewportScale = UWidgetLayoutLibrary.GetViewportScale(GlobalData.World);
		if (isProcess)
		{
			item2.SetWidth(viewportSize.X / viewportScale);
			item2.SetHeight(viewportSize.Y / viewportScale);
			this.PanelItemOriginalScale = new FVector?(item.K2_GetComponentScale());
			FVector uiitemScale = new FVector(1f, 1f, 1f);
			item.SetUIItemScale(uiitemScale);
			EventSystem.Instance.Emit<bool>(EEventName.OnPreparePhotoScreenShot, false);
			return;
		}
		item2.SetWidth(viewportSize.X / (viewportScale * 1.5f));
		item2.SetHeight(viewportSize.Y / (viewportScale * 1.5f));
		item.SetUIItemScale(this.PanelItemOriginalScale.Value);
		EventSystem.Instance.Emit<bool>(EEventName.OnPreparePhotoScreenShot, true);
	}

	// Token: 0x06013B1A RID: 80666 RVA: 0x004EEC6C File Offset: 0x004ECE6C
	private void RefreshMarkItem(bool isProcess)
	{
		if (isProcess)
		{
			PhotoSaveMarkItem markItem = this.MarkItem;
			if (markItem == null)
			{
				return;
			}
			markItem.SetUiActive(!this.IsShowPlayerName);
			return;
		}
		else
		{
			PhotoSaveMarkItem markItem2 = this.MarkItem;
			if (markItem2 == null)
			{
				return;
			}
			markItem2.SetUiActive(this.IsShowPlayerName);
			return;
		}
	}

	// Token: 0x06013B1B RID: 80667 RVA: 0x004EECA4 File Offset: 0x004ECEA4
	private void RefreshPhotoPanelByUiDirectly()
	{
		base.GetItem(14).SetUIActive(true);
		base.GetItem(15).SetUIActive(false);
		UUIItem item = base.GetItem(13);
		UUIItem item2 = base.GetItem(7);
		UUIItem text = base.GetText(10);
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		float viewportScale = UWidgetLayoutLibrary.GetViewportScale(GlobalData.World);
		if (this.ShareActionId == EShareActionId.Photo)
		{
			item.SetWidth(viewportSize.X / (viewportScale * 1.5f));
			item.SetHeight(viewportSize.Y / (viewportScale * 1.5f));
		}
		else
		{
			item.SetWidth(1750f);
			item.SetHeight(986f);
		}
		text.SetUIActive(false);
		item2.SetUIActive(false);
		this.RefreshShareBtn();
		this.RefreshSaveBtn();
	}

	// Token: 0x06013B1C RID: 80668 RVA: 0x004EED5C File Offset: 0x004ECF5C
	private bool GetIfShareBtnCanShow()
	{
		return !BaseConfigController.Instance.GetIosAuditFirstDownloadTip();
	}

	// Token: 0x06013B1D RID: 80669 RVA: 0x004EED70 File Offset: 0x004ECF70
	private void RefreshSaveBtn()
	{
		bool flag = PhotographController.Instance.CheckHasSpecifiedFeatureForSave();
		bool flag2 = Info.Instance.IsXSXPlatform();
		UUIButtonComponent button = base.GetButton(6);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(!flag2 && !flag);
	}

	// Token: 0x06013B1E RID: 80670 RVA: 0x004EEDBC File Offset: 0x004ECFBC
	private void RefreshShareBtn()
	{
		base.GetItem(31).SetUIActive(true);
		base.GetButton(29).RootUIComp.Get().SetUIActive(false);
		base.GetHorizontalLayout(5).RootUIComp.Get().SetUIActive(this.GetIfShareBtnCanShow());
		List<EChannelShare> openedShareIds = ChannelController.Instance.GetOpenedShareIds();
		this.ShareBtnLayout = new GenericLayout<PhotoShareBtnItem, EChannelShare>(base.GetHorizontalLayout(5), new Func<PhotoShareBtnItem>(this.InitShareBtn), null, false, true);
		this.ShareBtnLayout.RefreshByData(openedShareIds, null, false);
		base.GetItem(30).SetUIActive(openedShareIds.Count > 0);
	}

	// Token: 0x06013B1F RID: 80671 RVA: 0x004EEE64 File Offset: 0x004ED064
	private void RefreshRetakeBtn()
	{
		base.GetItem(31).SetUIActive(false);
		base.GetItem(30).SetUIActive(true);
		base.GetButton(29).RootUIComp.Get().SetUIActive(true);
		base.GetHorizontalLayout(5).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06013B20 RID: 80672 RVA: 0x004EEEC4 File Offset: 0x004ED0C4
	private void RefreshBtnEmpty()
	{
		base.GetItem(30).SetUIActive(false);
		base.GetButton(29).RootUIComp.Get().SetUIActive(false);
		base.GetHorizontalLayout(5).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06013B21 RID: 80673 RVA: 0x004EEF14 File Offset: 0x004ED114
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnEntityCameraFinished, new Action<bool>(this.EntityCameraFinished));
		EventSystem.Instance.Add(EEventName.OnFirstShare, new Action(this.RefreshFirstShare));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
	}

	// Token: 0x06013B22 RID: 80674 RVA: 0x004EEF74 File Offset: 0x004ED174
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnEntityCameraFinished, new Action<bool>(this.EntityCameraFinished));
		EventSystem.Instance.Remove(EEventName.OnFirstShare, new Action(this.RefreshFirstShare));
		EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
	}

	// Token: 0x06013B23 RID: 80675 RVA: 0x004EEFD1 File Offset: 0x004ED1D1
	protected override void OnAfterShow()
	{
		if (this.CaptureFullScene)
		{
			this.PlayScreenShotSequence();
			return;
		}
		if (this.PrepareFullScreenShot)
		{
			this.RefreshFullScreenPhotoPanel(true);
			this.RefreshMarkItem(true);
			this.OnAfterShowPrepareFullScreenAsync().Forget();
			return;
		}
		this.PlayScreenShotSequence();
	}

	// Token: 0x06013B24 RID: 80676 RVA: 0x004EF00C File Offset: 0x004ED20C
	private UniTask OnAfterShowPrepareFullScreenAsync()
	{
		PhotoSaveView.<OnAfterShowPrepareFullScreenAsync>d__62 <OnAfterShowPrepareFullScreenAsync>d__;
		<OnAfterShowPrepareFullScreenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnAfterShowPrepareFullScreenAsync>d__.<>4__this = this;
		<OnAfterShowPrepareFullScreenAsync>d__.<>1__state = -1;
		<OnAfterShowPrepareFullScreenAsync>d__.<>t__builder.Start<PhotoSaveView.<OnAfterShowPrepareFullScreenAsync>d__62>(ref <OnAfterShowPrepareFullScreenAsync>d__);
		return <OnAfterShowPrepareFullScreenAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013B25 RID: 80677 RVA: 0x004EF04F File Offset: 0x004ED24F
	protected override void OnBeforeDestroy()
	{
		UKuroRenderingRuntimeBPPluginBPLibrary.ReleaseGetSceneColorShotBefore();
		GenericLayout<PhotoShareBtnItem, EChannelShare> shareBtnLayout = this.ShareBtnLayout;
		if (shareBtnLayout != null)
		{
			shareBtnLayout.ClearChildren();
		}
		this.ShareBtnLayout = null;
		this.Reset();
	}

	// Token: 0x06013B26 RID: 80678 RVA: 0x004EF074 File Offset: 0x004ED274
	private float[] GetCaptureRange()
	{
		UUIItem item = base.GetItem(this.IsPhoto ? 11 : 23);
		UUIItem item2 = base.GetItem(this.IsPhoto ? 12 : 24);
		FVector2D positionInViewPort = item.GetPositionInViewPort(true);
		FVector2D positionInViewPort2 = item2.GetPositionInViewPort(true);
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		float num = (positionInViewPort.X < 0f) ? 0f : positionInViewPort.X;
		float num2 = (positionInViewPort.Y < 0f) ? 0f : positionInViewPort.Y;
		float num3 = (positionInViewPort2.X < viewportSize.X) ? positionInViewPort2.X : viewportSize.X;
		float num4 = (positionInViewPort2.Y < viewportSize.Y) ? positionInViewPort2.Y : viewportSize.Y;
		return new float[]
		{
			num,
			num2,
			num3,
			num4
		};
	}

	// Token: 0x06013B27 RID: 80679 RVA: 0x004EF154 File Offset: 0x004ED354
	private void PlayScreenShotSequence()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("ScreenShot", false, null);
	}

	// Token: 0x06013B28 RID: 80680 RVA: 0x004EF180 File Offset: 0x004ED380
	private unsafe void OnClickShareBtn(EChannelShare channel, int shareConfigId)
	{
		Log.Instance.Info(ELogModule.Photo, ELogAuthor.BB, "点击分享截图按钮", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.TakeScreenshot(false, delegate(int width, int height, TArray<FColor> colors)
		{
			TArray<byte> tarray = new TArray<byte>();
			UKuroGameScreenshotBPLibrary.CompressConvertColorsToBitmap(width, height, colors, ref tarray);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Photo;
			ELogAuthor author = ELogAuthor.BB;
			string message = "截图完成，压缩截图结果进行分享";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("width", width);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("height", height);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ColorSize", (colors != null) ? new int?(colors.Num()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("bitMapSize", (tarray != null) ? new int?(tarray.Num()) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			ChannelController.Instance.ShareChannel(channel, tarray, this.ShareActionId, shareConfigId, this.ShareReportExtraType);
		}, null, null);
	}

	// Token: 0x06013B29 RID: 80681 RVA: 0x004EF1DC File Offset: 0x004ED3DC
	private void OnClickedConfirmButton()
	{
		Log.Instance.Info(ELogModule.Photo, ELogAuthor.BB, "点击保存截图按钮", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CheckPhotoPermission())
		{
			this.TakeScreenshot(true, new Action<int, int, TArray<FColor>>(this.OnTakePhoto), new Action<bool>(this.OnIOSPhotoLibraryAuthorizationCompleted), new FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate(this.OnPhotoCompressed));
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhotoPermissionRequest);
		Action value = delegate()
		{
			if (base.IsDestroyOrDestroying || base.IsHideOrHiding)
			{
				Log.Instance.Error(ELogModule.Photo, ELogAuthor.BB, "相册权限确认回调时PhotoSaveView已失效，取消请求权限", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (PhotographController.Instance.CouldRequestPhotoPermission())
			{
				LocalStorage.SetGlobal<double>(ELocalStorageGlobalKey.RequestPhotoPermissionMinTime, TimeUtil.Instance.GetServerTime() + (double)ConfigCommonParamById.GetIntConfig("PermissionRequestsTimeId").Value);
				KuroSdkController.Instance.RequestPhotoPermission(new Action<bool>(this.OnRequestPermissionCallback));
				return;
			}
			this.OnPhotoPermissionDenied();
		};
		confirmBoxDataNew.FunctionMap[1] = new Action(this.OnPhotoPermissionDenied);
		confirmBoxDataNew.FunctionMap[2] = value;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06013B2A RID: 80682 RVA: 0x004EF289 File Offset: 0x004ED489
	private void OnRequestPermissionCallback(bool isAllowed)
	{
		if (isAllowed)
		{
			this.TakeScreenshot(true, new Action<int, int, TArray<FColor>>(this.OnTakePhoto), new Action<bool>(this.OnIOSPhotoLibraryAuthorizationCompleted), null);
			return;
		}
		this.OnPhotoPermissionDenied();
	}

	// Token: 0x06013B2B RID: 80683 RVA: 0x004EF2B8 File Offset: 0x004ED4B8
	private void OnPhotoPermissionDenied()
	{
		ESourcePlatformType platformType = Info.Instance.PlatformType;
		if (platformType == ESourcePlatformType.IOS)
		{
			GenericPromptController.Instance.ShowPromptByCode("Privilege_album_IOS", Array.Empty<object>());
			return;
		}
		if (platformType == ESourcePlatformType.Android)
		{
			GenericPromptController.Instance.ShowPromptByCode("Privilege_album_Android", Array.Empty<object>());
			return;
		}
		if (platformType != ESourcePlatformType.OpenHarmony)
		{
			return;
		}
		GenericPromptController.Instance.ShowPromptByCode("Privilege_album_Android", Array.Empty<object>());
	}

	// Token: 0x06013B2C RID: 80684 RVA: 0x004EF31C File Offset: 0x004ED51C
	private string GetPhotoName()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		return TimeUtil.Instance.DateFormatString2(serverTime) + ".png";
	}

	// Token: 0x06013B2D RID: 80685 RVA: 0x004EF34C File Offset: 0x004ED54C
	private void PrepareScreenShot(bool isFirst, Action onPrepareFinish)
	{
		float[] captureRange = this.GetCaptureRange();
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		UGameScreenshotTask ugameScreenshotTask = ScreenShotManager.PrepareTakeScreenshot("", (float)((int)captureRange[0]), (float)((int)captureRange[1]), (float)((int)captureRange[2]), (float)((int)captureRange[3]), false, viewportSize.X, viewportSize.Y, 1);
		if (ugameScreenshotTask == null)
		{
			return;
		}
		ugameScreenshotTask.OnTakeScreenshotCapturedDelegate.Clear();
		ugameScreenshotTask.OnTakeScreenshotCapturedDelegate.Add(delegate(int width, int height, in TArray<FColor> colors)
		{
			if ((this.IsShowPlayerName & isFirst) || (!this.IsShowPlayerName && !isFirst))
			{
				this.CurrentTakeColors = colors;
				this.CurrentTakeWidth = width;
				this.CurrentTakeHeight = height;
			}
			else
			{
				this.CurrentWatermarkTakeColors = colors;
				this.CurrentWatermarkTakeWidth = width;
				this.CurrentWatermarkTakeHeight = height;
			}
			onPrepareFinish();
		});
		ugameScreenshotTask.TakeScreenshot();
	}

	// Token: 0x06013B2E RID: 80686 RVA: 0x004EF3E0 File Offset: 0x004ED5E0
	[NullableContext(2)]
	private void TakeScreenshot(bool isSaveFile, [Nullable(new byte[]
	{
		1,
		2
	})] Action<int, int, TArray<FColor>> onTakeScreenShotCallback, Action<bool> onIOSPhotoLibraryAuthorizationCompleted = null, FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate onPhotoCompressed = null)
	{
		string photoName = this.GetPhotoName();
		this.RelativeShotPath = this.GetRelativeShotPath(photoName);
		string storagePath = UBlueprintPathsLibrary.ProjectUserDir() + this.RelativeShotPath;
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		int multiplierScale = this.GetSafeMultiplierScale(viewportSize);
		if (this.CaptureFullScene & isSaveFile)
		{
			UUIItem rootItem = base.GetRootItem();
			if (rootItem != null)
			{
				rootItem.SetUIActive(false);
			}
			ULGUIBPLibrary.ResetGlobalBlurUIItem(GlobalData.GameInstance.GetWorld());
			EventSystem.Instance.Emit<bool, bool>(EEventName.OnPhotographViewCaptureMode, true, this.IsShowPlayerName);
			EventSystem.Instance.Emit<bool>(EEventName.OnPreparePhotoScreenShot, false);
			Action restorePhotographUi = delegate()
			{
				EventSystem.Instance.Emit<bool, bool>(EEventName.OnPhotographViewCaptureMode, false, false);
				EventSystem.Instance.Emit<bool>(EEventName.OnPreparePhotoScreenShot, true);
			};
			Action<int, int, TArray<FColor>> <>9__2;
			TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				PhotoSaveView <>4__this = this;
				string storagePath = storagePath;
				int minX = 0;
				int minY = 0;
				FVector2D viewportSize;
				int maxX = (int)viewportSize.X;
				int maxY = (int)viewportSize.Y;
				bool isSaveFile2 = isSaveFile;
				viewportSize = viewportSize;
				int multiplierScale = multiplierScale;
				bool isHighRes = true;
				Action<int, int, TArray<FColor>> onCaptured;
				if ((onCaptured = <>9__2) == null)
				{
					onCaptured = (<>9__2 = delegate(int w, int h, TArray<FColor> c)
					{
						restorePhotographUi();
						onTakeScreenShotCallback(w, h, c);
					});
				}
				if (!<>4__this.RunScreenShot(storagePath, minX, minY, maxX, maxY, isSaveFile2, viewportSize, multiplierScale, isHighRes, onCaptured, onIOSPhotoLibraryAuthorizationCompleted, onPhotoCompressed))
				{
					Log.Instance.Error(ELogModule.Photo, ELogAuthor.CXJ, "延迟场景截图：PrepareTakeScreenshot 返回 undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
					restorePhotographUi();
					UUIItem rootItem2 = this.GetRootItem();
					if (rootItem2 != null)
					{
						rootItem2.SetUIActive(true);
					}
					UiBlurLogic.Instance.SetNormalUiRenderAfterBlur(this);
				}
			}, null, null);
			return;
		}
		float[] captureRange = this.GetCaptureRange();
		this.RunScreenShot(storagePath, (int)captureRange[0], (int)captureRange[1], (int)captureRange[2], (int)captureRange[3], isSaveFile, viewportSize, multiplierScale, false, onTakeScreenShotCallback, onIOSPhotoLibraryAuthorizationCompleted, onPhotoCompressed);
	}

	// Token: 0x06013B2F RID: 80687 RVA: 0x004EF548 File Offset: 0x004ED748
	[NullableContext(2)]
	private bool RunScreenShot([Nullable(1)] string storagePath, int minX, int minY, int maxX, int maxY, bool isSaveFile, FVector2D viewportSize, int multiplierScale, bool isHighRes, [Nullable(new byte[]
	{
		1,
		2
	})] Action<int, int, TArray<FColor>> onCaptured, Action<bool> onIOSPhotoLibraryAuthorizationCompleted = null, FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate onPhotoCompressed = null)
	{
		UGameScreenshotTask ugameScreenshotTask = ScreenShotManager.PrepareTakeScreenshot(storagePath, (float)minX, (float)minY, (float)maxX, (float)maxY, isSaveFile, viewportSize.X, viewportSize.Y, multiplierScale);
		if (ugameScreenshotTask == null)
		{
			return false;
		}
		ugameScreenshotTask.OnTakeScreenshotCapturedDelegate.Add(delegate(int w, int h, in TArray<FColor> c)
		{
			onCaptured(w, h, c);
		});
		if (onIOSPhotoLibraryAuthorizationCompleted != null)
		{
			ugameScreenshotTask.OnIOSPhotoLibraryAuthorizationCompletedDelegate.Add(onIOSPhotoLibraryAuthorizationCompleted);
		}
		if (onPhotoCompressed != null)
		{
			ugameScreenshotTask.OnTakeScreenshotCompressedDelegate.Add(onPhotoCompressed);
		}
		if (isHighRes)
		{
			ugameScreenshotTask.TakeScreenshotHighRes(multiplierScale);
		}
		else
		{
			ugameScreenshotTask.TakeScreenshot();
		}
		return true;
	}

	// Token: 0x06013B30 RID: 80688 RVA: 0x004EF5DC File Offset: 0x004ED7DC
	private int GetSafeMultiplierScale(FVector2D viewportSize)
	{
		Dictionary<int, int> dictionary = LocalStorage.GetGlobal<Dictionary<int, int>>(ELocalStorageGlobalKey.PhotographSetupOption, null) ?? new Dictionary<int, int>();
		int? num = dictionary.ContainsKey(8) ? new int?(dictionary[8]) : null;
		PhotoDropDown? photoDropDown = (num != null) ? ConfigPhotoDropDownById.GetConfig(num.Value, true) : null;
		int num2 = (photoDropDown != null) ? int.Parse(photoDropDown.Value.Param()[0]) : 1;
		int? intConfig = ConfigCommonParamById.GetIntConfig("PhotoMaxAllowedResolution");
		int? num3 = intConfig;
		int num4 = 0;
		if (num3.GetValueOrDefault() > num4 & num3 != null)
		{
			float num5 = Math.Max(viewportSize.X, viewportSize.Y) * (float)num2;
			num3 = intConfig;
			float? num6 = (num3 != null) ? new float?((float)num3.GetValueOrDefault()) : null;
			if (num5 > num6.GetValueOrDefault() & num6 != null)
			{
				num2 = 1;
			}
		}
		return num2;
	}

	// Token: 0x06013B31 RID: 80689 RVA: 0x004EF6E4 File Offset: 0x004ED8E4
	[NullableContext(2)]
	private unsafe void OnTakePhoto(int width, int height, TArray<FColor> colors)
	{
		if (this.CurrentTakeColors == null || width > this.CurrentTakeWidth)
		{
			this.CurrentTakeWidth = width;
			this.CurrentTakeHeight = height;
			this.CurrentTakeColors = colors;
		}
		else if (this.IsShowPlayerName)
		{
			this.CurrentTakeColors = this.CurrentWatermarkTakeColors;
			this.CurrentTakeWidth = this.CurrentWatermarkTakeWidth;
			this.CurrentTakeHeight = this.CurrentWatermarkTakeHeight;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Photo;
		ELogAuthor author = ELogAuthor.BB;
		string message = "截图完成，截图结果进行保存";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("width", width);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("height", height);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ColorSize", (colors != null) ? new int?(colors.Num()) : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		ESourcePlatformType platformType = Info.Instance.PlatformType;
		if (platformType <= ESourcePlatformType.Android)
		{
			if (platformType != ESourcePlatformType.IOS)
			{
				if (platformType == ESourcePlatformType.Android)
				{
					TArray<byte> tarray = new TArray<byte>();
					UKuroGameScreenshotBPLibrary.ConvertColorsToBitmap(this.CurrentTakeWidth, this.CurrentTakeHeight, this.CurrentTakeColors, ref tarray);
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Photo;
					ELogAuthor author2 = ELogAuthor.BB;
					string message2 = "截图保存至Android相册";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bitmapSize", (tarray != null) ? new int?(tarray.Num()) : null);
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					UKuroGameScreenshotBPLibrary.SaveColorArrayToAndroidAlbum(this.CurrentTakeWidth, this.CurrentTakeHeight, tarray);
					GenericPromptController.Instance.ShowPromptByCode("SaveGalleryPathTips", Array.Empty<object>());
					goto IL_3C2;
				}
			}
			else
			{
				if (!UKuroGameScreenshotBPLibrary.IsPhotoLibraryAuthorized())
				{
					Log.Instance.Info(ELogModule.Photo, ELogAuthor.BB, "没有获得IOS相册权限，请求权限，请求完成后再次尝试截图", default(ReadOnlySpan<ValueTuple<string, object>>));
					ScreenShotManager.RequestIOSPhotoLibraryAuthorization();
					return;
				}
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Photo;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "截图保存IOS相册";
				string item = "colors";
				TArray<FColor> currentTakeColors = this.CurrentTakeColors;
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item, (currentTakeColors != null) ? new int?(currentTakeColors.Num()) : null);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				UKuroGameScreenshotBPLibrary.SaveColorArrayToIosAlbum(this.CurrentTakeWidth, this.CurrentTakeHeight, this.CurrentTakeColors);
				GenericPromptController.Instance.ShowPromptByCode("SaveGalleryPathTips", Array.Empty<object>());
				goto IL_3C2;
			}
		}
		else
		{
			if (platformType == ESourcePlatformType.PS5)
			{
				goto IL_3C2;
			}
			if (platformType == ESourcePlatformType.OpenHarmony)
			{
				TArray<byte> tarray2 = new TArray<byte>();
				UKuroGameScreenshotBPLibrary.CompressConvertColorsToBitmap(this.CurrentTakeWidth, this.CurrentTakeHeight, this.CurrentTakeColors, ref tarray2);
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Photo;
				ELogAuthor author4 = ELogAuthor.BB;
				string message4 = "截图保存至鸿蒙相册";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("bitmapSize", (tarray2 != null) ? new int?(tarray2.Num()) : null);
				instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				UKuroGameScreenshotBPLibrary.SaveColorArrayToOpenHarmonyAlbum(this.CurrentTakeWidth, this.CurrentTakeHeight, tarray2);
				GenericPromptController.Instance.ShowPromptByCode("SaveGalleryPathTips", Array.Empty<object>());
				goto IL_3C2;
			}
		}
		string photoName = this.GetPhotoName();
		this.RelativeShotPath = this.GetRelativeShotPath(photoName);
		string filePath = UBlueprintPathsLibrary.ProjectUserDir() + this.RelativeShotPath;
		bool flag = this.CurrentTakeColors != null && this.CurrentTakeWidth >= width;
		int width2 = flag ? this.CurrentTakeWidth : width;
		int height2 = flag ? this.CurrentTakeHeight : height;
		TArray<FColor> tarray3 = flag ? this.CurrentTakeColors : colors;
		UKuroGameScreenshotBPLibrary.SaveScreenshot(filePath, width2, height2, tarray3);
		Log instance5 = Log.Instance;
		ELogModule module5 = ELogModule.Photo;
		ELogAuthor author5 = ELogAuthor.BB;
		string message5 = "截图保存至游戏安装文件夹";
		ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("path", this.RelativeShotPath);
		instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
		if (!Platform.Instance.IsCloudGame())
		{
			GenericPromptController.Instance.ShowPromptByCode("SavePathTips", new object[]
			{
				this.RelativeShotPath
			});
		}
		IL_3C2:
		this.ClosePhotoSaveView();
	}

	// Token: 0x06013B32 RID: 80690 RVA: 0x004EFABC File Offset: 0x004EDCBC
	[NullableContext(2)]
	private void OnPhotoCompressed(in TArray<byte> compressedBitmap)
	{
		Log.Instance.Info(ELogModule.Photo, ELogAuthor.BB, "PS Test OnPhotoCompressed", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (Info.Instance.PlatformType == ESourcePlatformType.PS5)
		{
			string photoName = this.GetPhotoName();
			UGameplayStatics.ExportPngPhotoFromData(compressedBitmap, photoName);
		}
	}

	// Token: 0x06013B33 RID: 80691 RVA: 0x004EFB04 File Offset: 0x004EDD04
	private unsafe void OnIOSPhotoLibraryAuthorizationCompleted(bool isGranted)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Photo;
		ELogAuthor author = ELogAuthor.BB;
		string message = "允许权限后重新截图";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isGranted", isGranted);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("width", this.CurrentTakeWidth);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("height", this.CurrentTakeHeight);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
		string item = "colorsSize";
		TArray<FColor> currentTakeColors = this.CurrentTakeColors;
		ptr = new ValueTuple<string, object>(item, (currentTakeColors != null) ? new int?(currentTakeColors.Num()) : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		if (!isGranted)
		{
			this.ClosePhotoSaveView();
			return;
		}
		if (this.CurrentTakeWidth <= 0 || this.CurrentTakeHeight <= 0 || this.CurrentTakeColors == null)
		{
			this.ClosePhotoSaveView();
			return;
		}
		UKuroGameScreenshotBPLibrary.SaveColorArrayToIosAlbum(this.CurrentTakeWidth, this.CurrentTakeHeight, this.CurrentTakeColors);
		GenericPromptController.Instance.ShowPromptByCode("SaveGalleryPathTips", Array.Empty<object>());
		this.ClosePhotoSaveView();
	}

	// Token: 0x06013B34 RID: 80692 RVA: 0x004EFC2F File Offset: 0x004EDE2F
	private void ClosePhotoSaveView()
	{
		if (PhotographController.Instance.CheckIfInEntityCamera())
		{
			UiManager.Instance.CloseView(EUiViewName.PhotoSaveView, null);
			PhotographController.Instance.ClosePhotograph(true);
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.PhotoSaveView, null);
	}

	// Token: 0x06013B35 RID: 80693 RVA: 0x004EFC6A File Offset: 0x004EDE6A
	private string GetRelativeShotPath(string photoName)
	{
		return PhotographModel.Instance.SavePath + photoName;
	}

	// Token: 0x06013B36 RID: 80694 RVA: 0x004EFC7C File Offset: 0x004EDE7C
	private void OnClickedCloseButton()
	{
		if (!this.IsPhoto)
		{
			base.CloseMe(null);
			return;
		}
		this.ClosePhotoSaveView();
	}

	// Token: 0x06013B37 RID: 80695 RVA: 0x004EFC94 File Offset: 0x004EDE94
	private void OnClickRetake()
	{
		PhotographController.Instance.ResetShotStateForRetake();
		PhotographController.Instance.UpdateMissionOptionToFinished(false, false);
		base.CloseMe(null);
	}

	// Token: 0x06013B38 RID: 80696 RVA: 0x004EFCB3 File Offset: 0x004EDEB3
	private void OnClickPersonalInfoShow(EToggleState toggleState)
	{
		LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.PhotoAndShareShowPlayerName, toggleState == EToggleState.ETT_Checked);
		this.IsShowPlayerName = (toggleState == EToggleState.ETT_Checked);
		PhotoSaveMarkItem markItem = this.MarkItem;
		if (markItem != null)
		{
			markItem.SetUiActive(toggleState == EToggleState.ETT_Checked);
		}
		EventSystem.Instance.Emit(EEventName.OnPhotoSaveViewPersonalInfoShowRefresh);
	}

	// Token: 0x06013B39 RID: 80697 RVA: 0x004EFCF0 File Offset: 0x004EDEF0
	private void EntityCameraFinished(bool judgement)
	{
		if (!PhotographController.Instance.CheckIfInMission())
		{
			base.GetItem(7).SetUIActive(false);
			base.GetSprite(9).SetUIActive(false);
			base.GetSprite(8).SetUIActive(false);
			return;
		}
		if (judgement)
		{
			base.GetItem(7).SetUIActive(true);
			base.GetSprite(9).SetUIActive(true);
			base.GetSprite(8).SetUIActive(false);
			LguiUtil.Instance.SetLocalText(base.GetText(10), "FindAllConditionsTrue", Array.Empty<object>());
			this.RefreshBtnEmpty();
			return;
		}
		base.GetItem(7).SetUIActive(true);
		base.GetSprite(9).SetUIActive(false);
		base.GetSprite(8).SetUIActive(true);
		LguiUtil.Instance.SetLocalText(base.GetText(10), "FindAllConditionsFalse", Array.Empty<object>());
		this.RefreshRetakeBtn();
	}

	// Token: 0x06013B3A RID: 80698 RVA: 0x004EFDCC File Offset: 0x004EDFCC
	private void RefreshFirstShare()
	{
		bool flag = !PhotographController.Instance.CheckIfInEntityCamera() && ChannelModel.Instance.CouldGetShareReward(this.ShareActionId);
		base.GetItem(this.IsPhoto ? 27 : 28).SetUIActive(flag);
		if (flag)
		{
			ShareReward? config = ConfigShareRewardById.GetConfig((int)this.ShareActionId, true);
			if (config == null)
			{
				return;
			}
			Dictionary<int, int> dictionary = config.Value.Reward();
			int itemConfigId = 0;
			int num = 0;
			using (Dictionary<int, int>.Enumerator enumerator = dictionary.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<int, int> keyValuePair = enumerator.Current;
					itemConfigId = keyValuePair.Key;
					num = keyValuePair.Value;
				}
			}
			string iconSmall = InventoryConfig.Instance.GetItemConfig(itemConfigId).Value.IconSmall;
			UUITexture texture = base.GetTexture(this.IsPhoto ? 32 : 33);
			texture.SetUIActive(false);
			base.SetTextureByPath(iconSmall, texture, null, delegate(bool _)
			{
				texture.SetUIActive(true);
			});
			base.GetText(this.IsPhoto ? 25 : 26).SetText(num.ToString(), true);
		}
	}

	// Token: 0x06013B3B RID: 80699 RVA: 0x004EFF24 File Offset: 0x004EE124
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.PhotoSaveView || viewName == EUiViewName.NetWorkMaskView || viewName == EUiViewName.ConfirmBoxView)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06013B3C RID: 80700 RVA: 0x004EFF58 File Offset: 0x004EE158
	private void Reset()
	{
		this.CurrentTakeWidth = 0;
		this.CurrentTakeHeight = 0;
		this.CurrentTakeColors = null;
		UiLayer.Instance.SetLayerActive(ELayerType.Float, true);
		UiLayer.Instance.SetLayerActive(ELayerType.Pop, true);
		LoadingController.Instance.UpdateUidViewShow();
		if (!UiManager.Instance.IsViewShow(EUiViewName.PhotographView))
		{
			UiLayer.Instance.SetLayerActive(ELayerType.HUD, true);
		}
		ScreenShotManager.ResetScreenShot();
	}

	// Token: 0x06013B3D RID: 80701 RVA: 0x004EFFC4 File Offset: 0x004EE1C4
	private UniTask WaitForNextTick()
	{
		PhotoSaveView.<WaitForNextTick>d__87 <WaitForNextTick>d__;
		<WaitForNextTick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitForNextTick>d__.<>1__state = -1;
		<WaitForNextTick>d__.<>t__builder.Start<PhotoSaveView.<WaitForNextTick>d__87>(ref <WaitForNextTick>d__);
		return <WaitForNextTick>d__.<>t__builder.Task;
	}

	// Token: 0x06013B3E RID: 80702 RVA: 0x004F0000 File Offset: 0x004EE200
	private UniTask PrepareScreenShotAsync(bool isFirst)
	{
		PhotoSaveView.<PrepareScreenShotAsync>d__88 <PrepareScreenShotAsync>d__;
		<PrepareScreenShotAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PrepareScreenShotAsync>d__.<>4__this = this;
		<PrepareScreenShotAsync>d__.isFirst = isFirst;
		<PrepareScreenShotAsync>d__.<>1__state = -1;
		<PrepareScreenShotAsync>d__.<>t__builder.Start<PhotoSaveView.<PrepareScreenShotAsync>d__88>(ref <PrepareScreenShotAsync>d__);
		return <PrepareScreenShotAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013B3F RID: 80703 RVA: 0x004F004B File Offset: 0x004EE24B
	[CompilerGenerated]
	internal static int <GetSortTenGachaInfos>g__RevertType|39_0(InventoryDefine.EItemDataType type)
	{
		switch (type)
		{
		case InventoryDefine.EItemDataType.RoleItem:
			return 2;
		case InventoryDefine.EItemDataType.WeaponItem:
			return 1;
		}
		return 0;
	}

	// Token: 0x0400944E RID: 37966
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PhotoShareBtnItem, EChannelShare> ShareBtnLayout;

	// Token: 0x0400944F RID: 37967
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<GachaShareSwitchItem, GachaShareSwitchData> GachaSwitchLayout;

	// Token: 0x04009450 RID: 37968
	private bool IsPhoto = true;

	// Token: 0x04009451 RID: 37969
	private bool PrepareFullScreenShot;

	// Token: 0x04009452 RID: 37970
	private bool CaptureFullScene;

	// Token: 0x04009453 RID: 37971
	private string RelativeShotPath = "";

	// Token: 0x04009454 RID: 37972
	[Nullable(2)]
	private PhotoSaveMarkItem MarkItem;

	// Token: 0x04009455 RID: 37973
	[Nullable(2)]
	private GachaShareOnePanel GachaView;

	// Token: 0x04009456 RID: 37974
	[Nullable(2)]
	private GachaShareTenPanel GachaViewTen;

	// Token: 0x04009457 RID: 37975
	[Nullable(2)]
	private FragmentMemoryShareView FragmentMemoryShareViewRef;

	// Token: 0x04009458 RID: 37976
	[Nullable(2)]
	private RoleSkinShareView RoleSkinShareView;

	// Token: 0x04009459 RID: 37977
	[Nullable(2)]
	private VersionPreheatSharePanel VersionPreheatView;

	// Token: 0x0400945A RID: 37978
	[Nullable(2)]
	private Spring25SharePanel Spring25View;

	// Token: 0x0400945B RID: 37979
	[Nullable(2)]
	private HandBookPhotoShareView HandBookPhotoShareView;

	// Token: 0x0400945C RID: 37980
	[Nullable(2)]
	private TowerVariationShareView TowerVariationShareView;

	// Token: 0x0400945D RID: 37981
	private WheelTowerTotalScoreSharePanel WheelTowerTotalScoreView;

	// Token: 0x0400945E RID: 37982
	private WheelTowerSettlementShareView WheelTowerSettlementShareView;

	// Token: 0x0400945F RID: 37983
	private ShipTowerSharePanel ChallengeRecordShareView;

	// Token: 0x04009460 RID: 37984
	private EShareActionId ShareActionId = EShareActionId.Photo;

	// Token: 0x04009461 RID: 37985
	private EShareReportExtraType ShareReportExtraType;

	// Token: 0x04009462 RID: 37986
	private int CurrentTakeWidth;

	// Token: 0x04009463 RID: 37987
	private int CurrentTakeHeight;

	// Token: 0x04009464 RID: 37988
	[Nullable(2)]
	private TArray<FColor> CurrentTakeColors;

	// Token: 0x04009465 RID: 37989
	private int CurrentWatermarkTakeWidth;

	// Token: 0x04009466 RID: 37990
	private int CurrentWatermarkTakeHeight;

	// Token: 0x04009467 RID: 37991
	[Nullable(2)]
	private TArray<FColor> CurrentWatermarkTakeColors;

	// Token: 0x04009468 RID: 37992
	private FVector? PanelItemOriginalScale;

	// Token: 0x04009469 RID: 37993
	private bool IsShowPlayerName;

	// Token: 0x02008BFC RID: 35836
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D71C RID: 186140
		PhotoTexture,
		// Token: 0x0402D71D RID: 186141
		PhotoFrameItem,
		// Token: 0x0402D71E RID: 186142
		CloseButton,
		// Token: 0x0402D71F RID: 186143
		BlackBgSprite,
		// Token: 0x0402D720 RID: 186144
		BtnParent,
		// Token: 0x0402D721 RID: 186145
		ShareBtnLayout,
		// Token: 0x0402D722 RID: 186146
		SaveButton,
		// Token: 0x0402D723 RID: 186147
		PnlTips,
		// Token: 0x0402D724 RID: 186148
		SprCross,
		// Token: 0x0402D725 RID: 186149
		SprTick,
		// Token: 0x0402D726 RID: 186150
		TxtConditions,
		// Token: 0x0402D727 RID: 186151
		MinItemPhoto,
		// Token: 0x0402D728 RID: 186152
		MaxItemPhoto,
		// Token: 0x0402D729 RID: 186153
		PhotoItem,
		// Token: 0x0402D72A RID: 186154
		PhotoPanel,
		// Token: 0x0402D72B RID: 186155
		LandscapePanel,
		// Token: 0x0402D72C RID: 186156
		TypeText,
		// Token: 0x0402D72D RID: 186157
		NameText,
		// Token: 0x0402D72E RID: 186158
		DateText,
		// Token: 0x0402D72F RID: 186159
		LandscapeTexture,
		// Token: 0x0402D730 RID: 186160
		DescriptionText,
		// Token: 0x0402D731 RID: 186161
		MarkItemPhoto,
		// Token: 0x0402D732 RID: 186162
		MarkItemLandscape,
		// Token: 0x0402D733 RID: 186163
		MinItemLandscape,
		// Token: 0x0402D734 RID: 186164
		MaxItemLandscape,
		// Token: 0x0402D735 RID: 186165
		TxtCostPhoto,
		// Token: 0x0402D736 RID: 186166
		TxtCostLandscape,
		// Token: 0x0402D737 RID: 186167
		FirstPhoto,
		// Token: 0x0402D738 RID: 186168
		FirstLandscape,
		// Token: 0x0402D739 RID: 186169
		RetakeButton,
		// Token: 0x0402D73A RID: 186170
		LineParent,
		// Token: 0x0402D73B RID: 186171
		LineItem,
		// Token: 0x0402D73C RID: 186172
		TextureCostPhoto,
		// Token: 0x0402D73D RID: 186173
		TextureCostLandscape,
		// Token: 0x0402D73E RID: 186174
		PersonalInfoTogglePhoto,
		// Token: 0x0402D73F RID: 186175
		PersonalInfoToggleLandscape,
		// Token: 0x0402D740 RID: 186176
		SubViewRoot,
		// Token: 0x0402D741 RID: 186177
		ExternalTexture,
		// Token: 0x0402D742 RID: 186178
		GachaSwitchLayout,
		// Token: 0x0402D743 RID: 186179
		GachaSwitchItem
	}
}
