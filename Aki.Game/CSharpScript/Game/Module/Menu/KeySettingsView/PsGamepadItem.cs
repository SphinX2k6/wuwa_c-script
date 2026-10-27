using System;
using System.Collections.Generic;
using CSharpScript.Game.InputSetting;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200546B RID: 21611
	public class PsGamepadItem : GamepadItemBase
	{
		// Token: 0x060372AB RID: 225963 RVA: 0x00D14DFC File Offset: 0x00D12FFC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUISprite)),
				new ValueTuple<int, Type>(9, typeof(UUISprite)),
				new ValueTuple<int, Type>(10, typeof(UUISprite)),
				new ValueTuple<int, Type>(11, typeof(UUISprite)),
				new ValueTuple<int, Type>(12, typeof(UUISprite)),
				new ValueTuple<int, Type>(13, typeof(UUISprite)),
				new ValueTuple<int, Type>(14, typeof(UUISprite)),
				new ValueTuple<int, Type>(15, typeof(UUISprite)),
				new ValueTuple<int, Type>(16, typeof(UUISprite))
			};
		}

		// Token: 0x060372AC RID: 225964 RVA: 0x00D14F94 File Offset: 0x00D13194
		protected override void OnStart()
		{
			base.AddKeySprite(EKey.GenericUSBController_Axis1, base.GetSprite(0));
			base.AddKeySprite(EKey.GenericUSBController_Axis2, base.GetSprite(0));
			base.AddKeySprite(EKey.GenericUSBController_Axis3, base.GetSprite(1));
			base.AddKeySprite(EKey.GenericUSBController_Axis4, base.GetSprite(1));
			base.AddKeySprite(EKey.GenericUSBController_Axis5, base.GetSprite(0));
			base.AddKeySprite(EKey.GenericUSBController_Axis6, base.GetSprite(1));
			base.AddKeySprite(EKey.GenericUSBController_Button11, base.GetSprite(0));
			base.AddKeySprite(EKey.GenericUSBController_Button12, base.GetSprite(1));
			base.AddKeySprite(EKey.GenericUSBController_Button4, base.GetSprite(6));
			base.AddKeySprite(EKey.GenericUSBController_Button2, base.GetSprite(7));
			base.AddKeySprite(EKey.GenericUSBController_Button1, base.GetSprite(8));
			base.AddKeySprite(EKey.GenericUSBController_Button3, base.GetSprite(9));
			base.AddKeySprite(EKey.GenericUSBController_Button5, base.GetSprite(10));
			base.AddKeySprite(EKey.GenericUSBController_Button7, base.GetSprite(11));
			base.AddKeySprite(EKey.GenericUSBController_Button6, base.GetSprite(12));
			base.AddKeySprite(EKey.GenericUSBController_Button8, base.GetSprite(13));
			base.AddKeySprite(EKey.GenericUSBController_Button14, base.GetSprite(14));
			base.AddKeySprite(EKey.GenericUSBController_Button10, base.GetSprite(15));
			base.AddKeySprite(EKey.GenericUSBController_Button9, base.GetSprite(16));
			base.AddKeySprite(EKey.GenericUSBController_Button16, base.GetSprite(2));
			base.AddKeySprite(EKey.GenericUSBController_Button17, base.GetSprite(5));
			base.AddKeySprite(EKey.GenericUSBController_Button18, base.GetSprite(3));
			base.AddKeySprite(EKey.GenericUSBController_Button19, base.GetSprite(4));
			base.AddKeySprite(EKey.Gamepad_Left2D, base.GetSprite(0));
			base.AddKeySprite(EKey.Gamepad_LeftY, base.GetSprite(0));
			base.AddKeySprite(EKey.Gamepad_LeftX, base.GetSprite(0));
			base.AddKeySprite(EKey.Gamepad_LeftThumbstick, base.GetSprite(0));
			base.AddKeySprite(EKey.Gamepad_Right2D, base.GetSprite(1));
			base.AddKeySprite(EKey.Gamepad_RightY, base.GetSprite(1));
			base.AddKeySprite(EKey.Gamepad_RightX, base.GetSprite(1));
			base.AddKeySprite(EKey.Gamepad_RightThumbstick, base.GetSprite(1));
			base.AddKeySprite(EKey.Gamepad_DPad_Up, base.GetSprite(2));
			base.AddKeySprite(EKey.Gamepad_DPad_Down, base.GetSprite(3));
			base.AddKeySprite(EKey.Gamepad_DPad_Left, base.GetSprite(4));
			base.AddKeySprite(EKey.Gamepad_DPad_Right, base.GetSprite(5));
			base.AddKeySprite(EKey.Gamepad_FaceButton_Top, base.GetSprite(6));
			base.AddKeySprite(EKey.Gamepad_FaceButton_Bottom, base.GetSprite(7));
			base.AddKeySprite(EKey.Gamepad_FaceButton_Left, base.GetSprite(8));
			base.AddKeySprite(EKey.Gamepad_FaceButton_Right, base.GetSprite(9));
			base.AddKeySprite(EKey.Gamepad_LeftShoulder, base.GetSprite(10));
			base.AddKeySprite(EKey.Gamepad_LeftTriggerAxis, base.GetSprite(11));
			base.AddKeySprite(EKey.Gamepad_LeftTrigger, base.GetSprite(11));
			base.AddKeySprite(EKey.Gamepad_RightShoulder, base.GetSprite(12));
			base.AddKeySprite(EKey.Gamepad_RightTriggerAxis, base.GetSprite(13));
			base.AddKeySprite(EKey.Gamepad_RightTrigger, base.GetSprite(13));
			base.AddKeySprite(EKey.Gamepad_Special_Left, base.GetSprite(14));
			base.AddKeySprite(EKey.Gamepad_Special_Right, base.GetSprite(15));
		}

		// Token: 0x0200B6E8 RID: 46824
		public class EChildType
		{
			// Token: 0x04037694 RID: 226964
			public const int LeftStickSprite = 0;

			// Token: 0x04037695 RID: 226965
			public const int RightStickSprite = 1;

			// Token: 0x04037696 RID: 226966
			public const int UpSprite = 2;

			// Token: 0x04037697 RID: 226967
			public const int DownSprite = 3;

			// Token: 0x04037698 RID: 226968
			public const int LeftSprite = 4;

			// Token: 0x04037699 RID: 226969
			public const int RightSprite = 5;

			// Token: 0x0403769A RID: 226970
			public const int TopButtonSprite = 6;

			// Token: 0x0403769B RID: 226971
			public const int BottomButtonSprite = 7;

			// Token: 0x0403769C RID: 226972
			public const int LeftButtonSprite = 8;

			// Token: 0x0403769D RID: 226973
			public const int RightButtonSprite = 9;

			// Token: 0x0403769E RID: 226974
			public const int LaSprite = 10;

			// Token: 0x0403769F RID: 226975
			public const int LbSprite = 11;

			// Token: 0x040376A0 RID: 226976
			public const int RaSprite = 12;

			// Token: 0x040376A1 RID: 226977
			public const int RbSprite = 13;

			// Token: 0x040376A2 RID: 226978
			public const int HomeButtonSprite = 14;

			// Token: 0x040376A3 RID: 226979
			public const int MiniRightButtonSprite = 15;

			// Token: 0x040376A4 RID: 226980
			public const int MiniLeftButtonSprite = 16;
		}
	}
}
