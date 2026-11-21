using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Core.Common
{
	// Token: 0x0200016F RID: 367
	[NullableContext(1)]
	[Nullable(0)]
	public class Info : Singleton
	{
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x0003B173 File Offset: 0x00039373
		public UGameInstance GameInstance
		{
			get
			{
				return this.GameInstanceInternal;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0003B17B File Offset: 0x0003937B
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

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0003B194 File Offset: 0x00039394
		public void Initialize(UGameInstance gameInstance)
		{
			this.GameInstanceInternal = gameInstance;
			this.Environment = EEnvironment.UE4;
			this.IsLowMemoryDeviceInternal = UKuroStaticLibrary.IsLowMemoryDevice();
			this.IsInCgInternal = false;
			this.IsInSimulateInEditorInternal = false;
			this.InitializePlatformType();
			Func<string> cloudGamePlatformHook = Info.CloudGamePlatformHook;
			this.InitCloudGame(((cloudGamePlatformHook != null) ? cloudGamePlatformHook() : null) ?? string.Empty);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0003B1EE File Offset: 0x000393EE
		public bool IsGameRunning()
		{
			return this.Environment == EEnvironment.UE4;
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0003B1F9 File Offset: 0x000393F9
		public bool IsInCg()
		{
			return this.IsInCgInternal;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0003B201 File Offset: 0x00039401
		public void SetInCg(bool value)
		{
			if (this.IsInCgInternal != value)
			{
				this.IsInCgInternal = value;
				UKuroEffectSystemFunctionLibrary.OnIsInEditorTickChange(this.IsInEditorTick());
			}
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0003B21E File Offset: 0x0003941E
		public bool IsInEditorTick()
		{
			return this.IsInSimulateInEditorInternal || this.IsInCgInternal;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0003B230 File Offset: 0x00039430
		public bool IsLowMemoryDevice
		{
			get
			{
				return this.IsLowMemoryDeviceInternal;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0003B238 File Offset: 0x00039438
		public bool IsApplicationLowMemoryDevice
		{
			get
			{
				return this.IsLowMemoryDeviceInternal || this.PlatformTypeInternal == ESourcePlatformType.XboxOne;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0003B24D File Offset: 0x0003944D
		public ESourcePlatformType PlatformType
		{
			get
			{
				return this.PlatformTypeInternal;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0003B255 File Offset: 0x00039455
		public EInputControllerType InputControllerType
		{
			get
			{
				return this.InputControllerTypeInternal;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x0003B25D File Offset: 0x0003945D
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x0003B265 File Offset: 0x00039465
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

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x0003B291 File Offset: 0x00039491
		public EOperationType OperationType
		{
			get
			{
				return this.OperationTypeInternal;
			}
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x0003B29C File Offset: 0x0003949C
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

		// Token: 0x06000CBD RID: 3261 RVA: 0x0003B51C File Offset: 0x0003971C
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

		// Token: 0x06000CBE RID: 3262 RVA: 0x0003B590 File Offset: 0x00039790
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

		// Token: 0x06000CBF RID: 3263 RVA: 0x0003B6C4 File Offset: 0x000398C4
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

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0003B708 File Offset: 0x00039908
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

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0003B750 File Offset: 0x00039950
		public bool IsPcOrGamepadPlatform()
		{
			return this.IsPcPlatform() || this.IsGamepadPlatform();
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0003B762 File Offset: 0x00039962
		public bool IsPcPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.Windows || this.PlatformTypeInternal == ESourcePlatformType.Mac || this.PlatformTypeInternal == ESourcePlatformType.Linux || this.PlatformTypeInternal == ESourcePlatformType.WinGDK;
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0003B78B File Offset: 0x0003998B
		public bool IsXboxPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.XboxOne || this.PlatformTypeInternal == ESourcePlatformType.XSX || this.PlatformTypeInternal == ESourcePlatformType.WinGDK;
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0003B7AC File Offset: 0x000399AC
		public bool IsXSXPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.XSX;
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0003B7B8 File Offset: 0x000399B8
		public bool IsWinGDKPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.WinGDK;
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0003B7C4 File Offset: 0x000399C4
		public bool IsHomeConsolePlatform()
		{
			return this.IsPs5Platform() || this.IsXboxPlatform();
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0003B7D6 File Offset: 0x000399D6
		public bool IsMobilePlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.IOS || this.PlatformTypeInternal == ESourcePlatformType.Android || this.PlatformTypeInternal == ESourcePlatformType.OpenHarmony;
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0003B7F6 File Offset: 0x000399F6
		public bool IsIosPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.IOS;
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0003B801 File Offset: 0x00039A01
		public bool IsGamepadPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.XboxOne || this.PlatformTypeInternal == ESourcePlatformType.XSX || this.PlatformTypeInternal == ESourcePlatformType.PS4 || this.PlatformTypeInternal == ESourcePlatformType.PS5;
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0003B82A File Offset: 0x00039A2A
		public bool IsPs5Platform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.PS5;
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x0003B835 File Offset: 0x00039A35
		public bool IsMacPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.Mac;
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x0003B840 File Offset: 0x00039A40
		public bool IsWindowsPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.Windows || this.IsWinGDKPlatform();
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0003B853 File Offset: 0x00039A53
		public bool IsWindowsOnlyPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.Windows;
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x0003B85E File Offset: 0x00039A5E
		public bool IsAndroidPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.Android;
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0003B869 File Offset: 0x00039A69
		public bool IsOpenHarmonyPlatform()
		{
			return this.PlatformTypeInternal == ESourcePlatformType.OpenHarmony;
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0003B875 File Offset: 0x00039A75
		public bool IsInKeyBoard()
		{
			return this.InputControllerMainType == EInputControllerMainType.Keyboard;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0003B880 File Offset: 0x00039A80
		public bool IsInTouch()
		{
			return this.InputControllerMainType == EInputControllerMainType.Touch;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0003B88B File Offset: 0x00039A8B
		public bool IsInGamepad()
		{
			return this.InputControllerMainType == EInputControllerMainType.Gamepad;
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0003B896 File Offset: 0x00039A96
		public bool IsXboxGamepad()
		{
			return this.IsInGamepad() && this.InputControllerType == EInputControllerType.XboxOne;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0003B8AB File Offset: 0x00039AAB
		public bool IsPsGamepad()
		{
			return this.IsInGamepad() && (this.InputControllerType == EInputControllerType.PS4 || this.InputControllerType == EInputControllerType.PS5);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0003B8CB File Offset: 0x00039ACB
		public bool IsBackBoneGamepad()
		{
			return this.IsInGamepad() && this.InputControllerType == EInputControllerType.BackBone;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0003B8E0 File Offset: 0x00039AE0
		public bool IsNsProGamepad()
		{
			return this.IsInGamepad() && this.InputControllerType == EInputControllerType.NsPro;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0003B8F5 File Offset: 0x00039AF5
		public bool CheckIsBackBoneGamepad(EInputControllerType type)
		{
			return type == EInputControllerType.BackBone;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0003B8FB File Offset: 0x00039AFB
		public bool CheckIsNsProGamepad(EInputControllerType type)
		{
			return type == EInputControllerType.NsPro;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0003B901 File Offset: 0x00039B01
		public bool CheckIsPsGamepad(EInputControllerType type)
		{
			return type == EInputControllerType.PS4 || type == EInputControllerType.PS5;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0003B910 File Offset: 0x00039B10
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

		// Token: 0x06000CDB RID: 3291 RVA: 0x0003B980 File Offset: 0x00039B80
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

		// Token: 0x06000CDC RID: 3292 RVA: 0x0003BA08 File Offset: 0x00039C08
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

		// Token: 0x06000CDD RID: 3293 RVA: 0x0003BA75 File Offset: 0x00039C75
		[Conditional("DEBUG")]
		public void GmSwitchInputControllerType(EInputControllerType inputControllerType, string reason)
		{
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0003BA77 File Offset: 0x00039C77
		public void SetInputTypeChangeFunc(TInputTypeChange func)
		{
			this.InputTypeChangeFunc = func;
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0003BA80 File Offset: 0x00039C80
		public void ClearInputTypeChangeFunc()
		{
			this.InputTypeChangeFunc = null;
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0003BA89 File Offset: 0x00039C89
		public void SetShowTypeChangeFunc(TShowTypeChange func)
		{
			this.ShowTypeChangeFunc = func;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0003BA92 File Offset: 0x00039C92
		public void ClearShowTypeChangeFunc()
		{
			this.ShowTypeChangeFunc = null;
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0003BA9B File Offset: 0x00039C9B
		public void SetInputMainTypeChangeFunc(TInputMainTypeChange func)
		{
			this.InputMainTypeChangeFunc = func;
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0003BAA4 File Offset: 0x00039CA4
		public void ClearInputMainTypeChangeFunc()
		{
			this.InputMainTypeChangeFunc = null;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0003BAAD File Offset: 0x00039CAD
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

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0003BAD0 File Offset: 0x00039CD0
		public static void CreateStaticDefaultValue()
		{
			Info.OnCreateStaticDefaultValue();
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x0003BAD7 File Offset: 0x00039CD7
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

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0003BAF5 File Offset: 0x00039CF5
		private static void OnCreateStaticDefaultValue()
		{
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0003BAF7 File Offset: 0x00039CF7
		private static void OnResetStaticDefaultValue()
		{
			Info.IsCloudGameHook = null;
			Info.CloudGamePlatformHook = null;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0003BB05 File Offset: 0x00039D05
		static Info()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(Info.CreateStaticDefaultValue), new Action(Info.ResetStaticDefaultValue));
		}

		// Token: 0x04000736 RID: 1846
		public static Func<bool> IsCloudGameHook;

		// Token: 0x04000737 RID: 1847
		public static Func<string> CloudGamePlatformHook;

		// Token: 0x04000738 RID: 1848
		private UGameInstance GameInstanceInternal;

		// Token: 0x04000739 RID: 1849
		public readonly string Version = "1.0.0";

		// Token: 0x0400073A RID: 1850
		public EEnvironment Environment;

		// Token: 0x0400073B RID: 1851
		public readonly bool EnableForceTick;

		// Token: 0x0400073C RID: 1852
		private bool IsInCgInternal;

		// Token: 0x0400073D RID: 1853
		public bool UseFastInputCallback = true;

		// Token: 0x0400073E RID: 1854
		public bool AxisInputOptimize = true;

		// Token: 0x0400073F RID: 1855
		private bool IsInSimulateInEditorInternal;

		// Token: 0x04000740 RID: 1856
		private bool IsLowMemoryDeviceInternal;

		// Token: 0x04000741 RID: 1857
		public const bool IsPlayInEditor = false;

		// Token: 0x04000742 RID: 1858
		public const bool IsBuildShipping = true;

		// Token: 0x04000743 RID: 1859
		public const bool IsBuildTest = false;

		// Token: 0x04000744 RID: 1860
		public const bool IsBuildDevelopmentOrDebug = false;

		// Token: 0x04000745 RID: 1861
		private ESourcePlatformType PlatformTypeInternal;

		// Token: 0x04000746 RID: 1862
		private EInputControllerType InputControllerTypeInternal;

		// Token: 0x04000747 RID: 1863
		private EInputControllerMainType InputControllerMainTypeInternal;

		// Token: 0x04000748 RID: 1864
		private EOperationType OperationTypeInternal;

		// Token: 0x04000749 RID: 1865
		public bool IsGmLockGamepad;

		// Token: 0x0400074A RID: 1866
		[Nullable(2)]
		private TInputTypeChange InputTypeChangeFunc;

		// Token: 0x0400074B RID: 1867
		[Nullable(2)]
		private TShowTypeChange ShowTypeChangeFunc;

		// Token: 0x0400074C RID: 1868
		[Nullable(2)]
		private TInputMainTypeChange InputMainTypeChangeFunc;

		// Token: 0x0400074D RID: 1869
		[Nullable(2)]
		private static Info _instance;
	}
}
