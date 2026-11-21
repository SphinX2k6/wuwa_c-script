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

// Token: 0x02001AC7 RID: 6855
[NullableContext(1)]
[Nullable(0)]
public class PhotoSaveView : UiViewBase
{
	// Token: 0x06010FE3 RID: 69603 RVA: 0x004FCBE0 File Offset: 0x004FADE0
	public PhotoSaveView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010FE4 RID: 69604 RVA: 0x004FCC04 File Offset: 0x004FAE04
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

	// Token: 0x06010FE5 RID: 69605 RVA: 0x004FD01C File Offset: 0x004FB21C
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoSaveView.<OnBeforeStartAsync>d__32 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoSaveView.<OnBeforeStartAsync>d__32>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010FE6 RID: 69606 RVA: 0x004FD05F File Offset: 0x004FB25F
	private PhotoShareBtnItem InitShareBtn()
	{
		PhotoShareBtnItem photoShareBtnItem = new PhotoShareBtnItem();
		photoShareBtnItem.SetClickCallBack(new Action<EChannelShare, int>(this.OnClickShareBtn));
		return photoShareBtnItem;
	}

	// Token: 0x06010FE7 RID: 69607 RVA: 0x004FD078 File Offset: 0x004FB278
	private GachaShareSwitchItem InitGachaShareSwitchItem()
	{
		GachaShareSwitchItem gachaShareSwitchItem = new GachaShareSwitchItem();
		gachaShareSwitchItem.SetToggleClickCallback(new Action<GachaShareSwitchData, int>(this.OnClickGachaSwitchItem));
		return gachaShareSwitchItem;
	}

	// Token: 0x06010FE8 RID: 69608 RVA: 0x004FD094 File Offset: 0x004FB294
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

	// Token: 0x06010FE9 RID: 69609 RVA: 0x004FD14C File Offset: 0x004FB34C
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

	// Token: 0x06010FEA RID: 69610 RVA: 0x004FD194 File Offset: 0x004FB394
	private UniTask RefreshGachaView(IReadOnlyList<GachaResult> gachaInfos)
	{
		PhotoSaveView.<RefreshGachaView>d__37 <RefreshGachaView>d__;
		<RefreshGachaView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshGachaView>d__.<>4__this = this;
		<RefreshGachaView>d__.gachaInfos = gachaInfos;
		<RefreshGachaView>d__.<>1__state = -1;
		<RefreshGachaView>d__.<>t__builder.Start<PhotoSaveView.<RefreshGachaView>d__37>(ref <RefreshGachaView>d__);
		return <RefreshGachaView>d__.<>t__builder.Task;
	}

	// Token: 0x06010FEB RID: 69611 RVA: 0x004FD1E0 File Offset: 0x004FB3E0
	[NullableContext(2)]
	private UniTask RefreshOneGachaView(GachaResult gachaInfo)
	{
		PhotoSaveView.<RefreshOneGachaView>d__38 <RefreshOneGachaView>d__;
		<RefreshOneGachaView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshOneGachaView>d__.<>4__this = this;
		<RefreshOneGachaView>d__.gachaInfo = gachaInfo;
		<RefreshOneGachaView>d__.<>1__state = -1;
		<RefreshOneGachaView>d__.<>t__builder.Start<PhotoSaveView.<RefreshOneGachaView>d__38>(ref <RefreshOneGachaView>d__);
		return <RefreshOneGachaView>d__.<>t__builder.Task;
	}

	// Token: 0x06010FEC RID: 69612 RVA: 0x004FD22C File Offset: 0x004FB42C
	private UniTask RefreshTenGachaView(IReadOnlyList<GachaResult> gachaInfos)
	{
		PhotoSaveView.<RefreshTenGachaView>d__39 <RefreshTenGachaView>d__;
		<RefreshTenGachaView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTenGachaView>d__.<>4__this = this;
		<RefreshTenGachaView>d__.gachaInfos = gachaInfos;
		<RefreshTenGachaView>d__.<>1__state = -1;
		<RefreshTenGachaView>d__.<>t__builder.Start<PhotoSaveView.<RefreshTenGachaView>d__39>(ref <RefreshTenGachaView>d__);
		return <RefreshTenGachaView>d__.<>t__builder.Task;
	}

