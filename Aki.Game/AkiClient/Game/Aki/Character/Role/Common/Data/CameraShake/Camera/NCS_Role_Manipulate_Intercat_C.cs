using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040C6 RID: 16582
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_Intercat.NCS_Role_Manipulate_Intercat_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Role_Manipulate_Intercat_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACEA RID: 175338 RVA: 0x009EBEE8 File Offset: 0x009EA0E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Role_Manipulate_Intercat_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_Intercat.NCS_Role_Manipulate_Intercat_C");
			}
			return NCS_Role_Manipulate_Intercat_C._ClassPtr;
		}

		// Token: 0x0602ACEB RID: 175339 RVA: 0x009EBF0C File Offset: 0x009EA10C
		public NCS_Role_Manipulate_Intercat_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Manipulate_Intercat_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACEC RID: 175340 RVA: 0x009EBF34 File Offset: 0x009EA134
		[NullableContext(1)]
		public NCS_Role_Manipulate_Intercat_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Role_Manipulate_Intercat_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACED RID: 175341 RVA: 0x009EBF67 File Offset: 0x009EA167
		protected NCS_Role_Manipulate_Intercat_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162B2 RID: 90802
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Manipulate_Intercat.NCS_Role_Manipulate_Intercat_C";

		// Token: 0x040162B3 RID: 90803
		private static IntPtr _ClassPtr;

		// Token: 0x040162B4 RID: 90804
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
