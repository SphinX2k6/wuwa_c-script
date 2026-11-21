using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200617C RID: 24956
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EKey : IEquatable<EKey>
	{
		// Token: 0x0603BD77 RID: 245111 RVA: 0x010FED61 File Offset: 0x010FCF61
		private EKey(string value)
		{
			this._value = value;
		}

		// Token: 0x0603BD78 RID: 245112 RVA: 0x010FED6A File Offset: 0x010FCF6A
		public bool Equals(EKey other)
		{
			return this._value == other._value;
		}

		// Token: 0x0603BD79 RID: 245113 RVA: 0x010FED80 File Offset: 0x010FCF80
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

		// Token: 0x0603BD7A RID: 245114 RVA: 0x010FEDA5 File Offset: 0x010FCFA5
		public override int GetHashCode()
		{
			if (this._value == null)
			{
				return 0;
			}
			return this._value.GetHashCode();
		}

		// Token: 0x0603BD7B RID: 245115 RVA: 0x010FEDBC File Offset: 0x010FCFBC
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x0603BD7C RID: 245116 RVA: 0x010FEDC4 File Offset: 0x010FCFC4
		public static implicit operator string(EKey key)
		{
			return key.ToString();
		}

		// Token: 0x0603BD7D RID: 245117 RVA: 0x010FEDD3 File Offset: 0x010FCFD3
		public static explicit operator EKey(string value)
		{
			return new EKey(value);
		}

		// Token: 0x0603BD7E RID: 245118 RVA: 0x010FEDDB File Offset: 0x010FCFDB
		public static bool operator ==(EKey left, EKey right)
		{
			return left.Equals(right);
		}

		// Token: 0x0603BD7F RID: 245119 RVA: 0x010FEDE5 File Offset: 0x010FCFE5
		public static bool operator !=(EKey left, EKey right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401F8D7 RID: 129239
		private readonly string _value;

		// Token: 0x0401F8D8 RID: 129240
		public static readonly EKey AnyKey = new EKey("AnyKey");

		// Token: 0x0401F8D9 RID: 129241
		public static readonly EKey MouseX = new EKey("MouseX");

		// Token: 0x0401F8DA RID: 129242
		public static readonly EKey MouseY = new EKey("MouseY");

		// Token: 0x0401F8DB RID: 129243
		public static readonly EKey Mouse2D = new EKey("Mouse2D");

		// Token: 0x0401F8DC RID: 129244
		public static readonly EKey MouseScrollUp = new EKey("MouseScrollUp");

		// Token: 0x0401F8DD RID: 129245
		public static readonly EKey MouseScrollDown = new EKey("MouseScrollDown");

		// Token: 0x0401F8DE RID: 129246
		public static readonly EKey MouseWheelAxis = new EKey("MouseWheelAxis");

		// Token: 0x0401F8DF RID: 129247
		public static readonly EKey LeftMouseButton = new EKey("LeftMouseButton");

		// Token: 0x0401F8E0 RID: 129248
		public static readonly EKey RightMouseButton = new EKey("RightMouseButton");

		// Token: 0x0401F8E1 RID: 129249
		public static readonly EKey MiddleMouseButton = new EKey("MiddleMouseButton");

		// Token: 0x0401F8E2 RID: 129250
		public static readonly EKey ThumbMouseButton = new EKey("ThumbMouseButton");

		// Token: 0x0401F8E3 RID: 129251
		public static readonly EKey ThumbMouseButton2 = new EKey("ThumbMouseButton2");

		// Token: 0x0401F8E4 RID: 129252
		public static readonly EKey BackSpace = new EKey("BackSpace");

		// Token: 0x0401F8E5 RID: 129253
		public static readonly EKey Tab = new EKey("Tab");

		// Token: 0x0401F8E6 RID: 129254
		public static readonly EKey Enter = new EKey("Enter");

		// Token: 0x0401F8E7 RID: 129255
		public static readonly EKey Pause = new EKey("Pause");

		// Token: 0x0401F8E8 RID: 129256
		public static readonly EKey CapsLock = new EKey("CapsLock");

		// Token: 0x0401F8E9 RID: 129257
		public static readonly EKey Escape = new EKey("Escape");

		// Token: 0x0401F8EA RID: 129258
		public static readonly EKey SpaceBar = new EKey("SpaceBar");

		// Token: 0x0401F8EB RID: 129259
		public static readonly EKey PageUp = new EKey("PageUp");

		// Token: 0x0401F8EC RID: 129260
		public static readonly EKey PageDown = new EKey("PageDown");

		// Token: 0x0401F8ED RID: 129261
		public static readonly EKey End = new EKey("End");

		// Token: 0x0401F8EE RID: 129262
		public static readonly EKey Home = new EKey("Home");

		// Token: 0x0401F8EF RID: 129263
		public static readonly EKey Left = new EKey("Left");

		// Token: 0x0401F8F0 RID: 129264
		public static readonly EKey Up = new EKey("Up");

		// Token: 0x0401F8F1 RID: 129265
		public static readonly EKey Right = new EKey("Right");

		// Token: 0x0401F8F2 RID: 129266
		public static readonly EKey Down = new EKey("Down");

		// Token: 0x0401F8F3 RID: 129267
		public static readonly EKey Insert = new EKey("Insert");

		// Token: 0x0401F8F4 RID: 129268
		public static readonly EKey Delete = new EKey("Delete");

		// Token: 0x0401F8F5 RID: 129269
		public static readonly EKey Zero = new EKey("Zero");

		// Token: 0x0401F8F6 RID: 129270
		public static readonly EKey One = new EKey("One");

		// Token: 0x0401F8F7 RID: 129271
		public static readonly EKey Two = new EKey("Two");

		// Token: 0x0401F8F8 RID: 129272
		public static readonly EKey Three = new EKey("Three");

		// Token: 0x0401F8F9 RID: 129273
		public static readonly EKey Four = new EKey("Four");

		// Token: 0x0401F8FA RID: 129274
		public static readonly EKey Five = new EKey("Five");

		// Token: 0x0401F8FB RID: 129275
		public static readonly EKey Six = new EKey("Six");

		// Token: 0x0401F8FC RID: 129276
		public static readonly EKey Seven = new EKey("Seven");

		// Token: 0x0401F8FD RID: 129277
		public static readonly EKey Eight = new EKey("Eight");

		// Token: 0x0401F8FE RID: 129278
		public static readonly EKey Nine = new EKey("Nine");

		// Token: 0x0401F8FF RID: 129279
		public static readonly EKey A = new EKey("A");

		// Token: 0x0401F900 RID: 129280
		public static readonly EKey B = new EKey("B");

		// Token: 0x0401F901 RID: 129281
		public static readonly EKey C = new EKey("C");

		// Token: 0x0401F902 RID: 129282
		public static readonly EKey D = new EKey("D");

		// Token: 0x0401F903 RID: 129283
		public static readonly EKey E = new EKey("E");

		// Token: 0x0401F904 RID: 129284
		public static readonly EKey F = new EKey("F");

		// Token: 0x0401F905 RID: 129285
		public static readonly EKey G = new EKey("G");

		// Token: 0x0401F906 RID: 129286
		public static readonly EKey H = new EKey("H");

		// Token: 0x0401F907 RID: 129287
		public static readonly EKey I = new EKey("I");

		// Token: 0x0401F908 RID: 129288
		public static readonly EKey J = new EKey("J");

		// Token: 0x0401F909 RID: 129289
		public static readonly EKey K = new EKey("K");

		// Token: 0x0401F90A RID: 129290
		public static readonly EKey L = new EKey("L");

		// Token: 0x0401F90B RID: 129291
		public static readonly EKey M = new EKey("M");

		// Token: 0x0401F90C RID: 129292
		public static readonly EKey N = new EKey("N");

		// Token: 0x0401F90D RID: 129293
		public static readonly EKey O = new EKey("O");

		// Token: 0x0401F90E RID: 129294
		public static readonly EKey P = new EKey("P");

		// Token: 0x0401F90F RID: 129295
		public static readonly EKey Q = new EKey("Q");

		// Token: 0x0401F910 RID: 129296
		public static readonly EKey R = new EKey("R");

		// Token: 0x0401F911 RID: 129297
		public static readonly EKey S = new EKey("S");

		// Token: 0x0401F912 RID: 129298
		public static readonly EKey T = new EKey("T");

		// Token: 0x0401F913 RID: 129299
		public static readonly EKey U = new EKey("U");

		// Token: 0x0401F914 RID: 129300
		public static readonly EKey V = new EKey("V");

		// Token: 0x0401F915 RID: 129301
		public static readonly EKey W = new EKey("W");

		// Token: 0x0401F916 RID: 129302
		public static readonly EKey X = new EKey("X");

		// Token: 0x0401F917 RID: 129303
		public static readonly EKey Y = new EKey("Y");

		// Token: 0x0401F918 RID: 129304
		public static readonly EKey Z = new EKey("Z");

		// Token: 0x0401F919 RID: 129305
		public static readonly EKey NumPadZero = new EKey("NumPadZero");

		// Token: 0x0401F91A RID: 129306
		public static readonly EKey NumPadOne = new EKey("NumPadOne");

		// Token: 0x0401F91B RID: 129307
		public static readonly EKey NumPadTwo = new EKey("NumPadTwo");

		// Token: 0x0401F91C RID: 129308
		public static readonly EKey NumPadThree = new EKey("NumPadThree");

		// Token: 0x0401F91D RID: 129309
		public static readonly EKey NumPadFour = new EKey("NumPadFour");

		// Token: 0x0401F91E RID: 129310
		public static readonly EKey NumPadFive = new EKey("NumPadFive");

		// Token: 0x0401F91F RID: 129311
		public static readonly EKey NumPadSix = new EKey("NumPadSix");

		// Token: 0x0401F920 RID: 129312
		public static readonly EKey NumPadSeven = new EKey("NumPadSeven");

		// Token: 0x0401F921 RID: 129313
		public static readonly EKey NumPadEight = new EKey("NumPadEight");

		// Token: 0x0401F922 RID: 129314
		public static readonly EKey NumPadNine = new EKey("NumPadNine");

		// Token: 0x0401F923 RID: 129315
		public static readonly EKey Multiply = new EKey("Multiply");

		// Token: 0x0401F924 RID: 129316
		public static readonly EKey Add = new EKey("Add");

		// Token: 0x0401F925 RID: 129317
		public static readonly EKey Subtract = new EKey("Subtract");

		// Token: 0x0401F926 RID: 129318
		public static readonly EKey Decimal = new EKey("Decimal");

		// Token: 0x0401F927 RID: 129319
		public static readonly EKey Divide = new EKey("Divide");

		// Token: 0x0401F928 RID: 129320
		public static readonly EKey F1 = new EKey("F1");

		// Token: 0x0401F929 RID: 129321
		public static readonly EKey F2 = new EKey("F2");

		// Token: 0x0401F92A RID: 129322
		public static readonly EKey F3 = new EKey("F3");

		// Token: 0x0401F92B RID: 129323
		public static readonly EKey F4 = new EKey("F4");

		// Token: 0x0401F92C RID: 129324
		public static readonly EKey F5 = new EKey("F5");

		// Token: 0x0401F92D RID: 129325
		public static readonly EKey F6 = new EKey("F6");

		// Token: 0x0401F92E RID: 129326
		public static readonly EKey F7 = new EKey("F7");

		// Token: 0x0401F92F RID: 129327
		public static readonly EKey F8 = new EKey("F8");

		// Token: 0x0401F930 RID: 129328
		public static readonly EKey F9 = new EKey("F9");

		// Token: 0x0401F931 RID: 129329
		public static readonly EKey F10 = new EKey("F10");

		// Token: 0x0401F932 RID: 129330
		public static readonly EKey F11 = new EKey("F11");

		// Token: 0x0401F933 RID: 129331
		public static readonly EKey F12 = new EKey("F12");

		// Token: 0x0401F934 RID: 129332
		public static readonly EKey NumLock = new EKey("NumLock");

		// Token: 0x0401F935 RID: 129333
		public static readonly EKey ScrollLock = new EKey("ScrollLock");

		// Token: 0x0401F936 RID: 129334
		public static readonly EKey LeftShift = new EKey("LeftShift");

		// Token: 0x0401F937 RID: 129335
		public static readonly EKey RightShift = new EKey("RightShift");

		// Token: 0x0401F938 RID: 129336
		public static readonly EKey LeftControl = new EKey("LeftControl");

		// Token: 0x0401F939 RID: 129337
		public static readonly EKey RightControl = new EKey("RightControl");

		// Token: 0x0401F93A RID: 129338
		public static readonly EKey LeftAlt = new EKey("LeftAlt");

		// Token: 0x0401F93B RID: 129339
		public static readonly EKey RightAlt = new EKey("RightAlt");

		// Token: 0x0401F93C RID: 129340
		public static readonly EKey LeftCommand = new EKey("LeftCommand");

		// Token: 0x0401F93D RID: 129341
		public static readonly EKey RightCommand = new EKey("RightCommand");

		// Token: 0x0401F93E RID: 129342
		public static readonly EKey Semicolon = new EKey("Semicolon");

		// Token: 0x0401F93F RID: 129343
		public static readonly EKey EqualsKey = new EKey("Equals");

		// Token: 0x0401F940 RID: 129344
		public static readonly EKey Comma = new EKey("Comma");

		// Token: 0x0401F941 RID: 129345
		public static readonly EKey Underscore = new EKey("Underscore");

		// Token: 0x0401F942 RID: 129346
		public static readonly EKey Hyphen = new EKey("Hyphen");

		// Token: 0x0401F943 RID: 129347
		public static readonly EKey Period = new EKey("Period");

		// Token: 0x0401F944 RID: 129348
		public static readonly EKey Slash = new EKey("Slash");

		// Token: 0x0401F945 RID: 129349
		public static readonly EKey Tilde = new EKey("Tilde");

		// Token: 0x0401F946 RID: 129350
		public static readonly EKey LeftBracket = new EKey("LeftBracket");

		// Token: 0x0401F947 RID: 129351
		public static readonly EKey Backslash = new EKey("Backslash");

		// Token: 0x0401F948 RID: 129352
		public static readonly EKey RightBracket = new EKey("RightBracket");

		// Token: 0x0401F949 RID: 129353
		public static readonly EKey Apostrophe = new EKey("Apostrophe");

		// Token: 0x0401F94A RID: 129354
		public static readonly EKey Ampersand = new EKey("Ampersand");

		// Token: 0x0401F94B RID: 129355
		public static readonly EKey Asterix = new EKey("Asterix");

		// Token: 0x0401F94C RID: 129356
		public static readonly EKey Caret = new EKey("Caret");

		// Token: 0x0401F94D RID: 129357
		public static readonly EKey Colon = new EKey("Colon");

		// Token: 0x0401F94E RID: 129358
		public static readonly EKey Dollar = new EKey("Dollar");

		// Token: 0x0401F94F RID: 129359
		public static readonly EKey Exclamation = new EKey("Exclamation");

		// Token: 0x0401F950 RID: 129360
		public static readonly EKey LeftParantheses = new EKey("LeftParantheses");

		// Token: 0x0401F951 RID: 129361
		public static readonly EKey RightParantheses = new EKey("RightParantheses");

		// Token: 0x0401F952 RID: 129362
		public static readonly EKey Quote = new EKey("Quote");

		// Token: 0x0401F953 RID: 129363
		public static readonly EKey A_AccentGrave = new EKey("A_AccentGrave");

		// Token: 0x0401F954 RID: 129364
		public static readonly EKey E_AccentGrave = new EKey("E_AccentGrave");

		// Token: 0x0401F955 RID: 129365
		public static readonly EKey E_AccentAigu = new EKey("E_AccentAigu");

		// Token: 0x0401F956 RID: 129366
		public static readonly EKey C_Cedille = new EKey("C_Cedille");

		// Token: 0x0401F957 RID: 129367
		public static readonly EKey Section = new EKey("Section");

		// Token: 0x0401F958 RID: 129368
		public static readonly EKey Keyboard_Invalid = new EKey("Keyboard_Invalid");

		// Token: 0x0401F959 RID: 129369
		public static readonly EKey Platform_Delete = new EKey("Platform_Delete");

		// Token: 0x0401F95A RID: 129370
		public static readonly EKey Gamepad_Left2D = new EKey("Gamepad_Left2D");

		// Token: 0x0401F95B RID: 129371
		public static readonly EKey Gamepad_LeftX = new EKey("Gamepad_LeftX");

		// Token: 0x0401F95C RID: 129372
		public static readonly EKey Gamepad_LeftY = new EKey("Gamepad_LeftY");

		// Token: 0x0401F95D RID: 129373
		public static readonly EKey Gamepad_Right2D = new EKey("Gamepad_Right2D");

		// Token: 0x0401F95E RID: 129374
		public static readonly EKey Gamepad_RightX = new EKey("Gamepad_RightX");

		// Token: 0x0401F95F RID: 129375
		public static readonly EKey Gamepad_RightY = new EKey("Gamepad_RightY");

		// Token: 0x0401F960 RID: 129376
		public static readonly EKey Gamepad_LeftTriggerAxis = new EKey("Gamepad_LeftTriggerAxis");

		// Token: 0x0401F961 RID: 129377
		public static readonly EKey Gamepad_RightTriggerAxis = new EKey("Gamepad_RightTriggerAxis");

		// Token: 0x0401F962 RID: 129378
		public static readonly EKey Gamepad_LeftThumbstick = new EKey("Gamepad_LeftThumbstick");

		// Token: 0x0401F963 RID: 129379
		public static readonly EKey Gamepad_RightThumbstick = new EKey("Gamepad_RightThumbstick");

		// Token: 0x0401F964 RID: 129380
		public static readonly EKey Gamepad_Special_Left = new EKey("Gamepad_Special_Left");

		// Token: 0x0401F965 RID: 129381
		public static readonly EKey Gamepad_Special_Left_X = new EKey("Gamepad_Special_Left_X");

		// Token: 0x0401F966 RID: 129382
		public static readonly EKey Gamepad_Special_Left_Y = new EKey("Gamepad_Special_Left_Y");

		// Token: 0x0401F967 RID: 129383
		public static readonly EKey Gamepad_Special_Right = new EKey("Gamepad_Special_Right");

		// Token: 0x0401F968 RID: 129384
		public static readonly EKey Gamepad_FaceButton_Bottom = new EKey("Gamepad_FaceButton_Bottom");

		// Token: 0x0401F969 RID: 129385
		public static readonly EKey Gamepad_FaceButton_Right = new EKey("Gamepad_FaceButton_Right");

		// Token: 0x0401F96A RID: 129386
		public static readonly EKey Gamepad_FaceButton_Left = new EKey("Gamepad_FaceButton_Left");

		// Token: 0x0401F96B RID: 129387
		public static readonly EKey Gamepad_FaceButton_Top = new EKey("Gamepad_FaceButton_Top");

		// Token: 0x0401F96C RID: 129388
		public static readonly EKey Gamepad_LeftShoulder = new EKey("Gamepad_LeftShoulder");

		// Token: 0x0401F96D RID: 129389
		public static readonly EKey Gamepad_RightShoulder = new EKey("Gamepad_RightShoulder");

		// Token: 0x0401F96E RID: 129390
		public static readonly EKey Gamepad_LeftTrigger = new EKey("Gamepad_LeftTrigger");

		// Token: 0x0401F96F RID: 129391
		public static readonly EKey Gamepad_RightTrigger = new EKey("Gamepad_RightTrigger");

		// Token: 0x0401F970 RID: 129392
		public static readonly EKey Gamepad_DPad_Up = new EKey("Gamepad_DPad_Up");

		// Token: 0x0401F971 RID: 129393
		public static readonly EKey Gamepad_DPad_Down = new EKey("Gamepad_DPad_Down");

		// Token: 0x0401F972 RID: 129394
		public static readonly EKey Gamepad_DPad_Right = new EKey("Gamepad_DPad_Right");

		// Token: 0x0401F973 RID: 129395
		public static readonly EKey Gamepad_DPad_Left = new EKey("Gamepad_DPad_Left");

		// Token: 0x0401F974 RID: 129396
		public static readonly EKey Gamepad_LeftStick_Up = new EKey("Gamepad_LeftStick_Up");

		// Token: 0x0401F975 RID: 129397
		public static readonly EKey Gamepad_LeftStick_Down = new EKey("Gamepad_LeftStick_Down");

		// Token: 0x0401F976 RID: 129398
		public static readonly EKey Gamepad_LeftStick_Right = new EKey("Gamepad_LeftStick_Right");

		// Token: 0x0401F977 RID: 129399
		public static readonly EKey Gamepad_LeftStick_Left = new EKey("Gamepad_LeftStick_Left");

		// Token: 0x0401F978 RID: 129400
		public static readonly EKey Gamepad_RightStick_Up = new EKey("Gamepad_RightStick_Up");

		// Token: 0x0401F979 RID: 129401
		public static readonly EKey Gamepad_RightStick_Down = new EKey("Gamepad_RightStick_Down");

		// Token: 0x0401F97A RID: 129402
		public static readonly EKey Gamepad_RightStick_Right = new EKey("Gamepad_RightStick_Right");

		// Token: 0x0401F97B RID: 129403
		public static readonly EKey Gamepad_RightStick_Left = new EKey("Gamepad_RightStick_Left");

		// Token: 0x0401F97C RID: 129404
		public static readonly EKey Gamepad_Invalid = new EKey("Gamepad_Invalid");

		// Token: 0x0401F97D RID: 129405
		public static readonly EKey Tilt = new EKey("Tilt");

		// Token: 0x0401F97E RID: 129406
		public static readonly EKey RotationRate = new EKey("RotationRate");

		// Token: 0x0401F97F RID: 129407
		public static readonly EKey Gravity = new EKey("Gravity");

		// Token: 0x0401F980 RID: 129408
		public static readonly EKey Acceleration = new EKey("Acceleration");

		// Token: 0x0401F981 RID: 129409
		public static readonly EKey Gesture_Pinch = new EKey("Gesture_Pinch");

		// Token: 0x0401F982 RID: 129410
		public static readonly EKey Gesture_Flick = new EKey("Gesture_Flick");

		// Token: 0x0401F983 RID: 129411
		public static readonly EKey Gesture_Rotate = new EKey("Gesture_Rotate");

		// Token: 0x0401F984 RID: 129412
		public static readonly EKey PS4_Special = new EKey("PS4_Special");

		// Token: 0x0401F985 RID: 129413
		public static readonly EKey Steam_Touch_0 = new EKey("Steam_Touch_0");

		// Token: 0x0401F986 RID: 129414
		public static readonly EKey Steam_Touch_1 = new EKey("Steam_Touch_1");

		// Token: 0x0401F987 RID: 129415
		public static readonly EKey Steam_Touch_2 = new EKey("Steam_Touch_2");

		// Token: 0x0401F988 RID: 129416
		public static readonly EKey Steam_Touch_3 = new EKey("Steam_Touch_3");

		// Token: 0x0401F989 RID: 129417
		public static readonly EKey Steam_Back_Left = new EKey("Steam_Back_Left");

		// Token: 0x0401F98A RID: 129418
		public static readonly EKey Steam_Back_Right = new EKey("Steam_Back_Right");

		// Token: 0x0401F98B RID: 129419
		public static readonly EKey Global_Menu = new EKey("Global_Menu");

		// Token: 0x0401F98C RID: 129420
		public static readonly EKey Global_View = new EKey("Global_View");

		// Token: 0x0401F98D RID: 129421
		public static readonly EKey Global_Pause = new EKey("Global_Pause");

		// Token: 0x0401F98E RID: 129422
		public static readonly EKey Global_Play = new EKey("Global_Play");

		// Token: 0x0401F98F RID: 129423
		public static readonly EKey Global_Back = new EKey("Global_Back");

		// Token: 0x0401F990 RID: 129424
		public static readonly EKey Android_Back = new EKey("Android_Back");

		// Token: 0x0401F991 RID: 129425
		public static readonly EKey Android_Volume_Up = new EKey("Android_Volume_Up");

		// Token: 0x0401F992 RID: 129426
		public static readonly EKey Android_Volume_Down = new EKey("Android_Volume_Down");

		// Token: 0x0401F993 RID: 129427
		public static readonly EKey Android_Menu = new EKey("Android_Menu");

		// Token: 0x0401F994 RID: 129428
		public static readonly EKey Daydream_Left_Select_Click = new EKey("Daydream_Left_Select_Click");

		// Token: 0x0401F995 RID: 129429
		public static readonly EKey Daydream_Left_Trackpad_X = new EKey("Daydream_Left_Trackpad_X");

		// Token: 0x0401F996 RID: 129430
		public static readonly EKey Daydream_Left_Trackpad_Y = new EKey("Daydream_Left_Trackpad_Y");

		// Token: 0x0401F997 RID: 129431
		public static readonly EKey Daydream_Left_Trackpad_Click = new EKey("Daydream_Left_Trackpad_Click");

		// Token: 0x0401F998 RID: 129432
		public static readonly EKey Daydream_Left_Trackpad_Touch = new EKey("Daydream_Left_Trackpad_Touch");

		// Token: 0x0401F999 RID: 129433
		public static readonly EKey Daydream_Right_Select_Click = new EKey("Daydream_Right_Select_Click");

		// Token: 0x0401F99A RID: 129434
		public static readonly EKey Daydream_Right_Trackpad_X = new EKey("Daydream_Right_Trackpad_X");

		// Token: 0x0401F99B RID: 129435
		public static readonly EKey Daydream_Right_Trackpad_Y = new EKey("Daydream_Right_Trackpad_Y");

		// Token: 0x0401F99C RID: 129436
		public static readonly EKey Daydream_Right_Trackpad_Click = new EKey("Daydream_Right_Trackpad_Click");

		// Token: 0x0401F99D RID: 129437
		public static readonly EKey Daydream_Right_Trackpad_Touch = new EKey("Daydream_Right_Trackpad_Touch");

		// Token: 0x0401F99E RID: 129438
		public static readonly EKey Vive_Left_System_Click = new EKey("Vive_Left_System_Click");

		// Token: 0x0401F99F RID: 129439
		public static readonly EKey Vive_Left_Grip_Click = new EKey("Vive_Left_Grip_Click");

		// Token: 0x0401F9A0 RID: 129440
		public static readonly EKey Vive_Left_Menu_Click = new EKey("Vive_Left_Menu_Click");

		// Token: 0x0401F9A1 RID: 129441
		public static readonly EKey Vive_Left_Trigger_Click = new EKey("Vive_Left_Trigger_Click");

		// Token: 0x0401F9A2 RID: 129442
		public static readonly EKey Vive_Left_Trigger_Axis = new EKey("Vive_Left_Trigger_Axis");

		// Token: 0x0401F9A3 RID: 129443
		public static readonly EKey Vive_Left_Trackpad_X = new EKey("Vive_Left_Trackpad_X");

		// Token: 0x0401F9A4 RID: 129444
		public static readonly EKey Vive_Left_Trackpad_Y = new EKey("Vive_Left_Trackpad_Y");

		// Token: 0x0401F9A5 RID: 129445
		public static readonly EKey Vive_Left_Trackpad_Click = new EKey("Vive_Left_Trackpad_Click");

		// Token: 0x0401F9A6 RID: 129446
		public static readonly EKey Vive_Left_Trackpad_Touch = new EKey("Vive_Left_Trackpad_Touch");

		// Token: 0x0401F9A7 RID: 129447
		public static readonly EKey Vive_Left_Trackpad_Up = new EKey("Vive_Left_Trackpad_Up");

		// Token: 0x0401F9A8 RID: 129448
		public static readonly EKey Vive_Left_Trackpad_Down = new EKey("Vive_Left_Trackpad_Down");

		// Token: 0x0401F9A9 RID: 129449
		public static readonly EKey Vive_Left_Trackpad_Left = new EKey("Vive_Left_Trackpad_Left");

		// Token: 0x0401F9AA RID: 129450
		public static readonly EKey Vive_Left_Trackpad_Right = new EKey("Vive_Left_Trackpad_Right");

		// Token: 0x0401F9AB RID: 129451
		public static readonly EKey Vive_Right_System_Click = new EKey("Vive_Right_System_Click");

		// Token: 0x0401F9AC RID: 129452
		public static readonly EKey Vive_Right_Grip_Click = new EKey("Vive_Right_Grip_Click");

		// Token: 0x0401F9AD RID: 129453
		public static readonly EKey Vive_Right_Menu_Click = new EKey("Vive_Right_Menu_Click");

		// Token: 0x0401F9AE RID: 129454
		public static readonly EKey Vive_Right_Trigger_Click = new EKey("Vive_Right_Trigger_Click");

		// Token: 0x0401F9AF RID: 129455
		public static readonly EKey Vive_Right_Trigger_Axis = new EKey("Vive_Right_Trigger_Axis");

		// Token: 0x0401F9B0 RID: 129456
		public static readonly EKey Vive_Right_Trackpad_X = new EKey("Vive_Right_Trackpad_X");

		// Token: 0x0401F9B1 RID: 129457
		public static readonly EKey Vive_Right_Trackpad_Y = new EKey("Vive_Right_Trackpad_Y");

		// Token: 0x0401F9B2 RID: 129458
		public static readonly EKey Vive_Right_Trackpad_Click = new EKey("Vive_Right_Trackpad_Click");

		// Token: 0x0401F9B3 RID: 129459
		public static readonly EKey Vive_Right_Trackpad_Touch = new EKey("Vive_Right_Trackpad_Touch");

		// Token: 0x0401F9B4 RID: 129460
		public static readonly EKey Vive_Right_Trackpad_Up = new EKey("Vive_Right_Trackpad_Up");

		// Token: 0x0401F9B5 RID: 129461
		public static readonly EKey Vive_Right_Trackpad_Down = new EKey("Vive_Right_Trackpad_Down");

		// Token: 0x0401F9B6 RID: 129462
		public static readonly EKey Vive_Right_Trackpad_Left = new EKey("Vive_Right_Trackpad_Left");

		// Token: 0x0401F9B7 RID: 129463
		public static readonly EKey Vive_Right_Trackpad_Right = new EKey("Vive_Right_Trackpad_Right");

		// Token: 0x0401F9B8 RID: 129464
		public static readonly EKey MixedReality_Left_Menu_Click = new EKey("MixedReality_Left_Menu_Click");

		// Token: 0x0401F9B9 RID: 129465
		public static readonly EKey MixedReality_Left_Grip_Click = new EKey("MixedReality_Left_Grip_Click");

		// Token: 0x0401F9BA RID: 129466
		public static readonly EKey MixedReality_Left_Trigger_Click = new EKey("MixedReality_Left_Trigger_Click");

		// Token: 0x0401F9BB RID: 129467
		public static readonly EKey MixedReality_Left_Trigger_Axis = new EKey("MixedReality_Left_Trigger_Axis");

		// Token: 0x0401F9BC RID: 129468
		public static readonly EKey MixedReality_Left_Thumbstick_X = new EKey("MixedReality_Left_Thumbstick_X");

		// Token: 0x0401F9BD RID: 129469
		public static readonly EKey MixedReality_Left_Thumbstick_Y = new EKey("MixedReality_Left_Thumbstick_Y");

		// Token: 0x0401F9BE RID: 129470
		public static readonly EKey MixedReality_Left_Thumbstick_Click = new EKey("MixedReality_Left_Thumbstick_Click");

		// Token: 0x0401F9BF RID: 129471
		public static readonly EKey MixedReality_Left_Thumbstick_Up = new EKey("MixedReality_Left_Thumbstick_Up");

		// Token: 0x0401F9C0 RID: 129472
		public static readonly EKey MixedReality_Left_Thumbstick_Down = new EKey("MixedReality_Left_Thumbstick_Down");

		// Token: 0x0401F9C1 RID: 129473
		public static readonly EKey MixedReality_Left_Thumbstick_Left = new EKey("MixedReality_Left_Thumbstick_Left");

		// Token: 0x0401F9C2 RID: 129474
		public static readonly EKey MixedReality_Left_Thumbstick_Right = new EKey("MixedReality_Left_Thumbstick_Right");

		// Token: 0x0401F9C3 RID: 129475
		public static readonly EKey MixedReality_Left_Trackpad_X = new EKey("MixedReality_Left_Trackpad_X");

		// Token: 0x0401F9C4 RID: 129476
		public static readonly EKey MixedReality_Left_Trackpad_Y = new EKey("MixedReality_Left_Trackpad_Y");

		// Token: 0x0401F9C5 RID: 129477
		public static readonly EKey MixedReality_Left_Trackpad_Click = new EKey("MixedReality_Left_Trackpad_Click");

		// Token: 0x0401F9C6 RID: 129478
		public static readonly EKey MixedReality_Left_Trackpad_Touch = new EKey("MixedReality_Left_Trackpad_Touch");

		// Token: 0x0401F9C7 RID: 129479
		public static readonly EKey MixedReality_Left_Trackpad_Up = new EKey("MixedReality_Left_Trackpad_Up");

		// Token: 0x0401F9C8 RID: 129480
		public static readonly EKey MixedReality_Left_Trackpad_Down = new EKey("MixedReality_Left_Trackpad_Down");

		// Token: 0x0401F9C9 RID: 129481
		public static readonly EKey MixedReality_Left_Trackpad_Left = new EKey("MixedReality_Left_Trackpad_Left");

		// Token: 0x0401F9CA RID: 129482
		public static readonly EKey MixedReality_Left_Trackpad_Right = new EKey("MixedReality_Left_Trackpad_Right");

		// Token: 0x0401F9CB RID: 129483
		public static readonly EKey MixedReality_Right_Menu_Click = new EKey("MixedReality_Right_Menu_Click");

		// Token: 0x0401F9CC RID: 129484
		public static readonly EKey MixedReality_Right_Grip_Click = new EKey("MixedReality_Right_Grip_Click");

		// Token: 0x0401F9CD RID: 129485
		public static readonly EKey MixedReality_Right_Trigger_Click = new EKey("MixedReality_Right_Trigger_Click");

		// Token: 0x0401F9CE RID: 129486
		public static readonly EKey MixedReality_Right_Trigger_Axis = new EKey("MixedReality_Right_Trigger_Axis");

		// Token: 0x0401F9CF RID: 129487
		public static readonly EKey MixedReality_Right_Thumbstick_X = new EKey("MixedReality_Right_Thumbstick_X");

		// Token: 0x0401F9D0 RID: 129488
		public static readonly EKey MixedReality_Right_Thumbstick_Y = new EKey("MixedReality_Right_Thumbstick_Y");

		// Token: 0x0401F9D1 RID: 129489
		public static readonly EKey MixedReality_Right_Thumbstick_Click = new EKey("MixedReality_Right_Thumbstick_Click");

		// Token: 0x0401F9D2 RID: 129490
		public static readonly EKey MixedReality_Right_Thumbstick_Up = new EKey("MixedReality_Right_Thumbstick_Up");

		// Token: 0x0401F9D3 RID: 129491
		public static readonly EKey MixedReality_Right_Thumbstick_Down = new EKey("MixedReality_Right_Thumbstick_Down");

		// Token: 0x0401F9D4 RID: 129492
		public static readonly EKey MixedReality_Right_Thumbstick_Left = new EKey("MixedReality_Right_Thumbstick_Left");

		// Token: 0x0401F9D5 RID: 129493
		public static readonly EKey MixedReality_Right_Thumbstick_Right = new EKey("MixedReality_Right_Thumbstick_Right");

		// Token: 0x0401F9D6 RID: 129494
		public static readonly EKey MixedReality_Right_Trackpad_X = new EKey("MixedReality_Right_Trackpad_X");

		// Token: 0x0401F9D7 RID: 129495
		public static readonly EKey MixedReality_Right_Trackpad_Y = new EKey("MixedReality_Right_Trackpad_Y");

		// Token: 0x0401F9D8 RID: 129496
		public static readonly EKey MixedReality_Right_Trackpad_Click = new EKey("MixedReality_Right_Trackpad_Click");

		// Token: 0x0401F9D9 RID: 129497
		public static readonly EKey MixedReality_Right_Trackpad_Touch = new EKey("MixedReality_Right_Trackpad_Touch");

		// Token: 0x0401F9DA RID: 129498
		public static readonly EKey MixedReality_Right_Trackpad_Up = new EKey("MixedReality_Right_Trackpad_Up");

		// Token: 0x0401F9DB RID: 129499
		public static readonly EKey MixedReality_Right_Trackpad_Down = new EKey("MixedReality_Right_Trackpad_Down");

		// Token: 0x0401F9DC RID: 129500
		public static readonly EKey MixedReality_Right_Trackpad_Left = new EKey("MixedReality_Right_Trackpad_Left");

		// Token: 0x0401F9DD RID: 129501
		public static readonly EKey MixedReality_Right_Trackpad_Right = new EKey("MixedReality_Right_Trackpad_Right");

		// Token: 0x0401F9DE RID: 129502
		public static readonly EKey OculusTouch_Left_X_Click = new EKey("OculusTouch_Left_X_Click");

		// Token: 0x0401F9DF RID: 129503
		public static readonly EKey OculusTouch_Left_Y_Click = new EKey("OculusTouch_Left_Y_Click");

		// Token: 0x0401F9E0 RID: 129504
		public static readonly EKey OculusTouch_Left_X_Touch = new EKey("OculusTouch_Left_X_Touch");

		// Token: 0x0401F9E1 RID: 129505
		public static readonly EKey OculusTouch_Left_Y_Touch = new EKey("OculusTouch_Left_Y_Touch");

		// Token: 0x0401F9E2 RID: 129506
		public static readonly EKey OculusTouch_Left_Menu_Click = new EKey("OculusTouch_Left_Menu_Click");

		// Token: 0x0401F9E3 RID: 129507
		public static readonly EKey OculusTouch_Left_Grip_Click = new EKey("OculusTouch_Left_Grip_Click");

		// Token: 0x0401F9E4 RID: 129508
		public static readonly EKey OculusTouch_Left_Grip_Axis = new EKey("OculusTouch_Left_Grip_Axis");

		// Token: 0x0401F9E5 RID: 129509
		public static readonly EKey OculusTouch_Left_Trigger_Click = new EKey("OculusTouch_Left_Trigger_Click");

		// Token: 0x0401F9E6 RID: 129510
		public static readonly EKey OculusTouch_Left_Trigger_Axis = new EKey("OculusTouch_Left_Trigger_Axis");

		// Token: 0x0401F9E7 RID: 129511
		public static readonly EKey OculusTouch_Left_Trigger_Touch = new EKey("OculusTouch_Left_Trigger_Touch");

		// Token: 0x0401F9E8 RID: 129512
		public static readonly EKey OculusTouch_Left_Thumbstick_X = new EKey("OculusTouch_Left_Thumbstick_X");

		// Token: 0x0401F9E9 RID: 129513
		public static readonly EKey OculusTouch_Left_Thumbstick_Y = new EKey("OculusTouch_Left_Thumbstick_Y");

		// Token: 0x0401F9EA RID: 129514
		public static readonly EKey OculusTouch_Left_Thumbstick_Click = new EKey("OculusTouch_Left_Thumbstick_Click");

		// Token: 0x0401F9EB RID: 129515
		public static readonly EKey OculusTouch_Left_Thumbstick_Touch = new EKey("OculusTouch_Left_Thumbstick_Touch");

		// Token: 0x0401F9EC RID: 129516
		public static readonly EKey OculusTouch_Left_Thumbstick_Up = new EKey("OculusTouch_Left_Thumbstick_Up");

		// Token: 0x0401F9ED RID: 129517
		public static readonly EKey OculusTouch_Left_Thumbstick_Down = new EKey("OculusTouch_Left_Thumbstick_Down");

		// Token: 0x0401F9EE RID: 129518
		public static readonly EKey OculusTouch_Left_Thumbstick_Left = new EKey("OculusTouch_Left_Thumbstick_Left");

		// Token: 0x0401F9EF RID: 129519
		public static readonly EKey OculusTouch_Left_Thumbstick_Right = new EKey("OculusTouch_Left_Thumbstick_Right");

		// Token: 0x0401F9F0 RID: 129520
		public static readonly EKey OculusTouch_Right_A_Click = new EKey("OculusTouch_Right_A_Click");

		// Token: 0x0401F9F1 RID: 129521
		public static readonly EKey OculusTouch_Right_B_Click = new EKey("OculusTouch_Right_B_Click");

		// Token: 0x0401F9F2 RID: 129522
		public static readonly EKey OculusTouch_Right_A_Touch = new EKey("OculusTouch_Right_A_Touch");

		// Token: 0x0401F9F3 RID: 129523
		public static readonly EKey OculusTouch_Right_B_Touch = new EKey("OculusTouch_Right_B_Touch");

		// Token: 0x0401F9F4 RID: 129524
		public static readonly EKey OculusTouch_Right_System_Click = new EKey("OculusTouch_Right_System_Click");

		// Token: 0x0401F9F5 RID: 129525
		public static readonly EKey OculusTouch_Right_Grip_Click = new EKey("OculusTouch_Right_Grip_Click");

		// Token: 0x0401F9F6 RID: 129526
		public static readonly EKey OculusTouch_Right_Grip_Axis = new EKey("OculusTouch_Right_Grip_Axis");

		// Token: 0x0401F9F7 RID: 129527
		public static readonly EKey OculusTouch_Right_Trigger_Click = new EKey("OculusTouch_Right_Trigger_Click");

		// Token: 0x0401F9F8 RID: 129528
		public static readonly EKey OculusTouch_Right_Trigger_Axis = new EKey("OculusTouch_Right_Trigger_Axis");

		// Token: 0x0401F9F9 RID: 129529
		public static readonly EKey OculusTouch_Right_Trigger_Touch = new EKey("OculusTouch_Right_Trigger_Touch");

		// Token: 0x0401F9FA RID: 129530
		public static readonly EKey OculusTouch_Right_Thumbstick_X = new EKey("OculusTouch_Right_Thumbstick_X");

		// Token: 0x0401F9FB RID: 129531
		public static readonly EKey OculusTouch_Right_Thumbstick_Y = new EKey("OculusTouch_Right_Thumbstick_Y");

		// Token: 0x0401F9FC RID: 129532
		public static readonly EKey OculusTouch_Right_Thumbstick_Click = new EKey("OculusTouch_Right_Thumbstick_Click");

		// Token: 0x0401F9FD RID: 129533
		public static readonly EKey OculusTouch_Right_Thumbstick_Touch = new EKey("OculusTouch_Right_Thumbstick_Touch");

		// Token: 0x0401F9FE RID: 129534
		public static readonly EKey OculusTouch_Right_Thumbstick_Up = new EKey("OculusTouch_Right_Thumbstick_Up");

		// Token: 0x0401F9FF RID: 129535
		public static readonly EKey OculusTouch_Right_Thumbstick_Down = new EKey("OculusTouch_Right_Thumbstick_Down");

		// Token: 0x0401FA00 RID: 129536
		public static readonly EKey OculusTouch_Right_Thumbstick_Left = new EKey("OculusTouch_Right_Thumbstick_Left");

		// Token: 0x0401FA01 RID: 129537
		public static readonly EKey OculusTouch_Right_Thumbstick_Right = new EKey("OculusTouch_Right_Thumbstick_Right");

		// Token: 0x0401FA02 RID: 129538
		public static readonly EKey ValveIndex_Left_A_Click = new EKey("ValveIndex_Left_A_Click");

		// Token: 0x0401FA03 RID: 129539
		public static readonly EKey ValveIndex_Left_B_Click = new EKey("ValveIndex_Left_B_Click");

		// Token: 0x0401FA04 RID: 129540
		public static readonly EKey ValveIndex_Left_A_Touch = new EKey("ValveIndex_Left_A_Touch");

		// Token: 0x0401FA05 RID: 129541
		public static readonly EKey ValveIndex_Left_B_Touch = new EKey("ValveIndex_Left_B_Touch");

		// Token: 0x0401FA06 RID: 129542
		public static readonly EKey ValveIndex_Left_System_Click = new EKey("ValveIndex_Left_System_Click");

		// Token: 0x0401FA07 RID: 129543
		public static readonly EKey ValveIndex_Left_System_Touch = new EKey("ValveIndex_Left_System_Touch");

		// Token: 0x0401FA08 RID: 129544
		public static readonly EKey ValveIndex_Left_Grip_Axis = new EKey("ValveIndex_Left_Grip_Axis");

		// Token: 0x0401FA09 RID: 129545
		public static readonly EKey ValveIndex_Left_Grip_Force = new EKey("ValveIndex_Left_Grip_Force");

		// Token: 0x0401FA0A RID: 129546
		public static readonly EKey ValveIndex_Left_Trigger_Click = new EKey("ValveIndex_Left_Trigger_Click");

		// Token: 0x0401FA0B RID: 129547
		public static readonly EKey ValveIndex_Left_Trigger_Axis = new EKey("ValveIndex_Left_Trigger_Axis");

		// Token: 0x0401FA0C RID: 129548
		public static readonly EKey ValveIndex_Left_Trigger_Touch = new EKey("ValveIndex_Left_Trigger_Touch");

		// Token: 0x0401FA0D RID: 129549
		public static readonly EKey ValveIndex_Left_Thumbstick_X = new EKey("ValveIndex_Left_Thumbstick_X");

		// Token: 0x0401FA0E RID: 129550
		public static readonly EKey ValveIndex_Left_Thumbstick_Y = new EKey("ValveIndex_Left_Thumbstick_Y");

		// Token: 0x0401FA0F RID: 129551
		public static readonly EKey ValveIndex_Left_Thumbstick_Click = new EKey("ValveIndex_Left_Thumbstick_Click");

		// Token: 0x0401FA10 RID: 129552
		public static readonly EKey ValveIndex_Left_Thumbstick_Touch = new EKey("ValveIndex_Left_Thumbstick_Touch");

		// Token: 0x0401FA11 RID: 129553
		public static readonly EKey ValveIndex_Left_Thumbstick_Up = new EKey("ValveIndex_Left_Thumbstick_Up");

		// Token: 0x0401FA12 RID: 129554
		public static readonly EKey ValveIndex_Left_Thumbstick_Down = new EKey("ValveIndex_Left_Thumbstick_Down");

		// Token: 0x0401FA13 RID: 129555
		public static readonly EKey ValveIndex_Left_Thumbstick_Left = new EKey("ValveIndex_Left_Thumbstick_Left");

		// Token: 0x0401FA14 RID: 129556
		public static readonly EKey ValveIndex_Left_Thumbstick_Right = new EKey("ValveIndex_Left_Thumbstick_Right");

		// Token: 0x0401FA15 RID: 129557
		public static readonly EKey ValveIndex_Left_Trackpad_X = new EKey("ValveIndex_Left_Trackpad_X");

		// Token: 0x0401FA16 RID: 129558
		public static readonly EKey ValveIndex_Left_Trackpad_Y = new EKey("ValveIndex_Left_Trackpad_Y");

		// Token: 0x0401FA17 RID: 129559
		public static readonly EKey ValveIndex_Left_Trackpad_Force = new EKey("ValveIndex_Left_Trackpad_Force");

		// Token: 0x0401FA18 RID: 129560
		public static readonly EKey ValveIndex_Left_Trackpad_Touch = new EKey("ValveIndex_Left_Trackpad_Touch");

		// Token: 0x0401FA19 RID: 129561
		public static readonly EKey ValveIndex_Left_Trackpad_Up = new EKey("ValveIndex_Left_Trackpad_Up");

		// Token: 0x0401FA1A RID: 129562
		public static readonly EKey ValveIndex_Left_Trackpad_Down = new EKey("ValveIndex_Left_Trackpad_Down");

		// Token: 0x0401FA1B RID: 129563
		public static readonly EKey ValveIndex_Left_Trackpad_Left = new EKey("ValveIndex_Left_Trackpad_Left");

		// Token: 0x0401FA1C RID: 129564
		public static readonly EKey ValveIndex_Left_Trackpad_Right = new EKey("ValveIndex_Left_Trackpad_Right");

		// Token: 0x0401FA1D RID: 129565
		public static readonly EKey ValveIndex_Right_A_Click = new EKey("ValveIndex_Right_A_Click");

		// Token: 0x0401FA1E RID: 129566
		public static readonly EKey ValveIndex_Right_B_Click = new EKey("ValveIndex_Right_B_Click");

		// Token: 0x0401FA1F RID: 129567
		public static readonly EKey ValveIndex_Right_A_Touch = new EKey("ValveIndex_Right_A_Touch");

		// Token: 0x0401FA20 RID: 129568
		public static readonly EKey ValveIndex_Right_B_Touch = new EKey("ValveIndex_Right_B_Touch");

		// Token: 0x0401FA21 RID: 129569
		public static readonly EKey ValveIndex_Right_System_Click = new EKey("ValveIndex_Right_System_Click");

		// Token: 0x0401FA22 RID: 129570
		public static readonly EKey ValveIndex_Right_System_Touch = new EKey("ValveIndex_Right_System_Touch");

		// Token: 0x0401FA23 RID: 129571
		public static readonly EKey ValveIndex_Right_Grip_Axis = new EKey("ValveIndex_Right_Grip_Axis");

		// Token: 0x0401FA24 RID: 129572
		public static readonly EKey ValveIndex_Right_Grip_Force = new EKey("ValveIndex_Right_Grip_Force");

		// Token: 0x0401FA25 RID: 129573
		public static readonly EKey ValveIndex_Right_Trigger_Click = new EKey("ValveIndex_Right_Trigger_Click");

		// Token: 0x0401FA26 RID: 129574
		public static readonly EKey ValveIndex_Right_Trigger_Axis = new EKey("ValveIndex_Right_Trigger_Axis");

		// Token: 0x0401FA27 RID: 129575
		public static readonly EKey ValveIndex_Right_Trigger_Touch = new EKey("ValveIndex_Right_Trigger_Touch");

		// Token: 0x0401FA28 RID: 129576
		public static readonly EKey ValveIndex_Right_Thumbstick_X = new EKey("ValveIndex_Right_Thumbstick_X");

		// Token: 0x0401FA29 RID: 129577
		public static readonly EKey ValveIndex_Right_Thumbstick_Y = new EKey("ValveIndex_Right_Thumbstick_Y");

		// Token: 0x0401FA2A RID: 129578
		public static readonly EKey ValveIndex_Right_Thumbstick_Click = new EKey("ValveIndex_Right_Thumbstick_Click");

		// Token: 0x0401FA2B RID: 129579
		public static readonly EKey ValveIndex_Right_Thumbstick_Touch = new EKey("ValveIndex_Right_Thumbstick_Touch");

		// Token: 0x0401FA2C RID: 129580
		public static readonly EKey ValveIndex_Right_Thumbstick_Up = new EKey("ValveIndex_Right_Thumbstick_Up");

		// Token: 0x0401FA2D RID: 129581
		public static readonly EKey ValveIndex_Right_Thumbstick_Down = new EKey("ValveIndex_Right_Thumbstick_Down");

		// Token: 0x0401FA2E RID: 129582
		public static readonly EKey ValveIndex_Right_Thumbstick_Left = new EKey("ValveIndex_Right_Thumbstick_Left");

		// Token: 0x0401FA2F RID: 129583
		public static readonly EKey ValveIndex_Right_Thumbstick_Right = new EKey("ValveIndex_Right_Thumbstick_Right");

		// Token: 0x0401FA30 RID: 129584
		public static readonly EKey ValveIndex_Right_Trackpad_X = new EKey("ValveIndex_Right_Trackpad_X");

		// Token: 0x0401FA31 RID: 129585
		public static readonly EKey ValveIndex_Right_Trackpad_Y = new EKey("ValveIndex_Right_Trackpad_Y");

		// Token: 0x0401FA32 RID: 129586
		public static readonly EKey ValveIndex_Right_Trackpad_Force = new EKey("ValveIndex_Right_Trackpad_Force");

		// Token: 0x0401FA33 RID: 129587
		public static readonly EKey ValveIndex_Right_Trackpad_Touch = new EKey("ValveIndex_Right_Trackpad_Touch");

		// Token: 0x0401FA34 RID: 129588
		public static readonly EKey ValveIndex_Right_Trackpad_Up = new EKey("ValveIndex_Right_Trackpad_Up");

		// Token: 0x0401FA35 RID: 129589
		public static readonly EKey ValveIndex_Right_Trackpad_Down = new EKey("ValveIndex_Right_Trackpad_Down");

		// Token: 0x0401FA36 RID: 129590
		public static readonly EKey ValveIndex_Right_Trackpad_Left = new EKey("ValveIndex_Right_Trackpad_Left");

		// Token: 0x0401FA37 RID: 129591
		public static readonly EKey ValveIndex_Right_Trackpad_Right = new EKey("ValveIndex_Right_Trackpad_Right");

		// Token: 0x0401FA38 RID: 129592
		public static readonly EKey Virtual_Accept = new EKey("Virtual_Accept");

		// Token: 0x0401FA39 RID: 129593
		public static readonly EKey Virtual_Back = new EKey("Virtual_Back");

		// Token: 0x0401FA3A RID: 129594
		public static readonly EKey GenericUSBController_Button1 = new EKey("GenericUSBController_Button1");

		// Token: 0x0401FA3B RID: 129595
		public static readonly EKey GenericUSBController_Button2 = new EKey("GenericUSBController_Button2");

		// Token: 0x0401FA3C RID: 129596
		public static readonly EKey GenericUSBController_Button3 = new EKey("GenericUSBController_Button3");

		// Token: 0x0401FA3D RID: 129597
		public static readonly EKey GenericUSBController_Button4 = new EKey("GenericUSBController_Button4");

		// Token: 0x0401FA3E RID: 129598
		public static readonly EKey GenericUSBController_Button5 = new EKey("GenericUSBController_Button5");

		// Token: 0x0401FA3F RID: 129599
		public static readonly EKey GenericUSBController_Button6 = new EKey("GenericUSBController_Button6");

		// Token: 0x0401FA40 RID: 129600
		public static readonly EKey GenericUSBController_Button7 = new EKey("GenericUSBController_Button7");

		// Token: 0x0401FA41 RID: 129601
		public static readonly EKey GenericUSBController_Button8 = new EKey("GenericUSBController_Button8");

		// Token: 0x0401FA42 RID: 129602
		public static readonly EKey GenericUSBController_Button9 = new EKey("GenericUSBController_Button9");

		// Token: 0x0401FA43 RID: 129603
		public static readonly EKey GenericUSBController_Button10 = new EKey("GenericUSBController_Button10");

		// Token: 0x0401FA44 RID: 129604
		public static readonly EKey GenericUSBController_Button11 = new EKey("GenericUSBController_Button11");

		// Token: 0x0401FA45 RID: 129605
		public static readonly EKey GenericUSBController_Button12 = new EKey("GenericUSBController_Button12");

		// Token: 0x0401FA46 RID: 129606
		public static readonly EKey GenericUSBController_Button13 = new EKey("GenericUSBController_Button13");

		// Token: 0x0401FA47 RID: 129607
		public static readonly EKey GenericUSBController_Button14 = new EKey("GenericUSBController_Button14");

		// Token: 0x0401FA48 RID: 129608
		public static readonly EKey GenericUSBController_Button15 = new EKey("GenericUSBController_Button15");

		// Token: 0x0401FA49 RID: 129609
		public static readonly EKey GenericUSBController_Button16 = new EKey("GenericUSBController_Button16");

		// Token: 0x0401FA4A RID: 129610
		public static readonly EKey GenericUSBController_Button17 = new EKey("GenericUSBController_Button17");

		// Token: 0x0401FA4B RID: 129611
		public static readonly EKey GenericUSBController_Button18 = new EKey("GenericUSBController_Button18");

		// Token: 0x0401FA4C RID: 129612
		public static readonly EKey GenericUSBController_Button19 = new EKey("GenericUSBController_Button19");

		// Token: 0x0401FA4D RID: 129613
		public static readonly EKey GenericUSBController_Button20 = new EKey("GenericUSBController_Button20");

		// Token: 0x0401FA4E RID: 129614
		public static readonly EKey GenericUSBController_Button21 = new EKey("GenericUSBController_Button21");

		// Token: 0x0401FA4F RID: 129615
		public static readonly EKey GenericUSBController_Button22 = new EKey("GenericUSBController_Button22");

		// Token: 0x0401FA50 RID: 129616
		public static readonly EKey GenericUSBController_Button23 = new EKey("GenericUSBController_Button23");

		// Token: 0x0401FA51 RID: 129617
		public static readonly EKey GenericUSBController_Button24 = new EKey("GenericUSBController_Button24");

		// Token: 0x0401FA52 RID: 129618
		public static readonly EKey GenericUSBController_Button25 = new EKey("GenericUSBController_Button25");

		// Token: 0x0401FA53 RID: 129619
		public static readonly EKey GenericUSBController_Button26 = new EKey("GenericUSBController_Button26");

		// Token: 0x0401FA54 RID: 129620
		public static readonly EKey GenericUSBController_Button27 = new EKey("GenericUSBController_Button27");

		// Token: 0x0401FA55 RID: 129621
		public static readonly EKey GenericUSBController_Button28 = new EKey("GenericUSBController_Button28");

		// Token: 0x0401FA56 RID: 129622
		public static readonly EKey GenericUSBController_Button29 = new EKey("GenericUSBController_Button29");

		// Token: 0x0401FA57 RID: 129623
		public static readonly EKey GenericUSBController_Button30 = new EKey("GenericUSBController_Button30");

		// Token: 0x0401FA58 RID: 129624
		public static readonly EKey GenericUSBController_ButtonInvalid = new EKey("GenericUSBController_ButtonInvalid");

		// Token: 0x0401FA59 RID: 129625
		public static readonly EKey GenericUSBController_Axis1 = new EKey("GenericUSBController_Axis1");

		// Token: 0x0401FA5A RID: 129626
		public static readonly EKey GenericUSBController_Axis2 = new EKey("GenericUSBController_Axis2");

		// Token: 0x0401FA5B RID: 129627
		public static readonly EKey GenericUSBController_Axis3 = new EKey("GenericUSBController_Axis3");

		// Token: 0x0401FA5C RID: 129628
		public static readonly EKey GenericUSBController_Axis4 = new EKey("GenericUSBController_Axis4");

		// Token: 0x0401FA5D RID: 129629
		public static readonly EKey GenericUSBController_Axis5 = new EKey("GenericUSBController_Axis5");

		// Token: 0x0401FA5E RID: 129630
		public static readonly EKey GenericUSBController_Axis6 = new EKey("GenericUSBController_Axis6");

		// Token: 0x0401FA5F RID: 129631
		public static readonly EKey GenericUSBController_Axis7 = new EKey("GenericUSBController_Axis7");

		// Token: 0x0401FA60 RID: 129632
		public static readonly EKey Invalid = new EKey("Invalid");
	}
}
