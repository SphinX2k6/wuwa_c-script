using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Down
{
	// Token: 0x02004109 RID: 16649
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv10.NCS_Down_Lv10_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Down_Lv10_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADF6 RID: 175606 RVA: 0x009EE280 File Offset: 0x009EC480
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Down_Lv10_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv10.NCS_Down_Lv10_C");
			}
			return NCS_Down_Lv10_C._ClassPtr;
		}

		// Token: 0x0602ADF7 RID: 175607 RVA: 0x009EE2A4 File Offset: 0x009EC4A4
		public NCS_Down_Lv10_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv10_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADF8 RID: 175608 RVA: 0x009EE2CC File Offset: 0x009EC4CC
		[NullableContext(1)]
		public NCS_Down_Lv10_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv10_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADF9 RID: 175609 RVA: 0x009EE2FF File Offset: 0x009EC4FF
		protected NCS_Down_Lv10_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401637B RID: 91003
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv10.NCS_Down_Lv10_C";

		// Token: 0x0401637C RID: 91004
		private static IntPtr _ClassPtr;

		// Token: 0x0401637D RID: 91005
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
