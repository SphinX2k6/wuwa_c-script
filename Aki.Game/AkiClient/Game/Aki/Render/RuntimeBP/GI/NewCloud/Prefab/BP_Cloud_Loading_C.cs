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
	// Token: 0x02003D4D RID: 15693
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_Loading.BP_Cloud_Loading_C")]
	[UnrealStructLayout(1944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1944)]
	public class BP_Cloud_Loading_C : BP_CloudPrefab_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602638C RID: 156556 RVA: 0x0096E8B4 File Offset: 0x0096CAB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cloud_Loading_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_Loading.BP_Cloud_Loading_C");
			}
			return BP_Cloud_Loading_C._ClassPtr;
		}

		// Token: 0x0602638D RID: 156557 RVA: 0x0096E8D8 File Offset: 0x0096CAD8
		public BP_Cloud_Loading_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_Loading_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602638E RID: 156558 RVA: 0x0096E900 File Offset: 0x0096CB00
		[NullableContext(1)]
		public BP_Cloud_Loading_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_Loading_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602638F RID: 156559 RVA: 0x0096E934 File Offset: 0x0096CB34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Hidden(bool InstantHide)
		{
			BP_Cloud_Loading_C.__Hidden_FunctionParams* ptr = stackalloc BP_Cloud_Loading_C.__Hidden_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_Loading_C.__Hidden_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_Loading_C.__Hidden_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InstantHide = InstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_Loading_C.__Hidden_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026390 RID: 156560 RVA: 0x0096E97C File Offset: 0x0096CB7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Active(bool bInstantHide)
		{
			BP_Cloud_Loading_C.__Active_FunctionParams* ptr = stackalloc BP_Cloud_Loading_C.__Active_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Cloud_Loading_C.__Active_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_Loading_C.__Active_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInstantHide = bInstantHide;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_Loading_C.__Active_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026391 RID: 156561 RVA: 0x0096E9C2 File Offset: 0x0096CBC2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_Loading_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026392 RID: 156562 RVA: 0x0096E9D6 File Offset: 0x0096CBD6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_Loading_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026393 RID: 156563 RVA: 0x0096E9EC File Offset: 0x0096CBEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cloud_Loading_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_Loading_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_Loading_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_Loading_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_Loading_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026394 RID: 156564 RVA: 0x0096EA34 File Offset: 0x0096CC34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_Loading_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_Loading_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_Loading_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_Loading_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_Loading_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026395 RID: 156565 RVA: 0x0096EA7C File Offset: 0x0096CC7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Cloud_Loading_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_Loading_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_Loading_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_Loading_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_Loading_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026396 RID: 156566 RVA: 0x0096EAC4 File Offset: 0x0096CCC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_Loading_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_Loading_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_Loading_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_Loading_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_Loading_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026397 RID: 156567 RVA: 0x0096EB0B File Offset: 0x0096CD0B
		protected BP_Cloud_Loading_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401323B RID: 78395
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_Loading.BP_Cloud_Loading_C";

		// Token: 0x0401323C RID: 78396
		private static IntPtr _ClassPtr;

		// Token: 0x0401323D RID: 78397
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401323E RID: 78398
		private static IntPtr __Hidden_NativeFunctionPtr;

		// Token: 0x0401323F RID: 78399
		private static IntPtr __Active_NativeFunctionPtr;

		// Token: 0x04013240 RID: 78400
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013241 RID: 78401
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013242 RID: 78402
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A0B7 RID: 41143
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Hidden_FunctionParams
		{
			// Token: 0x04031BBC RID: 203708
			[FieldOffset(0)]
			public bool InstantHide;
		}

		// Token: 0x0200A0B8 RID: 41144
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __Active_FunctionParams
		{
			// Token: 0x04031BBD RID: 203709
			[FieldOffset(0)]
			public bool bInstantHide;
		}

		// Token: 0x0200A0B9 RID: 41145
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031BBE RID: 203710
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A0BA RID: 41146
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031BBF RID: 203711
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
