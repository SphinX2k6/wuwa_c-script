using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x0200405E RID: 16478
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Jump_xuli.CS_Motor_Jump_xuli_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_Jump_xuli_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A50D RID: 173325 RVA: 0x009DC7D4 File Offset: 0x009DA9D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_Jump_xuli_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Jump_xuli.CS_Motor_Jump_xuli_C");
			}
			return CS_Motor_Jump_xuli_C._ClassPtr;
		}

		// Token: 0x0602A50E RID: 173326 RVA: 0x009DC7F8 File Offset: 0x009DA9F8
		public CS_Motor_Jump_xuli_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Jump_xuli_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A50F RID: 173327 RVA: 0x009DC820 File Offset: 0x009DAA20
		[NullableContext(1)]
		public CS_Motor_Jump_xuli_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Jump_xuli_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A510 RID: 173328 RVA: 0x009DC853 File Offset: 0x009DAA53
		protected CS_Motor_Jump_xuli_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D4C RID: 89420
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Jump_xuli.CS_Motor_Jump_xuli_C";

		// Token: 0x04015D4D RID: 89421
		private static IntPtr _ClassPtr;

		// Token: 0x04015D4E RID: 89422
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
