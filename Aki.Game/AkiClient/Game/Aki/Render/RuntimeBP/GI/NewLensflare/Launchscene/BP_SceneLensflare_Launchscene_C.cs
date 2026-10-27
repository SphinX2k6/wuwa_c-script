using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewLensflare.Launchscene
{
	// Token: 0x02003D4B RID: 15691
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewLensflare/Launchscene/BP_SceneLensflare_Launchscene.BP_SceneLensflare_Launchscene_C")]
	[UnrealStructLayout(1560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1560)]
	public class BP_SceneLensflare_Launchscene_C : ALensflareSamplerActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026334 RID: 156468 RVA: 0x0096DF97 File Offset: 0x0096C197
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneLensflare_Launchscene_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewLensflare/Launchscene/BP_SceneLensflare_Launchscene.BP_SceneLensflare_Launchscene_C");
			}
			return BP_SceneLensflare_Launchscene_C._ClassPtr;
		}

		// Token: 0x06026335 RID: 156469 RVA: 0x0096DFBC File Offset: 0x0096C1BC
		public BP_SceneLensflare_Launchscene_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneLensflare_Launchscene_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026336 RID: 156470 RVA: 0x0096DFE4 File Offset: 0x0096C1E4
		[NullableContext(1)]
		public BP_SceneLensflare_Launchscene_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneLensflare_Launchscene_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005112 RID: 20754
		// (get) Token: 0x06026337 RID: 156471 RVA: 0x0096E017 File Offset: 0x0096C217
		// (set) Token: 0x06026338 RID: 156472 RVA: 0x0096E027 File Offset: 0x0096C227
		public unsafe bool 自定义Ghost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005113 RID: 20755
		// (get) Token: 0x06026339 RID: 156473 RVA: 0x0096E038 File Offset: 0x0096C238
		// (set) Token: 0x0602633A RID: 156474 RVA: 0x0096E048 File Offset: 0x0096C248
		public unsafe float Ghost_大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005114 RID: 20756
		// (get) Token: 0x0602633B RID: 156475 RVA: 0x0096E059 File Offset: 0x0096C259
		// (set) Token: 0x0602633C RID: 156476 RVA: 0x0096E069 File Offset: 0x0096C269
		public unsafe float Ghost_分布偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005115 RID: 20757
		// (get) Token: 0x0602633D RID: 156477 RVA: 0x0096E07A File Offset: 0x0096C27A
		// (set) Token: 0x0602633E RID: 156478 RVA: 0x0096E08A File Offset: 0x0096C28A
		public unsafe float Ghost_分布范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005116 RID: 20758
		// (get) Token: 0x0602633F RID: 156479 RVA: 0x0096E09B File Offset: 0x0096C29B
		// (set) Token: 0x06026340 RID: 156480 RVA: 0x0096E0AF File Offset: 0x0096C2AF
		public unsafe FLinearColor Ghost_调色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005117 RID: 20759
		// (get) Token: 0x06026341 RID: 156481 RVA: 0x0096E0C4 File Offset: 0x0096C2C4
		// (set) Token: 0x06026342 RID: 156482 RVA: 0x0096E0D4 File Offset: 0x0096C2D4
		public unsafe float Ghost_不透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005118 RID: 20760
		// (get) Token: 0x06026343 RID: 156483 RVA: 0x0096E0E5 File Offset: 0x0096C2E5
		// (set) Token: 0x06026344 RID: 156484 RVA: 0x0096E0F5 File Offset: 0x0096C2F5
		public unsafe bool 自定义Halo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005119 RID: 20761
		// (get) Token: 0x06026345 RID: 156485 RVA: 0x0096E106 File Offset: 0x0096C306
		// (set) Token: 0x06026346 RID: 156486 RVA: 0x0096E116 File Offset: 0x0096C316
		public unsafe float Halo_圆环衰减
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700511A RID: 20762
		// (get) Token: 0x06026347 RID: 156487 RVA: 0x0096E127 File Offset: 0x0096C327
		// (set) Token: 0x06026348 RID: 156488 RVA: 0x0096E137 File Offset: 0x0096C337
		public unsafe float Halo_大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700511B RID: 20763
		// (get) Token: 0x06026349 RID: 156489 RVA: 0x0096E148 File Offset: 0x0096C348
		// (set) Token: 0x0602634A RID: 156490 RVA: 0x0096E158 File Offset: 0x0096C358
		public unsafe float Halo_分布偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700511C RID: 20764
		// (get) Token: 0x0602634B RID: 156491 RVA: 0x0096E169 File Offset: 0x0096C369
		// (set) Token: 0x0602634C RID: 156492 RVA: 0x0096E179 File Offset: 0x0096C379
		public unsafe float Halo_分布范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700511D RID: 20765
		// (get) Token: 0x0602634D RID: 156493 RVA: 0x0096E18A File Offset: 0x0096C38A
		// (set) Token: 0x0602634E RID: 156494 RVA: 0x0096E19E File Offset: 0x0096C39E
		public unsafe FLinearColor Halo_调色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700511E RID: 20766
		// (get) Token: 0x0602634F RID: 156495 RVA: 0x0096E1B3 File Offset: 0x0096C3B3
		// (set) Token: 0x06026350 RID: 156496 RVA: 0x0096E1C3 File Offset: 0x0096C3C3
		public unsafe float Halo_不透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700511F RID: 20767
		// (get) Token: 0x06026351 RID: 156497 RVA: 0x0096E1D4 File Offset: 0x0096C3D4
		// (set) Token: 0x06026352 RID: 156498 RVA: 0x0096E1E4 File Offset: 0x0096C3E4
		public unsafe bool 自定义Glare
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005120 RID: 20768
		// (get) Token: 0x06026353 RID: 156499 RVA: 0x0096E1F5 File Offset: 0x0096C3F5
		// (set) Token: 0x06026354 RID: 156500 RVA: 0x0096E209 File Offset: 0x0096C409
		public unsafe FVector2D Glare_大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005121 RID: 20769
		// (get) Token: 0x06026355 RID: 156501 RVA: 0x0096E21E File Offset: 0x0096C41E
		// (set) Token: 0x06026356 RID: 156502 RVA: 0x0096E232 File Offset: 0x0096C432
		public unsafe FLinearColor Glare_调色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005122 RID: 20770
		// (get) Token: 0x06026357 RID: 156503 RVA: 0x0096E247 File Offset: 0x0096C447
		// (set) Token: 0x06026358 RID: 156504 RVA: 0x0096E257 File Offset: 0x0096C457
		public unsafe float Glare_不透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005123 RID: 20771
		// (get) Token: 0x06026359 RID: 156505 RVA: 0x0096E268 File Offset: 0x0096C468
		// (set) Token: 0x0602635A RID: 156506 RVA: 0x0096E278 File Offset: 0x0096C478
		public unsafe float Glare_旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005124 RID: 20772
		// (get) Token: 0x0602635B RID: 156507 RVA: 0x0096E289 File Offset: 0x0096C489
		// (set) Token: 0x0602635C RID: 156508 RVA: 0x0096E299 File Offset: 0x0096C499
		public unsafe float Glare_锁定动态旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005125 RID: 20773
		// (get) Token: 0x0602635D RID: 156509 RVA: 0x0096E2AA File Offset: 0x0096C4AA
		// (set) Token: 0x0602635E RID: 156510 RVA: 0x0096E2BA File Offset: 0x0096C4BA
		public unsafe float Ghost_受背景色影响
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005126 RID: 20774
		// (get) Token: 0x0602635F RID: 156511 RVA: 0x0096E2CB File Offset: 0x0096C4CB
		// (set) Token: 0x06026360 RID: 156512 RVA: 0x0096E2DB File Offset: 0x0096C4DB
		public unsafe float Halo_受背景色影响
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005127 RID: 20775
		// (get) Token: 0x06026361 RID: 156513 RVA: 0x0096E2EC File Offset: 0x0096C4EC
		// (set) Token: 0x06026362 RID: 156514 RVA: 0x0096E2FC File Offset: 0x0096C4FC
		public unsafe float Glare_受背景色影响
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005128 RID: 20776
		// (get) Token: 0x06026363 RID: 156515 RVA: 0x0096E30D File Offset: 0x0096C50D
		// (set) Token: 0x06026364 RID: 156516 RVA: 0x0096E31D File Offset: 0x0096C51D
		public unsafe float Ghost_视角衰减速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005129 RID: 20777
		// (get) Token: 0x06026365 RID: 156517 RVA: 0x0096E32E File Offset: 0x0096C52E
		// (set) Token: 0x06026366 RID: 156518 RVA: 0x0096E33E File Offset: 0x0096C53E
		public unsafe float Halo_视角衰减速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x1700512A RID: 20778
		// (get) Token: 0x06026367 RID: 156519 RVA: 0x0096E34F File Offset: 0x0096C54F
		// (set) Token: 0x06026368 RID: 156520 RVA: 0x0096E35F File Offset: 0x0096C55F
		public unsafe float Glare_视角衰减速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x1700512B RID: 20779
		// (get) Token: 0x06026369 RID: 156521 RVA: 0x0096E370 File Offset: 0x0096C570
		// (set) Token: 0x0602636A RID: 156522 RVA: 0x0096E380 File Offset: 0x0096C580
		public unsafe bool 自定义Ghost贴图
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700512C RID: 20780
		// (get) Token: 0x0602636B RID: 156523 RVA: 0x0096E391 File Offset: 0x0096C591
		// (set) Token: 0x0602636C RID: 156524 RVA: 0x0096E3A5 File Offset: 0x0096C5A5
		public unsafe UTexture2D Ghost贴图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Launchscene_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Launchscene_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x1700512D RID: 20781
		// (get) Token: 0x0602636D RID: 156525 RVA: 0x0096E3BA File Offset: 0x0096C5BA
		// (set) Token: 0x0602636E RID: 156526 RVA: 0x0096E3CA File Offset: 0x0096C5CA
		public unsafe bool 自定义Halo贴图
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700512E RID: 20782
		// (get) Token: 0x0602636F RID: 156527 RVA: 0x0096E3DB File Offset: 0x0096C5DB
		// (set) Token: 0x06026370 RID: 156528 RVA: 0x0096E3EF File Offset: 0x0096C5EF
		public unsafe UTexture2D Halo贴图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Launchscene_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Launchscene_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x1700512F RID: 20783
		// (get) Token: 0x06026371 RID: 156529 RVA: 0x0096E404 File Offset: 0x0096C604
		// (set) Token: 0x06026372 RID: 156530 RVA: 0x0096E414 File Offset: 0x0096C614
		public unsafe bool 自定义Glare贴图
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005130 RID: 20784
		// (get) Token: 0x06026373 RID: 156531 RVA: 0x0096E425 File Offset: 0x0096C625
		// (set) Token: 0x06026374 RID: 156532 RVA: 0x0096E439 File Offset: 0x0096C639
		public unsafe UTexture2D Glare贴图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Launchscene_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Launchscene_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x17005131 RID: 20785
		// (get) Token: 0x06026375 RID: 156533 RVA: 0x0096E44E File Offset: 0x0096C64E
		// (set) Token: 0x06026376 RID: 156534 RVA: 0x0096E462 File Offset: 0x0096C662
		public unsafe FLinearColor Glare_UV缩放_偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Launchscene_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x06026377 RID: 156535 RVA: 0x0096E478 File Offset: 0x0096C678
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyDynamicMaterialGhost(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGhost_FunctionParams* ptr = stackalloc BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGhost_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGhost_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGhost_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGhost_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026378 RID: 156536 RVA: 0x0096E4D0 File Offset: 0x0096C6D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ApplyDynamicMaterialGhost_Implementation(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGhost_FunctionParams* ptr = stackalloc BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGhost_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGhost_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGhost_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGhost_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026379 RID: 156537 RVA: 0x0096E528 File Offset: 0x0096C728
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyDynamicMaterialHalo(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialHalo_FunctionParams* ptr = stackalloc BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialHalo_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialHalo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialHalo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialHalo_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602637A RID: 156538 RVA: 0x0096E580 File Offset: 0x0096C780
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ApplyDynamicMaterialHalo_Implementation(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialHalo_FunctionParams* ptr = stackalloc BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialHalo_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialHalo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialHalo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialHalo_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602637B RID: 156539 RVA: 0x0096E5D8 File Offset: 0x0096C7D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyDynamicMaterialGlare(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGlare_FunctionParams* ptr = stackalloc BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGlare_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGlare_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGlare_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGlare_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602637C RID: 156540 RVA: 0x0096E630 File Offset: 0x0096C830
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ApplyDynamicMaterialGlare_Implementation(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGlare_FunctionParams* ptr = stackalloc BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGlare_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGlare_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGlare_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_Launchscene_C.__ApplyDynamicMaterialGlare_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602637D RID: 156541 RVA: 0x0096E686 File Offset: 0x0096C886
		protected BP_SceneLensflare_Launchscene_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401320D RID: 78349
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewLensflare/Launchscene/BP_SceneLensflare_Launchscene.BP_SceneLensflare_Launchscene_C";

		// Token: 0x0401320E RID: 78350
		private static IntPtr _ClassPtr;

		// Token: 0x0401320F RID: 78351
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013210 RID: 78352
		internal static int __PropertyOffset_1;

		// Token: 0x04013211 RID: 78353
		internal static int __PropertyOffset_2;

		// Token: 0x04013212 RID: 78354
		internal static int __PropertyOffset_3;

		// Token: 0x04013213 RID: 78355
		internal static int __PropertyOffset_4;

		// Token: 0x04013214 RID: 78356
		internal static int __PropertyOffset_5;

		// Token: 0x04013215 RID: 78357
		internal static int __PropertyOffset_6;

		// Token: 0x04013216 RID: 78358
		internal static int __PropertyOffset_7;

		// Token: 0x04013217 RID: 78359
		internal static int __PropertyOffset_8;

		// Token: 0x04013218 RID: 78360
		internal static int __PropertyOffset_9;

		// Token: 0x04013219 RID: 78361
		internal static int __PropertyOffset_10;

		// Token: 0x0401321A RID: 78362
		internal static int __PropertyOffset_11;

		// Token: 0x0401321B RID: 78363
		internal static int __PropertyOffset_12;

		// Token: 0x0401321C RID: 78364
		internal static int __PropertyOffset_13;

		// Token: 0x0401321D RID: 78365
		internal static int __PropertyOffset_14;

		// Token: 0x0401321E RID: 78366
		internal static int __PropertyOffset_15;

		// Token: 0x0401321F RID: 78367
		internal static int __PropertyOffset_16;

		// Token: 0x04013220 RID: 78368
		internal static int __PropertyOffset_17;

		// Token: 0x04013221 RID: 78369
		internal static int __PropertyOffset_18;

		// Token: 0x04013222 RID: 78370
		internal static int __PropertyOffset_19;

		// Token: 0x04013223 RID: 78371
		internal static int __PropertyOffset_20;

		// Token: 0x04013224 RID: 78372
		internal static int __PropertyOffset_21;

		// Token: 0x04013225 RID: 78373
		internal static int __PropertyOffset_22;

		// Token: 0x04013226 RID: 78374
		internal static int __PropertyOffset_23;

		// Token: 0x04013227 RID: 78375
		internal static int __PropertyOffset_24;

		// Token: 0x04013228 RID: 78376
		internal static int __PropertyOffset_25;

		// Token: 0x04013229 RID: 78377
		internal static int __PropertyOffset_26;

		// Token: 0x0401322A RID: 78378
		internal static int __PropertyOffset_27;

		// Token: 0x0401322B RID: 78379
		internal static int __PropertyOffset_28;

		// Token: 0x0401322C RID: 78380
		internal static int __PropertyOffset_29;

		// Token: 0x0401322D RID: 78381
		internal static int __PropertyOffset_30;

		// Token: 0x0401322E RID: 78382
		internal static int __PropertyOffset_31;

		// Token: 0x0401322F RID: 78383
		internal static int __PropertyOffset_32;

		// Token: 0x04013230 RID: 78384
		private static IntPtr __ApplyDynamicMaterialGhost_NativeFunctionPtr;

		// Token: 0x04013231 RID: 78385
		private static IntPtr __ApplyDynamicMaterialHalo_NativeFunctionPtr;

		// Token: 0x04013232 RID: 78386
		private static IntPtr __ApplyDynamicMaterialGlare_NativeFunctionPtr;

		// Token: 0x0200A0B2 RID: 41138
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ApplyDynamicMaterialGhost_FunctionParams
		{
			// Token: 0x04031BB7 RID: 203703
			[FieldOffset(0)]
			public IntPtr DynMaterial;
		}

		// Token: 0x0200A0B3 RID: 41139
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ApplyDynamicMaterialHalo_FunctionParams
		{
			// Token: 0x04031BB8 RID: 203704
			[FieldOffset(0)]
			public IntPtr DynMaterial;
		}

		// Token: 0x0200A0B4 RID: 41140
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ApplyDynamicMaterialGlare_FunctionParams
		{
			// Token: 0x04031BB9 RID: 203705
			[FieldOffset(0)]
			public IntPtr DynMaterial;
		}
	}
}
