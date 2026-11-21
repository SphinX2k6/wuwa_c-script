using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x020043F2 RID: 17394
	public class MenuScrollSettingSliderItem : MenuScrollSettingBaseItem
	{
		// Token: 0x0602BF4A RID: 180042 RVA: 0x00C578C4 File Offset: 0x00C55AC4
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

		// Token: 0x0602BF4B RID: 180043 RVA: 0x00C57976 File Offset: 0x00C55B76
		protected override void OnStart()
		{
			base.GetSlider(1).SetCanClickWhenDisable(true);
			this.AddSliderEvent();
		}

		// Token: 0x0602BF4C RID: 180044 RVA: 0x00C5798B File Offset: 0x00C55B8B
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

		// Token: 0x0602BF4D RID: 180045 RVA: 0x00C579CA File Offset: 0x00C55BCA
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

		// Token: 0x0602BF4E RID: 180046 RVA: 0x00C579F9 File Offset: 0x00C55BF9
		private void RefreshTitle()
		{
			base.GetText(0).ShowTextNew(this.Data.FunctionName ?? "");
		}

		// Token: 0x0602BF4F RID: 180047 RVA: 0x00C57A1C File Offset: 0x00C55C1C
		private void RefreshSlider()
		{
			float[] sliderRange = this.Data.SliderRange;
			float num = sliderRange[0];
			float num2 = sliderRange[1];
			MenuModel instance = MenuModel.Instance;
			float? num3 = (instance != null) ? instance.GetDataCacheOrCurValueFloat(this.Data.FunctionId) : null;
			float floatPointFloor = MathUtils.Instance.GetFloatPointFloor(num3.GetValueOrDefault(), this.Data.SliderDigits);
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

		// Token: 0x0602BF50 RID: 180048 RVA: 0x00C57ABC File Offset: 0x00C55CBC
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

		// Token: 0x0602BF51 RID: 180049 RVA: 0x00C57B0E File Offset: 0x00C55D0E
		private void OnSliderChangeCallback(float position)
		{
			this.OnSliderChangeCallback(position, true);
		}

		// Token: 0x0602BF52 RID: 180050 RVA: 0x00C57B18 File Offset: 0x00C55D18
		private void OnSliderChangeCallback(float position, bool fire = true)
		{
			if (base.GetItemClickLimit(base.GetSlider(1)))
			{
				this.SetSlider(this.DisableValue, fire);
				return;
			}
			this.SetSliderText(position, fire);
		}

		// Token: 0x0602BF53 RID: 180051 RVA: 0x00C57B3F File Offset: 0x00C55D3F
		private void OnSliderEndDragCallback()
		{
			if (base.GetItemClickLimit(base.GetSlider(1)))
			{
				return;
			}
			this.OnSliderEnd();
		}

		// Token: 0x0602BF54 RID: 180052 RVA: 0x00C57B57 File Offset: 0x00C55D57
		private void SetSlider(float position, bool fire = true)
		{
			base.GetSlider(1).SetValue(position, fire);
			this.SetSliderText(position, fire);
		}

		// Token: 0x0602BF55 RID: 180053 RVA: 0x00C57B70 File Offset: 0x00C55D70
		private void SetSliderText(float position, bool fire = true)
		{
			float sliderDisplayValue = FunctionItemViewTool.GetSliderDisplayValue(this.Data, position);
			base.GetText(2).SetText(sliderDisplayValue.ToString(), true);
			if (fire)
			{
				this.FireSaveMenuChange(sliderDisplayValue);
			}
		}

		// Token: 0x0602BF56 RID: 180054 RVA: 0x00C57BAD File Offset: 0x00C55DAD
		private void OnSliderEnd()
		{
			MenuModel.Instance.IsEdited = true;
			this.PlaySequenceByName("Flashing".ToString());
		}

		// Token: 0x0602BF57 RID: 180055 RVA: 0x00C57BCF File Offset: 0x00C55DCF
		public override void SetInteractionActive(bool val)
		{
			base.GetSlider(1).SetSelfInteractive(val);
			if (!val)
			{
				this.DisableValue = base.GetSlider(1).GetValue();
			}
		}

		// Token: 0x0602BF58 RID: 180056 RVA: 0x00C57BF4 File Offset: 0x00C55DF4
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

		// Token: 0x0602BF59 RID: 180057 RVA: 0x00C57CA4 File Offset: 0x00C55EA4
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

		// Token: 0x0602BF5A RID: 180058 RVA: 0x00C57CED File Offset: 0x00C55EED
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

		// Token: 0x0602BF5B RID: 180059 RVA: 0x00C57D14 File Offset: 0x00C55F14
		public UniTask RefreshDetailSprite()
		{
			MenuScrollSettingSliderItem.<RefreshDetailSprite>d__19 <RefreshDetailSprite>d__;
			<RefreshDetailSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDetailSprite>d__.<>4__this = this;
			<RefreshDetailSprite>d__.<>1__state = -1;
			<RefreshDetailSprite>d__.<>t__builder.Start<MenuScrollSettingSliderItem.<RefreshDetailSprite>d__19>(ref <RefreshDetailSprite>d__);
			return <RefreshDetailSprite>d__.<>t__builder.Task;
		}

		// Token: 0x04017ADB RID: 96987
		private float DisableValue;

		// Token: 0x0200A0DE RID: 41182
		private class EComponents
		{
			// Token: 0x04031FB5 RID: 204725
			public const int Title = 0;

			// Token: 0x04031FB6 RID: 204726
			public const int Slider = 1;

			// Token: 0x04031FB7 RID: 204727
			public const int SliderText = 2;

			// Token: 0x04031FB8 RID: 204728
			public const int DetailItem = 3;

			// Token: 0x04031FB9 RID: 204729
			public const int DetailText = 4;

			// Token: 0x04031FBA RID: 204730
			public const int DetailSprite = 5;

			// Token: 0x04031FBB RID: 204731
			public const int DetailToggleTransition = 6;
		}
	}
}
