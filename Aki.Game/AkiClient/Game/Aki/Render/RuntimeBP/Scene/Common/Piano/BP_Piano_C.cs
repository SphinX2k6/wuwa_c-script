using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.Piano
{
	// Token: 0x02003B69 RID: 15209
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_Piano.BP_Piano_C")]
	[UnrealStructLayout(1976, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1976)]
	public class BP_Piano_C : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021D09 RID: 138505 RVA: 0x008F67D8 File Offset: 0x008F49D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Piano_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_Piano.BP_Piano_C");
			}
			return BP_Piano_C._ClassPtr;
		}

		// Token: 0x06021D0A RID: 138506 RVA: 0x008F67FC File Offset: 0x008F49FC
		public BP_Piano_C() : this(BuiltinUtils.AllocNativeUObject(BP_Piano_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021D0B RID: 138507 RVA: 0x008F6824 File Offset: 0x008F4A24
		[NullableContext(1)]
		public BP_Piano_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Piano_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x06021D0C RID: 138508 RVA: 0x008F6857 File Offset: 0x008F4A57
		// (set) Token: 0x06021D0D RID: 138509 RVA: 0x008F686B File Offset: 0x008F4A6B
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x06021D0E RID: 138510 RVA: 0x008F6880 File Offset: 0x008F4A80
		// (set) Token: 0x06021D0F RID: 138511 RVA: 0x008F6894 File Offset: 0x008F4A94
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x06021D10 RID: 138512 RVA: 0x008F68A9 File Offset: 0x008F4AA9
		// (set) Token: 0x06021D11 RID: 138513 RVA: 0x008F68BD File Offset: 0x008F4ABD
		public unsafe UChildActorComponent Note_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x06021D12 RID: 138514 RVA: 0x008F68D2 File Offset: 0x008F4AD2
		// (set) Token: 0x06021D13 RID: 138515 RVA: 0x008F68E6 File Offset: 0x008F4AE6
		public unsafe UChildActorComponent Note_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x06021D14 RID: 138516 RVA: 0x008F68FB File Offset: 0x008F4AFB
		// (set) Token: 0x06021D15 RID: 138517 RVA: 0x008F690F File Offset: 0x008F4B0F
		public unsafe UChildActorComponent Note_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x06021D16 RID: 138518 RVA: 0x008F6924 File Offset: 0x008F4B24
		// (set) Token: 0x06021D17 RID: 138519 RVA: 0x008F6938 File Offset: 0x008F4B38
		public unsafe UChildActorComponent Key_C4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x06021D18 RID: 138520 RVA: 0x008F694D File Offset: 0x008F4B4D
		// (set) Token: 0x06021D19 RID: 138521 RVA: 0x008F6961 File Offset: 0x008F4B61
		public unsafe USceneComponent Group3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x06021D1A RID: 138522 RVA: 0x008F6976 File Offset: 0x008F4B76
		// (set) Token: 0x06021D1B RID: 138523 RVA: 0x008F698A File Offset: 0x008F4B8A
		public unsafe USceneComponent Group2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x06021D1C RID: 138524 RVA: 0x008F699F File Offset: 0x008F4B9F
		// (set) Token: 0x06021D1D RID: 138525 RVA: 0x008F69B3 File Offset: 0x008F4BB3
		public unsafe USceneComponent Group1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x06021D1E RID: 138526 RVA: 0x008F69C8 File Offset: 0x008F4BC8
		// (set) Token: 0x06021D1F RID: 138527 RVA: 0x008F69DC File Offset: 0x008F4BDC
		public unsafe UChildActorComponent Key_ASharp2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x06021D20 RID: 138528 RVA: 0x008F69F1 File Offset: 0x008F4BF1
		// (set) Token: 0x06021D21 RID: 138529 RVA: 0x008F6A05 File Offset: 0x008F4C05
		public unsafe UChildActorComponent Key_A3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x06021D22 RID: 138530 RVA: 0x008F6A1A File Offset: 0x008F4C1A
		// (set) Token: 0x06021D23 RID: 138531 RVA: 0x008F6A2E File Offset: 0x008F4C2E
		public unsafe UChildActorComponent Key_GSharp2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x06021D24 RID: 138532 RVA: 0x008F6A43 File Offset: 0x008F4C43
		// (set) Token: 0x06021D25 RID: 138533 RVA: 0x008F6A57 File Offset: 0x008F4C57
		public unsafe UChildActorComponent Key_G3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x06021D26 RID: 138534 RVA: 0x008F6A6C File Offset: 0x008F4C6C
		// (set) Token: 0x06021D27 RID: 138535 RVA: 0x008F6A80 File Offset: 0x008F4C80
		public unsafe UChildActorComponent Key_FSharp2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x06021D28 RID: 138536 RVA: 0x008F6A95 File Offset: 0x008F4C95
		// (set) Token: 0x06021D29 RID: 138537 RVA: 0x008F6AA9 File Offset: 0x008F4CA9
		public unsafe UChildActorComponent Key_F3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x06021D2A RID: 138538 RVA: 0x008F6ABE File Offset: 0x008F4CBE
		// (set) Token: 0x06021D2B RID: 138539 RVA: 0x008F6AD2 File Offset: 0x008F4CD2
		public unsafe UChildActorComponent Key_E3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x06021D2C RID: 138540 RVA: 0x008F6AE7 File Offset: 0x008F4CE7
		// (set) Token: 0x06021D2D RID: 138541 RVA: 0x008F6AFB File Offset: 0x008F4CFB
		public unsafe UChildActorComponent Key_DSharp2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x06021D2E RID: 138542 RVA: 0x008F6B10 File Offset: 0x008F4D10
		// (set) Token: 0x06021D2F RID: 138543 RVA: 0x008F6B24 File Offset: 0x008F4D24
		public unsafe UChildActorComponent Key_D3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x06021D30 RID: 138544 RVA: 0x008F6B39 File Offset: 0x008F4D39
		// (set) Token: 0x06021D31 RID: 138545 RVA: 0x008F6B4D File Offset: 0x008F4D4D
		public unsafe UChildActorComponent Key_CSharp2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x06021D32 RID: 138546 RVA: 0x008F6B62 File Offset: 0x008F4D62
		// (set) Token: 0x06021D33 RID: 138547 RVA: 0x008F6B76 File Offset: 0x008F4D76
		public unsafe UChildActorComponent Key_B3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x06021D34 RID: 138548 RVA: 0x008F6B8B File Offset: 0x008F4D8B
		// (set) Token: 0x06021D35 RID: 138549 RVA: 0x008F6B9F File Offset: 0x008F4D9F
		public unsafe UChildActorComponent Key_C3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x06021D36 RID: 138550 RVA: 0x008F6BB4 File Offset: 0x008F4DB4
		// (set) Token: 0x06021D37 RID: 138551 RVA: 0x008F6BC8 File Offset: 0x008F4DC8
		public unsafe UChildActorComponent Key_ASharp1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x06021D38 RID: 138552 RVA: 0x008F6BDD File Offset: 0x008F4DDD
		// (set) Token: 0x06021D39 RID: 138553 RVA: 0x008F6BF1 File Offset: 0x008F4DF1
		public unsafe UChildActorComponent Key_A2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x06021D3A RID: 138554 RVA: 0x008F6C06 File Offset: 0x008F4E06
		// (set) Token: 0x06021D3B RID: 138555 RVA: 0x008F6C1A File Offset: 0x008F4E1A
		public unsafe UChildActorComponent Key_GSharp1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x06021D3C RID: 138556 RVA: 0x008F6C2F File Offset: 0x008F4E2F
		// (set) Token: 0x06021D3D RID: 138557 RVA: 0x008F6C43 File Offset: 0x008F4E43
		public unsafe UChildActorComponent Key_CSharp1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x06021D3E RID: 138558 RVA: 0x008F6C58 File Offset: 0x008F4E58
		// (set) Token: 0x06021D3F RID: 138559 RVA: 0x008F6C6C File Offset: 0x008F4E6C
		public unsafe UChildActorComponent Key_FSharp1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x06021D40 RID: 138560 RVA: 0x008F6C81 File Offset: 0x008F4E81
		// (set) Token: 0x06021D41 RID: 138561 RVA: 0x008F6C95 File Offset: 0x008F4E95
		public unsafe UChildActorComponent Key_B2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x06021D42 RID: 138562 RVA: 0x008F6CAA File Offset: 0x008F4EAA
		// (set) Token: 0x06021D43 RID: 138563 RVA: 0x008F6CBE File Offset: 0x008F4EBE
		public unsafe UChildActorComponent Key_E2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x06021D44 RID: 138564 RVA: 0x008F6CD3 File Offset: 0x008F4ED3
		// (set) Token: 0x06021D45 RID: 138565 RVA: 0x008F6CE7 File Offset: 0x008F4EE7
		public unsafe UChildActorComponent Key_DSharp1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x06021D46 RID: 138566 RVA: 0x008F6CFC File Offset: 0x008F4EFC
		// (set) Token: 0x06021D47 RID: 138567 RVA: 0x008F6D10 File Offset: 0x008F4F10
		public unsafe UChildActorComponent Key_D2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x06021D48 RID: 138568 RVA: 0x008F6D25 File Offset: 0x008F4F25
		// (set) Token: 0x06021D49 RID: 138569 RVA: 0x008F6D39 File Offset: 0x008F4F39
		public unsafe UChildActorComponent Key_G2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x06021D4A RID: 138570 RVA: 0x008F6D4E File Offset: 0x008F4F4E
		// (set) Token: 0x06021D4B RID: 138571 RVA: 0x008F6D62 File Offset: 0x008F4F62
		public unsafe UChildActorComponent Key_C2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x06021D4C RID: 138572 RVA: 0x008F6D77 File Offset: 0x008F4F77
		// (set) Token: 0x06021D4D RID: 138573 RVA: 0x008F6D8B File Offset: 0x008F4F8B
		public unsafe UChildActorComponent Key_F2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x06021D4E RID: 138574 RVA: 0x008F6DA0 File Offset: 0x008F4FA0
		// (set) Token: 0x06021D4F RID: 138575 RVA: 0x008F6DB4 File Offset: 0x008F4FB4
		public unsafe UChildActorComponent Key_B1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x06021D50 RID: 138576 RVA: 0x008F6DC9 File Offset: 0x008F4FC9
		// (set) Token: 0x06021D51 RID: 138577 RVA: 0x008F6DDD File Offset: 0x008F4FDD
		public unsafe UChildActorComponent Key_ASharp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x06021D52 RID: 138578 RVA: 0x008F6DF2 File Offset: 0x008F4FF2
		// (set) Token: 0x06021D53 RID: 138579 RVA: 0x008F6E06 File Offset: 0x008F5006
		public unsafe UChildActorComponent Key_A1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x06021D54 RID: 138580 RVA: 0x008F6E1B File Offset: 0x008F501B
		// (set) Token: 0x06021D55 RID: 138581 RVA: 0x008F6E2F File Offset: 0x008F502F
		public unsafe UChildActorComponent Key_GSharp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x06021D56 RID: 138582 RVA: 0x008F6E44 File Offset: 0x008F5044
		// (set) Token: 0x06021D57 RID: 138583 RVA: 0x008F6E58 File Offset: 0x008F5058
		public unsafe UChildActorComponent Key_G1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x06021D58 RID: 138584 RVA: 0x008F6E6D File Offset: 0x008F506D
		// (set) Token: 0x06021D59 RID: 138585 RVA: 0x008F6E81 File Offset: 0x008F5081
		public unsafe UChildActorComponent Key_C1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x06021D5A RID: 138586 RVA: 0x008F6E96 File Offset: 0x008F5096
		// (set) Token: 0x06021D5B RID: 138587 RVA: 0x008F6EAA File Offset: 0x008F50AA
		public unsafe UChildActorComponent Key_F1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_40);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_40, value);
			}
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x06021D5C RID: 138588 RVA: 0x008F6EBF File Offset: 0x008F50BF
		// (set) Token: 0x06021D5D RID: 138589 RVA: 0x008F6ED3 File Offset: 0x008F50D3
		public unsafe UChildActorComponent Key_E1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_41);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_41, value);
			}
		}

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x06021D5E RID: 138590 RVA: 0x008F6EE8 File Offset: 0x008F50E8
		// (set) Token: 0x06021D5F RID: 138591 RVA: 0x008F6EFC File Offset: 0x008F50FC
		public unsafe UChildActorComponent Key_DSharp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_42);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_42, value);
			}
		}

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x06021D60 RID: 138592 RVA: 0x008F6F11 File Offset: 0x008F5111
		// (set) Token: 0x06021D61 RID: 138593 RVA: 0x008F6F25 File Offset: 0x008F5125
		public unsafe UChildActorComponent Key_D1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_43);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_43, value);
			}
		}

		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x06021D62 RID: 138594 RVA: 0x008F6F3A File Offset: 0x008F513A
		// (set) Token: 0x06021D63 RID: 138595 RVA: 0x008F6F4E File Offset: 0x008F514E
		public unsafe UChildActorComponent Key_CSharp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_44);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_44, value);
			}
		}

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x06021D64 RID: 138596 RVA: 0x008F6F63 File Offset: 0x008F5163
		// (set) Token: 0x06021D65 RID: 138597 RVA: 0x008F6F77 File Offset: 0x008F5177
		public unsafe UChildActorComponent Key_FSharp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x06021D66 RID: 138598 RVA: 0x008F6F8C File Offset: 0x008F518C
		// (set) Token: 0x06021D67 RID: 138599 RVA: 0x008F6FA0 File Offset: 0x008F51A0
		public unsafe USceneComponent Note
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x06021D68 RID: 138600 RVA: 0x008F6FB5 File Offset: 0x008F51B5
		// (set) Token: 0x06021D69 RID: 138601 RVA: 0x008F6FC9 File Offset: 0x008F51C9
		public unsafe USceneComponent Key
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x06021D6A RID: 138602 RVA: 0x008F6FE0 File Offset: 0x008F51E0
		// (set) Token: 0x06021D6B RID: 138603 RVA: 0x008F7019 File Offset: 0x008F5219
		[Nullable(1)]
		public TArray<BP_PianoKey_C> BPKeyArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<BP_PianoKey_C> result;
				if ((result = this._BPKeyArray) == null)
				{
					result = (this._BPKeyArray = new TArray<BP_PianoKey_C>(base.NativePtr + (IntPtr)BP_Piano_C.__PropertyOffset_48, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BPKeyArray.CopyAssign(value);
			}
		}

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x06021D6C RID: 138604 RVA: 0x008F7028 File Offset: 0x008F5228
		// (set) Token: 0x06021D6D RID: 138605 RVA: 0x008F7061 File Offset: 0x008F5261
		[Nullable(1)]
		public MoveNote MoveNote
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				MoveNote result;
				if ((result = this._MoveNote) == null)
				{
					result = (this._MoveNote = new MoveNote(base.NativePtr + (IntPtr)BP_Piano_C.__PropertyOffset_49, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_Piano_C.__PropertyOffset_49, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x06021D6E RID: 138606 RVA: 0x008F7084 File Offset: 0x008F5284
		// (set) Token: 0x06021D6F RID: 138607 RVA: 0x008F70BD File Offset: 0x008F52BD
		[Nullable(1)]
		public TArray<BP_PianoNote_C> BPNoteArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<BP_PianoNote_C> result;
				if ((result = this._BPNoteArray) == null)
				{
					result = (this._BPNoteArray = new TArray<BP_PianoNote_C>(base.NativePtr + (IntPtr)BP_Piano_C.__PropertyOffset_50, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BPNoteArray.CopyAssign(value);
			}
		}

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x06021D70 RID: 138608 RVA: 0x008F70CC File Offset: 0x008F52CC
		// (set) Token: 0x06021D71 RID: 138609 RVA: 0x008F7105 File Offset: 0x008F5305
		[Nullable(1)]
		public TSet<BP_PianoNote_C> TriggeredNoteSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<BP_PianoNote_C> result;
				if ((result = this._TriggeredNoteSet) == null)
				{
					result = (this._TriggeredNoteSet = new TSet<BP_PianoNote_C>(base.NativePtr + (IntPtr)BP_Piano_C.__PropertyOffset_51, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TriggeredNoteSet.CopyAssign(value);
			}
		}

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x06021D72 RID: 138610 RVA: 0x008F7113 File Offset: 0x008F5313
		// (set) Token: 0x06021D73 RID: 138611 RVA: 0x008F7127 File Offset: 0x008F5327
		public unsafe UAkAudioEvent WwiseEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_52);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_52, value);
			}
		}

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x06021D74 RID: 138612 RVA: 0x008F713C File Offset: 0x008F533C
		// (set) Token: 0x06021D75 RID: 138613 RVA: 0x008F714C File Offset: 0x008F534C
		public unsafe byte MIDIStartIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Piano_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Piano_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x06021D76 RID: 138614 RVA: 0x008F715D File Offset: 0x008F535D
		// (set) Token: 0x06021D77 RID: 138615 RVA: 0x008F7171 File Offset: 0x008F5371
		public unsafe ULevelSequence Sequence
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_54);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_54, value);
			}
		}

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x06021D78 RID: 138616 RVA: 0x008F7186 File Offset: 0x008F5386
		// (set) Token: 0x06021D79 RID: 138617 RVA: 0x008F719A File Offset: 0x008F539A
		public unsafe ULevelSequencePlayer SequencePlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequencePlayer>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_55);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Piano_C.__PropertyOffset_55, value);
			}
		}

		// Token: 0x06021D7A RID: 138618 RVA: 0x008F71B0 File Offset: 0x008F53B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InitSequence(ref ALevelSequenceActor LevelSequenceActor)
		{
			BP_Piano_C.__InitSequence_FunctionParams* ptr = stackalloc BP_Piano_C.__InitSequence_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_Piano_C.__InitSequence_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Piano_C.__InitSequence_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_Piano_C.__InitSequence_FunctionParams ptr2 = ref *ptr;
			ALevelSequenceActor alevelSequenceActor = LevelSequenceActor;
			ptr2.LevelSequenceActor = ((alevelSequenceActor != null) ? alevelSequenceActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Piano_C.__InitSequence_NativeFunctionPtr, (void*)ptr);
			LevelSequenceActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(ptr->LevelSequenceActor);
		}

		// Token: 0x06021D7B RID: 138619 RVA: 0x008F7214 File Offset: 0x008F5414
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitNoteRefArray()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Piano_C.__InitNoteRefArray_NativeFunctionPtr, null);
		}

		// Token: 0x06021D7C RID: 138620 RVA: 0x008F7228 File Offset: 0x008F5428
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitKeyRefArray()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Piano_C.__InitKeyRefArray_NativeFunctionPtr, null);
		}

		// Token: 0x06021D7D RID: 138621 RVA: 0x008F723C File Offset: 0x008F543C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetNote(PianoKeyEnum KeyType, ref BP_PianoNote_C Note)
		{
			BP_Piano_C.__GetNote_FunctionParams* ptr = stackalloc BP_Piano_C.__GetNote_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_Piano_C.__GetNote_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Piano_C.__GetNote_NativeFunctionPtr, (void*)ptr, 1);
			ptr->KeyType = KeyType;
			ref BP_Piano_C.__GetNote_FunctionParams ptr2 = ref *ptr;
			BP_PianoNote_C bp_PianoNote_C = Note;
			ptr2.Note = ((bp_PianoNote_C != null) ? bp_PianoNote_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Piano_C.__GetNote_NativeFunctionPtr, (void*)ptr);
			Note = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_PianoNote_C>(ptr->Note);
		}

		// Token: 0x06021D7E RID: 138622 RVA: 0x008F72AC File Offset: 0x008F54AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PlayAudio(PianoKeyEnum KeyType)
		{
			BP_Piano_C.__PlayAudio_FunctionParams* ptr = stackalloc BP_Piano_C.__PlayAudio_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_Piano_C.__PlayAudio_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Piano_C.__PlayAudio_NativeFunctionPtr, (void*)ptr, 1);
			ptr->KeyType = KeyType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Piano_C.__PlayAudio_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D7F RID: 138623 RVA: 0x008F72F7 File Offset: 0x008F54F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Piano_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021D80 RID: 138624 RVA: 0x008F730B File Offset: 0x008F550B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Piano_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021D81 RID: 138625 RVA: 0x008F7320 File Offset: 0x008F5520
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Piano_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Piano_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Piano_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Piano_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Piano_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D82 RID: 138626 RVA: 0x008F7368 File Offset: 0x008F5568
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Piano_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Piano_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Piano_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Piano_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Piano_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021D83 RID: 138627 RVA: 0x008F73B0 File Offset: 0x008F55B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CustomEvent_0(bool Overlap, PianoKeyEnum KeyType)
		{
			BP_Piano_C.__CustomEvent_0_FunctionParams* ptr = stackalloc BP_Piano_C.__CustomEvent_0_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_Piano_C.__CustomEvent_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Piano_C.__CustomEvent_0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Overlap = Overlap;
			ptr->KeyType = KeyType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Piano_C.__CustomEvent_0_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D84 RID: 138628 RVA: 0x008F7404 File Offset: 0x008F5604
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_Piano_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_Piano_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Piano_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Piano_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Piano_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D85 RID: 138629 RVA: 0x008F7450 File Offset: 0x008F5650
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_Piano_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_Piano_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Piano_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Piano_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Piano_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021D86 RID: 138630 RVA: 0x008F749C File Offset: 0x008F569C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Piano_C.__CustomEvent_1_NativeFunctionPtr, null);
		}

		// Token: 0x06021D87 RID: 138631 RVA: 0x008F74B0 File Offset: 0x008F56B0
		protected BP_Piano_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010827 RID: 67623
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_Piano.BP_Piano_C";

		// Token: 0x04010828 RID: 67624
		private static IntPtr _ClassPtr;

		// Token: 0x04010829 RID: 67625
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401082A RID: 67626
		public static IntPtr __MoveNote__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401082B RID: 67627
		internal static int __PropertyOffset_1;

		// Token: 0x0401082C RID: 67628
		internal static int __PropertyOffset_2;

		// Token: 0x0401082D RID: 67629
		internal static int __PropertyOffset_3;

		// Token: 0x0401082E RID: 67630
		internal static int __PropertyOffset_4;

		// Token: 0x0401082F RID: 67631
		internal static int __PropertyOffset_5;

		// Token: 0x04010830 RID: 67632
		internal static int __PropertyOffset_6;

		// Token: 0x04010831 RID: 67633
		internal static int __PropertyOffset_7;

		// Token: 0x04010832 RID: 67634
		internal static int __PropertyOffset_8;

		// Token: 0x04010833 RID: 67635
		internal static int __PropertyOffset_9;

		// Token: 0x04010834 RID: 67636
		internal static int __PropertyOffset_10;

		// Token: 0x04010835 RID: 67637
		internal static int __PropertyOffset_11;

		// Token: 0x04010836 RID: 67638
		internal static int __PropertyOffset_12;

		// Token: 0x04010837 RID: 67639
		internal static int __PropertyOffset_13;

		// Token: 0x04010838 RID: 67640
		internal static int __PropertyOffset_14;

		// Token: 0x04010839 RID: 67641
		internal static int __PropertyOffset_15;

		// Token: 0x0401083A RID: 67642
		internal static int __PropertyOffset_16;

		// Token: 0x0401083B RID: 67643
		internal static int __PropertyOffset_17;

		// Token: 0x0401083C RID: 67644
		internal static int __PropertyOffset_18;

		// Token: 0x0401083D RID: 67645
		internal static int __PropertyOffset_19;

		// Token: 0x0401083E RID: 67646
		internal static int __PropertyOffset_20;

		// Token: 0x0401083F RID: 67647
		internal static int __PropertyOffset_21;

		// Token: 0x04010840 RID: 67648
		internal static int __PropertyOffset_22;

		// Token: 0x04010841 RID: 67649
		internal static int __PropertyOffset_23;

		// Token: 0x04010842 RID: 67650
		internal static int __PropertyOffset_24;

		// Token: 0x04010843 RID: 67651
		internal static int __PropertyOffset_25;

		// Token: 0x04010844 RID: 67652
		internal static int __PropertyOffset_26;

		// Token: 0x04010845 RID: 67653
		internal static int __PropertyOffset_27;

		// Token: 0x04010846 RID: 67654
		internal static int __PropertyOffset_28;

		// Token: 0x04010847 RID: 67655
		internal static int __PropertyOffset_29;

		// Token: 0x04010848 RID: 67656
		internal static int __PropertyOffset_30;

		// Token: 0x04010849 RID: 67657
		internal static int __PropertyOffset_31;

		// Token: 0x0401084A RID: 67658
		internal static int __PropertyOffset_32;

		// Token: 0x0401084B RID: 67659
		internal static int __PropertyOffset_33;

		// Token: 0x0401084C RID: 67660
		internal static int __PropertyOffset_34;

		// Token: 0x0401084D RID: 67661
		internal static int __PropertyOffset_35;

		// Token: 0x0401084E RID: 67662
		internal static int __PropertyOffset_36;

		// Token: 0x0401084F RID: 67663
		internal static int __PropertyOffset_37;

		// Token: 0x04010850 RID: 67664
		internal static int __PropertyOffset_38;

		// Token: 0x04010851 RID: 67665
		internal static int __PropertyOffset_39;

		// Token: 0x04010852 RID: 67666
		internal static int __PropertyOffset_40;

		// Token: 0x04010853 RID: 67667
		internal static int __PropertyOffset_41;

		// Token: 0x04010854 RID: 67668
		internal static int __PropertyOffset_42;

		// Token: 0x04010855 RID: 67669
		internal static int __PropertyOffset_43;

		// Token: 0x04010856 RID: 67670
		internal static int __PropertyOffset_44;

		// Token: 0x04010857 RID: 67671
		internal static int __PropertyOffset_45;

		// Token: 0x04010858 RID: 67672
		internal static int __PropertyOffset_46;

		// Token: 0x04010859 RID: 67673
		internal static int __PropertyOffset_47;

		// Token: 0x0401085A RID: 67674
		internal static int __PropertyOffset_48;

		// Token: 0x0401085B RID: 67675
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_PianoKey_C> _BPKeyArray;

		// Token: 0x0401085C RID: 67676
		internal static int __PropertyOffset_49;

		// Token: 0x0401085D RID: 67677
		private MoveNote _MoveNote;

		// Token: 0x0401085E RID: 67678
		internal static int __PropertyOffset_50;

		// Token: 0x0401085F RID: 67679
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_PianoNote_C> _BPNoteArray;

		// Token: 0x04010860 RID: 67680
		internal static int __PropertyOffset_51;

		// Token: 0x04010861 RID: 67681
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<BP_PianoNote_C> _TriggeredNoteSet;

		// Token: 0x04010862 RID: 67682
		internal static int __PropertyOffset_52;

		// Token: 0x04010863 RID: 67683
		internal static int __PropertyOffset_53;

		// Token: 0x04010864 RID: 67684
		internal static int __PropertyOffset_54;

		// Token: 0x04010865 RID: 67685
		internal static int __PropertyOffset_55;

		// Token: 0x04010866 RID: 67686
		private static IntPtr __InitSequence_NativeFunctionPtr;

		// Token: 0x04010867 RID: 67687
		private static IntPtr __InitNoteRefArray_NativeFunctionPtr;

		// Token: 0x04010868 RID: 67688
		private static IntPtr __InitKeyRefArray_NativeFunctionPtr;

		// Token: 0x04010869 RID: 67689
		private static IntPtr __GetNote_NativeFunctionPtr;

		// Token: 0x0401086A RID: 67690
		private static IntPtr __PlayAudio_NativeFunctionPtr;

		// Token: 0x0401086B RID: 67691
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401086C RID: 67692
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401086D RID: 67693
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x0401086E RID: 67694
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0401086F RID: 67695
		private static IntPtr __CustomEvent_1_NativeFunctionPtr;

		// Token: 0x02009CD5 RID: 40149
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __InitSequence_FunctionParams
		{
			// Token: 0x040313C4 RID: 201668
			[FieldOffset(0)]
			public IntPtr LevelSequenceActor;
		}

		// Token: 0x02009CD6 RID: 40150
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __GetNote_FunctionParams
		{
			// Token: 0x040313C5 RID: 201669
			[FieldOffset(0)]
			public TEnumAsByte<PianoKeyEnum> KeyType;

			// Token: 0x040313C6 RID: 201670
			[FieldOffset(8)]
			public IntPtr Note;
		}

		// Token: 0x02009CD7 RID: 40151
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __PlayAudio_FunctionParams
		{
			// Token: 0x040313C7 RID: 201671
			[FieldOffset(0)]
			public TEnumAsByte<PianoKeyEnum> KeyType;
		}

		// Token: 0x02009CD8 RID: 40152
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040313C8 RID: 201672
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009CD9 RID: 40153
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __CustomEvent_0_FunctionParams
		{
			// Token: 0x040313C9 RID: 201673
			[FieldOffset(0)]
			public bool Overlap;

			// Token: 0x040313CA RID: 201674
			[FieldOffset(1)]
			public TEnumAsByte<PianoKeyEnum> KeyType;
		}

		// Token: 0x02009CDA RID: 40154
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040313CB RID: 201675
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
