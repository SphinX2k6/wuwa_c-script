using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040C1 RID: 16577
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_Cast.NCS_Role_Manipulate_Cast_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Role_Manipulate_Cast_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACD6 RID: 175318 RVA: 0x009EBC40 File Offset: 0x009E9E40
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Role_Manipulate_Cast_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_Cast.NCS_Role_Manipulate_Cast_C");
			}
			return NCS_Role_Manipulate_Cast_C._ClassPtr;
		}

		// Token: 0x0602ACD7 RID: 175319 RVA: 0x009EBC64 File Offset: 0x009E9E64
		public NCS_Role_Manipulate_Cast_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Manipulate_Cast_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACD8 RID: 175320 RVA: 0x009EBC8C File Offset: 0x009E9E8C
		[NullableContext(1)]
		public NCS_Role_Manipulate_Cast_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Manipulate_Cast_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACD9 RID: 175321 RVA: 0x009EBCBF File Offset: 0x009E9EBF
		protected NCS_Role_Manipulate_Cast_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162A3 RID: 90787
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_Cast.NCS_Role_Manipulate_Cast_C";

		// Token: 0x040162A4 RID: 90788
		private static IntPtr _ClassPtr;

		// Token: 0x040162A5 RID: 90789
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
