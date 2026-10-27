using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D8D RID: 15757
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive.NinjaLive_C")]
	[UnrealStructLayout(2064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2064)]
	public class NinjaLive_C : AUKuroCustomCookActor, IUnrealUObject, IUnrealObject, INinjaLiveInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06026EA7 RID: 159399 RVA: 0x00981696 File Offset: 0x0097F896
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NinjaLive_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive.NinjaLive_C");
			}
			return NinjaLive_C._ClassPtr;
		}

		// Token: 0x06026EA8 RID: 159400 RVA: 0x009816BC File Offset: 0x0097F8BC
		public NinjaLive_C() : this(BuiltinUtils.AllocNativeUObject(NinjaLive_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026EA9 RID: 159401 RVA: 0x009816E4 File Offset: 0x0097F8E4
		[NullableContext(1)]
		public NinjaLive_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NinjaLive_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005538 RID: 21816
		// (get) Token: 0x06026EAA RID: 159402 RVA: 0x00981717 File Offset: 0x0097F917
		// (set) Token: 0x06026EAB RID: 159403 RVA: 0x0098172B File Offset: 0x0097F92B
		public unsafe NinjaLiveComponent_C NinjaLiveComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<NinjaLiveComponent_C>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005539 RID: 21817
		// (get) Token: 0x06026EAC RID: 159404 RVA: 0x00981740 File Offset: 0x0097F940
		// (set) Token: 0x06026EAD RID: 159405 RVA: 0x00981754 File Offset: 0x0097F954
		public unsafe UBoxComponent InteractionVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700553A RID: 21818
		// (get) Token: 0x06026EAE RID: 159406 RVA: 0x00981769 File Offset: 0x0097F969
		// (set) Token: 0x06026EAF RID: 159407 RVA: 0x0098177D File Offset: 0x0097F97D
		public unsafe UBoxComponent ActivationVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700553B RID: 21819
		// (get) Token: 0x06026EB0 RID: 159408 RVA: 0x00981792 File Offset: 0x0097F992
		// (set) Token: 0x06026EB1 RID: 159409 RVA: 0x009817A6 File Offset: 0x0097F9A6
		public unsafe UMaterialBillboardComponent EditorIcon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700553C RID: 21820
		// (get) Token: 0x06026EB2 RID: 159410 RVA: 0x009817BB File Offset: 0x0097F9BB
		// (set) Token: 0x06026EB3 RID: 159411 RVA: 0x009817CF File Offset: 0x0097F9CF
		public unsafe UStaticMeshComponent TraceMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700553D RID: 21821
		// (get) Token: 0x06026EB4 RID: 159412 RVA: 0x009817E4 File Offset: 0x0097F9E4
		// (set) Token: 0x06026EB5 RID: 159413 RVA: 0x009817F8 File Offset: 0x0097F9F8
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700553E RID: 21822
		// (get) Token: 0x06026EB6 RID: 159414 RVA: 0x0098180D File Offset: 0x0097FA0D
		// (set) Token: 0x06026EB7 RID: 159415 RVA: 0x00981821 File Offset: 0x0097FA21
		public unsafe UTextureRenderTarget2D RT_DensityPreview
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700553F RID: 21823
		// (get) Token: 0x06026EB8 RID: 159416 RVA: 0x00981836 File Offset: 0x0097FA36
		// (set) Token: 0x06026EB9 RID: 159417 RVA: 0x0098184A File Offset: 0x0097FA4A
		public unsafe UMaterialInstance InactiveGrayMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005540 RID: 21824
		// (get) Token: 0x06026EBA RID: 159418 RVA: 0x0098185F File Offset: 0x0097FA5F
		// (set) Token: 0x06026EBB RID: 159419 RVA: 0x0098186F File Offset: 0x0097FA6F
		public unsafe bool DisableBlueprint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005541 RID: 21825
		// (get) Token: 0x06026EBC RID: 159420 RVA: 0x00981880 File Offset: 0x0097FA80
		// (set) Token: 0x06026EBD RID: 159421 RVA: 0x00981890 File Offset: 0x0097FA90
		public unsafe float TimeCounterForBrush
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005542 RID: 21826
		// (get) Token: 0x06026EBE RID: 159422 RVA: 0x009818A1 File Offset: 0x0097FAA1
		// (set) Token: 0x06026EBF RID: 159423 RVA: 0x009818B1 File Offset: 0x0097FAB1
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005543 RID: 21827
		// (get) Token: 0x06026EC0 RID: 159424 RVA: 0x009818C2 File Offset: 0x0097FAC2
		// (set) Token: 0x06026EC1 RID: 159425 RVA: 0x009818D2 File Offset: 0x0097FAD2
		public unsafe bool MousePressed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005544 RID: 21828
		// (get) Token: 0x06026EC2 RID: 159426 RVA: 0x009818E3 File Offset: 0x0097FAE3
		// (set) Token: 0x06026EC3 RID: 159427 RVA: 0x009818F3 File Offset: 0x0097FAF3
		public unsafe bool ShowTraceMeshInEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005545 RID: 21829
		// (get) Token: 0x06026EC4 RID: 159428 RVA: 0x00981904 File Offset: 0x0097FB04
		// (set) Token: 0x06026EC5 RID: 159429 RVA: 0x00981918 File Offset: 0x0097FB18
		public unsafe FVector TraceMeshSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005546 RID: 21830
		// (get) Token: 0x06026EC6 RID: 159430 RVA: 0x0098192D File Offset: 0x0097FB2D
		// (set) Token: 0x06026EC7 RID: 159431 RVA: 0x00981941 File Offset: 0x0097FB41
		[Nullable(0)]
		public unsafe TEnumAsByte<UserInput_Enum> UserInputBasedInteraction
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_15);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005547 RID: 21831
		// (get) Token: 0x06026EC8 RID: 159432 RVA: 0x00981956 File Offset: 0x0097FB56
		// (set) Token: 0x06026EC9 RID: 159433 RVA: 0x00981966 File Offset: 0x0097FB66
		public unsafe bool OverlapBasedInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005548 RID: 21832
		// (get) Token: 0x06026ECA RID: 159434 RVA: 0x00981978 File Offset: 0x0097FB78
		// (set) Token: 0x06026ECB RID: 159435 RVA: 0x009819B1 File Offset: 0x0097FBB1
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
					result = (this._NinjaLIVECollisionExclude = new TArray<NinjaLive_C>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_17, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NinjaLIVECollisionExclude.CopyAssign(value);
			}
		}

		// Token: 0x17005549 RID: 21833
		// (get) Token: 0x06026ECC RID: 159436 RVA: 0x009819BF File Offset: 0x0097FBBF
		// (set) Token: 0x06026ECD RID: 159437 RVA: 0x009819CF File Offset: 0x0097FBCF
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700554A RID: 21834
		// (get) Token: 0x06026ECE RID: 159438 RVA: 0x009819E0 File Offset: 0x0097FBE0
		// (set) Token: 0x06026ECF RID: 159439 RVA: 0x009819F0 File Offset: 0x0097FBF0
		public unsafe bool SimActivatedByPawnProximity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700554B RID: 21835
		// (get) Token: 0x06026ED0 RID: 159440 RVA: 0x00981A01 File Offset: 0x0097FC01
		// (set) Token: 0x06026ED1 RID: 159441 RVA: 0x00981A11 File Offset: 0x0097FC11
		public unsafe bool ShowActivationVolumeInEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700554C RID: 21836
		// (get) Token: 0x06026ED2 RID: 159442 RVA: 0x00981A22 File Offset: 0x0097FC22
		// (set) Token: 0x06026ED3 RID: 159443 RVA: 0x00981A36 File Offset: 0x0097FC36
		public unsafe FVector ActivationVolumeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700554D RID: 21837
		// (get) Token: 0x06026ED4 RID: 159444 RVA: 0x00981A4B File Offset: 0x0097FC4B
		// (set) Token: 0x06026ED5 RID: 159445 RVA: 0x00981A5B File Offset: 0x0097FC5B
		public unsafe float ActivatorProximityCheckFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700554E RID: 21838
		// (get) Token: 0x06026ED6 RID: 159446 RVA: 0x00981A6C File Offset: 0x0097FC6C
		// (set) Token: 0x06026ED7 RID: 159447 RVA: 0x00981A80 File Offset: 0x0097FC80
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> ActivatorType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_23);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700554F RID: 21839
		// (get) Token: 0x06026ED8 RID: 159448 RVA: 0x00981A95 File Offset: 0x0097FC95
		// (set) Token: 0x06026ED9 RID: 159449 RVA: 0x00981AA9 File Offset: 0x0097FCA9
		public unsafe AActor Activator
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17005550 RID: 21840
		// (get) Token: 0x06026EDA RID: 159450 RVA: 0x00981ABE File Offset: 0x0097FCBE
		// (set) Token: 0x06026EDB RID: 159451 RVA: 0x00981ACE File Offset: 0x0097FCCE
		public unsafe bool PawnInsideActivationBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005551 RID: 21841
		// (get) Token: 0x06026EDC RID: 159452 RVA: 0x00981ADF File Offset: 0x0097FCDF
		// (set) Token: 0x06026EDD RID: 159453 RVA: 0x00981AEF File Offset: 0x0097FCEF
		public unsafe bool InitDone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005552 RID: 21842
		// (get) Token: 0x06026EDE RID: 159454 RVA: 0x00981B00 File Offset: 0x0097FD00
		// (set) Token: 0x06026EDF RID: 159455 RVA: 0x00981B10 File Offset: 0x0097FD10
		public unsafe bool BeginPlaySupressed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005553 RID: 21843
		// (get) Token: 0x06026EE0 RID: 159456 RVA: 0x00981B21 File Offset: 0x0097FD21
		// (set) Token: 0x06026EE1 RID: 159457 RVA: 0x00981B31 File Offset: 0x0097FD31
		public unsafe bool UseTraceMeshAsInteractionVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005554 RID: 21844
		// (get) Token: 0x06026EE2 RID: 159458 RVA: 0x00981B42 File Offset: 0x0097FD42
		// (set) Token: 0x06026EE3 RID: 159459 RVA: 0x00981B52 File Offset: 0x0097FD52
		public unsafe bool ShowInteractionVolumeInEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005555 RID: 21845
		// (get) Token: 0x06026EE4 RID: 159460 RVA: 0x00981B63 File Offset: 0x0097FD63
		// (set) Token: 0x06026EE5 RID: 159461 RVA: 0x00981B77 File Offset: 0x0097FD77
		public unsafe FVector InteractionVolumeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17005556 RID: 21846
		// (get) Token: 0x06026EE6 RID: 159462 RVA: 0x00981B8C File Offset: 0x0097FD8C
		// (set) Token: 0x06026EE7 RID: 159463 RVA: 0x00981BC5 File Offset: 0x0097FDC5
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
					result = (this._MultipleTouchLookup = new TArray<bool>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_31, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MultipleTouchLookup.CopyAssign(value);
			}
		}

		// Token: 0x17005557 RID: 21847
		// (get) Token: 0x06026EE8 RID: 159464 RVA: 0x00981BD3 File Offset: 0x0097FDD3
		// (set) Token: 0x06026EE9 RID: 159465 RVA: 0x00981BE3 File Offset: 0x0097FDE3
		public unsafe float TickRateCustom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17005558 RID: 21848
		// (get) Token: 0x06026EEA RID: 159466 RVA: 0x00981BF4 File Offset: 0x0097FDF4
		// (set) Token: 0x06026EEB RID: 159467 RVA: 0x00981C08 File Offset: 0x0097FE08
		public unsafe UPrimitiveComponent InteractionVolumeTemplate
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17005559 RID: 21849
		// (get) Token: 0x06026EEC RID: 159468 RVA: 0x00981C1D File Offset: 0x0097FE1D
		// (set) Token: 0x06026EED RID: 159469 RVA: 0x00981C31 File Offset: 0x0097FE31
		public unsafe FName TrackActorPrimitiveComponentsWithTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x1700555A RID: 21850
		// (get) Token: 0x06026EEE RID: 159470 RVA: 0x00981C46 File Offset: 0x0097FE46
		// (set) Token: 0x06026EEF RID: 159471 RVA: 0x00981C5A File Offset: 0x0097FE5A
		public unsafe FName TrackActorSkeletalMeshComponentsWithTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x1700555B RID: 21851
		// (get) Token: 0x06026EF0 RID: 159472 RVA: 0x00981C70 File Offset: 0x0097FE70
		// (set) Token: 0x06026EF1 RID: 159473 RVA: 0x00981CA9 File Offset: 0x0097FEA9
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
					result = (this._OverlapFilterInclusiveObjType = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_36, this));
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

		// Token: 0x1700555C RID: 21852
		// (get) Token: 0x06026EF2 RID: 159474 RVA: 0x00981CB8 File Offset: 0x0097FEB8
		// (set) Token: 0x06026EF3 RID: 159475 RVA: 0x00981CF1 File Offset: 0x0097FEF1
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
					result = (this._OverlapFilterInclusiveBoneNameExact = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_37, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OverlapFilterInclusiveBoneNameExact.CopyAssign(value);
			}
		}

		// Token: 0x1700555D RID: 21853
		// (get) Token: 0x06026EF4 RID: 159476 RVA: 0x00981D00 File Offset: 0x0097FF00
		// (set) Token: 0x06026EF5 RID: 159477 RVA: 0x00981D39 File Offset: 0x0097FF39
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
					result = (this._OverlapFilterInclusiveBoneNamePartial = new TArray<string>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_38, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OverlapFilterInclusiveBoneNamePartial.CopyAssign(value);
			}
		}

		// Token: 0x1700555E RID: 21854
		// (get) Token: 0x06026EF6 RID: 159478 RVA: 0x00981D48 File Offset: 0x0097FF48
		// (set) Token: 0x06026EF7 RID: 159479 RVA: 0x00981D81 File Offset: 0x0097FF81
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
					result = (this._ExcludeSpecificActorsFromOverlap = new TArray<AActor>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_39, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ExcludeSpecificActorsFromOverlap.CopyAssign(value);
			}
		}

		// Token: 0x1700555F RID: 21855
		// (get) Token: 0x06026EF8 RID: 159480 RVA: 0x00981D8F File Offset: 0x0097FF8F
		// (set) Token: 0x06026EF9 RID: 159481 RVA: 0x00981D9F File Offset: 0x0097FF9F
		public unsafe bool AutoExcludeLargeOverlappingObjects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005560 RID: 21856
		// (get) Token: 0x06026EFA RID: 159482 RVA: 0x00981DB0 File Offset: 0x0097FFB0
		// (set) Token: 0x06026EFB RID: 159483 RVA: 0x00981DE9 File Offset: 0x0097FFE9
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
					result = (this._OverlapFilterInclusiveCollisionType = new TMap<TEnumAsByte<ECollisionChannel>, TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_41, this));
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

		// Token: 0x17005561 RID: 21857
		// (get) Token: 0x06026EFC RID: 159484 RVA: 0x00981DF7 File Offset: 0x0097FFF7
		// (set) Token: 0x06026EFD RID: 159485 RVA: 0x00981E0B File Offset: 0x0098000B
		[Nullable(0)]
		public unsafe TEnumAsByte<InactiveBehaviour_Enum> TraceMeshInactiveBehaviour
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_42);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17005562 RID: 21858
		// (get) Token: 0x06026EFE RID: 159486 RVA: 0x00981E20 File Offset: 0x00980020
		// (set) Token: 0x06026EFF RID: 159487 RVA: 0x00981E30 File Offset: 0x00980030
		public unsafe bool ActivationEventsDebugPrint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005563 RID: 21859
		// (get) Token: 0x06026F00 RID: 159488 RVA: 0x00981E41 File Offset: 0x00980041
		// (set) Token: 0x06026F01 RID: 159489 RVA: 0x00981E51 File Offset: 0x00980051
		public unsafe bool SimContainerCapacityWarning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005564 RID: 21860
		// (get) Token: 0x06026F02 RID: 159490 RVA: 0x00981E62 File Offset: 0x00980062
		// (set) Token: 0x06026F03 RID: 159491 RVA: 0x00981E72 File Offset: 0x00980072
		public unsafe bool SaveDebugTextToLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005565 RID: 21861
		// (get) Token: 0x06026F04 RID: 159492 RVA: 0x00981E83 File Offset: 0x00980083
		// (set) Token: 0x06026F05 RID: 159493 RVA: 0x00981E93 File Offset: 0x00980093
		public unsafe float DebugTextLifeTimeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17005566 RID: 21862
		// (get) Token: 0x06026F06 RID: 159494 RVA: 0x00981EA4 File Offset: 0x009800A4
		// (set) Token: 0x06026F07 RID: 159495 RVA: 0x00981EB8 File Offset: 0x009800B8
		public unsafe UPrimitiveComponent OverlappingSkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x17005567 RID: 21863
		// (get) Token: 0x06026F08 RID: 159496 RVA: 0x00981ECD File Offset: 0x009800CD
		// (set) Token: 0x06026F09 RID: 159497 RVA: 0x00981EDD File Offset: 0x009800DD
		public unsafe float BrushStrengthTemp2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17005568 RID: 21864
		// (get) Token: 0x06026F0A RID: 159498 RVA: 0x00981EEE File Offset: 0x009800EE
		// (set) Token: 0x06026F0B RID: 159499 RVA: 0x00981EFE File Offset: 0x009800FE
		public unsafe float InputFeedbackTemp1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17005569 RID: 21865
		// (get) Token: 0x06026F0C RID: 159500 RVA: 0x00981F0F File Offset: 0x0098010F
		// (set) Token: 0x06026F0D RID: 159501 RVA: 0x00981F1F File Offset: 0x0098011F
		public unsafe bool DisableAndNotTickBlock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_50) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_50) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700556A RID: 21866
		// (get) Token: 0x06026F0E RID: 159502 RVA: 0x00981F30 File Offset: 0x00980130
		// (set) Token: 0x06026F0F RID: 159503 RVA: 0x00981F69 File Offset: 0x00980169
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
					result = (this._OverlappingComponents = new TArray<UPrimitiveComponent>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_51, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OverlappingComponents.CopyAssign(value);
			}
		}

		// Token: 0x1700556B RID: 21867
		// (get) Token: 0x06026F10 RID: 159504 RVA: 0x00981F78 File Offset: 0x00980178
		// (set) Token: 0x06026F11 RID: 159505 RVA: 0x00981FB1 File Offset: 0x009801B1
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
					result = (this._OverlappingActors = new TArray<AActor>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_52, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OverlappingActors.CopyAssign(value);
			}
		}

		// Token: 0x1700556C RID: 21868
		// (get) Token: 0x06026F12 RID: 159506 RVA: 0x00981FC0 File Offset: 0x009801C0
		// (set) Token: 0x06026F13 RID: 159507 RVA: 0x00981FF9 File Offset: 0x009801F9
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
					result = (this._SkeletalMesh_TempArray_Pairs = new TMap<int, UPrimitiveComponent>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_53, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SkeletalMesh_TempArray_Pairs.CopyAssign(value);
			}
		}

		// Token: 0x1700556D RID: 21869
		// (get) Token: 0x06026F14 RID: 159508 RVA: 0x00982008 File Offset: 0x00980208
		// (set) Token: 0x06026F15 RID: 159509 RVA: 0x00982041 File Offset: 0x00980241
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
					result = (this._OverlappingActorsInitial = new TArray<AActor>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_54, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OverlappingActorsInitial.CopyAssign(value);
			}
		}

		// Token: 0x1700556E RID: 21870
		// (get) Token: 0x06026F16 RID: 159510 RVA: 0x00982050 File Offset: 0x00980250
		// (set) Token: 0x06026F17 RID: 159511 RVA: 0x00982089 File Offset: 0x00980289
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
					result = (this._OwnerRePlayEvent = new OwnerRePlayEvent(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_55, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_55, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700556F RID: 21871
		// (get) Token: 0x06026F18 RID: 159512 RVA: 0x009820AA File Offset: 0x009802AA
		// (set) Token: 0x06026F19 RID: 159513 RVA: 0x009820BA File Offset: 0x009802BA
		public unsafe bool OverrideComponentVariables
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_56) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_56) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005570 RID: 21872
		// (get) Token: 0x06026F1A RID: 159514 RVA: 0x009820CB File Offset: 0x009802CB
		// (set) Token: 0x06026F1B RID: 159515 RVA: 0x009820DB File Offset: 0x009802DB
		public unsafe bool AutoConnectToMemoryPool_IF_Found
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_57) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_57) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005571 RID: 21873
		// (get) Token: 0x06026F1C RID: 159516 RVA: 0x009820EC File Offset: 0x009802EC
		// (set) Token: 0x06026F1D RID: 159517 RVA: 0x009820FC File Offset: 0x009802FC
		public unsafe int OutputFilterMaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_58);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x17005572 RID: 21874
		// (get) Token: 0x06026F1E RID: 159518 RVA: 0x0098210D File Offset: 0x0098030D
		// (set) Token: 0x06026F1F RID: 159519 RVA: 0x0098211D File Offset: 0x0098031D
		public unsafe bool ShowLODdebugMessagesOnScreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_59) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_59) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005573 RID: 21875
		// (get) Token: 0x06026F20 RID: 159520 RVA: 0x0098212E File Offset: 0x0098032E
		// (set) Token: 0x06026F21 RID: 159521 RVA: 0x0098213E File Offset: 0x0098033E
		public unsafe float GlobalBrushScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_60);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_60) = value;
			}
		}

		// Token: 0x17005574 RID: 21876
		// (get) Token: 0x06026F22 RID: 159522 RVA: 0x0098214F File Offset: 0x0098034F
		// (set) Token: 0x06026F23 RID: 159523 RVA: 0x0098215F File Offset: 0x0098035F
		public unsafe bool LOD1_ReduceIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_61) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_61) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005575 RID: 21877
		// (get) Token: 0x06026F24 RID: 159524 RVA: 0x00982170 File Offset: 0x00980370
		// (set) Token: 0x06026F25 RID: 159525 RVA: 0x00982180 File Offset: 0x00980380
		public unsafe bool LOD2_ReduceSamplingFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_62) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_62) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005576 RID: 21878
		// (get) Token: 0x06026F26 RID: 159526 RVA: 0x00982191 File Offset: 0x00980391
		// (set) Token: 0x06026F27 RID: 159527 RVA: 0x009821A1 File Offset: 0x009803A1
		public unsafe bool LOD3_ReduceCollisionAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_63) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_63) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005577 RID: 21879
		// (get) Token: 0x06026F28 RID: 159528 RVA: 0x009821B2 File Offset: 0x009803B2
		// (set) Token: 0x06026F29 RID: 159529 RVA: 0x009821C2 File Offset: 0x009803C2
		public unsafe int MinSamplingFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_64) = value;
			}
		}

		// Token: 0x17005578 RID: 21880
		// (get) Token: 0x06026F2A RID: 159530 RVA: 0x009821D3 File Offset: 0x009803D3
		// (set) Token: 0x06026F2B RID: 159531 RVA: 0x009821E3 File Offset: 0x009803E3
		public unsafe float LOD_FarBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_65);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_65) = value;
			}
		}

		// Token: 0x17005579 RID: 21881
		// (get) Token: 0x06026F2C RID: 159532 RVA: 0x009821F4 File Offset: 0x009803F4
		// (set) Token: 0x06026F2D RID: 159533 RVA: 0x00982204 File Offset: 0x00980404
		public unsafe float LOD_NearBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_66);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_66) = value;
			}
		}

		// Token: 0x1700557A RID: 21882
		// (get) Token: 0x06026F2E RID: 159534 RVA: 0x00982215 File Offset: 0x00980415
		// (set) Token: 0x06026F2F RID: 159535 RVA: 0x00982225 File Offset: 0x00980425
		public unsafe int DownscaleCollisionPainterResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_67);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_67) = value;
			}
		}

		// Token: 0x1700557B RID: 21883
		// (get) Token: 0x06026F30 RID: 159536 RVA: 0x00982236 File Offset: 0x00980436
		// (set) Token: 0x06026F31 RID: 159537 RVA: 0x00982246 File Offset: 0x00980446
		public unsafe int DownscalePressureResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_68);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_68) = value;
			}
		}

		// Token: 0x1700557C RID: 21884
		// (get) Token: 0x06026F32 RID: 159538 RVA: 0x00982257 File Offset: 0x00980457
		// (set) Token: 0x06026F33 RID: 159539 RVA: 0x00982267 File Offset: 0x00980467
		public unsafe bool SingleTargetMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_69) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_69) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700557D RID: 21885
		// (get) Token: 0x06026F34 RID: 159540 RVA: 0x00982278 File Offset: 0x00980478
		// (set) Token: 0x06026F35 RID: 159541 RVA: 0x00982288 File Offset: 0x00980488
		public unsafe bool InitialActorsProcessed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_70) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_70) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700557E RID: 21886
		// (get) Token: 0x06026F36 RID: 159542 RVA: 0x00982299 File Offset: 0x00980499
		// (set) Token: 0x06026F37 RID: 159543 RVA: 0x009822A9 File Offset: 0x009804A9
		public unsafe bool SKMeshTagged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_71) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_71) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700557F RID: 21887
		// (get) Token: 0x06026F38 RID: 159544 RVA: 0x009822BA File Offset: 0x009804BA
		// (set) Token: 0x06026F39 RID: 159545 RVA: 0x009822CA File Offset: 0x009804CA
		public unsafe bool bOnlySelfTraceMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_72) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_72) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005580 RID: 21888
		// (get) Token: 0x06026F3A RID: 159546 RVA: 0x009822DB File Offset: 0x009804DB
		// (set) Token: 0x06026F3B RID: 159547 RVA: 0x009822EB File Offset: 0x009804EB
		public unsafe bool bOnlyFirstSkeletal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_73) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_73) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005581 RID: 21889
		// (get) Token: 0x06026F3C RID: 159548 RVA: 0x009822FC File Offset: 0x009804FC
		// (set) Token: 0x06026F3D RID: 159549 RVA: 0x00982335 File Offset: 0x00980535
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
					result = (this._tempArray = new TArray<USkeletalMeshComponent>(base.NativePtr + (IntPtr)NinjaLive_C.__PropertyOffset_74, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.tempArray.CopyAssign(value);
			}
		}

		// Token: 0x06026F3E RID: 159550 RVA: 0x00982343 File Offset: 0x00980543
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ResetTempArrays()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__ResetTempArrays_NativeFunctionPtr, null);
		}

		// Token: 0x06026F3F RID: 159551 RVA: 0x00982357 File Offset: 0x00980557
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06026F40 RID: 159552 RVA: 0x0098236B File Offset: 0x0098056B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026F41 RID: 159553 RVA: 0x00982380 File Offset: 0x00980580
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpTchEvt_Released(ETouchIndex FingerIndex, FVector Location)
		{
			NinjaLive_C.__InpTchEvt_Released_FunctionParams* ptr = stackalloc NinjaLive_C.__InpTchEvt_Released_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(NinjaLive_C.__InpTchEvt_Released_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__InpTchEvt_Released_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__InpTchEvt_Released_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026F42 RID: 159554 RVA: 0x009823D4 File Offset: 0x009805D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpTchEvt_Pressed(ETouchIndex FingerIndex, FVector Location)
		{
			NinjaLive_C.__InpTchEvt_Pressed_FunctionParams* ptr = stackalloc NinjaLive_C.__InpTchEvt_Pressed_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(NinjaLive_C.__InpTchEvt_Pressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__InpTchEvt_Pressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__InpTchEvt_Pressed_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026F43 RID: 159555 RVA: 0x00982428 File Offset: 0x00980628
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06026F44 RID: 159556 RVA: 0x0098249C File Offset: 0x0098069C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06026F45 RID: 159557 RVA: 0x00982510 File Offset: 0x00980710
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LiveActivation(FName ParamName, float FadeTimeOfBrush, float FadeTimeOfCanvas)
		{
			NinjaLive_C.__LiveActivation_FunctionParams* ptr = stackalloc NinjaLive_C.__LiveActivation_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(NinjaLive_C.__LiveActivation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__LiveActivation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ParamName = ParamName;
			ptr->FadeTimeOfBrush = FadeTimeOfBrush;
			ptr->FadeTimeOfCanvas = FadeTimeOfCanvas;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__LiveActivation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026F46 RID: 159558 RVA: 0x00982564 File Offset: 0x00980764
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LiveFluidParams(float BrushSize)
		{
			NinjaLive_C.__LiveFluidParams_FunctionParams* ptr = stackalloc NinjaLive_C.__LiveFluidParams_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLive_C.__LiveFluidParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__LiveFluidParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BrushSize = BrushSize;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__LiveFluidParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026F47 RID: 159559 RVA: 0x009825AC File Offset: 0x009807AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			NinjaLive_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaLive_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLive_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026F48 RID: 159560 RVA: 0x009825F4 File Offset: 0x009807F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			NinjaLive_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaLive_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLive_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026F49 RID: 159561 RVA: 0x0098263B File Offset: 0x0098083B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026F4A RID: 159562 RVA: 0x0098264F File Offset: 0x0098084F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026F4B RID: 159563 RVA: 0x00982664 File Offset: 0x00980864
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RePlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__RePlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026F4C RID: 159564 RVA: 0x00982678 File Offset: 0x00980878
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeCookForPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__BeforeCookForPC_NativeFunctionPtr, null);
		}

		// Token: 0x06026F4D RID: 159565 RVA: 0x0098268C File Offset: 0x0098088C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeCookForPC_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__BeforeCookForPC_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026F4E RID: 159566 RVA: 0x009826A1 File Offset: 0x009808A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeCookForMobile()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__BeforeCookForMobile_NativeFunctionPtr, null);
		}

		// Token: 0x06026F4F RID: 159567 RVA: 0x009826B5 File Offset: 0x009808B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeCookForMobile_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__BeforeCookForMobile_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026F50 RID: 159568 RVA: 0x009826CC File Offset: 0x009808CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06026F51 RID: 159569 RVA: 0x00982788 File Offset: 0x00980988
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06026F52 RID: 159570 RVA: 0x00982814 File Offset: 0x00980A14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorEndOverlap(AActor OtherActor)
		{
			NinjaLive_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc NinjaLive_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLive_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026F53 RID: 159571 RVA: 0x0098286C File Offset: 0x00980A6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorEndOverlap_Implementation(AActor OtherActor)
		{
			NinjaLive_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc NinjaLive_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLive_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026F54 RID: 159572 RVA: 0x009828C4 File Offset: 0x00980AC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			NinjaLive_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc NinjaLive_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLive_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026F55 RID: 159573 RVA: 0x0098291C File Offset: 0x00980B1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
		{
			NinjaLive_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc NinjaLive_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(NinjaLive_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026F56 RID: 159574 RVA: 0x00982972 File Offset: 0x00980B72
		protected NinjaLive_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401396C RID: 80236
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive.NinjaLive_C";

		// Token: 0x0401396D RID: 80237
		private static IntPtr _ClassPtr;

		// Token: 0x0401396E RID: 80238
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401396F RID: 80239
		public static IntPtr __OwnerRePlayEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013970 RID: 80240
		internal static int __PropertyOffset_1;

		// Token: 0x04013971 RID: 80241
		internal static int __PropertyOffset_2;

		// Token: 0x04013972 RID: 80242
		internal static int __PropertyOffset_3;

		// Token: 0x04013973 RID: 80243
		internal static int __PropertyOffset_4;

		// Token: 0x04013974 RID: 80244
		internal static int __PropertyOffset_5;

		// Token: 0x04013975 RID: 80245
		internal static int __PropertyOffset_6;

		// Token: 0x04013976 RID: 80246
		internal static int __PropertyOffset_7;

		// Token: 0x04013977 RID: 80247
		internal static int __PropertyOffset_8;

		// Token: 0x04013978 RID: 80248
		internal static int __PropertyOffset_9;

		// Token: 0x04013979 RID: 80249
		internal static int __PropertyOffset_10;

		// Token: 0x0401397A RID: 80250
		internal static int __PropertyOffset_11;

		// Token: 0x0401397B RID: 80251
		internal static int __PropertyOffset_12;

		// Token: 0x0401397C RID: 80252
		internal static int __PropertyOffset_13;

		// Token: 0x0401397D RID: 80253
		internal static int __PropertyOffset_14;

		// Token: 0x0401397E RID: 80254
		internal static int __PropertyOffset_15;

		// Token: 0x0401397F RID: 80255
		internal static int __PropertyOffset_16;

		// Token: 0x04013980 RID: 80256
		internal static int __PropertyOffset_17;

		// Token: 0x04013981 RID: 80257
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<NinjaLive_C> _NinjaLIVECollisionExclude;

		// Token: 0x04013982 RID: 80258
		internal static int __PropertyOffset_18;

		// Token: 0x04013983 RID: 80259
		internal static int __PropertyOffset_19;

		// Token: 0x04013984 RID: 80260
		internal static int __PropertyOffset_20;

		// Token: 0x04013985 RID: 80261
		internal static int __PropertyOffset_21;

		// Token: 0x04013986 RID: 80262
		internal static int __PropertyOffset_22;

		// Token: 0x04013987 RID: 80263
		internal static int __PropertyOffset_23;

		// Token: 0x04013988 RID: 80264
		internal static int __PropertyOffset_24;

		// Token: 0x04013989 RID: 80265
		internal static int __PropertyOffset_25;

		// Token: 0x0401398A RID: 80266
		internal static int __PropertyOffset_26;

		// Token: 0x0401398B RID: 80267
		internal static int __PropertyOffset_27;

		// Token: 0x0401398C RID: 80268
		internal static int __PropertyOffset_28;

		// Token: 0x0401398D RID: 80269
		internal static int __PropertyOffset_29;

		// Token: 0x0401398E RID: 80270
		internal static int __PropertyOffset_30;

		// Token: 0x0401398F RID: 80271
		internal static int __PropertyOffset_31;

		// Token: 0x04013990 RID: 80272
		private TArray<bool> _MultipleTouchLookup;

		// Token: 0x04013991 RID: 80273
		internal static int __PropertyOffset_32;

		// Token: 0x04013992 RID: 80274
		internal static int __PropertyOffset_33;

		// Token: 0x04013993 RID: 80275
		internal static int __PropertyOffset_34;

		// Token: 0x04013994 RID: 80276
		internal static int __PropertyOffset_35;

		// Token: 0x04013995 RID: 80277
		internal static int __PropertyOffset_36;

		// Token: 0x04013996 RID: 80278
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _OverlapFilterInclusiveObjType;

		// Token: 0x04013997 RID: 80279
		internal static int __PropertyOffset_37;

		// Token: 0x04013998 RID: 80280
		private TArray<FName> _OverlapFilterInclusiveBoneNameExact;

		// Token: 0x04013999 RID: 80281
		internal static int __PropertyOffset_38;

		// Token: 0x0401399A RID: 80282
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _OverlapFilterInclusiveBoneNamePartial;

		// Token: 0x0401399B RID: 80283
		internal static int __PropertyOffset_39;

		// Token: 0x0401399C RID: 80284
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ExcludeSpecificActorsFromOverlap;

		// Token: 0x0401399D RID: 80285
		internal static int __PropertyOffset_40;

		// Token: 0x0401399E RID: 80286
		internal static int __PropertyOffset_41;

		// Token: 0x0401399F RID: 80287
		[Nullable(new byte[]
		{
			2,
			0,
			0
		})]
		private TMap<TEnumAsByte<ECollisionChannel>, TEnumAsByte<EObjectTypeQuery>> _OverlapFilterInclusiveCollisionType;

		// Token: 0x040139A0 RID: 80288
		internal static int __PropertyOffset_42;

		// Token: 0x040139A1 RID: 80289
		internal static int __PropertyOffset_43;

		// Token: 0x040139A2 RID: 80290
		internal static int __PropertyOffset_44;

		// Token: 0x040139A3 RID: 80291
		internal static int __PropertyOffset_45;

		// Token: 0x040139A4 RID: 80292
		internal static int __PropertyOffset_46;

		// Token: 0x040139A5 RID: 80293
		internal static int __PropertyOffset_47;

		// Token: 0x040139A6 RID: 80294
		internal static int __PropertyOffset_48;

		// Token: 0x040139A7 RID: 80295
		internal static int __PropertyOffset_49;

		// Token: 0x040139A8 RID: 80296
		internal static int __PropertyOffset_50;

		// Token: 0x040139A9 RID: 80297
		internal static int __PropertyOffset_51;

		// Token: 0x040139AA RID: 80298
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPrimitiveComponent> _OverlappingComponents;

		// Token: 0x040139AB RID: 80299
		internal static int __PropertyOffset_52;

		// Token: 0x040139AC RID: 80300
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _OverlappingActors;

		// Token: 0x040139AD RID: 80301
		internal static int __PropertyOffset_53;

		// Token: 0x040139AE RID: 80302
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UPrimitiveComponent> _SkeletalMesh_TempArray_Pairs;

		// Token: 0x040139AF RID: 80303
		internal static int __PropertyOffset_54;

		// Token: 0x040139B0 RID: 80304
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _OverlappingActorsInitial;

		// Token: 0x040139B1 RID: 80305
		internal static int __PropertyOffset_55;

		// Token: 0x040139B2 RID: 80306
		private OwnerRePlayEvent _OwnerRePlayEvent;

		// Token: 0x040139B3 RID: 80307
		internal static int __PropertyOffset_56;

		// Token: 0x040139B4 RID: 80308
		internal static int __PropertyOffset_57;

		// Token: 0x040139B5 RID: 80309
		internal static int __PropertyOffset_58;

		// Token: 0x040139B6 RID: 80310
		internal static int __PropertyOffset_59;

		// Token: 0x040139B7 RID: 80311
		internal static int __PropertyOffset_60;

		// Token: 0x040139B8 RID: 80312
		internal static int __PropertyOffset_61;

		// Token: 0x040139B9 RID: 80313
		internal static int __PropertyOffset_62;

		// Token: 0x040139BA RID: 80314
		internal static int __PropertyOffset_63;

		// Token: 0x040139BB RID: 80315
		internal static int __PropertyOffset_64;

		// Token: 0x040139BC RID: 80316
		internal static int __PropertyOffset_65;

		// Token: 0x040139BD RID: 80317
		internal static int __PropertyOffset_66;

		// Token: 0x040139BE RID: 80318
		internal static int __PropertyOffset_67;

		// Token: 0x040139BF RID: 80319
		internal static int __PropertyOffset_68;

		// Token: 0x040139C0 RID: 80320
		internal static int __PropertyOffset_69;

		// Token: 0x040139C1 RID: 80321
		internal static int __PropertyOffset_70;

		// Token: 0x040139C2 RID: 80322
		internal static int __PropertyOffset_71;

		// Token: 0x040139C3 RID: 80323
		internal static int __PropertyOffset_72;

		// Token: 0x040139C4 RID: 80324
		internal static int __PropertyOffset_73;

		// Token: 0x040139C5 RID: 80325
		internal static int __PropertyOffset_74;

		// Token: 0x040139C6 RID: 80326
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMeshComponent> _tempArray;

		// Token: 0x040139C7 RID: 80327
		private static IntPtr __ResetTempArrays_NativeFunctionPtr;

		// Token: 0x040139C8 RID: 80328
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040139C9 RID: 80329
		private static IntPtr __InpTchEvt_Released_NativeFunctionPtr;

		// Token: 0x040139CA RID: 80330
		private static IntPtr __InpTchEvt_Pressed_NativeFunctionPtr;

		// Token: 0x040139CB RID: 80331
		private static IntPtr __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_1_NativeFunctionPtr;

		// Token: 0x040139CC RID: 80332
		private static IntPtr __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_0_NativeFunctionPtr;

		// Token: 0x040139CD RID: 80333
		private static IntPtr __LiveActivation_NativeFunctionPtr;

		// Token: 0x040139CE RID: 80334
		private static IntPtr __LiveFluidParams_NativeFunctionPtr;

		// Token: 0x040139CF RID: 80335
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040139D0 RID: 80336
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040139D1 RID: 80337
		private static IntPtr __RePlay_NativeFunctionPtr;

		// Token: 0x040139D2 RID: 80338
		private static IntPtr __BeforeCookForPC_NativeFunctionPtr;

		// Token: 0x040139D3 RID: 80339
		private static IntPtr __BeforeCookForMobile_NativeFunctionPtr;

		// Token: 0x040139D4 RID: 80340
		private static IntPtr __BeginOverlapComponent_NativeFunctionPtr;

		// Token: 0x040139D5 RID: 80341
		private static IntPtr __EndOverlapComponent_NativeFunctionPtr;

		// Token: 0x040139D6 RID: 80342
		private static IntPtr __ReceiveActorEndOverlap_NativeFunctionPtr;

		// Token: 0x040139D7 RID: 80343
		private static IntPtr __ReceiveActorBeginOverlap_NativeFunctionPtr;

		// Token: 0x0200A15C RID: 41308
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InpTchEvt_Released_FunctionParams
		{
			// Token: 0x04031D0C RID: 204044
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x04031D0D RID: 204045
			[FieldOffset(4)]
			public FVector Location;
		}

		// Token: 0x0200A15D RID: 41309
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InpTchEvt_Pressed_FunctionParams
		{
			// Token: 0x04031D0E RID: 204046
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x04031D0F RID: 204047
			[FieldOffset(4)]
			public FVector Location;
		}

		// Token: 0x0200A15E RID: 41310
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_1_FunctionParams
		{
			// Token: 0x04031D10 RID: 204048
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A15F RID: 41311
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_0_FunctionParams
		{
			// Token: 0x04031D11 RID: 204049
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A160 RID: 41312
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __LiveActivation_FunctionParams
		{
			// Token: 0x04031D12 RID: 204050
			[FieldOffset(0)]
			public FName ParamName;

			// Token: 0x04031D13 RID: 204051
			[FieldOffset(12)]
			public float FadeTimeOfBrush;

			// Token: 0x04031D14 RID: 204052
			[FieldOffset(16)]
			public float FadeTimeOfCanvas;
		}

		// Token: 0x0200A161 RID: 41313
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __LiveFluidParams_FunctionParams
		{
			// Token: 0x04031D15 RID: 204053
			[FieldOffset(0)]
			public float BrushSize;
		}

		// Token: 0x0200A162 RID: 41314
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031D16 RID: 204054
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A163 RID: 41315
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BeginOverlapComponent_FunctionParams
		{
			// Token: 0x04031D17 RID: 204055
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031D18 RID: 204056
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031D19 RID: 204057
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031D1A RID: 204058
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031D1B RID: 204059
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031D1C RID: 204060
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x0200A164 RID: 41316
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __EndOverlapComponent_FunctionParams
		{
			// Token: 0x04031D1D RID: 204061
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031D1E RID: 204062
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031D1F RID: 204063
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031D20 RID: 204064
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x0200A165 RID: 41317
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorEndOverlap_FunctionParams
		{
			// Token: 0x04031D21 RID: 204065
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x0200A166 RID: 41318
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x04031D22 RID: 204066
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}
	}
}
