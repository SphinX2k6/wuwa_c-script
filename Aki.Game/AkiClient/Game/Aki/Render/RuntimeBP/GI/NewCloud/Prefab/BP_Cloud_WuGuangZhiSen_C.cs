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
	// Token: 0x02003D51 RID: 15697
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_WuGuangZhiSen.BP_Cloud_WuGuangZhiSen_C")]
	[UnrealStructLayout(1944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1944)]
	public class BP_Cloud_WuGuangZhiSen_C : BP_CloudPrefab_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060263BC RID: 156604 RVA: 0x0096F234 File Offset: 0x0096D434
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cloud_WuGuangZhiSen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_WuGuangZhiSen.BP_Cloud_WuGuangZhiSen_C");
			}
			return BP_Cloud_WuGuangZhiSen_C._ClassPtr;
		}

		// Token: 0x060263BD RID: 156605 RVA: 0x0096F258 File Offset: 0x0096D458
		public BP_Cloud_WuGuangZhiSen_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_WuGuangZhiSen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060263BE RID: 156606 RVA: 0x0096F280 File Offset: 0x0096D480
		[NullableContext(1)]
		public BP_Cloud_WuGuangZhiSen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_WuGuangZhiSen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060263BF RID: 156607 RVA: 0x0096F2B4 File Offset: 0x0096D4B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Hidden(bool InstantHide)
		{
			BP_Cloud_WuGuangZhiSen_C.__Hidden_FunctionParams* ptr = stackalloc BP_Cloud_WuGuangZhiSen_C.__Hidden_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_WuGuangZhiSen_C.__Hidden_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_WuGuangZhiSen_C.__Hidden_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InstantHide = InstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_WuGuangZhiSen_C.__Hidden_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263C0 RID: 156608 RVA: 0x0096F2FC File Offset: 0x0096D4FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Active(bool bInstantHide)
		{
			BP_Cloud_WuGuangZhiSen_C.__Active_FunctionParams* ptr = stackalloc BP_Cloud_WuGuangZhiSen_C.__Active_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_WuGuangZhiSen_C.__Active_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_WuGuangZhiSen_C.__Active_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInstantHide = bInstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_WuGuangZhiSen_C.__Active_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263C1 RID: 156609 RVA: 0x0096F342 File Offset: 0x0096D542
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_WuGuangZhiSen_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060263C2 RID: 156610 RVA: 0x0096F356 File Offset: 0x0096D556
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_WuGuangZhiSen_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060263C3 RID: 156611 RVA: 0x0096F36C File Offset: 0x0096D56C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cloud_WuGuangZhiSen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_WuGuangZhiSen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_WuGuangZhiSen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_WuGuangZhiSen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_WuGuangZhiSen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263C4 RID: 156612 RVA: 0x0096F3B4 File Offset: 0x0096D5B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_WuGuangZhiSen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_WuGuangZhiSen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_WuGuangZhiSen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_WuGuangZhiSen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_WuGuangZhiSen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263C5 RID: 156613 RVA: 0x0096F3FC File Offset: 0x0096D5FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Cloud_WuGuangZhiSen_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_WuGuangZhiSen_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_WuGuangZhiSen_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_WuGuangZhiSen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_WuGuangZhiSen_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263C6 RID: 156614 RVA: 0x0096F444 File Offset: 0x0096D644
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_WuGuangZhiSen_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_WuGuangZhiSen_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_WuGuangZhiSen_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_WuGuangZhiSen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_WuGuangZhiSen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263C7 RID: 156615 RVA: 0x0096F48B File Offset: 0x0096D68B
		protected BP_Cloud_WuGuangZhiSen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401325B RID: 78427
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_WuGuangZhiSen.BP_Cloud_WuGuangZhiSen_C";

		// Token: 0x0401325C RID: 78428
		private static IntPtr _ClassPtr;

		// Token: 0x0401325D RID: 78429
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401325E RID: 78430
		private static IntPtr __Hidden_NativeFunctionPtr;

		// Token: 0x0401325F RID: 78431
		private static IntPtr __Active_NativeFunctionPtr;

		// Token: 0x04013260 RID: 78432
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013261 RID: 78433
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013262 RID: 78434
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A0C7 RID: 41159
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Hidden_FunctionParams
		{
			// Token: 0x04031BCC RID: 203724
			[FieldOffset(0)]
			public bool InstantHide;
		}

		// Token: 0x0200A0C8 RID: 41160
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Active_FunctionParams
		{
			// Token: 0x04031BCD RID: 203725
			[FieldOffset(0)]
			public bool bInstantHide;
		}

		// Token: 0x0200A0C9 RID: 41161
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031BCE RID: 203726
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A0CA RID: 41162
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031BCF RID: 203727
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
