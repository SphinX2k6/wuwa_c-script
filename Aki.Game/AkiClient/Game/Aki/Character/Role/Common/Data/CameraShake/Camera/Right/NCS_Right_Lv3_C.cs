using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Right
{
	// Token: 0x020040D6 RID: 16598
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv3.NCS_Right_Lv3_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Right_Lv3_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD2A RID: 175402 RVA: 0x009EC768 File Offset: 0x009EA968
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Right_Lv3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv3.NCS_Right_Lv3_C");
			}
			return NCS_Right_Lv3_C._ClassPtr;
		}

		// Token: 0x0602AD2B RID: 175403 RVA: 0x009EC78C File Offset: 0x009EA98C
		public NCS_Right_Lv3_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD2C RID: 175404 RVA: 0x009EC7B4 File Offset: 0x009EA9B4
		[NullableContext(1)]
		public NCS_Right_Lv3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD2D RID: 175405 RVA: 0x009EC7E7 File Offset: 0x009EA9E7
		protected NCS_Right_Lv3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162E2 RID: 90850
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv3.NCS_Right_Lv3_C";

		// Token: 0x040162E3 RID: 90851
		private static IntPtr _ClassPtr;

		// Token: 0x040162E4 RID: 90852
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
