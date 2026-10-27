using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040C0 RID: 16576
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_01.NCS_Role_01_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Role_01_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACD2 RID: 175314 RVA: 0x009EBBB8 File Offset: 0x009E9DB8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Role_01_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_01.NCS_Role_01_C");
			}
			return NCS_Role_01_C._ClassPtr;
		}

		// Token: 0x0602ACD3 RID: 175315 RVA: 0x009EBBDC File Offset: 0x009E9DDC
		public NCS_Role_01_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Role_01_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACD4 RID: 175316 RVA: 0x009EBC04 File Offset: 0x009E9E04
		[NullableContext(1)]
		public NCS_Role_01_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Role_01_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACD5 RID: 175317 RVA: 0x009EBC37 File Offset: 0x009E9E37
		protected NCS_Role_01_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162A0 RID: 90784
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_01.NCS_Role_01_C";

		// Token: 0x040162A1 RID: 90785
		private static IntPtr _ClassPtr;

		// Token: 0x040162A2 RID: 90786
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
