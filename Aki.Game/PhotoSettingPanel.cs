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

// Token: 0x02002573 RID: 9587
[NullableContext(1)]
[Nullable(0)]
public class PhotoSettingPanel : PhotoDetailPanelBase
{
	// Token: 0x060135B7 RID: 79287 RVA: 0x004D0DFC File Offset: 0x004CEFFC
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

	// Token: 0x17001901 RID: 6401
	// (get) Token: 0x060135B8 RID: 79288 RVA: 0x004D0F1F File Offset: 0x004CF11F
	protected override int TabLockPanelIndex
	{
		get
		{
			return 7;
		}
	}

	// Token: 0x17001902 RID: 6402
	// (get) Token: 0x060135B9 RID: 79289 RVA: 0x004D0F22 File Offset: 0x004CF122
	protected override int SubTabLockPanelIndex
	{
		get
		{
			return 10;
		}
	}

	// Token: 0x060135BA RID: 79290 RVA: 0x004D0F28 File Offset: 0x004CF128
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoSettingPanel.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoSettingPanel.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060135BB RID: 79291 RVA: 0x004D0F6C File Offset: 0x004CF16C
	protected override void OnStart()
	{
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnModeChanged = (Action<PhotoCameraType>)Delegate.Combine(viewModel.OnModeChanged, new Action<PhotoCameraType>(this.OnModeChanged));
		PhotoMainViewModel viewModel2 = this.ViewModel;
		viewModel2.OnCameraReset = (Action)Delegate.Combine(viewModel2.OnCameraReset, new Action(this.OnCameraReset));
	}

	// Token: 0x060135BC RID: 79292 RVA: 0x004D0FC8 File Offset: 0x004CF1C8
	private UniTask RefreshSubTabList()
	{
		PhotoSettingPanel.<RefreshSubTabList>d__15 <RefreshSubTabList>d__;
		<RefreshSubTabList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubTabList>d__.<>4__this = this;
		<RefreshSubTabList>d__.<>1__state = -1;
		<RefreshSubTabList>d__.<>t__builder.Start<PhotoSettingPanel.<RefreshSubTabList>d__15>(ref <RefreshSubTabList>d__);
		return <RefreshSubTabList>d__.<>t__builder.Task;
	}

	// Token: 0x060135BD RID: 79293 RVA: 0x004D100C File Offset: 0x004CF20C
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

	// Token: 0x060135BE RID: 79294 RVA: 0x004D1058 File Offset: 0x004CF258
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

	// Token: 0x060135BF RID: 79295 RVA: 0x004D10B0 File Offset: 0x004CF2B0
	private UniTask RefreshSetupList()
	{
		PhotoSettingPanel.<RefreshSetupList>d__18 <RefreshSetupList>d__;
		<RefreshSetupList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSetupList>d__.<>4__this = this;
		<RefreshSetupList>d__.<>1__state = -1;
		<RefreshSetupList>d__.<>t__builder.Start<PhotoSettingPanel.<RefreshSetupList>d__18>(ref <RefreshSetupList>d__);
		return <RefreshSetupList>d__.<>t__builder.Task;
	}

	// Token: 0x060135C0 RID: 79296 RVA: 0x004D10F4 File Offset: 0x004CF2F4
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

	// Token: 0x060135C1 RID: 79297 RVA: 0x004D1254 File Offset: 0x004CF454
	private void SetHierarchyIndex(PhotographSetupBase item, int index)
	{
		UUIItem uuiitem = item.GetOriginalItem() ?? item.GetRootItem();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetHierarchyIndex(index);
	}

	// Token: 0x060135C2 RID: 79298 RVA: 0x004D1274 File Offset: 0x004CF474
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

	// Token: 0x060135C3 RID: 79299 RVA: 0x004D12D4 File Offset: 0x004CF4D4
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

	// Token: 0x060135C4 RID: 79300 RVA: 0x004D1394 File Offset: 0x004CF594
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

	// Token: 0x060135C5 RID: 79301 RVA: 0x004D13B4 File Offset: 0x004CF5B4
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

	// Token: 0x060135C6 RID: 79302 RVA: 0x004D1424 File Offset: 0x004CF624
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

	// Token: 0x060135C7 RID: 79303 RVA: 0x004D149C File Offset: 0x004CF69C
	private UniTask RefreshTemplateList()
	{
		PhotoSettingPanel.<RefreshTemplateList>d__26 <RefreshTemplateList>d__;
		<RefreshTemplateList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTemplateList>d__.<>4__this = this;
		<RefreshTemplateList>d__.<>1__state = -1;
		<RefreshTemplateList>d__.<>t__builder.Start<PhotoSettingPanel.<RefreshTemplateList>d__26>(ref <RefreshTemplateList>d__);
		return <RefreshTemplateList>d__.<>t__builder.Task;
	}

