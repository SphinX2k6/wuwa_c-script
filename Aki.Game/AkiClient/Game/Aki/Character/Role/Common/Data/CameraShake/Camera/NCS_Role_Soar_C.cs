using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040C7 RID: 16583
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Soar.NCS_Role_Soar_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Role_Soar_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACEE RID: 175342 RVA: 0x009EBF70 File Offset: 0x009EA170
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Role_Soar_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Soar.NCS_Role_Soar_C");
			}
			return NCS_Role_Soar_C._ClassPtr;
		}

		// Token: 0x0602ACEF RID: 175343 RVA: 0x009EBF94 File Offset: 0x009EA194
		public NCS_Role_Soar_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Soar_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACF0 RID: 175344 RVA: 0x009EBFBC File Offset: 0x009EA1BC
		[NullableContext(1)]
		public NCS_Role_Soar_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Soar_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACF1 RID: 175345 RVA: 0x009EBFEF File Offset: 0x009EA1EF
		protected NCS_Role_Soar_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162B5 RID: 90805
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Soar.NCS_Role_Soar_C";

		// Token: 0x040162B6 RID: 90806
		private static IntPtr _ClassPtr;

		// Token: 0x040162B7 RID: 90807
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
