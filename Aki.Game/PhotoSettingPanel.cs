using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A5E RID: 6750
[NullableContext(1)]
[Nullable(0)]
public class PhotoSettingPanel : PhotoDetailPanelBase
{
	// Token: 0x06010A9A RID: 68250 RVA: 0x004DFA64 File Offset: 0x004DDC64
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText))
		};
	}

	// Token: 0x1700193B RID: 6459
	// (get) Token: 0x06010A9B RID: 68251 RVA: 0x004DFB87 File Offset: 0x004DDD87
	protected override int TabLockPanelIndex
	{
		get
		{
			return 7;
		}
	}

	// Token: 0x1700193C RID: 6460
	// (get) Token: 0x06010A9C RID: 68252 RVA: 0x004DFB8A File Offset: 0x004DDD8A
	protected override int SubTabLockPanelIndex
	{
		get
		{
			return 10;
		}
	}

	// Token: 0x06010A9D RID: 68253 RVA: 0x004DFB90 File Offset: 0x004DDD90
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoSettingPanel.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoSettingPanel.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010A9E RID: 68254 RVA: 0x004DFBD4 File Offset: 0x004DDDD4
	protected override void OnStart()
	{
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnModeChanged = (Action<PhotoCameraType>)Delegate.Combine(viewModel.OnModeChanged, new Action<PhotoCameraType>(this.OnModeChanged));
		PhotoMainViewModel viewModel2 = this.ViewModel;
		viewModel2.OnCameraReset = (Action)Delegate.Combine(viewModel2.OnCameraReset, new Action(this.OnCameraReset));
	}

	// Token: 0x06010A9F RID: 68255 RVA: 0x004DFC30 File Offset: 0x004DDE30
	private UniTask RefreshSubTabList()
	{
		PhotoSettingPanel.<RefreshSubTabList>d__15 <RefreshSubTabList>d__;
		<RefreshSubTabList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubTabList>d__.<>4__this = this;
		<RefreshSubTabList>d__.<>1__state = -1;
		<RefreshSubTabList>d__.<>t__builder.Start<PhotoSettingPanel.<RefreshSubTabList>d__15>(ref <RefreshSubTabList>d__);
		return <RefreshSubTabList>d__.<>t__builder.Task;
	}

	// Token: 0x06010AA0 RID: 68256 RVA: 0x004DFC74 File Offset: 0x004DDE74
	private UniTask RefreshSubTabContent(EPhotoSetSubTabType subTabType)
	{
		PhotoSettingPanel.<RefreshSubTabContent>d__16 <RefreshSubTabContent>d__;
		<RefreshSubTabContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubTabContent>d__.<>4__this = this;
		<RefreshSubTabContent>d__.subTabType = subTabType;
		<RefreshSubTabContent>d__.<>1__state = -1;
		<RefreshSubTabContent>d__.<>t__builder.Start<PhotoSettingPanel.<RefreshSubTabContent>d__16>(ref <RefreshSubTabContent>d__);
		return <RefreshSubTabContent>d__.<>t__builder.Task;
	}

	// Token: 0x06010AA1 RID: 68257 RVA: 0x004DFCC0 File Offset: 0x004DDEC0
	protected override void RefreshContentVisible()
	{
		bool flag = this.CurrentSubTabType == EPhotoSetSubTabType.Setting;
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(1);
		if (loopScrollViewComponent == null)
		{
			return;
		}
		loopScrollViewComponent.RootUIComp.Get().SetUIActive(!flag && !base.IsCurrentSubTabBanned);
	}

	// Token: 0x06010AA2 RID: 68258 RVA: 0x004DFD18 File Offset: 0x004DDF18
	private UniTask RefreshSetupList()
	{
		PhotoSettingPanel.<RefreshSetupList>d__18 <RefreshSetupList>d__;
		<RefreshSetupList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSetupList>d__.<>4__this = this;
		<RefreshSetupList>d__.<>1__state = -1;
		<RefreshSetupList>d__.<>t__builder.Start<PhotoSettingPanel.<RefreshSetupList>d__18>(ref <RefreshSetupList>d__);
		return <RefreshSetupList>d__.<>t__builder.Task;
	}

	// Token: 0x06010AA3 RID: 68259 RVA: 0x004DFD5C File Offset: 0x004DDF5C
	private void RefreshSubItemFlag()
	{
		foreach (PhotographSetupBase photographSetupBase in this.SetupItemMap.Values)
		{
			photographSetupBase.SetSubItem(false);
		}
		foreach (int id in this.CurrentShowSetupIdList)
		{
			PhotoSetup? photoSetupConfigById = PhotographConfig.Instance.GetPhotoSetupConfigById(id);
			if (photoSetupConfigById != null)
			{
				int subOptionsLength = photoSetupConfigById.Value.SubOptionsLength;
				for (int i = 0; i < subOptionsLength; i++)
				{
					DicIntIntArray? dicIntIntArray;
					IntArray? intArray;
					int[] array = (photoSetupConfigById.Value.SubOptions(i) != null) ? ((dicIntIntArray.GetValueOrDefault().Value != null) ? intArray.GetValueOrDefault().GetArrayIntArray() : null) : null;
					if (array != null)
					{
						foreach (int valueType in array)
						{
							PhotographSetupBase setupItem = this.GetSetupItem((EPhotoSetupValueType)valueType);
							if (setupItem != null)
							{
								setupItem.SetSubItem(true);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06010AA4 RID: 68260 RVA: 0x004DFEBC File Offset: 0x004DE0BC
	private void SetHierarchyIndex(PhotographSetupBase item, int index)
	{
		UUIItem uuiitem = item.GetOriginalItem() ?? item.GetRootItem();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetHierarchyIndex(index);
	}

	// Token: 0x06010AA5 RID: 68261 RVA: 0x004DFEDC File Offset: 0x004DE0DC
	private void RefreshAllSubOption()
	{
		foreach (PhotographSetupBase photographSetupBase in this.SetupItemMap.Values)
		{
			PhotoToggleSetItem photoToggleSetItem = photographSetupBase as PhotoToggleSetItem;
			if (photoToggleSetItem != null)
			{
				photoToggleSetItem.RefreshSubOption();
			}
		}
	}

	// Token: 0x06010AA6 RID: 68262 RVA: 0x004DFF3C File Offset: 0x004DE13C
	private void RefreshSubOptions(List<EPhotoSetupValueType> allTypes, List<EPhotoSetupValueType> banTypes, EPhotoSubOptionBanType banType)
	{
		foreach (EPhotoSetupValueType valueType in allTypes)
		{
			PhotographSetupBase setupItem = this.GetSetupItem(valueType);
			if (setupItem != null)
			{
				setupItem.SetUiActive(true);
				setupItem.SetLock(false);
			}
		}
		foreach (EPhotoSetupValueType valueType2 in banTypes)
		{
			PhotographSetupBase setupItem2 = this.GetSetupItem(valueType2);
			if (setupItem2 != null)
			{
				if (banType != EPhotoSubOptionBanType.Hide)
				{
					if (banType == EPhotoSubOptionBanType.Lock)
					{
						setupItem2.SetLock(true);
					}
				}
				else
				{
					setupItem2.SetUiActive(false);
				}
			}
		}
	}

	// Token: 0x06010AA7 RID: 68263 RVA: 0x004DFFFC File Offset: 0x004DE1FC
	[NullableContext(2)]
	private PhotographSetupBase GetSetupItem(EPhotoSetupValueType valueType)
	{
		PhotographSetupBase result;
		if (this.SetupItemMap.TryGetValue((int)valueType, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06010AA8 RID: 68264 RVA: 0x004E001C File Offset: 0x004DE21C
	private UniTask NewSetupItem(int setupId, UUIItem contentItem, UUIItem itemSlider, UUIItem itemToggle, UUIItem itemDropDown)
	{
		PhotoSettingPanel.<NewSetupItem>d__24 <NewSetupItem>d__;
		<NewSetupItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewSetupItem>d__.<>4__this = this;
		<NewSetupItem>d__.setupId = setupId;
		<NewSetupItem>d__.contentItem = contentItem;
		<NewSetupItem>d__.itemSlider = itemSlider;
		<NewSetupItem>d__.itemToggle = itemToggle;
		<NewSetupItem>d__.itemDropDown = itemDropDown;
		<NewSetupItem>d__.<>1__state = -1;
		<NewSetupItem>d__.<>t__builder.Start<PhotoSettingPanel.<NewSetupItem>d__24>(ref <NewSetupItem>d__);
		return <NewSetupItem>d__.<>t__builder.Task;
	}

	// Token: 0x06010AA9 RID: 68265 RVA: 0x004E008C File Offset: 0x004DE28C
	private void ClearSetupItems()
	{
		foreach (PhotographSetupBase photographSetupBase in this.SetupItemCache.Values)
		{
			photographSetupBase.Destroy();
		}
		this.SetupItemCache.Clear();
		this.SetupItemMap.Clear();
		this.CurrentShowSetupIdList.Clear();
	}

	// Token: 0x06010AAA RID: 68266 RVA: 0x004E0104 File Offset: 0x004DE304
	private UniTask RefreshTemplateList()
	{
		PhotoSettingPanel.<RefreshTemplateList>d__26 <RefreshTemplateList>d__;
		<RefreshTemplateList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTemplateList>d__.<>4__this = this;
		<RefreshTemplateList>d__.<>1__state = -1;
		<RefreshTemplateList>d__.<>t__builder.Start<PhotoSettingPanel.<RefreshTemplateList>d__26>(ref <RefreshTemplateList>d__);
		return <RefreshTemplateList>d__.<>t__builder.Task;
	}

	// Token: 0x06010AAB RID: 68267 RVA: 0x004E0148 File Offset: 0x004DE348
	private void RestoreSelectedTemplate()
	{
		PhotoSettingPanel.<>c__DisplayClass27_0 CS$<>8__locals1 = new PhotoSettingPanel.<>c__DisplayClass27_0();
		if (this.TemplateScroll == null || this.TemplateDataList.Count == 0)
		{
			this.ViewModel.CurrentTemplateId = 1;
			return;
		}
		PhotoSettingPanel.<>c__DisplayClass27_0 CS$<>8__locals2 = CS$<>8__locals1;
		PhotoTemplatePart templatePart = this.GetTemplatePart();
		CS$<>8__locals2.templateId = ((templatePart != null) ? templatePart.TemplateId : 0);
		int num = this.TemplateDataList.FindIndex((PhotoTemplate template) => template.Id == CS$<>8__locals1.templateId);
		if (num < 0)
		{
			this.SelectDefaultTemplate();
			return;
		}
		this.TemplateScroll.SelectGridProxy(num, false);
		this.ViewModel.CurrentTemplateId = this.TemplateDataList[num].Id;
	}

	// Token: 0x06010AAC RID: 68268 RVA: 0x004E01E4 File Offset: 0x004DE3E4
	private void SelectDefaultTemplate()
	{
		if (this.TemplateScroll == null || this.TemplateDataList.Count == 0)
		{
			return;
		}
		int num = this.TemplateDataList.FindIndex((PhotoTemplate template) => template.IsDefault);
		num = ((num >= 0) ? num : 0);
		this.TemplateScroll.SelectGridProxy(num, false);
		this.ViewModel.CurrentTemplateId = this.TemplateDataList[num].Id;
	}

	// Token: 0x06010AAD RID: 68269 RVA: 0x004E0268 File Offset: 0x004DE468
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnModeChanged = (Action<PhotoCameraType>)Delegate.Remove(viewModel.OnModeChanged, new Action<PhotoCameraType>(this.OnModeChanged));
		PhotoMainViewModel viewModel2 = this.ViewModel;
		viewModel2.OnCameraReset = (Action)Delegate.Remove(viewModel2.OnCameraReset, new Action(this.OnCameraReset));
		this.ClearSetupItems();
	}

	// Token: 0x06010AAE RID: 68270 RVA: 0x004E02CF File Offset: 0x004DE4CF
	private PhotoCameraTempItem CreateTemplateItem()
	{
		PhotoCameraTempItem photoCameraTempItem = new PhotoCameraTempItem();
		photoCameraTempItem.OnTemplateClick = new Action<int>(this.OnTemplateClick);
		photoCameraTempItem.SetViewModel(this.ViewModel);
		return photoCameraTempItem;
	}

	// Token: 0x06010AAF RID: 68271 RVA: 0x004E02F4 File Offset: 0x004DE4F4
	private void OnSubTabClick(PhotoSubTab data)
	{
		PhotoSubTabPanel tabMenuPanel = this.TabMenuPanel;
		if (tabMenuPanel != null)
		{
			tabMenuPanel.SelectByKey(data.Id, false);
		}
		this.CurrentSubTabType = (EPhotoSetSubTabType)data.Type;
		base.SetSubTabId(data.Id, true);
		this.RefreshSubTabContent(this.CurrentSubTabType).Forget();
	}

	// Token: 0x06010AB0 RID: 68272 RVA: 0x004E034C File Offset: 0x004DE54C
	private void OnTemplateClick(int gridIndex)
	{
		if (this.ViewModel.IsSwitchingMode)
		{
			return;
		}
		LoopScrollView<PhotoCameraTempItem, PhotoTemplate> templateScroll = this.TemplateScroll;
		if (templateScroll != null)
		{
			templateScroll.SelectGridProxy(gridIndex, false);
		}
		PhotoTemplate template = this.TemplateDataList[gridIndex];
		this.ViewModel.CurrentTemplateId = template.Id;
		if (template.IsDefault)
		{
			this.OnDefaultTemplateClick(template);
			return;
		}
		this.OnCustomTemplateClick(template);
	}

	// Token: 0x06010AB1 RID: 68273 RVA: 0x004E03B4 File Offset: 0x004DE5B4
	private void OnCustomTemplateClick(PhotoTemplate template)
	{
		if (string.IsNullOrEmpty(template.DAPath))
		{
			return;
		}
		PhotoCamera photoCamera = PhotographController.Instance.GetPhotoCamera();
		if (photoCamera == null)
		{
			return;
		}
		PhotoTemplatePart orCreateTemplatePart = this.GetOrCreateTemplatePart();
		if (orCreateTemplatePart != null)
		{
			if (!orCreateTemplatePart.HasDefaultState)
			{
				orCreateTemplatePart.CaptureDefaultState();
			}
			orCreateTemplatePart.TemplateId = template.Id;
			orCreateTemplatePart.TemplateDaPath = template.DAPath;
		}
		photoCamera.ApplyTemplate(template.DAPath).Forget<bool>();
	}

	// Token: 0x06010AB2 RID: 68274 RVA: 0x004E0424 File Offset: 0x004DE624
	private void OnDefaultTemplateClick(PhotoTemplate template)
	{
		PhotoTemplatePart templatePart = this.GetTemplatePart();
		if (templatePart == null || !templatePart.HasDefaultState)
		{
			return;
		}
		PhotoCamera photoCamera = PhotographController.Instance.GetPhotoCamera();
		if (photoCamera == null)
		{
			return;
		}
		photoCamera.ApplyDefaultTemplate(templatePart.DefaultLens);
		PhotographController.Instance.RestoreDepthOfField(templatePart.DefaultDofMap);
		templatePart.TemplateId = template.Id;
		templatePart.TemplateDaPath = "";
		templatePart.ClearDefaultState();
	}

	// Token: 0x06010AB3 RID: 68275 RVA: 0x004E0490 File Offset: 0x004DE690
	private void OnCameraReset()
	{
		PhotoTemplatePart templatePart = this.GetTemplatePart();
		if (templatePart != null)
		{
			templatePart.ClearDefaultState();
			templatePart.TemplateId = 0;
			templatePart.TemplateDaPath = "";
		}
		this.SelectDefaultTemplate();
	}

	// Token: 0x06010AB4 RID: 68276 RVA: 0x004E04C8 File Offset: 0x004DE6C8
	[NullableContext(2)]
	private PhotoTemplatePart GetTemplatePart()
	{
		int photoModeIdByType = PhotographConfig.Instance.GetPhotoModeIdByType(this.ViewModel.CurrentMode);
		if (photoModeIdByType <= 0)
		{
			return null;
		}
		PhotoCameraSnapshot sessionSnapshot = PhotoSnapshotController.Instance.GetSessionSnapshot(photoModeIdByType);
		if (sessionSnapshot == null)
		{
			return null;
		}
		return sessionSnapshot.Template;
	}

	// Token: 0x06010AB5 RID: 68277 RVA: 0x004E0508 File Offset: 0x004DE708
	[NullableContext(2)]
	private PhotoTemplatePart GetOrCreateTemplatePart()
	{
		int photoModeIdByType = PhotographConfig.Instance.GetPhotoModeIdByType(this.ViewModel.CurrentMode);
		if (photoModeIdByType <= 0)
		{
			return null;
		}
		return PhotoSnapshotController.Instance.GetOrCreateSessionSnapshot(photoModeIdByType).Template;
	}

	// Token: 0x06010AB6 RID: 68278 RVA: 0x004E0541 File Offset: 0x004DE741
	private void OnModeChanged(PhotoCameraType mode)
	{
		LoopScrollView<PhotoCameraTempItem, PhotoTemplate> templateScroll = this.TemplateScroll;
		if (templateScroll != null)
		{
			templateScroll.ClearSelectInfo();
		}
		this.RefreshSetupList().Forget();
		this.RefreshTemplateList().Forget();
	}

	// Token: 0x04009332 RID: 37682
	private readonly Dictionary<int, PhotographSetupBase> SetupItemMap = new Dictionary<int, PhotographSetupBase>();

	// Token: 0x04009333 RID: 37683
	private readonly Dictionary<int, PhotographSetupBase> SetupItemCache = new Dictionary<int, PhotographSetupBase>();

	// Token: 0x04009334 RID: 37684
	private readonly HashSet<int> CurrentShowSetupIdList = new HashSet<int>();

	// Token: 0x04009335 RID: 37685
	[Nullable(2)]
	private PhotoSubTabPanel TabMenuPanel;

	// Token: 0x04009336 RID: 37686
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<PhotoCameraTempItem, PhotoTemplate> TemplateScroll;

	// Token: 0x04009337 RID: 37687
	private readonly List<PhotoTemplate> TemplateDataList = new List<PhotoTemplate>();

	// Token: 0x04009338 RID: 37688
	private EPhotoSetSubTabType CurrentSubTabType = EPhotoSetSubTabType.Setting;

	// Token: 0x02007CE2 RID: 31970
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402870D RID: 165645
		ItemTabMenu,
		// Token: 0x0402870E RID: 165646
		LoopScrollCameraTemplate,
		// Token: 0x0402870F RID: 165647
		ItemCameraTemplate,
		// Token: 0x04028710 RID: 165648
		ScrollSetting,
		// Token: 0x04028711 RID: 165649
		ItemSliderTemplate,
		// Token: 0x04028712 RID: 165650
		ItemToggleTemplate,
		// Token: 0x04028713 RID: 165651
		ItemDropDownTemplate,
		// Token: 0x04028714 RID: 165652
		ItemTabLockPanel,
		// Token: 0x04028715 RID: 165653
		TextTabLockTips,
		// Token: 0x04028716 RID: 165654
		ItemParentContent,
		// Token: 0x04028717 RID: 165655
		ItemSubTabLockPanel,
		// Token: 0x04028718 RID: 165656
		TextSubTabLockTips
	}
}
