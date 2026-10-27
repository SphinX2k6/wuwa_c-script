using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.Piano
{
	// Token: 0x02003B66 RID: 15206
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_DecorativePiano.BP_DecorativePiano_C")]
	[UnrealStructLayout(1832, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1825)]
	public class BP_DecorativePiano_C : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021C32 RID: 138290 RVA: 0x008F52A2 File Offset: 0x008F34A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DecorativePiano_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_DecorativePiano.BP_DecorativePiano_C");
			}
			return BP_DecorativePiano_C._ClassPtr;
		}

		// Token: 0x06021C33 RID: 138291 RVA: 0x008F52C8 File Offset: 0x008F34C8
		public BP_DecorativePiano_C() : this(BuiltinUtils.AllocNativeUObject(BP_DecorativePiano_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021C34 RID: 138292 RVA: 0x008F52F0 File Offset: 0x008F34F0
		[NullableContext(1)]
		public BP_DecorativePiano_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DecorativePiano_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x06021C35 RID: 138293 RVA: 0x008F5323 File Offset: 0x008F3523
		// (set) Token: 0x06021C36 RID: 138294 RVA: 0x008F5337 File Offset: 0x008F3537
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700382A RID: 14378
		// (get) Token: 0x06021C37 RID: 138295 RVA: 0x008F534C File Offset: 0x008F354C
		// (set) Token: 0x06021C38 RID: 138296 RVA: 0x008F5360 File Offset: 0x008F3560
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x06021C39 RID: 138297 RVA: 0x008F5375 File Offset: 0x008F3575
		// (set) Token: 0x06021C3A RID: 138298 RVA: 0x008F5389 File Offset: 0x008F3589
		public unsafe UChildActorComponent Key_C4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x06021C3B RID: 138299 RVA: 0x008F539E File Offset: 0x008F359E
		// (set) Token: 0x06021C3C RID: 138300 RVA: 0x008F53B2 File Offset: 0x008F35B2
		public unsafe USceneComponent Group3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x06021C3D RID: 138301 RVA: 0x008F53C7 File Offset: 0x008F35C7
		// (set) Token: 0x06021C3E RID: 138302 RVA: 0x008F53DB File Offset: 0x008F35DB
		public unsafe USceneComponent Group2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x06021C3F RID: 138303 RVA: 0x008F53F0 File Offset: 0x008F35F0
		// (set) Token: 0x06021C40 RID: 138304 RVA: 0x008F5404 File Offset: 0x008F3604
		public unsafe USceneComponent Group1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x06021C41 RID: 138305 RVA: 0x008F5419 File Offset: 0x008F3619
		// (set) Token: 0x06021C42 RID: 138306 RVA: 0x008F542D File Offset: 0x008F362D
		public unsafe UChildActorComponent Key_ASharp2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x06021C43 RID: 138307 RVA: 0x008F5442 File Offset: 0x008F3642
		// (set) Token: 0x06021C44 RID: 138308 RVA: 0x008F5456 File Offset: 0x008F3656
		public unsafe UChildActorComponent Key_A3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x06021C45 RID: 138309 RVA: 0x008F546B File Offset: 0x008F366B
		// (set) Token: 0x06021C46 RID: 138310 RVA: 0x008F547F File Offset: 0x008F367F
		public unsafe UChildActorComponent Key_GSharp2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x06021C47 RID: 138311 RVA: 0x008F5494 File Offset: 0x008F3694
		// (set) Token: 0x06021C48 RID: 138312 RVA: 0x008F54A8 File Offset: 0x008F36A8
		public unsafe UChildActorComponent Key_G3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x06021C49 RID: 138313 RVA: 0x008F54BD File Offset: 0x008F36BD
		// (set) Token: 0x06021C4A RID: 138314 RVA: 0x008F54D1 File Offset: 0x008F36D1
		public unsafe UChildActorComponent Key_FSharp2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x06021C4B RID: 138315 RVA: 0x008F54E6 File Offset: 0x008F36E6
		// (set) Token: 0x06021C4C RID: 138316 RVA: 0x008F54FA File Offset: 0x008F36FA
		public unsafe UChildActorComponent Key_F3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x06021C4D RID: 138317 RVA: 0x008F550F File Offset: 0x008F370F
		// (set) Token: 0x06021C4E RID: 138318 RVA: 0x008F5523 File Offset: 0x008F3723
		public unsafe UChildActorComponent Key_E3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x06021C4F RID: 138319 RVA: 0x008F5538 File Offset: 0x008F3738
		// (set) Token: 0x06021C50 RID: 138320 RVA: 0x008F554C File Offset: 0x008F374C
		public unsafe UChildActorComponent Key_DSharp2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x06021C51 RID: 138321 RVA: 0x008F5561 File Offset: 0x008F3761
		// (set) Token: 0x06021C52 RID: 138322 RVA: 0x008F5575 File Offset: 0x008F3775
		public unsafe UChildActorComponent Key_D3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x06021C53 RID: 138323 RVA: 0x008F558A File Offset: 0x008F378A
		// (set) Token: 0x06021C54 RID: 138324 RVA: 0x008F559E File Offset: 0x008F379E
		public unsafe UChildActorComponent Key_CSharp2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x06021C55 RID: 138325 RVA: 0x008F55B3 File Offset: 0x008F37B3
		// (set) Token: 0x06021C56 RID: 138326 RVA: 0x008F55C7 File Offset: 0x008F37C7
		public unsafe UChildActorComponent Key_B3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x06021C57 RID: 138327 RVA: 0x008F55DC File Offset: 0x008F37DC
		// (set) Token: 0x06021C58 RID: 138328 RVA: 0x008F55F0 File Offset: 0x008F37F0
		public unsafe UChildActorComponent Key_C3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x06021C59 RID: 138329 RVA: 0x008F5605 File Offset: 0x008F3805
		// (set) Token: 0x06021C5A RID: 138330 RVA: 0x008F5619 File Offset: 0x008F3819
		public unsafe UChildActorComponent Key_ASharp1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x06021C5B RID: 138331 RVA: 0x008F562E File Offset: 0x008F382E
		// (set) Token: 0x06021C5C RID: 138332 RVA: 0x008F5642 File Offset: 0x008F3842
		public unsafe UChildActorComponent Key_A2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x06021C5D RID: 138333 RVA: 0x008F5657 File Offset: 0x008F3857
		// (set) Token: 0x06021C5E RID: 138334 RVA: 0x008F566B File Offset: 0x008F386B
		public unsafe UChildActorComponent Key_GSharp1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x06021C5F RID: 138335 RVA: 0x008F5680 File Offset: 0x008F3880
		// (set) Token: 0x06021C60 RID: 138336 RVA: 0x008F5694 File Offset: 0x008F3894
		public unsafe UChildActorComponent Key_CSharp1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x06021C61 RID: 138337 RVA: 0x008F56A9 File Offset: 0x008F38A9
		// (set) Token: 0x06021C62 RID: 138338 RVA: 0x008F56BD File Offset: 0x008F38BD
		public unsafe UChildActorComponent Key_FSharp1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x06021C63 RID: 138339 RVA: 0x008F56D2 File Offset: 0x008F38D2
		// (set) Token: 0x06021C64 RID: 138340 RVA: 0x008F56E6 File Offset: 0x008F38E6
		public unsafe UChildActorComponent Key_B2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x06021C65 RID: 138341 RVA: 0x008F56FB File Offset: 0x008F38FB
		// (set) Token: 0x06021C66 RID: 138342 RVA: 0x008F570F File Offset: 0x008F390F
		public unsafe UChildActorComponent Key_E2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x06021C67 RID: 138343 RVA: 0x008F5724 File Offset: 0x008F3924
		// (set) Token: 0x06021C68 RID: 138344 RVA: 0x008F5738 File Offset: 0x008F3938
		public unsafe UChildActorComponent Key_DSharp1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x06021C69 RID: 138345 RVA: 0x008F574D File Offset: 0x008F394D
		// (set) Token: 0x06021C6A RID: 138346 RVA: 0x008F5761 File Offset: 0x008F3961
		public unsafe UChildActorComponent Key_D2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x06021C6B RID: 138347 RVA: 0x008F5776 File Offset: 0x008F3976
		// (set) Token: 0x06021C6C RID: 138348 RVA: 0x008F578A File Offset: 0x008F398A
		public unsafe UChildActorComponent Key_G2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x06021C6D RID: 138349 RVA: 0x008F579F File Offset: 0x008F399F
		// (set) Token: 0x06021C6E RID: 138350 RVA: 0x008F57B3 File Offset: 0x008F39B3
		public unsafe UChildActorComponent Key_C2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x06021C6F RID: 138351 RVA: 0x008F57C8 File Offset: 0x008F39C8
		// (set) Token: 0x06021C70 RID: 138352 RVA: 0x008F57DC File Offset: 0x008F39DC
		public unsafe UChildActorComponent Key_F2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x06021C71 RID: 138353 RVA: 0x008F57F1 File Offset: 0x008F39F1
		// (set) Token: 0x06021C72 RID: 138354 RVA: 0x008F5805 File Offset: 0x008F3A05
		public unsafe UChildActorComponent Key_B1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x06021C73 RID: 138355 RVA: 0x008F581A File Offset: 0x008F3A1A
		// (set) Token: 0x06021C74 RID: 138356 RVA: 0x008F582E File Offset: 0x008F3A2E
		public unsafe UChildActorComponent Key_ASharp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x06021C75 RID: 138357 RVA: 0x008F5843 File Offset: 0x008F3A43
		// (set) Token: 0x06021C76 RID: 138358 RVA: 0x008F5857 File Offset: 0x008F3A57
		public unsafe UChildActorComponent Key_A1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x06021C77 RID: 138359 RVA: 0x008F586C File Offset: 0x008F3A6C
		// (set) Token: 0x06021C78 RID: 138360 RVA: 0x008F5880 File Offset: 0x008F3A80
		public unsafe UChildActorComponent Key_GSharp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x06021C79 RID: 138361 RVA: 0x008F5895 File Offset: 0x008F3A95
		// (set) Token: 0x06021C7A RID: 138362 RVA: 0x008F58A9 File Offset: 0x008F3AA9
		public unsafe UChildActorComponent Key_G1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x06021C7B RID: 138363 RVA: 0x008F58BE File Offset: 0x008F3ABE
		// (set) Token: 0x06021C7C RID: 138364 RVA: 0x008F58D2 File Offset: 0x008F3AD2
		public unsafe UChildActorComponent Key_C1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x06021C7D RID: 138365 RVA: 0x008F58E7 File Offset: 0x008F3AE7
		// (set) Token: 0x06021C7E RID: 138366 RVA: 0x008F58FB File Offset: 0x008F3AFB
		public unsafe UChildActorComponent Key_F1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x06021C7F RID: 138367 RVA: 0x008F5910 File Offset: 0x008F3B10
		// (set) Token: 0x06021C80 RID: 138368 RVA: 0x008F5924 File Offset: 0x008F3B24
		public unsafe UChildActorComponent Key_E1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x06021C81 RID: 138369 RVA: 0x008F5939 File Offset: 0x008F3B39
		// (set) Token: 0x06021C82 RID: 138370 RVA: 0x008F594D File Offset: 0x008F3B4D
		public unsafe UChildActorComponent Key_DSharp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x06021C83 RID: 138371 RVA: 0x008F5962 File Offset: 0x008F3B62
		// (set) Token: 0x06021C84 RID: 138372 RVA: 0x008F5976 File Offset: 0x008F3B76
		public unsafe UChildActorComponent Key_D1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_40);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_40, value);
			}
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x06021C85 RID: 138373 RVA: 0x008F598B File Offset: 0x008F3B8B
		// (set) Token: 0x06021C86 RID: 138374 RVA: 0x008F599F File Offset: 0x008F3B9F
		public unsafe UChildActorComponent Key_CSharp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_41);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_41, value);
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x06021C87 RID: 138375 RVA: 0x008F59B4 File Offset: 0x008F3BB4
		// (set) Token: 0x06021C88 RID: 138376 RVA: 0x008F59C8 File Offset: 0x008F3BC8
		public unsafe UChildActorComponent Key_FSharp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_42);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_42, value);
			}
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x06021C89 RID: 138377 RVA: 0x008F59DD File Offset: 0x008F3BDD
		// (set) Token: 0x06021C8A RID: 138378 RVA: 0x008F59F1 File Offset: 0x008F3BF1
		public unsafe USceneComponent Key
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_43);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_43, value);
			}
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x06021C8B RID: 138379 RVA: 0x008F5A08 File Offset: 0x008F3C08
		// (set) Token: 0x06021C8C RID: 138380 RVA: 0x008F5A41 File Offset: 0x008F3C41
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
					result = (this._BPKeyArray = new TArray<BP_PianoKey_C>(base.NativePtr + (IntPtr)BP_DecorativePiano_C.__PropertyOffset_44, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BPKeyArray.CopyAssign(value);
			}
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x06021C8D RID: 138381 RVA: 0x008F5A50 File Offset: 0x008F3C50
		// (set) Token: 0x06021C8E RID: 138382 RVA: 0x008F5A89 File Offset: 0x008F3C89
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
					result = (this._MoveNote = new MoveNote(base.NativePtr + (IntPtr)BP_DecorativePiano_C.__PropertyOffset_45, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_DecorativePiano_C.__PropertyOffset_45, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x06021C8F RID: 138383 RVA: 0x008F5AAA File Offset: 0x008F3CAA
		// (set) Token: 0x06021C90 RID: 138384 RVA: 0x008F5ABE File Offset: 0x008F3CBE
		public unsafe UAkAudioEvent WwiseEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DecorativePiano_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x06021C91 RID: 138385 RVA: 0x008F5AD3 File Offset: 0x008F3CD3
		// (set) Token: 0x06021C92 RID: 138386 RVA: 0x008F5AE3 File Offset: 0x008F3CE3
		public unsafe byte MIDIStartIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DecorativePiano_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DecorativePiano_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x06021C93 RID: 138387 RVA: 0x008F5AF4 File Offset: 0x008F3CF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitKeyRefArray()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DecorativePiano_C.__InitKeyRefArray_NativeFunctionPtr, null);
		}

		// Token: 0x06021C94 RID: 138388 RVA: 0x008F5B08 File Offset: 0x008F3D08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PlayAudio(PianoKeyEnum KeyType)
		{
			BP_DecorativePiano_C.__PlayAudio_FunctionParams* ptr = stackalloc BP_DecorativePiano_C.__PlayAudio_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_DecorativePiano_C.__PlayAudio_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DecorativePiano_C.__PlayAudio_NativeFunctionPtr, (void*)ptr, 1);
			ptr->KeyType = KeyType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DecorativePiano_C.__PlayAudio_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C95 RID: 138389 RVA: 0x008F5B53 File Offset: 0x008F3D53
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DecorativePiano_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021C96 RID: 138390 RVA: 0x008F5B67 File Offset: 0x008F3D67
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DecorativePiano_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021C97 RID: 138391 RVA: 0x008F5B7C File Offset: 0x008F3D7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DecorativePiano_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DecorativePiano_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DecorativePiano_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DecorativePiano_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DecorativePiano_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C98 RID: 138392 RVA: 0x008F5BC4 File Offset: 0x008F3DC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DecorativePiano_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DecorativePiano_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DecorativePiano_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DecorativePiano_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DecorativePiano_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021C99 RID: 138393 RVA: 0x008F5C0C File Offset: 0x008F3E0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CustomEvent_0(bool Overlap, PianoKeyEnum KeyType)
		{
			BP_DecorativePiano_C.__CustomEvent_0_FunctionParams* ptr = stackalloc BP_DecorativePiano_C.__CustomEvent_0_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_DecorativePiano_C.__CustomEvent_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DecorativePiano_C.__CustomEvent_0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Overlap = Overlap;
			ptr->KeyType = KeyType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DecorativePiano_C.__CustomEvent_0_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C9A RID: 138394 RVA: 0x008F5C60 File Offset: 0x008F3E60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_DecorativePiano_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_DecorativePiano_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_DecorativePiano_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DecorativePiano_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DecorativePiano_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C9B RID: 138395 RVA: 0x008F5CAC File Offset: 0x008F3EAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_DecorativePiano_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_DecorativePiano_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_DecorativePiano_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DecorativePiano_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DecorativePiano_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021C9C RID: 138396 RVA: 0x008F5CF8 File Offset: 0x008F3EF8
		protected BP_DecorativePiano_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040107AA RID: 67498
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_DecorativePiano.BP_DecorativePiano_C";

		// Token: 0x040107AB RID: 67499
		private static IntPtr _ClassPtr;

		// Token: 0x040107AC RID: 67500
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040107AD RID: 67501
		public static IntPtr __MoveNote__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040107AE RID: 67502
		internal static int __PropertyOffset_1;

		// Token: 0x040107AF RID: 67503
		internal static int __PropertyOffset_2;

		// Token: 0x040107B0 RID: 67504
		internal static int __PropertyOffset_3;

		// Token: 0x040107B1 RID: 67505
		internal static int __PropertyOffset_4;

		// Token: 0x040107B2 RID: 67506
		internal static int __PropertyOffset_5;

		// Token: 0x040107B3 RID: 67507
		internal static int __PropertyOffset_6;

		// Token: 0x040107B4 RID: 67508
		internal static int __PropertyOffset_7;

		// Token: 0x040107B5 RID: 67509
		internal static int __PropertyOffset_8;

		// Token: 0x040107B6 RID: 67510
		internal static int __PropertyOffset_9;

		// Token: 0x040107B7 RID: 67511
		internal static int __PropertyOffset_10;

		// Token: 0x040107B8 RID: 67512
		internal static int __PropertyOffset_11;

		// Token: 0x040107B9 RID: 67513
		internal static int __PropertyOffset_12;

		// Token: 0x040107BA RID: 67514
		internal static int __PropertyOffset_13;

		// Token: 0x040107BB RID: 67515
		internal static int __PropertyOffset_14;

		// Token: 0x040107BC RID: 67516
		internal static int __PropertyOffset_15;

		// Token: 0x040107BD RID: 67517
		internal static int __PropertyOffset_16;

		// Token: 0x040107BE RID: 67518
		internal static int __PropertyOffset_17;

		// Token: 0x040107BF RID: 67519
		internal static int __PropertyOffset_18;

		// Token: 0x040107C0 RID: 67520
		internal static int __PropertyOffset_19;

		// Token: 0x040107C1 RID: 67521
		internal static int __PropertyOffset_20;

		// Token: 0x040107C2 RID: 67522
		internal static int __PropertyOffset_21;

		// Token: 0x040107C3 RID: 67523
		internal static int __PropertyOffset_22;

		// Token: 0x040107C4 RID: 67524
		internal static int __PropertyOffset_23;

		// Token: 0x040107C5 RID: 67525
		internal static int __PropertyOffset_24;

		// Token: 0x040107C6 RID: 67526
		internal static int __PropertyOffset_25;

		// Token: 0x040107C7 RID: 67527
		internal static int __PropertyOffset_26;

		// Token: 0x040107C8 RID: 67528
		internal static int __PropertyOffset_27;

		// Token: 0x040107C9 RID: 67529
		internal static int __PropertyOffset_28;

		// Token: 0x040107CA RID: 67530
		internal static int __PropertyOffset_29;

		// Token: 0x040107CB RID: 67531
		internal static int __PropertyOffset_30;

		// Token: 0x040107CC RID: 67532
		internal static int __PropertyOffset_31;

		// Token: 0x040107CD RID: 67533
		internal static int __PropertyOffset_32;

		// Token: 0x040107CE RID: 67534
		internal static int __PropertyOffset_33;

		// Token: 0x040107CF RID: 67535
		internal static int __PropertyOffset_34;

		// Token: 0x040107D0 RID: 67536
		internal static int __PropertyOffset_35;

		// Token: 0x040107D1 RID: 67537
		internal static int __PropertyOffset_36;

		// Token: 0x040107D2 RID: 67538
		internal static int __PropertyOffset_37;

		// Token: 0x040107D3 RID: 67539
		internal static int __PropertyOffset_38;

		// Token: 0x040107D4 RID: 67540
		internal static int __PropertyOffset_39;

		// Token: 0x040107D5 RID: 67541
		internal static int __PropertyOffset_40;

		// Token: 0x040107D6 RID: 67542
		internal static int __PropertyOffset_41;

		// Token: 0x040107D7 RID: 67543
		internal static int __PropertyOffset_42;

		// Token: 0x040107D8 RID: 67544
		internal static int __PropertyOffset_43;

		// Token: 0x040107D9 RID: 67545
		internal static int __PropertyOffset_44;

		// Token: 0x040107DA RID: 67546
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_PianoKey_C> _BPKeyArray;

		// Token: 0x040107DB RID: 67547
		internal static int __PropertyOffset_45;

		// Token: 0x040107DC RID: 67548
		private MoveNote _MoveNote;

		// Token: 0x040107DD RID: 67549
		internal static int __PropertyOffset_46;

		// Token: 0x040107DE RID: 67550
		internal static int __PropertyOffset_47;

		// Token: 0x040107DF RID: 67551
		private static IntPtr __InitKeyRefArray_NativeFunctionPtr;

		// Token: 0x040107E0 RID: 67552
		private static IntPtr __PlayAudio_NativeFunctionPtr;

		// Token: 0x040107E1 RID: 67553
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040107E2 RID: 67554
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040107E3 RID: 67555
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x040107E4 RID: 67556
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009CCE RID: 40142
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __PlayAudio_FunctionParams
		{
			// Token: 0x040313B3 RID: 201651
			[FieldOffset(0)]
			public TEnumAsByte<PianoKeyEnum> KeyType;
		}

		// Token: 0x02009CCF RID: 40143
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040313B4 RID: 201652
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009CD0 RID: 40144
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __CustomEvent_0_FunctionParams
		{
			// Token: 0x040313B5 RID: 201653
			[FieldOffset(0)]
			public bool Overlap;

			// Token: 0x040313B6 RID: 201654
			[FieldOffset(1)]
			public TEnumAsByte<PianoKeyEnum> KeyType;
		}

		// Token: 0x02009CD1 RID: 40145
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040313B7 RID: 201655
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
