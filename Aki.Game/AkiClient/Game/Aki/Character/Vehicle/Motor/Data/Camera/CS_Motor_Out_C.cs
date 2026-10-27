using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x0200405F RID: 16479
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Out.CS_Motor_Out_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_Out_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A511 RID: 173329 RVA: 0x009DC85C File Offset: 0x009DAA5C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_Out_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Out.CS_Motor_Out_C");
			}
			return CS_Motor_Out_C._ClassPtr;
		}

		// Token: 0x0602A512 RID: 173330 RVA: 0x009DC880 File Offset: 0x009DAA80
		public CS_Motor_Out_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Out_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A513 RID: 173331 RVA: 0x009DC8A8 File Offset: 0x009DAAA8
		[NullableContext(1)]
		public CS_Motor_Out_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Out_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A514 RID: 173332 RVA: 0x009DC8DB File Offset: 0x009DAADB
		protected CS_Motor_Out_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D4F RID: 89423
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Out.CS_Motor_Out_C";

		// Token: 0x04015D50 RID: 89424
		private static IntPtr _ClassPtr;

		// Token: 0x04015D51 RID: 89425
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
