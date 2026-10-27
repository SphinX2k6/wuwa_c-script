using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Tuanzi.CommonConfig
{
	// Token: 0x0200418E RID: 16782
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Tuanzi/CommonConfig/BP_DangoGlobalConfig.BP_DangoGlobalConfig_C")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class BP_DangoGlobalConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B75C RID: 178012 RVA: 0x00A017EE File Offset: 0x009FF9EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DangoGlobalConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Tuanzi/CommonConfig/BP_DangoGlobalConfig.BP_DangoGlobalConfig_C");
			}
			return BP_DangoGlobalConfig_C._ClassPtr;
		}

		// Token: 0x0602B75D RID: 178013 RVA: 0x00A01814 File Offset: 0x009FFA14
		public BP_DangoGlobalConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_DangoGlobalConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B75E RID: 178014 RVA: 0x00A0183C File Offset: 0x009FFA3C
		[NullableContext(1)]
		public BP_DangoGlobalConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DangoGlobalConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B36 RID: 27446
		// (get) Token: 0x0602B75F RID: 178015 RVA: 0x00A0186F File Offset: 0x009FFA6F
		// (set) Token: 0x0602B760 RID: 178016 RVA: 0x00A0187F File Offset: 0x009FFA7F
		public unsafe int 跳跃前摇时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006B37 RID: 27447
		// (get) Token: 0x0602B761 RID: 178017 RVA: 0x00A01890 File Offset: 0x009FFA90
		// (set) Token: 0x0602B762 RID: 178018 RVA: 0x00A018A0 File Offset: 0x009FFAA0
		public unsafe int 跳跃移动时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006B38 RID: 27448
		// (get) Token: 0x0602B763 RID: 178019 RVA: 0x00A018B1 File Offset: 0x009FFAB1
		// (set) Token: 0x0602B764 RID: 178020 RVA: 0x00A018C1 File Offset: 0x009FFAC1
		public unsafe int 跳跃后摇时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006B39 RID: 27449
		// (get) Token: 0x0602B765 RID: 178021 RVA: 0x00A018D2 File Offset: 0x009FFAD2
		// (set) Token: 0x0602B766 RID: 178022 RVA: 0x00A018E2 File Offset: 0x009FFAE2
		public unsafe int 跳跃旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006B3A RID: 27450
		// (get) Token: 0x0602B767 RID: 178023 RVA: 0x00A018F3 File Offset: 0x009FFAF3
		// (set) Token: 0x0602B768 RID: 178024 RVA: 0x00A01903 File Offset: 0x009FFB03
		public unsafe int 跳跃高度偏移基准
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006B3B RID: 27451
		// (get) Token: 0x0602B769 RID: 178025 RVA: 0x00A01914 File Offset: 0x009FFB14
		// (set) Token: 0x0602B76A RID: 178026 RVA: 0x00A01924 File Offset: 0x009FFB24
		public unsafe int 跳跃上升偏移曲线高度范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006B3C RID: 27452
		// (get) Token: 0x0602B76B RID: 178027 RVA: 0x00A01935 File Offset: 0x009FFB35
		// (set) Token: 0x0602B76C RID: 178028 RVA: 0x00A01945 File Offset: 0x009FFB45
		public unsafe int 跳跃下降偏移曲线高度范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006B3D RID: 27453
		// (get) Token: 0x0602B76D RID: 178029 RVA: 0x00A01956 File Offset: 0x009FFB56
		// (set) Token: 0x0602B76E RID: 178030 RVA: 0x00A0196A File Offset: 0x009FFB6A
		public unsafe UCurveFloat 跳跃上升偏移曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DangoGlobalConfig_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DangoGlobalConfig_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17006B3E RID: 27454
		// (get) Token: 0x0602B76F RID: 178031 RVA: 0x00A0197F File Offset: 0x009FFB7F
		// (set) Token: 0x0602B770 RID: 178032 RVA: 0x00A01993 File Offset: 0x009FFB93
		public unsafe UCurveFloat 跳跃下降偏移曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DangoGlobalConfig_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DangoGlobalConfig_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17006B3F RID: 27455
		// (get) Token: 0x0602B771 RID: 178033 RVA: 0x00A019A8 File Offset: 0x009FFBA8
		// (set) Token: 0x0602B772 RID: 178034 RVA: 0x00A019B8 File Offset: 0x009FFBB8
		public unsafe int 跳跃中镜头臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006B40 RID: 27456
		// (get) Token: 0x0602B773 RID: 178035 RVA: 0x00A019C9 File Offset: 0x009FFBC9
		// (set) Token: 0x0602B774 RID: 178036 RVA: 0x00A019D9 File Offset: 0x009FFBD9
		public unsafe int 跳跃中镜头追踪时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006B41 RID: 27457
		// (get) Token: 0x0602B775 RID: 178037 RVA: 0x00A019EA File Offset: 0x009FFBEA
		// (set) Token: 0x0602B776 RID: 178038 RVA: 0x00A019FA File Offset: 0x009FFBFA
		public unsafe float 跳跃中镜头FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006B42 RID: 27458
		// (get) Token: 0x0602B777 RID: 178039 RVA: 0x00A01A0C File Offset: 0x009FFC0C
		// (set) Token: 0x0602B778 RID: 178040 RVA: 0x00A01A45 File Offset: 0x009FFC45
		[Nullable(1)]
		public SBaseCurve 跳跃中镜头曲线
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._跳跃中镜头曲线) == null)
				{
					result = (this._跳跃中镜头曲线 = new SBaseCurve(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_12, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006B43 RID: 27459
		// (get) Token: 0x0602B779 RID: 178041 RVA: 0x00A01A66 File Offset: 0x009FFC66
		// (set) Token: 0x0602B77A RID: 178042 RVA: 0x00A01A76 File Offset: 0x009FFC76
		public unsafe int 跳跃前镜头死区距离基准
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006B44 RID: 27460
		// (get) Token: 0x0602B77B RID: 178043 RVA: 0x00A01A87 File Offset: 0x009FFC87
		// (set) Token: 0x0602B77C RID: 178044 RVA: 0x00A01A97 File Offset: 0x009FFC97
		public unsafe int 跳跃前镜头臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006B45 RID: 27461
		// (get) Token: 0x0602B77D RID: 178045 RVA: 0x00A01AA8 File Offset: 0x009FFCA8
		// (set) Token: 0x0602B77E RID: 178046 RVA: 0x00A01ABC File Offset: 0x009FFCBC
		public unsafe FInt32Range 跳跃前镜头近距离基准范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006B46 RID: 27462
		// (get) Token: 0x0602B77F RID: 178047 RVA: 0x00A01AD1 File Offset: 0x009FFCD1
		// (set) Token: 0x0602B780 RID: 178048 RVA: 0x00A01AE5 File Offset: 0x009FFCE5
		public unsafe FInt32Range 跳跃前镜头近距离追踪时间范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006B47 RID: 27463
		// (get) Token: 0x0602B781 RID: 178049 RVA: 0x00A01AFA File Offset: 0x009FFCFA
		// (set) Token: 0x0602B782 RID: 178050 RVA: 0x00A01B0A File Offset: 0x009FFD0A
		public unsafe int 跳跃前镜头远距离基准
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006B48 RID: 27464
		// (get) Token: 0x0602B783 RID: 178051 RVA: 0x00A01B1B File Offset: 0x009FFD1B
		// (set) Token: 0x0602B784 RID: 178052 RVA: 0x00A01B2B File Offset: 0x009FFD2B
		public unsafe int 跳跃前镜头远距离追踪时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006B49 RID: 27465
		// (get) Token: 0x0602B785 RID: 178053 RVA: 0x00A01B3C File Offset: 0x009FFD3C
		// (set) Token: 0x0602B786 RID: 178054 RVA: 0x00A01B4C File Offset: 0x009FFD4C
		public unsafe float 跳跃前镜头FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006B4A RID: 27466
		// (get) Token: 0x0602B787 RID: 178055 RVA: 0x00A01B60 File Offset: 0x009FFD60
		// (set) Token: 0x0602B788 RID: 178056 RVA: 0x00A01B99 File Offset: 0x009FFD99
		[Nullable(1)]
		public SBaseCurve 跳跃前镜头曲线
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._跳跃前镜头曲线) == null)
				{
					result = (this._跳跃前镜头曲线 = new SBaseCurve(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_20, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_20, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006B4B RID: 27467
		// (get) Token: 0x0602B789 RID: 178057 RVA: 0x00A01BBC File Offset: 0x009FFDBC
		// (set) Token: 0x0602B78A RID: 178058 RVA: 0x00A01BF5 File Offset: 0x009FFDF5
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EDangoPerformType>, SDangoPerformData> 动作表现
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EDangoPerformType>, SDangoPerformData> result;
				if ((result = this._动作表现) == null)
				{
					result = (this._动作表现 = new TMap<TEnumAsByte<EDangoPerformType>, SDangoPerformData>(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_21, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.动作表现.CopyAssign(value);
			}
		}

		// Token: 0x17006B4C RID: 27468
		// (get) Token: 0x0602B78B RID: 178059 RVA: 0x00A01C03 File Offset: 0x009FFE03
		// (set) Token: 0x0602B78C RID: 178060 RVA: 0x00A01C17 File Offset: 0x009FFE17
		public unsafe FName 堆叠绑定骨骼名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17006B4D RID: 27469
		// (get) Token: 0x0602B78D RID: 178061 RVA: 0x00A01C2C File Offset: 0x009FFE2C
		// (set) Token: 0x0602B78E RID: 178062 RVA: 0x00A01C3C File Offset: 0x009FFE3C
		public unsafe int 堆叠间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DangoGlobalConfig_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17006B4E RID: 27470
		// (get) Token: 0x0602B78F RID: 178063 RVA: 0x00A01C4D File Offset: 0x009FFE4D
		// (set) Token: 0x0602B790 RID: 178064 RVA: 0x00A01C61 File Offset: 0x009FFE61
		public unsafe UCurveFloat 黑洞下降偏移曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DangoGlobalConfig_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DangoGlobalConfig_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x0602B791 RID: 178065 RVA: 0x00A01C76 File Offset: 0x009FFE76
		protected BP_DangoGlobalConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040169F6 RID: 92662
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Tuanzi/CommonConfig/BP_DangoGlobalConfig.BP_DangoGlobalConfig_C";

		// Token: 0x040169F7 RID: 92663
		private static IntPtr _ClassPtr;

		// Token: 0x040169F8 RID: 92664
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040169F9 RID: 92665
		internal static int __PropertyOffset_0;

		// Token: 0x040169FA RID: 92666
		internal static int __PropertyOffset_1;

		// Token: 0x040169FB RID: 92667
		internal static int __PropertyOffset_2;

		// Token: 0x040169FC RID: 92668
		internal static int __PropertyOffset_3;

		// Token: 0x040169FD RID: 92669
		internal static int __PropertyOffset_4;

		// Token: 0x040169FE RID: 92670
		internal static int __PropertyOffset_5;

		// Token: 0x040169FF RID: 92671
		internal static int __PropertyOffset_6;

		// Token: 0x04016A00 RID: 92672
		internal static int __PropertyOffset_7;

		// Token: 0x04016A01 RID: 92673
		internal static int __PropertyOffset_8;

		// Token: 0x04016A02 RID: 92674
		internal static int __PropertyOffset_9;

		// Token: 0x04016A03 RID: 92675
		internal static int __PropertyOffset_10;

		// Token: 0x04016A04 RID: 92676
		internal static int __PropertyOffset_11;

		// Token: 0x04016A05 RID: 92677
		internal static int __PropertyOffset_12;

		// Token: 0x04016A06 RID: 92678
		private SBaseCurve _跳跃中镜头曲线;

		// Token: 0x04016A07 RID: 92679
		internal static int __PropertyOffset_13;

		// Token: 0x04016A08 RID: 92680
		internal static int __PropertyOffset_14;

		// Token: 0x04016A09 RID: 92681
		internal static int __PropertyOffset_15;

		// Token: 0x04016A0A RID: 92682
		internal static int __PropertyOffset_16;

		// Token: 0x04016A0B RID: 92683
		internal static int __PropertyOffset_17;

		// Token: 0x04016A0C RID: 92684
		internal static int __PropertyOffset_18;

		// Token: 0x04016A0D RID: 92685
		internal static int __PropertyOffset_19;

		// Token: 0x04016A0E RID: 92686
		internal static int __PropertyOffset_20;

		// Token: 0x04016A0F RID: 92687
		private SBaseCurve _跳跃前镜头曲线;

		// Token: 0x04016A10 RID: 92688
		internal static int __PropertyOffset_21;

		// Token: 0x04016A11 RID: 92689
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EDangoPerformType>, SDangoPerformData> _动作表现;

		// Token: 0x04016A12 RID: 92690
		internal static int __PropertyOffset_22;

		// Token: 0x04016A13 RID: 92691
		internal static int __PropertyOffset_23;

		// Token: 0x04016A14 RID: 92692
		internal static int __PropertyOffset_24;
	}
}
