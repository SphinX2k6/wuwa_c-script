using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneInteraction.FruitTree
{
	// Token: 0x02003BB3 RID: 15283
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneInteraction/FruitTree/BP_FruitTreeInteractionCPU.BP_FruitTreeInteractionCPU_C")]
	[UnrealStructLayout(1752, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1749)]
	public class BP_FruitTreeInteractionCPU_C : AKuroFruitTreeInteractionActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060221D7 RID: 139735 RVA: 0x008FFE9E File Offset: 0x008FE09E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FruitTreeInteractionCPU_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneInteraction/FruitTree/BP_FruitTreeInteractionCPU.BP_FruitTreeInteractionCPU_C");
			}
			return BP_FruitTreeInteractionCPU_C._ClassPtr;
		}

		// Token: 0x060221D8 RID: 139736 RVA: 0x008FFEC4 File Offset: 0x008FE0C4
		public BP_FruitTreeInteractionCPU_C() : this(BuiltinUtils.AllocNativeUObject(BP_FruitTreeInteractionCPU_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060221D9 RID: 139737 RVA: 0x008FFEEC File Offset: 0x008FE0EC
		[NullableContext(1)]
		public BP_FruitTreeInteractionCPU_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FruitTreeInteractionCPU_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039D1 RID: 14801
		// (get) Token: 0x060221DA RID: 139738 RVA: 0x008FFF1F File Offset: 0x008FE11F
		// (set) Token: 0x060221DB RID: 139739 RVA: 0x008FFF33 File Offset: 0x008FE133
		public unsafe UStaticMeshComponent WholeMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FruitTreeInteractionCPU_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FruitTreeInteractionCPU_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170039D2 RID: 14802
		// (get) Token: 0x060221DC RID: 139740 RVA: 0x008FFF48 File Offset: 0x008FE148
		// (set) Token: 0x060221DD RID: 139741 RVA: 0x008FFF5C File Offset: 0x008FE15C
		public unsafe UHoudiniPointCache HPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FruitTreeInteractionCPU_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FruitTreeInteractionCPU_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170039D3 RID: 14803
		// (get) Token: 0x060221DE RID: 139742 RVA: 0x008FFF71 File Offset: 0x008FE171
		// (set) Token: 0x060221DF RID: 139743 RVA: 0x008FFF81 File Offset: 0x008FE181
		public unsafe float RadiusIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FruitTreeInteractionCPU_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FruitTreeInteractionCPU_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170039D4 RID: 14804
		// (get) Token: 0x060221E0 RID: 139744 RVA: 0x008FFF92 File Offset: 0x008FE192
		// (set) Token: 0x060221E1 RID: 139745 RVA: 0x008FFFA2 File Offset: 0x008FE1A2
		public unsafe bool ReverseV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FruitTreeInteractionCPU_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FruitTreeInteractionCPU_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x060221E2 RID: 139746 RVA: 0x008FFFB3 File Offset: 0x008FE1B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FruitTreeInteractionCPU_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060221E3 RID: 139747 RVA: 0x008FFFC7 File Offset: 0x008FE1C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FruitTreeInteractionCPU_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060221E4 RID: 139748 RVA: 0x008FFFDC File Offset: 0x008FE1DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_FruitTreeInteractionCPU_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_FruitTreeInteractionCPU_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_FruitTreeInteractionCPU_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FruitTreeInteractionCPU_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FruitTreeInteractionCPU_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221E5 RID: 139749 RVA: 0x00900040 File Offset: 0x008FE240
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FruitTreeInteractionCPU_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FruitTreeInteractionCPU_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FruitTreeInteractionCPU_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FruitTreeInteractionCPU_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FruitTreeInteractionCPU_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221E6 RID: 139750 RVA: 0x00900088 File Offset: 0x008FE288
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FruitTreeInteractionCPU_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FruitTreeInteractionCPU_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FruitTreeInteractionCPU_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FruitTreeInteractionCPU_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FruitTreeInteractionCPU_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060221E7 RID: 139751 RVA: 0x009000CF File Offset: 0x008FE2CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FruitTreeInteractionCPU_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060221E8 RID: 139752 RVA: 0x009000E3 File Offset: 0x008FE2E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FruitTreeInteractionCPU_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060221E9 RID: 139753 RVA: 0x009000F8 File Offset: 0x008FE2F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_FruitTreeInteractionCPU_C.__BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_FruitTreeInteractionCPU_C.__BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_FruitTreeInteractionCPU_C.__BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FruitTreeInteractionCPU_C.__BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FruitTreeInteractionCPU_C.__BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221EA RID: 139754 RVA: 0x009001B4 File Offset: 0x008FE3B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_FruitTreeInteractionCPU_C.__BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_FruitTreeInteractionCPU_C.__BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_FruitTreeInteractionCPU_C.__BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FruitTreeInteractionCPU_C.__BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FruitTreeInteractionCPU_C.__BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221EB RID: 139755 RVA: 0x0090023D File Offset: 0x008FE43D
		protected BP_FruitTreeInteractionCPU_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B51 RID: 68433
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneInteraction/FruitTree/BP_FruitTreeInteractionCPU.BP_FruitTreeInteractionCPU_C";

		// Token: 0x04010B52 RID: 68434
		private static IntPtr _ClassPtr;

		// Token: 0x04010B53 RID: 68435
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B54 RID: 68436
		internal static int __PropertyOffset_1;

		// Token: 0x04010B55 RID: 68437
		internal static int __PropertyOffset_2;

		// Token: 0x04010B56 RID: 68438
		internal static int __PropertyOffset_3;

		// Token: 0x04010B57 RID: 68439
		internal static int __PropertyOffset_4;

		// Token: 0x04010B58 RID: 68440
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010B59 RID: 68441
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x04010B5A RID: 68442
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010B5B RID: 68443
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010B5C RID: 68444
		private static IntPtr __BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010B5D RID: 68445
		private static IntPtr __BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009D3D RID: 40253
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x0403149D RID: 201885
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x0403149E RID: 201886
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0403149F RID: 201887
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009D3E RID: 40254
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314A0 RID: 201888
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D3F RID: 40255
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040314A1 RID: 201889
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040314A2 RID: 201890
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040314A3 RID: 201891
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040314A4 RID: 201892
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040314A5 RID: 201893
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040314A6 RID: 201894
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D40 RID: 40256
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_FruitTreeInteractionCPU_KillBounds_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040314A7 RID: 201895
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040314A8 RID: 201896
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040314A9 RID: 201897
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040314AA RID: 201898
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
