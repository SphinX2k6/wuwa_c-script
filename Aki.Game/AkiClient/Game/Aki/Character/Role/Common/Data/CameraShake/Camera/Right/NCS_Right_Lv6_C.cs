using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Right
{
	// Token: 0x020040D9 RID: 16601
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv6.NCS_Right_Lv6_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Right_Lv6_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD36 RID: 175414 RVA: 0x009EC900 File Offset: 0x009EAB00
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Right_Lv6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv6.NCS_Right_Lv6_C");
			}
			return NCS_Right_Lv6_C._ClassPtr;
		}

		// Token: 0x0602AD37 RID: 175415 RVA: 0x009EC924 File Offset: 0x009EAB24
		public NCS_Right_Lv6_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD38 RID: 175416 RVA: 0x009EC94C File Offset: 0x009EAB4C
		[NullableContext(1)]
		public NCS_Right_Lv6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD39 RID: 175417 RVA: 0x009EC97F File Offset: 0x009EAB7F
		protected NCS_Right_Lv6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162EB RID: 90859
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv6.NCS_Right_Lv6_C";

		// Token: 0x040162EC RID: 90860
		private static IntPtr _ClassPtr;

		// Token: 0x040162ED RID: 90861
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
