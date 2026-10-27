using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Up
{
	// Token: 0x020040CD RID: 16589
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv4.NCS_Up_Lv4_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Up_Lv4_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD06 RID: 175366 RVA: 0x009EC2A0 File Offset: 0x009EA4A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Up_Lv4_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv4.NCS_Up_Lv4_C");
			}
			return NCS_Up_Lv4_C._ClassPtr;
		}

		// Token: 0x0602AD07 RID: 175367 RVA: 0x009EC2C4 File Offset: 0x009EA4C4
		public NCS_Up_Lv4_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv4_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD08 RID: 175368 RVA: 0x009EC2EC File Offset: 0x009EA4EC
		[NullableContext(1)]
		public NCS_Up_Lv4_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv4_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD09 RID: 175369 RVA: 0x009EC31F File Offset: 0x009EA51F
		protected NCS_Up_Lv4_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162C7 RID: 90823
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv4.NCS_Up_Lv4_C";

		// Token: 0x040162C8 RID: 90824
		private static IntPtr _ClassPtr;

		// Token: 0x040162C9 RID: 90825
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
