using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.AssestStruct
{
	// Token: 0x02003F86 RID: 16262
	[UnrealObjectPath("/Game/Aki/Data/Fight/AssestStruct/BP_SplineMoveConfig.BP_SplineMoveConfig_C")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class BP_SplineMoveConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029834 RID: 170036 RVA: 0x009C5E54 File Offset: 0x009C4054
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplineMoveConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Fight/AssestStruct/BP_SplineMoveConfig.BP_SplineMoveConfig_C");
			}
			return BP_SplineMoveConfig_C._ClassPtr;
		}

		// Token: 0x06029835 RID: 170037 RVA: 0x009C5E78 File Offset: 0x009C4078
		public BP_SplineMoveConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplineMoveConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029836 RID: 170038 RVA: 0x009C5EA0 File Offset: 0x009C40A0
		[NullableContext(1)]
		public BP_SplineMoveConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplineMoveConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170063A8 RID: 25512
		// (get) Token: 0x06029837 RID: 170039 RVA: 0x009C5ED3 File Offset: 0x009C40D3
		// (set) Token: 0x06029838 RID: 170040 RVA: 0x009C5EE3 File Offset: 0x009C40E3
		public unsafe float TurnRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170063A9 RID: 25513
		// (get) Token: 0x06029839 RID: 170041 RVA: 0x009C5EF4 File Offset: 0x009C40F4
		// (set) Token: 0x0602983A RID: 170042 RVA: 0x009C5F04 File Offset: 0x009C4104
		public unsafe float AirControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170063AA RID: 25514
		// (get) Token: 0x0602983B RID: 170043 RVA: 0x009C5F15 File Offset: 0x009C4115
		// (set) Token: 0x0602983C RID: 170044 RVA: 0x009C5F25 File Offset: 0x009C4125
		public unsafe float JumpHeightRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170063AB RID: 25515
		// (get) Token: 0x0602983D RID: 170045 RVA: 0x009C5F36 File Offset: 0x009C4136
		// (set) Token: 0x0602983E RID: 170046 RVA: 0x009C5F46 File Offset: 0x009C4146
		public unsafe float JumpTimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170063AC RID: 25516
		// (get) Token: 0x0602983F RID: 170047 RVA: 0x009C5F57 File Offset: 0x009C4157
		// (set) Token: 0x06029840 RID: 170048 RVA: 0x009C5F67 File Offset: 0x009C4167
		public unsafe float MaxFlySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170063AD RID: 25517
		// (get) Token: 0x06029841 RID: 170049 RVA: 0x009C5F78 File Offset: 0x009C4178
		// (set) Token: 0x06029842 RID: 170050 RVA: 0x009C5F88 File Offset: 0x009C4188
		public unsafe float AnsAccel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x06029843 RID: 170051 RVA: 0x009C5F99 File Offset: 0x009C4199
		protected BP_SplineMoveConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015473 RID: 87155
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Fight/AssestStruct/BP_SplineMoveConfig.BP_SplineMoveConfig_C";

		// Token: 0x04015474 RID: 87156
		private static IntPtr _ClassPtr;

		// Token: 0x04015475 RID: 87157
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015476 RID: 87158
		internal static int __PropertyOffset_0;

		// Token: 0x04015477 RID: 87159
		internal static int __PropertyOffset_1;

		// Token: 0x04015478 RID: 87160
		internal static int __PropertyOffset_2;

		// Token: 0x04015479 RID: 87161
		internal static int __PropertyOffset_3;

		// Token: 0x0401547A RID: 87162
		internal static int __PropertyOffset_4;

		// Token: 0x0401547B RID: 87163
		internal static int __PropertyOffset_5;
	}
}
