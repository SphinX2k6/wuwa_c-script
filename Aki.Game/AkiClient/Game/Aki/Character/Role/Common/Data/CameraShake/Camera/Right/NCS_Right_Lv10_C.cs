using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Right
{
	// Token: 0x020040D3 RID: 16595
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv10.NCS_Right_Lv10_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Right_Lv10_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD1E RID: 175390 RVA: 0x009EC5D0 File Offset: 0x009EA7D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Right_Lv10_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv10.NCS_Right_Lv10_C");
			}
			return NCS_Right_Lv10_C._ClassPtr;
		}

		// Token: 0x0602AD1F RID: 175391 RVA: 0x009EC5F4 File Offset: 0x009EA7F4
		public NCS_Right_Lv10_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv10_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD20 RID: 175392 RVA: 0x009EC61C File Offset: 0x009EA81C
		[NullableContext(1)]
		public NCS_Right_Lv10_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv10_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD21 RID: 175393 RVA: 0x009EC64F File Offset: 0x009EA84F
		protected NCS_Right_Lv10_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162D9 RID: 90841
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv10.NCS_Right_Lv10_C";

		// Token: 0x040162DA RID: 90842
		private static IntPtr _ClassPtr;

		// Token: 0x040162DB RID: 90843
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
