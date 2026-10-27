using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.In
{
	// Token: 0x02004105 RID: 16645
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv6.NCS_In_Lv6_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_In_Lv6_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADE6 RID: 175590 RVA: 0x009EE060 File Offset: 0x009EC260
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_In_Lv6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv6.NCS_In_Lv6_C");
			}
			return NCS_In_Lv6_C._ClassPtr;
		}

		// Token: 0x0602ADE7 RID: 175591 RVA: 0x009EE084 File Offset: 0x009EC284
		public NCS_In_Lv6_C() : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADE8 RID: 175592 RVA: 0x009EE0AC File Offset: 0x009EC2AC
		[NullableContext(1)]
		public NCS_In_Lv6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADE9 RID: 175593 RVA: 0x009EE0DF File Offset: 0x009EC2DF
		protected NCS_In_Lv6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401636F RID: 90991
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv6.NCS_In_Lv6_C";

		// Token: 0x04016370 RID: 90992
		private static IntPtr _ClassPtr;

		// Token: 0x04016371 RID: 90993
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
