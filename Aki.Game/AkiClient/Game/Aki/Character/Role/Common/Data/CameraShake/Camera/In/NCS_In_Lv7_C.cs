using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.In
{
	// Token: 0x02004106 RID: 16646
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv7.NCS_In_Lv7_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_In_Lv7_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADEA RID: 175594 RVA: 0x009EE0E8 File Offset: 0x009EC2E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_In_Lv7_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv7.NCS_In_Lv7_C");
			}
			return NCS_In_Lv7_C._ClassPtr;
		}

		// Token: 0x0602ADEB RID: 175595 RVA: 0x009EE10C File Offset: 0x009EC30C
		public NCS_In_Lv7_C() : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv7_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADEC RID: 175596 RVA: 0x009EE134 File Offset: 0x009EC334
		[NullableContext(1)]
		public NCS_In_Lv7_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv7_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADED RID: 175597 RVA: 0x009EE167 File Offset: 0x009EC367
		protected NCS_In_Lv7_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016372 RID: 90994
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv7.NCS_In_Lv7_C";

		// Token: 0x04016373 RID: 90995
		private static IntPtr _ClassPtr;

		// Token: 0x04016374 RID: 90996
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
