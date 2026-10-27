using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012EE RID: 4846
[NullableContext(1)]
[Nullable(0)]
public class BuildingMainModule : UiPanelBase
{
	// Token: 0x060085F7 RID: 34295 RVA: 0x001C8B88 File Offset: 0x001C6D88
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent))
		};
	}

	// Token: 0x060085F8 RID: 34296 RVA: 0x001C8C10 File Offset: 0x001C6E10
	private UniTask InitMapTile()
	{
		BuildingMainModule.<InitMapTile>d__7 <InitMapTile>d__;
		<InitMapTile>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitMapTile>d__.<>4__this = this;
		<InitMapTile>d__.<>1__state = -1;
		<InitMapTile>d__.<>t__builder.Start<BuildingMainModule.<InitMapTile>d__7>(ref <InitMapTile>d__);
		return <InitMapTile>d__.<>t__builder.Task;
	}

	// Token: 0x060085F9 RID: 34297 RVA: 0x001C8C54 File Offset: 0x001C6E54
	private void InitMoveComponent()
	{
		this.MoveComponent = new BuildingMapMoveComponent(base.GetDraggable(0), true, true, false);
		this.MoveComponent.SetScaleSafeArea(0.44999998807907104, 0.6000000238418579);
		this.MoveComponent.SetChangeScaleCallback(new Action<ESetScaleSource>(this.OnChangeSlider));
	}

	// Token: 0x060085FA RID: 34298 RVA: 0x001C8CAC File Offset: 0x001C6EAC
	private void InitZoom()
	{
		this.Slider = base.GetSlider(2);
		this.Slider.SetMinValue((float)this.MoveComponent.MapScaleSafeArea.Min, false, false);
		this.Slider.SetMaxValue((float)this.MoveComponent.MapScaleSafeArea.Max, false, false);
		this.Slider.OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChange));
		this.Slider.SetValue((float)this.MoveComponent.MapScaleSafeArea.Min, true);
		this.ZoomIn = new LongPressButton(base.GetButton(3), delegate(float _)
		{
			this.OnZoomIn();
		}, 100);
		this.ZoomOut = new LongPressButton(base.GetButton(4), delegate(float _)
		{
			this.OnZoomOut();
		}, 100);
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x060085FB RID: 34299 RVA: 0x001C8D90 File Offset: 0x001C6F90
	protected override UniTask OnBeforeStartAsync()
	{
		BuildingMainModule.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BuildingMainModule.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060085FC RID: 34300 RVA: 0x001C8DD3 File Offset: 0x001C6FD3
	protected override void OnStart()
	{
		this.InitMoveComponent();
		this.InitZoom();
	}

	// Token: 0x060085FD RID: 34301 RVA: 0x001C8DE1 File Offset: 0x001C6FE1
	public void RefreshModule()
	{
		this.MapTile.RefreshRole();
	}

	// Token: 0x060085FE RID: 34302 RVA: 0x001C8DEE File Offset: 0x001C6FEE
	protected override void OnBeforeShow()
	{
		this.MoveComponent.BindTouch();
		this.MoveComponent.AddGamepadEvent();
	}

	// Token: 0x060085FF RID: 34303 RVA: 0x001C8E06 File Offset: 0x001C7006
	protected override void OnAfterHide()
	{
		this.MoveComponent.UnbindTouch();
		this.MoveComponent.RemoveGamepadEvent();
	}

	// Token: 0x06008600 RID: 34304 RVA: 0x001C8E1E File Offset: 0x001C701E
	protected override void OnBeforeDestroy()
	{
		this.MoveComponent.Destroy();
	}

	// Token: 0x06008601 RID: 34305 RVA: 0x001C8E2B File Offset: 0x001C702B
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		return this.MapTile.GetGuideUiItemAndUiItemForShowEx(configParams);
	}

	// Token: 0x06008602 RID: 34306 RVA: 0x001C8E39 File Offset: 0x001C7039
	private void OnChangeSlider(ESetScaleSource source)
	{
		if (source != ESetScaleSource.Slider)
		{
			this.Slider.SetValue((float)this.MoveComponent.MapScale, false);
		}
	}

	// Token: 0x06008603 RID: 34307 RVA: 0x001C8E57 File Offset: 0x001C7057
	private void OnZoomOut()
	{
		this.MoveComponent.LongPressScroll((float)(-(float)this.MoveComponent.ScaleStep));
	}

	// Token: 0x06008604 RID: 34308 RVA: 0x001C8E71 File Offset: 0x001C7071
	private void OnZoomIn()
	{
		this.MoveComponent.LongPressScroll((float)this.MoveComponent.ScaleStep);
	}

	// Token: 0x06008605 RID: 34309 RVA: 0x001C8E8A File Offset: 0x001C708A
	private void OnSliderValueChange(float value)
	{
		this.MoveComponent.SliderScroll(value);
	}

	// Token: 0x06008606 RID: 34310 RVA: 0x001C8E98 File Offset: 0x001C7098
	public void HideBuildingModule()
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.MapTile.SetBuildingItemActive(false);
	}

	// Token: 0x06008607 RID: 34311 RVA: 0x001C8EB9 File Offset: 0x001C70B9
	public void ShowBuilding()
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		this.MapTile.SetBuildingItemActive(true);
	}

	// Token: 0x06008608 RID: 34312 RVA: 0x001C8EDA File Offset: 0x001C70DA
	public void RefreshBuilding(int buildingId)
	{
		this.MapTile.RefreshBuildingItem(buildingId);
	}

	// Token: 0x04003C08 RID: 15368
	private BuildingMapTileModule MapTile;

	// Token: 0x04003C09 RID: 15369
	private BuildingMapMoveComponent MoveComponent;

	// Token: 0x04003C0A RID: 15370
	private UUISliderComponent Slider;

	// Token: 0x04003C0B RID: 15371
	protected LongPressButton ZoomIn;

	// Token: 0x04003C0C RID: 15372
	protected LongPressButton ZoomOut;

	// Token: 0x0200790E RID: 30990
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027E1A RID: 163354
		public const int MapItem = 0;

		// Token: 0x04027E1B RID: 163355
		public const int ZoomItem = 1;

		// Token: 0x04027E1C RID: 163356
		public const int ScaleSlider = 2;

		// Token: 0x04027E1D RID: 163357
		public const int ZoomIn = 3;

		// Token: 0x04027E1E RID: 163358
		public const int ZoomOut = 4;
	}
}
