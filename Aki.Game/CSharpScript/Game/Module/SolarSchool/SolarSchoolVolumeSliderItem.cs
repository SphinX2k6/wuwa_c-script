using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Menu;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A5D RID: 23133
	public class SolarSchoolVolumeSliderItem : SyncGridProxyAbstract<EFunction>
	{
		// Token: 0x06038FE2 RID: 233442 RVA: 0x00FF6744 File Offset: 0x00FF4944
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038FE3 RID: 233443 RVA: 0x00FF67D0 File Offset: 0x00FF49D0
		protected override void OnStart()
		{
			this.RootToggle = (this.RootActor.GetComponentByClass(UUIExtendToggle.StaticClass()) as UUIExtendToggle);
			UUIExtendToggle rootToggle = this.RootToggle;
			if (rootToggle != null)
			{
				rootToggle.SetToggleGroup(null);
			}
			UUIExtendToggle rootToggle2 = this.RootToggle;
			if (rootToggle2 != null)
			{
				rootToggle2.SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
			}
			UUIExtendToggle rootToggle3 = this.RootToggle;
			if (rootToggle3 != null)
			{
				rootToggle3.CanExecuteChange.Bind(() => false);
			}
			base.GetSlider(1).OnValueChangeCb.Bind(new Action<float>(this.OnValueChange));
		}

		// Token: 0x06038FE4 RID: 233444 RVA: 0x00FF6878 File Offset: 0x00FF4A78
		public override void Refresh(EFunction functionId)
		{
			this.FunctionId = functionId;
			MenuConfig? menuConfigByFunctionId = MenuBaseConfig.Instance.GetMenuConfigByFunctionId((int)functionId);
			if (menuConfigByFunctionId == null)
			{
				return;
			}
			MenuData menuData = new MenuData(menuConfigByFunctionId.Value);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), menuData.FunctionName, Array.Empty<object>());
			float[] sliderRange = menuData.SliderRange;
			float currentValueSafelyFloat = GameSettingsManager.Instance.GetCurrentValueSafelyFloat(functionId, menuData.SliderDefault, true);
			UUISliderComponent slider = base.GetSlider(1);
			slider.SetMaxValue(sliderRange[1], true, false);
			slider.SetMinValue(sliderRange[0], true, false);
			slider.SetValue(MathUtils.Instance.Clamp(currentValueSafelyFloat, sliderRange[0], sliderRange[1]), false);
			this.RefreshValueText(currentValueSafelyFloat, menuData);
		}

		// Token: 0x06038FE5 RID: 233445 RVA: 0x00FF6922 File Offset: 0x00FF4B22
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle rootToggle = this.RootToggle;
			if (rootToggle != null)
			{
				rootToggle.CanExecuteChange.Unbind();
			}
			this.RootToggle = null;
			base.GetSlider(1).OnValueChangeCb.Unbind();
		}

		// Token: 0x06038FE6 RID: 233446 RVA: 0x00FF6954 File Offset: 0x00FF4B54
		private void OnValueChange(float value)
		{
			MenuConfig? menuConfigByFunctionId = MenuBaseConfig.Instance.GetMenuConfigByFunctionId((int)this.FunctionId);
			if (menuConfigByFunctionId == null)
			{
				return;
			}
			MenuData menuData = new MenuData(menuConfigByFunctionId.Value);
			float value2 = this.RefreshValueText(value, menuData);
			MenuController.Instance.HandleFireSaveMenuChange(menuData, value2);
		}

		// Token: 0x06038FE7 RID: 233447 RVA: 0x00FF69A0 File Offset: 0x00FF4BA0
		[NullableContext(1)]
		private float RefreshValueText(float value, MenuData menuData)
		{
			float sliderDisplayValue = FunctionItemViewTool.GetSliderDisplayValue(menuData, value);
			base.GetText(2).SetText(sliderDisplayValue.ToString(), true);
			return sliderDisplayValue;
		}

		// Token: 0x0401DFF7 RID: 122871
		private EFunction FunctionId;

		// Token: 0x0401DFF8 RID: 122872
		[Nullable(2)]
		private UUIExtendToggle RootToggle;

		// Token: 0x0200B649 RID: 46665
		private class EComponents
		{
			// Token: 0x0403863C RID: 230972
			public const int Title = 0;

			// Token: 0x0403863D RID: 230973
			public const int Slider = 1;

			// Token: 0x0403863E RID: 230974
			public const int Value = 2;
		}
	}
}
