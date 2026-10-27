using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x02004054 RID: 16468
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv7.CS_Motor_Down_Lv7_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_Down_Lv7_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4E5 RID: 173285 RVA: 0x009DC284 File Offset: 0x009DA484
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_Down_Lv7_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv7.CS_Motor_Down_Lv7_C");
			}
			return CS_Motor_Down_Lv7_C._ClassPtr;
		}

		// Token: 0x0602A4E6 RID: 173286 RVA: 0x009DC2A8 File Offset: 0x009DA4A8
		public CS_Motor_Down_Lv7_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Down_Lv7_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4E7 RID: 173287 RVA: 0x009DC2D0 File Offset: 0x009DA4D0
		[NullableContext(1)]
		public CS_Motor_Down_Lv7_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Down_Lv7_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4E8 RID: 173288 RVA: 0x009DC303 File Offset: 0x009DA503
		protected CS_Motor_Down_Lv7_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D2E RID: 89390
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv7.CS_Motor_Down_Lv7_C";

		// Token: 0x04015D2F RID: 89391
		private static IntPtr _ClassPtr;

		// Token: 0x04015D30 RID: 89392
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
