using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005414 RID: 21524
	[NullableContext(2)]
	[Nullable(0)]
	public class BrightnessView : UiViewBase
	{
		// Token: 0x06037039 RID: 225337 RVA: 0x00D090D8 File Offset: 0x00D072D8
		[NullableContext(1)]
		public BrightnessView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603703A RID: 225338 RVA: 0x00D090E4 File Offset: 0x00D072E4
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

		// Token: 0x0603703B RID: 225339 RVA: 0x00D09200 File Offset: 0x00D07400
		private void OnSub(bool _)
		{
			float newVal = base.GetSlider(2).GetValue() - 5f;
			this.ChangeSlider(newVal, true);
		}

		// Token: 0x0603703C RID: 225340 RVA: 0x00D09228 File Offset: 0x00D07428
		private void OnAdd(bool _)
		{
			float newVal = base.GetSlider(2).GetValue() + 5f;
			this.ChangeSlider(newVal, true);
		}

		// Token: 0x0603703D RID: 225341 RVA: 0x00D09250 File Offset: 0x00D07450
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

		// Token: 0x0603703E RID: 225342 RVA: 0x00D092C8 File Offset: 0x00D074C8
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

		// Token: 0x0603703F RID: 225343 RVA: 0x00D0947E File Offset: 0x00D0767E
		private void OnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06037040 RID: 225344 RVA: 0x00D09488 File Offset: 0x00D07688
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

		// Token: 0x06037041 RID: 225345 RVA: 0x00D09561 File Offset: 0x00D07761
		private void OnYes()
		{
			GenericPromptController.Instance.ShowPromptByCode("AdjustBrighness", Array.Empty<object>());
			this.IsConfirm = true;
			this.OnClose();
		}

		// Token: 0x06037042 RID: 225346 RVA: 0x00D09584 File Offset: 0x00D07784
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

		// Token: 0x06037043 RID: 225347 RVA: 0x00D09600 File Offset: 0x00D07800
		private void OnReset()
		{
			float sliderDefault = this.MenuDataIns.SliderDefault;
			float sliderPosition = FunctionItemViewTool.GetSliderPosition(this.MenuDataIns.SliderRange, sliderDefault * this.Scalar, this.MenuDataIns.SliderDigits);
			base.GetSlider(2).SetValue(sliderPosition, true);
		}

		// Token: 0x0401D04C RID: 118860
		private const int STEP = 5;

		// Token: 0x0401D04D RID: 118861
		private const float SLIDER_MIN_VALUE = 0f;

		// Token: 0x0401D04E RID: 118862
		private const float SLIDER_MAX_VALUE = 100f;

		// Token: 0x0401D04F RID: 118863
		protected MenuData MenuDataIns;

		// Token: 0x0401D050 RID: 118864
		protected bool IsConfirm;

		// Token: 0x0401D051 RID: 118865
		private float Scalar;

		// Token: 0x0401D052 RID: 118866
		private float LastData;

		// Token: 0x0401D053 RID: 118867
		private IReadOnlyList<object> MenuSettingParam;

		// Token: 0x0401D054 RID: 118868
		private Action<int, float> MenuSettingCallback;

		// Token: 0x0401D055 RID: 118869
		private LongPressButtonItem AddLongPress;

		// Token: 0x0401D056 RID: 118870
		private LongPressButtonItem RemoveLongPress;
	}
}
