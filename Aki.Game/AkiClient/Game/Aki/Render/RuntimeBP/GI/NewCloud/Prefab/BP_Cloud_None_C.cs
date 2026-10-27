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
	// Token: 0x02003D4F RID: 15695
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_None.BP_Cloud_None_C")]
	[UnrealStructLayout(1944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1944)]
	public class BP_Cloud_None_C : BP_CloudPrefab_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060263A4 RID: 156580 RVA: 0x0096ED74 File Offset: 0x0096CF74
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cloud_None_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_None.BP_Cloud_None_C");
			}
			return BP_Cloud_None_C._ClassPtr;
		}

		// Token: 0x060263A5 RID: 156581 RVA: 0x0096ED98 File Offset: 0x0096CF98
		public BP_Cloud_None_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_None_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060263A6 RID: 156582 RVA: 0x0096EDC0 File Offset: 0x0096CFC0
		[NullableContext(1)]
		public BP_Cloud_None_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_None_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060263A7 RID: 156583 RVA: 0x0096EDF4 File Offset: 0x0096CFF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Hidden(bool InstantHide)
		{
			BP_Cloud_None_C.__Hidden_FunctionParams* ptr = stackalloc BP_Cloud_None_C.__Hidden_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_None_C.__Hidden_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_None_C.__Hidden_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InstantHide = InstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_None_C.__Hidden_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263A8 RID: 156584 RVA: 0x0096EE3C File Offset: 0x0096D03C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Active(bool bInstantHide)
		{
			BP_Cloud_None_C.__Active_FunctionParams* ptr = stackalloc BP_Cloud_None_C.__Active_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_None_C.__Active_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_None_C.__Active_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInstantHide = bInstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_None_C.__Active_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263A9 RID: 156585 RVA: 0x0096EE82 File Offset: 0x0096D082
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_None_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060263AA RID: 156586 RVA: 0x0096EE96 File Offset: 0x0096D096
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_None_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060263AB RID: 156587 RVA: 0x0096EEAC File Offset: 0x0096D0AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cloud_None_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_None_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_None_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_None_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_None_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263AC RID: 156588 RVA: 0x0096EEF4 File Offset: 0x0096D0F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_None_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_None_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_None_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_None_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_None_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263AD RID: 156589 RVA: 0x0096EF3C File Offset: 0x0096D13C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Cloud_None_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_None_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_None_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_None_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_None_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263AE RID: 156590 RVA: 0x0096EF84 File Offset: 0x0096D184
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_None_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_None_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_None_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_None_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_None_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263AF RID: 156591 RVA: 0x0096EFCB File Offset: 0x0096D1CB
		protected BP_Cloud_None_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401324B RID: 78411
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_None.BP_Cloud_None_C";

		// Token: 0x0401324C RID: 78412
		private static IntPtr _ClassPtr;

		// Token: 0x0401324D RID: 78413
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401324E RID: 78414
		private static IntPtr __Hidden_NativeFunctionPtr;

		// Token: 0x0401324F RID: 78415
		private static IntPtr __Active_NativeFunctionPtr;

		// Token: 0x04013250 RID: 78416
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013251 RID: 78417
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013252 RID: 78418
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A0BF RID: 41151
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Hidden_FunctionParams
		{
			// Token: 0x04031BC4 RID: 203716
			[FieldOffset(0)]
			public bool InstantHide;
		}

		// Token: 0x0200A0C0 RID: 41152
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Active_FunctionParams
		{
			// Token: 0x04031BC5 RID: 203717
			[FieldOffset(0)]
			public bool bInstantHide;
		}

		// Token: 0x0200A0C1 RID: 41153
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031BC6 RID: 203718
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A0C2 RID: 41154
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031BC7 RID: 203719
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
