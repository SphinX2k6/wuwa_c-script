using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x0200405D RID: 16477
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Jump.CS_Motor_Jump_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_Jump_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A509 RID: 173321 RVA: 0x009DC74C File Offset: 0x009DA94C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_Jump_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Jump.CS_Motor_Jump_C");
			}
			return CS_Motor_Jump_C._ClassPtr;
		}

		// Token: 0x0602A50A RID: 173322 RVA: 0x009DC770 File Offset: 0x009DA970
		public CS_Motor_Jump_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Jump_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A50B RID: 173323 RVA: 0x009DC798 File Offset: 0x009DA998
		[NullableContext(1)]
		public CS_Motor_Jump_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Jump_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A50C RID: 173324 RVA: 0x009DC7CB File Offset: 0x009DA9CB
		protected CS_Motor_Jump_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D49 RID: 89417
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Jump.CS_Motor_Jump_C";

		// Token: 0x04015D4A RID: 89418
		private static IntPtr _ClassPtr;

		// Token: 0x04015D4B RID: 89419
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
