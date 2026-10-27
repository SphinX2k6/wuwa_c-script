using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200256F RID: 9583
public class PhotoLightPanel : PhotoDetailPanelBase
{
	// Token: 0x06013587 RID: 79239 RVA: 0x004D05C0 File Offset: 0x004CE7C0
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
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText))
		};
	}

	// Token: 0x170018FA RID: 6394
	// (get) Token: 0x06013588 RID: 79240 RVA: 0x004D06B5 File Offset: 0x004CE8B5
	protected override int TabLockPanelIndex
	{
		get
		{
			return 6;
		}
	}

	// Token: 0x170018FB RID: 6395
	// (get) Token: 0x06013589 RID: 79241 RVA: 0x004D06B8 File Offset: 0x004CE8B8
	protected override int SubTabLockPanelIndex
	{
		get
		{
			return 8;
		}
	}

	// Token: 0x0601358A RID: 79242 RVA: 0x004D06BC File Offset: 0x004CE8BC
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoLightPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoLightPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601358B RID: 79243 RVA: 0x004D0700 File Offset: 0x004CE900
	private UniTask RefreshLightList()
	{
		PhotoLightPanel.<RefreshLightList>d__11 <RefreshLightList>d__;
		<RefreshLightList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshLightList>d__.<>4__this = this;
		<RefreshLightList>d__.<>1__state = -1;
		<RefreshLightList>d__.<>t__builder.Start<PhotoLightPanel.<RefreshLightList>d__11>(ref <RefreshLightList>d__);
		return <RefreshLightList>d__.<>t__builder.Task;
	}

	// Token: 0x0601358C RID: 79244 RVA: 0x004D0744 File Offset: 0x004CE944
	private void OnLightClick(int gridIndex)
	{
		if (gridIndex < 0 || gridIndex >= this.LightDataList.Count)
		{
			return;
		}
		LoopScrollView<PhotoLightItem, PhotoLight> lightScroll = this.LightScroll;
		if (lightScroll != null)
		{
			lightScroll.SelectGridProxy(gridIndex, false);
		}
		PhotoLight data = this.LightDataList[gridIndex];
		bool isDefault = data.IsDefault;
		this.IsDefaultLightSelected = isDefault;
		this.RefreshLightParamPanelVisible();
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		int? num = (effectComponent != null) ? new int?(effectComponent.SelectLight(data)) : null;
		float num2 = (num != null) ? ((float)num.GetValueOrDefault()) : data.Direction;
		this.ViewModel.CurrentLightId = data.Id;
		this.ViewModel.CurrentLightDirection = (isDefault ? 0 : ((int)num2));
		if (!isDefault)
		{
			PhotoLightDirectionItem directionItem = this.DirectionItem;
			if (directionItem == null)
			{
				return;
			}
			directionItem.SetDirection(num2, data.Direction);
		}
	}

	// Token: 0x0601358D RID: 79245 RVA: 0x004D0816 File Offset: 0x004CEA16
	private void OnLightDirectionChanged(float value)
	{
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		if (effectComponent != null)
		{
			effectComponent.SetLightDirection(value);
		}
		this.ViewModel.CurrentLightDirection = (int)value;
	}

	// Token: 0x0601358E RID: 79246 RVA: 0x004D0838 File Offset: 0x004CEA38
	protected override void RefreshContentVisible()
	{
		bool uiactive = !base.IsCurrentTabBanned;
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(1);
		if (loopScrollViewComponent != null)
		{
			UUIItem uuiitem = loopScrollViewComponent.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(uiactive);
			}
		}
		this.RefreshLightParamPanelVisible();
	}

	// Token: 0x0601358F RID: 79247 RVA: 0x004D087C File Offset: 0x004CEA7C
	private void RefreshLightParamPanelVisible()
	{
		bool flag = !base.IsCurrentTabBanned;
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(flag && !this.IsDefaultLightSelected);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(flag && this.IsDefaultLightSelected);
	}

	// Token: 0x06013590 RID: 79248 RVA: 0x004D08D1 File Offset: 0x004CEAD1
	[NullableContext(2)]
	private PhotoCameraEffectComponent GetEffectComponent()
	{
		return PhotographController.Instance.GetPhotoCameraComponent<PhotoCameraEffectComponent>(EPhotoCameraComponent.Effect);
	}

	// Token: 0x06013591 RID: 79249 RVA: 0x004D08DE File Offset: 0x004CEADE
	[NullableContext(1)]
	private PhotoLightItem CreateLightItem()
	{
		return new PhotoLightItem
		{
			OnLightClick = new Action<int>(this.OnLightClick)
		};
	}

	// Token: 0x040091CE RID: 37326
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<PhotoLightItem, PhotoLight> LightScroll;

	// Token: 0x040091CF RID: 37327
	[Nullable(2)]
	private PhotoLightDirectionItem DirectionItem;

	// Token: 0x040091D0 RID: 37328
	[Nullable(1)]
	private List<PhotoLight> LightDataList = new List<PhotoLight>();

	// Token: 0x040091D1 RID: 37329
	private bool IsDefaultLightSelected = true;

	// Token: 0x02008B56 RID: 35670
	private enum EComponents
	{
		// Token: 0x0402D3E3 RID: 185315
		ItemTabMenu,
		// Token: 0x0402D3E4 RID: 185316
		LoopScrollLight,
		// Token: 0x0402D3E5 RID: 185317
		ItemLightTemplate,
		// Token: 0x0402D3E6 RID: 185318
		ItemParamSet,
		// Token: 0x0402D3E7 RID: 185319
		ItemDirectionSlider,
		// Token: 0x0402D3E8 RID: 185320
		ItemEmpty,
		// Token: 0x0402D3E9 RID: 185321
		ItemTabLockPanel,
		// Token: 0x0402D3EA RID: 185322
		TextTabLockTips,
		// Token: 0x0402D3EB RID: 185323
		ItemSubTabLockPanel,
		// Token: 0x0402D3EC RID: 185324
		TextSubTabLockTips
	}
}
