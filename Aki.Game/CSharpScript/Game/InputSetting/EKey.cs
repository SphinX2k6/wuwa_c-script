using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FFB RID: 28667
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EKey : IEquatable<EKey>
	{
		// Token: 0x06045BC1 RID: 285633 RVA: 0x011549F9 File Offset: 0x01152BF9
		private EKey(string value)
		{
			this._value = value;
		}

		// Token: 0x06045BC2 RID: 285634 RVA: 0x01154A02 File Offset: 0x01152C02
		public bool Equals(EKey other)
		{
			return this._value == other._value;
		}

		// Token: 0x06045BC3 RID: 285635 RVA: 0x01154A18 File Offset: 0x01152C18
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is EKey)
			{
				EKey other = (EKey)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06045BC4 RID: 285636 RVA: 0x01154A3D File Offset: 0x01152C3D
		public override int GetHashCode()
		{
			if (this._value == null)
			{
				return 0;
			}
			return this._value.GetHashCode();
		}

		// Token: 0x06045BC5 RID: 285637 RVA: 0x01154A54 File Offset: 0x01152C54
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x06045BC6 RID: 285638 RVA: 0x01154A5C File Offset: 0x01152C5C
		public static implicit operator string(EKey key)
		{
			return key.ToString();
		}

		// Token: 0x06045BC7 RID: 285639 RVA: 0x01154A6B File Offset: 0x01152C6B
		public static explicit operator EKey(string value)
		{
			return new EKey(value);
		}

		// Token: 0x06045BC8 RID: 285640 RVA: 0x01154A73 File Offset: 0x01152C73
		public static bool operator ==(EKey left, EKey right)
		{
			return left.Equals(right);
		}

		// Token: 0x06045BC9 RID: 285641 RVA: 0x01154A7D File Offset: 0x01152C7D
		public static bool operator !=(EKey left, EKey right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04024621 RID: 149025
		private readonly string _value;

		// Token: 0x04024622 RID: 149026
		public static readonly EKey AnyKey = new EKey("AnyKey");

		// Token: 0x04024623 RID: 149027
		public static readonly EKey MouseX = new EKey("MouseX");

		// Token: 0x04024624 RID: 149028
		public static readonly EKey MouseY = new EKey("MouseY");

		// Token: 0x04024625 RID: 149029
		public static readonly EKey Mouse2D = new EKey("Mouse2D");

		// Token: 0x04024626 RID: 149030
		public static readonly EKey MouseScrollUp = new EKey("MouseScrollUp");

		// Token: 0x04024627 RID: 149031
		public static readonly EKey MouseScrollDown = new EKey("MouseScrollDown");

		// Token: 0x04024628 RID: 149032
		public static readonly EKey MouseWheelAxis = new EKey("MouseWheelAxis");

		// Token: 0x04024629 RID: 149033
		public static readonly EKey LeftMouseButton = new EKey("LeftMouseButton");

		// Token: 0x0402462A RID: 149034
		public static readonly EKey RightMouseButton = new EKey("RightMouseButton");

		// Token: 0x0402462B RID: 149035
		public static readonly EKey MiddleMouseButton = new EKey("MiddleMouseButton");

		// Token: 0x0402462C RID: 149036
		public static readonly EKey ThumbMouseButton = new EKey("ThumbMouseButton");

		// Token: 0x0402462D RID: 149037
		public static readonly EKey ThumbMouseButton2 = new EKey("ThumbMouseButton2");

		// Token: 0x0402462E RID: 149038
		public static readonly EKey BackSpace = new EKey("BackSpace");

		// Token: 0x0402462F RID: 149039
		public static readonly EKey Tab = new EKey("Tab");

		// Token: 0x04024630 RID: 149040
		public static readonly EKey Enter = new EKey("Enter");

		// Token: 0x04024631 RID: 149041
		public static readonly EKey Pause = new EKey("Pause");

		// Token: 0x04024632 RID: 149042
		public static readonly EKey CapsLock = new EKey("CapsLock");

		// Token: 0x04024633 RID: 149043
		public static readonly EKey Escape = new EKey("Escape");

		// Token: 0x04024634 RID: 149044
		public static readonly EKey SpaceBar = new EKey("SpaceBar");

		// Token: 0x04024635 RID: 149045
		public static readonly EKey PageUp = new EKey("PageUp");

		// Token: 0x04024636 RID: 149046
		public static readonly EKey PageDown = new EKey("PageDown");

		// Token: 0x04024637 RID: 149047
		public static readonly EKey End = new EKey("End");

		// Token: 0x04024638 RID: 149048
		public static readonly EKey Home = new EKey("Home");

		// Token: 0x04024639 RID: 149049
		public static readonly EKey Left = new EKey("Left");

		// Token: 0x0402463A RID: 149050
		public static readonly EKey Up = new EKey("Up");

		// Token: 0x0402463B RID: 149051
		public static readonly EKey Right = new EKey("Right");

		// Token: 0x0402463C RID: 149052
		public static readonly EKey Down = new EKey("Down");

		// Token: 0x0402463D RID: 149053
		public static readonly EKey Insert = new EKey("Insert");

		// Token: 0x0402463E RID: 149054
		public static readonly EKey Delete = new EKey("Delete");

		// Token: 0x0402463F RID: 149055
		public static readonly EKey Zero = new EKey("Zero");

		// Token: 0x04024640 RID: 149056
		public static readonly EKey One = new EKey("One");

		// Token: 0x04024641 RID: 149057
		public static readonly EKey Two = new EKey("Two");

		// Token: 0x04024642 RID: 149058
		public static readonly EKey Three = new EKey("Three");

		// Token: 0x04024643 RID: 149059
		public static readonly EKey Four = new EKey("Four");

		// Token: 0x04024644 RID: 149060
		public static readonly EKey Five = new EKey("Five");

		// Token: 0x04024645 RID: 149061
		public static readonly EKey Six = new EKey("Six");

		// Token: 0x04024646 RID: 149062
		public static readonly EKey Seven = new EKey("Seven");

		// Token: 0x04024647 RID: 149063
		public static readonly EKey Eight = new EKey("Eight");

		// Token: 0x04024648 RID: 149064
		public static readonly EKey Nine = new EKey("Nine");

		// Token: 0x04024649 RID: 149065
		public static readonly EKey A = new EKey("A");

		// Token: 0x0402464A RID: 149066
		public static readonly EKey B = new EKey("B");

		// Token: 0x0402464B RID: 149067
		public static readonly EKey C = new EKey("C");

		// Token: 0x0402464C RID: 149068
		public static readonly EKey D = new EKey("D");

		// Token: 0x0402464D RID: 149069
		public static readonly EKey E = new EKey("E");

		// Token: 0x0402464E RID: 149070
		public static readonly EKey F = new EKey("F");

		// Token: 0x0402464F RID: 149071
		public static readonly EKey G = new EKey("G");

		// Token: 0x04024650 RID: 149072
		public static readonly EKey H = new EKey("H");

		// Token: 0x04024651 RID: 149073
		public static readonly EKey I = new EKey("I");

		// Token: 0x04024652 RID: 149074
		public static readonly EKey J = new EKey("J");

		// Token: 0x04024653 RID: 149075
		public static readonly EKey K = new EKey("K");

		// Token: 0x04024654 RID: 149076
		public static readonly EKey L = new EKey("L");

		// Token: 0x04024655 RID: 149077
		public static readonly EKey M = new EKey("M");

		// Token: 0x04024656 RID: 149078
		public static readonly EKey N = new EKey("N");

		// Token: 0x04024657 RID: 149079
		public static readonly EKey O = new EKey("O");

		// Token: 0x04024658 RID: 149080
		public static readonly EKey P = new EKey("P");

		// Token: 0x04024659 RID: 149081
		public static readonly EKey Q = new EKey("Q");

		// Token: 0x0402465A RID: 149082
		public static readonly EKey R = new EKey("R");

		// Token: 0x0402465B RID: 149083
		public static readonly EKey S = new EKey("S");

		// Token: 0x0402465C RID: 149084
		public static readonly EKey T = new EKey("T");

		// Token: 0x0402465D RID: 149085
		public static readonly EKey U = new EKey("U");

		// Token: 0x0402465E RID: 149086
		public static readonly EKey V = new EKey("V");

		// Token: 0x0402465F RID: 149087
		public static readonly EKey W = new EKey("W");

		// Token: 0x04024660 RID: 149088
		public static readonly EKey X = new EKey("X");

		// Token: 0x04024661 RID: 149089
		public static readonly EKey Y = new EKey("Y");

		// Token: 0x04024662 RID: 149090
		public static readonly EKey Z = new EKey("Z");

		// Token: 0x04024663 RID: 149091
		public static readonly EKey NumPadZero = new EKey("NumPadZero");

		// Token: 0x04024664 RID: 149092
		public static readonly EKey NumPadOne = new EKey("NumPadOne");

		// Token: 0x04024665 RID: 149093
		public static readonly EKey NumPadTwo = new EKey("NumPadTwo");

		// Token: 0x04024666 RID: 149094
		public static readonly EKey NumPadThree = new EKey("NumPadThree");

		// Token: 0x04024667 RID: 149095
		public static readonly EKey NumPadFour = new EKey("NumPadFour");

		// Token: 0x04024668 RID: 149096
		public static readonly EKey NumPadFive = new EKey("NumPadFive");

		// Token: 0x04024669 RID: 149097
		public static readonly EKey NumPadSix = new EKey("NumPadSix");

		// Token: 0x0402466A RID: 149098
		public static readonly EKey NumPadSeven = new EKey("NumPadSeven");

		// Token: 0x0402466B RID: 149099
		public static readonly EKey NumPadEight = new EKey("NumPadEight");

		// Token: 0x0402466C RID: 149100
		public static readonly EKey NumPadNine = new EKey("NumPadNine");

		// Token: 0x0402466D RID: 149101
		public static readonly EKey Multiply = new EKey("Multiply");

		// Token: 0x0402466E RID: 149102
		public static readonly EKey Add = new EKey("Add");

		// Token: 0x0402466F RID: 149103
		public static readonly EKey Subtract = new EKey("Subtract");

		// Token: 0x04024670 RID: 149104
		public static readonly EKey Decimal = new EKey("Decimal");

		// Token: 0x04024671 RID: 149105
		public static readonly EKey Divide = new EKey("Divide");

		// Token: 0x04024672 RID: 149106
		public static readonly EKey F1 = new EKey("F1");

		// Token: 0x04024673 RID: 149107
		public static readonly EKey F2 = new EKey("F2");

		// Token: 0x04024674 RID: 149108
		public static readonly EKey F3 = new EKey("F3");

		// Token: 0x04024675 RID: 149109
		public static readonly EKey F4 = new EKey("F4");

		// Token: 0x04024676 RID: 149110
		public static readonly EKey F5 = new EKey("F5");

		// Token: 0x04024677 RID: 149111
		public static readonly EKey F6 = new EKey("F6");

		// Token: 0x04024678 RID: 149112
		public static readonly EKey F7 = new EKey("F7");

		// Token: 0x04024679 RID: 149113
		public static readonly EKey F8 = new EKey("F8");

		// Token: 0x0402467A RID: 149114
		public static readonly EKey F9 = new EKey("F9");

		// Token: 0x0402467B RID: 149115
		public static readonly EKey F10 = new EKey("F10");

		// Token: 0x0402467C RID: 149116
		public static readonly EKey F11 = new EKey("F11");

		// Token: 0x0402467D RID: 149117
		public static readonly EKey F12 = new EKey("F12");

		// Token: 0x0402467E RID: 149118
		public static readonly EKey NumLock = new EKey("NumLock");

		// Token: 0x0402467F RID: 149119
		public static readonly EKey ScrollLock = new EKey("ScrollLock");

		// Token: 0x04024680 RID: 149120
		public static readonly EKey LeftShift = new EKey("LeftShift");

		// Token: 0x04024681 RID: 149121
		public static readonly EKey RightShift = new EKey("RightShift");

		// Token: 0x04024682 RID: 149122
		public static readonly EKey LeftControl = new EKey("LeftControl");

		// Token: 0x04024683 RID: 149123
		public static readonly EKey RightControl = new EKey("RightControl");

		// Token: 0x04024684 RID: 149124
		public static readonly EKey LeftAlt = new EKey("LeftAlt");

		// Token: 0x04024685 RID: 149125
		public static readonly EKey RightAlt = new EKey("RightAlt");

		// Token: 0x04024686 RID: 149126
		public static readonly EKey LeftCommand = new EKey("LeftCommand");

		// Token: 0x04024687 RID: 149127
		public static readonly EKey RightCommand = new EKey("RightCommand");

		// Token: 0x04024688 RID: 149128
		public static readonly EKey Semicolon = new EKey("Semicolon");

		// Token: 0x04024689 RID: 149129
		public static readonly EKey EqualsKey = new EKey("Equals");

		// Token: 0x0402468A RID: 149130
		public static readonly EKey Comma = new EKey("Comma");

		// Token: 0x0402468B RID: 149131
		public static readonly EKey Underscore = new EKey("Underscore");

		// Token: 0x0402468C RID: 149132
		public static readonly EKey Hyphen = new EKey("Hyphen");

		// Token: 0x0402468D RID: 149133
		public static readonly EKey Period = new EKey("Period");

		// Token: 0x0402468E RID: 149134
		public static readonly EKey Slash = new EKey("Slash");

		// Token: 0x0402468F RID: 149135
		public static readonly EKey Tilde = new EKey("Tilde");

		// Token: 0x04024690 RID: 149136
		public static readonly EKey LeftBracket = new EKey("LeftBracket");

		// Token: 0x04024691 RID: 149137
		public static readonly EKey Backslash = new EKey("Backslash");

		// Token: 0x04024692 RID: 149138
		public static readonly EKey RightBracket = new EKey("RightBracket");

		// Token: 0x04024693 RID: 149139
		public static readonly EKey Apostrophe = new EKey("Apostrophe");

		// Token: 0x04024694 RID: 149140
		public static readonly EKey Ampersand = new EKey("Ampersand");

		// Token: 0x04024695 RID: 149141
		public static readonly EKey Asterix = new EKey("Asterix");

		// Token: 0x04024696 RID: 149142
		public static readonly EKey Caret = new EKey("Caret");

		// Token: 0x04024697 RID: 149143
		public static readonly EKey Colon = new EKey("Colon");

		// Token: 0x04024698 RID: 149144
		public static readonly EKey Dollar = new EKey("Dollar");

		// Token: 0x04024699 RID: 149145
		public static readonly EKey Exclamation = new EKey("Exclamation");

		// Token: 0x0402469A RID: 149146
		public static readonly EKey LeftParantheses = new EKey("LeftParantheses");

		// Token: 0x0402469B RID: 149147
		public static readonly EKey RightParantheses = new EKey("RightParantheses");

		// Token: 0x0402469C RID: 149148
		public static readonly EKey Quote = new EKey("Quote");

		// Token: 0x0402469D RID: 149149
		public static readonly EKey A_AccentGrave = new EKey("A_AccentGrave");

		// Token: 0x0402469E RID: 149150
		public static readonly EKey E_AccentGrave = new EKey("E_AccentGrave");

		// Token: 0x0402469F RID: 149151
		public static readonly EKey E_AccentAigu = new EKey("E_AccentAigu");

		// Token: 0x040246A0 RID: 149152
		public static readonly EKey C_Cedille = new EKey("C_Cedille");

		// Token: 0x040246A1 RID: 149153
		public static readonly EKey Section = new EKey("Section");

		// Token: 0x040246A2 RID: 149154
		public static readonly EKey Keyboard_Invalid = new EKey("Keyboard_Invalid");

		// Token: 0x040246A3 RID: 149155
		public static readonly EKey Platform_Delete = new EKey("Platform_Delete");

		// Token: 0x040246A4 RID: 149156
		public static readonly EKey Gamepad_Left2D = new EKey("Gamepad_Left2D");

		// Token: 0x040246A5 RID: 149157
		public static readonly EKey Gamepad_LeftX = new EKey("Gamepad_LeftX");

		// Token: 0x040246A6 RID: 149158
		public static readonly EKey Gamepad_LeftY = new EKey("Gamepad_LeftY");

		// Token: 0x040246A7 RID: 149159
		public static readonly EKey Gamepad_Right2D = new EKey("Gamepad_Right2D");

		// Token: 0x040246A8 RID: 149160
		public static readonly EKey Gamepad_RightX = new EKey("Gamepad_RightX");

		// Token: 0x040246A9 RID: 149161
		public static readonly EKey Gamepad_RightY = new EKey("Gamepad_RightY");

		// Token: 0x040246AA RID: 149162
		public static readonly EKey Gamepad_LeftTriggerAxis = new EKey("Gamepad_LeftTriggerAxis");

		// Token: 0x040246AB RID: 149163
		public static readonly EKey Gamepad_RightTriggerAxis = new EKey("Gamepad_RightTriggerAxis");

		// Token: 0x040246AC RID: 149164
		public static readonly EKey Gamepad_LeftThumbstick = new EKey("Gamepad_LeftThumbstick");

		// Token: 0x040246AD RID: 149165
		public static readonly EKey Gamepad_RightThumbstick = new EKey("Gamepad_RightThumbstick");

		// Token: 0x040246AE RID: 149166
		public static readonly EKey Gamepad_Special_Left = new EKey("Gamepad_Special_Left");

		// Token: 0x040246AF RID: 149167
		public static readonly EKey Gamepad_Special_Left_X = new EKey("Gamepad_Special_Left_X");

		// Token: 0x040246B0 RID: 149168
		public static readonly EKey Gamepad_Special_Left_Y = new EKey("Gamepad_Special_Left_Y");

		// Token: 0x040246B1 RID: 149169
		public static readonly EKey Gamepad_Special_Right = new EKey("Gamepad_Special_Right");

		// Token: 0x040246B2 RID: 149170
		public static readonly EKey Gamepad_FaceButton_Bottom = new EKey("Gamepad_FaceButton_Bottom");

		// Token: 0x040246B3 RID: 149171
		public static readonly EKey Gamepad_FaceButton_Right = new EKey("Gamepad_FaceButton_Right");

		// Token: 0x040246B4 RID: 149172
		public static readonly EKey Gamepad_FaceButton_Left = new EKey("Gamepad_FaceButton_Left");

		// Token: 0x040246B5 RID: 149173
		public static readonly EKey Gamepad_FaceButton_Top = new EKey("Gamepad_FaceButton_Top");

		// Token: 0x040246B6 RID: 149174
		public static readonly EKey Gamepad_LeftShoulder = new EKey("Gamepad_LeftShoulder");

		// Token: 0x040246B7 RID: 149175
		public static readonly EKey Gamepad_RightShoulder = new EKey("Gamepad_RightShoulder");

		// Token: 0x040246B8 RID: 149176
		public static readonly EKey Gamepad_LeftTrigger = new EKey("Gamepad_LeftTrigger");

		// Token: 0x040246B9 RID: 149177
		public static readonly EKey Gamepad_RightTrigger = new EKey("Gamepad_RightTrigger");

		// Token: 0x040246BA RID: 149178
		public static readonly EKey Gamepad_DPad_Up = new EKey("Gamepad_DPad_Up");

		// Token: 0x040246BB RID: 149179
		public static readonly EKey Gamepad_DPad_Down = new EKey("Gamepad_DPad_Down");

		// Token: 0x040246BC RID: 149180
		public static readonly EKey Gamepad_DPad_Right = new EKey("Gamepad_DPad_Right");

		// Token: 0x040246BD RID: 149181
		public static readonly EKey Gamepad_DPad_Left = new EKey("Gamepad_DPad_Left");

		// Token: 0x040246BE RID: 149182
		public static readonly EKey Gamepad_LeftStick_Up = new EKey("Gamepad_LeftStick_Up");

		// Token: 0x040246BF RID: 149183
		public static readonly EKey Gamepad_LeftStick_Down = new EKey("Gamepad_LeftStick_Down");

		// Token: 0x040246C0 RID: 149184
		public static readonly EKey Gamepad_LeftStick_Right = new EKey("Gamepad_LeftStick_Right");

		// Token: 0x040246C1 RID: 149185
		public static readonly EKey Gamepad_LeftStick_Left = new EKey("Gamepad_LeftStick_Left");

		// Token: 0x040246C2 RID: 149186
		public static readonly EKey Gamepad_RightStick_Up = new EKey("Gamepad_RightStick_Up");

		// Token: 0x040246C3 RID: 149187
		public static readonly EKey Gamepad_RightStick_Down = new EKey("Gamepad_RightStick_Down");

		// Token: 0x040246C4 RID: 149188
		public static readonly EKey Gamepad_RightStick_Right = new EKey("Gamepad_RightStick_Right");

		// Token: 0x040246C5 RID: 149189
		public static readonly EKey Gamepad_RightStick_Left = new EKey("Gamepad_RightStick_Left");

		// Token: 0x040246C6 RID: 149190
		public static readonly EKey Gamepad_Invalid = new EKey("Gamepad_Invalid");

		// Token: 0x040246C7 RID: 149191
		public static readonly EKey Tilt = new EKey("Tilt");

		// Token: 0x040246C8 RID: 149192
		public static readonly EKey RotationRate = new EKey("RotationRate");

		// Token: 0x040246C9 RID: 149193
		public static readonly EKey Gravity = new EKey("Gravity");

		// Token: 0x040246CA RID: 149194
		public static readonly EKey Acceleration = new EKey("Acceleration");

		// Token: 0x040246CB RID: 149195
		public static readonly EKey Gesture_Pinch = new EKey("Gesture_Pinch");

		// Token: 0x040246CC RID: 149196
		public static readonly EKey Gesture_Flick = new EKey("Gesture_Flick");

		// Token: 0x040246CD RID: 149197
		public static readonly EKey Gesture_Rotate = new EKey("Gesture_Rotate");

		// Token: 0x040246CE RID: 149198
		public static readonly EKey PS4_Special = new EKey("PS4_Special");

		// Token: 0x040246CF RID: 149199
		public static readonly EKey Steam_Touch_0 = new EKey("Steam_Touch_0");

		// Token: 0x040246D0 RID: 149200
		public static readonly EKey Steam_Touch_1 = new EKey("Steam_Touch_1");

		// Token: 0x040246D1 RID: 149201
		public static readonly EKey Steam_Touch_2 = new EKey("Steam_Touch_2");

		// Token: 0x040246D2 RID: 149202
		public static readonly EKey Steam_Touch_3 = new EKey("Steam_Touch_3");

		// Token: 0x040246D3 RID: 149203
		public static readonly EKey Steam_Back_Left = new EKey("Steam_Back_Left");

		// Token: 0x040246D4 RID: 149204
		public static readonly EKey Steam_Back_Right = new EKey("Steam_Back_Right");

		// Token: 0x040246D5 RID: 149205
		public static readonly EKey Global_Menu = new EKey("Global_Menu");

		// Token: 0x040246D6 RID: 149206
		public static readonly EKey Global_View = new EKey("Global_View");

		// Token: 0x040246D7 RID: 149207
		public static readonly EKey Global_Pause = new EKey("Global_Pause");

		// Token: 0x040246D8 RID: 149208
		public static readonly EKey Global_Play = new EKey("Global_Play");

		// Token: 0x040246D9 RID: 149209
		public static readonly EKey Global_Back = new EKey("Global_Back");

		// Token: 0x040246DA RID: 149210
		public static readonly EKey Android_Back = new EKey("Android_Back");

		// Token: 0x040246DB RID: 149211
		public static readonly EKey Android_Volume_Up = new EKey("Android_Volume_Up");

		// Token: 0x040246DC RID: 149212
		public static readonly EKey Android_Volume_Down = new EKey("Android_Volume_Down");

		// Token: 0x040246DD RID: 149213
		public static readonly EKey Android_Menu = new EKey("Android_Menu");

		// Token: 0x040246DE RID: 149214
		public static readonly EKey Daydream_Left_Select_Click = new EKey("Daydream_Left_Select_Click");

		// Token: 0x040246DF RID: 149215
		public static readonly EKey Daydream_Left_Trackpad_X = new EKey("Daydream_Left_Trackpad_X");

		// Token: 0x040246E0 RID: 149216
		public static readonly EKey Daydream_Left_Trackpad_Y = new EKey("Daydream_Left_Trackpad_Y");

		// Token: 0x040246E1 RID: 149217
		public static readonly EKey Daydream_Left_Trackpad_Click = new EKey("Daydream_Left_Trackpad_Click");

		// Token: 0x040246E2 RID: 149218
		public static readonly EKey Daydream_Left_Trackpad_Touch = new EKey("Daydream_Left_Trackpad_Touch");

		// Token: 0x040246E3 RID: 149219
		public static readonly EKey Daydream_Right_Select_Click = new EKey("Daydream_Right_Select_Click");

		// Token: 0x040246E4 RID: 149220
		public static readonly EKey Daydream_Right_Trackpad_X = new EKey("Daydream_Right_Trackpad_X");

		// Token: 0x040246E5 RID: 149221
		public static readonly EKey Daydream_Right_Trackpad_Y = new EKey("Daydream_Right_Trackpad_Y");

		// Token: 0x040246E6 RID: 149222
		public static readonly EKey Daydream_Right_Trackpad_Click = new EKey("Daydream_Right_Trackpad_Click");

		// Token: 0x040246E7 RID: 149223
		public static readonly EKey Daydream_Right_Trackpad_Touch = new EKey("Daydream_Right_Trackpad_Touch");

		// Token: 0x040246E8 RID: 149224
		public static readonly EKey Vive_Left_System_Click = new EKey("Vive_Left_System_Click");

		// Token: 0x040246E9 RID: 149225
		public static readonly EKey Vive_Left_Grip_Click = new EKey("Vive_Left_Grip_Click");

		// Token: 0x040246EA RID: 149226
		public static readonly EKey Vive_Left_Menu_Click = new EKey("Vive_Left_Menu_Click");

		// Token: 0x040246EB RID: 149227
		public static readonly EKey Vive_Left_Trigger_Click = new EKey("Vive_Left_Trigger_Click");

		// Token: 0x040246EC RID: 149228
		public static readonly EKey Vive_Left_Trigger_Axis = new EKey("Vive_Left_Trigger_Axis");

		// Token: 0x040246ED RID: 149229
		public static readonly EKey Vive_Left_Trackpad_X = new EKey("Vive_Left_Trackpad_X");

		// Token: 0x040246EE RID: 149230
		public static readonly EKey Vive_Left_Trackpad_Y = new EKey("Vive_Left_Trackpad_Y");

		// Token: 0x040246EF RID: 149231
		public static readonly EKey Vive_Left_Trackpad_Click = new EKey("Vive_Left_Trackpad_Click");

		// Token: 0x040246F0 RID: 149232
		public static readonly EKey Vive_Left_Trackpad_Touch = new EKey("Vive_Left_Trackpad_Touch");

		// Token: 0x040246F1 RID: 149233
		public static readonly EKey Vive_Left_Trackpad_Up = new EKey("Vive_Left_Trackpad_Up");

		// Token: 0x040246F2 RID: 149234
		public static readonly EKey Vive_Left_Trackpad_Down = new EKey("Vive_Left_Trackpad_Down");

		// Token: 0x040246F3 RID: 149235
		public static readonly EKey Vive_Left_Trackpad_Left = new EKey("Vive_Left_Trackpad_Left");

		// Token: 0x040246F4 RID: 149236
		public static readonly EKey Vive_Left_Trackpad_Right = new EKey("Vive_Left_Trackpad_Right");

		// Token: 0x040246F5 RID: 149237
		public static readonly EKey Vive_Right_System_Click = new EKey("Vive_Right_System_Click");

		// Token: 0x040246F6 RID: 149238
		public static readonly EKey Vive_Right_Grip_Click = new EKey("Vive_Right_Grip_Click");

		// Token: 0x040246F7 RID: 149239
		public static readonly EKey Vive_Right_Menu_Click = new EKey("Vive_Right_Menu_Click");

		// Token: 0x040246F8 RID: 149240
		public static readonly EKey Vive_Right_Trigger_Click = new EKey("Vive_Right_Trigger_Click");

		// Token: 0x040246F9 RID: 149241
		public static readonly EKey Vive_Right_Trigger_Axis = new EKey("Vive_Right_Trigger_Axis");

		// Token: 0x040246FA RID: 149242
		public static readonly EKey Vive_Right_Trackpad_X = new EKey("Vive_Right_Trackpad_X");

		// Token: 0x040246FB RID: 149243
		public static readonly EKey Vive_Right_Trackpad_Y = new EKey("Vive_Right_Trackpad_Y");

		// Token: 0x040246FC RID: 149244
		public static readonly EKey Vive_Right_Trackpad_Click = new EKey("Vive_Right_Trackpad_Click");

		// Token: 0x040246FD RID: 149245
		public static readonly EKey Vive_Right_Trackpad_Touch = new EKey("Vive_Right_Trackpad_Touch");

		// Token: 0x040246FE RID: 149246
		public static readonly EKey Vive_Right_Trackpad_Up = new EKey("Vive_Right_Trackpad_Up");

		// Token: 0x040246FF RID: 149247
		public static readonly EKey Vive_Right_Trackpad_Down = new EKey("Vive_Right_Trackpad_Down");

		// Token: 0x04024700 RID: 149248
		public static readonly EKey Vive_Right_Trackpad_Left = new EKey("Vive_Right_Trackpad_Left");

		// Token: 0x04024701 RID: 149249
		public static readonly EKey Vive_Right_Trackpad_Right = new EKey("Vive_Right_Trackpad_Right");

		// Token: 0x04024702 RID: 149250
		public static readonly EKey MixedReality_Left_Menu_Click = new EKey("MixedReality_Left_Menu_Click");

		// Token: 0x04024703 RID: 149251
		public static readonly EKey MixedReality_Left_Grip_Click = new EKey("MixedReality_Left_Grip_Click");

		// Token: 0x04024704 RID: 149252
		public static readonly EKey MixedReality_Left_Trigger_Click = new EKey("MixedReality_Left_Trigger_Click");

		// Token: 0x04024705 RID: 149253
		public static readonly EKey MixedReality_Left_Trigger_Axis = new EKey("MixedReality_Left_Trigger_Axis");

		// Token: 0x04024706 RID: 149254
		public static readonly EKey MixedReality_Left_Thumbstick_X = new EKey("MixedReality_Left_Thumbstick_X");

		// Token: 0x04024707 RID: 149255
		public static readonly EKey MixedReality_Left_Thumbstick_Y = new EKey("MixedReality_Left_Thumbstick_Y");

		// Token: 0x04024708 RID: 149256
		public static readonly EKey MixedReality_Left_Thumbstick_Click = new EKey("MixedReality_Left_Thumbstick_Click");

		// Token: 0x04024709 RID: 149257
		public static readonly EKey MixedReality_Left_Thumbstick_Up = new EKey("MixedReality_Left_Thumbstick_Up");

		// Token: 0x0402470A RID: 149258
		public static readonly EKey MixedReality_Left_Thumbstick_Down = new EKey("MixedReality_Left_Thumbstick_Down");

		// Token: 0x0402470B RID: 149259
		public static readonly EKey MixedReality_Left_Thumbstick_Left = new EKey("MixedReality_Left_Thumbstick_Left");

		// Token: 0x0402470C RID: 149260
		public static readonly EKey MixedReality_Left_Thumbstick_Right = new EKey("MixedReality_Left_Thumbstick_Right");

		// Token: 0x0402470D RID: 149261
		public static readonly EKey MixedReality_Left_Trackpad_X = new EKey("MixedReality_Left_Trackpad_X");

		// Token: 0x0402470E RID: 149262
		public static readonly EKey MixedReality_Left_Trackpad_Y = new EKey("MixedReality_Left_Trackpad_Y");

		// Token: 0x0402470F RID: 149263
		public static readonly EKey MixedReality_Left_Trackpad_Click = new EKey("MixedReality_Left_Trackpad_Click");

		// Token: 0x04024710 RID: 149264
		public static readonly EKey MixedReality_Left_Trackpad_Touch = new EKey("MixedReality_Left_Trackpad_Touch");

		// Token: 0x04024711 RID: 149265
		public static readonly EKey MixedReality_Left_Trackpad_Up = new EKey("MixedReality_Left_Trackpad_Up");

		// Token: 0x04024712 RID: 149266
		public static readonly EKey MixedReality_Left_Trackpad_Down = new EKey("MixedReality_Left_Trackpad_Down");

		// Token: 0x04024713 RID: 149267
		public static readonly EKey MixedReality_Left_Trackpad_Left = new EKey("MixedReality_Left_Trackpad_Left");

		// Token: 0x04024714 RID: 149268
		public static readonly EKey MixedReality_Left_Trackpad_Right = new EKey("MixedReality_Left_Trackpad_Right");

		// Token: 0x04024715 RID: 149269
		public static readonly EKey MixedReality_Right_Menu_Click = new EKey("MixedReality_Right_Menu_Click");

		// Token: 0x04024716 RID: 149270
		public static readonly EKey MixedReality_Right_Grip_Click = new EKey("MixedReality_Right_Grip_Click");

		// Token: 0x04024717 RID: 149271
		public static readonly EKey MixedReality_Right_Trigger_Click = new EKey("MixedReality_Right_Trigger_Click");

		// Token: 0x04024718 RID: 149272
		public static readonly EKey MixedReality_Right_Trigger_Axis = new EKey("MixedReality_Right_Trigger_Axis");

		// Token: 0x04024719 RID: 149273
		public static readonly EKey MixedReality_Right_Thumbstick_X = new EKey("MixedReality_Right_Thumbstick_X");

		// Token: 0x0402471A RID: 149274
		public static readonly EKey MixedReality_Right_Thumbstick_Y = new EKey("MixedReality_Right_Thumbstick_Y");

		// Token: 0x0402471B RID: 149275
		public static readonly EKey MixedReality_Right_Thumbstick_Click = new EKey("MixedReality_Right_Thumbstick_Click");

		// Token: 0x0402471C RID: 149276
		public static readonly EKey MixedReality_Right_Thumbstick_Up = new EKey("MixedReality_Right_Thumbstick_Up");

		// Token: 0x0402471D RID: 149277
		public static readonly EKey MixedReality_Right_Thumbstick_Down = new EKey("MixedReality_Right_Thumbstick_Down");

		// Token: 0x0402471E RID: 149278
		public static readonly EKey MixedReality_Right_Thumbstick_Left = new EKey("MixedReality_Right_Thumbstick_Left");

		// Token: 0x0402471F RID: 149279
		public static readonly EKey MixedReality_Right_Thumbstick_Right = new EKey("MixedReality_Right_Thumbstick_Right");

		// Token: 0x04024720 RID: 149280
		public static readonly EKey MixedReality_Right_Trackpad_X = new EKey("MixedReality_Right_Trackpad_X");

		// Token: 0x04024721 RID: 149281
		public static readonly EKey MixedReality_Right_Trackpad_Y = new EKey("MixedReality_Right_Trackpad_Y");

		// Token: 0x04024722 RID: 149282
		public static readonly EKey MixedReality_Right_Trackpad_Click = new EKey("MixedReality_Right_Trackpad_Click");

		// Token: 0x04024723 RID: 149283
		public static readonly EKey MixedReality_Right_Trackpad_Touch = new EKey("MixedReality_Right_Trackpad_Touch");

		// Token: 0x04024724 RID: 149284
		public static readonly EKey MixedReality_Right_Trackpad_Up = new EKey("MixedReality_Right_Trackpad_Up");

		// Token: 0x04024725 RID: 149285
		public static readonly EKey MixedReality_Right_Trackpad_Down = new EKey("MixedReality_Right_Trackpad_Down");

		// Token: 0x04024726 RID: 149286
		public static readonly EKey MixedReality_Right_Trackpad_Left = new EKey("MixedReality_Right_Trackpad_Left");

		// Token: 0x04024727 RID: 149287
		public static readonly EKey MixedReality_Right_Trackpad_Right = new EKey("MixedReality_Right_Trackpad_Right");

		// Token: 0x04024728 RID: 149288
		public static readonly EKey OculusTouch_Left_X_Click = new EKey("OculusTouch_Left_X_Click");

		// Token: 0x04024729 RID: 149289
		public static readonly EKey OculusTouch_Left_Y_Click = new EKey("OculusTouch_Left_Y_Click");

		// Token: 0x0402472A RID: 149290
		public static readonly EKey OculusTouch_Left_X_Touch = new EKey("OculusTouch_Left_X_Touch");

		// Token: 0x0402472B RID: 149291
		public static readonly EKey OculusTouch_Left_Y_Touch = new EKey("OculusTouch_Left_Y_Touch");

		// Token: 0x0402472C RID: 149292
		public static readonly EKey OculusTouch_Left_Menu_Click = new EKey("OculusTouch_Left_Menu_Click");

		// Token: 0x0402472D RID: 149293
		public static readonly EKey OculusTouch_Left_Grip_Click = new EKey("OculusTouch_Left_Grip_Click");

		// Token: 0x0402472E RID: 149294
		public static readonly EKey OculusTouch_Left_Grip_Axis = new EKey("OculusTouch_Left_Grip_Axis");

		// Token: 0x0402472F RID: 149295
		public static readonly EKey OculusTouch_Left_Trigger_Click = new EKey("OculusTouch_Left_Trigger_Click");

		// Token: 0x04024730 RID: 149296
		public static readonly EKey OculusTouch_Left_Trigger_Axis = new EKey("OculusTouch_Left_Trigger_Axis");

		// Token: 0x04024731 RID: 149297
		public static readonly EKey OculusTouch_Left_Trigger_Touch = new EKey("OculusTouch_Left_Trigger_Touch");

		// Token: 0x04024732 RID: 149298
		public static readonly EKey OculusTouch_Left_Thumbstick_X = new EKey("OculusTouch_Left_Thumbstick_X");

		// Token: 0x04024733 RID: 149299
		public static readonly EKey OculusTouch_Left_Thumbstick_Y = new EKey("OculusTouch_Left_Thumbstick_Y");

		// Token: 0x04024734 RID: 149300
		public static readonly EKey OculusTouch_Left_Thumbstick_Click = new EKey("OculusTouch_Left_Thumbstick_Click");

		// Token: 0x04024735 RID: 149301
		public static readonly EKey OculusTouch_Left_Thumbstick_Touch = new EKey("OculusTouch_Left_Thumbstick_Touch");

		// Token: 0x04024736 RID: 149302
		public static readonly EKey OculusTouch_Left_Thumbstick_Up = new EKey("OculusTouch_Left_Thumbstick_Up");

		// Token: 0x04024737 RID: 149303
		public static readonly EKey OculusTouch_Left_Thumbstick_Down = new EKey("OculusTouch_Left_Thumbstick_Down");

		// Token: 0x04024738 RID: 149304
		public static readonly EKey OculusTouch_Left_Thumbstick_Left = new EKey("OculusTouch_Left_Thumbstick_Left");

		// Token: 0x04024739 RID: 149305
		public static readonly EKey OculusTouch_Left_Thumbstick_Right = new EKey("OculusTouch_Left_Thumbstick_Right");

		// Token: 0x0402473A RID: 149306
		public static readonly EKey OculusTouch_Right_A_Click = new EKey("OculusTouch_Right_A_Click");

		// Token: 0x0402473B RID: 149307
		public static readonly EKey OculusTouch_Right_B_Click = new EKey("OculusTouch_Right_B_Click");

		// Token: 0x0402473C RID: 149308
		public static readonly EKey OculusTouch_Right_A_Touch = new EKey("OculusTouch_Right_A_Touch");

		// Token: 0x0402473D RID: 149309
		public static readonly EKey OculusTouch_Right_B_Touch = new EKey("OculusTouch_Right_B_Touch");

		// Token: 0x0402473E RID: 149310
		public static readonly EKey OculusTouch_Right_System_Click = new EKey("OculusTouch_Right_System_Click");

		// Token: 0x0402473F RID: 149311
		public static readonly EKey OculusTouch_Right_Grip_Click = new EKey("OculusTouch_Right_Grip_Click");

		// Token: 0x04024740 RID: 149312
		public static readonly EKey OculusTouch_Right_Grip_Axis = new EKey("OculusTouch_Right_Grip_Axis");

		// Token: 0x04024741 RID: 149313
		public static readonly EKey OculusTouch_Right_Trigger_Click = new EKey("OculusTouch_Right_Trigger_Click");

		// Token: 0x04024742 RID: 149314
		public static readonly EKey OculusTouch_Right_Trigger_Axis = new EKey("OculusTouch_Right_Trigger_Axis");

		// Token: 0x04024743 RID: 149315
		public static readonly EKey OculusTouch_Right_Trigger_Touch = new EKey("OculusTouch_Right_Trigger_Touch");

		// Token: 0x04024744 RID: 149316
		public static readonly EKey OculusTouch_Right_Thumbstick_X = new EKey("OculusTouch_Right_Thumbstick_X");

		// Token: 0x04024745 RID: 149317
		public static readonly EKey OculusTouch_Right_Thumbstick_Y = new EKey("OculusTouch_Right_Thumbstick_Y");

		// Token: 0x04024746 RID: 149318
		public static readonly EKey OculusTouch_Right_Thumbstick_Click = new EKey("OculusTouch_Right_Thumbstick_Click");

		// Token: 0x04024747 RID: 149319
		public static readonly EKey OculusTouch_Right_Thumbstick_Touch = new EKey("OculusTouch_Right_Thumbstick_Touch");

		// Token: 0x04024748 RID: 149320
		public static readonly EKey OculusTouch_Right_Thumbstick_Up = new EKey("OculusTouch_Right_Thumbstick_Up");

		// Token: 0x04024749 RID: 149321
		public static readonly EKey OculusTouch_Right_Thumbstick_Down = new EKey("OculusTouch_Right_Thumbstick_Down");

		// Token: 0x0402474A RID: 149322
		public static readonly EKey OculusTouch_Right_Thumbstick_Left = new EKey("OculusTouch_Right_Thumbstick_Left");

		// Token: 0x0402474B RID: 149323
		public static readonly EKey OculusTouch_Right_Thumbstick_Right = new EKey("OculusTouch_Right_Thumbstick_Right");

		// Token: 0x0402474C RID: 149324
		public static readonly EKey ValveIndex_Left_A_Click = new EKey("ValveIndex_Left_A_Click");

		// Token: 0x0402474D RID: 149325
		public static readonly EKey ValveIndex_Left_B_Click = new EKey("ValveIndex_Left_B_Click");

		// Token: 0x0402474E RID: 149326
		public static readonly EKey ValveIndex_Left_A_Touch = new EKey("ValveIndex_Left_A_Touch");

		// Token: 0x0402474F RID: 149327
		public static readonly EKey ValveIndex_Left_B_Touch = new EKey("ValveIndex_Left_B_Touch");

		// Token: 0x04024750 RID: 149328
		public static readonly EKey ValveIndex_Left_System_Click = new EKey("ValveIndex_Left_System_Click");

		// Token: 0x04024751 RID: 149329
		public static readonly EKey ValveIndex_Left_System_Touch = new EKey("ValveIndex_Left_System_Touch");

		// Token: 0x04024752 RID: 149330
		public static readonly EKey ValveIndex_Left_Grip_Axis = new EKey("ValveIndex_Left_Grip_Axis");

		// Token: 0x04024753 RID: 149331
		public static readonly EKey ValveIndex_Left_Grip_Force = new EKey("ValveIndex_Left_Grip_Force");

		// Token: 0x04024754 RID: 149332
		public static readonly EKey ValveIndex_Left_Trigger_Click = new EKey("ValveIndex_Left_Trigger_Click");

		// Token: 0x04024755 RID: 149333
		public static readonly EKey ValveIndex_Left_Trigger_Axis = new EKey("ValveIndex_Left_Trigger_Axis");

		// Token: 0x04024756 RID: 149334
		public static readonly EKey ValveIndex_Left_Trigger_Touch = new EKey("ValveIndex_Left_Trigger_Touch");

		// Token: 0x04024757 RID: 149335
		public static readonly EKey ValveIndex_Left_Thumbstick_X = new EKey("ValveIndex_Left_Thumbstick_X");

		// Token: 0x04024758 RID: 149336
		public static readonly EKey ValveIndex_Left_Thumbstick_Y = new EKey("ValveIndex_Left_Thumbstick_Y");

		// Token: 0x04024759 RID: 149337
		public static readonly EKey ValveIndex_Left_Thumbstick_Click = new EKey("ValveIndex_Left_Thumbstick_Click");

		// Token: 0x0402475A RID: 149338
		public static readonly EKey ValveIndex_Left_Thumbstick_Touch = new EKey("ValveIndex_Left_Thumbstick_Touch");

		// Token: 0x0402475B RID: 149339
		public static readonly EKey ValveIndex_Left_Thumbstick_Up = new EKey("ValveIndex_Left_Thumbstick_Up");

		// Token: 0x0402475C RID: 149340
		public static readonly EKey ValveIndex_Left_Thumbstick_Down = new EKey("ValveIndex_Left_Thumbstick_Down");

		// Token: 0x0402475D RID: 149341
		public static readonly EKey ValveIndex_Left_Thumbstick_Left = new EKey("ValveIndex_Left_Thumbstick_Left");

		// Token: 0x0402475E RID: 149342
		public static readonly EKey ValveIndex_Left_Thumbstick_Right = new EKey("ValveIndex_Left_Thumbstick_Right");

		// Token: 0x0402475F RID: 149343
		public static readonly EKey ValveIndex_Left_Trackpad_X = new EKey("ValveIndex_Left_Trackpad_X");

		// Token: 0x04024760 RID: 149344
		public static readonly EKey ValveIndex_Left_Trackpad_Y = new EKey("ValveIndex_Left_Trackpad_Y");

		// Token: 0x04024761 RID: 149345
		public static readonly EKey ValveIndex_Left_Trackpad_Force = new EKey("ValveIndex_Left_Trackpad_Force");

		// Token: 0x04024762 RID: 149346
		public static readonly EKey ValveIndex_Left_Trackpad_Touch = new EKey("ValveIndex_Left_Trackpad_Touch");

		// Token: 0x04024763 RID: 149347
		public static readonly EKey ValveIndex_Left_Trackpad_Up = new EKey("ValveIndex_Left_Trackpad_Up");

		// Token: 0x04024764 RID: 149348
		public static readonly EKey ValveIndex_Left_Trackpad_Down = new EKey("ValveIndex_Left_Trackpad_Down");

		// Token: 0x04024765 RID: 149349
		public static readonly EKey ValveIndex_Left_Trackpad_Left = new EKey("ValveIndex_Left_Trackpad_Left");

		// Token: 0x04024766 RID: 149350
		public static readonly EKey ValveIndex_Left_Trackpad_Right = new EKey("ValveIndex_Left_Trackpad_Right");

		// Token: 0x04024767 RID: 149351
		public static readonly EKey ValveIndex_Right_A_Click = new EKey("ValveIndex_Right_A_Click");

		// Token: 0x04024768 RID: 149352
		public static readonly EKey ValveIndex_Right_B_Click = new EKey("ValveIndex_Right_B_Click");

		// Token: 0x04024769 RID: 149353
		public static readonly EKey ValveIndex_Right_A_Touch = new EKey("ValveIndex_Right_A_Touch");

		// Token: 0x0402476A RID: 149354
		public static readonly EKey ValveIndex_Right_B_Touch = new EKey("ValveIndex_Right_B_Touch");

		// Token: 0x0402476B RID: 149355
		public static readonly EKey ValveIndex_Right_System_Click = new EKey("ValveIndex_Right_System_Click");

		// Token: 0x0402476C RID: 149356
		public static readonly EKey ValveIndex_Right_System_Touch = new EKey("ValveIndex_Right_System_Touch");

		// Token: 0x0402476D RID: 149357
		public static readonly EKey ValveIndex_Right_Grip_Axis = new EKey("ValveIndex_Right_Grip_Axis");

		// Token: 0x0402476E RID: 149358
		public static readonly EKey ValveIndex_Right_Grip_Force = new EKey("ValveIndex_Right_Grip_Force");

		// Token: 0x0402476F RID: 149359
		public static readonly EKey ValveIndex_Right_Trigger_Click = new EKey("ValveIndex_Right_Trigger_Click");

		// Token: 0x04024770 RID: 149360
		public static readonly EKey ValveIndex_Right_Trigger_Axis = new EKey("ValveIndex_Right_Trigger_Axis");

		// Token: 0x04024771 RID: 149361
		public static readonly EKey ValveIndex_Right_Trigger_Touch = new EKey("ValveIndex_Right_Trigger_Touch");

		// Token: 0x04024772 RID: 149362
		public static readonly EKey ValveIndex_Right_Thumbstick_X = new EKey("ValveIndex_Right_Thumbstick_X");

		// Token: 0x04024773 RID: 149363
		public static readonly EKey ValveIndex_Right_Thumbstick_Y = new EKey("ValveIndex_Right_Thumbstick_Y");

		// Token: 0x04024774 RID: 149364
		public static readonly EKey ValveIndex_Right_Thumbstick_Click = new EKey("ValveIndex_Right_Thumbstick_Click");

		// Token: 0x04024775 RID: 149365
		public static readonly EKey ValveIndex_Right_Thumbstick_Touch = new EKey("ValveIndex_Right_Thumbstick_Touch");

		// Token: 0x04024776 RID: 149366
		public static readonly EKey ValveIndex_Right_Thumbstick_Up = new EKey("ValveIndex_Right_Thumbstick_Up");

		// Token: 0x04024777 RID: 149367
		public static readonly EKey ValveIndex_Right_Thumbstick_Down = new EKey("ValveIndex_Right_Thumbstick_Down");

		// Token: 0x04024778 RID: 149368
		public static readonly EKey ValveIndex_Right_Thumbstick_Left = new EKey("ValveIndex_Right_Thumbstick_Left");

		// Token: 0x04024779 RID: 149369
		public static readonly EKey ValveIndex_Right_Thumbstick_Right = new EKey("ValveIndex_Right_Thumbstick_Right");

		// Token: 0x0402477A RID: 149370
		public static readonly EKey ValveIndex_Right_Trackpad_X = new EKey("ValveIndex_Right_Trackpad_X");

		// Token: 0x0402477B RID: 149371
		public static readonly EKey ValveIndex_Right_Trackpad_Y = new EKey("ValveIndex_Right_Trackpad_Y");

		// Token: 0x0402477C RID: 149372
		public static readonly EKey ValveIndex_Right_Trackpad_Force = new EKey("ValveIndex_Right_Trackpad_Force");

		// Token: 0x0402477D RID: 149373
		public static readonly EKey ValveIndex_Right_Trackpad_Touch = new EKey("ValveIndex_Right_Trackpad_Touch");

		// Token: 0x0402477E RID: 149374
		public static readonly EKey ValveIndex_Right_Trackpad_Up = new EKey("ValveIndex_Right_Trackpad_Up");

		// Token: 0x0402477F RID: 149375
		public static readonly EKey ValveIndex_Right_Trackpad_Down = new EKey("ValveIndex_Right_Trackpad_Down");

		// Token: 0x04024780 RID: 149376
		public static readonly EKey ValveIndex_Right_Trackpad_Left = new EKey("ValveIndex_Right_Trackpad_Left");

		// Token: 0x04024781 RID: 149377
		public static readonly EKey ValveIndex_Right_Trackpad_Right = new EKey("ValveIndex_Right_Trackpad_Right");

		// Token: 0x04024782 RID: 149378
		public static readonly EKey Virtual_Accept = new EKey("Virtual_Accept");

		// Token: 0x04024783 RID: 149379
		public static readonly EKey Virtual_Back = new EKey("Virtual_Back");

		// Token: 0x04024784 RID: 149380
		public static readonly EKey GenericUSBController_Button1 = new EKey("GenericUSBController_Button1");

		// Token: 0x04024785 RID: 149381
		public static readonly EKey GenericUSBController_Button2 = new EKey("GenericUSBController_Button2");

		// Token: 0x04024786 RID: 149382
		public static readonly EKey GenericUSBController_Button3 = new EKey("GenericUSBController_Button3");

		// Token: 0x04024787 RID: 149383
		public static readonly EKey GenericUSBController_Button4 = new EKey("GenericUSBController_Button4");

		// Token: 0x04024788 RID: 149384
		public static readonly EKey GenericUSBController_Button5 = new EKey("GenericUSBController_Button5");

		// Token: 0x04024789 RID: 149385
		public static readonly EKey GenericUSBController_Button6 = new EKey("GenericUSBController_Button6");

		// Token: 0x0402478A RID: 149386
		public static readonly EKey GenericUSBController_Button7 = new EKey("GenericUSBController_Button7");

		// Token: 0x0402478B RID: 149387
		public static readonly EKey GenericUSBController_Button8 = new EKey("GenericUSBController_Button8");

		// Token: 0x0402478C RID: 149388
		public static readonly EKey GenericUSBController_Button9 = new EKey("GenericUSBController_Button9");

		// Token: 0x0402478D RID: 149389
		public static readonly EKey GenericUSBController_Button10 = new EKey("GenericUSBController_Button10");

		// Token: 0x0402478E RID: 149390
		public static readonly EKey GenericUSBController_Button11 = new EKey("GenericUSBController_Button11");

		// Token: 0x0402478F RID: 149391
		public static readonly EKey GenericUSBController_Button12 = new EKey("GenericUSBController_Button12");

		// Token: 0x04024790 RID: 149392
		public static readonly EKey GenericUSBController_Button13 = new EKey("GenericUSBController_Button13");

		// Token: 0x04024791 RID: 149393
		public static readonly EKey GenericUSBController_Button14 = new EKey("GenericUSBController_Button14");

		// Token: 0x04024792 RID: 149394
		public static readonly EKey GenericUSBController_Button15 = new EKey("GenericUSBController_Button15");

		// Token: 0x04024793 RID: 149395
		public static readonly EKey GenericUSBController_Button16 = new EKey("GenericUSBController_Button16");

		// Token: 0x04024794 RID: 149396
		public static readonly EKey GenericUSBController_Button17 = new EKey("GenericUSBController_Button17");

		// Token: 0x04024795 RID: 149397
		public static readonly EKey GenericUSBController_Button18 = new EKey("GenericUSBController_Button18");

		// Token: 0x04024796 RID: 149398
		public static readonly EKey GenericUSBController_Button19 = new EKey("GenericUSBController_Button19");

		// Token: 0x04024797 RID: 149399
		public static readonly EKey GenericUSBController_Button20 = new EKey("GenericUSBController_Button20");

		// Token: 0x04024798 RID: 149400
		public static readonly EKey GenericUSBController_Button21 = new EKey("GenericUSBController_Button21");

		// Token: 0x04024799 RID: 149401
		public static readonly EKey GenericUSBController_Button22 = new EKey("GenericUSBController_Button22");

		// Token: 0x0402479A RID: 149402
		public static readonly EKey GenericUSBController_Button23 = new EKey("GenericUSBController_Button23");

		// Token: 0x0402479B RID: 149403
		public static readonly EKey GenericUSBController_Button24 = new EKey("GenericUSBController_Button24");

		// Token: 0x0402479C RID: 149404
		public static readonly EKey GenericUSBController_Button25 = new EKey("GenericUSBController_Button25");

		// Token: 0x0402479D RID: 149405
		public static readonly EKey GenericUSBController_Button26 = new EKey("GenericUSBController_Button26");

		// Token: 0x0402479E RID: 149406
		public static readonly EKey GenericUSBController_Button27 = new EKey("GenericUSBController_Button27");

		// Token: 0x0402479F RID: 149407
		public static readonly EKey GenericUSBController_Button28 = new EKey("GenericUSBController_Button28");

		// Token: 0x040247A0 RID: 149408
		public static readonly EKey GenericUSBController_Button29 = new EKey("GenericUSBController_Button29");

		// Token: 0x040247A1 RID: 149409
		public static readonly EKey GenericUSBController_Button30 = new EKey("GenericUSBController_Button30");

		// Token: 0x040247A2 RID: 149410
		public static readonly EKey GenericUSBController_ButtonInvalid = new EKey("GenericUSBController_ButtonInvalid");

		// Token: 0x040247A3 RID: 149411
		public static readonly EKey GenericUSBController_Axis1 = new EKey("GenericUSBController_Axis1");

		// Token: 0x040247A4 RID: 149412
		public static readonly EKey GenericUSBController_Axis2 = new EKey("GenericUSBController_Axis2");

		// Token: 0x040247A5 RID: 149413
		public static readonly EKey GenericUSBController_Axis3 = new EKey("GenericUSBController_Axis3");

		// Token: 0x040247A6 RID: 149414
		public static readonly EKey GenericUSBController_Axis4 = new EKey("GenericUSBController_Axis4");

		// Token: 0x040247A7 RID: 149415
		public static readonly EKey GenericUSBController_Axis5 = new EKey("GenericUSBController_Axis5");

		// Token: 0x040247A8 RID: 149416
		public static readonly EKey GenericUSBController_Axis6 = new EKey("GenericUSBController_Axis6");

		// Token: 0x040247A9 RID: 149417
		public static readonly EKey GenericUSBController_Axis7 = new EKey("GenericUSBController_Axis7");

		// Token: 0x040247AA RID: 149418
		public static readonly EKey Invalid = new EKey("Invalid");
	}
}
