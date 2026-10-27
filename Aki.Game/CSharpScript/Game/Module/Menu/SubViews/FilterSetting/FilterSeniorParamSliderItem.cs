using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.FilterSetting
{
	// Token: 0x02005442 RID: 21570
	public class FilterSeniorParamSliderItem : GridProxyAbstract<FilterSeniorSetting>
	{
		// Token: 0x0603712B RID: 225579 RVA: 0x00D0D41C File Offset: 0x00D0B61C
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

		// Token: 0x0603712C RID: 225580 RVA: 0x00D0D4B8 File Offset: 0x00D0B6B8
		protected override void OnStart()
		{
			base.GetSlider(1).OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChanged));
		}

		// Token: 0x0603712D RID: 225581 RVA: 0x00D0D4D8 File Offset: 0x00D0B6D8
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

		// Token: 0x0603712E RID: 225582 RVA: 0x00D0D670 File Offset: 0x00D0B870
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

		// Token: 0x0401D0EC RID: 119020
		[Nullable(2)]
		public FilterSettingViewModel ParentViewModel;

		// Token: 0x0401D0ED RID: 119021
		private FilterSeniorSetting FilterSeniorSetting;

		// Token: 0x0200B6BD RID: 46781
		public class EComponent
		{
			// Token: 0x040375B5 RID: 226741
			public const int TextValue = 0;

			// Token: 0x040375B6 RID: 226742
			public const int SliderValue = 1;

			// Token: 0x040375B7 RID: 226743
			public const int SpriteHandle = 2;

			// Token: 0x040375B8 RID: 226744
			public const int SpriteNormalBg = 3;

			// Token: 0x040375B9 RID: 226745
			public const int SpriteTempBg = 4;

			// Token: 0x040375BA RID: 226746
			public const int ItemFillArea = 5;

			// Token: 0x040375BB RID: 226747
			public const int ToggleRoot = 6;

			// Token: 0x040375BC RID: 226748
			public const int TextName = 7;
		}
	}
}