	// Token: 0x060135C8 RID: 79304 RVA: 0x004D14E0 File Offset: 0x004CF6E0
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

	// Token: 0x060135C9 RID: 79305 RVA: 0x004D157C File Offset: 0x004CF77C
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

	// Token: 0x060135CA RID: 79306 RVA: 0x004D1600 File Offset: 0x004CF800
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnModeChanged = (Action<PhotoCameraType>)Delegate.Remove(viewModel.OnModeChanged, new Action<PhotoCameraType>(this.OnModeChanged));
		PhotoMainViewModel viewModel2 = this.ViewModel;
		viewModel2.OnCameraReset = (Action)Delegate.Remove(viewModel2.OnCameraReset, new Action(this.OnCameraReset));
		this.ClearSetupItems();
	}

	// Token: 0x060135CB RID: 79307 RVA: 0x004D1667 File Offset: 0x004CF867
	private PhotoCameraTempItem CreateTemplateItem()
	{
		PhotoCameraTempItem photoCameraTempItem = new PhotoCameraTempItem();
		photoCameraTempItem.OnTemplateClick = new Action<int>(this.OnTemplateClick);
		photoCameraTempItem.SetViewModel(this.ViewModel);
		return photoCameraTempItem;
	}

	// Token: 0x060135CC RID: 79308 RVA: 0x004D168C File Offset: 0x004CF88C
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

	// Token: 0x060135CD RID: 79309 RVA: 0x004D16E4 File Offset: 0x004CF8E4
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

	// Token: 0x060135CE RID: 79310 RVA: 0x004D174C File Offset: 0x004CF94C
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

	// Token: 0x060135CF RID: 79311 RVA: 0x004D17BC File Offset: 0x004CF9BC
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

	// Token: 0x060135D0 RID: 79312 RVA: 0x004D1828 File Offset: 0x004CFA28
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

	// Token: 0x060135D1 RID: 79313 RVA: 0x004D1860 File Offset: 0x004CFA60
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

	// Token: 0x060135D2 RID: 79314 RVA: 0x004D18A0 File Offset: 0x004CFAA0
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

	// Token: 0x060135D3 RID: 79315 RVA: 0x004D18D9 File Offset: 0x004CFAD9
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

	// Token: 0x040091D9 RID: 37337
	private readonly Dictionary<int, PhotographSetupBase> SetupItemMap = new Dictionary<int, PhotographSetupBase>();

	// Token: 0x040091DA RID: 37338
	private readonly Dictionary<int, PhotographSetupBase> SetupItemCache = new Dictionary<int, PhotographSetupBase>();

	// Token: 0x040091DB RID: 37339
	private readonly HashSet<int> CurrentShowSetupIdList = new HashSet<int>();

	// Token: 0x040091DC RID: 37340
	[Nullable(2)]
	private PhotoSubTabPanel TabMenuPanel;

	// Token: 0x040091DD RID: 37341
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<PhotoCameraTempItem, PhotoTemplate> TemplateScroll;

	// Token: 0x040091DE RID: 37342
	private readonly List<PhotoTemplate> TemplateDataList = new List<PhotoTemplate>();

	// Token: 0x040091DF RID: 37343
	private EPhotoSetSubTabType CurrentSubTabType = EPhotoSetSubTabType.Setting;

	// Token: 0x02008B5C RID: 35676
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D400 RID: 185344
		ItemTabMenu,
		// Token: 0x0402D401 RID: 185345
		LoopScrollCameraTemplate,
		// Token: 0x0402D402 RID: 185346
		ItemCameraTemplate,
		// Token: 0x0402D403 RID: 185347
		ScrollSetting,
		// Token: 0x0402D404 RID: 185348
		ItemSliderTemplate,
		// Token: 0x0402D405 RID: 185349
		ItemToggleTemplate,
		// Token: 0x0402D406 RID: 185350
		ItemDropDownTemplate,
		// Token: 0x0402D407 RID: 185351
		ItemTabLockPanel,
		// Token: 0x0402D408 RID: 185352
		TextTabLockTips,
		// Token: 0x0402D409 RID: 185353
		ItemParentContent,
		// Token: 0x0402D40A RID: 185354
		ItemSubTabLockPanel,
		// Token: 0x0402D40B RID: 185355
		TextSubTabLockTips
	}
}
