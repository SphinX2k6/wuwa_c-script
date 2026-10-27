using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.CherryBlossomsInteraction
{
	// Token: 0x02003DF1 RID: 15857
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/CherryBlossomsInteraction/BP_CherryBlossomsInteraction.BP_CherryBlossomsInteraction_C")]
	[UnrealStructLayout(1808, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1808)]
	public class BP_CherryBlossomsInteraction_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602791C RID: 162076 RVA: 0x00994FAD File Offset: 0x009931AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CherryBlossomsInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/CherryBlossomsInteraction/BP_CherryBlossomsInteraction.BP_CherryBlossomsInteraction_C");
			}
			return BP_CherryBlossomsInteraction_C._ClassPtr;
		}

		// Token: 0x0602791D RID: 162077 RVA: 0x00994FD4 File Offset: 0x009931D4
		public BP_CherryBlossomsInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_CherryBlossomsInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602791E RID: 162078 RVA: 0x00994FFC File Offset: 0x009931FC
		[NullableContext(1)]
		public BP_CherryBlossomsInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CherryBlossomsInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170058C7 RID: 22727
		// (get) Token: 0x0602791F RID: 162079 RVA: 0x0099502F File Offset: 0x0099322F
		// (set) Token: 0x06027920 RID: 162080 RVA: 0x00995043 File Offset: 0x00993243
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170058C8 RID: 22728
		// (get) Token: 0x06027921 RID: 162081 RVA: 0x00995058 File Offset: 0x00993258
		// (set) Token: 0x06027922 RID: 162082 RVA: 0x0099506C File Offset: 0x0099326C
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170058C9 RID: 22729
		// (get) Token: 0x06027923 RID: 162083 RVA: 0x00995081 File Offset: 0x00993281
		// (set) Token: 0x06027924 RID: 162084 RVA: 0x00995095 File Offset: 0x00993295
		public unsafe UStaticMeshComponent Sphere4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170058CA RID: 22730
		// (get) Token: 0x06027925 RID: 162085 RVA: 0x009950AA File Offset: 0x009932AA
		// (set) Token: 0x06027926 RID: 162086 RVA: 0x009950BE File Offset: 0x009932BE
		public unsafe UStaticMeshComponent Sphere3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170058CB RID: 22731
		// (get) Token: 0x06027927 RID: 162087 RVA: 0x009950D3 File Offset: 0x009932D3
		// (set) Token: 0x06027928 RID: 162088 RVA: 0x009950E7 File Offset: 0x009932E7
		public unsafe UStaticMeshComponent Sphere2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170058CC RID: 22732
		// (get) Token: 0x06027929 RID: 162089 RVA: 0x009950FC File Offset: 0x009932FC
		// (set) Token: 0x0602792A RID: 162090 RVA: 0x00995110 File Offset: 0x00993310
		public unsafe UStaticMeshComponent Sphere1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170058CD RID: 22733
		// (get) Token: 0x0602792B RID: 162091 RVA: 0x00995125 File Offset: 0x00993325
		// (set) Token: 0x0602792C RID: 162092 RVA: 0x00995139 File Offset: 0x00993339
		public unsafe UNiagaraComponent NS_FX_CherryBlossomsInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170058CE RID: 22734
		// (get) Token: 0x0602792D RID: 162093 RVA: 0x0099514E File Offset: 0x0099334E
		// (set) Token: 0x0602792E RID: 162094 RVA: 0x00995162 File Offset: 0x00993362
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170058CF RID: 22735
		// (get) Token: 0x0602792F RID: 162095 RVA: 0x00995177 File Offset: 0x00993377
		// (set) Token: 0x06027930 RID: 162096 RVA: 0x0099518B File Offset: 0x0099338B
		public unsafe FVector FieldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170058D0 RID: 22736
		// (get) Token: 0x06027931 RID: 162097 RVA: 0x009951A0 File Offset: 0x009933A0
		// (set) Token: 0x06027932 RID: 162098 RVA: 0x009951B0 File Offset: 0x009933B0
		public unsafe int Resolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170058D1 RID: 22737
		// (get) Token: 0x06027933 RID: 162099 RVA: 0x009951C1 File Offset: 0x009933C1
		// (set) Token: 0x06027934 RID: 162100 RVA: 0x009951D5 File Offset: 0x009933D5
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170058D2 RID: 22738
		// (get) Token: 0x06027935 RID: 162101 RVA: 0x009951EA File Offset: 0x009933EA
		// (set) Token: 0x06027936 RID: 162102 RVA: 0x009951FE File Offset: 0x009933FE
		public unsafe USkeletalMeshComponent Weapon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x170058D3 RID: 22739
		// (get) Token: 0x06027937 RID: 162103 RVA: 0x00995213 File Offset: 0x00993413
		// (set) Token: 0x06027938 RID: 162104 RVA: 0x00995227 File Offset: 0x00993427
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170058D4 RID: 22740
		// (get) Token: 0x06027939 RID: 162105 RVA: 0x0099523C File Offset: 0x0099343C
		// (set) Token: 0x0602793A RID: 162106 RVA: 0x00995250 File Offset: 0x00993450
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170058D5 RID: 22741
		// (get) Token: 0x0602793B RID: 162107 RVA: 0x00995265 File Offset: 0x00993465
		// (set) Token: 0x0602793C RID: 162108 RVA: 0x00995279 File Offset: 0x00993479
		public unsafe FVector WeaponVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170058D6 RID: 22742
		// (get) Token: 0x0602793D RID: 162109 RVA: 0x0099528E File Offset: 0x0099348E
		// (set) Token: 0x0602793E RID: 162110 RVA: 0x009952A2 File Offset: 0x009934A2
		public unsafe UMaterialParameterCollection Global_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x170058D7 RID: 22743
		// (get) Token: 0x0602793F RID: 162111 RVA: 0x009952B7 File Offset: 0x009934B7
		// (set) Token: 0x06027940 RID: 162112 RVA: 0x009952C7 File Offset: 0x009934C7
		public unsafe bool TriggerAll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x170058D8 RID: 22744
		// (get) Token: 0x06027941 RID: 162113 RVA: 0x009952D8 File Offset: 0x009934D8
		// (set) Token: 0x06027942 RID: 162114 RVA: 0x009952EC File Offset: 0x009934EC
		public unsafe FLinearColor GlobalWorldPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170058D9 RID: 22745
		// (get) Token: 0x06027943 RID: 162115 RVA: 0x00995301 File Offset: 0x00993501
		// (set) Token: 0x06027944 RID: 162116 RVA: 0x00995311 File Offset: 0x00993511
		public unsafe float PlayerSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170058DA RID: 22746
		// (get) Token: 0x06027945 RID: 162117 RVA: 0x00995322 File Offset: 0x00993522
		// (set) Token: 0x06027946 RID: 162118 RVA: 0x00995332 File Offset: 0x00993532
		public unsafe float WeaponSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170058DB RID: 22747
		// (get) Token: 0x06027947 RID: 162119 RVA: 0x00995343 File Offset: 0x00993543
		// (set) Token: 0x06027948 RID: 162120 RVA: 0x00995357 File Offset: 0x00993557
		public unsafe FVector DepthCapturePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170058DC RID: 22748
		// (get) Token: 0x06027949 RID: 162121 RVA: 0x0099536C File Offset: 0x0099356C
		// (set) Token: 0x0602794A RID: 162122 RVA: 0x00995380 File Offset: 0x00993580
		public unsafe UTexture DepthTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x170058DD RID: 22749
		// (get) Token: 0x0602794B RID: 162123 RVA: 0x00995395 File Offset: 0x00993595
		// (set) Token: 0x0602794C RID: 162124 RVA: 0x009953A5 File Offset: 0x009935A5
		public unsafe bool UseSamplePoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x170058DE RID: 22750
		// (get) Token: 0x0602794D RID: 162125 RVA: 0x009953B6 File Offset: 0x009935B6
		// (set) Token: 0x0602794E RID: 162126 RVA: 0x009953C6 File Offset: 0x009935C6
		public unsafe int LeavesIDStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170058DF RID: 22751
		// (get) Token: 0x0602794F RID: 162127 RVA: 0x009953D7 File Offset: 0x009935D7
		// (set) Token: 0x06027950 RID: 162128 RVA: 0x009953E7 File Offset: 0x009935E7
		public unsafe int LeavesIDEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170058E0 RID: 22752
		// (get) Token: 0x06027951 RID: 162129 RVA: 0x009953F8 File Offset: 0x009935F8
		// (set) Token: 0x06027952 RID: 162130 RVA: 0x00995408 File Offset: 0x00993608
		public unsafe int LeavesNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170058E1 RID: 22753
		// (get) Token: 0x06027953 RID: 162131 RVA: 0x00995419 File Offset: 0x00993619
		// (set) Token: 0x06027954 RID: 162132 RVA: 0x00995429 File Offset: 0x00993629
		public unsafe float BoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170058E2 RID: 22754
		// (get) Token: 0x06027955 RID: 162133 RVA: 0x0099543A File Offset: 0x0099363A
		// (set) Token: 0x06027956 RID: 162134 RVA: 0x0099544A File Offset: 0x0099364A
		public unsafe float LeavesScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170058E3 RID: 22755
		// (get) Token: 0x06027957 RID: 162135 RVA: 0x0099545B File Offset: 0x0099365B
		// (set) Token: 0x06027958 RID: 162136 RVA: 0x0099546B File Offset: 0x0099366B
		public unsafe int LUTIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170058E4 RID: 22756
		// (get) Token: 0x06027959 RID: 162137 RVA: 0x0099547C File Offset: 0x0099367C
		// (set) Token: 0x0602795A RID: 162138 RVA: 0x0099548C File Offset: 0x0099368C
		public unsafe float LeavesRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170058E5 RID: 22757
		// (get) Token: 0x0602795B RID: 162139 RVA: 0x0099549D File Offset: 0x0099369D
		// (set) Token: 0x0602795C RID: 162140 RVA: 0x009954AD File Offset: 0x009936AD
		public unsafe float LeavesAO
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170058E6 RID: 22758
		// (get) Token: 0x0602795D RID: 162141 RVA: 0x009954BE File Offset: 0x009936BE
		// (set) Token: 0x0602795E RID: 162142 RVA: 0x009954CE File Offset: 0x009936CE
		public unsafe float LutProbabilityPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170058E7 RID: 22759
		// (get) Token: 0x0602795F RID: 162143 RVA: 0x009954DF File Offset: 0x009936DF
		// (set) Token: 0x06027960 RID: 162144 RVA: 0x009954F3 File Offset: 0x009936F3
		public unsafe UTexture LeavesMaskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x170058E8 RID: 22760
		// (get) Token: 0x06027961 RID: 162145 RVA: 0x00995508 File Offset: 0x00993708
		// (set) Token: 0x06027962 RID: 162146 RVA: 0x00995518 File Offset: 0x00993718
		public unsafe bool UseLUT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x170058E9 RID: 22761
		// (get) Token: 0x06027963 RID: 162147 RVA: 0x00995529 File Offset: 0x00993729
		// (set) Token: 0x06027964 RID: 162148 RVA: 0x00995539 File Offset: 0x00993739
		public unsafe float OffsetDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x170058EA RID: 22762
		// (get) Token: 0x06027965 RID: 162149 RVA: 0x0099554C File Offset: 0x0099374C
		// (set) Token: 0x06027966 RID: 162150 RVA: 0x00995585 File Offset: 0x00993785
		[Nullable(1)]
		public TArray<FVector4> SamplePointsArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._SamplePointsArray) == null)
				{
					result = (this._SamplePointsArray = new TArray<FVector4>(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_36, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SamplePointsArray.CopyAssign(value);
			}
		}

		// Token: 0x170058EB RID: 22763
		// (get) Token: 0x06027967 RID: 162151 RVA: 0x00995593 File Offset: 0x00993793
		// (set) Token: 0x06027968 RID: 162152 RVA: 0x009955A3 File Offset: 0x009937A3
		public unsafe float CullingHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x170058EC RID: 22764
		// (get) Token: 0x06027969 RID: 162153 RVA: 0x009955B4 File Offset: 0x009937B4
		// (set) Token: 0x0602796A RID: 162154 RVA: 0x009955C8 File Offset: 0x009937C8
		public unsafe FVector RuntimeDepthCapturePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x170058ED RID: 22765
		// (get) Token: 0x0602796B RID: 162155 RVA: 0x009955DD File Offset: 0x009937DD
		// (set) Token: 0x0602796C RID: 162156 RVA: 0x009955F1 File Offset: 0x009937F1
		public unsafe UTexture RuntimeDepthTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x170058EE RID: 22766
		// (get) Token: 0x0602796D RID: 162157 RVA: 0x00995606 File Offset: 0x00993806
		// (set) Token: 0x0602796E RID: 162158 RVA: 0x0099561A File Offset: 0x0099381A
		public unsafe FVector RuntimeDepthCaptureBoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x170058EF RID: 22767
		// (get) Token: 0x0602796F RID: 162159 RVA: 0x0099562F File Offset: 0x0099382F
		// (set) Token: 0x06027970 RID: 162160 RVA: 0x0099563F File Offset: 0x0099383F
		public unsafe bool UseRuntimeCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x170058F0 RID: 22768
		// (get) Token: 0x06027971 RID: 162161 RVA: 0x00995650 File Offset: 0x00993850
		// (set) Token: 0x06027972 RID: 162162 RVA: 0x00995664 File Offset: 0x00993864
		public unsafe UHoudiniPointCache HPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_42);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_42, value);
			}
		}

		// Token: 0x170058F1 RID: 22769
		// (get) Token: 0x06027973 RID: 162163 RVA: 0x00995679 File Offset: 0x00993879
		// (set) Token: 0x06027974 RID: 162164 RVA: 0x00995689 File Offset: 0x00993889
		public unsafe bool InTheBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x170058F2 RID: 22770
		// (get) Token: 0x06027975 RID: 162165 RVA: 0x0099569A File Offset: 0x0099389A
		// (set) Token: 0x06027976 RID: 162166 RVA: 0x009956AA File Offset: 0x009938AA
		public unsafe bool IsResetParam
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x170058F3 RID: 22771
		// (get) Token: 0x06027977 RID: 162167 RVA: 0x009956BB File Offset: 0x009938BB
		// (set) Token: 0x06027978 RID: 162168 RVA: 0x009956CF File Offset: 0x009938CF
		public unsafe FColor ColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x170058F4 RID: 22772
		// (get) Token: 0x06027979 RID: 162169 RVA: 0x009956E4 File Offset: 0x009938E4
		// (set) Token: 0x0602797A RID: 162170 RVA: 0x009956F4 File Offset: 0x009938F4
		public unsafe float DetectionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x170058F5 RID: 22773
		// (get) Token: 0x0602797B RID: 162171 RVA: 0x00995705 File Offset: 0x00993905
		// (set) Token: 0x0602797C RID: 162172 RVA: 0x00995715 File Offset: 0x00993915
		public unsafe int MapNumXY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CherryBlossomsInteraction_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x170058F6 RID: 22774
		// (get) Token: 0x0602797D RID: 162173 RVA: 0x00995726 File Offset: 0x00993926
		// (set) Token: 0x0602797E RID: 162174 RVA: 0x0099573A File Offset: 0x0099393A
		public unsafe UMaterialInterface LeavesMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_48);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_48, value);
			}
		}

		// Token: 0x170058F7 RID: 22775
		// (get) Token: 0x0602797F RID: 162175 RVA: 0x0099574F File Offset: 0x0099394F
		// (set) Token: 0x06027980 RID: 162176 RVA: 0x00995763 File Offset: 0x00993963
		public unsafe UTexture LeavesIDBaseColorMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_49);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_49, value);
			}
		}

		// Token: 0x170058F8 RID: 22776
		// (get) Token: 0x06027981 RID: 162177 RVA: 0x00995778 File Offset: 0x00993978
		// (set) Token: 0x06027982 RID: 162178 RVA: 0x0099578C File Offset: 0x0099398C
		public unsafe UTexture LeavesIDNormalMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_50);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CherryBlossomsInteraction_C.__PropertyOffset_50, value);
			}
		}

		// Token: 0x06027983 RID: 162179 RVA: 0x009957A1 File Offset: 0x009939A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetHPCParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__SetHPCParam_NativeFunctionPtr, null);
		}

		// Token: 0x06027984 RID: 162180 RVA: 0x009957B5 File Offset: 0x009939B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetMaterialParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__SetMaterialParam_NativeFunctionPtr, null);
		}

		// Token: 0x06027985 RID: 162181 RVA: 0x009957C9 File Offset: 0x009939C9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ResetParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__ResetParam_NativeFunctionPtr, null);
		}

		// Token: 0x06027986 RID: 162182 RVA: 0x009957DD File Offset: 0x009939DD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetDepthCameraPos()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__SetDepthCameraPos_NativeFunctionPtr, null);
		}

		// Token: 0x06027987 RID: 162183 RVA: 0x009957F4 File Offset: 0x009939F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetInTheBox(FVector pos, ref bool IntheBox)
		{
			BP_CherryBlossomsInteraction_C.__GetInTheBox_FunctionParams* ptr = stackalloc BP_CherryBlossomsInteraction_C.__GetInTheBox_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_CherryBlossomsInteraction_C.__GetInTheBox_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CherryBlossomsInteraction_C.__GetInTheBox_NativeFunctionPtr, (void*)ptr, 1);
			ptr->pos = pos;
			ptr->IntheBox = IntheBox;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__GetInTheBox_NativeFunctionPtr, (void*)ptr);
			IntheBox = ptr->IntheBox;
		}

		// Token: 0x06027988 RID: 162184 RVA: 0x0099584A File Offset: 0x00993A4A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisplaySamplePoint()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__DisplaySamplePoint_NativeFunctionPtr, null);
		}

		// Token: 0x06027989 RID: 162185 RVA: 0x0099585E File Offset: 0x00993A5E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetLeavesParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__SetLeavesParameters_NativeFunctionPtr, null);
		}

		// Token: 0x0602798A RID: 162186 RVA: 0x00995872 File Offset: 0x00993A72
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__Debug_NativeFunctionPtr, null);
		}

		// Token: 0x0602798B RID: 162187 RVA: 0x00995888 File Offset: 0x00993A88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Choose_Available_Point(FVectorDouble CollisionPoint, FVectorDouble WeaponPoint, BP_SceneBattleInteract_C ConfigDA, ref FVectorDouble AvailblePoint)
		{
			BP_CherryBlossomsInteraction_C.__Choose_Available_Point_FunctionParams* ptr = stackalloc BP_CherryBlossomsInteraction_C.__Choose_Available_Point_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_CherryBlossomsInteraction_C.__Choose_Available_Point_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CherryBlossomsInteraction_C.__Choose_Available_Point_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CollisionPoint = CollisionPoint;
			ptr->WeaponPoint = WeaponPoint;
			ptr->ConfigDA = ((ConfigDA != null) ? ConfigDA.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__Choose_Available_Point_NativeFunctionPtr, (void*)ptr);
			AvailblePoint = ptr->AvailblePoint;
		}

		// Token: 0x0602798C RID: 162188 RVA: 0x00995905 File Offset: 0x00993B05
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void WeaponData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__WeaponData_NativeFunctionPtr, null);
		}

		// Token: 0x0602798D RID: 162189 RVA: 0x0099591C File Offset: 0x00993B1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateParam(float dt)
		{
			BP_CherryBlossomsInteraction_C.__UpdateParam_FunctionParams* ptr = stackalloc BP_CherryBlossomsInteraction_C.__UpdateParam_FunctionParams[(UIntPtr)335] + 15L / (long)sizeof(BP_CherryBlossomsInteraction_C.__UpdateParam_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CherryBlossomsInteraction_C.__UpdateParam_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__UpdateParam_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602798E RID: 162190 RVA: 0x00995965 File Offset: 0x00993B65
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__InitParam_NativeFunctionPtr, null);
		}

		// Token: 0x0602798F RID: 162191 RVA: 0x00995979 File Offset: 0x00993B79
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027990 RID: 162192 RVA: 0x0099598D File Offset: 0x00993B8D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027991 RID: 162193 RVA: 0x009959A2 File Offset: 0x00993BA2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06027992 RID: 162194 RVA: 0x009959B6 File Offset: 0x00993BB6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027993 RID: 162195 RVA: 0x009959CC File Offset: 0x00993BCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_CherryBlossomsInteraction_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_CherryBlossomsInteraction_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_CherryBlossomsInteraction_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CherryBlossomsInteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027994 RID: 162196 RVA: 0x00995A2F File Offset: 0x00993C2F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__CustomTick_NativeFunctionPtr, null);
		}

		// Token: 0x06027995 RID: 162197 RVA: 0x00995A44 File Offset: 0x00993C44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CherryBlossomsInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CherryBlossomsInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CherryBlossomsInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CherryBlossomsInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027996 RID: 162198 RVA: 0x00995A8C File Offset: 0x00993C8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CherryBlossomsInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CherryBlossomsInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CherryBlossomsInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CherryBlossomsInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027997 RID: 162199 RVA: 0x00995AD4 File Offset: 0x00993CD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CustomEvent(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_CherryBlossomsInteraction_C.__CustomEvent_FunctionParams* ptr = stackalloc BP_CherryBlossomsInteraction_C.__CustomEvent_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_CherryBlossomsInteraction_C.__CustomEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CherryBlossomsInteraction_C.__CustomEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CherryBlossomsInteraction_C.__CustomEvent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027998 RID: 162200 RVA: 0x00995B37 File Offset: 0x00993D37
		protected BP_CherryBlossomsInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014023 RID: 81955
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/CherryBlossomsInteraction/BP_CherryBlossomsInteraction.BP_CherryBlossomsInteraction_C";

		// Token: 0x04014024 RID: 81956
		private static IntPtr _ClassPtr;

		// Token: 0x04014025 RID: 81957
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014026 RID: 81958
		internal static int __PropertyOffset_1;

		// Token: 0x04014027 RID: 81959
		internal static int __PropertyOffset_2;

		// Token: 0x04014028 RID: 81960
		internal static int __PropertyOffset_3;

		// Token: 0x04014029 RID: 81961
		internal static int __PropertyOffset_4;

		// Token: 0x0401402A RID: 81962
		internal static int __PropertyOffset_5;

		// Token: 0x0401402B RID: 81963
		internal static int __PropertyOffset_6;

		// Token: 0x0401402C RID: 81964
		internal static int __PropertyOffset_7;

		// Token: 0x0401402D RID: 81965
		internal static int __PropertyOffset_8;

		// Token: 0x0401402E RID: 81966
		internal static int __PropertyOffset_9;

		// Token: 0x0401402F RID: 81967
		internal static int __PropertyOffset_10;

		// Token: 0x04014030 RID: 81968
		internal static int __PropertyOffset_11;

		// Token: 0x04014031 RID: 81969
		internal static int __PropertyOffset_12;

		// Token: 0x04014032 RID: 81970
		internal static int __PropertyOffset_13;

		// Token: 0x04014033 RID: 81971
		internal static int __PropertyOffset_14;

		// Token: 0x04014034 RID: 81972
		internal static int __PropertyOffset_15;

		// Token: 0x04014035 RID: 81973
		internal static int __PropertyOffset_16;

		// Token: 0x04014036 RID: 81974
		internal static int __PropertyOffset_17;

		// Token: 0x04014037 RID: 81975
		internal static int __PropertyOffset_18;

		// Token: 0x04014038 RID: 81976
		internal static int __PropertyOffset_19;

		// Token: 0x04014039 RID: 81977
		internal static int __PropertyOffset_20;

		// Token: 0x0401403A RID: 81978
		internal static int __PropertyOffset_21;

		// Token: 0x0401403B RID: 81979
		internal static int __PropertyOffset_22;

		// Token: 0x0401403C RID: 81980
		internal static int __PropertyOffset_23;

		// Token: 0x0401403D RID: 81981
		internal static int __PropertyOffset_24;

		// Token: 0x0401403E RID: 81982
		internal static int __PropertyOffset_25;

		// Token: 0x0401403F RID: 81983
		internal static int __PropertyOffset_26;

		// Token: 0x04014040 RID: 81984
		internal static int __PropertyOffset_27;

		// Token: 0x04014041 RID: 81985
		internal static int __PropertyOffset_28;

		// Token: 0x04014042 RID: 81986
		internal static int __PropertyOffset_29;

		// Token: 0x04014043 RID: 81987
		internal static int __PropertyOffset_30;

		// Token: 0x04014044 RID: 81988
		internal static int __PropertyOffset_31;

		// Token: 0x04014045 RID: 81989
		internal static int __PropertyOffset_32;

		// Token: 0x04014046 RID: 81990
		internal static int __PropertyOffset_33;

		// Token: 0x04014047 RID: 81991
		internal static int __PropertyOffset_34;

		// Token: 0x04014048 RID: 81992
		internal static int __PropertyOffset_35;

		// Token: 0x04014049 RID: 81993
		internal static int __PropertyOffset_36;

		// Token: 0x0401404A RID: 81994
		private TArray<FVector4> _SamplePointsArray;

		// Token: 0x0401404B RID: 81995
		internal static int __PropertyOffset_37;

		// Token: 0x0401404C RID: 81996
		internal static int __PropertyOffset_38;

		// Token: 0x0401404D RID: 81997
		internal static int __PropertyOffset_39;

		// Token: 0x0401404E RID: 81998
		internal static int __PropertyOffset_40;

		// Token: 0x0401404F RID: 81999
		internal static int __PropertyOffset_41;

		// Token: 0x04014050 RID: 82000
		internal static int __PropertyOffset_42;

		// Token: 0x04014051 RID: 82001
		internal static int __PropertyOffset_43;

		// Token: 0x04014052 RID: 82002
		internal static int __PropertyOffset_44;

		// Token: 0x04014053 RID: 82003
		internal static int __PropertyOffset_45;

		// Token: 0x04014054 RID: 82004
		internal static int __PropertyOffset_46;

		// Token: 0x04014055 RID: 82005
		internal static int __PropertyOffset_47;

		// Token: 0x04014056 RID: 82006
		internal static int __PropertyOffset_48;

		// Token: 0x04014057 RID: 82007
		internal static int __PropertyOffset_49;

		// Token: 0x04014058 RID: 82008
		internal static int __PropertyOffset_50;

		// Token: 0x04014059 RID: 82009
		private static IntPtr __SetHPCParam_NativeFunctionPtr;

		// Token: 0x0401405A RID: 82010
		private static IntPtr __SetMaterialParam_NativeFunctionPtr;

		// Token: 0x0401405B RID: 82011
		private static IntPtr __ResetParam_NativeFunctionPtr;

		// Token: 0x0401405C RID: 82012
		private static IntPtr __SetDepthCameraPos_NativeFunctionPtr;

		// Token: 0x0401405D RID: 82013
		private static IntPtr __GetInTheBox_NativeFunctionPtr;

		// Token: 0x0401405E RID: 82014
		private static IntPtr __DisplaySamplePoint_NativeFunctionPtr;

		// Token: 0x0401405F RID: 82015
		private static IntPtr __SetLeavesParameters_NativeFunctionPtr;

		// Token: 0x04014060 RID: 82016
		private static IntPtr __Debug_NativeFunctionPtr;

		// Token: 0x04014061 RID: 82017
		private static IntPtr __Choose_Available_Point_NativeFunctionPtr;

		// Token: 0x04014062 RID: 82018
		private static IntPtr __WeaponData_NativeFunctionPtr;

		// Token: 0x04014063 RID: 82019
		private static IntPtr __UpdateParam_NativeFunctionPtr;

		// Token: 0x04014064 RID: 82020
		private static IntPtr __InitParam_NativeFunctionPtr;

		// Token: 0x04014065 RID: 82021
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04014066 RID: 82022
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04014067 RID: 82023
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x04014068 RID: 82024
		private static IntPtr __CustomTick_NativeFunctionPtr;

		// Token: 0x04014069 RID: 82025
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401406A RID: 82026
		private static IntPtr __CustomEvent_NativeFunctionPtr;

		// Token: 0x0200A24C RID: 41548
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetInTheBox_FunctionParams
		{
			// Token: 0x04031EDD RID: 204509
			[FieldOffset(0)]
			public FVector pos;

			// Token: 0x04031EDE RID: 204510
			[FieldOffset(12)]
			public bool IntheBox;
		}

		// Token: 0x0200A24D RID: 41549
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Choose_Available_Point_FunctionParams
		{
			// Token: 0x04031EDF RID: 204511
			[FieldOffset(0)]
			public FVectorDouble CollisionPoint;

			// Token: 0x04031EE0 RID: 204512
			[FieldOffset(24)]
			public FVectorDouble WeaponPoint;

			// Token: 0x04031EE1 RID: 204513
			[FieldOffset(48)]
			public IntPtr ConfigDA;

			// Token: 0x04031EE2 RID: 204514
			[FieldOffset(56)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x0200A24E RID: 41550
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 320)]
		protected ref struct __UpdateParam_FunctionParams
		{
			// Token: 0x04031EE3 RID: 204515
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x0200A24F RID: 41551
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031EE4 RID: 204516
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031EE5 RID: 204517
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031EE6 RID: 204518
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x0200A250 RID: 41552
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031EE7 RID: 204519
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A251 RID: 41553
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CustomEvent_FunctionParams
		{
			// Token: 0x04031EE8 RID: 204520
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031EE9 RID: 204521
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031EEA RID: 204522
			[FieldOffset(32)]
			public int Id;
		}
	}
}
