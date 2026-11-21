using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.FilterSetting
{
	// Token: 0x02004425 RID: 17445
	public class FilterSeniorParamSliderItem : GridProxyAbstract<FilterSeniorSetting>
	{
		// Token: 0x0602C074 RID: 180340 RVA: 0x00C5C834 File Offset: 0x00C5AA34
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText))
			};
		}

		// Token: 0x0602C075 RID: 180341 RVA: 0x00C5C8D0 File Offset: 0x00C5AAD0
		protected override void OnStart()
		{
			base.GetSlider(1).OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChanged));
		}

		// Token: 0x0602C076 RID: 180342 RVA: 0x00C5C8F0 File Offset: 0x00C5AAF0
		public override void Refresh(FilterSeniorSetting data, bool isSelected, int gridIndex)
		{
			this.FilterSeniorSetting = data;
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(data.IsNeedSpecialBg);
			}
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(!data.IsNeedSpecialBg);
			}
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(!data.IsNeedSpecialBg);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), data.Name, Array.Empty<object>());
			int filterSettingIdCache = MenuModel.Instance.FilterSettingIdCache;
			float[] array;
			if (!MenuModel.Instance.FilterSettingValuesCache.TryGetValue(filterSettingIdCache, out array))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GameSettings;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "全局滤镜高级参数未找到默认值";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("param", this.FilterSeniorSetting.ParamIndex);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			double num = Math.Round((double)(array[this.FilterSeniorSetting.ParamIndex] * (float)this.FilterSeniorSetting.Ratio));
			if (num == 0.0)
			{
				num = 0.0;
			}
			UUIText text = base.GetText(0);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted<double>(num);
			defaultInterpolatedStringHandler.AppendFormatted(this.FilterSeniorSetting.Unit);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			double num2 = MathUtils.Instance.RangeClamp(num, (double)this.FilterSeniorSetting.RangeMin, (double)this.FilterSeniorSetting.RangeMax, 0.0, 1.0);
			UUISliderComponent slider = base.GetSlider(1);
			if (slider == null)
			{
				return;
			}
			slider.SetValue((float)num2, false);
		}

		// Token: 0x0602C077 RID: 180343 RVA: 0x00C5CA88 File Offset: 0x00C5AC88
		private void OnSliderValueChanged(float value)
		{
			FilterSettingViewModel parentViewModel = this.ParentViewModel;
			if (parentViewModel != null && parentViewModel.IsPropertyDirty(512))
			{
				return;
			}
			float num = MathUtils.Instance.RangeClamp(value, 0f, 1f, this.FilterSeniorSetting.RangeMin, this.FilterSeniorSetting.RangeMax);
			float arg = num / (float)this.FilterSeniorSetting.Ratio;
			FilterSettingViewModel parentViewModel2 = this.ParentViewModel;
			if (parentViewModel2 != null)
			{
				Action<EFilterSettingValueIndex, float> onSeniorSliderChanged = parentViewModel2.OnSeniorSliderChanged;
				if (onSeniorSliderChanged != null)
				{
					onSeniorSliderChanged((EFilterSettingValueIndex)this.FilterSeniorSetting.ParamIndex, arg);
				}
			}
			double num2 = Math.Round((double)num);
			if (num2 == 0.0)
			{
				num2 = 0.0;
			}
			UUIText text = base.GetText(0);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted<double>(num2);
			defaultInterpolatedStringHandler.AppendFormatted(this.FilterSeniorSetting.Unit);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x04017B85 RID: 97157
		[Nullable(2)]
		public FilterSettingViewModel ParentViewModel;

		// Token: 0x04017B86 RID: 97158
		private FilterSeniorSetting FilterSeniorSetting;

		// Token: 0x0200A0F5 RID: 41205
		public class EComponent
		{
			// Token: 0x0403200A RID: 204810
			public const int TextValue = 0;

			// Token: 0x0403200B RID: 204811
			public const int SliderValue = 1;

			// Token: 0x0403200C RID: 204812
			public const int SpriteHandle = 2;

			// Token: 0x0403200D RID: 204813
			public const int SpriteNormalBg = 3;

			// Token: 0x0403200E RID: 204814
			public const int SpriteTempBg = 4;

			// Token: 0x0403200F RID: 204815
			public const int ItemFillArea = 5;

			// Token: 0x04032010 RID: 204816
			public const int ToggleRoot = 6;

			// Token: 0x04032011 RID: 204817
			public const int TextName = 7;
		}
	}
}
