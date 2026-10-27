using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040BF RID: 16575
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Frozen.NCS_Frozen_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Frozen_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACCE RID: 175310 RVA: 0x009EBB30 File Offset: 0x009E9D30
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Frozen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Frozen.NCS_Frozen_C");
			}
			return NCS_Frozen_C._ClassPtr;
		}

		// Token: 0x0602ACCF RID: 175311 RVA: 0x009EBB54 File Offset: 0x009E9D54
		public NCS_Frozen_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Frozen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACD0 RID: 175312 RVA: 0x009EBB7C File Offset: 0x009E9D7C
		[NullableContext(1)]
		public NCS_Frozen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Frozen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACD1 RID: 175313 RVA: 0x009EBBAF File Offset: 0x009E9DAF
		protected NCS_Frozen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401629D RID: 90781
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Frozen.NCS_Frozen_C";

		// Token: 0x0401629E RID: 90782
		private static IntPtr _ClassPtr;

		// Token: 0x0401629F RID: 90783
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
