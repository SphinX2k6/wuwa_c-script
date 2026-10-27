using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.In
{
	// Token: 0x02004102 RID: 16642
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv3.NCS_In_Lv3_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_In_Lv3_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADDA RID: 175578 RVA: 0x009EDEC8 File Offset: 0x009EC0C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_In_Lv3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv3.NCS_In_Lv3_C");
			}
			return NCS_In_Lv3_C._ClassPtr;
		}

		// Token: 0x0602ADDB RID: 175579 RVA: 0x009EDEEC File Offset: 0x009EC0EC
		public NCS_In_Lv3_C() : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADDC RID: 175580 RVA: 0x009EDF14 File Offset: 0x009EC114
		[NullableContext(1)]
		public NCS_In_Lv3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADDD RID: 175581 RVA: 0x009EDF47 File Offset: 0x009EC147
		protected NCS_In_Lv3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016366 RID: 90982
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv3.NCS_In_Lv3_C";

		// Token: 0x04016367 RID: 90983
		private static IntPtr _ClassPtr;

		// Token: 0x04016368 RID: 90984
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
