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
	// Token: 0x02003BE8 RID: 15336
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/VehicleDamage/BP_VehicleDamage_type2.BP_VehicleDamage_type2_C")]
	[UnrealStructLayout(2688, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2684)]
	public class BP_VehicleDamage_type2_C : AKuroVehicleDestructionActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022C23 RID: 142371 RVA: 0x00911706 File Offset: 0x0090F906
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VehicleDamage_type2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/VehicleDamage/BP_VehicleDamage_type2.BP_VehicleDamage_type2_C");
			}
			return BP_VehicleDamage_type2_C._ClassPtr;
		}

		// Token: 0x06022C24 RID: 142372 RVA: 0x0091172C File Offset: 0x0090F92C
		public BP_VehicleDamage_type2_C() : this(BuiltinUtils.AllocNativeUObject(BP_VehicleDamage_type2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022C25 RID: 142373 RVA: 0x00911754 File Offset: 0x0090F954
		[NullableContext(1)]
		public BP_VehicleDamage_type2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VehicleDamage_type2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003D96 RID: 15766
		// (get) Token: 0x06022C26 RID: 142374 RVA: 0x00911787 File Offset: 0x0090F987
		// (set) Token: 0x06022C27 RID: 142375 RVA: 0x0091179B File Offset: 0x0090F99B
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003D97 RID: 15767
		// (get) Token: 0x06022C28 RID: 142376 RVA: 0x009117B0 File Offset: 0x0090F9B0
		// (set) Token: 0x06022C29 RID: 142377 RVA: 0x009117C4 File Offset: 0x0090F9C4
		public unsafe UBoxComponent BoxTrigger
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003D98 RID: 15768
		// (get) Token: 0x06022C2A RID: 142378 RVA: 0x009117D9 File Offset: 0x0090F9D9
		// (set) Token: 0x06022C2B RID: 142379 RVA: 0x009117ED File Offset: 0x0090F9ED
		public unsafe UStaticMeshComponent blast_10
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003D99 RID: 15769
		// (get) Token: 0x06022C2C RID: 142380 RVA: 0x00911802 File Offset: 0x0090FA02
		// (set) Token: 0x06022C2D RID: 142381 RVA: 0x00911816 File Offset: 0x0090FA16
		public unsafe UBoxComponent myCustomBlock
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003D9A RID: 15770
		// (get) Token: 0x06022C2E RID: 142382 RVA: 0x0091182B File Offset: 0x0090FA2B
		// (set) Token: 0x06022C2F RID: 142383 RVA: 0x0091183F File Offset: 0x0090FA3F
		public unsafe UNiagaraComponent NS_VehicleFire
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003D9B RID: 15771
		// (get) Token: 0x06022C30 RID: 142384 RVA: 0x00911854 File Offset: 0x0090FA54
		// (set) Token: 0x06022C31 RID: 142385 RVA: 0x00911868 File Offset: 0x0090FA68
		public unsafe UNiagaraComponent NS_VehicleBloom
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003D9C RID: 15772
		// (get) Token: 0x06022C32 RID: 142386 RVA: 0x0091187D File Offset: 0x0090FA7D
		// (set) Token: 0x06022C33 RID: 142387 RVA: 0x00911891 File Offset: 0x0090FA91
		public unsafe UBoxComponent ValidAttackBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003D9D RID: 15773
		// (get) Token: 0x06022C34 RID: 142388 RVA: 0x009118A6 File Offset: 0x0090FAA6
		// (set) Token: 0x06022C35 RID: 142389 RVA: 0x009118BA File Offset: 0x0090FABA
		public unsafe UNiagaraComponent NS_engineFly
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003D9E RID: 15774
		// (get) Token: 0x06022C36 RID: 142390 RVA: 0x009118CF File Offset: 0x0090FACF
		// (set) Token: 0x06022C37 RID: 142391 RVA: 0x009118E3 File Offset: 0x0090FAE3
		public unsafe UStaticMeshComponent blast_small14
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003D9F RID: 15775
		// (get) Token: 0x06022C38 RID: 142392 RVA: 0x009118F8 File Offset: 0x0090FAF8
		// (set) Token: 0x06022C39 RID: 142393 RVA: 0x0091190C File Offset: 0x0090FB0C
		public unsafe UStaticMeshComponent blast_small10
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003DA0 RID: 15776
		// (get) Token: 0x06022C3A RID: 142394 RVA: 0x00911921 File Offset: 0x0090FB21
		// (set) Token: 0x06022C3B RID: 142395 RVA: 0x00911935 File Offset: 0x0090FB35
		public unsafe UStaticMeshComponent blast_small13
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003DA1 RID: 15777
		// (get) Token: 0x06022C3C RID: 142396 RVA: 0x0091194A File Offset: 0x0090FB4A
		// (set) Token: 0x06022C3D RID: 142397 RVA: 0x0091195E File Offset: 0x0090FB5E
		public unsafe UStaticMeshComponent blast_small12
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003DA2 RID: 15778
		// (get) Token: 0x06022C3E RID: 142398 RVA: 0x00911973 File Offset: 0x0090FB73
		// (set) Token: 0x06022C3F RID: 142399 RVA: 0x00911987 File Offset: 0x0090FB87
		public unsafe UStaticMeshComponent blast_small11
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003DA3 RID: 15779
		// (get) Token: 0x06022C40 RID: 142400 RVA: 0x0091199C File Offset: 0x0090FB9C
		// (set) Token: 0x06022C41 RID: 142401 RVA: 0x009119B0 File Offset: 0x0090FBB0
		public unsafe UStaticMeshComponent blast_small8
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003DA4 RID: 15780
		// (get) Token: 0x06022C42 RID: 142402 RVA: 0x009119C5 File Offset: 0x0090FBC5
		// (set) Token: 0x06022C43 RID: 142403 RVA: 0x009119D9 File Offset: 0x0090FBD9
		public unsafe UStaticMeshComponent blast_small9
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003DA5 RID: 15781
		// (get) Token: 0x06022C44 RID: 142404 RVA: 0x009119EE File Offset: 0x0090FBEE
		// (set) Token: 0x06022C45 RID: 142405 RVA: 0x00911A02 File Offset: 0x0090FC02
		public unsafe UStaticMeshComponent blast_small7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003DA6 RID: 15782
		// (get) Token: 0x06022C46 RID: 142406 RVA: 0x00911A17 File Offset: 0x0090FC17
		// (set) Token: 0x06022C47 RID: 142407 RVA: 0x00911A2B File Offset: 0x0090FC2B
		public unsafe UStaticMeshComponent blast_small5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003DA7 RID: 15783
		// (get) Token: 0x06022C48 RID: 142408 RVA: 0x00911A40 File Offset: 0x0090FC40
		// (set) Token: 0x06022C49 RID: 142409 RVA: 0x00911A54 File Offset: 0x0090FC54
		public unsafe UStaticMeshComponent blast_small6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003DA8 RID: 15784
		// (get) Token: 0x06022C4A RID: 142410 RVA: 0x00911A69 File Offset: 0x0090FC69
		// (set) Token: 0x06022C4B RID: 142411 RVA: 0x00911A7D File Offset: 0x0090FC7D
		public unsafe UStaticMeshComponent blast_small2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17003DA9 RID: 15785
		// (get) Token: 0x06022C4C RID: 142412 RVA: 0x00911A92 File Offset: 0x0090FC92
		// (set) Token: 0x06022C4D RID: 142413 RVA: 0x00911AA6 File Offset: 0x0090FCA6
		public unsafe UStaticMeshComponent blast_small3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17003DAA RID: 15786
		// (get) Token: 0x06022C4E RID: 142414 RVA: 0x00911ABB File Offset: 0x0090FCBB
		// (set) Token: 0x06022C4F RID: 142415 RVA: 0x00911ACF File Offset: 0x0090FCCF
		public unsafe UStaticMeshComponent blast_small1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17003DAB RID: 15787
		// (get) Token: 0x06022C50 RID: 142416 RVA: 0x00911AE4 File Offset: 0x0090FCE4
		// (set) Token: 0x06022C51 RID: 142417 RVA: 0x00911AF8 File Offset: 0x0090FCF8
		public unsafe UPhysicsConstraintComponent cons_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17003DAC RID: 15788
		// (get) Token: 0x06022C52 RID: 142418 RVA: 0x00911B0D File Offset: 0x0090FD0D
		// (set) Token: 0x06022C53 RID: 142419 RVA: 0x00911B21 File Offset: 0x0090FD21
		public unsafe UStaticMeshComponent blast_back_cover
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17003DAD RID: 15789
		// (get) Token: 0x06022C54 RID: 142420 RVA: 0x00911B36 File Offset: 0x0090FD36
		// (set) Token: 0x06022C55 RID: 142421 RVA: 0x00911B4A File Offset: 0x0090FD4A
		public unsafe UStaticMeshComponent blast_wheel3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17003DAE RID: 15790
		// (get) Token: 0x06022C56 RID: 142422 RVA: 0x00911B5F File Offset: 0x0090FD5F
		// (set) Token: 0x06022C57 RID: 142423 RVA: 0x00911B73 File Offset: 0x0090FD73
		public unsafe UStaticMeshComponent blast_wheel2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003DAF RID: 15791
		// (get) Token: 0x06022C58 RID: 142424 RVA: 0x00911B88 File Offset: 0x0090FD88
		// (set) Token: 0x06022C59 RID: 142425 RVA: 0x00911B9C File Offset: 0x0090FD9C
		public unsafe UStaticMeshComponent blast_wheel1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17003DB0 RID: 15792
		// (get) Token: 0x06022C5A RID: 142426 RVA: 0x00911BB1 File Offset: 0x0090FDB1
		// (set) Token: 0x06022C5B RID: 142427 RVA: 0x00911BC5 File Offset: 0x0090FDC5
		public unsafe UStaticMeshComponent blast_wheel4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17003DB1 RID: 15793
		// (get) Token: 0x06022C5C RID: 142428 RVA: 0x00911BDA File Offset: 0x0090FDDA
		// (set) Token: 0x06022C5D RID: 142429 RVA: 0x00911BEE File Offset: 0x0090FDEE
		public unsafe UStaticMeshComponent blast_front_cover
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17003DB2 RID: 15794
		// (get) Token: 0x06022C5E RID: 142430 RVA: 0x00911C03 File Offset: 0x0090FE03
		// (set) Token: 0x06022C5F RID: 142431 RVA: 0x00911C17 File Offset: 0x0090FE17
		public unsafe UPhysicsConstraintComponent cons_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17003DB3 RID: 15795
		// (get) Token: 0x06022C60 RID: 142432 RVA: 0x00911C2C File Offset: 0x0090FE2C
		// (set) Token: 0x06022C61 RID: 142433 RVA: 0x00911C40 File Offset: 0x0090FE40
		public unsafe UPhysicsConstraintComponent cons_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x17003DB4 RID: 15796
		// (get) Token: 0x06022C62 RID: 142434 RVA: 0x00911C55 File Offset: 0x0090FE55
		// (set) Token: 0x06022C63 RID: 142435 RVA: 0x00911C69 File Offset: 0x0090FE69
		public unsafe UPhysicsConstraintComponent cons_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x17003DB5 RID: 15797
		// (get) Token: 0x06022C64 RID: 142436 RVA: 0x00911C7E File Offset: 0x0090FE7E
		// (set) Token: 0x06022C65 RID: 142437 RVA: 0x00911C92 File Offset: 0x0090FE92
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x06022C66 RID: 142438 RVA: 0x00911CA7 File Offset: 0x0090FEA7
		// (set) Token: 0x06022C67 RID: 142439 RVA: 0x00911CBB File Offset: 0x0090FEBB
		public unsafe UStaticMeshComponent SM_vehicleDamage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x06022C68 RID: 142440 RVA: 0x00911CD0 File Offset: 0x0090FED0
		// (set) Token: 0x06022C69 RID: 142441 RVA: 0x00911CE4 File Offset: 0x0090FEE4
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x17003DB8 RID: 15800
		// (get) Token: 0x06022C6A RID: 142442 RVA: 0x00911CF9 File Offset: 0x0090FEF9
		// (set) Token: 0x06022C6B RID: 142443 RVA: 0x00911D0D File Offset: 0x0090FF0D
		public unsafe UMaterialInstanceDynamic StampMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x17003DB9 RID: 15801
		// (get) Token: 0x06022C6C RID: 142444 RVA: 0x00911D24 File Offset: 0x0090FF24
		// (set) Token: 0x06022C6D RID: 142445 RVA: 0x00911D5D File Offset: 0x0090FF5D
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
					result = (this._CarAllMats = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_36, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CarAllMats.CopyAssign(value);
			}
		}

		// Token: 0x17003DBA RID: 15802
		// (get) Token: 0x06022C6E RID: 142446 RVA: 0x00911D6B File Offset: 0x0090FF6B
		// (set) Token: 0x06022C6F RID: 142447 RVA: 0x00911D7F File Offset: 0x0090FF7F
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x17003DBB RID: 15803
		// (get) Token: 0x06022C70 RID: 142448 RVA: 0x00911D94 File Offset: 0x0090FF94
		// (set) Token: 0x06022C71 RID: 142449 RVA: 0x00911DA4 File Offset: 0x0090FFA4
		public unsafe float HitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17003DBC RID: 15804
		// (get) Token: 0x06022C72 RID: 142450 RVA: 0x00911DB5 File Offset: 0x0090FFB5
		// (set) Token: 0x06022C73 RID: 142451 RVA: 0x00911DC5 File Offset: 0x0090FFC5
		public unsafe float TraceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17003DBD RID: 15805
		// (get) Token: 0x06022C74 RID: 142452 RVA: 0x00911DD6 File Offset: 0x0090FFD6
		// (set) Token: 0x06022C75 RID: 142453 RVA: 0x00911DEA File Offset: 0x0090FFEA
		public unsafe FVector CurWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17003DBE RID: 15806
		// (get) Token: 0x06022C76 RID: 142454 RVA: 0x00911DFF File Offset: 0x0090FFFF
		// (set) Token: 0x06022C77 RID: 142455 RVA: 0x00911E13 File Offset: 0x00910013
		public unsafe FVector hittingPoint_world_position_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17003DBF RID: 15807
		// (get) Token: 0x06022C78 RID: 142456 RVA: 0x00911E28 File Offset: 0x00910028
		// (set) Token: 0x06022C79 RID: 142457 RVA: 0x00911E3C File Offset: 0x0091003C
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17003DC0 RID: 15808
		// (get) Token: 0x06022C7A RID: 142458 RVA: 0x00911E51 File Offset: 0x00910051
		// (set) Token: 0x06022C7B RID: 142459 RVA: 0x00911E65 File Offset: 0x00910065
		public unsafe UTextureRenderTarget2D SkinMaskRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_43);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_43, value);
			}
		}

		// Token: 0x17003DC1 RID: 15809
		// (get) Token: 0x06022C7C RID: 142460 RVA: 0x00911E7A File Offset: 0x0091007A
		// (set) Token: 0x06022C7D RID: 142461 RVA: 0x00911E8E File Offset: 0x0091008E
		public unsafe UTexture2D TreePosTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_44);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_44, value);
			}
		}

		// Token: 0x17003DC2 RID: 15810
		// (get) Token: 0x06022C7E RID: 142462 RVA: 0x00911EA3 File Offset: 0x009100A3
		// (set) Token: 0x06022C7F RID: 142463 RVA: 0x00911EB7 File Offset: 0x009100B7
		public unsafe FVector LastWeaponPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17003DC3 RID: 15811
		// (get) Token: 0x06022C80 RID: 142464 RVA: 0x00911ECC File Offset: 0x009100CC
		// (set) Token: 0x06022C81 RID: 142465 RVA: 0x00911EDC File Offset: 0x009100DC
		public unsafe bool LastPointUseAble
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DC4 RID: 15812
		// (get) Token: 0x06022C82 RID: 142466 RVA: 0x00911EED File Offset: 0x009100ED
		// (set) Token: 0x06022C83 RID: 142467 RVA: 0x00911EFD File Offset: 0x009100FD
		public unsafe bool debugWeapon_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_47) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_47) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DC5 RID: 15813
		// (get) Token: 0x06022C84 RID: 142468 RVA: 0x00911F0E File Offset: 0x0091010E
		// (set) Token: 0x06022C85 RID: 142469 RVA: 0x00911F1E File Offset: 0x0091011E
		public unsafe bool debugDamage_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DC6 RID: 15814
		// (get) Token: 0x06022C86 RID: 142470 RVA: 0x00911F30 File Offset: 0x00910130
		// (set) Token: 0x06022C87 RID: 142471 RVA: 0x00911F69 File Offset: 0x00910169
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
					result = (this._SMComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_49, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SMComponents.CopyAssign(value);
			}
		}

		// Token: 0x17003DC7 RID: 15815
		// (get) Token: 0x06022C88 RID: 142472 RVA: 0x00911F78 File Offset: 0x00910178
		// (set) Token: 0x06022C89 RID: 142473 RVA: 0x00911FB1 File Offset: 0x009101B1
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
					result = (this._SMHealth = new TArray<float>(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_50, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SMHealth.CopyAssign(value);
			}
		}

		// Token: 0x17003DC8 RID: 15816
		// (get) Token: 0x06022C8A RID: 142474 RVA: 0x00911FC0 File Offset: 0x009101C0
		// (set) Token: 0x06022C8B RID: 142475 RVA: 0x00911FF9 File Offset: 0x009101F9
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
					result = (this._ConsArr = new TArray<UPhysicsConstraintComponent>(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_51, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ConsArr.CopyAssign(value);
			}
		}

		// Token: 0x17003DC9 RID: 15817
		// (get) Token: 0x06022C8C RID: 142476 RVA: 0x00912008 File Offset: 0x00910208
		// (set) Token: 0x06022C8D RID: 142477 RVA: 0x00912041 File Offset: 0x00910241
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
					result = (this._ForceArr = new TArray<FVector>(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_52, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ForceArr.CopyAssign(value);
			}
		}

		// Token: 0x17003DCA RID: 15818
		// (get) Token: 0x06022C8E RID: 142478 RVA: 0x0091204F File Offset: 0x0091024F
		// (set) Token: 0x06022C8F RID: 142479 RVA: 0x0091205F File Offset: 0x0091025F
		public unsafe bool NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_53) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_53) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DCB RID: 15819
		// (get) Token: 0x06022C90 RID: 142480 RVA: 0x00912070 File Offset: 0x00910270
		// (set) Token: 0x06022C91 RID: 142481 RVA: 0x00912084 File Offset: 0x00910284
		public unsafe FVector LastHitPositon
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x17003DCC RID: 15820
		// (get) Token: 0x06022C92 RID: 142482 RVA: 0x0091209C File Offset: 0x0091029C
		// (set) Token: 0x06022C93 RID: 142483 RVA: 0x009120D5 File Offset: 0x009102D5
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
					result = (this._Wheels = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_55, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Wheels.CopyAssign(value);
			}
		}

		// Token: 0x17003DCD RID: 15821
		// (get) Token: 0x06022C94 RID: 142484 RVA: 0x009120E3 File Offset: 0x009102E3
		// (set) Token: 0x06022C95 RID: 142485 RVA: 0x009120F7 File Offset: 0x009102F7
		public unsafe UNiagaraSystem NS_Bloom
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_56);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_56, value);
			}
		}

		// Token: 0x17003DCE RID: 15822
		// (get) Token: 0x06022C96 RID: 142486 RVA: 0x0091210C File Offset: 0x0091030C
		// (set) Token: 0x06022C97 RID: 142487 RVA: 0x00912120 File Offset: 0x00910320
		public unsafe UNiagaraSystem NS_Attack
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_57);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_57, value);
			}
		}

		// Token: 0x17003DCF RID: 15823
		// (get) Token: 0x06022C98 RID: 142488 RVA: 0x00912135 File Offset: 0x00910335
		// (set) Token: 0x06022C99 RID: 142489 RVA: 0x00912145 File Offset: 0x00910345
		public unsafe bool EngineAlreadyBreak
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_58) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_58) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DD0 RID: 15824
		// (get) Token: 0x06022C9A RID: 142490 RVA: 0x00912156 File Offset: 0x00910356
		// (set) Token: 0x06022C9B RID: 142491 RVA: 0x00912166 File Offset: 0x00910366
		public unsafe bool EngineBreakOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_59) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_59) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DD1 RID: 15825
		// (get) Token: 0x06022C9C RID: 142492 RVA: 0x00912177 File Offset: 0x00910377
		// (set) Token: 0x06022C9D RID: 142493 RVA: 0x00912187 File Offset: 0x00910387
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_60) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_60) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DD2 RID: 15826
		// (get) Token: 0x06022C9E RID: 142494 RVA: 0x00912198 File Offset: 0x00910398
		// (set) Token: 0x06022C9F RID: 142495 RVA: 0x009121AC File Offset: 0x009103AC
		public unsafe UNiagaraSystem NS_CarFire
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_61);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_61, value);
			}
		}

		// Token: 0x17003DD3 RID: 15827
		// (get) Token: 0x06022CA0 RID: 142496 RVA: 0x009121C1 File Offset: 0x009103C1
		// (set) Token: 0x06022CA1 RID: 142497 RVA: 0x009121D5 File Offset: 0x009103D5
		public unsafe UNiagaraSystem NS_EngineFire
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_62);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_62, value);
			}
		}

		// Token: 0x17003DD4 RID: 15828
		// (get) Token: 0x06022CA2 RID: 142498 RVA: 0x009121EA File Offset: 0x009103EA
		// (set) Token: 0x06022CA3 RID: 142499 RVA: 0x009121FA File Offset: 0x009103FA
		public unsafe bool bDebug_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_63) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_63) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DD5 RID: 15829
		// (get) Token: 0x06022CA4 RID: 142500 RVA: 0x0091220B File Offset: 0x0091040B
		// (set) Token: 0x06022CA5 RID: 142501 RVA: 0x0091221F File Offset: 0x0091041F
		public unsafe UNiagaraSystem NS_TireBroken
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_64);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_64, value);
			}
		}

		// Token: 0x17003DD6 RID: 15830
		// (get) Token: 0x06022CA6 RID: 142502 RVA: 0x00912234 File Offset: 0x00910434
		// (set) Token: 0x06022CA7 RID: 142503 RVA: 0x00912244 File Offset: 0x00910444
		public unsafe bool bIsOpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_65) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_65) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DD7 RID: 15831
		// (get) Token: 0x06022CA8 RID: 142504 RVA: 0x00912255 File Offset: 0x00910455
		// (set) Token: 0x06022CA9 RID: 142505 RVA: 0x00912265 File Offset: 0x00910465
		public unsafe bool bIsTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_66) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_66) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DD8 RID: 15832
		// (get) Token: 0x06022CAA RID: 142506 RVA: 0x00912276 File Offset: 0x00910476
		// (set) Token: 0x06022CAB RID: 142507 RVA: 0x0091228A File Offset: 0x0091048A
		public unsafe FTransform LeftTrans1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_67);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_67) = value;
			}
		}

		// Token: 0x17003DD9 RID: 15833
		// (get) Token: 0x06022CAC RID: 142508 RVA: 0x0091229F File Offset: 0x0091049F
		// (set) Token: 0x06022CAD RID: 142509 RVA: 0x009122B3 File Offset: 0x009104B3
		public unsafe FTransform LeftTrans2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_68);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_68) = value;
			}
		}

		// Token: 0x17003DDA RID: 15834
		// (get) Token: 0x06022CAE RID: 142510 RVA: 0x009122C8 File Offset: 0x009104C8
		// (set) Token: 0x06022CAF RID: 142511 RVA: 0x009122DC File Offset: 0x009104DC
		public unsafe FTransform LeftTrans3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_69);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_69) = value;
			}
		}

		// Token: 0x17003DDB RID: 15835
		// (get) Token: 0x06022CB0 RID: 142512 RVA: 0x009122F1 File Offset: 0x009104F1
		// (set) Token: 0x06022CB1 RID: 142513 RVA: 0x00912305 File Offset: 0x00910505
		public unsafe FTransform RightTrans1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_70);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_70) = value;
			}
		}

		// Token: 0x17003DDC RID: 15836
		// (get) Token: 0x06022CB2 RID: 142514 RVA: 0x0091231A File Offset: 0x0091051A
		// (set) Token: 0x06022CB3 RID: 142515 RVA: 0x0091232E File Offset: 0x0091052E
		public unsafe FTransform RightTrans2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_71);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_71) = value;
			}
		}

		// Token: 0x17003DDD RID: 15837
		// (get) Token: 0x06022CB4 RID: 142516 RVA: 0x00912343 File Offset: 0x00910543
		// (set) Token: 0x06022CB5 RID: 142517 RVA: 0x00912357 File Offset: 0x00910557
		public unsafe FTransform RightTrans3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_72);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_72) = value;
			}
		}

		// Token: 0x17003DDE RID: 15838
		// (get) Token: 0x06022CB6 RID: 142518 RVA: 0x0091236C File Offset: 0x0091056C
		// (set) Token: 0x06022CB7 RID: 142519 RVA: 0x00912380 File Offset: 0x00910580
		public unsafe UAkAudioEvent CloseDoorSound
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_73);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_73, value);
			}
		}

		// Token: 0x17003DDF RID: 15839
		// (get) Token: 0x06022CB8 RID: 142520 RVA: 0x00912395 File Offset: 0x00910595
		// (set) Token: 0x06022CB9 RID: 142521 RVA: 0x009123A9 File Offset: 0x009105A9
		public unsafe UAkAudioEvent OpenDoorSound
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_74);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_type2_C.__PropertyOffset_74, value);
			}
		}

		// Token: 0x17003DE0 RID: 15840
		// (get) Token: 0x06022CBA RID: 142522 RVA: 0x009123BE File Offset: 0x009105BE
		// (set) Token: 0x06022CBB RID: 142523 RVA: 0x009123CE File Offset: 0x009105CE
		public unsafe float dtForNiagara
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_75);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_75) = value;
			}
		}

		// Token: 0x17003DE1 RID: 15841
		// (get) Token: 0x06022CBC RID: 142524 RVA: 0x009123DF File Offset: 0x009105DF
		// (set) Token: 0x06022CBD RID: 142525 RVA: 0x009123EF File Offset: 0x009105EF
		public unsafe int thisFrameWeaponID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_76);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_76) = value;
			}
		}

		// Token: 0x17003DE2 RID: 15842
		// (get) Token: 0x06022CBE RID: 142526 RVA: 0x00912400 File Offset: 0x00910600
		// (set) Token: 0x06022CBF RID: 142527 RVA: 0x00912410 File Offset: 0x00910610
		public unsafe int lastFrameWeaponID_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_77);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_type2_C.__PropertyOffset_77) = value;
			}
		}

		// Token: 0x06022CC0 RID: 142528 RVA: 0x00912424 File Offset: 0x00910624
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CreateDM(UStaticMeshComponent Component)
		{
			BP_VehicleDamage_type2_C.__CreateDM_FunctionParams* ptr = stackalloc BP_VehicleDamage_type2_C.__CreateDM_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_VehicleDamage_type2_C.__CreateDM_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_type2_C.__CreateDM_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Component = ((Component != null) ? Component.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__CreateDM_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022CC1 RID: 142529 RVA: 0x00912479 File Offset: 0x00910679
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022CC2 RID: 142530 RVA: 0x0091248D File Offset: 0x0091068D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022CC3 RID: 142531 RVA: 0x009124A4 File Offset: 0x009106A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_288D18084A520619C86AF88579BB211B(int PlayingID)
		{
			BP_VehicleDamage_type2_C.__Completed_288D18084A520619C86AF88579BB211B_FunctionParams* ptr = stackalloc BP_VehicleDamage_type2_C.__Completed_288D18084A520619C86AF88579BB211B_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_type2_C.__Completed_288D18084A520619C86AF88579BB211B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_type2_C.__Completed_288D18084A520619C86AF88579BB211B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__Completed_288D18084A520619C86AF88579BB211B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022CC4 RID: 142532 RVA: 0x009124EC File Offset: 0x009106EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_A1D80AE34A6FB523D2E3408304A08CA8(int PlayingID)
		{
			BP_VehicleDamage_type2_C.__Completed_A1D80AE34A6FB523D2E3408304A08CA8_FunctionParams* ptr = stackalloc BP_VehicleDamage_type2_C.__Completed_A1D80AE34A6FB523D2E3408304A08CA8_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_type2_C.__Completed_A1D80AE34A6FB523D2E3408304A08CA8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_type2_C.__Completed_A1D80AE34A6FB523D2E3408304A08CA8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__Completed_A1D80AE34A6FB523D2E3408304A08CA8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022CC5 RID: 142533 RVA: 0x00912534 File Offset: 0x00910734
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_325847C543568188EA0591BC9EE24EE7(int PlayingID)
		{
			BP_VehicleDamage_type2_C.__Completed_325847C543568188EA0591BC9EE24EE7_FunctionParams* ptr = stackalloc BP_VehicleDamage_type2_C.__Completed_325847C543568188EA0591BC9EE24EE7_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_type2_C.__Completed_325847C543568188EA0591BC9EE24EE7_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_type2_C.__Completed_325847C543568188EA0591BC9EE24EE7_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__Completed_325847C543568188EA0591BC9EE24EE7_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022CC6 RID: 142534 RVA: 0x0091257A File Offset: 0x0091077A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022CC7 RID: 142535 RVA: 0x0091258E File Offset: 0x0091078E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022CC8 RID: 142536 RVA: 0x009125A4 File Offset: 0x009107A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VehicleDamage_type2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VehicleDamage_type2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_type2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_type2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022CC9 RID: 142537 RVA: 0x009125EC File Offset: 0x009107EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VehicleDamage_type2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VehicleDamage_type2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_type2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_type2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022CCA RID: 142538 RVA: 0x00912634 File Offset: 0x00910834
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_VehicleDamage_type2_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_VehicleDamage_type2_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_VehicleDamage_type2_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_type2_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022CCB RID: 142539 RVA: 0x00912697 File Offset: 0x00910897
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__CustomEvent1_NativeFunctionPtr, null);
		}

		// Token: 0x06022CCC RID: 142540 RVA: 0x009126AB File Offset: 0x009108AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__CustomEvent_NativeFunctionPtr, null);
		}

		// Token: 0x06022CCD RID: 142541 RVA: 0x009126BF File Offset: 0x009108BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06022CCE RID: 142542 RVA: 0x009126D3 File Offset: 0x009108D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void test()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__test_NativeFunctionPtr, null);
		}

		// Token: 0x06022CCF RID: 142543 RVA: 0x009126E8 File Offset: 0x009108E8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnVehiclePartBroken_Event_0(int PartIndex, string PartName)
		{
			BP_VehicleDamage_type2_C.__OnVehiclePartBroken_Event_0_FunctionParams* ptr = stackalloc BP_VehicleDamage_type2_C.__OnVehiclePartBroken_Event_0_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_VehicleDamage_type2_C.__OnVehiclePartBroken_Event_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_type2_C.__OnVehiclePartBroken_Event_0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PartIndex = PartIndex;
			FString.CopyFrom((void*)(&ptr->PartName), PartName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_type2_C.__OnVehiclePartBroken_Event_0_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_VehicleDamage_type2_C.__OnVehiclePartBroken_Event_0_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022CD0 RID: 142544 RVA: 0x0091274C File Offset: 0x0091094C
		protected BP_VehicleDamage_type2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011187 RID: 70023
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/VehicleDamage/BP_VehicleDamage_type2.BP_VehicleDamage_type2_C";

		// Token: 0x04011188 RID: 70024
		private static IntPtr _ClassPtr;

		// Token: 0x04011189 RID: 70025
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401118A RID: 70026
		internal static int __PropertyOffset_1;

		// Token: 0x0401118B RID: 70027
		internal static int __PropertyOffset_2;

		// Token: 0x0401118C RID: 70028
		internal static int __PropertyOffset_3;

		// Token: 0x0401118D RID: 70029
		internal static int __PropertyOffset_4;

		// Token: 0x0401118E RID: 70030
		internal static int __PropertyOffset_5;

		// Token: 0x0401118F RID: 70031
		internal static int __PropertyOffset_6;

		// Token: 0x04011190 RID: 70032
		internal static int __PropertyOffset_7;

		// Token: 0x04011191 RID: 70033
		internal static int __PropertyOffset_8;

		// Token: 0x04011192 RID: 70034
		internal static int __PropertyOffset_9;

		// Token: 0x04011193 RID: 70035
		internal static int __PropertyOffset_10;

		// Token: 0x04011194 RID: 70036
		internal static int __PropertyOffset_11;

		// Token: 0x04011195 RID: 70037
		internal static int __PropertyOffset_12;

		// Token: 0x04011196 RID: 70038
		internal static int __PropertyOffset_13;

		// Token: 0x04011197 RID: 70039
		internal static int __PropertyOffset_14;

		// Token: 0x04011198 RID: 70040
		internal static int __PropertyOffset_15;

		// Token: 0x04011199 RID: 70041
		internal static int __PropertyOffset_16;

		// Token: 0x0401119A RID: 70042
		internal static int __PropertyOffset_17;

		// Token: 0x0401119B RID: 70043
		internal static int __PropertyOffset_18;

		// Token: 0x0401119C RID: 70044
		internal static int __PropertyOffset_19;

		// Token: 0x0401119D RID: 70045
		internal static int __PropertyOffset_20;

		// Token: 0x0401119E RID: 70046
		internal static int __PropertyOffset_21;

		// Token: 0x0401119F RID: 70047
		internal static int __PropertyOffset_22;

		// Token: 0x040111A0 RID: 70048
		internal static int __PropertyOffset_23;

		// Token: 0x040111A1 RID: 70049
		internal static int __PropertyOffset_24;

		// Token: 0x040111A2 RID: 70050
		internal static int __PropertyOffset_25;

		// Token: 0x040111A3 RID: 70051
		internal static int __PropertyOffset_26;

		// Token: 0x040111A4 RID: 70052
		internal static int __PropertyOffset_27;

		// Token: 0x040111A5 RID: 70053
		internal static int __PropertyOffset_28;

		// Token: 0x040111A6 RID: 70054
		internal static int __PropertyOffset_29;

		// Token: 0x040111A7 RID: 70055
		internal static int __PropertyOffset_30;

		// Token: 0x040111A8 RID: 70056
		internal static int __PropertyOffset_31;

		// Token: 0x040111A9 RID: 70057
		internal static int __PropertyOffset_32;

		// Token: 0x040111AA RID: 70058
		internal static int __PropertyOffset_33;

		// Token: 0x040111AB RID: 70059
		internal static int __PropertyOffset_34;

		// Token: 0x040111AC RID: 70060
		internal static int __PropertyOffset_35;

		// Token: 0x040111AD RID: 70061
		internal static int __PropertyOffset_36;

		// Token: 0x040111AE RID: 70062
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _CarAllMats;

		// Token: 0x040111AF RID: 70063
		internal static int __PropertyOffset_37;

		// Token: 0x040111B0 RID: 70064
		internal static int __PropertyOffset_38;

		// Token: 0x040111B1 RID: 70065
		internal static int __PropertyOffset_39;

		// Token: 0x040111B2 RID: 70066
		internal static int __PropertyOffset_40;

		// Token: 0x040111B3 RID: 70067
		internal static int __PropertyOffset_41;

		// Token: 0x040111B4 RID: 70068
		internal static int __PropertyOffset_42;

		// Token: 0x040111B5 RID: 70069
		internal static int __PropertyOffset_43;

		// Token: 0x040111B6 RID: 70070
		internal static int __PropertyOffset_44;

		// Token: 0x040111B7 RID: 70071
		internal static int __PropertyOffset_45;

		// Token: 0x040111B8 RID: 70072
		internal static int __PropertyOffset_46;

		// Token: 0x040111B9 RID: 70073
		internal static int __PropertyOffset_47;

		// Token: 0x040111BA RID: 70074
		internal static int __PropertyOffset_48;

		// Token: 0x040111BB RID: 70075
		internal static int __PropertyOffset_49;

		// Token: 0x040111BC RID: 70076
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _SMComponents;

		// Token: 0x040111BD RID: 70077
		internal static int __PropertyOffset_50;

		// Token: 0x040111BE RID: 70078
		private TArray<float> _SMHealth;

		// Token: 0x040111BF RID: 70079
		internal static int __PropertyOffset_51;

		// Token: 0x040111C0 RID: 70080
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicsConstraintComponent> _ConsArr;

		// Token: 0x040111C1 RID: 70081
		internal static int __PropertyOffset_52;

		// Token: 0x040111C2 RID: 70082
		private TArray<FVector> _ForceArr;

		// Token: 0x040111C3 RID: 70083
		internal static int __PropertyOffset_53;

		// Token: 0x040111C4 RID: 70084
		internal static int __PropertyOffset_54;

		// Token: 0x040111C5 RID: 70085
		internal static int __PropertyOffset_55;

		// Token: 0x040111C6 RID: 70086
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _Wheels;

		// Token: 0x040111C7 RID: 70087
		internal static int __PropertyOffset_56;

		// Token: 0x040111C8 RID: 70088
		internal static int __PropertyOffset_57;

		// Token: 0x040111C9 RID: 70089
		internal static int __PropertyOffset_58;

		// Token: 0x040111CA RID: 70090
		internal static int __PropertyOffset_59;

		// Token: 0x040111CB RID: 70091
		internal static int __PropertyOffset_60;

		// Token: 0x040111CC RID: 70092
		internal static int __PropertyOffset_61;

		// Token: 0x040111CD RID: 70093
		internal static int __PropertyOffset_62;

		// Token: 0x040111CE RID: 70094
		internal static int __PropertyOffset_63;

		// Token: 0x040111CF RID: 70095
		internal static int __PropertyOffset_64;

		// Token: 0x040111D0 RID: 70096
		internal static int __PropertyOffset_65;

		// Token: 0x040111D1 RID: 70097
		internal static int __PropertyOffset_66;

		// Token: 0x040111D2 RID: 70098
		internal static int __PropertyOffset_67;

		// Token: 0x040111D3 RID: 70099
		internal static int __PropertyOffset_68;

		// Token: 0x040111D4 RID: 70100
		internal static int __PropertyOffset_69;

		// Token: 0x040111D5 RID: 70101
		internal static int __PropertyOffset_70;

		// Token: 0x040111D6 RID: 70102
		internal static int __PropertyOffset_71;

		// Token: 0x040111D7 RID: 70103
		internal static int __PropertyOffset_72;

		// Token: 0x040111D8 RID: 70104
		internal static int __PropertyOffset_73;

		// Token: 0x040111D9 RID: 70105
		internal static int __PropertyOffset_74;

		// Token: 0x040111DA RID: 70106
		internal static int __PropertyOffset_75;

		// Token: 0x040111DB RID: 70107
		internal static int __PropertyOffset_76;

		// Token: 0x040111DC RID: 70108
		internal static int __PropertyOffset_77;

		// Token: 0x040111DD RID: 70109
		private static IntPtr __CreateDM_NativeFunctionPtr;

		// Token: 0x040111DE RID: 70110
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040111DF RID: 70111
		private static IntPtr __Completed_288D18084A520619C86AF88579BB211B_NativeFunctionPtr;

		// Token: 0x040111E0 RID: 70112
		private static IntPtr __Completed_A1D80AE34A6FB523D2E3408304A08CA8_NativeFunctionPtr;

		// Token: 0x040111E1 RID: 70113
		private static IntPtr __Completed_325847C543568188EA0591BC9EE24EE7_NativeFunctionPtr;

		// Token: 0x040111E2 RID: 70114
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040111E3 RID: 70115
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040111E4 RID: 70116
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x040111E5 RID: 70117
		private static IntPtr __CustomEvent1_NativeFunctionPtr;

		// Token: 0x040111E6 RID: 70118
		private static IntPtr __CustomEvent_NativeFunctionPtr;

		// Token: 0x040111E7 RID: 70119
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040111E8 RID: 70120
		private static IntPtr __test_NativeFunctionPtr;

		// Token: 0x040111E9 RID: 70121
		private static IntPtr __OnVehiclePartBroken_Event_0_NativeFunctionPtr;

		// Token: 0x02009DC5 RID: 40389
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __CreateDM_FunctionParams
		{
			// Token: 0x040315B5 RID: 202165
			[FieldOffset(0)]
			public IntPtr Component;
		}

		// Token: 0x02009DC6 RID: 40390
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_288D18084A520619C86AF88579BB211B_FunctionParams
		{
			// Token: 0x040315B6 RID: 202166
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009DC7 RID: 40391
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_A1D80AE34A6FB523D2E3408304A08CA8_FunctionParams
		{
			// Token: 0x040315B7 RID: 202167
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009DC8 RID: 40392
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_325847C543568188EA0591BC9EE24EE7_FunctionParams
		{
			// Token: 0x040315B8 RID: 202168
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009DC9 RID: 40393
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040315B9 RID: 202169
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DCA RID: 40394
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x040315BA RID: 202170
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x040315BB RID: 202171
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x040315BC RID: 202172
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009DCB RID: 40395
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnVehiclePartBroken_Event_0_FunctionParams
		{
			// Token: 0x040315BD RID: 202173
			[FieldOffset(0)]
			public int PartIndex;

			// Token: 0x040315BE RID: 202174
			[FieldOffset(8)]
			public FString PartName;
		}
	}
}
