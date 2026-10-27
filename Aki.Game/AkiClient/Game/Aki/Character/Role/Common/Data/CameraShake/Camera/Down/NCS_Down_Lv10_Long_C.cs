using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Down
{
	// Token: 0x0200410A RID: 16650
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv10_Long.NCS_Down_Lv10_Long_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Down_Lv10_Long_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADFA RID: 175610 RVA: 0x009EE308 File Offset: 0x009EC508
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Down_Lv10_Long_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv10_Long.NCS_Down_Lv10_Long_C");
			}
			return NCS_Down_Lv10_Long_C._ClassPtr;
		}

		// Token: 0x0602ADFB RID: 175611 RVA: 0x009EE32C File Offset: 0x009EC52C
		public NCS_Down_Lv10_Long_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv10_Long_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADFC RID: 175612 RVA: 0x009EE354 File Offset: 0x009EC554
		[NullableContext(1)]
		public NCS_Down_Lv10_Long_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv10_Long_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADFD RID: 175613 RVA: 0x009EE387 File Offset: 0x009EC587
		protected NCS_Down_Lv10_Long_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401637E RID: 91006
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv10_Long.NCS_Down_Lv10_Long_C";

		// Token: 0x0401637F RID: 91007
		private static IntPtr _ClassPtr;

		// Token: 0x04016380 RID: 91008
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
