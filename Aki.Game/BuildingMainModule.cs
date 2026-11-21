using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007A2 RID: 1954
[NullableContext(1)]
[Nullable(0)]
public class BuildingMainModule : UiPanelBase
{
	// Token: 0x06005992 RID: 22930 RVA: 0x001D19F4 File Offset: 0x001CFBF4
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

	// Token: 0x06005993 RID: 22931 RVA: 0x001D1A7C File Offset: 0x001CFC7C
	private UniTask InitMapTile()
	{
		BuildingMainModule.<InitMapTile>d__7 <InitMapTile>d__;
		<InitMapTile>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitMapTile>d__.<>4__this = this;
		<InitMapTile>d__.<>1__state = -1;
		<InitMapTile>d__.<>t__builder.Start<BuildingMainModule.<InitMapTile>d__7>(ref <InitMapTile>d__);
		return <InitMapTile>d__.<>t__builder.Task;
	}

	// Token: 0x06005994 RID: 22932 RVA: 0x001D1AC0 File Offset: 0x001CFCC0
	private void InitMoveComponent()
	{
		this.MoveComponent = new BuildingMapMoveComponent(base.GetDraggable(0), true, true, false);
		this.MoveComponent.SetScaleSafeArea(0.44999998807907104, 0.6000000238418579);
		this.MoveComponent.SetChangeScaleCallback(new Action<ESetScaleSource>(this.OnChangeSlider));
	}

	// Token: 0x06005995 RID: 22933 RVA: 0x001D1B18 File Offset: 0x001CFD18
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

	// Token: 0x06005996 RID: 22934 RVA: 0x001D1BFC File Offset: 0x001CFDFC
	protected override UniTask OnBeforeStartAsync()
	{
		BuildingMainModule.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BuildingMainModule.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005997 RID: 22935 RVA: 0x001D1C3F File Offset: 0x001CFE3F
	protected override void OnStart()
	{
		this.InitMoveComponent();
		this.InitZoom();
	}

	// Token: 0x06005998 RID: 22936 RVA: 0x001D1C4D File Offset: 0x001CFE4D
	public void RefreshModule()
	{
		this.MapTile.RefreshRole();
	}

	// Token: 0x06005999 RID: 22937 RVA: 0x001D1C5A File Offset: 0x001CFE5A
	protected override void OnBeforeShow()
	{
		this.MoveComponent.BindTouch();
		this.MoveComponent.AddGamepadEvent();
	}

	// Token: 0x0600599A RID: 22938 RVA: 0x001D1C72 File Offset: 0x001CFE72
	protected override void OnAfterHide()
	{
		this.MoveComponent.UnbindTouch();
		this.MoveComponent.RemoveGamepadEvent();
	}

	// Token: 0x0600599B RID: 22939 RVA: 0x001D1C8A File Offset: 0x001CFE8A
	protected override void OnBeforeDestroy()
	{
		this.MoveComponent.Destroy();
	}

	// Token: 0x0600599C RID: 22940 RVA: 0x001D1C97 File Offset: 0x001CFE97
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		return this.MapTile.GetGuideUiItemAndUiItemForShowEx(configParams);
	}

	// Token: 0x0600599D RID: 22941 RVA: 0x001D1CA5 File Offset: 0x001CFEA5
	private void OnChangeSlider(ESetScaleSource source)
	{
		if (source != ESetScaleSource.Slider)
		{
			this.Slider.SetValue((float)this.MoveComponent.MapScale, false);
		}
	}

	// Token: 0x0600599E RID: 22942 RVA: 0x001D1CC3 File Offset: 0x001CFEC3
	private void OnZoomOut()
	{
		this.MoveComponent.LongPressScroll((float)(-(float)this.MoveComponent.ScaleStep));
	}

	// Token: 0x0600599F RID: 22943 RVA: 0x001D1CDD File Offset: 0x001CFEDD
	private void OnZoomIn()
	{
		this.MoveComponent.LongPressScroll((float)this.MoveComponent.ScaleStep);
	}

	// Token: 0x060059A0 RID: 22944 RVA: 0x001D1CF6 File Offset: 0x001CFEF6
	private void OnSliderValueChange(float value)
	{
		this.MoveComponent.SliderScroll(value);
	}

	// Token: 0x060059A1 RID: 22945 RVA: 0x001D1D04 File Offset: 0x001CFF04
	public void HideBuildingModule()
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.MapTile.SetBuildingItemActive(false);
	}

	// Token: 0x060059A2 RID: 22946 RVA: 0x001D1D25 File Offset: 0x001CFF25
	public void ShowBuilding()
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		this.MapTile.SetBuildingItemActive(true);
	}

	// Token: 0x060059A3 RID: 22947 RVA: 0x001D1D46 File Offset: 0x001CFF46
	public void RefreshBuilding(int buildingId)
	{
		this.MapTile.RefreshBuildingItem(buildingId);
	}

	// Token: 0x04003CA0 RID: 15520
	private BuildingMapTileModule MapTile;

	// Token: 0x04003CA1 RID: 15521
	private BuildingMapMoveComponent MoveComponent;

	// Token: 0x04003CA2 RID: 15522
	private UUISliderComponent Slider;

	// Token: 0x04003CA3 RID: 15523
	protected LongPressButton ZoomIn;

	// Token: 0x04003CA4 RID: 15524
	protected LongPressButton ZoomOut;

	// Token: 0x02006A98 RID: 27288
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04023147 RID: 143687
		public const int MapItem = 0;

		// Token: 0x04023148 RID: 143688
		public const int ZoomItem = 1;

		// Token: 0x04023149 RID: 143689
		public const int ScaleSlider = 2;

		// Token: 0x0402314A RID: 143690
		public const int ZoomIn = 3;

		// Token: 0x0402314B RID: 143691
		public const int ZoomOut = 4;
	}
}
