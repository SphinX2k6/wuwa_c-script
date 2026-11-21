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
		// Token: 0x0600013F RID: 319 RVA: 0x000088A4 File Offset: 0x00006AA4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (TsHotFixActionHandle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C");
			}
			return TsHotFixActionHandle_C._ClassPtr;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000088C8 File Offset: 0x00006AC8
		public TsHotFixActionHandle_C() : this(BuiltinUtils.AllocNativeUObject(TsHotFixActionHandle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000088F0 File Offset: 0x00006AF0
		public TsHotFixActionHandle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsHotFixActionHandle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00008923 File Offset: 0x00006B23
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00008937 File Offset: 0x00006B37
		public unsafe FName FuncName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_FuncName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_FuncName) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000894C File Offset: 0x00006B4C
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00008960 File Offset: 0x00006B60
		[Nullable(2)]
		public unsafe UObject 目标
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + TsHotFixActionHandle_C.__PropertyOffset_目标);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsHotFixActionHandle_C.__PropertyOffset_目标, value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00008975 File Offset: 0x00006B75
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00008989 File Offset: 0x00006B89
		public unsafe string ActionName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsHotFixActionHandle_C.__PropertyOffset_ActionName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsHotFixActionHandle_C.__PropertyOffset_ActionName)), value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000899E File Offset: 0x00006B9E
		// (set) Token: 0x06000149 RID: 329 RVA: 0x000089AE File Offset: 0x00006BAE
		public unsafe bool bPress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_bPress) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_bPress) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000089C0 File Offset: 0x00006BC0
		// (set) Token: 0x0600014B RID: 331 RVA: 0x000089F9 File Offset: 0x00006BF9
		public OnPressActionCallback OnPressActionCallback
		{
			get
			{
				base.FastCheckIsValid();
				OnPressActionCallback result;
				if ((result = this._OnPressActionCallback) == null)
				{
					result = (this._OnPressActionCallback = new OnPressActionCallback(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_OnPressActionCallback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_OnPressActionCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00008A1A File Offset: 0x00006C1A
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00008A2E File Offset: 0x00006C2E
		[Nullable(0)]
		public unsafe TEnumAsByte<ETouchIndex> TouchIndex
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_TouchIndex);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_TouchIndex) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00008A43 File Offset: 0x00006C43
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00008A57 File Offset: 0x00006C57
		public unsafe FVector TouchPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_TouchPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_TouchPosition) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00008A6C File Offset: 0x00006C6C
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00008AA5 File Offset: 0x00006CA5
		public OnTouchActionCallback OnTouchActionCallback
		{
			get
			{
				base.FastCheckIsValid();
				OnTouchActionCallback result;
				if ((result = this._OnTouchActionCallback) == null)
				{
					result = (this._OnTouchActionCallback = new OnTouchActionCallback(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_OnTouchActionCallback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_OnTouchActionCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00008AC8 File Offset: 0x00006CC8
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00008B01 File Offset: 0x00006D01
		public OnTouchMovedActionCallback OnTouchMovedActionCallback
		{
			get
			{
				base.FastCheckIsValid();
				OnTouchMovedActionCallback result;
				if ((result = this._OnTouchMovedActionCallback) == null)
				{
					result = (this._OnTouchMovedActionCallback = new OnTouchMovedActionCallback(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_OnTouchMovedActionCallback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_OnTouchMovedActionCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00008B24 File Offset: 0x00006D24
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00008B5D File Offset: 0x00006D5D
		public OnAxisCallback OnAxisCallback
		{
			get
			{
				base.FastCheckIsValid();
				OnAxisCallback result;
				if ((result = this._OnAxisCallback) == null)
				{
					result = (this._OnAxisCallback = new OnAxisCallback(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_OnAxisCallback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_OnAxisCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00008B7E File Offset: 0x00006D7E
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00008B92 File Offset: 0x00006D92
		public unsafe string AxisName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsHotFixActionHandle_C.__PropertyOffset_AxisName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsHotFixActionHandle_C.__PropertyOffset_AxisName)), value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00008BA7 File Offset: 0x00006DA7
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00008BBB File Offset: 0x00006DBB
		public unsafe FName Func_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_Func_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_Func_Name) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00008BD0 File Offset: 0x00006DD0
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00008C09 File Offset: 0x00006E09
		public OnAnyKeyPressCallback OnAnyKeyPressCallback
		{
			get
			{
				base.FastCheckIsValid();
				OnAnyKeyPressCallback result;
				if ((result = this._OnAnyKeyPressCallback) == null)
				{
					result = (this._OnAnyKeyPressCallback = new OnAnyKeyPressCallback(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_OnAnyKeyPressCallback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)TsHotFixActionHandle_C.__PropertyOffset_OnAnyKeyPressCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00008C2C File Offset: 0x00006E2C
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

		// Token: 0x0600015D RID: 349 RVA: 0x00008CA0 File Offset: 0x00006EA0
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

		// Token: 0x0600015E RID: 350 RVA: 0x00008CF8 File Offset: 0x00006EF8
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

		// Token: 0x0600015F RID: 351 RVA: 0x00008D80 File Offset: 0x00006F80
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

		// Token: 0x06000160 RID: 352 RVA: 0x00008DD8 File Offset: 0x00006FD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnAxisInput(float value)
		{
			TsHotFixActionHandle_C.__OnAxisInput_FunctionParams* ptr = stackalloc TsHotFixActionHandle_C.__OnAxisInput_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(TsHotFixActionHandle_C.__OnAxisInput_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(TsHotFixActionHandle_C.__OnAxisInput_NativeFunctionPtr, (void*)ptr, 1);
			ptr->value = value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, TsHotFixActionHandle_C.__OnAxisInput_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00008E20 File Offset: 0x00007020
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

		// Token: 0x06000162 RID: 354 RVA: 0x00008E94 File Offset: 0x00007094
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

		// Token: 0x06000163 RID: 355 RVA: 0x00008EEC File Offset: 0x000070EC
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

		// Token: 0x06000164 RID: 356 RVA: 0x00008F40 File Offset: 0x00007140
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

		// Token: 0x06000165 RID: 357 RVA: 0x00008F98 File Offset: 0x00007198
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

		// Token: 0x06000166 RID: 358 RVA: 0x00008FEC File Offset: 0x000071EC
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

		// Token: 0x06000167 RID: 359 RVA: 0x00009040 File Offset: 0x00007240
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

		// Token: 0x06000168 RID: 360 RVA: 0x00009098 File Offset: 0x00007298
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

		// Token: 0x06000169 RID: 361 RVA: 0x000090F0 File Offset: 0x000072F0
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

		// Token: 0x0600016A RID: 362 RVA: 0x00009164 File Offset: 0x00007364
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

		// Token: 0x0600016B RID: 363 RVA: 0x000091D8 File Offset: 0x000073D8
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

		// Token: 0x0600016C RID: 364 RVA: 0x0000924C File Offset: 0x0000744C
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

		// Token: 0x0600016D RID: 365 RVA: 0x000092BE File Offset: 0x000074BE
		protected TsHotFixActionHandle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000085 RID: 133
		public new const string __ObjectPath = "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C";

		// Token: 0x04000086 RID: 134
		private static IntPtr _ClassPtr;

		// Token: 0x04000087 RID: 135
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000088 RID: 136
		public static IntPtr __OnAnyKeyPressCallback__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000089 RID: 137
		public static IntPtr __OnAxisCallback__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400008A RID: 138
		public static IntPtr __OnTouchMovedActionCallback__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400008B RID: 139
		public static IntPtr __OnTouchActionCallback__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400008C RID: 140
		public static IntPtr __OnPressActionCallback__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400008D RID: 141
		internal static int __PropertyOffset_FuncName;

		// Token: 0x0400008E RID: 142
		internal static int __PropertyOffset_目标;

		// Token: 0x0400008F RID: 143
		internal static int __PropertyOffset_ActionName;

		// Token: 0x04000090 RID: 144
		internal static int __PropertyOffset_bPress;

		// Token: 0x04000091 RID: 145
		internal static int __PropertyOffset_OnPressActionCallback;

		// Token: 0x04000092 RID: 146
		[Nullable(2)]
		private OnPressActionCallback _OnPressActionCallback;

		// Token: 0x04000093 RID: 147
		internal static int __PropertyOffset_TouchIndex;

		// Token: 0x04000094 RID: 148
		internal static int __PropertyOffset_TouchPosition;

		// Token: 0x04000095 RID: 149
		internal static int __PropertyOffset_OnTouchActionCallback;

		// Token: 0x04000096 RID: 150
		[Nullable(2)]
		private OnTouchActionCallback _OnTouchActionCallback;

		// Token: 0x04000097 RID: 151
		internal static int __PropertyOffset_OnTouchMovedActionCallback;

		// Token: 0x04000098 RID: 152
		[Nullable(2)]
		private OnTouchMovedActionCallback _OnTouchMovedActionCallback;

		// Token: 0x04000099 RID: 153
		internal static int __PropertyOffset_OnAxisCallback;

		// Token: 0x0400009A RID: 154
		[Nullable(2)]
		private OnAxisCallback _OnAxisCallback;

		// Token: 0x0400009B RID: 155
		internal static int __PropertyOffset_AxisName;

		// Token: 0x0400009C RID: 156
		internal static int __PropertyOffset_Func_Name;

		// Token: 0x0400009D RID: 157
		internal static int __PropertyOffset_OnAnyKeyPressCallback;

		// Token: 0x0400009E RID: 158
		[Nullable(2)]
		private OnAnyKeyPressCallback _OnAnyKeyPressCallback;

		// Token: 0x0400009F RID: 159
		private static IntPtr __OnAnyKeyPressAction_NativeFunctionPtr;

		// Token: 0x040000A0 RID: 160
		private static IntPtr __ClearKeyBinding_NativeFunctionPtr;

		// Token: 0x040000A1 RID: 161
		private static IntPtr __AddAnyKeyPress_NativeFunctionPtr;

		// Token: 0x040000A2 RID: 162
		private static IntPtr __ClearAxisBinding_NativeFunctionPtr;

		// Token: 0x040000A3 RID: 163
		private static IntPtr __OnAxisInput_NativeFunctionPtr;

		// Token: 0x040000A4 RID: 164
		private static IntPtr __AddAxisBinding_NativeFunctionPtr;

		// Token: 0x040000A5 RID: 165
		private static IntPtr __AddTouchMoveBinding_NativeFunctionPtr;

		// Token: 0x040000A6 RID: 166
		private static IntPtr __OnTouchMoveAction_NativeFunctionPtr;

		// Token: 0x040000A7 RID: 167
		private static IntPtr __ClearActionBinding_NativeFunctionPtr;

		// Token: 0x040000A8 RID: 168
		private static IntPtr __OnTouchReleaseAction_NativeFunctionPtr;

		// Token: 0x040000A9 RID: 169
		private static IntPtr __OnTouchPressAction_NativeFunctionPtr;

		// Token: 0x040000AA RID: 170
		private static IntPtr __AddTouchReleaseBinding_NativeFunctionPtr;

		// Token: 0x040000AB RID: 171
		private static IntPtr __AddTouchPressBinding_NativeFunctionPtr;

		// Token: 0x040000AC RID: 172
		private static IntPtr __AddReleaseBinding_NativeFunctionPtr;

		// Token: 0x040000AD RID: 173
		private static IntPtr __AddPressBinding_NativeFunctionPtr;

		// Token: 0x040000AE RID: 174
		private static IntPtr __OnReleaseAction_NativeFunctionPtr;

		// Token: 0x040000AF RID: 175
		private static IntPtr __OnPressAction_NativeFunctionPtr;

		// Token: 0x020002A2 RID: 674
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnAnyKeyPressAction_FunctionParams
		{
			// Token: 0x04000AAE RID: 2734
			[FieldOffset(0)]
			public byte key;
		}

		// Token: 0x020002A3 RID: 675
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ClearKeyBinding_FunctionParams
		{
			// Token: 0x04000AAF RID: 2735
			[FieldOffset(0)]
			public IntPtr controller;
		}

		// Token: 0x020002A4 RID: 676
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __AddAnyKeyPress_FunctionParams
		{
			// Token: 0x04000AB0 RID: 2736
			[FieldOffset(0)]
			public IntPtr controller;

			// Token: 0x04000AB1 RID: 2737
			[FieldOffset(8)]
			public byte chord;
		}

		// Token: 0x020002A5 RID: 677
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ClearAxisBinding_FunctionParams
		{
			// Token: 0x04000AB2 RID: 2738
			[FieldOffset(0)]
			public IntPtr controller;
		}

		// Token: 0x020002A6 RID: 678
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnAxisInput_FunctionParams
		{
			// Token: 0x04000AB3 RID: 2739
			[FieldOffset(0)]
			public float value;
		}

		// Token: 0x020002A7 RID: 679
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddAxisBinding_FunctionParams
		{
			// Token: 0x04000AB4 RID: 2740
			[FieldOffset(0)]
			public FString axisName;

			// Token: 0x04000AB5 RID: 2741
			[FieldOffset(16)]
			public IntPtr controller;
		}

		// Token: 0x020002A8 RID: 680
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __AddTouchMoveBinding_FunctionParams
		{
			// Token: 0x04000AB6 RID: 2742
			[FieldOffset(0)]
			public IntPtr controller;
		}

		// Token: 0x020002A9 RID: 681
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnTouchMoveAction_FunctionParams
		{
			// Token: 0x04000AB7 RID: 2743
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> touchindex;

			// Token: 0x04000AB8 RID: 2744
			[FieldOffset(4)]
			public FVector position;
		}

		// Token: 0x020002AA RID: 682
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ClearActionBinding_FunctionParams
		{
			// Token: 0x04000AB9 RID: 2745
			[FieldOffset(0)]
			public IntPtr controller;
		}

		// Token: 0x020002AB RID: 683
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnTouchReleaseAction_FunctionParams
		{
			// Token: 0x04000ABA RID: 2746
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> touchIndex;

			// Token: 0x04000ABB RID: 2747
			[FieldOffset(4)]
			public FVector position;
		}

		// Token: 0x020002AC RID: 684
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnTouchPressAction_FunctionParams
		{
			// Token: 0x04000ABC RID: 2748
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> touchIndex;

			// Token: 0x04000ABD RID: 2749
			[FieldOffset(4)]
			public FVector position;
		}

		// Token: 0x020002AD RID: 685
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __AddTouchReleaseBinding_FunctionParams
		{
			// Token: 0x04000ABE RID: 2750
			[FieldOffset(0)]
			public IntPtr controller;
		}

		// Token: 0x020002AE RID: 686
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __AddTouchPressBinding_FunctionParams
		{
			// Token: 0x04000ABF RID: 2751
			[FieldOffset(0)]
			public IntPtr controller;
		}

		// Token: 0x020002AF RID: 687
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddReleaseBinding_FunctionParams
		{
			// Token: 0x04000AC0 RID: 2752
			[FieldOffset(0)]
			public FString actionName;

			// Token: 0x04000AC1 RID: 2753
			[FieldOffset(16)]
			public IntPtr controller;
		}

		// Token: 0x020002B0 RID: 688
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddPressBinding_FunctionParams
		{
			// Token: 0x04000AC2 RID: 2754
			[FieldOffset(0)]
			public FString actionName;

			// Token: 0x04000AC3 RID: 2755
			[FieldOffset(16)]
			public IntPtr controller;
		}

		// Token: 0x020002B1 RID: 689
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnReleaseAction_FunctionParams
		{
			// Token: 0x04000AC4 RID: 2756
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x020002B2 RID: 690
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnPressAction_FunctionParams
		{
			// Token: 0x04000AC5 RID: 2757
			[FieldOffset(0)]
			public byte key;
		}
	}
}
