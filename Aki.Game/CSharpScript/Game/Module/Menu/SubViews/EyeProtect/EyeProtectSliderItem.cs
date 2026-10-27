using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.EyeProtect
{
	// Token: 0x0200544D RID: 21581
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class EyeProtectSliderItem : GridProxyAbstract<EyeProtectSliderData>
	{
		// Token: 0x06037195 RID: 225685 RVA: 0x00D0F460 File Offset: 0x00D0D660
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

		// Token: 0x06037196 RID: 225686 RVA: 0x00D0F4E6 File Offset: 0x00D0D6E6
		protected override void OnStart()
		{
			base.GetSlider(1).OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChange));
		}

		// Token: 0x06037197 RID: 225687 RVA: 0x00D0F508 File Offset: 0x00D0D708
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

		// Token: 0x06037198 RID: 225688 RVA: 0x00D0F5B0 File Offset: 0x00D0D7B0
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

		// Token: 0x06037199 RID: 225689 RVA: 0x00D0F604 File Offset: 0x00D0D804
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

		// Token: 0x0401D11C RID: 119068
		[Nullable(2)]
		protected EyeProtectSliderData Data;

		// Token: 0x0401D11D RID: 119069
		protected bool IsTemp;

		// Token: 0x0200B6C7 RID: 46791
		[NullableContext(0)]
		public class ESliderComponent
		{
			// Token: 0x040375FB RID: 226811
			public const int NumText = 0;

			// Token: 0x040375FC RID: 226812
			public const int Slider = 1;

			// Token: 0x040375FD RID: 226813
			public const int TitleText = 2;

			// Token: 0x040375FE RID: 226814
			public const int TemperatureBg = 3;

			// Token: 0x040375FF RID: 226815
			public const int FillArea = 4;
		}
	}
}
