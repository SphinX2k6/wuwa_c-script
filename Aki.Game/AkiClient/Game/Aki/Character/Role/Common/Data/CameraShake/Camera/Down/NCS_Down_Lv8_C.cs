using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Down
{
	// Token: 0x02004112 RID: 16658
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv8.NCS_Down_Lv8_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Down_Lv8_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE1A RID: 175642 RVA: 0x009EE748 File Offset: 0x009EC948
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Down_Lv8_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv8.NCS_Down_Lv8_C");
			}
			return NCS_Down_Lv8_C._ClassPtr;
		}

		// Token: 0x0602AE1B RID: 175643 RVA: 0x009EE76C File Offset: 0x009EC96C
		public NCS_Down_Lv8_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv8_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE1C RID: 175644 RVA: 0x009EE794 File Offset: 0x009EC994
		[NullableContext(1)]
		public NCS_Down_Lv8_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv8_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AE1D RID: 175645 RVA: 0x009EE7C7 File Offset: 0x009EC9C7
		protected NCS_Down_Lv8_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016396 RID: 91030
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv8.NCS_Down_Lv8_C";

		// Token: 0x04016397 RID: 91031
		private static IntPtr _ClassPtr;

		// Token: 0x04016398 RID: 91032
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
