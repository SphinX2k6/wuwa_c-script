using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.FilterSetting
{
	// Token: 0x02005446 RID: 21574
	[NullableContext(2)]
	[Nullable(0)]
	public class FilterSettingSliderItem : UiPanelBase
	{
		// Token: 0x17008443 RID: 33859
		// (get) Token: 0x06037155 RID: 225621 RVA: 0x00D0E888 File Offset: 0x00D0CA88
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

		// Token: 0x06037157 RID: 225623 RVA: 0x00D0E8A8 File Offset: 0x00D0CAA8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(2, typeof(UUISprite))
			};
		}

		// Token: 0x06037158 RID: 225624 RVA: 0x00D0E904 File Offset: 0x00D0CB04
		protected override UniTask OnBeforeStartAsync()
		{
			FilterSettingSliderItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FilterSettingSliderItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037159 RID: 225625 RVA: 0x00D0E947 File Offset: 0x00D0CB47
		protected override void OnBeforeDestroy()
		{
			UUISliderComponent slider = base.GetSlider(1);
			if (slider == null)
			{
				return;
			}
			slider.OnValueChangeCb.Unbind();
		}

		// Token: 0x0603715A RID: 225626 RVA: 0x00D0E95F File Offset: 0x00D0CB5F
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

		// Token: 0x0603715B RID: 225627 RVA: 0x00D0E998 File Offset: 0x00D0CB98
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

		// Token: 0x0603715C RID: 225628 RVA: 0x00D0E9AD File Offset: 0x00D0CBAD
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
