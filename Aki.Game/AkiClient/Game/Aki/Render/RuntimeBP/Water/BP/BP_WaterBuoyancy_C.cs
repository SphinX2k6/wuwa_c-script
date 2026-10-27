using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Water.BP
{
	// Token: 0x02003A8C RID: 14988
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Water/BP/BP_WaterBuoyancy.BP_WaterBuoyancy_C")]
	[UnrealStructLayout(1776, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1761)]
	public class BP_WaterBuoyancy_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FDDD RID: 130525 RVA: 0x008C4A89 File Offset: 0x008C2C89
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterBuoyancy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Water/BP/BP_WaterBuoyancy.BP_WaterBuoyancy_C");
			}
			return BP_WaterBuoyancy_C._ClassPtr;
		}

		// Token: 0x0601FDDE RID: 130526 RVA: 0x008C4AB0 File Offset: 0x008C2CB0
		public BP_WaterBuoyancy_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterBuoyancy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FDDF RID: 130527 RVA: 0x008C4AD8 File Offset: 0x008C2CD8
		[NullableContext(1)]
		public BP_WaterBuoyancy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterBuoyancy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D5A RID: 11610
		// (get) Token: 0x0601FDE0 RID: 130528 RVA: 0x008C4B0B File Offset: 0x008C2D0B
		// (set) Token: 0x0601FDE1 RID: 130529 RVA: 0x008C4B1F File Offset: 0x008C2D1F
		public unsafe BP_WaterInteractObjectRipple_Component_C WaterRippleComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_WaterInteractObjectRipple_Component_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancy_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancy_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x0601FDE2 RID: 130530 RVA: 0x008C4B34 File Offset: 0x008C2D34
		// (set) Token: 0x0601FDE3 RID: 130531 RVA: 0x008C4B48 File Offset: 0x008C2D48
		public unsafe UStaticMeshComponent CollisionMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancy_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancy_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x0601FDE4 RID: 130532 RVA: 0x008C4B5D File Offset: 0x008C2D5D
		// (set) Token: 0x0601FDE5 RID: 130533 RVA: 0x008C4B71 File Offset: 0x008C2D71
		public unsafe UStaticMesh BuoyancyStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancy_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancy_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x0601FDE6 RID: 130534 RVA: 0x008C4B88 File Offset: 0x008C2D88
		// (set) Token: 0x0601FDE7 RID: 130535 RVA: 0x008C4BC1 File Offset: 0x008C2DC1
		[Nullable(1)]
		public TArray<FVector4> sphereList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._sphereList) == null)
				{
					result = (this._sphereList = new TArray<FVector4>(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.sphereList.CopyAssign(value);
			}
		}

		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x0601FDE8 RID: 130536 RVA: 0x008C4BCF File Offset: 0x008C2DCF
		// (set) Token: 0x0601FDE9 RID: 130537 RVA: 0x008C4BDF File Offset: 0x008C2DDF
		public unsafe float waterHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x0601FDEA RID: 130538 RVA: 0x008C4BF0 File Offset: 0x008C2DF0
		// (set) Token: 0x0601FDEB RID: 130539 RVA: 0x008C4C00 File Offset: 0x008C2E00
		public unsafe float StaticHeightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x0601FDEC RID: 130540 RVA: 0x008C4C11 File Offset: 0x008C2E11
		// (set) Token: 0x0601FDED RID: 130541 RVA: 0x008C4C21 File Offset: 0x008C2E21
		public unsafe float BuoyancyIntersity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x0601FDEE RID: 130542 RVA: 0x008C4C32 File Offset: 0x008C2E32
		// (set) Token: 0x0601FDEF RID: 130543 RVA: 0x008C4C42 File Offset: 0x008C2E42
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x0601FDF0 RID: 130544 RVA: 0x008C4C53 File Offset: 0x008C2E53
		// (set) Token: 0x0601FDF1 RID: 130545 RVA: 0x008C4C63 File Offset: 0x008C2E63
		public unsafe float LinearDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002D63 RID: 11619
		// (get) Token: 0x0601FDF2 RID: 130546 RVA: 0x008C4C74 File Offset: 0x008C2E74
		// (set) Token: 0x0601FDF3 RID: 130547 RVA: 0x008C4C84 File Offset: 0x008C2E84
		public unsafe float AngularDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x0601FDF4 RID: 130548 RVA: 0x008C4C95 File Offset: 0x008C2E95
		// (set) Token: 0x0601FDF5 RID: 130549 RVA: 0x008C4CA5 File Offset: 0x008C2EA5
		public unsafe float MinDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x0601FDF6 RID: 130550 RVA: 0x008C4CB6 File Offset: 0x008C2EB6
		// (set) Token: 0x0601FDF7 RID: 130551 RVA: 0x008C4CC6 File Offset: 0x008C2EC6
		public unsafe float RippleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x0601FDF8 RID: 130552 RVA: 0x008C4CD7 File Offset: 0x008C2ED7
		// (set) Token: 0x0601FDF9 RID: 130553 RVA: 0x008C4CE7 File Offset: 0x008C2EE7
		public unsafe float RippleTickInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x0601FDFA RID: 130554 RVA: 0x008C4CF8 File Offset: 0x008C2EF8
		// (set) Token: 0x0601FDFB RID: 130555 RVA: 0x008C4D08 File Offset: 0x008C2F08
		public unsafe float LastRippleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x0601FDFC RID: 130556 RVA: 0x008C4D19 File Offset: 0x008C2F19
		// (set) Token: 0x0601FDFD RID: 130557 RVA: 0x008C4D2D File Offset: 0x008C2F2D
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002D69 RID: 11625
		// (get) Token: 0x0601FDFE RID: 130558 RVA: 0x008C4D44 File Offset: 0x008C2F44
		// (set) Token: 0x0601FDFF RID: 130559 RVA: 0x008C4D7D File Offset: 0x008C2F7D
		[Nullable(1)]
		public TArray<FVector> RipplePointList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._RipplePointList) == null)
				{
					result = (this._RipplePointList = new TArray<FVector>(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_16, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.RipplePointList.CopyAssign(value);
			}
		}

		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x0601FE00 RID: 130560 RVA: 0x008C4D8B File Offset: 0x008C2F8B
		// (set) Token: 0x0601FE01 RID: 130561 RVA: 0x008C4D9B File Offset: 0x008C2F9B
		public unsafe double RippleDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x0601FE02 RID: 130562 RVA: 0x008C4DAC File Offset: 0x008C2FAC
		// (set) Token: 0x0601FE03 RID: 130563 RVA: 0x008C4DBC File Offset: 0x008C2FBC
		public unsafe float 产生水波时吃水比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x0601FE04 RID: 130564 RVA: 0x008C4DCD File Offset: 0x008C2FCD
		// (set) Token: 0x0601FE05 RID: 130565 RVA: 0x008C4DE1 File Offset: 0x008C2FE1
		public unsafe FTransformDouble LastTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x0601FE06 RID: 130566 RVA: 0x008C4DF6 File Offset: 0x008C2FF6
		// (set) Token: 0x0601FE07 RID: 130567 RVA: 0x008C4E06 File Offset: 0x008C3006
		public unsafe double DistforPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x0601FE08 RID: 130568 RVA: 0x008C4E17 File Offset: 0x008C3017
		// (set) Token: 0x0601FE09 RID: 130569 RVA: 0x008C4E27 File Offset: 0x008C3027
		public unsafe float V_total
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x0601FE0A RID: 130570 RVA: 0x008C4E38 File Offset: 0x008C3038
		// (set) Token: 0x0601FE0B RID: 130571 RVA: 0x008C4E48 File Offset: 0x008C3048
		public unsafe float V_inWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x0601FE0C RID: 130572 RVA: 0x008C4E59 File Offset: 0x008C3059
		// (set) Token: 0x0601FE0D RID: 130573 RVA: 0x008C4E69 File Offset: 0x008C3069
		public unsafe float FPSLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x0601FE0E RID: 130574 RVA: 0x008C4E7A File Offset: 0x008C307A
		// (set) Token: 0x0601FE0F RID: 130575 RVA: 0x008C4E8A File Offset: 0x008C308A
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x0601FE10 RID: 130576 RVA: 0x008C4E9B File Offset: 0x008C309B
		// (set) Token: 0x0601FE11 RID: 130577 RVA: 0x008C4EAB File Offset: 0x008C30AB
		public unsafe double BuoyancyRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x0601FE12 RID: 130578 RVA: 0x008C4EBC File Offset: 0x008C30BC
		// (set) Token: 0x0601FE13 RID: 130579 RVA: 0x008C4ECC File Offset: 0x008C30CC
		public unsafe bool UseWaterRipple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x0601FE14 RID: 130580 RVA: 0x008C4EDD File Offset: 0x008C30DD
		// (set) Token: 0x0601FE15 RID: 130581 RVA: 0x008C4EED File Offset: 0x008C30ED
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x0601FE16 RID: 130582 RVA: 0x008C4EFE File Offset: 0x008C30FE
		// (set) Token: 0x0601FE17 RID: 130583 RVA: 0x008C4F0E File Offset: 0x008C310E
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x0601FE18 RID: 130584 RVA: 0x008C4F1F File Offset: 0x008C311F
		// (set) Token: 0x0601FE19 RID: 130585 RVA: 0x008C4F33 File Offset: 0x008C3133
		public unsafe BP_WaterBuoyancyCollision_C BuoyancyCollision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_WaterBuoyancyCollision_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancy_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancy_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x0601FE1A RID: 130586 RVA: 0x008C4F48 File Offset: 0x008C3148
		// (set) Token: 0x0601FE1B RID: 130587 RVA: 0x008C4F5C File Offset: 0x008C315C
		public unsafe FVector Box_Extent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x0601FE1C RID: 130588 RVA: 0x008C4F71 File Offset: 0x008C3171
		// (set) Token: 0x0601FE1D RID: 130589 RVA: 0x008C4F85 File Offset: 0x008C3185
		public unsafe FVector Box_Origin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x0601FE1E RID: 130590 RVA: 0x008C4F9A File Offset: 0x008C319A
		// (set) Token: 0x0601FE1F RID: 130591 RVA: 0x008C4FAA File Offset: 0x008C31AA
		public unsafe bool InRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x0601FE20 RID: 130592 RVA: 0x008C4FBB File Offset: 0x008C31BB
		// (set) Token: 0x0601FE21 RID: 130593 RVA: 0x008C4FCB File Offset: 0x008C31CB
		public unsafe float Timer_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x0601FE22 RID: 130594 RVA: 0x008C4FDC File Offset: 0x008C31DC
		// (set) Token: 0x0601FE23 RID: 130595 RVA: 0x008C4FF0 File Offset: 0x008C31F0
		public unsafe FVectorDouble BornLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x0601FE24 RID: 130596 RVA: 0x008C5005 File Offset: 0x008C3205
		// (set) Token: 0x0601FE25 RID: 130597 RVA: 0x008C5015 File Offset: 0x008C3215
		public unsafe double ResetDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x0601FE26 RID: 130598 RVA: 0x008C5026 File Offset: 0x008C3226
		// (set) Token: 0x0601FE27 RID: 130599 RVA: 0x008C5036 File Offset: 0x008C3236
		public unsafe bool IsVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancy_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FE28 RID: 130600 RVA: 0x008C5047 File Offset: 0x008C3247
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void WaterRipple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancy_C.__WaterRipple_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE29 RID: 130601 RVA: 0x008C505C File Offset: 0x008C325C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void VolumeSphereInWater(float in_h, FVector in_c, float in_r, ref float out_V, ref float out_SpheveV)
		{
			BP_WaterBuoyancy_C.__VolumeSphereInWater_FunctionParams* ptr = stackalloc BP_WaterBuoyancy_C.__VolumeSphereInWater_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(BP_WaterBuoyancy_C.__VolumeSphereInWater_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBuoyancy_C.__VolumeSphereInWater_NativeFunctionPtr, (void*)ptr, 1);
			ptr->in_h = in_h;
			ptr->in_c = in_c;
			ptr->in_r = in_r;
			ptr->out_V = out_V;
			ptr->out_SpheveV = out_SpheveV;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancy_C.__VolumeSphereInWater_NativeFunctionPtr, (void*)ptr);
			out_V = ptr->out_V;
			out_SpheveV = ptr->out_SpheveV;
		}

		// Token: 0x0601FE2A RID: 130602 RVA: 0x008C50D7 File Offset: 0x008C32D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancy_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE2B RID: 130603 RVA: 0x008C50EB File Offset: 0x008C32EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBuoyancy_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FE2C RID: 130604 RVA: 0x008C5100 File Offset: 0x008C3300
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancy_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE2D RID: 130605 RVA: 0x008C5114 File Offset: 0x008C3314
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBuoyancy_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FE2E RID: 130606 RVA: 0x008C5129 File Offset: 0x008C3329
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancy_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE2F RID: 130607 RVA: 0x008C513D File Offset: 0x008C333D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBuoyancy_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FE30 RID: 130608 RVA: 0x008C5152 File Offset: 0x008C3352
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancy_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE31 RID: 130609 RVA: 0x008C5166 File Offset: 0x008C3366
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBuoyancy_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FE32 RID: 130610 RVA: 0x008C517C File Offset: 0x008C337C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterBuoyancy_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterBuoyancy_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterBuoyancy_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBuoyancy_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancy_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FE33 RID: 130611 RVA: 0x008C51C4 File Offset: 0x008C33C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterBuoyancy_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterBuoyancy_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterBuoyancy_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBuoyancy_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBuoyancy_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FE34 RID: 130612 RVA: 0x008C520B File Offset: 0x008C340B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnVisible()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancy_C.__OnVisible_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE35 RID: 130613 RVA: 0x008C521F File Offset: 0x008C341F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnVisible_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBuoyancy_C.__OnVisible_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FE36 RID: 130614 RVA: 0x008C5234 File Offset: 0x008C3434
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnInvisible()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancy_C.__OnInvisible_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE37 RID: 130615 RVA: 0x008C5248 File Offset: 0x008C3448
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnInvisible_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBuoyancy_C.__OnInvisible_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FE38 RID: 130616 RVA: 0x008C525D File Offset: 0x008C345D
		protected BP_WaterBuoyancy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F5D3 RID: 62931
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Water/BP/BP_WaterBuoyancy.BP_WaterBuoyancy_C";

		// Token: 0x0400F5D4 RID: 62932
		private static IntPtr _ClassPtr;

		// Token: 0x0400F5D5 RID: 62933
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F5D6 RID: 62934
		internal static int __PropertyOffset_1;

		// Token: 0x0400F5D7 RID: 62935
		internal static int __PropertyOffset_2;

		// Token: 0x0400F5D8 RID: 62936
		internal static int __PropertyOffset_3;

		// Token: 0x0400F5D9 RID: 62937
		internal static int __PropertyOffset_4;

		// Token: 0x0400F5DA RID: 62938
		private TArray<FVector4> _sphereList;

		// Token: 0x0400F5DB RID: 62939
		internal static int __PropertyOffset_5;

		// Token: 0x0400F5DC RID: 62940
		internal static int __PropertyOffset_6;

		// Token: 0x0400F5DD RID: 62941
		internal static int __PropertyOffset_7;

		// Token: 0x0400F5DE RID: 62942
		internal static int __PropertyOffset_8;

		// Token: 0x0400F5DF RID: 62943
		internal static int __PropertyOffset_9;

		// Token: 0x0400F5E0 RID: 62944
		internal static int __PropertyOffset_10;

		// Token: 0x0400F5E1 RID: 62945
		internal static int __PropertyOffset_11;

		// Token: 0x0400F5E2 RID: 62946
		internal static int __PropertyOffset_12;

		// Token: 0x0400F5E3 RID: 62947
		internal static int __PropertyOffset_13;

		// Token: 0x0400F5E4 RID: 62948
		internal static int __PropertyOffset_14;

		// Token: 0x0400F5E5 RID: 62949
		internal static int __PropertyOffset_15;

		// Token: 0x0400F5E6 RID: 62950
		internal static int __PropertyOffset_16;

		// Token: 0x0400F5E7 RID: 62951
		private TArray<FVector> _RipplePointList;

		// Token: 0x0400F5E8 RID: 62952
		internal static int __PropertyOffset_17;

		// Token: 0x0400F5E9 RID: 62953
		internal static int __PropertyOffset_18;

		// Token: 0x0400F5EA RID: 62954
		internal static int __PropertyOffset_19;

		// Token: 0x0400F5EB RID: 62955
		internal static int __PropertyOffset_20;

		// Token: 0x0400F5EC RID: 62956
		internal static int __PropertyOffset_21;

		// Token: 0x0400F5ED RID: 62957
		internal static int __PropertyOffset_22;

		// Token: 0x0400F5EE RID: 62958
		internal static int __PropertyOffset_23;

		// Token: 0x0400F5EF RID: 62959
		internal static int __PropertyOffset_24;

		// Token: 0x0400F5F0 RID: 62960
		internal static int __PropertyOffset_25;

		// Token: 0x0400F5F1 RID: 62961
		internal static int __PropertyOffset_26;

		// Token: 0x0400F5F2 RID: 62962
		internal static int __PropertyOffset_27;

		// Token: 0x0400F5F3 RID: 62963
		internal static int __PropertyOffset_28;

		// Token: 0x0400F5F4 RID: 62964
		internal static int __PropertyOffset_29;

		// Token: 0x0400F5F5 RID: 62965
		internal static int __PropertyOffset_30;

		// Token: 0x0400F5F6 RID: 62966
		internal static int __PropertyOffset_31;

		// Token: 0x0400F5F7 RID: 62967
		internal static int __PropertyOffset_32;

		// Token: 0x0400F5F8 RID: 62968
		internal static int __PropertyOffset_33;

		// Token: 0x0400F5F9 RID: 62969
		internal static int __PropertyOffset_34;

		// Token: 0x0400F5FA RID: 62970
		internal static int __PropertyOffset_35;

		// Token: 0x0400F5FB RID: 62971
		internal static int __PropertyOffset_36;

		// Token: 0x0400F5FC RID: 62972
		private static IntPtr __WaterRipple_NativeFunctionPtr;

		// Token: 0x0400F5FD RID: 62973
		private static IntPtr __VolumeSphereInWater_NativeFunctionPtr;

		// Token: 0x0400F5FE RID: 62974
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F5FF RID: 62975
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F600 RID: 62976
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x0400F601 RID: 62977
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x0400F602 RID: 62978
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F603 RID: 62979
		private static IntPtr __OnVisible_NativeFunctionPtr;

		// Token: 0x0400F604 RID: 62980
		private static IntPtr __OnInvisible_NativeFunctionPtr;

		// Token: 0x02009B5D RID: 39773
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __VolumeSphereInWater_FunctionParams
		{
			// Token: 0x0403118B RID: 201099
			[FieldOffset(0)]
			public float in_h;

			// Token: 0x0403118C RID: 201100
			[FieldOffset(4)]
			public FVector in_c;

			// Token: 0x0403118D RID: 201101
			[FieldOffset(16)]
			public float in_r;

			// Token: 0x0403118E RID: 201102
			[FieldOffset(20)]
			public float out_V;

			// Token: 0x0403118F RID: 201103
			[FieldOffset(24)]
			public float out_SpheveV;
		}

		// Token: 0x02009B5E RID: 39774
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031190 RID: 201104
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
