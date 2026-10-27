using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D09 RID: 15625
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_CameraEffect.BP_CameraEffect_C")]
	[UnrealStructLayout(1696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1696)]
	public class BP_CameraEffect_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060255E8 RID: 153064 RVA: 0x00958248 File Offset: 0x00956448
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CameraEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_CameraEffect.BP_CameraEffect_C");
			}
			return BP_CameraEffect_C._ClassPtr;
		}

		// Token: 0x060255E9 RID: 153065 RVA: 0x0095826C File Offset: 0x0095646C
		public BP_CameraEffect_C() : this(BuiltinUtils.AllocNativeUObject(BP_CameraEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060255EA RID: 153066 RVA: 0x00958294 File Offset: 0x00956494
		[NullableContext(1)]
		public BP_CameraEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CameraEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C42 RID: 19522
		// (get) Token: 0x060255EB RID: 153067 RVA: 0x009582C7 File Offset: 0x009564C7
		// (set) Token: 0x060255EC RID: 153068 RVA: 0x009582DB File Offset: 0x009564DB
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004C43 RID: 19523
		// (get) Token: 0x060255ED RID: 153069 RVA: 0x009582F0 File Offset: 0x009564F0
		// (set) Token: 0x060255EE RID: 153070 RVA: 0x00958304 File Offset: 0x00956504
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004C44 RID: 19524
		// (get) Token: 0x060255EF RID: 153071 RVA: 0x00958319 File Offset: 0x00956519
		// (set) Token: 0x060255F0 RID: 153072 RVA: 0x0095832D File Offset: 0x0095652D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004C45 RID: 19525
		// (get) Token: 0x060255F1 RID: 153073 RVA: 0x00958342 File Offset: 0x00956542
		// (set) Token: 0x060255F2 RID: 153074 RVA: 0x00958352 File Offset: 0x00956552
		public unsafe float 全局风方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004C46 RID: 19526
		// (get) Token: 0x060255F3 RID: 153075 RVA: 0x00958363 File Offset: 0x00956563
		// (set) Token: 0x060255F4 RID: 153076 RVA: 0x00958373 File Offset: 0x00956573
		public unsafe float 角色光照方向_水平_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004C47 RID: 19527
		// (get) Token: 0x060255F5 RID: 153077 RVA: 0x00958384 File Offset: 0x00956584
		// (set) Token: 0x060255F6 RID: 153078 RVA: 0x00958398 File Offset: 0x00956598
		public unsafe UNiagaraComponent CurrentNS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004C48 RID: 19528
		// (get) Token: 0x060255F7 RID: 153079 RVA: 0x009583AD File Offset: 0x009565AD
		// (set) Token: 0x060255F8 RID: 153080 RVA: 0x009583BD File Offset: 0x009565BD
		public unsafe float 集群特效密度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004C49 RID: 19529
		// (get) Token: 0x060255F9 RID: 153081 RVA: 0x009583CE File Offset: 0x009565CE
		// (set) Token: 0x060255FA RID: 153082 RVA: 0x009583DE File Offset: 0x009565DE
		public unsafe float 全局风强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004C4A RID: 19530
		// (get) Token: 0x060255FB RID: 153083 RVA: 0x009583F0 File Offset: 0x009565F0
		// (set) Token: 0x060255FC RID: 153084 RVA: 0x00958429 File Offset: 0x00956629
		[Nullable(1)]
		public TArray<UNiagaraSystem> Niagara_System_Objects
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraSystem> result;
				if ((result = this._Niagara_System_Objects) == null)
				{
					result = (this._Niagara_System_Objects = new TArray<UNiagaraSystem>(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Niagara_System_Objects.CopyAssign(value);
			}
		}

		// Token: 0x17004C4B RID: 19531
		// (get) Token: 0x060255FD RID: 153085 RVA: 0x00958437 File Offset: 0x00956637
		// (set) Token: 0x060255FE RID: 153086 RVA: 0x00958447 File Offset: 0x00956647
		public unsafe float 角色光照亮部Hue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004C4C RID: 19532
		// (get) Token: 0x060255FF RID: 153087 RVA: 0x00958458 File Offset: 0x00956658
		// (set) Token: 0x06025600 RID: 153088 RVA: 0x00958468 File Offset: 0x00956668
		public unsafe float 角色光照亮部Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004C4D RID: 19533
		// (get) Token: 0x06025601 RID: 153089 RVA: 0x00958479 File Offset: 0x00956679
		// (set) Token: 0x06025602 RID: 153090 RVA: 0x00958489 File Offset: 0x00956689
		public unsafe float 角色光照亮部Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004C4E RID: 19534
		// (get) Token: 0x06025603 RID: 153091 RVA: 0x0095849A File Offset: 0x0095669A
		// (set) Token: 0x06025604 RID: 153092 RVA: 0x009584AA File Offset: 0x009566AA
		public unsafe float 角色光照暗部Hue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004C4F RID: 19535
		// (get) Token: 0x06025605 RID: 153093 RVA: 0x009584BB File Offset: 0x009566BB
		// (set) Token: 0x06025606 RID: 153094 RVA: 0x009584CB File Offset: 0x009566CB
		public unsafe float 角色光照暗部Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004C50 RID: 19536
		// (get) Token: 0x06025607 RID: 153095 RVA: 0x009584DC File Offset: 0x009566DC
		// (set) Token: 0x06025608 RID: 153096 RVA: 0x009584EC File Offset: 0x009566EC
		public unsafe float 角色光照暗部Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004C51 RID: 19537
		// (get) Token: 0x06025609 RID: 153097 RVA: 0x009584FD File Offset: 0x009566FD
		// (set) Token: 0x0602560A RID: 153098 RVA: 0x0095850D File Offset: 0x0095670D
		public unsafe float 角色光照边缘光Hue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004C52 RID: 19538
		// (get) Token: 0x0602560B RID: 153099 RVA: 0x0095851E File Offset: 0x0095671E
		// (set) Token: 0x0602560C RID: 153100 RVA: 0x0095852E File Offset: 0x0095672E
		public unsafe float 角色光照边缘光Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004C53 RID: 19539
		// (get) Token: 0x0602560D RID: 153101 RVA: 0x0095853F File Offset: 0x0095673F
		// (set) Token: 0x0602560E RID: 153102 RVA: 0x0095854F File Offset: 0x0095674F
		public unsafe float 角色光照边缘光Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004C54 RID: 19540
		// (get) Token: 0x0602560F RID: 153103 RVA: 0x00958560 File Offset: 0x00956760
		// (set) Token: 0x06025610 RID: 153104 RVA: 0x00958574 File Offset: 0x00956774
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17004C55 RID: 19541
		// (get) Token: 0x06025611 RID: 153105 RVA: 0x00958589 File Offset: 0x00956789
		// (set) Token: 0x06025612 RID: 153106 RVA: 0x0095859D File Offset: 0x0095679D
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17004C56 RID: 19542
		// (get) Token: 0x06025613 RID: 153107 RVA: 0x009585B2 File Offset: 0x009567B2
		// (set) Token: 0x06025614 RID: 153108 RVA: 0x009585C2 File Offset: 0x009567C2
		public unsafe float Mode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004C57 RID: 19543
		// (get) Token: 0x06025615 RID: 153109 RVA: 0x009585D3 File Offset: 0x009567D3
		// (set) Token: 0x06025616 RID: 153110 RVA: 0x009585E3 File Offset: 0x009567E3
		public unsafe float BackgroundStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004C58 RID: 19544
		// (get) Token: 0x06025617 RID: 153111 RVA: 0x009585F4 File Offset: 0x009567F4
		// (set) Token: 0x06025618 RID: 153112 RVA: 0x00958604 File Offset: 0x00956804
		public unsafe float RotationAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004C59 RID: 19545
		// (get) Token: 0x06025619 RID: 153113 RVA: 0x00958615 File Offset: 0x00956815
		// (set) Token: 0x0602561A RID: 153114 RVA: 0x00958625 File Offset: 0x00956825
		public unsafe float BlurIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004C5A RID: 19546
		// (get) Token: 0x0602561B RID: 153115 RVA: 0x00958636 File Offset: 0x00956836
		// (set) Token: 0x0602561C RID: 153116 RVA: 0x00958646 File Offset: 0x00956846
		public unsafe float CircleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004C5B RID: 19547
		// (get) Token: 0x0602561D RID: 153117 RVA: 0x00958657 File Offset: 0x00956857
		// (set) Token: 0x0602561E RID: 153118 RVA: 0x00958667 File Offset: 0x00956867
		public unsafe float FrameThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004C5C RID: 19548
		// (get) Token: 0x0602561F RID: 153119 RVA: 0x00958678 File Offset: 0x00956878
		// (set) Token: 0x06025620 RID: 153120 RVA: 0x00958688 File Offset: 0x00956888
		public unsafe float FrameX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17004C5D RID: 19549
		// (get) Token: 0x06025621 RID: 153121 RVA: 0x00958699 File Offset: 0x00956899
		// (set) Token: 0x06025622 RID: 153122 RVA: 0x009586A9 File Offset: 0x009568A9
		public unsafe float FrameY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17004C5E RID: 19550
		// (get) Token: 0x06025623 RID: 153123 RVA: 0x009586BA File Offset: 0x009568BA
		// (set) Token: 0x06025624 RID: 153124 RVA: 0x009586CA File Offset: 0x009568CA
		public unsafe float Line1X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004C5F RID: 19551
		// (get) Token: 0x06025625 RID: 153125 RVA: 0x009586DB File Offset: 0x009568DB
		// (set) Token: 0x06025626 RID: 153126 RVA: 0x009586EB File Offset: 0x009568EB
		public unsafe float Line1Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17004C60 RID: 19552
		// (get) Token: 0x06025627 RID: 153127 RVA: 0x009586FC File Offset: 0x009568FC
		// (set) Token: 0x06025628 RID: 153128 RVA: 0x0095870C File Offset: 0x0095690C
		public unsafe float Line2X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17004C61 RID: 19553
		// (get) Token: 0x06025629 RID: 153129 RVA: 0x0095871D File Offset: 0x0095691D
		// (set) Token: 0x0602562A RID: 153130 RVA: 0x0095872D File Offset: 0x0095692D
		public unsafe float Line2Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17004C62 RID: 19554
		// (get) Token: 0x0602562B RID: 153131 RVA: 0x0095873E File Offset: 0x0095693E
		// (set) Token: 0x0602562C RID: 153132 RVA: 0x0095874E File Offset: 0x0095694E
		public unsafe float LineAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17004C63 RID: 19555
		// (get) Token: 0x0602562D RID: 153133 RVA: 0x0095875F File Offset: 0x0095695F
		// (set) Token: 0x0602562E RID: 153134 RVA: 0x0095876F File Offset: 0x0095696F
		public unsafe float LineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17004C64 RID: 19556
		// (get) Token: 0x0602562F RID: 153135 RVA: 0x00958780 File Offset: 0x00956980
		// (set) Token: 0x06025630 RID: 153136 RVA: 0x00958790 File Offset: 0x00956990
		public unsafe float EmissionPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17004C65 RID: 19557
		// (get) Token: 0x06025631 RID: 153137 RVA: 0x009587A1 File Offset: 0x009569A1
		// (set) Token: 0x06025632 RID: 153138 RVA: 0x009587B1 File Offset: 0x009569B1
		public unsafe float EmissionRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17004C66 RID: 19558
		// (get) Token: 0x06025633 RID: 153139 RVA: 0x009587C2 File Offset: 0x009569C2
		// (set) Token: 0x06025634 RID: 153140 RVA: 0x009587D2 File Offset: 0x009569D2
		public unsafe float EmissionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17004C67 RID: 19559
		// (get) Token: 0x06025635 RID: 153141 RVA: 0x009587E3 File Offset: 0x009569E3
		// (set) Token: 0x06025636 RID: 153142 RVA: 0x009587F3 File Offset: 0x009569F3
		public unsafe float ShadowPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17004C68 RID: 19560
		// (get) Token: 0x06025637 RID: 153143 RVA: 0x00958804 File Offset: 0x00956A04
		// (set) Token: 0x06025638 RID: 153144 RVA: 0x00958814 File Offset: 0x00956A14
		public unsafe float ShadowRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17004C69 RID: 19561
		// (get) Token: 0x06025639 RID: 153145 RVA: 0x00958825 File Offset: 0x00956A25
		// (set) Token: 0x0602563A RID: 153146 RVA: 0x00958835 File Offset: 0x00956A35
		public unsafe float ShadowStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17004C6A RID: 19562
		// (get) Token: 0x0602563B RID: 153147 RVA: 0x00958846 File Offset: 0x00956A46
		// (set) Token: 0x0602563C RID: 153148 RVA: 0x00958856 File Offset: 0x00956A56
		public unsafe float MaskWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17004C6B RID: 19563
		// (get) Token: 0x0602563D RID: 153149 RVA: 0x00958867 File Offset: 0x00956A67
		// (set) Token: 0x0602563E RID: 153150 RVA: 0x00958877 File Offset: 0x00956A77
		public unsafe float MaskHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17004C6C RID: 19564
		// (get) Token: 0x0602563F RID: 153151 RVA: 0x00958888 File Offset: 0x00956A88
		// (set) Token: 0x06025640 RID: 153152 RVA: 0x0095889C File Offset: 0x00956A9C
		public unsafe FColor MaskColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17004C6D RID: 19565
		// (get) Token: 0x06025641 RID: 153153 RVA: 0x009588B1 File Offset: 0x00956AB1
		// (set) Token: 0x06025642 RID: 153154 RVA: 0x009588C5 File Offset: 0x00956AC5
		public unsafe FColor EmissionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17004C6E RID: 19566
		// (get) Token: 0x06025643 RID: 153155 RVA: 0x009588DA File Offset: 0x00956ADA
		// (set) Token: 0x06025644 RID: 153156 RVA: 0x009588EE File Offset: 0x00956AEE
		public unsafe FColor ShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17004C6F RID: 19567
		// (get) Token: 0x06025645 RID: 153157 RVA: 0x00958903 File Offset: 0x00956B03
		// (set) Token: 0x06025646 RID: 153158 RVA: 0x00958913 File Offset: 0x00956B13
		public unsafe float RhombusRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17004C70 RID: 19568
		// (get) Token: 0x06025647 RID: 153159 RVA: 0x00958924 File Offset: 0x00956B24
		// (set) Token: 0x06025648 RID: 153160 RVA: 0x00958934 File Offset: 0x00956B34
		public unsafe float PositionHorizon
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17004C71 RID: 19569
		// (get) Token: 0x06025649 RID: 153161 RVA: 0x00958945 File Offset: 0x00956B45
		// (set) Token: 0x0602564A RID: 153162 RVA: 0x00958955 File Offset: 0x00956B55
		public unsafe float PositionVertical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17004C72 RID: 19570
		// (get) Token: 0x0602564B RID: 153163 RVA: 0x00958966 File Offset: 0x00956B66
		// (set) Token: 0x0602564C RID: 153164 RVA: 0x00958976 File Offset: 0x00956B76
		public unsafe float CircleMaskSoftness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17004C73 RID: 19571
		// (get) Token: 0x0602564D RID: 153165 RVA: 0x00958987 File Offset: 0x00956B87
		// (set) Token: 0x0602564E RID: 153166 RVA: 0x00958997 File Offset: 0x00956B97
		public unsafe float CircleMaskRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x0602564F RID: 153167 RVA: 0x009589A8 File Offset: 0x00956BA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPPVWeatherDA(UKuroWeatherDataAsset WeatherDA)
		{
			BP_CameraEffect_C.__SetPPVWeatherDA_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__SetPPVWeatherDA_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CameraEffect_C.__SetPPVWeatherDA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__SetPPVWeatherDA_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WeatherDA = ((WeatherDA != null) ? WeatherDA.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__SetPPVWeatherDA_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025650 RID: 153168 RVA: 0x00958A00 File Offset: 0x00956C00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPPVBlendWeight(float BlendWeight)
		{
			BP_CameraEffect_C.__SetPPVBlendWeight_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__SetPPVBlendWeight_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraEffect_C.__SetPPVBlendWeight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__SetPPVBlendWeight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BlendWeight = BlendWeight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__SetPPVBlendWeight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025651 RID: 153169 RVA: 0x00958A48 File Offset: 0x00956C48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPPVPriority(float Priority)
		{
			BP_CameraEffect_C.__SetPPVPriority_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__SetPPVPriority_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraEffect_C.__SetPPVPriority_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__SetPPVPriority_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Priority = Priority;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__SetPPVPriority_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025652 RID: 153170 RVA: 0x00958A90 File Offset: 0x00956C90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetNiagaraEffect(int Index)
		{
			BP_CameraEffect_C.__SetNiagaraEffect_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__SetNiagaraEffect_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CameraEffect_C.__SetNiagaraEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__SetNiagaraEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__SetNiagaraEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025653 RID: 153171 RVA: 0x00958AD6 File Offset: 0x00956CD6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 贴图画框()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__贴图画框_NativeFunctionPtr, null);
		}

		// Token: 0x06025654 RID: 153172 RVA: 0x00958AEA File Offset: 0x00956CEA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 菱形遮罩()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__菱形遮罩_NativeFunctionPtr, null);
		}

		// Token: 0x06025655 RID: 153173 RVA: 0x00958AFE File Offset: 0x00956CFE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 圆形遮罩()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__圆形遮罩_NativeFunctionPtr, null);
		}

		// Token: 0x06025656 RID: 153174 RVA: 0x00958B12 File Offset: 0x00956D12
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 纯色遮罩()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__纯色遮罩_NativeFunctionPtr, null);
		}

		// Token: 0x06025657 RID: 153175 RVA: 0x00958B26 File Offset: 0x00956D26
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 艺术画框()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__艺术画框_NativeFunctionPtr, null);
		}

		// Token: 0x06025658 RID: 153176 RVA: 0x00958B3A File Offset: 0x00956D3A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 默认()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__默认_NativeFunctionPtr, null);
		}

		// Token: 0x06025659 RID: 153177 RVA: 0x00958B4E File Offset: 0x00956D4E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x0602565A RID: 153178 RVA: 0x00958B62 File Offset: 0x00956D62
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 关闭集群特效()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__关闭集群特效_NativeFunctionPtr, null);
		}

		// Token: 0x0602565B RID: 153179 RVA: 0x00958B76 File Offset: 0x00956D76
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _8彩带()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___8彩带_NativeFunctionPtr, null);
		}

		// Token: 0x0602565C RID: 153180 RVA: 0x00958B8A File Offset: 0x00956D8A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _7蒲公英()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___7蒲公英_NativeFunctionPtr, null);
		}

		// Token: 0x0602565D RID: 153181 RVA: 0x00958B9E File Offset: 0x00956D9E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _6樱花()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___6樱花_NativeFunctionPtr, null);
		}

		// Token: 0x0602565E RID: 153182 RVA: 0x00958BB2 File Offset: 0x00956DB2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _5彼岸花()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___5彼岸花_NativeFunctionPtr, null);
		}

		// Token: 0x0602565F RID: 153183 RVA: 0x00958BC6 File Offset: 0x00956DC6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _4竹叶()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___4竹叶_NativeFunctionPtr, null);
		}

		// Token: 0x06025660 RID: 153184 RVA: 0x00958BDA File Offset: 0x00956DDA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _3银杏叶()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___3银杏叶_NativeFunctionPtr, null);
		}

		// Token: 0x06025661 RID: 153185 RVA: 0x00958BEE File Offset: 0x00956DEE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _2枫叶红()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___2枫叶红_NativeFunctionPtr, null);
		}

		// Token: 0x06025662 RID: 153186 RVA: 0x00958C02 File Offset: 0x00956E02
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _1枫叶橙()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___1枫叶橙_NativeFunctionPtr, null);
		}

		// Token: 0x06025663 RID: 153187 RVA: 0x00958C16 File Offset: 0x00956E16
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCharacterLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__UpdateCharacterLight_NativeFunctionPtr, null);
		}

		// Token: 0x06025664 RID: 153188 RVA: 0x00958C2A File Offset: 0x00956E2A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateWindFieldDirectoin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__UpdateWindFieldDirectoin_NativeFunctionPtr, null);
		}

		// Token: 0x06025665 RID: 153189 RVA: 0x00958C3E File Offset: 0x00956E3E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025666 RID: 153190 RVA: 0x00958C52 File Offset: 0x00956E52
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraEffect_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025667 RID: 153191 RVA: 0x00958C67 File Offset: 0x00956E67
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025668 RID: 153192 RVA: 0x00958C7B File Offset: 0x00956E7B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraEffect_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025669 RID: 153193 RVA: 0x00958C90 File Offset: 0x00956E90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CameraEffect_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraEffect_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602566A RID: 153194 RVA: 0x00958CD8 File Offset: 0x00956ED8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CameraEffect_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraEffect_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602566B RID: 153195 RVA: 0x00958D20 File Offset: 0x00956F20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CameraEffect_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraEffect_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602566C RID: 153196 RVA: 0x00958D68 File Offset: 0x00956F68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CameraEffect_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraEffect_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602566D RID: 153197 RVA: 0x00958DAF File Offset: 0x00956FAF
		protected BP_CameraEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A32 RID: 76338
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_CameraEffect.BP_CameraEffect_C";

		// Token: 0x04012A33 RID: 76339
		private static IntPtr _ClassPtr;

		// Token: 0x04012A34 RID: 76340
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A35 RID: 76341
		internal static int __PropertyOffset_1;

		// Token: 0x04012A36 RID: 76342
		internal static int __PropertyOffset_2;

		// Token: 0x04012A37 RID: 76343
		internal static int __PropertyOffset_3;

		// Token: 0x04012A38 RID: 76344
		internal static int __PropertyOffset_4;

		// Token: 0x04012A39 RID: 76345
		internal static int __PropertyOffset_5;

		// Token: 0x04012A3A RID: 76346
		internal static int __PropertyOffset_6;

		// Token: 0x04012A3B RID: 76347
		internal static int __PropertyOffset_7;

		// Token: 0x04012A3C RID: 76348
		internal static int __PropertyOffset_8;

		// Token: 0x04012A3D RID: 76349
		internal static int __PropertyOffset_9;

		// Token: 0x04012A3E RID: 76350
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraSystem> _Niagara_System_Objects;

		// Token: 0x04012A3F RID: 76351
		internal static int __PropertyOffset_10;

		// Token: 0x04012A40 RID: 76352
		internal static int __PropertyOffset_11;

		// Token: 0x04012A41 RID: 76353
		internal static int __PropertyOffset_12;

		// Token: 0x04012A42 RID: 76354
		internal static int __PropertyOffset_13;

		// Token: 0x04012A43 RID: 76355
		internal static int __PropertyOffset_14;

		// Token: 0x04012A44 RID: 76356
		internal static int __PropertyOffset_15;

		// Token: 0x04012A45 RID: 76357
		internal static int __PropertyOffset_16;

		// Token: 0x04012A46 RID: 76358
		internal static int __PropertyOffset_17;

		// Token: 0x04012A47 RID: 76359
		internal static int __PropertyOffset_18;

		// Token: 0x04012A48 RID: 76360
		internal static int __PropertyOffset_19;

		// Token: 0x04012A49 RID: 76361
		internal static int __PropertyOffset_20;

		// Token: 0x04012A4A RID: 76362
		internal static int __PropertyOffset_21;

		// Token: 0x04012A4B RID: 76363
		internal static int __PropertyOffset_22;

		// Token: 0x04012A4C RID: 76364
		internal static int __PropertyOffset_23;

		// Token: 0x04012A4D RID: 76365
		internal static int __PropertyOffset_24;

		// Token: 0x04012A4E RID: 76366
		internal static int __PropertyOffset_25;

		// Token: 0x04012A4F RID: 76367
		internal static int __PropertyOffset_26;

		// Token: 0x04012A50 RID: 76368
		internal static int __PropertyOffset_27;

		// Token: 0x04012A51 RID: 76369
		internal static int __PropertyOffset_28;

		// Token: 0x04012A52 RID: 76370
		internal static int __PropertyOffset_29;

		// Token: 0x04012A53 RID: 76371
		internal static int __PropertyOffset_30;

		// Token: 0x04012A54 RID: 76372
		internal static int __PropertyOffset_31;

		// Token: 0x04012A55 RID: 76373
		internal static int __PropertyOffset_32;

		// Token: 0x04012A56 RID: 76374
		internal static int __PropertyOffset_33;

		// Token: 0x04012A57 RID: 76375
		internal static int __PropertyOffset_34;

		// Token: 0x04012A58 RID: 76376
		internal static int __PropertyOffset_35;

		// Token: 0x04012A59 RID: 76377
		internal static int __PropertyOffset_36;

		// Token: 0x04012A5A RID: 76378
		internal static int __PropertyOffset_37;

		// Token: 0x04012A5B RID: 76379
		internal static int __PropertyOffset_38;

		// Token: 0x04012A5C RID: 76380
		internal static int __PropertyOffset_39;

		// Token: 0x04012A5D RID: 76381
		internal static int __PropertyOffset_40;

		// Token: 0x04012A5E RID: 76382
		internal static int __PropertyOffset_41;

		// Token: 0x04012A5F RID: 76383
		internal static int __PropertyOffset_42;

		// Token: 0x04012A60 RID: 76384
		internal static int __PropertyOffset_43;

		// Token: 0x04012A61 RID: 76385
		internal static int __PropertyOffset_44;

		// Token: 0x04012A62 RID: 76386
		internal static int __PropertyOffset_45;

		// Token: 0x04012A63 RID: 76387
		internal static int __PropertyOffset_46;

		// Token: 0x04012A64 RID: 76388
		internal static int __PropertyOffset_47;

		// Token: 0x04012A65 RID: 76389
		internal static int __PropertyOffset_48;

		// Token: 0x04012A66 RID: 76390
		internal static int __PropertyOffset_49;

		// Token: 0x04012A67 RID: 76391
		internal static int __PropertyOffset_50;

		// Token: 0x04012A68 RID: 76392
		private static IntPtr __SetPPVWeatherDA_NativeFunctionPtr;

		// Token: 0x04012A69 RID: 76393
		private static IntPtr __SetPPVBlendWeight_NativeFunctionPtr;

		// Token: 0x04012A6A RID: 76394
		private static IntPtr __SetPPVPriority_NativeFunctionPtr;

		// Token: 0x04012A6B RID: 76395
		private static IntPtr __SetNiagaraEffect_NativeFunctionPtr;

		// Token: 0x04012A6C RID: 76396
		private static IntPtr __贴图画框_NativeFunctionPtr;

		// Token: 0x04012A6D RID: 76397
		private static IntPtr __菱形遮罩_NativeFunctionPtr;

		// Token: 0x04012A6E RID: 76398
		private static IntPtr __圆形遮罩_NativeFunctionPtr;

		// Token: 0x04012A6F RID: 76399
		private static IntPtr __纯色遮罩_NativeFunctionPtr;

		// Token: 0x04012A70 RID: 76400
		private static IntPtr __艺术画框_NativeFunctionPtr;

		// Token: 0x04012A71 RID: 76401
		private static IntPtr __默认_NativeFunctionPtr;

		// Token: 0x04012A72 RID: 76402
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x04012A73 RID: 76403
		private static IntPtr __关闭集群特效_NativeFunctionPtr;

		// Token: 0x04012A74 RID: 76404
		private static IntPtr ___8彩带_NativeFunctionPtr;

		// Token: 0x04012A75 RID: 76405
		private static IntPtr ___7蒲公英_NativeFunctionPtr;

		// Token: 0x04012A76 RID: 76406
		private static IntPtr ___6樱花_NativeFunctionPtr;

		// Token: 0x04012A77 RID: 76407
		private static IntPtr ___5彼岸花_NativeFunctionPtr;

		// Token: 0x04012A78 RID: 76408
		private static IntPtr ___4竹叶_NativeFunctionPtr;

		// Token: 0x04012A79 RID: 76409
		private static IntPtr ___3银杏叶_NativeFunctionPtr;

		// Token: 0x04012A7A RID: 76410
		private static IntPtr ___2枫叶红_NativeFunctionPtr;

		// Token: 0x04012A7B RID: 76411
		private static IntPtr ___1枫叶橙_NativeFunctionPtr;

		// Token: 0x04012A7C RID: 76412
		private static IntPtr __UpdateCharacterLight_NativeFunctionPtr;

		// Token: 0x04012A7D RID: 76413
		private static IntPtr __UpdateWindFieldDirectoin_NativeFunctionPtr;

		// Token: 0x04012A7E RID: 76414
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012A7F RID: 76415
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012A80 RID: 76416
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012A81 RID: 76417
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009FEE RID: 40942
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetPPVWeatherDA_FunctionParams
		{
			// Token: 0x04031A89 RID: 203401
			[FieldOffset(0)]
			public IntPtr WeatherDA;
		}

		// Token: 0x02009FEF RID: 40943
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPPVBlendWeight_FunctionParams
		{
			// Token: 0x04031A8A RID: 203402
			[FieldOffset(0)]
			public float BlendWeight;
		}

		// Token: 0x02009FF0 RID: 40944
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPPVPriority_FunctionParams
		{
			// Token: 0x04031A8B RID: 203403
			[FieldOffset(0)]
			public float Priority;
		}

		// Token: 0x02009FF1 RID: 40945
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetNiagaraEffect_FunctionParams
		{
			// Token: 0x04031A8C RID: 203404
			[FieldOffset(0)]
			public int Index;
		}

		// Token: 0x02009FF2 RID: 40946
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A8D RID: 203405
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FF3 RID: 40947
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031A8E RID: 203406
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
