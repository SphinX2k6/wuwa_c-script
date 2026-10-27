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
	// Token: 0x02003D55 RID: 15701
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_ZhongQuTaiDi.BP_Cloud_ZhongQuTaiDi_C")]
	[UnrealStructLayout(1944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1944)]
	public class BP_Cloud_ZhongQuTaiDi_C : BP_CloudPrefab_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060263EA RID: 156650 RVA: 0x0096FB24 File Offset: 0x0096DD24
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cloud_ZhongQuTaiDi_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_ZhongQuTaiDi.BP_Cloud_ZhongQuTaiDi_C");
			}
			return BP_Cloud_ZhongQuTaiDi_C._ClassPtr;
		}

		// Token: 0x060263EB RID: 156651 RVA: 0x0096FB48 File Offset: 0x0096DD48
		public BP_Cloud_ZhongQuTaiDi_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_ZhongQuTaiDi_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060263EC RID: 156652 RVA: 0x0096FB70 File Offset: 0x0096DD70
		[NullableContext(1)]
		public BP_Cloud_ZhongQuTaiDi_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_ZhongQuTaiDi_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060263ED RID: 156653 RVA: 0x0096FBA3 File Offset: 0x0096DDA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_ZhongQuTaiDi_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060263EE RID: 156654 RVA: 0x0096FBB7 File Offset: 0x0096DDB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_ZhongQuTaiDi_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060263EF RID: 156655 RVA: 0x0096FBCC File Offset: 0x0096DDCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cloud_ZhongQuTaiDi_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_ZhongQuTaiDi_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_ZhongQuTaiDi_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_ZhongQuTaiDi_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_ZhongQuTaiDi_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263F0 RID: 156656 RVA: 0x0096FC14 File Offset: 0x0096DE14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_ZhongQuTaiDi_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_ZhongQuTaiDi_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_ZhongQuTaiDi_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_ZhongQuTaiDi_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_ZhongQuTaiDi_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263F1 RID: 156657 RVA: 0x0096FC5C File Offset: 0x0096DE5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Cloud_ZhongQuTaiDi_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_ZhongQuTaiDi_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_ZhongQuTaiDi_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_ZhongQuTaiDi_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_ZhongQuTaiDi_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263F2 RID: 156658 RVA: 0x0096FCA4 File Offset: 0x0096DEA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_ZhongQuTaiDi_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_ZhongQuTaiDi_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_ZhongQuTaiDi_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_ZhongQuTaiDi_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_ZhongQuTaiDi_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263F3 RID: 156659 RVA: 0x0096FCEB File Offset: 0x0096DEEB
		protected BP_Cloud_ZhongQuTaiDi_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013279 RID: 78457
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_ZhongQuTaiDi.BP_Cloud_ZhongQuTaiDi_C";

		// Token: 0x0401327A RID: 78458
		private static IntPtr _ClassPtr;

		// Token: 0x0401327B RID: 78459
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401327C RID: 78460
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401327D RID: 78461
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401327E RID: 78462
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A0D5 RID: 41173
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031BDA RID: 203738
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A0D6 RID: 41174
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031BDB RID: 203739
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
