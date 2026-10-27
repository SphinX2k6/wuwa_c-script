using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.LightningFire
{
	// Token: 0x02003C74 RID: 15476
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/LightningFire/BP_LightningFire.BP_LightningFire_C")]
	[UnrealStructLayout(1784, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1784)]
	public class BP_LightningFire_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023E89 RID: 147081 RVA: 0x00930538 File Offset: 0x0092E738
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LightningFire_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/LightningFire/BP_LightningFire.BP_LightningFire_C");
			}
			return BP_LightningFire_C._ClassPtr;
		}

		// Token: 0x06023E8A RID: 147082 RVA: 0x0093055C File Offset: 0x0092E75C
		public BP_LightningFire_C() : this(BuiltinUtils.AllocNativeUObject(BP_LightningFire_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023E8B RID: 147083 RVA: 0x00930584 File Offset: 0x0092E784
		[NullableContext(1)]
		public BP_LightningFire_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LightningFire_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004412 RID: 17426
		// (get) Token: 0x06023E8C RID: 147084 RVA: 0x009305B7 File Offset: 0x0092E7B7
		// (set) Token: 0x06023E8D RID: 147085 RVA: 0x009305CB File Offset: 0x0092E7CB
		public unsafe UNiagaraComponent NS_LightningFire_ES3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004413 RID: 17427
		// (get) Token: 0x06023E8E RID: 147086 RVA: 0x009305E0 File Offset: 0x0092E7E0
		// (set) Token: 0x06023E8F RID: 147087 RVA: 0x009305F4 File Offset: 0x0092E7F4
		public unsafe UStaticMeshComponent SM_LightningFire
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004414 RID: 17428
		// (get) Token: 0x06023E90 RID: 147088 RVA: 0x00930609 File Offset: 0x0092E809
		// (set) Token: 0x06023E91 RID: 147089 RVA: 0x0093061D File Offset: 0x0092E81D
		public unsafe USphereComponent DetectionCollision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004415 RID: 17429
		// (get) Token: 0x06023E92 RID: 147090 RVA: 0x00930632 File Offset: 0x0092E832
		// (set) Token: 0x06023E93 RID: 147091 RVA: 0x00930646 File Offset: 0x0092E846
		public unsafe UNiagaraComponent Niagara_Tree
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004416 RID: 17430
		// (get) Token: 0x06023E94 RID: 147092 RVA: 0x0093065B File Offset: 0x0092E85B
		// (set) Token: 0x06023E95 RID: 147093 RVA: 0x0093066F File Offset: 0x0092E86F
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004417 RID: 17431
		// (get) Token: 0x06023E96 RID: 147094 RVA: 0x00930684 File Offset: 0x0092E884
		// (set) Token: 0x06023E97 RID: 147095 RVA: 0x00930698 File Offset: 0x0092E898
		public unsafe UBoxComponent PostProcessBoundView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004418 RID: 17432
		// (get) Token: 0x06023E98 RID: 147096 RVA: 0x009306AD File Offset: 0x0092E8AD
		// (set) Token: 0x06023E99 RID: 147097 RVA: 0x009306C1 File Offset: 0x0092E8C1
		public unsafe UTextRenderComponent FireBurnt
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004419 RID: 17433
		// (get) Token: 0x06023E9A RID: 147098 RVA: 0x009306D6 File Offset: 0x0092E8D6
		// (set) Token: 0x06023E9B RID: 147099 RVA: 0x009306EA File Offset: 0x0092E8EA
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700441A RID: 17434
		// (get) Token: 0x06023E9C RID: 147100 RVA: 0x009306FF File Offset: 0x0092E8FF
		// (set) Token: 0x06023E9D RID: 147101 RVA: 0x00930713 File Offset: 0x0092E913
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x1700441B RID: 17435
		// (get) Token: 0x06023E9E RID: 147102 RVA: 0x00930728 File Offset: 0x0092E928
		// (set) Token: 0x06023E9F RID: 147103 RVA: 0x00930738 File Offset: 0x0092E938
		public unsafe float SpreadTimeLinear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700441C RID: 17436
		// (get) Token: 0x06023EA0 RID: 147104 RVA: 0x00930749 File Offset: 0x0092E949
		// (set) Token: 0x06023EA1 RID: 147105 RVA: 0x00930759 File Offset: 0x0092E959
		public unsafe bool StartPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700441D RID: 17437
		// (get) Token: 0x06023EA2 RID: 147106 RVA: 0x0093076A File Offset: 0x0092E96A
		// (set) Token: 0x06023EA3 RID: 147107 RVA: 0x0093077E File Offset: 0x0092E97E
		public unsafe FLinearColor FireColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700441E RID: 17438
		// (get) Token: 0x06023EA4 RID: 147108 RVA: 0x00930793 File Offset: 0x0092E993
		// (set) Token: 0x06023EA5 RID: 147109 RVA: 0x009307A3 File Offset: 0x0092E9A3
		public unsafe float SpreadSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700441F RID: 17439
		// (get) Token: 0x06023EA6 RID: 147110 RVA: 0x009307B4 File Offset: 0x0092E9B4
		// (set) Token: 0x06023EA7 RID: 147111 RVA: 0x009307C4 File Offset: 0x0092E9C4
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004420 RID: 17440
		// (get) Token: 0x06023EA8 RID: 147112 RVA: 0x009307D5 File Offset: 0x0092E9D5
		// (set) Token: 0x06023EA9 RID: 147113 RVA: 0x009307E5 File Offset: 0x0092E9E5
		public unsafe float BoundSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004421 RID: 17441
		// (get) Token: 0x06023EAA RID: 147114 RVA: 0x009307F6 File Offset: 0x0092E9F6
		// (set) Token: 0x06023EAB RID: 147115 RVA: 0x00930806 File Offset: 0x0092EA06
		public unsafe float Is_Play
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004422 RID: 17442
		// (get) Token: 0x06023EAC RID: 147116 RVA: 0x00930817 File Offset: 0x0092EA17
		// (set) Token: 0x06023EAD RID: 147117 RVA: 0x0093082C File Offset: 0x0092EA2C
		[Nullable(1)]
		public TSoftObjectPtr<AKuroGlobalGI> GlobalGI
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<AKuroGlobalGI>(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_17, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_17, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004423 RID: 17443
		// (get) Token: 0x06023EAE RID: 147118 RVA: 0x00930851 File Offset: 0x0092EA51
		// (set) Token: 0x06023EAF RID: 147119 RVA: 0x00930866 File Offset: 0x0092EA66
		[Nullable(1)]
		public TSoftObjectPtr<AKuroGlobalGI> GlobalGI_Temp
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<AKuroGlobalGI>(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_18, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_18, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004424 RID: 17444
		// (get) Token: 0x06023EB0 RID: 147120 RVA: 0x0093088B File Offset: 0x0092EA8B
		// (set) Token: 0x06023EB1 RID: 147121 RVA: 0x0093089B File Offset: 0x0092EA9B
		public unsafe float Probability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004425 RID: 17445
		// (get) Token: 0x06023EB2 RID: 147122 RVA: 0x009308AC File Offset: 0x0092EAAC
		// (set) Token: 0x06023EB3 RID: 147123 RVA: 0x009308BC File Offset: 0x0092EABC
		public unsafe float DeltaScond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004426 RID: 17446
		// (get) Token: 0x06023EB4 RID: 147124 RVA: 0x009308CD File Offset: 0x0092EACD
		// (set) Token: 0x06023EB5 RID: 147125 RVA: 0x009308DD File Offset: 0x0092EADD
		public unsafe float TriggerDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004427 RID: 17447
		// (get) Token: 0x06023EB6 RID: 147126 RVA: 0x009308EE File Offset: 0x0092EAEE
		// (set) Token: 0x06023EB7 RID: 147127 RVA: 0x00930902 File Offset: 0x0092EB02
		public unsafe FVectorDouble NiagaraPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004428 RID: 17448
		// (get) Token: 0x06023EB8 RID: 147128 RVA: 0x00930917 File Offset: 0x0092EB17
		// (set) Token: 0x06023EB9 RID: 147129 RVA: 0x00930927 File Offset: 0x0092EB27
		public unsafe float TakeEffectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004429 RID: 17449
		// (get) Token: 0x06023EBA RID: 147130 RVA: 0x00930938 File Offset: 0x0092EB38
		// (set) Token: 0x06023EBB RID: 147131 RVA: 0x00930948 File Offset: 0x0092EB48
		public unsafe bool bPlayerIsTriggerZone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700442A RID: 17450
		// (get) Token: 0x06023EBC RID: 147132 RVA: 0x00930959 File Offset: 0x0092EB59
		// (set) Token: 0x06023EBD RID: 147133 RVA: 0x00930969 File Offset: 0x0092EB69
		public unsafe bool DeBug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700442B RID: 17451
		// (get) Token: 0x06023EBE RID: 147134 RVA: 0x0093097A File Offset: 0x0092EB7A
		// (set) Token: 0x06023EBF RID: 147135 RVA: 0x0093098A File Offset: 0x0092EB8A
		public unsafe float TreeFireSpriteSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700442C RID: 17452
		// (get) Token: 0x06023EC0 RID: 147136 RVA: 0x0093099B File Offset: 0x0092EB9B
		// (set) Token: 0x06023EC1 RID: 147137 RVA: 0x009309AF File Offset: 0x0092EBAF
		public unsafe UKuroWeatherDataAsset WeatherDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x1700442D RID: 17453
		// (get) Token: 0x06023EC2 RID: 147138 RVA: 0x009309C4 File Offset: 0x0092EBC4
		// (set) Token: 0x06023EC3 RID: 147139 RVA: 0x009309D4 File Offset: 0x0092EBD4
		public unsafe float PostProcessRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700442E RID: 17454
		// (get) Token: 0x06023EC4 RID: 147140 RVA: 0x009309E5 File Offset: 0x0092EBE5
		// (set) Token: 0x06023EC5 RID: 147141 RVA: 0x009309F5 File Offset: 0x0092EBF5
		public unsafe float Post_BlendRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x1700442F RID: 17455
		// (get) Token: 0x06023EC6 RID: 147142 RVA: 0x00930A06 File Offset: 0x0092EC06
		// (set) Token: 0x06023EC7 RID: 147143 RVA: 0x00930A16 File Offset: 0x0092EC16
		public unsafe float Post_Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17004430 RID: 17456
		// (get) Token: 0x06023EC8 RID: 147144 RVA: 0x00930A27 File Offset: 0x0092EC27
		// (set) Token: 0x06023EC9 RID: 147145 RVA: 0x00930A3B File Offset: 0x0092EC3B
		public unsafe AStaticMeshActor FoliageStaticMeshActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x17004431 RID: 17457
		// (get) Token: 0x06023ECA RID: 147146 RVA: 0x00930A50 File Offset: 0x0092EC50
		// (set) Token: 0x06023ECB RID: 147147 RVA: 0x00930A60 File Offset: 0x0092EC60
		public unsafe bool View_Probability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004432 RID: 17458
		// (get) Token: 0x06023ECC RID: 147148 RVA: 0x00930A71 File Offset: 0x0092EC71
		// (set) Token: 0x06023ECD RID: 147149 RVA: 0x00930A81 File Offset: 0x0092EC81
		public unsafe bool bIsOnCooldown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004433 RID: 17459
		// (get) Token: 0x06023ECE RID: 147150 RVA: 0x00930A92 File Offset: 0x0092EC92
		// (set) Token: 0x06023ECF RID: 147151 RVA: 0x00930AA2 File Offset: 0x0092ECA2
		public unsafe float CooldoownTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17004434 RID: 17460
		// (get) Token: 0x06023ED0 RID: 147152 RVA: 0x00930AB3 File Offset: 0x0092ECB3
		// (set) Token: 0x06023ED1 RID: 147153 RVA: 0x00930AC3 File Offset: 0x0092ECC3
		public unsafe bool TriggerCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004435 RID: 17461
		// (get) Token: 0x06023ED2 RID: 147154 RVA: 0x00930AD4 File Offset: 0x0092ECD4
		// (set) Token: 0x06023ED3 RID: 147155 RVA: 0x00930AE4 File Offset: 0x0092ECE4
		public unsafe bool Is_ES3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightningFire_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004436 RID: 17462
		// (get) Token: 0x06023ED4 RID: 147156 RVA: 0x00930AF5 File Offset: 0x0092ECF5
		// (set) Token: 0x06023ED5 RID: 147157 RVA: 0x00930B09 File Offset: 0x0092ED09
		public unsafe UAkAudioEvent AudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightningFire_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x06023ED6 RID: 147158 RVA: 0x00930B1E File Offset: 0x0092ED1E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_ES3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningFire_C.__Set_ES3_NativeFunctionPtr, null);
		}

		// Token: 0x06023ED7 RID: 147159 RVA: 0x00930B32 File Offset: 0x0092ED32
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetPostProcessVolume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningFire_C.__SetPostProcessVolume_NativeFunctionPtr, null);
		}

		// Token: 0x06023ED8 RID: 147160 RVA: 0x00930B48 File Offset: 0x0092ED48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ContorlParameter(bool NewParam)
		{
			BP_LightningFire_C.__ContorlParameter_FunctionParams* ptr = stackalloc BP_LightningFire_C.__ContorlParameter_FunctionParams[(UIntPtr)263] + 15L / (long)sizeof(BP_LightningFire_C.__ContorlParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightningFire_C.__ContorlParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningFire_C.__ContorlParameter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023ED9 RID: 147161 RVA: 0x00930B91 File Offset: 0x0092ED91
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_InitialParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningFire_C.__Set_InitialParameter_NativeFunctionPtr, null);
		}

		// Token: 0x06023EDA RID: 147162 RVA: 0x00930BA5 File Offset: 0x0092EDA5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Tick_Parameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningFire_C.__Set_Tick_Parameter_NativeFunctionPtr, null);
		}

		// Token: 0x06023EDB RID: 147163 RVA: 0x00930BB9 File Offset: 0x0092EDB9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DebugPlayEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningFire_C.__DebugPlayEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06023EDC RID: 147164 RVA: 0x00930BCD File Offset: 0x0092EDCD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningFire_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023EDD RID: 147165 RVA: 0x00930BE1 File Offset: 0x0092EDE1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightningFire_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023EDE RID: 147166 RVA: 0x00930BF8 File Offset: 0x0092EDF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LightningFire_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightningFire_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightningFire_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightningFire_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningFire_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023EDF RID: 147167 RVA: 0x00930C40 File Offset: 0x0092EE40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LightningFire_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightningFire_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightningFire_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightningFire_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightningFire_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023EE0 RID: 147168 RVA: 0x00930C87 File Offset: 0x0092EE87
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningFire_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023EE1 RID: 147169 RVA: 0x00930C9B File Offset: 0x0092EE9B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightningFire_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023EE2 RID: 147170 RVA: 0x00930CB0 File Offset: 0x0092EEB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ResetCooldownEvent()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningFire_C.__ResetCooldownEvent_NativeFunctionPtr, null);
		}

		// Token: 0x06023EE3 RID: 147171 RVA: 0x00930CC4 File Offset: 0x0092EEC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_LightningFire_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_LightningFire_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_LightningFire_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightningFire_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningFire_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023EE4 RID: 147172 RVA: 0x00930D80 File Offset: 0x0092EF80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_LightningFire_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_LightningFire_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_LightningFire_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightningFire_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningFire_C.__BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023EE5 RID: 147173 RVA: 0x00930E0C File Offset: 0x0092F00C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_LightningFire_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LightningFire_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightningFire_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightningFire_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightningFire_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023EE6 RID: 147174 RVA: 0x00930E54 File Offset: 0x0092F054
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_LightningFire_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LightningFire_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightningFire_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightningFire_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightningFire_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023EE7 RID: 147175 RVA: 0x00930E9B File Offset: 0x0092F09B
		protected BP_LightningFire_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C3A RID: 72762
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/LightningFire/BP_LightningFire.BP_LightningFire_C";

		// Token: 0x04011C3B RID: 72763
		private static IntPtr _ClassPtr;

		// Token: 0x04011C3C RID: 72764
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011C3D RID: 72765
		internal static int __PropertyOffset_1;

		// Token: 0x04011C3E RID: 72766
		internal static int __PropertyOffset_2;

		// Token: 0x04011C3F RID: 72767
		internal static int __PropertyOffset_3;

		// Token: 0x04011C40 RID: 72768
		internal static int __PropertyOffset_4;

		// Token: 0x04011C41 RID: 72769
		internal static int __PropertyOffset_5;

		// Token: 0x04011C42 RID: 72770
		internal static int __PropertyOffset_6;

		// Token: 0x04011C43 RID: 72771
		internal static int __PropertyOffset_7;

		// Token: 0x04011C44 RID: 72772
		internal static int __PropertyOffset_8;

		// Token: 0x04011C45 RID: 72773
		internal static int __PropertyOffset_9;

		// Token: 0x04011C46 RID: 72774
		internal static int __PropertyOffset_10;

		// Token: 0x04011C47 RID: 72775
		internal static int __PropertyOffset_11;

		// Token: 0x04011C48 RID: 72776
		internal static int __PropertyOffset_12;

		// Token: 0x04011C49 RID: 72777
		internal static int __PropertyOffset_13;

		// Token: 0x04011C4A RID: 72778
		internal static int __PropertyOffset_14;

		// Token: 0x04011C4B RID: 72779
		internal static int __PropertyOffset_15;

		// Token: 0x04011C4C RID: 72780
		internal static int __PropertyOffset_16;

		// Token: 0x04011C4D RID: 72781
		internal static int __PropertyOffset_17;

		// Token: 0x04011C4E RID: 72782
		internal static int __PropertyOffset_18;

		// Token: 0x04011C4F RID: 72783
		internal static int __PropertyOffset_19;

		// Token: 0x04011C50 RID: 72784
		internal static int __PropertyOffset_20;

		// Token: 0x04011C51 RID: 72785
		internal static int __PropertyOffset_21;

		// Token: 0x04011C52 RID: 72786
		internal static int __PropertyOffset_22;

		// Token: 0x04011C53 RID: 72787
		internal static int __PropertyOffset_23;

		// Token: 0x04011C54 RID: 72788
		internal static int __PropertyOffset_24;

		// Token: 0x04011C55 RID: 72789
		internal static int __PropertyOffset_25;

		// Token: 0x04011C56 RID: 72790
		internal static int __PropertyOffset_26;

		// Token: 0x04011C57 RID: 72791
		internal static int __PropertyOffset_27;

		// Token: 0x04011C58 RID: 72792
		internal static int __PropertyOffset_28;

		// Token: 0x04011C59 RID: 72793
		internal static int __PropertyOffset_29;

		// Token: 0x04011C5A RID: 72794
		internal static int __PropertyOffset_30;

		// Token: 0x04011C5B RID: 72795
		internal static int __PropertyOffset_31;

		// Token: 0x04011C5C RID: 72796
		internal static int __PropertyOffset_32;

		// Token: 0x04011C5D RID: 72797
		internal static int __PropertyOffset_33;

		// Token: 0x04011C5E RID: 72798
		internal static int __PropertyOffset_34;

		// Token: 0x04011C5F RID: 72799
		internal static int __PropertyOffset_35;

		// Token: 0x04011C60 RID: 72800
		internal static int __PropertyOffset_36;

		// Token: 0x04011C61 RID: 72801
		internal static int __PropertyOffset_37;

		// Token: 0x04011C62 RID: 72802
		private static IntPtr __Set_ES3_NativeFunctionPtr;

		// Token: 0x04011C63 RID: 72803
		private static IntPtr __SetPostProcessVolume_NativeFunctionPtr;

		// Token: 0x04011C64 RID: 72804
		private static IntPtr __ContorlParameter_NativeFunctionPtr;

		// Token: 0x04011C65 RID: 72805
		private static IntPtr __Set_InitialParameter_NativeFunctionPtr;

		// Token: 0x04011C66 RID: 72806
		private static IntPtr __Set_Tick_Parameter_NativeFunctionPtr;

		// Token: 0x04011C67 RID: 72807
		private static IntPtr __DebugPlayEffect_NativeFunctionPtr;

		// Token: 0x04011C68 RID: 72808
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011C69 RID: 72809
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011C6A RID: 72810
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011C6B RID: 72811
		private static IntPtr __ResetCooldownEvent_NativeFunctionPtr;

		// Token: 0x04011C6C RID: 72812
		private static IntPtr __BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011C6D RID: 72813
		private static IntPtr __BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011C6E RID: 72814
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009EB3 RID: 40627
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 248)]
		protected ref struct __ContorlParameter_FunctionParams
		{
			// Token: 0x0403178C RID: 202636
			[FieldOffset(0)]
			public bool NewParam;
		}

		// Token: 0x02009EB4 RID: 40628
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403178D RID: 202637
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EB5 RID: 40629
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403178E RID: 202638
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403178F RID: 202639
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031790 RID: 202640
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031791 RID: 202641
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031792 RID: 202642
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031793 RID: 202643
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009EB6 RID: 40630
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_LightningFire_DetectionCollision_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031794 RID: 202644
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031795 RID: 202645
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031796 RID: 202646
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031797 RID: 202647
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009EB7 RID: 40631
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031798 RID: 202648
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
