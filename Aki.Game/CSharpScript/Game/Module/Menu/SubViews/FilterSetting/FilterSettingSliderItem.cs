using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.FilterSetting
{
	// Token: 0x02004429 RID: 17449
	[NullableContext(2)]
	[Nullable(0)]
	public class FilterSettingSliderItem : UiPanelBase
	{
		// Token: 0x1700580F RID: 22543
		// (get) Token: 0x0602C09E RID: 180382 RVA: 0x00C5DCA0 File Offset: 0x00C5BEA0
		private FilterSettingViewModel ParentViewModel
		{
			get
			{
				if (this.OpenParam == null)
				{
					return null;
				}
				return this.OpenParam as FilterSettingViewModel;
			}
		}

		// Token: 0x0602C0A0 RID: 180384 RVA: 0x00C5DCC0 File Offset: 0x00C5BEC0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(2, typeof(UUISprite))
			};
		}

		// Token: 0x0602C0A1 RID: 180385 RVA: 0x00C5DD1C File Offset: 0x00C5BF1C
		protected override UniTask OnBeforeStartAsync()
		{
			FilterSettingSliderItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FilterSettingSliderItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C0A2 RID: 180386 RVA: 0x00C5DD5F File Offset: 0x00C5BF5F
		protected override void OnBeforeDestroy()
		{
			UUISliderComponent slider = base.GetSlider(1);
			if (slider == null)
			{
				return;
			}
			slider.OnValueChangeCb.Unbind();
		}

		// Token: 0x0602C0A3 RID: 180387 RVA: 0x00C5DD77 File Offset: 0x00C5BF77
		private void OnSliderValueChanged(float value)
		{
			if (this.ParentViewModel != null && !this.ParentViewModel.IsPropertyDirty(2))
			{
				this.ParentViewModel.IntensityNormalized = value;
				Action onSliderChanged = this.ParentViewModel.OnSliderChanged;
				if (onSliderChanged == null)
				{
					return;
				}
				onSliderChanged();
			}
		}

		// Token: 0x0602C0A4 RID: 180388 RVA: 0x00C5DDB0 File Offset: 0x00C5BFB0
		[NullableContext(1)]
		public void SetTitleText(string text)
		{
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x0602C0A5 RID: 180389 RVA: 0x00C5DDC5 File Offset: 0x00C5BFC5
		public void SetSliderValue(float value)
		{
			UUISliderComponent slider = base.GetSlider(1);
			if (slider == null)
			{
				return;
			}
			slider.SetValue(value, false);
		}
	}
}
