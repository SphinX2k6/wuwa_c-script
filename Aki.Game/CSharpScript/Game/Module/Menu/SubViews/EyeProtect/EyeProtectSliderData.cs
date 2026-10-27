using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.GameSettings;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.EyeProtect
{
	// Token: 0x0200544B RID: 21579
	[NullableContext(1)]
	[Nullable(0)]
	public class EyeProtectSliderData
	{
		// Token: 0x0603717F RID: 225663 RVA: 0x00D0EE2C File Offset: 0x00D0D02C
		public EyeProtectSliderData(MenuData metaData, EyeProtectViewModel viewModel, EModeValue modeValue)
		{
			this.FunctionIdInternal = new EFunction?(metaData.FunctionId);
			this.MinValueInternal = metaData.SliderRange[0];
			this.MaxValueInternal = metaData.SliderRange[1];
			this.ViewModel = viewModel;
			if (modeValue == EModeValue.Custom)
			{
				this.CurValueInternal = (GameSettingsManager.Instance.GetCurrentValueFloat(metaData.FunctionId, true, true) ?? metaData.SliderDefault);
			}
			else
			{
				this.CurValueInternal = metaData.SliderDefault;
				UKuroScreenBlueLightFilterParameter ukuroScreenBlueLightFilterParameter = null;
				if (modeValue == EModeValue.Strong)
				{
					EyeProtectViewModel viewModel2 = this.ViewModel;
					ukuroScreenBlueLightFilterParameter = ((viewModel2 != null) ? viewModel2.ParamStrong : null);
				}
				else if (modeValue == EModeValue.Weak)
				{
					EyeProtectViewModel viewModel3 = this.ViewModel;
					ukuroScreenBlueLightFilterParameter = ((viewModel3 != null) ? viewModel3.ParamWeak : null);
				}
				if (ukuroScreenBlueLightFilterParameter != null)
				{
					EFunction? functionIdInternal = this.FunctionIdInternal;
					if (functionIdInternal != null)
					{
						switch (functionIdInternal.GetValueOrDefault())
						{
						case EFunction.EyeProtectionTemp:
							this.CurValueInternal = ukuroScreenBlueLightFilterParameter.ScreenBlueLightFilterTemperature;
							break;
						case EFunction.EyeProtectionStrength:
							this.CurValueInternal = ukuroScreenBlueLightFilterParameter.ScreenBlueLightFilterStrength;
							break;
						case EFunction.EyeProtectionBrightness:
							this.CurValueInternal = ukuroScreenBlueLightFilterParameter.ScreenBrightnessClampMax;
							break;
						case EFunction.EyeProtectionTexture:
							this.CurValueInternal = ukuroScreenBlueLightFilterParameter.ScreenBlueLightFilterTextureIntensity;
							break;
						}
					}
				}
			}
			this.DefaultValueInternal = metaData.SliderDefault;
			this.TitleInternal = metaData.FunctionName;
			this.MetaData = metaData;
			this.ViewModel = viewModel;
			this.ModeValue = new EModeValue?(modeValue);
			this.OnChangeValue = new Action<float>(this.OnChangeValueImpl);
			this.OnApplyValue = new Action(this.OnApplyValueImpl);
		}

		// Token: 0x17008445 RID: 33861
		// (get) Token: 0x06037180 RID: 225664 RVA: 0x00D0EFBA File Offset: 0x00D0D1BA
		public MenuData MenuData
		{
			get
			{
				return this.MetaData;
			}
		}

		// Token: 0x17008446 RID: 33862
		// (get) Token: 0x06037181 RID: 225665 RVA: 0x00D0EFC2 File Offset: 0x00D0D1C2
		public float MinValue
		{
			get
			{
				return this.MinValueInternal;
			}
		}

		// Token: 0x17008447 RID: 33863
		// (get) Token: 0x06037182 RID: 225666 RVA: 0x00D0EFCA File Offset: 0x00D0D1CA
		public float MaxValue
		{
			get
			{
				return this.MaxValueInternal;
			}
		}

		// Token: 0x17008448 RID: 33864
		// (get) Token: 0x06037183 RID: 225667 RVA: 0x00D0EFD2 File Offset: 0x00D0D1D2
		public float CurValue
		{
			get
			{
				return this.CurValueInternal;
			}
		}

		// Token: 0x17008449 RID: 33865
		// (get) Token: 0x06037184 RID: 225668 RVA: 0x00D0EFDA File Offset: 0x00D0D1DA
		public float DefaultCurValue
		{
			get
			{
				return this.DefaultValueInternal;
			}
		}

		// Token: 0x1700844A RID: 33866
		// (get) Token: 0x06037185 RID: 225669 RVA: 0x00D0EFE2 File Offset: 0x00D0D1E2
		public string Title
		{
			get
			{
				return this.TitleInternal;
			}
		}

		// Token: 0x1700844B RID: 33867
		// (get) Token: 0x06037186 RID: 225670 RVA: 0x00D0EFEA File Offset: 0x00D0D1EA
		public EFunction? FunctionId
		{
			get
			{
				return this.FunctionIdInternal;
			}
		}

		// Token: 0x06037187 RID: 225671 RVA: 0x00D0EFF2 File Offset: 0x00D0D1F2
		public EModeValue? GetModeValue()
		{
			return this.ModeValue;
		}

		// Token: 0x06037188 RID: 225672 RVA: 0x00D0EFFC File Offset: 0x00D0D1FC
		private void OnChangeValueImpl(float value)
		{
			if (this.GetModeValue().GetValueOrDefault() != EModeValue.Custom)
			{
				return;
			}
			if (this.ViewModel != null)
			{
				this.ViewModel.IsSliderDirty = true;
				Action onSliderValueChange = this.ViewModel.OnSliderValueChange;
				if (onSliderValueChange != null)
				{
					onSliderValueChange();
				}
				this.CurValueInternal = value;
				EFunction? functionId = this.FunctionId;
				if (functionId != null)
				{
					switch (functionId.GetValueOrDefault())
					{
					case EFunction.EyeProtectionTemp:
						GameSettingsUtils.ApplyEyeProtectionTemp(value, (int)this.ModeValue.Value);
						return;
					case EFunction.EyeProtectionStrength:
						GameSettingsUtils.ApplyEyeProtectionStrength(value, (int)this.ModeValue.Value);
						return;
					case EFunction.EyeProtectionBrightness:
						GameSettingsUtils.ApplyEyeProtectionBrightness(value, (int)this.ModeValue.Value);
						return;
					case EFunction.EyeProtectionTexture:
						GameSettingsUtils.ApplyEyeProtectionTexture(value, (int)this.ModeValue.Value);
						break;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x06037189 RID: 225673 RVA: 0x00D0F0D0 File Offset: 0x00D0D2D0
		public void OnSetValue()
		{
			EFunction? functionId = this.FunctionId;
			if (functionId != null)
			{
				switch (functionId.GetValueOrDefault())
				{
				case EFunction.EyeProtectionTemp:
					GameSettingsUtils.ApplyEyeProtectionTemp(this.CurValueInternal, (int)this.ModeValue.Value);
					return;
				case EFunction.EyeProtectionStrength:
					GameSettingsUtils.ApplyEyeProtectionStrength(this.CurValueInternal, (int)this.ModeValue.Value);
					return;
				case EFunction.EyeProtectionBrightness:
					GameSettingsUtils.ApplyEyeProtectionBrightness(this.CurValueInternal, (int)this.ModeValue.Value);
					return;
				case EFunction.EyeProtectionTexture:
					GameSettingsUtils.ApplyEyeProtectionTexture(this.CurValueInternal, (int)this.ModeValue.Value);
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0603718A RID: 225674 RVA: 0x00D0F174 File Offset: 0x00D0D374
		private void OnApplyValueImpl()
		{
			if (this.GetModeValue().GetValueOrDefault() != EModeValue.Custom)
			{
				return;
			}
			GameSettingsManager.Instance.HandleValueChangeFloat(this.FunctionId.Value, this.CurValueInternal, EGameSettingsApplyReason.WhenUi);
		}

		// Token: 0x0401D10D RID: 119053
		protected float MinValueInternal;

		// Token: 0x0401D10E RID: 119054
		protected float MaxValueInternal;

		// Token: 0x0401D10F RID: 119055
		protected float CurValueInternal;

		// Token: 0x0401D110 RID: 119056
		protected float DefaultValueInternal;

		// Token: 0x0401D111 RID: 119057
		protected string TitleInternal = "";

		// Token: 0x0401D112 RID: 119058
		[Nullable(2)]
		protected EyeProtectViewModel ViewModel;

		// Token: 0x0401D113 RID: 119059
		protected EFunction? FunctionIdInternal;

		// Token: 0x0401D114 RID: 119060
		[Nullable(2)]
		protected MenuData MetaData;

		// Token: 0x0401D115 RID: 119061
		protected EModeValue? ModeValue;

		// Token: 0x0401D116 RID: 119062
		public Action<float> OnChangeValue;

		// Token: 0x0401D117 RID: 119063
		public Action OnApplyValue;
	}
}
