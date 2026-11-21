using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.EyeProtect
{
	// Token: 0x02004430 RID: 17456
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class EyeProtectSliderItem : GridProxyAbstract<EyeProtectSliderData>
	{
		// Token: 0x0602C0DE RID: 180446 RVA: 0x00C5E878 File Offset: 0x00C5CA78
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x0602C0DF RID: 180447 RVA: 0x00C5E8FE File Offset: 0x00C5CAFE
		protected override void OnStart()
		{
			base.GetSlider(1).OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChange));
		}

		// Token: 0x0602C0E0 RID: 180448 RVA: 0x00C5E920 File Offset: 0x00C5CB20
		public override void Refresh(EyeProtectSliderData data, bool isSelected, int gridIndex)
		{
			UUISliderComponent slider = base.GetSlider(1);
			slider.SetMaxValue(data.MaxValue, true, false);
			slider.SetMinValue(data.MinValue, true, false);
			slider.SetValue(data.CurValue, true);
			this.IsTemp = (data.FunctionId.GetValueOrDefault() == EFunction.EyeProtectionTemp);
			this.Init(data);
			this.Data = data;
			float sliderDisplayValue = FunctionItemViewTool.GetSliderDisplayValue(data.MenuData, data.CurValue);
			string str = this.IsTemp ? "k" : "";
			base.GetText(0).SetText(sliderDisplayValue.ToString() + str, true);
		}

		// Token: 0x0602C0E1 RID: 180449 RVA: 0x00C5E9C8 File Offset: 0x00C5CBC8
		private void Init(EyeProtectSliderData data)
		{
			if (this.Data != null)
			{
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), data.Title, Array.Empty<object>());
			if (this.IsTemp)
			{
				base.GetItem(3).SetUIActive(true);
				base.GetItem(4).SetUIActive(false);
			}
		}

		// Token: 0x0602C0E2 RID: 180450 RVA: 0x00C5EA1C File Offset: 0x00C5CC1C
		private void OnSliderValueChange(float value)
		{
			if (this.Data == null)
			{
				return;
			}
			this.Data.OnChangeValue(value);
			float sliderDisplayValue = FunctionItemViewTool.GetSliderDisplayValue(this.Data.MenuData, value);
			string str = this.IsTemp ? "k" : "";
			base.GetText(0).SetText(sliderDisplayValue.ToString() + str, true);
		}

		// Token: 0x04017BB5 RID: 97205
		[Nullable(2)]
		protected EyeProtectSliderData Data;

		// Token: 0x04017BB6 RID: 97206
		protected bool IsTemp;

		// Token: 0x0200A0FF RID: 41215
		[NullableContext(0)]
		public class ESliderComponent
		{
			// Token: 0x04032050 RID: 204880
			public const int NumText = 0;

			// Token: 0x04032051 RID: 204881
			public const int Slider = 1;

			// Token: 0x04032052 RID: 204882
			public const int TitleText = 2;

			// Token: 0x04032053 RID: 204883
			public const int TemperatureBg = 3;

			// Token: 0x04032054 RID: 204884
			public const int FillArea = 4;
		}
	}
}
