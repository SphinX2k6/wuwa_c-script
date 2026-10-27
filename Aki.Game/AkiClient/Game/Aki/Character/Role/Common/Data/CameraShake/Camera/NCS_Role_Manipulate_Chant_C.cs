using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040C2 RID: 16578
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_Chant.NCS_Role_Manipulate_Chant_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Role_Manipulate_Chant_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACDA RID: 175322 RVA: 0x009EBCC8 File Offset: 0x009E9EC8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Role_Manipulate_Chant_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_Chant.NCS_Role_Manipulate_Chant_C");
			}
			return NCS_Role_Manipulate_Chant_C._ClassPtr;
		}

		// Token: 0x0602ACDB RID: 175323 RVA: 0x009EBCEC File Offset: 0x009E9EEC
		public NCS_Role_Manipulate_Chant_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Manipulate_Chant_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACDC RID: 175324 RVA: 0x009EBD14 File Offset: 0x009E9F14
		[NullableContext(1)]
		public NCS_Role_Manipulate_Chant_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Manipulate_Chant_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACDD RID: 175325 RVA: 0x009EBD47 File Offset: 0x009E9F47
		protected NCS_Role_Manipulate_Chant_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162A6 RID: 90790
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_Chant.NCS_Role_Manipulate_Chant_C";

		// Token: 0x040162A7 RID: 90791
		private static IntPtr _ClassPtr;

		// Token: 0x040162A8 RID: 90792
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
