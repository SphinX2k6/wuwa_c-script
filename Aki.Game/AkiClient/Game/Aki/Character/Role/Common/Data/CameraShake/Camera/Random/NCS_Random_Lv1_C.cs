using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Random
{
	// Token: 0x020040DF RID: 16607
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv1.NCS_Random_Lv1_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Random_Lv1_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD4E RID: 175438 RVA: 0x009ECC30 File Offset: 0x009EAE30
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Random_Lv1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv1.NCS_Random_Lv1_C");
			}
			return NCS_Random_Lv1_C._ClassPtr;
		}

		// Token: 0x0602AD4F RID: 175439 RVA: 0x009ECC54 File Offset: 0x009EAE54
		public NCS_Random_Lv1_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD50 RID: 175440 RVA: 0x009ECC7C File Offset: 0x009EAE7C
		[NullableContext(1)]
		public NCS_Random_Lv1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD51 RID: 175441 RVA: 0x009ECCAF File Offset: 0x009EAEAF
		protected NCS_Random_Lv1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162FD RID: 90877
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv1.NCS_Random_Lv1_C";

		// Token: 0x040162FE RID: 90878
		private static IntPtr _ClassPtr;

		// Token: 0x040162FF RID: 90879
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
