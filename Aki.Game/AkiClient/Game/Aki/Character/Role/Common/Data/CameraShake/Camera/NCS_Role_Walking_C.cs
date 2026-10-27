using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040C8 RID: 16584
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Walking.NCS_Role_Walking_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Role_Walking_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACF2 RID: 175346 RVA: 0x009EBFF8 File Offset: 0x009EA1F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Role_Walking_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Walking.NCS_Role_Walking_C");
			}
			return NCS_Role_Walking_C._ClassPtr;
		}

		// Token: 0x0602ACF3 RID: 175347 RVA: 0x009EC01C File Offset: 0x009EA21C
		public NCS_Role_Walking_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Walking_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACF4 RID: 175348 RVA: 0x009EC044 File Offset: 0x009EA244
		[NullableContext(1)]
		public NCS_Role_Walking_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Walking_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACF5 RID: 175349 RVA: 0x009EC077 File Offset: 0x009EA277
		protected NCS_Role_Walking_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162B8 RID: 90808
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Walking.NCS_Role_Walking_C";

		// Token: 0x040162B9 RID: 90809
		private static IntPtr _ClassPtr;

		// Token: 0x040162BA RID: 90810
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
