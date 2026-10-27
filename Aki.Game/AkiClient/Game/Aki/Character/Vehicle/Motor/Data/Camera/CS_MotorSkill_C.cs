using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x0200404E RID: 16462
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_MotorSkill.CS_MotorSkill_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_MotorSkill_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4CD RID: 173261 RVA: 0x009DBF53 File Offset: 0x009DA153
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_MotorSkill_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_MotorSkill.CS_MotorSkill_C");
			}
			return CS_MotorSkill_C._ClassPtr;
		}

		// Token: 0x0602A4CE RID: 173262 RVA: 0x009DBF78 File Offset: 0x009DA178
		public CS_MotorSkill_C() : this(BuiltinUtils.AllocNativeUObject(CS_MotorSkill_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4CF RID: 173263 RVA: 0x009DBFA0 File Offset: 0x009DA1A0
		[NullableContext(1)]
		public CS_MotorSkill_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_MotorSkill_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4D0 RID: 173264 RVA: 0x009DBFD3 File Offset: 0x009DA1D3
		protected CS_MotorSkill_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D1C RID: 89372
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_MotorSkill.CS_MotorSkill_C";

		// Token: 0x04015D1D RID: 89373
		private static IntPtr _ClassPtr;

		// Token: 0x04015D1E RID: 89374
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
