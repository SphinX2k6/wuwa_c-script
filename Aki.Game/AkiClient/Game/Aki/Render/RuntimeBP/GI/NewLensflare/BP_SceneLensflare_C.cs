using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewLensflare
{
	// Token: 0x02003D4A RID: 15690
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewLensflare/BP_SceneLensflare.BP_SceneLensflare_C")]
	[UnrealStructLayout(1608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1604)]
	public class BP_SceneLensflare_C : ALensflareSamplerActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060262CA RID: 156362 RVA: 0x0096D3D0 File Offset: 0x0096B5D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneLensflare_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewLensflare/BP_SceneLensflare.BP_SceneLensflare_C");
			}
			return BP_SceneLensflare_C._ClassPtr;
		}

		// Token: 0x060262CB RID: 156363 RVA: 0x0096D3F4 File Offset: 0x0096B5F4
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_SceneLensflare_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x060262CC RID: 156364 RVA: 0x0096D3FC File Offset: 0x0096B5FC
		public BP_SceneLensflare_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneLensflare_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060262CD RID: 156365 RVA: 0x0096D424 File Offset: 0x0096B624
		[NullableContext(1)]
		public BP_SceneLensflare_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneLensflare_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170050E8 RID: 20712
		// (get) Token: 0x060262CE RID: 156366 RVA: 0x0096D457 File Offset: 0x0096B657
		// (set) Token: 0x060262CF RID: 156367 RVA: 0x0096D46B File Offset: 0x0096B66B
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170050E9 RID: 20713
		// (get) Token: 0x060262D0 RID: 156368 RVA: 0x0096D480 File Offset: 0x0096B680
		// (set) Token: 0x060262D1 RID: 156369 RVA: 0x0096D490 File Offset: 0x0096B690
		public unsafe bool 自定义Ghost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170050EA RID: 20714
		// (get) Token: 0x060262D2 RID: 156370 RVA: 0x0096D4A1 File Offset: 0x0096B6A1
		// (set) Token: 0x060262D3 RID: 156371 RVA: 0x0096D4B1 File Offset: 0x0096B6B1
		public unsafe float Ghost_大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170050EB RID: 20715
		// (get) Token: 0x060262D4 RID: 156372 RVA: 0x0096D4C2 File Offset: 0x0096B6C2
		// (set) Token: 0x060262D5 RID: 156373 RVA: 0x0096D4D2 File Offset: 0x0096B6D2
		public unsafe float Ghost_分布偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170050EC RID: 20716
		// (get) Token: 0x060262D6 RID: 156374 RVA: 0x0096D4E3 File Offset: 0x0096B6E3
		// (set) Token: 0x060262D7 RID: 156375 RVA: 0x0096D4F3 File Offset: 0x0096B6F3
		public unsafe float Ghost_分布范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170050ED RID: 20717
		// (get) Token: 0x060262D8 RID: 156376 RVA: 0x0096D504 File Offset: 0x0096B704
		// (set) Token: 0x060262D9 RID: 156377 RVA: 0x0096D518 File Offset: 0x0096B718
		public unsafe FLinearColor Ghost_调色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170050EE RID: 20718
		// (get) Token: 0x060262DA RID: 156378 RVA: 0x0096D52D File Offset: 0x0096B72D
		// (set) Token: 0x060262DB RID: 156379 RVA: 0x0096D53D File Offset: 0x0096B73D
		public unsafe float Ghost_不透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170050EF RID: 20719
		// (get) Token: 0x060262DC RID: 156380 RVA: 0x0096D54E File Offset: 0x0096B74E
		// (set) Token: 0x060262DD RID: 156381 RVA: 0x0096D55E File Offset: 0x0096B75E
		public unsafe bool 自定义Halo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170050F0 RID: 20720
		// (get) Token: 0x060262DE RID: 156382 RVA: 0x0096D56F File Offset: 0x0096B76F
		// (set) Token: 0x060262DF RID: 156383 RVA: 0x0096D57F File Offset: 0x0096B77F
		public unsafe float Halo_圆环衰减
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170050F1 RID: 20721
		// (get) Token: 0x060262E0 RID: 156384 RVA: 0x0096D590 File Offset: 0x0096B790
		// (set) Token: 0x060262E1 RID: 156385 RVA: 0x0096D5A0 File Offset: 0x0096B7A0
		public unsafe float Halo_大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170050F2 RID: 20722
		// (get) Token: 0x060262E2 RID: 156386 RVA: 0x0096D5B1 File Offset: 0x0096B7B1
		// (set) Token: 0x060262E3 RID: 156387 RVA: 0x0096D5C1 File Offset: 0x0096B7C1
		public unsafe float Halo_分布偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170050F3 RID: 20723
		// (get) Token: 0x060262E4 RID: 156388 RVA: 0x0096D5D2 File Offset: 0x0096B7D2
		// (set) Token: 0x060262E5 RID: 156389 RVA: 0x0096D5E2 File Offset: 0x0096B7E2
		public unsafe float Halo_分布范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170050F4 RID: 20724
		// (get) Token: 0x060262E6 RID: 156390 RVA: 0x0096D5F3 File Offset: 0x0096B7F3
		// (set) Token: 0x060262E7 RID: 156391 RVA: 0x0096D607 File Offset: 0x0096B807
		public unsafe FLinearColor Halo_调色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170050F5 RID: 20725
		// (get) Token: 0x060262E8 RID: 156392 RVA: 0x0096D61C File Offset: 0x0096B81C
		// (set) Token: 0x060262E9 RID: 156393 RVA: 0x0096D62C File Offset: 0x0096B82C
		public unsafe float Halo_不透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170050F6 RID: 20726
		// (get) Token: 0x060262EA RID: 156394 RVA: 0x0096D63D File Offset: 0x0096B83D
		// (set) Token: 0x060262EB RID: 156395 RVA: 0x0096D64D File Offset: 0x0096B84D
		public unsafe bool 自定义Glare
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170050F7 RID: 20727
		// (get) Token: 0x060262EC RID: 156396 RVA: 0x0096D65E File Offset: 0x0096B85E
		// (set) Token: 0x060262ED RID: 156397 RVA: 0x0096D672 File Offset: 0x0096B872
		public unsafe FVector2D Glare_大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170050F8 RID: 20728
		// (get) Token: 0x060262EE RID: 156398 RVA: 0x0096D687 File Offset: 0x0096B887
		// (set) Token: 0x060262EF RID: 156399 RVA: 0x0096D69B File Offset: 0x0096B89B
		public unsafe FLinearColor Glare_调色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170050F9 RID: 20729
		// (get) Token: 0x060262F0 RID: 156400 RVA: 0x0096D6B0 File Offset: 0x0096B8B0
		// (set) Token: 0x060262F1 RID: 156401 RVA: 0x0096D6C0 File Offset: 0x0096B8C0
		public unsafe float Glare_不透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170050FA RID: 20730
		// (get) Token: 0x060262F2 RID: 156402 RVA: 0x0096D6D1 File Offset: 0x0096B8D1
		// (set) Token: 0x060262F3 RID: 156403 RVA: 0x0096D6E1 File Offset: 0x0096B8E1
		public unsafe float Glare_旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170050FB RID: 20731
		// (get) Token: 0x060262F4 RID: 156404 RVA: 0x0096D6F2 File Offset: 0x0096B8F2
		// (set) Token: 0x060262F5 RID: 156405 RVA: 0x0096D702 File Offset: 0x0096B902
		public unsafe float Glare_锁定动态旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170050FC RID: 20732
		// (get) Token: 0x060262F6 RID: 156406 RVA: 0x0096D713 File Offset: 0x0096B913
		// (set) Token: 0x060262F7 RID: 156407 RVA: 0x0096D723 File Offset: 0x0096B923
		public unsafe float Ghost_受背景色影响
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170050FD RID: 20733
		// (get) Token: 0x060262F8 RID: 156408 RVA: 0x0096D734 File Offset: 0x0096B934
		// (set) Token: 0x060262F9 RID: 156409 RVA: 0x0096D744 File Offset: 0x0096B944
		public unsafe float Halo_受背景色影响
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170050FE RID: 20734
		// (get) Token: 0x060262FA RID: 156410 RVA: 0x0096D755 File Offset: 0x0096B955
		// (set) Token: 0x060262FB RID: 156411 RVA: 0x0096D765 File Offset: 0x0096B965
		public unsafe float Glare_受背景色影响
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170050FF RID: 20735
		// (get) Token: 0x060262FC RID: 156412 RVA: 0x0096D776 File Offset: 0x0096B976
		// (set) Token: 0x060262FD RID: 156413 RVA: 0x0096D786 File Offset: 0x0096B986
		public unsafe float Ghost_视角衰减速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005100 RID: 20736
		// (get) Token: 0x060262FE RID: 156414 RVA: 0x0096D797 File Offset: 0x0096B997
		// (set) Token: 0x060262FF RID: 156415 RVA: 0x0096D7A7 File Offset: 0x0096B9A7
		public unsafe float Halo_视角衰减速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17005101 RID: 20737
		// (get) Token: 0x06026300 RID: 156416 RVA: 0x0096D7B8 File Offset: 0x0096B9B8
		// (set) Token: 0x06026301 RID: 156417 RVA: 0x0096D7C8 File Offset: 0x0096B9C8
		public unsafe float Glare_视角衰减速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17005102 RID: 20738
		// (get) Token: 0x06026302 RID: 156418 RVA: 0x0096D7D9 File Offset: 0x0096B9D9
		// (set) Token: 0x06026303 RID: 156419 RVA: 0x0096D7E9 File Offset: 0x0096B9E9
		public unsafe bool Ghost_使用固定旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005103 RID: 20739
		// (get) Token: 0x06026304 RID: 156420 RVA: 0x0096D7FA File Offset: 0x0096B9FA
		// (set) Token: 0x06026305 RID: 156421 RVA: 0x0096D80A File Offset: 0x0096BA0A
		public unsafe float Ghost_固定旋转值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17005104 RID: 20740
		// (get) Token: 0x06026306 RID: 156422 RVA: 0x0096D81B File Offset: 0x0096BA1B
		// (set) Token: 0x06026307 RID: 156423 RVA: 0x0096D82B File Offset: 0x0096BA2B
		public unsafe bool 自定义Ghost贴图
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005105 RID: 20741
		// (get) Token: 0x06026308 RID: 156424 RVA: 0x0096D83C File Offset: 0x0096BA3C
		// (set) Token: 0x06026309 RID: 156425 RVA: 0x0096D850 File Offset: 0x0096BA50
		public unsafe UTexture2D Ghost贴图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x17005106 RID: 20742
		// (get) Token: 0x0602630A RID: 156426 RVA: 0x0096D865 File Offset: 0x0096BA65
		// (set) Token: 0x0602630B RID: 156427 RVA: 0x0096D875 File Offset: 0x0096BA75
		public unsafe bool Halo_使用固定旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005107 RID: 20743
		// (get) Token: 0x0602630C RID: 156428 RVA: 0x0096D886 File Offset: 0x0096BA86
		// (set) Token: 0x0602630D RID: 156429 RVA: 0x0096D896 File Offset: 0x0096BA96
		public unsafe float Halo_固定旋转值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17005108 RID: 20744
		// (get) Token: 0x0602630E RID: 156430 RVA: 0x0096D8A7 File Offset: 0x0096BAA7
		// (set) Token: 0x0602630F RID: 156431 RVA: 0x0096D8B7 File Offset: 0x0096BAB7
		public unsafe bool 自定义Halo贴图
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005109 RID: 20745
		// (get) Token: 0x06026310 RID: 156432 RVA: 0x0096D8C8 File Offset: 0x0096BAC8
		// (set) Token: 0x06026311 RID: 156433 RVA: 0x0096D8DC File Offset: 0x0096BADC
		public unsafe UTexture2D Halo贴图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x1700510A RID: 20746
		// (get) Token: 0x06026312 RID: 156434 RVA: 0x0096D8F1 File Offset: 0x0096BAF1
		// (set) Token: 0x06026313 RID: 156435 RVA: 0x0096D901 File Offset: 0x0096BB01
		public unsafe bool 自定义Glare贴图
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700510B RID: 20747
		// (get) Token: 0x06026314 RID: 156436 RVA: 0x0096D912 File Offset: 0x0096BB12
		// (set) Token: 0x06026315 RID: 156437 RVA: 0x0096D926 File Offset: 0x0096BB26
		public unsafe UTexture2D Glare贴图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x1700510C RID: 20748
		// (get) Token: 0x06026316 RID: 156438 RVA: 0x0096D93B File Offset: 0x0096BB3B
		// (set) Token: 0x06026317 RID: 156439 RVA: 0x0096D94F File Offset: 0x0096BB4F
		public unsafe FLinearColor Glare_UV缩放_偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x1700510D RID: 20749
		// (get) Token: 0x06026318 RID: 156440 RVA: 0x0096D964 File Offset: 0x0096BB64
		// (set) Token: 0x06026319 RID: 156441 RVA: 0x0096D974 File Offset: 0x0096BB74
		public unsafe float 衰减系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x1700510E RID: 20750
		// (get) Token: 0x0602631A RID: 156442 RVA: 0x0096D985 File Offset: 0x0096BB85
		// (set) Token: 0x0602631B RID: 156443 RVA: 0x0096D995 File Offset: 0x0096BB95
		public unsafe float 屏占比剔除阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x1700510F RID: 20751
		// (get) Token: 0x0602631C RID: 156444 RVA: 0x0096D9A6 File Offset: 0x0096BBA6
		// (set) Token: 0x0602631D RID: 156445 RVA: 0x0096D9B6 File Offset: 0x0096BBB6
		public unsafe float 反向衰减偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17005110 RID: 20752
		// (get) Token: 0x0602631E RID: 156446 RVA: 0x0096D9C7 File Offset: 0x0096BBC7
		// (set) Token: 0x0602631F RID: 156447 RVA: 0x0096D9D7 File Offset: 0x0096BBD7
		public unsafe float 反向衰减长度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17005111 RID: 20753
		// (get) Token: 0x06026320 RID: 156448 RVA: 0x0096D9E8 File Offset: 0x0096BBE8
		// (set) Token: 0x06026321 RID: 156449 RVA: 0x0096D9F8 File Offset: 0x0096BBF8
		public unsafe float 反向衰减系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x06026322 RID: 156450 RVA: 0x0096DA0C File Offset: 0x0096BC0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_SceneLensflare_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneLensflare_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06026323 RID: 156451 RVA: 0x0096DA54 File Offset: 0x0096BC54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_SceneLensflare_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneLensflare_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06026324 RID: 156452 RVA: 0x0096DA9C File Offset: 0x0096BC9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetParameterCommon(UMaterialInstanceDynamic DynamicMaterial)
		{
			BP_SceneLensflare_C.__SetParameterCommon_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__SetParameterCommon_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SceneLensflare_C.__SetParameterCommon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__SetParameterCommon_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynamicMaterial = ((DynamicMaterial != null) ? DynamicMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_C.__SetParameterCommon_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026325 RID: 156453 RVA: 0x0096DAF4 File Offset: 0x0096BCF4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override FLensflareSamplerActorParameter GetLensflareParameter()
		{
			BP_SceneLensflare_C.__GetLensflareParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__GetLensflareParameter_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_SceneLensflare_C.__GetLensflareParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__GetLensflareParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_C.__GetLensflareParameter_NativeFunctionPtr, (void*)ptr);
			return new FLensflareSamplerActorParameter(&ptr->__Result, true, true);
		}

		// Token: 0x06026326 RID: 156454 RVA: 0x0096DB44 File Offset: 0x0096BD44
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual FLensflareSamplerActorParameter GetLensflareParameter_Implementation()
		{
			BP_SceneLensflare_C.__GetLensflareParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__GetLensflareParameter_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_SceneLensflare_C.__GetLensflareParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__GetLensflareParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_C.__GetLensflareParameter_NativeFunctionPtr, (void*)ptr, 0);
			return new FLensflareSamplerActorParameter(&ptr->__Result, true, true);
		}

		// Token: 0x06026327 RID: 156455 RVA: 0x0096DB94 File Offset: 0x0096BD94
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override FLensflareSamplerActorGlareParameter GetCustomGlareParameter()
		{
			BP_SceneLensflare_C.__GetCustomGlareParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__GetCustomGlareParameter_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(BP_SceneLensflare_C.__GetCustomGlareParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__GetCustomGlareParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_C.__GetCustomGlareParameter_NativeFunctionPtr, (void*)ptr);
			return new FLensflareSamplerActorGlareParameter(&ptr->__Result, true, true);
		}

		// Token: 0x06026328 RID: 156456 RVA: 0x0096DBE4 File Offset: 0x0096BDE4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual FLensflareSamplerActorGlareParameter GetCustomGlareParameter_Implementation()
		{
			BP_SceneLensflare_C.__GetCustomGlareParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__GetCustomGlareParameter_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(BP_SceneLensflare_C.__GetCustomGlareParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__GetCustomGlareParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_C.__GetCustomGlareParameter_NativeFunctionPtr, (void*)ptr, 0);
			return new FLensflareSamplerActorGlareParameter(&ptr->__Result, true, true);
		}

		// Token: 0x06026329 RID: 156457 RVA: 0x0096DC38 File Offset: 0x0096BE38
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override FLensflareSamplerActorHaloParameter GetCustomHaloParameter()
		{
			BP_SceneLensflare_C.__GetCustomHaloParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__GetCustomHaloParameter_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_SceneLensflare_C.__GetCustomHaloParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__GetCustomHaloParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_C.__GetCustomHaloParameter_NativeFunctionPtr, (void*)ptr);
			return new FLensflareSamplerActorHaloParameter(&ptr->__Result, true, true);
		}

		// Token: 0x0602632A RID: 156458 RVA: 0x0096DC88 File Offset: 0x0096BE88
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual FLensflareSamplerActorHaloParameter GetCustomHaloParameter_Implementation()
		{
			BP_SceneLensflare_C.__GetCustomHaloParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__GetCustomHaloParameter_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_SceneLensflare_C.__GetCustomHaloParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__GetCustomHaloParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_C.__GetCustomHaloParameter_NativeFunctionPtr, (void*)ptr, 0);
			return new FLensflareSamplerActorHaloParameter(&ptr->__Result, true, true);
		}

		// Token: 0x0602632B RID: 156459 RVA: 0x0096DCDC File Offset: 0x0096BEDC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override FLensflareSamplerActorGhostParameter GetCustomGhostParameter()
		{
			BP_SceneLensflare_C.__GetCustomGhostParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__GetCustomGhostParameter_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_SceneLensflare_C.__GetCustomGhostParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__GetCustomGhostParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_C.__GetCustomGhostParameter_NativeFunctionPtr, (void*)ptr);
			return new FLensflareSamplerActorGhostParameter(&ptr->__Result, true, true);
		}

		// Token: 0x0602632C RID: 156460 RVA: 0x0096DD2C File Offset: 0x0096BF2C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual FLensflareSamplerActorGhostParameter GetCustomGhostParameter_Implementation()
		{
			BP_SceneLensflare_C.__GetCustomGhostParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__GetCustomGhostParameter_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_SceneLensflare_C.__GetCustomGhostParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__GetCustomGhostParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_C.__GetCustomGhostParameter_NativeFunctionPtr, (void*)ptr, 0);
			return new FLensflareSamplerActorGhostParameter(&ptr->__Result, true, true);
		}

		// Token: 0x0602632D RID: 156461 RVA: 0x0096DD80 File Offset: 0x0096BF80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyDynamicMaterialGhost(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_C.__ApplyDynamicMaterialGhost_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__ApplyDynamicMaterialGhost_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_C.__ApplyDynamicMaterialGhost_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__ApplyDynamicMaterialGhost_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_C.__ApplyDynamicMaterialGhost_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602632E RID: 156462 RVA: 0x0096DDD8 File Offset: 0x0096BFD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ApplyDynamicMaterialGhost_Implementation(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_C.__ApplyDynamicMaterialGhost_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__ApplyDynamicMaterialGhost_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_C.__ApplyDynamicMaterialGhost_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__ApplyDynamicMaterialGhost_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_C.__ApplyDynamicMaterialGhost_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602632F RID: 156463 RVA: 0x0096DE30 File Offset: 0x0096C030
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyDynamicMaterialHalo(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_C.__ApplyDynamicMaterialHalo_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__ApplyDynamicMaterialHalo_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_C.__ApplyDynamicMaterialHalo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__ApplyDynamicMaterialHalo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_C.__ApplyDynamicMaterialHalo_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026330 RID: 156464 RVA: 0x0096DE88 File Offset: 0x0096C088
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ApplyDynamicMaterialHalo_Implementation(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_C.__ApplyDynamicMaterialHalo_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__ApplyDynamicMaterialHalo_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_C.__ApplyDynamicMaterialHalo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__ApplyDynamicMaterialHalo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_C.__ApplyDynamicMaterialHalo_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026331 RID: 156465 RVA: 0x0096DEE0 File Offset: 0x0096C0E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyDynamicMaterialGlare(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_C.__ApplyDynamicMaterialGlare_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__ApplyDynamicMaterialGlare_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_C.__ApplyDynamicMaterialGlare_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__ApplyDynamicMaterialGlare_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_C.__ApplyDynamicMaterialGlare_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026332 RID: 156466 RVA: 0x0096DF38 File Offset: 0x0096C138
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ApplyDynamicMaterialGlare_Implementation(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_C.__ApplyDynamicMaterialGlare_FunctionParams* ptr = stackalloc BP_SceneLensflare_C.__ApplyDynamicMaterialGlare_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_C.__ApplyDynamicMaterialGlare_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_C.__ApplyDynamicMaterialGlare_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_C.__ApplyDynamicMaterialGlare_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026333 RID: 156467 RVA: 0x0096DF8E File Offset: 0x0096C18E
		protected BP_SceneLensflare_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040131D6 RID: 78294
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x040131D7 RID: 78295
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewLensflare/BP_SceneLensflare.BP_SceneLensflare_C";

		// Token: 0x040131D8 RID: 78296
		private static IntPtr _ClassPtr;

		// Token: 0x040131D9 RID: 78297
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040131DA RID: 78298
		internal static int __PropertyOffset_1;

		// Token: 0x040131DB RID: 78299
		internal static int __PropertyOffset_2;

		// Token: 0x040131DC RID: 78300
		internal static int __PropertyOffset_3;

		// Token: 0x040131DD RID: 78301
		internal static int __PropertyOffset_4;

		// Token: 0x040131DE RID: 78302
		internal static int __PropertyOffset_5;

		// Token: 0x040131DF RID: 78303
		internal static int __PropertyOffset_6;

		// Token: 0x040131E0 RID: 78304
		internal static int __PropertyOffset_7;

		// Token: 0x040131E1 RID: 78305
		internal static int __PropertyOffset_8;

		// Token: 0x040131E2 RID: 78306
		internal static int __PropertyOffset_9;

		// Token: 0x040131E3 RID: 78307
		internal static int __PropertyOffset_10;

		// Token: 0x040131E4 RID: 78308
		internal static int __PropertyOffset_11;

		// Token: 0x040131E5 RID: 78309
		internal static int __PropertyOffset_12;

		// Token: 0x040131E6 RID: 78310
		internal static int __PropertyOffset_13;

		// Token: 0x040131E7 RID: 78311
		internal static int __PropertyOffset_14;

		// Token: 0x040131E8 RID: 78312
		internal static int __PropertyOffset_15;

		// Token: 0x040131E9 RID: 78313
		internal static int __PropertyOffset_16;

		// Token: 0x040131EA RID: 78314
		internal static int __PropertyOffset_17;

		// Token: 0x040131EB RID: 78315
		internal static int __PropertyOffset_18;

		// Token: 0x040131EC RID: 78316
		internal static int __PropertyOffset_19;

		// Token: 0x040131ED RID: 78317
		internal static int __PropertyOffset_20;

		// Token: 0x040131EE RID: 78318
		internal static int __PropertyOffset_21;

		// Token: 0x040131EF RID: 78319
		internal static int __PropertyOffset_22;

		// Token: 0x040131F0 RID: 78320
		internal static int __PropertyOffset_23;

		// Token: 0x040131F1 RID: 78321
		internal static int __PropertyOffset_24;

		// Token: 0x040131F2 RID: 78322
		internal static int __PropertyOffset_25;

		// Token: 0x040131F3 RID: 78323
		internal static int __PropertyOffset_26;

		// Token: 0x040131F4 RID: 78324
		internal static int __PropertyOffset_27;

		// Token: 0x040131F5 RID: 78325
		internal static int __PropertyOffset_28;

		// Token: 0x040131F6 RID: 78326
		internal static int __PropertyOffset_29;

		// Token: 0x040131F7 RID: 78327
		internal static int __PropertyOffset_30;

		// Token: 0x040131F8 RID: 78328
		internal static int __PropertyOffset_31;

		// Token: 0x040131F9 RID: 78329
		internal static int __PropertyOffset_32;

		// Token: 0x040131FA RID: 78330
		internal static int __PropertyOffset_33;

		// Token: 0x040131FB RID: 78331
		internal static int __PropertyOffset_34;

		// Token: 0x040131FC RID: 78332
		internal static int __PropertyOffset_35;

		// Token: 0x040131FD RID: 78333
		internal static int __PropertyOffset_36;

		// Token: 0x040131FE RID: 78334
		internal static int __PropertyOffset_37;

		// Token: 0x040131FF RID: 78335
		internal static int __PropertyOffset_38;

		// Token: 0x04013200 RID: 78336
		internal static int __PropertyOffset_39;

		// Token: 0x04013201 RID: 78337
		internal static int __PropertyOffset_40;

		// Token: 0x04013202 RID: 78338
		internal static int __PropertyOffset_41;

		// Token: 0x04013203 RID: 78339
		internal static int __PropertyOffset_42;

		// Token: 0x04013204 RID: 78340
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x04013205 RID: 78341
		private static IntPtr __SetParameterCommon_NativeFunctionPtr;

		// Token: 0x04013206 RID: 78342
		private static IntPtr __GetLensflareParameter_NativeFunctionPtr;

		// Token: 0x04013207 RID: 78343
		private static IntPtr __GetCustomGlareParameter_NativeFunctionPtr;

		// Token: 0x04013208 RID: 78344
		private static IntPtr __GetCustomHaloParameter_NativeFunctionPtr;

		// Token: 0x04013209 RID: 78345
		private static IntPtr __GetCustomGhostParameter_NativeFunctionPtr;

		// Token: 0x0401320A RID: 78346
		private static IntPtr __ApplyDynamicMaterialGhost_NativeFunctionPtr;

		// Token: 0x0401320B RID: 78347
		private static IntPtr __ApplyDynamicMaterialHalo_NativeFunctionPtr;

		// Token: 0x0401320C RID: 78348
		private static IntPtr __ApplyDynamicMaterialGlare_NativeFunctionPtr;

		// Token: 0x0200A0A9 RID: 41129
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x04031BAE RID: 203694
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x0200A0AA RID: 41130
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetParameterCommon_FunctionParams
		{
			// Token: 0x04031BAF RID: 203695
			[FieldOffset(0)]
			public IntPtr DynamicMaterial;
		}

		// Token: 0x0200A0AB RID: 41131
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected new ref struct __GetLensflareParameter_FunctionParams
		{
			// Token: 0x04031BB0 RID: 203696
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200A0AC RID: 41132
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected new ref struct __GetCustomGlareParameter_FunctionParams
		{
			// Token: 0x04031BB1 RID: 203697
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200A0AD RID: 41133
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected new ref struct __GetCustomHaloParameter_FunctionParams
		{
			// Token: 0x04031BB2 RID: 203698
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200A0AE RID: 41134
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected new ref struct __GetCustomGhostParameter_FunctionParams
		{
			// Token: 0x04031BB3 RID: 203699
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200A0AF RID: 41135
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ApplyDynamicMaterialGhost_FunctionParams
		{
			// Token: 0x04031BB4 RID: 203700
			[FieldOffset(0)]
			public IntPtr DynMaterial;
		}

		// Token: 0x0200A0B0 RID: 41136
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ApplyDynamicMaterialHalo_FunctionParams
		{
			// Token: 0x04031BB5 RID: 203701
			[FieldOffset(0)]
			public IntPtr DynMaterial;
		}

		// Token: 0x0200A0B1 RID: 41137
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ApplyDynamicMaterialGlare_FunctionParams
		{
			// Token: 0x04031BB6 RID: 203702
			[FieldOffset(0)]
			public IntPtr DynMaterial;
		}
	}
}
