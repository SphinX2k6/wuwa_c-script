using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.Prefab
{
	// Token: 0x02003D50 RID: 15696
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_TianCheng.BP_Cloud_TianCheng_C")]
	[UnrealStructLayout(1944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1944)]
	public class BP_Cloud_TianCheng_C : BP_CloudPrefab_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060263B0 RID: 156592 RVA: 0x0096EFD4 File Offset: 0x0096D1D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cloud_TianCheng_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_TianCheng.BP_Cloud_TianCheng_C");
			}
			return BP_Cloud_TianCheng_C._ClassPtr;
		}

		// Token: 0x060263B1 RID: 156593 RVA: 0x0096EFF8 File Offset: 0x0096D1F8
		public BP_Cloud_TianCheng_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_TianCheng_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060263B2 RID: 156594 RVA: 0x0096F020 File Offset: 0x0096D220
		[NullableContext(1)]
		public BP_Cloud_TianCheng_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_TianCheng_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060263B3 RID: 156595 RVA: 0x0096F054 File Offset: 0x0096D254
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Hidden(bool InstantHide)
		{
			BP_Cloud_TianCheng_C.__Hidden_FunctionParams* ptr = stackalloc BP_Cloud_TianCheng_C.__Hidden_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_TianCheng_C.__Hidden_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_TianCheng_C.__Hidden_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InstantHide = InstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_TianCheng_C.__Hidden_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263B4 RID: 156596 RVA: 0x0096F09C File Offset: 0x0096D29C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Active(bool bInstantHide)
		{
			BP_Cloud_TianCheng_C.__Active_FunctionParams* ptr = stackalloc BP_Cloud_TianCheng_C.__Active_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_TianCheng_C.__Active_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_TianCheng_C.__Active_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInstantHide = bInstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_TianCheng_C.__Active_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263B5 RID: 156597 RVA: 0x0096F0E2 File Offset: 0x0096D2E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_TianCheng_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060263B6 RID: 156598 RVA: 0x0096F0F6 File Offset: 0x0096D2F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_TianCheng_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060263B7 RID: 156599 RVA: 0x0096F10C File Offset: 0x0096D30C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cloud_TianCheng_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_TianCheng_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_TianCheng_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_TianCheng_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_TianCheng_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263B8 RID: 156600 RVA: 0x0096F154 File Offset: 0x0096D354
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_TianCheng_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_TianCheng_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_TianCheng_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_TianCheng_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_TianCheng_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263B9 RID: 156601 RVA: 0x0096F19C File Offset: 0x0096D39C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Cloud_TianCheng_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_TianCheng_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_TianCheng_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_TianCheng_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_TianCheng_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263BA RID: 156602 RVA: 0x0096F1E4 File Offset: 0x0096D3E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_TianCheng_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_TianCheng_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_TianCheng_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_TianCheng_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_TianCheng_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263BB RID: 156603 RVA: 0x0096F22B File Offset: 0x0096D42B
		protected BP_Cloud_TianCheng_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013253 RID: 78419
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_TianCheng.BP_Cloud_TianCheng_C";

		// Token: 0x04013254 RID: 78420
		private static IntPtr _ClassPtr;

		// Token: 0x04013255 RID: 78421
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013256 RID: 78422
		private static IntPtr __Hidden_NativeFunctionPtr;

		// Token: 0x04013257 RID: 78423
		private static IntPtr __Active_NativeFunctionPtr;

		// Token: 0x04013258 RID: 78424
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013259 RID: 78425
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401325A RID: 78426
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A0C3 RID: 41155
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Hidden_FunctionParams
		{
			// Token: 0x04031BC8 RID: 203720
			[FieldOffset(0)]
			public bool InstantHide;
		}

		// Token: 0x0200A0C4 RID: 41156
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Active_FunctionParams
		{
			// Token: 0x04031BC9 RID: 203721
			[FieldOffset(0)]
			public bool bInstantHide;
		}

		// Token: 0x0200A0C5 RID: 41157
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031BCA RID: 203722
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A0C6 RID: 41158
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031BCB RID: 203723
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
