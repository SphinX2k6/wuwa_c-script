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
	// Token: 0x02003D4E RID: 15694
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_MingChaoTianQi.BP_Cloud_MingChaoTianQi_C")]
	[UnrealStructLayout(1944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1944)]
	public class BP_Cloud_MingChaoTianQi_C : BP_CloudPrefab_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026398 RID: 156568 RVA: 0x0096EB14 File Offset: 0x0096CD14
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cloud_MingChaoTianQi_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_MingChaoTianQi.BP_Cloud_MingChaoTianQi_C");
			}
			return BP_Cloud_MingChaoTianQi_C._ClassPtr;
		}

		// Token: 0x06026399 RID: 156569 RVA: 0x0096EB38 File Offset: 0x0096CD38
		public BP_Cloud_MingChaoTianQi_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_MingChaoTianQi_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602639A RID: 156570 RVA: 0x0096EB60 File Offset: 0x0096CD60
		[NullableContext(1)]
		public BP_Cloud_MingChaoTianQi_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_MingChaoTianQi_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602639B RID: 156571 RVA: 0x0096EB94 File Offset: 0x0096CD94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Hidden(bool InstantHide)
		{
			BP_Cloud_MingChaoTianQi_C.__Hidden_FunctionParams* ptr = stackalloc BP_Cloud_MingChaoTianQi_C.__Hidden_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_MingChaoTianQi_C.__Hidden_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_MingChaoTianQi_C.__Hidden_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InstantHide = InstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_MingChaoTianQi_C.__Hidden_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602639C RID: 156572 RVA: 0x0096EBDC File Offset: 0x0096CDDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Active(bool bInstantHide)
		{
			BP_Cloud_MingChaoTianQi_C.__Active_FunctionParams* ptr = stackalloc BP_Cloud_MingChaoTianQi_C.__Active_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_MingChaoTianQi_C.__Active_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_MingChaoTianQi_C.__Active_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInstantHide = bInstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_MingChaoTianQi_C.__Active_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602639D RID: 156573 RVA: 0x0096EC22 File Offset: 0x0096CE22
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_MingChaoTianQi_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602639E RID: 156574 RVA: 0x0096EC36 File Offset: 0x0096CE36
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_MingChaoTianQi_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602639F RID: 156575 RVA: 0x0096EC4C File Offset: 0x0096CE4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cloud_MingChaoTianQi_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_MingChaoTianQi_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_MingChaoTianQi_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_MingChaoTianQi_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_MingChaoTianQi_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263A0 RID: 156576 RVA: 0x0096EC94 File Offset: 0x0096CE94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_MingChaoTianQi_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_MingChaoTianQi_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_MingChaoTianQi_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_MingChaoTianQi_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_MingChaoTianQi_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263A1 RID: 156577 RVA: 0x0096ECDC File Offset: 0x0096CEDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Cloud_MingChaoTianQi_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_MingChaoTianQi_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_MingChaoTianQi_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_MingChaoTianQi_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_MingChaoTianQi_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263A2 RID: 156578 RVA: 0x0096ED24 File Offset: 0x0096CF24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_MingChaoTianQi_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_MingChaoTianQi_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_MingChaoTianQi_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_MingChaoTianQi_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_MingChaoTianQi_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263A3 RID: 156579 RVA: 0x0096ED6B File Offset: 0x0096CF6B
		protected BP_Cloud_MingChaoTianQi_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013243 RID: 78403
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_MingChaoTianQi.BP_Cloud_MingChaoTianQi_C";

		// Token: 0x04013244 RID: 78404
		private static IntPtr _ClassPtr;

		// Token: 0x04013245 RID: 78405
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013246 RID: 78406
		private static IntPtr __Hidden_NativeFunctionPtr;

		// Token: 0x04013247 RID: 78407
		private static IntPtr __Active_NativeFunctionPtr;

		// Token: 0x04013248 RID: 78408
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013249 RID: 78409
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401324A RID: 78410
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A0BB RID: 41147
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Hidden_FunctionParams
		{
			// Token: 0x04031BC0 RID: 203712
			[FieldOffset(0)]
			public bool InstantHide;
		}

		// Token: 0x0200A0BC RID: 41148
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Active_FunctionParams
		{
			// Token: 0x04031BC1 RID: 203713
			[FieldOffset(0)]
			public bool bInstantHide;
		}

		// Token: 0x0200A0BD RID: 41149
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031BC2 RID: 203714
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A0BE RID: 41150
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031BC3 RID: 203715
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
