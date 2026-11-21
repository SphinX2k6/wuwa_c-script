using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Input.Blueprints
{
	// Token: 0x020032D6 RID: 13014
	[UnrealObjectPath("/Game/Aki/Character/Input/Blueprints/BP_CameraDrivenAutoFlightData.BP_CameraDrivenAutoFlightData_C")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 108)]
	public class BP_CameraDrivenAutoFlightData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020F6E RID: 135022 RVA: 0x00953A30 File Offset: 0x00951C30
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CameraDrivenAutoFlightData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Input/Blueprints/BP_CameraDrivenAutoFlightData.BP_CameraDrivenAutoFlightData_C");
			}
			return BP_CameraDrivenAutoFlightData_C._ClassPtr;
		}

		// Token: 0x06020F6F RID: 135023 RVA: 0x00953A54 File Offset: 0x00951C54
		public BP_CameraDrivenAutoFlightData_C() : this(BuiltinUtils.AllocNativeUObject(BP_CameraDrivenAutoFlightData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020F70 RID: 135024 RVA: 0x00953A7C File Offset: 0x00951C7C
		[NullableContext(1)]
		public BP_CameraDrivenAutoFlightData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CameraDrivenAutoFlightData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041F2 RID: 16882
		// (get) Token: 0x06020F71 RID: 135025 RVA: 0x00953AAF File Offset: 0x00951CAF
		// (set) Token: 0x06020F72 RID: 135026 RVA: 0x00953ABF File Offset: 0x00951CBF
		public unsafe float 自动驾驶开始时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶开始时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶开始时间) = value;
			}
		}

		// Token: 0x170041F3 RID: 16883
		// (get) Token: 0x06020F73 RID: 135027 RVA: 0x00953AD0 File Offset: 0x00951CD0
		// (set) Token: 0x06020F74 RID: 135028 RVA: 0x00953AE0 File Offset: 0x00951CE0
		public unsafe float 自动驾驶启动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶启动输入);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶启动输入) = value;
			}
		}

		// Token: 0x170041F4 RID: 16884
		// (get) Token: 0x06020F75 RID: 135029 RVA: 0x00953AF1 File Offset: 0x00951CF1
		// (set) Token: 0x06020F76 RID: 135030 RVA: 0x00953B01 File Offset: 0x00951D01
		public unsafe float 自动驾驶完成角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶完成角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶完成角度) = value;
			}
		}

		// Token: 0x170041F5 RID: 16885
		// (get) Token: 0x06020F77 RID: 135031 RVA: 0x00953B12 File Offset: 0x00951D12
		// (set) Token: 0x06020F78 RID: 135032 RVA: 0x00953B22 File Offset: 0x00951D22
		public unsafe float 自动驾驶归正角度Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶归正角度Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶归正角度Min) = value;
			}
		}

		// Token: 0x170041F6 RID: 16886
		// (get) Token: 0x06020F79 RID: 135033 RVA: 0x00953B33 File Offset: 0x00951D33
		// (set) Token: 0x06020F7A RID: 135034 RVA: 0x00953B43 File Offset: 0x00951D43
		public unsafe float 自动驾驶归正角度Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶归正角度Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶归正角度Max) = value;
			}
		}

		// Token: 0x170041F7 RID: 16887
		// (get) Token: 0x06020F7B RID: 135035 RVA: 0x00953B54 File Offset: 0x00951D54
		// (set) Token: 0x06020F7C RID: 135036 RVA: 0x00953B64 File Offset: 0x00951D64
		public unsafe float 自动驾驶归正角度模拟输入Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶归正角度模拟输入Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶归正角度模拟输入Min) = value;
			}
		}

		// Token: 0x170041F8 RID: 16888
		// (get) Token: 0x06020F7D RID: 135037 RVA: 0x00953B75 File Offset: 0x00951D75
		// (set) Token: 0x06020F7E RID: 135038 RVA: 0x00953B85 File Offset: 0x00951D85
		public unsafe float 自动驾驶归正角度模拟输入Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶归正角度模拟输入Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraDrivenAutoFlightData_C.__PropertyOffset_自动驾驶归正角度模拟输入Max) = value;
			}
		}

		// Token: 0x06020F7F RID: 135039 RVA: 0x00953B96 File Offset: 0x00951D96
		protected BP_CameraDrivenAutoFlightData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011DE5 RID: 73189
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Input/Blueprints/BP_CameraDrivenAutoFlightData.BP_CameraDrivenAutoFlightData_C";

		// Token: 0x04011DE6 RID: 73190
		private static IntPtr _ClassPtr;

		// Token: 0x04011DE7 RID: 73191
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011DE8 RID: 73192
		internal static int __PropertyOffset_自动驾驶开始时间;

		// Token: 0x04011DE9 RID: 73193
		internal static int __PropertyOffset_自动驾驶启动输入;

		// Token: 0x04011DEA RID: 73194
		internal static int __PropertyOffset_自动驾驶完成角度;

		// Token: 0x04011DEB RID: 73195
		internal static int __PropertyOffset_自动驾驶归正角度Min;

		// Token: 0x04011DEC RID: 73196
		internal static int __PropertyOffset_自动驾驶归正角度Max;

		// Token: 0x04011DED RID: 73197
		internal static int __PropertyOffset_自动驾驶归正角度模拟输入Min;

		// Token: 0x04011DEE RID: 73198
		internal static int __PropertyOffset_自动驾驶归正角度模拟输入Max;
	}
}
