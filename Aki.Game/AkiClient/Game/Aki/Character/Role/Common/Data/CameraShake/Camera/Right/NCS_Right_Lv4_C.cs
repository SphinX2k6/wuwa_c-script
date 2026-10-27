using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Right
{
	// Token: 0x020040D7 RID: 16599
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv4.NCS_Right_Lv4_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Right_Lv4_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD2E RID: 175406 RVA: 0x009EC7F0 File Offset: 0x009EA9F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Right_Lv4_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv4.NCS_Right_Lv4_C");
			}
			return NCS_Right_Lv4_C._ClassPtr;
		}

		// Token: 0x0602AD2F RID: 175407 RVA: 0x009EC814 File Offset: 0x009EAA14
		public NCS_Right_Lv4_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv4_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD30 RID: 175408 RVA: 0x009EC83C File Offset: 0x009EAA3C
		[NullableContext(1)]
		public NCS_Right_Lv4_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv4_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD31 RID: 175409 RVA: 0x009EC86F File Offset: 0x009EAA6F
		protected NCS_Right_Lv4_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162E5 RID: 90853
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv4.NCS_Right_Lv4_C";

		// Token: 0x040162E6 RID: 90854
		private static IntPtr _ClassPtr;

		// Token: 0x040162E7 RID: 90855
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
