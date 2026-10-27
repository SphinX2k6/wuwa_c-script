using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Monster.Boss.MB1TianyanhuanxinMd00311
{
	// Token: 0x02004254 RID: 16980
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Monster/Boss/MB1TianyanhuanxinMd00311/BP_MB1TianyanhuanxinMd00311.BP_MB1TianyanhuanxinMd00311_C")]
	[UnrealStructLayout(2368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2360)]
	public class BP_MB1TianyanhuanxinMd00311_C : __TsBaseCharacter_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BFD1 RID: 180177 RVA: 0x00A111C8 File Offset: 0x00A0F3C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MB1TianyanhuanxinMd00311_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Monster/Boss/MB1TianyanhuanxinMd00311/BP_MB1TianyanhuanxinMd00311.BP_MB1TianyanhuanxinMd00311_C");
			}
			return BP_MB1TianyanhuanxinMd00311_C._ClassPtr;
		}

		// Token: 0x0602BFD2 RID: 180178 RVA: 0x00A111EC File Offset: 0x00A0F3EC
		public BP_MB1TianyanhuanxinMd00311_C() : this(BuiltinUtils.AllocNativeUObject(BP_MB1TianyanhuanxinMd00311_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BFD3 RID: 180179 RVA: 0x00A11214 File Offset: 0x00A0F414
		[NullableContext(1)]
		public BP_MB1TianyanhuanxinMd00311_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MB1TianyanhuanxinMd00311_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D2E RID: 27950
		// (get) Token: 0x0602BFD4 RID: 180180 RVA: 0x00A11247 File Offset: 0x00A0F447
		// (set) Token: 0x0602BFD5 RID: 180181 RVA: 0x00A1125B File Offset: 0x00A0F45B
		public unsafe UKuroRegionSphereComponent 定制BUFF
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRegionSphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006D2F RID: 27951
		// (get) Token: 0x0602BFD6 RID: 180182 RVA: 0x00A11270 File Offset: 0x00A0F470
		// (set) Token: 0x0602BFD7 RID: 180183 RVA: 0x00A11284 File Offset: 0x00A0F484
		public unsafe UKuroAdjustableCapsuleComponent Bone_Tail
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006D30 RID: 27952
		// (get) Token: 0x0602BFD8 RID: 180184 RVA: 0x00A11299 File Offset: 0x00A0F499
		// (set) Token: 0x0602BFD9 RID: 180185 RVA: 0x00A112AD File Offset: 0x00A0F4AD
		public unsafe UKuroRegionSphereComponent 镜头子弹
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRegionSphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006D31 RID: 27953
		// (get) Token: 0x0602BFDA RID: 180186 RVA: 0x00A112C2 File Offset: 0x00A0F4C2
		// (set) Token: 0x0602BFDB RID: 180187 RVA: 0x00A112D6 File Offset: 0x00A0F4D6
		public unsafe UKuroRegionDetectComponent KuroRegionDetect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRegionDetectComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17006D32 RID: 27954
		// (get) Token: 0x0602BFDC RID: 180188 RVA: 0x00A112EB File Offset: 0x00A0F4EB
		// (set) Token: 0x0602BFDD RID: 180189 RVA: 0x00A112FF File Offset: 0x00A0F4FF
		public unsafe UKuroAdjustableBoxComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAdjustableBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17006D33 RID: 27955
		// (get) Token: 0x0602BFDE RID: 180190 RVA: 0x00A11314 File Offset: 0x00A0F514
		// (set) Token: 0x0602BFDF RID: 180191 RVA: 0x00A11328 File Offset: 0x00A0F528
		public unsafe UCapsuleComponent Bip001LCalf
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17006D34 RID: 27956
		// (get) Token: 0x0602BFE0 RID: 180192 RVA: 0x00A1133D File Offset: 0x00A0F53D
		// (set) Token: 0x0602BFE1 RID: 180193 RVA: 0x00A11351 File Offset: 0x00A0F551
		public unsafe UCapsuleComponent Bip001LThigh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17006D35 RID: 27957
		// (get) Token: 0x0602BFE2 RID: 180194 RVA: 0x00A11366 File Offset: 0x00A0F566
		// (set) Token: 0x0602BFE3 RID: 180195 RVA: 0x00A1137A File Offset: 0x00A0F57A
		public unsafe UCapsuleComponent Bip001RCalf
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17006D36 RID: 27958
		// (get) Token: 0x0602BFE4 RID: 180196 RVA: 0x00A1138F File Offset: 0x00A0F58F
		// (set) Token: 0x0602BFE5 RID: 180197 RVA: 0x00A113A3 File Offset: 0x00A0F5A3
		public unsafe UCapsuleComponent Bip001RThigh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17006D37 RID: 27959
		// (get) Token: 0x0602BFE6 RID: 180198 RVA: 0x00A113B8 File Offset: 0x00A0F5B8
		// (set) Token: 0x0602BFE7 RID: 180199 RVA: 0x00A113CC File Offset: 0x00A0F5CC
		public unsafe UCapsuleComponent Bip001LForearm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17006D38 RID: 27960
		// (get) Token: 0x0602BFE8 RID: 180200 RVA: 0x00A113E1 File Offset: 0x00A0F5E1
		// (set) Token: 0x0602BFE9 RID: 180201 RVA: 0x00A113F5 File Offset: 0x00A0F5F5
		public unsafe UCapsuleComponent Bip001LUpperArm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17006D39 RID: 27961
		// (get) Token: 0x0602BFEA RID: 180202 RVA: 0x00A1140A File Offset: 0x00A0F60A
		// (set) Token: 0x0602BFEB RID: 180203 RVA: 0x00A1141E File Offset: 0x00A0F61E
		public unsafe UCapsuleComponent Bip001RForearm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17006D3A RID: 27962
		// (get) Token: 0x0602BFEC RID: 180204 RVA: 0x00A11433 File Offset: 0x00A0F633
		// (set) Token: 0x0602BFED RID: 180205 RVA: 0x00A11447 File Offset: 0x00A0F647
		public unsafe UCapsuleComponent Bip001RUpperArm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17006D3B RID: 27963
		// (get) Token: 0x0602BFEE RID: 180206 RVA: 0x00A1145C File Offset: 0x00A0F65C
		// (set) Token: 0x0602BFEF RID: 180207 RVA: 0x00A11470 File Offset: 0x00A0F670
		public unsafe UCapsuleComponent Bip001Spine2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17006D3C RID: 27964
		// (get) Token: 0x0602BFF0 RID: 180208 RVA: 0x00A11485 File Offset: 0x00A0F685
		// (set) Token: 0x0602BFF1 RID: 180209 RVA: 0x00A11499 File Offset: 0x00A0F699
		public unsafe UCapsuleComponent Bip001Head
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MB1TianyanhuanxinMd00311_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x0602BFF2 RID: 180210 RVA: 0x00A114AE File Offset: 0x00A0F6AE
		protected BP_MB1TianyanhuanxinMd00311_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F9A RID: 94106
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Monster/Boss/MB1TianyanhuanxinMd00311/BP_MB1TianyanhuanxinMd00311.BP_MB1TianyanhuanxinMd00311_C";

		// Token: 0x04016F9B RID: 94107
		private static IntPtr _ClassPtr;

		// Token: 0x04016F9C RID: 94108
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016F9D RID: 94109
		internal static int __PropertyOffset_0;

		// Token: 0x04016F9E RID: 94110
		internal static int __PropertyOffset_1;

		// Token: 0x04016F9F RID: 94111
		internal static int __PropertyOffset_2;

		// Token: 0x04016FA0 RID: 94112
		internal static int __PropertyOffset_3;

		// Token: 0x04016FA1 RID: 94113
		internal static int __PropertyOffset_4;

		// Token: 0x04016FA2 RID: 94114
		internal static int __PropertyOffset_5;

		// Token: 0x04016FA3 RID: 94115
		internal static int __PropertyOffset_6;

		// Token: 0x04016FA4 RID: 94116
		internal static int __PropertyOffset_7;

		// Token: 0x04016FA5 RID: 94117
		internal static int __PropertyOffset_8;

		// Token: 0x04016FA6 RID: 94118
		internal static int __PropertyOffset_9;

		// Token: 0x04016FA7 RID: 94119
		internal static int __PropertyOffset_10;

		// Token: 0x04016FA8 RID: 94120
		internal static int __PropertyOffset_11;

		// Token: 0x04016FA9 RID: 94121
		internal static int __PropertyOffset_12;

		// Token: 0x04016FAA RID: 94122
		internal static int __PropertyOffset_13;

		// Token: 0x04016FAB RID: 94123
		internal static int __PropertyOffset_14;
	}
}
