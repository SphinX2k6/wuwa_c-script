using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.GameSettings;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.EyeProtect
{
	// Token: 0x0200442E RID: 17454
	[NullableContext(1)]
	[Nullable(0)]
	public class EyeProtectSliderData
	{
		// Token: 0x0602C0C8 RID: 180424 RVA: 0x00C5E244 File Offset: 0x00C5C444
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

		// Token: 0x17005811 RID: 22545
		// (get) Token: 0x0602C0C9 RID: 180425 RVA: 0x00C5E3D2 File Offset: 0x00C5C5D2
		public MenuData MenuData
		{
			get
			{
				return this.MetaData;
			}
		}

		// Token: 0x17005812 RID: 22546
		// (get) Token: 0x0602C0CA RID: 180426 RVA: 0x00C5E3DA File Offset: 0x00C5C5DA
		public float MinValue
		{
			get
			{
				return this.MinValueInternal;
			}
		}

		// Token: 0x17005813 RID: 22547
		// (get) Token: 0x0602C0CB RID: 180427 RVA: 0x00C5E3E2 File Offset: 0x00C5C5E2
		public float MaxValue
		{
			get
			{
				return this.MaxValueInternal;
			}
		}

		// Token: 0x17005814 RID: 22548
		// (get) Token: 0x0602C0CC RID: 180428 RVA: 0x00C5E3EA File Offset: 0x00C5C5EA
		public float CurValue
		{
			get
			{
				return this.CurValueInternal;
			}
		}

		// Token: 0x17005815 RID: 22549
		// (get) Token: 0x0602C0CD RID: 180429 RVA: 0x00C5E3F2 File Offset: 0x00C5C5F2
		public float DefaultCurValue
		{
			get
			{
				return this.DefaultValueInternal;
			}
		}

		// Token: 0x17005816 RID: 22550
		// (get) Token: 0x0602C0CE RID: 180430 RVA: 0x00C5E3FA File Offset: 0x00C5C5FA
		public string Title
		{
			get
			{
				return this.TitleInternal;
			}
		}

		// Token: 0x17005817 RID: 22551
		// (get) Token: 0x0602C0CF RID: 180431 RVA: 0x00C5E402 File Offset: 0x00C5C602
		public EFunction? FunctionId
		{
			get
			{
				return this.FunctionIdInternal;
			}
		}

		// Token: 0x0602C0D0 RID: 180432 RVA: 0x00C5E40A File Offset: 0x00C5C60A
		public EModeValue? GetModeValue()
		{
			return this.ModeValue;
		}

		// Token: 0x0602C0D1 RID: 180433 RVA: 0x00C5E414 File Offset: 0x00C5C614
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

		// Token: 0x0602C0D2 RID: 180434 RVA: 0x00C5E4E8 File Offset: 0x00C5C6E8
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

		// Token: 0x0602C0D3 RID: 180435 RVA: 0x00C5E58C File Offset: 0x00C5C78C
		private void OnApplyValueImpl()
		{
			if (this.GetModeValue().GetValueOrDefault() != EModeValue.Custom)
			{
				return;
			}
			GameSettingsManager.Instance.HandleValueChangeFloat(this.FunctionId.Value, this.CurValueInternal, EGameSettingsApplyReason.WhenUi);
		}

		// Token: 0x04017BA6 RID: 97190
		protected float MinValueInternal;

		// Token: 0x04017BA7 RID: 97191
		protected float MaxValueInternal;

		// Token: 0x04017BA8 RID: 97192
		protected float CurValueInternal;

		// Token: 0x04017BA9 RID: 97193
		protected float DefaultValueInternal;

		// Token: 0x04017BAA RID: 97194
		protected string TitleInternal = "";

		// Token: 0x04017BAB RID: 97195
		[Nullable(2)]
		protected EyeProtectViewModel ViewModel;

		// Token: 0x04017BAC RID: 97196
		protected EFunction? FunctionIdInternal;

		// Token: 0x04017BAD RID: 97197
		[Nullable(2)]
		protected MenuData MetaData;

		// Token: 0x04017BAE RID: 97198
		protected EModeValue? ModeValue;

		// Token: 0x04017BAF RID: 97199
		public Action<float> OnChangeValue;

		// Token: 0x04017BB0 RID: 97200
		public Action OnApplyValue;
	}
}
