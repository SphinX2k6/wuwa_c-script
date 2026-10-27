using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneInteraction.WaterBlob
{
	// Token: 0x02003BB0 RID: 15280
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneInteraction/WaterBlob/BP_WaterBlob.BP_WaterBlob_C")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1688)]
	public class BP_WaterBlob_C : AKuroWaterBallUVChartInteraction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060221BC RID: 139708 RVA: 0x008FF6BB File Offset: 0x008FD8BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterBlob_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneInteraction/WaterBlob/BP_WaterBlob.BP_WaterBlob_C");
			}
			return BP_WaterBlob_C._ClassPtr;
		}

		// Token: 0x060221BD RID: 139709 RVA: 0x008FF6E0 File Offset: 0x008FD8E0
		public BP_WaterBlob_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterBlob_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060221BE RID: 139710 RVA: 0x008FF708 File Offset: 0x008FD908
		[NullableContext(1)]
		public BP_WaterBlob_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterBlob_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060221BF RID: 139711 RVA: 0x008FF73C File Offset: 0x008FD93C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterBlob_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterBlob_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterBlob_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBlob_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBlob_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221C0 RID: 139712 RVA: 0x008FF784 File Offset: 0x008FD984
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterBlob_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterBlob_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterBlob_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBlob_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBlob_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060221C1 RID: 139713 RVA: 0x008FF7CC File Offset: 0x008FD9CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_WaterBlob_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_WaterBlob_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_WaterBlob_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBlob_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBlob_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221C2 RID: 139714 RVA: 0x008FF830 File Offset: 0x008FDA30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WaterBlob_C.__BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterBlob_C.__BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WaterBlob_C.__BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBlob_C.__BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBlob_C.__BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221C3 RID: 139715 RVA: 0x008FF8EC File Offset: 0x008FDAEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WaterBlob_C.__BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterBlob_C.__BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WaterBlob_C.__BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBlob_C.__BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBlob_C.__BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221C4 RID: 139716 RVA: 0x008FF975 File Offset: 0x008FDB75
		protected BP_WaterBlob_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B3C RID: 68412
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneInteraction/WaterBlob/BP_WaterBlob.BP_WaterBlob_C";

		// Token: 0x04010B3D RID: 68413
		private static IntPtr _ClassPtr;

		// Token: 0x04010B3E RID: 68414
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B3F RID: 68415
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010B40 RID: 68416
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x04010B41 RID: 68417
		private static IntPtr __BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010B42 RID: 68418
		private static IntPtr __BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009D32 RID: 40242
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031474 RID: 201844
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D33 RID: 40243
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031475 RID: 201845
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031476 RID: 201846
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031477 RID: 201847
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009D34 RID: 40244
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031478 RID: 201848
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031479 RID: 201849
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403147A RID: 201850
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403147B RID: 201851
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403147C RID: 201852
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403147D RID: 201853
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D35 RID: 40245
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_WaterBlob_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403147E RID: 201854
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403147F RID: 201855
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031480 RID: 201856
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031481 RID: 201857
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
