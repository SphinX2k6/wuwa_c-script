using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Down
{
	// Token: 0x0200410C RID: 16652
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv2.NCS_Down_Lv2_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Down_Lv2_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE02 RID: 175618 RVA: 0x009EE418 File Offset: 0x009EC618
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Down_Lv2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv2.NCS_Down_Lv2_C");
			}
			return NCS_Down_Lv2_C._ClassPtr;
		}

		// Token: 0x0602AE03 RID: 175619 RVA: 0x009EE43C File Offset: 0x009EC63C
		public NCS_Down_Lv2_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE04 RID: 175620 RVA: 0x009EE464 File Offset: 0x009EC664
		[NullableContext(1)]
		public NCS_Down_Lv2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AE05 RID: 175621 RVA: 0x009EE497 File Offset: 0x009EC697
		protected NCS_Down_Lv2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016384 RID: 91012
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv2.NCS_Down_Lv2_C";

		// Token: 0x04016385 RID: 91013
		private static IntPtr _ClassPtr;

		// Token: 0x04016386 RID: 91014
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
