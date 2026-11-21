using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A4C RID: 6732
[NullableContext(1)]
[Nullable(0)]
public class PhotoEnvironmentPanel : PhotoDetailPanelBase
{
	// Token: 0x060109C1 RID: 68033 RVA: 0x004DC2BC File Offset: 0x004DA4BC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem))
		};
	}

	// Token: 0x1700192A RID: 6442
	// (get) Token: 0x060109C2 RID: 68034 RVA: 0x004DC43B File Offset: 0x004DA63B
	protected override int TabLockPanelIndex
	{
		get
		{
			return 10;
		}
	}

	// Token: 0x1700192B RID: 6443
	// (get) Token: 0x060109C3 RID: 68035 RVA: 0x004DC43F File Offset: 0x004DA63F
	protected override int SubTabLockPanelIndex
	{
		get
		{
			return 12;
		}
	}

	// Token: 0x060109C4 RID: 68036 RVA: 0x004DC444 File Offset: 0x004DA644
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoEnvironmentPanel.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoEnvironmentPanel.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060109C5 RID: 68037 RVA: 0x004DC487 File Offset: 0x004DA687
	public override void RefreshDetail()
	{
		PhotoTimeSetItem timeSetItem = this.TimeSetItem;
		if (timeSetItem == null)
		{
			return;
		}
		timeSetItem.Refresh();
	}

	// Token: 0x060109C6 RID: 68038 RVA: 0x004DC499 File Offset: 0x004DA699
	protected override void OnBeforeDestroy()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.OnLateUpdate.Unbind();
		}
		base.OnBeforeDestroy();
	}

	// Token: 0x060109C7 RID: 68039 RVA: 0x004DC4B8 File Offset: 0x004DA6B8
	private void OnLateTick(float _)
	{
		if (!this.NeedScrollToEndOnLateTick)
		{
			return;
		}
		this.NeedScrollToEndOnLateTick = false;
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		if (scrollViewWithScrollbar == null)
		{
			return;
		}
		scrollViewWithScrollbar.ScrollToEnd();
	}

	// Token: 0x060109C8 RID: 68040 RVA: 0x004DC4DC File Offset: 0x004DA6DC
	private UniTask RefreshSubTabList()
	{
		PhotoEnvironmentPanel.<RefreshSubTabList>d__21 <RefreshSubTabList>d__;
		<RefreshSubTabList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubTabList>d__.<>4__this = this;
		<RefreshSubTabList>d__.<>1__state = -1;
		<RefreshSubTabList>d__.<>t__builder.Start<PhotoEnvironmentPanel.<RefreshSubTabList>d__21>(ref <RefreshSubTabList>d__);
		return <RefreshSubTabList>d__.<>t__builder.Task;
	}

	// Token: 0x060109C9 RID: 68041 RVA: 0x004DC520 File Offset: 0x004DA720
	private void ShowSubTabContent(EPhotoEnvironmentSubTabType subTabType)
	{
		bool flag = subTabType == EPhotoEnvironmentSubTabType.Weather;
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.RootUIComp.Get().SetUIActive(flag);
		}
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		if (flag)
		{
			this.RefreshWeatherList().Forget();
			this.RefreshWindList().Forget();
			return;
		}
		this.RefreshAtmosphereList().Forget();
	}

	// Token: 0x060109CA RID: 68042 RVA: 0x004DC590 File Offset: 0x004DA790
	private UniTask RefreshWeatherList()
	{
		PhotoEnvironmentPanel.<RefreshWeatherList>d__23 <RefreshWeatherList>d__;
		<RefreshWeatherList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshWeatherList>d__.<>4__this = this;
		<RefreshWeatherList>d__.<>1__state = -1;
		<RefreshWeatherList>d__.<>t__builder.Start<PhotoEnvironmentPanel.<RefreshWeatherList>d__23>(ref <RefreshWeatherList>d__);
		return <RefreshWeatherList>d__.<>t__builder.Task;
	}

	// Token: 0x060109CB RID: 68043 RVA: 0x004DC5D4 File Offset: 0x004DA7D4
	private void SelectCurWeather()
	{
		PhotoEnvironmentPanel.<>c__DisplayClass24_0 CS$<>8__locals1 = new PhotoEnvironmentPanel.<>c__DisplayClass24_0();
		if (this.WeatherDataList.Count == 0)
		{
			return;
		}
		PhotoEnvironmentPanel.<>c__DisplayClass24_0 CS$<>8__locals2 = CS$<>8__locals1;
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		CS$<>8__locals2.currentId = ((effectComponent != null) ? effectComponent.GetCurrentWeatherId() : 0);
		int num = (CS$<>8__locals1.currentId > 0) ? this.WeatherDataList.FindIndex((PhotoWeatherData d) => d.WeatherId == CS$<>8__locals1.currentId) : -1;
		if (num < 0)
		{
			num = this.WeatherDataList.FindIndex((PhotoWeatherData d) => d.IsDefault);
		}
		GenericLayout<PhotoWeatherItem, PhotoWeatherData> weatherLayout = this.WeatherLayout;
		if (weatherLayout == null)
		{
			return;
		}
		weatherLayout.SelectGridProxy((num >= 0) ? num : 0, false);
	}

	// Token: 0x060109CC RID: 68044 RVA: 0x004DC67C File Offset: 0x004DA87C
	private List<PhotoWeatherData> BuildWeatherDataList()
	{
		List<PhotoWeatherData> list = new List<PhotoWeatherData>();
		list.Add(new PhotoWeatherData());
		Area? areaInfo = AreaModel.Instance.AreaInfo;
		if (areaInfo == null)
		{
			return list;
		}
		WeatherLib? config = ConfigWeatherLibById.GetConfig(areaInfo.Value.WeatherGroupId, true);
		if (config == null)
		{
			return list;
		}
		for (int i = 0; i < config.Value.PhotoWeatherLength; i++)
		{
			int num = config.Value.PhotoWeather(i);
			Weather? config2 = ConfigWeatherById.GetConfig(num, true);
			if (config2 != null)
			{
				PhotoWeather? config3 = ConfigPhotoWeatherById.GetConfig(config2.Value.PhotoWeatherType, true);
				if (config3 != null)
				{
					list.Add(new PhotoWeatherData(num, config3.Value));
				}
			}
		}
		return list;
	}

	// Token: 0x060109CD RID: 68045 RVA: 0x004DC750 File Offset: 0x004DA950
	private void OnWeatherClick(int gridIndex)
	{
		if (gridIndex < 0 || gridIndex >= this.WeatherDataList.Count)
		{
			return;
		}
		GenericLayout<PhotoWeatherItem, PhotoWeatherData> weatherLayout = this.WeatherLayout;
		if (weatherLayout != null)
		{
			weatherLayout.SelectGridProxy(gridIndex, false);
		}
		PhotoWeatherData photoWeatherData = this.WeatherDataList[gridIndex];
		this.ViewModel.CurrentWeatherId = photoWeatherData.WeatherId;
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		if (effectComponent == null)
		{
			return;
		}
		effectComponent.SelectWeather(photoWeatherData.WeatherId, photoWeatherData.IsDefault);
	}

	// Token: 0x060109CE RID: 68046 RVA: 0x004DC7C0 File Offset: 0x004DA9C0
	private UniTask RefreshWindList()
	{
		PhotoEnvironmentPanel.<RefreshWindList>d__27 <RefreshWindList>d__;
		<RefreshWindList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshWindList>d__.<>4__this = this;
		<RefreshWindList>d__.<>1__state = -1;
		<RefreshWindList>d__.<>t__builder.Start<PhotoEnvironmentPanel.<RefreshWindList>d__27>(ref <RefreshWindList>d__);
		return <RefreshWindList>d__.<>t__builder.Task;
	}

	// Token: 0x060109CF RID: 68047 RVA: 0x004DC804 File Offset: 0x004DAA04
	private void SelectCurWind()
	{
		PhotoEnvironmentPanel.<>c__DisplayClass28_0 CS$<>8__locals1 = new PhotoEnvironmentPanel.<>c__DisplayClass28_0();
		if (this.WindDataList.Count == 0)
		{
			return;
		}
		PhotoEnvironmentPanel.<>c__DisplayClass28_0 CS$<>8__locals2 = CS$<>8__locals1;
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		CS$<>8__locals2.currentId = ((effectComponent != null) ? effectComponent.GetCurrentWindId() : 0);
		int num = (CS$<>8__locals1.currentId > 0) ? this.WindDataList.FindIndex((PhotoWindDirection d) => d.Id == CS$<>8__locals1.currentId) : -1;
		if (num < 0)
		{
			num = this.WindDataList.FindIndex((PhotoWindDirection d) => d.IsDefault);
		}
		this.OnWindClick((num >= 0) ? num : 0);
	}

	// Token: 0x060109D0 RID: 68048 RVA: 0x004DC8A0 File Offset: 0x004DAAA0
	private void OnWindClick(int gridIndex)
	{
		if (gridIndex < 0 || gridIndex >= this.WindDataList.Count)
		{
			return;
		}
		GenericLayout<PhotoWindItem, PhotoWindDirection> windLayout = this.WindLayout;
		if (windLayout != null)
		{
			windLayout.SelectGridProxy(gridIndex, false);
		}
		PhotoWindDirection photoWindDirection = this.WindDataList[gridIndex];
		bool isDefault = photoWindDirection.IsDefault;
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(!isDefault);
		}
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		int num = (effectComponent != null) ? effectComponent.SelectWind(photoWindDirection.Id, photoWindDirection.Direction, photoWindDirection.DefaultStrength, isDefault) : photoWindDirection.DefaultStrength;
		this.ViewModel.CurrentWindId = photoWindDirection.Id;
		this.ViewModel.CurrentWindStrength = (isDefault ? 0 : num);
		if (!isDefault)
		{
			PhotoEnvStrengthItem windStrengthItem = this.WindStrengthItem;
			if (windStrengthItem != null)
			{
				windStrengthItem.SetStrength((float)num, (float)photoWindDirection.DefaultStrength);
			}
			this.NeedScrollToEndOnLateTick = true;
		}
	}

	// Token: 0x060109D1 RID: 68049 RVA: 0x004DC976 File Offset: 0x004DAB76
	private void OnWindStrengthChanged(float value)
	{
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		if (effectComponent != null)
		{
			effectComponent.SetWindStrength((float)((int)value));
		}
		this.ViewModel.CurrentWindStrength = (int)value;
	}

	// Token: 0x060109D2 RID: 68050 RVA: 0x004DC999 File Offset: 0x004DAB99
	private void OnAtmosphereStrengthChanged(float value)
	{
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		if (effectComponent != null)
		{
			effectComponent.SetAtmosphereStrength((float)((int)value));
		}
		this.ViewModel.CurrentAtmosphereStrength = (int)value;
	}

	// Token: 0x060109D3 RID: 68051 RVA: 0x004DC9BC File Offset: 0x004DABBC
	[NullableContext(2)]
	private PhotoCameraEffectComponent GetEffectComponent()
	{
		return PhotographController.Instance.GetPhotoCameraComponent<PhotoCameraEffectComponent>(EPhotoCameraComponent.Effect);
	}

	// Token: 0x060109D4 RID: 68052 RVA: 0x004DC9CC File Offset: 0x004DABCC
	private UniTask RefreshAtmosphereList()
	{
		PhotoEnvironmentPanel.<RefreshAtmosphereList>d__33 <RefreshAtmosphereList>d__;
		<RefreshAtmosphereList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAtmosphereList>d__.<>4__this = this;
		<RefreshAtmosphereList>d__.<>1__state = -1;
		<RefreshAtmosphereList>d__.<>t__builder.Start<PhotoEnvironmentPanel.<RefreshAtmosphereList>d__33>(ref <RefreshAtmosphereList>d__);
		return <RefreshAtmosphereList>d__.<>t__builder.Task;
	}

	// Token: 0x060109D5 RID: 68053 RVA: 0x004DCA10 File Offset: 0x004DAC10
	private void SelectCurAtmosphere()
	{
		PhotoEnvironmentPanel.<>c__DisplayClass34_0 CS$<>8__locals1 = new PhotoEnvironmentPanel.<>c__DisplayClass34_0();
		if (this.AtmosphereDataList.Count == 0)
		{
			return;
		}
		PhotoEnvironmentPanel.<>c__DisplayClass34_0 CS$<>8__locals2 = CS$<>8__locals1;
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		CS$<>8__locals2.currentId = ((effectComponent != null) ? effectComponent.GetCurrentAtmosphereId() : 0);
		int num = (CS$<>8__locals1.currentId > 0) ? this.AtmosphereDataList.FindIndex((PhotoAtmosphere d) => d.Id == CS$<>8__locals1.currentId) : -1;
		if (num < 0)
		{
			num = this.AtmosphereDataList.FindIndex((PhotoAtmosphere d) => d.IsDefault);
		}
		this.OnAtmosphereClick((num >= 0) ? num : 0);
	}

	// Token: 0x060109D6 RID: 68054 RVA: 0x004DCAAC File Offset: 0x004DACAC
	private void OnAtmosphereClick(int gridIndex)
	{
		if (gridIndex < 0 || gridIndex >= this.AtmosphereDataList.Count)
		{
			return;
		}
		LoopScrollView<PhotoAtmosphereItem, PhotoAtmosphere> atmosphereScroll = this.AtmosphereScroll;
		if (atmosphereScroll != null)
		{
			atmosphereScroll.SelectGridProxy(gridIndex, false);
		}
		PhotoAtmosphere photoAtmosphere = this.AtmosphereDataList[gridIndex];
		bool isDefault = photoAtmosphere.IsDefault;
		UUIItem item = base.GetItem(15);
		if (item != null)
		{
			item.SetUIActive(isDefault);
		}
		UUIItem item2 = base.GetItem(14);
		if (item2 != null)
		{
			item2.SetUIActive(!isDefault);
		}
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		int num = (effectComponent != null) ? effectComponent.SelectAtmosphere(photoAtmosphere.Id, (EPhotoClusterEffectType)photoAtmosphere.EffectType, photoAtmosphere.DefaultStrength, isDefault) : photoAtmosphere.DefaultStrength;
		this.ViewModel.CurrentAtmosphereId = photoAtmosphere.Id;
		this.ViewModel.CurrentAtmosphereStrength = (isDefault ? 0 : num);
		if (!isDefault)
		{
			PhotoEnvStrengthItem atmosphereStrengthItem = this.AtmosphereStrengthItem;
			if (atmosphereStrengthItem == null)
			{
				return;
			}
			atmosphereStrengthItem.SetStrength((float)num, (float)photoAtmosphere.DefaultStrength);
		}
	}

	// Token: 0x060109D7 RID: 68055 RVA: 0x004DCB8F File Offset: 0x004DAD8F
	private PhotoWeatherItem CreateWeatherItem()
	{
		return new PhotoWeatherItem
		{
			OnWeatherClick = new Action<int>(this.OnWeatherClick)
		};
	}

	// Token: 0x060109D8 RID: 68056 RVA: 0x004DCBA8 File Offset: 0x004DADA8
	private PhotoWindItem CreateWindItem()
	{
		return new PhotoWindItem
		{
			OnWindClick = new Action<int>(this.OnWindClick)
		};
	}

	// Token: 0x060109D9 RID: 68057 RVA: 0x004DCBC1 File Offset: 0x004DADC1
	private PhotoAtmosphereItem CreateAtmosphereItem()
	{
		return new PhotoAtmosphereItem
		{
			OnAtmosphereClick = new Action<int>(this.OnAtmosphereClick)
		};
	}

	// Token: 0x060109DA RID: 68058 RVA: 0x004DCBDA File Offset: 0x004DADDA
	private void OnSubTabClick(PhotoSubTab data, bool playSwitchAnim = true)
	{
		PhotoSubTabPanel subTabPanel = this.SubTabPanel;
		if (subTabPanel != null)
		{
			subTabPanel.SelectByKey(data.Id, false);
		}
		base.SetSubTabId(data.Id, playSwitchAnim);
		this.ShowSubTabContent((EPhotoEnvironmentSubTabType)data.Type);
	}

	// Token: 0x040092FA RID: 37626
	[Nullable(2)]
	private PhotoSubTabPanel SubTabPanel;

	// Token: 0x040092FB RID: 37627
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<PhotoWeatherItem, PhotoWeatherData> WeatherLayout;

	// Token: 0x040092FC RID: 37628
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PhotoWindItem, PhotoWindDirection> WindLayout;

	// Token: 0x040092FD RID: 37629
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<PhotoAtmosphereItem, PhotoAtmosphere> AtmosphereScroll;

	// Token: 0x040092FE RID: 37630
	[Nullable(2)]
	private PhotoTimeSetItem TimeSetItem;

	// Token: 0x040092FF RID: 37631
	[Nullable(2)]
	private PhotoEnvStrengthItem WindStrengthItem;

	// Token: 0x04009300 RID: 37632
	[Nullable(2)]
	private PhotoEnvStrengthItem AtmosphereStrengthItem;

	// Token: 0x04009301 RID: 37633
	private List<PhotoWeatherData> WeatherDataList = new List<PhotoWeatherData>();

	// Token: 0x04009302 RID: 37634
	private List<PhotoWindDirection> WindDataList = new List<PhotoWindDirection>();

	// Token: 0x04009303 RID: 37635
	private List<PhotoAtmosphere> AtmosphereDataList = new List<PhotoAtmosphere>();

	// Token: 0x04009304 RID: 37636
	private bool NeedScrollToEndOnLateTick;

	// Token: 0x02007CB9 RID: 31929
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04028628 RID: 165416
		ItemSubTabMenu,
		// Token: 0x04028629 RID: 165417
		ScrollWeatherPanel,
		// Token: 0x0402862A RID: 165418
		ItemTimeSet,
		// Token: 0x0402862B RID: 165419
		LayoutWeather,
		// Token: 0x0402862C RID: 165420
		LayoutWindDirection,
		// Token: 0x0402862D RID: 165421
		ItemWindStrength,
		// Token: 0x0402862E RID: 165422
		ItemAtmospherePanel,
		// Token: 0x0402862F RID: 165423
		LoopScrollAtmosphere,
		// Token: 0x04028630 RID: 165424
		ItemAtmosphereTemplate,
		// Token: 0x04028631 RID: 165425
		ItemAtmosphereStrength,
		// Token: 0x04028632 RID: 165426
		ItemTabLockPanel,
		// Token: 0x04028633 RID: 165427
		TextTabLockTips,
		// Token: 0x04028634 RID: 165428
		ItemSubTabLockPanel,
		// Token: 0x04028635 RID: 165429
		TextSubTabLockTips,
		// Token: 0x04028636 RID: 165430
		ItemSliderPanel,
		// Token: 0x04028637 RID: 165431
		ItemEmptyPanel
	}
}
