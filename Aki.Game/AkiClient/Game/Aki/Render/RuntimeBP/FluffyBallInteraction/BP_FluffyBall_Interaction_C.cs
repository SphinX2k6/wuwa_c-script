using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluffyBallInteraction
{
	// Token: 0x02003DB0 RID: 15792
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluffyBallInteraction/BP_FluffyBall_Interaction.BP_FluffyBall_Interaction_C")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1596)]
	public class BP_FluffyBall_Interaction_C : AKuroBPActor, IUnrealUObject, IUnrealObject, IBulletHitActorInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06027319 RID: 160537 RVA: 0x0098AB97 File Offset: 0x00988D97
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FluffyBall_Interaction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluffyBallInteraction/BP_FluffyBall_Interaction.BP_FluffyBall_Interaction_C");
			}
			return BP_FluffyBall_Interaction_C._ClassPtr;
		}

		// Token: 0x0602731A RID: 160538 RVA: 0x0098ABBB File Offset: 0x00988DBB
		int IBulletHitActorInterface.InterfaceOffset()
		{
			return BP_FluffyBall_Interaction_C.__InterfaceOffset_IBulletHitActorInterface;
		}

		// Token: 0x0602731B RID: 160539 RVA: 0x0098ABC4 File Offset: 0x00988DC4
		public BP_FluffyBall_Interaction_C() : this(BuiltinUtils.AllocNativeUObject(BP_FluffyBall_Interaction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602731C RID: 160540 RVA: 0x0098ABEC File Offset: 0x00988DEC
		[NullableContext(1)]
		public BP_FluffyBall_Interaction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FluffyBall_Interaction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170056BC RID: 22204
		// (get) Token: 0x0602731D RID: 160541 RVA: 0x0098AC1F File Offset: 0x00988E1F
		// (set) Token: 0x0602731E RID: 160542 RVA: 0x0098AC33 File Offset: 0x00988E33
		public unsafe UStaticMeshComponent SM_Dai_Pro_113AS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170056BD RID: 22205
		// (get) Token: 0x0602731F RID: 160543 RVA: 0x0098AC48 File Offset: 0x00988E48
		// (set) Token: 0x06027320 RID: 160544 RVA: 0x0098AC5C File Offset: 0x00988E5C
		public unsafe USphereComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170056BE RID: 22206
		// (get) Token: 0x06027321 RID: 160545 RVA: 0x0098AC71 File Offset: 0x00988E71
		// (set) Token: 0x06027322 RID: 160546 RVA: 0x0098AC85 File Offset: 0x00988E85
		public unsafe UNiagaraComponent NS_Fx_FluffyBall
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170056BF RID: 22207
		// (get) Token: 0x06027323 RID: 160547 RVA: 0x0098AC9A File Offset: 0x00988E9A
		// (set) Token: 0x06027324 RID: 160548 RVA: 0x0098ACAE File Offset: 0x00988EAE
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170056C0 RID: 22208
		// (get) Token: 0x06027325 RID: 160549 RVA: 0x0098ACC3 File Offset: 0x00988EC3
		// (set) Token: 0x06027326 RID: 160550 RVA: 0x0098ACD3 File Offset: 0x00988ED3
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170056C1 RID: 22209
		// (get) Token: 0x06027327 RID: 160551 RVA: 0x0098ACE4 File Offset: 0x00988EE4
		// (set) Token: 0x06027328 RID: 160552 RVA: 0x0098ACF8 File Offset: 0x00988EF8
		public unsafe FVector BulletPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170056C2 RID: 22210
		// (get) Token: 0x06027329 RID: 160553 RVA: 0x0098AD0D File Offset: 0x00988F0D
		// (set) Token: 0x0602732A RID: 160554 RVA: 0x0098AD1D File Offset: 0x00988F1D
		public unsafe bool Hit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056C3 RID: 22211
		// (get) Token: 0x0602732B RID: 160555 RVA: 0x0098AD2E File Offset: 0x00988F2E
		// (set) Token: 0x0602732C RID: 160556 RVA: 0x0098AD42 File Offset: 0x00988F42
		public unsafe UMaterialInstanceDynamic DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170056C4 RID: 22212
		// (get) Token: 0x0602732D RID: 160557 RVA: 0x0098AD57 File Offset: 0x00988F57
		// (set) Token: 0x0602732E RID: 160558 RVA: 0x0098AD6B File Offset: 0x00988F6B
		public unsafe UMaterialInstanceDynamic DMI_LOD0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluffyBall_Interaction_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170056C5 RID: 22213
		// (get) Token: 0x0602732F RID: 160559 RVA: 0x0098AD80 File Offset: 0x00988F80
		// (set) Token: 0x06027330 RID: 160560 RVA: 0x0098AD94 File Offset: 0x00988F94
		public unsafe FTransformDouble BaseTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170056C6 RID: 22214
		// (get) Token: 0x06027331 RID: 160561 RVA: 0x0098ADA9 File Offset: 0x00988FA9
		// (set) Token: 0x06027332 RID: 160562 RVA: 0x0098ADBD File Offset: 0x00988FBD
		public unsafe FVector RotationDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluffyBall_Interaction_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x06027333 RID: 160563 RVA: 0x0098ADD4 File Offset: 0x00988FD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateParams(float dt)
		{
			BP_FluffyBall_Interaction_C.__UpdateParams_FunctionParams* ptr = stackalloc BP_FluffyBall_Interaction_C.__UpdateParams_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_FluffyBall_Interaction_C.__UpdateParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluffyBall_Interaction_C.__UpdateParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__UpdateParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027334 RID: 160564 RVA: 0x0098AE1A File Offset: 0x0098901A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x06027335 RID: 160565 RVA: 0x0098AE30 File Offset: 0x00989030
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HitDetection(FVectorDouble HitPos)
		{
			BP_FluffyBall_Interaction_C.__HitDetection_FunctionParams* ptr = stackalloc BP_FluffyBall_Interaction_C.__HitDetection_FunctionParams[(UIntPtr)247] + 15L / (long)sizeof(BP_FluffyBall_Interaction_C.__HitDetection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluffyBall_Interaction_C.__HitDetection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitPos = HitPos;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__HitDetection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027336 RID: 160566 RVA: 0x0098AE79 File Offset: 0x00989079
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027337 RID: 160567 RVA: 0x0098AE8D File Offset: 0x0098908D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027338 RID: 160568 RVA: 0x0098AEA2 File Offset: 0x009890A2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06027339 RID: 160569 RVA: 0x0098AEB6 File Offset: 0x009890B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602733A RID: 160570 RVA: 0x0098AECC File Offset: 0x009890CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FluffyBall_Interaction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FluffyBall_Interaction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FluffyBall_Interaction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluffyBall_Interaction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602733B RID: 160571 RVA: 0x0098AF14 File Offset: 0x00989114
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FluffyBall_Interaction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FluffyBall_Interaction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FluffyBall_Interaction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluffyBall_Interaction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602733C RID: 160572 RVA: 0x0098AF5C File Offset: 0x0098915C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnBulletHit(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_FluffyBall_Interaction_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_FluffyBall_Interaction_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_FluffyBall_Interaction_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluffyBall_Interaction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602733D RID: 160573 RVA: 0x0098AFB0 File Offset: 0x009891B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnBulletHit_Implementation(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_FluffyBall_Interaction_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_FluffyBall_Interaction_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_FluffyBall_Interaction_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluffyBall_Interaction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FluffyBall_Interaction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602733E RID: 160574 RVA: 0x0098B003 File Offset: 0x00989203
		protected BP_FluffyBall_Interaction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013C4F RID: 80975
		internal static int __InterfaceOffset_IBulletHitActorInterface;

		// Token: 0x04013C50 RID: 80976
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluffyBallInteraction/BP_FluffyBall_Interaction.BP_FluffyBall_Interaction_C";

		// Token: 0x04013C51 RID: 80977
		private static IntPtr _ClassPtr;

		// Token: 0x04013C52 RID: 80978
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013C53 RID: 80979
		internal static int __PropertyOffset_1;

		// Token: 0x04013C54 RID: 80980
		internal static int __PropertyOffset_2;

		// Token: 0x04013C55 RID: 80981
		internal static int __PropertyOffset_3;

		// Token: 0x04013C56 RID: 80982
		internal static int __PropertyOffset_4;

		// Token: 0x04013C57 RID: 80983
		internal static int __PropertyOffset_5;

		// Token: 0x04013C58 RID: 80984
		internal static int __PropertyOffset_6;

		// Token: 0x04013C59 RID: 80985
		internal static int __PropertyOffset_7;

		// Token: 0x04013C5A RID: 80986
		internal static int __PropertyOffset_8;

		// Token: 0x04013C5B RID: 80987
		internal static int __PropertyOffset_9;

		// Token: 0x04013C5C RID: 80988
		internal static int __PropertyOffset_10;

		// Token: 0x04013C5D RID: 80989
		internal static int __PropertyOffset_11;

		// Token: 0x04013C5E RID: 80990
		private static IntPtr __UpdateParams_NativeFunctionPtr;

		// Token: 0x04013C5F RID: 80991
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x04013C60 RID: 80992
		private static IntPtr __HitDetection_NativeFunctionPtr;

		// Token: 0x04013C61 RID: 80993
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013C62 RID: 80994
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013C63 RID: 80995
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013C64 RID: 80996
		private static IntPtr __OnBulletHit_NativeFunctionPtr;

		// Token: 0x0200A1F9 RID: 41465
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __UpdateParams_FunctionParams
		{
			// Token: 0x04031E5A RID: 204378
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x0200A1FA RID: 41466
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 232)]
		protected ref struct __HitDetection_FunctionParams
		{
			// Token: 0x04031E5B RID: 204379
			[FieldOffset(0)]
			public FVectorDouble HitPos;
		}

		// Token: 0x0200A1FB RID: 41467
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031E5C RID: 204380
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A1FC RID: 41468
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnBulletHit_FunctionParams
		{
			// Token: 0x04031E5D RID: 204381
			[FieldOffset(0)]
			public int BulletEntityId;

			// Token: 0x04031E5E RID: 204382
			[FieldOffset(8)]
			public FVectorDouble HitPoint;
		}
	}
}
