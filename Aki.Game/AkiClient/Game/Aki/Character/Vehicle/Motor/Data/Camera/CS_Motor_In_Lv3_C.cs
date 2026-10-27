using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x02004058 RID: 16472
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv3.CS_Motor_In_Lv3_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_In_Lv3_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4F5 RID: 173301 RVA: 0x009DC4A4 File Offset: 0x009DA6A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_In_Lv3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv3.CS_Motor_In_Lv3_C");
			}
			return CS_Motor_In_Lv3_C._ClassPtr;
		}

		// Token: 0x0602A4F6 RID: 173302 RVA: 0x009DC4C8 File Offset: 0x009DA6C8
		public CS_Motor_In_Lv3_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_In_Lv3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4F7 RID: 173303 RVA: 0x009DC4F0 File Offset: 0x009DA6F0
		[NullableContext(1)]
		public CS_Motor_In_Lv3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_In_Lv3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4F8 RID: 173304 RVA: 0x009DC523 File Offset: 0x009DA723
		protected CS_Motor_In_Lv3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D3A RID: 89402
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv3.CS_Motor_In_Lv3_C";

		// Token: 0x04015D3B RID: 89403
		private static IntPtr _ClassPtr;

		// Token: 0x04015D3C RID: 89404
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
