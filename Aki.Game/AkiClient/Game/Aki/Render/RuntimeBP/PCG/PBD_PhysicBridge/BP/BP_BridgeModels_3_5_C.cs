using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP
{
	// Token: 0x02003C3E RID: 15422
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_3_5.BP_BridgeModels_3_5_C")]
	[UnrealStructLayout(2328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2328)]
	public class BP_BridgeModels_3_5_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060237BD RID: 145341 RVA: 0x009250FB File Offset: 0x009232FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BridgeModels_3_5_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_3_5.BP_BridgeModels_3_5_C");
			}
			return BP_BridgeModels_3_5_C._ClassPtr;
		}

		// Token: 0x060237BE RID: 145342 RVA: 0x00925120 File Offset: 0x00923320
		public BP_BridgeModels_3_5_C() : this(BuiltinUtils.AllocNativeUObject(BP_BridgeModels_3_5_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060237BF RID: 145343 RVA: 0x00925148 File Offset: 0x00923348
		[NullableContext(1)]
		public BP_BridgeModels_3_5_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BridgeModels_3_5_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004185 RID: 16773
		// (get) Token: 0x060237C0 RID: 145344 RVA: 0x0092517B File Offset: 0x0092337B
		// (set) Token: 0x060237C1 RID: 145345 RVA: 0x0092518F File Offset: 0x0092338F
		public unsafe UBoxComponent LODRangeBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004186 RID: 16774
		// (get) Token: 0x060237C2 RID: 145346 RVA: 0x009251A4 File Offset: 0x009233A4
		// (set) Token: 0x060237C3 RID: 145347 RVA: 0x009251B8 File Offset: 0x009233B8
		public unsafe UStaticMeshComponent SM_Gel_Bri_06CL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004187 RID: 16775
		// (get) Token: 0x060237C4 RID: 145348 RVA: 0x009251CD File Offset: 0x009233CD
		// (set) Token: 0x060237C5 RID: 145349 RVA: 0x009251E1 File Offset: 0x009233E1
		public unsafe UStaticMeshComponent SM_Gel_Bri_06BL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004188 RID: 16776
		// (get) Token: 0x060237C6 RID: 145350 RVA: 0x009251F6 File Offset: 0x009233F6
		// (set) Token: 0x060237C7 RID: 145351 RVA: 0x0092520A File Offset: 0x0092340A
		public unsafe UStaticMeshComponent Cube16
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004189 RID: 16777
		// (get) Token: 0x060237C8 RID: 145352 RVA: 0x0092521F File Offset: 0x0092341F
		// (set) Token: 0x060237C9 RID: 145353 RVA: 0x00925233 File Offset: 0x00923433
		public unsafe UStaticMeshComponent Cube15
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700418A RID: 16778
		// (get) Token: 0x060237CA RID: 145354 RVA: 0x00925248 File Offset: 0x00923448
		// (set) Token: 0x060237CB RID: 145355 RVA: 0x0092525C File Offset: 0x0092345C
		public unsafe UStaticMeshComponent Cube14
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700418B RID: 16779
		// (get) Token: 0x060237CC RID: 145356 RVA: 0x00925271 File Offset: 0x00923471
		// (set) Token: 0x060237CD RID: 145357 RVA: 0x00925285 File Offset: 0x00923485
		public unsafe UStaticMeshComponent Cube13
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700418C RID: 16780
		// (get) Token: 0x060237CE RID: 145358 RVA: 0x0092529A File Offset: 0x0092349A
		// (set) Token: 0x060237CF RID: 145359 RVA: 0x009252AE File Offset: 0x009234AE
		public unsafe UStaticMeshComponent Cube12
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700418D RID: 16781
		// (get) Token: 0x060237D0 RID: 145360 RVA: 0x009252C3 File Offset: 0x009234C3
		// (set) Token: 0x060237D1 RID: 145361 RVA: 0x009252D7 File Offset: 0x009234D7
		public unsafe UStaticMeshComponent Cube11
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x1700418E RID: 16782
		// (get) Token: 0x060237D2 RID: 145362 RVA: 0x009252EC File Offset: 0x009234EC
		// (set) Token: 0x060237D3 RID: 145363 RVA: 0x00925300 File Offset: 0x00923500
		public unsafe UChildActorComponent _94_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700418F RID: 16783
		// (get) Token: 0x060237D4 RID: 145364 RVA: 0x00925315 File Offset: 0x00923515
		// (set) Token: 0x060237D5 RID: 145365 RVA: 0x00925329 File Offset: 0x00923529
		public unsafe UChildActorComponent _94_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004190 RID: 16784
		// (get) Token: 0x060237D6 RID: 145366 RVA: 0x0092533E File Offset: 0x0092353E
		// (set) Token: 0x060237D7 RID: 145367 RVA: 0x00925352 File Offset: 0x00923552
		public unsafe UChildActorComponent _94_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17004191 RID: 16785
		// (get) Token: 0x060237D8 RID: 145368 RVA: 0x00925367 File Offset: 0x00923567
		// (set) Token: 0x060237D9 RID: 145369 RVA: 0x0092537B File Offset: 0x0092357B
		public unsafe UChildActorComponent _94_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17004192 RID: 16786
		// (get) Token: 0x060237DA RID: 145370 RVA: 0x00925390 File Offset: 0x00923590
		// (set) Token: 0x060237DB RID: 145371 RVA: 0x009253A4 File Offset: 0x009235A4
		public unsafe UChildActorComponent _83_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17004193 RID: 16787
		// (get) Token: 0x060237DC RID: 145372 RVA: 0x009253B9 File Offset: 0x009235B9
		// (set) Token: 0x060237DD RID: 145373 RVA: 0x009253CD File Offset: 0x009235CD
		public unsafe UChildActorComponent _83_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17004194 RID: 16788
		// (get) Token: 0x060237DE RID: 145374 RVA: 0x009253E2 File Offset: 0x009235E2
		// (set) Token: 0x060237DF RID: 145375 RVA: 0x009253F6 File Offset: 0x009235F6
		public unsafe UChildActorComponent _83_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17004195 RID: 16789
		// (get) Token: 0x060237E0 RID: 145376 RVA: 0x0092540B File Offset: 0x0092360B
		// (set) Token: 0x060237E1 RID: 145377 RVA: 0x0092541F File Offset: 0x0092361F
		public unsafe UChildActorComponent _83_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17004196 RID: 16790
		// (get) Token: 0x060237E2 RID: 145378 RVA: 0x00925434 File Offset: 0x00923634
		// (set) Token: 0x060237E3 RID: 145379 RVA: 0x00925448 File Offset: 0x00923648
		public unsafe UChildActorComponent _60_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17004197 RID: 16791
		// (get) Token: 0x060237E4 RID: 145380 RVA: 0x0092545D File Offset: 0x0092365D
		// (set) Token: 0x060237E5 RID: 145381 RVA: 0x00925471 File Offset: 0x00923671
		public unsafe UChildActorComponent _60_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17004198 RID: 16792
		// (get) Token: 0x060237E6 RID: 145382 RVA: 0x00925486 File Offset: 0x00923686
		// (set) Token: 0x060237E7 RID: 145383 RVA: 0x0092549A File Offset: 0x0092369A
		public unsafe UChildActorComponent _60_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17004199 RID: 16793
		// (get) Token: 0x060237E8 RID: 145384 RVA: 0x009254AF File Offset: 0x009236AF
		// (set) Token: 0x060237E9 RID: 145385 RVA: 0x009254C3 File Offset: 0x009236C3
		public unsafe UChildActorComponent _60_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x1700419A RID: 16794
		// (get) Token: 0x060237EA RID: 145386 RVA: 0x009254D8 File Offset: 0x009236D8
		// (set) Token: 0x060237EB RID: 145387 RVA: 0x009254EC File Offset: 0x009236EC
		public unsafe UChildActorComponent _72_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x1700419B RID: 16795
		// (get) Token: 0x060237EC RID: 145388 RVA: 0x00925501 File Offset: 0x00923701
		// (set) Token: 0x060237ED RID: 145389 RVA: 0x00925515 File Offset: 0x00923715
		public unsafe UChildActorComponent _72_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x1700419C RID: 16796
		// (get) Token: 0x060237EE RID: 145390 RVA: 0x0092552A File Offset: 0x0092372A
		// (set) Token: 0x060237EF RID: 145391 RVA: 0x0092553E File Offset: 0x0092373E
		public unsafe UChildActorComponent _72_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x1700419D RID: 16797
		// (get) Token: 0x060237F0 RID: 145392 RVA: 0x00925553 File Offset: 0x00923753
		// (set) Token: 0x060237F1 RID: 145393 RVA: 0x00925567 File Offset: 0x00923767
		public unsafe UChildActorComponent _72_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x1700419E RID: 16798
		// (get) Token: 0x060237F2 RID: 145394 RVA: 0x0092557C File Offset: 0x0092377C
		// (set) Token: 0x060237F3 RID: 145395 RVA: 0x00925590 File Offset: 0x00923790
		public unsafe UStaticMeshComponent StaticMesh99
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x1700419F RID: 16799
		// (get) Token: 0x060237F4 RID: 145396 RVA: 0x009255A5 File Offset: 0x009237A5
		// (set) Token: 0x060237F5 RID: 145397 RVA: 0x009255B9 File Offset: 0x009237B9
		public unsafe UStaticMeshComponent StaticMesh98
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x170041A0 RID: 16800
		// (get) Token: 0x060237F6 RID: 145398 RVA: 0x009255CE File Offset: 0x009237CE
		// (set) Token: 0x060237F7 RID: 145399 RVA: 0x009255E2 File Offset: 0x009237E2
		public unsafe UStaticMeshComponent StaticMesh97
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x170041A1 RID: 16801
		// (get) Token: 0x060237F8 RID: 145400 RVA: 0x009255F7 File Offset: 0x009237F7
		// (set) Token: 0x060237F9 RID: 145401 RVA: 0x0092560B File Offset: 0x0092380B
		public unsafe UStaticMeshComponent StaticMesh96
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x170041A2 RID: 16802
		// (get) Token: 0x060237FA RID: 145402 RVA: 0x00925620 File Offset: 0x00923820
		// (set) Token: 0x060237FB RID: 145403 RVA: 0x00925634 File Offset: 0x00923834
		public unsafe UStaticMeshComponent StaticMesh95
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x170041A3 RID: 16803
		// (get) Token: 0x060237FC RID: 145404 RVA: 0x00925649 File Offset: 0x00923849
		// (set) Token: 0x060237FD RID: 145405 RVA: 0x0092565D File Offset: 0x0092385D
		public unsafe UStaticMeshComponent StaticMesh94
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x170041A4 RID: 16804
		// (get) Token: 0x060237FE RID: 145406 RVA: 0x00925672 File Offset: 0x00923872
		// (set) Token: 0x060237FF RID: 145407 RVA: 0x00925686 File Offset: 0x00923886
		public unsafe UStaticMeshComponent StaticMesh93
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x170041A5 RID: 16805
		// (get) Token: 0x06023800 RID: 145408 RVA: 0x0092569B File Offset: 0x0092389B
		// (set) Token: 0x06023801 RID: 145409 RVA: 0x009256AF File Offset: 0x009238AF
		public unsafe UStaticMeshComponent StaticMesh92
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x170041A6 RID: 16806
		// (get) Token: 0x06023802 RID: 145410 RVA: 0x009256C4 File Offset: 0x009238C4
		// (set) Token: 0x06023803 RID: 145411 RVA: 0x009256D8 File Offset: 0x009238D8
		public unsafe UStaticMeshComponent StaticMesh91
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x170041A7 RID: 16807
		// (get) Token: 0x06023804 RID: 145412 RVA: 0x009256ED File Offset: 0x009238ED
		// (set) Token: 0x06023805 RID: 145413 RVA: 0x00925701 File Offset: 0x00923901
		public unsafe UStaticMeshComponent StaticMesh90
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x170041A8 RID: 16808
		// (get) Token: 0x06023806 RID: 145414 RVA: 0x00925716 File Offset: 0x00923916
		// (set) Token: 0x06023807 RID: 145415 RVA: 0x0092572A File Offset: 0x0092392A
		public unsafe UStaticMeshComponent StaticMesh89
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x170041A9 RID: 16809
		// (get) Token: 0x06023808 RID: 145416 RVA: 0x0092573F File Offset: 0x0092393F
		// (set) Token: 0x06023809 RID: 145417 RVA: 0x00925753 File Offset: 0x00923953
		public unsafe UStaticMeshComponent StaticMesh88
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x170041AA RID: 16810
		// (get) Token: 0x0602380A RID: 145418 RVA: 0x00925768 File Offset: 0x00923968
		// (set) Token: 0x0602380B RID: 145419 RVA: 0x0092577C File Offset: 0x0092397C
		public unsafe UStaticMeshComponent StaticMesh87
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x170041AB RID: 16811
		// (get) Token: 0x0602380C RID: 145420 RVA: 0x00925791 File Offset: 0x00923991
		// (set) Token: 0x0602380D RID: 145421 RVA: 0x009257A5 File Offset: 0x009239A5
		public unsafe UStaticMeshComponent StaticMesh86
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x170041AC RID: 16812
		// (get) Token: 0x0602380E RID: 145422 RVA: 0x009257BA File Offset: 0x009239BA
		// (set) Token: 0x0602380F RID: 145423 RVA: 0x009257CE File Offset: 0x009239CE
		public unsafe UStaticMeshComponent StaticMesh85
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_40);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_40, value);
			}
		}

		// Token: 0x170041AD RID: 16813
		// (get) Token: 0x06023810 RID: 145424 RVA: 0x009257E3 File Offset: 0x009239E3
		// (set) Token: 0x06023811 RID: 145425 RVA: 0x009257F7 File Offset: 0x009239F7
		public unsafe UStaticMeshComponent StaticMesh84
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_41);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_41, value);
			}
		}

		// Token: 0x170041AE RID: 16814
		// (get) Token: 0x06023812 RID: 145426 RVA: 0x0092580C File Offset: 0x00923A0C
		// (set) Token: 0x06023813 RID: 145427 RVA: 0x00925820 File Offset: 0x00923A20
		public unsafe UStaticMeshComponent StaticMesh83
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_42);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_42, value);
			}
		}

		// Token: 0x170041AF RID: 16815
		// (get) Token: 0x06023814 RID: 145428 RVA: 0x00925835 File Offset: 0x00923A35
		// (set) Token: 0x06023815 RID: 145429 RVA: 0x00925849 File Offset: 0x00923A49
		public unsafe UStaticMeshComponent StaticMesh82
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_43);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_43, value);
			}
		}

		// Token: 0x170041B0 RID: 16816
		// (get) Token: 0x06023816 RID: 145430 RVA: 0x0092585E File Offset: 0x00923A5E
		// (set) Token: 0x06023817 RID: 145431 RVA: 0x00925872 File Offset: 0x00923A72
		public unsafe UStaticMeshComponent StaticMesh81
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_44);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_44, value);
			}
		}

		// Token: 0x170041B1 RID: 16817
		// (get) Token: 0x06023818 RID: 145432 RVA: 0x00925887 File Offset: 0x00923A87
		// (set) Token: 0x06023819 RID: 145433 RVA: 0x0092589B File Offset: 0x00923A9B
		public unsafe UStaticMeshComponent StaticMesh80
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x170041B2 RID: 16818
		// (get) Token: 0x0602381A RID: 145434 RVA: 0x009258B0 File Offset: 0x00923AB0
		// (set) Token: 0x0602381B RID: 145435 RVA: 0x009258C4 File Offset: 0x00923AC4
		public unsafe UStaticMeshComponent StaticMesh79
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x170041B3 RID: 16819
		// (get) Token: 0x0602381C RID: 145436 RVA: 0x009258D9 File Offset: 0x00923AD9
		// (set) Token: 0x0602381D RID: 145437 RVA: 0x009258ED File Offset: 0x00923AED
		public unsafe UStaticMeshComponent StaticMesh78
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x170041B4 RID: 16820
		// (get) Token: 0x0602381E RID: 145438 RVA: 0x00925902 File Offset: 0x00923B02
		// (set) Token: 0x0602381F RID: 145439 RVA: 0x00925916 File Offset: 0x00923B16
		public unsafe UStaticMeshComponent StaticMesh77
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_48);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_48, value);
			}
		}

		// Token: 0x170041B5 RID: 16821
		// (get) Token: 0x06023820 RID: 145440 RVA: 0x0092592B File Offset: 0x00923B2B
		// (set) Token: 0x06023821 RID: 145441 RVA: 0x0092593F File Offset: 0x00923B3F
		public unsafe UStaticMeshComponent StaticMesh76
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_49);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_49, value);
			}
		}

		// Token: 0x170041B6 RID: 16822
		// (get) Token: 0x06023822 RID: 145442 RVA: 0x00925954 File Offset: 0x00923B54
		// (set) Token: 0x06023823 RID: 145443 RVA: 0x00925968 File Offset: 0x00923B68
		public unsafe UStaticMeshComponent StaticMesh75
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_50);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_50, value);
			}
		}

		// Token: 0x170041B7 RID: 16823
		// (get) Token: 0x06023824 RID: 145444 RVA: 0x0092597D File Offset: 0x00923B7D
		// (set) Token: 0x06023825 RID: 145445 RVA: 0x00925991 File Offset: 0x00923B91
		public unsafe UStaticMeshComponent StaticMesh74
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_51);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_51, value);
			}
		}

		// Token: 0x170041B8 RID: 16824
		// (get) Token: 0x06023826 RID: 145446 RVA: 0x009259A6 File Offset: 0x00923BA6
		// (set) Token: 0x06023827 RID: 145447 RVA: 0x009259BA File Offset: 0x00923BBA
		public unsafe UStaticMeshComponent StaticMesh73
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_52);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_52, value);
			}
		}

		// Token: 0x170041B9 RID: 16825
		// (get) Token: 0x06023828 RID: 145448 RVA: 0x009259CF File Offset: 0x00923BCF
		// (set) Token: 0x06023829 RID: 145449 RVA: 0x009259E3 File Offset: 0x00923BE3
		public unsafe UStaticMeshComponent StaticMesh72
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_53);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_53, value);
			}
		}

		// Token: 0x170041BA RID: 16826
		// (get) Token: 0x0602382A RID: 145450 RVA: 0x009259F8 File Offset: 0x00923BF8
		// (set) Token: 0x0602382B RID: 145451 RVA: 0x00925A0C File Offset: 0x00923C0C
		public unsafe UStaticMeshComponent StaticMesh71
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_54);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_54, value);
			}
		}

		// Token: 0x170041BB RID: 16827
		// (get) Token: 0x0602382C RID: 145452 RVA: 0x00925A21 File Offset: 0x00923C21
		// (set) Token: 0x0602382D RID: 145453 RVA: 0x00925A35 File Offset: 0x00923C35
		public unsafe UStaticMeshComponent StaticMesh70
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_55);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_55, value);
			}
		}

		// Token: 0x170041BC RID: 16828
		// (get) Token: 0x0602382E RID: 145454 RVA: 0x00925A4A File Offset: 0x00923C4A
		// (set) Token: 0x0602382F RID: 145455 RVA: 0x00925A5E File Offset: 0x00923C5E
		public unsafe UStaticMeshComponent StaticMesh69
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_56);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_56, value);
			}
		}

		// Token: 0x170041BD RID: 16829
		// (get) Token: 0x06023830 RID: 145456 RVA: 0x00925A73 File Offset: 0x00923C73
		// (set) Token: 0x06023831 RID: 145457 RVA: 0x00925A87 File Offset: 0x00923C87
		public unsafe UStaticMeshComponent StaticMesh68
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_57);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_57, value);
			}
		}

		// Token: 0x170041BE RID: 16830
		// (get) Token: 0x06023832 RID: 145458 RVA: 0x00925A9C File Offset: 0x00923C9C
		// (set) Token: 0x06023833 RID: 145459 RVA: 0x00925AB0 File Offset: 0x00923CB0
		public unsafe UStaticMeshComponent StaticMesh67
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_58);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_58, value);
			}
		}

		// Token: 0x170041BF RID: 16831
		// (get) Token: 0x06023834 RID: 145460 RVA: 0x00925AC5 File Offset: 0x00923CC5
		// (set) Token: 0x06023835 RID: 145461 RVA: 0x00925AD9 File Offset: 0x00923CD9
		public unsafe UStaticMeshComponent StaticMesh66
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_59);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_59, value);
			}
		}

		// Token: 0x170041C0 RID: 16832
		// (get) Token: 0x06023836 RID: 145462 RVA: 0x00925AEE File Offset: 0x00923CEE
		// (set) Token: 0x06023837 RID: 145463 RVA: 0x00925B02 File Offset: 0x00923D02
		public unsafe UStaticMeshComponent StaticMesh65
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_60);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_60, value);
			}
		}

		// Token: 0x170041C1 RID: 16833
		// (get) Token: 0x06023838 RID: 145464 RVA: 0x00925B17 File Offset: 0x00923D17
		// (set) Token: 0x06023839 RID: 145465 RVA: 0x00925B2B File Offset: 0x00923D2B
		public unsafe UStaticMeshComponent StaticMesh64
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_61);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_61, value);
			}
		}

		// Token: 0x170041C2 RID: 16834
		// (get) Token: 0x0602383A RID: 145466 RVA: 0x00925B40 File Offset: 0x00923D40
		// (set) Token: 0x0602383B RID: 145467 RVA: 0x00925B54 File Offset: 0x00923D54
		public unsafe UStaticMeshComponent StaticMesh63
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_62);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_62, value);
			}
		}

		// Token: 0x170041C3 RID: 16835
		// (get) Token: 0x0602383C RID: 145468 RVA: 0x00925B69 File Offset: 0x00923D69
		// (set) Token: 0x0602383D RID: 145469 RVA: 0x00925B7D File Offset: 0x00923D7D
		public unsafe UStaticMeshComponent StaticMesh62
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_63);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_63, value);
			}
		}

		// Token: 0x170041C4 RID: 16836
		// (get) Token: 0x0602383E RID: 145470 RVA: 0x00925B92 File Offset: 0x00923D92
		// (set) Token: 0x0602383F RID: 145471 RVA: 0x00925BA6 File Offset: 0x00923DA6
		public unsafe UStaticMeshComponent StaticMesh60
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_64);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_64, value);
			}
		}

		// Token: 0x170041C5 RID: 16837
		// (get) Token: 0x06023840 RID: 145472 RVA: 0x00925BBB File Offset: 0x00923DBB
		// (set) Token: 0x06023841 RID: 145473 RVA: 0x00925BCF File Offset: 0x00923DCF
		public unsafe UStaticMeshComponent StaticMesh59
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_65);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_65, value);
			}
		}

		// Token: 0x170041C6 RID: 16838
		// (get) Token: 0x06023842 RID: 145474 RVA: 0x00925BE4 File Offset: 0x00923DE4
		// (set) Token: 0x06023843 RID: 145475 RVA: 0x00925BF8 File Offset: 0x00923DF8
		public unsafe UStaticMeshComponent StaticMesh58
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_66);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_66, value);
			}
		}

		// Token: 0x170041C7 RID: 16839
		// (get) Token: 0x06023844 RID: 145476 RVA: 0x00925C0D File Offset: 0x00923E0D
		// (set) Token: 0x06023845 RID: 145477 RVA: 0x00925C21 File Offset: 0x00923E21
		public unsafe UStaticMeshComponent StaticMesh57
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_67);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_67, value);
			}
		}

		// Token: 0x170041C8 RID: 16840
		// (get) Token: 0x06023846 RID: 145478 RVA: 0x00925C36 File Offset: 0x00923E36
		// (set) Token: 0x06023847 RID: 145479 RVA: 0x00925C4A File Offset: 0x00923E4A
		public unsafe UStaticMeshComponent Cube8
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_68);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_68, value);
			}
		}

		// Token: 0x170041C9 RID: 16841
		// (get) Token: 0x06023848 RID: 145480 RVA: 0x00925C5F File Offset: 0x00923E5F
		// (set) Token: 0x06023849 RID: 145481 RVA: 0x00925C73 File Offset: 0x00923E73
		public unsafe UStaticMeshComponent Cube7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_69);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_69, value);
			}
		}

		// Token: 0x170041CA RID: 16842
		// (get) Token: 0x0602384A RID: 145482 RVA: 0x00925C88 File Offset: 0x00923E88
		// (set) Token: 0x0602384B RID: 145483 RVA: 0x00925C9C File Offset: 0x00923E9C
		public unsafe UChildActorComponent _15_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_70);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_70, value);
			}
		}

		// Token: 0x170041CB RID: 16843
		// (get) Token: 0x0602384C RID: 145484 RVA: 0x00925CB1 File Offset: 0x00923EB1
		// (set) Token: 0x0602384D RID: 145485 RVA: 0x00925CC5 File Offset: 0x00923EC5
		public unsafe UStaticMeshComponent Cube3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_71);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_71, value);
			}
		}

		// Token: 0x170041CC RID: 16844
		// (get) Token: 0x0602384E RID: 145486 RVA: 0x00925CDA File Offset: 0x00923EDA
		// (set) Token: 0x0602384F RID: 145487 RVA: 0x00925CEE File Offset: 0x00923EEE
		public unsafe UStaticMeshComponent Cube2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_72);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_72, value);
			}
		}

		// Token: 0x170041CD RID: 16845
		// (get) Token: 0x06023850 RID: 145488 RVA: 0x00925D03 File Offset: 0x00923F03
		// (set) Token: 0x06023851 RID: 145489 RVA: 0x00925D17 File Offset: 0x00923F17
		public unsafe UChildActorComponent _15_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_73);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_73, value);
			}
		}

		// Token: 0x170041CE RID: 16846
		// (get) Token: 0x06023852 RID: 145490 RVA: 0x00925D2C File Offset: 0x00923F2C
		// (set) Token: 0x06023853 RID: 145491 RVA: 0x00925D40 File Offset: 0x00923F40
		public unsafe UChildActorComponent _15_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_74);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_74, value);
			}
		}

		// Token: 0x170041CF RID: 16847
		// (get) Token: 0x06023854 RID: 145492 RVA: 0x00925D55 File Offset: 0x00923F55
		// (set) Token: 0x06023855 RID: 145493 RVA: 0x00925D69 File Offset: 0x00923F69
		public unsafe UChildActorComponent _15_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_75);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_75, value);
			}
		}

		// Token: 0x170041D0 RID: 16848
		// (get) Token: 0x06023856 RID: 145494 RVA: 0x00925D7E File Offset: 0x00923F7E
		// (set) Token: 0x06023857 RID: 145495 RVA: 0x00925D92 File Offset: 0x00923F92
		public unsafe UChildActorComponent _24_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_76);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_76, value);
			}
		}

		// Token: 0x170041D1 RID: 16849
		// (get) Token: 0x06023858 RID: 145496 RVA: 0x00925DA7 File Offset: 0x00923FA7
		// (set) Token: 0x06023859 RID: 145497 RVA: 0x00925DBB File Offset: 0x00923FBB
		public unsafe UChildActorComponent _24_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_77);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_77, value);
			}
		}

		// Token: 0x170041D2 RID: 16850
		// (get) Token: 0x0602385A RID: 145498 RVA: 0x00925DD0 File Offset: 0x00923FD0
		// (set) Token: 0x0602385B RID: 145499 RVA: 0x00925DE4 File Offset: 0x00923FE4
		public unsafe UChildActorComponent _24_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_78);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_78, value);
			}
		}

		// Token: 0x170041D3 RID: 16851
		// (get) Token: 0x0602385C RID: 145500 RVA: 0x00925DF9 File Offset: 0x00923FF9
		// (set) Token: 0x0602385D RID: 145501 RVA: 0x00925E0D File Offset: 0x0092400D
		public unsafe UChildActorComponent _24_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_79);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_79, value);
			}
		}

		// Token: 0x170041D4 RID: 16852
		// (get) Token: 0x0602385E RID: 145502 RVA: 0x00925E22 File Offset: 0x00924022
		// (set) Token: 0x0602385F RID: 145503 RVA: 0x00925E36 File Offset: 0x00924036
		public unsafe UStaticMeshComponent Cube6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_80);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_80, value);
			}
		}

		// Token: 0x170041D5 RID: 16853
		// (get) Token: 0x06023860 RID: 145504 RVA: 0x00925E4B File Offset: 0x0092404B
		// (set) Token: 0x06023861 RID: 145505 RVA: 0x00925E5F File Offset: 0x0092405F
		public unsafe UStaticMeshComponent Cube5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_81);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_81, value);
			}
		}

		// Token: 0x170041D6 RID: 16854
		// (get) Token: 0x06023862 RID: 145506 RVA: 0x00925E74 File Offset: 0x00924074
		// (set) Token: 0x06023863 RID: 145507 RVA: 0x00925E88 File Offset: 0x00924088
		public unsafe UChildActorComponent _50_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_82);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_82, value);
			}
		}

		// Token: 0x170041D7 RID: 16855
		// (get) Token: 0x06023864 RID: 145508 RVA: 0x00925E9D File Offset: 0x0092409D
		// (set) Token: 0x06023865 RID: 145509 RVA: 0x00925EB1 File Offset: 0x009240B1
		public unsafe UChildActorComponent _50_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_83);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_83, value);
			}
		}

		// Token: 0x170041D8 RID: 16856
		// (get) Token: 0x06023866 RID: 145510 RVA: 0x00925EC6 File Offset: 0x009240C6
		// (set) Token: 0x06023867 RID: 145511 RVA: 0x00925EDA File Offset: 0x009240DA
		public unsafe UStaticMeshComponent Cube10
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_84);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_84, value);
			}
		}

		// Token: 0x170041D9 RID: 16857
		// (get) Token: 0x06023868 RID: 145512 RVA: 0x00925EEF File Offset: 0x009240EF
		// (set) Token: 0x06023869 RID: 145513 RVA: 0x00925F03 File Offset: 0x00924103
		public unsafe UStaticMeshComponent Cube9
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_85);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_85, value);
			}
		}

		// Token: 0x170041DA RID: 16858
		// (get) Token: 0x0602386A RID: 145514 RVA: 0x00925F18 File Offset: 0x00924118
		// (set) Token: 0x0602386B RID: 145515 RVA: 0x00925F2C File Offset: 0x0092412C
		public unsafe UChildActorComponent _50_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_86);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_86, value);
			}
		}

		// Token: 0x170041DB RID: 16859
		// (get) Token: 0x0602386C RID: 145516 RVA: 0x00925F41 File Offset: 0x00924141
		// (set) Token: 0x0602386D RID: 145517 RVA: 0x00925F55 File Offset: 0x00924155
		public unsafe UChildActorComponent _50_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_87);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_87, value);
			}
		}

		// Token: 0x170041DC RID: 16860
		// (get) Token: 0x0602386E RID: 145518 RVA: 0x00925F6A File Offset: 0x0092416A
		// (set) Token: 0x0602386F RID: 145519 RVA: 0x00925F7E File Offset: 0x0092417E
		public unsafe UChildActorComponent _10_1_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_88);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_88, value);
			}
		}

		// Token: 0x170041DD RID: 16861
		// (get) Token: 0x06023870 RID: 145520 RVA: 0x00925F93 File Offset: 0x00924193
		// (set) Token: 0x06023871 RID: 145521 RVA: 0x00925FA7 File Offset: 0x009241A7
		public unsafe UChildActorComponent _10_1_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_89);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_89, value);
			}
		}

		// Token: 0x170041DE RID: 16862
		// (get) Token: 0x06023872 RID: 145522 RVA: 0x00925FBC File Offset: 0x009241BC
		// (set) Token: 0x06023873 RID: 145523 RVA: 0x00925FD0 File Offset: 0x009241D0
		public unsafe UStaticMeshComponent Cube1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_90);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_90, value);
			}
		}

		// Token: 0x170041DF RID: 16863
		// (get) Token: 0x06023874 RID: 145524 RVA: 0x00925FE5 File Offset: 0x009241E5
		// (set) Token: 0x06023875 RID: 145525 RVA: 0x00925FF9 File Offset: 0x009241F9
		public unsafe UStaticMeshComponent Cube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_91);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_91, value);
			}
		}

		// Token: 0x170041E0 RID: 16864
		// (get) Token: 0x06023876 RID: 145526 RVA: 0x0092600E File Offset: 0x0092420E
		// (set) Token: 0x06023877 RID: 145527 RVA: 0x00926022 File Offset: 0x00924222
		public unsafe UChildActorComponent _10_2_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_92);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_92, value);
			}
		}

		// Token: 0x170041E1 RID: 16865
		// (get) Token: 0x06023878 RID: 145528 RVA: 0x00926037 File Offset: 0x00924237
		// (set) Token: 0x06023879 RID: 145529 RVA: 0x0092604B File Offset: 0x0092424B
		public unsafe UChildActorComponent _10_2_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_93);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_93, value);
			}
		}

		// Token: 0x170041E2 RID: 16866
		// (get) Token: 0x0602387A RID: 145530 RVA: 0x00926060 File Offset: 0x00924260
		// (set) Token: 0x0602387B RID: 145531 RVA: 0x00926074 File Offset: 0x00924274
		public unsafe UStaticMeshComponent StaticMesh61
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_94);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_94, value);
			}
		}

		// Token: 0x170041E3 RID: 16867
		// (get) Token: 0x0602387C RID: 145532 RVA: 0x00926089 File Offset: 0x00924289
		// (set) Token: 0x0602387D RID: 145533 RVA: 0x0092609D File Offset: 0x0092429D
		public unsafe UStaticMeshComponent StaticMesh56
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_95);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_95, value);
			}
		}

		// Token: 0x170041E4 RID: 16868
		// (get) Token: 0x0602387E RID: 145534 RVA: 0x009260B2 File Offset: 0x009242B2
		// (set) Token: 0x0602387F RID: 145535 RVA: 0x009260C6 File Offset: 0x009242C6
		public unsafe UStaticMeshComponent StaticMesh55
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_96);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_96, value);
			}
		}

		// Token: 0x170041E5 RID: 16869
		// (get) Token: 0x06023880 RID: 145536 RVA: 0x009260DB File Offset: 0x009242DB
		// (set) Token: 0x06023881 RID: 145537 RVA: 0x009260EF File Offset: 0x009242EF
		public unsafe UStaticMeshComponent StaticMesh54
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_97);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_97, value);
			}
		}

		// Token: 0x170041E6 RID: 16870
		// (get) Token: 0x06023882 RID: 145538 RVA: 0x00926104 File Offset: 0x00924304
		// (set) Token: 0x06023883 RID: 145539 RVA: 0x00926118 File Offset: 0x00924318
		public unsafe UStaticMeshComponent StaticMesh53
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_98);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_98, value);
			}
		}

		// Token: 0x170041E7 RID: 16871
		// (get) Token: 0x06023884 RID: 145540 RVA: 0x0092612D File Offset: 0x0092432D
		// (set) Token: 0x06023885 RID: 145541 RVA: 0x00926141 File Offset: 0x00924341
		public unsafe UStaticMeshComponent StaticMesh52
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_99);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_99, value);
			}
		}

		// Token: 0x170041E8 RID: 16872
		// (get) Token: 0x06023886 RID: 145542 RVA: 0x00926156 File Offset: 0x00924356
		// (set) Token: 0x06023887 RID: 145543 RVA: 0x0092616A File Offset: 0x0092436A
		public unsafe UStaticMeshComponent StaticMesh51
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_100);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_100, value);
			}
		}

		// Token: 0x170041E9 RID: 16873
		// (get) Token: 0x06023888 RID: 145544 RVA: 0x0092617F File Offset: 0x0092437F
		// (set) Token: 0x06023889 RID: 145545 RVA: 0x00926193 File Offset: 0x00924393
		public unsafe UStaticMeshComponent StaticMesh50
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_101);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_101, value);
			}
		}

		// Token: 0x170041EA RID: 16874
		// (get) Token: 0x0602388A RID: 145546 RVA: 0x009261A8 File Offset: 0x009243A8
		// (set) Token: 0x0602388B RID: 145547 RVA: 0x009261BC File Offset: 0x009243BC
		public unsafe UStaticMeshComponent StaticMesh49
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_102);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_102, value);
			}
		}

		// Token: 0x170041EB RID: 16875
		// (get) Token: 0x0602388C RID: 145548 RVA: 0x009261D1 File Offset: 0x009243D1
		// (set) Token: 0x0602388D RID: 145549 RVA: 0x009261E5 File Offset: 0x009243E5
		public unsafe UStaticMeshComponent StaticMesh48
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_103);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_103, value);
			}
		}

		// Token: 0x170041EC RID: 16876
		// (get) Token: 0x0602388E RID: 145550 RVA: 0x009261FA File Offset: 0x009243FA
		// (set) Token: 0x0602388F RID: 145551 RVA: 0x0092620E File Offset: 0x0092440E
		public unsafe UStaticMeshComponent StaticMesh47
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_104);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_104, value);
			}
		}

		// Token: 0x170041ED RID: 16877
		// (get) Token: 0x06023890 RID: 145552 RVA: 0x00926223 File Offset: 0x00924423
		// (set) Token: 0x06023891 RID: 145553 RVA: 0x00926237 File Offset: 0x00924437
		public unsafe UStaticMeshComponent StaticMesh46
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_105);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_105, value);
			}
		}

		// Token: 0x170041EE RID: 16878
		// (get) Token: 0x06023892 RID: 145554 RVA: 0x0092624C File Offset: 0x0092444C
		// (set) Token: 0x06023893 RID: 145555 RVA: 0x00926260 File Offset: 0x00924460
		public unsafe UStaticMeshComponent StaticMesh45
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_106);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_106, value);
			}
		}

		// Token: 0x170041EF RID: 16879
		// (get) Token: 0x06023894 RID: 145556 RVA: 0x00926275 File Offset: 0x00924475
		// (set) Token: 0x06023895 RID: 145557 RVA: 0x00926289 File Offset: 0x00924489
		public unsafe UStaticMeshComponent StaticMesh44
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_107);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_107, value);
			}
		}

		// Token: 0x170041F0 RID: 16880
		// (get) Token: 0x06023896 RID: 145558 RVA: 0x0092629E File Offset: 0x0092449E
		// (set) Token: 0x06023897 RID: 145559 RVA: 0x009262B2 File Offset: 0x009244B2
		public unsafe UStaticMeshComponent StaticMesh43
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_108);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_108, value);
			}
		}

		// Token: 0x170041F1 RID: 16881
		// (get) Token: 0x06023898 RID: 145560 RVA: 0x009262C7 File Offset: 0x009244C7
		// (set) Token: 0x06023899 RID: 145561 RVA: 0x009262DB File Offset: 0x009244DB
		public unsafe UStaticMeshComponent StaticMesh42
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_109);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_109, value);
			}
		}

		// Token: 0x170041F2 RID: 16882
		// (get) Token: 0x0602389A RID: 145562 RVA: 0x009262F0 File Offset: 0x009244F0
		// (set) Token: 0x0602389B RID: 145563 RVA: 0x00926304 File Offset: 0x00924504
		public unsafe UStaticMeshComponent StaticMesh41
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_110);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_110, value);
			}
		}

		// Token: 0x170041F3 RID: 16883
		// (get) Token: 0x0602389C RID: 145564 RVA: 0x00926319 File Offset: 0x00924519
		// (set) Token: 0x0602389D RID: 145565 RVA: 0x0092632D File Offset: 0x0092452D
		public unsafe UStaticMeshComponent StaticMesh40
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_111);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_111, value);
			}
		}

		// Token: 0x170041F4 RID: 16884
		// (get) Token: 0x0602389E RID: 145566 RVA: 0x00926342 File Offset: 0x00924542
		// (set) Token: 0x0602389F RID: 145567 RVA: 0x00926356 File Offset: 0x00924556
		public unsafe UStaticMeshComponent StaticMesh39
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_112);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_112, value);
			}
		}

		// Token: 0x170041F5 RID: 16885
		// (get) Token: 0x060238A0 RID: 145568 RVA: 0x0092636B File Offset: 0x0092456B
		// (set) Token: 0x060238A1 RID: 145569 RVA: 0x0092637F File Offset: 0x0092457F
		public unsafe UStaticMeshComponent StaticMesh38
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_113);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_113, value);
			}
		}

		// Token: 0x170041F6 RID: 16886
		// (get) Token: 0x060238A2 RID: 145570 RVA: 0x00926394 File Offset: 0x00924594
		// (set) Token: 0x060238A3 RID: 145571 RVA: 0x009263A8 File Offset: 0x009245A8
		public unsafe UStaticMeshComponent StaticMesh37
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_114);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_114, value);
			}
		}

		// Token: 0x170041F7 RID: 16887
		// (get) Token: 0x060238A4 RID: 145572 RVA: 0x009263BD File Offset: 0x009245BD
		// (set) Token: 0x060238A5 RID: 145573 RVA: 0x009263D1 File Offset: 0x009245D1
		public unsafe UStaticMeshComponent StaticMesh36
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_115);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_115, value);
			}
		}

		// Token: 0x170041F8 RID: 16888
		// (get) Token: 0x060238A6 RID: 145574 RVA: 0x009263E6 File Offset: 0x009245E6
		// (set) Token: 0x060238A7 RID: 145575 RVA: 0x009263FA File Offset: 0x009245FA
		public unsafe UStaticMeshComponent StaticMesh35
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_116);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_116, value);
			}
		}

		// Token: 0x170041F9 RID: 16889
		// (get) Token: 0x060238A8 RID: 145576 RVA: 0x0092640F File Offset: 0x0092460F
		// (set) Token: 0x060238A9 RID: 145577 RVA: 0x00926423 File Offset: 0x00924623
		public unsafe UStaticMeshComponent StaticMesh34
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_117);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_117, value);
			}
		}

		// Token: 0x170041FA RID: 16890
		// (get) Token: 0x060238AA RID: 145578 RVA: 0x00926438 File Offset: 0x00924638
		// (set) Token: 0x060238AB RID: 145579 RVA: 0x0092644C File Offset: 0x0092464C
		public unsafe UStaticMeshComponent StaticMesh33
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_118);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_118, value);
			}
		}

		// Token: 0x170041FB RID: 16891
		// (get) Token: 0x060238AC RID: 145580 RVA: 0x00926461 File Offset: 0x00924661
		// (set) Token: 0x060238AD RID: 145581 RVA: 0x00926475 File Offset: 0x00924675
		public unsafe UStaticMeshComponent StaticMesh32
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_119);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_119, value);
			}
		}

		// Token: 0x170041FC RID: 16892
		// (get) Token: 0x060238AE RID: 145582 RVA: 0x0092648A File Offset: 0x0092468A
		// (set) Token: 0x060238AF RID: 145583 RVA: 0x0092649E File Offset: 0x0092469E
		public unsafe UStaticMeshComponent StaticMesh31
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_120);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_120, value);
			}
		}

		// Token: 0x170041FD RID: 16893
		// (get) Token: 0x060238B0 RID: 145584 RVA: 0x009264B3 File Offset: 0x009246B3
		// (set) Token: 0x060238B1 RID: 145585 RVA: 0x009264C7 File Offset: 0x009246C7
		public unsafe UStaticMeshComponent StaticMesh30
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_121);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_121, value);
			}
		}

		// Token: 0x170041FE RID: 16894
		// (get) Token: 0x060238B2 RID: 145586 RVA: 0x009264DC File Offset: 0x009246DC
		// (set) Token: 0x060238B3 RID: 145587 RVA: 0x009264F0 File Offset: 0x009246F0
		public unsafe UStaticMeshComponent StaticMesh29
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_122);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_122, value);
			}
		}

		// Token: 0x170041FF RID: 16895
		// (get) Token: 0x060238B4 RID: 145588 RVA: 0x00926505 File Offset: 0x00924705
		// (set) Token: 0x060238B5 RID: 145589 RVA: 0x00926519 File Offset: 0x00924719
		public unsafe UStaticMeshComponent StaticMesh28
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_123);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_123, value);
			}
		}

		// Token: 0x17004200 RID: 16896
		// (get) Token: 0x060238B6 RID: 145590 RVA: 0x0092652E File Offset: 0x0092472E
		// (set) Token: 0x060238B7 RID: 145591 RVA: 0x00926542 File Offset: 0x00924742
		public unsafe UStaticMeshComponent StaticMesh27
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_124);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_124, value);
			}
		}

		// Token: 0x17004201 RID: 16897
		// (get) Token: 0x060238B8 RID: 145592 RVA: 0x00926557 File Offset: 0x00924757
		// (set) Token: 0x060238B9 RID: 145593 RVA: 0x0092656B File Offset: 0x0092476B
		public unsafe UStaticMeshComponent StaticMesh26
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_125);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_125, value);
			}
		}

		// Token: 0x17004202 RID: 16898
		// (get) Token: 0x060238BA RID: 145594 RVA: 0x00926580 File Offset: 0x00924780
		// (set) Token: 0x060238BB RID: 145595 RVA: 0x00926594 File Offset: 0x00924794
		public unsafe UStaticMeshComponent StaticMesh25
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_126);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_126, value);
			}
		}

		// Token: 0x17004203 RID: 16899
		// (get) Token: 0x060238BC RID: 145596 RVA: 0x009265A9 File Offset: 0x009247A9
		// (set) Token: 0x060238BD RID: 145597 RVA: 0x009265BD File Offset: 0x009247BD
		public unsafe UStaticMeshComponent StaticMesh24
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_127);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_127, value);
			}
		}

		// Token: 0x17004204 RID: 16900
		// (get) Token: 0x060238BE RID: 145598 RVA: 0x009265D2 File Offset: 0x009247D2
		// (set) Token: 0x060238BF RID: 145599 RVA: 0x009265E6 File Offset: 0x009247E6
		public unsafe UStaticMeshComponent StaticMesh23
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_128);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_128, value);
			}
		}

		// Token: 0x17004205 RID: 16901
		// (get) Token: 0x060238C0 RID: 145600 RVA: 0x009265FB File Offset: 0x009247FB
		// (set) Token: 0x060238C1 RID: 145601 RVA: 0x0092660F File Offset: 0x0092480F
		public unsafe UStaticMeshComponent StaticMesh22
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_129);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_129, value);
			}
		}

		// Token: 0x17004206 RID: 16902
		// (get) Token: 0x060238C2 RID: 145602 RVA: 0x00926624 File Offset: 0x00924824
		// (set) Token: 0x060238C3 RID: 145603 RVA: 0x00926638 File Offset: 0x00924838
		public unsafe UStaticMeshComponent StaticMesh21
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_130);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_130, value);
			}
		}

		// Token: 0x17004207 RID: 16903
		// (get) Token: 0x060238C4 RID: 145604 RVA: 0x0092664D File Offset: 0x0092484D
		// (set) Token: 0x060238C5 RID: 145605 RVA: 0x00926661 File Offset: 0x00924861
		public unsafe UStaticMeshComponent StaticMesh20
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_131);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_131, value);
			}
		}

		// Token: 0x17004208 RID: 16904
		// (get) Token: 0x060238C6 RID: 145606 RVA: 0x00926676 File Offset: 0x00924876
		// (set) Token: 0x060238C7 RID: 145607 RVA: 0x0092668A File Offset: 0x0092488A
		public unsafe UStaticMeshComponent StaticMesh19
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_132);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_132, value);
			}
		}

		// Token: 0x17004209 RID: 16905
		// (get) Token: 0x060238C8 RID: 145608 RVA: 0x0092669F File Offset: 0x0092489F
		// (set) Token: 0x060238C9 RID: 145609 RVA: 0x009266B3 File Offset: 0x009248B3
		public unsafe UStaticMeshComponent StaticMesh18
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_133);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_133, value);
			}
		}

		// Token: 0x1700420A RID: 16906
		// (get) Token: 0x060238CA RID: 145610 RVA: 0x009266C8 File Offset: 0x009248C8
		// (set) Token: 0x060238CB RID: 145611 RVA: 0x009266DC File Offset: 0x009248DC
		public unsafe UStaticMeshComponent StaticMesh17
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_134);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_134, value);
			}
		}

		// Token: 0x1700420B RID: 16907
		// (get) Token: 0x060238CC RID: 145612 RVA: 0x009266F1 File Offset: 0x009248F1
		// (set) Token: 0x060238CD RID: 145613 RVA: 0x00926705 File Offset: 0x00924905
		public unsafe UStaticMeshComponent StaticMesh16
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_135);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_135, value);
			}
		}

		// Token: 0x1700420C RID: 16908
		// (get) Token: 0x060238CE RID: 145614 RVA: 0x0092671A File Offset: 0x0092491A
		// (set) Token: 0x060238CF RID: 145615 RVA: 0x0092672E File Offset: 0x0092492E
		public unsafe UStaticMeshComponent StaticMesh15
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_136);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_136, value);
			}
		}

		// Token: 0x1700420D RID: 16909
		// (get) Token: 0x060238D0 RID: 145616 RVA: 0x00926743 File Offset: 0x00924943
		// (set) Token: 0x060238D1 RID: 145617 RVA: 0x00926757 File Offset: 0x00924957
		public unsafe UStaticMeshComponent StaticMesh14
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_137);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_137, value);
			}
		}

		// Token: 0x1700420E RID: 16910
		// (get) Token: 0x060238D2 RID: 145618 RVA: 0x0092676C File Offset: 0x0092496C
		// (set) Token: 0x060238D3 RID: 145619 RVA: 0x00926780 File Offset: 0x00924980
		public unsafe UStaticMeshComponent StaticMesh13
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_138);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_138, value);
			}
		}

		// Token: 0x1700420F RID: 16911
		// (get) Token: 0x060238D4 RID: 145620 RVA: 0x00926795 File Offset: 0x00924995
		// (set) Token: 0x060238D5 RID: 145621 RVA: 0x009267A9 File Offset: 0x009249A9
		public unsafe UStaticMeshComponent StaticMesh12
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_139);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_139, value);
			}
		}

		// Token: 0x17004210 RID: 16912
		// (get) Token: 0x060238D6 RID: 145622 RVA: 0x009267BE File Offset: 0x009249BE
		// (set) Token: 0x060238D7 RID: 145623 RVA: 0x009267D2 File Offset: 0x009249D2
		public unsafe UStaticMeshComponent StaticMesh11
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_140);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_140, value);
			}
		}

		// Token: 0x17004211 RID: 16913
		// (get) Token: 0x060238D8 RID: 145624 RVA: 0x009267E7 File Offset: 0x009249E7
		// (set) Token: 0x060238D9 RID: 145625 RVA: 0x009267FB File Offset: 0x009249FB
		public unsafe UStaticMeshComponent StaticMesh10
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_141);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_141, value);
			}
		}

		// Token: 0x17004212 RID: 16914
		// (get) Token: 0x060238DA RID: 145626 RVA: 0x00926810 File Offset: 0x00924A10
		// (set) Token: 0x060238DB RID: 145627 RVA: 0x00926824 File Offset: 0x00924A24
		public unsafe UStaticMeshComponent StaticMesh09
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_142);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_142, value);
			}
		}

		// Token: 0x17004213 RID: 16915
		// (get) Token: 0x060238DC RID: 145628 RVA: 0x00926839 File Offset: 0x00924A39
		// (set) Token: 0x060238DD RID: 145629 RVA: 0x0092684D File Offset: 0x00924A4D
		public unsafe UStaticMeshComponent StaticMesh08
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_143);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_143, value);
			}
		}

		// Token: 0x17004214 RID: 16916
		// (get) Token: 0x060238DE RID: 145630 RVA: 0x00926862 File Offset: 0x00924A62
		// (set) Token: 0x060238DF RID: 145631 RVA: 0x00926876 File Offset: 0x00924A76
		public unsafe UStaticMeshComponent StaticMesh07
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_144);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_144, value);
			}
		}

		// Token: 0x17004215 RID: 16917
		// (get) Token: 0x060238E0 RID: 145632 RVA: 0x0092688B File Offset: 0x00924A8B
		// (set) Token: 0x060238E1 RID: 145633 RVA: 0x0092689F File Offset: 0x00924A9F
		public unsafe UStaticMeshComponent StaticMesh06
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_145);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_145, value);
			}
		}

		// Token: 0x17004216 RID: 16918
		// (get) Token: 0x060238E2 RID: 145634 RVA: 0x009268B4 File Offset: 0x00924AB4
		// (set) Token: 0x060238E3 RID: 145635 RVA: 0x009268C8 File Offset: 0x00924AC8
		public unsafe UStaticMeshComponent StaticMesh05
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_146);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_146, value);
			}
		}

		// Token: 0x17004217 RID: 16919
		// (get) Token: 0x060238E4 RID: 145636 RVA: 0x009268DD File Offset: 0x00924ADD
		// (set) Token: 0x060238E5 RID: 145637 RVA: 0x009268F1 File Offset: 0x00924AF1
		public unsafe UStaticMeshComponent StaticMesh04
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_147);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_147, value);
			}
		}

		// Token: 0x17004218 RID: 16920
		// (get) Token: 0x060238E6 RID: 145638 RVA: 0x00926906 File Offset: 0x00924B06
		// (set) Token: 0x060238E7 RID: 145639 RVA: 0x0092691A File Offset: 0x00924B1A
		public unsafe UStaticMeshComponent StaticMesh03
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_148);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_148, value);
			}
		}

		// Token: 0x17004219 RID: 16921
		// (get) Token: 0x060238E8 RID: 145640 RVA: 0x0092692F File Offset: 0x00924B2F
		// (set) Token: 0x060238E9 RID: 145641 RVA: 0x00926943 File Offset: 0x00924B43
		public unsafe UStaticMeshComponent StaticMesh02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_149);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_149, value);
			}
		}

		// Token: 0x1700421A RID: 16922
		// (get) Token: 0x060238EA RID: 145642 RVA: 0x00926958 File Offset: 0x00924B58
		// (set) Token: 0x060238EB RID: 145643 RVA: 0x0092696C File Offset: 0x00924B6C
		public unsafe UStaticMeshComponent StaticMesh01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_150);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_150, value);
			}
		}

		// Token: 0x1700421B RID: 16923
		// (get) Token: 0x060238EC RID: 145644 RVA: 0x00926981 File Offset: 0x00924B81
		// (set) Token: 0x060238ED RID: 145645 RVA: 0x00926995 File Offset: 0x00924B95
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_151);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_3_5_C.__PropertyOffset_151, value);
			}
		}

		// Token: 0x1700421C RID: 16924
		// (get) Token: 0x060238EE RID: 145646 RVA: 0x009269AC File Offset: 0x00924BAC
		// (set) Token: 0x060238EF RID: 145647 RVA: 0x009269E5 File Offset: 0x00924BE5
		[Nullable(1)]
		public custom custom
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				custom result;
				if ((result = this._custom) == null)
				{
					result = (this._custom = new custom(base.NativePtr + (IntPtr)BP_BridgeModels_3_5_C.__PropertyOffset_152, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_BridgeModels_3_5_C.__PropertyOffset_152, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700421D RID: 16925
		// (get) Token: 0x060238F0 RID: 145648 RVA: 0x00926A06 File Offset: 0x00924C06
		// (set) Token: 0x060238F1 RID: 145649 RVA: 0x00926A1A File Offset: 0x00924C1A
		public unsafe FVector NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BridgeModels_3_5_C.__PropertyOffset_153);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BridgeModels_3_5_C.__PropertyOffset_153) = value;
			}
		}

		// Token: 0x1700421E RID: 16926
		// (get) Token: 0x060238F2 RID: 145650 RVA: 0x00926A30 File Offset: 0x00924C30
		// (set) Token: 0x060238F3 RID: 145651 RVA: 0x00926A69 File Offset: 0x00924C69
		[Nullable(1)]
		public TArray<UStaticMeshComponent> BlockList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._BlockList) == null)
				{
					result = (this._BlockList = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_BridgeModels_3_5_C.__PropertyOffset_154, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BlockList.CopyAssign(value);
			}
		}

		// Token: 0x1700421F RID: 16927
		// (get) Token: 0x060238F4 RID: 145652 RVA: 0x00926A78 File Offset: 0x00924C78
		// (set) Token: 0x060238F5 RID: 145653 RVA: 0x00926AB1 File Offset: 0x00924CB1
		[Nullable(1)]
		public TArray<UChildActorComponent> PinArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UChildActorComponent> result;
				if ((result = this._PinArray) == null)
				{
					result = (this._PinArray = new TArray<UChildActorComponent>(base.NativePtr + (IntPtr)BP_BridgeModels_3_5_C.__PropertyOffset_155, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PinArray.CopyAssign(value);
			}
		}

		// Token: 0x060238F6 RID: 145654 RVA: 0x00926AC0 File Offset: 0x00924CC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPlankVisible(bool IsInRange)
		{
			BP_BridgeModels_3_5_C.__SetPlankVisible_FunctionParams* ptr = stackalloc BP_BridgeModels_3_5_C.__SetPlankVisible_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_BridgeModels_3_5_C.__SetPlankVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_3_5_C.__SetPlankVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsInRange = IsInRange;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_3_5_C.__SetPlankVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060238F7 RID: 145655 RVA: 0x00926B06 File Offset: 0x00924D06
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RecoverBlock()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_3_5_C.__RecoverBlock_NativeFunctionPtr, null);
		}

		// Token: 0x060238F8 RID: 145656 RVA: 0x00926B1C File Offset: 0x00924D1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetSideBlockColli(bool IsBreak)
		{
			BP_BridgeModels_3_5_C.__SetSideBlockColli_FunctionParams* ptr = stackalloc BP_BridgeModels_3_5_C.__SetSideBlockColli_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BridgeModels_3_5_C.__SetSideBlockColli_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_3_5_C.__SetSideBlockColli_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsBreak = IsBreak;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_3_5_C.__SetSideBlockColli_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060238F9 RID: 145657 RVA: 0x00926B64 File Offset: 0x00924D64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetBridgeLink(int idx, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UChildActorComponent> tempArray1)
		{
			BP_BridgeModels_3_5_C.__GetBridgeLink_FunctionParams* ptr = stackalloc BP_BridgeModels_3_5_C.__GetBridgeLink_FunctionParams[(UIntPtr)287] + 15L / (long)sizeof(BP_BridgeModels_3_5_C.__GetBridgeLink_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_3_5_C.__GetBridgeLink_NativeFunctionPtr, (void*)ptr, 1);
			ptr->idx = idx;
			TArray<UChildActorComponent> tarray = tempArray1;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->tempArray1);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_3_5_C.__GetBridgeLink_NativeFunctionPtr, (void*)ptr);
			TArray<UChildActorComponent> tarray2 = tempArray1;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->tempArray1);
			}
			UnrealReflectionUtils.DestroyStruct(BP_BridgeModels_3_5_C.__GetBridgeLink_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060238FA RID: 145658 RVA: 0x00926BE6 File Offset: 0x00924DE6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_3_5_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060238FB RID: 145659 RVA: 0x00926BFA File Offset: 0x00924DFA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BridgeModels_3_5_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060238FC RID: 145660 RVA: 0x00926C0F File Offset: 0x00924E0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_3_5_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060238FD RID: 145661 RVA: 0x00926C23 File Offset: 0x00924E23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BridgeModels_3_5_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060238FE RID: 145662 RVA: 0x00926C38 File Offset: 0x00924E38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_0_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_BridgeModels_3_5_C.__BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_0_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BridgeModels_3_5_C.__BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_0_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BridgeModels_3_5_C.__BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_0_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_3_5_C.__BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_0_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_3_5_C.__BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_0_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060238FF RID: 145663 RVA: 0x00926CC4 File Offset: 0x00924EC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_BridgeModels_3_5_C.__BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BridgeModels_3_5_C.__BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_BridgeModels_3_5_C.__BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_3_5_C.__BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_3_5_C.__BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023900 RID: 145664 RVA: 0x00926D7E File Offset: 0x00924F7E
		protected BP_BridgeModels_3_5_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011847 RID: 71751
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_3_5.BP_BridgeModels_3_5_C";

		// Token: 0x04011848 RID: 71752
		private static IntPtr _ClassPtr;

		// Token: 0x04011849 RID: 71753
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401184A RID: 71754
		public static IntPtr __custom__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401184B RID: 71755
		internal static int __PropertyOffset_1;

		// Token: 0x0401184C RID: 71756
		internal static int __PropertyOffset_2;

		// Token: 0x0401184D RID: 71757
		internal static int __PropertyOffset_3;

		// Token: 0x0401184E RID: 71758
		internal static int __PropertyOffset_4;

		// Token: 0x0401184F RID: 71759
		internal static int __PropertyOffset_5;

		// Token: 0x04011850 RID: 71760
		internal static int __PropertyOffset_6;

		// Token: 0x04011851 RID: 71761
		internal static int __PropertyOffset_7;

		// Token: 0x04011852 RID: 71762
		internal static int __PropertyOffset_8;

		// Token: 0x04011853 RID: 71763
		internal static int __PropertyOffset_9;

		// Token: 0x04011854 RID: 71764
		internal static int __PropertyOffset_10;

		// Token: 0x04011855 RID: 71765
		internal static int __PropertyOffset_11;

		// Token: 0x04011856 RID: 71766
		internal static int __PropertyOffset_12;

		// Token: 0x04011857 RID: 71767
		internal static int __PropertyOffset_13;

		// Token: 0x04011858 RID: 71768
		internal static int __PropertyOffset_14;

		// Token: 0x04011859 RID: 71769
		internal static int __PropertyOffset_15;

		// Token: 0x0401185A RID: 71770
		internal static int __PropertyOffset_16;

		// Token: 0x0401185B RID: 71771
		internal static int __PropertyOffset_17;

		// Token: 0x0401185C RID: 71772
		internal static int __PropertyOffset_18;

		// Token: 0x0401185D RID: 71773
		internal static int __PropertyOffset_19;

		// Token: 0x0401185E RID: 71774
		internal static int __PropertyOffset_20;

		// Token: 0x0401185F RID: 71775
		internal static int __PropertyOffset_21;

		// Token: 0x04011860 RID: 71776
		internal static int __PropertyOffset_22;

		// Token: 0x04011861 RID: 71777
		internal static int __PropertyOffset_23;

		// Token: 0x04011862 RID: 71778
		internal static int __PropertyOffset_24;

		// Token: 0x04011863 RID: 71779
		internal static int __PropertyOffset_25;

		// Token: 0x04011864 RID: 71780
		internal static int __PropertyOffset_26;

		// Token: 0x04011865 RID: 71781
		internal static int __PropertyOffset_27;

		// Token: 0x04011866 RID: 71782
		internal static int __PropertyOffset_28;

		// Token: 0x04011867 RID: 71783
		internal static int __PropertyOffset_29;

		// Token: 0x04011868 RID: 71784
		internal static int __PropertyOffset_30;

		// Token: 0x04011869 RID: 71785
		internal static int __PropertyOffset_31;

		// Token: 0x0401186A RID: 71786
		internal static int __PropertyOffset_32;

		// Token: 0x0401186B RID: 71787
		internal static int __PropertyOffset_33;

		// Token: 0x0401186C RID: 71788
		internal static int __PropertyOffset_34;

		// Token: 0x0401186D RID: 71789
		internal static int __PropertyOffset_35;

		// Token: 0x0401186E RID: 71790
		internal static int __PropertyOffset_36;

		// Token: 0x0401186F RID: 71791
		internal static int __PropertyOffset_37;

		// Token: 0x04011870 RID: 71792
		internal static int __PropertyOffset_38;

		// Token: 0x04011871 RID: 71793
		internal static int __PropertyOffset_39;

		// Token: 0x04011872 RID: 71794
		internal static int __PropertyOffset_40;

		// Token: 0x04011873 RID: 71795
		internal static int __PropertyOffset_41;

		// Token: 0x04011874 RID: 71796
		internal static int __PropertyOffset_42;

		// Token: 0x04011875 RID: 71797
		internal static int __PropertyOffset_43;

		// Token: 0x04011876 RID: 71798
		internal static int __PropertyOffset_44;

		// Token: 0x04011877 RID: 71799
		internal static int __PropertyOffset_45;

		// Token: 0x04011878 RID: 71800
		internal static int __PropertyOffset_46;

		// Token: 0x04011879 RID: 71801
		internal static int __PropertyOffset_47;

		// Token: 0x0401187A RID: 71802
		internal static int __PropertyOffset_48;

		// Token: 0x0401187B RID: 71803
		internal static int __PropertyOffset_49;

		// Token: 0x0401187C RID: 71804
		internal static int __PropertyOffset_50;

		// Token: 0x0401187D RID: 71805
		internal static int __PropertyOffset_51;

		// Token: 0x0401187E RID: 71806
		internal static int __PropertyOffset_52;

		// Token: 0x0401187F RID: 71807
		internal static int __PropertyOffset_53;

		// Token: 0x04011880 RID: 71808
		internal static int __PropertyOffset_54;

		// Token: 0x04011881 RID: 71809
		internal static int __PropertyOffset_55;

		// Token: 0x04011882 RID: 71810
		internal static int __PropertyOffset_56;

		// Token: 0x04011883 RID: 71811
		internal static int __PropertyOffset_57;

		// Token: 0x04011884 RID: 71812
		internal static int __PropertyOffset_58;

		// Token: 0x04011885 RID: 71813
		internal static int __PropertyOffset_59;

		// Token: 0x04011886 RID: 71814
		internal static int __PropertyOffset_60;

		// Token: 0x04011887 RID: 71815
		internal static int __PropertyOffset_61;

		// Token: 0x04011888 RID: 71816
		internal static int __PropertyOffset_62;

		// Token: 0x04011889 RID: 71817
		internal static int __PropertyOffset_63;

		// Token: 0x0401188A RID: 71818
		internal static int __PropertyOffset_64;

		// Token: 0x0401188B RID: 71819
		internal static int __PropertyOffset_65;

		// Token: 0x0401188C RID: 71820
		internal static int __PropertyOffset_66;

		// Token: 0x0401188D RID: 71821
		internal static int __PropertyOffset_67;

		// Token: 0x0401188E RID: 71822
		internal static int __PropertyOffset_68;

		// Token: 0x0401188F RID: 71823
		internal static int __PropertyOffset_69;

		// Token: 0x04011890 RID: 71824
		internal static int __PropertyOffset_70;

		// Token: 0x04011891 RID: 71825
		internal static int __PropertyOffset_71;

		// Token: 0x04011892 RID: 71826
		internal static int __PropertyOffset_72;

		// Token: 0x04011893 RID: 71827
		internal static int __PropertyOffset_73;

		// Token: 0x04011894 RID: 71828
		internal static int __PropertyOffset_74;

		// Token: 0x04011895 RID: 71829
		internal static int __PropertyOffset_75;

		// Token: 0x04011896 RID: 71830
		internal static int __PropertyOffset_76;

		// Token: 0x04011897 RID: 71831
		internal static int __PropertyOffset_77;

		// Token: 0x04011898 RID: 71832
		internal static int __PropertyOffset_78;

		// Token: 0x04011899 RID: 71833
		internal static int __PropertyOffset_79;

		// Token: 0x0401189A RID: 71834
		internal static int __PropertyOffset_80;

		// Token: 0x0401189B RID: 71835
		internal static int __PropertyOffset_81;

		// Token: 0x0401189C RID: 71836
		internal static int __PropertyOffset_82;

		// Token: 0x0401189D RID: 71837
		internal static int __PropertyOffset_83;

		// Token: 0x0401189E RID: 71838
		internal static int __PropertyOffset_84;

		// Token: 0x0401189F RID: 71839
		internal static int __PropertyOffset_85;

		// Token: 0x040118A0 RID: 71840
		internal static int __PropertyOffset_86;

		// Token: 0x040118A1 RID: 71841
		internal static int __PropertyOffset_87;

		// Token: 0x040118A2 RID: 71842
		internal static int __PropertyOffset_88;

		// Token: 0x040118A3 RID: 71843
		internal static int __PropertyOffset_89;

		// Token: 0x040118A4 RID: 71844
		internal static int __PropertyOffset_90;

		// Token: 0x040118A5 RID: 71845
		internal static int __PropertyOffset_91;

		// Token: 0x040118A6 RID: 71846
		internal static int __PropertyOffset_92;

		// Token: 0x040118A7 RID: 71847
		internal static int __PropertyOffset_93;

		// Token: 0x040118A8 RID: 71848
		internal static int __PropertyOffset_94;

		// Token: 0x040118A9 RID: 71849
		internal static int __PropertyOffset_95;

		// Token: 0x040118AA RID: 71850
		internal static int __PropertyOffset_96;

		// Token: 0x040118AB RID: 71851
		internal static int __PropertyOffset_97;

		// Token: 0x040118AC RID: 71852
		internal static int __PropertyOffset_98;

		// Token: 0x040118AD RID: 71853
		internal static int __PropertyOffset_99;

		// Token: 0x040118AE RID: 71854
		internal static int __PropertyOffset_100;

		// Token: 0x040118AF RID: 71855
		internal static int __PropertyOffset_101;

		// Token: 0x040118B0 RID: 71856
		internal static int __PropertyOffset_102;

		// Token: 0x040118B1 RID: 71857
		internal static int __PropertyOffset_103;

		// Token: 0x040118B2 RID: 71858
		internal static int __PropertyOffset_104;

		// Token: 0x040118B3 RID: 71859
		internal static int __PropertyOffset_105;

		// Token: 0x040118B4 RID: 71860
		internal static int __PropertyOffset_106;

		// Token: 0x040118B5 RID: 71861
		internal static int __PropertyOffset_107;

		// Token: 0x040118B6 RID: 71862
		internal static int __PropertyOffset_108;

		// Token: 0x040118B7 RID: 71863
		internal static int __PropertyOffset_109;

		// Token: 0x040118B8 RID: 71864
		internal static int __PropertyOffset_110;

		// Token: 0x040118B9 RID: 71865
		internal static int __PropertyOffset_111;

		// Token: 0x040118BA RID: 71866
		internal static int __PropertyOffset_112;

		// Token: 0x040118BB RID: 71867
		internal static int __PropertyOffset_113;

		// Token: 0x040118BC RID: 71868
		internal static int __PropertyOffset_114;

		// Token: 0x040118BD RID: 71869
		internal static int __PropertyOffset_115;

		// Token: 0x040118BE RID: 71870
		internal static int __PropertyOffset_116;

		// Token: 0x040118BF RID: 71871
		internal static int __PropertyOffset_117;

		// Token: 0x040118C0 RID: 71872
		internal static int __PropertyOffset_118;

		// Token: 0x040118C1 RID: 71873
		internal static int __PropertyOffset_119;

		// Token: 0x040118C2 RID: 71874
		internal static int __PropertyOffset_120;

		// Token: 0x040118C3 RID: 71875
		internal static int __PropertyOffset_121;

		// Token: 0x040118C4 RID: 71876
		internal static int __PropertyOffset_122;

		// Token: 0x040118C5 RID: 71877
		internal static int __PropertyOffset_123;

		// Token: 0x040118C6 RID: 71878
		internal static int __PropertyOffset_124;

		// Token: 0x040118C7 RID: 71879
		internal static int __PropertyOffset_125;

		// Token: 0x040118C8 RID: 71880
		internal static int __PropertyOffset_126;

		// Token: 0x040118C9 RID: 71881
		internal static int __PropertyOffset_127;

		// Token: 0x040118CA RID: 71882
		internal static int __PropertyOffset_128;

		// Token: 0x040118CB RID: 71883
		internal static int __PropertyOffset_129;

		// Token: 0x040118CC RID: 71884
		internal static int __PropertyOffset_130;

		// Token: 0x040118CD RID: 71885
		internal static int __PropertyOffset_131;

		// Token: 0x040118CE RID: 71886
		internal static int __PropertyOffset_132;

		// Token: 0x040118CF RID: 71887
		internal static int __PropertyOffset_133;

		// Token: 0x040118D0 RID: 71888
		internal static int __PropertyOffset_134;

		// Token: 0x040118D1 RID: 71889
		internal static int __PropertyOffset_135;

		// Token: 0x040118D2 RID: 71890
		internal static int __PropertyOffset_136;

		// Token: 0x040118D3 RID: 71891
		internal static int __PropertyOffset_137;

		// Token: 0x040118D4 RID: 71892
		internal static int __PropertyOffset_138;

		// Token: 0x040118D5 RID: 71893
		internal static int __PropertyOffset_139;

		// Token: 0x040118D6 RID: 71894
		internal static int __PropertyOffset_140;

		// Token: 0x040118D7 RID: 71895
		internal static int __PropertyOffset_141;

		// Token: 0x040118D8 RID: 71896
		internal static int __PropertyOffset_142;

		// Token: 0x040118D9 RID: 71897
		internal static int __PropertyOffset_143;

		// Token: 0x040118DA RID: 71898
		internal static int __PropertyOffset_144;

		// Token: 0x040118DB RID: 71899
		internal static int __PropertyOffset_145;

		// Token: 0x040118DC RID: 71900
		internal static int __PropertyOffset_146;

		// Token: 0x040118DD RID: 71901
		internal static int __PropertyOffset_147;

		// Token: 0x040118DE RID: 71902
		internal static int __PropertyOffset_148;

		// Token: 0x040118DF RID: 71903
		internal static int __PropertyOffset_149;

		// Token: 0x040118E0 RID: 71904
		internal static int __PropertyOffset_150;

		// Token: 0x040118E1 RID: 71905
		internal static int __PropertyOffset_151;

		// Token: 0x040118E2 RID: 71906
		internal static int __PropertyOffset_152;

		// Token: 0x040118E3 RID: 71907
		private custom _custom;

		// Token: 0x040118E4 RID: 71908
		internal static int __PropertyOffset_153;

		// Token: 0x040118E5 RID: 71909
		internal static int __PropertyOffset_154;

		// Token: 0x040118E6 RID: 71910
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _BlockList;

		// Token: 0x040118E7 RID: 71911
		internal static int __PropertyOffset_155;

		// Token: 0x040118E8 RID: 71912
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UChildActorComponent> _PinArray;

		// Token: 0x040118E9 RID: 71913
		private static IntPtr __SetPlankVisible_NativeFunctionPtr;

		// Token: 0x040118EA RID: 71914
		private static IntPtr __RecoverBlock_NativeFunctionPtr;

		// Token: 0x040118EB RID: 71915
		private static IntPtr __SetSideBlockColli_NativeFunctionPtr;

		// Token: 0x040118EC RID: 71916
		private static IntPtr __GetBridgeLink_NativeFunctionPtr;

		// Token: 0x040118ED RID: 71917
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040118EE RID: 71918
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040118EF RID: 71919
		private static IntPtr __BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_0_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040118F0 RID: 71920
		private static IntPtr __BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009E72 RID: 40562
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __SetPlankVisible_FunctionParams
		{
			// Token: 0x040316FE RID: 202494
			[FieldOffset(0)]
			public bool IsInRange;
		}

		// Token: 0x02009E73 RID: 40563
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetSideBlockColli_FunctionParams
		{
			// Token: 0x040316FF RID: 202495
			[FieldOffset(0)]
			public bool IsBreak;
		}

		// Token: 0x02009E74 RID: 40564
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 272)]
		protected ref struct __GetBridgeLink_FunctionParams
		{
			// Token: 0x04031700 RID: 202496
			[FieldOffset(0)]
			public int idx;

			// Token: 0x04031701 RID: 202497
			[FieldOffset(8)]
			public byte tempArray1;
		}

		// Token: 0x02009E75 RID: 40565
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_0_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031702 RID: 202498
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031703 RID: 202499
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031704 RID: 202500
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031705 RID: 202501
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009E76 RID: 40566
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_BridgeModels_3_5_LODRangeBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031706 RID: 202502
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031707 RID: 202503
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031708 RID: 202504
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031709 RID: 202505
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403170A RID: 202506
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403170B RID: 202507
			[FieldOffset(32)]
			public byte SweepResult;
		}
	}
}
