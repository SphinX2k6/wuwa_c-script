using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Core.Common
{
	// Token: 0x0200016A RID: 362
	[NullableContext(1)]
	[Nullable(0)]
	public class Info : Singleton
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0003A42F File Offset: 0x0003862F
		public UGameInstance GameInstance
		{
			get
			{
				return this.GameInstanceInternal;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x0003A437 File Offset: 0x00038637
		[Nullable(2)]
		public UWorld World
		{
			[NullableContext(2)]
			get
			{
				UGameInstance gameInstanceInternal = this.GameInstanceInternal;
				return ((gameInstanceInternal != null) ? gameInstanceInternal.GetWorld() : null) ?? null;
			}
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0003A450 File Offset: 0x00038650
		public void Initialize(UGameInstance gameInstance)
		{
			this.GameInstanceInternal = gameInstance;
			this.Environment = EEnvironment.UE4;
			this.IsInEditor = UKuroStaticLibrary.IsEditor(gameInstance);
			this.IsShipping = KuroApplication.IsBuildShipping();
			this.IsTest = KuroApplication.IsBuildTest();
			this.IsDevelopmentOrDebug = (!this.IsShipping && !this.IsTest);
			this.IsLowMemoryDeviceInternal = UKuroStaticLibrary.IsLowMemoryDevice();
			this.IsInCgInternal = (this.IsInEditor && UKuroRenderingRuntimeBPPluginBPLibrary.GetCVarFloat("r.Kuro.Movie.EnableCGMovieRendering") > 0f);
			this.IsInSimulateInEditorInternal = false;
			this.InitializePlatformType();
			Func<string> cloudGamePlatformHook = Info.CloudGamePlatformHook;
			this.InitCloudGame(((cloudGamePlatformHook != null) ? cloudGamePlatformHook() : null) ?? string.Empty);
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0003A501 File Offset: 0x00038701
		public bool IsPlayInEditor
		{
			get
			{
				return this.IsInEditor;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0003A509 File Offset: 0x00038709
		public bool IsBuildShipping
		{
			get
			{
				return this.IsShipping;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0003A511 File Offset: 0x00038711
		public bool IsBuildTest
		{
			get
			{
				return this.IsTest;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0003A519 File Offset: 0x00038719
		public bool IsBuildDevelopmentOrDebug
		{
			get
			{
				return this.IsDevelopmentOrDebug;
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0003A521 File Offset: 0x00038721
		public bool IsGameRunning()
		{
			return this.Environment == EEnvironment.UE4;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0003A52C File Offset: 0x0003872C
		public bool IsInCg()
		{
			return this.IsInCgInternal;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0003A534 File Offset: 0x00038734
		public void SetInCg(bool value)
		{
			if (this.IsInCgInternal != value)
			{
				this.IsInCgInternal = value;
				UKuroEffectSystemFunctionLibrary.OnIsInEditorTickChange(this.IsInEditorTick());
			}
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0003A551 File Offset: 0x00038751
		public bool IsInEditorTick()
		{
			return this.IsInSimulateInEditorInternal || this.IsInCgInternal;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0003A563 File Offset: 0x00038763
		public bool IsLowMemoryDevice
		{
			get
			{
				return this.IsLowMemoryDeviceInternal;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0003A56B File Offset: 0x0003876B
		public bool IsApplicationLowMemoryDevice
		{
			get
			{
				return this.IsLowMemoryDeviceInternal || this.PlatformTypeInternal == ESourcePlatformType.XboxOne;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0003A580 File Offset: 0x00038780
		public ESourcePlatformType PlatformType
		{
			get
			{
				return this.PlatformTypeInternal;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x0003A588 File Offset: 0x00038788
		public EInputControllerType InputControllerType
		{
			get
			{
				return this.InputControllerTypeInternal;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0003A590 File Offset: 0x00038790
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x0003A598 File Offset: 0x00038798
		public EInputControllerMainType InputControllerMainType
		{
			get
			{
				return this.InputControllerMainTypeInternal;
			}
			set
			{
				if (UKuroVariableFunctionLibrary.HasIntValue("InputControllerMainType"))
				{
					UKuroVariableFunctionLibrary.RemoveIntValue("InputControllerMainType");
				}
				UKuroVariableFunctionLibrary.SetIntValue("InputControllerMainType", (int)value);
				this.InputControllerMainTypeInternal = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0003A5C4 File Offset: 0x000387C4
		public EOperationType OperationType
		{
			get
			{
				return this.OperationTypeInternal;
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0003A5CC File Offset: 0x000387CC
		private void InitializePlatformType()
		{
			string text = KuroApplication.IniPlatformName();
			if (text != null)
			{
				switch (text.Length)
				{
				case 3:
				{
					char c = text[2];
					if (c <= '5')
					{
						if (c != '4')
						{
							if (c == '5')
							{
								if (text == "PS5")
								{
									this.PlatformTypeInternal = ESourcePlatformType.PS5;
									goto IL_1E8;
								}
							}
						}
						else if (text == "PS4")
						{
							this.PlatformTypeInternal = ESourcePlatformType.PS4;
							goto IL_1E8;
						}
					}
					else if (c != 'S')
					{
						if (c != 'X')
						{
							if (c == 'c')
							{
								if (text == "Mac")
								{
									this.PlatformTypeInternal = ESourcePlatformType.Mac;
									goto IL_1E8;
								}
							}
						}
						else if (text == "XSX")
						{
							this.PlatformTypeInternal = ESourcePlatformType.XSX;
							goto IL_1E8;
						}
					}
					else if (text == "IOS")
					{
						this.PlatformTypeInternal = ESourcePlatformType.IOS;
						goto IL_1E8;
					}
					break;
				}
				case 5:
					if (text == "Linux")
					{
						this.PlatformTypeInternal = ESourcePlatformType.Linux;
						goto IL_1E8;
					}
					break;
				case 6:
					if (text == "WinGDK")
					{
						this.PlatformTypeInternal = ESourcePlatformType.WinGDK;
						goto IL_1E8;
					}
					break;
				case 7:
				{
					char c = text[0];
					if (c != 'A')
					{
						if (c != 'W')
						{
							if (c == 'X')
							{
								if (text == "XboxOne")
								{
									this.PlatformTypeInternal = ESourcePlatformType.XboxOne;
									goto IL_1E8;
								}
							}
						}
						else if (text == "Windows")
						{
							this.PlatformTypeInternal = ESourcePlatformType.Windows;
							goto IL_1E8;
						}
					}
					else if (text == "Android")
					{
						this.PlatformTypeInternal = ESourcePlatformType.Android;
						goto IL_1E8;
					}
					break;
				}
				case 11:
					if (text == "OpenHarmony")
					{
						this.PlatformTypeInternal = ESourcePlatformType.OpenHarmony;
						goto IL_1E8;
					}
					break;
				}
			}
			this.PlatformTypeInternal = ESourcePlatformType.None;
			IL_1E8:
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Platform;
			ELogAuthor author = ELogAuthor.WY;
			string message = "初始化平台类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlatformType", this.PlatformTypeInternal);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EInputControllerType inputControllerType;
			if (InfoDefine.DefaultPlatformAndInputControllerMap.TryGetValue(this.PlatformTypeInternal, out inputControllerType))
			{
				this.SwitchInputControllerType(inputControllerType, "InitializePlatformType");
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Platform;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "找不到平台默认对应的输入类型";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PlatformType", this.PlatformTypeInternal);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0003A84C File Offset: 0x00038A4C
		private void InitCloudGame(string platform)
		{
			Func<bool> isCloudGameHook = Info.IsCloudGameHook;
			if (isCloudGameHook == null || !isCloudGameHook())
			{
				return;
			}
			if (platform == "Android" || platform == "IOS")
			{
				this.SwitchInputControllerType(EInputControllerType.Touch, "InitCloudGame Mobile");
				return;
			}
			if (platform == "Mac" || platform == "Windows")
			{
				this.SwitchInputControllerType(EInputControllerType.Keyboard, "InitCloudGame Desktop");
			}
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0003A8C0 File Offset: 0x00038AC0
		public unsafe void SetInputControllerType(EInputControllerType inputController, string reason)
		{
			if (this.InputControllerTypeInternal == inputController)
			{
				return;
			}
			if (inputController == EInputControllerType.Keyboard && this.InputControllerTypeInternal == EInputControllerType.Touch)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Platform;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[PlatformDebug]从Touch输入方式切换成了键鼠的输入方式";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("lastInputController", this.InputControllerTypeInternal);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("inputController", inputController);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			EInputControllerType inputControllerTypeInternal = this.InputControllerTypeInternal;
			this.InputControllerTypeInternal = inputController;
			this.SetInputControllerMainType();
			TInputTypeChange inputTypeChangeFunc = this.InputTypeChangeFunc;
			if (inputTypeChangeFunc != null)
			{
				inputTypeChangeFunc(inputControllerTypeInternal, this.InputControllerTypeInternal);
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Platform;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "设置输入方式";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("lastInputController", inputControllerTypeInternal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("InputController", this.InputControllerTypeInternal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Reason", reason);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0003A9F4 File Offset: 0x00038BF4
		private void SetShowType(EInputControllerType inputController)
		{
			EOperationType eoperationType = InfoDefine.ShowTypeAndInputControllerMap[inputController];
			if (eoperationType == this.OperationTypeInternal)
			{
				return;
			}
			EOperationType operationTypeInternal = this.OperationTypeInternal;
			this.OperationTypeInternal = eoperationType;
			TShowTypeChange showTypeChangeFunc = this.ShowTypeChangeFunc;
			if (showTypeChangeFunc == null)
			{
				return;
			}
			showTypeChangeFunc(operationTypeInternal, eoperationType);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0003AA38 File Offset: 0x00038C38
		private void SetInputControllerMainType()
		{
			EInputControllerMainType einputControllerMainType = InfoDefine.InputControllerMainTypeMap[this.InputControllerTypeInternal];
			if (einputControllerMainType == this.InputControllerMainTypeInternal)
			{
				return;
			}
			EInputControllerMainType inputControllerMainTypeInternal = this.InputControllerMainTypeInternal;
			this.InputControllerMainType = einputControllerMainType;
			TInputMainTypeChange inputMainTypeChangeFunc = this.InputMainTypeChangeFunc;
			if (inputMainTypeChangeFunc == null)
			{
				return;
			}
			inputMainTypeChangeFunc(inputControllerMainTypeInternal, einputControllerMainType);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0003AA80 File Offset: 0x00038C80
		public bool IsPcOrGamepadPlatform()
		{
			return this.IsPcPlatform() || this.IsGamepadPlatform();
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0003AA92 File Offset: 0x00038C92
		public bool IsPcPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.Windows || this.PlatformTypeInternal == ESourcePlatformType.Mac || this.PlatformTypeInternal == ESourcePlatformType.Linux || this.PlatformTypeInternal == ESourcePlatformType.WinGDK;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0003AABB File Offset: 0x00038CBB
		public bool IsXboxPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.XboxOne || this.PlatformTypeInternal == ESourcePlatformType.XSX || this.PlatformTypeInternal == ESourcePlatformType.WinGDK;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0003AADC File Offset: 0x00038CDC
		public bool IsXSXPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.XSX;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0003AAE8 File Offset: 0x00038CE8
		public bool IsWinGDKPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.WinGDK;
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0003AAF4 File Offset: 0x00038CF4
		public bool IsHomeConsolePlatform()
		{
			return this.IsPs5Platform() || this.IsXboxPlatform();
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0003AB06 File Offset: 0x00038D06
		public bool IsMobilePlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.IOS || this.PlatformTypeInternal == ESourcePlatformType.Android || this.PlatformTypeInternal == ESourcePlatformType.OpenHarmony;
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0003AB26 File Offset: 0x00038D26
		public bool IsIosPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.IOS;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0003AB31 File Offset: 0x00038D31
		public bool IsGamepadPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.XboxOne || this.PlatformTypeInternal == ESourcePlatformType.XSX || this.PlatformTypeInternal == ESourcePlatformType.PS4 || this.PlatformTypeInternal == ESourcePlatformType.PS5;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0003AB5A File Offset: 0x00038D5A
		public bool IsPs5Platform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.PS5;
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0003AB65 File Offset: 0x00038D65
		public bool IsMacPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.Mac;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0003AB70 File Offset: 0x00038D70
		public bool IsWindowsPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.Windows || this.IsWinGDKPlatform();
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0003AB83 File Offset: 0x00038D83
		public bool IsWindowsOnlyPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.Windows;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0003AB8E File Offset: 0x00038D8E
		public bool IsAndroidPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.Android;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0003AB99 File Offset: 0x00038D99
		public bool IsOpenHarmonyPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.OpenHarmony;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0003ABA5 File Offset: 0x00038DA5
		public bool IsInKeyBoard()
		{
			return this.InputControllerMainType == EInputControllerMainType.Keyboard;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0003ABB0 File Offset: 0x00038DB0
		public bool IsInTouch()
		{
			return this.InputControllerMainType == EInputControllerMainType.Touch;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0003ABBB File Offset: 0x00038DBB
		public bool IsInGamepad()
		{
			return this.InputControllerMainType == EInputControllerMainType.Gamepad;
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0003ABC6 File Offset: 0x00038DC6
		public bool IsXboxGamepad()
		{
			return this.IsInGamepad() && this.InputControllerType == EInputControllerType.XboxOne;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0003ABDB File Offset: 0x00038DDB
		public bool IsPsGamepad()
		{
			return this.IsInGamepad() && (this.InputControllerType == EInputControllerType.PS4 || this.InputControllerType == EInputControllerType.PS5);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0003ABFB File Offset: 0x00038DFB
		public bool IsBackBoneGamepad()
		{
			return this.IsInGamepad() && this.InputControllerType == EInputControllerType.BackBone;
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0003AC10 File Offset: 0x00038E10
		public bool IsNsProGamepad()
		{
			return this.IsInGamepad() && this.InputControllerType == EInputControllerType.NsPro;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0003AC25 File Offset: 0x00038E25
		public bool CheckIsBackBoneGamepad(EInputControllerType type)
		{
			return type == EInputControllerType.BackBone;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0003AC2B File Offset: 0x00038E2B
		public bool CheckIsNsProGamepad(EInputControllerType type)
		{
			return type == EInputControllerType.NsPro;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0003AC31 File Offset: 0x00038E31
		public bool CheckIsPsGamepad(EInputControllerType type)
		{
			return type == EInputControllerType.PS4 || type == EInputControllerType.PS5;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0003AC40 File Offset: 0x00038E40
		public bool IsMobileInputModel()
		{
			if (this.IsMobilePlatform())
			{
				return true;
			}
			if (this.PlatformTypeInternal == ESourcePlatformType.Windows)
			{
				Func<bool> isCloudGameHook = Info.IsCloudGameHook;
				if (isCloudGameHook != null && isCloudGameHook())
				{
					Func<string> cloudGamePlatformHook = Info.CloudGamePlatformHook;
					if (!(((cloudGamePlatformHook != null) ? cloudGamePlatformHook() : null) == "Android"))
					{
						Func<string> cloudGamePlatformHook2 = Info.CloudGamePlatformHook;
						if (!(((cloudGamePlatformHook2 != null) ? cloudGamePlatformHook2() : null) == "IOS"))
						{
							return false;
						}
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0003ACB0 File Offset: 0x00038EB0
		public bool IsPcInputModel()
		{
			if (this.PlatformTypeInternal == ESourcePlatformType.Mac || this.PlatformTypeInternal == ESourcePlatformType.Linux || this.PlatformTypeInternal == ESourcePlatformType.WinGDK)
			{
				return true;
			}
			if (this.PlatformTypeInternal == ESourcePlatformType.Windows)
			{
				Func<bool> isCloudGameHook = Info.IsCloudGameHook;
				if (isCloudGameHook != null && isCloudGameHook())
				{
					Func<string> cloudGamePlatformHook = Info.CloudGamePlatformHook;
					if (((cloudGamePlatformHook != null) ? cloudGamePlatformHook() : null) != "Mac")
					{
						Func<string> cloudGamePlatformHook2 = Info.CloudGamePlatformHook;
						if (((cloudGamePlatformHook2 != null) ? cloudGamePlatformHook2() : null) != "Windows")
						{
							return false;
						}
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0003AD38 File Offset: 0x00038F38
		public void SwitchInputControllerType(EInputControllerType inputControllerType, string reason)
		{
			if (inputControllerType == EInputControllerType.None)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Platform;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "传入了EInputControllerType.None类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.IsGmLockGamepad)
			{
				return;
			}
			if (this.IsMobileInputModel() && inputControllerType == EInputControllerType.Keyboard)
			{
				return;
			}
			if (this.IsPcInputModel() && inputControllerType == EInputControllerType.Touch)
			{
				return;
			}
			this.SetInputControllerType(inputControllerType, reason);
			this.SetShowType(inputControllerType);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0003ADA5 File Offset: 0x00038FA5
		[Conditional("DEBUG")]
		public void GmSwitchInputControllerType(EInputControllerType inputControllerType, string reason)
		{
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0003ADA7 File Offset: 0x00038FA7
		public void SetInputTypeChangeFunc(TInputTypeChange func)
		{
			this.InputTypeChangeFunc = func;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0003ADB0 File Offset: 0x00038FB0
		public void ClearInputTypeChangeFunc()
		{
			this.InputTypeChangeFunc = null;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0003ADB9 File Offset: 0x00038FB9
		public void SetShowTypeChangeFunc(TShowTypeChange func)
		{
			this.ShowTypeChangeFunc = func;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0003ADC2 File Offset: 0x00038FC2
		public void ClearShowTypeChangeFunc()
		{
			this.ShowTypeChangeFunc = null;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0003ADCB File Offset: 0x00038FCB
		public void SetInputMainTypeChangeFunc(TInputMainTypeChange func)
		{
			this.InputMainTypeChangeFunc = func;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x0003ADD4 File Offset: 0x00038FD4
		public void ClearInputMainTypeChangeFunc()
		{
			this.InputMainTypeChangeFunc = null;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x0003ADDD File Offset: 0x00038FDD
		public static Info Instance
		{
			get
			{
				if (Info._instance == null)
				{
					Info._instance = new Info();
					Info._instance.OnInit();
				}
				return Info._instance;
			}
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0003AE00 File Offset: 0x00039000
		public static void CreateStaticDefaultValue()
		{
			Info.OnCreateStaticDefaultValue();
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0003AE07 File Offset: 0x00039007
		public static void ResetStaticDefaultValue()
		{
			Info instance = Info._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			Info._instance = null;
			Info.OnResetStaticDefaultValue();
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0003AE25 File Offset: 0x00039025
		private static void OnCreateStaticDefaultValue()
		{
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0003AE27 File Offset: 0x00039027
		private static void OnResetStaticDefaultValue()
		{
			Info.IsCloudGameHook = null;
			Info.CloudGamePlatformHook = null;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0003AE35 File Offset: 0x00039035
		static Info()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(Info.CreateStaticDefaultValue), new Action(Info.ResetStaticDefaultValue));
		}

		// Token: 0x04000727 RID: 1831
		public static Func<bool> IsCloudGameHook;

		// Token: 0x04000728 RID: 1832
		public static Func<string> CloudGamePlatformHook;

		// Token: 0x04000729 RID: 1833
		private UGameInstance GameInstanceInternal;

		// Token: 0x0400072A RID: 1834
		public readonly string Version = "1.0.0";

		// Token: 0x0400072B RID: 1835
		public EEnvironment Environment;

		// Token: 0x0400072C RID: 1836
		public readonly bool EnableForceTick;

		// Token: 0x0400072D RID: 1837
		private bool IsInEditor = true;

		// Token: 0x0400072E RID: 1838
		private bool IsShipping = true;

		// Token: 0x0400072F RID: 1839
		private bool IsTest;

		// Token: 0x04000730 RID: 1840
		private bool IsDevelopmentOrDebug;

		// Token: 0x04000731 RID: 1841
		private bool IsInCgInternal;

		// Token: 0x04000732 RID: 1842
		public bool UseFastInputCallback = true;

		// Token: 0x04000733 RID: 1843
		public bool AxisInputOptimize = true;

		// Token: 0x04000734 RID: 1844
		private bool IsInSimulateInEditorInternal;

		// Token: 0x04000735 RID: 1845
		private bool IsLowMemoryDeviceInternal;

		// Token: 0x04000736 RID: 1846
		private ESourcePlatformType PlatformTypeInternal;

		// Token: 0x04000737 RID: 1847
		private EInputControllerType InputControllerTypeInternal;

		// Token: 0x04000738 RID: 1848
		private EInputControllerMainType InputControllerMainTypeInternal;

		// Token: 0x04000739 RID: 1849
		private EOperationType OperationTypeInternal;

		// Token: 0x0400073A RID: 1850
		public bool IsGmLockGamepad;

		// Token: 0x0400073B RID: 1851
		[Nullable(2)]
		private TInputTypeChange InputTypeChangeFunc;

		// Token: 0x0400073C RID: 1852
		[Nullable(2)]
		private TShowTypeChange ShowTypeChangeFunc;

		// Token: 0x0400073D RID: 1853
		[Nullable(2)]
		private TInputMainTypeChange InputMainTypeChangeFunc;

		// Token: 0x0400073E RID: 1854
		[Nullable(2)]
		private static Info _instance;
	}
}
