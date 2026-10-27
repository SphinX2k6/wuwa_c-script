using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D59 RID: 15705
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudSequence.BP_CloudSequence_C")]
	[UnrealStructLayout(1696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1693)]
	public class BP_CloudSequence_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026542 RID: 156994 RVA: 0x00972335 File Offset: 0x00970535
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CloudSequence_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudSequence.BP_CloudSequence_C");
			}
			return BP_CloudSequence_C._ClassPtr;
		}

		// Token: 0x06026543 RID: 156995 RVA: 0x0097235C File Offset: 0x0097055C
		public BP_CloudSequence_C() : this(BuiltinUtils.AllocNativeUObject(BP_CloudSequence_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026544 RID: 156996 RVA: 0x00972384 File Offset: 0x00970584
		[NullableContext(1)]
		public BP_CloudSequence_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CloudSequence_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170051B7 RID: 20919
		// (get) Token: 0x06026545 RID: 156997 RVA: 0x009723B7 File Offset: 0x009705B7
		// (set) Token: 0x06026546 RID: 156998 RVA: 0x009723CB File Offset: 0x009705CB
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170051B8 RID: 20920
		// (get) Token: 0x06026547 RID: 156999 RVA: 0x009723E0 File Offset: 0x009705E0
		// (set) Token: 0x06026548 RID: 157000 RVA: 0x009723F4 File Offset: 0x009705F4
		public unsafe UStaticMeshComponent Cloud_Anomalies
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170051B9 RID: 20921
		// (get) Token: 0x06026549 RID: 157001 RVA: 0x00972409 File Offset: 0x00970609
		// (set) Token: 0x0602654A RID: 157002 RVA: 0x0097241D File Offset: 0x0097061D
		public unsafe UStaticMeshComponent Sun_Moon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170051BA RID: 20922
		// (get) Token: 0x0602654B RID: 157003 RVA: 0x00972432 File Offset: 0x00970632
		// (set) Token: 0x0602654C RID: 157004 RVA: 0x00972446 File Offset: 0x00970646
		public unsafe UStaticMeshComponent Cloud_BigShape
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170051BB RID: 20923
		// (get) Token: 0x0602654D RID: 157005 RVA: 0x0097245B File Offset: 0x0097065B
		// (set) Token: 0x0602654E RID: 157006 RVA: 0x0097246F File Offset: 0x0097066F
		public unsafe UStaticMeshComponent Cloud_Special
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170051BC RID: 20924
		// (get) Token: 0x0602654F RID: 157007 RVA: 0x00972484 File Offset: 0x00970684
		// (set) Token: 0x06026550 RID: 157008 RVA: 0x00972498 File Offset: 0x00970698
		public unsafe UStaticMeshComponent Cloud_Top
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170051BD RID: 20925
		// (get) Token: 0x06026551 RID: 157009 RVA: 0x009724AD File Offset: 0x009706AD
		// (set) Token: 0x06026552 RID: 157010 RVA: 0x009724C1 File Offset: 0x009706C1
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170051BE RID: 20926
		// (get) Token: 0x06026553 RID: 157011 RVA: 0x009724D6 File Offset: 0x009706D6
		// (set) Token: 0x06026554 RID: 157012 RVA: 0x009724EA File Offset: 0x009706EA
		public unsafe UMaterialInstanceDynamic DMI_Top
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170051BF RID: 20927
		// (get) Token: 0x06026555 RID: 157013 RVA: 0x009724FF File Offset: 0x009706FF
		// (set) Token: 0x06026556 RID: 157014 RVA: 0x00972513 File Offset: 0x00970713
		public unsafe UMaterialInstanceDynamic DMI_Anomalies
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170051C0 RID: 20928
		// (get) Token: 0x06026557 RID: 157015 RVA: 0x00972528 File Offset: 0x00970728
		// (set) Token: 0x06026558 RID: 157016 RVA: 0x0097253C File Offset: 0x0097073C
		public unsafe UMaterialInstanceDynamic DMI_SunMoon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x170051C1 RID: 20929
		// (get) Token: 0x06026559 RID: 157017 RVA: 0x00972551 File Offset: 0x00970751
		// (set) Token: 0x0602655A RID: 157018 RVA: 0x00972565 File Offset: 0x00970765
		public unsafe UMaterialInstanceDynamic DMI_BigShape
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170051C2 RID: 20930
		// (get) Token: 0x0602655B RID: 157019 RVA: 0x0097257A File Offset: 0x0097077A
		// (set) Token: 0x0602655C RID: 157020 RVA: 0x0097258A File Offset: 0x0097078A
		public unsafe bool UpdatePerFourFrame01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051C3 RID: 20931
		// (get) Token: 0x0602655D RID: 157021 RVA: 0x0097259B File Offset: 0x0097079B
		// (set) Token: 0x0602655E RID: 157022 RVA: 0x009725AB File Offset: 0x009707AB
		public unsafe bool UpdatePerFourFrame02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051C4 RID: 20932
		// (get) Token: 0x0602655F RID: 157023 RVA: 0x009725BC File Offset: 0x009707BC
		// (set) Token: 0x06026560 RID: 157024 RVA: 0x009725D0 File Offset: 0x009707D0
		public unsafe UTexture2D Top_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170051C5 RID: 20933
		// (get) Token: 0x06026561 RID: 157025 RVA: 0x009725E5 File Offset: 0x009707E5
		// (set) Token: 0x06026562 RID: 157026 RVA: 0x009725F9 File Offset: 0x009707F9
		public unsafe UTexture2D POI_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x170051C6 RID: 20934
		// (get) Token: 0x06026563 RID: 157027 RVA: 0x0097260E File Offset: 0x0097080E
		// (set) Token: 0x06026564 RID: 157028 RVA: 0x00972622 File Offset: 0x00970822
		public unsafe FRotator POI_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170051C7 RID: 20935
		// (get) Token: 0x06026565 RID: 157029 RVA: 0x00972637 File Offset: 0x00970837
		// (set) Token: 0x06026566 RID: 157030 RVA: 0x0097264B File Offset: 0x0097084B
		public unsafe UMaterialInstance TOP_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x170051C8 RID: 20936
		// (get) Token: 0x06026567 RID: 157031 RVA: 0x00972660 File Offset: 0x00970860
		// (set) Token: 0x06026568 RID: 157032 RVA: 0x00972670 File Offset: 0x00970870
		public unsafe bool UV1UV2_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051C9 RID: 20937
		// (get) Token: 0x06026569 RID: 157033 RVA: 0x00972681 File Offset: 0x00970881
		// (set) Token: 0x0602656A RID: 157034 RVA: 0x00972691 File Offset: 0x00970891
		public unsafe float UVTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170051CA RID: 20938
		// (get) Token: 0x0602656B RID: 157035 RVA: 0x009726A2 File Offset: 0x009708A2
		// (set) Token: 0x0602656C RID: 157036 RVA: 0x009726B2 File Offset: 0x009708B2
		public unsafe float CloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170051CB RID: 20939
		// (get) Token: 0x0602656D RID: 157037 RVA: 0x009726C3 File Offset: 0x009708C3
		// (set) Token: 0x0602656E RID: 157038 RVA: 0x009726D3 File Offset: 0x009708D3
		public unsafe float Top_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170051CC RID: 20940
		// (get) Token: 0x0602656F RID: 157039 RVA: 0x009726E4 File Offset: 0x009708E4
		// (set) Token: 0x06026570 RID: 157040 RVA: 0x009726F8 File Offset: 0x009708F8
		public unsafe UTexture2D Special_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x170051CD RID: 20941
		// (get) Token: 0x06026571 RID: 157041 RVA: 0x0097270D File Offset: 0x0097090D
		// (set) Token: 0x06026572 RID: 157042 RVA: 0x00972721 File Offset: 0x00970921
		public unsafe UMaterialInstance Special_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x170051CE RID: 20942
		// (get) Token: 0x06026573 RID: 157043 RVA: 0x00972736 File Offset: 0x00970936
		// (set) Token: 0x06026574 RID: 157044 RVA: 0x0097274A File Offset: 0x0097094A
		public unsafe FRotator Special_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170051CF RID: 20943
		// (get) Token: 0x06026575 RID: 157045 RVA: 0x0097275F File Offset: 0x0097095F
		// (set) Token: 0x06026576 RID: 157046 RVA: 0x0097276F File Offset: 0x0097096F
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170051D0 RID: 20944
		// (get) Token: 0x06026577 RID: 157047 RVA: 0x00972780 File Offset: 0x00970980
		// (set) Token: 0x06026578 RID: 157048 RVA: 0x00972790 File Offset: 0x00970990
		public unsafe int TransSortNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170051D1 RID: 20945
		// (get) Token: 0x06026579 RID: 157049 RVA: 0x009727A1 File Offset: 0x009709A1
		// (set) Token: 0x0602657A RID: 157050 RVA: 0x009727B5 File Offset: 0x009709B5
		public unsafe UStaticMesh CloudSpecialMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x170051D2 RID: 20946
		// (get) Token: 0x0602657B RID: 157051 RVA: 0x009727CA File Offset: 0x009709CA
		// (set) Token: 0x0602657C RID: 157052 RVA: 0x009727DE File Offset: 0x009709DE
		public unsafe UTexture2D Noise_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x170051D3 RID: 20947
		// (get) Token: 0x0602657D RID: 157053 RVA: 0x009727F3 File Offset: 0x009709F3
		// (set) Token: 0x0602657E RID: 157054 RVA: 0x00972803 File Offset: 0x00970A03
		public unsafe float NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170051D4 RID: 20948
		// (get) Token: 0x0602657F RID: 157055 RVA: 0x00972814 File Offset: 0x00970A14
		// (set) Token: 0x06026580 RID: 157056 RVA: 0x00972824 File Offset: 0x00970A24
		public unsafe float NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170051D5 RID: 20949
		// (get) Token: 0x06026581 RID: 157057 RVA: 0x00972835 File Offset: 0x00970A35
		// (set) Token: 0x06026582 RID: 157058 RVA: 0x00972845 File Offset: 0x00970A45
		public unsafe float NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170051D6 RID: 20950
		// (get) Token: 0x06026583 RID: 157059 RVA: 0x00972856 File Offset: 0x00970A56
		// (set) Token: 0x06026584 RID: 157060 RVA: 0x0097286A File Offset: 0x00970A6A
		public unsafe UTexture2D Anomalies_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x170051D7 RID: 20951
		// (get) Token: 0x06026585 RID: 157061 RVA: 0x0097287F File Offset: 0x00970A7F
		// (set) Token: 0x06026586 RID: 157062 RVA: 0x00972893 File Offset: 0x00970A93
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x170051D8 RID: 20952
		// (get) Token: 0x06026587 RID: 157063 RVA: 0x009728A8 File Offset: 0x00970AA8
		// (set) Token: 0x06026588 RID: 157064 RVA: 0x009728BC File Offset: 0x00970ABC
		public unsafe FRotator Anomalies_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x170051D9 RID: 20953
		// (get) Token: 0x06026589 RID: 157065 RVA: 0x009728D1 File Offset: 0x00970AD1
		// (set) Token: 0x0602658A RID: 157066 RVA: 0x009728E1 File Offset: 0x00970AE1
		public unsafe float Anomalies_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x170051DA RID: 20954
		// (get) Token: 0x0602658B RID: 157067 RVA: 0x009728F2 File Offset: 0x00970AF2
		// (set) Token: 0x0602658C RID: 157068 RVA: 0x00972906 File Offset: 0x00970B06
		public unsafe FVector Anomalies_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x170051DB RID: 20955
		// (get) Token: 0x0602658D RID: 157069 RVA: 0x0097291C File Offset: 0x00970B1C
		// (set) Token: 0x0602658E RID: 157070 RVA: 0x00972955 File Offset: 0x00970B55
		[Nullable(1)]
		public FKuroCurveFloat Sky
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Sky) == null)
				{
					result = (this._Sky = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_37, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_37, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170051DC RID: 20956
		// (get) Token: 0x0602658F RID: 157071 RVA: 0x00972978 File Offset: 0x00970B78
		// (set) Token: 0x06026590 RID: 157072 RVA: 0x009729B1 File Offset: 0x00970BB1
		[Nullable(1)]
		public FKuroCurveFloat StarTrails
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._StarTrails) == null)
				{
					result = (this._StarTrails = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_38, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_38, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170051DD RID: 20957
		// (get) Token: 0x06026591 RID: 157073 RVA: 0x009729D2 File Offset: 0x00970BD2
		// (set) Token: 0x06026592 RID: 157074 RVA: 0x009729E2 File Offset: 0x00970BE2
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x170051DE RID: 20958
		// (get) Token: 0x06026593 RID: 157075 RVA: 0x009729F3 File Offset: 0x00970BF3
		// (set) Token: 0x06026594 RID: 157076 RVA: 0x00972A03 File Offset: 0x00970C03
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x170051DF RID: 20959
		// (get) Token: 0x06026595 RID: 157077 RVA: 0x00972A14 File Offset: 0x00970C14
		// (set) Token: 0x06026596 RID: 157078 RVA: 0x00972A24 File Offset: 0x00970C24
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x170051E0 RID: 20960
		// (get) Token: 0x06026597 RID: 157079 RVA: 0x00972A35 File Offset: 0x00970C35
		// (set) Token: 0x06026598 RID: 157080 RVA: 0x00972A45 File Offset: 0x00970C45
		public unsafe bool IsTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_42) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_42) = (value ? 1 : 0);
			}
		}

		// Token: 0x170051E1 RID: 20961
		// (get) Token: 0x06026599 RID: 157081 RVA: 0x00972A56 File Offset: 0x00970C56
		// (set) Token: 0x0602659A RID: 157082 RVA: 0x00972A66 File Offset: 0x00970C66
		public unsafe float Anomalies_NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x170051E2 RID: 20962
		// (get) Token: 0x0602659B RID: 157083 RVA: 0x00972A77 File Offset: 0x00970C77
		// (set) Token: 0x0602659C RID: 157084 RVA: 0x00972A87 File Offset: 0x00970C87
		public unsafe float Anomalies_NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x170051E3 RID: 20963
		// (get) Token: 0x0602659D RID: 157085 RVA: 0x00972A98 File Offset: 0x00970C98
		// (set) Token: 0x0602659E RID: 157086 RVA: 0x00972AA8 File Offset: 0x00970CA8
		public unsafe float Anomalies_NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x170051E4 RID: 20964
		// (get) Token: 0x0602659F RID: 157087 RVA: 0x00972AB9 File Offset: 0x00970CB9
		// (set) Token: 0x060265A0 RID: 157088 RVA: 0x00972ACD File Offset: 0x00970CCD
		public unsafe UTexture2D Anomalies_NoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudSequence_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x170051E5 RID: 20965
		// (get) Token: 0x060265A1 RID: 157089 RVA: 0x00972AE2 File Offset: 0x00970CE2
		// (set) Token: 0x060265A2 RID: 157090 RVA: 0x00972AF6 File Offset: 0x00970CF6
		[Nullable(1)]
		public unsafe string LevelLog
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CloudSequence_C.__PropertyOffset_47)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CloudSequence_C.__PropertyOffset_47)), value);
			}
		}

		// Token: 0x170051E6 RID: 20966
		// (get) Token: 0x060265A3 RID: 157091 RVA: 0x00972B0B File Offset: 0x00970D0B
		// (set) Token: 0x060265A4 RID: 157092 RVA: 0x00972B1B File Offset: 0x00970D1B
		public unsafe float Translucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x170051E7 RID: 20967
		// (get) Token: 0x060265A5 RID: 157093 RVA: 0x00972B2C File Offset: 0x00970D2C
		// (set) Token: 0x060265A6 RID: 157094 RVA: 0x00972B3C File Offset: 0x00970D3C
		public unsafe float Soft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x170051E8 RID: 20968
		// (get) Token: 0x060265A7 RID: 157095 RVA: 0x00972B4D File Offset: 0x00970D4D
		// (set) Token: 0x060265A8 RID: 157096 RVA: 0x00972B5D File Offset: 0x00970D5D
		public unsafe float Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x170051E9 RID: 20969
		// (get) Token: 0x060265A9 RID: 157097 RVA: 0x00972B6E File Offset: 0x00970D6E
		// (set) Token: 0x060265AA RID: 157098 RVA: 0x00972B7E File Offset: 0x00970D7E
		public unsafe bool bDisableAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_51) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudSequence_C.__PropertyOffset_51) = (value ? 1 : 0);
			}
		}

		// Token: 0x060265AB RID: 157099 RVA: 0x00972B90 File Offset: 0x00970D90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Timer(ref float ElapsedTime)
		{
			BP_CloudSequence_C.__Timer_FunctionParams* ptr = stackalloc BP_CloudSequence_C.__Timer_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CloudSequence_C.__Timer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudSequence_C.__Timer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudSequence_C.__Timer_NativeFunctionPtr, (void*)ptr);
			ElapsedTime = ptr->ElapsedTime;
		}

		// Token: 0x060265AC RID: 157100 RVA: 0x00972BE0 File Offset: 0x00970DE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ChangeSky(bool IsTick)
		{
			BP_CloudSequence_C.__ChangeSky_FunctionParams* ptr = stackalloc BP_CloudSequence_C.__ChangeSky_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(BP_CloudSequence_C.__ChangeSky_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudSequence_C.__ChangeSky_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsTick = IsTick;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudSequence_C.__ChangeSky_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060265AD RID: 157101 RVA: 0x00972C28 File Offset: 0x00970E28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Special_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, UTexture2D Texture, FRotator POIRotation, float Intensity, FVector Scale, UTexture2D NoiseTex, float NoiseSpeed, float NoiseStrength, float NoiseTilling, FLinearColor Color)
		{
			BP_CloudSequence_C.__Special_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudSequence_C.__Special_Parameters_Initial_FunctionParams[(UIntPtr)263] + 15L / (long)sizeof(BP_CloudSequence_C.__Special_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudSequence_C.__Special_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->POIRotation = POIRotation;
			ptr->Intensity = Intensity;
			ptr->Scale = Scale;
			ptr->NoiseTex = ((NoiseTex != null) ? NoiseTex.NativePtr : IntPtr.Zero);
			ptr->NoiseSpeed = NoiseSpeed;
			ptr->NoiseStrength = NoiseStrength;
			ptr->NoiseTilling = NoiseTilling;
			ptr->Color = Color;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudSequence_C.__Special_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060265AE RID: 157102 RVA: 0x00972CFC File Offset: 0x00970EFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SunMoon_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, UTexture2D Texture, FRotator POIRotation, float Intensity)
		{
			BP_CloudSequence_C.__SunMoon_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudSequence_C.__SunMoon_Parameters_Initial_FunctionParams[(UIntPtr)231] + 15L / (long)sizeof(BP_CloudSequence_C.__SunMoon_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudSequence_C.__SunMoon_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->POIRotation = POIRotation;
			ptr->Intensity = Intensity;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudSequence_C.__SunMoon_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060265AF RID: 157103 RVA: 0x00972D90 File Offset: 0x00970F90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Single_POI_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, UTexture2D Texture, FRotator POIRotation)
		{
			BP_CloudSequence_C.__Single_POI_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudSequence_C.__Single_POI_Parameters_Initial_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_CloudSequence_C.__Single_POI_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudSequence_C.__Single_POI_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->POIRotation = POIRotation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudSequence_C.__Single_POI_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060265B0 RID: 157104 RVA: 0x00972E1C File Offset: 0x0097101C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePerFourFrame()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudSequence_C.__UpdatePerFourFrame_NativeFunctionPtr, null);
		}

		// Token: 0x060265B1 RID: 157105 RVA: 0x00972E30 File Offset: 0x00971030
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CreateDMI(UStaticMeshComponent Mesh, UMaterialInstance Material, ref UMaterialInstanceDynamic DMI)
		{
			BP_CloudSequence_C.__CreateDMI_FunctionParams* ptr = stackalloc BP_CloudSequence_C.__CreateDMI_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_CloudSequence_C.__CreateDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudSequence_C.__CreateDMI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Material = ((Material != null) ? Material.NativePtr : IntPtr.Zero);
			ref BP_CloudSequence_C.__CreateDMI_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = DMI;
			ptr2.DMI = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudSequence_C.__CreateDMI_NativeFunctionPtr, (void*)ptr);
			DMI = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->DMI);
		}

		// Token: 0x060265B2 RID: 157106 RVA: 0x00972EC0 File Offset: 0x009710C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Single_Cloud_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, UTexture2D Texture, bool UV1UV2_, float CloudSpeed, float Top_Rotation, float UVTiling, float NoiseStrength, float NoiseSpeed, float NoiseTilling, UTexture2D NoiseTex)
		{
			BP_CloudSequence_C.__Single_Cloud_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudSequence_C.__Single_Cloud_Parameters_Initial_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_CloudSequence_C.__Single_Cloud_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudSequence_C.__Single_Cloud_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->UV1UV2_ = UV1UV2_;
			ptr->CloudSpeed = CloudSpeed;
			ptr->Top_Rotation = Top_Rotation;
			ptr->UVTiling = UVTiling;
			ptr->NoiseStrength = NoiseStrength;
			ptr->NoiseSpeed = NoiseSpeed;
			ptr->NoiseTilling = NoiseTilling;
			ptr->NoiseTex = ((NoiseTex != null) ? NoiseTex.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudSequence_C.__Single_Cloud_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060265B3 RID: 157107 RVA: 0x00972F91 File Offset: 0x00971191
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudSequence_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060265B4 RID: 157108 RVA: 0x00972FA5 File Offset: 0x009711A5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudSequence_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060265B5 RID: 157109 RVA: 0x00972FBA File Offset: 0x009711BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudSequence_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060265B6 RID: 157110 RVA: 0x00972FCE File Offset: 0x009711CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudSequence_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060265B7 RID: 157111 RVA: 0x00972FE4 File Offset: 0x009711E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CloudSequence_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CloudSequence_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudSequence_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudSequence_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudSequence_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060265B8 RID: 157112 RVA: 0x0097302C File Offset: 0x0097122C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CloudSequence_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CloudSequence_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudSequence_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudSequence_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudSequence_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060265B9 RID: 157113 RVA: 0x00973073 File Offset: 0x00971273
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudSequence_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x060265BA RID: 157114 RVA: 0x00973087 File Offset: 0x00971287
		protected BP_CloudSequence_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013344 RID: 78660
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudSequence.BP_CloudSequence_C";

		// Token: 0x04013345 RID: 78661
		private static IntPtr _ClassPtr;

		// Token: 0x04013346 RID: 78662
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013347 RID: 78663
		internal static int __PropertyOffset_1;

		// Token: 0x04013348 RID: 78664
		internal static int __PropertyOffset_2;

		// Token: 0x04013349 RID: 78665
		internal static int __PropertyOffset_3;

		// Token: 0x0401334A RID: 78666
		internal static int __PropertyOffset_4;

		// Token: 0x0401334B RID: 78667
		internal static int __PropertyOffset_5;

		// Token: 0x0401334C RID: 78668
		internal static int __PropertyOffset_6;

		// Token: 0x0401334D RID: 78669
		internal static int __PropertyOffset_7;

		// Token: 0x0401334E RID: 78670
		internal static int __PropertyOffset_8;

		// Token: 0x0401334F RID: 78671
		internal static int __PropertyOffset_9;

		// Token: 0x04013350 RID: 78672
		internal static int __PropertyOffset_10;

		// Token: 0x04013351 RID: 78673
		internal static int __PropertyOffset_11;

		// Token: 0x04013352 RID: 78674
		internal static int __PropertyOffset_12;

		// Token: 0x04013353 RID: 78675
		internal static int __PropertyOffset_13;

		// Token: 0x04013354 RID: 78676
		internal static int __PropertyOffset_14;

		// Token: 0x04013355 RID: 78677
		internal static int __PropertyOffset_15;

		// Token: 0x04013356 RID: 78678
		internal static int __PropertyOffset_16;

		// Token: 0x04013357 RID: 78679
		internal static int __PropertyOffset_17;

		// Token: 0x04013358 RID: 78680
		internal static int __PropertyOffset_18;

		// Token: 0x04013359 RID: 78681
		internal static int __PropertyOffset_19;

		// Token: 0x0401335A RID: 78682
		internal static int __PropertyOffset_20;

		// Token: 0x0401335B RID: 78683
		internal static int __PropertyOffset_21;

		// Token: 0x0401335C RID: 78684
		internal static int __PropertyOffset_22;

		// Token: 0x0401335D RID: 78685
		internal static int __PropertyOffset_23;

		// Token: 0x0401335E RID: 78686
		internal static int __PropertyOffset_24;

		// Token: 0x0401335F RID: 78687
		internal static int __PropertyOffset_25;

		// Token: 0x04013360 RID: 78688
		internal static int __PropertyOffset_26;

		// Token: 0x04013361 RID: 78689
		internal static int __PropertyOffset_27;

		// Token: 0x04013362 RID: 78690
		internal static int __PropertyOffset_28;

		// Token: 0x04013363 RID: 78691
		internal static int __PropertyOffset_29;

		// Token: 0x04013364 RID: 78692
		internal static int __PropertyOffset_30;

		// Token: 0x04013365 RID: 78693
		internal static int __PropertyOffset_31;

		// Token: 0x04013366 RID: 78694
		internal static int __PropertyOffset_32;

		// Token: 0x04013367 RID: 78695
		internal static int __PropertyOffset_33;

		// Token: 0x04013368 RID: 78696
		internal static int __PropertyOffset_34;

		// Token: 0x04013369 RID: 78697
		internal static int __PropertyOffset_35;

		// Token: 0x0401336A RID: 78698
		internal static int __PropertyOffset_36;

		// Token: 0x0401336B RID: 78699
		internal static int __PropertyOffset_37;

		// Token: 0x0401336C RID: 78700
		private FKuroCurveFloat _Sky;

		// Token: 0x0401336D RID: 78701
		internal static int __PropertyOffset_38;

		// Token: 0x0401336E RID: 78702
		private FKuroCurveFloat _StarTrails;

		// Token: 0x0401336F RID: 78703
		internal static int __PropertyOffset_39;

		// Token: 0x04013370 RID: 78704
		internal static int __PropertyOffset_40;

		// Token: 0x04013371 RID: 78705
		internal static int __PropertyOffset_41;

		// Token: 0x04013372 RID: 78706
		internal static int __PropertyOffset_42;

		// Token: 0x04013373 RID: 78707
		internal static int __PropertyOffset_43;

		// Token: 0x04013374 RID: 78708
		internal static int __PropertyOffset_44;

		// Token: 0x04013375 RID: 78709
		internal static int __PropertyOffset_45;

		// Token: 0x04013376 RID: 78710
		internal static int __PropertyOffset_46;

		// Token: 0x04013377 RID: 78711
		internal static int __PropertyOffset_47;

		// Token: 0x04013378 RID: 78712
		internal static int __PropertyOffset_48;

		// Token: 0x04013379 RID: 78713
		internal static int __PropertyOffset_49;

		// Token: 0x0401337A RID: 78714
		internal static int __PropertyOffset_50;

		// Token: 0x0401337B RID: 78715
		internal static int __PropertyOffset_51;

		// Token: 0x0401337C RID: 78716
		private static IntPtr __Timer_NativeFunctionPtr;

		// Token: 0x0401337D RID: 78717
		private static IntPtr __ChangeSky_NativeFunctionPtr;

		// Token: 0x0401337E RID: 78718
		private static IntPtr __Special_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x0401337F RID: 78719
		private static IntPtr __SunMoon_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x04013380 RID: 78720
		private static IntPtr __Single_POI_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x04013381 RID: 78721
		private static IntPtr __UpdatePerFourFrame_NativeFunctionPtr;

		// Token: 0x04013382 RID: 78722
		private static IntPtr __CreateDMI_NativeFunctionPtr;

		// Token: 0x04013383 RID: 78723
		private static IntPtr __Single_Cloud_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x04013384 RID: 78724
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013385 RID: 78725
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013386 RID: 78726
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013387 RID: 78727
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x0200A0F6 RID: 41206
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Timer_FunctionParams
		{
			// Token: 0x04031C32 RID: 203826
			[FieldOffset(0)]
			public float ElapsedTime;
		}

		// Token: 0x0200A0F7 RID: 41207
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __ChangeSky_FunctionParams
		{
			// Token: 0x04031C33 RID: 203827
			[FieldOffset(0)]
			public bool IsTick;
		}

		// Token: 0x0200A0F8 RID: 41208
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 248)]
		protected ref struct __Special_Parameters_Initial_FunctionParams
		{
			// Token: 0x04031C34 RID: 203828
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x04031C35 RID: 203829
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x04031C36 RID: 203830
			[FieldOffset(16)]
			public IntPtr Texture;

			// Token: 0x04031C37 RID: 203831
			[FieldOffset(24)]
			public FRotator POIRotation;

			// Token: 0x04031C38 RID: 203832
			[FieldOffset(36)]
			public float Intensity;

			// Token: 0x04031C39 RID: 203833
			[FieldOffset(40)]
			public FVector Scale;

			// Token: 0x04031C3A RID: 203834
			[FieldOffset(56)]
			public IntPtr NoiseTex;

			// Token: 0x04031C3B RID: 203835
			[FieldOffset(64)]
			public float NoiseSpeed;

			// Token: 0x04031C3C RID: 203836
			[FieldOffset(68)]
			public float NoiseStrength;

			// Token: 0x04031C3D RID: 203837
			[FieldOffset(72)]
			public float NoiseTilling;

			// Token: 0x04031C3E RID: 203838
			[FieldOffset(76)]
			public FLinearColor Color;
		}

		// Token: 0x0200A0F9 RID: 41209
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 216)]
		protected ref struct __SunMoon_Parameters_Initial_FunctionParams
		{
			// Token: 0x04031C3F RID: 203839
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x04031C40 RID: 203840
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x04031C41 RID: 203841
			[FieldOffset(16)]
			public IntPtr Texture;

			// Token: 0x04031C42 RID: 203842
			[FieldOffset(24)]
			public FRotator POIRotation;

			// Token: 0x04031C43 RID: 203843
			[FieldOffset(36)]
			public float Intensity;
		}

		// Token: 0x0200A0FA RID: 41210
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __Single_POI_Parameters_Initial_FunctionParams
		{
			// Token: 0x04031C44 RID: 203844
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x04031C45 RID: 203845
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x04031C46 RID: 203846
			[FieldOffset(16)]
			public IntPtr Texture;

			// Token: 0x04031C47 RID: 203847
			[FieldOffset(24)]
			public FRotator POIRotation;
		}

		// Token: 0x0200A0FB RID: 41211
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CreateDMI_FunctionParams
		{
			// Token: 0x04031C48 RID: 203848
			[FieldOffset(0)]
			public IntPtr Mesh;

			// Token: 0x04031C49 RID: 203849
			[FieldOffset(8)]
			public IntPtr Material;

			// Token: 0x04031C4A RID: 203850
			[FieldOffset(16)]
			public IntPtr DMI;
		}

		// Token: 0x0200A0FC RID: 41212
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __Single_Cloud_Parameters_Initial_FunctionParams
		{
			// Token: 0x04031C4B RID: 203851
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x04031C4C RID: 203852
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x04031C4D RID: 203853
			[FieldOffset(16)]
			public IntPtr Texture;

			// Token: 0x04031C4E RID: 203854
			[FieldOffset(24)]
			public bool UV1UV2_;

			// Token: 0x04031C4F RID: 203855
			[FieldOffset(28)]
			public float CloudSpeed;

			// Token: 0x04031C50 RID: 203856
			[FieldOffset(32)]
			public float Top_Rotation;

			// Token: 0x04031C51 RID: 203857
			[FieldOffset(36)]
			public float UVTiling;

			// Token: 0x04031C52 RID: 203858
			[FieldOffset(40)]
			public float NoiseStrength;

			// Token: 0x04031C53 RID: 203859
			[FieldOffset(44)]
			public float NoiseSpeed;

			// Token: 0x04031C54 RID: 203860
			[FieldOffset(48)]
			public float NoiseTilling;

			// Token: 0x04031C55 RID: 203861
			[FieldOffset(56)]
			public IntPtr NoiseTex;
		}

		// Token: 0x0200A0FD RID: 41213
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031C56 RID: 203862
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
