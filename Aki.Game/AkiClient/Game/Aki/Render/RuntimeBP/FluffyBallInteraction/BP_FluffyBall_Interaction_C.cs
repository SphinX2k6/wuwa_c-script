using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluffyBallInteraction
{
	// Token: 0x020030FE RID: 12542
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluffyBallInteraction/BP_FluffyBall_Interaction.BP_FluffyBall_Interaction_C")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1596)]
	public class BP_FluffyBall_Interaction_C : AKuroBPActor, IUnrealUObject, IUnrealObject, IBulletHitActorInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601EAAE RID: 125614 RVA: 0x00919D26 File Offset: 0x00917F26
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FluffyBall_Interaction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluffyBallInteraction/BP_FluffyBall_Interaction.BP_FluffyBall_Interaction_C");
			}
			return BP_FluffyBall_Interaction_C._ClassPtr;
		}

		// Token: 0x0601EAAF RID: 125615 RVA: 0x00919D4A File Offset: 0x00917F4A
		int IBulletHitActorInterface.InterfaceOffset()
		{
			return BP_FluffyBall_Interaction_C.__InterfaceOffset_IBulletHitActorInterface;
		}

		// Token: 0x0601EAB0 RID: 125616 RVA: 0x00919D54 File Offset: 0x00917F54
		public BP_FluffyBall_Interaction_C() : this(BuiltinUtils.AllocNativeUObject(BP_FluffyBall_Interaction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EAB1 RID: 125617 RVA: 0x00919D7C File Offset: 0x00917F7C
		[NullableContext(1)]
		public BP_FluffyBall_Interaction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FluffyBall_Interaction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0601EAB2 RID: 125618 RVA: 0x00919DAF File Offset: 0x00917FAF
		// (set) Token: 0x0601EAB3 RID: 125619 RVA: 0x00919DC3 File Offset: 0x00917FC3
		public unsafe UStaticMeshComponent SM_Dai_Pro_113AS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_SM_Dai_Pro_113AS);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_SM_Dai_Pro_113AS, value);
			}
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x0601EAB4 RID: 125620 RVA: 0x00919DD8 File Offset: 0x00917FD8
		// (set) Token: 0x0601EAB5 RID: 125621 RVA: 0x00919DEC File Offset: 0x00917FEC
		public unsafe USphereComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_Sphere);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_Sphere, value);
			}
		}

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x0601EAB6 RID: 125622 RVA: 0x00919E01 File Offset: 0x00918001
		// (set) Token: 0x0601EAB7 RID: 125623 RVA: 0x00919E15 File Offset: 0x00918015
		public unsafe UNiagaraComponent NS_Fx_FluffyBall
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_NS_Fx_FluffyBall);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_NS_Fx_FluffyBall, value);
			}
		}

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0601EAB8 RID: 125624 RVA: 0x00919E2A File Offset: 0x0091802A
		// (set) Token: 0x0601EAB9 RID: 125625 RVA: 0x00919E3E File Offset: 0x0091803E
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x0601EABA RID: 125626 RVA: 0x00919E53 File Offset: 0x00918053
		// (set) Token: 0x0601EABB RID: 125627 RVA: 0x00919E63 File Offset: 0x00918063
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0601EABC RID: 125628 RVA: 0x00919E74 File Offset: 0x00918074
		// (set) Token: 0x0601EABD RID: 125629 RVA: 0x00919E88 File Offset: 0x00918088
		public unsafe FVector BulletPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_BulletPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_BulletPosition) = value;
			}
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0601EABE RID: 125630 RVA: 0x00919E9D File Offset: 0x0091809D
		// (set) Token: 0x0601EABF RID: 125631 RVA: 0x00919EAD File Offset: 0x009180AD
		public unsafe bool Hit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_Hit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_Hit) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0601EAC0 RID: 125632 RVA: 0x00919EBE File Offset: 0x009180BE
		// (set) Token: 0x0601EAC1 RID: 125633 RVA: 0x00919ED2 File Offset: 0x009180D2
		public unsafe UMaterialInstanceDynamic DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_DMI);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_DMI, value);
			}
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0601EAC2 RID: 125634 RVA: 0x00919EE7 File Offset: 0x009180E7
		// (set) Token: 0x0601EAC3 RID: 125635 RVA: 0x00919EFB File Offset: 0x009180FB
		public unsafe UMaterialInstanceDynamic DMI_LOD0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_DMI_LOD0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_DMI_LOD0, value);
			}
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x0601EAC4 RID: 125636 RVA: 0x00919F10 File Offset: 0x00918110
		// (set) Token: 0x0601EAC5 RID: 125637 RVA: 0x00919F24 File Offset: 0x00918124
		public unsafe FTransformDouble BaseTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_BaseTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_BaseTransform) = value;
			}
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x0601EAC6 RID: 125638 RVA: 0x00919F39 File Offset: 0x00918139
		// (set) Token: 0x0601EAC7 RID: 125639 RVA: 0x00919F4D File Offset: 0x0091814D
		public unsafe FVector RotationDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_RotationDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_RotationDir) = value;
			}
		}

		// Token: 0x0601EAC8 RID: 125640 RVA: 0x00919F64 File Offset: 0x00918164
		[SkipLocalsInit]
		public unsafe virtual void UpdateParams(float dt)
		{
			BP_FluffyBall_Interaction_C.__UpdateParams_FunctionParams* ptr = stackalloc BP_FluffyBall_Interaction_C.__UpdateParams_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_FluffyBall_Interaction_C.__UpdateParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluffyBall_Interaction_C.__UpdateParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__UpdateParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EAC9 RID: 125641 RVA: 0x00919FAA File Offset: 0x009181AA
		[SkipLocalsInit]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x0601EACA RID: 125642 RVA: 0x00919FC0 File Offset: 0x009181C0
		[SkipLocalsInit]
		public unsafe virtual void HitDetection(FVectorDouble HitPos)
		{
			BP_FluffyBall_Interaction_C.__HitDetection_FunctionParams* ptr = stackalloc BP_FluffyBall_Interaction_C.__HitDetection_FunctionParams[(UIntPtr)247] + 15L / (long)sizeof(BP_FluffyBall_Interaction_C.__HitDetection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluffyBall_Interaction_C.__HitDetection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitPos = HitPos;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__HitDetection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EACB RID: 125643 RVA: 0x0091A009 File Offset: 0x00918209
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601EACC RID: 125644 RVA: 0x0091A01D File Offset: 0x0091821D
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601EACD RID: 125645 RVA: 0x0091A031 File Offset: 0x00918231
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601EACE RID: 125646 RVA: 0x0091A045 File Offset: 0x00918245
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601EACF RID: 125647 RVA: 0x0091A05C File Offset: 0x0091825C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FluffyBall_Interaction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FluffyBall_Interaction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FluffyBall_Interaction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluffyBall_Interaction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EAD0 RID: 125648 RVA: 0x0091A0A4 File Offset: 0x009182A4
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FluffyBall_Interaction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FluffyBall_Interaction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FluffyBall_Interaction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluffyBall_Interaction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EAD1 RID: 125649 RVA: 0x0091A0EC File Offset: 0x009182EC
		[SkipLocalsInit]
		public unsafe virtual void OnBulletHit(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_FluffyBall_Interaction_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_FluffyBall_Interaction_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_FluffyBall_Interaction_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluffyBall_Interaction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EAD2 RID: 125650 RVA: 0x0091A140 File Offset: 0x00918340
		[SkipLocalsInit]
		protected unsafe virtual void OnBulletHit_Implementation(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_FluffyBall_Interaction_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_FluffyBall_Interaction_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_FluffyBall_Interaction_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluffyBall_Interaction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EAD3 RID: 125651 RVA: 0x0091A192 File Offset: 0x00918392
		protected BP_FluffyBall_Interaction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401045D RID: 66653
		internal static int __InterfaceOffset_IBulletHitActorInterface;

		// Token: 0x0401045E RID: 66654
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluffyBallInteraction/BP_FluffyBall_Interaction.BP_FluffyBall_Interaction_C";

		// Token: 0x0401045F RID: 66655
		private static IntPtr _ClassPtr;

		// Token: 0x04010460 RID: 66656
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010461 RID: 66657
		internal static int __PropertyOffset_SM_Dai_Pro_113AS;

		// Token: 0x04010462 RID: 66658
		internal static int __PropertyOffset_Sphere;

		// Token: 0x04010463 RID: 66659
		internal static int __PropertyOffset_NS_Fx_FluffyBall;

		// Token: 0x04010464 RID: 66660
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010465 RID: 66661
		internal static int __PropertyOffset_Radius;

		// Token: 0x04010466 RID: 66662
		internal static int __PropertyOffset_BulletPosition;

		// Token: 0x04010467 RID: 66663
		internal static int __PropertyOffset_Hit;

		// Token: 0x04010468 RID: 66664
		internal static int __PropertyOffset_DMI;

		// Token: 0x04010469 RID: 66665
		internal static int __PropertyOffset_DMI_LOD0;

		// Token: 0x0401046A RID: 66666
		internal static int __PropertyOffset_BaseTransform;

		// Token: 0x0401046B RID: 66667
		internal static int __PropertyOffset_RotationDir;

		// Token: 0x0401046C RID: 66668
		private static IntPtr __UpdateParams_NativeFunctionPtr;

		// Token: 0x0401046D RID: 66669
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x0401046E RID: 66670
		private static IntPtr __HitDetection_NativeFunctionPtr;

		// Token: 0x0401046F RID: 66671
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010470 RID: 66672
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010471 RID: 66673
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010472 RID: 66674
		private static IntPtr __OnBulletHit_NativeFunctionPtr;

		// Token: 0x02008EB1 RID: 36529
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __UpdateParams_FunctionParams
		{
			// Token: 0x0402CB4D RID: 183117
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x02008EB2 RID: 36530
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 232)]
		protected ref struct __HitDetection_FunctionParams
		{
			// Token: 0x0402CB4E RID: 183118
			[FieldOffset(0)]
			public FVectorDouble HitPos;
		}

		// Token: 0x02008EB3 RID: 36531
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CB4F RID: 183119
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008EB4 RID: 36532
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnBulletHit_FunctionParams
		{
			// Token: 0x0402CB50 RID: 183120
			[FieldOffset(0)]
			public int BulletEntityId;

			// Token: 0x0402CB51 RID: 183121
			[FieldOffset(8)]
			public FVectorDouble HitPoint;
		}
	}
}
