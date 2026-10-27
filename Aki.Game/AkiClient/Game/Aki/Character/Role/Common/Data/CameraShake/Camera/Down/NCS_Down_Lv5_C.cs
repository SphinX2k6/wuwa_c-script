using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Down
{
	// Token: 0x0200410F RID: 16655
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv5.NCS_Down_Lv5_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Down_Lv5_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE0E RID: 175630 RVA: 0x009EE5B0 File Offset: 0x009EC7B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Down_Lv5_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv5.NCS_Down_Lv5_C");
			}
			return NCS_Down_Lv5_C._ClassPtr;
		}

		// Token: 0x0602AE0F RID: 175631 RVA: 0x009EE5D4 File Offset: 0x009EC7D4
		public NCS_Down_Lv5_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv5_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE10 RID: 175632 RVA: 0x009EE5FC File Offset: 0x009EC7FC
		[NullableContext(1)]
		public NCS_Down_Lv5_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv5_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AE11 RID: 175633 RVA: 0x009EE62F File Offset: 0x009EC82F
		protected NCS_Down_Lv5_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401638D RID: 91021
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv5.NCS_Down_Lv5_C";

		// Token: 0x0401638E RID: 91022
		private static IntPtr _ClassPtr;

		// Token: 0x0401638F RID: 91023
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
