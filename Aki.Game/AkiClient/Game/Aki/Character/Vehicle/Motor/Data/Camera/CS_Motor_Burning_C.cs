using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x0200404F RID: 16463
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Burning.CS_Motor_Burning_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_Burning_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4D1 RID: 173265 RVA: 0x009DBFDC File Offset: 0x009DA1DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_Burning_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Burning.CS_Motor_Burning_C");
			}
			return CS_Motor_Burning_C._ClassPtr;
		}

		// Token: 0x0602A4D2 RID: 173266 RVA: 0x009DC000 File Offset: 0x009DA200
		public CS_Motor_Burning_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Burning_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4D3 RID: 173267 RVA: 0x009DC028 File Offset: 0x009DA228
		[NullableContext(1)]
		public CS_Motor_Burning_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Burning_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4D4 RID: 173268 RVA: 0x009DC05B File Offset: 0x009DA25B
		protected CS_Motor_Burning_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D1F RID: 89375
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Burning.CS_Motor_Burning_C";

		// Token: 0x04015D20 RID: 89376
		private static IntPtr _ClassPtr;

		// Token: 0x04015D21 RID: 89377
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
