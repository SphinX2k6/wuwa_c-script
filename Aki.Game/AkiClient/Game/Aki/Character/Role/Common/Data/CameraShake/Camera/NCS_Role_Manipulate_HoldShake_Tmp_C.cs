using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040C5 RID: 16581
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_HoldShake_Tmp.NCS_Role_Manipulate_HoldShake_Tmp_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Role_Manipulate_HoldShake_Tmp_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACE6 RID: 175334 RVA: 0x009EBE60 File Offset: 0x009EA060
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Role_Manipulate_HoldShake_Tmp_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_HoldShake_Tmp.NCS_Role_Manipulate_HoldShake_Tmp_C");
			}
			return NCS_Role_Manipulate_HoldShake_Tmp_C._ClassPtr;
		}

		// Token: 0x0602ACE7 RID: 175335 RVA: 0x009EBE84 File Offset: 0x009EA084
		public NCS_Role_Manipulate_HoldShake_Tmp_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Manipulate_HoldShake_Tmp_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACE8 RID: 175336 RVA: 0x009EBEAC File Offset: 0x009EA0AC
		[NullableContext(1)]
		public NCS_Role_Manipulate_HoldShake_Tmp_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Manipulate_HoldShake_Tmp_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACE9 RID: 175337 RVA: 0x009EBEDF File Offset: 0x009EA0DF
		protected NCS_Role_Manipulate_HoldShake_Tmp_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162AF RID: 90799
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_HoldShake_Tmp.NCS_Role_Manipulate_HoldShake_Tmp_C";

		// Token: 0x040162B0 RID: 90800
		private static IntPtr _ClassPtr;

		// Token: 0x040162B1 RID: 90801
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
