using System;
using System.Collections.Generic;
using CSharpScript.Game.InputSetting;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200546D RID: 21613
	public class XboxGamepadItem : GamepadItemBase
	{
		// Token: 0x060372B4 RID: 225972 RVA: 0x00D156A0 File Offset: 0x00D138A0
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

		// Token: 0x060372B5 RID: 225973 RVA: 0x00D15820 File Offset: 0x00D13A20
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

		// Token: 0x0200B6EA RID: 46826
		public class EChildType
		{
			// Token: 0x040376AD RID: 226989
			public const int LeftStickSprite = 0;

			// Token: 0x040376AE RID: 226990
			public const int RightStickSprite = 1;

			// Token: 0x040376AF RID: 226991
			public const int UpSprite = 2;

			// Token: 0x040376B0 RID: 226992
			public const int DownSprite = 3;

			// Token: 0x040376B1 RID: 226993
			public const int LeftSprite = 4;

			// Token: 0x040376B2 RID: 226994
			public const int RightSprite = 5;

			// Token: 0x040376B3 RID: 226995
			public const int TopButtonSprite = 6;

			// Token: 0x040376B4 RID: 226996
			public const int BottomButtonSprite = 7;

			// Token: 0x040376B5 RID: 226997
			public const int LeftButtonSprite = 8;

			// Token: 0x040376B6 RID: 226998
			public const int RightButtonSprite = 9;

			// Token: 0x040376B7 RID: 226999
			public const int LaSprite = 10;

			// Token: 0x040376B8 RID: 227000
			public const int LbSprite = 11;

			// Token: 0x040376B9 RID: 227001
			public const int RaSprite = 12;

			// Token: 0x040376BA RID: 227002
			public const int RbSprite = 13;

			// Token: 0x040376BB RID: 227003
			public const int SpecialRightSprite = 14;

			// Token: 0x040376BC RID: 227004
			public const int SpecialLeftSprite = 15;
		}
	}
}
