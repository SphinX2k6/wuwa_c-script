using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Up
{
	// Token: 0x020040D1 RID: 16593
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv8.NCS_Up_Lv8_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Up_Lv8_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD16 RID: 175382 RVA: 0x009EC4C0 File Offset: 0x009EA6C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Up_Lv8_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv8.NCS_Up_Lv8_C");
			}
			return NCS_Up_Lv8_C._ClassPtr;
		}

		// Token: 0x0602AD17 RID: 175383 RVA: 0x009EC4E4 File Offset: 0x009EA6E4
		public NCS_Up_Lv8_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv8_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD18 RID: 175384 RVA: 0x009EC50C File Offset: 0x009EA70C
		[NullableContext(1)]
		public NCS_Up_Lv8_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv8_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD19 RID: 175385 RVA: 0x009EC53F File Offset: 0x009EA73F
		protected NCS_Up_Lv8_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162D3 RID: 90835
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv8.NCS_Up_Lv8_C";

		// Token: 0x040162D4 RID: 90836
		private static IntPtr _ClassPtr;

		// Token: 0x040162D5 RID: 90837
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
