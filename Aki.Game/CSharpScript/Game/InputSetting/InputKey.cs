using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006183 RID: 24963
	[NullableContext(1)]
	[Nullable(0)]
	public class InputKey
	{
		// Token: 0x0603BE22 RID: 245282 RVA: 0x01104790 File Offset: 0x01102990
		public InputKey(string keyName)
		{
			this.KeyName = keyName;
			this.Key = new FKey
			{
				KeyName = new FName(keyName)
			};
			this.IsKeyboardKey = (UKismetInputLibrary.Key_IsKeyboardKey(this.Key) || keyName == EKey.Keyboard_Invalid);
			this.IsModifierKey = UKismetInputLibrary.Key_IsModifierKey(this.Key);
			this.IsGamepadKey = (UKismetInputLibrary.Key_IsGamepadKey(this.Key) || keyName == EKey.Gamepad_Invalid);
			this.IsMouseButton = UKismetInputLibrary.Key_IsMouseButton(this.Key);
			this.IsDigital = UKismetInputLibrary.Key_IsDigital(this.Key);
			this.IsAnalog = UKismetInputLibrary.Key_IsAnalog(this.Key);
			this.IsButtonAxis = UKismetInputLibrary.Key_IsButtonAxis(this.Key);
			this.IsAxis1D = UKismetInputLibrary.Key_IsAxis1D(this.Key);
			this.IsAxis2D = UKismetInputLibrary.Key_IsAxis2D(this.Key);
			this.IsAxis3D = UKismetInputLibrary.Key_IsAxis3D(this.Key);
			this.IsPcPsTouchPadKey = (keyName == EKey.GenericUSBController_Button14);
		}

		// Token: 0x0603BE23 RID: 245283 RVA: 0x011048B6 File Offset: 0x01102AB6
		public string GetKeyName()
		{
			return this.KeyName;
		}

		// Token: 0x0603BE24 RID: 245284 RVA: 0x011048BE File Offset: 0x01102ABE
		public FKey ToUeKey()
		{
			return this.Key;
		}

		// Token: 0x0603BE25 RID: 245285 RVA: 0x011048C8 File Offset: 0x01102AC8
		[NullableContext(0)]
		public OneOf<GamepadKey, PcKey>? GetConfig()
		{
			if (this.IsKeyboardKey || this.IsMouseButton)
			{
				PcKey? pcKeyConfig = InputSettingsConfig.Instance.GetPcKeyConfig(this.KeyName);
				if (pcKeyConfig == null)
				{
					return null;
				}
				return new OneOf<GamepadKey, PcKey>?(pcKeyConfig.GetValueOrDefault());
			}
			else
			{
				if (!this.IsGamepadKey)
				{
					return null;
				}
				GamepadKey? gamepadKeyConfig = InputSettingsConfig.Instance.GetGamepadKeyConfig(this.KeyName);
				if (gamepadKeyConfig == null)
				{
					return null;
				}
				return new OneOf<GamepadKey, PcKey>?(gamepadKeyConfig.GetValueOrDefault());
			}
		}

		// Token: 0x0603BE26 RID: 245286 RVA: 0x01104962 File Offset: 0x01102B62
		public string GetKeyIconPath()
		{
			if (this.IsKeyboardKey || this.IsMouseButton)
			{
				return InputKeyUtils.GetPcKeyIconPathByCurrentPlatform(this.KeyName) ?? "";
			}
			if (this.IsGamepadKey)
			{
				return InputKeyUtils.GetGamepadKeyIconPath(this.KeyName);
			}
			return "";
		}

		// Token: 0x0603BE27 RID: 245287 RVA: 0x011049A2 File Offset: 0x01102BA2
		public bool IsInputKeyDown()
		{
			return Global.PlayerController.IsInputKeyDown(this.ToUeKey());
		}

		// Token: 0x0603BE28 RID: 245288 RVA: 0x011049B4 File Offset: 0x01102BB4
		public float GetInputAnalogKeyState()
		{
			return Global.PlayerController.GetInputAnalogKeyState(this.ToUeKey());
		}

		// Token: 0x0401FA9E RID: 129694
		private readonly string KeyName = "";

		// Token: 0x0401FA9F RID: 129695
		public readonly bool IsKeyboardKey;

		// Token: 0x0401FAA0 RID: 129696
		public readonly bool IsModifierKey;

		// Token: 0x0401FAA1 RID: 129697
		public readonly bool IsGamepadKey;

		// Token: 0x0401FAA2 RID: 129698
		public readonly bool IsPcPsTouchPadKey;

		// Token: 0x0401FAA3 RID: 129699
		public readonly bool IsMouseButton;

		// Token: 0x0401FAA4 RID: 129700
		public readonly bool IsDigital;

		// Token: 0x0401FAA5 RID: 129701
		public readonly bool IsAnalog;

		// Token: 0x0401FAA6 RID: 129702
		public readonly bool IsButtonAxis;

		// Token: 0x0401FAA7 RID: 129703
		public readonly bool IsAxis1D;

		// Token: 0x0401FAA8 RID: 129704
		public readonly bool IsAxis2D;

		// Token: 0x0401FAA9 RID: 129705
		public readonly bool IsAxis3D;

		// Token: 0x0401FAAA RID: 129706
		[Nullable(2)]
		private readonly FKey Key;
	}
}
