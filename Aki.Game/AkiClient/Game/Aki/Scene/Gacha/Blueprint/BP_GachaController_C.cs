using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.Gacha.Blueprint
{
	// Token: 0x02003A68 RID: 14952
	[UnrealObjectPath("/Game/Aki/Scene/Gacha/Blueprint/BP_GachaController.BP_GachaController_C")]
	[UnrealStructLayout(2072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2072)]
	public class BP_GachaController_C : APlayerController, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F997 RID: 129431 RVA: 0x008BCEA4 File Offset: 0x008BB0A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GachaController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Scene/Gacha/Blueprint/BP_GachaController.BP_GachaController_C");
			}
			return BP_GachaController_C._ClassPtr;
		}

		// Token: 0x0601F998 RID: 129432 RVA: 0x008BCEC8 File Offset: 0x008BB0C8
		public BP_GachaController_C() : this(BuiltinUtils.AllocNativeUObject(BP_GachaController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F999 RID: 129433 RVA: 0x008BCEF0 File Offset: 0x008BB0F0
		[NullableContext(1)]
		public BP_GachaController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GachaController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x0601F99A RID: 129434 RVA: 0x008BCF23 File Offset: 0x008BB123
		// (set) Token: 0x0601F99B RID: 129435 RVA: 0x008BCF33 File Offset: 0x008BB133
		public unsafe bool LeftMouseBottomClick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaController_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaController_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x0601F99C RID: 129436 RVA: 0x008BCF44 File Offset: 0x008BB144
		// (set) Token: 0x0601F99D RID: 129437 RVA: 0x008BCF54 File Offset: 0x008BB154
		public unsafe float Camera_Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaController_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaController_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x0601F99E RID: 129438 RVA: 0x008BCF65 File Offset: 0x008BB165
		// (set) Token: 0x0601F99F RID: 129439 RVA: 0x008BCF79 File Offset: 0x008BB179
		[Nullable(2)]
		public unsafe BP_GachaArt_C CurrentWildCardsPawn
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GachaArt_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaController_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaController_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x0601F9A0 RID: 129440 RVA: 0x008BCF8E File Offset: 0x008BB18E
		// (set) Token: 0x0601F9A1 RID: 129441 RVA: 0x008BCF9E File Offset: 0x008BB19E
		public unsafe float Process
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaController_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaController_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x0601F9A2 RID: 129442 RVA: 0x008BCFAF File Offset: 0x008BB1AF
		// (set) Token: 0x0601F9A3 RID: 129443 RVA: 0x008BCFBF File Offset: 0x008BB1BF
		public unsafe float GoldenProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaController_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaController_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0601F9A4 RID: 129444 RVA: 0x008BCFD0 File Offset: 0x008BB1D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateProcess()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaController_C.__UpdateProcess_NativeFunctionPtr, null);
		}

		// Token: 0x0601F9A5 RID: 129445 RVA: 0x008BCFE4 File Offset: 0x008BB1E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateCursor(float DistanceRatio)
		{
			BP_GachaController_C.__UpdateCursor_FunctionParams* ptr = stackalloc BP_GachaController_C.__UpdateCursor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GachaController_C.__UpdateCursor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaController_C.__UpdateCursor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DistanceRatio = DistanceRatio;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaController_C.__UpdateCursor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F9A6 RID: 129446 RVA: 0x008BD02C File Offset: 0x008BB22C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateCenterDisk(float DistanceRatio)
		{
			BP_GachaController_C.__UpdateCenterDisk_FunctionParams* ptr = stackalloc BP_GachaController_C.__UpdateCenterDisk_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GachaController_C.__UpdateCenterDisk_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaController_C.__UpdateCenterDisk_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DistanceRatio = DistanceRatio;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaController_C.__UpdateCenterDisk_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F9A7 RID: 129447 RVA: 0x008BD072 File Offset: 0x008BB272
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GetCurrentPawn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaController_C.__GetCurrentPawn_NativeFunctionPtr, null);
		}

		// Token: 0x0601F9A8 RID: 129448 RVA: 0x008BD086 File Offset: 0x008BB286
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F9A9 RID: 129449 RVA: 0x008BD09A File Offset: 0x008BB29A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaController_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F9AA RID: 129450 RVA: 0x008BD0B0 File Offset: 0x008BB2B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GachaController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GachaController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GachaController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F9AB RID: 129451 RVA: 0x008BD0F8 File Offset: 0x008BB2F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GachaController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GachaController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GachaController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F9AC RID: 129452 RVA: 0x008BD13F File Offset: 0x008BB33F
		protected BP_GachaController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F31E RID: 62238
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Scene/Gacha/Blueprint/BP_GachaController.BP_GachaController_C";

		// Token: 0x0400F31F RID: 62239
		private static IntPtr _ClassPtr;

		// Token: 0x0400F320 RID: 62240
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F321 RID: 62241
		internal static int __PropertyOffset_1;

		// Token: 0x0400F322 RID: 62242
		internal static int __PropertyOffset_2;

		// Token: 0x0400F323 RID: 62243
		internal static int __PropertyOffset_3;

		// Token: 0x0400F324 RID: 62244
		internal static int __PropertyOffset_4;

		// Token: 0x0400F325 RID: 62245
		internal static int __PropertyOffset_5;

		// Token: 0x0400F326 RID: 62246
		private static IntPtr __UpdateProcess_NativeFunctionPtr;

		// Token: 0x0400F327 RID: 62247
		private static IntPtr __UpdateCursor_NativeFunctionPtr;

		// Token: 0x0400F328 RID: 62248
		private static IntPtr __UpdateCenterDisk_NativeFunctionPtr;

		// Token: 0x0400F329 RID: 62249
		private static IntPtr __GetCurrentPawn_NativeFunctionPtr;

		// Token: 0x0400F32A RID: 62250
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F32B RID: 62251
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009B11 RID: 39697
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __UpdateCursor_FunctionParams
		{
			// Token: 0x040310E9 RID: 200937
			[FieldOffset(0)]
			public float DistanceRatio;
		}

		// Token: 0x02009B12 RID: 39698
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __UpdateCenterDisk_FunctionParams
		{
			// Token: 0x040310EA RID: 200938
			[FieldOffset(0)]
			public float DistanceRatio;
		}

		// Token: 0x02009B13 RID: 39699
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040310EB RID: 200939
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
