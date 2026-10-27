using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040C3 RID: 16579
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_Draw.NCS_Role_Manipulate_Draw_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Role_Manipulate_Draw_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACDE RID: 175326 RVA: 0x009EBD50 File Offset: 0x009E9F50
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Role_Manipulate_Draw_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_Draw.NCS_Role_Manipulate_Draw_C");
			}
			return NCS_Role_Manipulate_Draw_C._ClassPtr;
		}

		// Token: 0x0602ACDF RID: 175327 RVA: 0x009EBD74 File Offset: 0x009E9F74
		public NCS_Role_Manipulate_Draw_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Manipulate_Draw_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACE0 RID: 175328 RVA: 0x009EBD9C File Offset: 0x009E9F9C
		[NullableContext(1)]
		public NCS_Role_Manipulate_Draw_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Manipulate_Draw_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACE1 RID: 175329 RVA: 0x009EBDCF File Offset: 0x009E9FCF
		protected NCS_Role_Manipulate_Draw_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162A9 RID: 90793
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_Draw.NCS_Role_Manipulate_Draw_C";

		// Token: 0x040162AA RID: 90794
		private static IntPtr _ClassPtr;

		// Token: 0x040162AB RID: 90795
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
