using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneInteraction.Hourglass
{
	// Token: 0x02003BB2 RID: 15282
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneInteraction/Hourglass/BP_Hourglass.BP_Hourglass_C")]
	[UnrealStructLayout(1776, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1776)]
	public class BP_Hourglass_C : AKuroHourglassActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060221CE RID: 139726 RVA: 0x008FFC44 File Offset: 0x008FDE44
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Hourglass_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneInteraction/Hourglass/BP_Hourglass.BP_Hourglass_C");
			}
			return BP_Hourglass_C._ClassPtr;
		}

		// Token: 0x060221CF RID: 139727 RVA: 0x008FFC68 File Offset: 0x008FDE68
		public BP_Hourglass_C() : this(BuiltinUtils.AllocNativeUObject(BP_Hourglass_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060221D0 RID: 139728 RVA: 0x008FFC90 File Offset: 0x008FDE90
		[NullableContext(1)]
		public BP_Hourglass_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Hourglass_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060221D1 RID: 139729 RVA: 0x008FFCC3 File Offset: 0x008FDEC3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Hourglass_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060221D2 RID: 139730 RVA: 0x008FFCD7 File Offset: 0x008FDED7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Hourglass_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060221D3 RID: 139731 RVA: 0x008FFCEC File Offset: 0x008FDEEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_Hourglass_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_Hourglass_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_Hourglass_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Hourglass_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Hourglass_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221D4 RID: 139732 RVA: 0x008FFD50 File Offset: 0x008FDF50
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_Hourglass_C.__BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_Hourglass_C.__BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_Hourglass_C.__BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Hourglass_C.__BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Hourglass_C.__BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221D5 RID: 139733 RVA: 0x008FFE0C File Offset: 0x008FE00C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_Hourglass_C.__BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_Hourglass_C.__BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Hourglass_C.__BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Hourglass_C.__BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Hourglass_C.__BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221D6 RID: 139734 RVA: 0x008FFE95 File Offset: 0x008FE095
		protected BP_Hourglass_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B4A RID: 68426
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneInteraction/Hourglass/BP_Hourglass.BP_Hourglass_C";

		// Token: 0x04010B4B RID: 68427
		private static IntPtr _ClassPtr;

		// Token: 0x04010B4C RID: 68428
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B4D RID: 68429
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010B4E RID: 68430
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x04010B4F RID: 68431
		private static IntPtr __BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010B50 RID: 68432
		private static IntPtr __BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009D3A RID: 40250
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031490 RID: 201872
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031491 RID: 201873
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031492 RID: 201874
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009D3B RID: 40251
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031493 RID: 201875
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031494 RID: 201876
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031495 RID: 201877
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031496 RID: 201878
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031497 RID: 201879
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031498 RID: 201880
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D3C RID: 40252
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_Hourglass_InteractionBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031499 RID: 201881
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403149A RID: 201882
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403149B RID: 201883
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403149C RID: 201884
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
