using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.AssestStruct
{
	// Token: 0x0200321D RID: 12829
	[UnrealObjectPath("/Game/Aki/Data/Fight/AssestStruct/BP_SplineMoveConfig.BP_SplineMoveConfig_C")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class BP_SplineMoveConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FFE0 RID: 131040 RVA: 0x0093A8A8 File Offset: 0x00938AA8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplineMoveConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Fight/AssestStruct/BP_SplineMoveConfig.BP_SplineMoveConfig_C");
			}
			return BP_SplineMoveConfig_C._ClassPtr;
		}

		// Token: 0x0601FFE1 RID: 131041 RVA: 0x0093A8CC File Offset: 0x00938ACC
		public BP_SplineMoveConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplineMoveConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FFE2 RID: 131042 RVA: 0x0093A8F4 File Offset: 0x00938AF4
		[NullableContext(1)]
		public BP_SplineMoveConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplineMoveConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003CA3 RID: 15523
		// (get) Token: 0x0601FFE3 RID: 131043 RVA: 0x0093A927 File Offset: 0x00938B27
		// (set) Token: 0x0601FFE4 RID: 131044 RVA: 0x0093A937 File Offset: 0x00938B37
		public unsafe float TurnRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_TurnRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_TurnRate) = value;
			}
		}

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x0601FFE5 RID: 131045 RVA: 0x0093A948 File Offset: 0x00938B48
		// (set) Token: 0x0601FFE6 RID: 131046 RVA: 0x0093A958 File Offset: 0x00938B58
		public unsafe float AirControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_AirControl);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_AirControl) = value;
			}
		}

		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x0601FFE7 RID: 131047 RVA: 0x0093A969 File Offset: 0x00938B69
		// (set) Token: 0x0601FFE8 RID: 131048 RVA: 0x0093A979 File Offset: 0x00938B79
		public unsafe float JumpHeightRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_JumpHeightRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_JumpHeightRate) = value;
			}
		}

		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x0601FFE9 RID: 131049 RVA: 0x0093A98A File Offset: 0x00938B8A
		// (set) Token: 0x0601FFEA RID: 131050 RVA: 0x0093A99A File Offset: 0x00938B9A
		public unsafe float JumpTimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_JumpTimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_JumpTimeScale) = value;
			}
		}

		// Token: 0x17003CA7 RID: 15527
		// (get) Token: 0x0601FFEB RID: 131051 RVA: 0x0093A9AB File Offset: 0x00938BAB
		// (set) Token: 0x0601FFEC RID: 131052 RVA: 0x0093A9BB File Offset: 0x00938BBB
		public unsafe float MaxFlySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_MaxFlySpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_MaxFlySpeed) = value;
			}
		}

		// Token: 0x17003CA8 RID: 15528
		// (get) Token: 0x0601FFED RID: 131053 RVA: 0x0093A9CC File Offset: 0x00938BCC
		// (set) Token: 0x0601FFEE RID: 131054 RVA: 0x0093A9DC File Offset: 0x00938BDC
		public unsafe float AnsAccel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_AnsAccel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMoveConfig_C.__PropertyOffset_AnsAccel) = value;
			}
		}

		// Token: 0x0601FFEF RID: 131055 RVA: 0x0093A9ED File Offset: 0x00938BED
		protected BP_SplineMoveConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011301 RID: 70401
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Fight/AssestStruct/BP_SplineMoveConfig.BP_SplineMoveConfig_C";

		// Token: 0x04011302 RID: 70402
		private static IntPtr _ClassPtr;

		// Token: 0x04011303 RID: 70403
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011304 RID: 70404
		internal static int __PropertyOffset_TurnRate;

		// Token: 0x04011305 RID: 70405
		internal static int __PropertyOffset_AirControl;

		// Token: 0x04011306 RID: 70406
		internal static int __PropertyOffset_JumpHeightRate;

		// Token: 0x04011307 RID: 70407
		internal static int __PropertyOffset_JumpTimeScale;

		// Token: 0x04011308 RID: 70408
		internal static int __PropertyOffset_MaxFlySpeed;

		// Token: 0x04011309 RID: 70409
		internal static int __PropertyOffset_AnsAccel;
	}
}
