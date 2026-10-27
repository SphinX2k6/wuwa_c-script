using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Right
{
	// Token: 0x020040DC RID: 16604
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv9.NCS_Right_Lv9_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Right_Lv9_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD42 RID: 175426 RVA: 0x009ECA98 File Offset: 0x009EAC98
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Right_Lv9_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv9.NCS_Right_Lv9_C");
			}
			return NCS_Right_Lv9_C._ClassPtr;
		}

		// Token: 0x0602AD43 RID: 175427 RVA: 0x009ECABC File Offset: 0x009EACBC
		public NCS_Right_Lv9_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv9_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD44 RID: 175428 RVA: 0x009ECAE4 File Offset: 0x009EACE4
		[NullableContext(1)]
		public NCS_Right_Lv9_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv9_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD45 RID: 175429 RVA: 0x009ECB17 File Offset: 0x009EAD17
		protected NCS_Right_Lv9_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162F4 RID: 90868
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv9.NCS_Right_Lv9_C";

		// Token: 0x040162F5 RID: 90869
		private static IntPtr _ClassPtr;

		// Token: 0x040162F6 RID: 90870
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
