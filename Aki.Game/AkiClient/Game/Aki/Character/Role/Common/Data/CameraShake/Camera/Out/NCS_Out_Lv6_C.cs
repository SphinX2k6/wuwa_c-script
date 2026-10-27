using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Out
{
	// Token: 0x020040F0 RID: 16624
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv6.NCS_Out_Lv6_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Out_Lv6_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD92 RID: 175506 RVA: 0x009ED538 File Offset: 0x009EB738
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Out_Lv6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv6.NCS_Out_Lv6_C");
			}
			return NCS_Out_Lv6_C._ClassPtr;
		}

		// Token: 0x0602AD93 RID: 175507 RVA: 0x009ED55C File Offset: 0x009EB75C
		public NCS_Out_Lv6_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD94 RID: 175508 RVA: 0x009ED584 File Offset: 0x009EB784
		[NullableContext(1)]
		public NCS_Out_Lv6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD95 RID: 175509 RVA: 0x009ED5B7 File Offset: 0x009EB7B7
		protected NCS_Out_Lv6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016330 RID: 90928
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv6.NCS_Out_Lv6_C";

		// Token: 0x04016331 RID: 90929
		private static IntPtr _ClassPtr;

		// Token: 0x04016332 RID: 90930
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
