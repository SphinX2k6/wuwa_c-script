using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Down
{
	// Token: 0x0200410E RID: 16654
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv4.NCS_Down_Lv4_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Down_Lv4_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE0A RID: 175626 RVA: 0x009EE528 File Offset: 0x009EC728
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Down_Lv4_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv4.NCS_Down_Lv4_C");
			}
			return NCS_Down_Lv4_C._ClassPtr;
		}

		// Token: 0x0602AE0B RID: 175627 RVA: 0x009EE54C File Offset: 0x009EC74C
		public NCS_Down_Lv4_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv4_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE0C RID: 175628 RVA: 0x009EE574 File Offset: 0x009EC774
		[NullableContext(1)]
		public NCS_Down_Lv4_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv4_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AE0D RID: 175629 RVA: 0x009EE5A7 File Offset: 0x009EC7A7
		protected NCS_Down_Lv4_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401638A RID: 91018
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv4.NCS_Down_Lv4_C";

		// Token: 0x0401638B RID: 91019
		private static IntPtr _ClassPtr;

		// Token: 0x0401638C RID: 91020
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
