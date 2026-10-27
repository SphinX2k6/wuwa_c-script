using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007002 RID: 28674
	[NullableContext(1)]
	[Nullable(0)]
	public class InputKey
	{
		// Token: 0x06045C6C RID: 285804 RVA: 0x0115A38C File Offset: 0x0115858C
		public InputKey(string keyName)
		{
			this.KeyName = keyName;
			this.Key = new FKey(new FName(keyName));
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

		// Token: 0x06045C6D RID: 285805 RVA: 0x0115A4AC File Offset: 0x011586AC
		public string GetKeyName()
		{
			return this.KeyName;
		}

		// Token: 0x06045C6E RID: 285806 RVA: 0x0115A4B4 File Offset: 0x011586B4
		public FKey ToUeKey()
		{
			return this.Key;
		}

		// Token: 0x06045C6F RID: 285807 RVA: 0x0115A4BC File Offset: 0x011586BC
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

		// Token: 0x06045C70 RID: 285808 RVA: 0x0115A556 File Offset: 0x01158756
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

		// Token: 0x06045C71 RID: 285809 RVA: 0x0115A596 File Offset: 0x01158796
		public bool IsInputKeyDown()
		{
			return Global.PlayerController.IsInputKeyDown(this.ToUeKey());
		}

		// Token: 0x06045C72 RID: 285810 RVA: 0x0115A5A8 File Offset: 0x011587A8
		public float GetInputAnalogKeyState()
		{
			return Global.PlayerController.GetInputAnalogKeyState(this.ToUeKey());
		}

		// Token: 0x040247E8 RID: 149480
		private readonly string KeyName = "";

		// Token: 0x040247E9 RID: 149481
		public readonly bool IsKeyboardKey;

		// Token: 0x040247EA RID: 149482
		public readonly bool IsModifierKey;

		// Token: 0x040247EB RID: 149483
		public readonly bool IsGamepadKey;

		// Token: 0x040247EC RID: 149484
		public readonly bool IsPcPsTouchPadKey;

		// Token: 0x040247ED RID: 149485
		public readonly bool IsMouseButton;

		// Token: 0x040247EE RID: 149486
		public readonly bool IsDigital;

		// Token: 0x040247EF RID: 149487
		public readonly bool IsAnalog;

		// Token: 0x040247F0 RID: 149488
		public readonly bool IsButtonAxis;

		// Token: 0x040247F1 RID: 149489
		public readonly bool IsAxis1D;

		// Token: 0x040247F2 RID: 149490
		public readonly bool IsAxis2D;

		// Token: 0x040247F3 RID: 149491
		public readonly bool IsAxis3D;

		// Token: 0x040247F4 RID: 149492
		[Nullable(2)]
		private readonly FKey Key;
	}
}
