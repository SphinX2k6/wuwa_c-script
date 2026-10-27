using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.HotPatch
{
	// Token: 0x02000026 RID: 38
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class TsHotFixActionHandle_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600013F RID: 319 RVA: 0x0000886C File Offset: 0x00006A6C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (TsHotFixActionHandle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C");
			}
			return TsHotFixActionHandle_C._ClassPtr;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00008890 File Offset: 0x00006A90
		public TsHotFixActionHandle_C() : this(BuiltinUtils.AllocNativeUObject(TsHotFixActionHandle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000088B8 File Offset: 0x00006AB8
		public TsHotFixActionHandle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsHotFixActionHandle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000088EB File Offset: 0x00006AEB
		// (set) Token: 0x06000143 RID: 323 RVA: 0x000088FF File Offset: 0x00006AFF
		public unsafe FName FuncName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00008914 File Offset: 0x00006B14
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00008928 File Offset: 0x00006B28
		[Nullable(2)]
		public unsafe UObject 目标
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + TsHotFixActionHandle_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsHotFixActionHandle_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000893D File Offset: 0x00006B3D
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00008951 File Offset: 0x00006B51
		public unsafe string ActionName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsHotFixActionHandle_C.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsHotFixActionHandle_C.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00008966 File Offset: 0x00006B66
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00008976 File Offset: 0x00006B76
		public unsafe bool bPress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00008988 File Offset: 0x00006B88
		// (set) Token: 0x0600014B RID: 331 RVA: 0x000089C1 File Offset: 0x00006BC1
		public OnPressActionCallback OnPressActionCallback
		{
			get
			{
				base.FastCheckIsValid();
				OnPressActionCallback result;
				if ((result = this._OnPressActionCallback) == null)
				{
					result = (this._OnPressActionCallback = new OnPressActionCallback(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_4, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000089E2 File Offset: 0x00006BE2
		// (set) Token: 0x0600014D RID: 333 RVA: 0x000089F6 File Offset: 0x00006BF6
		[Nullable(0)]
		public unsafe TEnumAsByte<ETouchIndex> TouchIndex
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_5);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00008A0B File Offset: 0x00006C0B
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00008A1F File Offset: 0x00006C1F
		public unsafe FVector TouchPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00008A34 File Offset: 0x00006C34
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00008A6D File Offset: 0x00006C6D
		public OnTouchActionCallback OnTouchActionCallback
		{
			get
			{
				base.FastCheckIsValid();
				OnTouchActionCallback result;
				if ((result = this._OnTouchActionCallback) == null)
				{
					result = (this._OnTouchActionCallback = new OnTouchActionCallback(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_7, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00008A90 File Offset: 0x00006C90
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00008AC9 File Offset: 0x00006CC9
		public OnTouchMovedActionCallback OnTouchMovedActionCallback
		{
			get
			{
				base.FastCheckIsValid();
				OnTouchMovedActionCallback result;
				if ((result = this._OnTouchMovedActionCallback) == null)
				{
					result = (this._OnTouchMovedActionCallback = new OnTouchMovedActionCallback(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_8, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00008AEC File Offset: 0x00006CEC
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00008B25 File Offset: 0x00006D25
		public OnAxisCallback OnAxisCallback
		{
			get
			{
				base.FastCheckIsValid();
				OnAxisCallback result;
				if ((result = this._OnAxisCallback) == null)
				{
					result = (this._OnAxisCallback = new OnAxisCallback(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_9, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00008B46 File Offset: 0x00006D46
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00008B5A File Offset: 0x00006D5A
		public unsafe string AxisName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsHotFixActionHandle_C.__PropertyOffset_10)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsHotFixActionHandle_C.__PropertyOffset_10)), value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00008B6F File Offset: 0x00006D6F
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00008B83 File Offset: 0x00006D83
		public unsafe FName Func_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00008B98 File Offset: 0x00006D98
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00008BD1 File Offset: 0x00006DD1
		public OnAnyKeyPressCallback OnAnyKeyPressCallback
		{
			get
			{
				base.FastCheckIsValid();
				OnAnyKeyPressCallback result;
				if ((result = this._OnAnyKeyPressCallback) == null)
				{
					result = (this._OnAnyKeyPressCallback = new OnAnyKeyPressCallback(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_12, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00008BF4 File Offset: 0x00006DF4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnAnyKeyPressAction(FKey key)
		{
			TsHotFixActionHandle_C.__OnAnyKeyPressAction_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__OnAnyKeyPressAction_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(TsHotFixActionHandle_C.__OnAnyKeyPressAction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__OnAnyKeyPressAction_NativeFunctionPtr, (void*)ptr, 1);
			if (key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->key, key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__OnAnyKeyPressAction_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(TsHotFixActionHandle_C.__OnAnyKeyPressAction_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00008C68 File Offset: 0x00006E68
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ClearKeyBinding(APlayerController controller)
		{
			TsHotFixActionHandle_C.__ClearKeyBinding_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__ClearKeyBinding_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(TsHotFixActionHandle_C.__ClearKeyBinding_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__ClearKeyBinding_NativeFunctionPtr, (void*)ptr, 1);
			ptr->controller = ((controller != null) ? controller.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__ClearKeyBinding_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00008CC0 File Offset: 0x00006EC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddAnyKeyPress(APlayerController controller, FInputChord chord)
		{
			TsHotFixActionHandle_C.__AddAnyKeyPress_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__AddAnyKeyPress_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(TsHotFixActionHandle_C.__AddAnyKeyPress_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__AddAnyKeyPress_NativeFunctionPtr, (void*)ptr, 1);
			ptr->controller = ((controller != null) ? controller.NativePtr : IntPtr.Zero);
			if (chord != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputChord.StaticStruct(), &ptr->chord, chord.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__AddAnyKeyPress_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(TsHotFixActionHandle_C.__AddAnyKeyPress_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00008D48 File Offset: 0x00006F48
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ClearAxisBinding(APlayerController controller)
		{
			TsHotFixActionHandle_C.__ClearAxisBinding_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__ClearAxisBinding_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(TsHotFixActionHandle_C.__ClearAxisBinding_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__ClearAxisBinding_NativeFunctionPtr, (void*)ptr, 1);
			ptr->controller = ((controller != null) ? controller.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__ClearAxisBinding_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00008DA0 File Offset: 0x00006FA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnAxisInput(float value)
		{
			TsHotFixActionHandle_C.__OnAxisInput_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__OnAxisInput_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(TsHotFixActionHandle_C.__OnAxisInput_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__OnAxisInput_NativeFunctionPtr, (void*)ptr, 1);
			ptr->value = value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__OnAxisInput_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00008DE8 File Offset: 0x00006FE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddAxisBinding(string axisName, [Nullable(2)] APlayerController controller)
		{
			TsHotFixActionHandle_C.__AddAxisBinding_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__AddAxisBinding_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(TsHotFixActionHandle_C.__AddAxisBinding_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__AddAxisBinding_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->axisName), axisName);
			ptr->controller = ((controller != null) ? controller.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__AddAxisBinding_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(TsHotFixActionHandle_C.__AddAxisBinding_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00008E5C File Offset: 0x0000705C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddTouchMoveBinding(APlayerController controller)
		{
			TsHotFixActionHandle_C.__AddTouchMoveBinding_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__AddTouchMoveBinding_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(TsHotFixActionHandle_C.__AddTouchMoveBinding_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__AddTouchMoveBinding_NativeFunctionPtr, (void*)ptr, 1);
			ptr->controller = ((controller != null) ? controller.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__AddTouchMoveBinding_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00008EB4 File Offset: 0x000070B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnTouchMoveAction(ETouchIndex touchindex, FVector position)
		{
			TsHotFixActionHandle_C.__OnTouchMoveAction_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__OnTouchMoveAction_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(TsHotFixActionHandle_C.__OnTouchMoveAction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__OnTouchMoveAction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->touchindex = touchindex;
			ptr->position = position;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__OnTouchMoveAction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00008F08 File Offset: 0x00007108
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ClearActionBinding(APlayerController controller)
		{
			TsHotFixActionHandle_C.__ClearActionBinding_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__ClearActionBinding_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(TsHotFixActionHandle_C.__ClearActionBinding_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__ClearActionBinding_NativeFunctionPtr, (void*)ptr, 1);
			ptr->controller = ((controller != null) ? controller.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__ClearActionBinding_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00008F60 File Offset: 0x00007160
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnTouchReleaseAction(ETouchIndex touchIndex, FVector position)
		{
			TsHotFixActionHandle_C.__OnTouchReleaseAction_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__OnTouchReleaseAction_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(TsHotFixActionHandle_C.__OnTouchReleaseAction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__OnTouchReleaseAction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->touchIndex = touchIndex;
			ptr->position = position;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__OnTouchReleaseAction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00008FB4 File Offset: 0x000071B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnTouchPressAction(ETouchIndex touchIndex, FVector position)
		{
			TsHotFixActionHandle_C.__OnTouchPressAction_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__OnTouchPressAction_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(TsHotFixActionHandle_C.__OnTouchPressAction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__OnTouchPressAction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->touchIndex = touchIndex;
			ptr->position = position;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__OnTouchPressAction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00009008 File Offset: 0x00007208
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddTouchReleaseBinding(APlayerController controller)
		{
			TsHotFixActionHandle_C.__AddTouchReleaseBinding_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__AddTouchReleaseBinding_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(TsHotFixActionHandle_C.__AddTouchReleaseBinding_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__AddTouchReleaseBinding_NativeFunctionPtr, (void*)ptr, 1);
			ptr->controller = ((controller != null) ? controller.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__AddTouchReleaseBinding_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00009060 File Offset: 0x00007260
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddTouchPressBinding(APlayerController controller)
		{
			TsHotFixActionHandle_C.__AddTouchPressBinding_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__AddTouchPressBinding_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(TsHotFixActionHandle_C.__AddTouchPressBinding_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__AddTouchPressBinding_NativeFunctionPtr, (void*)ptr, 1);
			ptr->controller = ((controller != null) ? controller.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__AddTouchPressBinding_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000090B8 File Offset: 0x000072B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddReleaseBinding(string actionName, [Nullable(2)] APlayerController controller)
		{
			TsHotFixActionHandle_C.__AddReleaseBinding_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__AddReleaseBinding_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(TsHotFixActionHandle_C.__AddReleaseBinding_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__AddReleaseBinding_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->actionName), actionName);
			ptr->controller = ((controller != null) ? controller.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__AddReleaseBinding_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(TsHotFixActionHandle_C.__AddReleaseBinding_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000912C File Offset: 0x0000732C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddPressBinding(string actionName, [Nullable(2)] APlayerController controller)
		{
			TsHotFixActionHandle_C.__AddPressBinding_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__AddPressBinding_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(TsHotFixActionHandle_C.__AddPressBinding_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__AddPressBinding_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->actionName), actionName);
			ptr->controller = ((controller != null) ? controller.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__AddPressBinding_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(TsHotFixActionHandle_C.__AddPressBinding_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000091A0 File Offset: 0x000073A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnReleaseAction(FKey Key)
		{
			TsHotFixActionHandle_C.__OnReleaseAction_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__OnReleaseAction_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(TsHotFixActionHandle_C.__OnReleaseAction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__OnReleaseAction_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__OnReleaseAction_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(TsHotFixActionHandle_C.__OnReleaseAction_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00009214 File Offset: 0x00007414
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnPressAction(FKey key)
		{
			TsHotFixActionHandle_C.__OnPressAction_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__OnPressAction_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(TsHotFixActionHandle_C.__OnPressAction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__OnPressAction_NativeFunctionPtr, (void*)ptr, 1);
			if (key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->key, key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__OnPressAction_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(TsHotFixActionHandle_C.__OnPressAction_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00009286 File Offset: 0x00007486
		protected TsHotFixActionHandle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000084 RID: 132
		public new const string __ObjectPath = "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C";

		// Token: 0x04000085 RID: 133
		private static IntPtr _ClassPtr;

		// Token: 0x04000086 RID: 134
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000087 RID: 135
		public static IntPtr __OnAnyKeyPressCallback__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000088 RID: 136
		public static IntPtr __OnAxisCallback__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000089 RID: 137
		public static IntPtr __OnTouchMovedActionCallback__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400008A RID: 138
		public static IntPtr __OnTouchActionCallback__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400008B RID: 139
		public static IntPtr __OnPressActionCallback__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400008C RID: 140
		internal static int __PropertyOffset_0;

		// Token: 0x0400008D RID: 141
		internal static int __PropertyOffset_1;

		// Token: 0x0400008E RID: 142
		internal static int __PropertyOffset_2;

		// Token: 0x0400008F RID: 143
		internal static int __PropertyOffset_3;

		// Token: 0x04000090 RID: 144
		internal static int __PropertyOffset_4;

		// Token: 0x04000091 RID: 145
		[Nullable(2)]
		private OnPressActionCallback _OnPressActionCallback;

		// Token: 0x04000092 RID: 146
		internal static int __PropertyOffset_5;

		// Token: 0x04000093 RID: 147
		internal static int __PropertyOffset_6;

		// Token: 0x04000094 RID: 148
		internal static int __PropertyOffset_7;

		// Token: 0x04000095 RID: 149
		[Nullable(2)]
		private OnTouchActionCallback _OnTouchActionCallback;

		// Token: 0x04000096 RID: 150
		internal static int __PropertyOffset_8;

		// Token: 0x04000097 RID: 151
		[Nullable(2)]
		private OnTouchMovedActionCallback _OnTouchMovedActionCallback;

		// Token: 0x04000098 RID: 152
		internal static int __PropertyOffset_9;

		// Token: 0x04000099 RID: 153
		[Nullable(2)]
		private OnAxisCallback _OnAxisCallback;

		// Token: 0x0400009A RID: 154
		internal static int __PropertyOffset_10;

		// Token: 0x0400009B RID: 155
		internal static int __PropertyOffset_11;

		// Token: 0x0400009C RID: 156
		internal static int __PropertyOffset_12;

		// Token: 0x0400009D RID: 157
		[Nullable(2)]
		private OnAnyKeyPressCallback _OnAnyKeyPressCallback;

		// Token: 0x0400009E RID: 158
		private static IntPtr __OnAnyKeyPressAction_NativeFunctionPtr;

		// Token: 0x0400009F RID: 159
		private static IntPtr __ClearKeyBinding_NativeFunctionPtr;

		// Token: 0x040000A0 RID: 160
		private static IntPtr __AddAnyKeyPress_NativeFunctionPtr;

		// Token: 0x040000A1 RID: 161
		private static IntPtr __ClearAxisBinding_NativeFunctionPtr;

		// Token: 0x040000A2 RID: 162
		private static IntPtr __OnAxisInput_NativeFunctionPtr;

		// Token: 0x040000A3 RID: 163
		private static IntPtr __AddAxisBinding_NativeFunctionPtr;

		// Token: 0x040000A4 RID: 164
		private static IntPtr __AddTouchMoveBinding_NativeFunctionPtr;

		// Token: 0x040000A5 RID: 165
		private static IntPtr __OnTouchMoveAction_NativeFunctionPtr;

		// Token: 0x040000A6 RID: 166
		private static IntPtr __ClearActionBinding_NativeFunctionPtr;

		// Token: 0x040000A7 RID: 167
		private static IntPtr __OnTouchReleaseAction_NativeFunctionPtr;

		// Token: 0x040000A8 RID: 168
		private static IntPtr __OnTouchPressAction_NativeFunctionPtr;

		// Token: 0x040000A9 RID: 169
		private static IntPtr __AddTouchReleaseBinding_NativeFunctionPtr;

		// Token: 0x040000AA RID: 170
		private static IntPtr __AddTouchPressBinding_NativeFunctionPtr;

		// Token: 0x040000AB RID: 171
		private static IntPtr __AddReleaseBinding_NativeFunctionPtr;

		// Token: 0x040000AC RID: 172
		private static IntPtr __AddPressBinding_NativeFunctionPtr;

		// Token: 0x040000AD RID: 173
		private static IntPtr __OnReleaseAction_NativeFunctionPtr;

		// Token: 0x040000AE RID: 174
		private static IntPtr __OnPressAction_NativeFunctionPtr;

		// Token: 0x02000299 RID: 665
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnAnyKeyPressAction_FunctionParams
		{
			// Token: 0x04000A5E RID: 2654
			[FieldOffset(0)]
			public byte key;
		}

		// Token: 0x0200029A RID: 666
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ClearKeyBinding_FunctionParams
		{
			// Token: 0x04000A5F RID: 2655
			[FieldOffset(0)]
			public IntPtr controller;
		}

		// Token: 0x0200029B RID: 667
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __AddAnyKeyPress_FunctionParams
		{
			// Token: 0x04000A60 RID: 2656
			[FieldOffset(0)]
			public IntPtr controller;

			// Token: 0x04000A61 RID: 2657
			[FieldOffset(8)]
			public byte chord;
		}

		// Token: 0x0200029C RID: 668
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ClearAxisBinding_FunctionParams
		{
			// Token: 0x04000A62 RID: 2658
			[FieldOffset(0)]
			public IntPtr controller;
		}

		// Token: 0x0200029D RID: 669
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnAxisInput_FunctionParams
		{
			// Token: 0x04000A63 RID: 2659
			[FieldOffset(0)]
			public float value;
		}

		// Token: 0x0200029E RID: 670
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddAxisBinding_FunctionParams
		{
			// Token: 0x04000A64 RID: 2660
			[FieldOffset(0)]
			public FString axisName;

			// Token: 0x04000A65 RID: 2661
			[FieldOffset(16)]
			public IntPtr controller;
		}

		// Token: 0x0200029F RID: 671
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __AddTouchMoveBinding_FunctionParams
		{
			// Token: 0x04000A66 RID: 2662
			[FieldOffset(0)]
			public IntPtr controller;
		}

		// Token: 0x020002A0 RID: 672
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnTouchMoveAction_FunctionParams
		{
			// Token: 0x04000A67 RID: 2663
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> touchindex;

			// Token: 0x04000A68 RID: 2664
			[FieldOffset(4)]
			public FVector position;
		}

		// Token: 0x020002A1 RID: 673
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ClearActionBinding_FunctionParams
		{
			// Token: 0x04000A69 RID: 2665
			[FieldOffset(0)]
			public IntPtr controller;
		}

		// Token: 0x020002A2 RID: 674
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnTouchReleaseAction_FunctionParams
		{
			// Token: 0x04000A6A RID: 2666
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> touchIndex;

			// Token: 0x04000A6B RID: 2667
			[FieldOffset(4)]
			public FVector position;
		}

		// Token: 0x020002A3 RID: 675
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnTouchPressAction_FunctionParams
		{
			// Token: 0x04000A6C RID: 2668
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> touchIndex;

			// Token: 0x04000A6D RID: 2669
			[FieldOffset(4)]
			public FVector position;
		}

		// Token: 0x020002A4 RID: 676
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __AddTouchReleaseBinding_FunctionParams
		{
			// Token: 0x04000A6E RID: 2670
			[FieldOffset(0)]
			public IntPtr controller;
		}

		// Token: 0x020002A5 RID: 677
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __AddTouchPressBinding_FunctionParams
		{
			// Token: 0x04000A6F RID: 2671
			[FieldOffset(0)]
			public IntPtr controller;
		}

		// Token: 0x020002A6 RID: 678
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddReleaseBinding_FunctionParams
		{
			// Token: 0x04000A70 RID: 2672
			[FieldOffset(0)]
			public FString actionName;

			// Token: 0x04000A71 RID: 2673
			[FieldOffset(16)]
			public IntPtr controller;
		}

		// Token: 0x020002A7 RID: 679
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddPressBinding_FunctionParams
		{
			// Token: 0x04000A72 RID: 2674
			[FieldOffset(0)]
			public FString actionName;

			// Token: 0x04000A73 RID: 2675
			[FieldOffset(16)]
			public IntPtr controller;
		}

		// Token: 0x020002A8 RID: 680
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnReleaseAction_FunctionParams
		{
			// Token: 0x04000A74 RID: 2676
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x020002A9 RID: 681
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnPressAction_FunctionParams
		{
			// Token: 0x04000A75 RID: 2677
			[FieldOffset(0)]
			public byte key;
		}
	}
}