	// Token: 0x06010FED RID: 69613 RVA: 0x004FD277 File Offset: 0x004FB477
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
				int num3 = PhotoSaveView.<GetSortTenGachaInfos>g__RevertType|40_0(GachaConfig.Instance.GetItemIdType(a.Proto_GachaReward.ItemId));
				return PhotoSaveView.<GetSortTenGachaInfos>g__RevertType|40_0(GachaConfig.Instance.GetItemIdType(b.Proto_GachaReward.ItemId)) - num3;
			}
			return num2 - num;
		});
		return list;
	}

	// Token: 0x06010FEE RID: 69614 RVA: 0x004FD2A4 File Offset: 0x004FB4A4
	private UniTask InitFragmentMemorySubView(FragmentMemoryCollectData data)
	{
		PhotoSaveView.<InitFragmentMemorySubView>d__41 <InitFragmentMemorySubView>d__;
		<InitFragmentMemorySubView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitFragmentMemorySubView>d__.<>4__this = this;
		<InitFragmentMemorySubView>d__.data = data;
		<InitFragmentMemorySubView>d__.<>1__state = -1;
		<InitFragmentMemorySubView>d__.<>t__builder.Start<PhotoSaveView.<InitFragmentMemorySubView>d__41>(ref <InitFragmentMemorySubView>d__);
		return <InitFragmentMemorySubView>d__.<>t__builder.Task;
	}

	// Token: 0x06010FEF RID: 69615 RVA: 0x004FD2F0 File Offset: 0x004FB4F0
	private UniTask InitRoleSkinSubView(RoleSkinData data)
	{
		PhotoSaveView.<InitRoleSkinSubView>d__42 <InitRoleSkinSubView>d__;
		<InitRoleSkinSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleSkinSubView>d__.<>4__this = this;
		<InitRoleSkinSubView>d__.data = data;
		<InitRoleSkinSubView>d__.<>1__state = -1;
		<InitRoleSkinSubView>d__.<>t__builder.Start<PhotoSaveView.<InitRoleSkinSubView>d__42>(ref <InitRoleSkinSubView>d__);
		return <InitRoleSkinSubView>d__.<>t__builder.Task;
	}

	// Token: 0x06010FF0 RID: 69616 RVA: 0x004FD33C File Offset: 0x004FB53C
	private UniTask InitWheelTowerSettlementShareView(IWheelTowerSettlementViewData data)
	{
		PhotoSaveView.<InitWheelTowerSettlementShareView>d__43 <InitWheelTowerSettlementShareView>d__;
		<InitWheelTowerSettlementShareView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitWheelTowerSettlementShareView>d__.<>4__this = this;
		<InitWheelTowerSettlementShareView>d__.data = data;
		<InitWheelTowerSettlementShareView>d__.<>1__state = -1;
		<InitWheelTowerSettlementShareView>d__.<>t__builder.Start<PhotoSaveView.<InitWheelTowerSettlementShareView>d__43>(ref <InitWheelTowerSettlementShareView>d__);
		return <InitWheelTowerSettlementShareView>d__.<>t__builder.Task;
	}

	// Token: 0x06010FF1 RID: 69617 RVA: 0x004FD388 File Offset: 0x004FB588
	private UniTask InitWheelTowerTotalScoreView()
	{
		PhotoSaveView.<InitWheelTowerTotalScoreView>d__44 <InitWheelTowerTotalScoreView>d__;
		<InitWheelTowerTotalScoreView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitWheelTowerTotalScoreView>d__.<>4__this = this;
		<InitWheelTowerTotalScoreView>d__.<>1__state = -1;
		<InitWheelTowerTotalScoreView>d__.<>t__builder.Start<PhotoSaveView.<InitWheelTowerTotalScoreView>d__44>(ref <InitWheelTowerTotalScoreView>d__);
		return <InitWheelTowerTotalScoreView>d__.<>t__builder.Task;
	}

	// Token: 0x06010FF2 RID: 69618 RVA: 0x004FD3CC File Offset: 0x004FB5CC
	private UniTask InitChallengeRecordShareView(ShipTowerRecordShareData data)
	{
		PhotoSaveView.<InitChallengeRecordShareView>d__45 <InitChallengeRecordShareView>d__;
		<InitChallengeRecordShareView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChallengeRecordShareView>d__.<>4__this = this;
		<InitChallengeRecordShareView>d__.data = data;
		<InitChallengeRecordShareView>d__.<>1__state = -1;
		<InitChallengeRecordShareView>d__.<>t__builder.Start<PhotoSaveView.<InitChallengeRecordShareView>d__45>(ref <InitChallengeRecordShareView>d__);
		return <InitChallengeRecordShareView>d__.<>t__builder.Task;
	}

	// Token: 0x06010FF3 RID: 69619 RVA: 0x004FD418 File Offset: 0x004FB618
	private UniTask InitHandBookPhotoShareView(HandBookPhotoData data)
	{
		PhotoSaveView.<InitHandBookPhotoShareView>d__46 <InitHandBookPhotoShareView>d__;
		<InitHandBookPhotoShareView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitHandBookPhotoShareView>d__.<>4__this = this;
		<InitHandBookPhotoShareView>d__.data = data;
		<InitHandBookPhotoShareView>d__.<>1__state = -1;
		<InitHandBookPhotoShareView>d__.<>t__builder.Start<PhotoSaveView.<InitHandBookPhotoShareView>d__46>(ref <InitHandBookPhotoShareView>d__);
		return <InitHandBookPhotoShareView>d__.<>t__builder.Task;
	}

	// Token: 0x06010FF4 RID: 69620 RVA: 0x004FD464 File Offset: 0x004FB664
	private UniTask InitTowerVariationShareView()
	{
		PhotoSaveView.<InitTowerVariationShareView>d__47 <InitTowerVariationShareView>d__;
		<InitTowerVariationShareView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTowerVariationShareView>d__.<>4__this = this;
		<InitTowerVariationShareView>d__.<>1__state = -1;
		<InitTowerVariationShareView>d__.<>t__builder.Start<PhotoSaveView.<InitTowerVariationShareView>d__47>(ref <InitTowerVariationShareView>d__);
		return <InitTowerVariationShareView>d__.<>t__builder.Task;
	}

	// Token: 0x06010FF5 RID: 69621 RVA: 0x004FD4A8 File Offset: 0x004FB6A8
	private UniTask InitVersionPreheatSubView(VersionPreheatShareData data)
	{
		PhotoSaveView.<InitVersionPreheatSubView>d__48 <InitVersionPreheatSubView>d__;
		<InitVersionPreheatSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitVersionPreheatSubView>d__.<>4__this = this;
		<InitVersionPreheatSubView>d__.data = data;
		<InitVersionPreheatSubView>d__.<>1__state = -1;
		<InitVersionPreheatSubView>d__.<>t__builder.Start<PhotoSaveView.<InitVersionPreheatSubView>d__48>(ref <InitVersionPreheatSubView>d__);
		return <InitVersionPreheatSubView>d__.<>t__builder.Task;
	}

	// Token: 0x06010FF6 RID: 69622 RVA: 0x004FD4F4 File Offset: 0x004FB6F4
	private UniTask InitSpring25SubView(Spring25ShareData data)
	{
		PhotoSaveView.<InitSpring25SubView>d__49 <InitSpring25SubView>d__;
		<InitSpring25SubView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSpring25SubView>d__.<>4__this = this;
		<InitSpring25SubView>d__.data = data;
		<InitSpring25SubView>d__.<>1__state = -1;
		<InitSpring25SubView>d__.<>t__builder.Start<PhotoSaveView.<InitSpring25SubView>d__49>(ref <InitSpring25SubView>d__);
		return <InitSpring25SubView>d__.<>t__builder.Task;
	}

	// Token: 0x06010FF7 RID: 69623 RVA: 0x004FD540 File Offset: 0x004FB740
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

	// Token: 0x06010FF8 RID: 69624 RVA: 0x004FD658 File Offset: 0x004FB858
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

	// Token: 0x06010FF9 RID: 69625 RVA: 0x004FD7D4 File Offset: 0x004FB9D4
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

	// Token: 0x06010FFA RID: 69626 RVA: 0x004FD8C8 File Offset: 0x004FBAC8
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

	// Token: 0x06010FFB RID: 69627 RVA: 0x004FD900 File Offset: 0x004FBB00
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

	// Token: 0x06010FFC RID: 69628 RVA: 0x004FD9B8 File Offset: 0x004FBBB8
	private bool GetIfShareBtnCanShow()
	{
		return !BaseConfigController.Instance.GetIosAuditFirstDownloadTip();
	}

	// Token: 0x06010FFD RID: 69629 RVA: 0x004FD9CC File Offset: 0x004FBBCC
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

	// Token: 0x06010FFE RID: 69630 RVA: 0x004FDA18 File Offset: 0x004FBC18
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

	// Token: 0x06010FFF RID: 69631 RVA: 0x004FDAC0 File Offset: 0x004FBCC0
	private void RefreshRetakeBtn()
	{
		base.GetItem(31).SetUIActive(false);
		base.GetItem(30).SetUIActive(true);
		base.GetButton(29).RootUIComp.Get().SetUIActive(true);
		base.GetHorizontalLayout(5).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06011000 RID: 69632 RVA: 0x004FDB20 File Offset: 0x004FBD20
	private void RefreshBtnEmpty()
	{
		base.GetItem(30).SetUIActive(false);
		base.GetButton(29).RootUIComp.Get().SetUIActive(false);
		base.GetHorizontalLayout(5).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06011001 RID: 69633 RVA: 0x004FDB70 File Offset: 0x004FBD70
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnEntityCameraFinished, new Action<bool>(this.EntityCameraFinished));
		EventSystem.Instance.Add(EEventName.OnFirstShare, new Action(this.RefreshFirstShare));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
	}

	// Token: 0x06011002 RID: 69634 RVA: 0x004FDBD0 File Offset: 0x004FBDD0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnEntityCameraFinished, new Action<bool>(this.EntityCameraFinished));
		EventSystem.Instance.Remove(EEventName.OnFirstShare, new Action(this.RefreshFirstShare));
		EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
	}

	// Token: 0x06011003 RID: 69635 RVA: 0x004FDC2D File Offset: 0x004FBE2D
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

	// Token: 0x06011004 RID: 69636 RVA: 0x004FDC68 File Offset: 0x004FBE68
	private UniTask OnAfterShowPrepareFullScreenAsync()
	{
		PhotoSaveView.<OnAfterShowPrepareFullScreenAsync>d__63 <OnAfterShowPrepareFullScreenAsync>d__;
		<OnAfterShowPrepareFullScreenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnAfterShowPrepareFullScreenAsync>d__.<>4__this = this;
		<OnAfterShowPrepareFullScreenAsync>d__.<>1__state = -1;
		<OnAfterShowPrepareFullScreenAsync>d__.<>t__builder.Start<PhotoSaveView.<OnAfterShowPrepareFullScreenAsync>d__63>(ref <OnAfterShowPrepareFullScreenAsync>d__);
		return <OnAfterShowPrepareFullScreenAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011005 RID: 69637 RVA: 0x004FDCAB File Offset: 0x004FBEAB
	protected override void OnBeforeDestroy()
	{
		this.RestorePhotographUiAfterCapture();
		UKuroRenderingRuntimeBPPluginBPLibrary.ReleaseGetSceneColorShotBefore();
		GenericLayout<PhotoShareBtnItem, EChannelShare> shareBtnLayout = this.ShareBtnLayout;
		if (shareBtnLayout != null)
		{
			shareBtnLayout.ClearChildren();
		}
		this.ShareBtnLayout = null;
		this.Reset();
	}

	// Token: 0x06011006 RID: 69638 RVA: 0x004FDCD8 File Offset: 0x004FBED8
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

	// Token: 0x06011007 RID: 69639 RVA: 0x004FDDB8 File Offset: 0x004FBFB8
	private void PlayScreenShotSequence()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("ScreenShot", false, null);
	}

	// Token: 0x06011008 RID: 69640 RVA: 0x004FDDE4 File Offset: 0x004FBFE4
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

	// Token: 0x06011009 RID: 69641 RVA: 0x004FDE40 File Offset: 0x004FC040
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

	// Token: 0x0601100A RID: 69642 RVA: 0x004FDEED File Offset: 0x004FC0ED
	private void OnRequestPermissionCallback(bool isAllowed)
	{
		if (isAllowed)
		{
			this.TakeScreenshot(true, new Action<int, int, TArray<FColor>>(this.OnTakePhoto), new Action<bool>(this.OnIOSPhotoLibraryAuthorizationCompleted), null);
			return;
		}
		this.OnPhotoPermissionDenied();
	}

	// Token: 0x0601100B RID: 69643 RVA: 0x004FDF1C File Offset: 0x004FC11C
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

	// Token: 0x0601100C RID: 69644 RVA: 0x004FDF80 File Offset: 0x004FC180
	private string GetPhotoName()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		return TimeUtil.Instance.DateFormatString2(serverTime) + ".png";
	}

	// Token: 0x0601100D RID: 69645 RVA: 0x004FDFB0 File Offset: 0x004FC1B0
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

	// Token: 0x0601100E RID: 69646 RVA: 0x004FE044 File Offset: 0x004FC244
	[NullableContext(2)]
	private void TakeScreenshot(bool isSaveFile, [Nullable(new byte[]
	{
		1,
		2
	})] Action<int, int, TArray<FColor>> onTakeScreenShotCallback, Action<bool> onIOSPhotoLibraryAuthorizationCompleted = null, FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate onPhotoCompressed = null)
	{
		bool pngOnly = isSaveFile && Info.Instance.PlatformType == ESourcePlatformType.PS5;
		if (pngOnly)
		{
			onPhotoCompressed = new FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate(this.OnPhotoCompressed);
		}
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
			this.RestoreCaptureUi = delegate()
			{
				EventSystem.Instance.Emit<bool, bool>(EEventName.OnPhotographViewCaptureMode, false, false);
				EventSystem.Instance.Emit<bool>(EEventName.OnPreparePhotoScreenShot, true);
			};
			Action<int, int, TArray<FColor>> <>9__2;
			TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				if (this.IsDestroyOrDestroying)
				{
					this.RestorePhotographUiAfterCapture();
					return;
				}
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
				if (!pngOnly)
				{
					if ((onCaptured = <>9__2) == null)
					{
						onCaptured = (<>9__2 = delegate(int w, int h, TArray<FColor> c)
						{
							this.RestorePhotographUiAfterCapture();
							onTakeScreenShotCallback(w, h, c);
						});
					}
				}
				else
				{
					onCaptured = null;
				}
				if (!<>4__this.RunScreenShot(storagePath, minX, minY, maxX, maxY, isSaveFile2, viewportSize, multiplierScale, isHighRes, onCaptured, onIOSPhotoLibraryAuthorizationCompleted, onPhotoCompressed))
				{
					Log.Instance.Error(ELogModule.Photo, ELogAuthor.CXJ, "延迟场景截图：截图任务启动失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.RestorePhotographUiAfterCapture();
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
		this.RunScreenShot(storagePath, (int)captureRange[0], (int)captureRange[1], (int)captureRange[2], (int)captureRange[3], isSaveFile, viewportSize, multiplierScale, false, pngOnly ? null : onTakeScreenShotCallback, onIOSPhotoLibraryAuthorizationCompleted, onPhotoCompressed);
	}

	// Token: 0x0601100F RID: 69647 RVA: 0x004FE1ED File Offset: 0x004FC3ED
	private void RestorePhotographUiAfterCapture()
	{
		Action restoreCaptureUi = this.RestoreCaptureUi;
		this.RestoreCaptureUi = null;
		if (restoreCaptureUi == null)
		{
			return;
		}
		restoreCaptureUi();
	}

	// Token: 0x06011010 RID: 69648 RVA: 0x004FE208 File Offset: 0x004FC408
	[NullableContext(2)]
	private bool RunScreenShot([Nullable(1)] string storagePath, int minX, int minY, int maxX, int maxY, bool isSaveFile, FVector2D viewportSize, int multiplierScale, bool isHighRes, Action<int, int, TArray<FColor>> onCaptured, Action<bool> onIOSPhotoLibraryAuthorizationCompleted = null, FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate onPhotoCompressed = null)
	{
		UGameScreenshotTask ugameScreenshotTask = ScreenShotManager.PrepareTakeScreenshot(storagePath, (float)minX, (float)minY, (float)maxX, (float)maxY, isSaveFile, viewportSize.X, viewportSize.Y, multiplierScale);
		if (ugameScreenshotTask == null)
		{
			return false;
		}
		if (onCaptured != null)
		{
			ugameScreenshotTask.OnTakeScreenshotCapturedDelegate.Add(delegate(int w, int h, in TArray<FColor> c)
			{
				onCaptured(w, h, c);
			});
		}
		if (onIOSPhotoLibraryAuthorizationCompleted != null)
		{
			ugameScreenshotTask.OnIOSPhotoLibraryAuthorizationCompletedDelegate.Add(onIOSPhotoLibraryAuthorizationCompleted);
		}
		if (onPhotoCompressed != null)
		{
			ugameScreenshotTask.OnTakeScreenshotCompressedDelegate.Add(onPhotoCompressed);
		}
		bool flag = isHighRes ? ugameScreenshotTask.TakeScreenshotHighRes(multiplierScale) : ugameScreenshotTask.TakeScreenshot();
		if (!flag)
		{
			ScreenShotManager.ResetScreenShot();
		}
		return flag;
	}

	// Token: 0x06011011 RID: 69649 RVA: 0x004FE2A8 File Offset: 0x004FC4A8
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

	// Token: 0x06011012 RID: 69650 RVA: 0x004FE3B0 File Offset: 0x004FC5B0
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

	// Token: 0x06011013 RID: 69651 RVA: 0x004FE788 File Offset: 0x004FC988
	[NullableContext(2)]
	private void OnPhotoCompressed(in TArray<byte> compressedBitmap)
	{
		Log.Instance.Info(ELogModule.Photo, ELogAuthor.BB, "PS Test OnPhotoCompressed", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (Info.Instance.PlatformType == ESourcePlatformType.PS5)
		{
			try
			{
				string photoName = this.GetPhotoName();
				UGameplayStatics.ExportPngPhotoFromData(compressedBitmap, photoName);
			}
			finally
			{
				this.FinishPs5PhotoNextFrameAsync().Forget();
			}
		}
	}

	// Token: 0x06011014 RID: 69652 RVA: 0x004FE7F0 File Offset: 0x004FC9F0
	private UniTask FinishPs5PhotoNextFrameAsync()
	{
		PhotoSaveView.<FinishPs5PhotoNextFrameAsync>d__79 <FinishPs5PhotoNextFrameAsync>d__;
		<FinishPs5PhotoNextFrameAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FinishPs5PhotoNextFrameAsync>d__.<>4__this = this;
		<FinishPs5PhotoNextFrameAsync>d__.<>1__state = -1;
		<FinishPs5PhotoNextFrameAsync>d__.<>t__builder.Start<PhotoSaveView.<FinishPs5PhotoNextFrameAsync>d__79>(ref <FinishPs5PhotoNextFrameAsync>d__);
		return <FinishPs5PhotoNextFrameAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011015 RID: 69653 RVA: 0x004FE834 File Offset: 0x004FCA34
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

	// Token: 0x06011016 RID: 69654 RVA: 0x004FE95F File Offset: 0x004FCB5F
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

	// Token: 0x06011017 RID: 69655 RVA: 0x004FE99A File Offset: 0x004FCB9A
	private string GetRelativeShotPath(string photoName)
	{
		return PhotographModel.Instance.SavePath + photoName;
	}

	// Token: 0x06011018 RID: 69656 RVA: 0x004FE9AC File Offset: 0x004FCBAC
	private void OnClickedCloseButton()
	{
		if (!this.IsPhoto)
		{
			base.CloseMe(null);
			return;
		}
		this.ClosePhotoSaveView();
	}

	// Token: 0x06011019 RID: 69657 RVA: 0x004FE9C4 File Offset: 0x004FCBC4
	private void OnClickRetake()
	{
		PhotographController.Instance.ResetShotStateForRetake();
		PhotographController.Instance.UpdateMissionOptionToFinished(false, false);
		base.CloseMe(null);
	}

	// Token: 0x0601101A RID: 69658 RVA: 0x004FE9E3 File Offset: 0x004FCBE3
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

	// Token: 0x0601101B RID: 69659 RVA: 0x004FEA20 File Offset: 0x004FCC20
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

	// Token: 0x0601101C RID: 69660 RVA: 0x004FEAFC File Offset: 0x004FCCFC
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

	// Token: 0x0601101D RID: 69661 RVA: 0x004FEC54 File Offset: 0x004FCE54
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.PhotoSaveView || viewName == EUiViewName.NetWorkMaskView || viewName == EUiViewName.ConfirmBoxView)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0601101E RID: 69662 RVA: 0x004FEC88 File Offset: 0x004FCE88
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

	// Token: 0x0601101F RID: 69663 RVA: 0x004FECF4 File Offset: 0x004FCEF4
	private UniTask WaitForNextTick()
	{
		PhotoSaveView.<WaitForNextTick>d__90 <WaitForNextTick>d__;
		<WaitForNextTick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitForNextTick>d__.<>1__state = -1;
		<WaitForNextTick>d__.<>t__builder.Start<PhotoSaveView.<WaitForNextTick>d__90>(ref <WaitForNextTick>d__);
		return <WaitForNextTick>d__.<>t__builder.Task;
	}

	// Token: 0x06011020 RID: 69664 RVA: 0x004FED30 File Offset: 0x004FCF30
	private UniTask PrepareScreenShotAsync(bool isFirst)
	{
		PhotoSaveView.<PrepareScreenShotAsync>d__91 <PrepareScreenShotAsync>d__;
		<PrepareScreenShotAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PrepareScreenShotAsync>d__.<>4__this = this;
		<PrepareScreenShotAsync>d__.isFirst = isFirst;
		<PrepareScreenShotAsync>d__.<>1__state = -1;
		<PrepareScreenShotAsync>d__.<>t__builder.Start<PhotoSaveView.<PrepareScreenShotAsync>d__91>(ref <PrepareScreenShotAsync>d__);
		return <PrepareScreenShotAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011021 RID: 69665 RVA: 0x004FED7B File Offset: 0x004FCF7B
	[CompilerGenerated]
	internal static int <GetSortTenGachaInfos>g__RevertType|40_0(InventoryDefine.EItemDataType type)
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

	// Token: 0x040095A4 RID: 38308
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PhotoShareBtnItem, EChannelShare> ShareBtnLayout;

	// Token: 0x040095A5 RID: 38309
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<GachaShareSwitchItem, GachaShareSwitchData> GachaSwitchLayout;

	// Token: 0x040095A6 RID: 38310
	private bool IsPhoto = true;

	// Token: 0x040095A7 RID: 38311
	private bool PrepareFullScreenShot;

	// Token: 0x040095A8 RID: 38312
	private bool CaptureFullScene;

	// Token: 0x040095A9 RID: 38313
	private string RelativeShotPath = "";

	// Token: 0x040095AA RID: 38314
	[Nullable(2)]
	private PhotoSaveMarkItem MarkItem;

	// Token: 0x040095AB RID: 38315
	[Nullable(2)]
	private GachaShareOnePanel GachaView;

	// Token: 0x040095AC RID: 38316
	[Nullable(2)]
	private GachaShareTenPanel GachaViewTen;

	// Token: 0x040095AD RID: 38317
	[Nullable(2)]
	private FragmentMemoryShareView FragmentMemoryShareViewRef;

	// Token: 0x040095AE RID: 38318
	[Nullable(2)]
	private RoleSkinShareView RoleSkinShareView;

	// Token: 0x040095AF RID: 38319
	[Nullable(2)]
	private VersionPreheatSharePanel VersionPreheatView;

	// Token: 0x040095B0 RID: 38320
	[Nullable(2)]
	private Spring25SharePanel Spring25View;

	// Token: 0x040095B1 RID: 38321
	[Nullable(2)]
	private HandBookPhotoShareView HandBookPhotoShareView;

	// Token: 0x040095B2 RID: 38322
	[Nullable(2)]
	private TowerVariationShareView TowerVariationShareView;

	// Token: 0x040095B3 RID: 38323
	private WheelTowerTotalScoreSharePanel WheelTowerTotalScoreView;

	// Token: 0x040095B4 RID: 38324
	private WheelTowerSettlementShareView WheelTowerSettlementShareView;

	// Token: 0x040095B5 RID: 38325
	private ShipTowerSharePanel ChallengeRecordShareView;

	// Token: 0x040095B6 RID: 38326
	private EShareActionId ShareActionId = EShareActionId.Photo;

	// Token: 0x040095B7 RID: 38327
	private EShareReportExtraType ShareReportExtraType;

	// Token: 0x040095B8 RID: 38328
	private int CurrentTakeWidth;

	// Token: 0x040095B9 RID: 38329
	private int CurrentTakeHeight;

	// Token: 0x040095BA RID: 38330
	[Nullable(2)]
	private TArray<FColor> CurrentTakeColors;

	// Token: 0x040095BB RID: 38331
	private int CurrentWatermarkTakeWidth;

	// Token: 0x040095BC RID: 38332
	private int CurrentWatermarkTakeHeight;

	// Token: 0x040095BD RID: 38333
	[Nullable(2)]
	private TArray<FColor> CurrentWatermarkTakeColors;

	// Token: 0x040095BE RID: 38334
	private FVector? PanelItemOriginalScale;

	// Token: 0x040095BF RID: 38335
	private bool IsShowPlayerName;

	// Token: 0x040095C0 RID: 38336
	[Nullable(2)]
	private Action RestoreCaptureUi;

	// Token: 0x02007D84 RID: 32132
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028A31 RID: 166449
		PhotoTexture,
		// Token: 0x04028A32 RID: 166450
		PhotoFrameItem,
		// Token: 0x04028A33 RID: 166451
		CloseButton,
		// Token: 0x04028A34 RID: 166452
		BlackBgSprite,
		// Token: 0x04028A35 RID: 166453
		BtnParent,
		// Token: 0x04028A36 RID: 166454
		ShareBtnLayout,
		// Token: 0x04028A37 RID: 166455
		SaveButton,
		// Token: 0x04028A38 RID: 166456
		PnlTips,
		// Token: 0x04028A39 RID: 166457
		SprCross,
		// Token: 0x04028A3A RID: 166458
		SprTick,
		// Token: 0x04028A3B RID: 166459
		TxtConditions,
		// Token: 0x04028A3C RID: 166460
		MinItemPhoto,
		// Token: 0x04028A3D RID: 166461
		MaxItemPhoto,
		// Token: 0x04028A3E RID: 166462
		PhotoItem,
		// Token: 0x04028A3F RID: 166463
		PhotoPanel,
		// Token: 0x04028A40 RID: 166464
		LandscapePanel,
		// Token: 0x04028A41 RID: 166465
		TypeText,
		// Token: 0x04028A42 RID: 166466
		NameText,
		// Token: 0x04028A43 RID: 166467
		DateText,
		// Token: 0x04028A44 RID: 166468
		LandscapeTexture,
		// Token: 0x04028A45 RID: 166469
		DescriptionText,
		// Token: 0x04028A46 RID: 166470
		MarkItemPhoto,
		// Token: 0x04028A47 RID: 166471
		MarkItemLandscape,
		// Token: 0x04028A48 RID: 166472
		MinItemLandscape,
		// Token: 0x04028A49 RID: 166473
		MaxItemLandscape,
		// Token: 0x04028A4A RID: 166474
		TxtCostPhoto,
		// Token: 0x04028A4B RID: 166475
		TxtCostLandscape,
		// Token: 0x04028A4C RID: 166476
		FirstPhoto,
		// Token: 0x04028A4D RID: 166477
		FirstLandscape,
		// Token: 0x04028A4E RID: 166478
		RetakeButton,
		// Token: 0x04028A4F RID: 166479
		LineParent,
		// Token: 0x04028A50 RID: 166480
		LineItem,
		// Token: 0x04028A51 RID: 166481
		TextureCostPhoto,
		// Token: 0x04028A52 RID: 166482
		TextureCostLandscape,
		// Token: 0x04028A53 RID: 166483
		PersonalInfoTogglePhoto,
		// Token: 0x04028A54 RID: 166484
		PersonalInfoToggleLandscape,
		// Token: 0x04028A55 RID: 166485
		SubViewRoot,
		// Token: 0x04028A56 RID: 166486
		ExternalTexture,
		// Token: 0x04028A57 RID: 166487
		GachaSwitchLayout,
		// Token: 0x04028A58 RID: 166488
		GachaSwitchItem
	}
}
