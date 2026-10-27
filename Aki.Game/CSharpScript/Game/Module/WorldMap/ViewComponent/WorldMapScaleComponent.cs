using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.View.BaseMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020047B4 RID: 18356
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapScaleComponent : MapComponent
	{
		// Token: 0x06030119 RID: 196889 RVA: 0x00B242E3 File Offset: 0x00B224E3
		public WorldMapScaleComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17007862 RID: 30818
		// (get) Token: 0x0603011A RID: 196890 RVA: 0x00B242EC File Offset: 0x00B224EC
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapScale;
			}
		}

		// Token: 0x17007863 RID: 30819
		// (get) Token: 0x0603011B RID: 196891 RVA: 0x00B242EF File Offset: 0x00B224EF
		// (set) Token: 0x0603011C RID: 196892 RVA: 0x00B242F7 File Offset: 0x00B224F7
		public float MapScale
		{
			get
			{
				return this._mapScaleInner;
			}
			set
			{
				if (this._mapScaleInner.Equals(value))
				{
					return;
				}
				this._mapScaleInner = value;
				this._mapScaleDirty = true;
			}
		}

		// Token: 0x17007864 RID: 30820
		// (get) Token: 0x0603011D RID: 196893 RVA: 0x00B24316 File Offset: 0x00B22516
		public bool IsScaleDirty
		{
			get
			{
				return this._mapScaleDirty;
			}
		}

		// Token: 0x0603011E RID: 196894 RVA: 0x00B2431E File Offset: 0x00B2251E
		public void FlushScaleDirty()
		{
			this._mapScaleDirty = false;
		}

		// Token: 0x17007865 RID: 30821
		// (get) Token: 0x0603011F RID: 196895 RVA: 0x00B24328 File Offset: 0x00B22528
		private WorldMapUiEntity WorldMapUiComponent
		{
			get
			{
				WorldMapUiEntity worldMapUiEntity = base.Parent.AsT3 as WorldMapUiEntity;
				if (worldMapUiEntity == null)
				{
					base.LogError(ELogAuthor.LRX, "[地图系统]->二级界面组件没有附加到容器下！", default(ReadOnlySpan<ValueTuple<string, object>>));
					return null;
				}
				return worldMapUiEntity;
			}
		}

		// Token: 0x17007866 RID: 30822
		// (get) Token: 0x06030120 RID: 196896 RVA: 0x00B24365 File Offset: 0x00B22565
		// (set) Token: 0x06030121 RID: 196897 RVA: 0x00B2436D File Offset: 0x00B2256D
		public WorldMapScaleComponent.TScaleChangeEvent ScaleChangeEvent { get; set; }

		// Token: 0x17007867 RID: 30823
		// (get) Token: 0x06030122 RID: 196898 RVA: 0x00B24376 File Offset: 0x00B22576
		// (set) Token: 0x06030123 RID: 196899 RVA: 0x00B2437E File Offset: 0x00B2257E
		public UUISliderComponent ScaleSlider { get; set; }

		// Token: 0x17007868 RID: 30824
		// (get) Token: 0x06030124 RID: 196900 RVA: 0x00B24387 File Offset: 0x00B22587
		// (set) Token: 0x06030125 RID: 196901 RVA: 0x00B2438F File Offset: 0x00B2258F
		public UUIItem BoxPanel { get; set; }

		// Token: 0x17007869 RID: 30825
		// (get) Token: 0x06030126 RID: 196902 RVA: 0x00B24398 File Offset: 0x00B22598
		// (set) Token: 0x06030127 RID: 196903 RVA: 0x00B243A0 File Offset: 0x00B225A0
		public UUISprite BoxThresholdSprite { get; set; }

		// Token: 0x1700786A RID: 30826
		// (get) Token: 0x06030128 RID: 196904 RVA: 0x00B243A9 File Offset: 0x00B225A9
		// (set) Token: 0x06030129 RID: 196905 RVA: 0x00B243B1 File Offset: 0x00B225B1
		public UUITexture BoxHandleTexture { get; set; }

		// Token: 0x1700786B RID: 30827
		// (get) Token: 0x0603012A RID: 196906 RVA: 0x00B243BA File Offset: 0x00B225BA
		// (set) Token: 0x0603012B RID: 196907 RVA: 0x00B243C2 File Offset: 0x00B225C2
		public ButtonItem BoxSwitchButton { get; set; }

		// Token: 0x1700786C RID: 30828
		// (get) Token: 0x0603012C RID: 196908 RVA: 0x00B243CB File Offset: 0x00B225CB
		// (set) Token: 0x0603012D RID: 196909 RVA: 0x00B243D3 File Offset: 0x00B225D3
		public LevelSequencePlayer BoxBarSequencer { get; set; }

		// Token: 0x1700786D RID: 30829
		// (get) Token: 0x0603012E RID: 196910 RVA: 0x00B243DC File Offset: 0x00B225DC
		// (set) Token: 0x0603012F RID: 196911 RVA: 0x00B243E4 File Offset: 0x00B225E4
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<string, UUITexture> SetHandleTextureFunction { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x1700786E RID: 30830
		// (get) Token: 0x06030130 RID: 196912 RVA: 0x00B243F0 File Offset: 0x00B225F0
		private static float BoxThresholdWidth
		{
			get
			{
				WorldMapModel instance = WorldMapModel.Instance;
				if (!instance.IsBoxBarEnabled)
				{
					return 0f;
				}
				return (instance.MapScaleMax - instance.MapScaleMin) * 0.2f;
			}
		}

		// Token: 0x1700786F RID: 30831
		// (get) Token: 0x06030131 RID: 196913 RVA: 0x00B24424 File Offset: 0x00B22624
		private static float SliderMinValue
		{
			get
			{
				return WorldMapModel.Instance.MapScaleMin - WorldMapScaleComponent.BoxThresholdWidth;
			}
		}

		// Token: 0x06030132 RID: 196914 RVA: 0x00B24436 File Offset: 0x00B22636
		private static float SliderValueOf(EWorldMapScaleTier tier, float scale)
		{
			if (tier != EWorldMapScaleTier.OutBox)
			{
				return scale;
			}
			return WorldMapScaleComponent.SliderMinValue;
		}

		// Token: 0x06030133 RID: 196915 RVA: 0x00B24443 File Offset: 0x00B22643
		private static bool IsInOutBoxThreshold(float value)
		{
			return WorldMapScaleComponent.BoxThresholdWidth > 1E-08f && value < WorldMapModel.Instance.MapScaleMin;
		}

		// Token: 0x06030134 RID: 196916 RVA: 0x00B24460 File Offset: 0x00B22660
		public void Initialize()
		{
			WorldMapModel instance = WorldMapModel.Instance;
			this.ScaleSlider.OnValueChangeCb.Unbind();
			this.ScaleSlider.OnValueChangeCb.Bind(new Action<float>(this.OnScaleSliderValueChanged));
			this.ScaleSlider.OnPointUpCallBack.Unbind();
			this.ScaleSlider.OnPointUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnScaleSliderPointUp));
			this.InitializeBoxBar();
			this.SetMapScale(instance.MapScale, EMapScaleSetType.Initialize, true, true);
			this.ScaleSlider.SetMinValue(WorldMapScaleComponent.SliderMinValue, false, false);
			this.ScaleSlider.SetMaxValue(instance.MapScaleMax, false, false);
			this.ScaleSlider.SetValue(WorldMapScaleComponent.SliderValueOf(instance.ScaleTier, this.MapScale), false);
		}

		// Token: 0x06030135 RID: 196917 RVA: 0x00B24524 File Offset: 0x00B22724
		private void InitializeBoxBar()
		{
			WorldMapModel instance = WorldMapModel.Instance;
			bool isBoxBarEnabled = instance.IsBoxBarEnabled;
			UUIItem boxPanel = this.BoxPanel;
			if (boxPanel != null)
			{
				boxPanel.SetUIActive(isBoxBarEnabled);
			}
			ButtonItem boxSwitchButton = this.BoxSwitchButton;
			if (boxSwitchButton != null)
			{
				boxSwitchButton.SetUiActive(isBoxBarEnabled);
			}
			if (!isBoxBarEnabled)
			{
				return;
			}
			UUISprite boxThresholdSprite = this.BoxThresholdSprite;
			if (boxThresholdSprite != null)
			{
				boxThresholdSprite.SetFillAmount(WorldMapScaleComponent.BoxThresholdWidth / (instance.MapScaleMax - WorldMapScaleComponent.SliderMinValue));
			}
			this.RefreshBoxHandleImage();
			this.RefreshBoxSwitchButtonText();
		}

		// Token: 0x06030136 RID: 196918 RVA: 0x00B24598 File Offset: 0x00B22798
		private void OnScaleSliderValueChanged(float value)
		{
			WorldMapModel instance = WorldMapModel.Instance;
			if (this.ScaleSlider.GetSelectionState() != EUISelectableSelectionState.Pressed)
			{
				this.ScaleSlider.SetValue(WorldMapScaleComponent.SliderValueOf(instance.ScaleTier, this.MapScale), false);
				return;
			}
			this.ApplyTierAndScale(instance.ScaleTier, value, EMapScaleSetType.Slider, true, false);
		}

		// Token: 0x06030137 RID: 196919 RVA: 0x00B245E8 File Offset: 0x00B227E8
		private void OnScaleSliderPointUp(ULGUIPointerEventData _)
		{
			if (WorldMapModel.Instance.ScaleTier == EWorldMapScaleTier.Other)
			{
				return;
			}
			float value = this.ScaleSlider.GetValue();
			EWorldMapScaleTier tier = WorldMapScaleComponent.IsInOutBoxThreshold(value) ? EWorldMapScaleTier.OutBox : EWorldMapScaleTier.Box;
			this.ApplyTierAndScale(tier, value, EMapScaleSetType.Slider, true, true);
		}

		// Token: 0x06030138 RID: 196920 RVA: 0x00B24628 File Offset: 0x00B22828
		public void OnScaleTierChanged()
		{
			WorldMapModel instance = WorldMapModel.Instance;
			if (!instance.HasOutBoxTier)
			{
				return;
			}
			this.InitializeBoxBar();
			this.ScaleSlider.SetMinValue(WorldMapScaleComponent.SliderMinValue, false, false);
			this.ScaleSlider.SetValue(WorldMapScaleComponent.SliderValueOf(instance.ScaleTier, this.MapScale), false);
			if (!instance.IsBoxBarEnabled)
			{
				return;
			}
			bool flag = instance.ScaleTier == EWorldMapScaleTier.OutBox;
			LevelSequencePlayer boxBarSequencer = this.BoxBarSequencer;
			if (boxBarSequencer == null)
			{
				return;
			}
			boxBarSequencer.PlayOrReplaySequenceByName(flag ? "BoxSwitchIn" : "BoxSwitchOut", false, null);
		}

		// Token: 0x06030139 RID: 196921 RVA: 0x00B246B8 File Offset: 0x00B228B8
		private void RefreshBoxSwitchButtonText()
		{
			bool flag = WorldMapModel.Instance.ScaleTier == EWorldMapScaleTier.OutBox;
			ButtonItem boxSwitchButton = this.BoxSwitchButton;
			if (boxSwitchButton == null)
			{
				return;
			}
			boxSwitchButton.SetLocalTextNew(flag ? "BoxMapChangeIn_Text" : "BoxMapChangeOut_Text", Array.Empty<object>());
		}

		// Token: 0x0603013A RID: 196922 RVA: 0x00B246F8 File Offset: 0x00B228F8
		private void RefreshBoxHandleImage()
		{
			if (this.BoxHandleTexture == null || this.SetHandleTextureFunction == null)
			{
				return;
			}
			string resourceId = (WorldMapModel.Instance.ScaleTier == EWorldMapScaleTier.OutBox) ? "T_MapCaseBarHandle" : "T_MapBarHandle";
			this.SetHandleTextureFunction(UiResourceConfig.Instance.GetResourcePath(resourceId), this.BoxHandleTexture);
		}

		// Token: 0x0603013B RID: 196923 RVA: 0x00B24750 File Offset: 0x00B22950
		public void AddMapScale(float delta, EMapScaleSetType type)
		{
			WorldMapModel instance = WorldMapModel.Instance;
			if (instance != null && instance.HasOutBoxTier && instance.ScaleTier == EWorldMapScaleTier.OutBox)
			{
				if (delta > 0f)
				{
					this.SetScaleTier(EWorldMapScaleTier.Box, type);
				}
				return;
			}
			if (delta < 0f && instance.IsBoxBarEnabled && this.MapScale - instance.MapScaleMin < 1E-08f)
			{
				this.SetScaleTier(EWorldMapScaleTier.OutBox, type);
				return;
			}
			this.SetMapScale(this.MapScale + delta, type, true, true);
		}

		// Token: 0x0603013C RID: 196924 RVA: 0x00B247C8 File Offset: 0x00B229C8
		public void SetScaleTier(EWorldMapScaleTier tier, EMapScaleSetType type)
		{
			WorldMapModel instance = WorldMapModel.Instance;
			if (tier == EWorldMapScaleTier.OutBox && !instance.HasOutBoxTier)
			{
				return;
			}
			float value = (tier == EWorldMapScaleTier.OutBox) ? instance.OutBoxScale : instance.MapScaleMin;
			this.ApplyTierAndScale(tier, value, type, true, true);
		}

		// Token: 0x0603013D RID: 196925 RVA: 0x00B24806 File Offset: 0x00B22A06
		public void SetMapScale(float value, EMapScaleSetType type, bool sendEvent = true, bool reAssign = true)
		{
			this.ApplyTierAndScale(WorldMapModel.Instance.ScaleTier, value, type, sendEvent, reAssign);
		}

		// Token: 0x0603013E RID: 196926 RVA: 0x00B24820 File Offset: 0x00B22A20
		public void ApplyMapScaleToView()
		{
			BaseMap map = this.WorldMapUiComponent.Map;
			map.SetMapScale(this.MapScale);
			map.SelfPlayerNode.D_SetRelativeScale3D(new FVectorDouble((double)(1f / this.MapScale), (double)(1f / this.MapScale), (double)(1f / this.MapScale)));
		}

		// Token: 0x0603013F RID: 196927 RVA: 0x00B2487C File Offset: 0x00B22A7C
		private void ApplyTierAndScale(EWorldMapScaleTier tier, float value, EMapScaleSetType type, bool sendEvent = true, bool reAssign = true)
		{
			WorldMapModel instance = WorldMapModel.Instance;
			float mapScale = this.MapScale;
			float num = (tier == EWorldMapScaleTier.OutBox) ? instance.OutBoxScale : MathCommon.Clamp(value, instance.MapScaleMin, instance.MapScaleMax);
			if (type != EMapScaleSetType.Initialize && tier == instance.ScaleTier && Math.Abs(num - mapScale) < 1E-08f)
			{
				return;
			}
			this.MapScale = num;
			instance.MapScale = num;
			bool flag = tier != instance.ScaleTier;
			if (flag)
			{
				bool flag2 = type == EMapScaleSetType.Initialize || type == EMapScaleSetType.Navigate;
				flag = !flag2;
			}
			bool flag3 = flag;
			if (!flag3)
			{
				this.ApplyMapScaleToView();
			}
			if (reAssign)
			{
				this.ScaleSlider.SetValue(WorldMapScaleComponent.SliderValueOf(tier, num), false);
			}
			if (sendEvent && !flag3)
			{
				WorldMapScaleComponent.TScaleChangeEvent scaleChangeEvent = this.ScaleChangeEvent;
				if (scaleChangeEvent != null)
				{
					scaleChangeEvent(mapScale, num, type);
				}
			}
			instance.SetScaleTier(tier, type);
		}

		// Token: 0x04019EAC RID: 106156
		private float _mapScaleInner;

		// Token: 0x04019EAD RID: 106157
		private bool _mapScaleDirty;

		// Token: 0x04019EB6 RID: 106166
		private const float BOX_THRESHOLD_RATIO = 0.2f;

		// Token: 0x0200AA6D RID: 43629
		// (Invoke) Token: 0x0604D8E5 RID: 317669
		[NullableContext(0)]
		public delegate void TScaleChangeEvent(float oldScale, float newScale, EMapScaleSetType type);
	}
}
