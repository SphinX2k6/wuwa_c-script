using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x0200540F RID: 21519
	public class MenuScrollSettingSliderItem : MenuScrollSettingBaseItem
	{
		// Token: 0x06037001 RID: 225281 RVA: 0x00D084A8 File Offset: 0x00D066A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUIExtendToggleSpriteTransition))
			};
		}

		// Token: 0x06037002 RID: 225282 RVA: 0x00D0855A File Offset: 0x00D0675A
		protected override void OnStart()
		{
			base.GetSlider(1).SetCanClickWhenDisable(true);
			this.AddSliderEvent();
		}

		// Token: 0x06037003 RID: 225283 RVA: 0x00D0856F File Offset: 0x00D0676F
		protected override void OnClear()
		{
			FLGUISliderDynamicDelegate onValueChangeCb = base.GetSlider(1).OnValueChangeCb;
			if (onValueChangeCb != null)
			{
				onValueChangeCb.Unbind();
			}
			FLGUISliderEndDragDelegate onEndDragCb = base.GetSlider(1).OnEndDragCb;
			if (onEndDragCb != null)
			{
				onEndDragCb.Unbind();
			}
			if (this.Data != null)
			{
				this.Data = null;
			}
		}

		// Token: 0x06037004 RID: 225284 RVA: 0x00D085AE File Offset: 0x00D067AE
		[NullableContext(1)]
		public override void Update(MenuData data, bool bGameSettingsUpdate)
		{
			this.Data = data;
			this.RefreshTitle();
			if (!bGameSettingsUpdate)
			{
				this.RefreshSlider();
			}
			this.RefreshDetailText();
			this.RefreshDetailSpriteVisible();
			this.RefreshDetailSprite().Forget();
		}

		// Token: 0x06037005 RID: 225285 RVA: 0x00D085DD File Offset: 0x00D067DD
		private void RefreshTitle()
		{
			base.GetText(0).ShowTextNew(this.Data.FunctionName ?? "");
		}

		// Token: 0x06037006 RID: 225286 RVA: 0x00D08600 File Offset: 0x00D06800
		private void RefreshSlider()
		{
			float[] sliderRange = this.Data.SliderRange;
			float num = sliderRange[0];
			float num2 = sliderRange[1];
			MenuModel instance = MenuModel.Instance;
			float? num3 = (instance != null) ? instance.GetDataCacheOrCurValueFloat(this.Data.FunctionId) : null;
			float floatPointFloor = MathUtils.Instance.GetFloatPointFloor(num3.Value, this.Data.SliderDigits);
			UUISliderComponent slider = base.GetSlider(1);
			UUIItem rootComponent = slider.GetRootComponent();
			if (rootComponent != null)
			{
				rootComponent.SetUIActive(true);
			}
			slider.SetMaxValue(num2, true, false);
			slider.SetMinValue(num, true, false);
			this.SetSlider(MathUtils.Instance.Clamp(floatPointFloor, num, num2), false);
		}

		// Token: 0x06037007 RID: 225287 RVA: 0x00D086A0 File Offset: 0x00D068A0
		private void AddSliderEvent()
		{
			UUISliderComponent slider = base.GetSlider(1);
			if (slider != null)
			{
				slider.OnValueChangeCb.Bind(new Action<float>(this.OnSliderChangeCallback));
			}
			UUISliderComponent slider2 = base.GetSlider(1);
			if (slider2 == null)
			{
				return;
			}
			slider2.OnEndDragCb.Bind(new Action(this.OnSliderEndDragCallback));
		}

		// Token: 0x06037008 RID: 225288 RVA: 0x00D086F2 File Offset: 0x00D068F2
		private void OnSliderChangeCallback(float position)
		{
			this.OnSliderChangeCallback(position, true);
		}

		// Token: 0x06037009 RID: 225289 RVA: 0x00D086FC File Offset: 0x00D068FC
		private void OnSliderChangeCallback(float position, bool fire = true)
		{
			if (base.GetItemClickLimit(base.GetSlider(1)))
			{
				this.SetSlider(this.DisableValue, fire);
				return;
			}
			this.SetSliderText(position, fire);
		}

		// Token: 0x0603700A RID: 225290 RVA: 0x00D08723 File Offset: 0x00D06923
		private void OnSliderEndDragCallback()
		{
			if (base.GetItemClickLimit(base.GetSlider(1)))
			{
				return;
			}
			this.OnSliderEnd();
		}

		// Token: 0x0603700B RID: 225291 RVA: 0x00D0873B File Offset: 0x00D0693B
		private void SetSlider(float position, bool fire = true)
		{
			base.GetSlider(1).SetValue(position, fire);
			this.SetSliderText(position, fire);
		}

		// Token: 0x0603700C RID: 225292 RVA: 0x00D08754 File Offset: 0x00D06954
		private void SetSliderText(float position, bool fire = true)
		{
			float sliderDisplayValue = FunctionItemViewTool.GetSliderDisplayValue(this.Data, position);
			base.GetText(2).SetText(sliderDisplayValue.ToString(), true);
			if (fire)
			{
				this.FireSaveMenuChange(sliderDisplayValue);
			}
		}

		// Token: 0x0603700D RID: 225293 RVA: 0x00D08791 File Offset: 0x00D06991
		private void OnSliderEnd()
		{
			MenuModel.Instance.IsEdited = true;
			this.PlaySequenceByName("Flashing".ToString());
		}

		// Token: 0x0603700E RID: 225294 RVA: 0x00D087B3 File Offset: 0x00D069B3
		public override void SetInteractionActive(bool val)
		{
			base.GetSlider(1).SetSelfInteractive(val);
			if (!val)
			{
				this.DisableValue = base.GetSlider(1).GetValue();
			}
		}

		// Token: 0x0603700F RID: 225295 RVA: 0x00D087D8 File Offset: 0x00D069D8
		protected override void OnSetDetailVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(bVisible);
			}
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.CanClickWhenDisable && !this.Data.GetEnable())
			{
				FColor color = bVisible ? FColor.FromHex("FFF7B6FF") : FColor.FromHex("FFFFFFFF");
				base.GetSprite(5).SetColor(color);
				base.GetUiExtendToggleSpriteTransition(6).TransitionState.UnDetermineUnHoverState.Color = color;
				base.GetUiExtendToggleSpriteTransition(6).TransitionState.UnDetermineHoverState.Color = color;
				base.GetUiExtendToggleSpriteTransition(6).TransitionState.UnDeterminePressedState.Color = color;
			}
		}

		// Token: 0x06037010 RID: 225296 RVA: 0x00D08888 File Offset: 0x00D06A88
		private void RefreshDetailText()
		{
			if (this.Data == null)
			{
				return;
			}
			if (!this.Data.HasDetailText())
			{
				return;
			}
			UUIText text = base.GetText(4);
			string detailTextId = this.Data.GetDetailTextId();
			LguiUtil.Instance.SetLocalTextNew(text, detailTextId, Array.Empty<object>());
		}

		// Token: 0x06037011 RID: 225297 RVA: 0x00D088D1 File Offset: 0x00D06AD1
		private void RefreshDetailSpriteVisible()
		{
			if (this.Data == null)
			{
				return;
			}
			UUISprite sprite = base.GetSprite(5);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(this.Data.ShowHelpBtn());
		}

		// Token: 0x06037012 RID: 225298 RVA: 0x00D088F8 File Offset: 0x00D06AF8
		public UniTask RefreshDetailSprite()
		{
			MenuScrollSettingSliderItem.<RefreshDetailSprite>d__19 <RefreshDetailSprite>d__;
			<RefreshDetailSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDetailSprite>d__.<>4__this = this;
			<RefreshDetailSprite>d__.<>1__state = -1;
			<RefreshDetailSprite>d__.<>t__builder.Start<MenuScrollSettingSliderItem.<RefreshDetailSprite>d__19>(ref <RefreshDetailSprite>d__);
			return <RefreshDetailSprite>d__.<>t__builder.Task;
		}

		// Token: 0x0401D042 RID: 118850
		private float DisableValue;

		// Token: 0x0200B6A6 RID: 46758
		private class EComponents
		{
			// Token: 0x04037560 RID: 226656
			public const int Title = 0;

			// Token: 0x04037561 RID: 226657
			public const int Slider = 1;

			// Token: 0x04037562 RID: 226658
			public const int SliderText = 2;

			// Token: 0x04037563 RID: 226659
			public const int DetailItem = 3;

			// Token: 0x04037564 RID: 226660
			public const int DetailText = 4;

			// Token: 0x04037565 RID: 226661
			public const int DetailSprite = 5;

			// Token: 0x04037566 RID: 226662
			public const int DetailToggleTransition = 6;
		}
	}
}
