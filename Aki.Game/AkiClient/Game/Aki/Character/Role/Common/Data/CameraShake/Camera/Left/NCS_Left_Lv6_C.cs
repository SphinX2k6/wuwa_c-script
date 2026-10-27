using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Left
{
	// Token: 0x020040FB RID: 16635
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv6.NCS_Left_Lv6_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Left_Lv6_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADBE RID: 175550 RVA: 0x009EDB10 File Offset: 0x009EBD10
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Left_Lv6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv6.NCS_Left_Lv6_C");
			}
			return NCS_Left_Lv6_C._ClassPtr;
		}

		// Token: 0x0602ADBF RID: 175551 RVA: 0x009EDB34 File Offset: 0x009EBD34
		public NCS_Left_Lv6_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADC0 RID: 175552 RVA: 0x009EDB5C File Offset: 0x009EBD5C
		[NullableContext(1)]
		public NCS_Left_Lv6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADC1 RID: 175553 RVA: 0x009EDB8F File Offset: 0x009EBD8F
		protected NCS_Left_Lv6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016351 RID: 90961
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv6.NCS_Left_Lv6_C";

		// Token: 0x04016352 RID: 90962
		private static IntPtr _ClassPtr;

		// Token: 0x04016353 RID: 90963
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
