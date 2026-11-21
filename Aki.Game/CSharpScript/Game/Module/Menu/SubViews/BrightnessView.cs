using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x020043F7 RID: 17399
	[NullableContext(2)]
	[Nullable(0)]
	public class BrightnessView : UiViewBase
	{
		// Token: 0x0602BF82 RID: 180098 RVA: 0x00C58500 File Offset: 0x00C56700
		[NullableContext(1)]
		public BrightnessView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BF83 RID: 180099 RVA: 0x00C5850C File Offset: 0x00C5670C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnYes)),
				new ValueTuple<int, Delegate>(1, new Action(this.OnReset)),
				new ValueTuple<int, Delegate>(2, new Action<float>(this.OnSlide))
			};
		}

		// Token: 0x0602BF84 RID: 180100 RVA: 0x00C58628 File Offset: 0x00C56828
		private void OnSub(bool _)
		{
			float newVal = base.GetSlider(2).GetValue() - 5f;
			this.ChangeSlider(newVal, true);
		}

		// Token: 0x0602BF85 RID: 180101 RVA: 0x00C58650 File Offset: 0x00C56850
		private void OnAdd(bool _)
		{
			float newVal = base.GetSlider(2).GetValue() + 5f;
			this.ChangeSlider(newVal, true);
		}

		// Token: 0x0602BF86 RID: 180102 RVA: 0x00C58678 File Offset: 0x00C56878
		private void ChangeSlider(float newVal, bool isFire = true)
		{
			if (newVal >= 100f)
			{
				base.GetButton(7).SetSelfInteractive(false);
			}
			else if (newVal <= 0f)
			{
				base.GetButton(6).SetSelfInteractive(false);
			}
			else
			{
				base.GetButton(6).SetSelfInteractive(true);
				base.GetButton(7).SetSelfInteractive(true);
			}
			base.GetSlider(2).SetValue(MathUtils.Instance.Clamp(newVal, 0f, 100f), isFire);
		}

		// Token: 0x0602BF87 RID: 180103 RVA: 0x00C586F0 File Offset: 0x00C568F0
		protected override void OnStart()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.PopItem.OverrideBackBtnCallBack(new Action(this.OnClose));
			}
			this.MenuSettingParam = (this.OpenParam as IReadOnlyList<object>);
			this.MenuDataIns = ((this.MenuSettingParam != null && this.MenuSettingParam.Count > 0) ? (this.MenuSettingParam[0] as MenuData) : null);
			if (this.MenuSettingParam != null && this.MenuSettingParam.Count > 1)
			{
				this.MenuSettingCallback = (this.MenuSettingParam[1] as Action<int, float>);
			}
			float num = this.MenuDataIns.SliderRange[0];
			float num2 = this.MenuDataIns.SliderRange[1];
			this.Scalar = Math.Abs(num2 - num) * 0.5f;
			this.LastData = (float)MenuController.Instance.GetTargetConfig(this.MenuDataIns.FunctionId) * this.Scalar;
			this.MenuSettingCallback((int)this.MenuDataIns.FunctionId, this.LastData / this.Scalar);
			float inValue = MathUtils.Instance.RangeClamp(this.LastData, num, num2, 0f, 100f);
			UUISliderComponent slider = base.GetSlider(2);
			slider.SetMaxValue(100f, true, false);
			slider.SetMinValue(0f, true, false);
			slider.SetValue(inValue, true);
			this.AddLongPress = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(7)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.OnAdd));
			this.RemoveLongPress = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(6)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.OnSub));
		}

		// Token: 0x0602BF88 RID: 180104 RVA: 0x00C588A6 File Offset: 0x00C56AA6
		private void OnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602BF89 RID: 180105 RVA: 0x00C588B0 File Offset: 0x00C56AB0
		protected override void OnBeforeDestroy()
		{
			float outRangeA = this.MenuDataIns.SliderRange[0];
			float outRangeB = this.MenuDataIns.SliderRange[1];
			float value = base.GetSlider(2).GetValue();
			float num = MathUtils.Instance.RangeClamp(value, 0f, 100f, outRangeA, outRangeB);
			if (this.IsConfirm && this.LastData != num)
			{
				this.MenuSettingCallback((int)this.MenuDataIns.FunctionId, num / this.Scalar);
				this.IsConfirm = false;
			}
			else
			{
				this.MenuSettingCallback((int)this.MenuDataIns.FunctionId, this.LastData / this.Scalar);
			}
			LongPressButtonItem addLongPress = this.AddLongPress;
			if (addLongPress != null)
			{
				addLongPress.Clear();
			}
			LongPressButtonItem removeLongPress = this.RemoveLongPress;
			if (removeLongPress != null)
			{
				removeLongPress.Clear();
			}
			this.AddLongPress = null;
			this.RemoveLongPress = null;
		}

		// Token: 0x0602BF8A RID: 180106 RVA: 0x00C58989 File Offset: 0x00C56B89
		private void OnYes()
		{
			GenericPromptController.Instance.ShowPromptByCode("AdjustBrighness", Array.Empty<object>());
			this.IsConfirm = true;
			this.OnClose();
		}

		// Token: 0x0602BF8B RID: 180107 RVA: 0x00C589AC File Offset: 0x00C56BAC
		private void OnSlide(float value)
		{
			float num = this.Scalar / 2f;
			float parameterValue;
			if (value < num)
			{
				parameterValue = MathUtils.Instance.Lerp(1.5f, 2.2f, value / num);
			}
			else
			{
				parameterValue = MathUtils.Instance.Lerp(2.2f, 3.5f, (value - num) / num);
			}
			UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetUiShowBrightnessMaterialParameterCollection(), RenderConfig.UIShowBrightness, parameterValue);
			this.ChangeSlider(value, false);
		}

		// Token: 0x0602BF8C RID: 180108 RVA: 0x00C58A28 File Offset: 0x00C56C28
		private void OnReset()
		{
			float sliderDefault = this.MenuDataIns.SliderDefault;
			float sliderPosition = FunctionItemViewTool.GetSliderPosition(this.MenuDataIns.SliderRange, sliderDefault * this.Scalar, this.MenuDataIns.SliderDigits);
			base.GetSlider(2).SetValue(sliderPosition, true);
		}

		// Token: 0x04017AE5 RID: 96997
		private const int STEP = 5;

		// Token: 0x04017AE6 RID: 96998
		private const float SLIDER_MIN_VALUE = 0f;

		// Token: 0x04017AE7 RID: 96999
		private const float SLIDER_MAX_VALUE = 100f;

		// Token: 0x04017AE8 RID: 97000
		protected MenuData MenuDataIns;

		// Token: 0x04017AE9 RID: 97001
		protected bool IsConfirm;

		// Token: 0x04017AEA RID: 97002
		private float Scalar;

		// Token: 0x04017AEB RID: 97003
		private float LastData;

		// Token: 0x04017AEC RID: 97004
		private IReadOnlyList<object> MenuSettingParam;

		// Token: 0x04017AED RID: 97005
		private Action<int, float> MenuSettingCallback;

		// Token: 0x04017AEE RID: 97006
		private LongPressButtonItem AddLongPress;

		// Token: 0x04017AEF RID: 97007
		private LongPressButtonItem RemoveLongPress;
	}
}
