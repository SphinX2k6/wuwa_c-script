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

// Token: 0x02002561 RID: 9569
[NullableContext(1)]
[Nullable(0)]
public class PhotoEnvironmentPanel : PhotoDetailPanelBase
{
	// Token: 0x060134DF RID: 79071 RVA: 0x004CD684 File Offset: 0x004CB884
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

	// Token: 0x170018F0 RID: 6384
	// (get) Token: 0x060134E0 RID: 79072 RVA: 0x004CD803 File Offset: 0x004CBA03
	protected override int TabLockPanelIndex
	{
		get
		{
			return 10;
		}
	}

	// Token: 0x170018F1 RID: 6385
	// (get) Token: 0x060134E1 RID: 79073 RVA: 0x004CD807 File Offset: 0x004CBA07
	protected override int SubTabLockPanelIndex
	{
		get
		{
			return 12;
		}
	}

	// Token: 0x060134E2 RID: 79074 RVA: 0x004CD80C File Offset: 0x004CBA0C
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoEnvironmentPanel.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoEnvironmentPanel.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060134E3 RID: 79075 RVA: 0x004CD84F File Offset: 0x004CBA4F
	public override void RefreshDetail()
	{
		PhotoTimeSetItem timeSetItem = this.TimeSetItem;
		if (timeSetItem == null)
		{
			return;
		}
		timeSetItem.Refresh();
	}

