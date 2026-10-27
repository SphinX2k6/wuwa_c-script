using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Right
{
	// Token: 0x020040DB RID: 16603
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv8.NCS_Right_Lv8_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Right_Lv8_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD3E RID: 175422 RVA: 0x009ECA10 File Offset: 0x009EAC10
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Right_Lv8_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv8.NCS_Right_Lv8_C");
			}
			return NCS_Right_Lv8_C._ClassPtr;
		}

		// Token: 0x0602AD3F RID: 175423 RVA: 0x009ECA34 File Offset: 0x009EAC34
		public NCS_Right_Lv8_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv8_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD40 RID: 175424 RVA: 0x009ECA5C File Offset: 0x009EAC5C
		[NullableContext(1)]
		public NCS_Right_Lv8_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv8_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD41 RID: 175425 RVA: 0x009ECA8F File Offset: 0x009EAC8F
		protected NCS_Right_Lv8_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162F1 RID: 90865
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv8.NCS_Right_Lv8_C";

		// Token: 0x040162F2 RID: 90866
		private static IntPtr _ClassPtr;

		// Token: 0x040162F3 RID: 90867
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
