using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.View.BaseMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020036E5 RID: 14053
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapScaleComponent : MapComponent
	{
		// Token: 0x060248E8 RID: 149736 RVA: 0x00A54265 File Offset: 0x00A52465
		public WorldMapScaleComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17004B1E RID: 19230
		// (get) Token: 0x060248E9 RID: 149737 RVA: 0x00A5426E File Offset: 0x00A5246E
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapScale;
			}
		}

		// Token: 0x17004B1F RID: 19231
		// (get) Token: 0x060248EA RID: 149738 RVA: 0x00A54271 File Offset: 0x00A52471
		// (set) Token: 0x060248EB RID: 149739 RVA: 0x00A54279 File Offset: 0x00A52479
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

		// Token: 0x17004B20 RID: 19232
		// (get) Token: 0x060248EC RID: 149740 RVA: 0x00A54298 File Offset: 0x00A52498
		public bool IsScaleDirty
		{
			get
			{
				return this._mapScaleDirty;
			}
		}

		// Token: 0x060248ED RID: 149741 RVA: 0x00A542A0 File Offset: 0x00A524A0
		public void FlushScaleDirty()
		{
			this._mapScaleDirty = false;
		}

		// Token: 0x17004B21 RID: 19233
		// (get) Token: 0x060248EE RID: 149742 RVA: 0x00A542AC File Offset: 0x00A524AC
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

		// Token: 0x17004B22 RID: 19234
		// (get) Token: 0x060248EF RID: 149743 RVA: 0x00A542E9 File Offset: 0x00A524E9
		// (set) Token: 0x060248F0 RID: 149744 RVA: 0x00A542F1 File Offset: 0x00A524F1
		public WorldMapScaleComponent.TScaleChangeEvent ScaleChangeEvent { get; set; }

		// Token: 0x17004B23 RID: 19235
		// (get) Token: 0x060248F1 RID: 149745 RVA: 0x00A542FA File Offset: 0x00A524FA
		// (set) Token: 0x060248F2 RID: 149746 RVA: 0x00A54302 File Offset: 0x00A52502
		public UUISliderComponent ScaleSlider { get; set; }

		// Token: 0x17004B24 RID: 19236
		// (get) Token: 0x060248F3 RID: 149747 RVA: 0x00A5430B File Offset: 0x00A5250B
		// (set) Token: 0x060248F4 RID: 149748 RVA: 0x00A54313 File Offset: 0x00A52513
		public UUIItem BoxPanel { get; set; }

		// Token: 0x17004B25 RID: 19237
		// (get) Token: 0x060248F5 RID: 149749 RVA: 0x00A5431C File Offset: 0x00A5251C
		// (set) Token: 0x060248F6 RID: 149750 RVA: 0x00A54324 File Offset: 0x00A52524
		public UUISprite BoxThresholdSprite { get; set; }

		// Token: 0x17004B26 RID: 19238
		// (get) Token: 0x060248F7 RID: 149751 RVA: 0x00A5432D File Offset: 0x00A5252D
		// (set) Token: 0x060248F8 RID: 149752 RVA: 0x00A54335 File Offset: 0x00A52535
		public UUITexture BoxHandleTexture { get; set; }

		// Token: 0x17004B27 RID: 19239
		// (get) Token: 0x060248F9 RID: 149753 RVA: 0x00A5433E File Offset: 0x00A5253E
		// (set) Token: 0x060248FA RID: 149754 RVA: 0x00A54346 File Offset: 0x00A52546
		public ButtonItem BoxSwitchButton { get; set; }

		// Token: 0x17004B28 RID: 19240
		// (get) Token: 0x060248FB RID: 149755 RVA: 0x00A5434F File Offset: 0x00A5254F
		// (set) Token: 0x060248FC RID: 149756 RVA: 0x00A54357 File Offset: 0x00A52557
		public LevelSequencePlayer BoxBarSequencer { get; set; }

		// Token: 0x17004B29 RID: 19241
		// (get) Token: 0x060248FD RID: 149757 RVA: 0x00A54360 File Offset: 0x00A52560
		// (set) Token: 0x060248FE RID: 149758 RVA: 0x00A54368 File Offset: 0x00A52568
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

		// Token: 0x17004B2A RID: 19242
		// (get) Token: 0x060248FF RID: 149759 RVA: 0x00A54374 File Offset: 0x00A52574
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

		// Token: 0x17004B2B RID: 19243
		// (get) Token: 0x06024900 RID: 149760 RVA: 0x00A543A8 File Offset: 0x00A525A8
		private static float SliderMinValue
		{
			get
			{
				return WorldMapModel.Instance.MapScaleMin - WorldMapScaleComponent.BoxThresholdWidth;
			}
		}

		// Token: 0x06024901 RID: 149761 RVA: 0x00A543BA File Offset: 0x00A525BA
		private static float SliderValueOf(EWorldMapScaleTier tier, float scale)
		{
			if (tier != EWorldMapScaleTier.OutBox)
			{
				return scale;
			}
			return WorldMapScaleComponent.SliderMinValue;
		}

		// Token: 0x06024902 RID: 149762 RVA: 0x00A543C7 File Offset: 0x00A525C7
		private static bool IsInOutBoxThreshold(float value)
		{
			return WorldMapScaleComponent.BoxThresholdWidth > 1E-08f && value < WorldMapModel.Instance.MapScaleMin;
		}

		// Token: 0x06024903 RID: 149763 RVA: 0x00A543E4 File Offset: 0x00A525E4
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

		// Token: 0x06024904 RID: 149764 RVA: 0x00A544A8 File Offset: 0x00A526A8
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

		// Token: 0x06024905 RID: 149765 RVA: 0x00A5451C File Offset: 0x00A5271C
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

		// Token: 0x06024906 RID: 149766 RVA: 0x00A5456C File Offset: 0x00A5276C
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

		// Token: 0x06024907 RID: 149767 RVA: 0x00A545AC File Offset: 0x00A527AC
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

		// Token: 0x06024908 RID: 149768 RVA: 0x00A5463C File Offset: 0x00A5283C
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

		// Token: 0x06024909 RID: 149769 RVA: 0x00A5467C File Offset: 0x00A5287C
		private void RefreshBoxHandleImage()
		{
			if (this.BoxHandleTexture == null || this.SetHandleTextureFunction == null)
			{
				return;
			}
			string resourceId = (WorldMapModel.Instance.ScaleTier == EWorldMapScaleTier.OutBox) ? "T_MapCaseBarHandle" : "T_MapBarHandle";
			this.SetHandleTextureFunction(UiResourceConfig.Instance.GetResourcePath(resourceId), this.BoxHandleTexture);
		}

		// Token: 0x0602490A RID: 149770 RVA: 0x00A546D4 File Offset: 0x00A528D4
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

		// Token: 0x0602490B RID: 149771 RVA: 0x00A5474C File Offset: 0x00A5294C
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

		// Token: 0x0602490C RID: 149772 RVA: 0x00A5478A File Offset: 0x00A5298A
		public void SetMapScale(float value, EMapScaleSetType type, bool sendEvent = true, bool reAssign = true)
		{
			this.ApplyTierAndScale(WorldMapModel.Instance.ScaleTier, value, type, sendEvent, reAssign);
		}

		// Token: 0x0602490D RID: 149773 RVA: 0x00A547A4 File Offset: 0x00A529A4
		public void ApplyMapScaleToView()
		{
			BaseMap map = this.WorldMapUiComponent.Map;
			map.SetMapScale(this.MapScale);
			map.SelfPlayerNode.D_SetRelativeScale3D(new FVectorDouble((double)(1f / this.MapScale), (double)(1f / this.MapScale), (double)(1f / this.MapScale)));
		}

		// Token: 0x0602490E RID: 149774 RVA: 0x00A54800 File Offset: 0x00A52A00
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

		// Token: 0x0401455C RID: 83292
		private float _mapScaleInner;

		// Token: 0x0401455D RID: 83293
		private bool _mapScaleDirty;

		// Token: 0x04014566 RID: 83302
		private const float BOX_THRESHOLD_RATIO = 0.2f;

		// Token: 0x02009421 RID: 37921
		// (Invoke) Token: 0x06043DF4 RID: 278004
		[NullableContext(0)]
		public delegate void TScaleChangeEvent(float oldScale, float newScale, EMapScaleSetType type);
	}
}
