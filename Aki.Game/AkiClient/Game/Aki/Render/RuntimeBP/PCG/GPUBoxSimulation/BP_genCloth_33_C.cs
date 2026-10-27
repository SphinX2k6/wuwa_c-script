using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CB6 RID: 15542
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_genCloth_33.BP_genCloth_33_C")]
	[UnrealStructLayout(1840, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1836)]
	public class BP_genCloth_33_C : AKuroCSGenericCloth_33, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060249E7 RID: 149991 RVA: 0x00944144 File Offset: 0x00942344
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_genCloth_33_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_genCloth_33.BP_genCloth_33_C");
			}
			return BP_genCloth_33_C._ClassPtr;
		}

		// Token: 0x060249E8 RID: 149992 RVA: 0x00944168 File Offset: 0x00942368
		public BP_genCloth_33_C() : this(BuiltinUtils.AllocNativeUObject(BP_genCloth_33_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060249E9 RID: 149993 RVA: 0x00944190 File Offset: 0x00942390
		[NullableContext(1)]
		public BP_genCloth_33_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_genCloth_33_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004807 RID: 18439
		// (get) Token: 0x060249EA RID: 149994 RVA: 0x009441C3 File Offset: 0x009423C3
		// (set) Token: 0x060249EB RID: 149995 RVA: 0x009441D7 File Offset: 0x009423D7
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004808 RID: 18440
		// (get) Token: 0x060249EC RID: 149996 RVA: 0x009441EC File Offset: 0x009423EC
		// (set) Token: 0x060249ED RID: 149997 RVA: 0x00944200 File Offset: 0x00942400
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004809 RID: 18441
		// (get) Token: 0x060249EE RID: 149998 RVA: 0x00944215 File Offset: 0x00942415
		// (set) Token: 0x060249EF RID: 149999 RVA: 0x00944229 File Offset: 0x00942429
		public unsafe UStaticMeshComponent xpbd_test
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700480A RID: 18442
		// (get) Token: 0x060249F0 RID: 150000 RVA: 0x0094423E File Offset: 0x0094243E
		// (set) Token: 0x060249F1 RID: 150001 RVA: 0x00944252 File Offset: 0x00942452
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700480B RID: 18443
		// (get) Token: 0x060249F2 RID: 150002 RVA: 0x00944267 File Offset: 0x00942467
		// (set) Token: 0x060249F3 RID: 150003 RVA: 0x0094427B File Offset: 0x0094247B
		public unsafe UDataTable DT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700480C RID: 18444
		// (get) Token: 0x060249F4 RID: 150004 RVA: 0x00944290 File Offset: 0x00942490
		// (set) Token: 0x060249F5 RID: 150005 RVA: 0x009442A4 File Offset: 0x009424A4
		public unsafe UMaterialInstanceDynamic MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700480D RID: 18445
		// (get) Token: 0x060249F6 RID: 150006 RVA: 0x009442B9 File Offset: 0x009424B9
		// (set) Token: 0x060249F7 RID: 150007 RVA: 0x009442C9 File Offset: 0x009424C9
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700480E RID: 18446
		// (get) Token: 0x060249F8 RID: 150008 RVA: 0x009442DA File Offset: 0x009424DA
		// (set) Token: 0x060249F9 RID: 150009 RVA: 0x009442EE File Offset: 0x009424EE
		public unsafe UMaterialInstance InputMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700480F RID: 18447
		// (get) Token: 0x060249FA RID: 150010 RVA: 0x00944303 File Offset: 0x00942503
		// (set) Token: 0x060249FB RID: 150011 RVA: 0x00944313 File Offset: 0x00942513
		public unsafe float force
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004810 RID: 18448
		// (get) Token: 0x060249FC RID: 150012 RVA: 0x00944324 File Offset: 0x00942524
		// (set) Token: 0x060249FD RID: 150013 RVA: 0x00944334 File Offset: 0x00942534
		public unsafe bool Pressing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004811 RID: 18449
		// (get) Token: 0x060249FE RID: 150014 RVA: 0x00944345 File Offset: 0x00942545
		// (set) Token: 0x060249FF RID: 150015 RVA: 0x00944355 File Offset: 0x00942555
		public unsafe bool FS_isPhysicSimulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004812 RID: 18450
		// (get) Token: 0x06024A00 RID: 150016 RVA: 0x00944366 File Offset: 0x00942566
		// (set) Token: 0x06024A01 RID: 150017 RVA: 0x00944376 File Offset: 0x00942576
		public unsafe float mass_in_kg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004813 RID: 18451
		// (get) Token: 0x06024A02 RID: 150018 RVA: 0x00944387 File Offset: 0x00942587
		// (set) Token: 0x06024A03 RID: 150019 RVA: 0x00944397 File Offset: 0x00942597
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004814 RID: 18452
		// (get) Token: 0x06024A04 RID: 150020 RVA: 0x009443A8 File Offset: 0x009425A8
		// (set) Token: 0x06024A05 RID: 150021 RVA: 0x009443B8 File Offset: 0x009425B8
		public unsafe bool _2DRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004815 RID: 18453
		// (get) Token: 0x06024A06 RID: 150022 RVA: 0x009443C9 File Offset: 0x009425C9
		// (set) Token: 0x06024A07 RID: 150023 RVA: 0x009443D9 File Offset: 0x009425D9
		public unsafe int XCount_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004816 RID: 18454
		// (get) Token: 0x06024A08 RID: 150024 RVA: 0x009443EA File Offset: 0x009425EA
		// (set) Token: 0x06024A09 RID: 150025 RVA: 0x009443FA File Offset: 0x009425FA
		public unsafe bool ReadFromBPL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004817 RID: 18455
		// (get) Token: 0x06024A0A RID: 150026 RVA: 0x0094440B File Offset: 0x0094260B
		// (set) Token: 0x06024A0B RID: 150027 RVA: 0x0094441B File Offset: 0x0094261B
		public unsafe bool extraOneMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004818 RID: 18456
		// (get) Token: 0x06024A0C RID: 150028 RVA: 0x0094442C File Offset: 0x0094262C
		// (set) Token: 0x06024A0D RID: 150029 RVA: 0x00944440 File Offset: 0x00942640
		public unsafe UMaterialInstance InputMat1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17004819 RID: 18457
		// (get) Token: 0x06024A0E RID: 150030 RVA: 0x00944455 File Offset: 0x00942655
		// (set) Token: 0x06024A0F RID: 150031 RVA: 0x00944469 File Offset: 0x00942669
		public unsafe UMaterialInstanceDynamic MID1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x1700481A RID: 18458
		// (get) Token: 0x06024A10 RID: 150032 RVA: 0x0094447E File Offset: 0x0094267E
		// (set) Token: 0x06024A11 RID: 150033 RVA: 0x0094448E File Offset: 0x0094268E
		public unsafe bool StopBP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700481B RID: 18459
		// (get) Token: 0x06024A12 RID: 150034 RVA: 0x0094449F File Offset: 0x0094269F
		// (set) Token: 0x06024A13 RID: 150035 RVA: 0x009444AF File Offset: 0x009426AF
		public unsafe bool UseYCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700481C RID: 18460
		// (get) Token: 0x06024A14 RID: 150036 RVA: 0x009444C0 File Offset: 0x009426C0
		// (set) Token: 0x06024A15 RID: 150037 RVA: 0x009444D0 File Offset: 0x009426D0
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700481D RID: 18461
		// (get) Token: 0x06024A16 RID: 150038 RVA: 0x009444E1 File Offset: 0x009426E1
		// (set) Token: 0x06024A17 RID: 150039 RVA: 0x009444F5 File Offset: 0x009426F5
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700481E RID: 18462
		// (get) Token: 0x06024A18 RID: 150040 RVA: 0x0094450A File Offset: 0x0094270A
		// (set) Token: 0x06024A19 RID: 150041 RVA: 0x0094451E File Offset: 0x0094271E
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x1700481F RID: 18463
		// (get) Token: 0x06024A1A RID: 150042 RVA: 0x00944533 File Offset: 0x00942733
		// (set) Token: 0x06024A1B RID: 150043 RVA: 0x00944547 File Offset: 0x00942747
		public unsafe UTextureRenderTarget2D RT_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17004820 RID: 18464
		// (get) Token: 0x06024A1C RID: 150044 RVA: 0x0094455C File Offset: 0x0094275C
		// (set) Token: 0x06024A1D RID: 150045 RVA: 0x00944570 File Offset: 0x00942770
		public unsafe FVector gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004821 RID: 18465
		// (get) Token: 0x06024A1E RID: 150046 RVA: 0x00944585 File Offset: 0x00942785
		// (set) Token: 0x06024A1F RID: 150047 RVA: 0x00944595 File Offset: 0x00942795
		public unsafe bool UseStaticCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004822 RID: 18466
		// (get) Token: 0x06024A20 RID: 150048 RVA: 0x009445A6 File Offset: 0x009427A6
		// (set) Token: 0x06024A21 RID: 150049 RVA: 0x009445BA File Offset: 0x009427BA
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17004823 RID: 18467
		// (get) Token: 0x06024A22 RID: 150050 RVA: 0x009445D0 File Offset: 0x009427D0
		// (set) Token: 0x06024A23 RID: 150051 RVA: 0x00944609 File Offset: 0x00942809
		[Nullable(1)]
		public TArray<FKuroCSUnifiedCollider_genericCloth_33> ColArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSUnifiedCollider_genericCloth_33> result;
				if ((result = this._ColArr) == null)
				{
					result = (this._ColArr = new TArray<FKuroCSUnifiedCollider_genericCloth_33>(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_29, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ColArr.CopyAssign(value);
			}
		}

		// Token: 0x17004824 RID: 18468
		// (get) Token: 0x06024A24 RID: 150052 RVA: 0x00944617 File Offset: 0x00942817
		// (set) Token: 0x06024A25 RID: 150053 RVA: 0x00944627 File Offset: 0x00942827
		public unsafe bool Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004825 RID: 18469
		// (get) Token: 0x06024A26 RID: 150054 RVA: 0x00944638 File Offset: 0x00942838
		// (set) Token: 0x06024A27 RID: 150055 RVA: 0x00944648 File Offset: 0x00942848
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17004826 RID: 18470
		// (get) Token: 0x06024A28 RID: 150056 RVA: 0x00944659 File Offset: 0x00942859
		// (set) Token: 0x06024A29 RID: 150057 RVA: 0x00944669 File Offset: 0x00942869
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004827 RID: 18471
		// (get) Token: 0x06024A2A RID: 150058 RVA: 0x0094467A File Offset: 0x0094287A
		// (set) Token: 0x06024A2B RID: 150059 RVA: 0x0094468A File Offset: 0x0094288A
		public unsafe bool alreadyBuildArr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004828 RID: 18472
		// (get) Token: 0x06024A2C RID: 150060 RVA: 0x0094469B File Offset: 0x0094289B
		// (set) Token: 0x06024A2D RID: 150061 RVA: 0x009446AB File Offset: 0x009428AB
		public unsafe bool bAfterBeginplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004829 RID: 18473
		// (get) Token: 0x06024A2E RID: 150062 RVA: 0x009446BC File Offset: 0x009428BC
		// (set) Token: 0x06024A2F RID: 150063 RVA: 0x009446CC File Offset: 0x009428CC
		public unsafe bool PlatformCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024A30 RID: 150064 RVA: 0x009446DD File Offset: 0x009428DD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024A31 RID: 150065 RVA: 0x009446F1 File Offset: 0x009428F1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_genCloth_33_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024A32 RID: 150066 RVA: 0x00944706 File Offset: 0x00942906
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024A33 RID: 150067 RVA: 0x0094471A File Offset: 0x0094291A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_genCloth_33_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024A34 RID: 150068 RVA: 0x00944730 File Offset: 0x00942930
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_genCloth_33_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_genCloth_33_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_genCloth_33_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024A35 RID: 150069 RVA: 0x00944778 File Offset: 0x00942978
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_genCloth_33_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_genCloth_33_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_genCloth_33_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_genCloth_33_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024A36 RID: 150070 RVA: 0x009447C0 File Offset: 0x009429C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_genCloth_33_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_genCloth_33_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_genCloth_33_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024A37 RID: 150071 RVA: 0x0094480C File Offset: 0x00942A0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_genCloth_33_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_genCloth_33_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_genCloth_33_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_genCloth_33_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024A38 RID: 150072 RVA: 0x00944858 File Offset: 0x00942A58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult Hit)
		{
			BP_genCloth_33_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_genCloth_33_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_genCloth_33_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitComponent = ((HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->NormalImpulse = NormalImpulse;
			if (Hit != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->Hit, Hit.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024A39 RID: 150073 RVA: 0x0094490C File Offset: 0x00942B0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_genCloth_33_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_genCloth_33_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_genCloth_33_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024A3A RID: 150074 RVA: 0x009449C8 File Offset: 0x00942BC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_genCloth_33_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_genCloth_33_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_genCloth_33_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024A3B RID: 150075 RVA: 0x00944A54 File Offset: 0x00942C54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_genCloth_33_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_genCloth_33_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_genCloth_33_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024A3C RID: 150076 RVA: 0x00944AB7 File Offset: 0x00942CB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06024A3D RID: 150077 RVA: 0x00944ACB File Offset: 0x00942CCB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetDeadNode()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_C.__SetDeadNode_NativeFunctionPtr, null);
		}

		// Token: 0x06024A3E RID: 150078 RVA: 0x00944ADF File Offset: 0x00942CDF
		protected BP_genCloth_33_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012305 RID: 74501
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_genCloth_33.BP_genCloth_33_C";

		// Token: 0x04012306 RID: 74502
		private static IntPtr _ClassPtr;

		// Token: 0x04012307 RID: 74503
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012308 RID: 74504
		internal static int __PropertyOffset_1;

		// Token: 0x04012309 RID: 74505
		internal static int __PropertyOffset_2;

		// Token: 0x0401230A RID: 74506
		internal static int __PropertyOffset_3;

		// Token: 0x0401230B RID: 74507
		internal static int __PropertyOffset_4;

		// Token: 0x0401230C RID: 74508
		internal static int __PropertyOffset_5;

		// Token: 0x0401230D RID: 74509
		internal static int __PropertyOffset_6;

		// Token: 0x0401230E RID: 74510
		internal static int __PropertyOffset_7;

		// Token: 0x0401230F RID: 74511
		internal static int __PropertyOffset_8;

		// Token: 0x04012310 RID: 74512
		internal static int __PropertyOffset_9;

		// Token: 0x04012311 RID: 74513
		internal static int __PropertyOffset_10;

		// Token: 0x04012312 RID: 74514
		internal static int __PropertyOffset_11;

		// Token: 0x04012313 RID: 74515
		internal static int __PropertyOffset_12;

		// Token: 0x04012314 RID: 74516
		internal static int __PropertyOffset_13;

		// Token: 0x04012315 RID: 74517
		internal static int __PropertyOffset_14;

		// Token: 0x04012316 RID: 74518
		internal static int __PropertyOffset_15;

		// Token: 0x04012317 RID: 74519
		internal static int __PropertyOffset_16;

		// Token: 0x04012318 RID: 74520
		internal static int __PropertyOffset_17;

		// Token: 0x04012319 RID: 74521
		internal static int __PropertyOffset_18;

		// Token: 0x0401231A RID: 74522
		internal static int __PropertyOffset_19;

		// Token: 0x0401231B RID: 74523
		internal static int __PropertyOffset_20;

		// Token: 0x0401231C RID: 74524
		internal static int __PropertyOffset_21;

		// Token: 0x0401231D RID: 74525
		internal static int __PropertyOffset_22;

		// Token: 0x0401231E RID: 74526
		internal static int __PropertyOffset_23;

		// Token: 0x0401231F RID: 74527
		internal static int __PropertyOffset_24;

		// Token: 0x04012320 RID: 74528
		internal static int __PropertyOffset_25;

		// Token: 0x04012321 RID: 74529
		internal static int __PropertyOffset_26;

		// Token: 0x04012322 RID: 74530
		internal static int __PropertyOffset_27;

		// Token: 0x04012323 RID: 74531
		internal static int __PropertyOffset_28;

		// Token: 0x04012324 RID: 74532
		internal static int __PropertyOffset_29;

		// Token: 0x04012325 RID: 74533
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSUnifiedCollider_genericCloth_33> _ColArr;

		// Token: 0x04012326 RID: 74534
		internal static int __PropertyOffset_30;

		// Token: 0x04012327 RID: 74535
		internal static int __PropertyOffset_31;

		// Token: 0x04012328 RID: 74536
		internal static int __PropertyOffset_32;

		// Token: 0x04012329 RID: 74537
		internal static int __PropertyOffset_33;

		// Token: 0x0401232A RID: 74538
		internal static int __PropertyOffset_34;

		// Token: 0x0401232B RID: 74539
		internal static int __PropertyOffset_35;

		// Token: 0x0401232C RID: 74540
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401232D RID: 74541
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401232E RID: 74542
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401232F RID: 74543
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04012330 RID: 74544
		private static IntPtr __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012331 RID: 74545
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012332 RID: 74546
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012333 RID: 74547
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x04012334 RID: 74548
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04012335 RID: 74549
		private static IntPtr __SetDeadNode_NativeFunctionPtr;

		// Token: 0x02009F53 RID: 40787
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403191F RID: 203039
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F54 RID: 40788
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031920 RID: 203040
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009F55 RID: 40789
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031921 RID: 203041
			[FieldOffset(0)]
			public IntPtr HitComponent;

			// Token: 0x04031922 RID: 203042
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031923 RID: 203043
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031924 RID: 203044
			[FieldOffset(24)]
			public FVector NormalImpulse;

			// Token: 0x04031925 RID: 203045
			[FieldOffset(36)]
			public byte Hit;
		}

		// Token: 0x02009F56 RID: 40790
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031926 RID: 203046
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031927 RID: 203047
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031928 RID: 203048
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031929 RID: 203049
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403192A RID: 203050
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403192B RID: 203051
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F57 RID: 40791
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403192C RID: 203052
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403192D RID: 203053
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403192E RID: 203054
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403192F RID: 203055
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009F58 RID: 40792
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031930 RID: 203056
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031931 RID: 203057
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031932 RID: 203058
			[FieldOffset(32)]
			public int Id;
		}
	}
}
