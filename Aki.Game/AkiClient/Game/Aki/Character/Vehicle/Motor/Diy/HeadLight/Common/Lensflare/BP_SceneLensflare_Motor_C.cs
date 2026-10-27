using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.HeadLight.Common.Lensflare
{
	// Token: 0x02004044 RID: 16452
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/Lensflare/BP_SceneLensflare_Motor.BP_SceneLensflare_Motor_C")]
	[UnrealStructLayout(1592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1592)]
	public class BP_SceneLensflare_Motor_C : ALensflareSamplerActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A416 RID: 173078 RVA: 0x009DA731 File Offset: 0x009D8931
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneLensflare_Motor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/Lensflare/BP_SceneLensflare_Motor.BP_SceneLensflare_Motor_C");
			}
			return BP_SceneLensflare_Motor_C._ClassPtr;
		}

		// Token: 0x0602A417 RID: 173079 RVA: 0x009DA758 File Offset: 0x009D8958
		public BP_SceneLensflare_Motor_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneLensflare_Motor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A418 RID: 173080 RVA: 0x009DA780 File Offset: 0x009D8980
		[NullableContext(1)]
		public BP_SceneLensflare_Motor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneLensflare_Motor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006780 RID: 26496
		// (get) Token: 0x0602A419 RID: 173081 RVA: 0x009DA7B3 File Offset: 0x009D89B3
		// (set) Token: 0x0602A41A RID: 173082 RVA: 0x009DA7C7 File Offset: 0x009D89C7
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Motor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Motor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006781 RID: 26497
		// (get) Token: 0x0602A41B RID: 173083 RVA: 0x009DA7DC File Offset: 0x009D89DC
		// (set) Token: 0x0602A41C RID: 173084 RVA: 0x009DA7EC File Offset: 0x009D89EC
		public unsafe bool 自定义Ghost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006782 RID: 26498
		// (get) Token: 0x0602A41D RID: 173085 RVA: 0x009DA7FD File Offset: 0x009D89FD
		// (set) Token: 0x0602A41E RID: 173086 RVA: 0x009DA80D File Offset: 0x009D8A0D
		public unsafe float Ghost_大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006783 RID: 26499
		// (get) Token: 0x0602A41F RID: 173087 RVA: 0x009DA81E File Offset: 0x009D8A1E
		// (set) Token: 0x0602A420 RID: 173088 RVA: 0x009DA82E File Offset: 0x009D8A2E
		public unsafe float Ghost_分布偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006784 RID: 26500
		// (get) Token: 0x0602A421 RID: 173089 RVA: 0x009DA83F File Offset: 0x009D8A3F
		// (set) Token: 0x0602A422 RID: 173090 RVA: 0x009DA84F File Offset: 0x009D8A4F
		public unsafe float Ghost_分布范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006785 RID: 26501
		// (get) Token: 0x0602A423 RID: 173091 RVA: 0x009DA860 File Offset: 0x009D8A60
		// (set) Token: 0x0602A424 RID: 173092 RVA: 0x009DA874 File Offset: 0x009D8A74
		public unsafe FLinearColor Ghost_调色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006786 RID: 26502
		// (get) Token: 0x0602A425 RID: 173093 RVA: 0x009DA889 File Offset: 0x009D8A89
		// (set) Token: 0x0602A426 RID: 173094 RVA: 0x009DA899 File Offset: 0x009D8A99
		public unsafe float Ghost_不透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006787 RID: 26503
		// (get) Token: 0x0602A427 RID: 173095 RVA: 0x009DA8AA File Offset: 0x009D8AAA
		// (set) Token: 0x0602A428 RID: 173096 RVA: 0x009DA8BA File Offset: 0x009D8ABA
		public unsafe bool 自定义Halo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006788 RID: 26504
		// (get) Token: 0x0602A429 RID: 173097 RVA: 0x009DA8CB File Offset: 0x009D8ACB
		// (set) Token: 0x0602A42A RID: 173098 RVA: 0x009DA8DB File Offset: 0x009D8ADB
		public unsafe float Halo_圆环衰减
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006789 RID: 26505
		// (get) Token: 0x0602A42B RID: 173099 RVA: 0x009DA8EC File Offset: 0x009D8AEC
		// (set) Token: 0x0602A42C RID: 173100 RVA: 0x009DA8FC File Offset: 0x009D8AFC
		public unsafe float Halo_大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700678A RID: 26506
		// (get) Token: 0x0602A42D RID: 173101 RVA: 0x009DA90D File Offset: 0x009D8B0D
		// (set) Token: 0x0602A42E RID: 173102 RVA: 0x009DA91D File Offset: 0x009D8B1D
		public unsafe float Halo_分布偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700678B RID: 26507
		// (get) Token: 0x0602A42F RID: 173103 RVA: 0x009DA92E File Offset: 0x009D8B2E
		// (set) Token: 0x0602A430 RID: 173104 RVA: 0x009DA93E File Offset: 0x009D8B3E
		public unsafe float Halo_分布范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700678C RID: 26508
		// (get) Token: 0x0602A431 RID: 173105 RVA: 0x009DA94F File Offset: 0x009D8B4F
		// (set) Token: 0x0602A432 RID: 173106 RVA: 0x009DA963 File Offset: 0x009D8B63
		public unsafe FLinearColor Halo_调色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700678D RID: 26509
		// (get) Token: 0x0602A433 RID: 173107 RVA: 0x009DA978 File Offset: 0x009D8B78
		// (set) Token: 0x0602A434 RID: 173108 RVA: 0x009DA988 File Offset: 0x009D8B88
		public unsafe float Halo_不透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700678E RID: 26510
		// (get) Token: 0x0602A435 RID: 173109 RVA: 0x009DA999 File Offset: 0x009D8B99
		// (set) Token: 0x0602A436 RID: 173110 RVA: 0x009DA9A9 File Offset: 0x009D8BA9
		public unsafe bool 自定义Glare
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700678F RID: 26511
		// (get) Token: 0x0602A437 RID: 173111 RVA: 0x009DA9BA File Offset: 0x009D8BBA
		// (set) Token: 0x0602A438 RID: 173112 RVA: 0x009DA9CE File Offset: 0x009D8BCE
		public unsafe FVector2D Glare_大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006790 RID: 26512
		// (get) Token: 0x0602A439 RID: 173113 RVA: 0x009DA9E3 File Offset: 0x009D8BE3
		// (set) Token: 0x0602A43A RID: 173114 RVA: 0x009DA9F7 File Offset: 0x009D8BF7
		public unsafe FLinearColor Glare_调色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006791 RID: 26513
		// (get) Token: 0x0602A43B RID: 173115 RVA: 0x009DAA0C File Offset: 0x009D8C0C
		// (set) Token: 0x0602A43C RID: 173116 RVA: 0x009DAA1C File Offset: 0x009D8C1C
		public unsafe float Glare_不透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006792 RID: 26514
		// (get) Token: 0x0602A43D RID: 173117 RVA: 0x009DAA2D File Offset: 0x009D8C2D
		// (set) Token: 0x0602A43E RID: 173118 RVA: 0x009DAA3D File Offset: 0x009D8C3D
		public unsafe float Glare_旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006793 RID: 26515
		// (get) Token: 0x0602A43F RID: 173119 RVA: 0x009DAA4E File Offset: 0x009D8C4E
		// (set) Token: 0x0602A440 RID: 173120 RVA: 0x009DAA5E File Offset: 0x009D8C5E
		public unsafe float Glare_锁定动态旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006794 RID: 26516
		// (get) Token: 0x0602A441 RID: 173121 RVA: 0x009DAA6F File Offset: 0x009D8C6F
		// (set) Token: 0x0602A442 RID: 173122 RVA: 0x009DAA7F File Offset: 0x009D8C7F
		public unsafe float Ghost_受背景色影响
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17006795 RID: 26517
		// (get) Token: 0x0602A443 RID: 173123 RVA: 0x009DAA90 File Offset: 0x009D8C90
		// (set) Token: 0x0602A444 RID: 173124 RVA: 0x009DAAA0 File Offset: 0x009D8CA0
		public unsafe float Halo_受背景色影响
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17006796 RID: 26518
		// (get) Token: 0x0602A445 RID: 173125 RVA: 0x009DAAB1 File Offset: 0x009D8CB1
		// (set) Token: 0x0602A446 RID: 173126 RVA: 0x009DAAC1 File Offset: 0x009D8CC1
		public unsafe float Glare_受背景色影响
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17006797 RID: 26519
		// (get) Token: 0x0602A447 RID: 173127 RVA: 0x009DAAD2 File Offset: 0x009D8CD2
		// (set) Token: 0x0602A448 RID: 173128 RVA: 0x009DAAE2 File Offset: 0x009D8CE2
		public unsafe float Ghost_视角衰减速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17006798 RID: 26520
		// (get) Token: 0x0602A449 RID: 173129 RVA: 0x009DAAF3 File Offset: 0x009D8CF3
		// (set) Token: 0x0602A44A RID: 173130 RVA: 0x009DAB03 File Offset: 0x009D8D03
		public unsafe float Halo_视角衰减速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17006799 RID: 26521
		// (get) Token: 0x0602A44B RID: 173131 RVA: 0x009DAB14 File Offset: 0x009D8D14
		// (set) Token: 0x0602A44C RID: 173132 RVA: 0x009DAB24 File Offset: 0x009D8D24
		public unsafe float Glare_视角衰减速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700679A RID: 26522
		// (get) Token: 0x0602A44D RID: 173133 RVA: 0x009DAB35 File Offset: 0x009D8D35
		// (set) Token: 0x0602A44E RID: 173134 RVA: 0x009DAB45 File Offset: 0x009D8D45
		public unsafe bool Ghost_使用固定旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700679B RID: 26523
		// (get) Token: 0x0602A44F RID: 173135 RVA: 0x009DAB56 File Offset: 0x009D8D56
		// (set) Token: 0x0602A450 RID: 173136 RVA: 0x009DAB66 File Offset: 0x009D8D66
		public unsafe float Ghost_固定旋转值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700679C RID: 26524
		// (get) Token: 0x0602A451 RID: 173137 RVA: 0x009DAB77 File Offset: 0x009D8D77
		// (set) Token: 0x0602A452 RID: 173138 RVA: 0x009DAB87 File Offset: 0x009D8D87
		public unsafe bool 自定义Ghost贴图
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700679D RID: 26525
		// (get) Token: 0x0602A453 RID: 173139 RVA: 0x009DAB98 File Offset: 0x009D8D98
		// (set) Token: 0x0602A454 RID: 173140 RVA: 0x009DABAC File Offset: 0x009D8DAC
		public unsafe UTexture2D Ghost贴图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Motor_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Motor_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x1700679E RID: 26526
		// (get) Token: 0x0602A455 RID: 173141 RVA: 0x009DABC1 File Offset: 0x009D8DC1
		// (set) Token: 0x0602A456 RID: 173142 RVA: 0x009DABD1 File Offset: 0x009D8DD1
		public unsafe bool Halo_使用固定旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700679F RID: 26527
		// (get) Token: 0x0602A457 RID: 173143 RVA: 0x009DABE2 File Offset: 0x009D8DE2
		// (set) Token: 0x0602A458 RID: 173144 RVA: 0x009DABF2 File Offset: 0x009D8DF2
		public unsafe float Halo_固定旋转值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170067A0 RID: 26528
		// (get) Token: 0x0602A459 RID: 173145 RVA: 0x009DAC03 File Offset: 0x009D8E03
		// (set) Token: 0x0602A45A RID: 173146 RVA: 0x009DAC13 File Offset: 0x009D8E13
		public unsafe bool 自定义Halo贴图
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067A1 RID: 26529
		// (get) Token: 0x0602A45B RID: 173147 RVA: 0x009DAC24 File Offset: 0x009D8E24
		// (set) Token: 0x0602A45C RID: 173148 RVA: 0x009DAC38 File Offset: 0x009D8E38
		public unsafe UTexture2D Halo贴图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Motor_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Motor_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x170067A2 RID: 26530
		// (get) Token: 0x0602A45D RID: 173149 RVA: 0x009DAC4D File Offset: 0x009D8E4D
		// (set) Token: 0x0602A45E RID: 173150 RVA: 0x009DAC5D File Offset: 0x009D8E5D
		public unsafe bool 自定义Glare贴图
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067A3 RID: 26531
		// (get) Token: 0x0602A45F RID: 173151 RVA: 0x009DAC6E File Offset: 0x009D8E6E
		// (set) Token: 0x0602A460 RID: 173152 RVA: 0x009DAC82 File Offset: 0x009D8E82
		public unsafe UTexture2D Glare贴图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Motor_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLensflare_Motor_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x170067A4 RID: 26532
		// (get) Token: 0x0602A461 RID: 173153 RVA: 0x009DAC97 File Offset: 0x009D8E97
		// (set) Token: 0x0602A462 RID: 173154 RVA: 0x009DACAB File Offset: 0x009D8EAB
		public unsafe FLinearColor Glare_UV缩放_偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x170067A5 RID: 26533
		// (get) Token: 0x0602A463 RID: 173155 RVA: 0x009DACC0 File Offset: 0x009D8EC0
		// (set) Token: 0x0602A464 RID: 173156 RVA: 0x009DACD0 File Offset: 0x009D8ED0
		public unsafe float 衰减系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x170067A6 RID: 26534
		// (get) Token: 0x0602A465 RID: 173157 RVA: 0x009DACE1 File Offset: 0x009D8EE1
		// (set) Token: 0x0602A466 RID: 173158 RVA: 0x009DACF1 File Offset: 0x009D8EF1
		public unsafe float 屏占比剔除阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLensflare_Motor_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x0602A467 RID: 173159 RVA: 0x009DAD04 File Offset: 0x009D8F04
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override FLensflareSamplerActorParameter GetLensflareParameter()
		{
			BP_SceneLensflare_Motor_C.__GetLensflareParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__GetLensflareParameter_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__GetLensflareParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__GetLensflareParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__GetLensflareParameter_NativeFunctionPtr, (void*)ptr);
			return new FLensflareSamplerActorParameter(&ptr->__Result, true, true);
		}

		// Token: 0x0602A468 RID: 173160 RVA: 0x009DAD54 File Offset: 0x009D8F54
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual FLensflareSamplerActorParameter GetLensflareParameter_Implementation()
		{
			BP_SceneLensflare_Motor_C.__GetLensflareParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__GetLensflareParameter_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__GetLensflareParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__GetLensflareParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__GetLensflareParameter_NativeFunctionPtr, (void*)ptr, 0);
			return new FLensflareSamplerActorParameter(&ptr->__Result, true, true);
		}

		// Token: 0x0602A469 RID: 173161 RVA: 0x009DADA4 File Offset: 0x009D8FA4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override FLensflareSamplerActorGlareParameter GetCustomGlareParameter()
		{
			BP_SceneLensflare_Motor_C.__GetCustomGlareParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__GetCustomGlareParameter_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__GetCustomGlareParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__GetCustomGlareParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__GetCustomGlareParameter_NativeFunctionPtr, (void*)ptr);
			return new FLensflareSamplerActorGlareParameter(&ptr->__Result, true, true);
		}

		// Token: 0x0602A46A RID: 173162 RVA: 0x009DADF4 File Offset: 0x009D8FF4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual FLensflareSamplerActorGlareParameter GetCustomGlareParameter_Implementation()
		{
			BP_SceneLensflare_Motor_C.__GetCustomGlareParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__GetCustomGlareParameter_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__GetCustomGlareParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__GetCustomGlareParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__GetCustomGlareParameter_NativeFunctionPtr, (void*)ptr, 0);
			return new FLensflareSamplerActorGlareParameter(&ptr->__Result, true, true);
		}

		// Token: 0x0602A46B RID: 173163 RVA: 0x009DAE48 File Offset: 0x009D9048
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override FLensflareSamplerActorHaloParameter GetCustomHaloParameter()
		{
			BP_SceneLensflare_Motor_C.__GetCustomHaloParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__GetCustomHaloParameter_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__GetCustomHaloParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__GetCustomHaloParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__GetCustomHaloParameter_NativeFunctionPtr, (void*)ptr);
			return new FLensflareSamplerActorHaloParameter(&ptr->__Result, true, true);
		}

		// Token: 0x0602A46C RID: 173164 RVA: 0x009DAE98 File Offset: 0x009D9098
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual FLensflareSamplerActorHaloParameter GetCustomHaloParameter_Implementation()
		{
			BP_SceneLensflare_Motor_C.__GetCustomHaloParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__GetCustomHaloParameter_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__GetCustomHaloParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__GetCustomHaloParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__GetCustomHaloParameter_NativeFunctionPtr, (void*)ptr, 0);
			return new FLensflareSamplerActorHaloParameter(&ptr->__Result, true, true);
		}

		// Token: 0x0602A46D RID: 173165 RVA: 0x009DAEEC File Offset: 0x009D90EC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override FLensflareSamplerActorGhostParameter GetCustomGhostParameter()
		{
			BP_SceneLensflare_Motor_C.__GetCustomGhostParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__GetCustomGhostParameter_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__GetCustomGhostParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__GetCustomGhostParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__GetCustomGhostParameter_NativeFunctionPtr, (void*)ptr);
			return new FLensflareSamplerActorGhostParameter(&ptr->__Result, true, true);
		}

		// Token: 0x0602A46E RID: 173166 RVA: 0x009DAF3C File Offset: 0x009D913C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual FLensflareSamplerActorGhostParameter GetCustomGhostParameter_Implementation()
		{
			BP_SceneLensflare_Motor_C.__GetCustomGhostParameter_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__GetCustomGhostParameter_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__GetCustomGhostParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__GetCustomGhostParameter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__GetCustomGhostParameter_NativeFunctionPtr, (void*)ptr, 0);
			return new FLensflareSamplerActorGhostParameter(&ptr->__Result, true, true);
		}

		// Token: 0x0602A46F RID: 173167 RVA: 0x009DAF8D File Offset: 0x009D918D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602A470 RID: 173168 RVA: 0x009DAFA1 File Offset: 0x009D91A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A471 RID: 173169 RVA: 0x009DAFB8 File Offset: 0x009D91B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyDynamicMaterialGhost(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGhost_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGhost_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGhost_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGhost_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGhost_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A472 RID: 173170 RVA: 0x009DB010 File Offset: 0x009D9210
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ApplyDynamicMaterialGhost_Implementation(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGhost_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGhost_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGhost_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGhost_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGhost_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A473 RID: 173171 RVA: 0x009DB068 File Offset: 0x009D9268
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyDynamicMaterialHalo(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialHalo_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialHalo_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialHalo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialHalo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialHalo_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A474 RID: 173172 RVA: 0x009DB0C0 File Offset: 0x009D92C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ApplyDynamicMaterialHalo_Implementation(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialHalo_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialHalo_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialHalo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialHalo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialHalo_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A475 RID: 173173 RVA: 0x009DB118 File Offset: 0x009D9318
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyDynamicMaterialGlare(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGlare_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGlare_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGlare_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGlare_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGlare_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A476 RID: 173174 RVA: 0x009DB170 File Offset: 0x009D9370
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ApplyDynamicMaterialGlare_Implementation(UMaterialInstanceDynamic DynMaterial)
		{
			BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGlare_FunctionParams* ptr = stackalloc BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGlare_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGlare_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGlare_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DynMaterial = ((DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLensflare_Motor_C.__ApplyDynamicMaterialGlare_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A477 RID: 173175 RVA: 0x009DB1C6 File Offset: 0x009D93C6
		protected BP_SceneLensflare_Motor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CA1 RID: 89249
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/Lensflare/BP_SceneLensflare_Motor.BP_SceneLensflare_Motor_C";

		// Token: 0x04015CA2 RID: 89250
		private static IntPtr _ClassPtr;

		// Token: 0x04015CA3 RID: 89251
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CA4 RID: 89252
		internal static int __PropertyOffset_1;

		// Token: 0x04015CA5 RID: 89253
		internal static int __PropertyOffset_2;

		// Token: 0x04015CA6 RID: 89254
		internal static int __PropertyOffset_3;

		// Token: 0x04015CA7 RID: 89255
		internal static int __PropertyOffset_4;

		// Token: 0x04015CA8 RID: 89256
		internal static int __PropertyOffset_5;

		// Token: 0x04015CA9 RID: 89257
		internal static int __PropertyOffset_6;

		// Token: 0x04015CAA RID: 89258
		internal static int __PropertyOffset_7;

		// Token: 0x04015CAB RID: 89259
		internal static int __PropertyOffset_8;

		// Token: 0x04015CAC RID: 89260
		internal static int __PropertyOffset_9;

		// Token: 0x04015CAD RID: 89261
		internal static int __PropertyOffset_10;

		// Token: 0x04015CAE RID: 89262
		internal static int __PropertyOffset_11;

		// Token: 0x04015CAF RID: 89263
		internal static int __PropertyOffset_12;

		// Token: 0x04015CB0 RID: 89264
		internal static int __PropertyOffset_13;

		// Token: 0x04015CB1 RID: 89265
		internal static int __PropertyOffset_14;

		// Token: 0x04015CB2 RID: 89266
		internal static int __PropertyOffset_15;

		// Token: 0x04015CB3 RID: 89267
		internal static int __PropertyOffset_16;

		// Token: 0x04015CB4 RID: 89268
		internal static int __PropertyOffset_17;

		// Token: 0x04015CB5 RID: 89269
		internal static int __PropertyOffset_18;

		// Token: 0x04015CB6 RID: 89270
		internal static int __PropertyOffset_19;

		// Token: 0x04015CB7 RID: 89271
		internal static int __PropertyOffset_20;

		// Token: 0x04015CB8 RID: 89272
		internal static int __PropertyOffset_21;

		// Token: 0x04015CB9 RID: 89273
		internal static int __PropertyOffset_22;

		// Token: 0x04015CBA RID: 89274
		internal static int __PropertyOffset_23;

		// Token: 0x04015CBB RID: 89275
		internal static int __PropertyOffset_24;

		// Token: 0x04015CBC RID: 89276
		internal static int __PropertyOffset_25;

		// Token: 0x04015CBD RID: 89277
		internal static int __PropertyOffset_26;

		// Token: 0x04015CBE RID: 89278
		internal static int __PropertyOffset_27;

		// Token: 0x04015CBF RID: 89279
		internal static int __PropertyOffset_28;

		// Token: 0x04015CC0 RID: 89280
		internal static int __PropertyOffset_29;

		// Token: 0x04015CC1 RID: 89281
		internal static int __PropertyOffset_30;

		// Token: 0x04015CC2 RID: 89282
		internal static int __PropertyOffset_31;

		// Token: 0x04015CC3 RID: 89283
		internal static int __PropertyOffset_32;

		// Token: 0x04015CC4 RID: 89284
		internal static int __PropertyOffset_33;

		// Token: 0x04015CC5 RID: 89285
		internal static int __PropertyOffset_34;

		// Token: 0x04015CC6 RID: 89286
		internal static int __PropertyOffset_35;

		// Token: 0x04015CC7 RID: 89287
		internal static int __PropertyOffset_36;

		// Token: 0x04015CC8 RID: 89288
		internal static int __PropertyOffset_37;

		// Token: 0x04015CC9 RID: 89289
		internal static int __PropertyOffset_38;

		// Token: 0x04015CCA RID: 89290
		internal static int __PropertyOffset_39;

		// Token: 0x04015CCB RID: 89291
		private static IntPtr __GetLensflareParameter_NativeFunctionPtr;

		// Token: 0x04015CCC RID: 89292
		private static IntPtr __GetCustomGlareParameter_NativeFunctionPtr;

		// Token: 0x04015CCD RID: 89293
		private static IntPtr __GetCustomHaloParameter_NativeFunctionPtr;

		// Token: 0x04015CCE RID: 89294
		private static IntPtr __GetCustomGhostParameter_NativeFunctionPtr;

		// Token: 0x04015CCF RID: 89295
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04015CD0 RID: 89296
		private static IntPtr __ApplyDynamicMaterialGhost_NativeFunctionPtr;

		// Token: 0x04015CD1 RID: 89297
		private static IntPtr __ApplyDynamicMaterialHalo_NativeFunctionPtr;

		// Token: 0x04015CD2 RID: 89298
		private static IntPtr __ApplyDynamicMaterialGlare_NativeFunctionPtr;

		// Token: 0x0200A352 RID: 41810
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected new ref struct __GetLensflareParameter_FunctionParams
		{
			// Token: 0x0403211A RID: 205082
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200A353 RID: 41811
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected new ref struct __GetCustomGlareParameter_FunctionParams
		{
			// Token: 0x0403211B RID: 205083
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200A354 RID: 41812
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected new ref struct __GetCustomHaloParameter_FunctionParams
		{
			// Token: 0x0403211C RID: 205084
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200A355 RID: 41813
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected new ref struct __GetCustomGhostParameter_FunctionParams
		{
			// Token: 0x0403211D RID: 205085
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200A356 RID: 41814
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ApplyDynamicMaterialGhost_FunctionParams
		{
			// Token: 0x0403211E RID: 205086
			[FieldOffset(0)]
			public IntPtr DynMaterial;
		}

		// Token: 0x0200A357 RID: 41815
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ApplyDynamicMaterialHalo_FunctionParams
		{
			// Token: 0x0403211F RID: 205087
			[FieldOffset(0)]
			public IntPtr DynMaterial;
		}

		// Token: 0x0200A358 RID: 41816
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ApplyDynamicMaterialGlare_FunctionParams
		{
			// Token: 0x04032120 RID: 205088
			[FieldOffset(0)]
			public IntPtr DynMaterial;
		}
	}
}
