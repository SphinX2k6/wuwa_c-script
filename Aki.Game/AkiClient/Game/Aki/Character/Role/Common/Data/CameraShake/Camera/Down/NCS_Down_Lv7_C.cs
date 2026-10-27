using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Down
{
	// Token: 0x02004111 RID: 16657
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv7.NCS_Down_Lv7_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Down_Lv7_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE16 RID: 175638 RVA: 0x009EE6C0 File Offset: 0x009EC8C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Down_Lv7_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv7.NCS_Down_Lv7_C");
			}
			return NCS_Down_Lv7_C._ClassPtr;
		}

		// Token: 0x0602AE17 RID: 175639 RVA: 0x009EE6E4 File Offset: 0x009EC8E4
		public NCS_Down_Lv7_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv7_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE18 RID: 175640 RVA: 0x009EE70C File Offset: 0x009EC90C
		[NullableContext(1)]
		public NCS_Down_Lv7_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv7_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AE19 RID: 175641 RVA: 0x009EE73F File Offset: 0x009EC93F
		protected NCS_Down_Lv7_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016393 RID: 91027
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv7.NCS_Down_Lv7_C";

		// Token: 0x04016394 RID: 91028
		private static IntPtr _ClassPtr;

		// Token: 0x04016395 RID: 91029
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
