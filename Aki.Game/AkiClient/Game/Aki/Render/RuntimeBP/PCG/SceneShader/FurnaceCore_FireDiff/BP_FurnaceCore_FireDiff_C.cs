using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader.FurnaceCore_FireDiff
{
	// Token: 0x02003C09 RID: 15369
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/FurnaceCore_FireDiff/BP_FurnaceCore_FireDiff.BP_FurnaceCore_FireDiff_C")]
	[UnrealStructLayout(1784, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1784)]
	public class BP_FurnaceCore_FireDiff_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060230D4 RID: 143572 RVA: 0x00919464 File Offset: 0x00917664
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FurnaceCore_FireDiff_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/FurnaceCore_FireDiff/BP_FurnaceCore_FireDiff.BP_FurnaceCore_FireDiff_C");
			}
			return BP_FurnaceCore_FireDiff_C._ClassPtr;
		}

		// Token: 0x060230D5 RID: 143573 RVA: 0x00919488 File Offset: 0x00917688
		public BP_FurnaceCore_FireDiff_C() : this(BuiltinUtils.AllocNativeUObject(BP_FurnaceCore_FireDiff_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060230D6 RID: 143574 RVA: 0x009194B0 File Offset: 0x009176B0
		[NullableContext(1)]
		public BP_FurnaceCore_FireDiff_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FurnaceCore_FireDiff_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F34 RID: 16180
		// (get) Token: 0x060230D7 RID: 143575 RVA: 0x009194E3 File Offset: 0x009176E3
		// (set) Token: 0x060230D8 RID: 143576 RVA: 0x009194F7 File Offset: 0x009176F7
		public unsafe UNiagaraComponent NS_LightningFire_ES3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003F35 RID: 16181
		// (get) Token: 0x060230D9 RID: 143577 RVA: 0x0091950C File Offset: 0x0091770C
		// (set) Token: 0x060230DA RID: 143578 RVA: 0x00919520 File Offset: 0x00917720
		public unsafe UStaticMeshComponent SM_LightningFire
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003F36 RID: 16182
		// (get) Token: 0x060230DB RID: 143579 RVA: 0x00919535 File Offset: 0x00917735
		// (set) Token: 0x060230DC RID: 143580 RVA: 0x00919549 File Offset: 0x00917749
		public unsafe USphereComponent DetectionCollision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003F37 RID: 16183
		// (get) Token: 0x060230DD RID: 143581 RVA: 0x0091955E File Offset: 0x0091775E
		// (set) Token: 0x060230DE RID: 143582 RVA: 0x00919572 File Offset: 0x00917772
		public unsafe UNiagaraComponent Niagara_Tree
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003F38 RID: 16184
		// (get) Token: 0x060230DF RID: 143583 RVA: 0x00919587 File Offset: 0x00917787
		// (set) Token: 0x060230E0 RID: 143584 RVA: 0x0091959B File Offset: 0x0091779B
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003F39 RID: 16185
		// (get) Token: 0x060230E1 RID: 143585 RVA: 0x009195B0 File Offset: 0x009177B0
		// (set) Token: 0x060230E2 RID: 143586 RVA: 0x009195C4 File Offset: 0x009177C4
		public unsafe UBoxComponent PostProcessBoundView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003F3A RID: 16186
		// (get) Token: 0x060230E3 RID: 143587 RVA: 0x009195D9 File Offset: 0x009177D9
		// (set) Token: 0x060230E4 RID: 143588 RVA: 0x009195ED File Offset: 0x009177ED
		public unsafe UTextRenderComponent FireBurnt
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003F3B RID: 16187
		// (get) Token: 0x060230E5 RID: 143589 RVA: 0x00919602 File Offset: 0x00917802
		// (set) Token: 0x060230E6 RID: 143590 RVA: 0x00919616 File Offset: 0x00917816
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003F3C RID: 16188
		// (get) Token: 0x060230E7 RID: 143591 RVA: 0x0091962B File Offset: 0x0091782B
		// (set) Token: 0x060230E8 RID: 143592 RVA: 0x0091963F File Offset: 0x0091783F
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003F3D RID: 16189
		// (get) Token: 0x060230E9 RID: 143593 RVA: 0x00919654 File Offset: 0x00917854
		// (set) Token: 0x060230EA RID: 143594 RVA: 0x00919664 File Offset: 0x00917864
		public unsafe float SpreadTimeLinear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003F3E RID: 16190
		// (get) Token: 0x060230EB RID: 143595 RVA: 0x00919675 File Offset: 0x00917875
		// (set) Token: 0x060230EC RID: 143596 RVA: 0x00919685 File Offset: 0x00917885
		public unsafe bool StartPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F3F RID: 16191
		// (get) Token: 0x060230ED RID: 143597 RVA: 0x00919696 File Offset: 0x00917896
		// (set) Token: 0x060230EE RID: 143598 RVA: 0x009196AA File Offset: 0x009178AA
		public unsafe FLinearColor FireColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003F40 RID: 16192
		// (get) Token: 0x060230EF RID: 143599 RVA: 0x009196BF File Offset: 0x009178BF
		// (set) Token: 0x060230F0 RID: 143600 RVA: 0x009196CF File Offset: 0x009178CF
		public unsafe float SpreadSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003F41 RID: 16193
		// (get) Token: 0x060230F1 RID: 143601 RVA: 0x009196E0 File Offset: 0x009178E0
		// (set) Token: 0x060230F2 RID: 143602 RVA: 0x009196F0 File Offset: 0x009178F0
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003F42 RID: 16194
		// (get) Token: 0x060230F3 RID: 143603 RVA: 0x00919701 File Offset: 0x00917901
		// (set) Token: 0x060230F4 RID: 143604 RVA: 0x00919711 File Offset: 0x00917911
		public unsafe float BoundSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003F43 RID: 16195
		// (get) Token: 0x060230F5 RID: 143605 RVA: 0x00919722 File Offset: 0x00917922
		// (set) Token: 0x060230F6 RID: 143606 RVA: 0x00919732 File Offset: 0x00917932
		public unsafe float Is_Play
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003F44 RID: 16196
		// (get) Token: 0x060230F7 RID: 143607 RVA: 0x00919743 File Offset: 0x00917943
		// (set) Token: 0x060230F8 RID: 143608 RVA: 0x00919758 File Offset: 0x00917958
		[Nullable(1)]
		public TSoftObjectPtr<AKuroGlobalGI> GlobalGI
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<AKuroGlobalGI>(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_17, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_17, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003F45 RID: 16197
		// (get) Token: 0x060230F9 RID: 143609 RVA: 0x0091977D File Offset: 0x0091797D
		// (set) Token: 0x060230FA RID: 143610 RVA: 0x00919792 File Offset: 0x00917992
		[Nullable(1)]
		public TSoftObjectPtr<AKuroGlobalGI> GlobalGI_Temp
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<AKuroGlobalGI>(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_18, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_18, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003F46 RID: 16198
		// (get) Token: 0x060230FB RID: 143611 RVA: 0x009197B7 File Offset: 0x009179B7
		// (set) Token: 0x060230FC RID: 143612 RVA: 0x009197C7 File Offset: 0x009179C7
		public unsafe float Probability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003F47 RID: 16199
		// (get) Token: 0x060230FD RID: 143613 RVA: 0x009197D8 File Offset: 0x009179D8
		// (set) Token: 0x060230FE RID: 143614 RVA: 0x009197E8 File Offset: 0x009179E8
		public unsafe float DeltaScond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003F48 RID: 16200
		// (get) Token: 0x060230FF RID: 143615 RVA: 0x009197F9 File Offset: 0x009179F9
		// (set) Token: 0x06023100 RID: 143616 RVA: 0x00919809 File Offset: 0x00917A09
		public unsafe float TriggerDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003F49 RID: 16201
		// (get) Token: 0x06023101 RID: 143617 RVA: 0x0091981A File Offset: 0x00917A1A
		// (set) Token: 0x06023102 RID: 143618 RVA: 0x0091982E File Offset: 0x00917A2E
		public unsafe FVectorDouble NiagaraPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003F4A RID: 16202
		// (get) Token: 0x06023103 RID: 143619 RVA: 0x00919843 File Offset: 0x00917A43
		// (set) Token: 0x06023104 RID: 143620 RVA: 0x00919853 File Offset: 0x00917A53
		public unsafe float TakeEffectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003F4B RID: 16203
		// (get) Token: 0x06023105 RID: 143621 RVA: 0x00919864 File Offset: 0x00917A64
		// (set) Token: 0x06023106 RID: 143622 RVA: 0x00919874 File Offset: 0x00917A74
		public unsafe bool bPlayerIsTriggerZone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F4C RID: 16204
		// (get) Token: 0x06023107 RID: 143623 RVA: 0x00919885 File Offset: 0x00917A85
		// (set) Token: 0x06023108 RID: 143624 RVA: 0x00919895 File Offset: 0x00917A95
		public unsafe bool DeBug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F4D RID: 16205
		// (get) Token: 0x06023109 RID: 143625 RVA: 0x009198A6 File Offset: 0x00917AA6
		// (set) Token: 0x0602310A RID: 143626 RVA: 0x009198B6 File Offset: 0x00917AB6
		public unsafe float TreeFireSpriteSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003F4E RID: 16206
		// (get) Token: 0x0602310B RID: 143627 RVA: 0x009198C7 File Offset: 0x00917AC7
		// (set) Token: 0x0602310C RID: 143628 RVA: 0x009198DB File Offset: 0x00917ADB
		public unsafe UKuroWeatherDataAsset WeatherDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17003F4F RID: 16207
		// (get) Token: 0x0602310D RID: 143629 RVA: 0x009198F0 File Offset: 0x00917AF0
		// (set) Token: 0x0602310E RID: 143630 RVA: 0x00919900 File Offset: 0x00917B00
		public unsafe float PostProcessRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17003F50 RID: 16208
		// (get) Token: 0x0602310F RID: 143631 RVA: 0x00919911 File Offset: 0x00917B11
		// (set) Token: 0x06023110 RID: 143632 RVA: 0x00919921 File Offset: 0x00917B21
		public unsafe float Post_BlendRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17003F51 RID: 16209
		// (get) Token: 0x06023111 RID: 143633 RVA: 0x00919932 File Offset: 0x00917B32
		// (set) Token: 0x06023112 RID: 143634 RVA: 0x00919942 File Offset: 0x00917B42
		public unsafe float Post_Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17003F52 RID: 16210
		// (get) Token: 0x06023113 RID: 143635 RVA: 0x00919953 File Offset: 0x00917B53
		// (set) Token: 0x06023114 RID: 143636 RVA: 0x00919967 File Offset: 0x00917B67
		public unsafe AStaticMeshActor FoliageStaticMeshActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x17003F53 RID: 16211
		// (get) Token: 0x06023115 RID: 143637 RVA: 0x0091997C File Offset: 0x00917B7C
		// (set) Token: 0x06023116 RID: 143638 RVA: 0x0091998C File Offset: 0x00917B8C
		public unsafe bool View_Probability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F54 RID: 16212
		// (get) Token: 0x06023117 RID: 143639 RVA: 0x0091999D File Offset: 0x00917B9D
		// (set) Token: 0x06023118 RID: 143640 RVA: 0x009199AD File Offset: 0x00917BAD
		public unsafe bool bIsOnCooldown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F55 RID: 16213
		// (get) Token: 0x06023119 RID: 143641 RVA: 0x009199BE File Offset: 0x00917BBE
		// (set) Token: 0x0602311A RID: 143642 RVA: 0x009199CE File Offset: 0x00917BCE
		public unsafe float CooldoownTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17003F56 RID: 16214
		// (get) Token: 0x0602311B RID: 143643 RVA: 0x009199DF File Offset: 0x00917BDF
		// (set) Token: 0x0602311C RID: 143644 RVA: 0x009199EF File Offset: 0x00917BEF
		public unsafe bool TriggerCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F57 RID: 16215
		// (get) Token: 0x0602311D RID: 143645 RVA: 0x00919A00 File Offset: 0x00917C00
		// (set) Token: 0x0602311E RID: 143646 RVA: 0x00919A10 File Offset: 0x00917C10
		public unsafe bool Is_ES3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FurnaceCore_FireDiff_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F58 RID: 16216
		// (get) Token: 0x0602311F RID: 143647 RVA: 0x00919A21 File Offset: 0x00917C21
		// (set) Token: 0x06023120 RID: 143648 RVA: 0x00919A35 File Offset: 0x00917C35
		public unsafe UAkAudioEvent AudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FurnaceCore_FireDiff_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x06023121 RID: 143649 RVA: 0x00919A4A File Offset: 0x00917C4A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_ES3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__Set_ES3_NativeFunctionPtr, null);
		}

		// Token: 0x06023122 RID: 143650 RVA: 0x00919A5E File Offset: 0x00917C5E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetPostProcessVolume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__SetPostProcessVolume_NativeFunctionPtr, null);
		}

		// Token: 0x06023123 RID: 143651 RVA: 0x00919A74 File Offset: 0x00917C74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ContorlParameter(bool NewParam)
		{
			BP_FurnaceCore_FireDiff_C.__ContorlParameter_FunctionParams* ptr = stackalloc BP_FurnaceCore_FireDiff_C.__ContorlParameter_FunctionParams[(UIntPtr)263] + 15L / (long)sizeof(BP_FurnaceCore_FireDiff_C.__ContorlParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FurnaceCore_FireDiff_C.__ContorlParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__ContorlParameter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023124 RID: 143652 RVA: 0x00919ABD File Offset: 0x00917CBD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_InitialParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__Set_InitialParameter_NativeFunctionPtr, null);
		}

		// Token: 0x06023125 RID: 143653 RVA: 0x00919AD1 File Offset: 0x00917CD1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Tick_Parameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__Set_Tick_Parameter_NativeFunctionPtr, null);
		}

		// Token: 0x06023126 RID: 143654 RVA: 0x00919AE5 File Offset: 0x00917CE5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DebugPlayEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__DebugPlayEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06023127 RID: 143655 RVA: 0x00919AF9 File Offset: 0x00917CF9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023128 RID: 143656 RVA: 0x00919B0D File Offset: 0x00917D0D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023129 RID: 143657 RVA: 0x00919B24 File Offset: 0x00917D24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FurnaceCore_FireDiff_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FurnaceCore_FireDiff_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FurnaceCore_FireDiff_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FurnaceCore_FireDiff_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602312A RID: 143658 RVA: 0x00919B6C File Offset: 0x00917D6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FurnaceCore_FireDiff_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FurnaceCore_FireDiff_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FurnaceCore_FireDiff_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FurnaceCore_FireDiff_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602312B RID: 143659 RVA: 0x00919BB3 File Offset: 0x00917DB3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602312C RID: 143660 RVA: 0x00919BC7 File Offset: 0x00917DC7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602312D RID: 143661 RVA: 0x00919BDC File Offset: 0x00917DDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ResetCooldownEvent()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__ResetCooldownEvent_NativeFunctionPtr, null);
		}

		// Token: 0x0602312E RID: 143662 RVA: 0x00919BF0 File Offset: 0x00917DF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_FurnaceCore_FireDiff_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_FurnaceCore_FireDiff_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_FurnaceCore_FireDiff_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FurnaceCore_FireDiff_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602312F RID: 143663 RVA: 0x00919CAC File Offset: 0x00917EAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_FurnaceCore_FireDiff_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_FurnaceCore_FireDiff_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_FurnaceCore_FireDiff_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FurnaceCore_FireDiff_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023130 RID: 143664 RVA: 0x00919D38 File Offset: 0x00917F38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_FurnaceCore_FireDiff_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FurnaceCore_FireDiff_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FurnaceCore_FireDiff_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FurnaceCore_FireDiff_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023131 RID: 143665 RVA: 0x00919D80 File Offset: 0x00917F80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_FurnaceCore_FireDiff_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FurnaceCore_FireDiff_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FurnaceCore_FireDiff_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FurnaceCore_FireDiff_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FurnaceCore_FireDiff_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023132 RID: 143666 RVA: 0x00919DC7 File Offset: 0x00917FC7
		protected BP_FurnaceCore_FireDiff_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011433 RID: 70707
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/FurnaceCore_FireDiff/BP_FurnaceCore_FireDiff.BP_FurnaceCore_FireDiff_C";

		// Token: 0x04011434 RID: 70708
		private static IntPtr _ClassPtr;

		// Token: 0x04011435 RID: 70709
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011436 RID: 70710
		internal static int __PropertyOffset_1;

		// Token: 0x04011437 RID: 70711
		internal static int __PropertyOffset_2;

		// Token: 0x04011438 RID: 70712
		internal static int __PropertyOffset_3;

		// Token: 0x04011439 RID: 70713
		internal static int __PropertyOffset_4;

		// Token: 0x0401143A RID: 70714
		internal static int __PropertyOffset_5;

		// Token: 0x0401143B RID: 70715
		internal static int __PropertyOffset_6;

		// Token: 0x0401143C RID: 70716
		internal static int __PropertyOffset_7;

		// Token: 0x0401143D RID: 70717
		internal static int __PropertyOffset_8;

		// Token: 0x0401143E RID: 70718
		internal static int __PropertyOffset_9;

		// Token: 0x0401143F RID: 70719
		internal static int __PropertyOffset_10;

		// Token: 0x04011440 RID: 70720
		internal static int __PropertyOffset_11;

		// Token: 0x04011441 RID: 70721
		internal static int __PropertyOffset_12;

		// Token: 0x04011442 RID: 70722
		internal static int __PropertyOffset_13;

		// Token: 0x04011443 RID: 70723
		internal static int __PropertyOffset_14;

		// Token: 0x04011444 RID: 70724
		internal static int __PropertyOffset_15;

		// Token: 0x04011445 RID: 70725
		internal static int __PropertyOffset_16;

		// Token: 0x04011446 RID: 70726
		internal static int __PropertyOffset_17;

		// Token: 0x04011447 RID: 70727
		internal static int __PropertyOffset_18;

		// Token: 0x04011448 RID: 70728
		internal static int __PropertyOffset_19;

		// Token: 0x04011449 RID: 70729
		internal static int __PropertyOffset_20;

		// Token: 0x0401144A RID: 70730
		internal static int __PropertyOffset_21;

		// Token: 0x0401144B RID: 70731
		internal static int __PropertyOffset_22;

		// Token: 0x0401144C RID: 70732
		internal static int __PropertyOffset_23;

		// Token: 0x0401144D RID: 70733
		internal static int __PropertyOffset_24;

		// Token: 0x0401144E RID: 70734
		internal static int __PropertyOffset_25;

		// Token: 0x0401144F RID: 70735
		internal static int __PropertyOffset_26;

		// Token: 0x04011450 RID: 70736
		internal static int __PropertyOffset_27;

		// Token: 0x04011451 RID: 70737
		internal static int __PropertyOffset_28;

		// Token: 0x04011452 RID: 70738
		internal static int __PropertyOffset_29;

		// Token: 0x04011453 RID: 70739
		internal static int __PropertyOffset_30;

		// Token: 0x04011454 RID: 70740
		internal static int __PropertyOffset_31;

		// Token: 0x04011455 RID: 70741
		internal static int __PropertyOffset_32;

		// Token: 0x04011456 RID: 70742
		internal static int __PropertyOffset_33;

		// Token: 0x04011457 RID: 70743
		internal static int __PropertyOffset_34;

		// Token: 0x04011458 RID: 70744
		internal static int __PropertyOffset_35;

		// Token: 0x04011459 RID: 70745
		internal static int __PropertyOffset_36;

		// Token: 0x0401145A RID: 70746
		internal static int __PropertyOffset_37;

		// Token: 0x0401145B RID: 70747
		private static IntPtr __Set_ES3_NativeFunctionPtr;

		// Token: 0x0401145C RID: 70748
		private static IntPtr __SetPostProcessVolume_NativeFunctionPtr;

		// Token: 0x0401145D RID: 70749
		private static IntPtr __ContorlParameter_NativeFunctionPtr;

		// Token: 0x0401145E RID: 70750
		private static IntPtr __Set_InitialParameter_NativeFunctionPtr;

		// Token: 0x0401145F RID: 70751
		private static IntPtr __Set_Tick_Parameter_NativeFunctionPtr;

		// Token: 0x04011460 RID: 70752
		private static IntPtr __DebugPlayEffect_NativeFunctionPtr;

		// Token: 0x04011461 RID: 70753
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011462 RID: 70754
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011463 RID: 70755
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011464 RID: 70756
		private static IntPtr __ResetCooldownEvent_NativeFunctionPtr;

		// Token: 0x04011465 RID: 70757
		private static IntPtr __BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011466 RID: 70758
		private static IntPtr __BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011467 RID: 70759
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009E09 RID: 40457
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 248)]
		protected ref struct __ContorlParameter_FunctionParams
		{
			// Token: 0x04031630 RID: 202288
			[FieldOffset(0)]
			public bool NewParam;
		}

		// Token: 0x02009E0A RID: 40458
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031631 RID: 202289
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E0B RID: 40459
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031632 RID: 202290
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031633 RID: 202291
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031634 RID: 202292
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031635 RID: 202293
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031636 RID: 202294
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031637 RID: 202295
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009E0C RID: 40460
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031638 RID: 202296
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031639 RID: 202297
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403163A RID: 202298
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403163B RID: 202299
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009E0D RID: 40461
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403163C RID: 202300
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
