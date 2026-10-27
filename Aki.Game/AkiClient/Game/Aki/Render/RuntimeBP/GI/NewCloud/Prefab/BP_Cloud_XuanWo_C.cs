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
	// Token: 0x02003D53 RID: 15699
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_XuanWo.BP_Cloud_XuanWo_C")]
	[UnrealStructLayout(1944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1944)]
	public class BP_Cloud_XuanWo_C : BP_CloudPrefab_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060263D4 RID: 156628 RVA: 0x0096F6F4 File Offset: 0x0096D8F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cloud_XuanWo_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_XuanWo.BP_Cloud_XuanWo_C");
			}
			return BP_Cloud_XuanWo_C._ClassPtr;
		}

		// Token: 0x060263D5 RID: 156629 RVA: 0x0096F718 File Offset: 0x0096D918
		public BP_Cloud_XuanWo_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_XuanWo_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060263D6 RID: 156630 RVA: 0x0096F740 File Offset: 0x0096D940
		[NullableContext(1)]
		public BP_Cloud_XuanWo_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_XuanWo_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060263D7 RID: 156631 RVA: 0x0096F774 File Offset: 0x0096D974
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Hidden(bool InstantHide)
		{
			BP_Cloud_XuanWo_C.__Hidden_FunctionParams* ptr = stackalloc BP_Cloud_XuanWo_C.__Hidden_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_XuanWo_C.__Hidden_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_XuanWo_C.__Hidden_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InstantHide = InstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_XuanWo_C.__Hidden_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263D8 RID: 156632 RVA: 0x0096F7BC File Offset: 0x0096D9BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Active(bool bInstantHide)
		{
			BP_Cloud_XuanWo_C.__Active_FunctionParams* ptr = stackalloc BP_Cloud_XuanWo_C.__Active_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_XuanWo_C.__Active_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_XuanWo_C.__Active_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInstantHide = bInstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_XuanWo_C.__Active_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263D9 RID: 156633 RVA: 0x0096F802 File Offset: 0x0096DA02
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_XuanWo_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060263DA RID: 156634 RVA: 0x0096F816 File Offset: 0x0096DA16
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_XuanWo_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060263DB RID: 156635 RVA: 0x0096F82C File Offset: 0x0096DA2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cloud_XuanWo_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_XuanWo_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_XuanWo_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_XuanWo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_XuanWo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263DC RID: 156636 RVA: 0x0096F874 File Offset: 0x0096DA74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_XuanWo_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_XuanWo_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_XuanWo_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_XuanWo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_XuanWo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263DD RID: 156637 RVA: 0x0096F8BC File Offset: 0x0096DABC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Cloud_XuanWo_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_XuanWo_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_XuanWo_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_XuanWo_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_XuanWo_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263DE RID: 156638 RVA: 0x0096F904 File Offset: 0x0096DB04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_XuanWo_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_XuanWo_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_XuanWo_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_XuanWo_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_XuanWo_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263DF RID: 156639 RVA: 0x0096F94B File Offset: 0x0096DB4B
		protected BP_Cloud_XuanWo_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401326B RID: 78443
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_XuanWo.BP_Cloud_XuanWo_C";

		// Token: 0x0401326C RID: 78444
		private static IntPtr _ClassPtr;

		// Token: 0x0401326D RID: 78445
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401326E RID: 78446
		private static IntPtr __Hidden_NativeFunctionPtr;

		// Token: 0x0401326F RID: 78447
		private static IntPtr __Active_NativeFunctionPtr;

		// Token: 0x04013270 RID: 78448
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013271 RID: 78449
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013272 RID: 78450
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A0CF RID: 41167
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Hidden_FunctionParams
		{
			// Token: 0x04031BD4 RID: 203732
			[FieldOffset(0)]
			public bool InstantHide;
		}

		// Token: 0x0200A0D0 RID: 41168
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Active_FunctionParams
		{
			// Token: 0x04031BD5 RID: 203733
			[FieldOffset(0)]
			public bool bInstantHide;
		}

		// Token: 0x0200A0D1 RID: 41169
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031BD6 RID: 203734
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A0D2 RID: 41170
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031BD7 RID: 203735
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
