using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Left
{
	// Token: 0x020040FC RID: 16636
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv7.NCS_Left_Lv7_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Left_Lv7_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADC2 RID: 175554 RVA: 0x009EDB98 File Offset: 0x009EBD98
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Left_Lv7_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv7.NCS_Left_Lv7_C");
			}
			return NCS_Left_Lv7_C._ClassPtr;
		}

		// Token: 0x0602ADC3 RID: 175555 RVA: 0x009EDBBC File Offset: 0x009EBDBC
		public NCS_Left_Lv7_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv7_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADC4 RID: 175556 RVA: 0x009EDBE4 File Offset: 0x009EBDE4
		[NullableContext(1)]
		public NCS_Left_Lv7_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv7_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADC5 RID: 175557 RVA: 0x009EDC17 File Offset: 0x009EBE17
		protected NCS_Left_Lv7_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016354 RID: 90964
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv7.NCS_Left_Lv7_C";

		// Token: 0x04016355 RID: 90965
		private static IntPtr _ClassPtr;

		// Token: 0x04016356 RID: 90966
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
