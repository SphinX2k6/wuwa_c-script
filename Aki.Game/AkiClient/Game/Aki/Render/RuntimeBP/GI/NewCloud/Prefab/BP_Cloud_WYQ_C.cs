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
	// Token: 0x02003D52 RID: 15698
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_WYQ.BP_Cloud_WYQ_C")]
	[UnrealStructLayout(1944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1944)]
	public class BP_Cloud_WYQ_C : BP_CloudPrefab_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060263C8 RID: 156616 RVA: 0x0096F494 File Offset: 0x0096D694
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cloud_WYQ_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_WYQ.BP_Cloud_WYQ_C");
			}
			return BP_Cloud_WYQ_C._ClassPtr;
		}

		// Token: 0x060263C9 RID: 156617 RVA: 0x0096F4B8 File Offset: 0x0096D6B8
		public BP_Cloud_WYQ_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_WYQ_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060263CA RID: 156618 RVA: 0x0096F4E0 File Offset: 0x0096D6E0
		[NullableContext(1)]
		public BP_Cloud_WYQ_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_WYQ_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060263CB RID: 156619 RVA: 0x0096F514 File Offset: 0x0096D714
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Hidden(bool InstantHide)
		{
			BP_Cloud_WYQ_C.__Hidden_FunctionParams* ptr = stackalloc BP_Cloud_WYQ_C.__Hidden_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_WYQ_C.__Hidden_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_WYQ_C.__Hidden_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InstantHide = InstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_WYQ_C.__Hidden_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263CC RID: 156620 RVA: 0x0096F55C File Offset: 0x0096D75C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Active(bool bInstantHide)
		{
			BP_Cloud_WYQ_C.__Active_FunctionParams* ptr = stackalloc BP_Cloud_WYQ_C.__Active_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_WYQ_C.__Active_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_WYQ_C.__Active_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInstantHide = bInstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_WYQ_C.__Active_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263CD RID: 156621 RVA: 0x0096F5A2 File Offset: 0x0096D7A2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_WYQ_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060263CE RID: 156622 RVA: 0x0096F5B6 File Offset: 0x0096D7B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_WYQ_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060263CF RID: 156623 RVA: 0x0096F5CC File Offset: 0x0096D7CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cloud_WYQ_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_WYQ_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_WYQ_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_WYQ_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_WYQ_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263D0 RID: 156624 RVA: 0x0096F614 File Offset: 0x0096D814
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_WYQ_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_WYQ_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_WYQ_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_WYQ_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_WYQ_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263D1 RID: 156625 RVA: 0x0096F65C File Offset: 0x0096D85C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Cloud_WYQ_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_WYQ_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_WYQ_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_WYQ_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_WYQ_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263D2 RID: 156626 RVA: 0x0096F6A4 File Offset: 0x0096D8A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_WYQ_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_WYQ_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_WYQ_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_WYQ_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_WYQ_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263D3 RID: 156627 RVA: 0x0096F6EB File Offset: 0x0096D8EB
		protected BP_Cloud_WYQ_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013263 RID: 78435
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_WYQ.BP_Cloud_WYQ_C";

		// Token: 0x04013264 RID: 78436
		private static IntPtr _ClassPtr;

		// Token: 0x04013265 RID: 78437
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013266 RID: 78438
		private static IntPtr __Hidden_NativeFunctionPtr;

		// Token: 0x04013267 RID: 78439
		private static IntPtr __Active_NativeFunctionPtr;

		// Token: 0x04013268 RID: 78440
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013269 RID: 78441
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401326A RID: 78442
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A0CB RID: 41163
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Hidden_FunctionParams
		{
			// Token: 0x04031BD0 RID: 203728
			[FieldOffset(0)]
			public bool InstantHide;
		}

		// Token: 0x0200A0CC RID: 41164
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Active_FunctionParams
		{
			// Token: 0x04031BD1 RID: 203729
			[FieldOffset(0)]
			public bool bInstantHide;
		}

		// Token: 0x0200A0CD RID: 41165
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031BD2 RID: 203730
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A0CE RID: 41166
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031BD3 RID: 203731
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
