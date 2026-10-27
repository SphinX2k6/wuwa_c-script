using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.In
{
	// Token: 0x02004101 RID: 16641
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv2.NCS_In_Lv2_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_In_Lv2_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADD6 RID: 175574 RVA: 0x009EDE40 File Offset: 0x009EC040
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_In_Lv2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv2.NCS_In_Lv2_C");
			}
			return NCS_In_Lv2_C._ClassPtr;
		}

		// Token: 0x0602ADD7 RID: 175575 RVA: 0x009EDE64 File Offset: 0x009EC064
		public NCS_In_Lv2_C() : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADD8 RID: 175576 RVA: 0x009EDE8C File Offset: 0x009EC08C
		[NullableContext(1)]
		public NCS_In_Lv2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADD9 RID: 175577 RVA: 0x009EDEBF File Offset: 0x009EC0BF
		protected NCS_In_Lv2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016363 RID: 90979
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv2.NCS_In_Lv2_C";

		// Token: 0x04016364 RID: 90980
		private static IntPtr _ClassPtr;

		// Token: 0x04016365 RID: 90981
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
