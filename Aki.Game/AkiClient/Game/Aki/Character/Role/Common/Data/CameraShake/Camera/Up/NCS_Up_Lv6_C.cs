using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Up
{
	// Token: 0x020040CF RID: 16591
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv6.NCS_Up_Lv6_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Up_Lv6_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD0E RID: 175374 RVA: 0x009EC3B0 File Offset: 0x009EA5B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Up_Lv6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv6.NCS_Up_Lv6_C");
			}
			return NCS_Up_Lv6_C._ClassPtr;
		}

		// Token: 0x0602AD0F RID: 175375 RVA: 0x009EC3D4 File Offset: 0x009EA5D4
		public NCS_Up_Lv6_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD10 RID: 175376 RVA: 0x009EC3FC File Offset: 0x009EA5FC
		[NullableContext(1)]
		public NCS_Up_Lv6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD11 RID: 175377 RVA: 0x009EC42F File Offset: 0x009EA62F
		protected NCS_Up_Lv6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162CD RID: 90829
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv6.NCS_Up_Lv6_C";

		// Token: 0x040162CE RID: 90830
		private static IntPtr _ClassPtr;

		// Token: 0x040162CF RID: 90831
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
