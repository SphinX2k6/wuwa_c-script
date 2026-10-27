using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BPWindBell
{
	// Token: 0x02003CCE RID: 15566
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BPWindBell/BP_Windbell_35_type2.BP_Windbell_35_type2_C")]
	[UnrealStructLayout(1760, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1756)]
	public class BP_Windbell_35_type2_C : AKuroPhysicActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024E0C RID: 151052 RVA: 0x0094ABD0 File Offset: 0x00948DD0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Windbell_35_type2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/BPWindBell/BP_Windbell_35_type2.BP_Windbell_35_type2_C");
			}
			return BP_Windbell_35_type2_C._ClassPtr;
		}

		// Token: 0x06024E0D RID: 151053 RVA: 0x0094ABF4 File Offset: 0x00948DF4
		public BP_Windbell_35_type2_C() : this(BuiltinUtils.AllocNativeUObject(BP_Windbell_35_type2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024E0E RID: 151054 RVA: 0x0094AC1C File Offset: 0x00948E1C
		[NullableContext(1)]
		public BP_Windbell_35_type2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Windbell_35_type2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700499D RID: 18845
		// (get) Token: 0x06024E0F RID: 151055 RVA: 0x0094AC4F File Offset: 0x00948E4F
		// (set) Token: 0x06024E10 RID: 151056 RVA: 0x0094AC63 File Offset: 0x00948E63
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700499E RID: 18846
		// (get) Token: 0x06024E11 RID: 151057 RVA: 0x0094AC78 File Offset: 0x00948E78
		// (set) Token: 0x06024E12 RID: 151058 RVA: 0x0094AC8C File Offset: 0x00948E8C
		public unsafe UStaticMeshComponent Box_main
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700499F RID: 18847
		// (get) Token: 0x06024E13 RID: 151059 RVA: 0x0094ACA1 File Offset: 0x00948EA1
		// (set) Token: 0x06024E14 RID: 151060 RVA: 0x0094ACB5 File Offset: 0x00948EB5
		public unsafe UStaticMeshComponent SM_windbell_t2_box_9
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170049A0 RID: 18848
		// (get) Token: 0x06024E15 RID: 151061 RVA: 0x0094ACCA File Offset: 0x00948ECA
		// (set) Token: 0x06024E16 RID: 151062 RVA: 0x0094ACDE File Offset: 0x00948EDE
		public unsafe UStaticMeshComponent SM_windbell_t2_box_8
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170049A1 RID: 18849
		// (get) Token: 0x06024E17 RID: 151063 RVA: 0x0094ACF3 File Offset: 0x00948EF3
		// (set) Token: 0x06024E18 RID: 151064 RVA: 0x0094AD07 File Offset: 0x00948F07
		public unsafe UStaticMeshComponent SM_windbell_t2_box_7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170049A2 RID: 18850
		// (get) Token: 0x06024E19 RID: 151065 RVA: 0x0094AD1C File Offset: 0x00948F1C
		// (set) Token: 0x06024E1A RID: 151066 RVA: 0x0094AD30 File Offset: 0x00948F30
		public unsafe UStaticMeshComponent SM_windbell_t2_box_6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170049A3 RID: 18851
		// (get) Token: 0x06024E1B RID: 151067 RVA: 0x0094AD45 File Offset: 0x00948F45
		// (set) Token: 0x06024E1C RID: 151068 RVA: 0x0094AD59 File Offset: 0x00948F59
		public unsafe UStaticMeshComponent SM_windbell_t2_box_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170049A4 RID: 18852
		// (get) Token: 0x06024E1D RID: 151069 RVA: 0x0094AD6E File Offset: 0x00948F6E
		// (set) Token: 0x06024E1E RID: 151070 RVA: 0x0094AD82 File Offset: 0x00948F82
		public unsafe UStaticMeshComponent SM_windbell_t2_box_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170049A5 RID: 18853
		// (get) Token: 0x06024E1F RID: 151071 RVA: 0x0094AD97 File Offset: 0x00948F97
		// (set) Token: 0x06024E20 RID: 151072 RVA: 0x0094ADAB File Offset: 0x00948FAB
		public unsafe UStaticMeshComponent SM_windbell_t2_box_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170049A6 RID: 18854
		// (get) Token: 0x06024E21 RID: 151073 RVA: 0x0094ADC0 File Offset: 0x00948FC0
		// (set) Token: 0x06024E22 RID: 151074 RVA: 0x0094ADD4 File Offset: 0x00948FD4
		public unsafe UStaticMeshComponent SM_windbell_t2_box_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x170049A7 RID: 18855
		// (get) Token: 0x06024E23 RID: 151075 RVA: 0x0094ADE9 File Offset: 0x00948FE9
		// (set) Token: 0x06024E24 RID: 151076 RVA: 0x0094ADFD File Offset: 0x00948FFD
		public unsafe UStaticMeshComponent SM_windbell_t2_box_5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170049A8 RID: 18856
		// (get) Token: 0x06024E25 RID: 151077 RVA: 0x0094AE12 File Offset: 0x00949012
		// (set) Token: 0x06024E26 RID: 151078 RVA: 0x0094AE26 File Offset: 0x00949026
		public unsafe UStaticMeshComponent Box_main2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x170049A9 RID: 18857
		// (get) Token: 0x06024E27 RID: 151079 RVA: 0x0094AE3B File Offset: 0x0094903B
		// (set) Token: 0x06024E28 RID: 151080 RVA: 0x0094AE4F File Offset: 0x0094904F
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170049AA RID: 18858
		// (get) Token: 0x06024E29 RID: 151081 RVA: 0x0094AE64 File Offset: 0x00949064
		// (set) Token: 0x06024E2A RID: 151082 RVA: 0x0094AE78 File Offset: 0x00949078
		public unsafe UCableComponent Cable_main
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170049AB RID: 18859
		// (get) Token: 0x06024E2B RID: 151083 RVA: 0x0094AE8D File Offset: 0x0094908D
		// (set) Token: 0x06024E2C RID: 151084 RVA: 0x0094AEA1 File Offset: 0x009490A1
		public unsafe UPhysicsConstraintComponent PhysicsConstraint_main
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x170049AC RID: 18860
		// (get) Token: 0x06024E2D RID: 151085 RVA: 0x0094AEB6 File Offset: 0x009490B6
		// (set) Token: 0x06024E2E RID: 151086 RVA: 0x0094AECA File Offset: 0x009490CA
		public unsafe UCableComponent Cable5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x170049AD RID: 18861
		// (get) Token: 0x06024E2F RID: 151087 RVA: 0x0094AEDF File Offset: 0x009490DF
		// (set) Token: 0x06024E30 RID: 151088 RVA: 0x0094AEF3 File Offset: 0x009490F3
		public unsafe UCableComponent Cable8
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x170049AE RID: 18862
		// (get) Token: 0x06024E31 RID: 151089 RVA: 0x0094AF08 File Offset: 0x00949108
		// (set) Token: 0x06024E32 RID: 151090 RVA: 0x0094AF1C File Offset: 0x0094911C
		public unsafe UCableComponent Cable7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x170049AF RID: 18863
		// (get) Token: 0x06024E33 RID: 151091 RVA: 0x0094AF31 File Offset: 0x00949131
		// (set) Token: 0x06024E34 RID: 151092 RVA: 0x0094AF45 File Offset: 0x00949145
		public unsafe UCableComponent Cable6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x170049B0 RID: 18864
		// (get) Token: 0x06024E35 RID: 151093 RVA: 0x0094AF5A File Offset: 0x0094915A
		// (set) Token: 0x06024E36 RID: 151094 RVA: 0x0094AF6E File Offset: 0x0094916E
		public unsafe UCableComponent Cable4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x170049B1 RID: 18865
		// (get) Token: 0x06024E37 RID: 151095 RVA: 0x0094AF83 File Offset: 0x00949183
		// (set) Token: 0x06024E38 RID: 151096 RVA: 0x0094AF97 File Offset: 0x00949197
		public unsafe UCableComponent Cable3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x170049B2 RID: 18866
		// (get) Token: 0x06024E39 RID: 151097 RVA: 0x0094AFAC File Offset: 0x009491AC
		// (set) Token: 0x06024E3A RID: 151098 RVA: 0x0094AFC0 File Offset: 0x009491C0
		public unsafe UCableComponent Cable2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x170049B3 RID: 18867
		// (get) Token: 0x06024E3B RID: 151099 RVA: 0x0094AFD5 File Offset: 0x009491D5
		// (set) Token: 0x06024E3C RID: 151100 RVA: 0x0094AFE9 File Offset: 0x009491E9
		public unsafe UCableComponent Cable1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x170049B4 RID: 18868
		// (get) Token: 0x06024E3D RID: 151101 RVA: 0x0094AFFE File Offset: 0x009491FE
		// (set) Token: 0x06024E3E RID: 151102 RVA: 0x0094B012 File Offset: 0x00949212
		public unsafe UPhysicsConstraintComponent PhysicsConstraint9
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x170049B5 RID: 18869
		// (get) Token: 0x06024E3F RID: 151103 RVA: 0x0094B027 File Offset: 0x00949227
		// (set) Token: 0x06024E40 RID: 151104 RVA: 0x0094B03B File Offset: 0x0094923B
		public unsafe UPhysicsConstraintComponent PhysicsConstraint8
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x170049B6 RID: 18870
		// (get) Token: 0x06024E41 RID: 151105 RVA: 0x0094B050 File Offset: 0x00949250
		// (set) Token: 0x06024E42 RID: 151106 RVA: 0x0094B064 File Offset: 0x00949264
		public unsafe UPhysicsConstraintComponent PhysicsConstraint7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x170049B7 RID: 18871
		// (get) Token: 0x06024E43 RID: 151107 RVA: 0x0094B079 File Offset: 0x00949279
		// (set) Token: 0x06024E44 RID: 151108 RVA: 0x0094B08D File Offset: 0x0094928D
		public unsafe UPhysicsConstraintComponent PhysicsConstraint6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x170049B8 RID: 18872
		// (get) Token: 0x06024E45 RID: 151109 RVA: 0x0094B0A2 File Offset: 0x009492A2
		// (set) Token: 0x06024E46 RID: 151110 RVA: 0x0094B0B6 File Offset: 0x009492B6
		public unsafe UBoxComponent Box1_Bend
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x170049B9 RID: 18873
		// (get) Token: 0x06024E47 RID: 151111 RVA: 0x0094B0CB File Offset: 0x009492CB
		// (set) Token: 0x06024E48 RID: 151112 RVA: 0x0094B0DF File Offset: 0x009492DF
		public unsafe UPhysicsConstraintComponent PhysicsConstraint
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x170049BA RID: 18874
		// (get) Token: 0x06024E49 RID: 151113 RVA: 0x0094B0F4 File Offset: 0x009492F4
		// (set) Token: 0x06024E4A RID: 151114 RVA: 0x0094B108 File Offset: 0x00949308
		public unsafe UPhysicsConstraintComponent PhysicsConstraint5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x170049BB RID: 18875
		// (get) Token: 0x06024E4B RID: 151115 RVA: 0x0094B11D File Offset: 0x0094931D
		// (set) Token: 0x06024E4C RID: 151116 RVA: 0x0094B131 File Offset: 0x00949331
		public unsafe UPhysicsConstraintComponent PhysicsConstraint4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x170049BC RID: 18876
		// (get) Token: 0x06024E4D RID: 151117 RVA: 0x0094B146 File Offset: 0x00949346
		// (set) Token: 0x06024E4E RID: 151118 RVA: 0x0094B15A File Offset: 0x0094935A
		public unsafe UPhysicsConstraintComponent PhysicsConstraint3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x170049BD RID: 18877
		// (get) Token: 0x06024E4F RID: 151119 RVA: 0x0094B16F File Offset: 0x0094936F
		// (set) Token: 0x06024E50 RID: 151120 RVA: 0x0094B183 File Offset: 0x00949383
		public unsafe UPhysicsConstraintComponent PhysicsConstraint2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Windbell_35_type2_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x170049BE RID: 18878
		// (get) Token: 0x06024E51 RID: 151121 RVA: 0x0094B198 File Offset: 0x00949398
		// (set) Token: 0x06024E52 RID: 151122 RVA: 0x0094B1D1 File Offset: 0x009493D1
		[Nullable(1)]
		public TArray<UCableComponent> CablesArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UCableComponent> result;
				if ((result = this._CablesArr) == null)
				{
					result = (this._CablesArr = new TArray<UCableComponent>(base.NativePtr + (IntPtr)BP_Windbell_35_type2_C.__PropertyOffset_34, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CablesArr.CopyAssign(value);
			}
		}

		// Token: 0x170049BF RID: 18879
		// (get) Token: 0x06024E53 RID: 151123 RVA: 0x0094B1DF File Offset: 0x009493DF
		// (set) Token: 0x06024E54 RID: 151124 RVA: 0x0094B1EF File Offset: 0x009493EF
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Windbell_35_type2_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Windbell_35_type2_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049C0 RID: 18880
		// (get) Token: 0x06024E55 RID: 151125 RVA: 0x0094B200 File Offset: 0x00949400
		// (set) Token: 0x06024E56 RID: 151126 RVA: 0x0094B210 File Offset: 0x00949410
		public unsafe bool playerInRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Windbell_35_type2_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Windbell_35_type2_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049C1 RID: 18881
		// (get) Token: 0x06024E57 RID: 151127 RVA: 0x0094B221 File Offset: 0x00949421
		// (set) Token: 0x06024E58 RID: 151128 RVA: 0x0094B231 File Offset: 0x00949431
		public unsafe bool alreadySimulate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Windbell_35_type2_C.__PropertyOffset_37) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Windbell_35_type2_C.__PropertyOffset_37) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049C2 RID: 18882
		// (get) Token: 0x06024E59 RID: 151129 RVA: 0x0094B244 File Offset: 0x00949444
		// (set) Token: 0x06024E5A RID: 151130 RVA: 0x0094B27D File Offset: 0x0094947D
		[Nullable(1)]
		public TArray<UStaticMeshComponent> SMsArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._SMsArr) == null)
				{
					result = (this._SMsArr = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_Windbell_35_type2_C.__PropertyOffset_38, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SMsArr.CopyAssign(value);
			}
		}

		// Token: 0x170049C3 RID: 18883
		// (get) Token: 0x06024E5B RID: 151131 RVA: 0x0094B28B File Offset: 0x0094948B
		// (set) Token: 0x06024E5C RID: 151132 RVA: 0x0094B29B File Offset: 0x0094949B
		public unsafe float dt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Windbell_35_type2_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Windbell_35_type2_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x06024E5D RID: 151133 RVA: 0x0094B2AC File Offset: 0x009494AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type2_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024E5E RID: 151134 RVA: 0x0094B2C0 File Offset: 0x009494C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Windbell_35_type2_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024E5F RID: 151135 RVA: 0x0094B2D8 File Offset: 0x009494D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Windbell_35_type2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Windbell_35_type2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Windbell_35_type2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Windbell_35_type2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024E60 RID: 151136 RVA: 0x0094B320 File Offset: 0x00949520
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Windbell_35_type2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Windbell_35_type2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Windbell_35_type2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Windbell_35_type2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Windbell_35_type2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024E61 RID: 151137 RVA: 0x0094B367 File Offset: 0x00949567
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ClosePhysicsVisibility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type2_C.__ClosePhysicsVisibility_NativeFunctionPtr, null);
		}

		// Token: 0x06024E62 RID: 151138 RVA: 0x0094B37B File Offset: 0x0094957B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ClosePhysicsVisibility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Windbell_35_type2_C.__ClosePhysicsVisibility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024E63 RID: 151139 RVA: 0x0094B390 File Offset: 0x00949590
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OpenPhysicsVisibility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type2_C.__OpenPhysicsVisibility_NativeFunctionPtr, null);
		}

		// Token: 0x06024E64 RID: 151140 RVA: 0x0094B3A4 File Offset: 0x009495A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void OpenPhysicsVisibility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Windbell_35_type2_C.__OpenPhysicsVisibility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024E65 RID: 151141 RVA: 0x0094B3BC File Offset: 0x009495BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_Windbell_35_type2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_Windbell_35_type2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_Windbell_35_type2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Windbell_35_type2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024E66 RID: 151142 RVA: 0x0094B478 File Offset: 0x00949678
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_Windbell_35_type2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_Windbell_35_type2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Windbell_35_type2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Windbell_35_type2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024E67 RID: 151143 RVA: 0x0094B504 File Offset: 0x00949704
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnApplyWorldOffset(in FVector InWorldOffset, bool bWorldShift)
		{
			BP_Windbell_35_type2_C.__OnApplyWorldOffset_FunctionParams* ptr = stackalloc BP_Windbell_35_type2_C.__OnApplyWorldOffset_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_Windbell_35_type2_C.__OnApplyWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Windbell_35_type2_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InWorldOffset = InWorldOffset;
			ptr->bWorldShift = bWorldShift;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Windbell_35_type2_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024E68 RID: 151144 RVA: 0x0094B558 File Offset: 0x00949758
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnApplyWorldOffset_Implementation(in FVector InWorldOffset, bool bWorldShift)
		{
			BP_Windbell_35_type2_C.__OnApplyWorldOffset_FunctionParams* ptr = stackalloc BP_Windbell_35_type2_C.__OnApplyWorldOffset_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_Windbell_35_type2_C.__OnApplyWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Windbell_35_type2_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InWorldOffset = InWorldOffset;
			ptr->bWorldShift = bWorldShift;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Windbell_35_type2_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024E69 RID: 151145 RVA: 0x0094B5AB File Offset: 0x009497AB
		protected BP_Windbell_35_type2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012554 RID: 75092
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BPWindBell/BP_Windbell_35_type2.BP_Windbell_35_type2_C";

		// Token: 0x04012555 RID: 75093
		private static IntPtr _ClassPtr;

		// Token: 0x04012556 RID: 75094
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012557 RID: 75095
		internal static int __PropertyOffset_1;

		// Token: 0x04012558 RID: 75096
		internal static int __PropertyOffset_2;

		// Token: 0x04012559 RID: 75097
		internal static int __PropertyOffset_3;

		// Token: 0x0401255A RID: 75098
		internal static int __PropertyOffset_4;

		// Token: 0x0401255B RID: 75099
		internal static int __PropertyOffset_5;

		// Token: 0x0401255C RID: 75100
		internal static int __PropertyOffset_6;

		// Token: 0x0401255D RID: 75101
		internal static int __PropertyOffset_7;

		// Token: 0x0401255E RID: 75102
		internal static int __PropertyOffset_8;

		// Token: 0x0401255F RID: 75103
		internal static int __PropertyOffset_9;

		// Token: 0x04012560 RID: 75104
		internal static int __PropertyOffset_10;

		// Token: 0x04012561 RID: 75105
		internal static int __PropertyOffset_11;

		// Token: 0x04012562 RID: 75106
		internal static int __PropertyOffset_12;

		// Token: 0x04012563 RID: 75107
		internal static int __PropertyOffset_13;

		// Token: 0x04012564 RID: 75108
		internal static int __PropertyOffset_14;

		// Token: 0x04012565 RID: 75109
		internal static int __PropertyOffset_15;

		// Token: 0x04012566 RID: 75110
		internal static int __PropertyOffset_16;

		// Token: 0x04012567 RID: 75111
		internal static int __PropertyOffset_17;

		// Token: 0x04012568 RID: 75112
		internal static int __PropertyOffset_18;

		// Token: 0x04012569 RID: 75113
		internal static int __PropertyOffset_19;

		// Token: 0x0401256A RID: 75114
		internal static int __PropertyOffset_20;

		// Token: 0x0401256B RID: 75115
		internal static int __PropertyOffset_21;

		// Token: 0x0401256C RID: 75116
		internal static int __PropertyOffset_22;

		// Token: 0x0401256D RID: 75117
		internal static int __PropertyOffset_23;

		// Token: 0x0401256E RID: 75118
		internal static int __PropertyOffset_24;

		// Token: 0x0401256F RID: 75119
		internal static int __PropertyOffset_25;

		// Token: 0x04012570 RID: 75120
		internal static int __PropertyOffset_26;

		// Token: 0x04012571 RID: 75121
		internal static int __PropertyOffset_27;

		// Token: 0x04012572 RID: 75122
		internal static int __PropertyOffset_28;

		// Token: 0x04012573 RID: 75123
		internal static int __PropertyOffset_29;

		// Token: 0x04012574 RID: 75124
		internal static int __PropertyOffset_30;

		// Token: 0x04012575 RID: 75125
		internal static int __PropertyOffset_31;

		// Token: 0x04012576 RID: 75126
		internal static int __PropertyOffset_32;

		// Token: 0x04012577 RID: 75127
		internal static int __PropertyOffset_33;

		// Token: 0x04012578 RID: 75128
		internal static int __PropertyOffset_34;

		// Token: 0x04012579 RID: 75129
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCableComponent> _CablesArr;

		// Token: 0x0401257A RID: 75130
		internal static int __PropertyOffset_35;

		// Token: 0x0401257B RID: 75131
		internal static int __PropertyOffset_36;

		// Token: 0x0401257C RID: 75132
		internal static int __PropertyOffset_37;

		// Token: 0x0401257D RID: 75133
		internal static int __PropertyOffset_38;

		// Token: 0x0401257E RID: 75134
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _SMsArr;

		// Token: 0x0401257F RID: 75135
		internal static int __PropertyOffset_39;

		// Token: 0x04012580 RID: 75136
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012581 RID: 75137
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012582 RID: 75138
		private static IntPtr __ClosePhysicsVisibility_NativeFunctionPtr;

		// Token: 0x04012583 RID: 75139
		private static IntPtr __OpenPhysicsVisibility_NativeFunctionPtr;

		// Token: 0x04012584 RID: 75140
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012585 RID: 75141
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012586 RID: 75142
		private static IntPtr __OnApplyWorldOffset_NativeFunctionPtr;

		// Token: 0x02009F80 RID: 40832
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031990 RID: 203152
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F81 RID: 40833
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031991 RID: 203153
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031992 RID: 203154
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031993 RID: 203155
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031994 RID: 203156
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031995 RID: 203157
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031996 RID: 203158
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F82 RID: 40834
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031997 RID: 203159
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031998 RID: 203160
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031999 RID: 203161
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403199A RID: 203162
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009F83 RID: 40835
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected new ref struct __OnApplyWorldOffset_FunctionParams
		{
			// Token: 0x0403199B RID: 203163
			[FieldOffset(0)]
			public FVector InWorldOffset;

			// Token: 0x0403199C RID: 203164
			[FieldOffset(12)]
			public bool bWorldShift;
		}
	}
}
