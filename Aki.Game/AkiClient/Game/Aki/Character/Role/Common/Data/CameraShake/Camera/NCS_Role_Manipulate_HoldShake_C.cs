using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040C4 RID: 16580
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_HoldShake.NCS_Role_Manipulate_HoldShake_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Role_Manipulate_HoldShake_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACE2 RID: 175330 RVA: 0x009EBDD8 File Offset: 0x009E9FD8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Role_Manipulate_HoldShake_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_HoldShake.NCS_Role_Manipulate_HoldShake_C");
			}
			return NCS_Role_Manipulate_HoldShake_C._ClassPtr;
		}

		// Token: 0x0602ACE3 RID: 175331 RVA: 0x009EBDFC File Offset: 0x009E9FFC
		public NCS_Role_Manipulate_HoldShake_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Manipulate_HoldShake_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACE4 RID: 175332 RVA: 0x009EBE24 File Offset: 0x009EA024
		[NullableContext(1)]
		public NCS_Role_Manipulate_HoldShake_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Manipulate_HoldShake_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACE5 RID: 175333 RVA: 0x009EBE57 File Offset: 0x009EA057
		protected NCS_Role_Manipulate_HoldShake_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162AC RID: 90796
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_HoldShake.NCS_Role_Manipulate_HoldShake_C";

		// Token: 0x040162AD RID: 90797
		private static IntPtr _ClassPtr;

		// Token: 0x040162AE RID: 90798
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
