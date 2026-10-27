using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.LeavesInteraction
{
	// Token: 0x02003CF8 RID: 15608
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_LeavesInteraction_SDF.BP_LeavesInteraction_SDF_C")]
	[UnrealStructLayout(1720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1718)]
	public class BP_LeavesInteraction_SDF_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060253D9 RID: 152537 RVA: 0x00954DB0 File Offset: 0x00952FB0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LeavesInteraction_SDF_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_LeavesInteraction_SDF.BP_LeavesInteraction_SDF_C");
			}
			return BP_LeavesInteraction_SDF_C._ClassPtr;
		}

		// Token: 0x060253DA RID: 152538 RVA: 0x00954DD4 File Offset: 0x00952FD4
		public BP_LeavesInteraction_SDF_C() : this(BuiltinUtils.AllocNativeUObject(BP_LeavesInteraction_SDF_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060253DB RID: 152539 RVA: 0x00954DFC File Offset: 0x00952FFC
		[NullableContext(1)]
		public BP_LeavesInteraction_SDF_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LeavesInteraction_SDF_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B91 RID: 19345
		// (get) Token: 0x060253DC RID: 152540 RVA: 0x00954E2F File Offset: 0x0095302F
		// (set) Token: 0x060253DD RID: 152541 RVA: 0x00954E43 File Offset: 0x00953043
		public unsafe UBoxComponent AreaBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004B92 RID: 19346
		// (get) Token: 0x060253DE RID: 152542 RVA: 0x00954E58 File Offset: 0x00953058
		// (set) Token: 0x060253DF RID: 152543 RVA: 0x00954E6C File Offset: 0x0095306C
		public unsafe UNiagaraComponent NS_FX_LeavesInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004B93 RID: 19347
		// (get) Token: 0x060253E0 RID: 152544 RVA: 0x00954E81 File Offset: 0x00953081
		// (set) Token: 0x060253E1 RID: 152545 RVA: 0x00954E95 File Offset: 0x00953095
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004B94 RID: 19348
		// (get) Token: 0x060253E2 RID: 152546 RVA: 0x00954EAA File Offset: 0x009530AA
		// (set) Token: 0x060253E3 RID: 152547 RVA: 0x00954EBE File Offset: 0x009530BE
		public unsafe FVector FieldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004B95 RID: 19349
		// (get) Token: 0x060253E4 RID: 152548 RVA: 0x00954ED3 File Offset: 0x009530D3
		// (set) Token: 0x060253E5 RID: 152549 RVA: 0x00954EE3 File Offset: 0x009530E3
		public unsafe int Resolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004B96 RID: 19350
		// (get) Token: 0x060253E6 RID: 152550 RVA: 0x00954EF4 File Offset: 0x009530F4
		// (set) Token: 0x060253E7 RID: 152551 RVA: 0x00954F08 File Offset: 0x00953108
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004B97 RID: 19351
		// (get) Token: 0x060253E8 RID: 152552 RVA: 0x00954F1D File Offset: 0x0095311D
		// (set) Token: 0x060253E9 RID: 152553 RVA: 0x00954F31 File Offset: 0x00953131
		public unsafe USkeletalMeshComponent Weapon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004B98 RID: 19352
		// (get) Token: 0x060253EA RID: 152554 RVA: 0x00954F46 File Offset: 0x00953146
		// (set) Token: 0x060253EB RID: 152555 RVA: 0x00954F5A File Offset: 0x0095315A
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004B99 RID: 19353
		// (get) Token: 0x060253EC RID: 152556 RVA: 0x00954F6F File Offset: 0x0095316F
		// (set) Token: 0x060253ED RID: 152557 RVA: 0x00954F83 File Offset: 0x00953183
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004B9A RID: 19354
		// (get) Token: 0x060253EE RID: 152558 RVA: 0x00954F98 File Offset: 0x00953198
		// (set) Token: 0x060253EF RID: 152559 RVA: 0x00954FAC File Offset: 0x009531AC
		public unsafe FVector WeaponVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004B9B RID: 19355
		// (get) Token: 0x060253F0 RID: 152560 RVA: 0x00954FC1 File Offset: 0x009531C1
		// (set) Token: 0x060253F1 RID: 152561 RVA: 0x00954FD5 File Offset: 0x009531D5
		public unsafe UMaterialParameterCollection Global_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004B9C RID: 19356
		// (get) Token: 0x060253F2 RID: 152562 RVA: 0x00954FEA File Offset: 0x009531EA
		// (set) Token: 0x060253F3 RID: 152563 RVA: 0x00954FFA File Offset: 0x009531FA
		public unsafe bool isClear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B9D RID: 19357
		// (get) Token: 0x060253F4 RID: 152564 RVA: 0x0095500B File Offset: 0x0095320B
		// (set) Token: 0x060253F5 RID: 152565 RVA: 0x0095501F File Offset: 0x0095321F
		public unsafe FLinearColor GlobalWorldPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004B9E RID: 19358
		// (get) Token: 0x060253F6 RID: 152566 RVA: 0x00955034 File Offset: 0x00953234
		// (set) Token: 0x060253F7 RID: 152567 RVA: 0x00955044 File Offset: 0x00953244
		public unsafe float PlayerSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004B9F RID: 19359
		// (get) Token: 0x060253F8 RID: 152568 RVA: 0x00955055 File Offset: 0x00953255
		// (set) Token: 0x060253F9 RID: 152569 RVA: 0x00955065 File Offset: 0x00953265
		public unsafe float WeaponSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004BA0 RID: 19360
		// (get) Token: 0x060253FA RID: 152570 RVA: 0x00955076 File Offset: 0x00953276
		// (set) Token: 0x060253FB RID: 152571 RVA: 0x0095508A File Offset: 0x0095328A
		public unsafe FVector DepthCapturePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004BA1 RID: 19361
		// (get) Token: 0x060253FC RID: 152572 RVA: 0x0095509F File Offset: 0x0095329F
		// (set) Token: 0x060253FD RID: 152573 RVA: 0x009550B3 File Offset: 0x009532B3
		public unsafe UTexture DepthTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17004BA2 RID: 19362
		// (get) Token: 0x060253FE RID: 152574 RVA: 0x009550C8 File Offset: 0x009532C8
		// (set) Token: 0x060253FF RID: 152575 RVA: 0x009550D8 File Offset: 0x009532D8
		public unsafe int LeavesIDStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004BA3 RID: 19363
		// (get) Token: 0x06025400 RID: 152576 RVA: 0x009550E9 File Offset: 0x009532E9
		// (set) Token: 0x06025401 RID: 152577 RVA: 0x009550F9 File Offset: 0x009532F9
		public unsafe int LeavesIDEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004BA4 RID: 19364
		// (get) Token: 0x06025402 RID: 152578 RVA: 0x0095510A File Offset: 0x0095330A
		// (set) Token: 0x06025403 RID: 152579 RVA: 0x0095511A File Offset: 0x0095331A
		public unsafe int LeavesNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004BA5 RID: 19365
		// (get) Token: 0x06025404 RID: 152580 RVA: 0x0095512B File Offset: 0x0095332B
		// (set) Token: 0x06025405 RID: 152581 RVA: 0x0095513B File Offset: 0x0095333B
		public unsafe float BoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004BA6 RID: 19366
		// (get) Token: 0x06025406 RID: 152582 RVA: 0x0095514C File Offset: 0x0095334C
		// (set) Token: 0x06025407 RID: 152583 RVA: 0x0095515C File Offset: 0x0095335C
		public unsafe float LeavesScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004BA7 RID: 19367
		// (get) Token: 0x06025408 RID: 152584 RVA: 0x0095516D File Offset: 0x0095336D
		// (set) Token: 0x06025409 RID: 152585 RVA: 0x0095517D File Offset: 0x0095337D
		public unsafe int LUTIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004BA8 RID: 19368
		// (get) Token: 0x0602540A RID: 152586 RVA: 0x0095518E File Offset: 0x0095338E
		// (set) Token: 0x0602540B RID: 152587 RVA: 0x0095519E File Offset: 0x0095339E
		public unsafe float LeavesRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004BA9 RID: 19369
		// (get) Token: 0x0602540C RID: 152588 RVA: 0x009551AF File Offset: 0x009533AF
		// (set) Token: 0x0602540D RID: 152589 RVA: 0x009551BF File Offset: 0x009533BF
		public unsafe float LeavesAO
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004BAA RID: 19370
		// (get) Token: 0x0602540E RID: 152590 RVA: 0x009551D0 File Offset: 0x009533D0
		// (set) Token: 0x0602540F RID: 152591 RVA: 0x009551E0 File Offset: 0x009533E0
		public unsafe float LutProbabilityPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004BAB RID: 19371
		// (get) Token: 0x06025410 RID: 152592 RVA: 0x009551F1 File Offset: 0x009533F1
		// (set) Token: 0x06025411 RID: 152593 RVA: 0x00955205 File Offset: 0x00953405
		public unsafe UTexture LeavesMaskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17004BAC RID: 19372
		// (get) Token: 0x06025412 RID: 152594 RVA: 0x0095521A File Offset: 0x0095341A
		// (set) Token: 0x06025413 RID: 152595 RVA: 0x0095522A File Offset: 0x0095342A
		public unsafe bool UseLUT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BAD RID: 19373
		// (get) Token: 0x06025414 RID: 152596 RVA: 0x0095523B File Offset: 0x0095343B
		// (set) Token: 0x06025415 RID: 152597 RVA: 0x0095524B File Offset: 0x0095344B
		public unsafe float OffsetDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004BAE RID: 19374
		// (get) Token: 0x06025416 RID: 152598 RVA: 0x0095525C File Offset: 0x0095345C
		// (set) Token: 0x06025417 RID: 152599 RVA: 0x00955270 File Offset: 0x00953470
		public unsafe FVector BPPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17004BAF RID: 19375
		// (get) Token: 0x06025418 RID: 152600 RVA: 0x00955285 File Offset: 0x00953485
		// (set) Token: 0x06025419 RID: 152601 RVA: 0x00955295 File Offset: 0x00953495
		public unsafe float CullingHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17004BB0 RID: 19376
		// (get) Token: 0x0602541A RID: 152602 RVA: 0x009552A6 File Offset: 0x009534A6
		// (set) Token: 0x0602541B RID: 152603 RVA: 0x009552BA File Offset: 0x009534BA
		public unsafe FVector RuntimeDepthCapturePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17004BB1 RID: 19377
		// (get) Token: 0x0602541C RID: 152604 RVA: 0x009552CF File Offset: 0x009534CF
		// (set) Token: 0x0602541D RID: 152605 RVA: 0x009552E3 File Offset: 0x009534E3
		public unsafe UTexture RuntimeDepthTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesInteraction_SDF_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17004BB2 RID: 19378
		// (get) Token: 0x0602541E RID: 152606 RVA: 0x009552F8 File Offset: 0x009534F8
		// (set) Token: 0x0602541F RID: 152607 RVA: 0x0095530C File Offset: 0x0095350C
		public unsafe FVector RuntimeDepthCaptureBoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17004BB3 RID: 19379
		// (get) Token: 0x06025420 RID: 152608 RVA: 0x00955321 File Offset: 0x00953521
		// (set) Token: 0x06025421 RID: 152609 RVA: 0x00955331 File Offset: 0x00953531
		public unsafe bool UseRuntimeCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BB4 RID: 19380
		// (get) Token: 0x06025422 RID: 152610 RVA: 0x00955342 File Offset: 0x00953542
		// (set) Token: 0x06025423 RID: 152611 RVA: 0x00955352 File Offset: 0x00953552
		public unsafe bool bHideInLowQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesInteraction_SDF_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x06025424 RID: 152612 RVA: 0x00955363 File Offset: 0x00953563
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetLeavesParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__SetLeavesParameters_NativeFunctionPtr, null);
		}

		// Token: 0x06025425 RID: 152613 RVA: 0x00955377 File Offset: 0x00953577
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__Debug_NativeFunctionPtr, null);
		}

		// Token: 0x06025426 RID: 152614 RVA: 0x0095538C File Offset: 0x0095358C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Choose_Available_Point(FVectorDouble CollisionPoint, FVectorDouble WeaponPoint, BP_SceneBattleInteract_C ConfigDA, ref FVectorDouble AvailblePoint)
		{
			BP_LeavesInteraction_SDF_C.__Choose_Available_Point_FunctionParams* ptr = stackalloc BP_LeavesInteraction_SDF_C.__Choose_Available_Point_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_LeavesInteraction_SDF_C.__Choose_Available_Point_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesInteraction_SDF_C.__Choose_Available_Point_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CollisionPoint = CollisionPoint;
			ptr->WeaponPoint = WeaponPoint;
			ptr->ConfigDA = ((ConfigDA != null) ? ConfigDA.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__Choose_Available_Point_NativeFunctionPtr, (void*)ptr);
			AvailblePoint = ptr->AvailblePoint;
		}

		// Token: 0x06025427 RID: 152615 RVA: 0x00955409 File Offset: 0x00953609
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void WeaponData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__WeaponData_NativeFunctionPtr, null);
		}

		// Token: 0x06025428 RID: 152616 RVA: 0x00955420 File Offset: 0x00953620
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateParam(float dt)
		{
			BP_LeavesInteraction_SDF_C.__UpdateParam_FunctionParams* ptr = stackalloc BP_LeavesInteraction_SDF_C.__UpdateParam_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_LeavesInteraction_SDF_C.__UpdateParam_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesInteraction_SDF_C.__UpdateParam_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__UpdateParam_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025429 RID: 152617 RVA: 0x00955466 File Offset: 0x00953666
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__InitParam_NativeFunctionPtr, null);
		}

		// Token: 0x0602542A RID: 152618 RVA: 0x0095547A File Offset: 0x0095367A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602542B RID: 152619 RVA: 0x0095548E File Offset: 0x0095368E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602542C RID: 152620 RVA: 0x009554A4 File Offset: 0x009536A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LeavesInteraction_SDF_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LeavesInteraction_SDF_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LeavesInteraction_SDF_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesInteraction_SDF_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602542D RID: 152621 RVA: 0x009554EC File Offset: 0x009536EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LeavesInteraction_SDF_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LeavesInteraction_SDF_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LeavesInteraction_SDF_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesInteraction_SDF_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602542E RID: 152622 RVA: 0x00955533 File Offset: 0x00953733
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602542F RID: 152623 RVA: 0x00955547 File Offset: 0x00953747
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025430 RID: 152624 RVA: 0x0095555C File Offset: 0x0095375C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_LeavesInteraction_SDF_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_LeavesInteraction_SDF_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_LeavesInteraction_SDF_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesInteraction_SDF_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025431 RID: 152625 RVA: 0x009555BF File Offset: 0x009537BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_SDF_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x06025432 RID: 152626 RVA: 0x009555D3 File Offset: 0x009537D3
		protected BP_LeavesInteraction_SDF_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040128FB RID: 76027
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_LeavesInteraction_SDF.BP_LeavesInteraction_SDF_C";

		// Token: 0x040128FC RID: 76028
		private static IntPtr _ClassPtr;

		// Token: 0x040128FD RID: 76029
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040128FE RID: 76030
		internal static int __PropertyOffset_1;

		// Token: 0x040128FF RID: 76031
		internal static int __PropertyOffset_2;

		// Token: 0x04012900 RID: 76032
		internal static int __PropertyOffset_3;

		// Token: 0x04012901 RID: 76033
		internal static int __PropertyOffset_4;

		// Token: 0x04012902 RID: 76034
		internal static int __PropertyOffset_5;

		// Token: 0x04012903 RID: 76035
		internal static int __PropertyOffset_6;

		// Token: 0x04012904 RID: 76036
		internal static int __PropertyOffset_7;

		// Token: 0x04012905 RID: 76037
		internal static int __PropertyOffset_8;

		// Token: 0x04012906 RID: 76038
		internal static int __PropertyOffset_9;

		// Token: 0x04012907 RID: 76039
		internal static int __PropertyOffset_10;

		// Token: 0x04012908 RID: 76040
		internal static int __PropertyOffset_11;

		// Token: 0x04012909 RID: 76041
		internal static int __PropertyOffset_12;

		// Token: 0x0401290A RID: 76042
		internal static int __PropertyOffset_13;

		// Token: 0x0401290B RID: 76043
		internal static int __PropertyOffset_14;

		// Token: 0x0401290C RID: 76044
		internal static int __PropertyOffset_15;

		// Token: 0x0401290D RID: 76045
		internal static int __PropertyOffset_16;

		// Token: 0x0401290E RID: 76046
		internal static int __PropertyOffset_17;

		// Token: 0x0401290F RID: 76047
		internal static int __PropertyOffset_18;

		// Token: 0x04012910 RID: 76048
		internal static int __PropertyOffset_19;

		// Token: 0x04012911 RID: 76049
		internal static int __PropertyOffset_20;

		// Token: 0x04012912 RID: 76050
		internal static int __PropertyOffset_21;

		// Token: 0x04012913 RID: 76051
		internal static int __PropertyOffset_22;

		// Token: 0x04012914 RID: 76052
		internal static int __PropertyOffset_23;

		// Token: 0x04012915 RID: 76053
		internal static int __PropertyOffset_24;

		// Token: 0x04012916 RID: 76054
		internal static int __PropertyOffset_25;

		// Token: 0x04012917 RID: 76055
		internal static int __PropertyOffset_26;

		// Token: 0x04012918 RID: 76056
		internal static int __PropertyOffset_27;

		// Token: 0x04012919 RID: 76057
		internal static int __PropertyOffset_28;

		// Token: 0x0401291A RID: 76058
		internal static int __PropertyOffset_29;

		// Token: 0x0401291B RID: 76059
		internal static int __PropertyOffset_30;

		// Token: 0x0401291C RID: 76060
		internal static int __PropertyOffset_31;

		// Token: 0x0401291D RID: 76061
		internal static int __PropertyOffset_32;

		// Token: 0x0401291E RID: 76062
		internal static int __PropertyOffset_33;

		// Token: 0x0401291F RID: 76063
		internal static int __PropertyOffset_34;

		// Token: 0x04012920 RID: 76064
		internal static int __PropertyOffset_35;

		// Token: 0x04012921 RID: 76065
		internal static int __PropertyOffset_36;

		// Token: 0x04012922 RID: 76066
		private static IntPtr __SetLeavesParameters_NativeFunctionPtr;

		// Token: 0x04012923 RID: 76067
		private static IntPtr __Debug_NativeFunctionPtr;

		// Token: 0x04012924 RID: 76068
		private static IntPtr __Choose_Available_Point_NativeFunctionPtr;

		// Token: 0x04012925 RID: 76069
		private static IntPtr __WeaponData_NativeFunctionPtr;

		// Token: 0x04012926 RID: 76070
		private static IntPtr __UpdateParam_NativeFunctionPtr;

		// Token: 0x04012927 RID: 76071
		private static IntPtr __InitParam_NativeFunctionPtr;

		// Token: 0x04012928 RID: 76072
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012929 RID: 76073
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401292A RID: 76074
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401292B RID: 76075
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x0401292C RID: 76076
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;

		// Token: 0x02009FD4 RID: 40916
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Choose_Available_Point_FunctionParams
		{
			// Token: 0x04031A51 RID: 203345
			[FieldOffset(0)]
			public FVectorDouble CollisionPoint;

			// Token: 0x04031A52 RID: 203346
			[FieldOffset(24)]
			public FVectorDouble WeaponPoint;

			// Token: 0x04031A53 RID: 203347
			[FieldOffset(48)]
			public IntPtr ConfigDA;

			// Token: 0x04031A54 RID: 203348
			[FieldOffset(56)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02009FD5 RID: 40917
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __UpdateParam_FunctionParams
		{
			// Token: 0x04031A55 RID: 203349
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x02009FD6 RID: 40918
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A56 RID: 203350
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FD7 RID: 40919
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031A57 RID: 203351
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031A58 RID: 203352
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031A59 RID: 203353
			[FieldOffset(32)]
			public int Id;
		}
	}
}