	// Token: 0x060134E4 RID: 79076 RVA: 0x004CD861 File Offset: 0x004CBA61
	protected override void OnBeforeDestroy()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.OnLateUpdate.Unbind();
		}
		base.OnBeforeDestroy();
	}

	// Token: 0x060134E5 RID: 79077 RVA: 0x004CD880 File Offset: 0x004CBA80
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

	// Token: 0x060134E6 RID: 79078 RVA: 0x004CD8A4 File Offset: 0x004CBAA4
	private UniTask RefreshSubTabList()
	{
		PhotoEnvironmentPanel.<RefreshSubTabList>d__21 <RefreshSubTabList>d__;
		<RefreshSubTabList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubTabList>d__.<>4__this = this;
		<RefreshSubTabList>d__.<>1__state = -1;
		<RefreshSubTabList>d__.<>t__builder.Start<PhotoEnvironmentPanel.<RefreshSubTabList>d__21>(ref <RefreshSubTabList>d__);
		return <RefreshSubTabList>d__.<>t__builder.Task;
	}

	// Token: 0x060134E7 RID: 79079 RVA: 0x004CD8E8 File Offset: 0x004CBAE8
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

	// Token: 0x060134E8 RID: 79080 RVA: 0x004CD958 File Offset: 0x004CBB58
	private UniTask RefreshWeatherList()
	{
		PhotoEnvironmentPanel.<RefreshWeatherList>d__23 <RefreshWeatherList>d__;
		<RefreshWeatherList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshWeatherList>d__.<>4__this = this;
		<RefreshWeatherList>d__.<>1__state = -1;
		<RefreshWeatherList>d__.<>t__builder.Start<PhotoEnvironmentPanel.<RefreshWeatherList>d__23>(ref <RefreshWeatherList>d__);
		return <RefreshWeatherList>d__.<>t__builder.Task;
	}

	// Token: 0x060134E9 RID: 79081 RVA: 0x004CD99C File Offset: 0x004CBB9C
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

	// Token: 0x060134EA RID: 79082 RVA: 0x004CDA44 File Offset: 0x004CBC44
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

	// Token: 0x060134EB RID: 79083 RVA: 0x004CDB18 File Offset: 0x004CBD18
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

	// Token: 0x060134EC RID: 79084 RVA: 0x004CDB88 File Offset: 0x004CBD88
	private UniTask RefreshWindList()
	{
		PhotoEnvironmentPanel.<RefreshWindList>d__27 <RefreshWindList>d__;
		<RefreshWindList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshWindList>d__.<>4__this = this;
		<RefreshWindList>d__.<>1__state = -1;
		<RefreshWindList>d__.<>t__builder.Start<PhotoEnvironmentPanel.<RefreshWindList>d__27>(ref <RefreshWindList>d__);
		return <RefreshWindList>d__.<>t__builder.Task;
	}

	// Token: 0x060134ED RID: 79085 RVA: 0x004CDBCC File Offset: 0x004CBDCC
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

	// Token: 0x060134EE RID: 79086 RVA: 0x004CDC68 File Offset: 0x004CBE68
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

	// Token: 0x060134EF RID: 79087 RVA: 0x004CDD3E File Offset: 0x004CBF3E
	private void OnWindStrengthChanged(float value)
	{
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		if (effectComponent != null)
		{
			effectComponent.SetWindStrength((float)((int)value));
		}
		this.ViewModel.CurrentWindStrength = (int)value;
	}

	// Token: 0x060134F0 RID: 79088 RVA: 0x004CDD61 File Offset: 0x004CBF61
	private void OnAtmosphereStrengthChanged(float value)
	{
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		if (effectComponent != null)
		{
			effectComponent.SetAtmosphereStrength((float)((int)value));
		}
		this.ViewModel.CurrentAtmosphereStrength = (int)value;
	}

	// Token: 0x060134F1 RID: 79089 RVA: 0x004CDD84 File Offset: 0x004CBF84
	[NullableContext(2)]
	private PhotoCameraEffectComponent GetEffectComponent()
	{
		return PhotographController.Instance.GetPhotoCameraComponent<PhotoCameraEffectComponent>(EPhotoCameraComponent.Effect);
	}

	// Token: 0x060134F2 RID: 79090 RVA: 0x004CDD94 File Offset: 0x004CBF94
	private UniTask RefreshAtmosphereList()
	{
		PhotoEnvironmentPanel.<RefreshAtmosphereList>d__33 <RefreshAtmosphereList>d__;
		<RefreshAtmosphereList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAtmosphereList>d__.<>4__this = this;
		<RefreshAtmosphereList>d__.<>1__state = -1;
		<RefreshAtmosphereList>d__.<>t__builder.Start<PhotoEnvironmentPanel.<RefreshAtmosphereList>d__33>(ref <RefreshAtmosphereList>d__);
		return <RefreshAtmosphereList>d__.<>t__builder.Task;
	}

	// Token: 0x060134F3 RID: 79091 RVA: 0x004CDDD8 File Offset: 0x004CBFD8
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

	// Token: 0x060134F4 RID: 79092 RVA: 0x004CDE74 File Offset: 0x004CC074
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

	// Token: 0x060134F5 RID: 79093 RVA: 0x004CDF57 File Offset: 0x004CC157
	private PhotoWeatherItem CreateWeatherItem()
	{
		return new PhotoWeatherItem
		{
			OnWeatherClick = new Action<int>(this.OnWeatherClick)
		};
	}

	// Token: 0x060134F6 RID: 79094 RVA: 0x004CDF70 File Offset: 0x004CC170
	private PhotoWindItem CreateWindItem()
	{
		return new PhotoWindItem
		{
			OnWindClick = new Action<int>(this.OnWindClick)
		};
	}

	// Token: 0x060134F7 RID: 79095 RVA: 0x004CDF89 File Offset: 0x004CC189
	private PhotoAtmosphereItem CreateAtmosphereItem()
	{
		return new PhotoAtmosphereItem
		{
			OnAtmosphereClick = new Action<int>(this.OnAtmosphereClick)
		};
	}

	// Token: 0x060134F8 RID: 79096 RVA: 0x004CDFA2 File Offset: 0x004CC1A2
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

	// Token: 0x040091A1 RID: 37281
	[Nullable(2)]
	private PhotoSubTabPanel SubTabPanel;

	// Token: 0x040091A2 RID: 37282
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<PhotoWeatherItem, PhotoWeatherData> WeatherLayout;

	// Token: 0x040091A3 RID: 37283
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PhotoWindItem, PhotoWindDirection> WindLayout;

	// Token: 0x040091A4 RID: 37284
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<PhotoAtmosphereItem, PhotoAtmosphere> AtmosphereScroll;

	// Token: 0x040091A5 RID: 37285
	[Nullable(2)]
	private PhotoTimeSetItem TimeSetItem;

	// Token: 0x040091A6 RID: 37286
	[Nullable(2)]
	private PhotoEnvStrengthItem WindStrengthItem;

	// Token: 0x040091A7 RID: 37287
	[Nullable(2)]
	private PhotoEnvStrengthItem AtmosphereStrengthItem;

	// Token: 0x040091A8 RID: 37288
	private List<PhotoWeatherData> WeatherDataList = new List<PhotoWeatherData>();

	// Token: 0x040091A9 RID: 37289
	private List<PhotoWindDirection> WindDataList = new List<PhotoWindDirection>();

	// Token: 0x040091AA RID: 37290
	private List<PhotoAtmosphere> AtmosphereDataList = new List<PhotoAtmosphere>();

	// Token: 0x040091AB RID: 37291
	private bool NeedScrollToEndOnLateTick;

	// Token: 0x02008B33 RID: 35635
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D31B RID: 185115
		ItemSubTabMenu,
		// Token: 0x0402D31C RID: 185116
		ScrollWeatherPanel,
		// Token: 0x0402D31D RID: 185117
		ItemTimeSet,
		// Token: 0x0402D31E RID: 185118
		LayoutWeather,
		// Token: 0x0402D31F RID: 185119
		LayoutWindDirection,
		// Token: 0x0402D320 RID: 185120
		ItemWindStrength,
		// Token: 0x0402D321 RID: 185121
		ItemAtmospherePanel,
		// Token: 0x0402D322 RID: 185122
		LoopScrollAtmosphere,
		// Token: 0x0402D323 RID: 185123
		ItemAtmosphereTemplate,
		// Token: 0x0402D324 RID: 185124
		ItemAtmosphereStrength,
		// Token: 0x0402D325 RID: 185125
		ItemTabLockPanel,
		// Token: 0x0402D326 RID: 185126
		TextTabLockTips,
		// Token: 0x0402D327 RID: 185127
		ItemSubTabLockPanel,
		// Token: 0x0402D328 RID: 185128
		TextSubTabLockTips,
		// Token: 0x0402D329 RID: 185129
		ItemSliderPanel,
		// Token: 0x0402D32A RID: 185130
		ItemEmptyPanel
	}
}
