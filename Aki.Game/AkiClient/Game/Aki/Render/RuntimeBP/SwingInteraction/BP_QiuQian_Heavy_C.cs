using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SwingInteraction
{
	// Token: 0x02003AC1 RID: 15041
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_QiuQian_Heavy.BP_QiuQian_Heavy_C")]
	[UnrealStructLayout(1704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1697)]
	public class BP_QiuQian_Heavy_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020545 RID: 132421 RVA: 0x008CFBB2 File Offset: 0x008CDDB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QiuQian_Heavy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_QiuQian_Heavy.BP_QiuQian_Heavy_C");
			}
			return BP_QiuQian_Heavy_C._ClassPtr;
		}

		// Token: 0x06020546 RID: 132422 RVA: 0x008CFBD8 File Offset: 0x008CDDD8
		public BP_QiuQian_Heavy_C() : this(BuiltinUtils.AllocNativeUObject(BP_QiuQian_Heavy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020547 RID: 132423 RVA: 0x008CFC00 File Offset: 0x008CDE00
		[NullableContext(1)]
		public BP_QiuQian_Heavy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QiuQian_Heavy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700302C RID: 12332
		// (get) Token: 0x06020548 RID: 132424 RVA: 0x008CFC33 File Offset: 0x008CDE33
		// (set) Token: 0x06020549 RID: 132425 RVA: 0x008CFC47 File Offset: 0x008CDE47
		public unsafe UStaticMeshComponent SM_Old_Eff_02BS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x0602054A RID: 132426 RVA: 0x008CFC5C File Offset: 0x008CDE5C
		// (set) Token: 0x0602054B RID: 132427 RVA: 0x008CFC70 File Offset: 0x008CDE70
		public unsafe UStaticMeshComponent SM_SwingSingleRopeR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x0602054C RID: 132428 RVA: 0x008CFC85 File Offset: 0x008CDE85
		// (set) Token: 0x0602054D RID: 132429 RVA: 0x008CFC99 File Offset: 0x008CDE99
		public unsafe UStaticMeshComponent SM_SwingSingleRopeL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x0602054E RID: 132430 RVA: 0x008CFCAE File Offset: 0x008CDEAE
		// (set) Token: 0x0602054F RID: 132431 RVA: 0x008CFCC2 File Offset: 0x008CDEC2
		public unsafe UStaticMeshComponent SM_SwingTop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x06020550 RID: 132432 RVA: 0x008CFCD7 File Offset: 0x008CDED7
		// (set) Token: 0x06020551 RID: 132433 RVA: 0x008CFCEB File Offset: 0x008CDEEB
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x06020552 RID: 132434 RVA: 0x008CFD00 File Offset: 0x008CDF00
		// (set) Token: 0x06020553 RID: 132435 RVA: 0x008CFD14 File Offset: 0x008CDF14
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x06020554 RID: 132436 RVA: 0x008CFD2C File Offset: 0x008CDF2C
		// (set) Token: 0x06020555 RID: 132437 RVA: 0x008CFD65 File Offset: 0x008CDF65
		[Nullable(1)]
		public TArray<FName> NameList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._NameList) == null)
				{
					result = (this._NameList = new TArray<FName>(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NameList.CopyAssign(value);
			}
		}

		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x06020556 RID: 132438 RVA: 0x008CFD73 File Offset: 0x008CDF73
		// (set) Token: 0x06020557 RID: 132439 RVA: 0x008CFD83 File Offset: 0x008CDF83
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x06020558 RID: 132440 RVA: 0x008CFD94 File Offset: 0x008CDF94
		// (set) Token: 0x06020559 RID: 132441 RVA: 0x008CFDA4 File Offset: 0x008CDFA4
		public unsafe bool bUseConstantDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x0602055A RID: 132442 RVA: 0x008CFDB5 File Offset: 0x008CDFB5
		// (set) Token: 0x0602055B RID: 132443 RVA: 0x008CFDC5 File Offset: 0x008CDFC5
		public unsafe float ConstantDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x0602055C RID: 132444 RVA: 0x008CFDD6 File Offset: 0x008CDFD6
		// (set) Token: 0x0602055D RID: 132445 RVA: 0x008CFDEA File Offset: 0x008CDFEA
		public unsafe FVector StartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x0602055E RID: 132446 RVA: 0x008CFDFF File Offset: 0x008CDFFF
		// (set) Token: 0x0602055F RID: 132447 RVA: 0x008CFE0F File Offset: 0x008CE00F
		public unsafe int particleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x06020560 RID: 132448 RVA: 0x008CFE20 File Offset: 0x008CE020
		// (set) Token: 0x06020561 RID: 132449 RVA: 0x008CFE30 File Offset: 0x008CE030
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x06020562 RID: 132450 RVA: 0x008CFE41 File Offset: 0x008CE041
		// (set) Token: 0x06020563 RID: 132451 RVA: 0x008CFE55 File Offset: 0x008CE055
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x06020564 RID: 132452 RVA: 0x008CFE6A File Offset: 0x008CE06A
		// (set) Token: 0x06020565 RID: 132453 RVA: 0x008CFE7A File Offset: 0x008CE07A
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x06020566 RID: 132454 RVA: 0x008CFE8B File Offset: 0x008CE08B
		// (set) Token: 0x06020567 RID: 132455 RVA: 0x008CFE9B File Offset: 0x008CE09B
		public unsafe float volDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x06020568 RID: 132456 RVA: 0x008CFEAC File Offset: 0x008CE0AC
		// (set) Token: 0x06020569 RID: 132457 RVA: 0x008CFEC0 File Offset: 0x008CE0C0
		public unsafe FVector startPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x0602056A RID: 132458 RVA: 0x008CFED5 File Offset: 0x008CE0D5
		// (set) Token: 0x0602056B RID: 132459 RVA: 0x008CFEE9 File Offset: 0x008CE0E9
		public unsafe FVector endPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x0602056C RID: 132460 RVA: 0x008CFEFE File Offset: 0x008CE0FE
		// (set) Token: 0x0602056D RID: 132461 RVA: 0x008CFF12 File Offset: 0x008CE112
		public unsafe FVector leftPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x0602056E RID: 132462 RVA: 0x008CFF27 File Offset: 0x008CE127
		// (set) Token: 0x0602056F RID: 132463 RVA: 0x008CFF3B File Offset: 0x008CE13B
		public unsafe FVector rightPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x06020570 RID: 132464 RVA: 0x008CFF50 File Offset: 0x008CE150
		// (set) Token: 0x06020571 RID: 132465 RVA: 0x008CFF64 File Offset: 0x008CE164
		public unsafe FVector leftNorm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x06020572 RID: 132466 RVA: 0x008CFF7C File Offset: 0x008CE17C
		// (set) Token: 0x06020573 RID: 132467 RVA: 0x008CFFB5 File Offset: 0x008CE1B5
		[Nullable(1)]
		public TArray<FParticle_QiuQian> particleArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FParticle_QiuQian> result;
				if ((result = this._particleArr) == null)
				{
					result = (this._particleArr = new TArray<FParticle_QiuQian>(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_22, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.particleArr.CopyAssign(value);
			}
		}

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x06020574 RID: 132468 RVA: 0x008CFFC3 File Offset: 0x008CE1C3
		// (set) Token: 0x06020575 RID: 132469 RVA: 0x008CFFD7 File Offset: 0x008CE1D7
		public unsafe FVector rightNorm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x06020576 RID: 132470 RVA: 0x008CFFEC File Offset: 0x008CE1EC
		// (set) Token: 0x06020577 RID: 132471 RVA: 0x008CFFFC File Offset: 0x008CE1FC
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x06020578 RID: 132472 RVA: 0x008D000D File Offset: 0x008CE20D
		// (set) Token: 0x06020579 RID: 132473 RVA: 0x008D001D File Offset: 0x008CE21D
		public unsafe float endParticleMassScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x0602057A RID: 132474 RVA: 0x008D002E File Offset: 0x008CE22E
		// (set) Token: 0x0602057B RID: 132475 RVA: 0x008D003E File Offset: 0x008CE23E
		public unsafe float debugDrawDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x0602057C RID: 132476 RVA: 0x008D004F File Offset: 0x008CE24F
		// (set) Token: 0x0602057D RID: 132477 RVA: 0x008D005F File Offset: 0x008CE25F
		public unsafe bool IsEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x0602057E RID: 132478 RVA: 0x008D0070 File Offset: 0x008CE270
		// (set) Token: 0x0602057F RID: 132479 RVA: 0x008D0080 File Offset: 0x008CE280
		public unsafe bool IsPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x06020580 RID: 132480 RVA: 0x008D0091 File Offset: 0x008CE291
		// (set) Token: 0x06020581 RID: 132481 RVA: 0x008D00A5 File Offset: 0x008CE2A5
		public unsafe UMaterialInstanceDynamic DMI_RopeL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x06020582 RID: 132482 RVA: 0x008D00BA File Offset: 0x008CE2BA
		// (set) Token: 0x06020583 RID: 132483 RVA: 0x008D00CE File Offset: 0x008CE2CE
		public unsafe UMaterialInstanceDynamic DMI_RopeR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_Heavy_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x06020584 RID: 132484 RVA: 0x008D00E3 File Offset: 0x008CE2E3
		// (set) Token: 0x06020585 RID: 132485 RVA: 0x008D00F3 File Offset: 0x008CE2F3
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x06020586 RID: 132486 RVA: 0x008D0104 File Offset: 0x008CE304
		// (set) Token: 0x06020587 RID: 132487 RVA: 0x008D0114 File Offset: 0x008CE314
		public unsafe float WarmTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x06020588 RID: 132488 RVA: 0x008D0125 File Offset: 0x008CE325
		// (set) Token: 0x06020589 RID: 132489 RVA: 0x008D0135 File Offset: 0x008CE335
		public unsafe bool IsWarm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_Heavy_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602058A RID: 132490 RVA: 0x008D0146 File Offset: 0x008CE346
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeParticleArr()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__InitializeParticleArr_NativeFunctionPtr, null);
		}

		// Token: 0x0602058B RID: 132491 RVA: 0x008D015C File Offset: 0x008CE35C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetDMIOffsetEnable(bool OffsetEnable)
		{
			BP_QiuQian_Heavy_C.__SetDMIOffsetEnable_FunctionParams* ptr = stackalloc BP_QiuQian_Heavy_C.__SetDMIOffsetEnable_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(BP_QiuQian_Heavy_C.__SetDMIOffsetEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQian_Heavy_C.__SetDMIOffsetEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OffsetEnable = OffsetEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__SetDMIOffsetEnable_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602058C RID: 132492 RVA: 0x008D01A2 File Offset: 0x008CE3A2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateaDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__UpdateaDMI_NativeFunctionPtr, null);
		}

		// Token: 0x0602058D RID: 132493 RVA: 0x008D01B6 File Offset: 0x008CE3B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__InitializeDMI_NativeFunctionPtr, null);
		}

		// Token: 0x0602058E RID: 132494 RVA: 0x008D01CC File Offset: 0x008CE3CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void solve(bool isPinned, FVector pos, FVector linkPos, float targetLen, FVector emitterOriginPos, ref FVector pos_new)
		{
			BP_QiuQian_Heavy_C.__solve_FunctionParams* ptr = stackalloc BP_QiuQian_Heavy_C.__solve_FunctionParams[(UIntPtr)131] + 15L / (long)sizeof(BP_QiuQian_Heavy_C.__solve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQian_Heavy_C.__solve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isPinned = isPinned;
			ptr->pos = pos;
			ptr->linkPos = linkPos;
			ptr->targetLen = targetLen;
			ptr->emitterOriginPos = emitterOriginPos;
			ptr->pos_new = pos_new;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__solve_NativeFunctionPtr, (void*)ptr);
			pos_new = ptr->pos_new;
		}

		// Token: 0x0602058F RID: 132495 RVA: 0x008D024D File Offset: 0x008CE44D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020590 RID: 132496 RVA: 0x008D0261 File Offset: 0x008CE461
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020591 RID: 132497 RVA: 0x008D0276 File Offset: 0x008CE476
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020592 RID: 132498 RVA: 0x008D028A File Offset: 0x008CE48A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020593 RID: 132499 RVA: 0x008D02A0 File Offset: 0x008CE4A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_QiuQian_Heavy_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_QiuQian_Heavy_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_QiuQian_Heavy_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQian_Heavy_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020594 RID: 132500 RVA: 0x008D02E8 File Offset: 0x008CE4E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_QiuQian_Heavy_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_QiuQian_Heavy_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_QiuQian_Heavy_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQian_Heavy_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020595 RID: 132501 RVA: 0x008D032F File Offset: 0x008CE52F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void place_plank_event()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__place_plank_event_NativeFunctionPtr, null);
		}

		// Token: 0x06020596 RID: 132502 RVA: 0x008D0343 File Offset: 0x008CE543
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06020597 RID: 132503 RVA: 0x008D0357 File Offset: 0x008CE557
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020598 RID: 132504 RVA: 0x008D036C File Offset: 0x008CE56C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06020599 RID: 132505 RVA: 0x008D0380 File Offset: 0x008CE580
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_Heavy_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602059A RID: 132506 RVA: 0x008D0395 File Offset: 0x008CE595
		protected BP_QiuQian_Heavy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA3D RID: 64061
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_QiuQian_Heavy.BP_QiuQian_Heavy_C";

		// Token: 0x0400FA3E RID: 64062
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA3F RID: 64063
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA40 RID: 64064
		internal static int __PropertyOffset_1;

		// Token: 0x0400FA41 RID: 64065
		internal static int __PropertyOffset_2;

		// Token: 0x0400FA42 RID: 64066
		internal static int __PropertyOffset_3;

		// Token: 0x0400FA43 RID: 64067
		internal static int __PropertyOffset_4;

		// Token: 0x0400FA44 RID: 64068
		internal static int __PropertyOffset_5;

		// Token: 0x0400FA45 RID: 64069
		internal static int __PropertyOffset_6;

		// Token: 0x0400FA46 RID: 64070
		internal static int __PropertyOffset_7;

		// Token: 0x0400FA47 RID: 64071
		private TArray<FName> _NameList;

		// Token: 0x0400FA48 RID: 64072
		internal static int __PropertyOffset_8;

		// Token: 0x0400FA49 RID: 64073
		internal static int __PropertyOffset_9;

		// Token: 0x0400FA4A RID: 64074
		internal static int __PropertyOffset_10;

		// Token: 0x0400FA4B RID: 64075
		internal static int __PropertyOffset_11;

		// Token: 0x0400FA4C RID: 64076
		internal static int __PropertyOffset_12;

		// Token: 0x0400FA4D RID: 64077
		internal static int __PropertyOffset_13;

		// Token: 0x0400FA4E RID: 64078
		internal static int __PropertyOffset_14;

		// Token: 0x0400FA4F RID: 64079
		internal static int __PropertyOffset_15;

		// Token: 0x0400FA50 RID: 64080
		internal static int __PropertyOffset_16;

		// Token: 0x0400FA51 RID: 64081
		internal static int __PropertyOffset_17;

		// Token: 0x0400FA52 RID: 64082
		internal static int __PropertyOffset_18;

		// Token: 0x0400FA53 RID: 64083
		internal static int __PropertyOffset_19;

		// Token: 0x0400FA54 RID: 64084
		internal static int __PropertyOffset_20;

		// Token: 0x0400FA55 RID: 64085
		internal static int __PropertyOffset_21;

		// Token: 0x0400FA56 RID: 64086
		internal static int __PropertyOffset_22;

		// Token: 0x0400FA57 RID: 64087
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FParticle_QiuQian> _particleArr;

		// Token: 0x0400FA58 RID: 64088
		internal static int __PropertyOffset_23;

		// Token: 0x0400FA59 RID: 64089
		internal static int __PropertyOffset_24;

		// Token: 0x0400FA5A RID: 64090
		internal static int __PropertyOffset_25;

		// Token: 0x0400FA5B RID: 64091
		internal static int __PropertyOffset_26;

		// Token: 0x0400FA5C RID: 64092
		internal static int __PropertyOffset_27;

		// Token: 0x0400FA5D RID: 64093
		internal static int __PropertyOffset_28;

		// Token: 0x0400FA5E RID: 64094
		internal static int __PropertyOffset_29;

		// Token: 0x0400FA5F RID: 64095
		internal static int __PropertyOffset_30;

		// Token: 0x0400FA60 RID: 64096
		internal static int __PropertyOffset_31;

		// Token: 0x0400FA61 RID: 64097
		internal static int __PropertyOffset_32;

		// Token: 0x0400FA62 RID: 64098
		internal static int __PropertyOffset_33;

		// Token: 0x0400FA63 RID: 64099
		private static IntPtr __InitializeParticleArr_NativeFunctionPtr;

		// Token: 0x0400FA64 RID: 64100
		private static IntPtr __SetDMIOffsetEnable_NativeFunctionPtr;

		// Token: 0x0400FA65 RID: 64101
		private static IntPtr __UpdateaDMI_NativeFunctionPtr;

		// Token: 0x0400FA66 RID: 64102
		private static IntPtr __InitializeDMI_NativeFunctionPtr;

		// Token: 0x0400FA67 RID: 64103
		private static IntPtr __solve_NativeFunctionPtr;

		// Token: 0x0400FA68 RID: 64104
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FA69 RID: 64105
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FA6A RID: 64106
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FA6B RID: 64107
		private static IntPtr __place_plank_event_NativeFunctionPtr;

		// Token: 0x0400FA6C RID: 64108
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x0400FA6D RID: 64109
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x02009BA5 RID: 39845
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __SetDMIOffsetEnable_FunctionParams
		{
			// Token: 0x04031208 RID: 201224
			[FieldOffset(0)]
			public bool OffsetEnable;
		}

		// Token: 0x02009BA6 RID: 39846
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 116)]
		protected ref struct __solve_FunctionParams
		{
			// Token: 0x04031209 RID: 201225
			[FieldOffset(0)]
			public bool isPinned;

			// Token: 0x0403120A RID: 201226
			[FieldOffset(4)]
			public FVector pos;

			// Token: 0x0403120B RID: 201227
			[FieldOffset(16)]
			public FVector linkPos;

			// Token: 0x0403120C RID: 201228
			[FieldOffset(28)]
			public float targetLen;

			// Token: 0x0403120D RID: 201229
			[FieldOffset(32)]
			public FVector emitterOriginPos;

			// Token: 0x0403120E RID: 201230
			[FieldOffset(44)]
			public FVector pos_new;
		}

		// Token: 0x02009BA7 RID: 39847
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403120F RID: 201231
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
