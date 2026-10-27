using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Input.Blueprints
{
	// Token: 0x02004265 RID: 16997
	[UnrealObjectPath("/Game/Aki/Character/Input/Blueprints/BP_CameraDrivenAutoFlightData.BP_CameraDrivenAutoFlightData_C")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 108)]
	public class BP_CameraDrivenAutoFlightData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C0B0 RID: 180400 RVA: 0x00A128C1 File Offset: 0x00A10AC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CameraDrivenAutoFlightData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Input/Blueprints/BP_CameraDrivenAutoFlightData.BP_CameraDrivenAutoFlightData_C");
			}
			return BP_CameraDrivenAutoFlightData_C._ClassPtr;
		}

		// Token: 0x0602C0B1 RID: 180401 RVA: 0x00A128E8 File Offset: 0x00A10AE8
		public BP_CameraDrivenAutoFlightData_C() : this(BuiltinUtils.AllocNativeUObject(BP_CameraDrivenAutoFlightData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C0B2 RID: 180402 RVA: 0x00A12910 File Offset: 0x00A10B10
		[NullableContext(1)]
		public BP_CameraDrivenAutoFlightData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CameraDrivenAutoFlightData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D6E RID: 28014
		// (get) Token: 0x0602C0B3 RID: 180403 RVA: 0x00A12943 File Offset: 0x00A10B43
		// (set) Token: 0x0602C0B4 RID: 180404 RVA: 0x00A12953 File Offset: 0x00A10B53
		public unsafe float 自动驾驶开始时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006D6F RID: 28015
		// (get) Token: 0x0602C0B5 RID: 180405 RVA: 0x00A12964 File Offset: 0x00A10B64
		// (set) Token: 0x0602C0B6 RID: 180406 RVA: 0x00A12974 File Offset: 0x00A10B74
		public unsafe float 自动驾驶启动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006D70 RID: 28016
		// (get) Token: 0x0602C0B7 RID: 180407 RVA: 0x00A12985 File Offset: 0x00A10B85
		// (set) Token: 0x0602C0B8 RID: 180408 RVA: 0x00A12995 File Offset: 0x00A10B95
		public unsafe float 自动驾驶完成角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006D71 RID: 28017
		// (get) Token: 0x0602C0B9 RID: 180409 RVA: 0x00A129A6 File Offset: 0x00A10BA6
		// (set) Token: 0x0602C0BA RID: 180410 RVA: 0x00A129B6 File Offset: 0x00A10BB6
		public unsafe float 自动驾驶归正角度Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006D72 RID: 28018
		// (get) Token: 0x0602C0BB RID: 180411 RVA: 0x00A129C7 File Offset: 0x00A10BC7
		// (set) Token: 0x0602C0BC RID: 180412 RVA: 0x00A129D7 File Offset: 0x00A10BD7
		public unsafe float 自动驾驶归正角度Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006D73 RID: 28019
		// (get) Token: 0x0602C0BD RID: 180413 RVA: 0x00A129E8 File Offset: 0x00A10BE8
		// (set) Token: 0x0602C0BE RID: 180414 RVA: 0x00A129F8 File Offset: 0x00A10BF8
		public unsafe float 自动驾驶归正角度模拟输入Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006D74 RID: 28020
		// (get) Token: 0x0602C0BF RID: 180415 RVA: 0x00A12A09 File Offset: 0x00A10C09
		// (set) Token: 0x0602C0C0 RID: 180416 RVA: 0x00A12A19 File Offset: 0x00A10C19
		public unsafe float 自动驾驶归正角度模拟输入Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x0602C0C1 RID: 180417 RVA: 0x00A12A2A File Offset: 0x00A10C2A
		protected BP_CameraDrivenAutoFlightData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017052 RID: 94290
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Input/Blueprints/BP_CameraDrivenAutoFlightData.BP_CameraDrivenAutoFlightData_C";

		// Token: 0x04017053 RID: 94291
		private static IntPtr _ClassPtr;

		// Token: 0x04017054 RID: 94292
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017055 RID: 94293
		internal static int __PropertyOffset_0;

		// Token: 0x04017056 RID: 94294
		internal static int __PropertyOffset_1;

		// Token: 0x04017057 RID: 94295
		internal static int __PropertyOffset_2;

		// Token: 0x04017058 RID: 94296
		internal static int __PropertyOffset_3;

		// Token: 0x04017059 RID: 94297
		internal static int __PropertyOffset_4;

		// Token: 0x0401705A RID: 94298
		internal static int __PropertyOffset_5;

		// Token: 0x0401705B RID: 94299
		internal static int __PropertyOffset_6;
	}
}
