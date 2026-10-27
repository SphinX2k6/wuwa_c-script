using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.In
{
	// Token: 0x02004107 RID: 16647
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv8.NCS_In_Lv8_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_In_Lv8_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADEE RID: 175598 RVA: 0x009EE170 File Offset: 0x009EC370
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_In_Lv8_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv8.NCS_In_Lv8_C");
			}
			return NCS_In_Lv8_C._ClassPtr;
		}

		// Token: 0x0602ADEF RID: 175599 RVA: 0x009EE194 File Offset: 0x009EC394
		public NCS_In_Lv8_C() : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv8_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADF0 RID: 175600 RVA: 0x009EE1BC File Offset: 0x009EC3BC
		[NullableContext(1)]
		public NCS_In_Lv8_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv8_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADF1 RID: 175601 RVA: 0x009EE1EF File Offset: 0x009EC3EF
		protected NCS_In_Lv8_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016375 RID: 90997
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv8.NCS_In_Lv8_C";

		// Token: 0x04016376 RID: 90998
		private static IntPtr _ClassPtr;

		// Token: 0x04016377 RID: 90999
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
