using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A5A RID: 6746
public class PhotoLightPanel : PhotoDetailPanelBase
{
	// Token: 0x06010A69 RID: 68201 RVA: 0x004DF1F8 File Offset: 0x004DD3F8
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

	// Token: 0x17001934 RID: 6452
	// (get) Token: 0x06010A6A RID: 68202 RVA: 0x004DF2ED File Offset: 0x004DD4ED
	protected override int TabLockPanelIndex
	{
		get
		{
			return 6;
		}
	}

	// Token: 0x17001935 RID: 6453
	// (get) Token: 0x06010A6B RID: 68203 RVA: 0x004DF2F0 File Offset: 0x004DD4F0
	protected override int SubTabLockPanelIndex
	{
		get
		{
			return 8;
		}
	}

	// Token: 0x06010A6C RID: 68204 RVA: 0x004DF2F4 File Offset: 0x004DD4F4
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoLightPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoLightPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010A6D RID: 68205 RVA: 0x004DF338 File Offset: 0x004DD538
	private UniTask RefreshLightList()
	{
		PhotoLightPanel.<RefreshLightList>d__11 <RefreshLightList>d__;
		<RefreshLightList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshLightList>d__.<>4__this = this;
		<RefreshLightList>d__.<>1__state = -1;
		<RefreshLightList>d__.<>t__builder.Start<PhotoLightPanel.<RefreshLightList>d__11>(ref <RefreshLightList>d__);
		return <RefreshLightList>d__.<>t__builder.Task;
	}

	// Token: 0x06010A6E RID: 68206 RVA: 0x004DF37C File Offset: 0x004DD57C
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

	// Token: 0x06010A6F RID: 68207 RVA: 0x004DF44E File Offset: 0x004DD64E
	private void OnLightDirectionChanged(float value)
	{
		PhotoCameraEffectComponent effectComponent = this.GetEffectComponent();
		if (effectComponent != null)
		{
			effectComponent.SetLightDirection(value);
		}
		this.ViewModel.CurrentLightDirection = (int)value;
	}

	// Token: 0x06010A70 RID: 68208 RVA: 0x004DF470 File Offset: 0x004DD670
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

	// Token: 0x06010A71 RID: 68209 RVA: 0x004DF4B4 File Offset: 0x004DD6B4
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

	// Token: 0x06010A72 RID: 68210 RVA: 0x004DF509 File Offset: 0x004DD709
	[NullableContext(2)]
	private PhotoCameraEffectComponent GetEffectComponent()
	{
		return PhotographController.Instance.GetPhotoCameraComponent<PhotoCameraEffectComponent>(EPhotoCameraComponent.Effect);
	}

	// Token: 0x06010A73 RID: 68211 RVA: 0x004DF516 File Offset: 0x004DD716
	[NullableContext(1)]
	private PhotoLightItem CreateLightItem()
	{
		return new PhotoLightItem
		{
			OnLightClick = new Action<int>(this.OnLightClick)
		};
	}

	// Token: 0x04009327 RID: 37671
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<PhotoLightItem, PhotoLight> LightScroll;

	// Token: 0x04009328 RID: 37672
	[Nullable(2)]
	private PhotoLightDirectionItem DirectionItem;

	// Token: 0x04009329 RID: 37673
	[Nullable(1)]
	private List<PhotoLight> LightDataList = new List<PhotoLight>();

	// Token: 0x0400932A RID: 37674
	private bool IsDefaultLightSelected = true;

	// Token: 0x02007CDC RID: 31964
	private enum EComponents
	{
		// Token: 0x040286F0 RID: 165616
		ItemTabMenu,
		// Token: 0x040286F1 RID: 165617
		LoopScrollLight,
		// Token: 0x040286F2 RID: 165618
		ItemLightTemplate,
		// Token: 0x040286F3 RID: 165619
		ItemParamSet,
		// Token: 0x040286F4 RID: 165620
		ItemDirectionSlider,
		// Token: 0x040286F5 RID: 165621
		ItemEmpty,
		// Token: 0x040286F6 RID: 165622
		ItemTabLockPanel,
		// Token: 0x040286F7 RID: 165623
		TextTabLockTips,
		// Token: 0x040286F8 RID: 165624
		ItemSubTabLockPanel,
		// Token: 0x040286F9 RID: 165625
		TextSubTabLockTips
	}
}
