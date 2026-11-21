using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x020030FC RID: 12540
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive.NinjaLive_C")]
	[UnrealStructLayout(2064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2064)]
	public class NinjaLive_C : AUKuroCustomCookActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E9FC RID: 125436 RVA: 0x009189DC File Offset: 0x00916BDC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NinjaLive_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive.NinjaLive_C");
			}
			return NinjaLive_C._ClassPtr;
		}

		// Token: 0x0601E9FD RID: 125437 RVA: 0x00918A00 File Offset: 0x00916C00
		public NinjaLive_C() : this(BuiltinUtils.AllocNativeUObject(NinjaLive_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E9FE RID: 125438 RVA: 0x00918A28 File Offset: 0x00916C28
		[NullableContext(1)]
		public NinjaLive_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NinjaLive_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x0601E9FF RID: 125439 RVA: 0x00918A5B File Offset: 0x00916C5B
		// (set) Token: 0x0601EA00 RID: 125440 RVA: 0x00918A6F File Offset: 0x00916C6F
		public unsafe UBoxComponent InteractionVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_InteractionVolume);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_InteractionVolume, value);
			}
		}

		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x0601EA01 RID: 125441 RVA: 0x00918A84 File Offset: 0x00916C84
		// (set) Token: 0x0601EA02 RID: 125442 RVA: 0x00918A98 File Offset: 0x00916C98
		public unsafe UBoxComponent ActivationVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_ActivationVolume);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_ActivationVolume, value);
			}
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x0601EA03 RID: 125443 RVA: 0x00918AAD File Offset: 0x00916CAD
		// (set) Token: 0x0601EA04 RID: 125444 RVA: 0x00918AC1 File Offset: 0x00916CC1
		public unsafe UStaticMeshComponent TraceMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_TraceMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_TraceMesh, value);
			}
		}

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x0601EA05 RID: 125445 RVA: 0x00918AD6 File Offset: 0x00916CD6
		// (set) Token: 0x0601EA06 RID: 125446 RVA: 0x00918AEA File Offset: 0x00916CEA
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x0601EA07 RID: 125447 RVA: 0x00918AFF File Offset: 0x00916CFF
		// (set) Token: 0x0601EA08 RID: 125448 RVA: 0x00918B13 File Offset: 0x00916D13
		public unsafe UTextureRenderTarget2D RT_DensityPreview
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_RT_DensityPreview);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_RT_DensityPreview, value);
			}
		}

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x0601EA09 RID: 125449 RVA: 0x00918B28 File Offset: 0x00916D28
		// (set) Token: 0x0601EA0A RID: 125450 RVA: 0x00918B3C File Offset: 0x00916D3C
		public unsafe UMaterialInstance InactiveGrayMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_InactiveGrayMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_InactiveGrayMaterial, value);
			}
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x0601EA0B RID: 125451 RVA: 0x00918B51 File Offset: 0x00916D51
		// (set) Token: 0x0601EA0C RID: 125452 RVA: 0x00918B61 File Offset: 0x00916D61
		public unsafe bool DisableBlueprint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_DisableBlueprint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_DisableBlueprint) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0601EA0D RID: 125453 RVA: 0x00918B72 File Offset: 0x00916D72
		// (set) Token: 0x0601EA0E RID: 125454 RVA: 0x00918B82 File Offset: 0x00916D82
		public unsafe float TimeCounterForBrush
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_TimeCounterForBrush);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_TimeCounterForBrush) = value;
			}
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0601EA0F RID: 125455 RVA: 0x00918B93 File Offset: 0x00916D93
		// (set) Token: 0x0601EA10 RID: 125456 RVA: 0x00918BA3 File Offset: 0x00916DA3
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_DeltaSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_DeltaSeconds) = value;
			}
		}

		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0601EA11 RID: 125457 RVA: 0x00918BB4 File Offset: 0x00916DB4
		// (set) Token: 0x0601EA12 RID: 125458 RVA: 0x00918BC4 File Offset: 0x00916DC4
		public unsafe bool MousePressed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_MousePressed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_MousePressed) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0601EA13 RID: 125459 RVA: 0x00918BD5 File Offset: 0x00916DD5
		// (set) Token: 0x0601EA14 RID: 125460 RVA: 0x00918BE5 File Offset: 0x00916DE5
		public unsafe bool ShowTraceMeshInEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ShowTraceMeshInEditor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ShowTraceMeshInEditor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x0601EA15 RID: 125461 RVA: 0x00918BF6 File Offset: 0x00916DF6
		// (set) Token: 0x0601EA16 RID: 125462 RVA: 0x00918C0A File Offset: 0x00916E0A
		public unsafe FVector TraceMeshSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_TraceMeshSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_TraceMeshSize) = value;
			}
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x0601EA17 RID: 125463 RVA: 0x00918C1F File Offset: 0x00916E1F
		// (set) Token: 0x0601EA18 RID: 125464 RVA: 0x00918C2F File Offset: 0x00916E2F
		public unsafe bool OverlapBasedInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OverlapBasedInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OverlapBasedInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x0601EA19 RID: 125465 RVA: 0x00918C40 File Offset: 0x00916E40
		// (set) Token: 0x0601EA1A RID: 125466 RVA: 0x00918C79 File Offset: 0x00916E79
		[Nullable(1)]
		public TArray<NinjaLive_C> NinjaLIVECollisionExclude
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<NinjaLive_C> result;
				if ((result = this._NinjaLIVECollisionExclude) == null)
				{
					result = (this._NinjaLIVECollisionExclude = new TArray<NinjaLive_C>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_NinjaLIVECollisionExclude, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NinjaLIVECollisionExclude.CopyAssign(value);
			}
		}

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x0601EA1B RID: 125467 RVA: 0x00918C87 File Offset: 0x00916E87
		// (set) Token: 0x0601EA1C RID: 125468 RVA: 0x00918C97 File Offset: 0x00916E97
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x0601EA1D RID: 125469 RVA: 0x00918CA8 File Offset: 0x00916EA8
		// (set) Token: 0x0601EA1E RID: 125470 RVA: 0x00918CB8 File Offset: 0x00916EB8
		public unsafe bool SimActivatedByPawnProximity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_SimActivatedByPawnProximity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_SimActivatedByPawnProximity) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x0601EA1F RID: 125471 RVA: 0x00918CC9 File Offset: 0x00916EC9
		// (set) Token: 0x0601EA20 RID: 125472 RVA: 0x00918CD9 File Offset: 0x00916ED9
		public unsafe bool ShowActivationVolumeInEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ShowActivationVolumeInEditor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ShowActivationVolumeInEditor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x0601EA21 RID: 125473 RVA: 0x00918CEA File Offset: 0x00916EEA
		// (set) Token: 0x0601EA22 RID: 125474 RVA: 0x00918CFE File Offset: 0x00916EFE
		public unsafe FVector ActivationVolumeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ActivationVolumeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ActivationVolumeSize) = value;
			}
		}

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x0601EA23 RID: 125475 RVA: 0x00918D13 File Offset: 0x00916F13
		// (set) Token: 0x0601EA24 RID: 125476 RVA: 0x00918D23 File Offset: 0x00916F23
		public unsafe float ActivatorProximityCheckFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ActivatorProximityCheckFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ActivatorProximityCheckFrequency) = value;
			}
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x0601EA25 RID: 125477 RVA: 0x00918D34 File Offset: 0x00916F34
		// (set) Token: 0x0601EA26 RID: 125478 RVA: 0x00918D48 File Offset: 0x00916F48
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> ActivatorType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ActivatorType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ActivatorType) = value;
			}
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x0601EA27 RID: 125479 RVA: 0x00918D5D File Offset: 0x00916F5D
		// (set) Token: 0x0601EA28 RID: 125480 RVA: 0x00918D71 File Offset: 0x00916F71
		public unsafe AActor Activator
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_Activator);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_Activator, value);
			}
		}

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x0601EA29 RID: 125481 RVA: 0x00918D86 File Offset: 0x00916F86
		// (set) Token: 0x0601EA2A RID: 125482 RVA: 0x00918D96 File Offset: 0x00916F96
		public unsafe bool PawnInsideActivationBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_PawnInsideActivationBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_PawnInsideActivationBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x0601EA2B RID: 125483 RVA: 0x00918DA7 File Offset: 0x00916FA7
		// (set) Token: 0x0601EA2C RID: 125484 RVA: 0x00918DB7 File Offset: 0x00916FB7
		public unsafe bool InitDone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_InitDone) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_InitDone) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x0601EA2D RID: 125485 RVA: 0x00918DC8 File Offset: 0x00916FC8
		// (set) Token: 0x0601EA2E RID: 125486 RVA: 0x00918DD8 File Offset: 0x00916FD8
		public unsafe bool BeginPlaySupressed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_BeginPlaySupressed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_BeginPlaySupressed) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x0601EA2F RID: 125487 RVA: 0x00918DE9 File Offset: 0x00916FE9
		// (set) Token: 0x0601EA30 RID: 125488 RVA: 0x00918DF9 File Offset: 0x00916FF9
		public unsafe bool UseTraceMeshAsInteractionVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_UseTraceMeshAsInteractionVolume) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_UseTraceMeshAsInteractionVolume) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x0601EA31 RID: 125489 RVA: 0x00918E0A File Offset: 0x0091700A
		// (set) Token: 0x0601EA32 RID: 125490 RVA: 0x00918E1A File Offset: 0x0091701A
		public unsafe bool ShowInteractionVolumeInEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ShowInteractionVolumeInEditor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ShowInteractionVolumeInEditor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x0601EA33 RID: 125491 RVA: 0x00918E2B File Offset: 0x0091702B
		// (set) Token: 0x0601EA34 RID: 125492 RVA: 0x00918E3F File Offset: 0x0091703F
		public unsafe FVector InteractionVolumeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_InteractionVolumeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_InteractionVolumeSize) = value;
			}
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x0601EA35 RID: 125493 RVA: 0x00918E54 File Offset: 0x00917054
		// (set) Token: 0x0601EA36 RID: 125494 RVA: 0x00918E8D File Offset: 0x0091708D
		[Nullable(1)]
		public TArray<bool> MultipleTouchLookup
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._MultipleTouchLookup) == null)
				{
					result = (this._MultipleTouchLookup = new TArray<bool>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_MultipleTouchLookup, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MultipleTouchLookup.CopyAssign(value);
			}
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x0601EA37 RID: 125495 RVA: 0x00918E9B File Offset: 0x0091709B
		// (set) Token: 0x0601EA38 RID: 125496 RVA: 0x00918EAB File Offset: 0x009170AB
		public unsafe float TickRateCustom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_TickRateCustom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_TickRateCustom) = value;
			}
		}

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x0601EA39 RID: 125497 RVA: 0x00918EBC File Offset: 0x009170BC
		// (set) Token: 0x0601EA3A RID: 125498 RVA: 0x00918ED0 File Offset: 0x009170D0
		public unsafe UPrimitiveComponent InteractionVolumeTemplate
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_InteractionVolumeTemplate);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_InteractionVolumeTemplate, value);
			}
		}

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x0601EA3B RID: 125499 RVA: 0x00918EE5 File Offset: 0x009170E5
		// (set) Token: 0x0601EA3C RID: 125500 RVA: 0x00918EF9 File Offset: 0x009170F9
		public unsafe FName TrackActorPrimitiveComponentsWithTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_TrackActorPrimitiveComponentsWithTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_TrackActorPrimitiveComponentsWithTag) = value;
			}
		}

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x0601EA3D RID: 125501 RVA: 0x00918F0E File Offset: 0x0091710E
		// (set) Token: 0x0601EA3E RID: 125502 RVA: 0x00918F22 File Offset: 0x00917122
		public unsafe FName TrackActorSkeletalMeshComponentsWithTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_TrackActorSkeletalMeshComponentsWithTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_TrackActorSkeletalMeshComponentsWithTag) = value;
			}
		}

		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x0601EA3F RID: 125503 RVA: 0x00918F38 File Offset: 0x00917138
		// (set) Token: 0x0601EA40 RID: 125504 RVA: 0x00918F71 File Offset: 0x00917171
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> OverlapFilterInclusiveObjType
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._OverlapFilterInclusiveObjType) == null)
				{
					result = (this._OverlapFilterInclusiveObjType = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OverlapFilterInclusiveObjType, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.OverlapFilterInclusiveObjType.CopyAssign(value);
			}
		}

		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x0601EA41 RID: 125505 RVA: 0x00918F80 File Offset: 0x00917180
		// (set) Token: 0x0601EA42 RID: 125506 RVA: 0x00918FB9 File Offset: 0x009171B9
		[Nullable(1)]
		public TArray<FName> OverlapFilterInclusiveBoneNameExact
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._OverlapFilterInclusiveBoneNameExact) == null)
				{
					result = (this._OverlapFilterInclusiveBoneNameExact = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OverlapFilterInclusiveBoneNameExact, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OverlapFilterInclusiveBoneNameExact.CopyAssign(value);
			}
		}

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x0601EA43 RID: 125507 RVA: 0x00918FC8 File Offset: 0x009171C8
		// (set) Token: 0x0601EA44 RID: 125508 RVA: 0x00919001 File Offset: 0x00917201
		[Nullable(1)]
		public TArray<string> OverlapFilterInclusiveBoneNamePartial
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._OverlapFilterInclusiveBoneNamePartial) == null)
				{
					result = (this._OverlapFilterInclusiveBoneNamePartial = new TArray<string>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OverlapFilterInclusiveBoneNamePartial, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OverlapFilterInclusiveBoneNamePartial.CopyAssign(value);
			}
		}

		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x0601EA45 RID: 125509 RVA: 0x00919010 File Offset: 0x00917210
		// (set) Token: 0x0601EA46 RID: 125510 RVA: 0x00919049 File Offset: 0x00917249
		[Nullable(1)]
		public TArray<AActor> ExcludeSpecificActorsFromOverlap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ExcludeSpecificActorsFromOverlap) == null)
				{
					result = (this._ExcludeSpecificActorsFromOverlap = new TArray<AActor>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ExcludeSpecificActorsFromOverlap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ExcludeSpecificActorsFromOverlap.CopyAssign(value);
			}
		}

		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x0601EA47 RID: 125511 RVA: 0x00919057 File Offset: 0x00917257
		// (set) Token: 0x0601EA48 RID: 125512 RVA: 0x00919067 File Offset: 0x00917267
		public unsafe bool AutoExcludeLargeOverlappingObjects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_AutoExcludeLargeOverlappingObjects) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_AutoExcludeLargeOverlappingObjects) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x0601EA49 RID: 125513 RVA: 0x00919078 File Offset: 0x00917278
		// (set) Token: 0x0601EA4A RID: 125514 RVA: 0x009190B1 File Offset: 0x009172B1
		[Nullable(new byte[]
		{
			1,
			0,
			0
		})]
		public TMap<TEnumAsByte<ECollisionChannel>, TEnumAsByte<EObjectTypeQuery>> OverlapFilterInclusiveCollisionType
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ECollisionChannel>, TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._OverlapFilterInclusiveCollisionType) == null)
				{
					result = (this._OverlapFilterInclusiveCollisionType = new TMap<TEnumAsByte<ECollisionChannel>, TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OverlapFilterInclusiveCollisionType, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				0
			})]
			set
			{
				this.OverlapFilterInclusiveCollisionType.CopyAssign(value);
			}
		}

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x0601EA4B RID: 125515 RVA: 0x009190BF File Offset: 0x009172BF
		// (set) Token: 0x0601EA4C RID: 125516 RVA: 0x009190CF File Offset: 0x009172CF
		public unsafe bool ActivationEventsDebugPrint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ActivationEventsDebugPrint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ActivationEventsDebugPrint) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x0601EA4D RID: 125517 RVA: 0x009190E0 File Offset: 0x009172E0
		// (set) Token: 0x0601EA4E RID: 125518 RVA: 0x009190F0 File Offset: 0x009172F0
		public unsafe bool SimContainerCapacityWarning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_SimContainerCapacityWarning) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_SimContainerCapacityWarning) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x0601EA4F RID: 125519 RVA: 0x00919101 File Offset: 0x00917301
		// (set) Token: 0x0601EA50 RID: 125520 RVA: 0x00919111 File Offset: 0x00917311
		public unsafe bool SaveDebugTextToLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_SaveDebugTextToLog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_SaveDebugTextToLog) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x0601EA51 RID: 125521 RVA: 0x00919122 File Offset: 0x00917322
		// (set) Token: 0x0601EA52 RID: 125522 RVA: 0x00919132 File Offset: 0x00917332
		public unsafe float DebugTextLifeTimeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_DebugTextLifeTimeLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_DebugTextLifeTimeLength) = value;
			}
		}

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x0601EA53 RID: 125523 RVA: 0x00919143 File Offset: 0x00917343
		// (set) Token: 0x0601EA54 RID: 125524 RVA: 0x00919157 File Offset: 0x00917357
		public unsafe UPrimitiveComponent OverlappingSkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_OverlappingSkeletalMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_OverlappingSkeletalMesh, value);
			}
		}

		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x0601EA55 RID: 125525 RVA: 0x0091916C File Offset: 0x0091736C
		// (set) Token: 0x0601EA56 RID: 125526 RVA: 0x0091917C File Offset: 0x0091737C
		public unsafe float BrushStrengthTemp2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_BrushStrengthTemp2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_BrushStrengthTemp2) = value;
			}
		}

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x0601EA57 RID: 125527 RVA: 0x0091918D File Offset: 0x0091738D
		// (set) Token: 0x0601EA58 RID: 125528 RVA: 0x0091919D File Offset: 0x0091739D
		public unsafe float InputFeedbackTemp1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_InputFeedbackTemp1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_InputFeedbackTemp1) = value;
			}
		}

		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x0601EA59 RID: 125529 RVA: 0x009191AE File Offset: 0x009173AE
		// (set) Token: 0x0601EA5A RID: 125530 RVA: 0x009191BE File Offset: 0x009173BE
		public unsafe bool DisableAndNotTickBlock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_DisableAndNotTickBlock) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_DisableAndNotTickBlock) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x0601EA5B RID: 125531 RVA: 0x009191D0 File Offset: 0x009173D0
		// (set) Token: 0x0601EA5C RID: 125532 RVA: 0x00919209 File Offset: 0x00917409
		[Nullable(1)]
		public TArray<UPrimitiveComponent> OverlappingComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UPrimitiveComponent> result;
				if ((result = this._OverlappingComponents) == null)
				{
					result = (this._OverlappingComponents = new TArray<UPrimitiveComponent>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OverlappingComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OverlappingComponents.CopyAssign(value);
			}
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x0601EA5D RID: 125533 RVA: 0x00919218 File Offset: 0x00917418
		// (set) Token: 0x0601EA5E RID: 125534 RVA: 0x00919251 File Offset: 0x00917451
		[Nullable(1)]
		public TArray<AActor> OverlappingActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._OverlappingActors) == null)
				{
					result = (this._OverlappingActors = new TArray<AActor>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OverlappingActors, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OverlappingActors.CopyAssign(value);
			}
		}

		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x0601EA5F RID: 125535 RVA: 0x00919260 File Offset: 0x00917460
		// (set) Token: 0x0601EA60 RID: 125536 RVA: 0x00919299 File Offset: 0x00917499
		[Nullable(1)]
		public TMap<int, UPrimitiveComponent> SkeletalMesh_TempArray_Pairs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<int, UPrimitiveComponent> result;
				if ((result = this._SkeletalMesh_TempArray_Pairs) == null)
				{
					result = (this._SkeletalMesh_TempArray_Pairs = new TMap<int, UPrimitiveComponent>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_SkeletalMesh_TempArray_Pairs, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SkeletalMesh_TempArray_Pairs.CopyAssign(value);
			}
		}

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x0601EA61 RID: 125537 RVA: 0x009192A8 File Offset: 0x009174A8
		// (set) Token: 0x0601EA62 RID: 125538 RVA: 0x009192E1 File Offset: 0x009174E1
		[Nullable(1)]
		public TArray<AActor> OverlappingActorsInitial
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._OverlappingActorsInitial) == null)
				{
					result = (this._OverlappingActorsInitial = new TArray<AActor>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OverlappingActorsInitial, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OverlappingActorsInitial.CopyAssign(value);
			}
		}

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x0601EA63 RID: 125539 RVA: 0x009192F0 File Offset: 0x009174F0
		// (set) Token: 0x0601EA64 RID: 125540 RVA: 0x00919329 File Offset: 0x00917529
		[Nullable(1)]
		public OwnerRePlayEvent OwnerRePlayEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OwnerRePlayEvent result;
				if ((result = this._OwnerRePlayEvent) == null)
				{
					result = (this._OwnerRePlayEvent = new OwnerRePlayEvent(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OwnerRePlayEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OwnerRePlayEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x0601EA65 RID: 125541 RVA: 0x0091934A File Offset: 0x0091754A
		// (set) Token: 0x0601EA66 RID: 125542 RVA: 0x0091935A File Offset: 0x0091755A
		public unsafe bool OverrideComponentVariables
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OverrideComponentVariables) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OverrideComponentVariables) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x0601EA67 RID: 125543 RVA: 0x0091936B File Offset: 0x0091756B
		// (set) Token: 0x0601EA68 RID: 125544 RVA: 0x0091937B File Offset: 0x0091757B
		public unsafe bool AutoConnectToMemoryPool_IF_Found
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_AutoConnectToMemoryPool_IF_Found) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_AutoConnectToMemoryPool_IF_Found) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x0601EA69 RID: 125545 RVA: 0x0091938C File Offset: 0x0091758C
		// (set) Token: 0x0601EA6A RID: 125546 RVA: 0x0091939C File Offset: 0x0091759C
		public unsafe int OutputFilterMaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OutputFilterMaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_OutputFilterMaterialIndex) = value;
			}
		}

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x0601EA6B RID: 125547 RVA: 0x009193AD File Offset: 0x009175AD
		// (set) Token: 0x0601EA6C RID: 125548 RVA: 0x009193BD File Offset: 0x009175BD
		public unsafe bool ShowLODdebugMessagesOnScreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ShowLODdebugMessagesOnScreen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_ShowLODdebugMessagesOnScreen) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x0601EA6D RID: 125549 RVA: 0x009193CE File Offset: 0x009175CE
		// (set) Token: 0x0601EA6E RID: 125550 RVA: 0x009193DE File Offset: 0x009175DE
		public unsafe float GlobalBrushScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_GlobalBrushScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_GlobalBrushScale) = value;
			}
		}

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x0601EA6F RID: 125551 RVA: 0x009193EF File Offset: 0x009175EF
		// (set) Token: 0x0601EA70 RID: 125552 RVA: 0x009193FF File Offset: 0x009175FF
		public unsafe bool LOD1_ReduceIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_LOD1_ReduceIterations) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_LOD1_ReduceIterations) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x0601EA71 RID: 125553 RVA: 0x00919410 File Offset: 0x00917610
		// (set) Token: 0x0601EA72 RID: 125554 RVA: 0x00919420 File Offset: 0x00917620
		public unsafe bool LOD2_ReduceSamplingFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_LOD2_ReduceSamplingFPS) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_LOD2_ReduceSamplingFPS) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x0601EA73 RID: 125555 RVA: 0x00919431 File Offset: 0x00917631
		// (set) Token: 0x0601EA74 RID: 125556 RVA: 0x00919441 File Offset: 0x00917641
		public unsafe bool LOD3_ReduceCollisionAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_LOD3_ReduceCollisionAmount) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_LOD3_ReduceCollisionAmount) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0601EA75 RID: 125557 RVA: 0x00919452 File Offset: 0x00917652
		// (set) Token: 0x0601EA76 RID: 125558 RVA: 0x00919462 File Offset: 0x00917662
		public unsafe int MinSamplingFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_MinSamplingFPS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_MinSamplingFPS) = value;
			}
		}

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0601EA77 RID: 125559 RVA: 0x00919473 File Offset: 0x00917673
		// (set) Token: 0x0601EA78 RID: 125560 RVA: 0x00919483 File Offset: 0x00917683
		public unsafe float LOD_FarBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_LOD_FarBound);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_LOD_FarBound) = value;
			}
		}

		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x0601EA79 RID: 125561 RVA: 0x00919494 File Offset: 0x00917694
		// (set) Token: 0x0601EA7A RID: 125562 RVA: 0x009194A4 File Offset: 0x009176A4
		public unsafe float LOD_NearBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_LOD_NearBound);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_LOD_NearBound) = value;
			}
		}

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0601EA7B RID: 125563 RVA: 0x009194B5 File Offset: 0x009176B5
		// (set) Token: 0x0601EA7C RID: 125564 RVA: 0x009194C5 File Offset: 0x009176C5
		public unsafe int DownscaleCollisionPainterResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_DownscaleCollisionPainterResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_DownscaleCollisionPainterResolution) = value;
			}
		}

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0601EA7D RID: 125565 RVA: 0x009194D6 File Offset: 0x009176D6
		// (set) Token: 0x0601EA7E RID: 125566 RVA: 0x009194E6 File Offset: 0x009176E6
		public unsafe int DownscalePressureResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_DownscalePressureResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_DownscalePressureResolution) = value;
			}
		}

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x0601EA7F RID: 125567 RVA: 0x009194F7 File Offset: 0x009176F7
		// (set) Token: 0x0601EA80 RID: 125568 RVA: 0x00919507 File Offset: 0x00917707
		public unsafe bool SingleTargetMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_SingleTargetMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_SingleTargetMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x0601EA81 RID: 125569 RVA: 0x00919518 File Offset: 0x00917718
		// (set) Token: 0x0601EA82 RID: 125570 RVA: 0x00919528 File Offset: 0x00917728
		public unsafe bool InitialActorsProcessed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_InitialActorsProcessed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_InitialActorsProcessed) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0601EA83 RID: 125571 RVA: 0x00919539 File Offset: 0x00917739
		// (set) Token: 0x0601EA84 RID: 125572 RVA: 0x00919549 File Offset: 0x00917749
		public unsafe bool SKMeshTagged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_SKMeshTagged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_SKMeshTagged) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x0601EA85 RID: 125573 RVA: 0x0091955A File Offset: 0x0091775A
		// (set) Token: 0x0601EA86 RID: 125574 RVA: 0x0091956A File Offset: 0x0091776A
		public unsafe bool bOnlySelfTraceMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_bOnlySelfTraceMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_bOnlySelfTraceMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0601EA87 RID: 125575 RVA: 0x0091957B File Offset: 0x0091777B
		// (set) Token: 0x0601EA88 RID: 125576 RVA: 0x0091958B File Offset: 0x0091778B
		public unsafe bool bOnlyFirstSkeletal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_bOnlyFirstSkeletal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_bOnlyFirstSkeletal) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0601EA89 RID: 125577 RVA: 0x0091959C File Offset: 0x0091779C
		// (set) Token: 0x0601EA8A RID: 125578 RVA: 0x009195D5 File Offset: 0x009177D5
		[Nullable(1)]
		public TArray<USkeletalMeshComponent> tempArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMeshComponent> result;
				if ((result = this._tempArray) == null)
				{
					result = (this._tempArray = new TArray<USkeletalMeshComponent>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_tempArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.tempArray.CopyAssign(value);
			}
		}

		// Token: 0x0601EA8B RID: 125579 RVA: 0x009195E3 File Offset: 0x009177E3
		[SkipLocalsInit]
		public virtual void ResetTempArrays()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__ResetTempArrays_NativeFunctionPtr, null);
		}

		// Token: 0x0601EA8C RID: 125580 RVA: 0x009195F7 File Offset: 0x009177F7
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601EA8D RID: 125581 RVA: 0x0091960B File Offset: 0x0091780B
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601EA8E RID: 125582 RVA: 0x00919620 File Offset: 0x00917820
		[SkipLocalsInit]
		public unsafe virtual void InpTchEvt_Released(ETouchIndex FingerIndex, FVector Location)
		{
			NinjaLive_C.__InpTchEvt_Released_FunctionParams* ptr = stackalloc NinjaLive_C.__InpTchEvt_Released_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(NinjaLive_C.__InpTchEvt_Released_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__InpTchEvt_Released_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__InpTchEvt_Released_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EA8F RID: 125583 RVA: 0x00919674 File Offset: 0x00917874
		[SkipLocalsInit]
		public unsafe virtual void InpTchEvt_Pressed(ETouchIndex FingerIndex, FVector Location)
		{
			NinjaLive_C.__InpTchEvt_Pressed_FunctionParams* ptr = stackalloc NinjaLive_C.__InpTchEvt_Pressed_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(NinjaLive_C.__InpTchEvt_Pressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__InpTchEvt_Pressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__InpTchEvt_Pressed_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EA90 RID: 125584 RVA: 0x009196C8 File Offset: 0x009178C8
		[SkipLocalsInit]
		public unsafe virtual void InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_1(FKey Key)
		{
			NinjaLive_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_1_FunctionParams* ptr = stackalloc NinjaLive_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_1_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_1_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_1_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_1_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EA91 RID: 125585 RVA: 0x0091973C File Offset: 0x0091793C
		[SkipLocalsInit]
		public unsafe virtual void InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_0(FKey Key)
		{
			NinjaLive_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_0_FunctionParams* ptr = stackalloc NinjaLive_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_0_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EA92 RID: 125586 RVA: 0x009197B0 File Offset: 0x009179B0
		[SkipLocalsInit]
		public unsafe virtual void LiveActivation(FName ParamName, float FadeTimeOfBrush, float FadeTimeOfCanvas)
		{
			NinjaLive_C.__LiveActivation_FunctionParams* ptr = stackalloc NinjaLive_C.__LiveActivation_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(NinjaLive_C.__LiveActivation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__LiveActivation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ParamName = ParamName;
			ptr->FadeTimeOfBrush = FadeTimeOfBrush;
			ptr->FadeTimeOfCanvas = FadeTimeOfCanvas;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__LiveActivation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EA93 RID: 125587 RVA: 0x00919804 File Offset: 0x00917A04
		[SkipLocalsInit]
		public unsafe virtual void LiveFluidParams(float BrushSize)
		{
			NinjaLive_C.__LiveFluidParams_FunctionParams* ptr = stackalloc NinjaLive_C.__LiveFluidParams_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLive_C.__LiveFluidParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__LiveFluidParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BrushSize = BrushSize;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__LiveFluidParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EA94 RID: 125588 RVA: 0x0091984C File Offset: 0x00917A4C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			NinjaLive_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaLive_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLive_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EA95 RID: 125589 RVA: 0x00919894 File Offset: 0x00917A94
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			NinjaLive_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaLive_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLive_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EA96 RID: 125590 RVA: 0x009198DA File Offset: 0x00917ADA
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601EA97 RID: 125591 RVA: 0x009198EE File Offset: 0x00917AEE
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601EA98 RID: 125592 RVA: 0x00919902 File Offset: 0x00917B02
		[SkipLocalsInit]
		public virtual void RePlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__RePlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601EA99 RID: 125593 RVA: 0x00919916 File Offset: 0x00917B16
		[SkipLocalsInit]
		public override void BeforeCookForPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__BeforeCookForPC_NativeFunctionPtr, null);
		}

		// Token: 0x0601EA9A RID: 125594 RVA: 0x0091992A File Offset: 0x00917B2A
		[SkipLocalsInit]
		protected override void BeforeCookForPC_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__BeforeCookForPC_NativeFunctionPtr, null);
		}

		// Token: 0x0601EA9B RID: 125595 RVA: 0x0091993E File Offset: 0x00917B3E
		[SkipLocalsInit]
		public override void BeforeCookForMobile()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__BeforeCookForMobile_NativeFunctionPtr, null);
		}

		// Token: 0x0601EA9C RID: 125596 RVA: 0x00919952 File Offset: 0x00917B52
		[SkipLocalsInit]
		protected override void BeforeCookForMobile_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__BeforeCookForMobile_NativeFunctionPtr, null);
		}

		// Token: 0x0601EA9D RID: 125597 RVA: 0x00919968 File Offset: 0x00917B68
		[SkipLocalsInit]
		public unsafe virtual void BeginOverlapComponent(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			NinjaLive_C.__BeginOverlapComponent_FunctionParams* ptr = stackalloc NinjaLive_C.__BeginOverlapComponent_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(NinjaLive_C.__BeginOverlapComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__BeginOverlapComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__BeginOverlapComponent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EA9E RID: 125598 RVA: 0x00919A24 File Offset: 0x00917C24
		[SkipLocalsInit]
		public unsafe virtual void EndOverlapComponent(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			NinjaLive_C.__EndOverlapComponent_FunctionParams* ptr = stackalloc NinjaLive_C.__EndOverlapComponent_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_C.__EndOverlapComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__EndOverlapComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__EndOverlapComponent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EA9F RID: 125599 RVA: 0x00919AB0 File Offset: 0x00917CB0
		[SkipLocalsInit]
		public unsafe override void ReceiveActorEndOverlap(AActor OtherActor)
		{
			NinjaLive_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc NinjaLive_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLive_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EAA0 RID: 125600 RVA: 0x00919B08 File Offset: 0x00917D08
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveActorEndOverlap_Implementation(AActor OtherActor)
		{
			NinjaLive_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc NinjaLive_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLive_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EAA1 RID: 125601 RVA: 0x00919B60 File Offset: 0x00917D60
		[SkipLocalsInit]
		public unsafe override void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			NinjaLive_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc NinjaLive_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLive_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EAA2 RID: 125602 RVA: 0x00919BB8 File Offset: 0x00917DB8
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
		{
			NinjaLive_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc NinjaLive_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLive_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EAA3 RID: 125603 RVA: 0x00919C0D File Offset: 0x00917E0D
		protected NinjaLive_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103F3 RID: 66547
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive.NinjaLive_C";

		// Token: 0x040103F4 RID: 66548
		private static IntPtr _ClassPtr;

		// Token: 0x040103F5 RID: 66549
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040103F6 RID: 66550
		public static IntPtr __OwnerRePlayEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040103F7 RID: 66551
		internal static int __PropertyOffset_InteractionVolume;

		// Token: 0x040103F8 RID: 66552
		internal static int __PropertyOffset_ActivationVolume;

		// Token: 0x040103F9 RID: 66553
		internal static int __PropertyOffset_TraceMesh;

		// Token: 0x040103FA RID: 66554
		internal static int __PropertyOffset_Root;

		// Token: 0x040103FB RID: 66555
		internal static int __PropertyOffset_RT_DensityPreview;

		// Token: 0x040103FC RID: 66556
		internal static int __PropertyOffset_InactiveGrayMaterial;

		// Token: 0x040103FD RID: 66557
		internal static int __PropertyOffset_DisableBlueprint;

		// Token: 0x040103FE RID: 66558
		internal static int __PropertyOffset_TimeCounterForBrush;

		// Token: 0x040103FF RID: 66559
		internal static int __PropertyOffset_DeltaSeconds;

		// Token: 0x04010400 RID: 66560
		internal static int __PropertyOffset_MousePressed;

		// Token: 0x04010401 RID: 66561
		internal static int __PropertyOffset_ShowTraceMeshInEditor;

		// Token: 0x04010402 RID: 66562
		internal static int __PropertyOffset_TraceMeshSize;

		// Token: 0x04010403 RID: 66563
		internal static int __PropertyOffset_OverlapBasedInteraction;

		// Token: 0x04010404 RID: 66564
		internal static int __PropertyOffset_NinjaLIVECollisionExclude;

		// Token: 0x04010405 RID: 66565
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<NinjaLive_C> _NinjaLIVECollisionExclude;

		// Token: 0x04010406 RID: 66566
		internal static int __PropertyOffset_Time;

		// Token: 0x04010407 RID: 66567
		internal static int __PropertyOffset_SimActivatedByPawnProximity;

		// Token: 0x04010408 RID: 66568
		internal static int __PropertyOffset_ShowActivationVolumeInEditor;

		// Token: 0x04010409 RID: 66569
		internal static int __PropertyOffset_ActivationVolumeSize;

		// Token: 0x0401040A RID: 66570
		internal static int __PropertyOffset_ActivatorProximityCheckFrequency;

		// Token: 0x0401040B RID: 66571
		internal static int __PropertyOffset_ActivatorType;

		// Token: 0x0401040C RID: 66572
		internal static int __PropertyOffset_Activator;

		// Token: 0x0401040D RID: 66573
		internal static int __PropertyOffset_PawnInsideActivationBounds;

		// Token: 0x0401040E RID: 66574
		internal static int __PropertyOffset_InitDone;

		// Token: 0x0401040F RID: 66575
		internal static int __PropertyOffset_BeginPlaySupressed;

		// Token: 0x04010410 RID: 66576
		internal static int __PropertyOffset_UseTraceMeshAsInteractionVolume;

		// Token: 0x04010411 RID: 66577
		internal static int __PropertyOffset_ShowInteractionVolumeInEditor;

		// Token: 0x04010412 RID: 66578
		internal static int __PropertyOffset_InteractionVolumeSize;

		// Token: 0x04010413 RID: 66579
		internal static int __PropertyOffset_MultipleTouchLookup;

		// Token: 0x04010414 RID: 66580
		private TArray<bool> _MultipleTouchLookup;

		// Token: 0x04010415 RID: 66581
		internal static int __PropertyOffset_TickRateCustom;

		// Token: 0x04010416 RID: 66582
		internal static int __PropertyOffset_InteractionVolumeTemplate;

		// Token: 0x04010417 RID: 66583
		internal static int __PropertyOffset_TrackActorPrimitiveComponentsWithTag;

		// Token: 0x04010418 RID: 66584
		internal static int __PropertyOffset_TrackActorSkeletalMeshComponentsWithTag;

		// Token: 0x04010419 RID: 66585
		internal static int __PropertyOffset_OverlapFilterInclusiveObjType;

		// Token: 0x0401041A RID: 66586
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _OverlapFilterInclusiveObjType;

		// Token: 0x0401041B RID: 66587
		internal static int __PropertyOffset_OverlapFilterInclusiveBoneNameExact;

		// Token: 0x0401041C RID: 66588
		private TArray<FName> _OverlapFilterInclusiveBoneNameExact;

		// Token: 0x0401041D RID: 66589
		internal static int __PropertyOffset_OverlapFilterInclusiveBoneNamePartial;

		// Token: 0x0401041E RID: 66590
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _OverlapFilterInclusiveBoneNamePartial;

		// Token: 0x0401041F RID: 66591
		internal static int __PropertyOffset_ExcludeSpecificActorsFromOverlap;

		// Token: 0x04010420 RID: 66592
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ExcludeSpecificActorsFromOverlap;

		// Token: 0x04010421 RID: 66593
		internal static int __PropertyOffset_AutoExcludeLargeOverlappingObjects;

		// Token: 0x04010422 RID: 66594
		internal static int __PropertyOffset_OverlapFilterInclusiveCollisionType;

		// Token: 0x04010423 RID: 66595
		[Nullable(new byte[]
		{
			2,
			0,
			0
		})]
		private TMap<TEnumAsByte<ECollisionChannel>, TEnumAsByte<EObjectTypeQuery>> _OverlapFilterInclusiveCollisionType;

		// Token: 0x04010424 RID: 66596
		internal static int __PropertyOffset_ActivationEventsDebugPrint;

		// Token: 0x04010425 RID: 66597
		internal static int __PropertyOffset_SimContainerCapacityWarning;

		// Token: 0x04010426 RID: 66598
		internal static int __PropertyOffset_SaveDebugTextToLog;

		// Token: 0x04010427 RID: 66599
		internal static int __PropertyOffset_DebugTextLifeTimeLength;

		// Token: 0x04010428 RID: 66600
		internal static int __PropertyOffset_OverlappingSkeletalMesh;

		// Token: 0x04010429 RID: 66601
		internal static int __PropertyOffset_BrushStrengthTemp2;

		// Token: 0x0401042A RID: 66602
		internal static int __PropertyOffset_InputFeedbackTemp1;

		// Token: 0x0401042B RID: 66603
		internal static int __PropertyOffset_DisableAndNotTickBlock;

		// Token: 0x0401042C RID: 66604
		internal static int __PropertyOffset_OverlappingComponents;

		// Token: 0x0401042D RID: 66605
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPrimitiveComponent> _OverlappingComponents;

		// Token: 0x0401042E RID: 66606
		internal static int __PropertyOffset_OverlappingActors;

		// Token: 0x0401042F RID: 66607
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _OverlappingActors;

		// Token: 0x04010430 RID: 66608
		internal static int __PropertyOffset_SkeletalMesh_TempArray_Pairs;

		// Token: 0x04010431 RID: 66609
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UPrimitiveComponent> _SkeletalMesh_TempArray_Pairs;

		// Token: 0x04010432 RID: 66610
		internal static int __PropertyOffset_OverlappingActorsInitial;

		// Token: 0x04010433 RID: 66611
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _OverlappingActorsInitial;

		// Token: 0x04010434 RID: 66612
		internal static int __PropertyOffset_OwnerRePlayEvent;

		// Token: 0x04010435 RID: 66613
		private OwnerRePlayEvent _OwnerRePlayEvent;

		// Token: 0x04010436 RID: 66614
		internal static int __PropertyOffset_OverrideComponentVariables;

		// Token: 0x04010437 RID: 66615
		internal static int __PropertyOffset_AutoConnectToMemoryPool_IF_Found;

		// Token: 0x04010438 RID: 66616
		internal static int __PropertyOffset_OutputFilterMaterialIndex;

		// Token: 0x04010439 RID: 66617
		internal static int __PropertyOffset_ShowLODdebugMessagesOnScreen;

		// Token: 0x0401043A RID: 66618
		internal static int __PropertyOffset_GlobalBrushScale;

		// Token: 0x0401043B RID: 66619
		internal static int __PropertyOffset_LOD1_ReduceIterations;

		// Token: 0x0401043C RID: 66620
		internal static int __PropertyOffset_LOD2_ReduceSamplingFPS;

		// Token: 0x0401043D RID: 66621
		internal static int __PropertyOffset_LOD3_ReduceCollisionAmount;

		// Token: 0x0401043E RID: 66622
		internal static int __PropertyOffset_MinSamplingFPS;

		// Token: 0x0401043F RID: 66623
		internal static int __PropertyOffset_LOD_FarBound;

		// Token: 0x04010440 RID: 66624
		internal static int __PropertyOffset_LOD_NearBound;

		// Token: 0x04010441 RID: 66625
		internal static int __PropertyOffset_DownscaleCollisionPainterResolution;

		// Token: 0x04010442 RID: 66626
		internal static int __PropertyOffset_DownscalePressureResolution;

		// Token: 0x04010443 RID: 66627
		internal static int __PropertyOffset_SingleTargetMode;

		// Token: 0x04010444 RID: 66628
		internal static int __PropertyOffset_InitialActorsProcessed;

		// Token: 0x04010445 RID: 66629
		internal static int __PropertyOffset_SKMeshTagged;

		// Token: 0x04010446 RID: 66630
		internal static int __PropertyOffset_bOnlySelfTraceMesh;

		// Token: 0x04010447 RID: 66631
		internal static int __PropertyOffset_bOnlyFirstSkeletal;

		// Token: 0x04010448 RID: 66632
		internal static int __PropertyOffset_tempArray;

		// Token: 0x04010449 RID: 66633
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMeshComponent> _tempArray;

		// Token: 0x0401044A RID: 66634
		private static IntPtr __ResetTempArrays_NativeFunctionPtr;

		// Token: 0x0401044B RID: 66635
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401044C RID: 66636
		private static IntPtr __InpTchEvt_Released_NativeFunctionPtr;

		// Token: 0x0401044D RID: 66637
		private static IntPtr __InpTchEvt_Pressed_NativeFunctionPtr;

		// Token: 0x0401044E RID: 66638
		private static IntPtr __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_1_NativeFunctionPtr;

		// Token: 0x0401044F RID: 66639
		private static IntPtr __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_0_NativeFunctionPtr;

		// Token: 0x04010450 RID: 66640
		private static IntPtr __LiveActivation_NativeFunctionPtr;

		// Token: 0x04010451 RID: 66641
		private static IntPtr __LiveFluidParams_NativeFunctionPtr;

		// Token: 0x04010452 RID: 66642
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010453 RID: 66643
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010454 RID: 66644
		private static IntPtr __RePlay_NativeFunctionPtr;

		// Token: 0x04010455 RID: 66645
		private static IntPtr __BeforeCookForPC_NativeFunctionPtr;

		// Token: 0x04010456 RID: 66646
		private static IntPtr __BeforeCookForMobile_NativeFunctionPtr;

		// Token: 0x04010457 RID: 66647
		private static IntPtr __BeginOverlapComponent_NativeFunctionPtr;

		// Token: 0x04010458 RID: 66648
		private static IntPtr __EndOverlapComponent_NativeFunctionPtr;

		// Token: 0x04010459 RID: 66649
		private static IntPtr __ReceiveActorEndOverlap_NativeFunctionPtr;

		// Token: 0x0401045A RID: 66650
		private static IntPtr __ReceiveActorBeginOverlap_NativeFunctionPtr;

		// Token: 0x02008EA5 RID: 36517
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InpTchEvt_Released_FunctionParams
		{
			// Token: 0x0402CB35 RID: 183093
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x0402CB36 RID: 183094
			[FieldOffset(4)]
			public FVector Location;
		}

		// Token: 0x02008EA6 RID: 36518
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InpTchEvt_Pressed_FunctionParams
		{
			// Token: 0x0402CB37 RID: 183095
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x0402CB38 RID: 183096
			[FieldOffset(4)]
			public FVector Location;
		}

		// Token: 0x02008EA7 RID: 36519
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_1_FunctionParams
		{
			// Token: 0x0402CB39 RID: 183097
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008EA8 RID: 36520
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_0_FunctionParams
		{
			// Token: 0x0402CB3A RID: 183098
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008EA9 RID: 36521
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __LiveActivation_FunctionParams
		{
			// Token: 0x0402CB3B RID: 183099
			[FieldOffset(0)]
			public FName ParamName;

			// Token: 0x0402CB3C RID: 183100
			[FieldOffset(12)]
			public float FadeTimeOfBrush;

			// Token: 0x0402CB3D RID: 183101
			[FieldOffset(16)]
			public float FadeTimeOfCanvas;
		}

		// Token: 0x02008EAA RID: 36522
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __LiveFluidParams_FunctionParams
		{
			// Token: 0x0402CB3E RID: 183102
			[FieldOffset(0)]
			public float BrushSize;
		}

		// Token: 0x02008EAB RID: 36523
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CB3F RID: 183103
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008EAC RID: 36524
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BeginOverlapComponent_FunctionParams
		{
			// Token: 0x0402CB40 RID: 183104
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0402CB41 RID: 183105
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0402CB42 RID: 183106
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0402CB43 RID: 183107
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0402CB44 RID: 183108
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0402CB45 RID: 183109
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02008EAD RID: 36525
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __EndOverlapComponent_FunctionParams
		{
			// Token: 0x0402CB46 RID: 183110
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0402CB47 RID: 183111
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0402CB48 RID: 183112
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0402CB49 RID: 183113
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02008EAE RID: 36526
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorEndOverlap_FunctionParams
		{
			// Token: 0x0402CB4A RID: 183114
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x02008EAF RID: 36527
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x0402CB4B RID: 183115
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}
	}
}
