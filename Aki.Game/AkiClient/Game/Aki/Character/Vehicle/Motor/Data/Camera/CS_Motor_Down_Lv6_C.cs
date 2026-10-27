using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x02004053 RID: 16467
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv6.CS_Motor_Down_Lv6_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_Down_Lv6_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4E1 RID: 173281 RVA: 0x009DC1FC File Offset: 0x009DA3FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_Down_Lv6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv6.CS_Motor_Down_Lv6_C");
			}
			return CS_Motor_Down_Lv6_C._ClassPtr;
		}

		// Token: 0x0602A4E2 RID: 173282 RVA: 0x009DC220 File Offset: 0x009DA420
		public CS_Motor_Down_Lv6_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Down_Lv6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4E3 RID: 173283 RVA: 0x009DC248 File Offset: 0x009DA448
		[NullableContext(1)]
		public CS_Motor_Down_Lv6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Down_Lv6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4E4 RID: 173284 RVA: 0x009DC27B File Offset: 0x009DA47B
		protected CS_Motor_Down_Lv6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D2B RID: 89387
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv6.CS_Motor_Down_Lv6_C";

		// Token: 0x04015D2C RID: 89388
		private static IntPtr _ClassPtr;

		// Token: 0x04015D2D RID: 89389
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
