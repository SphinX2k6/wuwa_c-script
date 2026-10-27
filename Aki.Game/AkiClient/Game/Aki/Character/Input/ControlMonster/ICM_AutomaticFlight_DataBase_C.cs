using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Input.ControlMonster
{
	// Token: 0x02004263 RID: 16995
	[UnrealObjectPath("/Game/Aki/Character/Input/ControlMonster/ICM_AutomaticFlight_DataBase.ICM_AutomaticFlight_DataBase_C")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class ICM_AutomaticFlight_DataBase_C : UKuroBpDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C096 RID: 180374 RVA: 0x00A125BC File Offset: 0x00A107BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ICM_AutomaticFlight_DataBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Input/ControlMonster/ICM_AutomaticFlight_DataBase.ICM_AutomaticFlight_DataBase_C");
			}
			return ICM_AutomaticFlight_DataBase_C._ClassPtr;
		}

		// Token: 0x0602C097 RID: 180375 RVA: 0x00A125E0 File Offset: 0x00A107E0
		public ICM_AutomaticFlight_DataBase_C() : this(BuiltinUtils.AllocNativeUObject(ICM_AutomaticFlight_DataBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C098 RID: 180376 RVA: 0x00A12608 File Offset: 0x00A10808
		[NullableContext(1)]
		public ICM_AutomaticFlight_DataBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ICM_AutomaticFlight_DataBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D66 RID: 28006
		// (get) Token: 0x0602C099 RID: 180377 RVA: 0x00A1263B File Offset: 0x00A1083B
		// (set) Token: 0x0602C09A RID: 180378 RVA: 0x00A1264B File Offset: 0x00A1084B
		public unsafe float 低飞行速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006D67 RID: 28007
		// (get) Token: 0x0602C09B RID: 180379 RVA: 0x00A1265C File Offset: 0x00A1085C
		// (set) Token: 0x0602C09C RID: 180380 RVA: 0x00A1266C File Offset: 0x00A1086C
		public unsafe float 标准飞行速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006D68 RID: 28008
		// (get) Token: 0x0602C09D RID: 180381 RVA: 0x00A1267D File Offset: 0x00A1087D
		// (set) Token: 0x0602C09E RID: 180382 RVA: 0x00A1268D File Offset: 0x00A1088D
		public unsafe float 高飞行速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006D69 RID: 28009
		// (get) Token: 0x0602C09F RID: 180383 RVA: 0x00A1269E File Offset: 0x00A1089E
		// (set) Token: 0x0602C0A0 RID: 180384 RVA: 0x00A126B2 File Offset: 0x00A108B2
		[Nullable(2)]
		public unsafe UCurveVector 速度过渡曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + ICM_AutomaticFlight_DataBase_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ICM_AutomaticFlight_DataBase_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17006D6A RID: 28010
		// (get) Token: 0x0602C0A1 RID: 180385 RVA: 0x00A126C7 File Offset: 0x00A108C7
		// (set) Token: 0x0602C0A2 RID: 180386 RVA: 0x00A126D7 File Offset: 0x00A108D7
		public unsafe float 前向轴输入响应比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006D6B RID: 28011
		// (get) Token: 0x0602C0A3 RID: 180387 RVA: 0x00A126E8 File Offset: 0x00A108E8
		// (set) Token: 0x0602C0A4 RID: 180388 RVA: 0x00A126F8 File Offset: 0x00A108F8
		public unsafe int 前向轴输入响应技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006D6C RID: 28012
		// (get) Token: 0x0602C0A5 RID: 180389 RVA: 0x00A12709 File Offset: 0x00A10909
		// (set) Token: 0x0602C0A6 RID: 180390 RVA: 0x00A12719 File Offset: 0x00A10919
		public unsafe float 后向轴输入响应比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006D6D RID: 28013
		// (get) Token: 0x0602C0A7 RID: 180391 RVA: 0x00A1272A File Offset: 0x00A1092A
		// (set) Token: 0x0602C0A8 RID: 180392 RVA: 0x00A1273A File Offset: 0x00A1093A
		public unsafe int 后向轴输入响应技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x0602C0A9 RID: 180393 RVA: 0x00A1274B File Offset: 0x00A1094B
		protected ICM_AutomaticFlight_DataBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017042 RID: 94274
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Input/ControlMonster/ICM_AutomaticFlight_DataBase.ICM_AutomaticFlight_DataBase_C";

		// Token: 0x04017043 RID: 94275
		private static IntPtr _ClassPtr;

		// Token: 0x04017044 RID: 94276
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017045 RID: 94277
		internal static int __PropertyOffset_0;

		// Token: 0x04017046 RID: 94278
		internal static int __PropertyOffset_1;

		// Token: 0x04017047 RID: 94279
		internal static int __PropertyOffset_2;

		// Token: 0x04017048 RID: 94280
		internal static int __PropertyOffset_3;

		// Token: 0x04017049 RID: 94281
		internal static int __PropertyOffset_4;

		// Token: 0x0401704A RID: 94282
		internal static int __PropertyOffset_5;

		// Token: 0x0401704B RID: 94283
		internal static int __PropertyOffset_6;

		// Token: 0x0401704C RID: 94284
		internal static int __PropertyOffset_7;
	}
}
