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
	// Token: 0x02003BE7 RID: 15335
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/VehicleDamage/BP_VehicleDamage_DoorOpen.BP_VehicleDamage_DoorOpen_C")]
	[UnrealStructLayout(2832, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2828)]
	public class BP_VehicleDamage_DoorOpen_C : AKuroVehicleDestructionActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022B2D RID: 142125 RVA: 0x0090FFB9 File Offset: 0x0090E1B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VehicleDamage_DoorOpen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/VehicleDamage/BP_VehicleDamage_DoorOpen.BP_VehicleDamage_DoorOpen_C");
			}
			return BP_VehicleDamage_DoorOpen_C._ClassPtr;
		}

		// Token: 0x06022B2E RID: 142126 RVA: 0x0090FFE0 File Offset: 0x0090E1E0
		public BP_VehicleDamage_DoorOpen_C() : this(BuiltinUtils.AllocNativeUObject(BP_VehicleDamage_DoorOpen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022B2F RID: 142127 RVA: 0x00910008 File Offset: 0x0090E208
		[NullableContext(1)]
		public BP_VehicleDamage_DoorOpen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VehicleDamage_DoorOpen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003D2F RID: 15663
		// (get) Token: 0x06022B30 RID: 142128 RVA: 0x0091003B File Offset: 0x0090E23B
		// (set) Token: 0x06022B31 RID: 142129 RVA: 0x0091004F File Offset: 0x0090E24F
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003D30 RID: 15664
		// (get) Token: 0x06022B32 RID: 142130 RVA: 0x00910064 File Offset: 0x0090E264
		// (set) Token: 0x06022B33 RID: 142131 RVA: 0x00910078 File Offset: 0x0090E278
		public unsafe UBoxComponent BoxTrigger
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003D31 RID: 15665
		// (get) Token: 0x06022B34 RID: 142132 RVA: 0x0091008D File Offset: 0x0090E28D
		// (set) Token: 0x06022B35 RID: 142133 RVA: 0x009100A1 File Offset: 0x0090E2A1
		public unsafe UStaticMeshComponent blast_10
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003D32 RID: 15666
		// (get) Token: 0x06022B36 RID: 142134 RVA: 0x009100B6 File Offset: 0x0090E2B6
		// (set) Token: 0x06022B37 RID: 142135 RVA: 0x009100CA File Offset: 0x0090E2CA
		public unsafe UBoxComponent myCustomBlock
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003D33 RID: 15667
		// (get) Token: 0x06022B38 RID: 142136 RVA: 0x009100DF File Offset: 0x0090E2DF
		// (set) Token: 0x06022B39 RID: 142137 RVA: 0x009100F3 File Offset: 0x0090E2F3
		public unsafe UNiagaraComponent NS_VehicleFire
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003D34 RID: 15668
		// (get) Token: 0x06022B3A RID: 142138 RVA: 0x00910108 File Offset: 0x0090E308
		// (set) Token: 0x06022B3B RID: 142139 RVA: 0x0091011C File Offset: 0x0090E31C
		public unsafe UNiagaraComponent NS_VehicleBloom
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003D35 RID: 15669
		// (get) Token: 0x06022B3C RID: 142140 RVA: 0x00910131 File Offset: 0x0090E331
		// (set) Token: 0x06022B3D RID: 142141 RVA: 0x00910145 File Offset: 0x0090E345
		public unsafe UBoxComponent ValidAttackBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x06022B3E RID: 142142 RVA: 0x0091015A File Offset: 0x0090E35A
		// (set) Token: 0x06022B3F RID: 142143 RVA: 0x0091016E File Offset: 0x0090E36E
		public unsafe UNiagaraComponent NS_engineFly
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x06022B40 RID: 142144 RVA: 0x00910183 File Offset: 0x0090E383
		// (set) Token: 0x06022B41 RID: 142145 RVA: 0x00910197 File Offset: 0x0090E397
		public unsafe UStaticMeshComponent blast_small14
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x06022B42 RID: 142146 RVA: 0x009101AC File Offset: 0x0090E3AC
		// (set) Token: 0x06022B43 RID: 142147 RVA: 0x009101C0 File Offset: 0x0090E3C0
		public unsafe UStaticMeshComponent blast_small10
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003D39 RID: 15673
		// (get) Token: 0x06022B44 RID: 142148 RVA: 0x009101D5 File Offset: 0x0090E3D5
		// (set) Token: 0x06022B45 RID: 142149 RVA: 0x009101E9 File Offset: 0x0090E3E9
		public unsafe UStaticMeshComponent blast_small13
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003D3A RID: 15674
		// (get) Token: 0x06022B46 RID: 142150 RVA: 0x009101FE File Offset: 0x0090E3FE
		// (set) Token: 0x06022B47 RID: 142151 RVA: 0x00910212 File Offset: 0x0090E412
		public unsafe UStaticMeshComponent blast_small12
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003D3B RID: 15675
		// (get) Token: 0x06022B48 RID: 142152 RVA: 0x00910227 File Offset: 0x0090E427
		// (set) Token: 0x06022B49 RID: 142153 RVA: 0x0091023B File Offset: 0x0090E43B
		public unsafe UStaticMeshComponent blast_small11
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003D3C RID: 15676
		// (get) Token: 0x06022B4A RID: 142154 RVA: 0x00910250 File Offset: 0x0090E450
		// (set) Token: 0x06022B4B RID: 142155 RVA: 0x00910264 File Offset: 0x0090E464
		public unsafe UStaticMeshComponent blast_small8
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003D3D RID: 15677
		// (get) Token: 0x06022B4C RID: 142156 RVA: 0x00910279 File Offset: 0x0090E479
		// (set) Token: 0x06022B4D RID: 142157 RVA: 0x0091028D File Offset: 0x0090E48D
		public unsafe UStaticMeshComponent blast_small9
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003D3E RID: 15678
		// (get) Token: 0x06022B4E RID: 142158 RVA: 0x009102A2 File Offset: 0x0090E4A2
		// (set) Token: 0x06022B4F RID: 142159 RVA: 0x009102B6 File Offset: 0x0090E4B6
		public unsafe UStaticMeshComponent blast_small7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003D3F RID: 15679
		// (get) Token: 0x06022B50 RID: 142160 RVA: 0x009102CB File Offset: 0x0090E4CB
		// (set) Token: 0x06022B51 RID: 142161 RVA: 0x009102DF File Offset: 0x0090E4DF
		public unsafe UStaticMeshComponent blast_small5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003D40 RID: 15680
		// (get) Token: 0x06022B52 RID: 142162 RVA: 0x009102F4 File Offset: 0x0090E4F4
		// (set) Token: 0x06022B53 RID: 142163 RVA: 0x00910308 File Offset: 0x0090E508
		public unsafe UStaticMeshComponent blast_small6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003D41 RID: 15681
		// (get) Token: 0x06022B54 RID: 142164 RVA: 0x0091031D File Offset: 0x0090E51D
		// (set) Token: 0x06022B55 RID: 142165 RVA: 0x00910331 File Offset: 0x0090E531
		public unsafe UStaticMeshComponent blast_small2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17003D42 RID: 15682
		// (get) Token: 0x06022B56 RID: 142166 RVA: 0x00910346 File Offset: 0x0090E546
		// (set) Token: 0x06022B57 RID: 142167 RVA: 0x0091035A File Offset: 0x0090E55A
		public unsafe UStaticMeshComponent blast_small3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17003D43 RID: 15683
		// (get) Token: 0x06022B58 RID: 142168 RVA: 0x0091036F File Offset: 0x0090E56F
		// (set) Token: 0x06022B59 RID: 142169 RVA: 0x00910383 File Offset: 0x0090E583
		public unsafe UStaticMeshComponent blast_small1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17003D44 RID: 15684
		// (get) Token: 0x06022B5A RID: 142170 RVA: 0x00910398 File Offset: 0x0090E598
		// (set) Token: 0x06022B5B RID: 142171 RVA: 0x009103AC File Offset: 0x0090E5AC
		public unsafe UPhysicsConstraintComponent cons_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17003D45 RID: 15685
		// (get) Token: 0x06022B5C RID: 142172 RVA: 0x009103C1 File Offset: 0x0090E5C1
		// (set) Token: 0x06022B5D RID: 142173 RVA: 0x009103D5 File Offset: 0x0090E5D5
		public unsafe UStaticMeshComponent blast_back_cover
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17003D46 RID: 15686
		// (get) Token: 0x06022B5E RID: 142174 RVA: 0x009103EA File Offset: 0x0090E5EA
		// (set) Token: 0x06022B5F RID: 142175 RVA: 0x009103FE File Offset: 0x0090E5FE
		public unsafe UStaticMeshComponent blast_wheel3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17003D47 RID: 15687
		// (get) Token: 0x06022B60 RID: 142176 RVA: 0x00910413 File Offset: 0x0090E613
		// (set) Token: 0x06022B61 RID: 142177 RVA: 0x00910427 File Offset: 0x0090E627
		public unsafe UStaticMeshComponent blast_wheel2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003D48 RID: 15688
		// (get) Token: 0x06022B62 RID: 142178 RVA: 0x0091043C File Offset: 0x0090E63C
		// (set) Token: 0x06022B63 RID: 142179 RVA: 0x00910450 File Offset: 0x0090E650
		public unsafe UStaticMeshComponent blast_wheel1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17003D49 RID: 15689
		// (get) Token: 0x06022B64 RID: 142180 RVA: 0x00910465 File Offset: 0x0090E665
		// (set) Token: 0x06022B65 RID: 142181 RVA: 0x00910479 File Offset: 0x0090E679
		public unsafe UStaticMeshComponent blast_wheel4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17003D4A RID: 15690
		// (get) Token: 0x06022B66 RID: 142182 RVA: 0x0091048E File Offset: 0x0090E68E
		// (set) Token: 0x06022B67 RID: 142183 RVA: 0x009104A2 File Offset: 0x0090E6A2
		public unsafe UStaticMeshComponent blast_front_cover
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17003D4B RID: 15691
		// (get) Token: 0x06022B68 RID: 142184 RVA: 0x009104B7 File Offset: 0x0090E6B7
		// (set) Token: 0x06022B69 RID: 142185 RVA: 0x009104CB File Offset: 0x0090E6CB
		public unsafe UPhysicsConstraintComponent cons_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17003D4C RID: 15692
		// (get) Token: 0x06022B6A RID: 142186 RVA: 0x009104E0 File Offset: 0x0090E6E0
		// (set) Token: 0x06022B6B RID: 142187 RVA: 0x009104F4 File Offset: 0x0090E6F4
		public unsafe UPhysicsConstraintComponent cons_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x17003D4D RID: 15693
		// (get) Token: 0x06022B6C RID: 142188 RVA: 0x00910509 File Offset: 0x0090E709
		// (set) Token: 0x06022B6D RID: 142189 RVA: 0x0091051D File Offset: 0x0090E71D
		public unsafe UPhysicsConstraintComponent cons_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x17003D4E RID: 15694
		// (get) Token: 0x06022B6E RID: 142190 RVA: 0x00910532 File Offset: 0x0090E732
		// (set) Token: 0x06022B6F RID: 142191 RVA: 0x00910546 File Offset: 0x0090E746
		public unsafe UStaticMeshComponent blast3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x17003D4F RID: 15695
		// (get) Token: 0x06022B70 RID: 142192 RVA: 0x0091055B File Offset: 0x0090E75B
		// (set) Token: 0x06022B71 RID: 142193 RVA: 0x0091056F File Offset: 0x0090E76F
		public unsafe UStaticMeshComponent blast2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17003D50 RID: 15696
		// (get) Token: 0x06022B72 RID: 142194 RVA: 0x00910584 File Offset: 0x0090E784
		// (set) Token: 0x06022B73 RID: 142195 RVA: 0x00910598 File Offset: 0x0090E798
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x17003D51 RID: 15697
		// (get) Token: 0x06022B74 RID: 142196 RVA: 0x009105AD File Offset: 0x0090E7AD
		// (set) Token: 0x06022B75 RID: 142197 RVA: 0x009105C1 File Offset: 0x0090E7C1
		public unsafe UStaticMeshComponent SM_vehicleDamage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x17003D52 RID: 15698
		// (get) Token: 0x06022B76 RID: 142198 RVA: 0x009105D6 File Offset: 0x0090E7D6
		// (set) Token: 0x06022B77 RID: 142199 RVA: 0x009105EA File Offset: 0x0090E7EA
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x17003D53 RID: 15699
		// (get) Token: 0x06022B78 RID: 142200 RVA: 0x009105FF File Offset: 0x0090E7FF
		// (set) Token: 0x06022B79 RID: 142201 RVA: 0x0091060F File Offset: 0x0090E80F
		public unsafe float Timeline_7_NewTrack_0_20B7364843DE02C9143D21AE9B98F04E
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17003D54 RID: 15700
		// (get) Token: 0x06022B7A RID: 142202 RVA: 0x00910620 File Offset: 0x0090E820
		// (set) Token: 0x06022B7B RID: 142203 RVA: 0x00910634 File Offset: 0x0090E834
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_7__Direction_20B7364843DE02C9143D21AE9B98F04E
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_38);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17003D55 RID: 15701
		// (get) Token: 0x06022B7C RID: 142204 RVA: 0x00910649 File Offset: 0x0090E849
		// (set) Token: 0x06022B7D RID: 142205 RVA: 0x0091065D File Offset: 0x0090E85D
		public unsafe UTimelineComponent Timeline_7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x17003D56 RID: 15702
		// (get) Token: 0x06022B7E RID: 142206 RVA: 0x00910672 File Offset: 0x0090E872
		// (set) Token: 0x06022B7F RID: 142207 RVA: 0x00910682 File Offset: 0x0090E882
		public unsafe float Timeline_6_NewTrack_0_269262EA4D691CA41AC69CB2C90247D5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17003D57 RID: 15703
		// (get) Token: 0x06022B80 RID: 142208 RVA: 0x00910693 File Offset: 0x0090E893
		// (set) Token: 0x06022B81 RID: 142209 RVA: 0x009106A7 File Offset: 0x0090E8A7
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_6__Direction_269262EA4D691CA41AC69CB2C90247D5
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_41);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17003D58 RID: 15704
		// (get) Token: 0x06022B82 RID: 142210 RVA: 0x009106BC File Offset: 0x0090E8BC
		// (set) Token: 0x06022B83 RID: 142211 RVA: 0x009106D0 File Offset: 0x0090E8D0
		public unsafe UTimelineComponent Timeline_6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_42);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_42, value);
			}
		}

		// Token: 0x17003D59 RID: 15705
		// (get) Token: 0x06022B84 RID: 142212 RVA: 0x009106E5 File Offset: 0x0090E8E5
		// (set) Token: 0x06022B85 RID: 142213 RVA: 0x009106F5 File Offset: 0x0090E8F5
		public unsafe float Timeline_5_NewTrack_0_5E7D7C604D7803FE2AE69AA32AAE2AD4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17003D5A RID: 15706
		// (get) Token: 0x06022B86 RID: 142214 RVA: 0x00910706 File Offset: 0x0090E906
		// (set) Token: 0x06022B87 RID: 142215 RVA: 0x0091071A File Offset: 0x0090E91A
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_5__Direction_5E7D7C604D7803FE2AE69AA32AAE2AD4
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_44);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17003D5B RID: 15707
		// (get) Token: 0x06022B88 RID: 142216 RVA: 0x0091072F File Offset: 0x0090E92F
		// (set) Token: 0x06022B89 RID: 142217 RVA: 0x00910743 File Offset: 0x0090E943
		public unsafe UTimelineComponent Timeline_5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x17003D5C RID: 15708
		// (get) Token: 0x06022B8A RID: 142218 RVA: 0x00910758 File Offset: 0x0090E958
		// (set) Token: 0x06022B8B RID: 142219 RVA: 0x00910768 File Offset: 0x0090E968
		public unsafe float Timeline_4_NewTrack_0_C0C241994F3B4E0ABC1475881C5BDE8A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17003D5D RID: 15709
		// (get) Token: 0x06022B8C RID: 142220 RVA: 0x00910779 File Offset: 0x0090E979
		// (set) Token: 0x06022B8D RID: 142221 RVA: 0x0091078D File Offset: 0x0090E98D
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_4__Direction_C0C241994F3B4E0ABC1475881C5BDE8A
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_47);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17003D5E RID: 15710
		// (get) Token: 0x06022B8E RID: 142222 RVA: 0x009107A2 File Offset: 0x0090E9A2
		// (set) Token: 0x06022B8F RID: 142223 RVA: 0x009107B6 File Offset: 0x0090E9B6
		public unsafe UTimelineComponent Timeline_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_48);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_48, value);
			}
		}

		// Token: 0x17003D5F RID: 15711
		// (get) Token: 0x06022B90 RID: 142224 RVA: 0x009107CB File Offset: 0x0090E9CB
		// (set) Token: 0x06022B91 RID: 142225 RVA: 0x009107DB File Offset: 0x0090E9DB
		public unsafe float Timeline_3_NewTrack_0_F9C424B041207DB9B7E9B1AA643B4E65
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17003D60 RID: 15712
		// (get) Token: 0x06022B92 RID: 142226 RVA: 0x009107EC File Offset: 0x0090E9EC
		// (set) Token: 0x06022B93 RID: 142227 RVA: 0x00910800 File Offset: 0x0090EA00
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_3__Direction_F9C424B041207DB9B7E9B1AA643B4E65
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_50);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17003D61 RID: 15713
		// (get) Token: 0x06022B94 RID: 142228 RVA: 0x00910815 File Offset: 0x0090EA15
		// (set) Token: 0x06022B95 RID: 142229 RVA: 0x00910829 File Offset: 0x0090EA29
		public unsafe UTimelineComponent Timeline_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_51);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_51, value);
			}
		}

		// Token: 0x17003D62 RID: 15714
		// (get) Token: 0x06022B96 RID: 142230 RVA: 0x0091083E File Offset: 0x0090EA3E
		// (set) Token: 0x06022B97 RID: 142231 RVA: 0x0091084E File Offset: 0x0090EA4E
		public unsafe float Timeline_2_NewTrack_0_B4CA38084A2C6D24440532854FD80F14
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17003D63 RID: 15715
		// (get) Token: 0x06022B98 RID: 142232 RVA: 0x0091085F File Offset: 0x0090EA5F
		// (set) Token: 0x06022B99 RID: 142233 RVA: 0x00910873 File Offset: 0x0090EA73
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_2__Direction_B4CA38084A2C6D24440532854FD80F14
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_53);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17003D64 RID: 15716
		// (get) Token: 0x06022B9A RID: 142234 RVA: 0x00910888 File Offset: 0x0090EA88
		// (set) Token: 0x06022B9B RID: 142235 RVA: 0x0091089C File Offset: 0x0090EA9C
		public unsafe UTimelineComponent Timeline_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_54);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_54, value);
			}
		}

		// Token: 0x17003D65 RID: 15717
		// (get) Token: 0x06022B9C RID: 142236 RVA: 0x009108B1 File Offset: 0x0090EAB1
		// (set) Token: 0x06022B9D RID: 142237 RVA: 0x009108C1 File Offset: 0x0090EAC1
		public unsafe float Timeline_1_NewTrack_0_6FE613B84448D861330C6F8ADEF1D7E2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_55);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_55) = value;
			}
		}

		// Token: 0x17003D66 RID: 15718
		// (get) Token: 0x06022B9E RID: 142238 RVA: 0x009108D2 File Offset: 0x0090EAD2
		// (set) Token: 0x06022B9F RID: 142239 RVA: 0x009108E6 File Offset: 0x0090EAE6
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_1__Direction_6FE613B84448D861330C6F8ADEF1D7E2
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_56);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_56) = value;
			}
		}

		// Token: 0x17003D67 RID: 15719
		// (get) Token: 0x06022BA0 RID: 142240 RVA: 0x009108FB File Offset: 0x0090EAFB
		// (set) Token: 0x06022BA1 RID: 142241 RVA: 0x0091090F File Offset: 0x0090EB0F
		public unsafe UTimelineComponent Timeline_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_57);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_57, value);
			}
		}

		// Token: 0x17003D68 RID: 15720
		// (get) Token: 0x06022BA2 RID: 142242 RVA: 0x00910924 File Offset: 0x0090EB24
		// (set) Token: 0x06022BA3 RID: 142243 RVA: 0x00910934 File Offset: 0x0090EB34
		public unsafe float Timeline_0_NewTrack_0_EA0C57A7433067A8F9D5B5834E432087
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_58);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x17003D69 RID: 15721
		// (get) Token: 0x06022BA4 RID: 142244 RVA: 0x00910945 File Offset: 0x0090EB45
		// (set) Token: 0x06022BA5 RID: 142245 RVA: 0x00910959 File Offset: 0x0090EB59
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_0__Direction_EA0C57A7433067A8F9D5B5834E432087
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_59);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_59) = value;
			}
		}

		// Token: 0x17003D6A RID: 15722
		// (get) Token: 0x06022BA6 RID: 142246 RVA: 0x0091096E File Offset: 0x0090EB6E
		// (set) Token: 0x06022BA7 RID: 142247 RVA: 0x00910982 File Offset: 0x0090EB82
		public unsafe UTimelineComponent Timeline_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_60);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_60, value);
			}
		}

		// Token: 0x17003D6B RID: 15723
		// (get) Token: 0x06022BA8 RID: 142248 RVA: 0x00910997 File Offset: 0x0090EB97
		// (set) Token: 0x06022BA9 RID: 142249 RVA: 0x009109AB File Offset: 0x0090EBAB
		public unsafe UMaterialInstanceDynamic StampMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_61);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_61, value);
			}
		}

		// Token: 0x17003D6C RID: 15724
		// (get) Token: 0x06022BAA RID: 142250 RVA: 0x009109C0 File Offset: 0x0090EBC0
		// (set) Token: 0x06022BAB RID: 142251 RVA: 0x009109F9 File Offset: 0x0090EBF9
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
					result = (this._CarAllMats = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_62, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CarAllMats.CopyAssign(value);
			}
		}

		// Token: 0x17003D6D RID: 15725
		// (get) Token: 0x06022BAC RID: 142252 RVA: 0x00910A07 File Offset: 0x0090EC07
		// (set) Token: 0x06022BAD RID: 142253 RVA: 0x00910A1B File Offset: 0x0090EC1B
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_63);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_63, value);
			}
		}

		// Token: 0x17003D6E RID: 15726
		// (get) Token: 0x06022BAE RID: 142254 RVA: 0x00910A30 File Offset: 0x0090EC30
		// (set) Token: 0x06022BAF RID: 142255 RVA: 0x00910A40 File Offset: 0x0090EC40
		public unsafe float HitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_64) = value;
			}
		}

		// Token: 0x17003D6F RID: 15727
		// (get) Token: 0x06022BB0 RID: 142256 RVA: 0x00910A51 File Offset: 0x0090EC51
		// (set) Token: 0x06022BB1 RID: 142257 RVA: 0x00910A61 File Offset: 0x0090EC61
		public unsafe float TraceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_65);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_65) = value;
			}
		}

		// Token: 0x17003D70 RID: 15728
		// (get) Token: 0x06022BB2 RID: 142258 RVA: 0x00910A72 File Offset: 0x0090EC72
		// (set) Token: 0x06022BB3 RID: 142259 RVA: 0x00910A86 File Offset: 0x0090EC86
		public unsafe FVector CurWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_66);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_66) = value;
			}
		}

		// Token: 0x17003D71 RID: 15729
		// (get) Token: 0x06022BB4 RID: 142260 RVA: 0x00910A9B File Offset: 0x0090EC9B
		// (set) Token: 0x06022BB5 RID: 142261 RVA: 0x00910AAF File Offset: 0x0090ECAF
		public unsafe FVector hittingPoint_world_position_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_67);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_67) = value;
			}
		}

		// Token: 0x17003D72 RID: 15730
		// (get) Token: 0x06022BB6 RID: 142262 RVA: 0x00910AC4 File Offset: 0x0090ECC4
		// (set) Token: 0x06022BB7 RID: 142263 RVA: 0x00910AD8 File Offset: 0x0090ECD8
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_68);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_68) = value;
			}
		}

		// Token: 0x17003D73 RID: 15731
		// (get) Token: 0x06022BB8 RID: 142264 RVA: 0x00910AED File Offset: 0x0090ECED
		// (set) Token: 0x06022BB9 RID: 142265 RVA: 0x00910B01 File Offset: 0x0090ED01
		public unsafe UTextureRenderTarget2D SkinMaskRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_69);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_69, value);
			}
		}

		// Token: 0x17003D74 RID: 15732
		// (get) Token: 0x06022BBA RID: 142266 RVA: 0x00910B16 File Offset: 0x0090ED16
		// (set) Token: 0x06022BBB RID: 142267 RVA: 0x00910B2A File Offset: 0x0090ED2A
		public unsafe UTexture2D TreePosTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_70);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_70, value);
			}
		}

		// Token: 0x17003D75 RID: 15733
		// (get) Token: 0x06022BBC RID: 142268 RVA: 0x00910B3F File Offset: 0x0090ED3F
		// (set) Token: 0x06022BBD RID: 142269 RVA: 0x00910B53 File Offset: 0x0090ED53
		public unsafe FVector LastWeaponPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_71);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_71) = value;
			}
		}

		// Token: 0x17003D76 RID: 15734
		// (get) Token: 0x06022BBE RID: 142270 RVA: 0x00910B68 File Offset: 0x0090ED68
		// (set) Token: 0x06022BBF RID: 142271 RVA: 0x00910B78 File Offset: 0x0090ED78
		public unsafe bool LastPointUseAble
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_72) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_72) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D77 RID: 15735
		// (get) Token: 0x06022BC0 RID: 142272 RVA: 0x00910B89 File Offset: 0x0090ED89
		// (set) Token: 0x06022BC1 RID: 142273 RVA: 0x00910B99 File Offset: 0x0090ED99
		public unsafe bool debugWeapon_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_73) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_73) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D78 RID: 15736
		// (get) Token: 0x06022BC2 RID: 142274 RVA: 0x00910BAA File Offset: 0x0090EDAA
		// (set) Token: 0x06022BC3 RID: 142275 RVA: 0x00910BBA File Offset: 0x0090EDBA
		public unsafe bool debugDamage_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_74) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_74) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D79 RID: 15737
		// (get) Token: 0x06022BC4 RID: 142276 RVA: 0x00910BCC File Offset: 0x0090EDCC
		// (set) Token: 0x06022BC5 RID: 142277 RVA: 0x00910C05 File Offset: 0x0090EE05
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
					result = (this._SMComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_75, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SMComponents.CopyAssign(value);
			}
		}

		// Token: 0x17003D7A RID: 15738
		// (get) Token: 0x06022BC6 RID: 142278 RVA: 0x00910C14 File Offset: 0x0090EE14
		// (set) Token: 0x06022BC7 RID: 142279 RVA: 0x00910C4D File Offset: 0x0090EE4D
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
					result = (this._SMHealth = new TArray<float>(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_76, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SMHealth.CopyAssign(value);
			}
		}

		// Token: 0x17003D7B RID: 15739
		// (get) Token: 0x06022BC8 RID: 142280 RVA: 0x00910C5C File Offset: 0x0090EE5C
		// (set) Token: 0x06022BC9 RID: 142281 RVA: 0x00910C95 File Offset: 0x0090EE95
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
					result = (this._ConsArr = new TArray<UPhysicsConstraintComponent>(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_77, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ConsArr.CopyAssign(value);
			}
		}

		// Token: 0x17003D7C RID: 15740
		// (get) Token: 0x06022BCA RID: 142282 RVA: 0x00910CA4 File Offset: 0x0090EEA4
		// (set) Token: 0x06022BCB RID: 142283 RVA: 0x00910CDD File Offset: 0x0090EEDD
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
					result = (this._ForceArr = new TArray<FVector>(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_78, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ForceArr.CopyAssign(value);
			}
		}

		// Token: 0x17003D7D RID: 15741
		// (get) Token: 0x06022BCC RID: 142284 RVA: 0x00910CEB File Offset: 0x0090EEEB
		// (set) Token: 0x06022BCD RID: 142285 RVA: 0x00910CFB File Offset: 0x0090EEFB
		public unsafe bool NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_79) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_79) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D7E RID: 15742
		// (get) Token: 0x06022BCE RID: 142286 RVA: 0x00910D0C File Offset: 0x0090EF0C
		// (set) Token: 0x06022BCF RID: 142287 RVA: 0x00910D20 File Offset: 0x0090EF20
		public unsafe FVector LastHitPositon
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_80);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_80) = value;
			}
		}

		// Token: 0x17003D7F RID: 15743
		// (get) Token: 0x06022BD0 RID: 142288 RVA: 0x00910D38 File Offset: 0x0090EF38
		// (set) Token: 0x06022BD1 RID: 142289 RVA: 0x00910D71 File Offset: 0x0090EF71
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
					result = (this._Wheels = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_81, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Wheels.CopyAssign(value);
			}
		}

		// Token: 0x17003D80 RID: 15744
		// (get) Token: 0x06022BD2 RID: 142290 RVA: 0x00910D7F File Offset: 0x0090EF7F
		// (set) Token: 0x06022BD3 RID: 142291 RVA: 0x00910D93 File Offset: 0x0090EF93
		public unsafe UNiagaraSystem NS_Bloom
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_82);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_82, value);
			}
		}

		// Token: 0x17003D81 RID: 15745
		// (get) Token: 0x06022BD4 RID: 142292 RVA: 0x00910DA8 File Offset: 0x0090EFA8
		// (set) Token: 0x06022BD5 RID: 142293 RVA: 0x00910DBC File Offset: 0x0090EFBC
		public unsafe UNiagaraSystem NS_Attack
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_83);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_83, value);
			}
		}

		// Token: 0x17003D82 RID: 15746
		// (get) Token: 0x06022BD6 RID: 142294 RVA: 0x00910DD1 File Offset: 0x0090EFD1
		// (set) Token: 0x06022BD7 RID: 142295 RVA: 0x00910DE1 File Offset: 0x0090EFE1
		public unsafe bool EngineAlreadyBreak
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_84) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_84) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D83 RID: 15747
		// (get) Token: 0x06022BD8 RID: 142296 RVA: 0x00910DF2 File Offset: 0x0090EFF2
		// (set) Token: 0x06022BD9 RID: 142297 RVA: 0x00910E02 File Offset: 0x0090F002
		public unsafe bool EngineBreakOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_85) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_85) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D84 RID: 15748
		// (get) Token: 0x06022BDA RID: 142298 RVA: 0x00910E13 File Offset: 0x0090F013
		// (set) Token: 0x06022BDB RID: 142299 RVA: 0x00910E23 File Offset: 0x0090F023
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_86) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_86) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D85 RID: 15749
		// (get) Token: 0x06022BDC RID: 142300 RVA: 0x00910E34 File Offset: 0x0090F034
		// (set) Token: 0x06022BDD RID: 142301 RVA: 0x00910E48 File Offset: 0x0090F048
		public unsafe UNiagaraSystem NS_CarFire
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_87);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_87, value);
			}
		}

		// Token: 0x17003D86 RID: 15750
		// (get) Token: 0x06022BDE RID: 142302 RVA: 0x00910E5D File Offset: 0x0090F05D
		// (set) Token: 0x06022BDF RID: 142303 RVA: 0x00910E71 File Offset: 0x0090F071
		public unsafe UNiagaraSystem NS_EngineFire
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_88);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_88, value);
			}
		}

		// Token: 0x17003D87 RID: 15751
		// (get) Token: 0x06022BE0 RID: 142304 RVA: 0x00910E86 File Offset: 0x0090F086
		// (set) Token: 0x06022BE1 RID: 142305 RVA: 0x00910E96 File Offset: 0x0090F096
		public unsafe bool bDebug_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_89) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_89) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D88 RID: 15752
		// (get) Token: 0x06022BE2 RID: 142306 RVA: 0x00910EA7 File Offset: 0x0090F0A7
		// (set) Token: 0x06022BE3 RID: 142307 RVA: 0x00910EBB File Offset: 0x0090F0BB
		public unsafe UNiagaraSystem NS_TireBroken
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_90);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_90, value);
			}
		}

		// Token: 0x17003D89 RID: 15753
		// (get) Token: 0x06022BE4 RID: 142308 RVA: 0x00910ED0 File Offset: 0x0090F0D0
		// (set) Token: 0x06022BE5 RID: 142309 RVA: 0x00910EE0 File Offset: 0x0090F0E0
		public unsafe bool bIsOpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_91) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_91) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D8A RID: 15754
		// (get) Token: 0x06022BE6 RID: 142310 RVA: 0x00910EF1 File Offset: 0x0090F0F1
		// (set) Token: 0x06022BE7 RID: 142311 RVA: 0x00910F01 File Offset: 0x0090F101
		public unsafe bool bIsTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_92) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_92) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D8B RID: 15755
		// (get) Token: 0x06022BE8 RID: 142312 RVA: 0x00910F12 File Offset: 0x0090F112
		// (set) Token: 0x06022BE9 RID: 142313 RVA: 0x00910F26 File Offset: 0x0090F126
		public unsafe FTransform LeftTrans1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_93);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_93) = value;
			}
		}

		// Token: 0x17003D8C RID: 15756
		// (get) Token: 0x06022BEA RID: 142314 RVA: 0x00910F3B File Offset: 0x0090F13B
		// (set) Token: 0x06022BEB RID: 142315 RVA: 0x00910F4F File Offset: 0x0090F14F
		public unsafe FTransform LeftTrans2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_94);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_94) = value;
			}
		}

		// Token: 0x17003D8D RID: 15757
		// (get) Token: 0x06022BEC RID: 142316 RVA: 0x00910F64 File Offset: 0x0090F164
		// (set) Token: 0x06022BED RID: 142317 RVA: 0x00910F78 File Offset: 0x0090F178
		public unsafe FTransform LeftTrans3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_95);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_95) = value;
			}
		}

		// Token: 0x17003D8E RID: 15758
		// (get) Token: 0x06022BEE RID: 142318 RVA: 0x00910F8D File Offset: 0x0090F18D
		// (set) Token: 0x06022BEF RID: 142319 RVA: 0x00910FA1 File Offset: 0x0090F1A1
		public unsafe FTransform RightTrans1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_96);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_96) = value;
			}
		}

		// Token: 0x17003D8F RID: 15759
		// (get) Token: 0x06022BF0 RID: 142320 RVA: 0x00910FB6 File Offset: 0x0090F1B6
		// (set) Token: 0x06022BF1 RID: 142321 RVA: 0x00910FCA File Offset: 0x0090F1CA
		public unsafe FTransform RightTrans2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_97);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_97) = value;
			}
		}

		// Token: 0x17003D90 RID: 15760
		// (get) Token: 0x06022BF2 RID: 142322 RVA: 0x00910FDF File Offset: 0x0090F1DF
		// (set) Token: 0x06022BF3 RID: 142323 RVA: 0x00910FF3 File Offset: 0x0090F1F3
		public unsafe FTransform RightTrans3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_98);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_98) = value;
			}
		}

		// Token: 0x17003D91 RID: 15761
		// (get) Token: 0x06022BF4 RID: 142324 RVA: 0x00911008 File Offset: 0x0090F208
		// (set) Token: 0x06022BF5 RID: 142325 RVA: 0x0091101C File Offset: 0x0090F21C
		public unsafe UAkAudioEvent CloseDoorSound
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_99);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_99, value);
			}
		}

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x06022BF6 RID: 142326 RVA: 0x00911031 File Offset: 0x0090F231
		// (set) Token: 0x06022BF7 RID: 142327 RVA: 0x00911045 File Offset: 0x0090F245
		public unsafe UAkAudioEvent OpenDoorSound
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_100);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleDamage_DoorOpen_C.__PropertyOffset_100, value);
			}
		}

		// Token: 0x17003D93 RID: 15763
		// (get) Token: 0x06022BF8 RID: 142328 RVA: 0x0091105A File Offset: 0x0090F25A
		// (set) Token: 0x06022BF9 RID: 142329 RVA: 0x0091106A File Offset: 0x0090F26A
		public unsafe float dtForNiagara
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_101);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_101) = value;
			}
		}

		// Token: 0x17003D94 RID: 15764
		// (get) Token: 0x06022BFA RID: 142330 RVA: 0x0091107B File Offset: 0x0090F27B
		// (set) Token: 0x06022BFB RID: 142331 RVA: 0x0091108B File Offset: 0x0090F28B
		public unsafe int thisFrameWeaponID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_102);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_102) = value;
			}
		}

		// Token: 0x17003D95 RID: 15765
		// (get) Token: 0x06022BFC RID: 142332 RVA: 0x0091109C File Offset: 0x0090F29C
		// (set) Token: 0x06022BFD RID: 142333 RVA: 0x009110AC File Offset: 0x0090F2AC
		public unsafe int lastFrameWeaponID_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_103);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleDamage_DoorOpen_C.__PropertyOffset_103) = value;
			}
		}

		// Token: 0x06022BFE RID: 142334 RVA: 0x009110C0 File Offset: 0x0090F2C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CreateDM(UStaticMeshComponent Component)
		{
			BP_VehicleDamage_DoorOpen_C.__CreateDM_FunctionParams* ptr = stackalloc BP_VehicleDamage_DoorOpen_C.__CreateDM_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_VehicleDamage_DoorOpen_C.__CreateDM_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_DoorOpen_C.__CreateDM_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Component = ((Component != null) ? Component.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__CreateDM_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022BFF RID: 142335 RVA: 0x00911115 File Offset: 0x0090F315
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022C00 RID: 142336 RVA: 0x00911129 File Offset: 0x0090F329
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022C01 RID: 142337 RVA: 0x0091113E File Offset: 0x0090F33E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_0__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C02 RID: 142338 RVA: 0x00911152 File Offset: 0x0090F352
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_0__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C03 RID: 142339 RVA: 0x00911166 File Offset: 0x0090F366
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_1__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_1__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C04 RID: 142340 RVA: 0x0091117A File Offset: 0x0090F37A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_1__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_1__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C05 RID: 142341 RVA: 0x0091118E File Offset: 0x0090F38E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_2__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_2__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C06 RID: 142342 RVA: 0x009111A2 File Offset: 0x0090F3A2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_2__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_2__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C07 RID: 142343 RVA: 0x009111B6 File Offset: 0x0090F3B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_3__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_3__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C08 RID: 142344 RVA: 0x009111CA File Offset: 0x0090F3CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_3__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_3__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C09 RID: 142345 RVA: 0x009111DE File Offset: 0x0090F3DE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_4__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_4__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C0A RID: 142346 RVA: 0x009111F2 File Offset: 0x0090F3F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_4__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_4__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C0B RID: 142347 RVA: 0x00911206 File Offset: 0x0090F406
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_5__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_5__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C0C RID: 142348 RVA: 0x0091121A File Offset: 0x0090F41A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_5__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_5__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C0D RID: 142349 RVA: 0x0091122E File Offset: 0x0090F42E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_6__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_6__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C0E RID: 142350 RVA: 0x00911242 File Offset: 0x0090F442
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_6__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_6__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C0F RID: 142351 RVA: 0x00911256 File Offset: 0x0090F456
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_7__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_7__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C10 RID: 142352 RVA: 0x0091126A File Offset: 0x0090F46A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_7__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Timeline_7__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06022C11 RID: 142353 RVA: 0x00911280 File Offset: 0x0090F480
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_40EBA32A4F2AE716AE3B93815F1DEEE3(int PlayingID)
		{
			BP_VehicleDamage_DoorOpen_C.__Completed_40EBA32A4F2AE716AE3B93815F1DEEE3_FunctionParams* ptr = stackalloc BP_VehicleDamage_DoorOpen_C.__Completed_40EBA32A4F2AE716AE3B93815F1DEEE3_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_DoorOpen_C.__Completed_40EBA32A4F2AE716AE3B93815F1DEEE3_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_DoorOpen_C.__Completed_40EBA32A4F2AE716AE3B93815F1DEEE3_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Completed_40EBA32A4F2AE716AE3B93815F1DEEE3_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022C12 RID: 142354 RVA: 0x009112C8 File Offset: 0x0090F4C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_64E97B4B44529050B8596992FBAF5F9B(int PlayingID)
		{
			BP_VehicleDamage_DoorOpen_C.__Completed_64E97B4B44529050B8596992FBAF5F9B_FunctionParams* ptr = stackalloc BP_VehicleDamage_DoorOpen_C.__Completed_64E97B4B44529050B8596992FBAF5F9B_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_DoorOpen_C.__Completed_64E97B4B44529050B8596992FBAF5F9B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_DoorOpen_C.__Completed_64E97B4B44529050B8596992FBAF5F9B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Completed_64E97B4B44529050B8596992FBAF5F9B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022C13 RID: 142355 RVA: 0x00911310 File Offset: 0x0090F510
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_79CF6ACA42AAF8B84E41119679134833(int PlayingID)
		{
			BP_VehicleDamage_DoorOpen_C.__Completed_79CF6ACA42AAF8B84E41119679134833_FunctionParams* ptr = stackalloc BP_VehicleDamage_DoorOpen_C.__Completed_79CF6ACA42AAF8B84E41119679134833_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_DoorOpen_C.__Completed_79CF6ACA42AAF8B84E41119679134833_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_DoorOpen_C.__Completed_79CF6ACA42AAF8B84E41119679134833_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Completed_79CF6ACA42AAF8B84E41119679134833_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022C14 RID: 142356 RVA: 0x00911358 File Offset: 0x0090F558
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_6B35900D4459C9E45C6E11A80F474F74(int PlayingID)
		{
			BP_VehicleDamage_DoorOpen_C.__Completed_6B35900D4459C9E45C6E11A80F474F74_FunctionParams* ptr = stackalloc BP_VehicleDamage_DoorOpen_C.__Completed_6B35900D4459C9E45C6E11A80F474F74_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_DoorOpen_C.__Completed_6B35900D4459C9E45C6E11A80F474F74_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_DoorOpen_C.__Completed_6B35900D4459C9E45C6E11A80F474F74_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Completed_6B35900D4459C9E45C6E11A80F474F74_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022C15 RID: 142357 RVA: 0x009113A0 File Offset: 0x0090F5A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_37097A5140DB97D8CA4BC6A54466E558(int PlayingID)
		{
			BP_VehicleDamage_DoorOpen_C.__Completed_37097A5140DB97D8CA4BC6A54466E558_FunctionParams* ptr = stackalloc BP_VehicleDamage_DoorOpen_C.__Completed_37097A5140DB97D8CA4BC6A54466E558_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_DoorOpen_C.__Completed_37097A5140DB97D8CA4BC6A54466E558_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_DoorOpen_C.__Completed_37097A5140DB97D8CA4BC6A54466E558_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__Completed_37097A5140DB97D8CA4BC6A54466E558_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022C16 RID: 142358 RVA: 0x009113E6 File Offset: 0x0090F5E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__CustomEvent1_NativeFunctionPtr, null);
		}

		// Token: 0x06022C17 RID: 142359 RVA: 0x009113FA File Offset: 0x0090F5FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__CustomEvent_NativeFunctionPtr, null);
		}

		// Token: 0x06022C18 RID: 142360 RVA: 0x00911410 File Offset: 0x0090F610
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_VehicleDamage_DoorOpen_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_VehicleDamage_DoorOpen_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_VehicleDamage_DoorOpen_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_DoorOpen_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022C19 RID: 142361 RVA: 0x00911474 File Offset: 0x0090F674
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VehicleDamage_DoorOpen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VehicleDamage_DoorOpen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_DoorOpen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_DoorOpen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022C1A RID: 142362 RVA: 0x009114BC File Offset: 0x0090F6BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VehicleDamage_DoorOpen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VehicleDamage_DoorOpen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VehicleDamage_DoorOpen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_DoorOpen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022C1B RID: 142363 RVA: 0x00911503 File Offset: 0x0090F703
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022C1C RID: 142364 RVA: 0x00911517 File Offset: 0x0090F717
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022C1D RID: 142365 RVA: 0x0091152C File Offset: 0x0090F72C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06022C1E RID: 142366 RVA: 0x00911540 File Offset: 0x0090F740
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void test()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__test_NativeFunctionPtr, null);
		}

		// Token: 0x06022C1F RID: 142367 RVA: 0x00911554 File Offset: 0x0090F754
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnVehiclePartBroken_Event_0(int PartIndex, string PartName)
		{
			BP_VehicleDamage_DoorOpen_C.__OnVehiclePartBroken_Event_0_FunctionParams* ptr = stackalloc BP_VehicleDamage_DoorOpen_C.__OnVehiclePartBroken_Event_0_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_VehicleDamage_DoorOpen_C.__OnVehiclePartBroken_Event_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_DoorOpen_C.__OnVehiclePartBroken_Event_0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PartIndex = PartIndex;
			FString.CopyFrom((void*)(&ptr->PartName), PartName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__OnVehiclePartBroken_Event_0_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_VehicleDamage_DoorOpen_C.__OnVehiclePartBroken_Event_0_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022C20 RID: 142368 RVA: 0x009115B8 File Offset: 0x0090F7B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_VehicleDamage_DoorOpen_C.__BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_VehicleDamage_DoorOpen_C.__BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_VehicleDamage_DoorOpen_C.__BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_DoorOpen_C.__BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022C21 RID: 142369 RVA: 0x00911674 File Offset: 0x0090F874
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_VehicleDamage_DoorOpen_C.__BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_VehicleDamage_DoorOpen_C.__BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_VehicleDamage_DoorOpen_C.__BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VehicleDamage_DoorOpen_C.__BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VehicleDamage_DoorOpen_C.__BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022C22 RID: 142370 RVA: 0x009116FD File Offset: 0x0090F8FD
		protected BP_VehicleDamage_DoorOpen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040110F6 RID: 69878
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/VehicleDamage/BP_VehicleDamage_DoorOpen.BP_VehicleDamage_DoorOpen_C";

		// Token: 0x040110F7 RID: 69879
		private static IntPtr _ClassPtr;

		// Token: 0x040110F8 RID: 69880
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040110F9 RID: 69881
		internal static int __PropertyOffset_1;

		// Token: 0x040110FA RID: 69882
		internal static int __PropertyOffset_2;

		// Token: 0x040110FB RID: 69883
		internal static int __PropertyOffset_3;

		// Token: 0x040110FC RID: 69884
		internal static int __PropertyOffset_4;

		// Token: 0x040110FD RID: 69885
		internal static int __PropertyOffset_5;

		// Token: 0x040110FE RID: 69886
		internal static int __PropertyOffset_6;

		// Token: 0x040110FF RID: 69887
		internal static int __PropertyOffset_7;

		// Token: 0x04011100 RID: 69888
		internal static int __PropertyOffset_8;

		// Token: 0x04011101 RID: 69889
		internal static int __PropertyOffset_9;

		// Token: 0x04011102 RID: 69890
		internal static int __PropertyOffset_10;

		// Token: 0x04011103 RID: 69891
		internal static int __PropertyOffset_11;

		// Token: 0x04011104 RID: 69892
		internal static int __PropertyOffset_12;

		// Token: 0x04011105 RID: 69893
		internal static int __PropertyOffset_13;

		// Token: 0x04011106 RID: 69894
		internal static int __PropertyOffset_14;

		// Token: 0x04011107 RID: 69895
		internal static int __PropertyOffset_15;

		// Token: 0x04011108 RID: 69896
		internal static int __PropertyOffset_16;

		// Token: 0x04011109 RID: 69897
		internal static int __PropertyOffset_17;

		// Token: 0x0401110A RID: 69898
		internal static int __PropertyOffset_18;

		// Token: 0x0401110B RID: 69899
		internal static int __PropertyOffset_19;

		// Token: 0x0401110C RID: 69900
		internal static int __PropertyOffset_20;

		// Token: 0x0401110D RID: 69901
		internal static int __PropertyOffset_21;

		// Token: 0x0401110E RID: 69902
		internal static int __PropertyOffset_22;

		// Token: 0x0401110F RID: 69903
		internal static int __PropertyOffset_23;

		// Token: 0x04011110 RID: 69904
		internal static int __PropertyOffset_24;

		// Token: 0x04011111 RID: 69905
		internal static int __PropertyOffset_25;

		// Token: 0x04011112 RID: 69906
		internal static int __PropertyOffset_26;

		// Token: 0x04011113 RID: 69907
		internal static int __PropertyOffset_27;

		// Token: 0x04011114 RID: 69908
		internal static int __PropertyOffset_28;

		// Token: 0x04011115 RID: 69909
		internal static int __PropertyOffset_29;

		// Token: 0x04011116 RID: 69910
		internal static int __PropertyOffset_30;

		// Token: 0x04011117 RID: 69911
		internal static int __PropertyOffset_31;

		// Token: 0x04011118 RID: 69912
		internal static int __PropertyOffset_32;

		// Token: 0x04011119 RID: 69913
		internal static int __PropertyOffset_33;

		// Token: 0x0401111A RID: 69914
		internal static int __PropertyOffset_34;

		// Token: 0x0401111B RID: 69915
		internal static int __PropertyOffset_35;

		// Token: 0x0401111C RID: 69916
		internal static int __PropertyOffset_36;

		// Token: 0x0401111D RID: 69917
		internal static int __PropertyOffset_37;

		// Token: 0x0401111E RID: 69918
		internal static int __PropertyOffset_38;

		// Token: 0x0401111F RID: 69919
		internal static int __PropertyOffset_39;

		// Token: 0x04011120 RID: 69920
		internal static int __PropertyOffset_40;

		// Token: 0x04011121 RID: 69921
		internal static int __PropertyOffset_41;

		// Token: 0x04011122 RID: 69922
		internal static int __PropertyOffset_42;

		// Token: 0x04011123 RID: 69923
		internal static int __PropertyOffset_43;

		// Token: 0x04011124 RID: 69924
		internal static int __PropertyOffset_44;

		// Token: 0x04011125 RID: 69925
		internal static int __PropertyOffset_45;

		// Token: 0x04011126 RID: 69926
		internal static int __PropertyOffset_46;

		// Token: 0x04011127 RID: 69927
		internal static int __PropertyOffset_47;

		// Token: 0x04011128 RID: 69928
		internal static int __PropertyOffset_48;

		// Token: 0x04011129 RID: 69929
		internal static int __PropertyOffset_49;

		// Token: 0x0401112A RID: 69930
		internal static int __PropertyOffset_50;

		// Token: 0x0401112B RID: 69931
		internal static int __PropertyOffset_51;

		// Token: 0x0401112C RID: 69932
		internal static int __PropertyOffset_52;

		// Token: 0x0401112D RID: 69933
		internal static int __PropertyOffset_53;

		// Token: 0x0401112E RID: 69934
		internal static int __PropertyOffset_54;

		// Token: 0x0401112F RID: 69935
		internal static int __PropertyOffset_55;

		// Token: 0x04011130 RID: 69936
		internal static int __PropertyOffset_56;

		// Token: 0x04011131 RID: 69937
		internal static int __PropertyOffset_57;

		// Token: 0x04011132 RID: 69938
		internal static int __PropertyOffset_58;

		// Token: 0x04011133 RID: 69939
		internal static int __PropertyOffset_59;

		// Token: 0x04011134 RID: 69940
		internal static int __PropertyOffset_60;

		// Token: 0x04011135 RID: 69941
		internal static int __PropertyOffset_61;

		// Token: 0x04011136 RID: 69942
		internal static int __PropertyOffset_62;

		// Token: 0x04011137 RID: 69943
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _CarAllMats;

		// Token: 0x04011138 RID: 69944
		internal static int __PropertyOffset_63;

		// Token: 0x04011139 RID: 69945
		internal static int __PropertyOffset_64;

		// Token: 0x0401113A RID: 69946
		internal static int __PropertyOffset_65;

		// Token: 0x0401113B RID: 69947
		internal static int __PropertyOffset_66;

		// Token: 0x0401113C RID: 69948
		internal static int __PropertyOffset_67;

		// Token: 0x0401113D RID: 69949
		internal static int __PropertyOffset_68;

		// Token: 0x0401113E RID: 69950
		internal static int __PropertyOffset_69;

		// Token: 0x0401113F RID: 69951
		internal static int __PropertyOffset_70;

		// Token: 0x04011140 RID: 69952
		internal static int __PropertyOffset_71;

		// Token: 0x04011141 RID: 69953
		internal static int __PropertyOffset_72;

		// Token: 0x04011142 RID: 69954
		internal static int __PropertyOffset_73;

		// Token: 0x04011143 RID: 69955
		internal static int __PropertyOffset_74;

		// Token: 0x04011144 RID: 69956
		internal static int __PropertyOffset_75;

		// Token: 0x04011145 RID: 69957
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _SMComponents;

		// Token: 0x04011146 RID: 69958
		internal static int __PropertyOffset_76;

		// Token: 0x04011147 RID: 69959
		private TArray<float> _SMHealth;

		// Token: 0x04011148 RID: 69960
		internal static int __PropertyOffset_77;

		// Token: 0x04011149 RID: 69961
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicsConstraintComponent> _ConsArr;

		// Token: 0x0401114A RID: 69962
		internal static int __PropertyOffset_78;

		// Token: 0x0401114B RID: 69963
		private TArray<FVector> _ForceArr;

		// Token: 0x0401114C RID: 69964
		internal static int __PropertyOffset_79;

		// Token: 0x0401114D RID: 69965
		internal static int __PropertyOffset_80;

		// Token: 0x0401114E RID: 69966
		internal static int __PropertyOffset_81;

		// Token: 0x0401114F RID: 69967
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _Wheels;

		// Token: 0x04011150 RID: 69968
		internal static int __PropertyOffset_82;

		// Token: 0x04011151 RID: 69969
		internal static int __PropertyOffset_83;

		// Token: 0x04011152 RID: 69970
		internal static int __PropertyOffset_84;

		// Token: 0x04011153 RID: 69971
		internal static int __PropertyOffset_85;

		// Token: 0x04011154 RID: 69972
		internal static int __PropertyOffset_86;

		// Token: 0x04011155 RID: 69973
		internal static int __PropertyOffset_87;

		// Token: 0x04011156 RID: 69974
		internal static int __PropertyOffset_88;

		// Token: 0x04011157 RID: 69975
		internal static int __PropertyOffset_89;

		// Token: 0x04011158 RID: 69976
		internal static int __PropertyOffset_90;

		// Token: 0x04011159 RID: 69977
		internal static int __PropertyOffset_91;

		// Token: 0x0401115A RID: 69978
		internal static int __PropertyOffset_92;

		// Token: 0x0401115B RID: 69979
		internal static int __PropertyOffset_93;

		// Token: 0x0401115C RID: 69980
		internal static int __PropertyOffset_94;

		// Token: 0x0401115D RID: 69981
		internal static int __PropertyOffset_95;

		// Token: 0x0401115E RID: 69982
		internal static int __PropertyOffset_96;

		// Token: 0x0401115F RID: 69983
		internal static int __PropertyOffset_97;

		// Token: 0x04011160 RID: 69984
		internal static int __PropertyOffset_98;

		// Token: 0x04011161 RID: 69985
		internal static int __PropertyOffset_99;

		// Token: 0x04011162 RID: 69986
		internal static int __PropertyOffset_100;

		// Token: 0x04011163 RID: 69987
		internal static int __PropertyOffset_101;

		// Token: 0x04011164 RID: 69988
		internal static int __PropertyOffset_102;

		// Token: 0x04011165 RID: 69989
		internal static int __PropertyOffset_103;

		// Token: 0x04011166 RID: 69990
		private static IntPtr __CreateDM_NativeFunctionPtr;

		// Token: 0x04011167 RID: 69991
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011168 RID: 69992
		private static IntPtr __Timeline_0__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04011169 RID: 69993
		private static IntPtr __Timeline_0__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0401116A RID: 69994
		private static IntPtr __Timeline_1__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0401116B RID: 69995
		private static IntPtr __Timeline_1__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0401116C RID: 69996
		private static IntPtr __Timeline_2__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0401116D RID: 69997
		private static IntPtr __Timeline_2__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0401116E RID: 69998
		private static IntPtr __Timeline_3__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0401116F RID: 69999
		private static IntPtr __Timeline_3__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04011170 RID: 70000
		private static IntPtr __Timeline_4__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04011171 RID: 70001
		private static IntPtr __Timeline_4__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04011172 RID: 70002
		private static IntPtr __Timeline_5__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04011173 RID: 70003
		private static IntPtr __Timeline_5__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04011174 RID: 70004
		private static IntPtr __Timeline_6__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04011175 RID: 70005
		private static IntPtr __Timeline_6__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04011176 RID: 70006
		private static IntPtr __Timeline_7__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04011177 RID: 70007
		private static IntPtr __Timeline_7__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04011178 RID: 70008
		private static IntPtr __Completed_40EBA32A4F2AE716AE3B93815F1DEEE3_NativeFunctionPtr;

		// Token: 0x04011179 RID: 70009
		private static IntPtr __Completed_64E97B4B44529050B8596992FBAF5F9B_NativeFunctionPtr;

		// Token: 0x0401117A RID: 70010
		private static IntPtr __Completed_79CF6ACA42AAF8B84E41119679134833_NativeFunctionPtr;

		// Token: 0x0401117B RID: 70011
		private static IntPtr __Completed_6B35900D4459C9E45C6E11A80F474F74_NativeFunctionPtr;

		// Token: 0x0401117C RID: 70012
		private static IntPtr __Completed_37097A5140DB97D8CA4BC6A54466E558_NativeFunctionPtr;

		// Token: 0x0401117D RID: 70013
		private static IntPtr __CustomEvent1_NativeFunctionPtr;

		// Token: 0x0401117E RID: 70014
		private static IntPtr __CustomEvent_NativeFunctionPtr;

		// Token: 0x0401117F RID: 70015
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x04011180 RID: 70016
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011181 RID: 70017
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011182 RID: 70018
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011183 RID: 70019
		private static IntPtr __test_NativeFunctionPtr;

		// Token: 0x04011184 RID: 70020
		private static IntPtr __OnVehiclePartBroken_Event_0_NativeFunctionPtr;

		// Token: 0x04011185 RID: 70021
		private static IntPtr __BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011186 RID: 70022
		private static IntPtr __BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009DBA RID: 40378
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __CreateDM_FunctionParams
		{
			// Token: 0x0403159F RID: 202143
			[FieldOffset(0)]
			public IntPtr Component;
		}

		// Token: 0x02009DBB RID: 40379
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_40EBA32A4F2AE716AE3B93815F1DEEE3_FunctionParams
		{
			// Token: 0x040315A0 RID: 202144
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009DBC RID: 40380
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_64E97B4B44529050B8596992FBAF5F9B_FunctionParams
		{
			// Token: 0x040315A1 RID: 202145
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009DBD RID: 40381
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_79CF6ACA42AAF8B84E41119679134833_FunctionParams
		{
			// Token: 0x040315A2 RID: 202146
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009DBE RID: 40382
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_6B35900D4459C9E45C6E11A80F474F74_FunctionParams
		{
			// Token: 0x040315A3 RID: 202147
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009DBF RID: 40383
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_37097A5140DB97D8CA4BC6A54466E558_FunctionParams
		{
			// Token: 0x040315A4 RID: 202148
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009DC0 RID: 40384
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x040315A5 RID: 202149
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x040315A6 RID: 202150
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x040315A7 RID: 202151
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009DC1 RID: 40385
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040315A8 RID: 202152
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DC2 RID: 40386
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnVehiclePartBroken_Event_0_FunctionParams
		{
			// Token: 0x040315A9 RID: 202153
			[FieldOffset(0)]
			public int PartIndex;

			// Token: 0x040315AA RID: 202154
			[FieldOffset(8)]
			public FString PartName;
		}

		// Token: 0x02009DC3 RID: 40387
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_ActorEffect_Trigger_BoxTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040315AB RID: 202155
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040315AC RID: 202156
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040315AD RID: 202157
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040315AE RID: 202158
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040315AF RID: 202159
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040315B0 RID: 202160
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009DC4 RID: 40388
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_CarOpenDoor_BoxTrigger_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040315B1 RID: 202161
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040315B2 RID: 202162
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040315B3 RID: 202163
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040315B4 RID: 202164
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
