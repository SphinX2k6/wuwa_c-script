using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.VehicleDamage
{
	// Token: 0x02003BE6 RID: 15334
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/VehicleDamage/BP_VehicleDamage.BP_VehicleDamage_C")]
	[UnrealStructLayout(2368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2368)]
	public class BP_VehicleDamage_C : AKuroVehicleDestructionActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022A93 RID: 141971 RVA: 0x0090F0F8 File Offset: 0x0090D2F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VehicleDamage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/VehicleDamage/BP_VehicleDamage.BP_VehicleDamage_C");
			}
			return BP_VehicleDamage_C._ClassPtr;
		}

		// Token: 0x06022A94 RID: 141972 RVA: 0x0090F11C File Offset: 0x0090D31C
		public BP_VehicleDamage_C() : this(BuiltinUtils.AllocNativeUObject(BP_VehicleDamage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022A95 RID: 141973 RVA: 0x0090F144 File Offset: 0x0090D344
		[NullableContext(1)]
		public BP_VehicleDamage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VehicleDamage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003CEC RID: 15596
		// (get) Token: 0x06022A96 RID: 141974 RVA: 0x0090F177 File Offset: 0x0090D377
		// (set) Token: 0x06022A97 RID: 141975 RVA: 0x0090F18B File Offset: 0x0090D38B
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003CED RID: 15597
		// (get) Token: 0x06022A98 RID: 141976 RVA: 0x0090F1A0 File Offset: 0x0090D3A0
		// (set) Token: 0x06022A99 RID: 141977 RVA: 0x0090F1B4 File Offset: 0x0090D3B4
		public unsafe UStaticMeshComponent blast_10
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003CEE RID: 15598
		// (get) Token: 0x06022A9A RID: 141978 RVA: 0x0090F1C9 File Offset: 0x0090D3C9
		// (set) Token: 0x06022A9B RID: 141979 RVA: 0x0090F1DD File Offset: 0x0090D3DD
		public unsafe UBoxComponent myCustomBlock
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003CEF RID: 15599
		// (get) Token: 0x06022A9C RID: 141980 RVA: 0x0090F1F2 File Offset: 0x0090D3F2
		// (set) Token: 0x06022A9D RID: 141981 RVA: 0x0090F206 File Offset: 0x0090D406
		public unsafe UNiagaraComponent NS_VehicleFire
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003CF0 RID: 15600
		// (get) Token: 0x06022A9E RID: 141982 RVA: 0x0090F21B File Offset: 0x0090D41B
		// (set) Token: 0x06022A9F RID: 141983 RVA: 0x0090F22F File Offset: 0x0090D42F
		public unsafe UNiagaraComponent NS_VehicleBloom
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003CF1 RID: 15601
		// (get) Token: 0x06022AA0 RID: 141984 RVA: 0x0090F244 File Offset: 0x0090D444
		// (set) Token: 0x06022AA1 RID: 141985 RVA: 0x0090F258 File Offset: 0x0090D458
		public unsafe UBoxComponent ValidAttackBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003CF2 RID: 15602
		// (get) Token: 0x06022AA2 RID: 141986 RVA: 0x0090F26D File Offset: 0x0090D46D
		// (set) Token: 0x06022AA3 RID: 141987 RVA: 0x0090F281 File Offset: 0x0090D481
		public unsafe UNiagaraComponent NS_engineFly
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003CF3 RID: 15603
		// (get) Token: 0x06022AA4 RID: 141988 RVA: 0x0090F296 File Offset: 0x0090D496
		// (set) Token: 0x06022AA5 RID: 141989 RVA: 0x0090F2AA File Offset: 0x0090D4AA
		public unsafe UStaticMeshComponent blast_small14
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003CF4 RID: 15604
		// (get) Token: 0x06022AA6 RID: 141990 RVA: 0x0090F2BF File Offset: 0x0090D4BF
		// (set) Token: 0x06022AA7 RID: 141991 RVA: 0x0090F2D3 File Offset: 0x0090D4D3
		public unsafe UStaticMeshComponent blast_small10
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003CF5 RID: 15605
		// (get) Token: 0x06022AA8 RID: 141992 RVA: 0x0090F2E8 File Offset: 0x0090D4E8
		// (set) Token: 0x06022AA9 RID: 141993 RVA: 0x0090F2FC File Offset: 0x0090D4FC
		public unsafe UStaticMeshComponent blast_small13
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003CF6 RID: 15606
		// (get) Token: 0x06022AAA RID: 141994 RVA: 0x0090F311 File Offset: 0x0090D511
		// (set) Token: 0x06022AAB RID: 141995 RVA: 0x0090F325 File Offset: 0x0090D525
		public unsafe UStaticMeshComponent blast_small12
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003CF7 RID: 15607
		// (get) Token: 0x06022AAC RID: 141996 RVA: 0x0090F33A File Offset: 0x0090D53A
		// (set) Token: 0x06022AAD RID: 141997 RVA: 0x0090F34E File Offset: 0x0090D54E
		public unsafe UStaticMeshComponent blast_small11
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003CF8 RID: 15608
		// (get) Token: 0x06022AAE RID: 141998 RVA: 0x0090F363 File Offset: 0x0090D563
		// (set) Token: 0x06022AAF RID: 141999 RVA: 0x0090F377 File Offset: 0x0090D577
		public unsafe UStaticMeshComponent blast_small8
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003CF9 RID: 15609
		// (get) Token: 0x06022AB0 RID: 142000 RVA: 0x0090F38C File Offset: 0x0090D58C
		// (set) Token: 0x06022AB1 RID: 142001 RVA: 0x0090F3A0 File Offset: 0x0090D5A0
		public unsafe UStaticMeshComponent blast_small9
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003CFA RID: 15610
		// (get) Token: 0x06022AB2 RID: 142002 RVA: 0x0090F3B5 File Offset: 0x0090D5B5
		// (set) Token: 0x06022AB3 RID: 142003 RVA: 0x0090F3C9 File Offset: 0x0090D5C9
		public unsafe UStaticMeshComponent blast_small7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003CFB RID: 15611
		// (get) Token: 0x06022AB4 RID: 142004 RVA: 0x0090F3DE File Offset: 0x0090D5DE
		// (set) Token: 0x06022AB5 RID: 142005 RVA: 0x0090F3F2 File Offset: 0x0090D5F2
		public unsafe UStaticMeshComponent blast_small5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003CFC RID: 15612
		// (get) Token: 0x06022AB6 RID: 142006 RVA: 0x0090F407 File Offset: 0x0090D607
		// (set) Token: 0x06022AB7 RID: 142007 RVA: 0x0090F41B File Offset: 0x0090D61B
		public unsafe UStaticMeshComponent blast_small6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003CFD RID: 15613
		// (get) Token: 0x06022AB8 RID: 142008 RVA: 0x0090F430 File Offset: 0x0090D630
		// (set) Token: 0x06022AB9 RID: 142009 RVA: 0x0090F444 File Offset: 0x0090D644
		public unsafe UStaticMeshComponent blast_small2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x06022ABA RID: 142010 RVA: 0x0090F459 File Offset: 0x0090D659
		// (set) Token: 0x06022ABB RID: 142011 RVA: 0x0090F46D File Offset: 0x0090D66D
		public unsafe UStaticMeshComponent blast_small3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17003CFF RID: 15615
		// (get) Token: 0x06022ABC RID: 142012 RVA: 0x0090F482 File Offset: 0x0090D682
		// (set) Token: 0x06022ABD RID: 142013 RVA: 0x0090F496 File Offset: 0x0090D696
		public unsafe UStaticMeshComponent blast_small1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17003D00 RID: 15616
		// (get) Token: 0x06022ABE RID: 142014 RVA: 0x0090F4AB File Offset: 0x0090D6AB
		// (set) Token: 0x06022ABF RID: 142015 RVA: 0x0090F4BF File Offset: 0x0090D6BF
		public unsafe UPhysicsConstraintComponent cons_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17003D01 RID: 15617
		// (get) Token: 0x06022AC0 RID: 142016 RVA: 0x0090F4D4 File Offset: 0x0090D6D4
		// (set) Token: 0x06022AC1 RID: 142017 RVA: 0x0090F4E8 File Offset: 0x0090D6E8
		public unsafe UStaticMeshComponent blast_back_cover
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17003D02 RID: 15618
		// (get) Token: 0x06022AC2 RID: 142018 RVA: 0x0090F4FD File Offset: 0x0090D6FD
		// (set) Token: 0x06022AC3 RID: 142019 RVA: 0x0090F511 File Offset: 0x0090D711
		public unsafe UStaticMeshComponent blast_wheel3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17003D03 RID: 15619
		// (get) Token: 0x06022AC4 RID: 142020 RVA: 0x0090F526 File Offset: 0x0090D726
		// (set) Token: 0x06022AC5 RID: 142021 RVA: 0x0090F53A File Offset: 0x0090D73A
		public unsafe UStaticMeshComponent blast_wheel2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17003D04 RID: 15620
		// (get) Token: 0x06022AC6 RID: 142022 RVA: 0x0090F54F File Offset: 0x0090D74F
		// (set) Token: 0x06022AC7 RID: 142023 RVA: 0x0090F563 File Offset: 0x0090D763
		public unsafe UStaticMeshComponent blast_wheel1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003D05 RID: 15621
		// (get) Token: 0x06022AC8 RID: 142024 RVA: 0x0090F578 File Offset: 0x0090D778
		// (set) Token: 0x06022AC9 RID: 142025 RVA: 0x0090F58C File Offset: 0x0090D78C
		public unsafe UStaticMeshComponent blast_wheel4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17003D06 RID: 15622
		// (get) Token: 0x06022ACA RID: 142026 RVA: 0x0090F5A1 File Offset: 0x0090D7A1
		// (set) Token: 0x06022ACB RID: 142027 RVA: 0x0090F5B5 File Offset: 0x0090D7B5
		public unsafe UStaticMeshComponent blast_front_cover
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17003D07 RID: 15623
		// (get) Token: 0x06022ACC RID: 142028 RVA: 0x0090F5CA File Offset: 0x0090D7CA
		// (set) Token: 0x06022ACD RID: 142029 RVA: 0x0090F5DE File Offset: 0x0090D7DE
		public unsafe UPhysicsConstraintComponent cons_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17003D08 RID: 15624
		// (get) Token: 0x06022ACE RID: 142030 RVA: 0x0090F5F3 File Offset: 0x0090D7F3
		// (set) Token: 0x06022ACF RID: 142031 RVA: 0x0090F607 File Offset: 0x0090D807
		public unsafe UPhysicsConstraintComponent cons_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17003D09 RID: 15625
		// (get) Token: 0x06022AD0 RID: 142032 RVA: 0x0090F61C File Offset: 0x0090D81C
		// (set) Token: 0x06022AD1 RID: 142033 RVA: 0x0090F630 File Offset: 0x0090D830
		public unsafe UPhysicsConstraintComponent cons_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x17003D0A RID: 15626
		// (get) Token: 0x06022AD2 RID: 142034 RVA: 0x0090F645 File Offset: 0x0090D845
		// (set) Token: 0x06022AD3 RID: 142035 RVA: 0x0090F659 File Offset: 0x0090D859
		public unsafe UStaticMeshComponent blast3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x17003D0B RID: 15627
		// (get) Token: 0x06022AD4 RID: 142036 RVA: 0x0090F66E File Offset: 0x0090D86E
		// (set) Token: 0x06022AD5 RID: 142037 RVA: 0x0090F682 File Offset: 0x0090D882
		public unsafe UStaticMeshComponent blast2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x17003D0C RID: 15628
		// (get) Token: 0x06022AD6 RID: 142038 RVA: 0x0090F697 File Offset: 0x0090D897
		// (set) Token: 0x06022AD7 RID: 142039 RVA: 0x0090F6AB File Offset: 0x0090D8AB
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17003D0D RID: 15629
		// (get) Token: 0x06022AD8 RID: 142040 RVA: 0x0090F6C0 File Offset: 0x0090D8C0
		// (set) Token: 0x06022AD9 RID: 142041 RVA: 0x0090F6D4 File Offset: 0x0090D8D4
		public unsafe UStaticMeshComponent SM_vehicleDamage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x06022ADA RID: 142042 RVA: 0x0090F6E9 File Offset: 0x0090D8E9
		// (set) Token: 0x06022ADB RID: 142043 RVA: 0x0090F6FD File Offset: 0x0090D8FD
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x17003D0F RID: 15631
		// (get) Token: 0x06022ADC RID: 142044 RVA: 0x0090F712 File Offset: 0x0090D912
		// (set) Token: 0x06022ADD RID: 142045 RVA: 0x0090F726 File Offset: 0x0090D926
		public unsafe UMaterialInstanceDynamic StampMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x17003D10 RID: 15632
		// (get) Token: 0x06022ADE RID: 142046 RVA: 0x0090F73C File Offset: 0x0090D93C
		// (set) Token: 0x06022ADF RID: 142047 RVA: 0x0090F775 File Offset: 0x0090D975
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> CarAllMats
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._CarAllMats) == null)
				{
					result = (this._CarAllMats = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_37, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CarAllMats.CopyAssign(value);
			}
		}

		// Token: 0x17003D11 RID: 15633
		// (get) Token: 0x06022AE0 RID: 142048 RVA: 0x0090F783 File Offset: 0x0090D983
		// (set) Token: 0x06022AE1 RID: 142049 RVA: 0x0090F797 File Offset: 0x0090D997
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x17003D12 RID: 15634
		// (get) Token: 0x06022AE2 RID: 142050 RVA: 0x0090F7AC File Offset: 0x0090D9AC
		// (set) Token: 0x06022AE3 RID: 142051 RVA: 0x0090F7BC File Offset: 0x0090D9BC
		public unsafe float HitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17003D13 RID: 15635
		// (get) Token: 0x06022AE4 RID: 142052 RVA: 0x0090F7CD File Offset: 0x0090D9CD
		// (set) Token: 0x06022AE5 RID: 142053 RVA: 0x0090F7DD File Offset: 0x0090D9DD
		public unsafe float TraceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17003D14 RID: 15636
		// (get) Token: 0x06022AE6 RID: 142054 RVA: 0x0090F7EE File Offset: 0x0090D9EE
		// (set) Token: 0x06022AE7 RID: 142055 RVA: 0x0090F802 File Offset: 0x0090DA02
		public unsafe FVector CurWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17003D15 RID: 15637
		// (get) Token: 0x06022AE8 RID: 142056 RVA: 0x0090F817 File Offset: 0x0090DA17
		// (set) Token: 0x06022AE9 RID: 142057 RVA: 0x0090F82B File Offset: 0x0090DA2B
		public unsafe FVector hittingPoint_world_position_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17003D16 RID: 15638
		// (get) Token: 0x06022AEA RID: 142058 RVA: 0x0090F840 File Offset: 0x0090DA40
		// (set) Token: 0x06022AEB RID: 142059 RVA: 0x0090F854 File Offset: 0x0090DA54
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17003D17 RID: 15639
		// (get) Token: 0x06022AEC RID: 142060 RVA: 0x0090F869 File Offset: 0x0090DA69
		// (set) Token: 0x06022AED RID: 142061 RVA: 0x0090F87D File Offset: 0x0090DA7D
		public unsafe UTextureRenderTarget2D SkinMaskRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_44);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_44, value);
			}
		}

		// Token: 0x17003D18 RID: 15640
		// (get) Token: 0x06022AEE RID: 142062 RVA: 0x0090F892 File Offset: 0x0090DA92
		// (set) Token: 0x06022AEF RID: 142063 RVA: 0x0090F8A6 File Offset: 0x0090DAA6
		public unsafe UTexture2D TreePosTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x17003D19 RID: 15641
		// (get) Token: 0x06022AF0 RID: 142064 RVA: 0x0090F8BB File Offset: 0x0090DABB
		// (set) Token: 0x06022AF1 RID: 142065 RVA: 0x0090F8CF File Offset: 0x0090DACF
		public unsafe FVector LastWeaponPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17003D1A RID: 15642
		// (get) Token: 0x06022AF2 RID: 142066 RVA: 0x0090F8E4 File Offset: 0x0090DAE4
		// (set) Token: 0x06022AF3 RID: 142067 RVA: 0x0090F8F4 File Offset: 0x0090DAF4
		public unsafe bool LastPointUseAble
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_47) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_47) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D1B RID: 15643
		// (get) Token: 0x06022AF4 RID: 142068 RVA: 0x0090F905 File Offset: 0x0090DB05
		// (set) Token: 0x06022AF5 RID: 142069 RVA: 0x0090F915 File Offset: 0x0090DB15
		public unsafe bool debugWeapon_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x06022AF6 RID: 142070 RVA: 0x0090F926 File Offset: 0x0090DB26
		// (set) Token: 0x06022AF7 RID: 142071 RVA: 0x0090F936 File Offset: 0x0090DB36
		public unsafe bool debugDamage_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D1D RID: 15645
		// (get) Token: 0x06022AF8 RID: 142072 RVA: 0x0090F948 File Offset: 0x0090DB48
		// (set) Token: 0x06022AF9 RID: 142073 RVA: 0x0090F981 File Offset: 0x0090DB81
		[Nullable(1)]
		public TArray<UStaticMeshComponent> SMComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._SMComponents) == null)
				{
					result = (this._SMComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_50, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SMComponents.CopyAssign(value);
			}
		}

		// Token: 0x17003D1E RID: 15646
		// (get) Token: 0x06022AFA RID: 142074 RVA: 0x0090F990 File Offset: 0x0090DB90
		// (set) Token: 0x06022AFB RID: 142075 RVA: 0x0090F9C9 File Offset: 0x0090DBC9
		[Nullable(1)]
		public TArray<float> SMHealth
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._SMHealth) == null)
				{
					result = (this._SMHealth = new TArray<float>(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_51, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SMHealth.CopyAssign(value);
			}
		}

		// Token: 0x17003D1F RID: 15647
		// (get) Token: 0x06022AFC RID: 142076 RVA: 0x0090F9D8 File Offset: 0x0090DBD8
		// (set) Token: 0x06022AFD RID: 142077 RVA: 0x0090FA11 File Offset: 0x0090DC11
		[Nullable(1)]
		public TArray<UPhysicsConstraintComponent> ConsArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UPhysicsConstraintComponent> result;
				if ((result = this._ConsArr) == null)
				{
					result = (this._ConsArr = new TArray<UPhysicsConstraintComponent>(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_52, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ConsArr.CopyAssign(value);
			}
		}

		// Token: 0x17003D20 RID: 15648
		// (get) Token: 0x06022AFE RID: 142078 RVA: 0x0090FA20 File Offset: 0x0090DC20
		// (set) Token: 0x06022AFF RID: 142079 RVA: 0x0090FA59 File Offset: 0x0090DC59
		[Nullable(1)]
		public TArray<FVector> ForceArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._ForceArr) == null)
				{
					result = (this._ForceArr = new TArray<FVector>(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_53, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ForceArr.CopyAssign(value);
			}
		}

		// Token: 0x17003D21 RID: 15649
		// (get) Token: 0x06022B00 RID: 142080 RVA: 0x0090FA67 File Offset: 0x0090DC67
		// (set) Token: 0x06022B01 RID: 142081 RVA: 0x0090FA77 File Offset: 0x0090DC77
		public unsafe bool NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D22 RID: 15650
		// (get) Token: 0x06022B02 RID: 142082 RVA: 0x0090FA88 File Offset: 0x0090DC88
		// (set) Token: 0x06022B03 RID: 142083 RVA: 0x0090FA9C File Offset: 0x0090DC9C
		public unsafe FVector LastHitPositon
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_55);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_55) = value;
			}
		}

		// Token: 0x17003D23 RID: 15651
		// (get) Token: 0x06022B04 RID: 142084 RVA: 0x0090FAB4 File Offset: 0x0090DCB4
		// (set) Token: 0x06022B05 RID: 142085 RVA: 0x0090FAED File Offset: 0x0090DCED
		[Nullable(1)]
		public TArray<UStaticMeshComponent> Wheels
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._Wheels) == null)
				{
					result = (this._Wheels = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_56, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Wheels.CopyAssign(value);
			}
		}

		// Token: 0x17003D24 RID: 15652
		// (get) Token: 0x06022B06 RID: 142086 RVA: 0x0090FAFB File Offset: 0x0090DCFB
		// (set) Token: 0x06022B07 RID: 142087 RVA: 0x0090FB0F File Offset: 0x0090DD0F
		public unsafe UNiagaraSystem NS_Bloom
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_57);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_57, value);
			}
		}

		// Token: 0x17003D25 RID: 15653
		// (get) Token: 0x06022B08 RID: 142088 RVA: 0x0090FB24 File Offset: 0x0090DD24
		// (set) Token: 0x06022B09 RID: 142089 RVA: 0x0090FB38 File Offset: 0x0090DD38
		public unsafe UNiagaraSystem NS_Attack
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_58);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_58, value);
			}
		}

		// Token: 0x17003D26 RID: 15654
		// (get) Token: 0x06022B0A RID: 142090 RVA: 0x0090FB4D File Offset: 0x0090DD4D
		// (set) Token: 0x06022B0B RID: 142091 RVA: 0x0090FB5D File Offset: 0x0090DD5D
		public unsafe bool EngineAlreadyBreak
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_59) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_59) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D27 RID: 15655
		// (get) Token: 0x06022B0C RID: 142092 RVA: 0x0090FB6E File Offset: 0x0090DD6E
		// (set) Token: 0x06022B0D RID: 142093 RVA: 0x0090FB7E File Offset: 0x0090DD7E
		public unsafe bool EngineBreakOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_60) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_60) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D28 RID: 15656
		// (get) Token: 0x06022B0E RID: 142094 RVA: 0x0090FB8F File Offset: 0x0090DD8F
		// (set) Token: 0x06022B0F RID: 142095 RVA: 0x0090FB9F File Offset: 0x0090DD9F
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_61) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_61) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D29 RID: 15657
		// (get) Token: 0x06022B10 RID: 142096 RVA: 0x0090FBB0 File Offset: 0x0090DDB0
		// (set) Token: 0x06022B11 RID: 142097 RVA: 0x0090FBC4 File Offset: 0x0090DDC4
		public unsafe UNiagaraSystem NS_CarFire
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_62);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_62, value);
			}
		}

		// Token: 0x17003D2A RID: 15658
		// (get) Token: 0x06022B12 RID: 142098 RVA: 0x0090FBD9 File Offset: 0x0090DDD9
		// (set) Token: 0x06022B13 RID: 142099 RVA: 0x0090FBED File Offset: 0x0090DDED
		public unsafe UNiagaraSystem NS_EngineFire
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_63);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_C.__PropertyOffset_63, value);
			}
		}

		// Token: 0x17003D2B RID: 15659
		// (get) Token: 0x06022B14 RID: 142100 RVA: 0x0090FC02 File Offset: 0x0090DE02
		// (set) Token: 0x06022B15 RID: 142101 RVA: 0x0090FC12 File Offset: 0x0090DE12
		public unsafe bool bDebug_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_64) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_64) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D2C RID: 15660
		// (get) Token: 0x06022B16 RID: 142102 RVA: 0x0090FC23 File Offset: 0x0090DE23
		// (set) Token: 0x06022B17 RID: 142103 RVA: 0x0090FC33 File Offset: 0x0090DE33
		public unsafe float dtForNiagara
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_65);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_65) = value;
			}
		}

		// Token: 0x17003D2D RID: 15661
		// (get) Token: 0x06022B18 RID: 142104 RVA: 0x0090FC44 File Offset: 0x0090DE44
		// (set) Token: 0x06022B19 RID: 142105 RVA: 0x0090FC54 File Offset: 0x0090DE54
		public unsafe int thisFrameWeaponID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_66);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_66) = value;
			}
		}

		// Token: 0x17003D2E RID: 15662
		// (get) Token: 0x06022B1A RID: 142106 RVA: 0x0090FC65 File Offset: 0x0090DE65
		// (set) Token: 0x06022B1B RID: 142107 RVA: 0x0090FC75 File Offset: 0x0090DE75
		public unsafe int lastFrameWeaponID_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_67);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_C.__PropertyOffset_67) = value;
			}
		}

		// Token: 0x06022B1C RID: 142108 RVA: 0x0090FC88 File Offset: 0x0090DE88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CreateDM(UStaticMeshComponent Component)
		{
			BP_VehicleDamage_C.__CreateDM_FunctionParams* ptr = stackalloc BP_VehicleDamage_C.__CreateDM_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_VehicleDamage_C.__CreateDM_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_C.__CreateDM_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Component = ((Component != null) ? Component.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_C.__CreateDM_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022B1D RID: 142109 RVA: 0x0090FCDD File Offset: 0x0090DEDD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022B1E RID: 142110 RVA: 0x0090FCF1 File Offset: 0x0090DEF1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VehicleDamage_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022B1F RID: 142111 RVA: 0x0090FD08 File Offset: 0x0090DF08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_0E15804D4F41346343B2EB9AA4C207F8(int PlayingID)
		{
			BP_VehicleDamage_C.__Completed_0E15804D4F41346343B2EB9AA4C207F8_FunctionParams* ptr = stackalloc BP_VehicleDamage_C.__Completed_0E15804D4F41346343B2EB9AA4C207F8_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_C.__Completed_0E15804D4F41346343B2EB9AA4C207F8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_C.__Completed_0E15804D4F41346343B2EB9AA4C207F8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_C.__Completed_0E15804D4F41346343B2EB9AA4C207F8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022B20 RID: 142112 RVA: 0x0090FD50 File Offset: 0x0090DF50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_5D181A7E42F3A6959622B6BE0BBB184B(int PlayingID)
		{
			BP_VehicleDamage_C.__Completed_5D181A7E42F3A6959622B6BE0BBB184B_FunctionParams* ptr = stackalloc BP_VehicleDamage_C.__Completed_5D181A7E42F3A6959622B6BE0BBB184B_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_C.__Completed_5D181A7E42F3A6959622B6BE0BBB184B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_C.__Completed_5D181A7E42F3A6959622B6BE0BBB184B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_C.__Completed_5D181A7E42F3A6959622B6BE0BBB184B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022B21 RID: 142113 RVA: 0x0090FD98 File Offset: 0x0090DF98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_0671AEF343B8C7120964849EB085DE4D(int PlayingID)
		{
			BP_VehicleDamage_C.__Completed_0671AEF343B8C7120964849EB085DE4D_FunctionParams* ptr = stackalloc BP_VehicleDamage_C.__Completed_0671AEF343B8C7120964849EB085DE4D_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_C.__Completed_0671AEF343B8C7120964849EB085DE4D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_C.__Completed_0671AEF343B8C7120964849EB085DE4D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_C.__Completed_0671AEF343B8C7120964849EB085DE4D_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022B22 RID: 142114 RVA: 0x0090FDDE File Offset: 0x0090DFDE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022B23 RID: 142115 RVA: 0x0090FDF2 File Offset: 0x0090DFF2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VehicleDamage_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022B24 RID: 142116 RVA: 0x0090FE08 File Offset: 0x0090E008
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VehicleDamage_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VehicleDamage_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022B25 RID: 142117 RVA: 0x0090FE50 File Offset: 0x0090E050
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VehicleDamage_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VehicleDamage_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VehicleDamage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022B26 RID: 142118 RVA: 0x0090FE98 File Offset: 0x0090E098
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_VehicleDamage_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_VehicleDamage_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_VehicleDamage_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022B27 RID: 142119 RVA: 0x0090FEFB File Offset: 0x0090E0FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_C.__CustomEvent1_NativeFunctionPtr, null);
		}

		// Token: 0x06022B28 RID: 142120 RVA: 0x0090FF0F File Offset: 0x0090E10F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_C.__CustomEvent_NativeFunctionPtr, null);
		}

		// Token: 0x06022B29 RID: 142121 RVA: 0x0090FF23 File Offset: 0x0090E123
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06022B2A RID: 142122 RVA: 0x0090FF37 File Offset: 0x0090E137
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void test()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_C.__test_NativeFunctionPtr, null);
		}

		// Token: 0x06022B2B RID: 142123 RVA: 0x0090FF4C File Offset: 0x0090E14C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnVehiclePartBroken_Event_0(int PartIndex, string PartName)
		{
			BP_VehicleDamage_C.__OnVehiclePartBroken_Event_0_FunctionParams* ptr = stackalloc BP_VehicleDamage_C.__OnVehiclePartBroken_Event_0_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_VehicleDamage_C.__OnVehiclePartBroken_Event_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_C.__OnVehiclePartBroken_Event_0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PartIndex = PartIndex;
			FString.CopyFrom((void*)(&ptr->PartName), PartName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_C.__OnVehiclePartBroken_Event_0_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_VehicleDamage_C.__OnVehiclePartBroken_Event_0_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022B2C RID: 142124 RVA: 0x0090FFB0 File Offset: 0x0090E1B0
		protected BP_VehicleDamage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401109D RID: 69789
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/VehicleDamage/BP_VehicleDamage.BP_VehicleDamage_C";

		// Token: 0x0401109E RID: 69790
		private static IntPtr _ClassPtr;

		// Token: 0x0401109F RID: 69791
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040110A0 RID: 69792
		internal static int __PropertyOffset_1;

		// Token: 0x040110A1 RID: 69793
		internal static int __PropertyOffset_2;

		// Token: 0x040110A2 RID: 69794
		internal static int __PropertyOffset_3;

		// Token: 0x040110A3 RID: 69795
		internal static int __PropertyOffset_4;

		// Token: 0x040110A4 RID: 69796
		internal static int __PropertyOffset_5;

		// Token: 0x040110A5 RID: 69797
		internal static int __PropertyOffset_6;

		// Token: 0x040110A6 RID: 69798
		internal static int __PropertyOffset_7;

		// Token: 0x040110A7 RID: 69799
		internal static int __PropertyOffset_8;

		// Token: 0x040110A8 RID: 69800
		internal static int __PropertyOffset_9;

		// Token: 0x040110A9 RID: 69801
		internal static int __PropertyOffset_10;

		// Token: 0x040110AA RID: 69802
		internal static int __PropertyOffset_11;

		// Token: 0x040110AB RID: 69803
		internal static int __PropertyOffset_12;

		// Token: 0x040110AC RID: 69804
		internal static int __PropertyOffset_13;

		// Token: 0x040110AD RID: 69805
		internal static int __PropertyOffset_14;

		// Token: 0x040110AE RID: 69806
		internal static int __PropertyOffset_15;

		// Token: 0x040110AF RID: 69807
		internal static int __PropertyOffset_16;

		// Token: 0x040110B0 RID: 69808
		internal static int __PropertyOffset_17;

		// Token: 0x040110B1 RID: 69809
		internal static int __PropertyOffset_18;

		// Token: 0x040110B2 RID: 69810
		internal static int __PropertyOffset_19;

		// Token: 0x040110B3 RID: 69811
		internal static int __PropertyOffset_20;

		// Token: 0x040110B4 RID: 69812
		internal static int __PropertyOffset_21;

		// Token: 0x040110B5 RID: 69813
		internal static int __PropertyOffset_22;

		// Token: 0x040110B6 RID: 69814
		internal static int __PropertyOffset_23;

		// Token: 0x040110B7 RID: 69815
		internal static int __PropertyOffset_24;

		// Token: 0x040110B8 RID: 69816
		internal static int __PropertyOffset_25;

		// Token: 0x040110B9 RID: 69817
		internal static int __PropertyOffset_26;

		// Token: 0x040110BA RID: 69818
		internal static int __PropertyOffset_27;

		// Token: 0x040110BB RID: 69819
		internal static int __PropertyOffset_28;

		// Token: 0x040110BC RID: 69820
		internal static int __PropertyOffset_29;

		// Token: 0x040110BD RID: 69821
		internal static int __PropertyOffset_30;

		// Token: 0x040110BE RID: 69822
		internal static int __PropertyOffset_31;

		// Token: 0x040110BF RID: 69823
		internal static int __PropertyOffset_32;

		// Token: 0x040110C0 RID: 69824
		internal static int __PropertyOffset_33;

		// Token: 0x040110C1 RID: 69825
		internal static int __PropertyOffset_34;

		// Token: 0x040110C2 RID: 69826
		internal static int __PropertyOffset_35;

		// Token: 0x040110C3 RID: 69827
		internal static int __PropertyOffset_36;

		// Token: 0x040110C4 RID: 69828
		internal static int __PropertyOffset_37;

		// Token: 0x040110C5 RID: 69829
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _CarAllMats;

		// Token: 0x040110C6 RID: 69830
		internal static int __PropertyOffset_38;

		// Token: 0x040110C7 RID: 69831
		internal static int __PropertyOffset_39;

		// Token: 0x040110C8 RID: 69832
		internal static int __PropertyOffset_40;

		// Token: 0x040110C9 RID: 69833
		internal static int __PropertyOffset_41;

		// Token: 0x040110CA RID: 69834
		internal static int __PropertyOffset_42;

		// Token: 0x040110CB RID: 69835
		internal static int __PropertyOffset_43;

		// Token: 0x040110CC RID: 69836
		internal static int __PropertyOffset_44;

		// Token: 0x040110CD RID: 69837
		internal static int __PropertyOffset_45;

		// Token: 0x040110CE RID: 69838
		internal static int __PropertyOffset_46;

		// Token: 0x040110CF RID: 69839
		internal static int __PropertyOffset_47;

		// Token: 0x040110D0 RID: 69840
		internal static int __PropertyOffset_48;

		// Token: 0x040110D1 RID: 69841
		internal static int __PropertyOffset_49;

		// Token: 0x040110D2 RID: 69842
		internal static int __PropertyOffset_50;

		// Token: 0x040110D3 RID: 69843
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _SMComponents;

		// Token: 0x040110D4 RID: 69844
		internal static int __PropertyOffset_51;

		// Token: 0x040110D5 RID: 69845
		private TArray<float> _SMHealth;

		// Token: 0x040110D6 RID: 69846
		internal static int __PropertyOffset_52;

		// Token: 0x040110D7 RID: 69847
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicsConstraintComponent> _ConsArr;

		// Token: 0x040110D8 RID: 69848
		internal static int __PropertyOffset_53;

		// Token: 0x040110D9 RID: 69849
		private TArray<FVector> _ForceArr;

		// Token: 0x040110DA RID: 69850
		internal static int __PropertyOffset_54;

		// Token: 0x040110DB RID: 69851
		internal static int __PropertyOffset_55;

		// Token: 0x040110DC RID: 69852
		internal static int __PropertyOffset_56;

		// Token: 0x040110DD RID: 69853
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _Wheels;

		// Token: 0x040110DE RID: 69854
		internal static int __PropertyOffset_57;

		// Token: 0x040110DF RID: 69855
		internal static int __PropertyOffset_58;

		// Token: 0x040110E0 RID: 69856
		internal static int __PropertyOffset_59;

		// Token: 0x040110E1 RID: 69857
		internal static int __PropertyOffset_60;

		// Token: 0x040110E2 RID: 69858
		internal static int __PropertyOffset_61;

		// Token: 0x040110E3 RID: 69859
		internal static int __PropertyOffset_62;

		// Token: 0x040110E4 RID: 69860
		internal static int __PropertyOffset_63;

		// Token: 0x040110E5 RID: 69861
		internal static int __PropertyOffset_64;

		// Token: 0x040110E6 RID: 69862
		internal static int __PropertyOffset_65;

		// Token: 0x040110E7 RID: 69863
		internal static int __PropertyOffset_66;

		// Token: 0x040110E8 RID: 69864
		internal static int __PropertyOffset_67;

		// Token: 0x040110E9 RID: 69865
		private static IntPtr __CreateDM_NativeFunctionPtr;

		// Token: 0x040110EA RID: 69866
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040110EB RID: 69867
		private static IntPtr __Completed_0E15804D4F41346343B2EB9AA4C207F8_NativeFunctionPtr;

		// Token: 0x040110EC RID: 69868
		private static IntPtr __Completed_5D181A7E42F3A6959622B6BE0BBB184B_NativeFunctionPtr;

		// Token: 0x040110ED RID: 69869
		private static IntPtr __Completed_0671AEF343B8C7120964849EB085DE4D_NativeFunctionPtr;

		// Token: 0x040110EE RID: 69870
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040110EF RID: 69871
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040110F0 RID: 69872
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x040110F1 RID: 69873
		private static IntPtr __CustomEvent1_NativeFunctionPtr;

		// Token: 0x040110F2 RID: 69874
		private static IntPtr __CustomEvent_NativeFunctionPtr;

		// Token: 0x040110F3 RID: 69875
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040110F4 RID: 69876
		private static IntPtr __test_NativeFunctionPtr;

		// Token: 0x040110F5 RID: 69877
		private static IntPtr __OnVehiclePartBroken_Event_0_NativeFunctionPtr;

		// Token: 0x02009DB3 RID: 40371
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __CreateDM_FunctionParams
		{
			// Token: 0x04031595 RID: 202133
			[FieldOffset(0)]
			public IntPtr Component;
		}

		// Token: 0x02009DB4 RID: 40372
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_0E15804D4F41346343B2EB9AA4C207F8_FunctionParams
		{
			// Token: 0x04031596 RID: 202134
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009DB5 RID: 40373
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_5D181A7E42F3A6959622B6BE0BBB184B_FunctionParams
		{
			// Token: 0x04031597 RID: 202135
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009DB6 RID: 40374
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_0671AEF343B8C7120964849EB085DE4D_FunctionParams
		{
			// Token: 0x04031598 RID: 202136
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009DB7 RID: 40375
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031599 RID: 202137
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DB8 RID: 40376
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x0403159A RID: 202138
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x0403159B RID: 202139
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0403159C RID: 202140
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009DB9 RID: 40377
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnVehiclePartBroken_Event_0_FunctionParams
		{
			// Token: 0x0403159D RID: 202141
			[FieldOffset(0)]
			public int PartIndex;

			// Token: 0x0403159E RID: 202142
			[FieldOffset(8)]
			public FString PartName;
		}
	}
}
