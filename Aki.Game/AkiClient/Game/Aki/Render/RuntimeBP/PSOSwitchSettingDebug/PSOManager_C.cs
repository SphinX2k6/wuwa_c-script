using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PSOSwitchSettingDebug
{
	// Token: 0x02003BCC RID: 15308
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/PSOManager.PSOManager_C")]
	[UnrealStructLayout(1472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1465)]
	public class PSOManager_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602253D RID: 140605 RVA: 0x00905E37 File Offset: 0x00904037
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PSOManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/PSOManager.PSOManager_C");
			}
			return PSOManager_C._ClassPtr;
		}

		// Token: 0x0602253E RID: 140606 RVA: 0x00905E5C File Offset: 0x0090405C
		public PSOManager_C() : this(BuiltinUtils.AllocNativeUObject(PSOManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602253F RID: 140607 RVA: 0x00905E84 File Offset: 0x00904084
		[NullableContext(1)]
		public PSOManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PSOManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003AF7 RID: 15095
		// (get) Token: 0x06022540 RID: 140608 RVA: 0x00905EB7 File Offset: 0x009040B7
		// (set) Token: 0x06022541 RID: 140609 RVA: 0x00905ECB File Offset: 0x009040CB
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + PSOManager_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PSOManager_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003AF8 RID: 15096
		// (get) Token: 0x06022542 RID: 140610 RVA: 0x00905EE0 File Offset: 0x009040E0
		// (set) Token: 0x06022543 RID: 140611 RVA: 0x00905EF0 File Offset: 0x009040F0
		public unsafe bool ubinstance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PSOManager_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PSOManager_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022544 RID: 140612 RVA: 0x00905F04 File Offset: 0x00904104
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			PSOManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc PSOManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(PSOManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PSOManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PSOManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022545 RID: 140613 RVA: 0x00905F4C File Offset: 0x0090414C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			PSOManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc PSOManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(PSOManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PSOManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, PSOManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022546 RID: 140614 RVA: 0x00905F94 File Offset: 0x00904194
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			PSOManager_C.__EditorTick_FunctionParams* ptr = stackalloc PSOManager_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(PSOManager_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PSOManager_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PSOManager_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022547 RID: 140615 RVA: 0x00905FDC File Offset: 0x009041DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			PSOManager_C.__EditorTick_FunctionParams* ptr = stackalloc PSOManager_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(PSOManager_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PSOManager_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, PSOManager_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022548 RID: 140616 RVA: 0x00906023 File Offset: 0x00904223
		protected PSOManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D6F RID: 68975
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/PSOManager.PSOManager_C";

		// Token: 0x04010D70 RID: 68976
		private static IntPtr _ClassPtr;

		// Token: 0x04010D71 RID: 68977
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D72 RID: 68978
		internal static int __PropertyOffset_1;

		// Token: 0x04010D73 RID: 68979
		internal static int __PropertyOffset_2;

		// Token: 0x04010D74 RID: 68980
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010D75 RID: 68981
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009D65 RID: 40293
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314E2 RID: 201954
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D66 RID: 40294
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040314E3 RID: 201955
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
