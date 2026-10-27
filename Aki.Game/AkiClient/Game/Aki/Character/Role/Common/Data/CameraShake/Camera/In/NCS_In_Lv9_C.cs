using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.In
{
	// Token: 0x02004108 RID: 16648
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv9.NCS_In_Lv9_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_In_Lv9_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADF2 RID: 175602 RVA: 0x009EE1F8 File Offset: 0x009EC3F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_In_Lv9_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv9.NCS_In_Lv9_C");
			}
			return NCS_In_Lv9_C._ClassPtr;
		}

		// Token: 0x0602ADF3 RID: 175603 RVA: 0x009EE21C File Offset: 0x009EC41C
		public NCS_In_Lv9_C() : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv9_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADF4 RID: 175604 RVA: 0x009EE244 File Offset: 0x009EC444
		[NullableContext(1)]
		public NCS_In_Lv9_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv9_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADF5 RID: 175605 RVA: 0x009EE277 File Offset: 0x009EC477
		protected NCS_In_Lv9_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016378 RID: 91000
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv9.NCS_In_Lv9_C";

		// Token: 0x04016379 RID: 91001
		private static IntPtr _ClassPtr;

		// Token: 0x0401637A RID: 91002
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
