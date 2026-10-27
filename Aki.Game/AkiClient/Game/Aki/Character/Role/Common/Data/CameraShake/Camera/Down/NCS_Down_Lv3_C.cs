using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Down
{
	// Token: 0x0200410D RID: 16653
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv3.NCS_Down_Lv3_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Down_Lv3_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE06 RID: 175622 RVA: 0x009EE4A0 File Offset: 0x009EC6A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Down_Lv3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv3.NCS_Down_Lv3_C");
			}
			return NCS_Down_Lv3_C._ClassPtr;
		}

		// Token: 0x0602AE07 RID: 175623 RVA: 0x009EE4C4 File Offset: 0x009EC6C4
		public NCS_Down_Lv3_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE08 RID: 175624 RVA: 0x009EE4EC File Offset: 0x009EC6EC
		[NullableContext(1)]
		public NCS_Down_Lv3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AE09 RID: 175625 RVA: 0x009EE51F File Offset: 0x009EC71F
		protected NCS_Down_Lv3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016387 RID: 91015
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv3.NCS_Down_Lv3_C";

		// Token: 0x04016388 RID: 91016
		private static IntPtr _ClassPtr;

		// Token: 0x04016389 RID: 91017
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
