using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Down
{
	// Token: 0x02004110 RID: 16656
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv6.NCS_Down_Lv6_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Down_Lv6_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE12 RID: 175634 RVA: 0x009EE638 File Offset: 0x009EC838
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Down_Lv6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv6.NCS_Down_Lv6_C");
			}
			return NCS_Down_Lv6_C._ClassPtr;
		}

		// Token: 0x0602AE13 RID: 175635 RVA: 0x009EE65C File Offset: 0x009EC85C
		public NCS_Down_Lv6_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE14 RID: 175636 RVA: 0x009EE684 File Offset: 0x009EC884
		[NullableContext(1)]
		public NCS_Down_Lv6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AE15 RID: 175637 RVA: 0x009EE6B7 File Offset: 0x009EC8B7
		protected NCS_Down_Lv6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016390 RID: 91024
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv6.NCS_Down_Lv6_C";

		// Token: 0x04016391 RID: 91025
		private static IntPtr _ClassPtr;

		// Token: 0x04016392 RID: 91026
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
