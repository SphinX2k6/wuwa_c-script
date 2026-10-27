using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneInteraction.WaterBall
{
	// Token: 0x02003BB1 RID: 15281
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneInteraction/WaterBall/BP_WaterBall.BP_WaterBall_C")]
	[UnrealStructLayout(1656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1656)]
	public class BP_WaterBall_C : AKuroWaterBallCubeInteraction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060221C5 RID: 139717 RVA: 0x008FF97E File Offset: 0x008FDB7E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterBall_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneInteraction/WaterBall/BP_WaterBall.BP_WaterBall_C");
			}
			return BP_WaterBall_C._ClassPtr;
		}

		// Token: 0x060221C6 RID: 139718 RVA: 0x008FF9A4 File Offset: 0x008FDBA4
		public BP_WaterBall_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterBall_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060221C7 RID: 139719 RVA: 0x008FF9CC File Offset: 0x008FDBCC
		[NullableContext(1)]
		public BP_WaterBall_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterBall_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060221C8 RID: 139720 RVA: 0x008FFA00 File Offset: 0x008FDC00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterBall_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterBall_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterBall_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBall_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBall_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221C9 RID: 139721 RVA: 0x008FFA48 File Offset: 0x008FDC48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterBall_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterBall_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterBall_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBall_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBall_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060221CA RID: 139722 RVA: 0x008FFA90 File Offset: 0x008FDC90
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WaterBall_C.__BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterBall_C.__BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WaterBall_C.__BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBall_C.__BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBall_C.__BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221CB RID: 139723 RVA: 0x008FFB4C File Offset: 0x008FDD4C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WaterBall_C.__BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterBall_C.__BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WaterBall_C.__BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBall_C.__BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBall_C.__BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221CC RID: 139724 RVA: 0x008FFBD8 File Offset: 0x008FDDD8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_WaterBall_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_WaterBall_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_WaterBall_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBall_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBall_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221CD RID: 139725 RVA: 0x008FFC3B File Offset: 0x008FDE3B
		protected BP_WaterBall_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B43 RID: 68419
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneInteraction/WaterBall/BP_WaterBall.BP_WaterBall_C";

		// Token: 0x04010B44 RID: 68420
		private static IntPtr _ClassPtr;

		// Token: 0x04010B45 RID: 68421
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B46 RID: 68422
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010B47 RID: 68423
		private static IntPtr __BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010B48 RID: 68424
		private static IntPtr __BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010B49 RID: 68425
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x02009D36 RID: 40246
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031482 RID: 201858
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D37 RID: 40247
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031483 RID: 201859
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031484 RID: 201860
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031485 RID: 201861
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031486 RID: 201862
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031487 RID: 201863
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031488 RID: 201864
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D38 RID: 40248
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_WaterBall_ActivationBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031489 RID: 201865
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403148A RID: 201866
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403148B RID: 201867
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403148C RID: 201868
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009D39 RID: 40249
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x0403148D RID: 201869
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x0403148E RID: 201870
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0403148F RID: 201871
			[FieldOffset(32)]
			public int Id;
		}
	}
}
