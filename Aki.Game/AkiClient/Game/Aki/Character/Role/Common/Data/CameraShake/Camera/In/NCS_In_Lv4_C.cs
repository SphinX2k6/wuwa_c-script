using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.In
{
	// Token: 0x02004103 RID: 16643
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv4.NCS_In_Lv4_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_In_Lv4_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADDE RID: 175582 RVA: 0x009EDF50 File Offset: 0x009EC150
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_In_Lv4_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv4.NCS_In_Lv4_C");
			}
			return NCS_In_Lv4_C._ClassPtr;
		}

		// Token: 0x0602ADDF RID: 175583 RVA: 0x009EDF74 File Offset: 0x009EC174
		public NCS_In_Lv4_C() : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv4_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADE0 RID: 175584 RVA: 0x009EDF9C File Offset: 0x009EC19C
		[NullableContext(1)]
		public NCS_In_Lv4_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv4_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADE1 RID: 175585 RVA: 0x009EDFCF File Offset: 0x009EC1CF
		protected NCS_In_Lv4_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016369 RID: 90985
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv4.NCS_In_Lv4_C";

		// Token: 0x0401636A RID: 90986
		private static IntPtr _ClassPtr;

		// Token: 0x0401636B RID: 90987
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
