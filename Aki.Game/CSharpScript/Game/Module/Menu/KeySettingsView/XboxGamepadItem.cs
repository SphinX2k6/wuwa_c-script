using System;
using System.Collections.Generic;
using CSharpScript.Game.InputSetting;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02004450 RID: 17488
	public class XboxGamepadItem : GamepadItemBase
	{
		// Token: 0x0602C1FD RID: 180733 RVA: 0x00C64AB8 File Offset: 0x00C62CB8
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
				new ValueTuple<int, Type>(15, typeof(UUISprite)),
				new ValueTuple<int, Type>(14, typeof(UUISprite))
			};
		}

		// Token: 0x0602C1FE RID: 180734 RVA: 0x00C64C38 File Offset: 0x00C62E38
		protected override void OnStart()
		{
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
			base.AddKeySprite(EKey.Gamepad_Special_Left, base.GetSprite(15));
			base.AddKeySprite(EKey.Gamepad_Special_Right, base.GetSprite(14));
		}

		// Token: 0x0200A122 RID: 41250
		public class EChildType
		{
			// Token: 0x04032102 RID: 205058
			public const int LeftStickSprite = 0;

			// Token: 0x04032103 RID: 205059
			public const int RightStickSprite = 1;

			// Token: 0x04032104 RID: 205060
			public const int UpSprite = 2;

			// Token: 0x04032105 RID: 205061
			public const int DownSprite = 3;

			// Token: 0x04032106 RID: 205062
			public const int LeftSprite = 4;

			// Token: 0x04032107 RID: 205063
			public const int RightSprite = 5;

			// Token: 0x04032108 RID: 205064
			public const int TopButtonSprite = 6;

			// Token: 0x04032109 RID: 205065
			public const int BottomButtonSprite = 7;

			// Token: 0x0403210A RID: 205066
			public const int LeftButtonSprite = 8;

			// Token: 0x0403210B RID: 205067
			public const int RightButtonSprite = 9;

			// Token: 0x0403210C RID: 205068
			public const int LaSprite = 10;

			// Token: 0x0403210D RID: 205069
			public const int LbSprite = 11;

			// Token: 0x0403210E RID: 205070
			public const int RaSprite = 12;

			// Token: 0x0403210F RID: 205071
			public const int RbSprite = 13;

			// Token: 0x04032110 RID: 205072
			public const int SpecialRightSprite = 14;

			// Token: 0x04032111 RID: 205073
			public const int SpecialLeftSprite = 15;
		}
	}
}
