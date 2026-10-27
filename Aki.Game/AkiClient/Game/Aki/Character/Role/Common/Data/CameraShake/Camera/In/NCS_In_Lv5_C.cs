using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.In
{
	// Token: 0x02004104 RID: 16644
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv5.NCS_In_Lv5_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_In_Lv5_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADE2 RID: 175586 RVA: 0x009EDFD8 File Offset: 0x009EC1D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_In_Lv5_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv5.NCS_In_Lv5_C");
			}
			return NCS_In_Lv5_C._ClassPtr;
		}

		// Token: 0x0602ADE3 RID: 175587 RVA: 0x009EDFFC File Offset: 0x009EC1FC
		public NCS_In_Lv5_C() : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv5_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADE4 RID: 175588 RVA: 0x009EE024 File Offset: 0x009EC224
		[NullableContext(1)]
		public NCS_In_Lv5_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv5_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADE5 RID: 175589 RVA: 0x009EE057 File Offset: 0x009EC257
		protected NCS_In_Lv5_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401636C RID: 90988
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv5.NCS_In_Lv5_C";

		// Token: 0x0401636D RID: 90989
		private static IntPtr _ClassPtr;

		// Token: 0x0401636E RID: 90990
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
